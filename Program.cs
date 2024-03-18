/*
 newly Update
 */

using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Xml.Linq;
using VetClinicPatientMgtProject.State;
using VetClinicPatientMgtProject.Validator;
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
                    MenuOperations.Print("Enter Option: or type 0 to quit");

                    try
                    {

                         string input = Console.ReadLine() ?? "";

                        var isValid = new IntegerValidator(input).ReturnValid();
                        selection_no = Convert.ToInt32(input);

                        if (!isValid || selection_no < 0 || selection_no > 7)
                        {
                            success = false;

                            MenuOperations.Print("Please Input Proper Selection. Please Press any key to continue");
                            Console.ReadKey();

                        }

                        else {
                            
                            success = true;
                        }
                            
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