#pragma checksum "C:\Users\nayr'b\Desktop\CodingDojo\CSharp_stack\quoting_dojo\Views\Home\quotes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1904981057bd94d5220121838b81833e2e81a7f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_quotes), @"mvc.1.0.view", @"/Views/Home/quotes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/quotes.cshtml", typeof(AspNetCore.Views_Home_quotes))]
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
#line 1 "C:\Users\nayr'b\Desktop\CodingDojo\CSharp_stack\quoting_dojo\Views\_ViewImports.cshtml"
using quoting_dojo;

#line default
#line hidden
#line 1 "C:\Users\nayr'b\Desktop\CodingDojo\CSharp_stack\quoting_dojo\Views\Home\quotes.cshtml"
using quoting_dojo.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1904981057bd94d5220121838b81833e2e81a7f2", @"/Views/Home/quotes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8befaa81ee46489c12f9a4c1c5bac316dfc787f5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_quotes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Quote>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 14, true);
            WriteLiteral("\r\n<html>\r\n    ");
            EndContext();
            BeginContext(56, 483, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b80b1bbef8934d5ca22982fa1a57a29f", async() => {
                BeginContext(62, 470, true);
                WriteLiteral(@"
<link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css"" integrity=""sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO"" crossorigin=""anonymous"">
<style>
    h1 {
        text-align: center;
        margin: 20px;
    }
    h6 {
        margin-left: 40px;
    }
    h5 {
        margin-top: 10px;
    }
    .container {
        width: 900px;
        height: 500px;
    }

</style>
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(539, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(541, 406, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "967ed0764270425fa7bbd13dc2325c00", async() => {
                BeginContext(547, 76, true);
                WriteLiteral("\r\n    <h1>Here are the awesome quotes!</h1>\r\n\r\n    <div class=\"container\">\r\n");
                EndContext();
#line 29 "C:\Users\nayr'b\Desktop\CodingDojo\CSharp_stack\quoting_dojo\Views\Home\quotes.cshtml"
         for(int i = @ViewBag.Allquotes.Count-1; i > 0; i--)
            {

#line default
#line hidden
                BeginContext(700, 21, true);
                WriteLiteral("                <h5>\"");
                EndContext();
                BeginContext(722, 29, false);
#line 31 "C:\Users\nayr'b\Desktop\CodingDojo\CSharp_stack\quoting_dojo\Views\Home\quotes.cshtml"
                Write(ViewBag.AllQuotes[i]["quote"]);

#line default
#line hidden
                EndContext();
                BeginContext(751, 28, true);
                WriteLiteral("\"</h5>\r\n                <h6>");
                EndContext();
                BeginContext(780, 28, false);
#line 32 "C:\Users\nayr'b\Desktop\CodingDojo\CSharp_stack\quoting_dojo\Views\Home\quotes.cshtml"
               Write(ViewBag.AllQuotes[i]["user"]);

#line default
#line hidden
                EndContext();
                BeginContext(808, 3, true);
                WriteLiteral(" - ");
                EndContext();
                BeginContext(812, 34, false);
#line 32 "C:\Users\nayr'b\Desktop\CodingDojo\CSharp_stack\quoting_dojo\Views\Home\quotes.cshtml"
                                               Write(ViewBag.AllQuotes[i]["created_at"]);

#line default
#line hidden
                EndContext();
                BeginContext(846, 29, true);
                WriteLiteral("</h6>\r\n                <hr>\r\n");
                EndContext();
#line 34 "C:\Users\nayr'b\Desktop\CodingDojo\CSharp_stack\quoting_dojo\Views\Home\quotes.cshtml"
            }

#line default
#line hidden
                BeginContext(890, 50, true);
                WriteLiteral("    </div>\r\n    <h4><a href=\"/\">Go Back</a></h4>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(947, 9, true);
            WriteLiteral("\r\n</html>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Quote> Html { get; private set; }
    }
}
#pragma warning restore 1591
