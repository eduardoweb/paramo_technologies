
using System;
using Sat.Recruitment.Api.Service;
using Sat.Recruitment.Api.Models;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc; 

namespace Sat.Recruitment.Api.Controllers
{
    [ApiController]
    [Route("api/user")]
    public class UsersController : ControllerBase
    {
        [HttpPost("create")]
        public Result SaveUser(User newUser)
        {
            try
            {
                var client = new HttpClient();

                var errors = "";

                ValidateErrorsService validateErrorsService = new ValidateErrorsService(new ValidateGeneratorErrors());
                validateErrorsService.GenerateValidateErrors(newUser, ref errors);
                if (errors != null && errors != "")
                {
                    return new Result()
                    {
                        IsSuccess = "false",
                        Errors = errors
                    };
                }

                CalculateGitService calculateGitService = new CalculateGitService(new CalculateGeneratorGif());
                calculateGitService.GenerateCalcule(ref newUser);

                NormalizeEmailService normalizeEmailService = new NormalizeEmailService(new NormalizeGeneratorEmail());
                normalizeEmailService.GenerateNormalizeEmail(ref newUser);


                UserRepositoryService userRepositoryService = new UserRepositoryService(new CreateGeneratorUser());
                return userRepositoryService.CreateUser(newUser);

            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                throw;
            }

        }
    }
}
