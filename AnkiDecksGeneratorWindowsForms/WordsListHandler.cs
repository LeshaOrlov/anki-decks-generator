using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnkiDecksGeneratorWindowsForms
{
    class WordsListHandler
    {

        public Card SearchInInternet(Card searchCard)
        {
            var macmillan = new Macmillan();
            Card card = macmillan.ProcessWord(searchCard);

            var cambrigeTranslate = new CambrigeTranslate();
            card.Translate = cambrigeTranslate.Translate(card);

            return card;
        }
    }
}
