using System;

namespace DynamicFormLoading
{
    public class Customer: IFormObject
    {
        public Customer()
        {}

        public Customer(string name, int customerId, string email, bool onEmailList, string username, string password, string address, DateTime birthday)
        {
            this.Name = name;
            this.CustomerId = customerId;
            this.Email = email;
            this.OnEmailList = onEmailList;
            this.Username = username;
            this.Password = password;
            this.Address = address;
            this.Birthday = birthday;
        }

        public string Name { get; set; }
        public int CustomerId { get; set; }
        public string Email  { get; set; }
        public bool OnEmailList { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public DateTime Birthday { get; set; }
    

        public int NumberOfProperties { get; set; }

        public ReflectedObject GetProperties()
        {
            var newMirror = new Mirror();
            return newMirror.GetReflectedObject(this);
        }
    }
}
