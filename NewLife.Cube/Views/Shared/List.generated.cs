﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using NewLife;
    using NewLife.Cube;
    
    #line 3 "..\..\Views\Shared\List.cshtml"
    using NewLife.Cube.Charts;
    
    #line default
    #line hidden
    using NewLife.Reflection;
    
    #line 1 "..\..\Views\Shared\List.cshtml"
    using NewLife.Web;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Shared\List.cshtml"
    using XCode;
    
    #line default
    #line hidden
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/List.cshtml")]
    public partial class _Views_Shared_List_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared_List_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 4 "..\..\Views\Shared\List.cshtml"
  
    Layout = NewLife.Cube.Setting.Current.Layout;

    var fact = ViewBag.Factory as IEntityOperate;
    var page = ViewBag.Page as Pager;

    var charts = ViewBag.Charts as ECharts[];

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" class=\"clearfix\"");

WriteLiteral(">\r\n");

WriteLiteral("    ");

            
            #line 14 "..\..\Views\Shared\List.cshtml"
Write(Html.Partial("_List_Toolbar"));

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n");

            
            #line 16 "..\..\Views\Shared\List.cshtml"
 if (charts != null && charts.Length > 0)
{

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"clearfix\"");

WriteLiteral(">\r\n");

            
            #line 19 "..\..\Views\Shared\List.cshtml"
        
            
            #line default
            #line hidden
            
            #line 19 "..\..\Views\Shared\List.cshtml"
         foreach (var item in charts)
        {
            
            
            #line default
            #line hidden
            
            #line 21 "..\..\Views\Shared\List.cshtml"
       Write(Html.Partial("_ECharts", item));

            
            #line default
            #line hidden
            
            #line 21 "..\..\Views\Shared\List.cshtml"
                                           
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n");

            
            #line 24 "..\..\Views\Shared\List.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("<div");

WriteLiteral(" class=\"table-responsive\"");

WriteLiteral(">\r\n");

WriteLiteral("    ");

            
            #line 26 "..\..\Views\Shared\List.cshtml"
Write(Html.Partial("_List_Data"));

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n<div");

WriteLiteral(" class=\"panel-footer\"");

WriteLiteral(">\r\n");

WriteLiteral("    ");

            
            #line 29 "..\..\Views\Shared\List.cshtml"
Write(Html.Partial("_List_Pager"));

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>");

        }
    }
}
#pragma warning restore 1591
