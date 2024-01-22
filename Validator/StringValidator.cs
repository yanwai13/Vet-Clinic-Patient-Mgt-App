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
        protected override bool AddObserver (string s) { return s.All(char.IsLetter);  } 
    }
}
