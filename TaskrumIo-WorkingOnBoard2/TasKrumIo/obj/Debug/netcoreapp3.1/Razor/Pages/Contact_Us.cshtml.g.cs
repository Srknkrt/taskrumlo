#pragma checksum "C:\Users\sekov\Downloads\TaskrumIo-WorkingOnBoard2\TasKrumIo\Pages\Contact_Us.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15153cb9d0609ec20143b296cae5478f0453a3e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TasKrumIo.Pages.Pages_Contact_Us), @"mvc.1.0.razor-page", @"/Pages/Contact_Us.cshtml")]
namespace TasKrumIo.Pages
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
#line 1 "C:\Users\sekov\Downloads\TaskrumIo-WorkingOnBoard2\TasKrumIo\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sekov\Downloads\TaskrumIo-WorkingOnBoard2\TasKrumIo\Pages\_ViewImports.cshtml"
using TasKrumIo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sekov\Downloads\TaskrumIo-WorkingOnBoard2\TasKrumIo\Pages\_ViewImports.cshtml"
using TasKrumIo.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15153cb9d0609ec20143b296cae5478f0453a3e6", @"/Pages/Contact_Us.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8359d55353544e3568cf9b1e6df9f7df907865a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Contact_Us : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color:#7C60B7; border:none ; padding:20px; font-size:20px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<link rel=\"stylesheet\" href=\"https://unpkg.com/leaflet@1.7.1/dist/leaflet.css\"\n      integrity=\"sha512-xodZBNTC5n17Xt2atTPuE1HxjVMSvLVW9ocqUKLsCC5CXdbqCmblAshOMAS6/keqq/sMZMZ19scR4PsZChSR7A==\"");
            BeginWriteAttribute("crossorigin", "\n      crossorigin=\"", 242, "\"", 262, 0);
            EndWriteAttribute();
            WriteLiteral(" />\n\n<script src=\"https://unpkg.com/leaflet@1.7.1/dist/leaflet.js\"\n        integrity=\"sha512-XQoYMqMTK8LvdxXYG3nZ448hOEQiglfqkJs1NOQV44cWnUrBc8PkAOcXy20w0vlaXaVUearIOBhiXZ5V3ynxwA==\"");
            BeginWriteAttribute("crossorigin", "\n        crossorigin=\"", 445, "\"", 467, 0);
            EndWriteAttribute();
            WriteLiteral(@"></script>

<div class=""text-center"" style=""padding-bottom:20px;"">
    <section class=""hero"">
        <div class=""hero-inner"">
            <h1>Conact Us</h1>

        </div>
    </section>
</div>
<h3 class=""main-text p-1"" style=""text-align:center""> Contact Us </h3>
<hr />


<div class=""container"">
    <div class=""row p-5"">
        <div class=""col-6"">
            <h4 class=""second-text text-center"">Get In Touch!</h4>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15153cb9d0609ec20143b296cae5478f0453a3e66742", async() => {
                WriteLiteral(@"
                <div class=""card border-secondary rounded-0"">
                    <div class=""card-header p-0"">
                        <div class="" text-white text-center py-2"" style=""background-color:#7C60B7"">
                            <h3><i class=""fa fa-envelope""></i> Contact US</h3>
                            <p class=""m-0"">Lorem Ipsum </p>
                        </div>
                    </div>
                    <div class=""card-body p-3"">
                        <div class=""form-group"">
                            <div class=""input-group mb-2"">
                                <div class=""input-group-prepend"">
                                    <div class=""input-group-text""><i class=""fa fa-user"" style=""color:#7C60B7""></i></div>
                                </div>
                                <input type=""text"" class=""form-control"" id=""nombre"" name=""nombre"" placeholder=""Your Name"" required>
                            </div>
                        </div>
                        <div class");
                WriteLiteral(@"=""form-group"">
                            <div class=""input-group mb-2"">
                                <div class=""input-group-prepend"">
                                    <div class=""input-group-text""><i class=""fa fa-envelope "" style=""color:#7C60B7""></i></div>
                                </div>
                                <input type=""email"" class=""form-control"" id=""nombre"" name=""email"" placeholder=""email@gmail.com"" required>
                            </div>
                        </div>

                        <div class=""form-group"">
                            <div class=""input-group mb-2"">
                                <div class=""input-group-prepend"">
                                    <div class=""input-group-text""><i class=""fa fa-comment "" style=""color:#7C60B7""></i></div>
                                </div>
                                <textarea class=""form-control"" placeholder=""Your Message"" required></textarea>
                            </div>
                        </div>");
                WriteLiteral(@"

                        <div class=""text-center"">
                            <input type=""submit"" value=""Send"" class=""btn text-white btn-block rounded-0 py-2"" style=""background-color:#7C60B7"">
                        </div>
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
        <div class=""col-6"">
            <h4 class=""second-text text-center"">Our Address</h4>
            <div id=""mapid"" style=""height: 342px;"">
                <script>
                    var mymap = L.map('mapid').setView([38.491774, 27.706417], 13);
                    L.tileLayer('https://api.mapbox.com/styles/v1/{id}/tiles/{z}/{x}/{y}?access_token=pk.eyJ1IjoiYWJkdWxsYWhvYiIsImEiOiJja2pqdnpleTY1bjlzMnlsZ3Q4cms2c3F4In0.ZpEx65D0Js2seKqJ6wPurA', {
                        attribution: 'Map data &copy; <a href=""https://www.openstreetmap.org/copyright"">OpenStreetMap</a> contributors, Imagery © <a href=""https://www.mapbox.com/"">Mapbox</a>',
                        maxZoom: 18,
                        id: 'mapbox/streets-v11',
                        tileSize: 512,
                        zoomOffset: -1,
                        accessToken: 'your.mapbox.access.token'
                    }).addTo(mymap);
                    var marker = L.marker([38.491774, 27.706417]).addTo(mymap);
              ");
            WriteLiteral(@"      marker.bindPopup(""<b>Here's Our Location</b><br>Opens 9AM-10AM -Except SAT & SUN."").openPopup();
                    
                </script>
                


            </div>

        </div>

    </div>



</div>

<h3 class=""main-text text-center"">Are You Intrested In Our Services ?</h3>
<hr />

<div class=""row p-5 justify-content-center"">
    <div>
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15153cb9d0609ec20143b296cae5478f0453a3e612191", async() => {
                WriteLiteral("Register Now...");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TasKrumIo.Pages.Contact_UsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TasKrumIo.Pages.Contact_UsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TasKrumIo.Pages.Contact_UsModel>)PageContext?.ViewData;
        public TasKrumIo.Pages.Contact_UsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591