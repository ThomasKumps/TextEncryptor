using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEncryptorPasswordGenerator
{
    public static class Generator
    {
        public static string NewPassword(byte length)
        {
            Random rnd = new Random();
            string password = "";

            for (byte b = 0; b < length; b++)
            {
                password += (char)rnd.Next(33, 127);
            }

            return password;
        }
        public static string OneTimePad(int length)
        {
            Random rnd = new Random();
            string pad = "";

            for (int i = 0; i < length; i++)
            {
                pad += (char)rnd.Next(CONSTANTS.FIRSTASCIISYMBOL+1, CONSTANTS.LASTASCIISYMBOL+1); // Avoid space (ASCII decimal 32) and exclusive upper bound (126+1)
            }

            return pad;
        }
    }
}
