#pragma checksum "C:\Users\SCVRLET\Desktop\Semestrovka-3b95702110b44d0552916618e3b477a092cf3729\UserStore\UserStore\Views\Home\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0cf1a0237bb24de15e8214d20c63a1578985a51f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Profile), @"mvc.1.0.view", @"/Views/Home/Profile.cshtml")]
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
#line 1 "C:\Users\SCVRLET\Desktop\Semestrovka-3b95702110b44d0552916618e3b477a092cf3729\UserStore\UserStore\Views\_ViewImports.cshtml"
using UserStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SCVRLET\Desktop\Semestrovka-3b95702110b44d0552916618e3b477a092cf3729\UserStore\UserStore\Views\_ViewImports.cshtml"
using UserStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\SCVRLET\Desktop\Semestrovka-3b95702110b44d0552916618e3b477a092cf3729\UserStore\UserStore\Views\Home\Profile.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0cf1a0237bb24de15e8214d20c63a1578985a51f", @"/Views/Home/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af95fdd3894c630ec7607b92b4b9bb0f279b1b24", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserStore.Models.ProfileViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/profile.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("avatar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/default_avatar/icon.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Users", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreatePost", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("postmaker-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("like-post-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("reply-maker-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/profile.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\SCVRLET\Desktop\Semestrovka-3b95702110b44d0552916618e3b477a092cf3729\UserStore\UserStore\Views\Home\Profile.cshtml"
  
    if(User.Identity.IsAuthenticated)
        Layout = "~/Views/Shared/_LayoutForLogged.cshtml";

    else
        Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0cf1a0237bb24de15e8214d20c63a1578985a51f8215", async() => {
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
            WriteLiteral("\r\n<div id=\"profile-information\">\r\n    <div id=\"profile-information-block\">\r\n        <div id=\"avatar-container\">\r\n");
#nullable restore
#line 17 "C:\Users\SCVRLET\Desktop\Semestrovka-3b95702110b44d0552916618e3b477a092cf3729\UserStore\UserStore\Views\Home\Profile.cshtml"
             if (Model.User.Avatar == null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0cf1a0237bb24de15e8214d20c63a1578985a51f9764", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 20 "C:\Users\SCVRLET\Desktop\Semestrovka-3b95702110b44d0552916618e3b477a092cf3729\UserStore\UserStore\Views\Home\Profile.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <img id=\"avatar\">\r\n");
#nullable restore
#line 24 "C:\Users\SCVRLET\Desktop\Semestrovka-3b95702110b44d0552916618e3b477a092cf3729\UserStore\UserStore\Views\Home\Profile.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div id=\"profile-text-info\">\r\n            <div class=\"profile-login\">\r\n                <h2><b>");
#nullable restore
#line 29 "C:\Users\SCVRLET\Desktop\Semestrovka-3b95702110b44d0552916618e3b477a092cf3729\UserStore\UserStore\Views\Home\Profile.cshtml"
                  Write(Model.User.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h2>\r\n            </div>\r\n            <div class=\"profile-name\">\r\n                <h6>");
#nullable restore
#line 32 "C:\Users\SCVRLET\Desktop\Semestrovka-3b95702110b44d0552916618e3b477a092cf3729\UserStore\UserStore\Views\Home\Profile.cshtml"
               Write(Model.User.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 32 "C:\Users\SCVRLET\Desktop\Semestrovka-3b95702110b44d0552916618e3b477a092cf3729\UserStore\UserStore\Views\Home\Profile.cshtml"
                                     Write(Model.User.SecondName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n            </div>\r\n            <div class=\"profile-joined-date\">\r\n                <h6>Joined at: ");
#nullable restore
#line 35 "C:\Users\SCVRLET\Desktop\Semestrovka-3b95702110b44d0552916618e3b477a092cf3729\UserStore\UserStore\Views\Home\Profile.cshtml"
                          Write(Model.User.JoinedAt.Date.ToString("MM/dd/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n<div class=\"post-creation-container\">\r\n    <div class=\"post-creation-block\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0cf1a0237bb24de15e8214d20c63a1578985a51f13155", async() => {
                WriteLiteral(@"
            <textarea name=""postText"" id=""autoresizing"" placeholder=""Tell me how do you feel""></textarea>
            <div id=""post-photos"">

            </div>
            <div class=""post-creation-footer"">
                <div class=""post-creation-icons"">
                    <div class=""post-creation-icon"">
                        <svg style=""margin-top:3px"" data-toggle=""modal"" data-target=""#add-post-photo"" xmlns=""http://www.w3.org/2000/svg"" width=""28"" height=""28"" fill=""currentColor"" class=""bi bi-camera"" viewBox=""0 0 16 16"">
                            <path d=""M15 12a1 1 0 0 1-1 1H2a1 1 0 0 1-1-1V6a1 1 0 0 1 1-1h1.172a3 3 0 0 0 2.12-.879l.83-.828A1 1 0 0 1 6.827 3h2.344a1 1 0 0 1 .707.293l.828.828A3 3 0 0 0 12.828 5H14a1 1 0 0 1 1 1v6zM2 4a2 2 0 0 0-2 2v6a2 2 0 0 0 2 2h12a2 2 0 0 0 2-2V6a2 2 0 0 0-2-2h-1.172a2 2 0 0 1-1.414-.586l-.828-.828A2 2 0 0 0 9.172 2H6.828a2 2 0 0 0-1.414.586l-.828.828A2 2 0 0 1 3.172 4H2z"" />
                            <path d=""M8 11a2.5 2.5 0 1 1 0-5 2.5 2.5 0 0 1 0 5z");
                WriteLiteral(@"m0 1a3.5 3.5 0 1 0 0-7 3.5 3.5 0 0 0 0 7zM3 6.5a.5.5 0 1 1-1 0 .5.5 0 0 1 1 0z"" />
                        </svg>
                    </div>
                </div>
                <button id=""make-post-button"" type=""submit"" class=""btn btn-primary submit px-3"">Submit</button>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<div id=\"posts-container\">\r\n");
#nullable restore
#line 64 "C:\Users\SCVRLET\Desktop\Semestrovka-3b95702110b44d0552916618e3b477a092cf3729\UserStore\UserStore\Views\Home\Profile.cshtml"
     foreach (var post in Model.UserPosts.Reverse())
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"post\">\r\n            <div class=\"post-header\">\r\n\r\n                <div class=\"post-info\">\r\n                    <div class=\"postmaker-avatar\">\r\n");
#nullable restore
#line 71 "C:\Users\SCVRLET\Desktop\Semestrovka-3b95702110b44d0552916618e3b477a092cf3729\UserStore\UserStore\Views\Home\Profile.cshtml"
                         if (Model.User.Avatar == null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0cf1a0237bb24de15e8214d20c63a1578985a51f17284", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 74 "C:\Users\SCVRLET\Desktop\Semestrovka-3b95702110b44d0552916618e3b477a092cf3729\UserStore\UserStore\Views\Home\Profile.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <img class=\"postmaker-img\" />\r\n");
#nullable restore
#line 78 "C:\Users\SCVRLET\Desktop\Semestrovka-3b95702110b44d0552916618e3b477a092cf3729\UserStore\UserStore\Views\Home\Profile.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"postmaker-login-and-date\" style=\"color:white\">\r\n                        <a style=\"color:rgb(111, 178, 255)\" href=\"{% url \'users:profile\' post.user_id.id %}\">\r\n                            ");
#nullable restore
#line 83 "C:\Users\SCVRLET\Desktop\Semestrovka-3b95702110b44d0552916618e3b477a092cf3729\UserStore\UserStore\Views\Home\Profile.cshtml"
                       Write(Model.User.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </a>\r\n                        <br><small>");
#nullable restore
#line 85 "C:\Users\SCVRLET\Desktop\Semestrovka-3b95702110b44d0552916618e3b477a092cf3729\UserStore\UserStore\Views\Home\Profile.cshtml"
                              Write(post.CreatedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 88 "C:\Users\SCVRLET\Desktop\Semestrovka-3b95702110b44d0552916618e3b477a092cf3729\UserStore\UserStore\Views\Home\Profile.cshtml"
                 if (User.Identity.Name == Model.User.UserName)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"edit-post\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0cf1a0237bb24de15e8214d20c63a1578985a51f20422", async() => {
                WriteLiteral("\r\n                            <button type=\"submit\" class=\"delete-post-button\">\r\n                                <input class=\"post-delete-id\" type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 4038, "\"", 4054, 1);
#nullable restore
#line 93 "C:\Users\SCVRLET\Desktop\Semestrovka-3b95702110b44d0552916618e3b477a092cf3729\UserStore\UserStore\Views\Home\Profile.cshtml"
WriteAttributeValue("", 4046, post.Id, 4046, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""postId"" style=""display: none"" />
                                <svg title=""Delete post"" xmlns=""http://www.w3.org/2000/svg"" width=""20"" height=""24"" fill=""currentColor"" class=""bi bi-x"" viewBox=""0 0 16 16"">
                                    <path d=""M4.646 4.646a.5.5 0 0 1 .708 0L8 7.293l2.646-2.647a.5.5 0 0 1 .708.708L8.707 8l2.647 2.646a.5.5 0 0 1-.708.708L8 8.707l-2.646 2.647a.5.5 0 0 1-.708-.708L7.293 8 4.646 5.354a.5.5 0 0 1 0-.708z"" />
                                </svg>
                            </button>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 100 "C:\Users\SCVRLET\Desktop\Semestrovka-3b95702110b44d0552916618e3b477a092cf3729\UserStore\UserStore\Views\Home\Profile.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"post-text\" style=\"color:white\">\r\n                ");
#nullable restore
#line 104 "C:\Users\SCVRLET\Desktop\Semestrovka-3b95702110b44d0552916618e3b477a092cf3729\UserStore\UserStore\Views\Home\Profile.cshtml"
           Write(post.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"like-comment-repost\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0cf1a0237bb24de15e8214d20c63a1578985a51f23763", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 108 "C:\Users\SCVRLET\Desktop\Semestrovka-3b95702110b44d0552916618e3b477a092cf3729\UserStore\UserStore\Views\Home\Profile.cshtml"
                     if (post.Likes.Where(x => x.UserId == userManager.FindByNameAsync(User.Identity.Name).Result.Id).Count() > 0)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <button type=\"submit\" class=\"button like\">\r\n                            <input class=\"post-id-value\" type=\"text\" name=\"postId\"");
                BeginWriteAttribute("value", " value=\"", 5210, "\"", 5226, 1);
#nullable restore
#line 111 "C:\Users\SCVRLET\Desktop\Semestrovka-3b95702110b44d0552916618e3b477a092cf3729\UserStore\UserStore\Views\Home\Profile.cshtml"
WriteAttributeValue("", 5218, post.Id, 5218, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" style=""display: none"" />
                            <svg xmlns=""http://www.w3.org/2000/svg"" width=""26"" height=""26"" fill=""violet"" class=""bi bi-heart-fill"" viewBox=""0 0 16 16"">
                                <path fill-rule=""evenodd"" d=""M8 1.314C12.438-3.248 23.534 4.735 8 15-7.534 4.736 3.562-3.248 8 1.314z"" />
                            </svg>

                        </button>
");
#nullable restore
#line 117 "C:\Users\SCVRLET\Desktop\Semestrovka-3b95702110b44d0552916618e3b477a092cf3729\UserStore\UserStore\Views\Home\Profile.cshtml"
                    }

                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <button type=\"submit\" class=\"button like\">\r\n                            <input class=\"post-id-value\" type=\"text\" name=\"postId\"");
                BeginWriteAttribute("value", " value=\"", 5842, "\"", 5858, 1);
#nullable restore
#line 122 "C:\Users\SCVRLET\Desktop\Semestrovka-3b95702110b44d0552916618e3b477a092cf3729\UserStore\UserStore\Views\Home\Profile.cshtml"
WriteAttributeValue("", 5850, post.Id, 5850, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" style=""display: none"" />
                            <svg xmlns=""http://www.w3.org/2000/svg"" width=""26"" height=""26"" fill=""currentColor"" class=""bi bi-heart"" viewBox=""0 0 16 16"">
                                <path d=""m8 2.748-.717-.737C5.6.281 2.514.878 1.4 3.053c-.523 1.023-.641 2.5.314 4.385.92 1.815 2.834 3.989 6.286 6.357 3.452-2.368 5.365-4.542 6.286-6.357.955-1.886.838-3.362.314-4.385C13.486.878 10.4.28 8.717 2.01L8 2.748zM8 15C-7.333 4.868 3.279-3.04 7.824 1.143c.06.055.119.112.176.171a3.12 3.12 0 0 1 .176-.17C12.72-3.042 23.333 4.867 8 15z"" />
                            </svg>

                        </button>
");
#nullable restore
#line 128 "C:\Users\SCVRLET\Desktop\Semestrovka-3b95702110b44d0552916618e3b477a092cf3729\UserStore\UserStore\Views\Home\Profile.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 130 "C:\Users\SCVRLET\Desktop\Semestrovka-3b95702110b44d0552916618e3b477a092cf3729\UserStore\UserStore\Views\Home\Profile.cshtml"
                 if (post.Likes != null)
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 131 "C:\Users\SCVRLET\Desktop\Semestrovka-3b95702110b44d0552916618e3b477a092cf3729\UserStore\UserStore\Views\Home\Profile.cshtml"
                     if (post.Likes.Count() > 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"like-comment-repost-number\">");
#nullable restore
#line 133 "C:\Users\SCVRLET\Desktop\Semestrovka-3b95702110b44d0552916618e3b477a092cf3729\UserStore\UserStore\Views\Home\Profile.cshtml"
                                                           Write(post.Likes.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 134 "C:\Users\SCVRLET\Desktop\Semestrovka-3b95702110b44d0552916618e3b477a092cf3729\UserStore\UserStore\Views\Home\Profile.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""button comment"">
                        <svg xmlns=""http://www.w3.org/2000/svg"" width=""26"" height=""26"" fill=""currentColor"" class=""bi bi-chat-square"" viewBox=""0 0 16 16"">
                            <path d=""M14 1a1 1 0 0 1 1 1v8a1 1 0 0 1-1 1h-2.5a2 2 0 0 0-1.6.8L8 14.333 6.1 11.8a2 2 0 0 0-1.6-.8H2a1 1 0 0 1-1-1V2a1 1 0 0 1 1-1h12zM2 0a2 2 0 0 0-2 2v8a2 2 0 0 0 2 2h2.5a1 1 0 0 1 .8.4l1.9 2.533a1 1 0 0 0 1.6 0l1.9-2.533a1 1 0 0 1 .8-.4H14a2 2 0 0 0 2-2V2a2 2 0 0 0-2-2H2z"" />
                        </svg>

                    </div>
                    <div class=""button repost"">
                        <svg xmlns=""http://www.w3.org/2000/svg"" width=""30"" height=""30"" fill=""currentColor"" class=""bi bi-reply"" viewBox=""0 0 16 16"">
                            <path d=""M6.598 5.013a.144.144 0 0 1 .202.134V6.3a.5.5 0 0 0 .5.5c.667 0 2.013.005 3.3.822.984.624 1.99 1.76 2.595 3.876-1.02-.983-2.185-1.516-3.205-1.799a8.74 8.74 0 0 0-1.921-.306 7.404 7.404 0 0 0-.798.008h-.013l-.005");
            WriteLiteral(@".001h-.001L7.3 9.9l-.05-.498a.5.5 0 0 0-.45.498v1.153c0 .108-.11.176-.202.134L2.614 8.254a.503.503 0 0 0-.042-.028.147.147 0 0 1 0-.252.499.499 0 0 0 .042-.028l3.984-2.933zM7.8 10.386c.068 0 .143.003.223.006.434.02 1.034.086 1.7.271 1.326.368 2.896 1.202 3.94 3.08a.5.5 0 0 0 .933-.305c-.464-3.71-1.886-5.662-3.46-6.66-1.245-.79-2.527-.942-3.336-.971v-.66a1.144 1.144 0 0 0-1.767-.96l-3.994 2.94a1.147 1.147 0 0 0 0 1.946l3.994 2.94a1.144 1.144 0 0 0 1.767-.96v-.667z"" />
                        </svg>
                    </div>
                </div>
                <div class=""reply-form"">
                    <div class=""reply-maker-avatar"">
");
#nullable restore
#line 149 "C:\Users\SCVRLET\Desktop\Semestrovka-3b95702110b44d0552916618e3b477a092cf3729\UserStore\UserStore\Views\Home\Profile.cshtml"
                         if (Model.User.Avatar == null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0cf1a0237bb24de15e8214d20c63a1578985a51f31823", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 152 "C:\Users\SCVRLET\Desktop\Semestrovka-3b95702110b44d0552916618e3b477a092cf3729\UserStore\UserStore\Views\Home\Profile.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <img class=\"reply-maker-img\" />\r\n");
#nullable restore
#line 156 "C:\Users\SCVRLET\Desktop\Semestrovka-3b95702110b44d0552916618e3b477a092cf3729\UserStore\UserStore\Views\Home\Profile.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                    <textarea></textarea>
                    <div class=""send-reply-button"">
                        <svg xmlns=""http://www.w3.org/2000/svg"" width=""28"" height=""28"" fill=""currentColor"" class=""bi bi-arrow-right-circle"" viewBox=""0 0 16 16"">
                            <path fill-rule=""evenodd"" d=""M1 8a7 7 0 1 0 14 0A7 7 0 0 0 1 8zm15 0A8 8 0 1 1 0 8a8 8 0 0 1 16 0zM4.5 7.5a.5.5 0 0 0 0 1h5.793l-2.147 2.146a.5.5 0 0 0 .708.708l3-3a.5.5 0 0 0 0-.708l-3-3a.5.5 0 1 0-.708.708L10.293 7.5H4.5z"" />
                        </svg>
                    </div>

                </div>
            </div>
");
#nullable restore
#line 167 "C:\Users\SCVRLET\Desktop\Semestrovka-3b95702110b44d0552916618e3b477a092cf3729\UserStore\UserStore\Views\Home\Profile.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>

<div class=""modal fade"" id=""add-post-photo"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Modal title</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <input id=""add-photo-field"" type=""file"" name=""add-photo"">
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-primary"">OK</button>
            </div>
        </div>
    </div>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0cf1a0237bb24de15e8214d20c63a1578985a51f35505", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<User> userManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserStore.Models.ProfileViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
