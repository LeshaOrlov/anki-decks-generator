using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnkiDecksGeneratorWindowsForms
{
    public class Card
    {
        public string Word { get; set; }
        public string PartOfSpeech { get; set; }
        public string Transcript { get; set; }
        public string Audio { get; set; }
        public string Translate { get; set; }
        public int Frequency { get; set; }
        public string[] exemples;

        public override string ToString()
        {
            return Word + " " + Transcript + "  " + Translate;
        }

        public bool Equals(Card card)
        {

            if (this.Word == card.Word)
            {
                if (this.PartOfSpeech == card.PartOfSpeech)
                    return true;
                else
                    return false;


            }
            else return false;
        }

    }


}
