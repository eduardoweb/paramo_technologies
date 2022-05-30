using System;
using Sat.Recruitment.Api.Interface;

namespace Sat.Recruitment.Api.Models
{
	internal class ValidateGeneratorErrors : IValidateErrorsGenerator
    {
        public void CreateValidateErrors(User newUser, ref string errors)
        {
            try
            {
                if (newUser.Name == "")
                    errors = "The name is required";
                if (newUser.Email == "")
                    errors = errors + " The email is required";
                if (newUser.Address == "")
                    errors = errors + " The address is required";
                if (newUser.Phone == "")
                    errors = errors + " The phone is required";
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                throw;

            }
        }
    
    }
}

