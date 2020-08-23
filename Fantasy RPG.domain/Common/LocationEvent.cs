namespace Fantasy_RPG.domain.Common
{
    public class LocationEvent
    {
        public int Id { get; }
        public string Description { get; set; }


        public LocationEvent(string description)
        {
            Description = description;
        }
    }
}
