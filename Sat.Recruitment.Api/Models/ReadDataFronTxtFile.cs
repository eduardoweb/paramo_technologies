using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using Sat.Recruitment.Api.Interface;

namespace Sat.Recruitment.Api.Models
{
	internal class ReadDataFronTxtFile : IReadDataGenerator
    {
        public StreamReader ReadDataTxt()
        {
            try
            {
                var pathFile = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
                var _file = pathFile.GetSection("PathFile").Value;

                var path = Directory.GetCurrentDirectory() + _file;

                FileStream fileStream = new FileStream(path, FileMode.Open);

                StreamReader reader = new StreamReader(fileStream);
                return reader;
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                throw;

            }
        }
    
    }
}

