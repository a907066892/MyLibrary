#pragma checksum "D:\MyLibrary\MyNetCore\MyNetCore\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9529e8274ff8c868ce7f16b1c0663d223c0f1445"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9529e8274ff8c868ce7f16b1c0663d223c0f1445", @"/Views/Shared/_Layout.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\MyLibrary\MyNetCore\MyNetCore\Views\Shared\_Layout.cshtml"
  
    ViewData["Title"] = "_Layout";
    Layout = "~/Views/Shared/BaseView.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div id=\"app\">\r\n    <el-container>\r\n        <!--顶部-->\r\n        <el-header>\r\n            ");
#nullable restore
#line 10 "D:\MyLibrary\MyNetCore\MyNetCore\Views\Shared\_Layout.cshtml"
       Write(Html.Partial("/Home/Header"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </el-header>\r\n        <el-container>\r\n            <!--侧边-->\r\n            <el-aside style=\"width:200px\">\r\n                ");
#nullable restore
#line 15 "D:\MyLibrary\MyNetCore\MyNetCore\Views\Shared\_Layout.cshtml"
           Write(Html.Partial("/Home/Menu"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </el-aside>\r\n\r\n            <!--主要-->\r\n            <el-main>\r\n                ");
#nullable restore
#line 20 "D:\MyLibrary\MyNetCore\MyNetCore\Views\Shared\_Layout.cshtml"
           Write(RenderBody());

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n            </el-main>\r\n        </el-container>\r\n        <!--底部-->\r\n        <el-footer>\r\n\r\n        </el-footer>\r\n    </el-container>\r\n</div>\r\n<script>\r\n    var vue = new Vue({\r\n        el: \"#app\"\r\n    })\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
