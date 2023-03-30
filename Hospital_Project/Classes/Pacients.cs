using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Project.Classes
{
    public class Pacients
    {
        private int id;
        private string pacName;
        private string phone;
        private string egn;
        private string Parent;
        private string Doctor;

        public Pacients() { }

        public int Id { get => id; set => id = value; }
        public string PacName { get => pacName; set => pacName = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Egn { get => egn; set => egn = value; }
        public string Parent1 { get => Parent; set => Parent = value; }
        public string Doctor1 { get => Doctor; set => Doctor = value; }
    }
}
