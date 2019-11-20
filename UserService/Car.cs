using System;
using System.Collections.Generic;
using System.Text;

namespace UserService
{
	public class Car
	{
		private string name;
		private string brandname;
		private int price;
		private int year;

		public Car(string name,string brandname, int price, int year)
		{
			this.name = name;
			this.brandname = brandname;
			this.price = price;
			this.year = year;
		}
	}
}
