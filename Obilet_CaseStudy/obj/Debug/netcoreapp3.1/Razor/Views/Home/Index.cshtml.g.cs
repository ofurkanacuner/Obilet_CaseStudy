#pragma checksum "C:\Users\4A Labs\Desktop\Obilet_CaseStudy-main\Obilet_CaseStudy\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bcdb05af2d8fed7fdbd13954245c3c655ed37c73"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\4A Labs\Desktop\Obilet_CaseStudy-main\Obilet_CaseStudy\Views\Home\Index.cshtml"
using Obilet_CaseStudy.Models.Request;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\4A Labs\Desktop\Obilet_CaseStudy-main\Obilet_CaseStudy\Views\Home\Index.cshtml"
using Obilet_CaseStudy.Models.Response;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bcdb05af2d8fed7fdbd13954245c3c655ed37c73", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BusJourneysRequest>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 5 "C:\Users\4A Labs\Desktop\Obilet_CaseStudy-main\Obilet_CaseStudy\Views\Home\Index.cshtml"
  
    Layout = "_Layout";
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<form action=""Home/JourneyPost"" method=""post"">
    <div class=""row"">
        <div class=""col-sm-4"">
            <div class=""card"">
                <div class=""card-header"">
                    Obilet.com
                </div>
                <div class=""card-body"">

                    <label>Nereden : </label>
                    <select class=""form-control"" id=""OriginId"" name=""OriginId"">
");
#nullable restore
#line 21 "C:\Users\4A Labs\Desktop\Obilet_CaseStudy-main\Obilet_CaseStudy\Views\Home\Index.cshtml"
                         foreach (var item in (List<GetBusLocationsResponse>)TempData["GetBusLocationsResponse"])
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 740, "\"", 756, 1);
#nullable restore
#line 23 "C:\Users\4A Labs\Desktop\Obilet_CaseStudy-main\Obilet_CaseStudy\Views\Home\Index.cshtml"
WriteAttributeValue("", 748, item.Id, 748, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 23 "C:\Users\4A Labs\Desktop\Obilet_CaseStudy-main\Obilet_CaseStudy\Views\Home\Index.cshtml"
                                                Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\n");
#nullable restore
#line 24 "C:\Users\4A Labs\Desktop\Obilet_CaseStudy-main\Obilet_CaseStudy\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </select>

                    <hr />

                    <input type=""button"" class=""btn btn-primary"" value=""Değiştir"" id=""swap"">

                    <hr />

                    <label>Nereye : </label>
                    <select class=""form-control"" id=""DestinationId"" name=""DestinationId"">
");
#nullable restore
#line 35 "C:\Users\4A Labs\Desktop\Obilet_CaseStudy-main\Obilet_CaseStudy\Views\Home\Index.cshtml"
                         foreach (var item in (List<GetBusLocationsResponse>)TempData["GetBusLocationsResponse"])
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 1296, "\"", 1312, 1);
#nullable restore
#line 37 "C:\Users\4A Labs\Desktop\Obilet_CaseStudy-main\Obilet_CaseStudy\Views\Home\Index.cshtml"
WriteAttributeValue("", 1304, item.Id, 1304, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 37 "C:\Users\4A Labs\Desktop\Obilet_CaseStudy-main\Obilet_CaseStudy\Views\Home\Index.cshtml"
                                                Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\n");
#nullable restore
#line 38 "C:\Users\4A Labs\Desktop\Obilet_CaseStudy-main\Obilet_CaseStudy\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </select>

                    <hr />

                    <label>Tarih : </label>
                    <input class=""form-control"" type=""text"" id=""DepartureDate"" name=""DepartureDate"">
                    <br />
                    <button type=""button"" id=""btnToday"" class=""btn btn-info"" onclick=""todayFunction()"">Bugün</button>
                    <button type=""button"" id=""btnTomorrow"" class=""btn btn-info"" onclick=""tomorrowFunction()"">Yarın</button>

                    <hr />

                    <button type=""submit"" class=""btn btn-primary"">Bilet Bul</button>

                    <br />

");
#nullable restore
#line 55 "C:\Users\4A Labs\Desktop\Obilet_CaseStudy-main\Obilet_CaseStudy\Views\Home\Index.cshtml"
                     if (TempData["Message"] != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"alert alert-danger\" role=\"alert\">\n                            ");
#nullable restore
#line 58 "C:\Users\4A Labs\Desktop\Obilet_CaseStudy-main\Obilet_CaseStudy\Views\Home\Index.cshtml"
                       Write(TempData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </div>\n");
#nullable restore
#line 60 "C:\Users\4A Labs\Desktop\Obilet_CaseStudy-main\Obilet_CaseStudy\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\n            </div>\n        </div>\n    </div>\n</form>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BusJourneysRequest> Html { get; private set; }
    }
}
#pragma warning restore 1591
