using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetClinicPatientMgtProject.BaseClass;
using VetClinicPatientMgtProject.Clinic;

namespace VetClinicPatientMgtProject.State
{



    public class Display : IActionFty
    {

        public void Action(PriorityQueue q, DoublyLinkedList<Pet> processed_q)
        {

        }
        public void DisplayQueue(PriorityQueue q)
        {

            MenuOperations.Print($"---------------------");
            if (q == null)
            {

                MenuOperations.Print("No processed queue! ");
                return;
            }

            Node<Pet> headNode = q.getPatients().GetHead();

            while (headNode != null)
            {

                MenuOperations.Print($"The Patient Name is {headNode.data.name}");
                MenuOperations.Print($"The Total Score is {headNode.data.CalculateScore()}");

                Node<Sickness> sNode = headNode.data.GetSickness().GetHead();
                Console.Write($"The Sickness is");
                while (sNode != null)
                {
                    MenuOperations.Print(sNode.data.name + ",");
                    sNode = sNode.next;
                }
                MenuOperations.Print("");
                headNode = headNode.next;

            }
            MenuOperations.Print($"---------------------");

            MenuOperations.ReturnToMainScreen();
        }//end of function

        public void ViewProcessedPatients(DoublyLinkedList<Pet> processed_q)
        {
            if (processed_q == null)
            {

                MenuOperations.Print("No processed queue! ");
                return;
            }

            Node<Pet> headNode = processed_q.GetHead();

            while (headNode != null)
            {

                MenuOperations.Print(headNode.data.name);

                MenuOperations.Print(headNode.data.CalculateScore());

                Node<Sickness> sNode = headNode.data.GetSickness().GetHead();

                while (sNode != null)
                {
                    MenuOperations.Print(sNode.data.name);
                    sNode = sNode.next;
                }
                headNode = headNode.next;

            }

            MenuOperations.ReturnToMainScreen();

        }//end of function




    }







}
