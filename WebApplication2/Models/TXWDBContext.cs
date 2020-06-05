using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApplication2.Models
{
    public partial class TXWDBContext : DbContext
    {
        public TXWDBContext(DbContextOptions<TXWDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountRecords> AccountRecords { get; set; }
        public virtual DbSet<AddressBook> AddressBook { get; set; }
        public virtual DbSet<ApplicationInfo> ApplicationInfo { get; set; }
        public virtual DbSet<Base_AdminAccount> Base_AdminAccount { get; set; }
        public virtual DbSet<Base_Cities> Base_Cities { get; set; }
        public virtual DbSet<Base_Counties> Base_Counties { get; set; }
        public virtual DbSet<Base_Files> Base_Files { get; set; }
        public virtual DbSet<Base_Industry> Base_Industry { get; set; }
        public virtual DbSet<Base_Message> Base_Message { get; set; }
        public virtual DbSet<Base_News> Base_News { get; set; }
        public virtual DbSet<Base_NewsCategory> Base_NewsCategory { get; set; }
        public virtual DbSet<Base_Provinces> Base_Provinces { get; set; }
        public virtual DbSet<Base_SerialNumber> Base_SerialNumber { get; set; }
        public virtual DbSet<Base_SysConfigure> Base_SysConfigure { get; set; }
        public virtual DbSet<Base_Towns> Base_Towns { get; set; }
        public virtual DbSet<Base_Unit> Base_Unit { get; set; }
        public virtual DbSet<Base_UserInfo> Base_UserInfo { get; set; }
        public virtual DbSet<Base_UserInfoPermissions> Base_UserInfoPermissions { get; set; }
        public virtual DbSet<Base_Villages> Base_Villages { get; set; }
        public virtual DbSet<Base_Website> Base_Website { get; set; }
        public virtual DbSet<BusinessSection> BusinessSection { get; set; }
        public virtual DbSet<ExpressCompany> ExpressCompany { get; set; }
        public virtual DbSet<ExpressCompanyRule> ExpressCompanyRule { get; set; }
        public virtual DbSet<ExpressDelivery_Order> ExpressDelivery_Order { get; set; }
        public virtual DbSet<ExpressDelivery_TraceData> ExpressDelivery_TraceData { get; set; }
        public virtual DbSet<ExpressDelivery_WaybillData> ExpressDelivery_WaybillData { get; set; }
        public virtual DbSet<ExpressOrderSource> ExpressOrderSource { get; set; }
        public virtual DbSet<ExpressPackage_Order> ExpressPackage_Order { get; set; }
        public virtual DbSet<FellowActivity> FellowActivity { get; set; }
        public virtual DbSet<FellowActivity_Apply> FellowActivity_Apply { get; set; }
        public virtual DbSet<Fellow_Chat_Record> Fellow_Chat_Record { get; set; }
        public virtual DbSet<Fellow_Friends> Fellow_Friends { get; set; }
        public virtual DbSet<FriendShip> FriendShip { get; set; }
        public virtual DbSet<FriendShip_Comment> FriendShip_Comment { get; set; }
        public virtual DbSet<FriendShip_Like> FriendShip_Like { get; set; }
        public virtual DbSet<MerchantExpressCompany> MerchantExpressCompany { get; set; }
        public virtual DbSet<Merchants> Merchants { get; set; }
        public virtual DbSet<MerchantsExpressPackage> MerchantsExpressPackage { get; set; }
        public virtual DbSet<Merchants_Permissions> Merchants_Permissions { get; set; }
        public virtual DbSet<ParcelPostOrder> ParcelPostOrder { get; set; }
        public virtual DbSet<PaymentRecords> PaymentRecords { get; set; }
        public virtual DbSet<PaymentUnifiedOrder> PaymentUnifiedOrder { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductCategory> ProductCategory { get; set; }
        public virtual DbSet<ProductDistribution> ProductDistribution { get; set; }
        public virtual DbSet<ProductDistributionOrder> ProductDistributionOrder { get; set; }
        public virtual DbSet<ProductDistributionOrderDetail> ProductDistributionOrderDetail { get; set; }
        public virtual DbSet<ProductDistributionSku> ProductDistributionSku { get; set; }
        public virtual DbSet<ProductInformation> ProductInformation { get; set; }
        public virtual DbSet<ProductMaterial> ProductMaterial { get; set; }
        public virtual DbSet<ProductOrder> ProductOrder { get; set; }
        public virtual DbSet<ProductOrderDetail> ProductOrderDetail { get; set; }
        public virtual DbSet<ProductOrderExpress> ProductOrderExpress { get; set; }
        public virtual DbSet<ProductSku> ProductSku { get; set; }
        public virtual DbSet<ProductSkuProperty> ProductSkuProperty { get; set; }
        public virtual DbSet<ProductSpecification> ProductSpecification { get; set; }
        public virtual DbSet<Property> Property { get; set; }
        public virtual DbSet<Published> Published { get; set; }
        public virtual DbSet<Published1> Published1 { get; set; }
        public virtual DbSet<Published2> Published2 { get; set; }
        public virtual DbSet<Published3> Published3 { get; set; }
        public virtual DbSet<Published4> Published4 { get; set; }
        public virtual DbSet<Published5> Published5 { get; set; }
        public virtual DbSet<Published6> Published6 { get; set; }
        public virtual DbSet<Received> Received { get; set; }
        public virtual DbSet<Received1> Received1 { get; set; }
        public virtual DbSet<Received2> Received2 { get; set; }
        public virtual DbSet<Received3> Received3 { get; set; }
        public virtual DbSet<Received4> Received4 { get; set; }
        public virtual DbSet<Received5> Received5 { get; set; }
        public virtual DbSet<Received6> Received6 { get; set; }
        public virtual DbSet<RechargeOrder> RechargeOrder { get; set; }
        public virtual DbSet<Specification> Specification { get; set; }
        public virtual DbSet<SpecificationProperty> SpecificationProperty { get; set; }
        public virtual DbSet<StageProductOrder> StageProductOrder { get; set; }
        public virtual DbSet<StageProductOrderDetail> StageProductOrderDetail { get; set; }
        public virtual DbSet<TaskNotify> TaskNotify { get; set; }
        public virtual DbSet<TaskWechatTemplateMessage> TaskWechatTemplateMessage { get; set; }
        public virtual DbSet<Useable_Merchant> Useable_Merchant { get; set; }
        public virtual DbSet<UserShopCart> UserShopCart { get; set; }
        public virtual DbSet<VillageDelivery_FeeStandard> VillageDelivery_FeeStandard { get; set; }
        public virtual DbSet<VillageDelivery_Order> VillageDelivery_Order { get; set; }
        public virtual DbSet<VillageDelivery_OrderTrace> VillageDelivery_OrderTrace { get; set; }
        public virtual DbSet<WarehouseIntegration> WarehouseIntegration { get; set; }
        public virtual DbSet<WarehouseOrder> WarehouseOrder { get; set; }
        public virtual DbSet<WithdrawalRecord> WithdrawalRecord { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=.\\sql2008r2;Initial Catalog=TXWDB;User ID=sa;Password=lctxw@163.com");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<AccountRecords>(entity =>
            {
                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Comment)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AddressBook>(entity =>
            {
                entity.Property(e => e.AddressDetail)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CityId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CountyId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProvinceId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TownId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.VillageId).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<ApplicationInfo>(entity =>
            {
                entity.Property(e => e.AccessKey)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.AppName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AppRemark)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SecretKey)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.WechatAppId)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.WechatMinAppId)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.WechatOfficeAccountAppId)
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Base_AdminAccount>(entity =>
            {
                entity.HasKey(e => e.AdminAccountId)
                    .HasName("PK_BASE_ADMINACCOUNT");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LoginName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Base_Cities>(entity =>
            {
                entity.Property(e => e.CityId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CityName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProvinceId).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<Base_Counties>(entity =>
            {
                entity.Property(e => e.CityId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CountyId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CountyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Base_Files>(entity =>
            {
                entity.Property(e => e.AbsPath)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ETag)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ThumbETag)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ThumbPath)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Base_Industry>(entity =>
            {
                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IndustryName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Base_Message>(entity =>
            {
                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MsgContent)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MsgTitle)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SendUserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Base_News>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_BASE_NEWS")
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.Content)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Source)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SubTitle)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Base_NewsCategory>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_BASE_NEWSCATEGORY")
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Base_Provinces>(entity =>
            {
                entity.Property(e => e.ProvinceId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ProvinceName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Base_SerialNumber>(entity =>
            {
                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SerialNumber)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Base_SysConfigure>(entity =>
            {
                entity.Property(e => e.Category)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Base_Towns>(entity =>
            {
                entity.Property(e => e.CountyId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TownId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TownName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Base_Unit>(entity =>
            {
                entity.HasKey(e => e.UnitId)
                    .HasName("PK_BASE_UNIT");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UnitName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Base_UserInfo>(entity =>
            {
                entity.Property(e => e.CanUseAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FreezeAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HomeTownId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.HomeVillageId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IdentityCard)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InviterKey)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JobIntro)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MoodContent)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NickName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NowCityId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.NowProvinceId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.RealName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RecommendKey)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotalAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UserEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserPwd)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WechatMinAppOpenId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WechatUnionId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WeiXinAppOpenId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WeiXinOpenId)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Base_UserInfoPermissions>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PermissionKey)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Base_Villages>(entity =>
            {
                entity.Property(e => e.CityId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CityName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CountyId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CountyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProvinceId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ProvinceName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TownId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TownName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VillageId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.VillageName)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Base_Website>(entity =>
            {
                entity.Property(e => e.CountyId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WebsiteAddress)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.WebsiteCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WebsiteName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BusinessSection>(entity =>
            {
                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SectionName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ExpressCompany>(entity =>
            {
                entity.Property(e => e.CaiNiaoCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyCode)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KuaidiNiaoCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ExpressCompanyRule>(entity =>
            {
                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Prefix)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ExpressDelivery_Order>(entity =>
            {
                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryDateTime).HasColumnType("datetime");

                entity.Property(e => e.ExpressAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ExpressNumber)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ExpressOrderNo)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.FinishedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentExpressAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ReceiverAddressDetail)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiverCityId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ReceiverCityName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiverCountyId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ReceiverCountyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiverName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiverPhone)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiverProvinceId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ReceiverProvinceName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SenderAddressDetail)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SenderCityId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SenderCityName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SenderCountyId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SenderCountyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SenderName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SenderPhone)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SenderProvinceId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SenderProvinceName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SuperAreaAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TrackData).HasColumnType("text");

                entity.Property(e => e.Weight).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<ExpressDelivery_TraceData>(entity =>
            {
                entity.HasKey(e => e.ExpressDeliveryTraceDataId)
                    .HasName("PK_EXPRESSDELIVERY_TRACEDATA");

                entity.Property(e => e.ExpressNumberNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.TraceData).HasColumnType("text");
            });

            modelBuilder.Entity<ExpressDelivery_WaybillData>(entity =>
            {
                entity.Property(e => e.CustomAreaData)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.WaybillData)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ExpressOrderSource>(entity =>
            {
                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExpressAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ExpressDeliveryOrderIds)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ExpressWeight).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentDateTime).HasColumnType("datetime");

                entity.Property(e => e.ReceiverAddressDetail)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiverCityId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ReceiverCountyId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ReceiverName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiverPhone)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiverProvinceId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Remark)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SenderAddressDetail)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SenderCityId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SenderCountyId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SenderName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SenderPhone)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SenderProvinceId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StateWeight).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Weight).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<ExpressPackage_Order>(entity =>
            {
                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExpressNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiveDateTime).HasColumnType("datetime");

                entity.Property(e => e.Remark)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SignUserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FellowActivity>(entity =>
            {
                entity.Property(e => e.ActivityDateTime).HasColumnType("datetime");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CheckContent)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CheckDateTime).HasColumnType("datetime");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JoinPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubTitle)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SurplusAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WithdrawalAmount).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<FellowActivity_Apply>(entity =>
            {
                entity.Property(e => e.Comment)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JoinPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OpenId)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNo)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionId)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Fellow_Chat_Record>(entity =>
            {
                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MsgContent)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ReadDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Fellow_Friends>(entity =>
            {
                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Reason)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FriendShip>(entity =>
            {
                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FriendShip_Comment>(entity =>
            {
                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FriendShip_Like>(entity =>
            {
                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MerchantExpressCompany>(entity =>
            {
                entity.Property(e => e.PrinterIPAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrinterName)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Merchants>(entity =>
            {
                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.AppOpenId)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessScope)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CanUseAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FreezeAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Linkman)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MerchantName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MerchantNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OpenId)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PayPassword)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotalAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TownId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.VillageId).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<MerchantsExpressPackage>(entity =>
            {
                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Merchants_Permissions>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PermissionKey)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ParcelPostOrder>(entity =>
            {
                entity.Property(e => e.BusinessCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReceivedDateTime).HasColumnType("datetime");

                entity.Property(e => e.SignUserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TakeInDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<PaymentRecords>(entity =>
            {
                entity.HasKey(e => e.PaymentRecordId)
                    .HasName("PK_PAYMENTRECORDS");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeductionTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayComment)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiveComment)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PaymentUnifiedOrder>(entity =>
            {
                entity.Property(e => e.AccessKey)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Attach)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.AuthCode)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Body)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.Detail)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceInfo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ErrMsg)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FrontNotifyUrl)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NotifyUrl)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OpenId)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.OutTradeNo)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentUnifiedOrderNo)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ResultQueryUrl)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TotalFee).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.WechatAppId)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.WechatH5PayRedirectUrl)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlatformProductName)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ProductImages)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PK_PRODUCTCATEGORY");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductDistribution>(entity =>
            {
                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductDistributionOrder>(entity =>
            {
                entity.Property(e => e.ProductDistributionOrderId).ValueGeneratedNever();

                entity.Property(e => e.BatchOrderNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DealerAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DealerCostAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DealerProfit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DistributionAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DistributionCostAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DistributionProfit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OutRefundNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OutTradeNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayDateTime).HasColumnType("datetime");

                entity.Property(e => e.RefundDateTime).HasColumnType("datetime");

                entity.Property(e => e.Remark)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.WechatOpenId)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductDistributionOrderDetail>(entity =>
            {
                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DealerAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DealerCostAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DealerCostPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DealerPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DealerProfit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DistributionAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DistributionCostAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DistributionCostPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DistributionPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DistributionProfit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SkuName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SupplierPrice).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<ProductDistributionSku>(entity =>
            {
                entity.Property(e => e.BasePrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CanUseStock).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DistributionDateTime).HasColumnType("datetime");

                entity.Property(e => e.FreezeStock).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesCount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SalesPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Stock).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<ProductInformation>(entity =>
            {
                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductContent).HasColumnType("text");
            });

            modelBuilder.Entity<ProductMaterial>(entity =>
            {
                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductTitle)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Source)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SubTitle)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductOrder>(entity =>
            {
                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CostAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OutRefundNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OutTradeNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Postage).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProductOrderNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiverAddressDetail)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiverCityId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ReceiverCityName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiverCountyId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ReceiverCountyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiverName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiverPhone)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiverProvinceId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ReceiverProvinceName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RecommendKey)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RecommendProfit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Remark)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductOrderDetail>(entity =>
            {
                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CostAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CostPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DealerAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DealerPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ShareProfit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SkuName)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductOrderExpress>(entity =>
            {
                entity.Property(e => e.ExpressCompanyCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ExpressCompanyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ExpressNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductSku>(entity =>
            {
                entity.HasKey(e => e.SkuId)
                    .HasName("PK_PRODUCTSKU");

                entity.Property(e => e.BasePrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CanUseStock).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FreezeStock).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesCount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SkuKey)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SkuName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Stock).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TradePrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<ProductSkuProperty>(entity =>
            {
                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductSpecification>(entity =>
            {
                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Property>(entity =>
            {
                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PropertyValue)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Published>(entity =>
            {
                entity.ToTable("Published", "JobService");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Published1>(entity =>
            {
                entity.ToTable("Published", "Cap");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Published2>(entity =>
            {
                entity.ToTable("Published", "WindowService");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Published3>(entity =>
            {
                entity.ToTable("Published", "OMS");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Published4>(entity =>
            {
                entity.ToTable("Published", "Merchant");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Published5>(entity =>
            {
                entity.ToTable("Published", "PayCenter");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Published6>(entity =>
            {
                entity.ToTable("Published", "Portal");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Received>(entity =>
            {
                entity.ToTable("Received", "JobService");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Group).HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Received1>(entity =>
            {
                entity.ToTable("Received", "Cap");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Group).HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Received2>(entity =>
            {
                entity.ToTable("Received", "WindowService");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Group).HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Received3>(entity =>
            {
                entity.ToTable("Received", "OMS");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Group).HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Received4>(entity =>
            {
                entity.ToTable("Received", "Merchant");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Group).HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Received5>(entity =>
            {
                entity.ToTable("Received", "PayCenter");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Group).HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Received6>(entity =>
            {
                entity.ToTable("Received", "Portal");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Group).HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<RechargeOrder>(entity =>
            {
                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RechargeOrderNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Specification>(entity =>
            {
                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SpecificationName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StageProductOrder>(entity =>
            {
                entity.Property(e => e.StageProductOrderId).ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BatchOrderNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CostAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OutRefundNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OutTradeNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayDateTime).HasColumnType("datetime");

                entity.Property(e => e.Profit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RefundDateTime).HasColumnType("datetime");

                entity.Property(e => e.Remark)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WechatOpenId)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StageProductOrderDetail>(entity =>
            {
                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CostAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CostPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Profit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SkuName)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TaskNotify>(entity =>
            {
                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SendDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TaskWechatTemplateMessage>(entity =>
            {
                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.Data)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SendDateTime).HasColumnType("datetime");

                entity.Property(e => e.SendResult)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TemplateId)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Touser)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Useable_Merchant>(entity =>
            {
                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserShopCart>(entity =>
            {
                entity.Property(e => e.AddDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<VillageDelivery_FeeStandard>(entity =>
            {
                entity.Property(e => e.ContinuePrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ContinueWeight).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FeeKey)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FeeName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.StartAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.StartWeight).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<VillageDelivery_Order>(entity =>
            {
                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNo)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ReceivedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ReceiverAddressDetail)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiverDriverTakeOrderTime).HasColumnType("datetime");

                entity.Property(e => e.ReceiverName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiverPhone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiverTownId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ReceiverVillageId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Remark)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SenderAddressDetail)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SenderDriverTakeOrderTime).HasColumnType("datetime");

                entity.Property(e => e.SenderName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SenderPhone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SenderTownId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SenderVillageId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TownDriverTakeOrderTime).HasColumnType("datetime");

                entity.Property(e => e.Weight).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<VillageDelivery_OrderTrace>(entity =>
            {
                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WarehouseIntegration>(entity =>
            {
                entity.Property(e => e.BusinessCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WarehouseOrder>(entity =>
            {
                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BusinessCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CashOnDeliveryAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CashOnDeliveryFileIds)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CashOnDeliveryNotifyDate).HasColumnType("datetime");

                entity.Property(e => e.CashOnDeliveryOutTradeNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CashOnDeliveryReceiveDate).HasColumnType("datetime");

                entity.Property(e => e.CashOnDeliveryReceiveFileIds)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClearAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProblemDate).HasColumnType("datetime");

                entity.Property(e => e.ProblemFileIds)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReminderArea)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReminderDate).HasColumnType("datetime");

                entity.Property(e => e.ReminderPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SignDateTime).HasColumnType("datetime");

                entity.Property(e => e.SignNotifyDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<WithdrawalRecord>(entity =>
            {
                entity.Property(e => e.ActualArrivalAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ApplyDateTime).HasColumnType("datetime");

                entity.Property(e => e.CheckDateTime).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CheckRemark)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FinancePaidDateTime).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FinanceRemark)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FinanceUserId).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifyUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNo)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentNo)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTime).HasColumnType("datetime");

                entity.Property(e => e.ReceiveUserName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceChargeAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ServiceChargeRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.WechatAppOpenId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WechatWebOpenId)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
