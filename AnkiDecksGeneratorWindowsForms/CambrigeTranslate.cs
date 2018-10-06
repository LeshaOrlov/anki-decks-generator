using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AnkiDecksGeneratorWindowsForms
{
    class CambrigeTranslate
    {
        public string Translate(Card card)
        {
            string result = "";
            
            var document = (new HtmlWeb()).Load("https://dictionary.cambridge.org/dictionary/english-russian/" + card.Word);

            //var page = (new HtmlWeb()).Load("https://dictionary.cambridge.org/search/english-russian/?q=" + card.Word);
            var linksNodes = document.DocumentNode.SelectNodes("//div[@class='pad']/ul/li/a");
            if (linksNodes != null)
            {
                foreach (HtmlNode link in linksNodes)
                {
                    var url = getCleanUrl(link);
                    var text = getText(link);
                    if (text == (card.Word + " " + card.PartOfSpeech))
                    {
                        document = (new HtmlWeb()).Load("https://dictionary.cambridge.org/dictionary/english-russian/" + url);
                        break;
                    }
                }
            }
           
            result = getText(document.DocumentNode.SelectSingleNode("//span[@class='trans']"));
            return result;
        }

        public string getText(HtmlNode node)
        {
            if (node != null)
                return node.InnerText.Trim();
            return String.Empty;
        }

        string getCleanUrl(HtmlNode link_)
        {
            return (new Regex("(.*/)?(.+?)(#.*)?")).Replace(link_.Attributes["href"].Value, "$2");
        }
    }
}
