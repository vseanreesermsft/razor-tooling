﻿// <auto-generated/>
#pragma warning disable 1591
namespace Test
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line (1,2)-(2,1) "x:\dir\subdir\Test\TestComponent.cshtml"
using Microsoft.AspNetCore.Components.RenderTree;

#line default
#line hidden
#nullable disable
    public partial class TestComponent : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "x:\dir\subdir\Test\TestComponent.cshtml"
  
    var output = string.Empty;
    if (__builder == null) output = "Builder is null!";
    else output = "Builder is not null!";

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "p");
            __builder.AddContent(1, "Output: ");
#nullable restore
#line (7,17)-(7,23) 24 "x:\dir\subdir\Test\TestComponent.cshtml"
__builder.AddContent(2, output);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
