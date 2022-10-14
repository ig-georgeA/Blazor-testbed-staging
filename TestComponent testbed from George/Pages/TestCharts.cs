using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Component_testbed_from_George.Pages;
using Component_testbed_from_George.Financial;

namespace TestComponent_testbed_from_George
{
	public class TestCharts
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgniteUI.Blazor.Controls.IgbCategoryChartModule),
				typeof(IgniteUI.Blazor.Controls.IgbPieChartModule));
			var mockHttpClient = new MockHttpClient().Create();
			ctx.Services.AddSingleton(new FinancialService(mockHttpClient));
			var componentUnderTest = ctx.RenderComponent<Charts>();
			Assert.NotNull(componentUnderTest);
		}
	}
}