using System;
using Sat.Recruitment.Api.Interface;
namespace Sat.Recruitment.Api.Models
{
	internal class NormalizeGeneratorEmail : INormalizeEmailGenerator
    {
        public void CreateNormalizeEmail(ref User newUser)
        {
            try
            {
                var aux = newUser.Email.Split(new char[] { '@' }, StringSplitOptions.RemoveEmptyEntries);

                var atIndex = aux[0].IndexOf("+", StringComparison.Ordinal);

                aux[0] = atIndex < 0 ? aux[0].Replace(".", "") : aux[0].Replace(".", "").Remove(atIndex);

                newUser.Email = string.Join("@", new string[] { aux[0], aux[1] });
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                throw;

            }
        }
    
    }
}

