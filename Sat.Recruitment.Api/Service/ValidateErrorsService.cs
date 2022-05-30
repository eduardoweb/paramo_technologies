using Sat.Recruitment.Api.Interface;
using Sat.Recruitment.Api.Models;

namespace Sat.Recruitment.Api.Service
{
	internal class ValidateErrorsService
	{
		private readonly IValidateErrorsGenerator _validateErrorsGenerator;


		public ValidateErrorsService(IValidateErrorsGenerator validateErrorsGenerator)
		{
			_validateErrorsGenerator = validateErrorsGenerator;
		}

		public void GenerateValidateErrors(User newUser, ref string errors)
        {
			_validateErrorsGenerator.CreateValidateErrors(newUser, ref errors);

		}
	}
}

