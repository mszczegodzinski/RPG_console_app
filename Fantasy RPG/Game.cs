using Fantasy_RPG.App.Concrete;
using System;

namespace Fantasy_RPG
{
    class Game
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(
            //    "Choose the character (type only numbers from the range 1-4) : \r\n" +
            //    "1. Warrior \r\n" +
            //    "2. Necromancer \r\n" +
            //    "3. Sorcerer \r\n" +
            //    "4. Amazon \r\n");
            Console.WriteLine("Welcome tireless wanderer!");
            Console.WriteLine("Write your name: ");
            string playerName = Console.ReadLine();
            //TODO: save the player's name
            Console.WriteLine(
                "Choose the character (type only numbers from the range 1-2) : \r\n" +
                "1. Warrior \r\n" +
                "2. Amazon \r\n");
            int characterNo;
            bool isCharacterNoCorrect = Int32.TryParse(Console.ReadLine(), out characterNo);
            bool correctCharacter = false;

            while (!isCharacterNoCorrect && !correctCharacter)
            {
                if (characterNo > 0 && characterNo <= 2)
                {
                    isCharacterNoCorrect = Int32.TryParse(Console.ReadLine(), out characterNo);
                    correctCharacter = true;
                }
                else
                {
                    Console.WriteLine("Incorrect type of character. Try again.");
                    Console.WriteLine(
                        "Choose the character (type only numbers from the range 1-2) : \r\n" +
                        "1. Warrior \r\n" +
                        "2. Amazon \r\n");
                    isCharacterNoCorrect = Int32.TryParse(Console.ReadLine(), out characterNo);
                }

            }

            CharacterService characterService = new CharacterService();

            string characterArticle = characterNo == 2 ? "an" : "a";
            //string characterType = characterService.GetItem(characterNo).ToString();
            Console.WriteLine($"Welcome {playerName}, you chose {characterArticle} {characterService.GetItem(characterNo)}");
            //TODO: build a character
            var character = characterService.GetItem(characterNo);
            Console.WriteLine(character);
            //TODO: start game in first location
        }
    }
}
