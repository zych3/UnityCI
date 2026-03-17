using NUnit.Framework;

public class SampleTests
{
	[Test]
	public void Addition_WorksCorrectly()
	{
		var result = 2 + 2;
		Assert.AreEqual(4, result);
	}

	[Test]
	public void String_Contains_Works()
	{
		var text = "hello unity ci";
		Assert.IsTrue(text.Contains("unity"));
	}
}
