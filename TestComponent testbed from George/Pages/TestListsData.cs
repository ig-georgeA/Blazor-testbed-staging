using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Component_testbed_from_George.Pages;
using Component_testbed_from_George.Northwind;

namespace TestComponent_testbed_from_George
{
	public class TestListsData
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgniteUI.Blazor.Controls.IgbCardModule),
				typeof(IgniteUI.Blazor.Controls.IgbListModule),
				typeof(IgniteUI.Blazor.Controls.IgbAvatarModule));
			var mockHttpClient = new MockHttpClient().Create();
			ctx.Services.AddSingleton(new NorthwindService(mockHttpClient));
			var componentUnderTest = ctx.RenderComponent<ListsData>();
			Assert.NotNull(componentUnderTest);
		}
	}
}