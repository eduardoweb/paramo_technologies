using Sat.Recruitment.Api.Interface;
using Sat.Recruitment.Api.Models;

namespace Sat.Recruitment.Api.Service
{
	internal class NormalizeEmailService
	{
		private readonly INormalizeEmailGenerator _normalizeEmailGenerator;


		public NormalizeEmailService(INormalizeEmailGenerator normalizeEmailGenerator)
		{
			_normalizeEmailGenerator = normalizeEmailGenerator;
		}

		public void GenerateNormalizeEmail(ref User newUser)
        {
			_normalizeEmailGenerator.CreateNormalizeEmail(ref newUser);

		}
	}
}

