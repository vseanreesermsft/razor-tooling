﻿// <auto-generated/>
#pragma warning disable 1591
namespace Test
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
#nullable restore
#line (1,2)-(2,1) "x:\dir\subdir\Test\TestComponent.cshtml"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
    public partial class TestComponent<
#nullable restore
#line 2 "x:\dir\subdir\Test\TestComponent.cshtml"
TItem1

#line default
#line hidden
#nullable disable
    ,
#nullable restore
#line 3 "x:\dir\subdir\Test\TestComponent.cshtml"
TItem2

#line default
#line hidden
#nullable disable
    > : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Item1</h1>");
#nullable restore
#line 6 "x:\dir\subdir\Test\TestComponent.cshtml"
 foreach (var item2 in Items2)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "p");
#nullable restore
#line (9,6)-(9,25) 24 "x:\dir\subdir\Test\TestComponent.cshtml"
__builder.AddContent(2, ChildContent(item2));

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(3, ";\r\n    ");
            __builder.CloseElement();
#nullable restore
#line 11 "x:\dir\subdir\Test\TestComponent.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "x:\dir\subdir\Test\TestComponent.cshtml"
       
    [Parameter] public TItem1 Item1 { get; set; }
    [Parameter] public List<TItem2> Items2 { get; set; }
    [Parameter] public RenderFragment<TItem2> ChildContent { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
