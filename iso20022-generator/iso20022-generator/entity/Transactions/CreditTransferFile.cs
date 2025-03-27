namespace OkiOki.Iso20022.Generator.entity.Transactions
{
    public class CreditTransferFile
    {
        private CreditTransferFile(DateTime executionTime, CreditTransferIdentification senderIdentification)
        {
            ExecutionTime = executionTime;
            SenderIdentification = senderIdentification;
        }

        public static CreditTransferFile CreateForOkiOki(DateTime executionTime)
        {
            CreditTransferFile file = new CreditTransferFile(
                executionTime,
                new CreditTransferIdentification("OkiOki", "BE19000000001212", "BBBRUBB")
                {
                    CountryCode = "BE"
                });

            return file;
        }

        public static CreditTransferFile Create(string name, string iban, string bic, string countryIsoCode, DateTime executionTime)
        {
            CreditTransferFile file = new CreditTransferFile(
                executionTime,
                new CreditTransferIdentification(name, iban, bic)
                {
                    CountryCode = countryIsoCode
                });

            return file;
        }

        public void AddTransaction(CreditTransferTransaction transaction)
        {
            Transactions.Add(transaction);
        }

        /// <summary>
        /// Check if a payment reference is already used in the file
        /// </summary>
        /// <param name="reference">Reference to check (structured or unstructured)</param>
        /// <returns></returns>
        public bool HasPaymentReferenceAlready(string reference)
        {
            string cleanedReference = reference.Replace("+", string.Empty).Replace("/", string.Empty).Trim();
            return Transactions.Any(t => t.PaymentReference == reference);
        }

        /// <summary>
        /// List of transactions in the file
        /// </summary>
        internal List<CreditTransferTransaction> Transactions { get; } = [];

        /// <summary>
        /// Execution time of the file
        /// </summary>
        public DateTime ExecutionTime { get; }

        /// <summary>
        /// Identification of the sender
        /// </summary>
        public CreditTransferIdentification SenderIdentification { get; }
    }
}
