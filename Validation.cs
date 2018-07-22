using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace John.SocialClub.Desktop
{
    public class Validation
    {
        #region password validation
        // Public method to call test validation
        public bool PasswordValidation(String password)
        {

            return (NumOfCharacters(password) &&
                HasUpperCase(password) &&
                HasNumber(password) &&
                HasSymbol(password)
                ? true : false);
        }

        // Verifies user input is between 6 and 12 characters
        public bool NumOfCharacters(String password)
        {

            return (password.Length < 6 || password.Length > 12 ? false : true);

        }


        // Verfies has atleast one upper case character
        public bool HasUpperCase(String password)
        {

            foreach(Char element in password)
            {
                if(char.IsUpper(element)) return true;
            }

            return false;
        }

        // Verifies has atleast one number
        public bool HasNumber(String password)
        {
            int num;
            foreach(Char element in password)
            {
                if(int.TryParse(element.ToString() , out num)) return true;
            }

            return false;
        }

        // Verifies has atleast one symbol of #, $, %, &
        public bool HasSymbol(String password)
        {
            // #$%&

            foreach(char element in password)
            {
                if((int)element >= 35 && (int)element <= 38) return true;
            }

            return false;
        }
        #endregion

        #region username validation
        public bool CheckID(string idnumber)
        {
            foreach(Char c in idnumber)
            {
                if(Char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }
        #endregion
    }
}
