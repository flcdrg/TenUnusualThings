

// This file was automatically generated.
// Do not make changes directly to this file - edit the template instead.
// 
// The following connection settings were used to generate this file
// 
//     Configuration file:     "EFExtensions\App.config"
//     Connection String Name: "AW"
//     Connection String:      "Data Source=.\sql2014;Initial Catalog=AdventureWorks2014;Integrated Security=True;"

// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Threading;
using System.Threading.Tasks;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace EFExtensions
{
    // ************************************************************************
    // Unit of work
    public interface IMyDbContext : IDisposable
    {
        IDbSet<CountryRegionCurrency> CountryRegionCurrencies { get; set; } // CountryRegionCurrency
        IDbSet<CreditCard> CreditCards { get; set; } // CreditCard
        IDbSet<Currency> Currencies { get; set; } // Currency
        IDbSet<CurrencyRate> CurrencyRates { get; set; } // CurrencyRate
        IDbSet<Customer> Customers { get; set; } // Customer
        IDbSet<PersonCreditCard> PersonCreditCards { get; set; } // PersonCreditCard
        IDbSet<SalesOrderDetail> SalesOrderDetails { get; set; } // SalesOrderDetail
        IDbSet<SalesOrderHeader> SalesOrderHeaders { get; set; } // SalesOrderHeader
        IDbSet<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReasons { get; set; } // SalesOrderHeaderSalesReason
        IDbSet<SalesPerson> SalesPersons { get; set; } // SalesPerson
        IDbSet<SalesPersonQuotaHistory> SalesPersonQuotaHistories { get; set; } // SalesPersonQuotaHistory
        IDbSet<SalesReason> SalesReasons { get; set; } // SalesReason
        IDbSet<SalesTaxRate> SalesTaxRates { get; set; } // SalesTaxRate
        IDbSet<SalesTerritory> SalesTerritories { get; set; } // SalesTerritory
        IDbSet<SalesTerritoryHistory> SalesTerritoryHistories { get; set; } // SalesTerritoryHistory
        IDbSet<ShoppingCartItem> ShoppingCartItems { get; set; } // ShoppingCartItem
        IDbSet<SpecialOffer> SpecialOffers { get; set; } // SpecialOffer
        IDbSet<SpecialOfferProduct> SpecialOfferProducts { get; set; } // SpecialOfferProduct
        IDbSet<Store> Stores { get; set; } // Store
        IDbSet<VIndividualCustomer> VIndividualCustomers { get; set; } // vIndividualCustomer
        IDbSet<VPersonDemographic> VPersonDemographics { get; set; } // vPersonDemographics
        IDbSet<VSalesPerson> VSalesPersons { get; set; } // vSalesPerson
        IDbSet<VSalesPersonSalesByFiscalYear> VSalesPersonSalesByFiscalYears { get; set; } // vSalesPersonSalesByFiscalYears
        IDbSet<VStoreWithAddress> VStoreWithAddresses { get; set; } // vStoreWithAddresses
        IDbSet<VStoreWithContact> VStoreWithContacts { get; set; } // vStoreWithContacts
        IDbSet<VStoreWithDemographic> VStoreWithDemographics { get; set; } // vStoreWithDemographics

        int SaveChanges();
        Task<int> SaveChangesAsync();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }

    // ************************************************************************
    // Database context
    public class MyDbContext : DbContext, IMyDbContext
    {
        public IDbSet<CountryRegionCurrency> CountryRegionCurrencies { get; set; } // CountryRegionCurrency
        public IDbSet<CreditCard> CreditCards { get; set; } // CreditCard
        public IDbSet<Currency> Currencies { get; set; } // Currency
        public IDbSet<CurrencyRate> CurrencyRates { get; set; } // CurrencyRate
        public IDbSet<Customer> Customers { get; set; } // Customer
        public IDbSet<PersonCreditCard> PersonCreditCards { get; set; } // PersonCreditCard
        public IDbSet<SalesOrderDetail> SalesOrderDetails { get; set; } // SalesOrderDetail
        public IDbSet<SalesOrderHeader> SalesOrderHeaders { get; set; } // SalesOrderHeader
        public IDbSet<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReasons { get; set; } // SalesOrderHeaderSalesReason
        public IDbSet<SalesPerson> SalesPersons { get; set; } // SalesPerson
        public IDbSet<SalesPersonQuotaHistory> SalesPersonQuotaHistories { get; set; } // SalesPersonQuotaHistory
        public IDbSet<SalesReason> SalesReasons { get; set; } // SalesReason
        public IDbSet<SalesTaxRate> SalesTaxRates { get; set; } // SalesTaxRate
        public IDbSet<SalesTerritory> SalesTerritories { get; set; } // SalesTerritory
        public IDbSet<SalesTerritoryHistory> SalesTerritoryHistories { get; set; } // SalesTerritoryHistory
        public IDbSet<ShoppingCartItem> ShoppingCartItems { get; set; } // ShoppingCartItem
        public IDbSet<SpecialOffer> SpecialOffers { get; set; } // SpecialOffer
        public IDbSet<SpecialOfferProduct> SpecialOfferProducts { get; set; } // SpecialOfferProduct
        public IDbSet<Store> Stores { get; set; } // Store
        public IDbSet<VIndividualCustomer> VIndividualCustomers { get; set; } // vIndividualCustomer
        public IDbSet<VPersonDemographic> VPersonDemographics { get; set; } // vPersonDemographics
        public IDbSet<VSalesPerson> VSalesPersons { get; set; } // vSalesPerson
        public IDbSet<VSalesPersonSalesByFiscalYear> VSalesPersonSalesByFiscalYears { get; set; } // vSalesPersonSalesByFiscalYears
        public IDbSet<VStoreWithAddress> VStoreWithAddresses { get; set; } // vStoreWithAddresses
        public IDbSet<VStoreWithContact> VStoreWithContacts { get; set; } // vStoreWithContacts
        public IDbSet<VStoreWithDemographic> VStoreWithDemographics { get; set; } // vStoreWithDemographics
        
        static MyDbContext()
        {
            Database.SetInitializer<MyDbContext>(null);
        }

        public MyDbContext()
            : base("Name=AW")
        {
        }

        public MyDbContext(string connectionString) : base(connectionString)
        {
        }

        public MyDbContext(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model) : base(connectionString, model)
        {
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new CountryRegionCurrencyConfiguration());
            modelBuilder.Configurations.Add(new CreditCardConfiguration());
            modelBuilder.Configurations.Add(new CurrencyConfiguration());
            modelBuilder.Configurations.Add(new CurrencyRateConfiguration());
            modelBuilder.Configurations.Add(new CustomerConfiguration());
            modelBuilder.Configurations.Add(new PersonCreditCardConfiguration());
            modelBuilder.Configurations.Add(new SalesOrderDetailConfiguration());
            modelBuilder.Configurations.Add(new SalesOrderHeaderConfiguration());
            modelBuilder.Configurations.Add(new SalesOrderHeaderSalesReasonConfiguration());
            modelBuilder.Configurations.Add(new SalesPersonConfiguration());
            modelBuilder.Configurations.Add(new SalesPersonQuotaHistoryConfiguration());
            modelBuilder.Configurations.Add(new SalesReasonConfiguration());
            modelBuilder.Configurations.Add(new SalesTaxRateConfiguration());
            modelBuilder.Configurations.Add(new SalesTerritoryConfiguration());
            modelBuilder.Configurations.Add(new SalesTerritoryHistoryConfiguration());
            modelBuilder.Configurations.Add(new ShoppingCartItemConfiguration());
            modelBuilder.Configurations.Add(new SpecialOfferConfiguration());
            modelBuilder.Configurations.Add(new SpecialOfferProductConfiguration());
            modelBuilder.Configurations.Add(new StoreConfiguration());
            modelBuilder.Configurations.Add(new VIndividualCustomerConfiguration());
            modelBuilder.Configurations.Add(new VPersonDemographicConfiguration());
            modelBuilder.Configurations.Add(new VSalesPersonConfiguration());
            modelBuilder.Configurations.Add(new VSalesPersonSalesByFiscalYearConfiguration());
            modelBuilder.Configurations.Add(new VStoreWithAddressConfiguration());
            modelBuilder.Configurations.Add(new VStoreWithContactConfiguration());
            modelBuilder.Configurations.Add(new VStoreWithDemographicConfiguration());
        }

        public static DbModelBuilder CreateModel(DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new CountryRegionCurrencyConfiguration(schema));
            modelBuilder.Configurations.Add(new CreditCardConfiguration(schema));
            modelBuilder.Configurations.Add(new CurrencyConfiguration(schema));
            modelBuilder.Configurations.Add(new CurrencyRateConfiguration(schema));
            modelBuilder.Configurations.Add(new CustomerConfiguration(schema));
            modelBuilder.Configurations.Add(new PersonCreditCardConfiguration(schema));
            modelBuilder.Configurations.Add(new SalesOrderDetailConfiguration(schema));
            modelBuilder.Configurations.Add(new SalesOrderHeaderConfiguration(schema));
            modelBuilder.Configurations.Add(new SalesOrderHeaderSalesReasonConfiguration(schema));
            modelBuilder.Configurations.Add(new SalesPersonConfiguration(schema));
            modelBuilder.Configurations.Add(new SalesPersonQuotaHistoryConfiguration(schema));
            modelBuilder.Configurations.Add(new SalesReasonConfiguration(schema));
            modelBuilder.Configurations.Add(new SalesTaxRateConfiguration(schema));
            modelBuilder.Configurations.Add(new SalesTerritoryConfiguration(schema));
            modelBuilder.Configurations.Add(new SalesTerritoryHistoryConfiguration(schema));
            modelBuilder.Configurations.Add(new ShoppingCartItemConfiguration(schema));
            modelBuilder.Configurations.Add(new SpecialOfferConfiguration(schema));
            modelBuilder.Configurations.Add(new SpecialOfferProductConfiguration(schema));
            modelBuilder.Configurations.Add(new StoreConfiguration(schema));
            modelBuilder.Configurations.Add(new VIndividualCustomerConfiguration(schema));
            modelBuilder.Configurations.Add(new VPersonDemographicConfiguration(schema));
            modelBuilder.Configurations.Add(new VSalesPersonConfiguration(schema));
            modelBuilder.Configurations.Add(new VSalesPersonSalesByFiscalYearConfiguration(schema));
            modelBuilder.Configurations.Add(new VStoreWithAddressConfiguration(schema));
            modelBuilder.Configurations.Add(new VStoreWithContactConfiguration(schema));
            modelBuilder.Configurations.Add(new VStoreWithDemographicConfiguration(schema));
            return modelBuilder;
        }
    }

    // ************************************************************************
    // Fake Database context
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.12.3.0")]
    public class FakeMyDbContext : IMyDbContext
    {
        public IDbSet<CountryRegionCurrency> CountryRegionCurrencies { get; set; }
        public IDbSet<CreditCard> CreditCards { get; set; }
        public IDbSet<Currency> Currencies { get; set; }
        public IDbSet<CurrencyRate> CurrencyRates { get; set; }
        public IDbSet<Customer> Customers { get; set; }
        public IDbSet<PersonCreditCard> PersonCreditCards { get; set; }
        public IDbSet<SalesOrderDetail> SalesOrderDetails { get; set; }
        public IDbSet<SalesOrderHeader> SalesOrderHeaders { get; set; }
        public IDbSet<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReasons { get; set; }
        public IDbSet<SalesPerson> SalesPersons { get; set; }
        public IDbSet<SalesPersonQuotaHistory> SalesPersonQuotaHistories { get; set; }
        public IDbSet<SalesReason> SalesReasons { get; set; }
        public IDbSet<SalesTaxRate> SalesTaxRates { get; set; }
        public IDbSet<SalesTerritory> SalesTerritories { get; set; }
        public IDbSet<SalesTerritoryHistory> SalesTerritoryHistories { get; set; }
        public IDbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public IDbSet<SpecialOffer> SpecialOffers { get; set; }
        public IDbSet<SpecialOfferProduct> SpecialOfferProducts { get; set; }
        public IDbSet<Store> Stores { get; set; }
        public IDbSet<VIndividualCustomer> VIndividualCustomers { get; set; }
        public IDbSet<VPersonDemographic> VPersonDemographics { get; set; }
        public IDbSet<VSalesPerson> VSalesPersons { get; set; }
        public IDbSet<VSalesPersonSalesByFiscalYear> VSalesPersonSalesByFiscalYears { get; set; }
        public IDbSet<VStoreWithAddress> VStoreWithAddresses { get; set; }
        public IDbSet<VStoreWithContact> VStoreWithContacts { get; set; }
        public IDbSet<VStoreWithDemographic> VStoreWithDemographics { get; set; }

        public FakeMyDbContext()
        {
            CountryRegionCurrencies = new FakeDbSet<CountryRegionCurrency>();
            CreditCards = new FakeDbSet<CreditCard>();
            Currencies = new FakeDbSet<Currency>();
            CurrencyRates = new FakeDbSet<CurrencyRate>();
            Customers = new FakeDbSet<Customer>();
            PersonCreditCards = new FakeDbSet<PersonCreditCard>();
            SalesOrderDetails = new FakeDbSet<SalesOrderDetail>();
            SalesOrderHeaders = new FakeDbSet<SalesOrderHeader>();
            SalesOrderHeaderSalesReasons = new FakeDbSet<SalesOrderHeaderSalesReason>();
            SalesPersons = new FakeDbSet<SalesPerson>();
            SalesPersonQuotaHistories = new FakeDbSet<SalesPersonQuotaHistory>();
            SalesReasons = new FakeDbSet<SalesReason>();
            SalesTaxRates = new FakeDbSet<SalesTaxRate>();
            SalesTerritories = new FakeDbSet<SalesTerritory>();
            SalesTerritoryHistories = new FakeDbSet<SalesTerritoryHistory>();
            ShoppingCartItems = new FakeDbSet<ShoppingCartItem>();
            SpecialOffers = new FakeDbSet<SpecialOffer>();
            SpecialOfferProducts = new FakeDbSet<SpecialOfferProduct>();
            Stores = new FakeDbSet<Store>();
            VIndividualCustomers = new FakeDbSet<VIndividualCustomer>();
            VPersonDemographics = new FakeDbSet<VPersonDemographic>();
            VSalesPersons = new FakeDbSet<VSalesPerson>();
            VSalesPersonSalesByFiscalYears = new FakeDbSet<VSalesPersonSalesByFiscalYear>();
            VStoreWithAddresses = new FakeDbSet<VStoreWithAddress>();
            VStoreWithContacts = new FakeDbSet<VStoreWithContact>();
            VStoreWithDemographics = new FakeDbSet<VStoreWithDemographic>();
        }

        public int SaveChanges()
        {
            return 0;
        }

        public Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        protected virtual void Dispose(bool disposing)
        {
        }
        
        public void Dispose()
        {
            Dispose(true);
        }
    }

    // ************************************************************************
    // Fake DbSet
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.12.3.0")]
    public class FakeDbSet<T> : IDbSet<T> where T : class
    {
        private readonly HashSet<T> _data;

        public FakeDbSet()
        {
            _data = new HashSet<T>();
        }

        public virtual T Find(params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public T Add(T item)
        {
            _data.Add(item);
            return item;
        }

        public T Remove(T item)
        {
            _data.Remove(item);
            return item;
        }

        public T Attach(T item)
        {
            _data.Add(item);
            return item;
        }

        public void Detach(T item)
        {
            _data.Remove(item);
        }

        Type IQueryable.ElementType
        {
            get { return _data.AsQueryable().ElementType; }
        }

        Expression IQueryable.Expression
        {
            get { return _data.AsQueryable().Expression; }
        }

        IQueryProvider IQueryable.Provider
        {
            get { return _data.AsQueryable().Provider; }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _data.GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return _data.GetEnumerator();
        }

        public T Create()
        {
            return Activator.CreateInstance<T>();
        }

        public ObservableCollection<T> Local
        {
            get
            {
                return new ObservableCollection<T>(_data);
            }
        }

        public TDerivedEntity Create<TDerivedEntity>() where TDerivedEntity : class, T
        {
            return Activator.CreateInstance<TDerivedEntity>();
        }
    }

    // ************************************************************************
    // POCO classes

    // CountryRegionCurrency
    public class CountryRegionCurrency
    {
        public string CountryRegionCode { get; set; } // CountryRegionCode (Primary key). ISO code for countries and regions. Foreign key to CountryRegion.CountryRegionCode.
        public string CurrencyCode { get; set; } // CurrencyCode (Primary key). ISO standard currency code. Foreign key to Currency.CurrencyCode.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual Currency Currency { get; set; } // FK_CountryRegionCurrency_Currency_CurrencyCode
        
        public CountryRegionCurrency()
        {
            ModifiedDate = System.DateTime.Now;
        }
    }

    // CreditCard
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.12.3.0")]
    public class CreditCard
    {
        public int CreditCardId { get; internal set; } // CreditCardID (Primary key). Primary key for CreditCard records.
        public string CardType { get; set; } // CardType. Credit card name.
        public string CardNumber { get; set; } // CardNumber. Credit card number.
        public byte ExpMonth { get; set; } // ExpMonth. Credit card expiration month.
        public short ExpYear { get; set; } // ExpYear. Credit card expiration year.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<PersonCreditCard> PersonCreditCards { get; set; } // Many to many mapping
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; } // SalesOrderHeader.FK_SalesOrderHeader_CreditCard_CreditCardID
        
        public CreditCard()
        {
            ModifiedDate = System.DateTime.Now;
            PersonCreditCards = new List<PersonCreditCard>();
            SalesOrderHeaders = new List<SalesOrderHeader>();
        }
    }

    // Currency
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.12.3.0")]
    public class Currency
    {
        public string CurrencyCode { get; set; } // CurrencyCode (Primary key). The ISO code for the Currency.
        public string Name { get; set; } // Name. Currency name.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<CountryRegionCurrency> CountryRegionCurrencies { get; set; } // Many to many mapping
        public virtual ICollection<CurrencyRate> CurrencyRates_FromCurrencyCode { get; set; } // CurrencyRate.FK_CurrencyRate_Currency_FromCurrencyCode
        public virtual ICollection<CurrencyRate> CurrencyRates_ToCurrencyCode { get; set; } // CurrencyRate.FK_CurrencyRate_Currency_ToCurrencyCode
        
        public Currency()
        {
            ModifiedDate = System.DateTime.Now;
            CountryRegionCurrencies = new List<CountryRegionCurrency>();
            CurrencyRates_FromCurrencyCode = new List<CurrencyRate>();
            CurrencyRates_ToCurrencyCode = new List<CurrencyRate>();
        }
    }

    // CurrencyRate
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.12.3.0")]
    public class CurrencyRate
    {
        public int CurrencyRateId { get; internal set; } // CurrencyRateID (Primary key). Primary key for CurrencyRate records.
        public DateTime CurrencyRateDate { get; set; } // CurrencyRateDate. Date and time the exchange rate was obtained.
        public string FromCurrencyCode { get; set; } // FromCurrencyCode. Exchange rate was converted from this currency code.
        public string ToCurrencyCode { get; set; } // ToCurrencyCode. Exchange rate was converted to this currency code.
        public decimal AverageRate { get; set; } // AverageRate. Average exchange rate for the day.
        public decimal EndOfDayRate { get; set; } // EndOfDayRate. Final exchange rate for the day.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; } // SalesOrderHeader.FK_SalesOrderHeader_CurrencyRate_CurrencyRateID

        // Foreign keys
        public virtual Currency Currency_FromCurrencyCode { get; set; } // FK_CurrencyRate_Currency_FromCurrencyCode
        public virtual Currency Currency_ToCurrencyCode { get; set; } // FK_CurrencyRate_Currency_ToCurrencyCode
        
        public CurrencyRate()
        {
            ModifiedDate = System.DateTime.Now;
            SalesOrderHeaders = new List<SalesOrderHeader>();
        }
    }

    // Customer
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.12.3.0")]
    public class Customer
    {
        public int CustomerId { get; internal set; } // CustomerID (Primary key). Primary key.
        public int? PersonId { get; set; } // PersonID. Foreign key to Person.BusinessEntityID
        public int? StoreId { get; set; } // StoreID. Foreign key to Store.BusinessEntityID
        public int? TerritoryId { get; set; } // TerritoryID. ID of the territory in which the customer is located. Foreign key to SalesTerritory.SalesTerritoryID.
        public string AccountNumber { get; internal set; } // AccountNumber. Unique number identifying the customer assigned by the accounting system.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; } // SalesOrderHeader.FK_SalesOrderHeader_Customer_CustomerID

        // Foreign keys
        public virtual SalesTerritory SalesTerritory { get; set; } // FK_Customer_SalesTerritory_TerritoryID
        public virtual Store Store { get; set; } // FK_Customer_Store_StoreID
        
        public Customer()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            SalesOrderHeaders = new List<SalesOrderHeader>();
        }
    }

    // PersonCreditCard
    public class PersonCreditCard
    {
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key). Business entity identification number. Foreign key to Person.BusinessEntityID.
        public int CreditCardId { get; set; } // CreditCardID (Primary key). Credit card identification number. Foreign key to CreditCard.CreditCardID.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual CreditCard CreditCard { get; set; } // FK_PersonCreditCard_CreditCard_CreditCardID
        
        public PersonCreditCard()
        {
            ModifiedDate = System.DateTime.Now;
        }
    }

    // SalesOrderDetail
    public class SalesOrderDetail
    {
        public int SalesOrderId { get; set; } // SalesOrderID (Primary key). Primary key. Foreign key to SalesOrderHeader.SalesOrderID.
        public int SalesOrderDetailId { get; internal set; } // SalesOrderDetailID (Primary key). Primary key. One incremental unique number per product sold.
        public string CarrierTrackingNumber { get; set; } // CarrierTrackingNumber. Shipment tracking number supplied by the shipper.
        public short OrderQty { get; set; } // OrderQty. Quantity ordered per product.
        public int ProductId { get; set; } // ProductID. Product sold to customer. Foreign key to Product.ProductID.
        public int SpecialOfferId { get; set; } // SpecialOfferID. Promotional code. Foreign key to SpecialOffer.SpecialOfferID.
        public decimal UnitPrice { get; set; } // UnitPrice. Selling price of a single product.
        public decimal UnitPriceDiscount { get; set; } // UnitPriceDiscount. Discount amount.
        public decimal LineTotal { get; internal set; } // LineTotal. Per product subtotal. Computed as UnitPrice * (1 - UnitPriceDiscount) * OrderQty.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual SalesOrderHeader SalesOrderHeader { get; set; } // FK_SalesOrderDetail_SalesOrderHeader_SalesOrderID
        
        public SalesOrderDetail()
        {
            UnitPriceDiscount = 0.0m;
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
        }
    }

    // SalesOrderHeader
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.12.3.0")]
    public class SalesOrderHeader
    {
        public int SalesOrderId { get; internal set; } // SalesOrderID (Primary key). Primary key.
        public byte RevisionNumber { get; set; } // RevisionNumber. Incremental number to track changes to the sales order over time.
        public DateTime OrderDate { get; set; } // OrderDate. Dates the sales order was created.
        public DateTime DueDate { get; set; } // DueDate. Date the order is due to the customer.
        public DateTime? ShipDate { get; set; } // ShipDate. Date the order was shipped to the customer.
        public byte Status { get; set; } // Status. Order current status. 1 = In process; 2 = Approved; 3 = Backordered; 4 = Rejected; 5 = Shipped; 6 = Cancelled
        public bool OnlineOrderFlag { get; set; } // OnlineOrderFlag. 0 = Order placed by sales person. 1 = Order placed online by customer.
        public string SalesOrderNumber { get; internal set; } // SalesOrderNumber. Unique sales order identification number.
        public string PurchaseOrderNumber { get; set; } // PurchaseOrderNumber. Customer purchase order number reference.
        public string AccountNumber { get; set; } // AccountNumber. Financial accounting number reference.
        public int CustomerId { get; set; } // CustomerID. Customer identification number. Foreign key to Customer.BusinessEntityID.
        public int? SalesPersonId { get; set; } // SalesPersonID. Sales person who created the sales order. Foreign key to SalesPerson.BusinessEntityID.
        public int? TerritoryId { get; set; } // TerritoryID. Territory in which the sale was made. Foreign key to SalesTerritory.SalesTerritoryID.
        public int BillToAddressId { get; set; } // BillToAddressID. Customer billing address. Foreign key to Address.AddressID.
        public int ShipToAddressId { get; set; } // ShipToAddressID. Customer shipping address. Foreign key to Address.AddressID.
        public int ShipMethodId { get; set; } // ShipMethodID. Shipping method. Foreign key to ShipMethod.ShipMethodID.
        public int? CreditCardId { get; set; } // CreditCardID. Credit card identification number. Foreign key to CreditCard.CreditCardID.
        public string CreditCardApprovalCode { get; set; } // CreditCardApprovalCode. Approval code provided by the credit card company.
        public int? CurrencyRateId { get; set; } // CurrencyRateID. Currency exchange rate used. Foreign key to CurrencyRate.CurrencyRateID.
        public decimal SubTotal { get; set; } // SubTotal. Sales subtotal. Computed as SUM(SalesOrderDetail.LineTotal)for the appropriate SalesOrderID.
        public decimal TaxAmt { get; set; } // TaxAmt. Tax amount.
        public decimal Freight { get; set; } // Freight. Shipping cost.
        public decimal TotalDue { get; internal set; } // TotalDue. Total due from customer. Computed as Subtotal + TaxAmt + Freight.
        public string Comment { get; set; } // Comment. Sales representative comments.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<SalesOrderDetail> SalesOrderDetails { get; set; } // Many to many mapping
        public virtual ICollection<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReasons { get; set; } // Many to many mapping

        // Foreign keys
        public virtual CreditCard CreditCard { get; set; } // FK_SalesOrderHeader_CreditCard_CreditCardID
        public virtual CurrencyRate CurrencyRate { get; set; } // FK_SalesOrderHeader_CurrencyRate_CurrencyRateID
        public virtual Customer Customer { get; set; } // FK_SalesOrderHeader_Customer_CustomerID
        public virtual SalesPerson SalesPerson { get; set; } // FK_SalesOrderHeader_SalesPerson_SalesPersonID
        public virtual SalesTerritory SalesTerritory { get; set; } // FK_SalesOrderHeader_SalesTerritory_TerritoryID
        
        public SalesOrderHeader()
        {
            RevisionNumber = 0;
            OrderDate = System.DateTime.Now;
            Status = 1;
            OnlineOrderFlag = true;
            SubTotal = 0.00m;
            TaxAmt = 0.00m;
            Freight = 0.00m;
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            SalesOrderDetails = new List<SalesOrderDetail>();
            SalesOrderHeaderSalesReasons = new List<SalesOrderHeaderSalesReason>();
        }
    }

    // SalesOrderHeaderSalesReason
    public class SalesOrderHeaderSalesReason
    {
        public int SalesOrderId { get; set; } // SalesOrderID (Primary key). Primary key. Foreign key to SalesOrderHeader.SalesOrderID.
        public int SalesReasonId { get; set; } // SalesReasonID (Primary key). Primary key. Foreign key to SalesReason.SalesReasonID.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual SalesOrderHeader SalesOrderHeader { get; set; } // FK_SalesOrderHeaderSalesReason_SalesOrderHeader_SalesOrderID
        public virtual SalesReason SalesReason { get; set; } // FK_SalesOrderHeaderSalesReason_SalesReason_SalesReasonID
        
        public SalesOrderHeaderSalesReason()
        {
            ModifiedDate = System.DateTime.Now;
        }
    }

    // SalesPerson
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.12.3.0")]
    public class SalesPerson
    {
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key). Primary key for SalesPerson records. Foreign key to Employee.BusinessEntityID
        public int? TerritoryId { get; set; } // TerritoryID. Territory currently assigned to. Foreign key to SalesTerritory.SalesTerritoryID.
        public decimal? SalesQuota { get; set; } // SalesQuota. Projected yearly sales.
        public decimal Bonus { get; set; } // Bonus. Bonus due if quota is met.
        public decimal CommissionPct { get; set; } // CommissionPct. Commision percent received per sale.
        public decimal SalesYtd { get; set; } // SalesYTD. Sales total year to date.
        public decimal SalesLastYear { get; set; } // SalesLastYear. Sales total of previous year.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; } // SalesOrderHeader.FK_SalesOrderHeader_SalesPerson_SalesPersonID
        public virtual ICollection<SalesPersonQuotaHistory> SalesPersonQuotaHistories { get; set; } // Many to many mapping
        public virtual ICollection<SalesTerritoryHistory> SalesTerritoryHistories { get; set; } // Many to many mapping
        public virtual ICollection<Store> Stores { get; set; } // Store.FK_Store_SalesPerson_SalesPersonID

        // Foreign keys
        public virtual SalesTerritory SalesTerritory { get; set; } // FK_SalesPerson_SalesTerritory_TerritoryID
        
        public SalesPerson()
        {
            Bonus = 0.00m;
            CommissionPct = 0.00m;
            SalesYtd = 0.00m;
            SalesLastYear = 0.00m;
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            SalesOrderHeaders = new List<SalesOrderHeader>();
            SalesPersonQuotaHistories = new List<SalesPersonQuotaHistory>();
            SalesTerritoryHistories = new List<SalesTerritoryHistory>();
            Stores = new List<Store>();
        }
    }

    // SalesPersonQuotaHistory
    public class SalesPersonQuotaHistory
    {
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key). Sales person identification number. Foreign key to SalesPerson.BusinessEntityID.
        public DateTime QuotaDate { get; set; } // QuotaDate (Primary key). Sales quota date.
        public decimal SalesQuota { get; set; } // SalesQuota. Sales quota amount.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual SalesPerson SalesPerson { get; set; } // FK_SalesPersonQuotaHistory_SalesPerson_BusinessEntityID
        
        public SalesPersonQuotaHistory()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
        }
    }

    // SalesReason
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.12.3.0")]
    public class SalesReason
    {
        public int SalesReasonId { get; internal set; } // SalesReasonID (Primary key). Primary key for SalesReason records.
        public string Name { get; set; } // Name. Sales reason description.
        public string ReasonType { get; set; } // ReasonType. Category the sales reason belongs to.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReasons { get; set; } // Many to many mapping
        
        public SalesReason()
        {
            ModifiedDate = System.DateTime.Now;
            SalesOrderHeaderSalesReasons = new List<SalesOrderHeaderSalesReason>();
        }
    }

    // SalesTaxRate
    public class SalesTaxRate
    {
        public int SalesTaxRateId { get; internal set; } // SalesTaxRateID (Primary key). Primary key for SalesTaxRate records.
        public int StateProvinceId { get; set; } // StateProvinceID. State, province, or country/region the sales tax applies to.
        public byte TaxType { get; set; } // TaxType. 1 = Tax applied to retail transactions, 2 = Tax applied to wholesale transactions, 3 = Tax applied to all sales (retail and wholesale) transactions.
        public decimal TaxRate { get; set; } // TaxRate. Tax rate amount.
        public string Name { get; set; } // Name. Tax rate description.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.
        
        public SalesTaxRate()
        {
            TaxRate = 0.00m;
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
        }
    }

    // SalesTerritory
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.12.3.0")]
    public class SalesTerritory
    {
        public int TerritoryId { get; internal set; } // TerritoryID (Primary key). Primary key for SalesTerritory records.
        public string Name { get; set; } // Name. Sales territory description
        public string CountryRegionCode { get; set; } // CountryRegionCode. ISO standard country or region code. Foreign key to CountryRegion.CountryRegionCode.
        public string Group { get; set; } // Group. Geographic area to which the sales territory belong.
        public decimal SalesYtd { get; set; } // SalesYTD. Sales in the territory year to date.
        public decimal SalesLastYear { get; set; } // SalesLastYear. Sales in the territory the previous year.
        public decimal CostYtd { get; set; } // CostYTD. Business costs in the territory year to date.
        public decimal CostLastYear { get; set; } // CostLastYear. Business costs in the territory the previous year.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<Customer> Customers { get; set; } // Customer.FK_Customer_SalesTerritory_TerritoryID
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; } // SalesOrderHeader.FK_SalesOrderHeader_SalesTerritory_TerritoryID
        public virtual ICollection<SalesPerson> SalesPersons { get; set; } // SalesPerson.FK_SalesPerson_SalesTerritory_TerritoryID
        public virtual ICollection<SalesTerritoryHistory> SalesTerritoryHistories { get; set; } // Many to many mapping
        
        public SalesTerritory()
        {
            SalesYtd = 0.00m;
            SalesLastYear = 0.00m;
            CostYtd = 0.00m;
            CostLastYear = 0.00m;
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            Customers = new List<Customer>();
            SalesOrderHeaders = new List<SalesOrderHeader>();
            SalesPersons = new List<SalesPerson>();
            SalesTerritoryHistories = new List<SalesTerritoryHistory>();
        }
    }

    // SalesTerritoryHistory
    public class SalesTerritoryHistory
    {
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key). Primary key. The sales rep.  Foreign key to SalesPerson.BusinessEntityID.
        public int TerritoryId { get; set; } // TerritoryID (Primary key). Primary key. Territory identification number. Foreign key to SalesTerritory.SalesTerritoryID.
        public DateTime StartDate { get; set; } // StartDate (Primary key). Primary key. Date the sales representive started work in the territory.
        public DateTime? EndDate { get; set; } // EndDate. Date the sales representative left work in the territory.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual SalesPerson SalesPerson { get; set; } // FK_SalesTerritoryHistory_SalesPerson_BusinessEntityID
        public virtual SalesTerritory SalesTerritory { get; set; } // FK_SalesTerritoryHistory_SalesTerritory_TerritoryID
        
        public SalesTerritoryHistory()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
        }
    }

    // ShoppingCartItem
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; internal set; } // ShoppingCartItemID (Primary key). Primary key for ShoppingCartItem records.
        public string ShoppingCartId { get; set; } // ShoppingCartID. Shopping cart identification number.
        public int Quantity { get; set; } // Quantity. Product quantity ordered.
        public int ProductId { get; set; } // ProductID. Product ordered. Foreign key to Product.ProductID.
        public DateTime DateCreated { get; set; } // DateCreated. Date the time the record was created.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.
        
        public ShoppingCartItem()
        {
            Quantity = 1;
            DateCreated = System.DateTime.Now;
            ModifiedDate = System.DateTime.Now;
        }
    }

    // SpecialOffer
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.12.3.0")]
    public class SpecialOffer
    {
        public int SpecialOfferId { get; internal set; } // SpecialOfferID (Primary key). Primary key for SpecialOffer records.
        public string Description { get; set; } // Description. Discount description.
        public decimal DiscountPct { get; set; } // DiscountPct. Discount precentage.
        public string Type { get; set; } // Type. Discount type category.
        public string Category { get; set; } // Category. Group the discount applies to such as Reseller or Customer.
        public DateTime StartDate { get; set; } // StartDate. Discount start date.
        public DateTime EndDate { get; set; } // EndDate. Discount end date.
        public int MinQty { get; set; } // MinQty. Minimum discount percent allowed.
        public int? MaxQty { get; set; } // MaxQty. Maximum discount percent allowed.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<SpecialOfferProduct> SpecialOfferProducts { get; set; } // Many to many mapping
        
        public SpecialOffer()
        {
            DiscountPct = 0.00m;
            MinQty = 0;
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            SpecialOfferProducts = new List<SpecialOfferProduct>();
        }
    }

    // SpecialOfferProduct
    public class SpecialOfferProduct
    {
        public int SpecialOfferId { get; set; } // SpecialOfferID (Primary key). Primary key for SpecialOfferProduct records.
        public int ProductId { get; set; } // ProductID (Primary key). Product identification number. Foreign key to Product.ProductID.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual SpecialOffer SpecialOffer { get; set; } // FK_SpecialOfferProduct_SpecialOffer_SpecialOfferID
        
        public SpecialOfferProduct()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
        }
    }

    // Store
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.12.3.0")]
    public class Store
    {
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key). Primary key. Foreign key to Customer.BusinessEntityID.
        public string Name { get; set; } // Name. Name of the store.
        public int? SalesPersonId { get; set; } // SalesPersonID. ID of the sales person assigned to the customer. Foreign key to SalesPerson.BusinessEntityID.
        public string Demographics { get; set; } // Demographics. Demographic informationg about the store such as the number of employees, annual sales and store type.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<Customer> Customers { get; set; } // Customer.FK_Customer_Store_StoreID

        // Foreign keys
        public virtual SalesPerson SalesPerson { get; set; } // FK_Store_SalesPerson_SalesPersonID
        
        public Store()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            Customers = new List<Customer>();
        }
    }

    // vIndividualCustomer
    public class VIndividualCustomer
    {
        public int BusinessEntityId { get; set; } // BusinessEntityID
        public string Title { get; set; } // Title
        public string FirstName { get; set; } // FirstName
        public string MiddleName { get; set; } // MiddleName
        public string LastName { get; set; } // LastName
        public string Suffix { get; set; } // Suffix
        public string PhoneNumber { get; set; } // PhoneNumber
        public string PhoneNumberType { get; set; } // PhoneNumberType
        public string EmailAddress { get; set; } // EmailAddress
        public int EmailPromotion { get; set; } // EmailPromotion
        public string AddressType { get; set; } // AddressType
        public string AddressLine1 { get; set; } // AddressLine1
        public string AddressLine2 { get; set; } // AddressLine2
        public string City { get; set; } // City
        public string StateProvinceName { get; set; } // StateProvinceName
        public string PostalCode { get; set; } // PostalCode
        public string CountryRegionName { get; set; } // CountryRegionName
        public string Demographics { get; set; } // Demographics
    }

    // vPersonDemographics
    public class VPersonDemographic
    {
        public int BusinessEntityId { get; set; } // BusinessEntityID
        public decimal? TotalPurchaseYtd { get; set; } // TotalPurchaseYTD
        public DateTime? DateFirstPurchase { get; set; } // DateFirstPurchase
        public DateTime? BirthDate { get; set; } // BirthDate
        public string MaritalStatus { get; set; } // MaritalStatus
        public string YearlyIncome { get; set; } // YearlyIncome
        public string Gender { get; set; } // Gender
        public int? TotalChildren { get; set; } // TotalChildren
        public int? NumberChildrenAtHome { get; set; } // NumberChildrenAtHome
        public string Education { get; set; } // Education
        public string Occupation { get; set; } // Occupation
        public bool? HomeOwnerFlag { get; set; } // HomeOwnerFlag
        public int? NumberCarsOwned { get; set; } // NumberCarsOwned
    }

    // vSalesPerson
    public class VSalesPerson
    {
        public int BusinessEntityId { get; set; } // BusinessEntityID
        public string Title { get; set; } // Title
        public string FirstName { get; set; } // FirstName
        public string MiddleName { get; set; } // MiddleName
        public string LastName { get; set; } // LastName
        public string Suffix { get; set; } // Suffix
        public string JobTitle { get; set; } // JobTitle
        public string PhoneNumber { get; set; } // PhoneNumber
        public string PhoneNumberType { get; set; } // PhoneNumberType
        public string EmailAddress { get; set; } // EmailAddress
        public int EmailPromotion { get; set; } // EmailPromotion
        public string AddressLine1 { get; set; } // AddressLine1
        public string AddressLine2 { get; set; } // AddressLine2
        public string City { get; set; } // City
        public string StateProvinceName { get; set; } // StateProvinceName
        public string PostalCode { get; set; } // PostalCode
        public string CountryRegionName { get; set; } // CountryRegionName
        public string TerritoryName { get; set; } // TerritoryName
        public string TerritoryGroup { get; set; } // TerritoryGroup
        public decimal? SalesQuota { get; set; } // SalesQuota
        public decimal SalesYtd { get; set; } // SalesYTD
        public decimal SalesLastYear { get; set; } // SalesLastYear
    }

    // vSalesPersonSalesByFiscalYears
    public class VSalesPersonSalesByFiscalYear
    {
        public int? SalesPersonId { get; set; } // SalesPersonID
        public string FullName { get; set; } // FullName
        public string JobTitle { get; set; } // JobTitle
        public string SalesTerritory { get; set; } // SalesTerritory
        public decimal? C2002 { get; set; } // 2002
        public decimal? C2003 { get; set; } // 2003
        public decimal? C2004 { get; set; } // 2004
    }

    // vStoreWithAddresses
    public class VStoreWithAddress
    {
        public int BusinessEntityId { get; set; } // BusinessEntityID
        public string Name { get; set; } // Name
        public string AddressType { get; set; } // AddressType
        public string AddressLine1 { get; set; } // AddressLine1
        public string AddressLine2 { get; set; } // AddressLine2
        public string City { get; set; } // City
        public string StateProvinceName { get; set; } // StateProvinceName
        public string PostalCode { get; set; } // PostalCode
        public string CountryRegionName { get; set; } // CountryRegionName
    }

    // vStoreWithContacts
    public class VStoreWithContact
    {
        public int BusinessEntityId { get; set; } // BusinessEntityID
        public string Name { get; set; } // Name
        public string ContactType { get; set; } // ContactType
        public string Title { get; set; } // Title
        public string FirstName { get; set; } // FirstName
        public string MiddleName { get; set; } // MiddleName
        public string LastName { get; set; } // LastName
        public string Suffix { get; set; } // Suffix
        public string PhoneNumber { get; set; } // PhoneNumber
        public string PhoneNumberType { get; set; } // PhoneNumberType
        public string EmailAddress { get; set; } // EmailAddress
        public int EmailPromotion { get; set; } // EmailPromotion
    }

    // vStoreWithDemographics
    public class VStoreWithDemographic
    {
        public int BusinessEntityId { get; set; } // BusinessEntityID
        public string Name { get; set; } // Name
        public decimal? AnnualSales { get; set; } // AnnualSales
        public decimal? AnnualRevenue { get; set; } // AnnualRevenue
        public string BankName { get; set; } // BankName
        public string BusinessType { get; set; } // BusinessType
        public int? YearOpened { get; set; } // YearOpened
        public string Specialty { get; set; } // Specialty
        public int? SquareFeet { get; set; } // SquareFeet
        public string Brands { get; set; } // Brands
        public string Internet { get; set; } // Internet
        public int? NumberEmployees { get; set; } // NumberEmployees
    }


    // ************************************************************************
    // POCO Configuration

    // CountryRegionCurrency
    internal class CountryRegionCurrencyConfiguration : EntityTypeConfiguration<CountryRegionCurrency>
    {
        public CountryRegionCurrencyConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".CountryRegionCurrency");
            HasKey(x => new { x.CountryRegionCode, x.CurrencyCode });

            Property(x => x.CountryRegionCode).HasColumnName("CountryRegionCode").IsRequired().HasMaxLength(3).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.CurrencyCode).HasColumnName("CurrencyCode").IsRequired().IsFixedLength().HasMaxLength(3).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Currency).WithMany(b => b.CountryRegionCurrencies).HasForeignKey(c => c.CurrencyCode); // FK_CountryRegionCurrency_Currency_CurrencyCode
        }
    }

    // CreditCard
    internal class CreditCardConfiguration : EntityTypeConfiguration<CreditCard>
    {
        public CreditCardConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".CreditCard");
            HasKey(x => x.CreditCardId);

            Property(x => x.CreditCardId).HasColumnName("CreditCardID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.CardType).HasColumnName("CardType").IsRequired().HasMaxLength(50);
            Property(x => x.CardNumber).HasColumnName("CardNumber").IsRequired().HasMaxLength(25);
            Property(x => x.ExpMonth).HasColumnName("ExpMonth").IsRequired();
            Property(x => x.ExpYear).HasColumnName("ExpYear").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

    // Currency
    internal class CurrencyConfiguration : EntityTypeConfiguration<Currency>
    {
        public CurrencyConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".Currency");
            HasKey(x => x.CurrencyCode);

            Property(x => x.CurrencyCode).HasColumnName("CurrencyCode").IsRequired().IsFixedLength().HasMaxLength(3).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

    // CurrencyRate
    internal class CurrencyRateConfiguration : EntityTypeConfiguration<CurrencyRate>
    {
        public CurrencyRateConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".CurrencyRate");
            HasKey(x => x.CurrencyRateId);

            Property(x => x.CurrencyRateId).HasColumnName("CurrencyRateID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.CurrencyRateDate).HasColumnName("CurrencyRateDate").IsRequired();
            Property(x => x.FromCurrencyCode).HasColumnName("FromCurrencyCode").IsRequired().IsFixedLength().HasMaxLength(3);
            Property(x => x.ToCurrencyCode).HasColumnName("ToCurrencyCode").IsRequired().IsFixedLength().HasMaxLength(3);
            Property(x => x.AverageRate).HasColumnName("AverageRate").IsRequired().HasPrecision(19,4);
            Property(x => x.EndOfDayRate).HasColumnName("EndOfDayRate").IsRequired().HasPrecision(19,4);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Currency_FromCurrencyCode).WithMany(b => b.CurrencyRates_FromCurrencyCode).HasForeignKey(c => c.FromCurrencyCode); // FK_CurrencyRate_Currency_FromCurrencyCode
            HasRequired(a => a.Currency_ToCurrencyCode).WithMany(b => b.CurrencyRates_ToCurrencyCode).HasForeignKey(c => c.ToCurrencyCode); // FK_CurrencyRate_Currency_ToCurrencyCode
        }
    }

    // Customer
    internal class CustomerConfiguration : EntityTypeConfiguration<Customer>
    {
        public CustomerConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".Customer");
            HasKey(x => x.CustomerId);

            Property(x => x.CustomerId).HasColumnName("CustomerID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.PersonId).HasColumnName("PersonID").IsOptional();
            Property(x => x.StoreId).HasColumnName("StoreID").IsOptional();
            Property(x => x.TerritoryId).HasColumnName("TerritoryID").IsOptional();
            Property(x => x.AccountNumber).HasColumnName("AccountNumber").IsRequired().IsUnicode(false).HasMaxLength(10).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasOptional(a => a.Store).WithMany(b => b.Customers).HasForeignKey(c => c.StoreId); // FK_Customer_Store_StoreID
            HasOptional(a => a.SalesTerritory).WithMany(b => b.Customers).HasForeignKey(c => c.TerritoryId); // FK_Customer_SalesTerritory_TerritoryID
        }
    }

    // PersonCreditCard
    internal class PersonCreditCardConfiguration : EntityTypeConfiguration<PersonCreditCard>
    {
        public PersonCreditCardConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".PersonCreditCard");
            HasKey(x => new { x.BusinessEntityId, x.CreditCardId });

            Property(x => x.BusinessEntityId).HasColumnName("BusinessEntityID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.CreditCardId).HasColumnName("CreditCardID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.CreditCard).WithMany(b => b.PersonCreditCards).HasForeignKey(c => c.CreditCardId); // FK_PersonCreditCard_CreditCard_CreditCardID
        }
    }

    // SalesOrderDetail
    internal class SalesOrderDetailConfiguration : EntityTypeConfiguration<SalesOrderDetail>
    {
        public SalesOrderDetailConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".SalesOrderDetail");
            HasKey(x => new { x.SalesOrderId, x.SalesOrderDetailId });

            Property(x => x.SalesOrderId).HasColumnName("SalesOrderID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.SalesOrderDetailId).HasColumnName("SalesOrderDetailID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.CarrierTrackingNumber).HasColumnName("CarrierTrackingNumber").IsOptional().HasMaxLength(25);
            Property(x => x.OrderQty).HasColumnName("OrderQty").IsRequired();
            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired();
            Property(x => x.SpecialOfferId).HasColumnName("SpecialOfferID").IsRequired();
            Property(x => x.UnitPrice).HasColumnName("UnitPrice").IsRequired().HasPrecision(19,4);
            Property(x => x.UnitPriceDiscount).HasColumnName("UnitPriceDiscount").IsRequired().HasPrecision(19,4);
            Property(x => x.LineTotal).HasColumnName("LineTotal").IsRequired().HasPrecision(38,6).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.SalesOrderHeader).WithMany(b => b.SalesOrderDetails).HasForeignKey(c => c.SalesOrderId); // FK_SalesOrderDetail_SalesOrderHeader_SalesOrderID
        }
    }

    // SalesOrderHeader
    internal class SalesOrderHeaderConfiguration : EntityTypeConfiguration<SalesOrderHeader>
    {
        public SalesOrderHeaderConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".SalesOrderHeader");
            HasKey(x => x.SalesOrderId);

            Property(x => x.SalesOrderId).HasColumnName("SalesOrderID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.RevisionNumber).HasColumnName("RevisionNumber").IsRequired();
            Property(x => x.OrderDate).HasColumnName("OrderDate").IsRequired();
            Property(x => x.DueDate).HasColumnName("DueDate").IsRequired();
            Property(x => x.ShipDate).HasColumnName("ShipDate").IsOptional();
            Property(x => x.Status).HasColumnName("Status").IsRequired();
            Property(x => x.OnlineOrderFlag).HasColumnName("OnlineOrderFlag").IsRequired();
            Property(x => x.SalesOrderNumber).HasColumnName("SalesOrderNumber").IsRequired().HasMaxLength(25).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(x => x.PurchaseOrderNumber).HasColumnName("PurchaseOrderNumber").IsOptional().HasMaxLength(25);
            Property(x => x.AccountNumber).HasColumnName("AccountNumber").IsOptional().HasMaxLength(15);
            Property(x => x.CustomerId).HasColumnName("CustomerID").IsRequired();
            Property(x => x.SalesPersonId).HasColumnName("SalesPersonID").IsOptional();
            Property(x => x.TerritoryId).HasColumnName("TerritoryID").IsOptional();
            Property(x => x.BillToAddressId).HasColumnName("BillToAddressID").IsRequired();
            Property(x => x.ShipToAddressId).HasColumnName("ShipToAddressID").IsRequired();
            Property(x => x.ShipMethodId).HasColumnName("ShipMethodID").IsRequired();
            Property(x => x.CreditCardId).HasColumnName("CreditCardID").IsOptional();
            Property(x => x.CreditCardApprovalCode).HasColumnName("CreditCardApprovalCode").IsOptional().IsUnicode(false).HasMaxLength(15);
            Property(x => x.CurrencyRateId).HasColumnName("CurrencyRateID").IsOptional();
            Property(x => x.SubTotal).HasColumnName("SubTotal").IsRequired().HasPrecision(19,4);
            Property(x => x.TaxAmt).HasColumnName("TaxAmt").IsRequired().HasPrecision(19,4);
            Property(x => x.Freight).HasColumnName("Freight").IsRequired().HasPrecision(19,4);
            Property(x => x.TotalDue).HasColumnName("TotalDue").IsRequired().HasPrecision(19,4).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(x => x.Comment).HasColumnName("Comment").IsOptional().HasMaxLength(128);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Customer).WithMany(b => b.SalesOrderHeaders).HasForeignKey(c => c.CustomerId); // FK_SalesOrderHeader_Customer_CustomerID
            HasOptional(a => a.SalesPerson).WithMany(b => b.SalesOrderHeaders).HasForeignKey(c => c.SalesPersonId); // FK_SalesOrderHeader_SalesPerson_SalesPersonID
            HasOptional(a => a.SalesTerritory).WithMany(b => b.SalesOrderHeaders).HasForeignKey(c => c.TerritoryId); // FK_SalesOrderHeader_SalesTerritory_TerritoryID
            HasOptional(a => a.CreditCard).WithMany(b => b.SalesOrderHeaders).HasForeignKey(c => c.CreditCardId); // FK_SalesOrderHeader_CreditCard_CreditCardID
            HasOptional(a => a.CurrencyRate).WithMany(b => b.SalesOrderHeaders).HasForeignKey(c => c.CurrencyRateId); // FK_SalesOrderHeader_CurrencyRate_CurrencyRateID
        }
    }

    // SalesOrderHeaderSalesReason
    internal class SalesOrderHeaderSalesReasonConfiguration : EntityTypeConfiguration<SalesOrderHeaderSalesReason>
    {
        public SalesOrderHeaderSalesReasonConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".SalesOrderHeaderSalesReason");
            HasKey(x => new { x.SalesOrderId, x.SalesReasonId });

            Property(x => x.SalesOrderId).HasColumnName("SalesOrderID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.SalesReasonId).HasColumnName("SalesReasonID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.SalesOrderHeader).WithMany(b => b.SalesOrderHeaderSalesReasons).HasForeignKey(c => c.SalesOrderId); // FK_SalesOrderHeaderSalesReason_SalesOrderHeader_SalesOrderID
            HasRequired(a => a.SalesReason).WithMany(b => b.SalesOrderHeaderSalesReasons).HasForeignKey(c => c.SalesReasonId); // FK_SalesOrderHeaderSalesReason_SalesReason_SalesReasonID
        }
    }

    // SalesPerson
    internal class SalesPersonConfiguration : EntityTypeConfiguration<SalesPerson>
    {
        public SalesPersonConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".SalesPerson");
            HasKey(x => x.BusinessEntityId);

            Property(x => x.BusinessEntityId).HasColumnName("BusinessEntityID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.TerritoryId).HasColumnName("TerritoryID").IsOptional();
            Property(x => x.SalesQuota).HasColumnName("SalesQuota").IsOptional().HasPrecision(19,4);
            Property(x => x.Bonus).HasColumnName("Bonus").IsRequired().HasPrecision(19,4);
            Property(x => x.CommissionPct).HasColumnName("CommissionPct").IsRequired().HasPrecision(10,4);
            Property(x => x.SalesYtd).HasColumnName("SalesYTD").IsRequired().HasPrecision(19,4);
            Property(x => x.SalesLastYear).HasColumnName("SalesLastYear").IsRequired().HasPrecision(19,4);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasOptional(a => a.SalesTerritory).WithMany(b => b.SalesPersons).HasForeignKey(c => c.TerritoryId); // FK_SalesPerson_SalesTerritory_TerritoryID
        }
    }

    // SalesPersonQuotaHistory
    internal class SalesPersonQuotaHistoryConfiguration : EntityTypeConfiguration<SalesPersonQuotaHistory>
    {
        public SalesPersonQuotaHistoryConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".SalesPersonQuotaHistory");
            HasKey(x => new { x.BusinessEntityId, x.QuotaDate });

            Property(x => x.BusinessEntityId).HasColumnName("BusinessEntityID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.QuotaDate).HasColumnName("QuotaDate").IsRequired();
            Property(x => x.SalesQuota).HasColumnName("SalesQuota").IsRequired().HasPrecision(19,4);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.SalesPerson).WithMany(b => b.SalesPersonQuotaHistories).HasForeignKey(c => c.BusinessEntityId); // FK_SalesPersonQuotaHistory_SalesPerson_BusinessEntityID
        }
    }

    // SalesReason
    internal class SalesReasonConfiguration : EntityTypeConfiguration<SalesReason>
    {
        public SalesReasonConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".SalesReason");
            HasKey(x => x.SalesReasonId);

            Property(x => x.SalesReasonId).HasColumnName("SalesReasonID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.ReasonType).HasColumnName("ReasonType").IsRequired().HasMaxLength(50);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

    // SalesTaxRate
    internal class SalesTaxRateConfiguration : EntityTypeConfiguration<SalesTaxRate>
    {
        public SalesTaxRateConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".SalesTaxRate");
            HasKey(x => x.SalesTaxRateId);

            Property(x => x.SalesTaxRateId).HasColumnName("SalesTaxRateID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.StateProvinceId).HasColumnName("StateProvinceID").IsRequired();
            Property(x => x.TaxType).HasColumnName("TaxType").IsRequired();
            Property(x => x.TaxRate).HasColumnName("TaxRate").IsRequired().HasPrecision(10,4);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

    // SalesTerritory
    internal class SalesTerritoryConfiguration : EntityTypeConfiguration<SalesTerritory>
    {
        public SalesTerritoryConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".SalesTerritory");
            HasKey(x => x.TerritoryId);

            Property(x => x.TerritoryId).HasColumnName("TerritoryID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.CountryRegionCode).HasColumnName("CountryRegionCode").IsRequired().HasMaxLength(3);
            Property(x => x.Group).HasColumnName("Group").IsRequired().HasMaxLength(50);
            Property(x => x.SalesYtd).HasColumnName("SalesYTD").IsRequired().HasPrecision(19,4);
            Property(x => x.SalesLastYear).HasColumnName("SalesLastYear").IsRequired().HasPrecision(19,4);
            Property(x => x.CostYtd).HasColumnName("CostYTD").IsRequired().HasPrecision(19,4);
            Property(x => x.CostLastYear).HasColumnName("CostLastYear").IsRequired().HasPrecision(19,4);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

    // SalesTerritoryHistory
    internal class SalesTerritoryHistoryConfiguration : EntityTypeConfiguration<SalesTerritoryHistory>
    {
        public SalesTerritoryHistoryConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".SalesTerritoryHistory");
            HasKey(x => new { x.BusinessEntityId, x.TerritoryId, x.StartDate });

            Property(x => x.BusinessEntityId).HasColumnName("BusinessEntityID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.TerritoryId).HasColumnName("TerritoryID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.StartDate).HasColumnName("StartDate").IsRequired();
            Property(x => x.EndDate).HasColumnName("EndDate").IsOptional();
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.SalesPerson).WithMany(b => b.SalesTerritoryHistories).HasForeignKey(c => c.BusinessEntityId); // FK_SalesTerritoryHistory_SalesPerson_BusinessEntityID
            HasRequired(a => a.SalesTerritory).WithMany(b => b.SalesTerritoryHistories).HasForeignKey(c => c.TerritoryId); // FK_SalesTerritoryHistory_SalesTerritory_TerritoryID
        }
    }

    // ShoppingCartItem
    internal class ShoppingCartItemConfiguration : EntityTypeConfiguration<ShoppingCartItem>
    {
        public ShoppingCartItemConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".ShoppingCartItem");
            HasKey(x => x.ShoppingCartItemId);

            Property(x => x.ShoppingCartItemId).HasColumnName("ShoppingCartItemID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ShoppingCartId).HasColumnName("ShoppingCartID").IsRequired().HasMaxLength(50);
            Property(x => x.Quantity).HasColumnName("Quantity").IsRequired();
            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired();
            Property(x => x.DateCreated).HasColumnName("DateCreated").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

    // SpecialOffer
    internal class SpecialOfferConfiguration : EntityTypeConfiguration<SpecialOffer>
    {
        public SpecialOfferConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".SpecialOffer");
            HasKey(x => x.SpecialOfferId);

            Property(x => x.SpecialOfferId).HasColumnName("SpecialOfferID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Description).HasColumnName("Description").IsRequired().HasMaxLength(255);
            Property(x => x.DiscountPct).HasColumnName("DiscountPct").IsRequired().HasPrecision(10,4);
            Property(x => x.Type).HasColumnName("Type").IsRequired().HasMaxLength(50);
            Property(x => x.Category).HasColumnName("Category").IsRequired().HasMaxLength(50);
            Property(x => x.StartDate).HasColumnName("StartDate").IsRequired();
            Property(x => x.EndDate).HasColumnName("EndDate").IsRequired();
            Property(x => x.MinQty).HasColumnName("MinQty").IsRequired();
            Property(x => x.MaxQty).HasColumnName("MaxQty").IsOptional();
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

    // SpecialOfferProduct
    internal class SpecialOfferProductConfiguration : EntityTypeConfiguration<SpecialOfferProduct>
    {
        public SpecialOfferProductConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".SpecialOfferProduct");
            HasKey(x => new { x.SpecialOfferId, x.ProductId });

            Property(x => x.SpecialOfferId).HasColumnName("SpecialOfferID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.SpecialOffer).WithMany(b => b.SpecialOfferProducts).HasForeignKey(c => c.SpecialOfferId); // FK_SpecialOfferProduct_SpecialOffer_SpecialOfferID
        }
    }

    // Store
    internal class StoreConfiguration : EntityTypeConfiguration<Store>
    {
        public StoreConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".Store");
            HasKey(x => x.BusinessEntityId);

            Property(x => x.BusinessEntityId).HasColumnName("BusinessEntityID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.SalesPersonId).HasColumnName("SalesPersonID").IsOptional();
            Property(x => x.Demographics).HasColumnName("Demographics").IsOptional();
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasOptional(a => a.SalesPerson).WithMany(b => b.Stores).HasForeignKey(c => c.SalesPersonId); // FK_Store_SalesPerson_SalesPersonID
        }
    }

    // vIndividualCustomer
    internal class VIndividualCustomerConfiguration : EntityTypeConfiguration<VIndividualCustomer>
    {
        public VIndividualCustomerConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".vIndividualCustomer");
            HasKey(x => new { x.BusinessEntityId, x.FirstName, x.LastName, x.EmailPromotion, x.AddressType, x.AddressLine1, x.City, x.StateProvinceName, x.PostalCode, x.CountryRegionName });

            Property(x => x.BusinessEntityId).HasColumnName("BusinessEntityID").IsRequired();
            Property(x => x.Title).HasColumnName("Title").IsOptional().HasMaxLength(8);
            Property(x => x.FirstName).HasColumnName("FirstName").IsRequired().HasMaxLength(50);
            Property(x => x.MiddleName).HasColumnName("MiddleName").IsOptional().HasMaxLength(50);
            Property(x => x.LastName).HasColumnName("LastName").IsRequired().HasMaxLength(50);
            Property(x => x.Suffix).HasColumnName("Suffix").IsOptional().HasMaxLength(10);
            Property(x => x.PhoneNumber).HasColumnName("PhoneNumber").IsOptional().HasMaxLength(25);
            Property(x => x.PhoneNumberType).HasColumnName("PhoneNumberType").IsOptional().HasMaxLength(50);
            Property(x => x.EmailAddress).HasColumnName("EmailAddress").IsOptional().HasMaxLength(50);
            Property(x => x.EmailPromotion).HasColumnName("EmailPromotion").IsRequired();
            Property(x => x.AddressType).HasColumnName("AddressType").IsRequired().HasMaxLength(50);
            Property(x => x.AddressLine1).HasColumnName("AddressLine1").IsRequired().HasMaxLength(60);
            Property(x => x.AddressLine2).HasColumnName("AddressLine2").IsOptional().HasMaxLength(60);
            Property(x => x.City).HasColumnName("City").IsRequired().HasMaxLength(30);
            Property(x => x.StateProvinceName).HasColumnName("StateProvinceName").IsRequired().HasMaxLength(50);
            Property(x => x.PostalCode).HasColumnName("PostalCode").IsRequired().HasMaxLength(15);
            Property(x => x.CountryRegionName).HasColumnName("CountryRegionName").IsRequired().HasMaxLength(50);
            Property(x => x.Demographics).HasColumnName("Demographics").IsOptional();
        }
    }

    // vPersonDemographics
    internal class VPersonDemographicConfiguration : EntityTypeConfiguration<VPersonDemographic>
    {
        public VPersonDemographicConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".vPersonDemographics");
            HasKey(x => x.BusinessEntityId);

            Property(x => x.BusinessEntityId).HasColumnName("BusinessEntityID").IsRequired();
            Property(x => x.TotalPurchaseYtd).HasColumnName("TotalPurchaseYTD").IsOptional().HasPrecision(19,4);
            Property(x => x.DateFirstPurchase).HasColumnName("DateFirstPurchase").IsOptional();
            Property(x => x.BirthDate).HasColumnName("BirthDate").IsOptional();
            Property(x => x.MaritalStatus).HasColumnName("MaritalStatus").IsOptional().HasMaxLength(1);
            Property(x => x.YearlyIncome).HasColumnName("YearlyIncome").IsOptional().HasMaxLength(30);
            Property(x => x.Gender).HasColumnName("Gender").IsOptional().HasMaxLength(1);
            Property(x => x.TotalChildren).HasColumnName("TotalChildren").IsOptional();
            Property(x => x.NumberChildrenAtHome).HasColumnName("NumberChildrenAtHome").IsOptional();
            Property(x => x.Education).HasColumnName("Education").IsOptional().HasMaxLength(30);
            Property(x => x.Occupation).HasColumnName("Occupation").IsOptional().HasMaxLength(30);
            Property(x => x.HomeOwnerFlag).HasColumnName("HomeOwnerFlag").IsOptional();
            Property(x => x.NumberCarsOwned).HasColumnName("NumberCarsOwned").IsOptional();
        }
    }

    // vSalesPerson
    internal class VSalesPersonConfiguration : EntityTypeConfiguration<VSalesPerson>
    {
        public VSalesPersonConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".vSalesPerson");
            HasKey(x => new { x.BusinessEntityId, x.FirstName, x.LastName, x.JobTitle, x.EmailPromotion, x.AddressLine1, x.City, x.StateProvinceName, x.PostalCode, x.CountryRegionName, x.SalesYtd, x.SalesLastYear });

            Property(x => x.BusinessEntityId).HasColumnName("BusinessEntityID").IsRequired();
            Property(x => x.Title).HasColumnName("Title").IsOptional().HasMaxLength(8);
            Property(x => x.FirstName).HasColumnName("FirstName").IsRequired().HasMaxLength(50);
            Property(x => x.MiddleName).HasColumnName("MiddleName").IsOptional().HasMaxLength(50);
            Property(x => x.LastName).HasColumnName("LastName").IsRequired().HasMaxLength(50);
            Property(x => x.Suffix).HasColumnName("Suffix").IsOptional().HasMaxLength(10);
            Property(x => x.JobTitle).HasColumnName("JobTitle").IsRequired().HasMaxLength(50);
            Property(x => x.PhoneNumber).HasColumnName("PhoneNumber").IsOptional().HasMaxLength(25);
            Property(x => x.PhoneNumberType).HasColumnName("PhoneNumberType").IsOptional().HasMaxLength(50);
            Property(x => x.EmailAddress).HasColumnName("EmailAddress").IsOptional().HasMaxLength(50);
            Property(x => x.EmailPromotion).HasColumnName("EmailPromotion").IsRequired();
            Property(x => x.AddressLine1).HasColumnName("AddressLine1").IsRequired().HasMaxLength(60);
            Property(x => x.AddressLine2).HasColumnName("AddressLine2").IsOptional().HasMaxLength(60);
            Property(x => x.City).HasColumnName("City").IsRequired().HasMaxLength(30);
            Property(x => x.StateProvinceName).HasColumnName("StateProvinceName").IsRequired().HasMaxLength(50);
            Property(x => x.PostalCode).HasColumnName("PostalCode").IsRequired().HasMaxLength(15);
            Property(x => x.CountryRegionName).HasColumnName("CountryRegionName").IsRequired().HasMaxLength(50);
            Property(x => x.TerritoryName).HasColumnName("TerritoryName").IsOptional().HasMaxLength(50);
            Property(x => x.TerritoryGroup).HasColumnName("TerritoryGroup").IsOptional().HasMaxLength(50);
            Property(x => x.SalesQuota).HasColumnName("SalesQuota").IsOptional().HasPrecision(19,4);
            Property(x => x.SalesYtd).HasColumnName("SalesYTD").IsRequired().HasPrecision(19,4);
            Property(x => x.SalesLastYear).HasColumnName("SalesLastYear").IsRequired().HasPrecision(19,4);
        }
    }

    // vSalesPersonSalesByFiscalYears
    internal class VSalesPersonSalesByFiscalYearConfiguration : EntityTypeConfiguration<VSalesPersonSalesByFiscalYear>
    {
        public VSalesPersonSalesByFiscalYearConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".vSalesPersonSalesByFiscalYears");
            HasKey(x => new { x.JobTitle, x.SalesTerritory });

            Property(x => x.SalesPersonId).HasColumnName("SalesPersonID").IsOptional();
            Property(x => x.FullName).HasColumnName("FullName").IsOptional().HasMaxLength(152);
            Property(x => x.JobTitle).HasColumnName("JobTitle").IsRequired().HasMaxLength(50);
            Property(x => x.SalesTerritory).HasColumnName("SalesTerritory").IsRequired().HasMaxLength(50);
            Property(x => x.C2002).HasColumnName("2002").IsOptional().HasPrecision(19,4);
            Property(x => x.C2003).HasColumnName("2003").IsOptional().HasPrecision(19,4);
            Property(x => x.C2004).HasColumnName("2004").IsOptional().HasPrecision(19,4);
        }
    }

    // vStoreWithAddresses
    internal class VStoreWithAddressConfiguration : EntityTypeConfiguration<VStoreWithAddress>
    {
        public VStoreWithAddressConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".vStoreWithAddresses");
            HasKey(x => new { x.BusinessEntityId, x.Name, x.AddressType, x.AddressLine1, x.City, x.StateProvinceName, x.PostalCode, x.CountryRegionName });

            Property(x => x.BusinessEntityId).HasColumnName("BusinessEntityID").IsRequired();
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.AddressType).HasColumnName("AddressType").IsRequired().HasMaxLength(50);
            Property(x => x.AddressLine1).HasColumnName("AddressLine1").IsRequired().HasMaxLength(60);
            Property(x => x.AddressLine2).HasColumnName("AddressLine2").IsOptional().HasMaxLength(60);
            Property(x => x.City).HasColumnName("City").IsRequired().HasMaxLength(30);
            Property(x => x.StateProvinceName).HasColumnName("StateProvinceName").IsRequired().HasMaxLength(50);
            Property(x => x.PostalCode).HasColumnName("PostalCode").IsRequired().HasMaxLength(15);
            Property(x => x.CountryRegionName).HasColumnName("CountryRegionName").IsRequired().HasMaxLength(50);
        }
    }

    // vStoreWithContacts
    internal class VStoreWithContactConfiguration : EntityTypeConfiguration<VStoreWithContact>
    {
        public VStoreWithContactConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".vStoreWithContacts");
            HasKey(x => new { x.BusinessEntityId, x.Name, x.ContactType, x.FirstName, x.LastName, x.EmailPromotion });

            Property(x => x.BusinessEntityId).HasColumnName("BusinessEntityID").IsRequired();
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.ContactType).HasColumnName("ContactType").IsRequired().HasMaxLength(50);
            Property(x => x.Title).HasColumnName("Title").IsOptional().HasMaxLength(8);
            Property(x => x.FirstName).HasColumnName("FirstName").IsRequired().HasMaxLength(50);
            Property(x => x.MiddleName).HasColumnName("MiddleName").IsOptional().HasMaxLength(50);
            Property(x => x.LastName).HasColumnName("LastName").IsRequired().HasMaxLength(50);
            Property(x => x.Suffix).HasColumnName("Suffix").IsOptional().HasMaxLength(10);
            Property(x => x.PhoneNumber).HasColumnName("PhoneNumber").IsOptional().HasMaxLength(25);
            Property(x => x.PhoneNumberType).HasColumnName("PhoneNumberType").IsOptional().HasMaxLength(50);
            Property(x => x.EmailAddress).HasColumnName("EmailAddress").IsOptional().HasMaxLength(50);
            Property(x => x.EmailPromotion).HasColumnName("EmailPromotion").IsRequired();
        }
    }

    // vStoreWithDemographics
    internal class VStoreWithDemographicConfiguration : EntityTypeConfiguration<VStoreWithDemographic>
    {
        public VStoreWithDemographicConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".vStoreWithDemographics");
            HasKey(x => new { x.BusinessEntityId, x.Name });

            Property(x => x.BusinessEntityId).HasColumnName("BusinessEntityID").IsRequired();
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.AnnualSales).HasColumnName("AnnualSales").IsOptional().HasPrecision(19,4);
            Property(x => x.AnnualRevenue).HasColumnName("AnnualRevenue").IsOptional().HasPrecision(19,4);
            Property(x => x.BankName).HasColumnName("BankName").IsOptional().HasMaxLength(50);
            Property(x => x.BusinessType).HasColumnName("BusinessType").IsOptional().HasMaxLength(5);
            Property(x => x.YearOpened).HasColumnName("YearOpened").IsOptional();
            Property(x => x.Specialty).HasColumnName("Specialty").IsOptional().HasMaxLength(50);
            Property(x => x.SquareFeet).HasColumnName("SquareFeet").IsOptional();
            Property(x => x.Brands).HasColumnName("Brands").IsOptional().HasMaxLength(30);
            Property(x => x.Internet).HasColumnName("Internet").IsOptional().HasMaxLength(30);
            Property(x => x.NumberEmployees).HasColumnName("NumberEmployees").IsOptional();
        }
    }

}

