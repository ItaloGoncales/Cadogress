using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadogress
{
    class FieldValidations // This class is used to do some Validations in some specific fields
    {
        public static bool checkEmptyFields(string description, string quantity, string value)
            // This function checks if all fields were filled
        {
            if ((description == "" || String.IsNullOrEmpty(description)) && (quantity == "" || String.IsNullOrEmpty(quantity)) && (value == "" || String.IsNullOrEmpty(value)))
            {
                // Compares if all fields are null or empty, and returns false if any field wasn't filled
                return false;
            }
            else
            {
                // If all fields were filled, the function returns true
                return true;
            }
        }

        public static bool checkEnumFields(string validation)
            // This function checks if a specific field was filled with numeral characters
        {
            double number;
            try
            {
                // Tries convert the string object into a double object
                number = Convert.ToDouble(validation);
            }
            catch (Exception)
            {
                // If the convertion fails, the function returns false
                return false;
            }
            // If the conversion is successful, the function returns true
            return true;
        }
    }
}
