using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetClinicPatientMgtProject.Validator;
using VetClinicPatientMgtProject.BaseClass;
using VetClinicPatientMgtProject.Clinic;

namespace VetClinicPatientMgtProject.State
{
    public class Input : IActionFty
    {
        public ValidatorClass validator;


        public bool DetermineValidation(string validType, string input) {

            bool result = false;

            switch (validType)
            {
                case "string":
                    validator = new StringValidator(input);
                    result = validator.ReturnValid();
                    break;
                case "empty":
                    validator = new EmptyValidator(input);
                    result = validator.ReturnValid();
                    break;
                case "integer":
                    validator = new IntegerValidator(input);
                    result = validator.ReturnValid();
                    break;
                case "date":
                    validator = new DateValidator(input);
                    result = validator.ReturnValid();
                    break;

            }

            return result;
        }

        public void Action(PriorityQueue q, DoublyLinkedList<Pet> processed_q)
        {
            MenuOperations.Print("What's the pet name?");

            //string? petName = MenuOperations.ReturnUserInput("string", "Pet Name");
            string ? petName = "";

            bool isNameInputFinish = true;
            do {

                petName = Console.ReadLine() ?? "";

                isNameInputFinish = DetermineValidation("string", petName) && !DetermineValidation("empty", petName);

                if (!isNameInputFinish)
                    MenuOperations.Print("Please input a proper name");


            } while (!isNameInputFinish);

            DateTime parsedDateTime;

            bool isDateInputFinish = true;
            string date = "";
            do
            {
                MenuOperations.Print("Please enter a date and time (yyyy-MM-dd HH:mm:ss): or Enter for current date and time");

                date = Console.ReadLine() ?? "";

                if (date == "")
                    date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                if (! (isDateInputFinish = DetermineValidation("date", date)))
                {
                    MenuOperations.Print("Please input a proper date");

                }
                


            } while (!isDateInputFinish);

            Pet? pet = new Pet(petName,  DateTime.Parse(date));

            bool isAlimentInputFinish = false;

            

            //bigger loop for input
            do
            {
                bool success = false;

                //smaller loop for validation process

                MenuOperations.Print("Enter ailment (leave blank when done) :");

                string aliment = Console.ReadLine() ?? "";

                
                if (DetermineValidation("empty", aliment) )
                //if (MenuOperations.IsEmpty(aliment))
                {
                    isAlimentInputFinish = true;
                    break;
                }
                else
                {
                    do
                    {
                        if (DetermineValidation("string", aliment)  )
                        //if (MenuOperations.IsString(aliment))
                        {
                            success = true;
                            break;
                        }
                        else
                        {
                            MenuOperations.Print($"Please kindly input proper aliment ");
                            aliment = Console.ReadLine();

                        }

                    } while (!success);

                    string severity, time, cont;
                   
                        
                        bool isClinicDataInputFinish = false;
                        do
                        {
                            MenuOperations.Print("Enter severity");
                            severity = Console.ReadLine();

                            MenuOperations.Print("Enter time");
                            time = Console.ReadLine();

                            MenuOperations.Print("contagious");
                            cont = Console.ReadLine();

                            if (DetermineValidation("integer", severity) 
                                && DetermineValidation("integer", time) 
                                && DetermineValidation("integer", cont)
                                && !DetermineValidation("empty", severity)
                                && !DetermineValidation("empty", time)
                                && !DetermineValidation("empty", cont))
                            //if (MenuOperations.IsString(aliment))
                            {

                                success = true;
                                break;
                            }
                            else
                            {
                                MenuOperations.Print($"Please kindly input proper severity, time, Severity,Time,Contagious ");
                                aliment = Console.ReadLine();

                            }

                        } while (!isClinicDataInputFinish);

                        pet?.AddSickness(new Sickness(aliment, Convert.ToInt32(severity), Convert.ToInt32(time), Convert.ToInt32(cont)));
                   
                   
                }


            } while (!isAlimentInputFinish);


            q.enqueue(pet);

            MenuOperations.Print($"input patient is finished");
            MenuOperations.ReturnToMainScreen();
        }



        public void DisplayQueue(PriorityQueue q)
        {

        }
        public void ViewProcessedPatients(DoublyLinkedList<Pet> processed_q)
        {

        }
    }
}
