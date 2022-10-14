using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Component_testbed_from_George.Pages;

namespace TestComponent_testbed_from_George
{
	public class TestExpansionPanels
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgniteUI.Blazor.Controls.IgbCardModule),
				typeof(IgniteUI.Blazor.Controls.IgbAvatarModule),
				typeof(IgniteUI.Blazor.Controls.IgbButtonModule),
				typeof(IgniteUI.Blazor.Controls.IgbRippleModule),
				typeof(IgniteUI.Blazor.Controls.IgbExpansionPanelModule),
				typeof(IgniteUI.Blazor.Controls.IgbListModule),
				typeof(IgniteUI.Blazor.Controls.IgbInputModule),
				typeof(IgniteUI.Blazor.Controls.IgbCheckboxModule));
			var componentUnderTest = ctx.RenderComponent<ExpansionPanels>();
			Assert.NotNull(componentUnderTest);
		}
	}
}