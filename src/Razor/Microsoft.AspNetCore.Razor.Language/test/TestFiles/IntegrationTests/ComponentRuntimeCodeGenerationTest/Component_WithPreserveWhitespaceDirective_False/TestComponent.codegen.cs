// <auto-generated/>
#pragma warning disable 1591
namespace Test
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
    public partial class TestComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "ul");
#nullable restore
#line 4 "x:\dir\subdir\Test\TestComponent.cshtml"
     foreach (var item in Enumerable.Range(1, 100))
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "li");
            __builder.AddContent(2, 
#nullable restore
#line 7 "x:\dir\subdir\Test\TestComponent.cshtml"
             item

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 9 "x:\dir\subdir\Test\TestComponent.cshtml"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591