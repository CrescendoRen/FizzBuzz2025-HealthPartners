namespace FizzBuzzTDD.Service
{
	public class FBService : IFBService
	{
		public string GetLine(int number, int fizzNum, int buzzNum)
		{
			var output = $"{number} ";

			if (number % fizzNum == 0)
				output = output + "Fizz";

			if (number % buzzNum == 0)
				output = output + "Buzz";

			return output;
		}
	}
}
