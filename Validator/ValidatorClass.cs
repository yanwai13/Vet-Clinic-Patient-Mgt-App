using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetClinicPatientMgtProject.Validator
{
    public abstract class ValidatorClass
    {
        protected bool _valid = false;

        protected abstract bool AddObserver(string s);
        public abstract bool ReturnValid();
    }
}
