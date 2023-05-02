using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Project.Classes
{
    internal class Positions
    {
        private int id;
        private string posName;

        public Positions() { }

        public string PosName { get => posName; set => posName = value; }
        public int ID { get => id; set => id = value; }
    }
}
