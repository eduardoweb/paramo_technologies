using Sat.Recruitment.Api.Models;

namespace Sat.Recruitment.Api.Interface
{
	interface IValidateErrorsGenerator
	{
		void CreateValidateErrors(User newUser, ref string errors);
	}
}

