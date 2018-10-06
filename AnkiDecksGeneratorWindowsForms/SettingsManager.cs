using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Text.RegularExpressions;

namespace AnkiDecksGeneratorWindowsForms
{
    static class SettingsManager
    {
        static string pathCacheFile = "Cards.xml";
        static string pathCacheAudioFiles = "./Audio";
        static string pathAnkiMultimediaFiles = @"C:\Users\Alex\AppData\Roaming\Anki2\1-й пользователь\collection.media\";
        static string pathMacmillanDictionary = "http://www.macmillandictionary.com/dictionary/british/";
        static string pathCambridgeDictionary = "https://dictionary.cambridge.org/dictionary/english-russian/";

        static string pathFileSettings = "Settings";

        static public string PathCacheFile { get { return pathCacheFile; } set { pathCacheFile = value; } }
        static public string PathCacheAudioFiles { get { return pathCacheAudioFiles; } set  { pathCacheAudioFiles = value; } }
        static public string PathAnkiMultimediaFiles { get { return pathAnkiMultimediaFiles; } set  { pathAnkiMultimediaFiles = value; } }
        static public string PathMacmillanDictionary { get { return pathMacmillanDictionary; } set  { pathMacmillanDictionary = value; } }
        static public string PathCambridgeDictionary { get { return pathCambridgeDictionary; } set  { pathCambridgeDictionary = value; } }




        static public void DownLoad(string pathFileSettings)
        {
            using (StreamReader tr = new StreamReader(pathFileSettings))
            {
                while (!tr.EndOfStream)
                {
                    Setting setting = GetSetting(tr.ReadLine());
                    SetSetting(setting);
                }
            }
        }

        static public void Save()
        {
            using (StreamWriter tr = new StreamWriter(new FileStream(pathFileSettings, FileMode.Create)))
            {
                tr.WriteLine("pathCacheFile = " + pathCacheFile);
                tr.WriteLine("pathCacheFile = " + pathCacheFile);
                tr.WriteLine("pathAnkiMultimediaFiles = " + pathAnkiMultimediaFiles);
                tr.WriteLine("pathMacmillanDictionary = " + pathMacmillanDictionary);
                tr.WriteLine("pathCambridgeDictionary = " + pathCambridgeDictionary);
            }
        }

        static private Setting GetSetting(string settingLine)
        {
            //улучшить
            Setting setting = new Setting();

            //string valideStr = (new Regex(" ")).Replace(settingLine,"").Trim();
            setting.Name = Regex.Match(settingLine, @"\w+").ToString().Trim();
            setting.Value = Regex.Match(settingLine, "\".+\"").ToString().Trim('"');

            return setting;
        }

        static private void SetSetting(Setting setting)
        {
            switch (setting.Name)
            {
                case "PathCacheFile":
                    {
                        pathCacheFile = setting.Value;
                        break;
                    }
                case "PathCacheAudioFiles":
                    {
                        pathCacheAudioFiles = setting.Value;
                        break;
                    }
                case "PathAnkiMultimediaFiles":
                    {
                        pathAnkiMultimediaFiles = setting.Value;
                        break;
                    }
                case "PathMacmillanDictionary":
                    {
                        pathMacmillanDictionary = setting.Value;
                        break;
                    }
                case "PathCambridgeDictionary":
                    {
                        pathCambridgeDictionary = setting.Value;
                        break;
                    }
                default:
                    break;
            }
        }

    }
}
