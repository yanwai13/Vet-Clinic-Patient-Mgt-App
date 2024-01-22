using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetClinicPatientMgtProject.BaseClass;
using VetClinicPatientMgtProject.Clinic;

namespace VetClinicPatientMgtProject.State
{
    public interface IActionFty
    {
        public void Action(PriorityQueue q, DoublyLinkedList<Pet> processed_q);
        public void DisplayQueue(PriorityQueue q);
        public void ViewProcessedPatients(DoublyLinkedList<Pet> processed_q);
    }
}
