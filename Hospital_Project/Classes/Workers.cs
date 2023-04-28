using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Project.Classes
{
    internal class Workers
    {
        private int id;
        private string workerName;
        private string phone;
        private string email;
        private string Position;
        private string salary;

        public string WorkerName { get => workerName; set => workerName = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public string Position1 { get => Position; set => Position = value; }
        public string Salary { get => salary; set => salary = value; }
        public int ID { get => id; set => id = value; }
    }
}
