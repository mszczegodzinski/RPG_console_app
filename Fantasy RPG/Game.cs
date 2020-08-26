using Fantasy_RPG.App.Concrete;
using Fantasy_RPG.domain.Common;
using System;

namespace Fantasy_RPG
{
    class Game
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome tireless wanderer!");
            Console.WriteLine("Write your name: ");
            string playerName = Console.ReadLine();
            //Choose a character type (only int 1 or 2):
            Console.WriteLine(
                "Choose the character (type only numbers from the range 1-2) : \r\n" +
                "1. Warrior \r\n" +
                "2. Amazon \r\n");
            int characterNo;
            bool isCharacterNoCorrect = Int32.TryParse(Console.ReadLine(), out characterNo);
            Console.WriteLine(!isCharacterNoCorrect);
            bool isCorrectRange = false;

            //if input is incorrect, try until it will be correct:
            while (!isCharacterNoCorrect)
            {
                while (!isCorrectRange)
                {
                    if (characterNo > 0 && characterNo <= 2)
                    {
                        isCorrectRange = true;
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
            }

            //initalizing all characters:
            CharacterService characterService = new CharacterService();
            string characterType = characterService.GetItem(characterNo).ToString();
            //greeting the player using his name and chosen character type: 
            Console.WriteLine($"Welcome {playerName}, you chose the {characterType}");
            //build the chosen character:
            var character = characterService.GetItem(characterNo);

            //initialize the board:
            LocationService locationService = new LocationService();
            bool isEndGame = false;
            int currentLocationCounter = 1;
            var currentLocation = locationService.GetItem(currentLocationCounter);
            var random = new Random();
            int turn = 1;

            //start game in first location:
            while (!isEndGame)
            {
                Console.WriteLine("");
                Console.WriteLine($"Turn {turn}");
                Console.WriteLine($"{currentLocation.Id}. {currentLocation.Name}");
                Console.WriteLine(currentLocation.Description);
                Console.WriteLine("Press any button to move on");
                Console.ReadLine();

                int goToNextLocation = random.Next(1, 4);
                currentLocationCounter += goToNextLocation;
                if(currentLocationCounter > locationService.GetLength())
                {
                    currentLocationCounter -= locationService.GetLength();
                }
                currentLocation = locationService.GetItem(currentLocationCounter);
                turn++;

                //temporary condition to end game:
                if (turn == 25)
                {
                    isEndGame = true;
                }


            }


        }
    }
}
