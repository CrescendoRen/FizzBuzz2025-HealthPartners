using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace Tests
{
	[TestClass]
	internal class HandlerShould
	{
		private Mock<IFBService> mockfbService = new Mock<IFBService>();
		private FizzBuzzHandler handler;

		public void TestSetup()
		{
			handler = new FizzBuzzHandler(mockfbService.Object);
		}

		[TestMethod]
		[TestCase(0, 100)]
		[TestCase(50, 65)]
		public void CallServiceCorrectNumberOfTimes(int startNum, int endNum)
		{
			TestSetup();
			mockfbService.Setup(x => x.GetLine(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>())).Returns("TEST");
			handler.RunFizzBuzz(startNum, endNum, 3, 5);
			mockfbService.Verify(x => x.GetLine(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>()), Times.Exactly(endNum - startNum));
		}

		[TestMethod]
		[TestCase(0, 100)]
		[TestCase(50, 65)]
		public void HaveCorrectNumberOfNewLines(int startNum, int endNum)
		{
			TestSetup();
			mockfbService.Setup(x => x.GetLine(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>())).Returns("TEST");
			var response = handler.RunFizzBuzz(startNum, endNum, 3, 5);
			Assert.That(response.Split('\n').Length, Is.EqualTo(endNum - startNum));
		}
	}
}
