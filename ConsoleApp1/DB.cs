namespace ConsoleApp1
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DB : DbContext
    {
        public DB()
            : base("name=DB")
        {
        }

        public virtual DbSet<AnalyticsRedirect> AnalyticsRedirects { get; set; }
        public virtual DbSet<AzmoonCamp> AzmoonCamps { get; set; }
        public virtual DbSet<AzmoonCampRegister> AzmoonCampRegisters { get; set; }
        public virtual DbSet<AzmoonCampRegistrationCode> AzmoonCampRegistrationCodes { get; set; }
        public virtual DbSet<AzmoonCity> AzmoonCities { get; set; }
        public virtual DbSet<AzmoonDar> AzmoonDars { get; set; }
        public virtual DbSet<AzmoonData> AzmoonDatas { get; set; }
        public virtual DbSet<AzmoonJozeDar> AzmoonJozeDars { get; set; }
        public virtual DbSet<AzmoonKarnamehReceipt> AzmoonKarnamehReceipts { get; set; }
        public virtual DbSet<AzmoonMoaref> AzmoonMoarefs { get; set; }
        public virtual DbSet<AzmoonMoshaverVoice> AzmoonMoshaverVoices { get; set; }
        public virtual DbSet<AzmoonOnline> AzmoonOnlines { get; set; }
        public virtual DbSet<AzmoonPackage> AzmoonPackages { get; set; }
        public virtual DbSet<AzmoonPackageDar> AzmoonPackageDars { get; set; }
        public virtual DbSet<AzmoonPackageJozeDar> AzmoonPackageJozeDars { get; set; }
        public virtual DbSet<AzmoonPreRegister> AzmoonPreRegisters { get; set; }
        public virtual DbSet<AzmoonPreRegisterStatu> AzmoonPreRegisterStatus { get; set; }
        public virtual DbSet<AzmoonProvince> AzmoonProvinces { get; set; }
        public virtual DbSet<AzmoonRepresentive> AzmoonRepresentives { get; set; }
        public virtual DbSet<AzmoonRepresentiveLandLine> AzmoonRepresentiveLandLines { get; set; }
        public virtual DbSet<AzmoonTopRankPerson> AzmoonTopRankPersons { get; set; }
        public virtual DbSet<AzmoonType> AzmoonTypes { get; set; }
        public virtual DbSet<AzmoonUserAnswer> AzmoonUserAnswers { get; set; }
        public virtual DbSet<AzmoonUserParticipantCourse> AzmoonUserParticipantCourses { get; set; }
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<CmsOutputForm> CmsOutputForms { get; set; }
        public virtual DbSet<CmsProductPromotion> CmsProductPromotions { get; set; }
        public virtual DbSet<CmsSlideShow> CmsSlideShows { get; set; }
        public virtual DbSet<CmsTemplate> CmsTemplates { get; set; }
        public virtual DbSet<CoreComment> CoreComments { get; set; }
        public virtual DbSet<CoreCommentUserPoint> CoreCommentUserPoints { get; set; }
        public virtual DbSet<CoreQA> CoreQAs { get; set; }
        public virtual DbSet<CourseType> CourseTypes { get; set; }
        public virtual DbSet<CrashReport> CrashReports { get; set; }
        public virtual DbSet<Dictionary> Dictionaries { get; set; }
        public virtual DbSet<ExchangeAgahi> ExchangeAgahis { get; set; }
        public virtual DbSet<ExchangeAgahiBook> ExchangeAgahiBooks { get; set; }
        public virtual DbSet<ExchangeAgahiType> ExchangeAgahiTypes { get; set; }
        public virtual DbSet<ExchangeBookState> ExchangeBookStates { get; set; }
        public virtual DbSet<ExchangeCategory> ExchangeCategories { get; set; }
        public virtual DbSet<GcmDevice> GcmDevices { get; set; }
        public virtual DbSet<Giftcard> Giftcards { get; set; }
        public virtual DbSet<Grade> Grades { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<InvoiceDiscountAudit> InvoiceDiscountAudits { get; set; }
        public virtual DbSet<Major> Majors { get; set; }
        public virtual DbSet<Module> Modules { get; set; }
        public virtual DbSet<ModuleAccess> ModuleAccesses { get; set; }
        public virtual DbSet<ModuleGetaway> ModuleGetaways { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<NewsGallery> NewsGalleries { get; set; }
        public virtual DbSet<NowruzCamp> NowruzCamps { get; set; }
        public virtual DbSet<NowruzCampRegister> NowruzCampRegisters { get; set; }
        public virtual DbSet<NowruzCampRegisterationCode> NowruzCampRegisterationCodes { get; set; }
        public virtual DbSet<OmegaInvoice> OmegaInvoices { get; set; }
        public virtual DbSet<OmegaInvoicePayment> OmegaInvoicePayments { get; set; }
        public virtual DbSet<OmegaPackage> OmegaPackages { get; set; }
        public virtual DbSet<OmegaUser> OmegaUsers { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<PaymentBank> PaymentBanks { get; set; }
        public virtual DbSet<PaymentGetaway> PaymentGetaways { get; set; }
        public virtual DbSet<PaymentHekmatBank> PaymentHekmatBanks { get; set; }
        public virtual DbSet<PaymentMellatBank> PaymentMellatBanks { get; set; }
        public virtual DbSet<PaymentPasargadBank> PaymentPasargadBanks { get; set; }
        public virtual DbSet<PaymentSamanBank> PaymentSamanBanks { get; set; }
        public virtual DbSet<PaymentStatu> PaymentStatus { get; set; }
        public virtual DbSet<Permission> Permissions { get; set; }
        public virtual DbSet<SaleStore> SaleStores { get; set; }
        public virtual DbSet<SaleStoreLandLine> SaleStoreLandLines { get; set; }
        public virtual DbSet<SchoolProfile> SchoolProfiles { get; set; }
        public virtual DbSet<SecurityClient> SecurityClients { get; set; }
        public virtual DbSet<SecurityGroup> SecurityGroups { get; set; }
        public virtual DbSet<ShopCity> ShopCities { get; set; }
        public virtual DbSet<ShopProvince> ShopProvinces { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<StoreApp> StoreApps { get; set; }
        public virtual DbSet<StoreAppProduct> StoreAppProducts { get; set; }
        public virtual DbSet<StoreAppPurchase> StoreAppPurchases { get; set; }
        public virtual DbSet<StoreAppPurchaseKey> StoreAppPurchaseKeys { get; set; }
        public virtual DbSet<StoreAppRelease> StoreAppReleases { get; set; }
        public virtual DbSet<StoreAuthor> StoreAuthors { get; set; }
        public virtual DbSet<StoreBasket> StoreBaskets { get; set; }
        public virtual DbSet<StoreBook> StoreBooks { get; set; }
        public virtual DbSet<StoreBookAuthor> StoreBookAuthors { get; set; }
        public virtual DbSet<StoreBookType> StoreBookTypes { get; set; }
        public virtual DbSet<StoreDiscount> StoreDiscounts { get; set; }
        public virtual DbSet<StoreGradeOfferProduct> StoreGradeOfferProducts { get; set; }
        public virtual DbSet<StoreInvoice> StoreInvoices { get; set; }
        public virtual DbSet<StoreInvoiceAudit> StoreInvoiceAudits { get; set; }
        public virtual DbSet<StoreInvoiceItem> StoreInvoiceItems { get; set; }
        public virtual DbSet<StoreInvoicePaymentMethod> StoreInvoicePaymentMethods { get; set; }
        public virtual DbSet<StoreInvoiceSendMethod> StoreInvoiceSendMethods { get; set; }
        public virtual DbSet<StoreInvoiceStatu> StoreInvoiceStatus { get; set; }
        public virtual DbSet<StoreOffer> StoreOffers { get; set; }
        public virtual DbSet<StorePayment> StorePayments { get; set; }
        public virtual DbSet<StoreProduct> StoreProducts { get; set; }
        public virtual DbSet<StoreProductSalePolicy> StoreProductSalePolicies { get; set; }
        public virtual DbSet<StoreScreenShot> StoreScreenShots { get; set; }
        public virtual DbSet<StoreUserAddress> StoreUserAddresses { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<Token> Tokens { get; set; }
        public virtual DbSet<TokenClient> TokenClients { get; set; }
        public virtual DbSet<Tree> Trees { get; set; }
        public virtual DbSet<Univercity> Univercities { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserGroup> UserGroups { get; set; }
        public virtual DbSet<UserProfile> UserProfiles { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Flag> Flags { get; set; }
        public virtual DbSet<AzmoonPackageListGridView> AzmoonPackageListGridViews { get; set; }
        public virtual DbSet<BookInListView> BookInListViews { get; set; }
        public virtual DbSet<InvoiceListGridView> InvoiceListGridViews { get; set; }
        public virtual DbSet<InvoiceUserAddressListGridView> InvoiceUserAddressListGridViews { get; set; }
        public virtual DbSet<OfferListView> OfferListViews { get; set; }
        public virtual DbSet<ProductCommentView> ProductCommentViews { get; set; }
        public virtual DbSet<ProductCommentView2> ProductCommentView2 { get; set; }
        public virtual DbSet<SaleProductInDateTime> SaleProductInDateTimes { get; set; }
        public virtual DbSet<StoreDiscountView> StoreDiscountViews { get; set; }
        public virtual DbSet<TopBookSaleListGridView> TopBookSaleListGridViews { get; set; }
        public virtual DbSet<UserView> UserViews { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AzmoonCamp>()
                .HasMany(e => e.AzmoonCampRegistrationCodes)
                .WithRequired(e => e.AzmoonCamp)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AzmoonCampRegister>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<AzmoonCampRegister>()
                .HasMany(e => e.AzmoonCampRegistrationCodes)
                .WithOptional(e => e.AzmoonCampRegister)
                .HasForeignKey(e => e.ConsumedBy);

            modelBuilder.Entity<AzmoonCampRegistrationCode>()
                .HasMany(e => e.AzmoonCampRegisters)
                .WithRequired(e => e.AzmoonCampRegistrationCode)
                .HasForeignKey(e => e.CampRegisterationCodeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AzmoonCity>()
                .HasMany(e => e.NowruzCampRegisters)
                .WithRequired(e => e.AzmoonCity)
                .HasForeignKey(e => e.AzmoonCityId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AzmoonDar>()
                .HasMany(e => e.AzmoonJozeDars)
                .WithRequired(e => e.AzmoonDar)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AzmoonDar>()
                .HasMany(e => e.AzmoonUserAnswers)
                .WithRequired(e => e.AzmoonDar)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AzmoonDar>()
                .HasMany(e => e.Users)
                .WithMany(e => e.AzmoonDars)
                .Map(m => m.ToTable("AzmoonUserAzmoonDars").MapLeftKey("AzmoonDarsId").MapRightKey("UserId"));

            modelBuilder.Entity<AzmoonJozeDar>()
                .HasMany(e => e.AzmoonPackageJozeDars)
                .WithRequired(e => e.AzmoonJozeDar)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AzmoonOnline>()
                .HasMany(e => e.AzmoonPackages)
                .WithRequired(e => e.AzmoonOnline)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AzmoonOnline>()
                .HasMany(e => e.AzmoonUserParticipantCourses)
                .WithRequired(e => e.AzmoonOnline)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AzmoonPackage>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<AzmoonPackage>()
                .HasMany(e => e.AzmoonKarnamehReceipts)
                .WithRequired(e => e.AzmoonPackage)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AzmoonPackage>()
                .HasMany(e => e.AzmoonPackageDars)
                .WithRequired(e => e.AzmoonPackage)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AzmoonPackage>()
                .HasMany(e => e.AzmoonUserAnswers)
                .WithRequired(e => e.AzmoonPackage)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AzmoonPackageDar>()
                .HasMany(e => e.AzmoonPackageJozeDars)
                .WithRequired(e => e.AzmoonPackageDar)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AzmoonPreRegister>()
                .HasMany(e => e.AzmoonTypes)
                .WithMany(e => e.AzmoonPreRegisters)
                .Map(m => m.ToTable("AzmoonPreRegisterAzmoonType").MapLeftKey("AzmoonPreRegisterId").MapRightKey("AzmoonTypeId"));

            modelBuilder.Entity<AzmoonProvince>()
                .HasMany(e => e.AzmoonCities)
                .WithRequired(e => e.AzmoonProvince)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AzmoonProvince>()
                .HasMany(e => e.NowruzCampRegisters)
                .WithRequired(e => e.AzmoonProvince)
                .HasForeignKey(e => e.AzmoonProvinceId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AzmoonRepresentive>()
                .HasMany(e => e.AzmoonPreRegisters)
                .WithRequired(e => e.AzmoonRepresentive)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AzmoonRepresentive>()
                .HasMany(e => e.AzmoonRepresentiveLandLines)
                .WithRequired(e => e.AzmoonRepresentive)
                .HasForeignKey(e => e.RepresentativeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AzmoonRepresentiveLandLine>()
                .Property(e => e.AreaCode)
                .IsUnicode(false);

            modelBuilder.Entity<AzmoonRepresentiveLandLine>()
                .Property(e => e.Landline)
                .IsUnicode(false);

            modelBuilder.Entity<Branch>()
                .HasMany(e => e.Majors)
                .WithRequired(e => e.Branch)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.Category1)
                .WithOptional(e => e.Category2)
                .HasForeignKey(e => e.ParentId);

            modelBuilder.Entity<City>()
                .HasMany(e => e.AzmoonCampRegisters)
                .WithRequired(e => e.City)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<City>()
                .HasMany(e => e.AzmoonRepresentives)
                .WithRequired(e => e.City)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<City>()
                .HasMany(e => e.ExchangeAgahis)
                .WithRequired(e => e.City)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<City>()
                .HasMany(e => e.SaleStores)
                .WithRequired(e => e.City)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<City>()
                .HasMany(e => e.StoreInvoices)
                .WithRequired(e => e.City)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<City>()
                .HasMany(e => e.StoreUserAddresses)
                .WithRequired(e => e.City)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CoreComment>()
                .HasMany(e => e.CoreComment1)
                .WithOptional(e => e.CoreComment2)
                .HasForeignKey(e => e.ParentId);

            modelBuilder.Entity<CoreQA>()
                .HasMany(e => e.CoreQA1)
                .WithOptional(e => e.CoreQA2)
                .HasForeignKey(e => e.ParentId);

            modelBuilder.Entity<CoreQA>()
                .HasMany(e => e.Categories)
                .WithMany(e => e.CoreQAs)
                .Map(m => m.ToTable("CoreQACategory").MapLeftKey("QAId").MapRightKey("CategoryId"));

            modelBuilder.Entity<CoreQA>()
                .HasMany(e => e.Tags)
                .WithMany(e => e.CoreQAs)
                .Map(m => m.ToTable("CoreQATag").MapLeftKey("QAId").MapRightKey("TagId"));

            modelBuilder.Entity<CourseType>()
                .HasMany(e => e.Courses)
                .WithRequired(e => e.CourseType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ExchangeAgahi>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ExchangeAgahi>()
                .HasMany(e => e.ExchangeCategories)
                .WithMany(e => e.ExchangeAgahis)
                .Map(m => m.ToTable("ExchangeCategoryAgahi").MapLeftKey("AgahiId").MapRightKey("CategoryId"));

            modelBuilder.Entity<ExchangeAgahiType>()
                .HasMany(e => e.ExchangeAgahis)
                .WithRequired(e => e.ExchangeAgahiType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ExchangeCategory>()
                .HasMany(e => e.ExchangeCategory1)
                .WithOptional(e => e.ExchangeCategory2)
                .HasForeignKey(e => e.ParentId);

            modelBuilder.Entity<Giftcard>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Giftcard>()
                .Property(e => e.Serial)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Grade>()
                .HasMany(e => e.AzmoonCampRegisters)
                .WithRequired(e => e.Grade)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Grade>()
                .HasMany(e => e.AzmoonDatas)
                .WithRequired(e => e.Grade)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Grade>()
                .HasMany(e => e.AzmoonPreRegisters)
                .WithRequired(e => e.Grade)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Grade>()
                .HasMany(e => e.Grade1)
                .WithOptional(e => e.Grade2)
                .HasForeignKey(e => e.ParentId);

            modelBuilder.Entity<Grade>()
                .HasMany(e => e.OmegaPackages)
                .WithMany(e => e.Grades)
                .Map(m => m.ToTable("OmegaPackageGrade").MapLeftKey("GradeId").MapRightKey("OmegaPackageId"));

            modelBuilder.Entity<InvoiceDiscountAudit>()
                .Property(e => e.Code)
                .IsFixedLength();

            modelBuilder.Entity<InvoiceDiscountAudit>()
                .Property(e => e.DiscountPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<InvoiceDiscountAudit>()
                .Property(e => e.OrganizeTitle)
                .IsFixedLength();

            modelBuilder.Entity<Major>()
                .HasMany(e => e.Courses)
                .WithRequired(e => e.Major)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Module>()
                .HasMany(e => e.ModuleAccesses)
                .WithRequired(e => e.Module)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Module>()
                .HasMany(e => e.ModuleGetaways)
                .WithRequired(e => e.Module)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Module>()
                .HasMany(e => e.Payments)
                .WithRequired(e => e.Module)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<News>()
                .HasMany(e => e.NewsGalleries)
                .WithRequired(e => e.News)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NowruzCamp>()
                .HasMany(e => e.NowruzCampRegisterationCodes)
                .WithRequired(e => e.NowruzCamp)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NowruzCampRegister>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<NowruzCampRegister>()
                .HasMany(e => e.NowruzCampRegisterationCodes)
                .WithOptional(e => e.NowruzCampRegister)
                .HasForeignKey(e => e.ConsumedBy);

            modelBuilder.Entity<OmegaInvoice>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OmegaInvoice>()
                .HasMany(e => e.OmegaInvoicePayments)
                .WithRequired(e => e.OmegaInvoice)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OmegaInvoice>()
                .HasMany(e => e.OmegaPackages)
                .WithMany(e => e.OmegaInvoices)
                .Map(m => m.ToTable("OmegaInvoiceItem").MapLeftKey("OmegaInvoiceId").MapRightKey("OmegaPackageId"));

            modelBuilder.Entity<OmegaInvoice>()
                .HasMany(e => e.Payments)
                .WithMany(e => e.OmegaInvoices)
                .Map(m => m.ToTable("OmegaPaymentId").MapLeftKey("OmegaInvoiceId").MapRightKey("PaymentId"));

            modelBuilder.Entity<OmegaInvoicePayment>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OmegaPackage>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OmegaUser>()
                .Property(e => e.Landline)
                .IsUnicode(false);

            modelBuilder.Entity<OmegaUser>()
                .Property(e => e.AreaCode)
                .IsUnicode(false);

            modelBuilder.Entity<OmegaUser>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

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

            modelBuilder.Entity<SaleStore>()
                .HasMany(e => e.SaleStoreLandLines)
                .WithRequired(e => e.SaleStore)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SaleStoreLandLine>()
                .Property(e => e.AreaCode)
                .IsUnicode(false);

            modelBuilder.Entity<ShopProvince>()
                .HasMany(e => e.ShopCities)
                .WithRequired(e => e.ShopProvince)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<State>()
                .HasMany(e => e.AzmoonCampRegisters)
                .WithRequired(e => e.State)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<State>()
                .HasMany(e => e.AzmoonPreRegisters)
                .WithRequired(e => e.State)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<State>()
                .HasMany(e => e.AzmoonRepresentives)
                .WithRequired(e => e.State)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<State>()
                .HasMany(e => e.AzmoonTopRankPersons)
                .WithRequired(e => e.State)
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
                .HasMany(e => e.SaleStores)
                .WithRequired(e => e.State)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<State>()
                .HasMany(e => e.StoreInvoices)
                .WithRequired(e => e.State)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<State>()
                .HasMany(e => e.StoreUserAddresses)
                .WithRequired(e => e.State)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StoreApp>()
                .HasMany(e => e.CmsProductPromotions)
                .WithRequired(e => e.StoreApp)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StoreApp>()
                .HasMany(e => e.CrashReports)
                .WithRequired(e => e.StoreApp)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StoreApp>()
                .HasMany(e => e.StoreAppProducts)
                .WithRequired(e => e.StoreApp)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StoreApp>()
                .HasMany(e => e.StoreAppReleases)
                .WithRequired(e => e.StoreApp)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StoreApp>()
                .HasMany(e => e.StoreAppPurchaseKeys)
                .WithRequired(e => e.StoreApp)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StoreAppProduct>()
                .Property(e => e.Sku)
                .IsUnicode(false);

            modelBuilder.Entity<StoreAppProduct>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<StoreAppProduct>()
                .HasMany(e => e.StoreAppPurchases)
                .WithRequired(e => e.StoreAppProduct)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StoreAuthor>()
                .HasMany(e => e.StoreBookAuthors)
                .WithRequired(e => e.StoreAuthor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StoreBook>()
                .HasMany(e => e.StoreBookAuthors)
                .WithRequired(e => e.StoreBook)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StoreBookType>()
                .HasMany(e => e.StoreBooks)
                .WithRequired(e => e.StoreBookType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StoreDiscount>()
                .HasMany(e => e.StoreProducts)
                .WithMany(e => e.StoreDiscounts)
                .Map(m => m.ToTable("StoreProductDiscount").MapLeftKey("DiscountId").MapRightKey("ProductId"));

            modelBuilder.Entity<StoreInvoice>()
                .Property(e => e.DiscountPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<StoreInvoice>()
                .Property(e => e.TotalPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<StoreInvoice>()
                .Property(e => e.PriceSend)
                .HasPrecision(19, 4);

            modelBuilder.Entity<StoreInvoice>()
                .Property(e => e.CreditPolicyPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<StoreInvoice>()
                .HasMany(e => e.InvoiceDiscountAudits)
                .WithRequired(e => e.StoreInvoice)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StoreInvoice>()
                .HasOptional(e => e.StoreInvoiceAudit)
                .WithRequired(e => e.StoreInvoice);

            modelBuilder.Entity<StoreInvoice>()
                .HasMany(e => e.StorePayments)
                .WithRequired(e => e.StoreInvoice)
                .HasForeignKey(e => e.InvoiceId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StoreInvoice>()
                .HasMany(e => e.StorePayments1)
                .WithMany(e => e.StoreInvoices)
                .Map(m => m.ToTable("StoreInvoicePayment").MapLeftKey("InvoiceId").MapRightKey("PaymentId"));

            modelBuilder.Entity<StoreInvoiceAudit>()
                .Property(e => e.OldAddress)
                .IsUnicode(false);

            modelBuilder.Entity<StoreInvoiceAudit>()
                .Property(e => e.NewAddress)
                .IsUnicode(false);

            modelBuilder.Entity<StoreInvoiceItem>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<StoreInvoicePaymentMethod>()
                .HasMany(e => e.StoreInvoices)
                .WithRequired(e => e.StoreInvoicePaymentMethod)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StoreInvoiceSendMethod>()
                .HasMany(e => e.StoreInvoices)
                .WithRequired(e => e.StoreInvoiceSendMethod)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StoreInvoiceStatu>()
                .HasMany(e => e.StoreInvoices)
                .WithRequired(e => e.StoreInvoiceStatu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StoreInvoiceStatu>()
                .HasMany(e => e.StoreInvoiceAudits)
                .WithOptional(e => e.StoreInvoiceStatu)
                .HasForeignKey(e => e.NewStatusId);

            modelBuilder.Entity<StoreInvoiceStatu>()
                .HasMany(e => e.StoreInvoiceAudits1)
                .WithOptional(e => e.StoreInvoiceStatu1)
                .HasForeignKey(e => e.OldStatusId);

            modelBuilder.Entity<StoreOffer>()
                .HasMany(e => e.StoreGradeOfferProducts)
                .WithRequired(e => e.StoreOffer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StorePayment>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<StoreProduct>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<StoreProduct>()
                .HasOptional(e => e.StoreApp)
                .WithRequired(e => e.StoreProduct);

            modelBuilder.Entity<StoreProduct>()
                .HasMany(e => e.StoreBaskets)
                .WithRequired(e => e.StoreProduct)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StoreProduct>()
                .HasOptional(e => e.StoreBook)
                .WithRequired(e => e.StoreProduct);

            modelBuilder.Entity<StoreProduct>()
                .HasMany(e => e.StoreGradeOfferProducts)
                .WithRequired(e => e.StoreProduct)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StoreProduct>()
                .HasMany(e => e.StoreInvoiceItems)
                .WithRequired(e => e.StoreProduct)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StoreProduct>()
                .HasMany(e => e.StoreProductSalePolicies)
                .WithRequired(e => e.StoreProduct)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StoreProduct>()
                .HasMany(e => e.StoreScreenShots)
                .WithRequired(e => e.StoreProduct)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StoreProduct>()
                .HasMany(e => e.Grades)
                .WithMany(e => e.StoreProducts)
                .Map(m => m.ToTable("StoreProductGrade").MapLeftKey("ProductId").MapRightKey("GradeId"));

            modelBuilder.Entity<StoreProduct>()
                .HasMany(e => e.Tags)
                .WithMany(e => e.StoreProducts)
                .Map(m => m.ToTable("StoreProductTag").MapLeftKey("ProductId").MapRightKey("TagId"));

            modelBuilder.Entity<User>()
                .HasMany(e => e.AzmoonCamps)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.CreatedBy);

            modelBuilder.Entity<User>()
                .HasMany(e => e.AzmoonCamps1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.EditedBy);

            modelBuilder.Entity<User>()
                .HasMany(e => e.AzmoonTopRankPersons)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.CreatedBy);

            modelBuilder.Entity<User>()
                .HasMany(e => e.AzmoonTopRankPersons1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.EditedBy);

            modelBuilder.Entity<User>()
                .HasMany(e => e.AzmoonUserAnswers)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.AzmoonUserParticipantCourses)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Giftcards)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.ConsumedBy);

            modelBuilder.Entity<User>()
                .HasMany(e => e.News)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.RegistrantUserId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.News1)
                .WithRequired(e => e.User1)
                .HasForeignKey(e => e.EditorUserId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.OmegaInvoices)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.MoarefId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.OmegaInvoicePayments)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasOptional(e => e.OmegaUser)
                .WithRequired(e => e.User);

            modelBuilder.Entity<User>()
                .HasMany(e => e.SaleStores)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.CreatedBy);

            modelBuilder.Entity<User>()
                .HasMany(e => e.SaleStores1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.EditedBy);

            modelBuilder.Entity<User>()
                .HasMany(e => e.SchoolProfiles)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.StoreAppPurchases)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.StoreBaskets)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.StoreInvoices)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasOptional(e => e.StoreInvoiceAudit)
                .WithRequired(e => e.User);

            modelBuilder.Entity<User>()
                .HasMany(e => e.StoreProductSalePolicies)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.CreatedBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.StoreProductSalePolicies1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.EditedBy);

            modelBuilder.Entity<User>()
                .HasMany(e => e.StoreUserAddresses)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasOptional(e => e.UserProfile)
                .WithRequired(e => e.User);

            modelBuilder.Entity<BookInListView>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BookInListView>()
                .Property(e => e.Tags)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceListGridView>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<InvoiceListGridView>()
                .Property(e => e.PayingPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<InvoiceUserAddressListGridView>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SaleProductInDateTime>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SaleProductInDateTime>()
                .Property(e => e.DiscountPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SaleProductInDateTime>()
                .Property(e => e.SumPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SaleProductInDateTime>()
                .Property(e => e.SumDiscountPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SaleProductInDateTime>()
                .Property(e => e.TotalPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SaleProductInDateTime>()
                .Property(e => e.PaymentTotalPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TopBookSaleListGridView>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TopBookSaleListGridView>()
                .Property(e => e.DiscountPrice)
                .HasPrecision(19, 4);
        }
    }
}
