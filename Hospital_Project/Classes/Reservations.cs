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
        private DateTime thedate;
        private int pacientId;
        private int doctorId;

        public int Id { get => id; set => id = value; }
        public DateTime Thedate { get => thedate; set => thedate = value; }
        public int PacientId { get => pacientId; set => pacientId = value; }
        public int DoctorId { get => doctorId; set => doctorId = value; }
    }
}
