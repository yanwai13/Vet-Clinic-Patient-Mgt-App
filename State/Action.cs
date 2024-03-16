using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetClinicPatientMgtProject.BaseClass;
using VetClinicPatientMgtProject.Clinic;

namespace VetClinicPatientMgtProject.State
{
    public class Action
    {
        private static Action? a;
        private IActionFty i;
        public static PriorityQueue? q;
        public static DoublyLinkedList<Pet>? processed_q;

        private Action()
        {


        }

        public static Action getAction()
        {

            if (a == null)
            {
                a = new Action();
                q = new PriorityQueue();
                processed_q = new DoublyLinkedList<Pet>();

            }
            return a;

        }

        public bool DetermineAction(int? actionType)
        {

            bool isExit = false;

            switch (actionType)
            {
               
                case 1:
                    i = new Input();
                    i.Action(q, processed_q);
                    //MenuOperations.InputPatient(q);
                    break;
                case 2:
                    i = new Move();
                    i.Action(q, processed_q);
                    //MenuOperations.MovePatient(q, processed_q);                    
                    break;

                case 3:
                    i = new Display();
                    i.DisplayQueue(q);

                    break;

                case 4:
                    i = new Display();
                    i.ViewProcessedPatients(processed_q);
                    break;
                case 5:
                    i = new Search();
                    i.Action(q, processed_q);
                    break;
                case 6:
                    isExit = true;
                    Console.WriteLine("Program Exit. Press any key to continue");
                    Console.ReadKey();
                    break;
                default:

                    MenuOperations.Print("Invalid Input. Please Press Key to Continue");
                    Console.ReadKey();  
                    break;
            }

            return isExit;
        }
    }
}
