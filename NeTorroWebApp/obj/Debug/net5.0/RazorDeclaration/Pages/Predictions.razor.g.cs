// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace NeTorroWebApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Bianca\Desktop\Net\.Ne-Torro\NeTorroWebApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bianca\Desktop\Net\.Ne-Torro\NeTorroWebApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Bianca\Desktop\Net\.Ne-Torro\NeTorroWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Bianca\Desktop\Net\.Ne-Torro\NeTorroWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Bianca\Desktop\Net\.Ne-Torro\NeTorroWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Bianca\Desktop\Net\.Ne-Torro\NeTorroWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Bianca\Desktop\Net\.Ne-Torro\NeTorroWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Bianca\Desktop\Net\.Ne-Torro\NeTorroWebApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Bianca\Desktop\Net\.Ne-Torro\NeTorroWebApp\_Imports.razor"
using NeTorroWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Bianca\Desktop\Net\.Ne-Torro\NeTorroWebApp\_Imports.razor"
using NeTorroWebApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Bianca\Desktop\Net\.Ne-Torro\NeTorroWebApp\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Bianca\Desktop\Net\.Ne-Torro\NeTorroWebApp\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Bianca\Desktop\Net\.Ne-Torro\NeTorroWebApp\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bianca\Desktop\Net\.Ne-Torro\NeTorroWebApp\Pages\Predictions.razor"
using Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Bianca\Desktop\Net\.Ne-Torro\NeTorroWebApp\Pages\Predictions.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/predictions")]
    public partial class Predictions : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 68 "C:\Users\Bianca\Desktop\Net\.Ne-Torro\NeTorroWebApp\Pages\Predictions.razor"
           
private List<Prediction> predictions;
    private Prediction prediction = new Prediction();
    [CascadingParameter] BlazoredModalInstance ModalInstance { get; set; }


    protected override async Task OnInitializedAsync()
    {
        predictions = await PredictionService.GetPredictions();
    }

    public void NavigateToCompany(int id)
    {
        NavManager.NavigateTo("/company/" + id);
    }

    private bool IsModalClosed = true;

    private async Task ShowAddPopup()
    {
        if (IsModalClosed)
        {
            var modal = Modal.Show<CreatePredPopup>("Add Data Stock");
            IsModalClosed = false;
            var result = await modal.Result;
            IsModalClosed = true;
        }
    }

    private async Task ShowEditPopup(int id)
    {

        if (IsModalClosed)
        {
            var parameters = new ModalParameters();
            parameters.Add(nameof(Finance.Id), id);

            var modal = Modal.Show<CreatePredPopup>("Update Finance", parameters);
            IsModalClosed = false;
            var result = await modal.Result;
            IsModalClosed = true;
        }
    }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModalService Modal { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPredictionService PredictionService { get; set; }
    }
}
#pragma warning restore 1591
