using Sat.Recruitment.Api.Interface;
using Sat.Recruitment.Api.Models;

namespace Sat.Recruitment.Api.Service
{
	internal class CalculateGitService
	{
		private readonly ICalculateGitGenerator _calculateGitGenerator;


		public CalculateGitService(ICalculateGitGenerator calculateGitGenerator)
		{
			_calculateGitGenerator = calculateGitGenerator;
		}

		public void GenerateCalcule(ref User newUser)
        {
			_calculateGitGenerator.CreateCalculate(ref newUser);

		}
	}
}

