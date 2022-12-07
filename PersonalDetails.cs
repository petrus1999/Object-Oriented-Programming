using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class PersonalDetails
    {
        public string Name;
        public string Surname;
        public string Monthofbirth;
        public int yearofbirth;
        public int Dayofbirth;

        public PersonalDetails (string personName, string personSurname, string personMonthofbirth, int personyearofbirth, int personDayofbirth)
        {
            Name = personName;
            Surname = personSurname;
            Monthofbirth = personMonthofbirth;
            yearofbirth = personyearofbirth;
            Dayofbirth = personDayofbirth;

        }
            


    }
}
