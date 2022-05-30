using Sat.Recruitment.Api.Interface;
using Sat.Recruitment.Api.Models;

namespace Sat.Recruitment.Api.Service
{
    internal class UserRepositoryService
    {
        private readonly IUserRepositoryGenerator _userRepositoryGenerator;


        public UserRepositoryService(IUserRepositoryGenerator userRepositoryGenerator)
        {
            _userRepositoryGenerator = userRepositoryGenerator;
        }

        public Result CreateUser(User newUser)
        {
            return _userRepositoryGenerator.CreateUser(newUser);

        }
    }
}

