#pragma checksum "C:\Users\acer\source\repos\PSC System\PSC System\Pages\Forms\ProfileOboardingForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70e3d8acd08bd6a24fa76f6b70afa6b18fba2ac0"
// <auto-generated/>
#pragma warning disable 1591
namespace PSC_System.Pages.Forms
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\acer\source\repos\PSC System\PSC System\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\acer\source\repos\PSC System\PSC System\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\acer\source\repos\PSC System\PSC System\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\acer\source\repos\PSC System\PSC System\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\acer\source\repos\PSC System\PSC System\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\acer\source\repos\PSC System\PSC System\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\acer\source\repos\PSC System\PSC System\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\acer\source\repos\PSC System\PSC System\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\acer\source\repos\PSC System\PSC System\_Imports.razor"
using PSC_System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\acer\source\repos\PSC System\PSC System\_Imports.razor"
using PSC_System.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\acer\source\repos\PSC System\PSC System\Pages\Forms\ProfileOboardingForm.razor"
using Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\acer\source\repos\PSC System\PSC System\Pages\Forms\ProfileOboardingForm.razor"
using Data.DataAccess;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\acer\source\repos\PSC System\PSC System\Pages\Forms\ProfileOboardingForm.razor"
using Data.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\acer\source\repos\PSC System\PSC System\Pages\Forms\ProfileOboardingForm.razor"
using Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/FORMS/ProfileOnboarding")]
    public partial class ProfileOboardingForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Profile Oboarding</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<h4>Setup Your Profile</h4>");
