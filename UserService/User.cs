using System;
using System.Collections.Generic;
using System.Text;

namespace UserService
{
	public class User
	{
		private string userid;
		private string username;
		private string email;
		private int usergroup;
		
		public User(string userid,string username, string email, int usergroup)
		{
			this.userid = userid;
			this.username = username;
			this.email = email;
			this.usergroup = usergroup;
		}
	}
}
