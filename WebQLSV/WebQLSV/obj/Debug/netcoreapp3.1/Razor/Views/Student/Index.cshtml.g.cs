#pragma checksum "C:\Users\PC\Desktop\DA_DTDM_Nhom09-master\DA_DTDM_Nhom09-master\WebQLSV\WebQLSV\Views\Student\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2fc464e3a0508c953495f5a5061d922578db0213"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Index), @"mvc.1.0.view", @"/Views/Student/Index.cshtml")]
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
#line 1 "C:\Users\PC\Desktop\DA_DTDM_Nhom09-master\DA_DTDM_Nhom09-master\WebQLSV\WebQLSV\Views\_ViewImports.cshtml"
using WebQLSV;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\PC\Desktop\DA_DTDM_Nhom09-master\DA_DTDM_Nhom09-master\WebQLSV\WebQLSV\Views\Student\Index.cshtml"
using WebQLSV.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fc464e3a0508c953495f5a5061d922578db0213", @"/Views/Student/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd499af85f232d9563261c49f4a12a2c1aa2ec14", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<StudentVm>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "C:\Users\PC\Desktop\DA_DTDM_Nhom09-master\DA_DTDM_Nhom09-master\WebQLSV\WebQLSV\Views\Student\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""card mb-4"">
    <div class=""card-header"">
        <a class=""btn btn-success"" href =""/Student/Insert"">Thêm sinh viên</a>
    </div>
    <div class=""card-header"">
        <i class=""fas fa-table mr-1""></i>
        Bảng thông tin sinh viên
    </div>
    <div class=""card-body"">
        <div class=""table-responsive"">
            <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                <thead>
                    <tr>
                        <th>Mã số sinh viên</th>
                        <th>Tên đầy đủ</th>
                        <th>Nam/nữ</th>
                        <th>Ngày sinh</th>
                        <th>Địa chỉ</th>
                        <th>Số điện thoại</th>
                        <th>Tình Trạng</th>
                        <th>Tùy chỉnh</th>
                    </tr>
                </thead>
                
                <tbody>
");
#nullable restore
#line 33 "C:\Users\PC\Desktop\DA_DTDM_Nhom09-master\DA_DTDM_Nhom09-master\WebQLSV\WebQLSV\Views\Student\Index.cshtml"
                     foreach (var i in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <td>");
#nullable restore
#line 36 "C:\Users\PC\Desktop\DA_DTDM_Nhom09-master\DA_DTDM_Nhom09-master\WebQLSV\WebQLSV\Views\Student\Index.cshtml"
                           Write(i.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 37 "C:\Users\PC\Desktop\DA_DTDM_Nhom09-master\DA_DTDM_Nhom09-master\WebQLSV\WebQLSV\Views\Student\Index.cshtml"
                           Write(i.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 38 "C:\Users\PC\Desktop\DA_DTDM_Nhom09-master\DA_DTDM_Nhom09-master\WebQLSV\WebQLSV\Views\Student\Index.cshtml"
                           Write(i.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 39 "C:\Users\PC\Desktop\DA_DTDM_Nhom09-master\DA_DTDM_Nhom09-master\WebQLSV\WebQLSV\Views\Student\Index.cshtml"
                           Write(i.Birthdate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 40 "C:\Users\PC\Desktop\DA_DTDM_Nhom09-master\DA_DTDM_Nhom09-master\WebQLSV\WebQLSV\Views\Student\Index.cshtml"
                           Write(i.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 41 "C:\Users\PC\Desktop\DA_DTDM_Nhom09-master\DA_DTDM_Nhom09-master\WebQLSV\WebQLSV\Views\Student\Index.cshtml"
                           Write(i.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 42 "C:\Users\PC\Desktop\DA_DTDM_Nhom09-master\DA_DTDM_Nhom09-master\WebQLSV\WebQLSV\Views\Student\Index.cshtml"
                            Write(i.IsDelete ? "Disable" : "Active");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>\n                                <a class=\"btn btn-info\"");
            BeginWriteAttribute("href", " href=\"", 1552, "\"", 1578, 2);
            WriteAttributeValue("", 1559, "/Student/Edit/", 1559, 14, true);
#nullable restore
#line 44 "C:\Users\PC\Desktop\DA_DTDM_Nhom09-master\DA_DTDM_Nhom09-master\WebQLSV\WebQLSV\Views\Student\Index.cshtml"
WriteAttributeValue("", 1573, i.Id, 1573, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Chỉnh sửa</a>\n                            </td>\n                        </tr>\n");
#nullable restore
#line 47 "C:\Users\PC\Desktop\DA_DTDM_Nhom09-master\DA_DTDM_Nhom09-master\WebQLSV\WebQLSV\Views\Student\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\n            </table>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<StudentVm>> Html { get; private set; }
    }
}
#pragma warning restore 1591
