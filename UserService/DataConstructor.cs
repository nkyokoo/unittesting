using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace UserService
{
	public class DataConstructor
	{
		public Boolean ConvertCarData(string json)
		{
			try
			{
				Cars car = JsonConvert.DeserializeObject<Cars>(json);
				
				return true;
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				return false;
			}
		}

		public Boolean ConvertUser(String json)
		{
			try
			{
				
				User users = JsonConvert.DeserializeObject<User>(json);

				return true;
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				return false;
			}		
		}
	}
}
