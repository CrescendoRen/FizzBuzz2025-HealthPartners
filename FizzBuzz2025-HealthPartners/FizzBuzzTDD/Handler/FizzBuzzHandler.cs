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
			throw new NotImplementedException();
		}
	}
}
