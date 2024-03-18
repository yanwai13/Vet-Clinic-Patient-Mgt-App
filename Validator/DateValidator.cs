using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetClinicPatientMgtProject.State;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace VetClinicPatientMgtProject.Validator
{
    public class DateValidator : ValidatorClass
    {
        public override bool ReturnValid()
        {
            return _valid;
        }
        public DateValidator(string input) : base()
        {
            _valid = AddObserver(input);
        }
        protected override bool AddObserver(string s) { 
                       

            return DateTime.TryParseExact(s, "yyyy-MM-dd HH:mm:ss", null, System.Globalization.DateTimeStyles.None, out DateTime parsedDateTime);
        }
    }
}
