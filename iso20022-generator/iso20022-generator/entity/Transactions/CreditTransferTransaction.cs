namespace OkiOki.Iso20022.Generator.entity.Transactions
{
    public class CreditTransferTransaction
    {
        private string? _paymentReference;
        public string? PaymentReference 
        {
            get { return _paymentReference; }
            set
            { 
                _paymentReference = value?.Replace("+", string.Empty).Replace("/", string.Empty).Trim();
            }
        }
        public bool PaymentReferenceIsStructured { get; set; }
        public bool PaymentReferenceIsIso { get; set; }

        public decimal AmountInEuro { get; set; }

        public required string End2EndIdentification { get; set; }

        public required CreditTransferIdentification ReceiverIdentification { get; set; }
    }
}
