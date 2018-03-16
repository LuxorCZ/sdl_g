using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.IO;
using Game.Engine.Entities;
using Game.Engine.Utilities;

namespace Game.Engine.Managers
{
    static class AssetManager
    {

        private static string path = "";
        private static string spritesPath = "";

        private static Dictionary<string, Sprite> sprites = new Dictionary<string, Sprite>();

        public static void Init()
        {

            path = ConfigurationSettings.AppSettings["am_assetsfolder"];
            spritesPath = ConfigurationSettings.AppSettings["am_spritessubfolder"];

            loadSprites();

        }

        public static Sprite GetAsset(string sprite)
        {
            //todo exceptiony
            return sprites[sprite];
        }

        //hloupá metoda, co načte vše ve složce (alespoň prozatím)
        public static void loadSprites()
        {
            Directory.EnumerateFiles(path + spritesPath).ToList().ForEach(
                x => {
                        sprites.Add(Path.GetFileNameWithoutExtension(x), ImageUtilities.getSprite(x));
                     }
            );

        }

    }
}
