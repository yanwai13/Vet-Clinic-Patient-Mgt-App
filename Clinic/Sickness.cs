using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetClinicPatientMgtProject.Clinic
{
    public class Sickness
    {
        public string name { get; set; }
        public int severity { get; set; }
        public int time { get; set; }
        public int contagious { get; set; }

        public Sickness(string name, int severity, int time, int contagious)
        {
            this.name = name;
            this.severity = severity;
            this.time = time;
            this.contagious = contagious;
        }



    }
}
