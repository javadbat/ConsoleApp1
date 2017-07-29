namespace ConsoleApp2.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EFModel : DbContext
    {
        public EFModel()
            : base("name=EFModel")
        {
        }

        public virtual DbSet<Basket> Baskets { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Dictionary> Dictionaries { get; set; }
        public virtual DbSet<ExchangeAgahi> ExchangeAgahis { get; set; }
        public virtual DbSet<ExchangeAgahiAdminStatu> ExchangeAgahiAdminStatus { get; set; }
        public virtual DbSet<ExchangeAgahiAudit> ExchangeAgahiAudits { get; set; }
        public virtual DbSet<ExchangeAgahiBook> ExchangeAgahiBooks { get; set; }
        public virtual DbSet<ExchangeAgahiType> ExchangeAgahiTypes { get; set; }
        public virtual DbSet<ExchangeAgahiUserStatu> ExchangeAgahiUserStatus { get; set; }
        public virtual DbSet<ExchangeBookState> ExchangeBookStates { get; set; }
        public virtual DbSet<ExchangeCategory> ExchangeCategories { get; set; }
        public virtual DbSet<ExchangePayment> ExchangePayments { get; set; }
        public virtual DbSet<Grade> Grades { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<InvoiceAudit> InvoiceAudits { get; set; }
        public virtual DbSet<InvoiceDiscountAudit> InvoiceDiscountAudits { get; set; }
        public virtual DbSet<InvoiceItem> InvoiceItems { get; set; }
        public virtual DbSet<InvoicePaymentMethod> InvoicePaymentMethods { get; set; }
        public virtual DbSet<InvoiceSendMethod> InvoiceSendMethods { get; set; }
        public virtual DbSet<InvoiceStatu> InvoiceStatus { get; set; }
        public virtual DbSet<Module> Modules { get; set; }
        public virtual DbSet<ModuleAccess> ModuleAccesses { get; set; }
        public virtual DbSet<ModuleGetaway> ModuleGetaways { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<PaymentBank> PaymentBanks { get; set; }
        public virtual DbSet<PaymentGetaway> PaymentGetaways { get; set; }
        public virtual DbSet<PaymentHekmatBank> PaymentHekmatBanks { get; set; }
        public virtual DbSet<PaymentMellatBank> PaymentMellatBanks { get; set; }
        public virtual DbSet<PaymentPasargadBank> PaymentPasargadBanks { get; set; }
        public virtual DbSet<PaymentSamanBank> PaymentSamanBanks { get; set; }
        public virtual DbSet<PaymentStatu> PaymentStatus { get; set; }
        public virtual DbSet<Permission> Permissions { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<Token> Tokens { get; set; }
        public virtual DbSet<Tree> Trees { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserAddress> UserAddresses { get; set; }
        public virtual DbSet<UserGroup> UserGroups { get; set; }
        public virtual DbSet<UserProfile> UserProfiles { get; set; }
        public virtual DbSet<Flag> Flags { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>()
                .HasMany(e => e.ExchangeAgahis)
                .WithRequired(e => e.City)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<City>()
                .HasMany(e => e.Invoices)
                .WithRequired(e => e.City)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<City>()
                .HasMany(e => e.UserAddresses)
                .WithRequired(e => e.City)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ExchangeAgahi>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ExchangeAgahi>()
                .Property(e => e.CoverPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ExchangeAgahi>()
                .HasMany(e => e.Baskets)
                .WithRequired(e => e.ExchangeAgahi)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ExchangeAgahi>()
                .HasMany(e => e.InvoiceItems)
                .WithRequired(e => e.ExchangeAgahi)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ExchangeAgahi>()
                .HasMany(e => e.ExchangeCategories)
                .WithMany(e => e.ExchangeAgahis)
                .Map(m => m.ToTable("ExchangeCategoryAgahi").MapLeftKey("AgahiId").MapRightKey("CategoryId"));

            modelBuilder.Entity<ExchangeAgahiAdminStatu>()
                .HasMany(e => e.ExchangeAgahis)
                .WithRequired(e => e.ExchangeAgahiAdminStatu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ExchangeAgahiAudit>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ExchangeAgahiAudit>()
                .Property(e => e.CoverPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ExchangeAgahiType>()
                .HasMany(e => e.ExchangeAgahis)
                .WithRequired(e => e.ExchangeAgahiType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ExchangeAgahiUserStatu>()
                .HasMany(e => e.ExchangeAgahis)
                .WithRequired(e => e.ExchangeAgahiUserStatu)
                .HasForeignKey(e => e.UserStatusId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ExchangeBookState>()
                .HasMany(e => e.ExchangeAgahiBooks)
                .WithRequired(e => e.ExchangeBookState)
                .HasForeignKey(e => e.BookStateId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ExchangeCategory>()
                .HasMany(e => e.ExchangeCategory1)
                .WithOptional(e => e.ExchangeCategory2)
                .HasForeignKey(e => e.ParentId);

            modelBuilder.Entity<ExchangePayment>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Grade>()
                .HasMany(e => e.Grade1)
                .WithOptional(e => e.Grade2)
                .HasForeignKey(e => e.ParentId);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.DiscountPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.TotalPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.SendPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.CreditPolicyPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Invoice>()
                .HasMany(e => e.ExchangePayments)
                .WithRequired(e => e.Invoice)
                .HasForeignKey(e => e.InvoiceId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Invoice>()
                .HasMany(e => e.InvoiceAudits)
                .WithRequired(e => e.Invoice)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Invoice>()
                .HasMany(e => e.InvoiceDiscountAudits)
                .WithRequired(e => e.Invoice)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Invoice>()
                .HasMany(e => e.ExchangePayments1)
                .WithMany(e => e.Invoices)
                .Map(m => m.ToTable("InvoicePayment").MapLeftKey("InvoiceId").MapRightKey("PaymentId"));

            modelBuilder.Entity<InvoiceAudit>()
                .Property(e => e.OldAddress)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceAudit>()
                .Property(e => e.NewAddress)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceDiscountAudit>()
                .Property(e => e.Code)
                .IsFixedLength();

            modelBuilder.Entity<InvoiceDiscountAudit>()
                .Property(e => e.DiscountPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<InvoiceDiscountAudit>()
                .Property(e => e.OrganizeTitle)
                .IsFixedLength();

            modelBuilder.Entity<InvoiceItem>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<InvoiceItem>()
                .Property(e => e.CoverPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<InvoicePaymentMethod>()
                .HasMany(e => e.Invoices)
                .WithRequired(e => e.InvoicePaymentMethod)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<InvoiceSendMethod>()
                .HasMany(e => e.Invoices)
                .WithRequired(e => e.InvoiceSendMethod)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<InvoiceStatu>()
                .HasMany(e => e.Invoices)
                .WithRequired(e => e.InvoiceStatu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Module>()
                .HasMany(e => e.ModuleGetaways)
                .WithRequired(e => e.Module)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Module>()
                .HasMany(e => e.Payments)
                .WithRequired(e => e.Module)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Payment>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Payment>()
                .Property(e => e.IP)
                .IsUnicode(false);

            modelBuilder.Entity<Payment>()
                .HasOptional(e => e.PaymentPasargadBank)
                .WithRequired(e => e.Payment);

            modelBuilder.Entity<Payment>()
                .HasOptional(e => e.PaymentHekmatBank)
                .WithRequired(e => e.Payment);

            modelBuilder.Entity<Payment>()
                .HasOptional(e => e.PaymentMellatBank)
                .WithRequired(e => e.Payment);

            modelBuilder.Entity<Payment>()
                .HasOptional(e => e.PaymentSamanBank)
                .WithRequired(e => e.Payment);

            modelBuilder.Entity<PaymentBank>()
                .HasMany(e => e.PaymentGetaways)
                .WithRequired(e => e.PaymentBank)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PaymentGetaway>()
                .HasMany(e => e.ModuleGetaways)
                .WithRequired(e => e.PaymentGetaway)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PaymentGetaway>()
                .HasMany(e => e.Payments)
                .WithRequired(e => e.PaymentGetaway)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<State>()
                .HasMany(e => e.Cities)
                .WithRequired(e => e.State)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<State>()
                .HasMany(e => e.ExchangeAgahis)
                .WithRequired(e => e.State)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<State>()
                .HasMany(e => e.Invoices)
                .WithRequired(e => e.State)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<State>()
                .HasMany(e => e.UserAddresses)
                .WithRequired(e => e.State)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Baskets)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Invoices)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasOptional(e => e.InvoiceAudit)
                .WithRequired(e => e.User);

            modelBuilder.Entity<User>()
                .HasOptional(e => e.UserProfile)
                .WithRequired(e => e.User);

            modelBuilder.Entity<User>()
                .HasMany(e => e.UserAddresses)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);
        }
    }
}
