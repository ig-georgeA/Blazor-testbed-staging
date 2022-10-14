using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Component_testbed_from_George.Pages;

namespace TestComponent_testbed_from_George
{
	public class TestLayouts
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor();
			var componentUnderTest = ctx.RenderComponent<Layouts>();
			Assert.NotNull(componentUnderTest);
		}
	}
}