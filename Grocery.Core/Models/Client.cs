﻿
namespace Grocery.Core.Models
{
    public partial class Client : Model
    {
        private string emailAddress { get; set; }
        private string _password { get; set; }
        public Client(int id, string name, string emailAddress, string password) : base(id, name)
        {
            emailAddress=emailAddress;
            password=password;
        }
    }
}
