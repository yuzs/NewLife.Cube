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
    
    #line 1 "..\..\Views\Shared\_Ace_Layout.cshtml"
    using NewLife.Common;
    
    #line default
    #line hidden
    using NewLife.Cube;
    
    #line 2 "..\..\Views\Shared\_Ace_Layout.cshtml"
    using NewLife.Cube.Charts;
    
    #line default
    #line hidden
    using NewLife.Reflection;
    using NewLife.Web;
    using XCode;
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_Ace_Layout.cshtml")]
    public partial class _Views_Shared__Ace_Layout_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared__Ace_Layout_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Shared\_Ace_Layout.cshtml"
  
    var set = NewLife.Cube.Setting.Current;
    var set2 = ViewBag.PageSetting as PageSetting;

    var charts = ViewBag.Charts as ECharts[];

            
            #line default
            #line hidden
WriteLiteral("\r\n<!DOCTYPE html>\r\n<html");

WriteLiteral(" lang=\"zh-CN\"");

WriteLiteral(">\r\n<head>\r\n    <meta");

WriteLiteral(" charset=\"utf-8\"");

WriteLiteral(">\r\n    <meta");

WriteLiteral(" http-equiv=\"X-UA-Compatible\"");

WriteLiteral(" content=\"IE=edge\"");

WriteLiteral(">\r\n    <meta");

WriteLiteral(" name=\"viewport\"");

WriteLiteral(" content=\"width=device-width, initial-scale=1\"");

WriteLiteral(">\r\n    <meta");

WriteLiteral(" name=\"description\"");

WriteLiteral(" content=\"新生命团队,NewLife,魔方,Cube,XCode\"");

WriteLiteral(" />\r\n    ");

WriteLiteral("\r\n    <title>");

            
            #line 17 "..\..\Views\Shared\_Ace_Layout.cshtml"
      Write(ViewBag.Title);

            
            #line default
            #line hidden
WriteLiteral(" - ");

            
            #line 17 "..\..\Views\Shared\_Ace_Layout.cshtml"
                       Write(SysConfig.Current.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</title>\r\n    <link");

WriteAttribute("href", Tuple.Create(" href=\"", 607), Tuple.Create("\"", 627)
, Tuple.Create(Tuple.Create("", 614), Tuple.Create<System.Object, System.Int32>(Href("~/favicon.ico")
, 614), false)
);

WriteLiteral(" rel=\"shortcut icon\"");

WriteLiteral(" type=\"image/x-icon\"");

WriteLiteral(">\r\n\r\n    <!-- 页面内联样式 -->\r\n");

WriteLiteral("    ");

            
            #line 21 "..\..\Views\Shared\_Ace_Layout.cshtml"
Write(RenderSection("css", required: false));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 23 "..\..\Views\Shared\_Ace_Layout.cshtml"
    
            
            #line default
            #line hidden
            
            #line 23 "..\..\Views\Shared\_Ace_Layout.cshtml"
     if (set != null && set.BootstrapSelect)
    {

            
            #line default
            #line hidden
WriteLiteral("        <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 823), Tuple.Create("\"", 879)
, Tuple.Create(Tuple.Create("", 830), Tuple.Create<System.Object, System.Int32>(Href("~/Content/bootstrap/css/bootstrap-multiselect.css")
, 830), false)
);

WriteLiteral(">\r\n");

            
            #line 26 "..\..\Views\Shared\_Ace_Layout.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 918), Tuple.Create("\"", 982)
, Tuple.Create(Tuple.Create("", 925), Tuple.Create<System.Object, System.Int32>(Href("~/Content/DateTimePicker/bootstrap-datetimepicker.min.css")
, 925), false)
);

WriteLiteral(">\r\n\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1014), Tuple.Create("\"", 1072)
, Tuple.Create(Tuple.Create("", 1021), Tuple.Create<System.Object, System.Int32>(Href("~/Content/bootstrap-switch/bootstrap-switch.min.css")
, 1021), false)
);

WriteLiteral(">\r\n\r\n    <!-- 最后引入基本样式 -->\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1127), Tuple.Create("\"", 1175)
, Tuple.Create(Tuple.Create("", 1134), Tuple.Create<System.Object, System.Int32>(Href("~/Content/bootstrap/css/bootstrap.min.css")
, 1134), false)
);

WriteLiteral(">\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1205), Tuple.Create("\"", 1256)
, Tuple.Create(Tuple.Create("", 1212), Tuple.Create<System.Object, System.Int32>(Href("~/Content/bootstrap/css/font-awesome.min.css")
, 1212), false)
);

WriteLiteral(">\r\n\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1288), Tuple.Create("\"", 1342)
, Tuple.Create(Tuple.Create("", 1295), Tuple.Create<System.Object, System.Int32>(Href("~/Content/bootstrap/css/bootstrap-theme.min.css")
, 1295), false)
);

