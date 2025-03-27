using Microsoft.Extensions.Logging;
using OkiOki.Iso20022.Generator.entity.Transactions;
using OkiOki.Iso20022.Generator.Entity;
using OkiOki.Iso20022.Generator.Schema;
using System.Reflection;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace OkiOki.Iso20022.Generator
{
    public class Iso20022Pain001Generator
    {
        private readonly Document doc = new Document();
        private readonly List<PaymentInstruction30> pmtInfList = []; // Index 2.0
        private readonly CustomerCreditTransferInitiationV09 cstmrCdtTrfInitn = new();
        private readonly GroupHeader85 grpHdr = new(); // Index 1.0
        
        /// <summary>
        /// Initializes a new generator which allows creating ISO20022-pain.001 files.
        /// </summary>
        /// <param name="init">Object with all the required information for setting up a new transaction document.</param>
        private Iso20022Pain001Generator(Initialization init, Sender sender)
        {
            Initialization = init;
            
            doc.CstmrCdtTrfInitn = cstmrCdtTrfInitn;

            // Level A
            cstmrCdtTrfInitn.GrpHdr = grpHdr; // Index 1.0
            grpHdr.MsgId = init.UniqueDocumentId; // Index 1.1 / Required for duplication check
            grpHdr.CreDtTm = DateTime.Now; // Index 1.2
            grpHdr.NbOfTxs = "0"; // Index 1.6
            grpHdr.CtrlSum = init.ControlSum; // Index 1.7
            if (init.ControlSum > 0)
            {
                grpHdr.CtrlSumSpecified = true;
            }

            PartyIdentification135 initPty = new PartyIdentification135(); // Index 1.8
            grpHdr.InitgPty = initPty; // Index 1.8

            initPty.Nm = sender.SenderPartyName; // Index 1.8 - Name
            Contact4 ctctDtls = new Contact4(); // Index 1.8
            initPty.CtctDtls = ctctDtls; // Index 1.8 - Contact Details
            ctctDtls.Nm = init.ContactDetailsName; // Index 1.8 - Contact Details.Name
            ctctDtls.Othr = new[] { 
                new OtherContact1 {
                    Id = init.ContactDetailsOther   // Index 1.8 - Contact Details.Other
                } 
            };
            Sender = sender;
        }

        private PaymentInstruction30 AddPaymentInfo(DateTime requiredExecutionDate, string paymentMethod = "TRF", bool batchBookingSpezified = false)
        {
            if (requiredExecutionDate.Date < DateTime.Now.Date)
                throw new ArgumentException("ExecutionDate cannot be in the past");

            // Level B
            PaymentInstruction30 pmtInf = new PaymentInstruction30();

            pmtInf.PmtInfId = $"PmtInfId-{pmtInfList.Count + 1}"; // Index 2.1

            PaymentMethod3Code pmtMtd;
            if (Enum.TryParse(paymentMethod, true, out pmtMtd) == false)
            {
                throw new InvalidCastException($"Invalid payment method '{paymentMethod}'");
            }

            pmtInf.PmtMtd = pmtMtd; // Index 2.2
            pmtInf.BtchBookgSpecified = batchBookingSpezified;
            pmtInf.BtchBookg = true; // Index 2.3

            pmtInf.ReqdExctnDt = new DateAndDateTime2Choice { Item = requiredExecutionDate }; // Index 2.17
            PartyIdentification135 dbtr = new PartyIdentification135(); // Index 2.19
            pmtInf.Dbtr = dbtr;

            dbtr.Nm = Sender.SenderPartyName;

            CashAccount38 dbtrAcct = new CashAccount38(); // Index 2.20
            pmtInf.DbtrAcct = dbtrAcct;
            AccountIdentification4Choice dbtrAcctId = new AccountIdentification4Choice(); // Index 2.20 / Id
            dbtrAcct.Id = dbtrAcctId;
            dbtrAcctId.Item = Sender.SenderIban; // Index 2.20 / Id / IBAN  Bezugs-Konto

            BranchAndFinancialInstitutionIdentification6 dbtrAgt = new BranchAndFinancialInstitutionIdentification6(); // Index 2.21
            pmtInf.DbtrAgt = dbtrAgt;

            // Add BIC only if is set to guarantee the compatibility to the old version
            FinancialInstitutionIdentification18 finInstnIdDbtr = new FinancialInstitutionIdentification18(); // Index 2.21 / Financial Institution Identification
            if (!string.IsNullOrEmpty(Sender.SenderBic)) // Index 2.21
            {
                finInstnIdDbtr.BICFI = Sender.SenderBic;
            }

            dbtrAgt.FinInstnId = finInstnIdDbtr;

            // Level C
            pmtInf.CdtTrfTxInf = Array.Empty<CreditTransferTransaction34>(); // Index 2.27

            pmtInfList.Add(pmtInf);

            return pmtInf;
        }

        private PaymentInstruction30 AddCreditTransferInfo(DateTime requiredExecutionDate, bool batchBookingSpezified = false)
        {
            return AddPaymentInfo(requiredExecutionDate, "TRF", batchBookingSpezified);
        }

        /// <summary>
        /// Adds a new transaction to the document
        /// </summary>
        /// <param name="receiver">Object with all the required information about the receiver of the new transaction</param>
        /// <param name="transaction">Object with all the required information about the transaction itself</param>
        private void AddTransaction(PaymentInstruction30 pmtInf, CreditTransferIdentification receiver, CreditTransferTransaction transaction)
        {
            CreditTransferTransaction34 cdtTrfTxInf = new CreditTransferTransaction34(); // Index 2.27

            PaymentIdentification6 pmtId = new PaymentIdentification6(); // Index 2.28
            cdtTrfTxInf.PmtId = pmtId;
            pmtId.InstrId = "1-" + pmtInf.CdtTrfTxInf.Length; // Index 2.29
            pmtId.EndToEndId = transaction.End2EndIdentification; // Index 2.30

            AmountType4Choice amt = new AmountType4Choice(); // Index 2.42
            cdtTrfTxInf.Amt = amt;

            ActiveOrHistoricCurrencyAndAmount currencyAndAmount = new ActiveOrHistoricCurrencyAndAmount(); // Index 2.43
            amt.Item = currencyAndAmount;
            currencyAndAmount.Ccy = "EUR";
            currencyAndAmount.Value = transaction.AmountInEuro;

            if (!string.IsNullOrWhiteSpace(receiver.Name))
            {
                PartyIdentification135 cdtr = new PartyIdentification135(); // Index 2.79

                cdtTrfTxInf.Cdtr = cdtr;
                cdtr.Nm = receiver.Name; // Index 2.79 / Name
                if (!string.IsNullOrWhiteSpace(receiver.City))
                {
                    PostalAddress24 pstlAdr = new PostalAddress24(); // Index 2.77 / Postal Address
                    cdtr.PstlAdr = pstlAdr;
                    
                    if (!string.IsNullOrWhiteSpace(receiver.StreetName))
                    {
                        pstlAdr.StrtNm = receiver.StreetName; // Index 2.77 / Street Name
                    }

                    if (!string.IsNullOrWhiteSpace(receiver.StreetNumber))
                    {
                        pstlAdr.BldgNb = receiver.StreetNumber; // Index 2.77 / Building Number
                    }

                    if (!string.IsNullOrWhiteSpace(receiver.Zip))
                    {
                        pstlAdr.PstCd = receiver.Zip; // Index 2.77 / Post Code
                    }

                    if (!string.IsNullOrWhiteSpace(receiver.City))
                    {
                        pstlAdr.TwnNm = receiver.City; // Index 2.77 / Town Name
                    }

                    if (!string.IsNullOrWhiteSpace(receiver.CountryCode))
                    {
                        pstlAdr.Ctry = receiver.CountryCode; // Index 2.77 / Country
                    }
                }
            }

            CashAccount38 cdtrAcct = new CashAccount38(); // Index 2.80
            cdtrAcct.Id = new AccountIdentification4Choice(); // Index 2.80 / Identification
            cdtTrfTxInf.CdtrAcct = cdtrAcct;

            if (transaction.GetType() == typeof(CreditTransferTransaction))
            {
                CreditTransferTransaction transactionIbaNandSCOR = ((CreditTransferTransaction)transaction);

                cdtrAcct.Id.Item = transactionIbaNandSCOR.ReceiverIdentification.Iban; // Index 2.80 / Id / IBAN  Ziel-Konto

                if (!string.IsNullOrWhiteSpace(transactionIbaNandSCOR.ReceiverIdentification.Bic))
                {
                    BranchAndFinancialInstitutionIdentification6 cdtrAgt = new BranchAndFinancialInstitutionIdentification6(); // Index 2.77
                    cdtTrfTxInf.CdtrAgt = cdtrAgt;

                    FinancialInstitutionIdentification18 finInstnIdCdtr = new FinancialInstitutionIdentification18(); // Index 2.77 / Financial Institution Identification
                    cdtrAgt.FinInstnId = finInstnIdCdtr;
                    finInstnIdCdtr.BICFI = transactionIbaNandSCOR.ReceiverIdentification.Bic; // Index 2.21
                }

                // SCOR
                if (!string.IsNullOrWhiteSpace(transactionIbaNandSCOR.PaymentReference)
                    && transactionIbaNandSCOR.PaymentReferenceIsStructured)
                {
                    var rmtInf = new RemittanceInformation16(); // Index 2.126
                    cdtTrfTxInf.RmtInf = rmtInf;
                    rmtInf.Strd = new[]
                    {
                        new StructuredRemittanceInformation16
                        {
                            CdtrRefInf = new CreditorReferenceInformation2
                            {
                                Ref = transactionIbaNandSCOR.PaymentReference,
                                Tp = new CreditorReferenceType2
                                {
                                    CdOrPrtry = new CreditorReferenceType1Choice
                                    {
                                        Item = DocumentType3Code.SCOR
                                    },
                                    Issr = transactionIbaNandSCOR.PaymentReferenceIsIso ? "ISO" : "BBA"
                                }
                            }
                        }
                    };                        
                }
                else
                {
                    if (!string.IsNullOrWhiteSpace(transactionIbaNandSCOR.PaymentReference))
                    {
                        var rmtInf = new RemittanceInformation16();
                        cdtTrfTxInf.RmtInf = rmtInf;
                        rmtInf.Ustrd = [transactionIbaNandSCOR.PaymentReference!];
                    }
                }
            }

            //if (!string.IsNullOrWhiteSpace(transaction.InstructionForDebtorAgent))
            //{
            //    cdtTrfTxInf.InstrForDbtrAgt = transaction.InstructionForDebtorAgent; // Index 2.85
            //}

            // Index 2.81 InstrForCdtrAgt -> The element may only be used in consultation with the commissioned financial institution.
            // This element may have different characteristics and instructions depending on the financial institution.
            //if (transaction.InstructionsForCreditorAgent?.Count > 0)
            //{
            //    cdtTrfTxInf.InstrForCdtrAgt = transaction.InstructionsForCreditorAgent.ToArray();
            //}

            AddNewCreditTransferTransactionInformation(pmtInf, cdtTrfTxInf);
        }

        private void AddNewCreditTransferTransactionInformation(PaymentInstruction30 pmtInf, CreditTransferTransaction34 cdtTrfTxInf)
        {
            var pmtInfCdtTrfTxInf = pmtInf.CdtTrfTxInf;
            Array.Resize(ref pmtInfCdtTrfTxInf, pmtInfCdtTrfTxInf.Length + 1);
            pmtInfCdtTrfTxInf[pmtInfCdtTrfTxInf.Length - 1] = cdtTrfTxInf;
            pmtInf.CdtTrfTxInf = pmtInfCdtTrfTxInf;
        }

        private void UpdateLevelA()
        {
            int total = 0;
            decimal sum = 0;
            cstmrCdtTrfInitn.PmtInf = pmtInfList.ToArray();
            if (Initialization.AutoCalculateControlSum)
            {
                pmtInfList.ForEach(p =>
                {
                    total = total + p.CdtTrfTxInf.Length;
                    foreach (var amt in p.CdtTrfTxInf)
                    {
                        sum = sum + ((ActiveOrHistoricCurrencyAndAmount)amt.Amt.Item).Value;
                    }
                });

                grpHdr.CtrlSum = sum; // Index 1.7
                grpHdr.CtrlSumSpecified = true;
            }

            grpHdr.NbOfTxs = total.ToString(); // Index 1.6
        }

        private async Task SerializeDocumentToXmlAsync(Stream stream, bool formatted)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Document));
            UTF8Encoding utf8e = new UTF8Encoding();
            XmlTextWriter xmlSink = new XmlTextWriter(stream, utf8e)
            {
                Formatting = formatted ? Formatting.Indented : Formatting.None
            };

            xmlSerializer.Serialize(xmlSink, doc);

            await stream.FlushAsync().ConfigureAwait(false);
        }

        /// <summary>
        /// Serializes the generated document object to a given file destination
        /// </summary>
        /// <param name="fileName">Full path to the desired xml file</param>
        public async Task SaveAsync(string fileName, bool formatted = false)
        {
            using FileStream stream = File.Open(fileName, FileMode.Create, FileAccess.ReadWrite);
            await SerializeDocumentToXmlAsync(stream, formatted).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns the xml serialized document object
        /// </summary>
        /// <returns></returns>
        public async Task<string?> GenerateValidatedXmlAsync(bool formatted = false)
        {
            if (pmtInfList.Count == 0)
            {
                return null;
            }

            UpdateLevelA();

            MemoryStream memStrm = new MemoryStream();
            await SerializeDocumentToXmlAsync(memStrm, formatted);
            byte[] utf8EncodedData = memStrm.ToArray();
            string result = Encoding.UTF8.GetString(utf8EncodedData).Replace("encoding=\"utf-8\"", "encoding=\"UTF-8\"");

            return ValidateXml(result) ? result : null;
        }

        /// <summary>
        /// Allows direct access to the generated document object. This method is not thought to
        /// be used under normal conditions however your financial institute maybe requires
        /// setting some addittional properties.
        /// </summary>
        /// <returns>Document object which will be serialized to xml</returns>
        public Document GetDocumentObject()
        {
            return doc;
        }

        /// <summary>
        /// Creates a new generator and adds a credit transfer file payment to it
        /// </summary>
        /// <param name="creditTransferFile">Credit transfer file with transactions for payment</param>
        /// <returns></returns>
        public static Iso20022Pain001Generator CreateAndAddCreditTransferFile(CreditTransferFile creditTransferFile)
        {
            var generator = new Iso20022Pain001Generator(
                new Initialization
                {
                    ContactDetailsName = "OkiOki",
                    AutoCalculateControlSum = true,
                },
                new Sender("OkiOki", "BE19000000001212", "BBBRUBB"));

            generator.AddCreditTransferFilePayment(creditTransferFile);

            return generator;
        }

        /// <summary>
        /// Adds a credit transfer file payment to the document
        /// </summary>
        /// <param name="creditTransferFile">Credit transfer file with transactions for payment</param>
        /// <returns></returns>
        public Iso20022Pain001Generator AddCreditTransferFilePayment(CreditTransferFile creditTransferFile)
        {
            if(!creditTransferFile.Transactions.Any())
            {
                return this;
            }

            var paymentInstruction = AddCreditTransferInfo(creditTransferFile.ExecutionTime, batchBookingSpezified: true);

            foreach (var transaction in creditTransferFile.Transactions)
            {
                AddTransaction(paymentInstruction, transaction.ReceiverIdentification, transaction);
            }

            return this;
        }

        /// <summary>
        /// Validates the given XML string against the ISO20022 XSD schema
        /// </summary>
        /// <param name="xmlString">XML To validate</param>
        /// <param name="logger">Optional logger</param>
        /// <returns>true or false as result of validation</returns>
        public static bool ValidateXml(string? xmlString, ILogger? logger = null)
        {
            try
            {
                if (string.IsNullOrEmpty(xmlString))
                {
                    return false;
                }

                // Verkrijg de XSD als een embedded resource
                string xsdResourceName = "OkiOki.Iso20022.Generator.pain.001.001.09.xsd"; // Gebruik de juiste naam van de resource
                string? xsdContent = GetEmbeddedResource(xsdResourceName);
                if (xsdContent == null)
                {
                    logger?.LogError("XSD resource not found");
                    return false;
                }

                // Maak XmlReaderSettings en voeg het XSD-content toe als schema
                XmlReaderSettings settings = new XmlReaderSettings();
                using (XmlReader xsdReader = XmlReader.Create(new StringReader(xsdContent)))
                {
                    settings.Schemas.Add(null, xsdReader); // null betekent dat het de default namespace is
                }
                settings.ValidationType = ValidationType.Schema;

                // Voeg een event handler toe voor validatiefouten
                settings.ValidationEventHandler += new ValidationEventHandler(ValidationEventHandler);

                // Maak XmlReader voor de XML-string
                using (XmlReader xmlReader = XmlReader.Create(new StringReader(xmlString), settings))
                {
                    while (xmlReader.Read()) { }
                }

                return true; // Geen validatiefouten, XML is geldig
            }
            catch (XmlSchemaValidationException ex)
            {
                logger?.LogError("Validation error: " + ex.Message);
                return false; // Fout tijdens validatie, XML is ongeldig
            }
        }

        /// <summary>
        /// Get the embedded XSD resource as string or null if not found
        /// </summary>
        /// <param name="resourceName">Full qualified resource name</param>
        /// <returns>Found XSD or null</returns>
        private static string? GetEmbeddedResource(string resourceName)
        {
            var assembly = Assembly.GetExecutingAssembly();
            using Stream? stream = assembly.GetManifestResourceStream(resourceName);
            if (stream == null)
            {
                return null;
            }
            using StreamReader reader = new StreamReader(stream);
            return reader.ReadToEnd();
        }

        // Event handler voor validatiefouten
        private static void ValidationEventHandler(object sender, ValidationEventArgs e)
        {
            if (e.Severity == XmlSeverityType.Error)
            {
                Console.WriteLine($"Validation error: {e.Message}");
            }
            else
            {
                Console.WriteLine($"Validation warning: {e.Message}");
            }
        }

        internal Initialization Initialization { get; }

        internal Sender Sender { get; }
    }
}
