using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xUnit_exercise
{
    public class Methods
    {
        public static string Formatter(string firstName, string lastName)
        {
            string lowerFirstName = firstName.ToLower();

            string initialFirstName = lowerFirstName.Remove(1);
            string initialFirstNameCapitalized = initialFirstName.ToUpper();
            string restFirstName = lowerFirstName.Remove(0, 1);
            string outcomeFirstName = initialFirstNameCapitalized + restFirstName; // FIRST NAME FORMATTED

            string lowerLastName = lastName.ToLower();
            string initialLastName = lowerLastName.Remove(1);
            string initialLastNameCapitalized = initialLastName.ToUpper();
            string restLastName = lowerLastName.Remove(0, 1);
            string outcomeLastName = initialLastNameCapitalized + restLastName; // LAST NAME FORMATTED

            string firstNameID = firstName.Remove(3);
            string outcomeFirstNameID = firstNameID.ToUpper();
            string lastNameID = lastName.Remove(3);
            string outcomeLastNameID = lastNameID.ToUpper();
            string userID = outcomeLastNameID + outcomeFirstNameID; // USER ID FORMATTED
           
            string outcome = $"#_{outcomeLastName}, {outcomeFirstName} ({userID})";
            return outcome;
        }



    }
}
