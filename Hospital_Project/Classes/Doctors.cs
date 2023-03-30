using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Project.Classes
{
    internal class Doctors
    {
        private int id;
        private string workerName;
        private string phone;
        private string email;
        private double salary;

        public Doctors() { }

        public int Id { get => id; set => id = value; }
        public string WorkerName { get => workerName; set => workerName = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public double Salary { get => salary; set => salary = value; }
    }
}
