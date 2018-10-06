using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using HtmlAgilityPack;

namespace AnkiDecksGeneratorWindowsForms
{
    class Macmillan
    {
        string searchPath = "http://www.macmillandictionary.com/dictionary/british/";

        public Macmillan()
        {

        }

        string getCleanUrl(HtmlNode link_)
        {
            return (new Regex("(.*/)?(.+?)(#.*)?")).Replace(link_.Attributes["href"].Value, "$2");
        }

        public Card ProcessWord(Card searchCard)
        {
            
            var page = (new HtmlWeb()).Load(searchPath + searchCard.Word);

            //Берём все слова из блока search results
            var partOfSpeech = getText(page.DocumentNode.SelectSingleNode("//span[@class='PART-OF-SPEECH']"));
            if ((searchCard.PartOfSpeech == null) ||(partOfSpeech == searchCard.PartOfSpeech))
            {
                searchPath = searchPath + searchCard.Word;
                //page = (new HtmlWeb()).Load(searchPath);
                return Parse(page);
             
            }
            else
            {
                var linksNodes = page.DocumentNode.SelectNodes("//div[@class='entrylist']/ul/li/a");
                //var partOfSpeachNodes = page.DocumentNode.SelectNodes("//span[@class='PART-OF-SPEECH']");
                if (linksNodes != null)
                {
                    foreach (HtmlNode link in linksNodes)
                    {
                        var url = getCleanUrl(link);
                        var text = getText(link);
                        if (text == (searchCard.Word + "  " + searchCard.PartOfSpeech))
                        {
                            page = (new HtmlWeb()).Load(searchPath + url);
                            break;
                        }
                    }
                    //for (int i = 0; i < partOfSpeachNodes.Count; i++)
                    //{
                    //    if (getText(partOfSpeachNodes[i]) == searchCard.PartOfSpeech)
                    //    {
                    //        searchPath = getCleanUrl(linksNodes[i]);
                    //        var document = (new HtmlWeb()).Load(searchPath);
                    //        return Parse(document);
                    //    }
                    //} 
                }

                return Parse(page);
            }




        }


        public Card Parse(HtmlDocument document)
        {
            

            var examples = document.DocumentNode.SelectNodes("//div[@class='EXAMPLES']");

            var transcription = getText(document.DocumentNode.SelectSingleNode("//span[@class='PRON show_less']"));
            var word = getText(document.DocumentNode.SelectSingleNode("//span[@class='BASE']"));
            var partOfSpeech = getText(document.DocumentNode.SelectSingleNode("//span[@class='PART-OF-SPEECH']"));
            var voiceNode = document.DocumentNode.SelectSingleNode("//img[@class='sound audio_play_button']");

            string mp3;
            if (voiceNode != null)
            {
                foreach (var attribut in voiceNode.Attributes)
                {
                    if (attribut.Name == "data-src-mp3")
                    {
                        mp3 = attribut.Value;

                        WebClient Client = new WebClient();
                        Uri uri = new Uri(mp3);
                        //bool exisF = File.Exists(SettingsManager.PathCacheAudioFiles + word + @".mp3");
                        if (!File.Exists(SettingsManager.PathCacheAudioFiles + word + @".mp3"))
                        {
                            Client.DownloadFile(uri, SettingsManager.PathAnkiMultimediaFiles+@"\" + word + ".mp3");
                            File.Copy(SettingsManager.PathAnkiMultimediaFiles+ @"\"+word + ".mp3", SettingsManager.PathCacheAudioFiles + word + ".mp3");
                        }
                    }
                }
            }
            else
            {
                //mp3 = "";
            }



            string[] primers;
            if (examples != null)
            {
                primers = new string[examples.Count];

                for (int i = 0; i < examples.Count; i++)
                {
                    primers[i] = examples[i].InnerText;
                }

            }
            else
            {
                primers = new string[] { "" };
            }

            Card en = new Card();
            en.Word = word;
            en.PartOfSpeech = partOfSpeech;
            en.Transcript = transcription;
            en.exemples = primers;

            return en;

        }



        public string getText(HtmlNode node)
        {
            if (node != null) return node.InnerText.Trim();

            return String.Empty;
        }



    }
}
