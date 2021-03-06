#pragma checksum "C:\Users\samke\OneDrive\Desktop\BET\aspnetcore-ecomerce\aspnetcore-ecomerce\src\AspnetRun.Web\Pages\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d4f2c8d53b19fe1b8ccae515cc75aaa4d09c716"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspnetRun.Web.Pages.Pages_Contact), @"mvc.1.0.razor-page", @"/Pages/Contact.cshtml")]
namespace AspnetRun.Web.Pages
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
#line 1 "C:\Users\samke\OneDrive\Desktop\BET\aspnetcore-ecomerce\aspnetcore-ecomerce\src\AspnetRun.Web\Pages\_ViewImports.cshtml"
using AspnetRun.Web;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d4f2c8d53b19fe1b8ccae515cc75aaa4d09c716", @"/Pages/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9290694c589961dbbbb11ce5a68a4d406e340569", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Contact : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("contact-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("contact-form mb-50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<!-- Contact Section Start -->
<div class=""contact-section section mt-90 mb-40"">
    <div class=""container"">
        <div class=""row"">

            <!-- Contact Page Title -->
            <div class=""contact-page-title col mb-40"">
                <h1>Hi, Howdy <br>Let???s Connect us</h1>
            </div>
        </div>
        <div class=""row"">

            <!-- Contact Tab List -->
            <div class=""col-lg-4 col-12 mb-50"">
                <ul class=""contact-tab-list nav"">
                    <li><a class=""active"" data-toggle=""tab"" href=""#contact-address"">Contact us</a></li>
                    <li><a data-toggle=""tab"" href=""#contact-form-tab"">Leave us a message</a></li>
                    <li><a data-toggle=""tab"" href=""#store-location"">All Store location</a></li>
                </ul>
            </div>

            <!-- Contact Tab Content -->
            <div class=""col-lg-8 col-12"">
                <div class=""tab-content"">

                    <!-- Contact Address Tab -->
                    <div");
            WriteLiteral(@" class=""tab-pane fade show active row d-flex"" id=""contact-address"">

                        <div class=""col-lg-4 col-md-6 col-12 mb-50"">
                            <div class=""contact-information"">
                                <h4>Address</h4>
                                <p>62 Beacon RD Florida North 1709 </p>
                            </div>
                        </div>

                        <div class=""col-lg-4 col-md-6 col-12 mb-50"">
                            <div class=""contact-information"">
                                <h4>Phone</h4>
                                <p><a href=""tel:01234567890"">01234 567 890</a><a href=""tel:01234567891"">01234 567 891</a></p>
                            </div>
                        </div>

                        <div class=""col-lg-4 col-md-6 col-12 mb-50"">
                            <div class=""contact-information"">
                                <h4>Web</h4>
                                <p><a href=""mailto:info@samkelo.com"">info@samkelo.com</a>");
            WriteLiteral(@"<a href=""#"">www.samkelo.com</a></p>
                            </div>
                        </div>

                    </div>

                    <!-- Contact Form Tab -->
                    <div class=""tab-pane fade row d-flex"" id=""contact-form-tab"">
                        <div class=""col"">

                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d4f2c8d53b19fe1b8ccae515cc75aaa4d09c7166951", async() => {
                WriteLiteral(@"
                                <div class=""row"">
                                    <div class=""col-md-6 col-12 mb-25"">
                                        <label for=""first_name"">First Name*</label>
                                        <input id=""first_name"" type=""text"" name=""first_name"">
                                    </div>
                                    <div class=""col-md-6 col-12 mb-25"">
                                        <label for=""last_name"">Last Name*</label>
                                        <input id=""last_name"" type=""text"" name=""last_name"">
                                    </div>
                                    <div class=""col-md-6 col-12 mb-25"">
                                        <label for=""email_address"">Email*</label>
                                        <input id=""email_address"" type=""email"" name=""email_address"">
                                    </div>
                                    <div class=""col-md-6 col-12 mb-25"">
                     ");
                WriteLiteral(@"                   <label for=""phone_number"">Phone</label>
                                        <input id=""phone_number"" type=""text"" name=""phone_number"">
                                    </div>
                                    <div class=""col-12 mb-25"">
                                        <label for=""message"">Message*</label>
                                        <textarea id=""message"" name=""message""></textarea>
                                    </div>
                                    <div class=""col-12"">
                                        <input type=""submit"" value=""SEND NOW"">
                                    </div>
                                </div>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            <p class=""form-messege""></p>

                        </div>
                    </div>

                    <!-- Contact Stores Tab -->
                    <div class=""tab-pane fade row d-flex"" id=""store-location"">

                        <div class=""col-md-6 col-12 mb-50"">
                            <div class=""single-store"">
                                <h3>E&E South Africa</h3>
                                <p>62 Beacon RD Florida North 1709.</p>
                                <p><a href=""tel:01234567890"">01234 567 890</a> / <a href=""tel:01234567891"">01234 567 891</a></p>
                                <p><a href=""mailto:info@samkelo.com"">info@samkelo.com</a> / <a href=""#"">www.samkelo.com</a></p>
                            </div>
                        </div>

                        <div class=""col-md-6 col-12 mb-50"">
                            <div class=""single-store"">
                                <h3>E&E Zambia</h3>
                                <p>62 Beac");
            WriteLiteral(@"on RD Florida North 1709.</p>
                                <p><a href=""tel:01234567890"">01234 567 890</a> / <a href=""tel:01234567891"">01234 567 891</a></p>
                                <p><a href=""mailto:info@samkelo.com"">info@samkelo.com</a> / <a href=""#"">www.samkelo.com</a></p>
                            </div>
                        </div>

                        <div class=""col-md-6 col-12 mb-50"">
                            <div class=""single-store"">
                                <h3>E&E China</h3>
                                <p>62 Beacon RD Florida North 1709.</p>
                                <p><a href=""tel:01234567890"">01234 567 890</a> / <a href=""tel:01234567891"">01234 567 891</a></p>
                                <p><a href=""mailto:info@samkelo.com"">info@samkelo.com</a> / <a href=""#"">www.samkelo.com</a></p>
                            </div>
                        </div>

                        <div class=""col-md-6 col-12 mb-50"">
                            <div class=""single-s");
            WriteLiteral(@"tore"">
                                <h3>E&E England</h3>
                                <p>62 Beacon RD Florida North 1709.</p>
                                <p><a href=""tel:01234567890"">01234 567 890</a> / <a href=""tel:01234567891"">01234 567 891</a></p>
                                <p><a href=""mailto:info@samkelo.com"">info@samkelo.com</a> / <a href=""#"">www.samkelo.com</a></p>
                            </div>
                        </div>

                        <div class=""col-md-6 col-12 mb-50"">
                            <div class=""single-store"">
                                <h3>E&E Canada</h3>
                                <p>62 Beacon RD Florida North 1709.</p>
                                <p><a href=""tel:01234567890"">01234 567 890</a> / <a href=""tel:01234567891"">01234 567 891</a></p>
                                <p><a href=""mailto:info@samkelo.com"">info@samkelo.com</a> / <a href=""#"">www.samkelo.com</a></p>
                            </div>
                        </div>

     ");
            WriteLiteral(@"                   <div class=""col-md-6 col-12 mb-50"">
                            <div class=""single-store"">
                                <h3>E&E Denmark</h3>
                                <p>62 Beacon RD Florida North 1709.</p>
                                <p><a href=""tel:01234567890"">01234 567 890</a> / <a href=""tel:01234567891"">01234 567 891</a></p>
                                <p><a href=""mailto:info@samkelo.com"">info@samkelo.com</a> / <a href=""#"">www.samkelo.com</a></p>
                            </div>
                        </div>

                    </div>
                </div>
            </div>
        </div>
    </div>
</div><!-- Contact Section End -->
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AspnetRun.Web.Pages.ContactModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AspnetRun.Web.Pages.ContactModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AspnetRun.Web.Pages.ContactModel>)PageContext?.ViewData;
        public AspnetRun.Web.Pages.ContactModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
