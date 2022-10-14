using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Component_testbed_from_George.Pages;

namespace TestComponent_testbed_from_George
{
	public class TestInputs
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgniteUI.Blazor.Controls.IgbInputModule),
				typeof(IgniteUI.Blazor.Controls.IgbDatePickerModule),
				typeof(IgniteUI.Blazor.Controls.IgbChipModule),
				typeof(IgniteUI.Blazor.Controls.IgbSliderModule),
				typeof(IgniteUI.Blazor.Controls.IgbRangeSliderModule),
				typeof(IgniteUI.Blazor.Controls.IgbButtonModule),
				typeof(IgniteUI.Blazor.Controls.IgbRippleModule),
				typeof(IgniteUI.Blazor.Controls.IgbSwitchModule),
				typeof(IgniteUI.Blazor.Controls.IgbCheckboxModule),
				typeof(IgniteUI.Blazor.Controls.IgbRadioGroupModule),
				typeof(IgniteUI.Blazor.Controls.IgbRadioModule),
				typeof(IgniteUI.Blazor.Controls.IgbAvatarModule));
			var componentUnderTest = ctx.RenderComponent<Inputs>();
			Assert.NotNull(componentUnderTest);
		}
	}
}