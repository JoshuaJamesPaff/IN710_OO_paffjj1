using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encrypter
{
    public class MessageParser
    {
        private IEncrypter worker;

        public MessageParser()
        {
        }

        //sets the type of encryption worker
        public void setEncryptType(int type){

            //if type is 0 - create string reverser
            if(type == 0){
                worker = new StringReverser();
            }
            //if type is 1 - create string rotater
            else if(type == 1){
                worker = new StringRotater();
            }
            //default
            else
            {
                worker = new StringRotater();
            }
        }
        //takes input and encrypts it
        public String Encrypt(String input)
        {
            return worker.Encrypt(input);
        }

        //takes input and decrypts it
        public String Decrypt(String input)
        {
            return worker.Decrypt(input);
        }
    }
}
