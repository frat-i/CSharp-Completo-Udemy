using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExFixacaoEnum.Entities
{
    internal class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateOnly DateBirth { get; set; }

        public Client()
        {

        }

        public Client(string name, string email, DateOnly dateBirth)
        {
            Name = name;
            Email = email;
            DateBirth = dateBirth;
        }

        public override string ToString()
        {
            return Name +
                   ", " +
                   DateBirth.ToString("dd/MM/yyyy") +
                   ", " +
                   Email;

        }
    }
}
