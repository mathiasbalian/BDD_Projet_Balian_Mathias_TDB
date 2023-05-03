using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD_Projet_Balian_Mathias_TDB
{
    public class User
    {
        public string email { get; set; }
        private string password;
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string phone { get; set; }
        public string adress { get; set; }
        public string creditCard { get; set; }
        public string fidelite { get; set; }
        public bool isAdmin { get; set; }

        public User(string email, string password, string lastName,
                    string firstName, string phone, string adress,
                    string creditCard, string fidelite, bool isAdmin)
        {
            this.email = email;
            this.password = password;
            this.lastName = lastName;
            this.firstName = firstName;
            this.phone = phone;
            this.adress = adress;
            this.creditCard = creditCard;
            this.fidelite = fidelite;
            this.isAdmin = isAdmin;
        }

        public User()
        {

        }

        public string toString()
        {
            return $"{this.email} {this.lastName} {this.firstName} {this.phone} {this.adress} {this.creditCard} fidelite :{this.fidelite}| " +
                $"{((isAdmin) ? "Administrateur" : "")}";
        }
    }
}
