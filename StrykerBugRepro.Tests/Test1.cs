using StrykerBugRepro.ViewModels;

namespace StrykerBugRepro.Tests;

[TestClass]
public sealed class Test1
{
	[TestMethod]
	public void TestMethod1()
	{
		var sut = new MainViewModel();

		var result = sut.DoSomething();

		Assert.IsTrue(result);
	}
}
