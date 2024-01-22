using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Xml.Linq;
using VetClinicPatientMgtProject.State;
using Action = VetClinicPatientMgtProject.State.Action;

namespace VetClinicPatientMgtProject
{
    public class Program
    {

        
        static void Main(string[] args)
        {
            
           

            bool isExited = false;

            //outer do while for output loop
            int selection_no = -1;

            do {
                Console.Clear();

                MenuOperations.Print("Welcome to the Vet clinic Management System\n");
                
                MenuOperations.PrintSelection();

                // Ask the user to input the options// if the user input non numeric input , prompt user to give a proper one
                bool success = false;
               

                do {
                    Console.WriteLine("Enter Option: or type 0 to quit");

                    try
                    {
                        selection_no = Convert.ToInt32(Console.ReadLine());
                       
                        success = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Any user input only contains numeric digits.");
                    }

                } while(!success);

                
                Console.Clear();
                Action a = Action.getAction();
                isExited = a.DetermineAction(selection_no);

            } while (!isExited);

            
        }
    }
}