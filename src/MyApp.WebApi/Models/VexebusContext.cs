using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MyApp.WebApi.Models;

public partial class VexebusContext : DbContext
{
    public VexebusContext()
    {
    }

    public VexebusContext(DbContextOptions<VexebusContext> options)
        : base(options)
    {
    }

    public virtual DbSet<A1> A1s { get; set; }

    public virtual DbSet<A2> A2s { get; set; }

    public virtual DbSet<Authorize> Authorizes { get; set; }

    public virtual DbSet<Device> Devices { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Event> Events { get; set; }

    public virtual DbSet<HbBangGiaVe> HbBangGiaVes { get; set; }

    public virtual DbSet<HbCart> HbCarts { get; set; }

    public virtual DbSet<HbCartDetail> HbCartDetails { get; set; }

    public virtual DbSet<HbCauHinh> HbCauHinhs { get; set; }

    public virtual DbSet<HbCustomer> HbCustomers { get; set; }

    public virtual DbSet<HbCustomerType> HbCustomerTypes { get; set; }

    public virtual DbSet<HbDiem> HbDiems { get; set; }

    public virtual DbSet<HbDoanhNghiep> HbDoanhNghieps { get; set; }

    public virtual DbSet<HbEmailConfig> HbEmailConfigs { get; set; }

    public virtual DbSet<HbFeedback> HbFeedbacks { get; set; }

    public virtual DbSet<HbFeedbackReplyTemplate> HbFeedbackReplyTemplates { get; set; }

    public virtual DbSet<HbGopY> HbGopies { get; set; }

    public virtual DbSet<HbLichTrinh> HbLichTrinhs { get; set; }

    public virtual DbSet<HbNhatKy> HbNhatKies { get; set; }

    public virtual DbSet<HbTicketPrice> HbTicketPrices { get; set; }

    public virtual DbSet<HbTicketType> HbTicketTypes { get; set; }

    public virtual DbSet<HbTuyen> HbTuyens { get; set; }

    public virtual DbSet<HbTuyenDiem> HbTuyenDiems { get; set; }

    public virtual DbSet<HbXe> HbXes { get; set; }

    public virtual DbSet<Image> Images { get; set; }

    public virtual DbSet<InvoiceErrorLog> InvoiceErrorLogs { get; set; }

    public virtual DbSet<Menu> Menus { get; set; }

    public virtual DbSet<MyRole> MyRoles { get; set; }

    public virtual DbSet<MyUserRole> MyUserRoles { get; set; }

    public virtual DbSet<OrderDetail> OrderDetails { get; set; }

    public virtual DbSet<OrderInvoice> OrderInvoices { get; set; }

    public virtual DbSet<OrderTemp> OrderTemps { get; set; }

    public virtual DbSet<PayType> PayTypes { get; set; }

    public virtual DbSet<PaymentOnlineConfig> PaymentOnlineConfigs { get; set; }

    public virtual DbSet<Place> Places { get; set; }

    public virtual DbSet<PlaceDaiNoi> PlaceDaiNois { get; set; }

    public virtual DbSet<PromotionConfig> PromotionConfigs { get; set; }

    public virtual DbSet<ReceiptConfig> ReceiptConfigs { get; set; }

    public virtual DbSet<ReceiptInfo> ReceiptInfos { get; set; }

    public virtual DbSet<ReceiptTemplateConfig> ReceiptTemplateConfigs { get; set; }

    public virtual DbSet<RequestLogger> RequestLoggers { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Role1> Roles1 { get; set; }

    public virtual DbSet<RoleClaim> RoleClaims { get; set; }

    public virtual DbSet<Service> Services { get; set; }

    public virtual DbSet<StatisticElement> StatisticElements { get; set; }

    public virtual DbSet<StatisticTemplate> StatisticTemplates { get; set; }

    public virtual DbSet<StatisticTemplateElement> StatisticTemplateElements { get; set; }

    public virtual DbSet<StatisticTemplateRole> StatisticTemplateRoles { get; set; }

    public virtual DbSet<SubOrderDetail> SubOrderDetails { get; set; }

    public virtual DbSet<Testing> Testings { get; set; }

    public virtual DbSet<TicketCategory> TicketCategories { get; set; }

    public virtual DbSet<TicketCounter> TicketCounters { get; set; }

    public virtual DbSet<TicketDetail> TicketDetails { get; set; }

    public virtual DbSet<TicketOrder> TicketOrders { get; set; }

    public virtual DbSet<TicketPrintLog> TicketPrintLogs { get; set; }

    public virtual DbSet<TicketScanLog> TicketScanLogs { get; set; }

    public virtual DbSet<TicketTypeDetail> TicketTypeDetails { get; set; }

    public virtual DbSet<TicketUsedLog> TicketUsedLogs { get; set; }

    public virtual DbSet<UpdatePaymentStatusLog> UpdatePaymentStatusLogs { get; set; }

    public virtual DbSet<UpdatePaymentStatusLogDetail> UpdatePaymentStatusLogDetails { get; set; }

    public virtual DbSet<UpdateTicketQuantityLog> UpdateTicketQuantityLogs { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserCard> UserCards { get; set; }

    public virtual DbSet<UserCart> UserCarts { get; set; }

    public virtual DbSet<UserCartDetail> UserCartDetails { get; set; }

    public virtual DbSet<UserClaim> UserClaims { get; set; }

    public virtual DbSet<UserLogin> UserLogins { get; set; }

    public virtual DbSet<UserToken> UserTokens { get; set; }

    public virtual DbSet<Video> Videos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=14.225.23.91;Database=vexebus;User Id=vexebus;Password=HueC1t@2023;trustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<A1>(entity =>
        {
            entity.ToTable("A1");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");

            entity.HasMany(d => d.A2s).WithMany(p => p.A1s)
                .UsingEntity<Dictionary<string, object>>(
                    "A3",
                    r => r.HasOne<A2>().WithMany()
                        .HasForeignKey("A2Id")
                        .HasConstraintName("FK_A3_A2"),
                    l => l.HasOne<A1>().WithMany()
                        .HasForeignKey("A1Id")
                        .HasConstraintName("FK_A3_A1"),
                    j =>
                    {
                        j.HasKey("A1Id", "A2Id");
                        j.ToTable("A3");
                        j.IndexerProperty<int>("A1Id").HasColumnName("A1_ID");
                        j.IndexerProperty<int>("A2Id").HasColumnName("A2_ID");
                    });
        });

        modelBuilder.Entity<A2>(entity =>
        {
            entity.ToTable("A2");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<Authorize>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Authorize");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.IsAuthorize)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .IsFixedLength();
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Device>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Table_1");

            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.ValueId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ValueName).HasMaxLength(100);
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.ToTable("Employee");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedById).HasColumnName("CreatedByID");
            entity.Property(e => e.CreatedTime).HasPrecision(3);
            entity.Property(e => e.Description).HasMaxLength(100);
            entity.Property(e => e.FullName).HasMaxLength(50);
            entity.Property(e => e.PassWord)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.UpdateById).HasColumnName("UpdateByID");
            entity.Property(e => e.UpdateTime).HasPrecision(3);
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Role).WithMany(p => p.Employees)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Employee_Role");
        });

        modelBuilder.Entity<Event>(entity =>
        {
            entity.ToTable("Event");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Address).HasMaxLength(300);
            entity.Property(e => e.CreatedById).HasColumnName("CreatedByID");
            entity.Property(e => e.CreatedTime).HasPrecision(3);
            entity.Property(e => e.EventTime).HasMaxLength(100);
            entity.Property(e => e.ImageId).HasColumnName("ImageID");
            entity.Property(e => e.Introduce).HasMaxLength(3000);
            entity.Property(e => e.IsAvatar)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IsDaily)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Note).HasMaxLength(300);
            entity.Property(e => e.OpenDate)
                .HasColumnType("datetime")
                .HasColumnName("Open_Date");
            entity.Property(e => e.Title).HasMaxLength(100);
            entity.Property(e => e.UpdateById).HasColumnName("UpdateByID");
            entity.Property(e => e.UpdateTime).HasColumnType("date");
            entity.Property(e => e.VideoId).HasColumnName("VideoID");
        });

        modelBuilder.Entity<HbBangGiaVe>(entity =>
        {
            entity.ToTable("HB_BangGiaVe");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DoanhNghiepId).HasColumnName("DoanhNghiepID");
            entity.Property(e => e.TicketPriceId).HasColumnName("TicketPriceID");
            entity.Property(e => e.TuyenId).HasColumnName("TuyenID");

            entity.HasOne(d => d.DoanhNghiep).WithMany(p => p.HbBangGiaVes)
                .HasForeignKey(d => d.DoanhNghiepId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_HB_BangGiaVe_HB_DoanhNghiep");

            entity.HasOne(d => d.TicketPrice).WithMany(p => p.HbBangGiaVes)
                .HasForeignKey(d => d.TicketPriceId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_HB_BangGiaVe_TicketPrice");

            entity.HasOne(d => d.Tuyen).WithMany(p => p.HbBangGiaVes)
                .HasForeignKey(d => d.TuyenId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_HB_BangGiaVe_HB_Tuyen");
        });

        modelBuilder.Entity<HbCart>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Cart");

            entity.ToTable("HB_Cart");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CartDetailId).HasColumnName("CartDetailID");
            entity.Property(e => e.CreatedTime).HasPrecision(3);
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.UpdateTime).HasPrecision(3);

            entity.HasOne(d => d.CartDetail).WithMany(p => p.HbCarts)
                .HasForeignKey(d => d.CartDetailId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Cart_CartDetail");

            entity.HasOne(d => d.Customer).WithMany(p => p.HbCarts)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Cart_Customer");
        });

        modelBuilder.Entity<HbCartDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_CartDetail");

            entity.ToTable("HB_CartDetail");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CartId).HasColumnName("CartID");
            entity.Property(e => e.CreatedTime).HasPrecision(3);
            entity.Property(e => e.CustomerTypeId).HasColumnName("CustomerTypeID");
            entity.Property(e => e.TicketPriceId).HasColumnName("TicketPriceID");
            entity.Property(e => e.TicketTypeId).HasColumnName("TicketTypeID");
            entity.Property(e => e.UpdateTime).HasPrecision(3);

            entity.HasOne(d => d.TicketPrice).WithMany(p => p.HbCartDetails)
                .HasForeignKey(d => d.TicketPriceId)
                .HasConstraintName("FK_HB_CartDetail_HB_TicketPrice");
        });

        modelBuilder.Entity<HbCauHinh>(entity =>
        {
            entity.ToTable("HB_CauHinh");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.PhanAnhHienTruong)
                .HasDefaultValueSql("((1440))")
                .HasComment("Thời gian đồng bộ dữ liệu phản ánh hiện trường (đơn vị: phút). ");
            entity.Property(e => e.TienIchXungQuanh)
                .HasDefaultValueSql("((1440))")
                .HasComment("Thời gian đồng bộ dữ liệu tiện ích xung quanh (đơn vị: phút). ");
        });

        modelBuilder.Entity<HbCustomer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_User");

            entity.ToTable("HB_Customer");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedById)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("CreatedByID");
            entity.Property(e => e.CreatedTime).HasPrecision(3);
            entity.Property(e => e.Email)
                .HasMaxLength(30)
                .IsFixedLength();
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Password)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.UpdateById).HasColumnName("UpdateByID");
            entity.Property(e => e.UpdateTime).HasPrecision(3);
        });

        modelBuilder.Entity<HbCustomerType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_CustomerType");

            entity.ToTable("HB_CustomerType");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ColorCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedById).HasColumnName("CreatedByID");
            entity.Property(e => e.CreatedTime).HasPrecision(3);
            entity.Property(e => e.Name).HasMaxLength(20);
            entity.Property(e => e.Note).HasMaxLength(100);
            entity.Property(e => e.UpdateById).HasColumnName("UpdateByID");
            entity.Property(e => e.UpdateTime).HasPrecision(3);
        });

        modelBuilder.Entity<HbDiem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_HB_Tram");

            entity.ToTable("HB_Diem");

            entity.HasIndex(e => e.DiaDiem, "NonClusteredIndex-20230425-105731").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DiaDiem).HasMaxLength(200);
            entity.Property(e => e.HoatDong).HasDefaultValueSql("((1))");
            entity.Property(e => e.SoHieu).HasMaxLength(10);
        });

        modelBuilder.Entity<HbDoanhNghiep>(entity =>
        {
            entity.ToTable("HB_DoanhNghiep");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.DiaChi).HasMaxLength(100);
            entity.Property(e => e.DienThoai).HasMaxLength(50);
            entity.Property(e => e.GioiThieu).HasMaxLength(4000);
            entity.Property(e => e.HoatDong).HasDefaultValueSql("((1))");
            entity.Property(e => e.HopThu).HasMaxLength(100);
            entity.Property(e => e.MaSoThue)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Ten).HasMaxLength(100);
            entity.Property(e => e.TrangChu).HasMaxLength(200);
        });

        modelBuilder.Entity<HbEmailConfig>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EmailCon__3214EC07E095C2B7");

            entity.ToTable("HB_EmailConfig");

            entity.Property(e => e.Content).HasMaxLength(400);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DisplayName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Host)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Subject).HasMaxLength(200);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<HbFeedback>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Feedback__3214EC075E16D5F1");

            entity.ToTable("HB_Feedback");

            entity.Property(e => e.Content).HasMaxLength(1000);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FullName).HasMaxLength(100);
            entity.Property(e => e.IsReply)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .IsFixedLength();
            entity.Property(e => e.Title).HasMaxLength(100);
        });

        modelBuilder.Entity<HbFeedbackReplyTemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Feedback__3214EC27D42367BD");

            entity.ToTable("HB_FeedbackReplyTemplate");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Content).HasMaxLength(500);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasPrecision(3);
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasPrecision(3);
        });

        modelBuilder.Entity<HbGopY>(entity =>
        {
            entity.ToTable("HB_GopY");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.DoanhNghiepId).HasColumnName("DoanhNghiepID");
            entity.Property(e => e.NgayGui).HasColumnType("smalldatetime");
            entity.Property(e => e.NoiDung).HasMaxLength(4000);
            entity.Property(e => e.TiepNhan).HasDefaultValueSql("((0))");

            entity.HasOne(d => d.Customer).WithMany(p => p.HbGopies)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_HB_GopY_Customer");

            entity.HasOne(d => d.DoanhNghiep).WithMany(p => p.HbGopies)
                .HasForeignKey(d => d.DoanhNghiepId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_HB_GopY_HB_DoanhNghiep");
        });

        modelBuilder.Entity<HbLichTrinh>(entity =>
        {
            entity.ToTable("HB_LichTrinh");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ChieuDi)
                .HasDefaultValueSql("((1))")
                .HasComment("1 - Chiều đi; 0 - Chiều về");
            entity.Property(e => e.TuyenId).HasColumnName("TuyenID");
            entity.Property(e => e.XeId).HasColumnName("XeID");

            entity.HasOne(d => d.Tuyen).WithMany(p => p.HbLichTrinhs)
                .HasForeignKey(d => d.TuyenId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_HB_LichTrinh_HB_Tuyen");

            entity.HasOne(d => d.Xe).WithMany(p => p.HbLichTrinhs)
                .HasForeignKey(d => d.XeId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_HB_LichTrinh_HB_Xe");
        });

        modelBuilder.Entity<HbNhatKy>(entity =>
        {
            entity.ToTable("HB_NhatKy");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.GhiChu).HasMaxLength(4000);
            entity.Property(e => e.LyDo).HasComment("Lý do trễ chuyến: 0 – Đúng giờ (mặc định); 1 – Tắc đường; 2 – Xe hỏng; 3 – Tai nạn; 4 – Khác");
            entity.Property(e => e.ThoiDiemDen).HasColumnType("smalldatetime");
            entity.Property(e => e.ThoiDiemDi).HasColumnType("smalldatetime");
            entity.Property(e => e.TramId).HasColumnName("TramID");
            entity.Property(e => e.XeId).HasColumnName("XeID");

            entity.HasOne(d => d.Tram).WithMany(p => p.HbNhatKies)
                .HasForeignKey(d => d.TramId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_HB_NhatKy_HB_Tram");

            entity.HasOne(d => d.Xe).WithMany(p => p.HbNhatKies)
                .HasForeignKey(d => d.XeId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_HB_NhatKy_HB_Xe");
        });

        modelBuilder.Entity<HbTicketPrice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_TicketPrice");

            entity.ToTable("HB_TicketPrice");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedById).HasColumnName("CreatedByID");
            entity.Property(e => e.CreatedTime).HasPrecision(3);
            entity.Property(e => e.CustomerTypeId).HasColumnName("CustomerTypeID");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TiketTypeId).HasColumnName("TiketTypeID");
            entity.Property(e => e.UpdateById).HasColumnName("UpdateByID");
            entity.Property(e => e.UpdateTime).HasPrecision(3);

            entity.HasOne(d => d.CustomerType).WithMany(p => p.HbTicketPrices)
                .HasForeignKey(d => d.CustomerTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TicketPrice_CustomerType");

            entity.HasOne(d => d.TiketType).WithMany(p => p.HbTicketPrices)
                .HasForeignKey(d => d.TiketTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TicketPrice_TicketType");
        });

        modelBuilder.Entity<HbTicketType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_TypeOfTicket");

            entity.ToTable("HB_TicketType");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Content).HasMaxLength(200);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedById).HasColumnName("CreatedByID");
            entity.Property(e => e.CreatedTime).HasPrecision(3);
            entity.Property(e => e.ImageId).HasColumnName("ImageID");
            entity.Property(e => e.IsVeTuyen).HasColumnName("Is_VeTuyen");
            entity.Property(e => e.ListEventId)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("ListEventID");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.TypeValue).HasDefaultValueSql("((1))");
            entity.Property(e => e.UpdateById).HasColumnName("UpdateByID");
            entity.Property(e => e.UpdateTime).HasPrecision(3);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HbTuyen>(entity =>
        {
            entity.ToTable("HB_Tuyen");

            entity.HasIndex(e => e.TenTuyen, "NonClusteredIndex-20230425-105755").IsUnique();

            entity.HasIndex(e => e.SoHieu, "NonClusteredIndex-20230425-105840").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.CuLy).HasColumnType("decimal(6, 3)");
            entity.Property(e => e.DiemCuoi).HasMaxLength(100);
            entity.Property(e => e.DiemDau).HasMaxLength(100);
            entity.Property(e => e.HoatDong).HasDefaultValueSql("((1))");
            entity.Property(e => e.KhungGio).HasMaxLength(100);
            entity.Property(e => e.MoTa).HasMaxLength(1000);
            entity.Property(e => e.SoHieu).HasMaxLength(50);
            entity.Property(e => e.SoLuotThich).HasDefaultValueSql("((0))");
            entity.Property(e => e.TanSuat).HasMaxLength(100);
            entity.Property(e => e.TenTuyen).HasMaxLength(100);
        });

        modelBuilder.Entity<HbTuyenDiem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_HB_Tuyen_Tram");

            entity.ToTable("HB_Tuyen_Diem");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ChieuDi)
                .HasDefaultValueSql("((1))")
                .HasComment("1 - Chiều đi; 0 - Chiều về");
            entity.Property(e => e.DiemId).HasColumnName("DiemID");
            entity.Property(e => e.TuyenId).HasColumnName("TuyenID");

            entity.HasOne(d => d.Diem).WithMany(p => p.HbTuyenDiems)
                .HasForeignKey(d => d.DiemId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_HB_Tuyen_Tram_HB_Tram");

            entity.HasOne(d => d.Tuyen).WithMany(p => p.HbTuyenDiems)
                .HasForeignKey(d => d.TuyenId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_HB_Tuyen_Tram_HB_Tuyen");
        });

        modelBuilder.Entity<HbXe>(entity =>
        {
            entity.ToTable("HB_Xe");

            entity.HasIndex(e => e.BienSo, "NonClusteredIndex-20230425-151508").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BienSo)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.DoanhNghiepId).HasColumnName("DoanhNghiepID");
            entity.Property(e => e.HoatDong).HasDefaultValueSql("((1))");
            entity.Property(e => e.MauSon).HasMaxLength(50);
            entity.Property(e => e.NgayKiemDinh).HasColumnType("date");
            entity.Property(e => e.NgayLuuHanh)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("date");
            entity.Property(e => e.NhanHieu).HasMaxLength(50);
            entity.Property(e => e.SoKhung)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SoMay)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TienNghi).HasMaxLength(500);

            entity.HasOne(d => d.DoanhNghiep).WithMany(p => p.HbXes)
                .HasForeignKey(d => d.DoanhNghiepId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_HB_Xe_HB_DoanhNghiep");
        });

        modelBuilder.Entity<Image>(entity =>
        {
            entity.ToTable("Image");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedById).HasColumnName("CreatedByID");
            entity.Property(e => e.CreatedTime).HasPrecision(3);
            entity.Property(e => e.DaiNoiId).HasColumnName("DaiNoiID");
            entity.Property(e => e.EventId).HasColumnName("EventID");
            entity.Property(e => e.IsAvatar)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .IsFixedLength();
            entity.Property(e => e.PlaceId).HasColumnName("PlaceID");
            entity.Property(e => e.ServiceId).HasColumnName("ServiceID");
            entity.Property(e => e.UpdateById).HasColumnName("UpdateByID");
            entity.Property(e => e.UpdateTime).HasPrecision(3);
            entity.Property(e => e.Url)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<InvoiceErrorLog>(entity =>
        {
            entity.ToTable("InvoiceErrorLog");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ErrorMessage).HasMaxLength(1000);
            entity.Property(e => e.Fid)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.OrderId)
                .HasMaxLength(11)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Menu>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_QLCX_Menu");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DisplayOrder).HasDefaultValueSql("((0))");
            entity.Property(e => e.Icon)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IsAdminTool)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('1')")
                .IsFixedLength();
            entity.Property(e => e.IsLeaf)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Name).HasMaxLength(500);
            entity.Property(e => e.ParentId).HasColumnName("ParentID");
            entity.Property(e => e.Path)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MyRole>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.RoleName).HasMaxLength(20);
        });

        modelBuilder.Entity<MyUserRole>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.UserName)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<OrderDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__OrderDet__3214EC0794B0F348");

            entity.ToTable("OrderDetail");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.OrderId)
                .HasMaxLength(17)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<OrderInvoice>(entity =>
        {
            entity.HasKey(e => e.Fid);

            entity.ToTable("OrderInvoice");

            entity.Property(e => e.Fid)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.Address).HasMaxLength(400);
            entity.Property(e => e.BuyerName).HasMaxLength(200);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CusCode)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.OrderId)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.Pattern)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNumber).HasMaxLength(20);
            entity.Property(e => e.Serial)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TaxCode)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<OrderTemp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ordertemp_PrimaryKey");

            entity.ToTable("OrderTemp");

            entity.Property(e => e.Id)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("ID");
            entity.Property(e => e.Address).HasMaxLength(400);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CusCode)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.FullName).HasMaxLength(100);
            entity.Property(e => e.IsForeign)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .IsFixedLength();
            entity.Property(e => e.IsSell)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength();
            entity.Property(e => e.IsUsePosMachine)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.OrderTime)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNumber).HasMaxLength(20);
            entity.Property(e => e.Remark).HasMaxLength(100);
            entity.Property(e => e.TaxNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TotalPrice).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.UniqId)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<PayType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PayType__3214EC07BABE55F1");

            entity.ToTable("PayType");

            entity.Property(e => e.Description).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<PaymentOnlineConfig>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PaymentO__3214EC07303FB76C");

            entity.ToTable("PaymentOnlineConfig");

            entity.Property(e => e.Description).HasMaxLength(100);
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength();
            entity.Property(e => e.TextName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TextValue)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Place>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_HistoricalRelic");

            entity.ToTable("Place");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Address).HasMaxLength(300);
            entity.Property(e => e.CreatedById).HasColumnName("CreatedByID");
            entity.Property(e => e.CreatedTime).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(3000);
            entity.Property(e => e.ImageId).HasColumnName("ImageID");
            entity.Property(e => e.Introduce).HasMaxLength(3000);
            entity.Property(e => e.ShortTitle).HasMaxLength(50);
            entity.Property(e => e.SlideShow)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .IsFixedLength();
            entity.Property(e => e.Title).HasMaxLength(100);
            entity.Property(e => e.TitleEn)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdateById).HasColumnName("UpdateByID");
            entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            entity.Property(e => e.VideoId).HasColumnName("VideoID");
        });

        modelBuilder.Entity<PlaceDaiNoi>(entity =>
        {
            entity.ToTable("PlaceDaiNoi");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedById).HasColumnName("CreatedByID");
            entity.Property(e => e.CreatedTime).HasColumnType("datetime");
            entity.Property(e => e.DisplayOrder).HasDefaultValueSql("((0))");
            entity.Property(e => e.ImageId).HasColumnName("ImageID");
            entity.Property(e => e.Introduce).HasMaxLength(3000);
            entity.Property(e => e.SubTitle).HasMaxLength(100);
            entity.Property(e => e.SubTitleEn).HasMaxLength(100);
            entity.Property(e => e.Title).HasMaxLength(100);
            entity.Property(e => e.TitleEn).HasMaxLength(100);
            entity.Property(e => e.Type).HasDefaultValueSql("((1))");
            entity.Property(e => e.UpdateById).HasColumnName("UpdateByID");
            entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            entity.Property(e => e.VideoId).HasColumnName("VideoID");
        });

        modelBuilder.Entity<PromotionConfig>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Promotio__3214EC27EA09A533");

            entity.ToTable("PromotionConfig");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasPrecision(3);
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.ExtendDate).HasColumnType("smalldatetime");
            entity.Property(e => e.FromDate).HasColumnType("smalldatetime");
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasPrecision(3);
        });

        modelBuilder.Entity<ReceiptConfig>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ReceiptC__3214EC075EEFEA84");

            entity.ToTable("ReceiptConfig");

            entity.Property(e => e.BusinessServiceUrl)
                .HasMaxLength(400)
                .IsUnicode(false);
            entity.Property(e => e.MatKhauDichVu)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MatKhauPhatHanh)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PortalServiceUrl)
                .HasMaxLength(400)
                .IsUnicode(false);
            entity.Property(e => e.PublishServiceUrl)
                .HasMaxLength(400)
                .IsUnicode(false);
            entity.Property(e => e.TaiKhoanDichVu)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TaiKhoanPhatHanh)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ReceiptInfo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ReceiptI__3214EC07834C3F93");

            entity.ToTable("ReceiptInfo");

            entity.Property(e => e.Address).HasMaxLength(500);
            entity.Property(e => e.CusCode)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FullName).HasMaxLength(400);
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TaxNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ReceiptTemplateConfig>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ReceiptT__3214EC07AF2B510A");

            entity.ToTable("ReceiptTemplateConfig");

            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<RequestLogger>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__RequestL__3214EC072A9D220F");

            entity.ToTable("RequestLogger");

            entity.Property(e => e.IpAddress)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.RequestDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.ToTable("Role");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedById).HasColumnName("CreatedByID");
            entity.Property(e => e.CreatedTime).HasPrecision(3);
            entity.Property(e => e.RoleName)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.UpdateById).HasColumnName("UpdateByID");
            entity.Property(e => e.UpdateTime).HasPrecision(3);
        });

        modelBuilder.Entity<Role1>(entity =>
        {
            entity.ToTable("Roles");

            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.NormalizedName).HasMaxLength(256);
        });

        modelBuilder.Entity<RoleClaim>(entity =>
        {
            entity.Property(e => e.RoleId).HasMaxLength(450);

            entity.HasOne(d => d.Role).WithMany(p => p.RoleClaims).HasForeignKey(d => d.RoleId);
        });

        modelBuilder.Entity<Service>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Service__3214EC27B54E4287");

            entity.ToTable("Service");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ImageId).HasColumnName("ImageID");
            entity.Property(e => e.Title).HasMaxLength(200);
            entity.Property(e => e.VideoId).HasColumnName("VideoID");
        });

        modelBuilder.Entity<StatisticElement>(entity =>
        {
            entity.ToTable("StatisticElement");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedById).HasColumnName("CreatedByID");
            entity.Property(e => e.CreatedTime).HasPrecision(3);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.UpdateById).HasColumnName("UpdateByID");
            entity.Property(e => e.UpdateTime).HasPrecision(3);
        });

        modelBuilder.Entity<StatisticTemplate>(entity =>
        {
            entity.ToTable("StatisticTemplate");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedById).HasColumnName("CreatedByID");
            entity.Property(e => e.CreatedTime).HasPrecision(3);
            entity.Property(e => e.IsTrinhDien).HasColumnName("IS_TrinhDien");
            entity.Property(e => e.IstatisticElementId).HasColumnName("IStatisticElementID");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.UpdateById).HasColumnName("UpdateByID");
            entity.Property(e => e.UpdateTime).HasPrecision(3);
        });

        modelBuilder.Entity<StatisticTemplateElement>(entity =>
        {
            entity.ToTable("StatisticTemplate_Element");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ElementId).HasColumnName("ElementID");
            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.TemplateId).HasColumnName("TemplateID");
            entity.Property(e => e.Value).HasMaxLength(100);
        });

        modelBuilder.Entity<StatisticTemplateRole>(entity =>
        {
            entity.ToTable("StatisticTemplate_Role");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.TemplateId).HasColumnName("TemplateID");
        });

        modelBuilder.Entity<SubOrderDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SubOrder__3214EC27FB36327D");

            entity.ToTable("SubOrderDetail");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.OrderId)
                .HasMaxLength(17)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Testing>(entity =>
        {
            entity.ToTable("Testing");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Fullname)
                .HasMaxLength(64)
                .IsFixedLength()
                .HasColumnName("fullname");
            entity.Property(e => e.Password)
                .HasMaxLength(32)
                .IsFixedLength()
                .HasColumnName("password");
            entity.Property(e => e.Username)
                .HasMaxLength(32)
                .IsFixedLength()
                .HasColumnName("username");
        });

        modelBuilder.Entity<TicketCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TicketCa__3214EC27926D0AA0");

            entity.ToTable("TicketCategory");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Description).HasMaxLength(400);
            entity.Property(e => e.Name).HasMaxLength(150);
        });

        modelBuilder.Entity<TicketCounter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TicketCo__3214EC07D287B54F");

            entity.ToTable("TicketCounter");

            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength();
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<TicketDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TicketDe__3214EC27A0C916D7");

            entity.ToTable("TicketDetail");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AdultQuantity).HasDefaultValueSql("((0))");
            entity.Property(e => e.ChildrenQuantity).HasDefaultValueSql("((0))");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.OrderId)
                .HasMaxLength(17)
                .IsUnicode(false);
            entity.Property(e => e.Quantity).HasDefaultValueSql("((0))");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TicketOrder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TicketOr__3214EC27F47F7640");

            entity.ToTable("TicketOrder");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.IsCash)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('1')")
                .IsFixedLength();
            entity.Property(e => e.IsDelete)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .IsFixedLength();
            entity.Property(e => e.IsForeign)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .IsFixedLength();
            entity.Property(e => e.IsSell)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IsUsePosMachine)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IsUsed)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .IsFixedLength();
            entity.Property(e => e.OrderTempId)
                .HasMaxLength(17)
                .IsUnicode(false);
            entity.Property(e => e.PaymentId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PrintType).HasComment("1 là in chung\r\n2 là in riêng");
            entity.Property(e => e.ReceiptId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Remark).HasMaxLength(100);
            entity.Property(e => e.TotalPrice).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TicketPrintLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TicketPrintLog");

            entity.Property(e => e.OrderId)
                .HasMaxLength(17)
                .IsUnicode(false);
            entity.Property(e => e.PrintedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PrintedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TicketScanLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TicketScanLog");

            entity.Property(e => e.Action)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DateUse).HasColumnType("datetime");
            entity.Property(e => e.DeviceId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.IsSuccess)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.OrderId)
                .HasMaxLength(17)
                .IsUnicode(false);
            entity.Property(e => e.Reason).HasMaxLength(100);
        });

        modelBuilder.Entity<TicketTypeDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TicketTy__3214EC27525D5D37");

            entity.ToTable("TicketTypeDetail");

            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<TicketUsedLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TicketUs__3214EC072A9B98F6");

            entity.ToTable("TicketUsedLog");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.IsUsed)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .IsFixedLength();
            entity.Property(e => e.OrderId)
                .HasMaxLength(17)
                .IsUnicode(false);
            entity.Property(e => e.UsedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<UpdatePaymentStatusLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UpdatePa__3214EC07F2E98CA4");

            entity.ToTable("UpdatePaymentStatusLog");

            entity.Property(e => e.AccountNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("accountNo");
            entity.Property(e => e.Amount)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("amount");
            entity.Property(e => e.BankCode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("bankCode");
            entity.Property(e => e.Checksum)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("checksum");
            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.CreatedDate)
                .HasMaxLength(14)
                .IsUnicode(false);
            entity.Property(e => e.Message)
                .HasMaxLength(250)
                .HasColumnName("message");
            entity.Property(e => e.Mobile)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("mobile");
            entity.Property(e => e.MsgType)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("msgType");
            entity.Property(e => e.PayDate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("payDate");
            entity.Property(e => e.QrTrace)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("qrTrace");
            entity.Property(e => e.TxnId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("txnId");
        });

        modelBuilder.Entity<UpdatePaymentStatusLogDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UpdatePa__3214EC07AC8FF999");

            entity.ToTable("UpdatePaymentStatusLogDetail");

            entity.Property(e => e.Amount)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("amount");
            entity.Property(e => e.Ccy)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ccy");
            entity.Property(e => e.Note)
                .HasMaxLength(250)
                .HasColumnName("note");
            entity.Property(e => e.ProductId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("productId");
            entity.Property(e => e.Qty)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("qty");
            entity.Property(e => e.TipAndFee)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("tipAndFee");
        });

        modelBuilder.Entity<UpdateTicketQuantityLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UpdateTi__3214EC07B2FE2DAF");

            entity.ToTable("UpdateTicketQuantityLog");

            entity.Property(e => e.OrderId)
                .HasMaxLength(17)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.NormalizedEmail).HasMaxLength(256);
            entity.Property(e => e.NormalizedUserName).HasMaxLength(256);
            entity.Property(e => e.UserName).HasMaxLength(256);

            entity.HasMany(d => d.Roles).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "UserRole",
                    r => r.HasOne<Role1>().WithMany().HasForeignKey("RoleId"),
                    l => l.HasOne<User>().WithMany().HasForeignKey("UserId"),
                    j =>
                    {
                        j.HasKey("UserId", "RoleId");
                        j.ToTable("UserRoles");
                    });
        });

        modelBuilder.Entity<UserCard>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UserCard__3214EC075B5F9045");

            entity.ToTable("UserCard");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.ApplicationLabel)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.AuthCode)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.CardHolderName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.OrderId)
                .HasMaxLength(17)
                .IsUnicode(false);
            entity.Property(e => e.Pan)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UserCart>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UserCart__3214EC071F4C10E5");

            entity.ToTable("UserCart");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UserCartDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UserCart__3214EC072490F65A");

            entity.ToTable("UserCartDetail");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<UserClaim>(entity =>
        {
            entity.Property(e => e.UserId).HasMaxLength(450);

            entity.HasOne(d => d.User).WithMany(p => p.UserClaims).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<UserLogin>(entity =>
        {
            entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

            entity.Property(e => e.UserId).HasMaxLength(450);

            entity.HasOne(d => d.User).WithMany(p => p.UserLogins).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<UserToken>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

            entity.HasOne(d => d.User).WithMany(p => p.UserTokens).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<Video>(entity =>
        {
            entity.ToTable("Video");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedById).HasColumnName("CreatedByID");
            entity.Property(e => e.CreatedTime).HasPrecision(3);
            entity.Property(e => e.DaiNoiId).HasColumnName("DaiNoiID");
            entity.Property(e => e.EventId).HasColumnName("EventID");
            entity.Property(e => e.PlaceId).HasColumnName("PlaceID");
            entity.Property(e => e.UpdateById).HasColumnName("UpdateByID");
            entity.Property(e => e.UpdateTime).HasPrecision(3);
            entity.Property(e => e.Url)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
