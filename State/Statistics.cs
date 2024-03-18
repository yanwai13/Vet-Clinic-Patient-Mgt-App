using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using VetClinicPatientMgtProject.BaseClass;
using VetClinicPatientMgtProject.Clinic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace VetClinicPatientMgtProject.State
{
    public class Statistics : IActionFty
    {
        List<Pet> _petsCurrentList = new();

        
        public void Action(PriorityQueue q, DoublyLinkedList<Pet> processed_q)
        {

            if (q.getHead() == null)
            {

                MenuOperations.Print("No more queue so No More Statictics ");
                MenuOperations.ReturnToMainScreen();
                return;
            }


            Node<Pet> headNode = q.getPatients().GetHead();

            while (headNode != null)
            {
                Pet pet = headNode.data;
                _petsCurrentList.Add(pet);                
                headNode = headNode.next;

            }

            //loop through the list and make a unique set
            Dictionary<string, int> dailyStatistics = new();          
            foreach (var pet in _petsCurrentList) {

                var year = pet.dateTime.Year;
                var month = pet.dateTime.Month;
                var day = pet.dateTime.Day;

                string compositeKey = $"{day}-{month}-{year}";

                if (!dailyStatistics.ContainsKey(compositeKey))
                {
                    dailyStatistics[compositeKey] = 1;
                }
                else {
                    dailyStatistics[compositeKey]++;
                }

            }

            foreach (var s in dailyStatistics) {
                MenuOperations.Print($"{s.Key} : {s.Value} case(s)");
            }
            MenuOperations.Print($"Show Statistics is finished");


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
