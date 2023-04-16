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
        private string email { get; set; }
        private string password;
        private string lastName { get; set; }
        private string firstName { get; set; }
        private string phone { get; set; }
        private string adress { get; set; }
        private string creditCard { get; set; }
        private string fidelite { get; set; }
        private bool isAdmin { get; set; }

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
