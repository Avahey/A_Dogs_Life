#pragma checksum "C:\Users\John\RiderProjects\ADogsLifeWebApplication\ADogsLifeWebApplication\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "089af3870b5e3092cae9b012c54b4d85a02a2ea6"
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
#line 1 "C:\Users\John\RiderProjects\ADogsLifeWebApplication\ADogsLifeWebApplication\Views\_ViewImports.cshtml"
using ADogsLifeWebApplication.ViewModels;

#line default
#line hidden
#line 3 "C:\Users\John\RiderProjects\ADogsLifeWebApplication\ADogsLifeWebApplication\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 1 "C:\Users\John\RiderProjects\ADogsLifeWebApplication\ADogsLifeWebApplication\Views\Home\Index.cshtml"
using ADogsLifeWebApplication.Models.Users;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"089af3870b5e3092cae9b012c54b4d85a02a2ea6", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45fcbf24119887dc1ff71d4ade4bb344ff427005", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewProfile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("View Profile"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark m-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Administration", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Edit Profile"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteUserOnUserIndexPage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditProfile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/CustomScript.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#line 6 "C:\Users\John\RiderProjects\ADogsLifeWebApplication\ADogsLifeWebApplication\Views\Home\Index.cshtml"
  
    ViewBag.Title = "User List";

