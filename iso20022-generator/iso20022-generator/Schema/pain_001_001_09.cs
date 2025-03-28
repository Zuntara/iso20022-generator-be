﻿namespace OkiOki.Iso20022.Generator.Schema
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class AccountIdentification4Choice
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IBAN", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("Othr", typeof(GenericAccountIdentification1))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class GenericAccountIdentification1
    {

        private string idField;

        private AccountSchemeName1Choice schmeNmField;

        private string issrField;

        /// <remarks/>
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public AccountSchemeName1Choice SchmeNm
        {
            get
            {
                return this.schmeNmField;
            }
            set
            {
                this.schmeNmField = value;
            }
        }

        /// <remarks/>
        public string Issr
        {
            get
            {
                return this.issrField;
            }
            set
            {
                this.issrField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class AccountSchemeName1Choice
    {

        private string itemField;

        private ItemChoiceType itemElementNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09", IncludeInSchema = false)]
    public enum ItemChoiceType
    {

        /// <remarks/>
        Cd,

        /// <remarks/>
        Prtry,
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class ActiveOrHistoricCurrencyAndAmount
    {

        private string ccyField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Ccy
        {
            get
            {
                return this.ccyField;
            }
            set
            {
                this.ccyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public enum AddressType2Code
    {

        /// <remarks/>
        ADDR,

        /// <remarks/>
        PBOX,

        /// <remarks/>
        HOME,

        /// <remarks/>
        BIZZ,

        /// <remarks/>
        MLTO,

        /// <remarks/>
        DLVY,
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class AddressType3Choice
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(AddressType2Code))]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(GenericIdentification30))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class GenericIdentification30
    {

        private string idField;

        private string issrField;

        private string schmeNmField;

        /// <remarks/>
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string Issr
        {
            get
            {
                return this.issrField;
            }
            set
            {
                this.issrField = value;
            }
        }

        /// <remarks/>
        public string SchmeNm
        {
            get
            {
                return this.schmeNmField;
            }
            set
            {
                this.schmeNmField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class AmountType4Choice
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EqvtAmt", typeof(EquivalentAmount2))]
        [System.Xml.Serialization.XmlElementAttribute("InstdAmt", typeof(ActiveOrHistoricCurrencyAndAmount))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class EquivalentAmount2
    {

        private ActiveOrHistoricCurrencyAndAmount amtField;

        private string ccyOfTrfField;

        /// <remarks/>
        public ActiveOrHistoricCurrencyAndAmount Amt
        {
            get
            {
                return this.amtField;
            }
            set
            {
                this.amtField = value;
            }
        }

        /// <remarks/>
        public string CcyOfTrf
        {
            get
            {
                return this.ccyOfTrfField;
            }
            set
            {
                this.ccyOfTrfField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class Authorisation1Choice
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(Authorisation1Code))]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(string))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public enum Authorisation1Code
    {

        /// <remarks/>
        AUTH,

        /// <remarks/>
        FDET,

        /// <remarks/>
        FSUM,

        /// <remarks/>
        ILEV,
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class BranchAndFinancialInstitutionIdentification6
    {

        private FinancialInstitutionIdentification18 finInstnIdField;

        private BranchData3 brnchIdField;

        /// <remarks/>
        public FinancialInstitutionIdentification18 FinInstnId
        {
            get
            {
                return this.finInstnIdField;
            }
            set
            {
                this.finInstnIdField = value;
            }
        }

        /// <remarks/>
        public BranchData3 BrnchId
        {
            get
            {
                return this.brnchIdField;
            }
            set
            {
                this.brnchIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class FinancialInstitutionIdentification18
    {

        private string bICFIField;

        private ClearingSystemMemberIdentification2 clrSysMmbIdField;

        private string lEIField;

        private string nmField;

        private PostalAddress24 pstlAdrField;

        private GenericFinancialIdentification1 othrField;

        /// <remarks/>
        public string BICFI
        {
            get
            {
                return this.bICFIField;
            }
            set
            {
                this.bICFIField = value;
            }
        }

        /// <remarks/>
        public ClearingSystemMemberIdentification2 ClrSysMmbId
        {
            get
            {
                return this.clrSysMmbIdField;
            }
            set
            {
                this.clrSysMmbIdField = value;
            }
        }

        /// <remarks/>
        public string LEI
        {
            get
            {
                return this.lEIField;
            }
            set
            {
                this.lEIField = value;
            }
        }

        /// <remarks/>
        public string Nm
        {
            get
            {
                return this.nmField;
            }
            set
            {
                this.nmField = value;
            }
        }

        /// <remarks/>
        public PostalAddress24 PstlAdr
        {
            get
            {
                return this.pstlAdrField;
            }
            set
            {
                this.pstlAdrField = value;
            }
        }

        /// <remarks/>
        public GenericFinancialIdentification1 Othr
        {
            get
            {
                return this.othrField;
            }
            set
            {
                this.othrField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class ClearingSystemMemberIdentification2
    {

        private ClearingSystemIdentification2Choice clrSysIdField;

        private string mmbIdField;

        /// <remarks/>
        public ClearingSystemIdentification2Choice ClrSysId
        {
            get
            {
                return this.clrSysIdField;
            }
            set
            {
                this.clrSysIdField = value;
            }
        }

        /// <remarks/>
        public string MmbId
        {
            get
            {
                return this.mmbIdField;
            }
            set
            {
                this.mmbIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class ClearingSystemIdentification2Choice
    {

        private string itemField;

        private ItemChoiceType1 itemElementNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType1 ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09", IncludeInSchema = false)]
    public enum ItemChoiceType1
    {

        /// <remarks/>
        Cd,

        /// <remarks/>
        Prtry,
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class PostalAddress24
    {

        private AddressType3Choice adrTpField;

        private string deptField;

        private string subDeptField;

        private string strtNmField;

        private string bldgNbField;

        private string bldgNmField;

        private string flrField;

        private string pstBxField;

        private string roomField;

        private string pstCdField;

        private string twnNmField;

        private string twnLctnNmField;

        private string dstrctNmField;

        private string ctrySubDvsnField;

        private string ctryField;

        private string[] adrLineField;

        /// <remarks/>
        public AddressType3Choice AdrTp
        {
            get
            {
                return this.adrTpField;
            }
            set
            {
                this.adrTpField = value;
            }
        }

        /// <remarks/>
        public string Dept
        {
            get
            {
                return this.deptField;
            }
            set
            {
                this.deptField = value;
            }
        }

        /// <remarks/>
        public string SubDept
        {
            get
            {
                return this.subDeptField;
            }
            set
            {
                this.subDeptField = value;
            }
        }

        /// <remarks/>
        public string StrtNm
        {
            get
            {
                return this.strtNmField;
            }
            set
            {
                this.strtNmField = value;
            }
        }

        /// <remarks/>
        public string BldgNb
        {
            get
            {
                return this.bldgNbField;
            }
            set
            {
                this.bldgNbField = value;
            }
        }

        /// <remarks/>
        public string BldgNm
        {
            get
            {
                return this.bldgNmField;
            }
            set
            {
                this.bldgNmField = value;
            }
        }

        /// <remarks/>
        public string Flr
        {
            get
            {
                return this.flrField;
            }
            set
            {
                this.flrField = value;
            }
        }

        /// <remarks/>
        public string PstBx
        {
            get
            {
                return this.pstBxField;
            }
            set
            {
                this.pstBxField = value;
            }
        }

        /// <remarks/>
        public string Room
        {
            get
            {
                return this.roomField;
            }
            set
            {
                this.roomField = value;
            }
        }

        /// <remarks/>
        public string PstCd
        {
            get
            {
                return this.pstCdField;
            }
            set
            {
                this.pstCdField = value;
            }
        }

        /// <remarks/>
        public string TwnNm
        {
            get
            {
                return this.twnNmField;
            }
            set
            {
                this.twnNmField = value;
            }
        }

        /// <remarks/>
        public string TwnLctnNm
        {
            get
            {
                return this.twnLctnNmField;
            }
            set
            {
                this.twnLctnNmField = value;
            }
        }

        /// <remarks/>
        public string DstrctNm
        {
            get
            {
                return this.dstrctNmField;
            }
            set
            {
                this.dstrctNmField = value;
            }
        }

        /// <remarks/>
        public string CtrySubDvsn
        {
            get
            {
                return this.ctrySubDvsnField;
            }
            set
            {
                this.ctrySubDvsnField = value;
            }
        }

        /// <remarks/>
        public string Ctry
        {
            get
            {
                return this.ctryField;
            }
            set
            {
                this.ctryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AdrLine")]
        public string[] AdrLine
        {
            get
            {
                return this.adrLineField;
            }
            set
            {
                this.adrLineField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class GenericFinancialIdentification1
    {

        private string idField;

        private FinancialIdentificationSchemeName1Choice schmeNmField;

        private string issrField;

        /// <remarks/>
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public FinancialIdentificationSchemeName1Choice SchmeNm
        {
            get
            {
                return this.schmeNmField;
            }
            set
            {
                this.schmeNmField = value;
            }
        }

        /// <remarks/>
        public string Issr
        {
            get
            {
                return this.issrField;
            }
            set
            {
                this.issrField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class FinancialIdentificationSchemeName1Choice
    {

        private string itemField;

        private ItemChoiceType2 itemElementNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType2 ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09", IncludeInSchema = false)]
    public enum ItemChoiceType2
    {

        /// <remarks/>
        Cd,

        /// <remarks/>
        Prtry,
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class BranchData3
    {

        private string idField;

        private string lEIField;

        private string nmField;

        private PostalAddress24 pstlAdrField;

        /// <remarks/>
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string LEI
        {
            get
            {
                return this.lEIField;
            }
            set
            {
                this.lEIField = value;
            }
        }

        /// <remarks/>
        public string Nm
        {
            get
            {
                return this.nmField;
            }
            set
            {
                this.nmField = value;
            }
        }

        /// <remarks/>
        public PostalAddress24 PstlAdr
        {
            get
            {
                return this.pstlAdrField;
            }
            set
            {
                this.pstlAdrField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class CashAccount38
    {

        private AccountIdentification4Choice idField;

        private CashAccountType2Choice tpField;

        private string ccyField;

        private string nmField;

        private ProxyAccountIdentification1 prxyField;

        /// <remarks/>
        public AccountIdentification4Choice Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public CashAccountType2Choice Tp
        {
            get
            {
                return this.tpField;
            }
            set
            {
                this.tpField = value;
            }
        }

        /// <remarks/>
        public string Ccy
        {
            get
            {
                return this.ccyField;
            }
            set
            {
                this.ccyField = value;
            }
        }

        /// <remarks/>
        public string Nm
        {
            get
            {
                return this.nmField;
            }
            set
            {
                this.nmField = value;
            }
        }

        /// <remarks/>
        public ProxyAccountIdentification1 Prxy
        {
            get
            {
                return this.prxyField;
            }
            set
            {
                this.prxyField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class CashAccountType2Choice
    {

        private string itemField;

        private ItemChoiceType3 itemElementNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType3 ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09", IncludeInSchema = false)]
    public enum ItemChoiceType3
    {

        /// <remarks/>
        Cd,

        /// <remarks/>
        Prtry,
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class ProxyAccountIdentification1
    {

        private ProxyAccountType1Choice tpField;

        private string idField;

        /// <remarks/>
        public ProxyAccountType1Choice Tp
        {
            get
            {
                return this.tpField;
            }
            set
            {
                this.tpField = value;
            }
        }

        /// <remarks/>
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class ProxyAccountType1Choice
    {

        private string itemField;

        private ItemChoiceType4 itemElementNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType4 ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09", IncludeInSchema = false)]
    public enum ItemChoiceType4
    {

        /// <remarks/>
        Cd,

        /// <remarks/>
        Prtry,
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class CategoryPurpose1Choice
    {

        private string itemField;

        private ItemChoiceType5 itemElementNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType5 ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09", IncludeInSchema = false)]
    public enum ItemChoiceType5
    {

        /// <remarks/>
        Cd,

        /// <remarks/>
        Prtry,
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public enum ChargeBearerType1Code
    {

        /// <remarks/>
        DEBT,

        /// <remarks/>
        CRED,

        /// <remarks/>
        SHAR,

        /// <remarks/>
        SLEV,
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class Cheque11
    {

        private ChequeType2Code chqTpField;

        private bool chqTpFieldSpecified;

        private string chqNbField;

        private NameAndAddress16 chqFrField;

        private ChequeDeliveryMethod1Choice dlvryMtdField;

        private NameAndAddress16 dlvrToField;

        private Priority2Code instrPrtyField;

        private bool instrPrtyFieldSpecified;

        private System.DateTime chqMtrtyDtField;

        private bool chqMtrtyDtFieldSpecified;

        private string frmsCdField;

        private string[] memoFldField;

        private string rgnlClrZoneField;

        private string prtLctnField;

        private string[] sgntrField;

        /// <remarks/>
        public ChequeType2Code ChqTp
        {
            get
            {
                return this.chqTpField;
            }
            set
            {
                this.chqTpField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ChqTpSpecified
        {
            get
            {
                return this.chqTpFieldSpecified;
            }
            set
            {
                this.chqTpFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string ChqNb
        {
            get
            {
                return this.chqNbField;
            }
            set
            {
                this.chqNbField = value;
            }
        }

        /// <remarks/>
        public NameAndAddress16 ChqFr
        {
            get
            {
                return this.chqFrField;
            }
            set
            {
                this.chqFrField = value;
            }
        }

        /// <remarks/>
        public ChequeDeliveryMethod1Choice DlvryMtd
        {
            get
            {
                return this.dlvryMtdField;
            }
            set
            {
                this.dlvryMtdField = value;
            }
        }

        /// <remarks/>
        public NameAndAddress16 DlvrTo
        {
            get
            {
                return this.dlvrToField;
            }
            set
            {
                this.dlvrToField = value;
            }
        }

        /// <remarks/>
        public Priority2Code InstrPrty
        {
            get
            {
                return this.instrPrtyField;
            }
            set
            {
                this.instrPrtyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InstrPrtySpecified
        {
            get
            {
                return this.instrPrtyFieldSpecified;
            }
            set
            {
                this.instrPrtyFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime ChqMtrtyDt
        {
            get
            {
                return this.chqMtrtyDtField;
            }
            set
            {
                this.chqMtrtyDtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ChqMtrtyDtSpecified
        {
            get
            {
                return this.chqMtrtyDtFieldSpecified;
            }
            set
            {
                this.chqMtrtyDtFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string FrmsCd
        {
            get
            {
                return this.frmsCdField;
            }
            set
            {
                this.frmsCdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MemoFld")]
        public string[] MemoFld
        {
            get
            {
                return this.memoFldField;
            }
            set
            {
                this.memoFldField = value;
            }
        }

        /// <remarks/>
        public string RgnlClrZone
        {
            get
            {
                return this.rgnlClrZoneField;
            }
            set
            {
                this.rgnlClrZoneField = value;
            }
        }

        /// <remarks/>
        public string PrtLctn
        {
            get
            {
                return this.prtLctnField;
            }
            set
            {
                this.prtLctnField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Sgntr")]
        public string[] Sgntr
        {
            get
            {
                return this.sgntrField;
            }
            set
            {
                this.sgntrField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public enum ChequeType2Code
    {

        /// <remarks/>
        CCHQ,

        /// <remarks/>
        CCCH,

        /// <remarks/>
        BCHQ,

        /// <remarks/>
        DRFT,

        /// <remarks/>
        ELDR,
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class NameAndAddress16
    {

        private string nmField;

        private PostalAddress24 adrField;

        /// <remarks/>
        public string Nm
        {
            get
            {
                return this.nmField;
            }
            set
            {
                this.nmField = value;
            }
        }

        /// <remarks/>
        public PostalAddress24 Adr
        {
            get
            {
                return this.adrField;
            }
            set
            {
                this.adrField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class ChequeDeliveryMethod1Choice
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(ChequeDelivery1Code))]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(string))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public enum ChequeDelivery1Code
    {

        /// <remarks/>
        MLDB,

        /// <remarks/>
        MLCD,

        /// <remarks/>
        MLFA,

        /// <remarks/>
        CRDB,

        /// <remarks/>
        CRCD,

        /// <remarks/>
        CRFA,

        /// <remarks/>
        PUDB,

        /// <remarks/>
        PUCD,

        /// <remarks/>
        PUFA,

        /// <remarks/>
        RGDB,

        /// <remarks/>
        RGCD,

        /// <remarks/>
        RGFA,
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public enum Priority2Code
    {

        /// <remarks/>
        HIGH,

        /// <remarks/>
        NORM,
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class Contact4
    {

        private NamePrefix2Code nmPrfxField;

        private bool nmPrfxFieldSpecified;

        private string nmField;

        private string phneNbField;

        private string mobNbField;

        private string faxNbField;

        private string emailAdrField;

        private string emailPurpField;

        private string jobTitlField;

        private string rspnsbltyField;

        private string deptField;

        private OtherContact1[] othrField;

        private PreferredContactMethod1Code prefrdMtdField;

        private bool prefrdMtdFieldSpecified;

        /// <remarks/>
        public NamePrefix2Code NmPrfx
        {
            get
            {
                return this.nmPrfxField;
            }
            set
            {
                this.nmPrfxField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NmPrfxSpecified
        {
            get
            {
                return this.nmPrfxFieldSpecified;
            }
            set
            {
                this.nmPrfxFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string Nm
        {
            get
            {
                return this.nmField;
            }
            set
            {
                this.nmField = value;
            }
        }

        /// <remarks/>
        public string PhneNb
        {
            get
            {
                return this.phneNbField;
            }
            set
            {
                this.phneNbField = value;
            }
        }

        /// <remarks/>
        public string MobNb
        {
            get
            {
                return this.mobNbField;
            }
            set
            {
                this.mobNbField = value;
            }
        }

        /// <remarks/>
        public string FaxNb
        {
            get
            {
                return this.faxNbField;
            }
            set
            {
                this.faxNbField = value;
            }
        }

        /// <remarks/>
        public string EmailAdr
        {
            get
            {
                return this.emailAdrField;
            }
            set
            {
                this.emailAdrField = value;
            }
        }

        /// <remarks/>
        public string EmailPurp
        {
            get
            {
                return this.emailPurpField;
            }
            set
            {
                this.emailPurpField = value;
            }
        }

        /// <remarks/>
        public string JobTitl
        {
            get
            {
                return this.jobTitlField;
            }
            set
            {
                this.jobTitlField = value;
            }
        }

        /// <remarks/>
        public string Rspnsblty
        {
            get
            {
                return this.rspnsbltyField;
            }
            set
            {
                this.rspnsbltyField = value;
            }
        }

        /// <remarks/>
        public string Dept
        {
            get
            {
                return this.deptField;
            }
            set
            {
                this.deptField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Othr")]
        public OtherContact1[] Othr
        {
            get
            {
                return this.othrField;
            }
            set
            {
                this.othrField = value;
            }
        }

        /// <remarks/>
        public PreferredContactMethod1Code PrefrdMtd
        {
            get
            {
                return this.prefrdMtdField;
            }
            set
            {
                this.prefrdMtdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PrefrdMtdSpecified
        {
            get
            {
                return this.prefrdMtdFieldSpecified;
            }
            set
            {
                this.prefrdMtdFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public enum NamePrefix2Code
    {

        /// <remarks/>
        DOCT,

        /// <remarks/>
        MADM,

        /// <remarks/>
        MISS,

        /// <remarks/>
        MIST,

        /// <remarks/>
        MIKS,
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class OtherContact1
    {

        private string chanlTpField;

        private string idField;

        /// <remarks/>
        public string ChanlTp
        {
            get
            {
                return this.chanlTpField;
            }
            set
            {
                this.chanlTpField = value;
            }
        }

        /// <remarks/>
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public enum PreferredContactMethod1Code
    {

        /// <remarks/>
        LETT,

        /// <remarks/>
        MAIL,

        /// <remarks/>
        PHON,

        /// <remarks/>
        FAXX,

        /// <remarks/>
        CELL,
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public enum CreditDebitCode
    {

        /// <remarks/>
        CRDT,

        /// <remarks/>
        DBIT,
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class CreditTransferTransaction34
    {

        private PaymentIdentification6 pmtIdField;

        private PaymentTypeInformation26 pmtTpInfField;

        private AmountType4Choice amtField;

        private ExchangeRate1 xchgRateInfField;

        private ChargeBearerType1Code chrgBrField;

        private bool chrgBrFieldSpecified;

        private Cheque11 chqInstrField;

        private PartyIdentification135 ultmtDbtrField;

        private BranchAndFinancialInstitutionIdentification6 intrmyAgt1Field;

        private CashAccount38 intrmyAgt1AcctField;

        private BranchAndFinancialInstitutionIdentification6 intrmyAgt2Field;

        private CashAccount38 intrmyAgt2AcctField;

        private BranchAndFinancialInstitutionIdentification6 intrmyAgt3Field;

        private CashAccount38 intrmyAgt3AcctField;

        private BranchAndFinancialInstitutionIdentification6 cdtrAgtField;

        private CashAccount38 cdtrAgtAcctField;

        private PartyIdentification135 cdtrField;

        private CashAccount38 cdtrAcctField;

        private PartyIdentification135 ultmtCdtrField;

        private InstructionForCreditorAgent1[] instrForCdtrAgtField;

        private string instrForDbtrAgtField;

        private Purpose2Choice purpField;

        private RegulatoryReporting3[] rgltryRptgField;

        private TaxInformation8 taxField;

        private RemittanceLocation7[] rltdRmtInfField;

        private RemittanceInformation16 rmtInfField;

        private SupplementaryData1[] splmtryDataField;

        /// <remarks/>
        public PaymentIdentification6 PmtId
        {
            get
            {
                return this.pmtIdField;
            }
            set
            {
                this.pmtIdField = value;
            }
        }

        /// <remarks/>
        public PaymentTypeInformation26 PmtTpInf
        {
            get
            {
                return this.pmtTpInfField;
            }
            set
            {
                this.pmtTpInfField = value;
            }
        }

        /// <remarks/>
        public AmountType4Choice Amt
        {
            get
            {
                return this.amtField;
            }
            set
            {
                this.amtField = value;
            }
        }

        /// <remarks/>
        public ExchangeRate1 XchgRateInf
        {
            get
            {
                return this.xchgRateInfField;
            }
            set
            {
                this.xchgRateInfField = value;
            }
        }

        /// <remarks/>
        public ChargeBearerType1Code ChrgBr
        {
            get
            {
                return this.chrgBrField;
            }
            set
            {
                this.chrgBrField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ChrgBrSpecified
        {
            get
            {
                return this.chrgBrFieldSpecified;
            }
            set
            {
                this.chrgBrFieldSpecified = value;
            }
        }

        /// <remarks/>
        public Cheque11 ChqInstr
        {
            get
            {
                return this.chqInstrField;
            }
            set
            {
                this.chqInstrField = value;
            }
        }

        /// <remarks/>
        public PartyIdentification135 UltmtDbtr
        {
            get
            {
                return this.ultmtDbtrField;
            }
            set
            {
                this.ultmtDbtrField = value;
            }
        }

        /// <remarks/>
        public BranchAndFinancialInstitutionIdentification6 IntrmyAgt1
        {
            get
            {
                return this.intrmyAgt1Field;
            }
            set
            {
                this.intrmyAgt1Field = value;
            }
        }

        /// <remarks/>
        public CashAccount38 IntrmyAgt1Acct
        {
            get
            {
                return this.intrmyAgt1AcctField;
            }
            set
            {
                this.intrmyAgt1AcctField = value;
            }
        }

        /// <remarks/>
        public BranchAndFinancialInstitutionIdentification6 IntrmyAgt2
        {
            get
            {
                return this.intrmyAgt2Field;
            }
            set
            {
                this.intrmyAgt2Field = value;
            }
        }

        /// <remarks/>
        public CashAccount38 IntrmyAgt2Acct
        {
            get
            {
                return this.intrmyAgt2AcctField;
            }
            set
            {
                this.intrmyAgt2AcctField = value;
            }
        }

        /// <remarks/>
        public BranchAndFinancialInstitutionIdentification6 IntrmyAgt3
        {
            get
            {
                return this.intrmyAgt3Field;
            }
            set
            {
                this.intrmyAgt3Field = value;
            }
        }

        /// <remarks/>
        public CashAccount38 IntrmyAgt3Acct
        {
            get
            {
                return this.intrmyAgt3AcctField;
            }
            set
            {
                this.intrmyAgt3AcctField = value;
            }
        }

        /// <remarks/>
        public BranchAndFinancialInstitutionIdentification6 CdtrAgt
        {
            get
            {
                return this.cdtrAgtField;
            }
            set
            {
                this.cdtrAgtField = value;
            }
        }

        /// <remarks/>
        public CashAccount38 CdtrAgtAcct
        {
            get
            {
                return this.cdtrAgtAcctField;
            }
            set
            {
                this.cdtrAgtAcctField = value;
            }
        }

        /// <remarks/>
        public PartyIdentification135 Cdtr
        {
            get
            {
                return this.cdtrField;
            }
            set
            {
                this.cdtrField = value;
            }
        }

        /// <remarks/>
        public CashAccount38 CdtrAcct
        {
            get
            {
                return this.cdtrAcctField;
            }
            set
            {
                this.cdtrAcctField = value;
            }
        }

        /// <remarks/>
        public PartyIdentification135 UltmtCdtr
        {
            get
            {
                return this.ultmtCdtrField;
            }
            set
            {
                this.ultmtCdtrField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InstrForCdtrAgt")]
        public InstructionForCreditorAgent1[] InstrForCdtrAgt
        {
            get
            {
                return this.instrForCdtrAgtField;
            }
            set
            {
                this.instrForCdtrAgtField = value;
            }
        }

        /// <remarks/>
        public string InstrForDbtrAgt
        {
            get
            {
                return this.instrForDbtrAgtField;
            }
            set
            {
                this.instrForDbtrAgtField = value;
            }
        }

        /// <remarks/>
        public Purpose2Choice Purp
        {
            get
            {
                return this.purpField;
            }
            set
            {
                this.purpField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RgltryRptg")]
        public RegulatoryReporting3[] RgltryRptg
        {
            get
            {
                return this.rgltryRptgField;
            }
            set
            {
                this.rgltryRptgField = value;
            }
        }

        /// <remarks/>
        public TaxInformation8 Tax
        {
            get
            {
                return this.taxField;
            }
            set
            {
                this.taxField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RltdRmtInf")]
        public RemittanceLocation7[] RltdRmtInf
        {
            get
            {
                return this.rltdRmtInfField;
            }
            set
            {
                this.rltdRmtInfField = value;
            }
        }

        /// <remarks/>
        public RemittanceInformation16 RmtInf
        {
            get
            {
                return this.rmtInfField;
            }
            set
            {
                this.rmtInfField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SplmtryData")]
        public SupplementaryData1[] SplmtryData
        {
            get
            {
                return this.splmtryDataField;
            }
            set
            {
                this.splmtryDataField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class PaymentIdentification6
    {

        private string instrIdField;

        private string endToEndIdField;

        private string uETRField;

        /// <remarks/>
        public string InstrId
        {
            get
            {
                return this.instrIdField;
            }
            set
            {
                this.instrIdField = value;
            }
        }

        /// <remarks/>
        public string EndToEndId
        {
            get
            {
                return this.endToEndIdField;
            }
            set
            {
                this.endToEndIdField = value;
            }
        }

        /// <remarks/>
        public string UETR
        {
            get
            {
                return this.uETRField;
            }
            set
            {
                this.uETRField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class PaymentTypeInformation26
    {

        private Priority2Code instrPrtyField;

        private bool instrPrtyFieldSpecified;

        private ServiceLevel8Choice[] svcLvlField;

        private LocalInstrument2Choice lclInstrmField;

        private CategoryPurpose1Choice ctgyPurpField;

        /// <remarks/>
        public Priority2Code InstrPrty
        {
            get
            {
                return this.instrPrtyField;
            }
            set
            {
                this.instrPrtyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InstrPrtySpecified
        {
            get
            {
                return this.instrPrtyFieldSpecified;
            }
            set
            {
                this.instrPrtyFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SvcLvl")]
        public ServiceLevel8Choice[] SvcLvl
        {
            get
            {
                return this.svcLvlField;
            }
            set
            {
                this.svcLvlField = value;
            }
        }

        /// <remarks/>
        public LocalInstrument2Choice LclInstrm
        {
            get
            {
                return this.lclInstrmField;
            }
            set
            {
                this.lclInstrmField = value;
            }
        }

        /// <remarks/>
        public CategoryPurpose1Choice CtgyPurp
        {
            get
            {
                return this.ctgyPurpField;
            }
            set
            {
                this.ctgyPurpField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class ServiceLevel8Choice
    {

        private string itemField;

        private ItemChoiceType6 itemElementNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType6 ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09", IncludeInSchema = false)]
    public enum ItemChoiceType6
    {

        /// <remarks/>
        Cd,

        /// <remarks/>
        Prtry,
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class LocalInstrument2Choice
    {

        private string itemField;

        private ItemChoiceType7 itemElementNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType7 ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09", IncludeInSchema = false)]
    public enum ItemChoiceType7
    {

        /// <remarks/>
        Cd,

        /// <remarks/>
        Prtry,
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class ExchangeRate1
    {

        private string unitCcyField;

        private decimal xchgRateField;

        private bool xchgRateFieldSpecified;

        private ExchangeRateType1Code rateTpField;

        private bool rateTpFieldSpecified;

        private string ctrctIdField;

        /// <remarks/>
        public string UnitCcy
        {
            get
            {
                return this.unitCcyField;
            }
            set
            {
                this.unitCcyField = value;
            }
        }

        /// <remarks/>
        public decimal XchgRate
        {
            get
            {
                return this.xchgRateField;
            }
            set
            {
                this.xchgRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool XchgRateSpecified
        {
            get
            {
                return this.xchgRateFieldSpecified;
            }
            set
            {
                this.xchgRateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public ExchangeRateType1Code RateTp
        {
            get
            {
                return this.rateTpField;
            }
            set
            {
                this.rateTpField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RateTpSpecified
        {
            get
            {
                return this.rateTpFieldSpecified;
            }
            set
            {
                this.rateTpFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string CtrctId
        {
            get
            {
                return this.ctrctIdField;
            }
            set
            {
                this.ctrctIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public enum ExchangeRateType1Code
    {

        /// <remarks/>
        SPOT,

        /// <remarks/>
        SALE,

        /// <remarks/>
        AGRD,
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class PartyIdentification135
    {

        private string nmField;

        private PostalAddress24 pstlAdrField;

        private Party38Choice idField;

        private string ctryOfResField;

        private Contact4 ctctDtlsField;

        /// <remarks/>
        public string Nm
        {
            get
            {
                return this.nmField;
            }
            set
            {
                this.nmField = value;
            }
        }

        /// <remarks/>
        public PostalAddress24 PstlAdr
        {
            get
            {
                return this.pstlAdrField;
            }
            set
            {
                this.pstlAdrField = value;
            }
        }

        /// <remarks/>
        public Party38Choice Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string CtryOfRes
        {
            get
            {
                return this.ctryOfResField;
            }
            set
            {
                this.ctryOfResField = value;
            }
        }

        /// <remarks/>
        public Contact4 CtctDtls
        {
            get
            {
                return this.ctctDtlsField;
            }
            set
            {
                this.ctctDtlsField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class Party38Choice
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OrgId", typeof(OrganisationIdentification29))]
        [System.Xml.Serialization.XmlElementAttribute("PrvtId", typeof(PersonIdentification13))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class OrganisationIdentification29
    {

        private string anyBICField;

        private string lEIField;

        private GenericOrganisationIdentification1[] othrField;

        /// <remarks/>
        public string AnyBIC
        {
            get
            {
                return this.anyBICField;
            }
            set
            {
                this.anyBICField = value;
            }
        }

        /// <remarks/>
        public string LEI
        {
            get
            {
                return this.lEIField;
            }
            set
            {
                this.lEIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Othr")]
        public GenericOrganisationIdentification1[] Othr
        {
            get
            {
                return this.othrField;
            }
            set
            {
                this.othrField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class GenericOrganisationIdentification1
    {

        private string idField;

        private OrganisationIdentificationSchemeName1Choice schmeNmField;

        private string issrField;

        /// <remarks/>
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public OrganisationIdentificationSchemeName1Choice SchmeNm
        {
            get
            {
                return this.schmeNmField;
            }
            set
            {
                this.schmeNmField = value;
            }
        }

        /// <remarks/>
        public string Issr
        {
            get
            {
                return this.issrField;
            }
            set
            {
                this.issrField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class OrganisationIdentificationSchemeName1Choice
    {

        private string itemField;

        private ItemChoiceType8 itemElementNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType8 ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09", IncludeInSchema = false)]
    public enum ItemChoiceType8
    {

        /// <remarks/>
        Cd,

        /// <remarks/>
        Prtry,
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class PersonIdentification13
    {

        private DateAndPlaceOfBirth1 dtAndPlcOfBirthField;

        private GenericPersonIdentification1[] othrField;

        /// <remarks/>
        public DateAndPlaceOfBirth1 DtAndPlcOfBirth
        {
            get
            {
                return this.dtAndPlcOfBirthField;
            }
            set
            {
                this.dtAndPlcOfBirthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Othr")]
        public GenericPersonIdentification1[] Othr
        {
            get
            {
                return this.othrField;
            }
            set
            {
                this.othrField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class DateAndPlaceOfBirth1
    {

        private System.DateTime birthDtField;

        private string prvcOfBirthField;

        private string cityOfBirthField;

        private string ctryOfBirthField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime BirthDt
        {
            get
            {
                return this.birthDtField;
            }
            set
            {
                this.birthDtField = value;
            }
        }

        /// <remarks/>
        public string PrvcOfBirth
        {
            get
            {
                return this.prvcOfBirthField;
            }
            set
            {
                this.prvcOfBirthField = value;
            }
        }

        /// <remarks/>
        public string CityOfBirth
        {
            get
            {
                return this.cityOfBirthField;
            }
            set
            {
                this.cityOfBirthField = value;
            }
        }

        /// <remarks/>
        public string CtryOfBirth
        {
            get
            {
                return this.ctryOfBirthField;
            }
            set
            {
                this.ctryOfBirthField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class GenericPersonIdentification1
    {

        private string idField;

        private PersonIdentificationSchemeName1Choice schmeNmField;

        private string issrField;

        /// <remarks/>
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public PersonIdentificationSchemeName1Choice SchmeNm
        {
            get
            {
                return this.schmeNmField;
            }
            set
            {
                this.schmeNmField = value;
            }
        }

        /// <remarks/>
        public string Issr
        {
            get
            {
                return this.issrField;
            }
            set
            {
                this.issrField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class PersonIdentificationSchemeName1Choice
    {

        private string itemField;

        private ItemChoiceType9 itemElementNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType9 ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09", IncludeInSchema = false)]
    public enum ItemChoiceType9
    {

        /// <remarks/>
        Cd,

        /// <remarks/>
        Prtry,
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class InstructionForCreditorAgent1
    {

        private Instruction3Code cdField;

        private bool cdFieldSpecified;

        private string instrInfField;

        /// <remarks/>
        public Instruction3Code Cd
        {
            get
            {
                return this.cdField;
            }
            set
            {
                this.cdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CdSpecified
        {
            get
            {
                return this.cdFieldSpecified;
            }
            set
            {
                this.cdFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string InstrInf
        {
            get
            {
                return this.instrInfField;
            }
            set
            {
                this.instrInfField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public enum Instruction3Code
    {

        /// <remarks/>
        CHQB,

        /// <remarks/>
        HOLD,

        /// <remarks/>
        PHOB,

        /// <remarks/>
        TELB,
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class Purpose2Choice
    {

        private string itemField;

        private ItemChoiceType10 itemElementNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType10 ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09", IncludeInSchema = false)]
    public enum ItemChoiceType10
    {

        /// <remarks/>
        Cd,

        /// <remarks/>
        Prtry,
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class RegulatoryReporting3
    {

        private RegulatoryReportingType1Code dbtCdtRptgIndField;

        private bool dbtCdtRptgIndFieldSpecified;

        private RegulatoryAuthority2 authrtyField;

        private StructuredRegulatoryReporting3[] dtlsField;

        /// <remarks/>
        public RegulatoryReportingType1Code DbtCdtRptgInd
        {
            get
            {
                return this.dbtCdtRptgIndField;
            }
            set
            {
                this.dbtCdtRptgIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DbtCdtRptgIndSpecified
        {
            get
            {
                return this.dbtCdtRptgIndFieldSpecified;
            }
            set
            {
                this.dbtCdtRptgIndFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RegulatoryAuthority2 Authrty
        {
            get
            {
                return this.authrtyField;
            }
            set
            {
                this.authrtyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Dtls")]
        public StructuredRegulatoryReporting3[] Dtls
        {
            get
            {
                return this.dtlsField;
            }
            set
            {
                this.dtlsField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public enum RegulatoryReportingType1Code
    {

        /// <remarks/>
        CRED,

        /// <remarks/>
        DEBT,

        /// <remarks/>
        BOTH,
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class RegulatoryAuthority2
    {

        private string nmField;

        private string ctryField;

        /// <remarks/>
        public string Nm
        {
            get
            {
                return this.nmField;
            }
            set
            {
                this.nmField = value;
            }
        }

        /// <remarks/>
        public string Ctry
        {
            get
            {
                return this.ctryField;
            }
            set
            {
                this.ctryField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class StructuredRegulatoryReporting3
    {

        private string tpField;

        private System.DateTime dtField;

        private bool dtFieldSpecified;

        private string ctryField;

        private string cdField;

        private ActiveOrHistoricCurrencyAndAmount amtField;

        private string[] infField;

        /// <remarks/>
        public string Tp
        {
            get
            {
                return this.tpField;
            }
            set
            {
                this.tpField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime Dt
        {
            get
            {
                return this.dtField;
            }
            set
            {
                this.dtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DtSpecified
        {
            get
            {
                return this.dtFieldSpecified;
            }
            set
            {
                this.dtFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string Ctry
        {
            get
            {
                return this.ctryField;
            }
            set
            {
                this.ctryField = value;
            }
        }

        /// <remarks/>
        public string Cd
        {
            get
            {
                return this.cdField;
            }
            set
            {
                this.cdField = value;
            }
        }

        /// <remarks/>
        public ActiveOrHistoricCurrencyAndAmount Amt
        {
            get
            {
                return this.amtField;
            }
            set
            {
                this.amtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Inf")]
        public string[] Inf
        {
            get
            {
                return this.infField;
            }
            set
            {
                this.infField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class TaxInformation8
    {

        private TaxParty1 cdtrField;

        private TaxParty2 dbtrField;

        private string admstnZoneField;

        private string refNbField;

        private string mtdField;

        private ActiveOrHistoricCurrencyAndAmount ttlTaxblBaseAmtField;

        private ActiveOrHistoricCurrencyAndAmount ttlTaxAmtField;

        private System.DateTime dtField;

        private bool dtFieldSpecified;

        private decimal seqNbField;

        private bool seqNbFieldSpecified;

        private TaxRecord2[] rcrdField;

        /// <remarks/>
        public TaxParty1 Cdtr
        {
            get
            {
                return this.cdtrField;
            }
            set
            {
                this.cdtrField = value;
            }
        }

        /// <remarks/>
        public TaxParty2 Dbtr
        {
            get
            {
                return this.dbtrField;
            }
            set
            {
                this.dbtrField = value;
            }
        }

        /// <remarks/>
        public string AdmstnZone
        {
            get
            {
                return this.admstnZoneField;
            }
            set
            {
                this.admstnZoneField = value;
            }
        }

        /// <remarks/>
        public string RefNb
        {
            get
            {
                return this.refNbField;
            }
            set
            {
                this.refNbField = value;
            }
        }

        /// <remarks/>
        public string Mtd
        {
            get
            {
                return this.mtdField;
            }
            set
            {
                this.mtdField = value;
            }
        }

        /// <remarks/>
        public ActiveOrHistoricCurrencyAndAmount TtlTaxblBaseAmt
        {
            get
            {
                return this.ttlTaxblBaseAmtField;
            }
            set
            {
                this.ttlTaxblBaseAmtField = value;
            }
        }

        /// <remarks/>
        public ActiveOrHistoricCurrencyAndAmount TtlTaxAmt
        {
            get
            {
                return this.ttlTaxAmtField;
            }
            set
            {
                this.ttlTaxAmtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime Dt
        {
            get
            {
                return this.dtField;
            }
            set
            {
                this.dtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DtSpecified
        {
            get
            {
                return this.dtFieldSpecified;
            }
            set
            {
                this.dtFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal SeqNb
        {
            get
            {
                return this.seqNbField;
            }
            set
            {
                this.seqNbField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SeqNbSpecified
        {
            get
            {
                return this.seqNbFieldSpecified;
            }
            set
            {
                this.seqNbFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Rcrd")]
        public TaxRecord2[] Rcrd
        {
            get
            {
                return this.rcrdField;
            }
            set
            {
                this.rcrdField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class TaxParty1
    {

        private string taxIdField;

        private string regnIdField;

        private string taxTpField;

        /// <remarks/>
        public string TaxId
        {
            get
            {
                return this.taxIdField;
            }
            set
            {
                this.taxIdField = value;
            }
        }

        /// <remarks/>
        public string RegnId
        {
            get
            {
                return this.regnIdField;
            }
            set
            {
                this.regnIdField = value;
            }
        }

        /// <remarks/>
        public string TaxTp
        {
            get
            {
                return this.taxTpField;
            }
            set
            {
                this.taxTpField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class TaxParty2
    {

        private string taxIdField;

        private string regnIdField;

        private string taxTpField;

        private TaxAuthorisation1 authstnField;

        /// <remarks/>
        public string TaxId
        {
            get
            {
                return this.taxIdField;
            }
            set
            {
                this.taxIdField = value;
            }
        }

        /// <remarks/>
        public string RegnId
        {
            get
            {
                return this.regnIdField;
            }
            set
            {
                this.regnIdField = value;
            }
        }

        /// <remarks/>
        public string TaxTp
        {
            get
            {
                return this.taxTpField;
            }
            set
            {
                this.taxTpField = value;
            }
        }

        /// <remarks/>
        public TaxAuthorisation1 Authstn
        {
            get
            {
                return this.authstnField;
            }
            set
            {
                this.authstnField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class TaxAuthorisation1
    {

        private string titlField;

        private string nmField;

        /// <remarks/>
        public string Titl
        {
            get
            {
                return this.titlField;
            }
            set
            {
                this.titlField = value;
            }
        }

        /// <remarks/>
        public string Nm
        {
            get
            {
                return this.nmField;
            }
            set
            {
                this.nmField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class TaxRecord2
    {

        private string tpField;

        private string ctgyField;

        private string ctgyDtlsField;

        private string dbtrStsField;

        private string certIdField;

        private string frmsCdField;

        private TaxPeriod2 prdField;

        private TaxAmount2 taxAmtField;

        private string addtlInfField;

        /// <remarks/>
        public string Tp
        {
            get
            {
                return this.tpField;
            }
            set
            {
                this.tpField = value;
            }
        }

        /// <remarks/>
        public string Ctgy
        {
            get
            {
                return this.ctgyField;
            }
            set
            {
                this.ctgyField = value;
            }
        }

        /// <remarks/>
        public string CtgyDtls
        {
            get
            {
                return this.ctgyDtlsField;
            }
            set
            {
                this.ctgyDtlsField = value;
            }
        }

        /// <remarks/>
        public string DbtrSts
        {
            get
            {
                return this.dbtrStsField;
            }
            set
            {
                this.dbtrStsField = value;
            }
        }

        /// <remarks/>
        public string CertId
        {
            get
            {
                return this.certIdField;
            }
            set
            {
                this.certIdField = value;
            }
        }

        /// <remarks/>
        public string FrmsCd
        {
            get
            {
                return this.frmsCdField;
            }
            set
            {
                this.frmsCdField = value;
            }
        }

        /// <remarks/>
        public TaxPeriod2 Prd
        {
            get
            {
                return this.prdField;
            }
            set
            {
                this.prdField = value;
            }
        }

        /// <remarks/>
        public TaxAmount2 TaxAmt
        {
            get
            {
                return this.taxAmtField;
            }
            set
            {
                this.taxAmtField = value;
            }
        }

        /// <remarks/>
        public string AddtlInf
        {
            get
            {
                return this.addtlInfField;
            }
            set
            {
                this.addtlInfField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class TaxPeriod2
    {

        private System.DateTime yrField;

        private bool yrFieldSpecified;

        private TaxRecordPeriod1Code tpField;

        private bool tpFieldSpecified;

        private DatePeriod2 frToDtField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime Yr
        {
            get
            {
                return this.yrField;
            }
            set
            {
                this.yrField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool YrSpecified
        {
            get
            {
                return this.yrFieldSpecified;
            }
            set
            {
                this.yrFieldSpecified = value;
            }
        }

        /// <remarks/>
        public TaxRecordPeriod1Code Tp
        {
            get
            {
                return this.tpField;
            }
            set
            {
                this.tpField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TpSpecified
        {
            get
            {
                return this.tpFieldSpecified;
            }
            set
            {
                this.tpFieldSpecified = value;
            }
        }

        /// <remarks/>
        public DatePeriod2 FrToDt
        {
            get
            {
                return this.frToDtField;
            }
            set
            {
                this.frToDtField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public enum TaxRecordPeriod1Code
    {

        /// <remarks/>
        MM01,

        /// <remarks/>
        MM02,

        /// <remarks/>
        MM03,

        /// <remarks/>
        MM04,

        /// <remarks/>
        MM05,

        /// <remarks/>
        MM06,

        /// <remarks/>
        MM07,

        /// <remarks/>
        MM08,

        /// <remarks/>
        MM09,

        /// <remarks/>
        MM10,

        /// <remarks/>
        MM11,

        /// <remarks/>
        MM12,

        /// <remarks/>
        QTR1,

        /// <remarks/>
        QTR2,

        /// <remarks/>
        QTR3,

        /// <remarks/>
        QTR4,

        /// <remarks/>
        HLF1,

        /// <remarks/>
        HLF2,
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class DatePeriod2
    {

        private System.DateTime frDtField;

        private System.DateTime toDtField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime FrDt
        {
            get
            {
                return this.frDtField;
            }
            set
            {
                this.frDtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime ToDt
        {
            get
            {
                return this.toDtField;
            }
            set
            {
                this.toDtField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class TaxAmount2
    {

        private decimal rateField;

        private bool rateFieldSpecified;

        private ActiveOrHistoricCurrencyAndAmount taxblBaseAmtField;

        private ActiveOrHistoricCurrencyAndAmount ttlAmtField;

        private TaxRecordDetails2[] dtlsField;

        /// <remarks/>
        public decimal Rate
        {
            get
            {
                return this.rateField;
            }
            set
            {
                this.rateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RateSpecified
        {
            get
            {
                return this.rateFieldSpecified;
            }
            set
            {
                this.rateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public ActiveOrHistoricCurrencyAndAmount TaxblBaseAmt
        {
            get
            {
                return this.taxblBaseAmtField;
            }
            set
            {
                this.taxblBaseAmtField = value;
            }
        }

        /// <remarks/>
        public ActiveOrHistoricCurrencyAndAmount TtlAmt
        {
            get
            {
                return this.ttlAmtField;
            }
            set
            {
                this.ttlAmtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Dtls")]
        public TaxRecordDetails2[] Dtls
        {
            get
            {
                return this.dtlsField;
            }
            set
            {
                this.dtlsField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class TaxRecordDetails2
    {

        private TaxPeriod2 prdField;

        private ActiveOrHistoricCurrencyAndAmount amtField;

        /// <remarks/>
        public TaxPeriod2 Prd
        {
            get
            {
                return this.prdField;
            }
            set
            {
                this.prdField = value;
            }
        }

        /// <remarks/>
        public ActiveOrHistoricCurrencyAndAmount Amt
        {
            get
            {
                return this.amtField;
            }
            set
            {
                this.amtField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class RemittanceLocation7
    {

        private string rmtIdField;

        private RemittanceLocationData1[] rmtLctnDtlsField;

        /// <remarks/>
        public string RmtId
        {
            get
            {
                return this.rmtIdField;
            }
            set
            {
                this.rmtIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RmtLctnDtls")]
        public RemittanceLocationData1[] RmtLctnDtls
        {
            get
            {
                return this.rmtLctnDtlsField;
            }
            set
            {
                this.rmtLctnDtlsField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class RemittanceLocationData1
    {

        private RemittanceLocationMethod2Code mtdField;

        private string elctrncAdrField;

        private NameAndAddress16 pstlAdrField;

        /// <remarks/>
        public RemittanceLocationMethod2Code Mtd
        {
            get
            {
                return this.mtdField;
            }
            set
            {
                this.mtdField = value;
            }
        }

        /// <remarks/>
        public string ElctrncAdr
        {
            get
            {
                return this.elctrncAdrField;
            }
            set
            {
                this.elctrncAdrField = value;
            }
        }

        /// <remarks/>
        public NameAndAddress16 PstlAdr
        {
            get
            {
                return this.pstlAdrField;
            }
            set
            {
                this.pstlAdrField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public enum RemittanceLocationMethod2Code
    {

        /// <remarks/>
        FAXI,

        /// <remarks/>
        EDIC,

        /// <remarks/>
        URID,

        /// <remarks/>
        EMAL,

        /// <remarks/>
        POST,

        /// <remarks/>
        SMSM,
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class RemittanceInformation16
    {

        private string[] ustrdField;

        private StructuredRemittanceInformation16[] strdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Ustrd")]
        public string[] Ustrd
        {
            get
            {
                return this.ustrdField;
            }
            set
            {
                this.ustrdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Strd")]
        public StructuredRemittanceInformation16[] Strd
        {
            get
            {
                return this.strdField;
            }
            set
            {
                this.strdField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class StructuredRemittanceInformation16
    {

        private ReferredDocumentInformation7[] rfrdDocInfField;

        private RemittanceAmount2 rfrdDocAmtField;

        private CreditorReferenceInformation2 cdtrRefInfField;

        private PartyIdentification135 invcrField;

        private PartyIdentification135 invceeField;

        private TaxInformation7 taxRmtField;

        private Garnishment3 grnshmtRmtField;

        private string[] addtlRmtInfField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RfrdDocInf")]
        public ReferredDocumentInformation7[] RfrdDocInf
        {
            get
            {
                return this.rfrdDocInfField;
            }
            set
            {
                this.rfrdDocInfField = value;
            }
        }

        /// <remarks/>
        public RemittanceAmount2 RfrdDocAmt
        {
            get
            {
                return this.rfrdDocAmtField;
            }
            set
            {
                this.rfrdDocAmtField = value;
            }
        }

        /// <remarks/>
        public CreditorReferenceInformation2 CdtrRefInf
        {
            get
            {
                return this.cdtrRefInfField;
            }
            set
            {
                this.cdtrRefInfField = value;
            }
        }

        /// <remarks/>
        public PartyIdentification135 Invcr
        {
            get
            {
                return this.invcrField;
            }
            set
            {
                this.invcrField = value;
            }
        }

        /// <remarks/>
        public PartyIdentification135 Invcee
        {
            get
            {
                return this.invceeField;
            }
            set
            {
                this.invceeField = value;
            }
        }

        /// <remarks/>
        public TaxInformation7 TaxRmt
        {
            get
            {
                return this.taxRmtField;
            }
            set
            {
                this.taxRmtField = value;
            }
        }

        /// <remarks/>
        public Garnishment3 GrnshmtRmt
        {
            get
            {
                return this.grnshmtRmtField;
            }
            set
            {
                this.grnshmtRmtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AddtlRmtInf")]
        public string[] AddtlRmtInf
        {
            get
            {
                return this.addtlRmtInfField;
            }
            set
            {
                this.addtlRmtInfField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class ReferredDocumentInformation7
    {

        private ReferredDocumentType4 tpField;

        private string nbField;

        private System.DateTime rltdDtField;

        private bool rltdDtFieldSpecified;

        private DocumentLineInformation1[] lineDtlsField;

        /// <remarks/>
        public ReferredDocumentType4 Tp
        {
            get
            {
                return this.tpField;
            }
            set
            {
                this.tpField = value;
            }
        }

        /// <remarks/>
        public string Nb
        {
            get
            {
                return this.nbField;
            }
            set
            {
                this.nbField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime RltdDt
        {
            get
            {
                return this.rltdDtField;
            }
            set
            {
                this.rltdDtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RltdDtSpecified
        {
            get
            {
                return this.rltdDtFieldSpecified;
            }
            set
            {
                this.rltdDtFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LineDtls")]
        public DocumentLineInformation1[] LineDtls
        {
            get
            {
                return this.lineDtlsField;
            }
            set
            {
                this.lineDtlsField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class ReferredDocumentType4
    {

        private ReferredDocumentType3Choice cdOrPrtryField;

        private string issrField;

        /// <remarks/>
        public ReferredDocumentType3Choice CdOrPrtry
        {
            get
            {
                return this.cdOrPrtryField;
            }
            set
            {
                this.cdOrPrtryField = value;
            }
        }

        /// <remarks/>
        public string Issr
        {
            get
            {
                return this.issrField;
            }
            set
            {
                this.issrField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class ReferredDocumentType3Choice
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(DocumentType6Code))]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(string))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public enum DocumentType6Code
    {

        /// <remarks/>
        MSIN,

        /// <remarks/>
        CNFA,

        /// <remarks/>
        DNFA,

        /// <remarks/>
        CINV,

        /// <remarks/>
        CREN,

        /// <remarks/>
        DEBN,

        /// <remarks/>
        HIRI,

        /// <remarks/>
        SBIN,

        /// <remarks/>
        CMCN,

        /// <remarks/>
        SOAC,

        /// <remarks/>
        DISP,

        /// <remarks/>
        BOLD,

        /// <remarks/>
        VCHR,

        /// <remarks/>
        AROI,

        /// <remarks/>
        TSUT,

        /// <remarks/>
        PUOR,
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class DocumentLineInformation1
    {

        private DocumentLineIdentification1[] idField;

        private string descField;

        private RemittanceAmount3 amtField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Id")]
        public DocumentLineIdentification1[] Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string Desc
        {
            get
            {
                return this.descField;
            }
            set
            {
                this.descField = value;
            }
        }

        /// <remarks/>
        public RemittanceAmount3 Amt
        {
            get
            {
                return this.amtField;
            }
            set
            {
                this.amtField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class DocumentLineIdentification1
    {

        private DocumentLineType1 tpField;

        private string nbField;

        private System.DateTime rltdDtField;

        private bool rltdDtFieldSpecified;

        /// <remarks/>
        public DocumentLineType1 Tp
        {
            get
            {
                return this.tpField;
            }
            set
            {
                this.tpField = value;
            }
        }

        /// <remarks/>
        public string Nb
        {
            get
            {
                return this.nbField;
            }
            set
            {
                this.nbField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime RltdDt
        {
            get
            {
                return this.rltdDtField;
            }
            set
            {
                this.rltdDtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RltdDtSpecified
        {
            get
            {
                return this.rltdDtFieldSpecified;
            }
            set
            {
                this.rltdDtFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class DocumentLineType1
    {

        private DocumentLineType1Choice cdOrPrtryField;

        private string issrField;

        /// <remarks/>
        public DocumentLineType1Choice CdOrPrtry
        {
            get
            {
                return this.cdOrPrtryField;
            }
            set
            {
                this.cdOrPrtryField = value;
            }
        }

        /// <remarks/>
        public string Issr
        {
            get
            {
                return this.issrField;
            }
            set
            {
                this.issrField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class DocumentLineType1Choice
    {

        private string itemField;

        private ItemChoiceType11 itemElementNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType11 ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09", IncludeInSchema = false)]
    public enum ItemChoiceType11
    {

        /// <remarks/>
        Cd,

        /// <remarks/>
        Prtry,
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class RemittanceAmount3
    {

        private ActiveOrHistoricCurrencyAndAmount duePyblAmtField;

        private DiscountAmountAndType1[] dscntApldAmtField;

        private ActiveOrHistoricCurrencyAndAmount cdtNoteAmtField;

        private TaxAmountAndType1[] taxAmtField;

        private DocumentAdjustment1[] adjstmntAmtAndRsnField;

        private ActiveOrHistoricCurrencyAndAmount rmtdAmtField;

        /// <remarks/>
        public ActiveOrHistoricCurrencyAndAmount DuePyblAmt
        {
            get
            {
                return this.duePyblAmtField;
            }
            set
            {
                this.duePyblAmtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DscntApldAmt")]
        public DiscountAmountAndType1[] DscntApldAmt
        {
            get
            {
                return this.dscntApldAmtField;
            }
            set
            {
                this.dscntApldAmtField = value;
            }
        }

        /// <remarks/>
        public ActiveOrHistoricCurrencyAndAmount CdtNoteAmt
        {
            get
            {
                return this.cdtNoteAmtField;
            }
            set
            {
                this.cdtNoteAmtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TaxAmt")]
        public TaxAmountAndType1[] TaxAmt
        {
            get
            {
                return this.taxAmtField;
            }
            set
            {
                this.taxAmtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AdjstmntAmtAndRsn")]
        public DocumentAdjustment1[] AdjstmntAmtAndRsn
        {
            get
            {
                return this.adjstmntAmtAndRsnField;
            }
            set
            {
                this.adjstmntAmtAndRsnField = value;
            }
        }

        /// <remarks/>
        public ActiveOrHistoricCurrencyAndAmount RmtdAmt
        {
            get
            {
                return this.rmtdAmtField;
            }
            set
            {
                this.rmtdAmtField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class DiscountAmountAndType1
    {

        private DiscountAmountType1Choice tpField;

        private ActiveOrHistoricCurrencyAndAmount amtField;

        /// <remarks/>
        public DiscountAmountType1Choice Tp
        {
            get
            {
                return this.tpField;
            }
            set
            {
                this.tpField = value;
            }
        }

        /// <remarks/>
        public ActiveOrHistoricCurrencyAndAmount Amt
        {
            get
            {
                return this.amtField;
            }
            set
            {
                this.amtField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class DiscountAmountType1Choice
    {

        private string itemField;

        private ItemChoiceType12 itemElementNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType12 ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09", IncludeInSchema = false)]
    public enum ItemChoiceType12
    {

        /// <remarks/>
        Cd,

        /// <remarks/>
        Prtry,
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class TaxAmountAndType1
    {

        private TaxAmountType1Choice tpField;

        private ActiveOrHistoricCurrencyAndAmount amtField;

        /// <remarks/>
        public TaxAmountType1Choice Tp
        {
            get
            {
                return this.tpField;
            }
            set
            {
                this.tpField = value;
            }
        }

        /// <remarks/>
        public ActiveOrHistoricCurrencyAndAmount Amt
        {
            get
            {
                return this.amtField;
            }
            set
            {
                this.amtField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class TaxAmountType1Choice
    {

        private string itemField;

        private ItemChoiceType13 itemElementNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType13 ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09", IncludeInSchema = false)]
    public enum ItemChoiceType13
    {

        /// <remarks/>
        Cd,

        /// <remarks/>
        Prtry,
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class DocumentAdjustment1
    {

        private ActiveOrHistoricCurrencyAndAmount amtField;

        private CreditDebitCode cdtDbtIndField;

        private bool cdtDbtIndFieldSpecified;

        private string rsnField;

        private string addtlInfField;

        /// <remarks/>
        public ActiveOrHistoricCurrencyAndAmount Amt
        {
            get
            {
                return this.amtField;
            }
            set
            {
                this.amtField = value;
            }
        }

        /// <remarks/>
        public CreditDebitCode CdtDbtInd
        {
            get
            {
                return this.cdtDbtIndField;
            }
            set
            {
                this.cdtDbtIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CdtDbtIndSpecified
        {
            get
            {
                return this.cdtDbtIndFieldSpecified;
            }
            set
            {
                this.cdtDbtIndFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string Rsn
        {
            get
            {
                return this.rsnField;
            }
            set
            {
                this.rsnField = value;
            }
        }

        /// <remarks/>
        public string AddtlInf
        {
            get
            {
                return this.addtlInfField;
            }
            set
            {
                this.addtlInfField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class RemittanceAmount2
    {

        private ActiveOrHistoricCurrencyAndAmount duePyblAmtField;

        private DiscountAmountAndType1[] dscntApldAmtField;

        private ActiveOrHistoricCurrencyAndAmount cdtNoteAmtField;

        private TaxAmountAndType1[] taxAmtField;

        private DocumentAdjustment1[] adjstmntAmtAndRsnField;

        private ActiveOrHistoricCurrencyAndAmount rmtdAmtField;

        /// <remarks/>
        public ActiveOrHistoricCurrencyAndAmount DuePyblAmt
        {
            get
            {
                return this.duePyblAmtField;
            }
            set
            {
                this.duePyblAmtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DscntApldAmt")]
        public DiscountAmountAndType1[] DscntApldAmt
        {
            get
            {
                return this.dscntApldAmtField;
            }
            set
            {
                this.dscntApldAmtField = value;
            }
        }

        /// <remarks/>
        public ActiveOrHistoricCurrencyAndAmount CdtNoteAmt
        {
            get
            {
                return this.cdtNoteAmtField;
            }
            set
            {
                this.cdtNoteAmtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TaxAmt")]
        public TaxAmountAndType1[] TaxAmt
        {
            get
            {
                return this.taxAmtField;
            }
            set
            {
                this.taxAmtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AdjstmntAmtAndRsn")]
        public DocumentAdjustment1[] AdjstmntAmtAndRsn
        {
            get
            {
                return this.adjstmntAmtAndRsnField;
            }
            set
            {
                this.adjstmntAmtAndRsnField = value;
            }
        }

        /// <remarks/>
        public ActiveOrHistoricCurrencyAndAmount RmtdAmt
        {
            get
            {
                return this.rmtdAmtField;
            }
            set
            {
                this.rmtdAmtField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class CreditorReferenceInformation2
    {

        private CreditorReferenceType2 tpField;

        private string refField;

        /// <remarks/>
        public CreditorReferenceType2 Tp
        {
            get
            {
                return this.tpField;
            }
            set
            {
                this.tpField = value;
            }
        }

        /// <remarks/>
        public string Ref
        {
            get
            {
                return this.refField;
            }
            set
            {
                this.refField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class CreditorReferenceType2
    {

        private CreditorReferenceType1Choice cdOrPrtryField;

        private string issrField;

        /// <remarks/>
        public CreditorReferenceType1Choice CdOrPrtry
        {
            get
            {
                return this.cdOrPrtryField;
            }
            set
            {
                this.cdOrPrtryField = value;
            }
        }

        /// <remarks/>
        public string Issr
        {
            get
            {
                return this.issrField;
            }
            set
            {
                this.issrField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class CreditorReferenceType1Choice
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(DocumentType3Code))]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(string))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public enum DocumentType3Code
    {

        /// <remarks/>
        RADM,

        /// <remarks/>
        RPIN,

        /// <remarks/>
        FXDR,

        /// <remarks/>
        DISP,

        /// <remarks/>
        PUOR,

        /// <remarks/>
        SCOR,
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class TaxInformation7
    {

        private TaxParty1 cdtrField;

        private TaxParty2 dbtrField;

        private TaxParty2 ultmtDbtrField;

        private string admstnZoneField;

        private string refNbField;

        private string mtdField;

        private ActiveOrHistoricCurrencyAndAmount ttlTaxblBaseAmtField;

        private ActiveOrHistoricCurrencyAndAmount ttlTaxAmtField;

        private System.DateTime dtField;

        private bool dtFieldSpecified;

        private decimal seqNbField;

        private bool seqNbFieldSpecified;

        private TaxRecord2[] rcrdField;

        /// <remarks/>
        public TaxParty1 Cdtr
        {
            get
            {
                return this.cdtrField;
            }
            set
            {
                this.cdtrField = value;
            }
        }

        /// <remarks/>
        public TaxParty2 Dbtr
        {
            get
            {
                return this.dbtrField;
            }
            set
            {
                this.dbtrField = value;
            }
        }

        /// <remarks/>
        public TaxParty2 UltmtDbtr
        {
            get
            {
                return this.ultmtDbtrField;
            }
            set
            {
                this.ultmtDbtrField = value;
            }
        }

        /// <remarks/>
        public string AdmstnZone
        {
            get
            {
                return this.admstnZoneField;
            }
            set
            {
                this.admstnZoneField = value;
            }
        }

        /// <remarks/>
        public string RefNb
        {
            get
            {
                return this.refNbField;
            }
            set
            {
                this.refNbField = value;
            }
        }

        /// <remarks/>
        public string Mtd
        {
            get
            {
                return this.mtdField;
            }
            set
            {
                this.mtdField = value;
            }
        }

        /// <remarks/>
        public ActiveOrHistoricCurrencyAndAmount TtlTaxblBaseAmt
        {
            get
            {
                return this.ttlTaxblBaseAmtField;
            }
            set
            {
                this.ttlTaxblBaseAmtField = value;
            }
        }

        /// <remarks/>
        public ActiveOrHistoricCurrencyAndAmount TtlTaxAmt
        {
            get
            {
                return this.ttlTaxAmtField;
            }
            set
            {
                this.ttlTaxAmtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime Dt
        {
            get
            {
                return this.dtField;
            }
            set
            {
                this.dtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DtSpecified
        {
            get
            {
                return this.dtFieldSpecified;
            }
            set
            {
                this.dtFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal SeqNb
        {
            get
            {
                return this.seqNbField;
            }
            set
            {
                this.seqNbField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SeqNbSpecified
        {
            get
            {
                return this.seqNbFieldSpecified;
            }
            set
            {
                this.seqNbFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Rcrd")]
        public TaxRecord2[] Rcrd
        {
            get
            {
                return this.rcrdField;
            }
            set
            {
                this.rcrdField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class Garnishment3
    {

        private GarnishmentType1 tpField;

        private PartyIdentification135 grnsheeField;

        private PartyIdentification135 grnshmtAdmstrField;

        private string refNbField;

        private System.DateTime dtField;

        private bool dtFieldSpecified;

        private ActiveOrHistoricCurrencyAndAmount rmtdAmtField;

        private bool fmlyMdclInsrncIndField;

        private bool fmlyMdclInsrncIndFieldSpecified;

        private bool mplyeeTermntnIndField;

        private bool mplyeeTermntnIndFieldSpecified;

        /// <remarks/>
        public GarnishmentType1 Tp
        {
            get
            {
                return this.tpField;
            }
            set
            {
                this.tpField = value;
            }
        }

        /// <remarks/>
        public PartyIdentification135 Grnshee
        {
            get
            {
                return this.grnsheeField;
            }
            set
            {
                this.grnsheeField = value;
            }
        }

        /// <remarks/>
        public PartyIdentification135 GrnshmtAdmstr
        {
            get
            {
                return this.grnshmtAdmstrField;
            }
            set
            {
                this.grnshmtAdmstrField = value;
            }
        }

        /// <remarks/>
        public string RefNb
        {
            get
            {
                return this.refNbField;
            }
            set
            {
                this.refNbField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime Dt
        {
            get
            {
                return this.dtField;
            }
            set
            {
                this.dtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DtSpecified
        {
            get
            {
                return this.dtFieldSpecified;
            }
            set
            {
                this.dtFieldSpecified = value;
            }
        }

        /// <remarks/>
        public ActiveOrHistoricCurrencyAndAmount RmtdAmt
        {
            get
            {
                return this.rmtdAmtField;
            }
            set
            {
                this.rmtdAmtField = value;
            }
        }

        /// <remarks/>
        public bool FmlyMdclInsrncInd
        {
            get
            {
                return this.fmlyMdclInsrncIndField;
            }
            set
            {
                this.fmlyMdclInsrncIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FmlyMdclInsrncIndSpecified
        {
            get
            {
                return this.fmlyMdclInsrncIndFieldSpecified;
            }
            set
            {
                this.fmlyMdclInsrncIndFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool MplyeeTermntnInd
        {
            get
            {
                return this.mplyeeTermntnIndField;
            }
            set
            {
                this.mplyeeTermntnIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MplyeeTermntnIndSpecified
        {
            get
            {
                return this.mplyeeTermntnIndFieldSpecified;
            }
            set
            {
                this.mplyeeTermntnIndFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class GarnishmentType1
    {

        private GarnishmentType1Choice cdOrPrtryField;

        private string issrField;

        /// <remarks/>
        public GarnishmentType1Choice CdOrPrtry
        {
            get
            {
                return this.cdOrPrtryField;
            }
            set
            {
                this.cdOrPrtryField = value;
            }
        }

        /// <remarks/>
        public string Issr
        {
            get
            {
                return this.issrField;
            }
            set
            {
                this.issrField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class GarnishmentType1Choice
    {

        private string itemField;

        private ItemChoiceType14 itemElementNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType14 ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09", IncludeInSchema = false)]
    public enum ItemChoiceType14
    {

        /// <remarks/>
        Cd,

        /// <remarks/>
        Prtry,
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class SupplementaryData1
    {

        private string plcAndNmField;

        private System.Xml.XmlElement envlpField;

        /// <remarks/>
        public string PlcAndNm
        {
            get
            {
                return this.plcAndNmField;
            }
            set
            {
                this.plcAndNmField = value;
            }
        }

        /// <remarks/>
        public System.Xml.XmlElement Envlp
        {
            get
            {
                return this.envlpField;
            }
            set
            {
                this.envlpField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class CustomerCreditTransferInitiationV09
    {

        private GroupHeader85 grpHdrField;

        private PaymentInstruction30[] pmtInfField;

        private SupplementaryData1[] splmtryDataField;

        /// <remarks/>
        public GroupHeader85 GrpHdr
        {
            get
            {
                return this.grpHdrField;
            }
            set
            {
                this.grpHdrField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PmtInf")]
        public PaymentInstruction30[] PmtInf
        {
            get
            {
                return this.pmtInfField;
            }
            set
            {
                this.pmtInfField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SplmtryData")]
        public SupplementaryData1[] SplmtryData
        {
            get
            {
                return this.splmtryDataField;
            }
            set
            {
                this.splmtryDataField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class GroupHeader85
    {

        private string msgIdField;

        private System.DateTime creDtTmField;

        private Authorisation1Choice[] authstnField;

        private string nbOfTxsField;

        private decimal ctrlSumField;

        private bool ctrlSumFieldSpecified;

        private PartyIdentification135 initgPtyField;

        private BranchAndFinancialInstitutionIdentification6 fwdgAgtField;

        /// <remarks/>
        public string MsgId
        {
            get
            {
                return this.msgIdField;
            }
            set
            {
                this.msgIdField = value;
            }
        }

        /// <remarks/>
        public System.DateTime CreDtTm
        {
            get
            {
                return this.creDtTmField;
            }
            set
            {
                this.creDtTmField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Authstn")]
        public Authorisation1Choice[] Authstn
        {
            get
            {
                return this.authstnField;
            }
            set
            {
                this.authstnField = value;
            }
        }

        /// <remarks/>
        public string NbOfTxs
        {
            get
            {
                return this.nbOfTxsField;
            }
            set
            {
                this.nbOfTxsField = value;
            }
        }

        /// <remarks/>
        public decimal CtrlSum
        {
            get
            {
                return this.ctrlSumField;
            }
            set
            {
                this.ctrlSumField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CtrlSumSpecified
        {
            get
            {
                return this.ctrlSumFieldSpecified;
            }
            set
            {
                this.ctrlSumFieldSpecified = value;
            }
        }

        /// <remarks/>
        public PartyIdentification135 InitgPty
        {
            get
            {
                return this.initgPtyField;
            }
            set
            {
                this.initgPtyField = value;
            }
        }

        /// <remarks/>
        public BranchAndFinancialInstitutionIdentification6 FwdgAgt
        {
            get
            {
                return this.fwdgAgtField;
            }
            set
            {
                this.fwdgAgtField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class PaymentInstruction30
    {

        private string pmtInfIdField;

        private PaymentMethod3Code pmtMtdField;

        private bool btchBookgField;

        private bool btchBookgFieldSpecified;

        private string nbOfTxsField;

        private decimal ctrlSumField;

        private bool ctrlSumFieldSpecified;

        private PaymentTypeInformation26 pmtTpInfField;

        private DateAndDateTime2Choice reqdExctnDtField;

        private System.DateTime poolgAdjstmntDtField;

        private bool poolgAdjstmntDtFieldSpecified;

        private PartyIdentification135 dbtrField;

        private CashAccount38 dbtrAcctField;

        private BranchAndFinancialInstitutionIdentification6 dbtrAgtField;

        private CashAccount38 dbtrAgtAcctField;

        private string instrForDbtrAgtField;

        private PartyIdentification135 ultmtDbtrField;

        private ChargeBearerType1Code chrgBrField;

        private bool chrgBrFieldSpecified;

        private CashAccount38 chrgsAcctField;

        private BranchAndFinancialInstitutionIdentification6 chrgsAcctAgtField;

        private CreditTransferTransaction34[] cdtTrfTxInfField;

        /// <remarks/>
        public string PmtInfId
        {
            get
            {
                return this.pmtInfIdField;
            }
            set
            {
                this.pmtInfIdField = value;
            }
        }

        /// <remarks/>
        public PaymentMethod3Code PmtMtd
        {
            get
            {
                return this.pmtMtdField;
            }
            set
            {
                this.pmtMtdField = value;
            }
        }

        /// <remarks/>
        public bool BtchBookg
        {
            get
            {
                return this.btchBookgField;
            }
            set
            {
                this.btchBookgField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BtchBookgSpecified
        {
            get
            {
                return this.btchBookgFieldSpecified;
            }
            set
            {
                this.btchBookgFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string NbOfTxs
        {
            get
            {
                return this.nbOfTxsField;
            }
            set
            {
                this.nbOfTxsField = value;
            }
        }

        /// <remarks/>
        public decimal CtrlSum
        {
            get
            {
                return this.ctrlSumField;
            }
            set
            {
                this.ctrlSumField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CtrlSumSpecified
        {
            get
            {
                return this.ctrlSumFieldSpecified;
            }
            set
            {
                this.ctrlSumFieldSpecified = value;
            }
        }

        /// <remarks/>
        public PaymentTypeInformation26 PmtTpInf
        {
            get
            {
                return this.pmtTpInfField;
            }
            set
            {
                this.pmtTpInfField = value;
            }
        }

        /// <remarks/>
        public DateAndDateTime2Choice ReqdExctnDt
        {
            get
            {
                return this.reqdExctnDtField;
            }
            set
            {
                this.reqdExctnDtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime PoolgAdjstmntDt
        {
            get
            {
                return this.poolgAdjstmntDtField;
            }
            set
            {
                this.poolgAdjstmntDtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PoolgAdjstmntDtSpecified
        {
            get
            {
                return this.poolgAdjstmntDtFieldSpecified;
            }
            set
            {
                this.poolgAdjstmntDtFieldSpecified = value;
            }
        }

        /// <remarks/>
        public PartyIdentification135 Dbtr
        {
            get
            {
                return this.dbtrField;
            }
            set
            {
                this.dbtrField = value;
            }
        }

        /// <remarks/>
        public CashAccount38 DbtrAcct
        {
            get
            {
                return this.dbtrAcctField;
            }
            set
            {
                this.dbtrAcctField = value;
            }
        }

        /// <remarks/>
        public BranchAndFinancialInstitutionIdentification6 DbtrAgt
        {
            get
            {
                return this.dbtrAgtField;
            }
            set
            {
                this.dbtrAgtField = value;
            }
        }

        /// <remarks/>
        public CashAccount38 DbtrAgtAcct
        {
            get
            {
                return this.dbtrAgtAcctField;
            }
            set
            {
                this.dbtrAgtAcctField = value;
            }
        }

        /// <remarks/>
        public string InstrForDbtrAgt
        {
            get
            {
                return this.instrForDbtrAgtField;
            }
            set
            {
                this.instrForDbtrAgtField = value;
            }
        }

        /// <remarks/>
        public PartyIdentification135 UltmtDbtr
        {
            get
            {
                return this.ultmtDbtrField;
            }
            set
            {
                this.ultmtDbtrField = value;
            }
        }

        /// <remarks/>
        public ChargeBearerType1Code ChrgBr
        {
            get
            {
                return this.chrgBrField;
            }
            set
            {
                this.chrgBrField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ChrgBrSpecified
        {
            get
            {
                return this.chrgBrFieldSpecified;
            }
            set
            {
                this.chrgBrFieldSpecified = value;
            }
        }

        /// <remarks/>
        public CashAccount38 ChrgsAcct
        {
            get
            {
                return this.chrgsAcctField;
            }
            set
            {
                this.chrgsAcctField = value;
            }
        }

        /// <remarks/>
        public BranchAndFinancialInstitutionIdentification6 ChrgsAcctAgt
        {
            get
            {
                return this.chrgsAcctAgtField;
            }
            set
            {
                this.chrgsAcctAgtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CdtTrfTxInf")]
        public CreditTransferTransaction34[] CdtTrfTxInf
        {
            get
            {
                return this.cdtTrfTxInfField;
            }
            set
            {
                this.cdtTrfTxInfField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public enum PaymentMethod3Code
    {

        /// <remarks/>
        CHK,

        /// <remarks/>
        TRF,

        /// <remarks/>
        TRA,
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class DateAndDateTime2Choice
    {

        private System.DateTime itemField;

        private ItemChoiceType15 itemElementNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Dt", typeof(System.DateTime), DataType = "date")]
        [System.Xml.Serialization.XmlElementAttribute("DtTm", typeof(System.DateTime))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public System.DateTime Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType15 ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09", IncludeInSchema = false)]
    public enum ItemChoiceType15
    {

        /// <remarks/>
        Dt,

        /// <remarks/>
        DtTm,
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09")]
    public partial class Document
    {

        private CustomerCreditTransferInitiationV09 cstmrCdtTrfInitnField;

        /// <remarks/>
        public CustomerCreditTransferInitiationV09 CstmrCdtTrfInitn
        {
            get
            {
                return this.cstmrCdtTrfInitnField;
            }
            set
            {
                this.cstmrCdtTrfInitnField = value;
            }
        }
    }
}