using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEncryptorPasswordGenerator
{
    public enum EncryptionMethod
    {
        Caesar,
        Vigenere
    }

    public enum TranslatePurpose
    {
        Encrypt,
        Decrypt
    }
    public static class Encryptor
    {
        public static string Encrypt(EncryptionMethod method, string message, string key)
        {
            string encryptedMessage = "";

            switch (method)
            {
                case EncryptionMethod.Caesar:
                    for (int i = 0, n = message.Length; i < n; i++)
                    {
                        encryptedMessage += returnCryptedChar(message[i], Convert.ToInt32(key), TranslatePurpose.Encrypt);
                    }
                        return encryptedMessage;
                case EncryptionMethod.Vigenere:
                        for (int i = 0, n = message.Length, vigLength = key.Length, vigCounter = 0; i < n; i++)
                        {
                            if (vigCounter >= vigLength)
                                vigCounter = 0;

                            encryptedMessage += returnCryptedChar(message[i], (int)key[vigCounter], TranslatePurpose.Encrypt);

                            vigCounter++;
                        }
                            return encryptedMessage;
            }
            return "1";
        }

        public static string Decrypt(EncryptionMethod method, string message, string key)
        {
            string decryptedMessage = "";

            switch (method)
            {
                case EncryptionMethod.Caesar:
                    for (int i = 0, n = message.Length; i < n; i++)
                    {
                        decryptedMessage += returnCryptedChar(message[i], Convert.ToInt32(key), TranslatePurpose.Decrypt);
                    }

                    return decryptedMessage;
                case EncryptionMethod.Vigenere:
                    for (int i = 0, n = message.Length, vigLength = key.Length, vigCounter = 0; i < n; i++)
                    {
                        if (vigCounter >= vigLength)
                            vigCounter = 0;

                        decryptedMessage += returnCryptedChar(message[i], (int)key[vigCounter], TranslatePurpose.Decrypt);

                        vigCounter++;
                    }
                    return decryptedMessage;
            }
            return "1";
        }
        private static char returnCryptedChar(char currentChar, int keyConverted, TranslatePurpose purpose)
        {
            if ((int)currentChar == 10 || (int)currentChar == 13) // carriage return, new line
            {
                return currentChar;
            }

            if (purpose == TranslatePurpose.Encrypt)
            {

                    if ((int)currentChar + keyConverted <= CONSTANTS.LASTASCIISYMBOL)
                    {
                        return (char)((int)currentChar + keyConverted);
                    }
                    else
                    {
                        return (char)(((int)currentChar + keyConverted) % (CONSTANTS.LASTASCIISYMBOL + 1) + CONSTANTS.FIRSTASCIISYMBOL);
                    }              
            }
            else // purpose is TranslatePurpose.Decrypt here
            {             
                if ((int)currentChar - keyConverted >= CONSTANTS.FIRSTASCIISYMBOL)
                {
                    return (char)((int)currentChar - keyConverted);
                }
                else
                {
                    return (char)(CONSTANTS.LASTASCIISYMBOL - (keyConverted - ((int)currentChar - (CONSTANTS.FIRSTASCIISYMBOL - 1))));
                }
            }
        }
    }
}
