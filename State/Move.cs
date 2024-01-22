using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetClinicPatientMgtProject.BaseClass;
using VetClinicPatientMgtProject.Clinic;

namespace VetClinicPatientMgtProject.State
{
    public class Move : IActionFty
    {

        public void Action(PriorityQueue q, DoublyLinkedList<Pet> processed_q)
        {

            if (q.getHead() == null)
            {

                MenuOperations.Print("No more queue! ");
                MenuOperations.ReturnToMainScreen();
                return;
            }

            Pet pet_from_queue = q.dequeue();

            processed_q.PushBack(pet_from_queue);
            MenuOperations.Print($"move patient is finished");


            MenuOperations.ReturnToMainScreen();
        }//end of method

        public void ChooseAction<T>(string action, T q)
        {

        }

        public void DisplayQueue(PriorityQueue q)
        {

        }

        public void ViewProcessedPatients(DoublyLinkedList<Pet> processed_q)
        {

        }
    }
}
