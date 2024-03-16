using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetClinicPatientMgtProject.State;

namespace VetClinicPatientMgtProject.Validator
{
    public class IntegerValidator : ValidatorClass
    {
        public override bool ReturnValid()
        {
            return _valid;
        }
        public IntegerValidator(string input) : base()
        {
            _valid = AddObserver(input);
        }
        protected override bool AddObserver(string s) { 
            var result = int.TryParse(s, out int r);

            if (result == true && r > 0)
                return true;

            return false;
        }
    }
}
