#pragma checksum "C:\Users\johnn\source\repos\PersonalWebsiteV2\PersonalWebsiteV2\Views\Home\Experience.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04958a99e9626a7b0f4bc1278f4e0dfb0be72d91"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Experience), @"mvc.1.0.view", @"/Views/Home/Experience.cshtml")]
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
#nullable restore
#line 1 "C:\Users\johnn\source\repos\PersonalWebsiteV2\PersonalWebsiteV2\Views\_ViewImports.cshtml"
using PersonalWebsiteV2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\johnn\source\repos\PersonalWebsiteV2\PersonalWebsiteV2\Views\_ViewImports.cshtml"
using PersonalWebsiteV2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04958a99e9626a7b0f4bc1278f4e0dfb0be72d91", @"/Views/Home/Experience.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad6683ef4ece1ea7279d634ce037b51b9b3a167a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Experience : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "MainComponent/_Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("button button--tertiary button--secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Academics", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\johnn\source\repos\PersonalWebsiteV2\PersonalWebsiteV2\Views\Home\Experience.cshtml"
  
    ViewData["Title"] = "Experience";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"cards-container flex\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "04958a99e9626a7b0f4bc1278f4e0dfb0be72d915127", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <div id=""content-card"" class=""card card--shadowed"">
        <div class=""card__header card__header--p-h-2 card__header--p-b-2"">
            <h1 class=""card__heading""><strong>Experience</strong></h1>
            <p>Below presents a timeline of my experiences and current status.</p>
            <br />
            <div class=""button-group"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "04958a99e9626a7b0f4bc1278f4e0dfb0be72d916617", async() => {
                WriteLiteral("<i class=\"icon icon--inline fas fa-caret-left\"></i>Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "04958a99e9626a7b0f4bc1278f4e0dfb0be72d918128", async() => {
                WriteLiteral("Academics");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                <a href=""#"" class=""button button--disabled  button--tertiary button--bg-disabled""><i class=""icon icon--inline fas fa-download""></i>Resume</a>
            </div>
        </div>
        <div class=""card__content card__content--p-h-2"">
            <div class=""timeline"">
                <div class=""timeline__item"">
                    <h1 class=""timeline__timestamp"">SEP 2020 - PRESENT</h1>
                    <h2 class=""timeline__title""><span class=""timeline__title--bold"">Aston Peer Mentor</span> Aston University Careers+Placements</h2>
                    <div class=""timeline__content"">
                        <p>Mentor as part of the E-Mentoring programme, providing support and information for first, second and placement-year Computer Science undergraduates.</p>
                    </div>
                </div>
                <div class=""timeline__item"">
                    <h1 class=""timeline__timestamp"">SEP 2019 - SEP 2020</h1>
                    <h2 class=""timeline__title""><");
            WriteLiteral(@"span class=""timeline__title--bold"">Placement Web Developer</span> Pinewood Technologies PLC</h2>
                    <div class=""timeline__content"">
                        <p>Technologies: C#, ASP.NET Framework & Core (MVC/API), JS, JQuery, KnockoutJS, SQL (Server), TFS, Docker, Azure Services & DevOps</p>
                        <p>Industrial Placement year in Web development, gaining technical experience in developing/maintaining web APIs, microservices and UX design, working with ASP.NET.</p>
                        <p>Worked on sites for <a href=""https://www.carstore.com/"" target=""_blank"" class=""link"">CarStore.com</a>, <a href=""https://www.stratstone.com/"" target=""_blank"" class=""link"">Stratstone.com</a>, <a href=""https://www.evanshalshaw.com/"" target=""_blank"" class=""link"">EvansHalshaw.com</a> and Pinewood CMS.</p>
                        <ul>
                            <li>Projects: Enrolment portal, DevOps Dashboard</li>
                        </ul>
                    </div>
                ");
            WriteLiteral(@"</div>
                <div class=""timeline__item"">
                    <h1 class=""timeline__timestamp"">OCT 2019 - MAY 2020</h1>
                    <h2 class=""timeline__title""><span class=""timeline__title--bold"">Aston University Careers+Placements</span> Aston Peer Mentor</h2>
                    <div class=""timeline__content"">
                        <p>Mentor as part of the E-Mentoring programme, providing support and information for first and second-year Computer Science undergraduates.</p>
                    </div>
                </div>
                <div class=""timeline__item"">
                    <h1 class=""timeline__timestamp"">JUN 2019 – SEP 2019</h1>
                    <h2 class=""timeline__title""><span class=""timeline__title--bold"">Web Developer,</span> Beautiful Canoe</h2>
                    <div class=""timeline__content"">
                        <p>Technologies: Laravel, Git (Lab), JS, Bootstrap, Vagrant, R, SQL</p>
                        <p>Summer contractual position developin");
            WriteLiteral(@"g and maintaining websites for two clients, gaining technical experience, improving team and communicational skills.</p>
                        <p>Projects:</p>
                        <ul>
                            <li>FLDB - Text Crimes, Aston Contractor and Tradesperson Sign-In System</li>
                        </ul>
                    </div>
                </div>
                <div class=""timeline__item"">
                    <h1 class=""timeline__timestamp"">OCT 2019 - MAY 2020</h1>
                    <h2 class=""timeline__title""><span class=""timeline__title--bold"">Aston Peer Mentor</span>Aston University Careers+Placements</h2>
                    <div class=""timeline__content"">
                        <p>Mentor as part of the E-Mentoring programme, providing support and information for first Computer Science undergraduates.</p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>");
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
