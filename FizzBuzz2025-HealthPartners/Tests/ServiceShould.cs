using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace Tests
{
	[TestClass]
	internal class ServiceShould
	{
		private FBService service;

		public void TestSetup()
		{
			service = new FBService();
		}

		[TestMethod]
		[TestCase(3)]
		[TestCase(10)]
		public void SupportFizz(int fizzNum)
		{
			TestSetup();

			var range = Enumerable.Range(0, 100).Where(x => (x % fizzNum) == 0).ToList();

			range.ForEach(x =>
			{
				var response = service.GetLine(x, fizzNum, 1000);
				Assert.That(response, Is.EqualTo($"{x} Fizz"));
			});
		}

		[TestMethod]
		[TestCase(3)]
		[TestCase(10)]
		public void SupportBuzz(int buzzNum)
		{
			TestSetup();

			var range = Enumerable.Range(0, 100).Where(x => (x % buzzNum) == 0).ToList();

			range.ForEach(x =>
			{
				var response = service.GetLine(x, 1000, buzzNum);
				Assert.That(response, Is.EqualTo($"{x} Buzz"));
			});
		}

		[TestMethod]
		[TestCase(3, 5)]
		[TestCase(10, 1)]
		public void SupportFizzBuzz(int fizzNum, int buzzNum)
		{
			TestSetup();

			var range = Enumerable.Range(0, 100).Where(x => (x % fizzNum) == 0 && (x % buzzNum) == 0).ToList();

			range.ForEach(x =>
			{
				var response = service.GetLine(x, fizzNum, buzzNum);
				Assert.That(response, Is.EqualTo($"{x} FizzBuzz"));
			});
		}
	}
}
