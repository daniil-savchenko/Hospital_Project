using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Project.Classes
{
    internal class Parents
    {
        private int id;
        private string parName;
        private string phone;
        private string egn;

        public Parents() { }

        public int Id { get => id; set => id = value; }
        public string ParName { get => parName; set => parName = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Egn { get => egn; set => egn = value; }
    }
}