#nullable restore
#line 20 "C:\Users\acer\source\repos\PSC System\PSC System\Pages\Forms\ProfileOboardingForm.razor"
 if (!Contain)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\acer\source\repos\PSC System\PSC System\Pages\Forms\ProfileOboardingForm.razor"
     if (careers is null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<center><p>Loading......</p></center>");
#nullable restore
#line 25 "C:\Users\acer\source\repos\PSC System\PSC System\Pages\Forms\ProfileOboardingForm.razor"
    }

    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(3);
            __builder.AddAttribute(4, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 29 "C:\Users\acer\source\repos\PSC System\PSC System\Pages\Forms\ProfileOboardingForm.razor"
                          CurrentUser

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 29 "C:\Users\acer\source\repos\PSC System\PSC System\Pages\Forms\ProfileOboardingForm.razor"
                                                       SubmitProfile

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "form-group row");
                __builder2.AddMarkupContent(9, "<label for=\"name\">Full Name</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(10);
                __builder2.AddAttribute(11, "id", "name");
                __builder2.AddAttribute(12, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 33 "C:\Users\acer\source\repos\PSC System\PSC System\Pages\Forms\ProfileOboardingForm.razor"
                                                  CurrentUser.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => CurrentUser.Name = __value, CurrentUser.Name))));
                __builder2.AddAttribute(14, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => CurrentUser.Name));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(15, "\r\n\r\n            ");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "form-group row");
                __builder2.AddMarkupContent(18, "<label for=\"name\">Career</label>\r\n                ");
                __Blazor.PSC_System.Pages.Forms.ProfileOboardingForm.TypeInference.CreateInputSelect_0(__builder2, 19, 20, "career", 21, 
#nullable restore
#line 38 "C:\Users\acer\source\repos\PSC System\PSC System\Pages\Forms\ProfileOboardingForm.razor"
                                                      CurrentUser.CID

#line default
#line hidden
#nullable disable
                , 22, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => CurrentUser.CID = __value, CurrentUser.CID)), 23, () => CurrentUser.CID, 24, (__builder3) => {
#nullable restore
#line 39 "C:\Users\acer\source\repos\PSC System\PSC System\Pages\Forms\ProfileOboardingForm.razor"
                     foreach (var career in careers)
                            {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(25, "option");
                    __builder3.AddAttribute(26, "value", 
#nullable restore
#line 41 "C:\Users\acer\source\repos\PSC System\PSC System\Pages\Forms\ProfileOboardingForm.razor"
                                        career.CID

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(27, 
#nullable restore
#line 41 "C:\Users\acer\source\repos\PSC System\PSC System\Pages\Forms\ProfileOboardingForm.razor"
                                                     career.CareerName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 42 "C:\Users\acer\source\repos\PSC System\PSC System\Pages\Forms\ProfileOboardingForm.razor"
                            }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n\r\n            ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "form-group row");
                __builder2.AddMarkupContent(31, "<label for=\"name\">Field</label>\r\n                ");
                __Blazor.PSC_System.Pages.Forms.ProfileOboardingForm.TypeInference.CreateInputSelect_1(__builder2, 32, 33, "field", 34, 
#nullable restore
#line 48 "C:\Users\acer\source\repos\PSC System\PSC System\Pages\Forms\ProfileOboardingForm.razor"
                                                     CurrentUser.FID

#line default
#line hidden
#nullable disable
                , 35, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => CurrentUser.FID = __value, CurrentUser.FID)), 36, () => CurrentUser.FID, 37, (__builder3) => {
#nullable restore
#line 49 "C:\Users\acer\source\repos\PSC System\PSC System\Pages\Forms\ProfileOboardingForm.razor"
                     foreach (var field in fields)
                            {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(38, "option");
                    __builder3.AddAttribute(39, "value", 
#nullable restore
#line 51 "C:\Users\acer\source\repos\PSC System\PSC System\Pages\Forms\ProfileOboardingForm.razor"
                                        field.FID

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(40, 
#nullable restore
#line 51 "C:\Users\acer\source\repos\PSC System\PSC System\Pages\Forms\ProfileOboardingForm.razor"
                                                    field.FieldName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 52 "C:\Users\acer\source\repos\PSC System\PSC System\Pages\Forms\ProfileOboardingForm.razor"
                            }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n\r\n            ");
                __builder2.AddMarkupContent(42, "<div class=\"form-group row\"><button type=\"submit\" class=\" btn btn-primary\"> submit </button></div>");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 60 "C:\Users\acer\source\repos\PSC System\PSC System\Pages\Forms\ProfileOboardingForm.razor"

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\acer\source\repos\PSC System\PSC System\Pages\Forms\ProfileOboardingForm.razor"
     
}
else
{
    NavManager.NavigateTo("/Profile");
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 70 "C:\Users\acer\source\repos\PSC System\PSC System\Pages\Forms\ProfileOboardingForm.razor"
       
    private ProfileModel CurrentUser = new ProfileModel();

    private List<CareerModel> careers;

    private List<FieldsModel> fields;

    private List<ProfileModel> profile;

    private bool Contain;


    protected override async Task OnInitializedAsync()
    {
        profile = await _Pdb.GetProfile();
        careers = await _Cdb.GetCareer();
        fields = await _Fdb.GetField();
        
        Contain = profile.Any(f => f.Id == _User.GetUserId());
    
    }

    private async Task SubmitProfile()
    {

        CurrentUser.Id = _User.GetUserId();
        ProfileModel newUser = new ProfileModel
        {

            Id = _User.GetUserId(),
            Name = CurrentUser.Name,
            CID = CurrentUser.CID,
            FID = CurrentUser.FID,
        };
        await _Pdb.InsertProfile(CurrentUser);

        profile = await _Pdb.GetProfile();
        Contain = profile.Any(f => f.Id == _User.GetUserId());

        if (Contain)
        {
         
                NavManager.NavigateTo("/Profile");
        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserSkillData _USdb { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISkillData _Sdb { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFieldData _Fdb { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICareerData _Cdb { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProfileData _Pdb { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserServices _User { get; set; }
    }
}
namespace __Blazor.PSC_System.Pages.Forms.ProfileOboardingForm
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
