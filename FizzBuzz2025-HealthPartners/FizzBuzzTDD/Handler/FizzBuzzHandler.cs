using FizzBuzzTDD.Service;

namespace FizzBuzzTDD.Handler
{
	public class FizzBuzzHandler : IFizzBuzzHandler
	{
		private readonly IFBService fbService;

		public FizzBuzzHandler(IFBService fbService)
		{
			this.fbService = fbService;
		}

		public string RunFizzBuzz(int startVal, int endVal, int fizzNum, int buzzNum)
		{
			var output = string.Empty;

			for (var i = startVal; i <= endVal; i++)
			{
				output = output + fbService.GetLine(i, fizzNum, buzzNum);

				if (i != endVal)
				{
					output = output + "\n";
				}
			}

			return output;
		}
	}
}
