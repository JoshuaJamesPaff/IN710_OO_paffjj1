using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixAndMatch
{
    public class CharacterManager : ICharacterPrinter
    {
        //manages a list of characters and a factory to build them
        private List<Character> characterSets;
        CharacterFactory factory;

        public CharacterManager()
        {
            characterSets = new List<Character>();
            factory = new CharacterFactory();

            //gets characters from factory
            addCharacterList();
        }

        //sets hard values of charcater sets
        public void addCharacterList()
        {
            characterSets = factory.generateCharacters();
        }

        public List<Character> getCharacterList()
        {
            return characterSets;
        }

        
        public Character createCharacter(string head, string body, string legs)
        {
            Character createCharacter = new Character("new", head, body, legs);
            return createCharacter;
        }

        //returns a list of bitmaps based off characters properties
        public List<Bitmap> printBitmaps(Character charToPrint)
        {
            List<Bitmap> bitmaps = new List<Bitmap>();

                Bitmap topImage = (Bitmap)Image.FromFile(charToPrint.Head + ".png");
                bitmaps.Add(topImage);
                Bitmap midImage = (Bitmap)Image.FromFile(charToPrint.Body + ".png");
                bitmaps.Add(midImage);
                Bitmap bottomImage = (Bitmap)Image.FromFile(charToPrint.Legs + ".png");
                bitmaps.Add(bottomImage);

                return bitmaps;
        }
    }
}
