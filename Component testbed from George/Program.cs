using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Component_testbed_from_George;
using Component_testbed_from_George.Northwind;
using Component_testbed_from_George.Financial;
using IgniteUI.Blazor.Controls;
using ;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<NorthwindService>();
builder.Services.AddScoped<FinancialService>();
RegisterIgniteUI(builder.Services);

await builder.Build().RunAsync();

void RegisterIgniteUI(IServiceCollection services)
{
    services.AddIgniteUIBlazor(
        typeof(IgbNavbarModule),
        typeof(IgbButtonModule),
        typeof(IgbRippleModule),
        typeof(IgbNavDrawerModule),
        typeof(IgbNavDrawerItemModule),
        typeof(IgbTabsModule),
        typeof(IgbCardModule),
        typeof(IgbAvatarModule),
        typeof(IgbExpansionPanelModule),
        typeof(IgbListModule),
        typeof(IgbInputModule),
        typeof(IgbCheckboxModule),
        typeof(IgbCalendarModule),
        typeof(IgbDataGridModule),
        typeof(IgbDataGridToolbarModule),
        typeof(IgbCategoryChartModule),
        typeof(IgbPieChartModule),
        typeof(IgbDatePickerModule),
        typeof(IgbChipModule),
        typeof(IgbSliderModule),
        typeof(IgbRangeSliderModule),
        typeof(IgbSwitchModule),
        typeof(IgbRadioGroupModule),
        typeof(IgbRadioModule),
        typeof(IgbDropdownModule),
        typeof(IgbDropdownItemModule),
        typeof(IgbSnackbarModule)
    );
}