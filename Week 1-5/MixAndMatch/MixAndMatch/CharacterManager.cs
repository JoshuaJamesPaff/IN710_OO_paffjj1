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

        //returns a list of bitmaps based off of a characters properties
        public List<Bitmap> printCharacter(Character charToPrint, string fileExtension)
        {
            List<Bitmap> output = new List<Bitmap>();
            //top img
            Bitmap topImage = (Bitmap)Image.FromFile(charToPrint.Head + fileExtension);
            output.Add(topImage);
            //mid img
            Bitmap midImage = (Bitmap)Image.FromFile(charToPrint.Body + fileExtension);
            output.Add(midImage);
            //bottom img
            Bitmap bottomImage = (Bitmap)Image.FromFile(charToPrint.Legs + fileExtension);
            output.Add(bottomImage);

            return output;
        }
    }
}
