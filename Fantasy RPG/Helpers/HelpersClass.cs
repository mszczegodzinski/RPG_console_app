using Fantasy_RPG.domain.Common;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Fantasy_RPG.Helpers
{
    public class HelpersClass
    {
        public HelpersClass()
        {
        }
        //calculate type of event:
        private string EventTypeGeneral(int idLocation)
        {
            var random = new Random();
            int enemyAttacks = random.Next(1, 6);   
            int findGold = random.Next(1, 4);       
            int nothingHappens = random.Next(1, 7); 
            string result = "";

            //check if location isn't the city, camp, village, library:
            if(idLocation != 1 && idLocation != 7 && idLocation != 10 && idLocation != 13 && idLocation != 14)
            {
                if (enemyAttacks >= nothingHappens)
                {
                    if (enemyAttacks >= findGold)
                    {
                        result = "Enemy attacks you!";
                    }
                    else
                    {
                        result = "You found a gold";
                    }
                }
                else if (nothingHappens > enemyAttacks)
                {
                    if (nothingHappens >= findGold)
                    {
                        result = "Nothing happens";
                    }
                    else
                    {
                        result = "You find a gold";
                    }
                }
            }
            else
            {
                if (nothingHappens >= findGold)
                {
                    result = "Nothing happens";
                }
                else
                {
                    result = "You found a gold";
                }
            }


            //specify type of enemy:
            if(result == "Enemy attacks you!")
            {
                switch (idLocation)
                {
                    //suburbs:
                    case 2:
                    case 20:
                        result = "Bandit attacks you!";
                        break;
                    //forest:
                    case 3:
                    case 5:
                    case 9:
                    case 12:
                        result = "Wolf attacks you!";
                        break;
                    //graveyard:
                    case 4:
                        result = "Zombie attacks you!";
                        break;
                    //plains:
                    case 6:
                    case 8:
                    case 11:
                    case 19:
                        result = "Robber attacks you!";
                        break;
                    //dark forest:
                    case 15:
                    case 18:
                        result = "Ghost attacks you!";
                        break;
                    //swamp:
                    case 16:
                        result = "Hydra attacks you!";
                        break;
                    //abandoned tower:
                    case 17:
                        result = "Warlock attacks you!";
                        break;
                    default:
                        result = "Incorrect enemy value";
                        break;
                }
            }
            return result;
        }
        public string LocationEvent(int idLocation)
        {
            
            var random = new Random();
            string result = "";
            switch (idLocation)
            {
                //city:
                case 1:
                    Console.WriteLine("City event: ");
                    result = this.EventTypeGeneral(idLocation);
                    break;
                //suburbs:
                case 2:
                case 20:
                    Console.WriteLine("Suburbs event: ");
                    result = this.EventTypeGeneral(idLocation);
                    break;
                //forest:
                case 3:
                case 5:
                case 9:
                case 12:
                    Console.WriteLine("Forest event: ");
                    result = this.EventTypeGeneral(idLocation);
                    break;
                //graveyard:
                case 4:
                    Console.WriteLine("Graveyard event: ");
                    result = this.EventTypeGeneral(idLocation);
                    break;
                //plains:
                case 6:
                case 8:
                case 11:
                case 19:
                    Console.WriteLine("Plains event: ");
                    result = this.EventTypeGeneral(idLocation);
                    break;
                //camp:
                case 7:
                    Console.WriteLine("Camp event: ");
                    result = this.EventTypeGeneral(idLocation);
                    break;
                //temple:
                case 10:
                    Console.WriteLine("Temple event: ");
                    result = this.EventTypeGeneral(idLocation);
                    break;
                //village:
                case 13:
                    Console.WriteLine("Village event: ");
                    result = this.EventTypeGeneral(idLocation);
                    break;
                //library:
                case 14:
                    Console.WriteLine("Library event: ");
                    result = this.EventTypeGeneral(idLocation);
                    break;
                //dark forest:
                case 15:
                case 18:
                    Console.WriteLine("Dark forest event: ");
                    result = this.EventTypeGeneral(idLocation);
                    break;
                //swamp:
                case 16:
                    Console.WriteLine("Swamp event: ");
                    result = this.EventTypeGeneral(idLocation);
                    break;
                //abandoned tower:
                case 17:
                    Console.WriteLine("Abandoned tower event: ");
                    result = this.EventTypeGeneral(idLocation);
                    break;
                default:
                    result = "Incorrect event value";
                    break;
            }
            return result;
        }
    }
}
