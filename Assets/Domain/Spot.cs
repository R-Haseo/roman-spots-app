namespace RomanSpots.Domain
{
    public sealed class Spot
    {
        public string Name { get; }

        public Spot(string name)
        {
            Name = name;
        }
    }
}
