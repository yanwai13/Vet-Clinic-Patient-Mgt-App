using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetClinicPatientMgtProject.Validator
{
    public class StringValidator : ValidatorClass
    {
        public override bool ReturnValid()  {

            return _valid;
        }
        public StringValidator(string input) : base() {
            _valid = AddObserver(input);
        }
        protected override bool AddObserver (string s) {

            //use LINQ to check each of the character of the string either letter or white space only         
            return s.All(c => char.IsLetter(c) || char.IsWhiteSpace(c));
        } 
    }
}
