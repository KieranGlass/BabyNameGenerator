using System;
using System.Collections.Generic;

namespace babyNameDecider
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello there! What is your name!? \n");
            string mumName = Console.ReadLine();
            Console.WriteLine("\n" + mumName + "! What a lovely name...... How far away is your due date? \n");
            string dueDate = Console.ReadLine();
            Console.WriteLine("\nYou're having a baby in " + dueDate + " and you haven't chosen a name yet!"); Console.WriteLine("Oh la la la, Don't worry, i can help! Are you having a boy or girl!? (Correct Spelling Please) \n");
            string genderAnswer = Console.ReadLine();
            string realGender = BabyMethods.GenderValid(genderAnswer);
          
            Console.WriteLine("\nA " + realGender + "! Congratulations!"); Console.WriteLine("What will the childs surname be? \n");
            string lastName = Console.ReadLine();

            bool genderBool = BabyMethods.BoiOrGal(realGender);

            List<string> nations = new List<string> { "French", "Spanish", "English", "Italian", "Israeli", "Japanese", "German", "Argentinian" };
            Console.WriteLine("\nWhich of the following nationalities would you consider your number 1 preference for names? \n");
            foreach (string pays in nations)
            {
                Console.WriteLine(pays + "\t");
            }
            Console.WriteLine("\n");
            string natPref1 = BabyMethods.NationPref(Console.ReadLine());
            Console.WriteLine("\n" + natPref1 + "! What would be your second choice? \n");
            string natPref2 = BabyMethods.NationPref(Console.ReadLine());
            Console.WriteLine("\nOk! " + natPref1 + " and " + natPref2 + "!" + "\n");

            Console.WriteLine("\nAre you ready " + mumName + ", There's no going back!? [PRESS ENTER] ");
            Console.ReadLine();

            if (genderBool == false)
            {
                Console.WriteLine("Name 1) " + BabyNames.Name1Gal(natPref1) + " " + lastName);
                Console.WriteLine("Name 2) " + BabyNames.Name1Gal(natPref2) + " " + lastName);
            }
            else
            {
                Console.WriteLine("Name 1) " + BabyNames.Name1Boi(natPref1) + " " + lastName);
                Console.WriteLine("Name 2) " + BabyNames.Name1Boi(natPref2) + " " + lastName);
            }
            Console.ReadLine();
        }
    }
}
