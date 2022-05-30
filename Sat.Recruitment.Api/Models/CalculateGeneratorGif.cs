using System;
using Sat.Recruitment.Api.Interface;

namespace Sat.Recruitment.Api.Models
{
	internal class CalculateGeneratorGif : ICalculateGitGenerator
    {
        public void CreateCalculate(ref User newUser)
        {
            try
            {
                if (newUser.UserType == "Normal")
                {
                    if (newUser.Money > 100)
                    {
                        var percentage = Convert.ToDecimal(0.12);
                        //If new user is normal and has more than USD100
                        var gif = newUser.Money * percentage;
                        newUser.Money = newUser.Money + gif;
                    }
                    if (newUser.Money < 100)
                    {
                        if (newUser.Money > 10)
                        {
                            var percentage = Convert.ToDecimal(0.8);
                            var gif = newUser.Money * percentage;
                            newUser.Money = newUser.Money + gif;
                        }
                    }
                }
                if (newUser.UserType == "SuperUser")
                {
                    if (newUser.Money > 100)
                    {
                        var percentage = Convert.ToDecimal(0.20);
                        var gif = newUser.Money * percentage;
                        newUser.Money = newUser.Money + gif;
                    }
                }
                if (newUser.UserType == "Premium")
                {
                    if (newUser.Money > 100)
                    {
                        var gif = newUser.Money * 2;
                        newUser.Money = newUser.Money + gif;
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                throw;

            }
        }
    
    }
}

