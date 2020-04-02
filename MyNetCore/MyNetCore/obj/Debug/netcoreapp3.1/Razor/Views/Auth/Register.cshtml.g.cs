#pragma checksum "D:\MyLibrary\MyNetCore\MyNetCore\Views\Auth\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "caf2b038c815b076330bd8a37d4ffb3dabc7c55d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Auth_Register), @"mvc.1.0.view", @"/Views/Auth/Register.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"caf2b038c815b076330bd8a37d4ffb3dabc7c55d", @"/Views/Auth/Register.cshtml")]
    public class Views_Auth_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\MyLibrary\MyNetCore\MyNetCore\Views\Auth\Register.cshtml"
  
    ViewData["Title"] = "Register";
    Layout = "~/Views/Shared/BaseView.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<title>注册</title>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "caf2b038c815b076330bd8a37d4ffb3dabc7c55d2823", async() => {
                WriteLiteral(@"
    <div id=""app"">
        <el-card class=""box-card"" style=""width:40%;margin:auto"">
            <div slot=""header"" style=""text-align:center"">
                <h2> 注册</h2>
            </div>
            <el-form :model=""form"" :rules=""rules"" status-icon ref=""form"" label-width=""80px"">
                <el-form-item prop=""UserName"" label=""用户名"">
                    <el-input v-model=""form.UserName""></el-input>
                </el-form-item>
                <el-form-item prop=""PassWordHash"" label=""密码"">
                    <el-input v-model=""form.PassWordHash""></el-input>
                </el-form-item>
                <el-form-item prop=""RePassWordHash"" label=""重复密码"">
                    <el-input v-model=""form.RePassWordHash""></el-input>
                </el-form-item>
                <el-form-item>
                    <el-button ");
                WriteLiteral("@click=\"onRegister\" style=\"width:100%\" type=\"primary\"> 注册</el-button>\r\n                </el-form-item>\r\n                <el-form-item>\r\n                    <el-link ");
                WriteLiteral("@click=\"onBack\" type=\"primary\">已有账户？返回</el-link>\r\n                </el-form-item>\r\n            </el-form>\r\n\r\n        </el-card>\r\n\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>

    var vue = new Vue({
        el: ""#app"",
        data: function () {
            var checkName = (value, valid, callback) => {
                if (!valid) {
                        return callback(""用户为空"");
                }
                callback();
            }
            var ceckPassWord = (value, valid, callback) => {
                if (!valid) {
                        return callback(""密码为空"");
                }
                callback();
            }

            var ceckRePassWord = (value, valid, callback) => {
                if (!valid) {
                  return callback(""重复密码为空"");
                } 
              if (valid != this.$refs.form.model.PassWordHash)
                  return callback(""两次输入密码不一致"");
                callback();
            }

            return {
                form: {
                    UserName: """",
                    PassWordHash: """",
                    RePassWordHash: """"
                },
                rules: ");
            WriteLiteral(@"{
                    UserName: [{ validator: checkName, triger: 'blur' }],
                    PassWordHash: [{ validator: ceckPassWord, triger: 'blur' }],
                    RePassWordHash: [{ validator: ceckRePassWord, triger: 'blur' }]
                }
            }
        },
        methods: {
            onRegister: function () {
                this.$refs['form'].validate((valid) => {
                    if (valid) { 
                        axios.post(""Register"", JSON.stringify(this.form), { headers: { ""Content-Type"": ""application/json"" } }).then((message) => {
                            base.ShowSuccess(""注册成功!"");
                            window.history.go(-1);
                        }).catch((error) => {
                            base.ShowError(error.response.data)
                        });

                    }
                })
            },
            onBack: function () {
                window.history.go(-1);
            }

        }


    })
</script");
            WriteLiteral(">\r\n");
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
