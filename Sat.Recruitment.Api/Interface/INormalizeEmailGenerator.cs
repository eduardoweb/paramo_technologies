using Sat.Recruitment.Api.Models;

namespace Sat.Recruitment.Api.Interface
{
	interface INormalizeEmailGenerator
	{
		void CreateNormalizeEmail(ref User newUser);
	}
}

