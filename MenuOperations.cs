

namespace VetClinicPatientMgtProject
{
    public class MenuOperations
    {
        public static void ReturnToMainScreen() {

            Print("Press any key to continue...");

            Console.ReadKey();

        }
        public static void Print<T>(T val)
        {
            Console.WriteLine($"{val}");   
        }
        public static void PrintSelection()
        {
            Print("Please Make A Selection: ");
            Print("1 - Add Patient ");
            Print("2 - Process Next Patient in Queue");
            Print("3 - Display Queue");
            Print("4 - View Processed Patients History");
            Print("5 - Search Patients History");
            Print("6 - Statistics");
            Print("7 - Exit\n");
        }

        public static bool IsEmpty(string s)
        {
            return string.IsNullOrEmpty(s) ;
        }

        public static bool IsString(string s)
        {
            return s.All(char.IsLetter);
        }

        public static bool isInputOfType<T> (string input)
        {

            try
            {
                // Attempt to convert the input to the specified type
                T convertedValue = (T)Convert.ChangeType(input, typeof(T));
                return true;
            }
            catch (FormatException)
            {
                // Conversion failed
                return false;
            }
            catch (InvalidCastException)
            {
                // Conversion failed
                return false;
            }
        }

        public static string ReturnUserInput (string varType, string questionName)
        {
            bool success = false;
            string userInput = "";


            do
            {
                userInput = Console.ReadLine();
               
                if (!IsEmpty(userInput) && IsString(userInput))
                    success = true;
            
                if (!success)
                    Print($"Please kindly input proper {questionName}");

            } while (!success);

            return userInput;
        }
        
       

       


        
    }
            
                   
                    
                    

   
}
