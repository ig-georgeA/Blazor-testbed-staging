using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Component_testbed_from_George.Pages;

namespace TestComponent_testbed_from_George
{
	public class TestDialogsAndOverlays
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgniteUI.Blazor.Controls.IgbButtonModule),
				typeof(IgniteUI.Blazor.Controls.IgbRippleModule),
				typeof(IgniteUI.Blazor.Controls.IgbSnackbarModule));
			var componentUnderTest = ctx.RenderComponent<DialogsAndOverlays>();
			Assert.NotNull(componentUnderTest);
		}
	}
}