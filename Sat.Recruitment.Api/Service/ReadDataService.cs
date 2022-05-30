using Sat.Recruitment.Api.Interface;
using System.IO;

namespace Sat.Recruitment.Api.Service
{
	internal class ReadDataService
	{
		private readonly IReadDataGenerator _readDataGenerator;


		public ReadDataService(IReadDataGenerator readDataGenerator)
		{
			_readDataGenerator = readDataGenerator;
		}

		public StreamReader ReadDataTxt()
        {
			return _readDataGenerator.ReadDataTxt();

		}
	}
}

