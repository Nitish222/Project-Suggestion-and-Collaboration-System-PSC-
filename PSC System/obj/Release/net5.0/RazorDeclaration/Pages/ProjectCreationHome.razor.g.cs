// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace PSC_System.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\njasw\OneDrive\Desktop\Desktop Dev\PSC System\PSC System\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\njasw\OneDrive\Desktop\Desktop Dev\PSC System\PSC System\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\njasw\OneDrive\Desktop\Desktop Dev\PSC System\PSC System\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\njasw\OneDrive\Desktop\Desktop Dev\PSC System\PSC System\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\njasw\OneDrive\Desktop\Desktop Dev\PSC System\PSC System\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\njasw\OneDrive\Desktop\Desktop Dev\PSC System\PSC System\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\njasw\OneDrive\Desktop\Desktop Dev\PSC System\PSC System\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\njasw\OneDrive\Desktop\Desktop Dev\PSC System\PSC System\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\njasw\OneDrive\Desktop\Desktop Dev\PSC System\PSC System\_Imports.razor"
using PSC_System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\njasw\OneDrive\Desktop\Desktop Dev\PSC System\PSC System\_Imports.razor"
using PSC_System.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\njasw\OneDrive\Desktop\Desktop Dev\PSC System\PSC System\Pages\ProjectCreationHome.razor"
using Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\njasw\OneDrive\Desktop\Desktop Dev\PSC System\PSC System\Pages\ProjectCreationHome.razor"
using Data.DataAccess;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\njasw\OneDrive\Desktop\Desktop Dev\PSC System\PSC System\Pages\ProjectCreationHome.razor"
using Data.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\njasw\OneDrive\Desktop\Desktop Dev\PSC System\PSC System\Pages\ProjectCreationHome.razor"
using Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ProjectHome")]
    public partial class ProjectCreationHome : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 80 "C:\Users\njasw\OneDrive\Desktop\Desktop Dev\PSC System\PSC System\Pages\ProjectCreationHome.razor"
       
    private List<ProjectModel> projectsList;

    private ProjectSuggestionModel Selectedsuggestion = new ProjectSuggestionModel();

    private ProfileModel currUser = new ProfileModel();

    private List<ProfileModel> profile;

    private List<ProjectModel> suggestions = new List<ProjectModel>();

    private List<UserProjectModel> currentProj;

    private int time;

    private bool contains;

    private bool showSuggestion = false;

    private string message;

    private int teamMemberCount=0;

    protected override async Task OnInitializedAsync()
    {
        projectsList = await _ProjDb.GetProject();
        profile = await _Pdb.GetProfile();
        currentProj = await _UserProjdb.GetUserProject(_User.GetUserId());

        contains = currentProj.Any(f => f.Id == _User.GetUserId());
        if (profile is null)
        {
        }
        else
        {
            currUser = profile.Find(f => f.Id == _User.GetUserId());
        }

        if (projectsList is null)
        {
            message = "nothing in Project List ";
        }
        else
        {
            foreach (var proj in projectsList)
            {
                if (currUser.FID == proj.FID)
                {
                    suggestions.Add(new ProjectModel
                    {
                        FID = proj.FID,
                        PID = proj.PID,
                        ProjectName = proj.ProjectName,
                    });
                }
            }
        }

    }

    private async Task StartProject()
    {
        UserProjectModel newProj = new UserProjectModel
        {
            Id = _User.GetUserId(),
            PTIME = Selectedsuggestion.PTIME,
            PID = Selectedsuggestion.PID,
        };

        await _UserProjdb.InsertUserProject(newProj);


        NavManager.NavigateTo("/CollaborationForm");

    }

    private async Task AddSuggestion()
    {
        time = Selectedsuggestion.PTIME;
        showSuggestion = true;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserProjectData _UserProjdb { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProjectData _ProjDb { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserSkillData _USdb { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISkillData _Sdb { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFieldData _Fdb { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICareerData _Cdb { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProfileData _Pdb { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserServices _User { get; set; }
    }
}
#pragma warning restore 1591
