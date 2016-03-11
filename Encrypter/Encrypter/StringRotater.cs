using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encrypter
{
    public class StringRotater : IEncrypter
    {
     
        /// simple rot13 method taken from http://www.dotnetperls.com/rot13
        ///
        /// returns encrypted/decrypted string
        public String Encrypt(String value)
        {
            char[] array = value.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                int number = (int)array[i];

                if (number >= 'a' && number <= 'z')
                {
                    if (number > 'm')
                    {
                        number -= 13;
                    }
                    else
                    {
                        number += 13;
                    }
                }
                else if (number >= 'A' && number <= 'Z')
                {
                    if (number > 'M')
                    {
                        number -= 13;
                    }
                    else
                    {
                        number += 13;
                    }
                }
                array[i] = (char)number;
            }
            return new string(array);
        }

        /// simple rot13 method taken from http://www.dotnetperls.com/rot13
        /// works both ways
        /// returns encrypted/decrypted string
        public String Decrypt(String value)
        {
            return Encrypt(value);
        }
    }
}
