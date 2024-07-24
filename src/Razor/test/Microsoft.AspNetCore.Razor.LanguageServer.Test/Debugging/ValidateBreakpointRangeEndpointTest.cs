﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT license. See License.txt in the project root for license information.

using System;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.Language;
using Microsoft.AspNetCore.Razor.LanguageServer.EndpointContracts;
using Microsoft.CodeAnalysis.Razor.ProjectSystem;
using Microsoft.CodeAnalysis.Razor.Workspaces;
using Microsoft.CodeAnalysis.Testing;
using Microsoft.CodeAnalysis.Text;
using Microsoft.CommonLanguageServerProtocol.Framework;
using Microsoft.VisualStudio.LanguageServer.Protocol;
using Moq;
using Xunit;
using Xunit.Abstractions;
using Range = Microsoft.VisualStudio.LanguageServer.Protocol.Range;

namespace Microsoft.AspNetCore.Razor.LanguageServer.Debugging;

public class ValidateBreakpointRangeEndpointTest(ITestOutputHelper testOutput) : SingleServerDelegatingEndpointTestBase(testOutput)
{
    [Fact]
    public async Task Handle_CSharpInHtml_ValidBreakpoint()
    {
        var input = """
                <div></div>

                @{
                    var currentCount = 1;
                }

                <p>@{|breakpoint:{|expected:currentCount|}|}</p>
                """;

        await VerifyBreakpointRangeAsync(input);
    }

    [Fact]
    public async Task Handle_CSharpInAttribute_ValidBreakpoint()
    {
        var input = """
                <div></div>

                @{
                    var currentCount = 1;
                }

                <button class="btn btn-primary" disabled="@({|breakpoint:{|expected:currentCount > 3|}|})">Click me</button>
                """;

        await VerifyBreakpointRangeAsync(input);
    }

    [Fact]
    public async Task Handle_CSharp_ValidBreakpoint()
    {
        var input = """
                <div></div>

                @{
                    {|breakpoint:{|expected:var x = GetX();|}|}
                }
                """;

        await VerifyBreakpointRangeAsync(input);
    }

    [Fact]
    public async Task Handle_CSharp_InvalidBreakpointRemoved()
    {
        var input = """
                <div></div>

                @{
                    //{|breakpoint:var x = GetX();|}
                }
                """;

        await VerifyBreakpointRangeAsync(input);
    }

    [Fact]
    public async Task Handle_CSharp_ValidBreakpointMoved()
    {
        var input = """
                <div></div>

                @{
                    {|breakpoint:var x = Goo;
                    {|expected:Goo;|}|}
                }
                """;

        await VerifyBreakpointRangeAsync(input);
    }

    [Fact]
    public async Task Handle_Html_BreakpointRemoved()
    {
        var input = """
                {|breakpoint:<div></div>|}

                @{
                    var x = GetX();
                }
                """;

        await VerifyBreakpointRangeAsync(input);
    }

    private async Task VerifyBreakpointRangeAsync(string input)
    {
        // Arrange
        TestFileMarkupParser.GetSpans(input, out var output, out ImmutableDictionary<string, ImmutableArray<TextSpan>> spans);

        Assert.True(spans.TryGetValue("breakpoint", out var breakpointSpans), "Test authoring failure: Expected at least one span named 'breakpoint'.");
        Assert.True(breakpointSpans.Length == 1, "Test authoring failure: Expected only one 'breakpoint' span.");

        var codeDocument = CreateCodeDocument(output);
        var razorFilePath = "C:/path/to/file.razor";

        // Act
        var result = await GetBreakpointRangeAsync(codeDocument, razorFilePath, breakpointSpans[0]);

        // Assert
        if (result is null)
        {
            Assert.False(spans.ContainsKey("expected"), "No breakpoint was returned from LSP, but there is a span named 'expected'.");
            return;
        }

        Assert.True(spans.TryGetValue("expected", out var expectedSpans), "Expected at least one span named 'expected'.");
        Assert.True(expectedSpans.Length == 1, "Expected only one 'expected' span.");

        var expectedRange = codeDocument.GetSourceText().GetRange(expectedSpans[0]);
        Assert.Equal(expectedRange, result);
    }

    private async Task<Range?> GetBreakpointRangeAsync(RazorCodeDocument codeDocument, string razorFilePath, TextSpan breakpointSpan)
    {
        var languageServer = await CreateLanguageServerAsync(codeDocument, razorFilePath);

        var endpoint = new ValidateBreakpointRangeEndpoint(DocumentMappingService, LanguageServerFeatureOptions, languageServer, LoggerFactory);

        var request = new ValidateBreakpointRangeParams
        {
            TextDocument = new TextDocumentIdentifier
            {
                Uri = new Uri(razorFilePath)
            },
            Range = codeDocument.GetSourceText().GetRange(breakpointSpan)
        };

        Assert.True(DocumentContextFactory.TryCreateForOpenDocument(request.TextDocument, out var documentContext));
        var requestContext = CreateValidateBreakpointRangeRequestContext(documentContext);

        return await endpoint.HandleRequestAsync(request, requestContext, DisposalToken);
    }

    private RazorRequestContext CreateValidateBreakpointRangeRequestContext(VersionedDocumentContext documentContext)
    {
        var lspServices = new Mock<ILspServices>(MockBehavior.Strict);

        var requestContext = CreateRazorRequestContext(documentContext, lspServices: lspServices.Object);

        return requestContext;
    }
}
