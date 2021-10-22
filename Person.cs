using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandiBooking
{
    //This class represents the parent class from which guests and receptions can be derived. 
    //This will also enable the project to be extended in the future if need be
    class Person
    {
  
        #region Data Members
        private string firstNAme, surname;
        private int age;
        #endregion

        #region Property Methods
        public string getFirstName
        {
            get { return firstNAme; }
            set { firstNAme = value; }
        }

        public string getSurname
        {
            get { return surname; }
            set { surname = value; }
        }
        public int getAge
        {
            get { return age; }
            set { age = value; }
        }
        #endregion

        #region Construtor
        public Person()
        {
            firstNAme = "";
            surname = "";
            age = 999;
        }
        public Person(string FirstName, string Surname, int Age)
        {
            firstNAme = FirstName;
            surname = Surname;
            age = Age;
        }
        #endregion
    }
}
