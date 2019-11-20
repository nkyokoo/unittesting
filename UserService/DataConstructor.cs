﻿using System;
using System.Collections.Generic;
using System.Text;
 using MySql.Data.MySqlClient;

namespace UserService
{
	public class DataConstructor
	{
		private MySqlConnection connection;
		DBConnection db = DBConnection.Instance();
		MySqlCommand command;
		MySqlDataReader dr;
		
		public Boolean ConvertCarData()
		{
			connection = db.Connection;
			command = connection.CreateCommand();
			command.CommandText = "SELECT * FROM cars" ;
			command.ExecuteNonQuery();
			dr = command.ExecuteReader();
			try
			{
				List<Car> carsList = new List<Car>();

				while (dr.Read())
				{
					carsList.Add(new Car(dr.GetString("name"),dr.GetString("brand"),dr.GetInt32("price"),dr.GetInt32("year")));
				}

				Cars cars = new Cars();
				cars._Cars = carsList;
					
				dr.Close();

				return true;
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				return false;
			}
		}

		public Boolean ConvertUser()
		{
			connection = db.Connection;
			command = connection.CreateCommand();
			command.CommandText = "SELECT id,name,email,groupid FROM users" ;
			command.ExecuteNonQuery();
			dr = command.ExecuteReader();
			try
			{
				List<User> userList = new List<User>();

				while (dr.Read())
				{
					userList.Add(new User(dr.GetString("id"), dr.GetString("name"), dr.GetString("email"),
						dr.GetInt32("groupid")));
				}

				Users users = new Users();
				users._Users = userList;

				dr.Close();
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
