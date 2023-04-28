using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Project.Classes
{
    internal class Reservations
    {
        private int id;
        private string thedate;
        private string pacientId;
        private string doctorId;

        public string Thedate { get => thedate; set => thedate = value; }
        public string PacientId { get => pacientId; set => pacientId = value; }
        public string DoctorId { get => doctorId; set => doctorId = value; }
        public int ID { get => id; set => id = value; }
    }
}
