#pragma checksum "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Goods\Loss.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6f9b1cb0bbcf6325db4dbbf21ca34e0292d9451"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FytSoa.Web.Pages.FytAdmin.Goods.Pages_FytAdmin_Goods_Loss), @"mvc.1.0.razor-page", @"/Pages/FytAdmin/Goods/Loss.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/FytAdmin/Goods/Loss.cshtml", typeof(FytSoa.Web.Pages.FytAdmin.Goods.Pages_FytAdmin_Goods_Loss), null)]
namespace FytSoa.Web.Pages.FytAdmin.Goods
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\_ViewImports.cshtml"
using FytSoa.Web;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6f9b1cb0bbcf6325db4dbbf21ca34e0292d9451", @"/Pages/FytAdmin/Goods/Loss.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21c44af9864cf57cf01e8fd1fe389a8e352e148c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_FytAdmin_Goods_Loss : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Goods\Loss.cshtml"
  
    ViewData["Title"] = "报损管理";
    Layout = AdminLayout.Pjax(HttpContext);

#line default
#line hidden
            BeginContext(142, 365, true);
            WriteLiteral(@"<div id=""container"">
    <div class=""list-wall"">
        <div class=""layui-form list-search"">
            <div class=""layui-inline"">
                <input class=""layui-input"" id=""key"" autocomplete=""off"" placeholder=""请输入关键字查询"">
            </div>
            <div class=""layui-inline"">
                <select id=""branks"" lay-search="""">
                    ");
            EndContext();
            BeginContext(507, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87548f1569ab420baac691052bc274e8", async() => {
                BeginContext(524, 11, true);
                WriteLiteral("--可根据品牌搜索--");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(544, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 16 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Goods\Loss.cshtml"
                      
                        foreach (var item in Model.codeList)
                        {

#line default
#line hidden
            BeginContext(659, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(687, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "060c27e5405645e4b85e148026e6b07c", async() => {
                BeginContext(715, 9, false);
#line 19 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Goods\Loss.cshtml"
                                                  Write(item.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 19 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Goods\Loss.cshtml"
                               WriteLiteral(item.Guid);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(733, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 20 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Goods\Loss.cshtml"
                        }
                    

#line default
#line hidden
            BeginContext(785, 5086, true);
            WriteLiteral(@"                </select>
            </div>
            <button type=""button"" class=""layui-btn layui-btn-sm"" data-type=""toolSearch""><i class=""layui-icon layui-icon-search""></i> 搜索</button>
        </div>
        <table class=""layui-hide"" id=""tablist"" lay-filter=""tool""></table>
    </div>
    <script type=""text/html"" id=""toolbar"">
        <div class=""layui-btn-container"">
            <button type=""button"" class=""layui-btn layui-btn-sm"" lay-event=""toolAdd""><i class=""layui-icon""></i> 新增</button>
        </div>
    </script>
    <script>
        layui.config({
            base: '/themes/js/modules/'
        }).use(['table', 'layer', 'jquery', 'common', 'form'],
            function () {
                var table = layui.table,
                    layer = layui.layer,
                    $ = layui.jquery,
                    os = layui.common,
                    form = layui.form;
                form.render('select');
                table.render({
                    toolbar: '#toolbar'");
            WriteLiteral(@",
                    elem: '#tablist',
                    url: '/api/goods/loss/list',
                    cols: [
                        [
                            { type: 'checkbox', fixed: 'left' },
                            { field: 'code', width: 180, title: '条形码', sort: true, fixed: 'left' },
                            { field: 'brankName', title: '品牌', sort: true },
                            { field: 'styleName', title: '款式', sort: true },
                            { field: 'salePrice', title: '价格', sort: true },
                            { field: 'disPrice', title: '折扣价', sort: true },
                            { field: 'stockSum', title: '库存', sort: true },
                            { field: 'saleSum', title: '报损数', sort: true },
                            { field: 'addDate', title: '添加时间', sort: true },
                            { width: 140, title: '操作', templet: '#tool' }
                        ]
                    ],
                    page: { limits: [10");
            WriteLiteral(@", 20, 50, 100, 500, 1000, 5000, 10000], groups: 8 },
                    id: 'tables'
                });

                var guid = '', active = {
                    reload: function () {
                        table.reload('tables',
                            {
                                page: {
                                    curr: 1
                                },
                                where: {
                                    key: $(""#key"").val(),
                                    guid: $(""#branks"").val()
                                }
                            });
                    },
                    toolSearch: function () {
                        active.reload();
                    },
                    toolAdd: function () {
                        os.Open('添加报损', '/fytadmin/goods/lossadd', '750px', '400px', function () {
                            active.reload();
                        });
                    }                  ");
            WriteLiteral(@"  
                };
                table.on('toolbar(tool)', function (obj) {
                    active[obj.event] ? active[obj.event].call(this) : '';
                });
                $('.list-search .layui-btn').on('click', function () {
                    var type = $(this).data('type');
                    active[type] ? active[type].call(this) : '';
                });
                //监听工具条
                table.on('tool(tool)', function (obj) {
                    var data = obj.data;
                    if (obj.event === 'edit') {
                        layer.prompt({ title: '请输入恢复的数量', formType: 0, value: data.saleSum }, function (vals, index) {
                            if (isNaN(vals)) { 
                                os.error('输入错误~');
                                return;
                            }
                            if (vals > data.saleSum) {
                                os.error('数量不能大于报损数量~');
                                return;
         ");
            WriteLiteral(@"                   }
                            var loadIndex = layer.load(1, {
                                shade: [0.1, '#fff']
                            });
                            os.ajax('api/goods/modifyloss', { Guid: data.guid, Counts: vals, SkuGuid:data.code }, function (res) { 
                                layer.close(loadIndex);
                                if (res.statusCode === 200) {
                                    layer.close(index);
                                    active.reload();
                                } else {
                                    os.error(res.message);
                                }
                            });
                        });
                    }
                });
            });
    </script>
    <script type=""text/html"" id=""tool"">
        <a class=""layui-btn layui-btn-primary layui-btn-xs"" lay-event=""edit""><i class=""layui-icon""></i> 恢复库存</a>
    </script>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FytSoa.Web.Pages.FytAdmin.Goods.LossModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Goods.LossModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Goods.LossModel>)PageContext?.ViewData;
        public FytSoa.Web.Pages.FytAdmin.Goods.LossModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
