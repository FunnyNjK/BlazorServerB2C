#pragma checksum "C:\Users\tommy\Source\Repos\FunnyNjK\BlazorServerB2C\BlazorServerB2C\BlazorServerB2C\Shared\LoginDisplay.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6bceb3aab7a4109dd9be315455100f8dc8c3c211"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorServerB2C.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\tommy\Source\Repos\FunnyNjK\BlazorServerB2C\BlazorServerB2C\BlazorServerB2C\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tommy\Source\Repos\FunnyNjK\BlazorServerB2C\BlazorServerB2C\BlazorServerB2C\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tommy\Source\Repos\FunnyNjK\BlazorServerB2C\BlazorServerB2C\BlazorServerB2C\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\tommy\Source\Repos\FunnyNjK\BlazorServerB2C\BlazorServerB2C\BlazorServerB2C\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\tommy\Source\Repos\FunnyNjK\BlazorServerB2C\BlazorServerB2C\BlazorServerB2C\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\tommy\Source\Repos\FunnyNjK\BlazorServerB2C\BlazorServerB2C\BlazorServerB2C\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\tommy\Source\Repos\FunnyNjK\BlazorServerB2C\BlazorServerB2C\BlazorServerB2C\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\tommy\Source\Repos\FunnyNjK\BlazorServerB2C\BlazorServerB2C\BlazorServerB2C\_Imports.razor"
using BlazorServerB2C;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\tommy\Source\Repos\FunnyNjK\BlazorServerB2C\BlazorServerB2C\BlazorServerB2C\_Imports.razor"
using BlazorServerB2C.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\tommy\Source\Repos\FunnyNjK\BlazorServerB2C\BlazorServerB2C\BlazorServerB2C\Shared\LoginDisplay.razor"
using Microsoft.AspNetCore.Authentication.AzureADB2C.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tommy\Source\Repos\FunnyNjK\BlazorServerB2C\BlazorServerB2C\BlazorServerB2C\Shared\LoginDisplay.razor"
using Microsoft.Extensions.Options;

#line default
#line hidden
#nullable disable
    public partial class LoginDisplay : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "C:\Users\tommy\Source\Repos\FunnyNjK\BlazorServerB2C\BlazorServerB2C\BlazorServerB2C\Shared\LoginDisplay.razor"
       
    private bool canEditProfile;

    protected override void OnInitialized()
    {
        var options = AzureADB2COptions.Get(AzureADB2CDefaults.AuthenticationScheme);
        canEditProfile = !string.IsNullOrEmpty(options.EditProfilePolicyId);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IOptionsMonitor<AzureADB2COptions> AzureADB2COptions { get; set; }
    }
}
#pragma warning restore 1591