WriteLiteral(">\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1372), Tuple.Create("\"", 1431)
, Tuple.Create(Tuple.Create("", 1379), Tuple.Create<System.Object, System.Int32>(Href("~/Content/bootstrap/css/bootstrap-responsive.min.css")
, 1379), false)
);

WriteLiteral(">\r\n\r\n    <!-- 文本字体 -->\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1482), Tuple.Create("\"", 1524)
, Tuple.Create(Tuple.Create("", 1489), Tuple.Create<System.Object, System.Int32>(Href("~/Content/ace/css/ace-fonts.min.css")
, 1489), false)
);

WriteLiteral(">\r\n    <!-- ace 样式 -->\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1575), Tuple.Create("\"", 1611)
, Tuple.Create(Tuple.Create("", 1582), Tuple.Create<System.Object, System.Int32>(Href("~/Content/ace/css/ace.min.css")
, 1582), false)
);

WriteLiteral(" class=\"ace-main-stylesheet\"");

WriteLiteral(" id=\"main-ace-style\"");

WriteLiteral(">\r\n    ");

WriteLiteral("\r\n    <link");

WriteAttribute("href", Tuple.Create(" href=\"", 1697), Tuple.Create("\"", 1741)
, Tuple.Create(Tuple.Create("", 1704), Tuple.Create<System.Object, System.Int32>(Href("~/Content/artDialog/css/ui-dialog.css")
, 1704), false)
);

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n\r\n    <!-- 自定义样式 -->\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1812), Tuple.Create("\"", 1853)
, Tuple.Create(Tuple.Create("", 1819), Tuple.Create<System.Object, System.Int32>(Href("~/Content/Cube.css?v=3.2.2020.0204")
, 1819), false)
);

WriteLiteral(">\r\n    <!-- JQuery作为一等公民，页面内部随时可能使用 -->\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 1906), Tuple.Create("\"", 1944)
, Tuple.Create(Tuple.Create("", 1912), Tuple.Create<System.Object, System.Int32>(Href("~/Content/js/jquery-2.1.3.min.js")
, 1912), false)
);

WriteLiteral("></script>\r\n");

            
            #line 50 "..\..\Views\Shared\_Ace_Layout.cshtml"
    
            
            #line default
            #line hidden
            
            #line 50 "..\..\Views\Shared\_Ace_Layout.cshtml"
     if (charts != null && charts.Length > 0)
    {

            
            #line default
            #line hidden
WriteLiteral("        <script");

WriteAttribute("src", Tuple.Create(" src=\"", 2026), Tuple.Create("\"", 2056)
, Tuple.Create(Tuple.Create("", 2032), Tuple.Create<System.Object, System.Int32>(Href("~/Content/echarts.min.js")
, 2032), false)
);

WriteLiteral("></script>\r\n");

            
            #line 53 "..\..\Views\Shared\_Ace_Layout.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</head>\r\n<body>\r\n    <div");

WriteLiteral(" class=\"panel panel-default\"");

WriteLiteral(">\r\n");

            
            #line 57 "..\..\Views\Shared\_Ace_Layout.cshtml"
        
            
            #line default
            #line hidden
            
            #line 57 "..\..\Views\Shared\_Ace_Layout.cshtml"
         if (set2 != null && set2.EnableNavbar)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"breadcrumbs\"");

WriteLiteral(" id=\"breadcrumbs\"");

WriteLiteral(">\r\n                <ul");

