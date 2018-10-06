using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkBD
{
    [Serializable]
    public class Card
    {
        public string Word { get; set; }
        public string Transcript { get; set; }
        public string Translate { get; set; }
        public string[] exemples;

        public bool Equals(Card card)
        {
            if (card == null) return false;
            if (this.Word == card.Word)
                return true;
            else
                return false;
            
        }
    }
}
