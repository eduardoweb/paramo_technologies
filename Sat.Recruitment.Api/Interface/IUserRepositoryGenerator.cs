using Sat.Recruitment.Api.Models;


namespace Sat.Recruitment.Api.Interface
{
    interface IUserRepositoryGenerator
    {
        Result CreateUser(User newUser);
    }
}