WriteLiteral(" class=\"breadcrumb\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 61 "..\..\Views\Shared\_Ace_Layout.cshtml"
               Write(Html.Partial("_Ace_Layout_Nav"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </ul>\r\n                <div");

WriteLiteral(" style=\"float: right; margin-left: 40px;\"");

WriteLiteral(">");

            
            #line 63 "..\..\Views\Shared\_Ace_Layout.cshtml"
                                                         Write(ViewBag.HeaderContent);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n            </div>\r\n");

            
            #line 65 "..\..\Views\Shared\_Ace_Layout.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"page-content\"");

WriteLiteral(">\r\n            <section");

WriteLiteral(" class=\"content-wrapper main-content clear-fix\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 68 "..\..\Views\Shared\_Ace_Layout.cshtml"
           Write(RenderBody());

            
            #line default
            #line hidden
WriteLiteral("\r\n            </section>\r\n        </div>\r\n");

            
            #line 71 "..\..\Views\Shared\_Ace_Layout.cshtml"
        
            
            #line default
            #line hidden
            
            #line 71 "..\..\Views\Shared\_Ace_Layout.cshtml"
         if (DbRunTimeModule.Enable)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"panel-footer\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 74 "..\..\Views\Shared\_Ace_Layout.cshtml"
           Write(Html.Raw(DbRunTimeModule.GetInfo()));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n");

            
            #line 76 "..\..\Views\Shared\_Ace_Layout.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n    <!-- 最早引入基本脚本 -->\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 2886), Tuple.Create("\"", 2931)
, Tuple.Create(Tuple.Create("", 2892), Tuple.Create<System.Object, System.Int32>(Href("~/Content/bootstrap/js/bootstrap.min.js")
, 2892), false)
);

WriteLiteral("></script>\r\n");

            
            #line 80 "..\..\Views\Shared\_Ace_Layout.cshtml"
    
            
            #line default
            #line hidden
            
            #line 80 "..\..\Views\Shared\_Ace_Layout.cshtml"
     if (set != null && set.BootstrapSelect)
    {

            
            #line default
            #line hidden
WriteLiteral("        <script");

WriteAttribute("src", Tuple.Create(" src=\"", 3012), Tuple.Create("\"", 3069)
, Tuple.Create(Tuple.Create("", 3018), Tuple.Create<System.Object, System.Int32>(Href("~/Content/bootstrap/js/bootstrap-multiselect.min.js")
, 3018), false)
);

WriteLiteral("></script>\r\n");

            
            #line 83 "..\..\Views\Shared\_Ace_Layout.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 85 "..\..\Views\Shared\_Ace_Layout.cshtml"
Write(RenderSection("scripts", required: false));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n    <!--日历控件支持-->\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 3171), Tuple.Create("\"", 3233)
, Tuple.Create(Tuple.Create("", 3177), Tuple.Create<System.Object, System.Int32>(Href("~/Content/DateTimePicker/bootstrap-datetimepicker.min.js")
, 3177), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 3257), Tuple.Create("\"", 3329)
, Tuple.Create(Tuple.Create("", 3263), Tuple.Create<System.Object, System.Int32>(Href("~/Content/DateTimePicker/locales/bootstrap-datetimepicker.zh-CN.js")
, 3263), false)
);

WriteLiteral("></script>\r\n    <script>\r\n        $(function () {\r\n            $(\'.form_datetime\'" +
").each(function () {\r\n                var df = $(this).attr(\'dateformat\');\r\n    " +
"            if (!df) {\r\n                    $(this).attr(\'dateformat\', \'yyyy-mm-" +
"dd hh:ii:ss\');\r\n                    $(this).width(140);\r\n                }\r\n    " +
"            else {\r\n                    // 把C#标准格式化替换为控件格式\r\n                    " +
"df = df.replace(\'mm\', \'ii\').replace(\'MM\', \'mm\').replace(\'HH\', \'hh\');\r\n          " +
"          $(this).attr(\'dateformat\', df);\r\n\r\n                    // 根据时间日期格式，锁定日" +
"期输入框宽度\r\n                    if (df.indexOf(\'hh\') >= 0)\r\n                        " +
"$(this).width(140);\r\n                    else\r\n                        $(this).w" +
"idth(80);\r\n                }\r\n\r\n                //根据日期格式自动推算日期选择view显示的范围\r\n     " +
"           var sv = 2;\r\n                var mv = 2;\r\n                var autoVie" +
"w = $(this).attr(\'autoView\');\r\n                if (autoView != \'false\') {\r\n     " +
"               df = $(this).attr(\'dateformat\');\r\n                    if (df.inde" +
"xOf(\'ii\') >= 0) {\r\n                        mv = 0;\r\n                        if (" +
"df.indexOf(\'dd\') >= 0) {\r\n                            sv = 2;\r\n                 " +
"       } else {\r\n                            sv = 1;\r\n                        }\r" +
"\n                    } else if (df.indexOf(\'hh\') >= 0) {\r\n                      " +
"  mv = 1;\r\n                        if (df.indexOf(\'dd\') >= 0) {\r\n               " +
"             sv = 2;\r\n                        } else {\r\n                        " +
"    sv = 1;\r\n                        }\r\n                    } else if (df.indexO" +
"f(\'dd\') >= 0) {\r\n                        mv = 2;\r\n                        sv = 2" +
";\r\n                    } else if (df.indexOf(\'mm\') >= 0) {\r\n                    " +
"    mv = 3;\r\n                        sv = 3;\r\n                    } else if (df." +
"indexOf(\'yyyy\') >= 0) {\r\n                        mv = 4;\r\n                      " +
"  sv = 4;\r\n                    }\r\n                }\r\n\r\n                $(this).a" +
"ttr(\'startview\', sv);\r\n                $(this).attr(\'minview\', mv);\r\n           " +
" });\r\n            $(\"[dateformat]\").each(function () {\r\n                $(this)." +
"datetimepicker({\r\n                    format: $(this).attr(\"dateformat\"),\r\n     " +
"               autoclose: true,\r\n                    language: \"zh-CN\",\r\n       " +
"             forceParse: false,\r\n                    startView: parseInt($(this)" +
".attr(\'startview\')),\r\n                    minView: parseInt($(this).attr(\'minvie" +
"w\'))\r\n                });\r\n            });\r\n");

            
            #line 155 "..\..\Views\Shared\_Ace_Layout.cshtml"
            
            
            #line default
            #line hidden
            
            #line 155 "..\..\Views\Shared\_Ace_Layout.cshtml"
             if (set != null && set.BootstrapSelect) {
            
            #line default
            #line hidden
WriteLiteral(@"
            $('.multiselect').each(function () {
                $(this).multiselect({
                    // 下拉列表仅在列表项比较多时显示过滤框
                    enableFiltering: $(this).children().length > 10,
                    buttonClass: 'btn btn-white btn-primary',
                    templates: {
                        button: '<button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"multiselect dropdown-toggle\"");

WriteLiteral(" data-toggle=\"dropdown\"");

WriteLiteral("></button>\',\r\n                        ul: \'<ul");

WriteLiteral(" class=\"multiselect-container dropdown-menu\"");

WriteLiteral("></ul>\',\r\n                        filter: \'<li");

WriteLiteral(" class=\"multiselect-item filter\"");

WriteLiteral("><div");

WriteLiteral(" class=\"input-group\"");

WriteLiteral("><span");

WriteLiteral(" class=\"input-group-addon\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-search\"");

WriteLiteral("></i></span><input");

WriteLiteral(" class=\"form-control multiselect-search\"");

WriteLiteral(" type=\"text\"");

WriteLiteral("></div></li>\',\r\n                        filterClearBtn: \'<span");

WriteLiteral(" class=\"input-group-btn\"");

WriteLiteral("><button");

WriteLiteral(" class=\"btn btn-default btn-white btn-grey multiselect-clear-filter\"");

WriteLiteral(" type=\"button\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-times-circle red2\"");

WriteLiteral("></i></button></span>\',\r\n                        li: \'<li><a");

WriteLiteral(" href=\"javascript:void(0);\"");

WriteLiteral("><label></label></a></li>\',\r\n                        divider: \'<li");

WriteLiteral(" class=\"multiselect-item divider\"");

WriteLiteral("></li>\',\r\n                        liGroup: \'<li");

WriteLiteral(" class=\"multiselect-item group\"");

WriteLiteral("><label");

WriteLiteral(" class=\"multiselect-group\"");

WriteLiteral("></label></li>\'\r\n                    },\r\n                    filterPlaceholder: \'" +
"搜索\',\r\n                    nonSelectedText: \'无\',\r\n                    allSelected" +
"Text: \'全选\'\r\n                });\r\n            });\r\n            ");

            
            #line 175 "..\..\Views\Shared\_Ace_Layout.cshtml"
                   }
            
            
            #line default
            #line hidden
            
            #line 178 "..\..\Views\Shared\_Ace_Layout.cshtml"
                                                                                        

            
            #line default
            #line hidden
WriteLiteral(@"            $('tr').dblclick(function () {
                var $this = $(this);
                var row = $this.closest(""tr"");
                var findcell = row.find('.editcell');
                if (findcell.length > 0) window.location.href = findcell.attr(""href"");
            });
        });
    </script>

    <!--开关插件-->
    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 7892), Tuple.Create("\"", 7948)
, Tuple.Create(Tuple.Create("", 7898), Tuple.Create<System.Object, System.Int32>(Href("~/Content/bootstrap-switch/bootstrap-switch.min.js")
, 7898), false)
);

WriteLiteral("></script>\r\n    <script>\r\n        $(function () {\r\n            $(\"input.chkSwitch" +
"\").bootstrapSwitch();\r\n        })\r\n    </script>\r\n\r\n    ");

WriteLiteral("\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 8112), Tuple.Create("\"", 8161)
, Tuple.Create(Tuple.Create("", 8118), Tuple.Create<System.Object, System.Int32>(Href("~/Content/artDialog/dist/dialog-plus-min.js")
, 8118), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 8185), Tuple.Create("\"", 8234)
, Tuple.Create(Tuple.Create("", 8191), Tuple.Create<System.Object, System.Int32>(Href("~/Content/artDialog/dist/dialog.new.life.js")
, 8191), false)
);

WriteLiteral("></script>\r\n    ");

WriteLiteral("\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 8279), Tuple.Create("\"", 8318)
, Tuple.Create(Tuple.Create("", 8285), Tuple.Create<System.Object, System.Int32>(Href("~/Content/Cube.js?v=3.2.2020.0204")
, 8285), false)
);

WriteLiteral("></script>\r\n</body>\r\n</html>");

        }
    }
}
#pragma warning restore 1591
