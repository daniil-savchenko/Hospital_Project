using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Project.Classes
{
    internal class Work
    {
        private string workerName;
        private string phone;
        private string email;
        private int Position;
        private double salary;

        public string WorkerName { get => workerName; set => workerName = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public int Position1 { get => Position; set => Position = value; }
        public double Salary { get => salary; set => salary = value; }
    }
}
