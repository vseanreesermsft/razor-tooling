﻿#pragma checksum "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/Sections.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1ed96a957fe000fd0c80cc511def19ab692563eb64f3349a4c87c524e2ecbd60"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.TestFiles_IntegrationTests_CodeGenerationIntegrationTest_Sections), @"mvc.1.0.view", @"/TestFiles/IntegrationTests/CodeGenerationIntegrationTest/Sections.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/TestFiles/IntegrationTests/CodeGenerationIntegrationTest/Sections.cshtml", typeof(AspNetCore.TestFiles_IntegrationTests_CodeGenerationIntegrationTest_Sections))]
namespace AspNetCore
{
    #line default
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    #line default
    #line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"1ed96a957fe000fd0c80cc511def19ab692563eb64f3349a4c87c524e2ecbd60", @"/TestFiles/IntegrationTests/CodeGenerationIntegrationTest/Sections.cshtml")]
    public class TestFiles_IntegrationTests_CodeGenerationIntegrationTest_Sections : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<
#line (1,8)-(1,16) "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/Sections.cshtml"
DateTime

#line default
#line hidden
    >
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::InputTestTagHelper __InputTestTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(17, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(64, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line (5,3)-(7,1) "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/Sections.cshtml"
 
    Layout = "_SectionTestLayout.cshtml";

#line default
#line hidden

            BeginContext(117, 26, true);
            WriteLiteral("\r\n<div>Some body</div>\r\n\r\n");
            EndContext();
            DefineSection("Section1", async() => {
                BeginContext(162, 43, true);
                WriteLiteral("\r\n    <div>This is in Section 1</div>\r\n    ");
                EndContext();
                BeginContext(205, 25, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input-test", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "__UniqueIdSuppressedForTesting__", async() => {
                }
                );
                __InputTestTagHelper = CreateTagHelper<global::InputTestTagHelper>();
                __tagHelperExecutionContext.Add(__InputTestTagHelper);
                __InputTestTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.
#line (13,22)-(13,26) "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/Sections.cshtml"
Date

#line default
#line hidden
                );
                __tagHelperExecutionContext.AddTagHelperAttribute("for", __InputTestTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(230, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DateTime> Html { get; private set; }
    }
}
#pragma warning restore 1591
