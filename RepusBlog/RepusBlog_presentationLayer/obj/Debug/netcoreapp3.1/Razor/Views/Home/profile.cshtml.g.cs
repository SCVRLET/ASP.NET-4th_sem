#pragma checksum "C:\Users\BANGLADESH\Desktop\ASP.NET-4th_sem\RepusBlog\RepusBlog_presentationLayer\Views\Home\profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a13d6c7d5df1309655ab24ab37503dd40fa09fbd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_profile), @"mvc.1.0.view", @"/Views/Home/profile.cshtml")]
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
#line 1 "C:\Users\BANGLADESH\Desktop\ASP.NET-4th_sem\RepusBlog\RepusBlog_presentationLayer\Views\_ViewImports.cshtml"
using RepusBlog_presentationLayer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\BANGLADESH\Desktop\ASP.NET-4th_sem\RepusBlog\RepusBlog_presentationLayer\Views\_ViewImports.cshtml"
using RepusBlog_presentationLayer.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a13d6c7d5df1309655ab24ab37503dd40fa09fbd", @"/Views/Home/profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d70056f725c68688d2f34514949169b937ba3bc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/noavatar.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Your avatar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("auth"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Mert S. Kaplan"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("twPc-avatarImg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\BANGLADESH\Desktop\ASP.NET-4th_sem\RepusBlog\RepusBlog_presentationLayer\Views\Home\profile.cshtml"
   ViewData["Title"] = "Профиль"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral(@"        <!-- Редактирование -->
        <div class=""modal fade"" id=""ModalEdit"" tabindex=""-1"" role=""dialog""
             aria-labelledby=""myModalEdit"" aria-hidden=""true"">
            <div class=""modal-dialog"" role=""document"">
                <div class=""container"">
                    <div class=""col-12"">
                        <div class=""modal-content"">
                            <div class=""modal-body"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a13d6c7d5df1309655ab24ab37503dd40fa09fbd6608", async() => {
                WriteLiteral("\n\n                                    <div class=\"form-group col-md-3\">\n                                        <div class=\"profile-header-img\" style=\"width: 100px; height: 100px;\">\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a13d6c7d5df1309655ab24ab37503dd40fa09fbd7098", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@" 
                                        </div><br><br>
                                        <label style=""margin-top: 2rem;"" for=""exampleAvatar"">Сменить аватар:</label>
                                        <input type=""file"" class=""form-control-file"" id=""exampleAvatar"">
                                    </div>

                                    <div class=""form-row"">

");
                WriteLiteral("\n");
                WriteLiteral("\n                                        <div class=\"form-group col-md-6\" style=\"margin-left: 1rem;\">\n                                            <label for=\"InputPassword\">Пароль:</label>\n                                            <input");
                BeginWriteAttribute("required", " required=\"", 3449, "\"", 3460, 0);
                EndWriteAttribute();
                WriteLiteral(@" type=""password"" name=""InputPassword""
                                                   class=""form-control"" id=""InputPassword""
                                                   pattern=""(?=^.{6,}$)(?=.*[0-9])(?=.*[A-Z])(?=.*[a-z]).*"" placeholder=""Введите пароль...""
                                                   title=""Должно содержать по крайней мере одно число, одну заглавную и строчную буквы, а также не менее 6 и более символов"">
                                        </div>
                                    </div>

                                    <div class=""modal-footer"">
                                        <button type=""submit"" class=""btn btn-primary"">Сохранить</button>
                                    </div>

                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                            </div>\n                        </div>\n                    </div>\n                </div>\n            </div>\n        </div>\n");
            WriteLiteral("\n<!-- main -->\n<div class=\"col-md-1\"></div>\n\n<div class=\"col-md-10\">\n    <div class=\"twPc-div\">\n        <a class=\"twPc-bg twPc-block\"></a>\n\n        <div>\n            <div class=\"twPc-button\">\n                <a");
            BeginWriteAttribute("href", " href=\"", 4619, "\"", 4626, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"twitter-follow-button\" data-show-count=\"false\"\n                   data-size=\"large\" data-show-screen-name=\"false\" data-dnt=\"true\">Follow</a>\n            </div>\n\n            <a title=\"Dias Bolatov\"");
            BeginWriteAttribute("href", " href=\"", 4831, "\"", 4838, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"twPc-avatarLink\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a13d6c7d5df1309655ab24ab37503dd40fa09fbd12159", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </a>

            <div class=""twPc-divUser"">
                <div class=""twPc-divName"">
                    <h4 style=""color: white;"" class=""m-t-10 m-b-5"">Dias Bolatov</h4>
                </div>
                <span>
                    <span>thebangladesh</span>
                </span>
            </div>

            <div class=""twPc-divStats"">
                <ul class=""twPc-Arrange"" style=""margin-left: 15rem;"">
                    <li class=""twPc-ArrangeSizeFit"">
                        <span class=""twPc-StatLabel twPc-block"">Посты</span>
                        <span class=""twPc-StatValue"">100</span>
                    </li>
                    <li class=""twPc-ArrangeSizeFit"" style=""margin-left: 2rem;"">
                        <span class=""twPc-StatLabel twPc-block"">Подписки</span>
                        <span class=""twPc-StatValue"">100</span>
                    </li>
                    <li class=""twPc-ArrangeSizeFit"">
                        <span class=""twPc-StatLabel twPc-block"">Подп");
            WriteLiteral(@"исчики</span>
                        <span class=""twPc-StatValue"">100</span>
                    </li>
                </ul>
            </div>

            <button type=""button"" class=""btn btn-outline-primary""
                data-toggle=""modal"" data-target=""#ModalEdit"">
                Редактировать профиль
            </button>
        </div>
    </div>

    <div id=""content"" class=""content content-full-width"">

        <!-- Создание постов -->
        <!-- Profile content -->
        <div class=""profile-content"" style=""margin-top: 4rem;"">
            <div class=""tab-content p-0"">
                <div class=""tab-pane fade active show"" id=""profile-post"">

                    <div class=""container"">
                        <div class=""row"">

                            <div class=""col-7"">
                                <ul class=""timeline"">
                                    <li>

                                        <!-- <div class=""timeline-time"">
                                          <span class");
            WriteLiteral(@"=""date"">Сегодня</span>
                                          <span class=""time"">13:54</span>
                                        </div> -->

                                        <div class=""timeline-body"">
                                            <div class=""timeline-header"">

                                                <span class=""userimage"">
                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a13d6c7d5df1309655ab24ab37503dd40fa09fbd15959", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                </span>

                                                <span class=""username"">
                                                    <a href=""javascript:;"">Dias Bolatov</a> <!-- Ну тут никнейм (псевдоним) от айдишника -->
                                                    <small></small>
                                                </span>

                                            </div>
                                            <div class=""timeline-content"">
                                                <p style=""font-size: 18px"">
                                                    Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc faucibus turpis quis tincidunt luctus.
                                                    Nam sagittis dui in nunc consequat, in imperdiet nunc sagittis.
                                                </p>
                                            </div>

                                            <!-- Кол");
            WriteLiteral(@"ичество лайков и комментариев поста -->
                                            <div class=""timeline-likes"">
                                                <div class=""stats-right"" style=""font-size: 15px"">
                                                    <span class=""stats-text"">Комментарии: 1</span>
                                                </div>
                                                <div class=""stats"">
                                                    <span class=""fa-stack fa-fw stats-icon"">
                                                        <i class=""fa fa-circle fa-stack-2x text-danger""></i>
                                                        <i class=""fa fa-heart fa-stack-1x fa-inverse t-plus-1""></i>
                                                    </span>
                                                    <span class=""fa-stack fa-fw stats-icon"">
                                                        <i class=""fa fa-circle fa-stack-2x text-primary""></i>
          ");
            WriteLiteral(@"                                              <i class=""fa fa-thumbs-up fa-stack-1x fa-inverse""></i>
                                                    </span>
                                                    <span class=""stats-total"" style=""font-size: 15px"">Лайки: 2 </span>
                                                </div>
                                            </div>
                                            <div class=""timeline-footer"">
                                                <a href=""javascript:;"" class=""m-r-15 text-inverse-lighter"">
                                                    <i class=""fa fa-thumbs-up fa-fw fa-lg m-r-3""></i> Лайк
                                                </a>
                                                <a href=""javascript:;"" class=""m-r-15 text-inverse-lighter"">
                                                    <i class=""fa fa-comments fa-fw fa-lg m-r-3""></i> Комментарии
                                                </a>
                      ");
            WriteLiteral(@"                      </div>

                                            <!-- Комментарий -->
                                            <div class=""timeline-comment-box"">
                                                <div class=""user"">
                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a13d6c7d5df1309655ab24ab37503dd40fa09fbd20584", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                                </div>\n                                                <div class=\"input\">\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a13d6c7d5df1309655ab24ab37503dd40fa09fbd21876", async() => {
                WriteLiteral(@"
                                                        <div class=""input-group"">
                                                            <input type=""text"" class=""form-control rounded-corner"" placeholder=""Напишите что-нибудь..."">
                                                            <span class=""input-group-btn p-l-10"">
                                                                <button style=""margin-left: 1rem;"" class=""btn btn-primary f-s-12 rounded-corner"" type=""button"">
                                                                    Отправить
                                                                </button>
                                                            </span>
                                                        </div>
                                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                </div>
                                            </div>

                                        </div>
                                    </li>

                                    <!-- Прокрутка вниз с загрузкой поста -->
                                    <li>
                                        <div class=""timeline-body"">
                                            Загрузка...
                                        </div>
                                    </li>

                                </ul>
                            </div>

                            <div class=""col-5"">1</div>

                        </div>
                    </div>

                </div>
            </div>
        </div>

    </div>
</div>

<div class=""col-md-1""></div>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
