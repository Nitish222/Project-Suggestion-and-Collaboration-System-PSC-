// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace PSC_System.Pages.Forms
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
#line 3 "C:\Users\njasw\OneDrive\Desktop\Desktop Dev\PSC System\PSC System\Pages\Forms\CollaborationForm.razor"
using Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\njasw\OneDrive\Desktop\Desktop Dev\PSC System\PSC System\Pages\Forms\CollaborationForm.razor"
using Data.DataAccess;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\njasw\OneDrive\Desktop\Desktop Dev\PSC System\PSC System\Pages\Forms\CollaborationForm.razor"
using Data.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\njasw\OneDrive\Desktop\Desktop Dev\PSC System\PSC System\Pages\Forms\CollaborationForm.razor"
using Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/CollaborationForm")]
    public partial class CollaborationForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 64 "C:\Users\njasw\OneDrive\Desktop\Desktop Dev\PSC System\PSC System\Pages\Forms\CollaborationForm.razor"
       

    private List<CollaborationModel> Team;

    private List<UserSkillJoinModel> userSkills;

    private List<ProjectSkillsModel> projectSkills;

    private List<UserProjectModel> userprojects;

    private List<CollaborationModel> potentialusers;

    private CollaborationModel AddSugestionUser;

    private float SkillRelevanceScore;

    private float SkillScore = 0;

    private float CurrentProjectScore = 100;

    private CollaborationMLModel MLModel { get; set; }

    private List<ProfileModel> profiles;

    private List<CollaborationMLModel> InputList = new List<CollaborationMLModel>();

    private List<MLComparisonModel> OutputList = new List<MLComparisonModel>();

    private MLModel1.ModelOutput result;

    private IEnumerable<MLComparisonModel> finalOut;

    private List<ProfileModel> suggestedProfile = new List<ProfileModel>();

    //get if user has a project in either User projects or Collaboration

    //assign score

    //pass to ML model
    //Load sample data
    private float score;

    protected override async Task OnInitializedAsync()
    {
        Team = await _Coldb.GetTeam();
        userSkills = await _USdb.GetSkills();
        userprojects = await _UserProjdb.GetUserProject(_User.GetUserId());
        UserProjectModel proj = new UserProjectModel();
        profiles = await _Pdb.GetProfile();
        if (userprojects is null)
        {

        }
        else
        {
            proj = userprojects.Find(f => f.Id == _User.GetUserId());
        }

        if (proj is null)
        {

        }
        else
        {
            projectSkills = await _ProjSkillDb.GetProjectSkills(proj.UPID);
        }

        potentialusers = await _Coldb.GetTeam();

        await assignSkillScore();

        if (InputList is null)
        {

        }
        else
        {
            foreach (var user in InputList)
            {
                var sampleData = new MLModel1.ModelInput()
                {
                    Id = user.Id,
                    User_ID = user.UserID,
                    Current_Project = user.CurrentProject,
                    Skill_Relevance = user.SkillRelevance,
                    Skill_Score = user.SkillScore,
                };

                result = MLModel1.Predict(sampleData);

                score = result.Score;
                OutputList.Add(
                        new MLComparisonModel
                        {
                            Id = user.UserID,
                            score = score
                        }
                );

            }
            var sortedOutput = OutputList.OrderByDescending(x => x.score);

            var recommendationUser = sortedOutput.Take(3);

            finalOut = recommendationUser;
        }


    }

    private async Task assignSkillScore()
    {
        if (userSkills is null)
        {

        }
        else
        {
            foreach (var user in userSkills)
            {

                if (projectSkills is null)
                {

                }
                else
                {
                    //+50 for each skill
                    foreach (var currprojectskills in projectSkills)
                    {
                        if (user.SID == currprojectskills.SID)
                        {
                            SkillScore += 50;

                            InputList.Add(new CollaborationMLModel
                            {
                                CurrentProject = CurrentProjectScore,
                                SkillRelevance = SkillRelevanceScore,
                                SkillScore = SkillScore,
                                UserID = user.Id,

                            });
                        }
                    }
                }

            }
        }


    }


    private async Task AddSuggestion(string Id,MouseEventArgs args)
    {
        CollaborationModel col = new CollaborationModel
        {
            Id = Id,
            UPID = userprojects.First().UPID,
        };

        await _Coldb.InsertCollaboration(col);

        NavManager.NavigateTo("/ProjectStatus");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProjectSkillData _ProjSkillDb { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICollaborationData _Coldb { get; set; }
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
