#pragma checksum "D:\Univeristy\Projects\SEM2_DNP\RiderProjects\DNP1ExamPreparation[293141]\DNPExamPreparation1\VolumeWeb\Pages\AllVolumeCalculations.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "679261c2f2845586bf1a71496ad4051bc941b504"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace DNPExamPreparation1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Univeristy\Projects\SEM2_DNP\RiderProjects\DNP1ExamPreparation[293141]\DNPExamPreparation1\VolumeWeb\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Univeristy\Projects\SEM2_DNP\RiderProjects\DNP1ExamPreparation[293141]\DNPExamPreparation1\VolumeWeb\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Univeristy\Projects\SEM2_DNP\RiderProjects\DNP1ExamPreparation[293141]\DNPExamPreparation1\VolumeWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Univeristy\Projects\SEM2_DNP\RiderProjects\DNP1ExamPreparation[293141]\DNPExamPreparation1\VolumeWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Univeristy\Projects\SEM2_DNP\RiderProjects\DNP1ExamPreparation[293141]\DNPExamPreparation1\VolumeWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Univeristy\Projects\SEM2_DNP\RiderProjects\DNP1ExamPreparation[293141]\DNPExamPreparation1\VolumeWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Univeristy\Projects\SEM2_DNP\RiderProjects\DNP1ExamPreparation[293141]\DNPExamPreparation1\VolumeWeb\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Univeristy\Projects\SEM2_DNP\RiderProjects\DNP1ExamPreparation[293141]\DNPExamPreparation1\VolumeWeb\_Imports.razor"
using DNPExamPreparation1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Univeristy\Projects\SEM2_DNP\RiderProjects\DNP1ExamPreparation[293141]\DNPExamPreparation1\VolumeWeb\_Imports.razor"
using DNPExamPreparation1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Univeristy\Projects\SEM2_DNP\RiderProjects\DNP1ExamPreparation[293141]\DNPExamPreparation1\VolumeWeb\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Univeristy\Projects\SEM2_DNP\RiderProjects\DNP1ExamPreparation[293141]\DNPExamPreparation1\VolumeWeb\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\Univeristy\Projects\SEM2_DNP\RiderProjects\DNP1ExamPreparation[293141]\DNPExamPreparation1\VolumeWeb\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Univeristy\Projects\SEM2_DNP\RiderProjects\DNP1ExamPreparation[293141]\DNPExamPreparation1\VolumeWeb\Pages\AllVolumeCalculations.razor"
using DNPExamPreparation1.Data.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Univeristy\Projects\SEM2_DNP\RiderProjects\DNP1ExamPreparation[293141]\DNPExamPreparation1\VolumeWeb\Pages\AllVolumeCalculations.razor"
using DNPExamPreparation1.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/allVolumeCalculations")]
    public partial class AllVolumeCalculations : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "D:\Univeristy\Projects\SEM2_DNP\RiderProjects\DNP1ExamPreparation[293141]\DNPExamPreparation1\VolumeWeb\Pages\AllVolumeCalculations.razor"
       
    private IList<VolumeResult> _allCalculations;
    protected override async Task OnInitializedAsync()
    {
    // Generate the list  
        _allCalculations=await GeometricalFigures.GetAllCalculations();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGeometricalFigures GeometricalFigures { get; set; }
    }
}
#pragma warning restore 1591
