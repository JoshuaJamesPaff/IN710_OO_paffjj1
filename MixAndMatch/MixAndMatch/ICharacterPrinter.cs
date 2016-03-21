using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MixAndMatch
{
    interface ICharacterPrinter
    {
        //returns a list of bitmaps of character c
        List<Bitmap> printBitmaps(Character c);
    }
}
