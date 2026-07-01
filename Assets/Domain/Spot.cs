namespace RomanSpots.Domain
{
    public sealed class Spot
    {
        public string Id { get; }
        public string Name { get; }
        public string Prefecture { get; }
        public string Category { get; }
        public string Description { get; }
        public string ImageAddress { get; }
        public string MapUrl { get; }
        public string ReferenceUrl { get; }

        public Spot(string id, string name, string prefecture, string category, string description, string imageAddress, string mapUrl, string referenceUrl)
        {
            Id = id;
            Name = name;
            Prefecture = prefecture;
            Category = category;
            Description = description;
            ImageAddress = imageAddress;
            MapUrl = mapUrl;
            ReferenceUrl = referenceUrl;
        }
    }
}
