namespace RomanSpots.Domain
{
    public sealed class Spot
    {
        public string Id { get; }
        public string Name { get; }
        public string Prefecture { get; }
        public string Category { get; }

        public Spot(string id, string name, string prefecture, string category)
        {
            Id = id;
            Name = name;
            Prefecture = prefecture;
            Category = category;
        }
    }
}
