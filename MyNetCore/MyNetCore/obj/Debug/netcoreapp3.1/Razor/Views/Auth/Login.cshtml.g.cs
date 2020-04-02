#pragma checksum "D:\MyLibrary\MyNetCore\MyNetCore\Views\Auth\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0c1265680f68905daf3169df83345a55ff53949"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Auth_Login), @"mvc.1.0.view", @"/Views/Auth/Login.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0c1265680f68905daf3169df83345a55ff53949", @"/Views/Auth/Login.cshtml")]
    public class Views_Auth_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NetCoreData.Model.User>
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
#nullable restore
#line 1 "D:\MyLibrary\MyNetCore\MyNetCore\Views\Auth\Login.cshtml"
  
    ViewData["Title"] = "User Login";
    Layout = "~/Views/Shared/BaseView.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<hr />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0c1265680f68905daf3169df83345a55ff539492772", async() => {
                WriteLiteral(@"
    <div id=""app""  >
        <el-card class=""box-card"" style="" width:40%;margin:auto"">

            <div slot=""header"" style=""text-align:center"">
                <h2> 登录 </h2>
            </div>
            <el-form :model=""form"" status-icon :rules=""rules"" ref=""form"" label-width=""80px""  >
                <el-form-item prop=""UserName"" label=""用户名"">
                    <el-input v-model=""form.UserName"" name=""UserName""></el-input>
                </el-form-item>
                <el-form-item prop=""PasswordHash"" label=""密码"">
                    <el-input v-model=""form.PasswordHash"" name=""PassWordHash""></el-input>
                </el-form-item>
                <el-form-item>
                    <el-button ");
                WriteLiteral("@click=\"onSubmit\" style=\"width:100%\"  type=\"primary\">登录</el-button> \r\n                </el-form-item>\r\n                <el-form-item>\r\n                    <el-button ");
                WriteLiteral("@click=\"onRegister\" style=\"width:100%\">注册</el-button>\r\n                </el-form-item>\r\n                <el-form-item>\r\n                    <el-button ");
                WriteLiteral("@click=\"onReset\" style=\"width:100%\">重置</el-button>\r\n                </el-form-item>\r\n            </el-form>\r\n\r\n        </el-card>\r\n    </div>\r\n");
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
    new Vue({
        el: ""#app"",
        data: function () {

            var   chechName=(rule, value, callback) => {
                 if (!value) {
                    return callback(new Error('用户名不能为空'));
                }
                callback();
            }
            var chechPassWord = (rule, value, callback) => {
                if (!value) {
                    return callback(new Error('密码不能为空'));
                }
                callback();
            }


            return {
                form: {
                    UserName: '',
                    PasswordHash: ''
                },
                rules: {
                    UserName: [{ validator: chechName, triger: 'blur' }],
                    PasswordHash: [{ validator: chechPassWord, triger: 'blur' }]
                }
            }
        },
        methods: { 
            onSubmit: function () {
                this.$refs['form'].validate((valid) => {
                    if (vali");
            WriteLiteral(@"d) {
                        axios.post(
                            ""Login"",
                            JSON.stringify(this.form), { headers: { ""Content-Type"": ""application/json"" } })
                            .then((message) => {
                                base.ShowSuccess( message);
                            })
                            .catch((error) => {
                                base.ShowError(error.response.data);
                            });
                    } else {
                        console.log('error submit!!');
                        return false;
                    }

                });
            },
            onRegister: function () {
                window.location.href = 'Register';      
            },
            onReset() {
                this.$refs['form'].resetFields();
            }
        }
    });

</script>
 
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NetCoreData.Model.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
