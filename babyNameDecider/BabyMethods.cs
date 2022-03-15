using System;
using System.Collections.Generic;

namespace babyNameDecider
{
   
    
        public class BabyMethods
        {
        
        public static string GenderValid(string x)

        {
            
            while (!(x == "boy" || x== "Boy" || x == "girl" || x == "Girl"))
            {
                Console.WriteLine("Watch that spelling! Try again...");
                x = Console.ReadLine();
            }
           
            return x;
        }

        public static bool BoiOrGal(string x)
        {
            if (x == "boy" || x == "Boy")
            {
                return true;
            }
            else return false;   
        }

        public static string NationPref(string x)
        {
            while (!(x == "french" || x == "French" || x == "spanish" || x == "Spanish" || x == "english" || x == "English" || x == "italian" || x == "Italian" ||
                x == "israeli" || x == "Israeli" || x == "japanese" || x == "Japanese" || x == "german" || x == "German" || x == "argentinian" || x == "Argentinian"))
            {
                Console.WriteLine("Watch that spelling! Try again...");
                x = Console.ReadLine();
            }

            return x;
        }
        

            
    }

}
