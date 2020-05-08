using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.Helpers
{
    // implementacja iterfaców które będą się łączyć oraz interfejs do klonowania
    public class User : IUser, IModel, ICloneable
    {
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int ID { get; set; }

        public User(int id, string name, string login, string password)
        {
            ID = id;
            Login = login;
            Password = password;
            Name = name;
        }

        public object Clone()
        {
            return new User(ID, Name, Login, Password);
        }

        public override string ToString()
        {
            return $"{ID} {Login} {Password} {Name}";
        }
    }
}
