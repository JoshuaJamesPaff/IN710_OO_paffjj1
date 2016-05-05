using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encrypter
{
    public partial class Form1 : Form
    {
        private MessageParser stringHandler;
 
        public Form1()
        {
            InitializeComponent();
            stringHandler = new MessageParser();
        }

        //returns 0 or 1 depending on the radiobutton selected. 0 = reverse, 1 = rot13
        private int getEncryptType()
        {
            if (radioButtonStringReversal.Checked == true)
            {
                return 0;
            }else{
                return 1;
            }
         
        }
        //sets encryption type and then encrypts
        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            stringHandler.setEncryptType(getEncryptType());
            textBoxOutput.Text = stringHandler.Encrypt(textBoxInput.Text);
        }

        //sets decryption type and then decrypts
        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            stringHandler.setEncryptType(getEncryptType());
            textBoxOutput.Text = stringHandler.Decrypt(textBoxOutput.Text);
        }
    }
}
