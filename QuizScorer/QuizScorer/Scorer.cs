using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizScorer
{
    public class Scorer
    {
        public Scorer()
        {

        }

        public static int AdultScore(int correct, int incorrect)
        {
            return (10 * correct) - (1 * incorrect);
        }

        public static int ChildScore(int correct, int incorrect)
        {
            return (15 * correct) - (0 * incorrect);
            
        }

    }
}
