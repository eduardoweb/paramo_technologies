using System;
using System.Collections.Generic;
using System.Diagnostics;
using Sat.Recruitment.Api.Interface;
using Sat.Recruitment.Api.Service;

namespace Sat.Recruitment.Api.Models
{
    internal class CreateGeneratorUser : IUserRepositoryGenerator
    {
        private readonly List<User> _users = new List<User>();

        public Result CreateUser(User newUser)
        {
            try
            {

                ReadDataService readDataService = new ReadDataService(new ReadDataFronTxtFile());
                var reader = readDataService.ReadDataTxt();

                var errors = "";
                var IsSuccess = "";

                while (reader.Peek() >= 0)
                {
                    var line = reader.ReadLineAsync().Result;
                    var user = new User
                    {
                        Name = line.Split(',')[0].ToString(),
                        Email = line.Split(',')[1].ToString(),
                        Phone = line.Split(',')[2].ToString(),
                        Address = line.Split(',')[3].ToString(),
                        UserType = line.Split(',')[4].ToString(),
                        Money = decimal.Parse(line.Split(',')[5].ToString()),
                    };
                    _users.Add(user);
                }
                reader.Close();

                var isDuplicated = false;
                foreach (var user in _users)
                {
                    if (user.Email == newUser.Email
                        ||
                        user.Phone == newUser.Phone)
                    {
                        isDuplicated = true;
                    }
                    else if (user.Name == newUser.Name)
                    {
                        if (user.Address == newUser.Address)
                        {
                            IsSuccess = "false";
                            throw new Exception("User is duplicated");
                        }

                    }
                }

                if (!isDuplicated)
                {

                    IsSuccess = "true";
                    errors = "User Created";
                    Debug.WriteLine("User Created");

                }
                else
                {
                    IsSuccess = "false";
                    errors = "The user is duplicated";
                    Debug.WriteLine("The user is duplicated");

                }


                return new Result()
                {
                    IsSuccess = IsSuccess,
                    Errors = errors
                };

            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                throw;

            }
        }
    }
}

