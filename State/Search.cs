using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetClinicPatientMgtProject.BaseClass;
using VetClinicPatientMgtProject.Clinic;
using VetClinicPatientMgtProject.Validator;

namespace VetClinicPatientMgtProject.State
{
    public class Search : IActionFty
    {
        public void Action(PriorityQueue q, DoublyLinkedList<Pet> processed_q)
        {

            if (q.size() == 0)
            {
                Console.WriteLine("The queue is empty.Press any key to continue.");
                Console.ReadKey();
                return;
            }

            string name;
            bool isSuccess = true;
            do {

                Console.Write("Enter the patient you wanna search : ");
                name = Console.ReadLine() ?? "";

                if (!new StringValidator(name).ReturnValid() || name == "")
                {
                    isSuccess = false;      
                }
                else {
                    isSuccess = true;
                    break;
                }


            } while (!isSuccess);

            var node = q.getHead();

            int index = 0;
            while (node != null)
            {
                index++;
                if (node.data.name.ToLower().Replace(" ", "").Contains(name.ToLower().Replace(" ", "")))                
                {
                    MenuOperations.Print($"Position : {index}");
                    MenuOperations.Print($"The Patient Name is {node.data.name}");
                    MenuOperations.Print($"The Total Score is {node.data.CalculateScore()}");

                    Node<Sickness> sNode = node.data.GetSickness().GetHead();

                    Console.Write($"The Sickness is");
                    while (sNode != null)
                    {
                        MenuOperations.Print(sNode.data.name + ",");
                        sNode = sNode.next;
                    }
                    MenuOperations.Print("");
    
                }

                node = node.next;

                if (node == null)
                {
                    break;
                }

            }

            Console.WriteLine("Search Complete. Press any key to continue.");
            Console.ReadKey();
        }

        public void DisplayQueue(PriorityQueue q)
        {
            throw new NotImplementedException();
        }

        public void ViewProcessedPatients(DoublyLinkedList<Pet> processed_q)
        {
            throw new NotImplementedException();
        }
    }
}
