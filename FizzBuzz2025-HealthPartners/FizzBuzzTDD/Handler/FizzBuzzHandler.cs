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
			var getLineMethod = typeof(IFBService).GetMethod("GetLine");

			for (var i = startVal; i <= endVal; i++)
			{
				var getLineRes = (string)getLineMethod.Invoke(fbService, new object[] { i, fizzNum, buzzNum });
				output = output + getLineRes;

				if (i != endVal)
				{
					output = output + "\n";
				}
			}

			return output;
		}
	}
}
