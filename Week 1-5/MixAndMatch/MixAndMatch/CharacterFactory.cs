using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixAndMatch
{
    //sets data
    public class CharacterFactory : ICharacterFactory
    {
        public List<Character> generateCharacters()
        {
            List<Character> characterSet = new List<Character>();
            characterSet.Add(new Character("Fairy", "head0", "body0", "legs0"));
            characterSet.Add(new Character("Zombie", "head1", "body1", "legs1"));
            characterSet.Add(new Character("Skeleton", "head2", "body2", "legs2"));
            characterSet.Add(new Character("Vampire", "head3", "body3", "legs3"));
            characterSet.Add(new Character("Werewolf", "head4", "body4", "legs4"));
            characterSet.Add(new Character("Witch", "head5", "body5", "legs5"));

            return characterSet;
        }
    }
}
