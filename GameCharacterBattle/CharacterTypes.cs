using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GamePractical
{
    class CharacterTypes
    {
        public enum Types {KING = 0, KNIGHT = 1, QUEEN = 2, TROLL = 3};
        public CharacterTypes()
        {
        }

        public static Types getTypes()
        {
            Types types = new Types();
            return types;
        }
    }
}
