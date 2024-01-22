using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetClinicPatientMgtProject.Validator
{
    public class EmptyValidator : ValidatorClass
    {
        public override bool ReturnValid()
        {

            return _valid;
        }
        public EmptyValidator(string input) : base()
        {
            _valid = AddObserver(input);
        }
        protected override bool AddObserver(string s)
        {
            return  string.IsNullOrEmpty(s); ;
        }
    }
}
