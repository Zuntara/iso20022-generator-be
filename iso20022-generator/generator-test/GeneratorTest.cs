using OkiOki.Iso20022.Generator.entity.Transactions;
using System;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace OkiOki.Iso20022.Generator.Tests
{
    public class GeneratorTest
    {
        public GeneratorTest(ITestOutputHelper testOutputHelper)
        {
            TestOutputHelper = testOutputHelper;
        }

        public ITestOutputHelper TestOutputHelper { get; }

        [Fact]
        public async Task MakeBelgianTransaction_Empty_TransactionsAsync()
        {
            CreditTransferFile file = CreditTransferFile.CreateForOkiOki(DateTime.Now.AddDays(10));

            var generator = Iso20022Pain001Generator.CreateAndAddCreditTransferFile(file);
            string retph = await generator.GenerateValidatedXmlAsync(true);
            
            TestOutputHelper.WriteLine(retph ?? string.Empty);

            Assert.True(string.IsNullOrWhiteSpace(retph));

            Assert.False(Iso20022Pain001Generator.ValidateXml(retph));
        }

        [Fact]
        public async Task MakeBelgianTransactionAsync()
        {
            CreditTransferFile file = CreditTransferFile.CreateForOkiOki(DateTime.Now.AddDays(10));
 
            // Belgian structured message
            file.AddTransaction(new CreditTransferTransaction
            {
                AmountInEuro = 535.25m,
                End2EndIdentification = "69-10",
                ReceiverIdentification = new CreditTransferIdentification("SocMetal", "BE78310000000086", null)
                {
                    StreetName = "Hoogstraat",
                    StreetNumber = "156",
                    Zip = "2000",
                    City = "Antwerp",
                    CountryCode = "BE"
                },
                PaymentReference = "010806817183",
                PaymentReferenceIsIso = false,
                PaymentReferenceIsStructured = true
            });

            // ISO Structured message
            file.AddTransaction(new CreditTransferTransaction
            {
                AmountInEuro = 1400m,
                End2EndIdentification = "70-11",
                ReceiverIdentification = new CreditTransferIdentification("Telephone Company", "FR1420041010050500013M02606", null)
                {
                    StreetName = "Hoogstraat",
                    StreetNumber = "200",
                    Zip = "2000",
                    City = "Antwerp",
                    CountryCode = "BE"
                },
                PaymentReference = "RF98123456789012345678901",
                PaymentReferenceIsIso = true,
                PaymentReferenceIsStructured = true
            });

            // Unstructured message
            file.AddTransaction(new CreditTransferTransaction
            {
                AmountInEuro = 100m,
                End2EndIdentification = "71-12",
                ReceiverIdentification = new CreditTransferIdentification("Electricity Company", "BE78310000000086", null)
                {
                    StreetName = "Hoogstraat",
                    StreetNumber = "156",
                    Zip = "2000",
                    City = "Antwerp",
                    CountryCode = "BE"
                },
                PaymentReference = "Electricity bill F/12345/45689",
                PaymentReferenceIsIso = false,
                PaymentReferenceIsStructured = false
            });

            var generator = Iso20022Pain001Generator.CreateAndAddCreditTransferFile(file);
            string retph = await generator.GenerateValidatedXmlAsync(true);

            TestOutputHelper.WriteLine(retph);

            Assert.True(Iso20022Pain001Generator.ValidateXml(retph));
        }

        [Fact]
        public async Task MakeBelgianTransaction_three_payments_Async()
        {
            CreditTransferFile file1 = CreditTransferFile.CreateForOkiOki(DateTime.Now.AddDays(10));
 
            // Belgian structured message
            file1.AddTransaction(new CreditTransferTransaction
            {
                AmountInEuro = 535.25m,
                End2EndIdentification = "69-10",
                ReceiverIdentification = new CreditTransferIdentification("SocMetal", "BE78310000000086", null)
                {
                    StreetName = "Hoogstraat",
                    StreetNumber = "156",
                    Zip = "2000",
                    City = "Antwerp",
                    CountryCode = "BE"
                },
                PaymentReference = "010806817183",
                PaymentReferenceIsIso = false,
                PaymentReferenceIsStructured = true
            });

            CreditTransferFile file2 = CreditTransferFile.CreateForOkiOki(DateTime.Now.AddDays(10));
            // ISO Structured message
            file2.AddTransaction(new CreditTransferTransaction
            {
                AmountInEuro = 1400m,
                End2EndIdentification = "70-11",
                ReceiverIdentification = new CreditTransferIdentification("Telephone Company", "FR1420041010050500013M02606", null)
                {
                    StreetName = "Hoogstraat",
                    StreetNumber = "200",
                    Zip = "2000",
                    City = "Antwerp",
                    CountryCode = "BE"
                },
                PaymentReference = "RF98123456789012345678901",
                PaymentReferenceIsIso = true,
                PaymentReferenceIsStructured = true
            });

            // Unstructured message
            CreditTransferFile file3 = CreditTransferFile.CreateForOkiOki(DateTime.Now.AddDays(10));
            file3.AddTransaction(new CreditTransferTransaction
            {
                AmountInEuro = 100m,
                End2EndIdentification = "71-12",
                ReceiverIdentification = new CreditTransferIdentification("Electricity Company", "BE78310000000086", null)
                {
                    StreetName = "Hoogstraat",
                    StreetNumber = "156",
                    Zip = "2000",
                    City = "Antwerp",
                    CountryCode = "BE"
                },
                PaymentReference = "Electricity bill F/12345/45689",
                PaymentReferenceIsIso = false,
                PaymentReferenceIsStructured = false
            });

            var generator = Iso20022Pain001Generator.CreateAndAddCreditTransferFile(file1);
            generator.AddCreditTransferFilePayment(file2);
            generator.AddCreditTransferFilePayment(file3);

            string retph = await generator.GenerateValidatedXmlAsync(true);

            TestOutputHelper.WriteLine(retph);

            Assert.True(Iso20022Pain001Generator.ValidateXml(retph));
        }
    }
}