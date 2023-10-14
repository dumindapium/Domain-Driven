namespace Domain.Products
{
    public record Sku
    {
        private const int defaultLength = 15;
        public string Value { get; init; }

        private Sku(string value)=> Value = value;

        public static Sku? Create(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return null;
            }
            if (value.Length != defaultLength)
            {
                return null;
            }
            return new Sku(value);
        }
    }
}
