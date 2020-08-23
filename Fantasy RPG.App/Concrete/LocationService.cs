using Fantasy_RPG.domain.Common;
using System.Collections.Generic;

namespace Fantasy_RPG.App.Concrete
{
    class LocationService
    {

        public LocationService()
        {
            InitializeLocations();
        }

        public void InitializeLocations()
        {
            List<Location> Locations = new List<Location>();
            string cityDecription = "Safe place to rest and improve your skills. You can buy here an equipment, earn some gold or spent your time in the tavern";
            string suburbsDecription = "You are in the suburbs. Watch out for bandits or thiefs";
            string graveyardDecription = "This place isn't nice. You have a strange feeling like someone is watching you";
            string forestDecription = "Sound of wind, birds, but be careful of wild animals";
            string plainDecription = "";
            string campDecription = "A little camp in the middle of plain. Take a rest. You can regenerate your health points here and help these people with their duties";
            string templeDecription = "";
            string villageDecription = "You've just arrived to the village. ";
            string libraryDecription = "Quiet and safe place. You may improve your skills if you ";
            string darkForestDecription = "Dark, thick and disturbing place. Some people said they saw the ghosts of the lost wayfarers. Don't spend too much time in this place";
            string swampDecription = "Uninhabitated and wild place. Mind for your steps";
            string abandonedTowerDecription = "Cursed place. These properdy owned to a warlock many years ago. It looks like forsaken now, but notice in front of says 'get out of here if you want to be alive'. Maybe I should come back later when I'll be better prepared?";

            Locations.Add(new Location(1, "City", cityDecription));
            Locations.Add(new Location(2, "Suburbs", suburbsDecription));
            Locations.Add(new Location(3, "Forest", forestDecription));
            Locations.Add(new Location(4, "Graveyard", graveyardDecription));
            Locations.Add(new Location(5, "Forest", forestDecription));
            Locations.Add(new Location(6, "Plain", plainDecription));
            Locations.Add(new Location(7, "Camp", campDecription));
            Locations.Add(new Location(8, "Plain", plainDecription));
            Locations.Add(new Location(9, "Forest", forestDecription));
            Locations.Add(new Location(10, "Temple", templeDecription));
            Locations.Add(new Location(11, "Plain", plainDecription));
            Locations.Add(new Location(12, "Forest", forestDecription));
            Locations.Add(new Location(13, "Village", villageDecription));
            Locations.Add(new Location(14, "Library", libraryDecription));
            Locations.Add(new Location(15, "Dark forest", darkForestDecription));
            Locations.Add(new Location(16, "Swamp", swampDecription));
            Locations.Add(new Location(17, "Abandoned tower", abandonedTowerDecription));
            Locations.Add(new Location(18, "Dark forest", darkForestDecription));
            Locations.Add(new Location(19, "Plain", plainDecription));
            Locations.Add(new Location(20, "Suburbs", suburbsDecription));
        }
    }
}