#line default
#line hidden
            WriteLiteral(@"
<div class=""container-fluid"">
    <div class=""card"">
        <div>
            <h1 class=""card-header"" id=""indexUserHeader"">Doggo Parents</h1>
        </div>
        <div class=""row indexRow"">
            <div class=""col m-1 column-align-left"">
                <div class=""card-deck"">
");
#line 18 "C:\Users\John\RiderProjects\ADogsLifeWebApplication\ADogsLifeWebApplication\Views\Home\Index.cshtml"
                     foreach (ApplicationUser user in UserManager.Users)
                    {
                        

#line default
#line hidden
#line 20 "C:\Users\John\RiderProjects\ADogsLifeWebApplication\ADogsLifeWebApplication\Views\Home\Index.cshtml"
                         if (User.Identity.Name != user.UserName)
                        {
                            string photoPath = "../Images/UserImages/" + user.Id + "/" + (user.PhotoPath ?? "noImage.jpg");

#line default
#line hidden
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "089af3870b5e3092cae9b012c54b4d85a02a2ea69209", async() => {
                WriteLiteral("\r\n                                <div class=\"container m-4\">\r\n                                    <div class=\"front\"");
                BeginWriteAttribute("style", " style=\"", 1097, "\"", 1138, 4);
                WriteAttributeValue("", 1105, "background-image:", 1105, 17, true);
                WriteAttributeValue(" ", 1122, "url(", 1123, 5, true);
#line 25 "C:\Users\John\RiderProjects\ADogsLifeWebApplication\ADogsLifeWebApplication\Views\Home\Index.cshtml"
WriteAttributeValue("", 1127, photoPath, 1127, 10, false);

#line default
#line hidden
                WriteAttributeValue("", 1137, ")", 1137, 1, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                        <div class=\"inner\">\r\n                                            <p style=\"font-size: 40px\">");
#line 27 "C:\Users\John\RiderProjects\ADogsLifeWebApplication\ADogsLifeWebApplication\Views\Home\Index.cshtml"
                                                                  Write(user.FirstName);

#line default
#line hidden
                WriteLiteral(" ");
#line 27 "C:\Users\John\RiderProjects\ADogsLifeWebApplication\ADogsLifeWebApplication\Views\Home\Index.cshtml"
                                                                                  Write(user.LastName);

#line default
#line hidden
                WriteLiteral("</p>\r\n                                            <span style=\"font-size: 25px\">");
#line 28 "C:\Users\John\RiderProjects\ADogsLifeWebApplication\ADogsLifeWebApplication\Views\Home\Index.cshtml"
                                                                     Write(user.Country);

#line default
#line hidden
                WriteLiteral(@"</span>
                                        </div>
                                    </div>
                                    <div class=""back"">
                                        <div class=""inner"">
                                            <div class=""row"">
                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "089af3870b5e3092cae9b012c54b4d85a02a2ea611554", async() => {
                    WriteLiteral("View");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 34 "C:\Users\John\RiderProjects\ADogsLifeWebApplication\ADogsLifeWebApplication\Views\Home\Index.cshtml"
                                                                                                       WriteLiteral(user.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 35 "C:\Users\John\RiderProjects\ADogsLifeWebApplication\ADogsLifeWebApplication\Views\Home\Index.cshtml"
                                                 if (SignInManager.IsSignedIn(User) && User.IsInRole("Admin"))
                                                {

#line default
#line hidden
                WriteLiteral("                                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "089af3870b5e3092cae9b012c54b4d85a02a2ea614625", async() => {
                    WriteLiteral("Edit");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 37 "C:\Users\John\RiderProjects\ADogsLifeWebApplication\ADogsLifeWebApplication\Views\Home\Index.cshtml"
                                                                                                               WriteLiteral(user.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#line 38 "C:\Users\John\RiderProjects\ADogsLifeWebApplication\ADogsLifeWebApplication\Views\Home\Index.cshtml"
                                                }

#line default
#line hidden
                WriteLiteral("                                            </div>\r\n                                            <div class=\"row\">\r\n");
#line 41 "C:\Users\John\RiderProjects\ADogsLifeWebApplication\ADogsLifeWebApplication\Views\Home\Index.cshtml"
                                                 if (SignInManager.IsSignedIn(User) && User.IsInRole("Admin"))
                                                {

#line default
#line hidden
                WriteLiteral("                                                    <span class=\"row\"");
                BeginWriteAttribute("id", " id=\"", 2609, "\"", 2640, 2);
                WriteAttributeValue("", 2614, "confirmDeleteSpan_", 2614, 18, true);
#line 43 "C:\Users\John\RiderProjects\ADogsLifeWebApplication\ADogsLifeWebApplication\Views\Home\Index.cshtml"
WriteAttributeValue("", 2632, user.Id, 2632, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                WriteLiteral(@" style=""display: none"">
                                                        <span>Are you sure you want to delete?</span>
                                                        <button type=""submit"" class=""btn btn-danger m-1"">Yes</button>
                                                        <a href=""javascript:void();"" class=""btn btn-dark m-1""");
                BeginWriteAttribute("onclick", " onclick=\"", 2997, "\"", 3039, 4);
                WriteAttributeValue("", 3007, "confirmDelete(\'", 3007, 15, true);
#line 46 "C:\Users\John\RiderProjects\ADogsLifeWebApplication\ADogsLifeWebApplication\Views\Home\Index.cshtml"
WriteAttributeValue("", 3022, user.Id, 3022, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 3030, "\',", 3030, 2, true);
                WriteAttributeValue(" ", 3032, "false)", 3033, 7, true);
                EndWriteAttribute();
                WriteLiteral(">No</a>\r\n                                                    </span>\r\n                                                    <span");
                BeginWriteAttribute("id", " id=\"", 3167, "\"", 3191, 2);
                WriteAttributeValue("", 3172, "deleteSpan_", 3172, 11, true);
#line 48 "C:\Users\John\RiderProjects\ADogsLifeWebApplication\ADogsLifeWebApplication\Views\Home\Index.cshtml"
WriteAttributeValue("", 3183, user.Id, 3183, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                WriteLiteral(">\r\n                                                        <a href=\"javascript:void();\" class=\"btn btn-danger m-1\"");
                BeginWriteAttribute("onclick", " onclick=\"", 3306, "\"", 3347, 4);
                WriteAttributeValue("", 3316, "confirmDelete(\'", 3316, 15, true);
#line 49 "C:\Users\John\RiderProjects\ADogsLifeWebApplication\ADogsLifeWebApplication\Views\Home\Index.cshtml"
WriteAttributeValue("", 3331, user.Id, 3331, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 3339, "\',", 3339, 2, true);
                WriteAttributeValue(" ", 3341, "true)", 3342, 6, true);
                EndWriteAttribute();
                WriteLiteral(">Delete</a>\r\n                                                    </span>\r\n");
#line 51 "C:\Users\John\RiderProjects\ADogsLifeWebApplication\ADogsLifeWebApplication\Views\Home\Index.cshtml"
                                                }

#line default
#line hidden
                WriteLiteral("                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 23 "C:\Users\John\RiderProjects\ADogsLifeWebApplication\ADogsLifeWebApplication\Views\Home\Index.cshtml"
                                                                                                                                                       WriteLiteral(user.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#line 57 "C:\Users\John\RiderProjects\ADogsLifeWebApplication\ADogsLifeWebApplication\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#line 57 "C:\Users\John\RiderProjects\ADogsLifeWebApplication\ADogsLifeWebApplication\Views\Home\Index.cshtml"
                         
                    }

#line default
#line hidden
            WriteLiteral("                </div>\r\n            </div>\r\n            <div class=\"col m-1 column-align-right\">\r\n");
#line 62 "C:\Users\John\RiderProjects\ADogsLifeWebApplication\ADogsLifeWebApplication\Views\Home\Index.cshtml"
                 foreach (ApplicationUser user in UserManager.Users)
                {
                    

#line default
#line hidden
#line 64 "C:\Users\John\RiderProjects\ADogsLifeWebApplication\ADogsLifeWebApplication\Views\Home\Index.cshtml"
                     if (user.UserName == User.Identity.Name)
                    {
                        string photoPath = "../Images/UserImages/" + user.Id + "/" + (user.PhotoPath ?? "noImage.jpg");

#line default
#line hidden
            WriteLiteral("                        <div class=\"list-card\">\r\n                            <h1 class=\"golden-text-shadow prop-headers\">");
#line 68 "C:\Users\John\RiderProjects\ADogsLifeWebApplication\ADogsLifeWebApplication\Views\Home\Index.cshtml"
                                                                   Write(user.FullName);

#line default
#line hidden
            WriteLiteral("</h1>\r\n                            <hr/>\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 4347, "\"", 4363, 1);
#line 70 "C:\Users\John\RiderProjects\ADogsLifeWebApplication\ADogsLifeWebApplication\Views\Home\Index.cshtml"
WriteAttributeValue("", 4353, photoPath, 4353, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(" class=\"img-list-user-page\"");
            BeginWriteAttribute("alt", " alt=\"", 4391, "\"", 4397, 0);
            EndWriteAttribute();
            WriteLiteral("/>\r\n                            <hr/>\r\n                            <p>");
#line 72 "C:\Users\John\RiderProjects\ADogsLifeWebApplication\ADogsLifeWebApplication\Views\Home\Index.cshtml"
                          Write(user.Description);

#line default
#line hidden
            WriteLiteral("</p>\r\n                            <div>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "089af3870b5e3092cae9b012c54b4d85a02a2ea626479", async() => {
                WriteLiteral("View");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 74 "C:\Users\John\RiderProjects\ADogsLifeWebApplication\ADogsLifeWebApplication\Views\Home\Index.cshtml"
                                                                                                            WriteLiteral(user.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "089af3870b5e3092cae9b012c54b4d85a02a2ea629000", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 75 "C:\Users\John\RiderProjects\ADogsLifeWebApplication\ADogsLifeWebApplication\Views\Home\Index.cshtml"
                                                                                                            WriteLiteral(user.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
                        <br/>
                        <div class=""list-card"">
                            <h3 class=""prop-headers"">Popular Post</h3>
                            <hr/>
                            <div class=""fakeimg"">
                                <p>Image</p>
                            </div>
                            <div class=""fakeimg"">
                                <p>Image</p>
                            </div>
                            <div class=""fakeimg"">
                                <p>Image</p>
                            </div>
                        </div>
                        <br/>
                        <div class=""list-card"">
                            <h3 class=""prop-headers"">Follow Me</h3>
                            <hr/>
                            <p>Some text..</p>
                        </div>
");
#line 98 "C:\Users\John\RiderProjects\ADogsLifeWebApplication\ADogsLifeWebApplication\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#line 98 "C:\Users\John\RiderProjects\ADogsLifeWebApplication\ADogsLifeWebApplication\Views\Home\Index.cshtml"
                     
                }

#line default
#line hidden
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "089af3870b5e3092cae9b012c54b4d85a02a2ea633002", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    <script>\r\n        var user = ");
#line 110 "C:\Users\John\RiderProjects\ADogsLifeWebApplication\ADogsLifeWebApplication\Views\Home\Index.cshtml"
              Write(UserManager.Users.Select(user => user.UserName == User.Identity.Name));

#line default
#line hidden
                WriteLiteral(";\r\n        document.getElementById(\"getUserPhoto\").innerHTML = user.PhotoPath;\r\n    </script>\r\n");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; }
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