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
            Locations.Add(new Location(1, "City", "City description"));
            Locations.Add(new Location(2, "Suburbs", "Suburbs description"));
            Locations.Add(new Location(3, "Hills", "Hills description"));
            Locations.Add(new Location(4, "Graveyard", "Graveyard description"));
            Locations.Add(new Location(5, "Forest", "Forest description"));
            Locations.Add(new Location(6, "Plain", "Plain description"));
            Locations.Add(new Location(7, "Camp", "camp description"));
            Locations.Add(new Location(8, "Plain", "Plain description"));
            Locations.Add(new Location(9, "Forest", "Forest description"));
            Locations.Add(new Location(10, "Temple", "Temple description"));
            Locations.Add(new Location(11, "Plain", "Plain description"));
            Locations.Add(new Location(12, "Forest", "Forest description"));
            Locations.Add(new Location(13, "Village", "Village description"));
            Locations.Add(new Location(14, "Library", "Library description"));
            Locations.Add(new Location(15, "Dark forest", "Dark forest description"));
            Locations.Add(new Location(16, "Swamp", "Swamp description"));
            Locations.Add(new Location(17, "Abandoned residence", "Abandoned residence description"));
            Locations.Add(new Location(18, "Dark forest", "Dark forest description"));
            Locations.Add(new Location(19, "Plain", "Plain description"));
            Locations.Add(new Location(20, "Suburbs", "Suburbs description"));
        }
    }
}
