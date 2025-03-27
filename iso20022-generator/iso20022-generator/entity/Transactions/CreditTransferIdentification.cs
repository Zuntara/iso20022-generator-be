namespace OkiOki.Iso20022.Generator.entity.Transactions
{
    public record CreditTransferIdentification(string Name, string Iban, string Bic)
    {
        private string _countryCode;

        public string? Name { get; } = Name;
        public string? Iban { get; } = Iban;
        public string? Bic { get; } = Bic;

        public string? StreetName { get; set; }
        public string? StreetNumber { get; set; }
        public string? Zip { get; set; }
        public string? City { get; set; }

        public required string CountryCode
        {
            get => _countryCode;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length != 2)
                {
                    throw new ArgumentException("CountryCode is not valid - must be 2 characters", nameof(value));
                }

                _countryCode = value;
            }
        }
    }
}
