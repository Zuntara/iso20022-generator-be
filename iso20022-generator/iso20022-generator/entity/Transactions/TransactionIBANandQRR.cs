﻿using System;

namespace iso20022_generator.entity.Transactions
{
    public class TransactionIBANandQRR : TransactionBase
    {
        private string _receiverIban;
        private string _qRRReferenceNumber;

        public string ReceiverIban
        {
            get => _receiverIban;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("IBAN cannot be null or whitespace.", nameof(value));
                if (value.Length < 15)
                    throw new ArgumentException("IBAN is to short", nameof(value));
                _receiverIban = value.Replace(" ", "");
            }
        }

        public string ReceiverBIC { get; set; }

        public string QRReferenceNumber
        {
            get => _qRRReferenceNumber;
            set => _qRRReferenceNumber = value.Replace(" ", "");
        }

        public string UnstructuredRemittanceInformation { get; set; }

        public string[] AdditionalRemittanceInformation { get; set; }
    }
}
