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
#line 1 "C:\Users\bpantaru\Desktop\Bianca\.Ne-Torro\NeTorroWebApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bpantaru\Desktop\Bianca\.Ne-Torro\NeTorroWebApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\bpantaru\Desktop\Bianca\.Ne-Torro\NeTorroWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\bpantaru\Desktop\Bianca\.Ne-Torro\NeTorroWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\bpantaru\Desktop\Bianca\.Ne-Torro\NeTorroWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\bpantaru\Desktop\Bianca\.Ne-Torro\NeTorroWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\bpantaru\Desktop\Bianca\.Ne-Torro\NeTorroWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\bpantaru\Desktop\Bianca\.Ne-Torro\NeTorroWebApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\bpantaru\Desktop\Bianca\.Ne-Torro\NeTorroWebApp\_Imports.razor"
using NeTorroWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\bpantaru\Desktop\Bianca\.Ne-Torro\NeTorroWebApp\_Imports.razor"
using NeTorroWebApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\bpantaru\Desktop\Bianca\.Ne-Torro\NeTorroWebApp\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\bpantaru\Desktop\Bianca\.Ne-Torro\NeTorroWebApp\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\bpantaru\Desktop\Bianca\.Ne-Torro\NeTorroWebApp\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bpantaru\Desktop\Bianca\.Ne-Torro\NeTorroWebApp\Pages\FinancialStatement.razor"
using Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\bpantaru\Desktop\Bianca\.Ne-Torro\NeTorroWebApp\Pages\FinancialStatement.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/finances")]
    public partial class FinancialStatement : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "C:\Users\bpantaru\Desktop\Bianca\.Ne-Torro\NeTorroWebApp\Pages\FinancialStatement.razor"
       
    private List<Finance> finances;
    private bool IsModalClosed = true;
    protected override async Task OnInitializedAsync()
    {
        finances = await FinanceService.GetFinancialStatement();
    }
    private async Task ShowAddPopup()
    {
        if (IsModalClosed)
        {
            var modal = Modal.Show<CreateFinancePopup>("Add Finance");
            IsModalClosed = false;
            var result = await modal.Result;
            finances = await FinanceService.GetFinancialStatement();
            IsModalClosed = true;
        }
    }

    private async Task ShowEditPopup(int id)
    {

        if (IsModalClosed)
        {
            var parameters = new ModalParameters();
            parameters.Add(nameof(Finance.Id), id);

            var modal = Modal.Show<UpdateFinancePopup>("Update Finance", parameters);
            IsModalClosed = false;
            var result = await modal.Result;
            finances = await FinanceService.GetFinancialStatement();
            IsModalClosed = true;
        }
    }

    private void DeleteResource(int id)
    {
        FinanceService.DeleteFinancialStatement(id);
        finances.RemoveAll(r => r.Id == id);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModalService Modal { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFinanceService FinanceService { get; set; }
    }
}
#pragma warning restore 1591
