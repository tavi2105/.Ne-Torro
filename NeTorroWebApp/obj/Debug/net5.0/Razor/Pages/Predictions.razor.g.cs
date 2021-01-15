#pragma checksum "C:\Users\Bianca\Desktop\Net\.Ne-Torro\NeTorroWebApp\Pages\Predictions.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8296308884bd88cf0584b9c529ccd6117cc34f5"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h1>Company stock price predictions</h1>");
#nullable restore
#line 9 "C:\Users\Bianca\Desktop\Net\.Ne-Torro\NeTorroWebApp\Pages\Predictions.razor"
 if (predictions == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p class=\"predictions\"><em>Loading predictions...</em></p>");
#nullable restore
#line 12 "C:\Users\Bianca\Desktop\Net\.Ne-Torro\NeTorroWebApp\Pages\Predictions.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "style", " height:800px;overflow-y:scroll");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table");
            __builder.AddMarkupContent(6, @"<thead><tr><th>CompanyName</th>
                <th>Date</th>
                <th>LowPrice</th>
                <th>HighPrice</th>
                <th>OpenPrice</th>
                <th>ClosePrice</th>
                <th>Volume</th></tr></thead>
        ");
            __builder.OpenElement(7, "tbody");
#nullable restore
#line 30 "C:\Users\Bianca\Desktop\Net\.Ne-Torro\NeTorroWebApp\Pages\Predictions.razor"
             foreach (var prediction in predictions)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "tr");
            __builder.OpenElement(9, "td");
            __builder.AddAttribute(10, "class", "text-primary");
            __builder.AddAttribute(11, "style", "cursor:pointer");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\Bianca\Desktop\Net\.Ne-Torro\NeTorroWebApp\Pages\Predictions.razor"
                                                                                () => NavigateToCompany(prediction.CompanyId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(13, 
#nullable restore
#line 33 "C:\Users\Bianca\Desktop\Net\.Ne-Torro\NeTorroWebApp\Pages\Predictions.razor"
                                                                                                                                 prediction.CompanyName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                    ");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 34 "C:\Users\Bianca\Desktop\Net\.Ne-Torro\NeTorroWebApp\Pages\Predictions.razor"
                         prediction.Date

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 35 "C:\Users\Bianca\Desktop\Net\.Ne-Torro\NeTorroWebApp\Pages\Predictions.razor"
                         prediction.LowPrice

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                    ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 36 "C:\Users\Bianca\Desktop\Net\.Ne-Torro\NeTorroWebApp\Pages\Predictions.razor"
                         prediction.HighPrice

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.OpenElement(24, "td");
            __builder.AddContent(25, 
#nullable restore
#line 37 "C:\Users\Bianca\Desktop\Net\.Ne-Torro\NeTorroWebApp\Pages\Predictions.razor"
                         prediction.OpenPrice

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                    ");
            __builder.OpenElement(27, "td");
            __builder.AddContent(28, 
#nullable restore
#line 38 "C:\Users\Bianca\Desktop\Net\.Ne-Torro\NeTorroWebApp\Pages\Predictions.razor"
                         prediction.ClosePrice

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                    ");
            __builder.OpenElement(30, "td");
            __builder.AddContent(31, 
#nullable restore
#line 39 "C:\Users\Bianca\Desktop\Net\.Ne-Torro\NeTorroWebApp\Pages\Predictions.razor"
                         prediction.Volume

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 41 "C:\Users\Bianca\Desktop\Net\.Ne-Torro\NeTorroWebApp\Pages\Predictions.razor"

            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(32, "button");
            __builder.AddAttribute(33, "class", "btn btn-primary");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "C:\Users\Bianca\Desktop\Net\.Ne-Torro\NeTorroWebApp\Pages\Predictions.razor"
                                               ShowAddPopup

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(35, " Add");
            __builder.CloseElement();
#nullable restore
#line 49 "C:\Users\Bianca\Desktop\Net\.Ne-Torro\NeTorroWebApp\Pages\Predictions.razor"
    /*
    <EditForm Model="@prediction" OnValidSubmit="@OnInitializedAsync">
        <DataAnnotationsValidator />
        <ValidationSummary />
        <div class="form-group">
            <label for="Name">Name</label>
            <InputString id="Expense" class="form-control" @bind-Value="prediction.CompanyName" />
        </div>
        <div class="container btn-group">
            <div class="row">
                <div class="col text-center">
                    <button class="btn btn-primary ">Centered button</button>
                </div>
            </div>
        </div>
    </EditForm>*/
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(36, "<style>\r\n        .predictions {\r\n            color: white;\r\n        }\r\n\r\n        .table {\r\n            color: whitesmoke;\r\n        }\r\n    </style>");
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
