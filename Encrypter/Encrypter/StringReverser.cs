using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encrypter
{
    public class StringReverser : IEncrypter
    {
        
        /// reverses input string
        public String Encrypt(String input)
        {
            char[] newString = input.ToCharArray();
            Array.Reverse(newString);
            return new string(newString);
        }

        /// reverses input string
        public String Decrypt(string input)
        {
            return Encrypt(input);
        }
    }
}
