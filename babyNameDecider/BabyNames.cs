using System;
using System.Collections.Generic;

namespace babyNameDecider
{
    public class BabyNames

    {
        
        static List<string> frenchGirlNames = new List<string> { "Mélodie", "Margaux", "Daphne", "Maeva", "Charlie"};
        static List<string> frenchBoyNames = new List<string> { "Louis", "Paul", "Alexandre", "Hugo", "Gaspard" };
        static List<string> spanishGirlNames = new List<string> { "Amaïa", "Amaya", "Luna", "Monica", "Valentina" };
        static List<string> spanishBoyNames = new List<string> { "Rodrigo", "Carlos", "Lucas", "Diego", "Gabriel" };
        static List<string> englishGirlNames = new List<string> { "Lara", "Ella", "Betsy", "Margaret", "Karen" };
        static List<string> englishBoyNames = new List<string> { "Oliver", "George", "Harry", "William", "Charles" };
        static List<string> italianGirlNames = new List<string> { "Sabrina", "Giulia", "Serena", "Selina", "Monika" };
        static List<string> italianBoyNames = new List<string> { "Ludo", "Alessio", "Mateo", "Andrea", "Lorenzo" };
        static List<string> israeliGirlNames = new List<string> { "Noa", "Eden", "Dalia", "Mila", "Norah" };
        static List<string> israeliBoyNames = new List<string> { "Ariel", "Joseph", "Michael", "Tamar", "David" };
        static List<string> japaneseGirlNames = new List<string> { "Mio", "Sakura", "Mitsuki", "Akari", "Yuzuki" };
        static List<string> japaneseBoyNames = new List<string> { "Haruto", "Asahi", "Kazuto", "Gaku", "Haruki" };
        static List<string> germanGirlNames = new List<string> { "Anna", "Johanna", "Eva", "Mathilda", "Greta" };
        static List<string> germanBoyNames = new List<string> { "Felix", "Max", "Jakob", "Theo", "Mats" };
        static List<string> argieGirlNames = new List<string> { "Sofia", "Emilia", "Zoelie", "Valentina", "Amaya" };
        static List<string> argieBoyNames = new List<string> { "Santiago", "Alejandro", "Nicolas", "Sebastian", "Matias" };

        public static string Name1Gal(string x)
        {
            Random fixer = new Random();
            
            
            if (x == "french" || x == "French")
            {
               return frenchGirlNames[fixer.Next(frenchGirlNames.Count)]; 
            }
            else if (x == "spanish" || x == "Spanish")
            {
               return spanishGirlNames[fixer.Next(spanishGirlNames.Count)];
            }
            else if (x == "english" || x == "English")
            {
                return englishGirlNames[fixer.Next(englishGirlNames.Count)];
            }
            else if (x == "italian" || x == "Italian")
            {
                return italianGirlNames[fixer.Next(italianGirlNames.Count)];
            }
            else if (x == "israeli" || x == "Israeli")
            {
                return israeliGirlNames[fixer.Next(israeliGirlNames.Count)];
            }
            else if (x == "japanese" || x == "Japanese")
            {
                return japaneseGirlNames[fixer.Next(japaneseGirlNames.Count)];
            }
            else if (x == "german" || x == "German")
            {
                return germanGirlNames[fixer.Next(germanGirlNames.Count)];
            }
            else if (x == "argentinian" || x == "Argentinian")
            {
                return argieGirlNames[fixer.Next(argieGirlNames.Count)];
            }
            return "poop";
        }


        public static string Name1Boi(string x)
        {
            Random fixer = new Random();


            if (x == "french" || x == "French")
            {
                return frenchBoyNames[fixer.Next(frenchBoyNames.Count)];
            }
            else if (x == "spanish" || x == "Spanish")
            {
                return spanishBoyNames[fixer.Next(spanishBoyNames.Count)];
            }
            else if (x == "english" || x == "English")
            {
                return englishBoyNames[fixer.Next(englishBoyNames.Count)];
            }
            else if (x == "italian" || x == "Italian")
            {
                return italianBoyNames[fixer.Next(italianBoyNames.Count)];
            }
            else if (x == "israeli" || x == "Israeli")
            {
                return israeliBoyNames[fixer.Next(israeliBoyNames.Count)];
            }
            else if (x == "japanese" || x == "Japanese")
            {
                return japaneseBoyNames[fixer.Next(japaneseBoyNames.Count)];
            }
            else if (x == "german" || x == "German")
            {
                return germanBoyNames[fixer.Next(germanBoyNames.Count)];
            }
            else if (x == "argentinian" || x == "Argentinian")
            {
                return argieBoyNames[fixer.Next(argieBoyNames.Count)];
            }
            return "poop";
        }

    }
}