using System;
using System.Collections.Generic;
using System.Text;

namespace UserService
{
	public class User
	{
		public string userid { get; }
		public string username { get; }
		public string email { get; }
		public int usergroup { get; }
		
		public User(string userid,string username, string email, int usergroup)
		{
			this.userid = userid;
			this.username = username;
			this.email = email;
			this.usergroup = usergroup;
		}
	}
}
