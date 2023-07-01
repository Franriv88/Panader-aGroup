using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Panadería {
	public class User {
		public int id { get; set; }
		public string name { get; set; }
		public string lastName { get; set; }
		public string userName { get; set; }
		public string password { get; set; }
		public bool isAdmin { get; set; }
		public bool isDeleted { get; set; }

		public User() {}

        public User(string name, string lastName, string userName, string password, bool isAdmin)
        {
            this.name = name;
            this.lastName = lastName;
            this.userName = userName;
			this.password = password;
            this.isAdmin = isAdmin;
            this.isDeleted = false;
        }

        public User(int id, string name, string lastName, string userName) {
			this.id = id;
			this.name = name;
			this.lastName = lastName;
			this.userName = userName;
			this.isAdmin = false;
			this.isDeleted = false;
		}

		public User(int id, string name, string lastName, string userName, string password, bool isAdmin, bool isDeleted) {
			this.id = id;
			this.name = name;
			this.lastName = lastName;
			this.userName = userName;
			this.password = password;
			this.isAdmin = isAdmin;
			this.isDeleted = isDeleted;
		}

        public string[] toArray()
        {
            return new string[] {
                this.id.ToString(),
                this.name.ToUpper(),
                this.lastName.ToUpper(),
                this.userName.ToUpper(),
                this.isAdmin? "True" : "False"
            };
        }
    }
}
