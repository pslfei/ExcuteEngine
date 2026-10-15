

using EngineCore.Models;
using EngineCore.Models.energyanalysis;
using Microsoft.EntityFrameworkCore;


namespace EngineCore;

public partial class WarnContext : DbContext
{

    string conn;
    public WarnContext(string conn)
    {
        this.conn = conn;
    }

    public WarnContext(DbContextOptions<WarnContext> options)
        : base(options)
    {

    }

    public virtual DbSet<clicktime> clicktimecfg { get; set; }
    public virtual DbSet<economiccfg> economiccfgs { get; set; }

    public virtual DbSet<economichistorycfg>? economichistorycfgs { get; set; }

    public virtual DbSet<Sensitivefactorstandard> Sensitivefactorstandards { get; set; }

    public virtual DbSet<CfgVarsystem> CfgVarsystems { get; set; }

    public virtual DbSet<CldConstant> CldConstants { get; set; }

    public virtual DbSet<CldFcblock> CldFcblocks { get; set; }

    public virtual DbSet<CldFcinput> CldFcinputs { get; set; }

    public virtual DbSet<CldFcoutput> CldFcoutputs { get; set; }

    public virtual DbSet<CldFcparameter> CldFcparameters { get; set; }

    public virtual DbSet<CldGraphic> CldGraphics { get; set; }

    public virtual DbSet<CldIref> CldIrefs { get; set; }

    public virtual DbSet<CldOref> CldOrefs { get; set; }

    public virtual DbSet<CldSignal> CldSignals { get; set; }
    public virtual DbSet<Hdl> Hdldata { get; set; }

    public virtual DbSet<CldWarnpoint> CldWarnpoints { get; set; }

    public virtual DbSet<Iomap> Iomaps { get; set; }

    public virtual DbSet<MetaCrossreference> MetaCrossreferences { get; set; }

    public virtual DbSet<MetaDatatype> MetaDatatypes { get; set; }

    public virtual DbSet<MetaDatatypedetail> MetaDatatypedetails { get; set; }

    public virtual DbSet<MetaFcdetail> MetaFcdetails { get; set; }

    public virtual DbSet<MetaFcmaster> MetaFcmasters { get; set; }

    public virtual DbSet<MetaFcmasterVersion> MetaFcmasterVersions { get; set; }

    public virtual DbSet<MetaSymboldetail> MetaSymboldetails { get; set; }

    public virtual DbSet<MetaSymbolexchange> MetaSymbolexchanges { get; set; }

    public virtual DbSet<MetaSymbolmaster> MetaSymbolmasters { get; set; }

    public virtual DbSet<PrjController> PrjControllers { get; set; }

    public virtual DbSet<PrjDocument> PrjDocuments { get; set; }

    public virtual DbSet<PrjNetwork> PrjNetworks { get; set; }

    public virtual DbSet<PrjProject> PrjProjects { get; set; }

    public virtual DbSet<PrjSheet> PrjSheets { get; set; }

    public virtual DbSet<PrjSystem> PrjSystems { get; set; }

    public virtual DbSet<PrjUnit> PrjUnits { get; set; }

    public virtual DbSet<T1> T1s { get; set; }

    public virtual DbSet<TempControlleruserlibraryname> TempControlleruserlibrarynames { get; set; }

    public virtual DbSet<TempFunctionnamechanged> TempFunctionnamechangeds { get; set; }

    public virtual DbSet<Temperaturepoint> Temperaturepoints { get; set; }

    public virtual DbSet<Viewdcspoint> Viewdcspoints { get; set; }

    public virtual DbSet<Viewpoint> Viewpoints { get; set; }

    public virtual DbSet<Viewwarnpoint> Viewwarnpoints { get; set; }

    public virtual DbSet<Whereusedalgname> Whereusedalgnames { get; set; }

    public virtual DbSet<Whereusediref> Whereusedirefs { get; set; }

    public virtual DbSet<Whereusedoref> Whereusedorefs { get; set; }

    public virtual DbSet<Whereusedvarsystem> Whereusedvarsystems { get; set; }


    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    ////=>optionsBuilder.UseMySql("server=localhost;port=3306;user=YOUR_USER;password=YOUR_PASSWORD;database=warn_dcs01", ServerVersion.Parse("5.7.30-mysql"));
    //{
    //    optionsBuilder.UseMySql(conn, ServerVersion.Parse("5.7.30-mysql"));
    //}

    public virtual DbSet<CldIndexcondition> CldIndexconditions { get; set; }
    public virtual DbSet<CldIndexconditioncompare> CldIndexconditionscompare { get; set; }
    public virtual DbSet<Xunyouhis> XunYoudata { get; set; }
    public virtual DbSet<WarnAlarm> WarnAlarms { get; set; }

    public virtual DbSet<FaultDiagnosis> FaultDiagnosis { get; set; }

    public virtual DbSet<Troubleshooting> Troubleshooting { get; set; }

    public virtual DbSet<parawarns> ParaWarns { get; set; }


    public virtual DbSet<Agccontrol> agccontrol { get; set; }

    public virtual DbSet<Agccontrolinfocfg> agccontrolinfocfg { get; set; }

    public virtual DbSet<Agcmonthinfocfg> agcmonthinfocfg { get; set; }

    public virtual DbSet<Controlcfg> controlcfg { get; set; }

    public virtual DbSet<Controlinfocfg> controlinfocfg { get; set; }

    public virtual DbSet<Dehcontrol> dehcontrol { get; set; }

    public virtual DbSet<Dehcontrolinfocfg> dehcontrolinfocfg { get; set; }


    public virtual DbSet<Devicehealthy> devicehealthy { get; set; }

    public virtual DbSet<Hdl> hdl { get; set; }

    public virtual DbSet<Healthy> healthy { get; set; }

    public virtual DbSet<Qhl> qhl { get; set; }

    public virtual DbSet<Rmrz> rmrz { get; set; }

    public virtual DbSet<weighteddata> weighteddatum { get; set; }
    public virtual DbSet<Controlweigh> controlweighcfg { get; set; }

    public virtual DbSet<warnpointoperationguide> warnpointoperationguide { get; set; }

    public virtual DbSet<deviceruncfg> deviceruncfg { get; set; }

    public virtual DbSet<Pointshow> Pointshows { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //=>optionsBuilder.UseMySql("server=localhost;port=3306;user=YOUR_USER;password=YOUR_PASSWORD;database=warn_dcs01", ServerVersion.Parse("5.7.30-mysql"));
    {
        optionsBuilder.UseMySql(conn, ServerVersion.Parse("5.7.30-mysql"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8_general_ci")
            .HasCharSet("utf8");



        modelBuilder.Entity<deviceruncfg>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("deviceruncfg")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.Id).HasColumnType("int(20)");
        });

        modelBuilder.Entity<warnpointoperationguide>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("warnpointoperationguide")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.Id).HasColumnType("int(11)");
        });

        modelBuilder.Entity<Sensitivefactorstandard>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("sensitivefactorstandards")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.Id).HasColumnType("int(11)");
        });
        modelBuilder.Entity<Controlweigh>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("systemweigh")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.Id).HasColumnType("int(11)");
        });
        modelBuilder.Entity<clicktime>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("clicktime")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.Id).HasColumnType("int(11)");
        });

        modelBuilder.Entity<economiccfg>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("economiccfg")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.Id).HasColumnType("int(11)");
        });



        modelBuilder.Entity<economichistorycfg>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("economichistorycfg")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.Id).HasColumnType("int(11)");
        });


        modelBuilder.Entity<WarnAlarm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("warnalarm")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.Id).HasColumnType("int(11)");
        });


        modelBuilder.Entity<FaultDiagnosis>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("faultdiagnosis")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.Id).HasColumnType("int(11)");
        });



        modelBuilder.Entity<Agccontrol>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("agccontrol")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.Id).HasColumnType("int(11)");
        });


        modelBuilder.Entity<Agccontrolinfocfg>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("agccontrolinfocfg")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.Id).HasColumnType("int(11)");
        });

        modelBuilder.Entity<Agcmonthinfocfg>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("agcmonthinfocfg")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.Id).HasColumnType("int(11)");
        });


        modelBuilder.Entity<Controlcfg>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("controlcfg")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.Id).HasColumnType("int(11)");
        });

        modelBuilder.Entity<Hdl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("hdl")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.Id).HasColumnType("int(11)");
        });
        modelBuilder.Entity<weighteddata>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("weighteddata")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.Id).HasColumnType("int(11)");
        });
        modelBuilder.Entity<Controlinfocfg>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("controlinfocfg")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.Id).HasColumnType("int(11)");
        });


        modelBuilder.Entity<Dehcontrol>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("dehcontrol")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.Id).HasColumnType("int(11)");
        });


        modelBuilder.Entity<Dehcontrolinfocfg>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("dehcontrolinfocfg")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.Id).HasColumnType("int(11)");
        });



        modelBuilder.Entity<Troubleshooting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("troubleshooting")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.Id).HasColumnType("int(11)");
            entity.Property(e => e.IsAlarmSuspended)
                .HasColumnType("int(11)")
                .HasDefaultValue(0);
        });



        modelBuilder.Entity<parawarns>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("parawarns")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.Id).HasColumnType("int(11)");
        });

        modelBuilder.Entity<CfgVarsystem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("cfg_varsystem");

            entity.HasIndex(e => e.Id, "ID");

            entity.HasIndex(e => e.Kkscode, "KKSCode");

            entity.HasIndex(e => e.Prj_Controller_ID, "Prj_Controller_ID");

            entity.HasIndex(e => e.Prj_System_ID, "Prj_System_ID");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("ID");
            entity.Property(e => e.AlarmPriority)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)");
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.DefaultValue).HasMaxLength(250);
            entity.Property(e => e.ForceValue).HasMaxLength(50);
            entity.Property(e => e.HighAlarm1Priority)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)");
            entity.Property(e => e.HighAlarm2Priority)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)");
            entity.Property(e => e.HighAlarm3Priority)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)");
            entity.Property(e => e.HighAlarm4Priority)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)");
            entity.Property(e => e.HighAlarmLimit1Value).HasDefaultValueSql("'0'");
            entity.Property(e => e.HighAlarmLimit2Value).HasDefaultValueSql("'0'");
            entity.Property(e => e.HighAlarmLimit3Value).HasDefaultValueSql("'0'");
            entity.Property(e => e.HighAlarmLimit4Value).HasDefaultValueSql("'0'");
            entity.Property(e => e.HighAlarmLimitUserValue)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)");
            entity.Property(e => e.HighAlarmUserPriority)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)");
            entity.Property(e => e.IomapDirection)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("IOMapDirection");
            entity.Property(e => e.IomapName)
                .HasMaxLength(50)
                .HasColumnName("IOMapName");
            entity.Property(e => e.Iotype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("IOType");
            entity.Property(e => e.Kkscode)
                .HasMaxLength(50)
                .HasColumnName("KKSCode");
            entity.Property(e => e.LowAlarm1Priority)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)");
            entity.Property(e => e.LowAlarm2Priority)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)");
            entity.Property(e => e.LowAlarm3Priority)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)");
            entity.Property(e => e.LowAlarm4Priority)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)");
            entity.Property(e => e.LowAlarmLimit1Value).HasDefaultValueSql("'0'");
            entity.Property(e => e.LowAlarmLimit2Value).HasDefaultValueSql("'0'");
            entity.Property(e => e.LowAlarmLimit3Value).HasDefaultValueSql("'0'");
            entity.Property(e => e.LowAlarmLimit4Value).HasDefaultValueSql("'0'");
            entity.Property(e => e.LowAlarmLimitUserValue)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)");
            entity.Property(e => e.LowAlarmUserPriority)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)");
            entity.Property(e => e.MaximunScale).HasMaxLength(50);
            entity.Property(e => e.MinimumScale).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Opcaddress)
                .HasMaxLength(150)
                .HasColumnName("OPCAddress");
            entity.Property(e => e.Prj_Controller_ID)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("Prj_Controller_ID");
            entity.Property(e => e.Prj_System_ID)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("Prj_System_ID");
            entity.Property(e => e.StatusChecking)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)");
            entity.Property(e => e.Unit).HasMaxLength(50);
        });

        modelBuilder.Entity<CldIndexcondition>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("cld_indexcondition");

            entity.HasIndex(e => e.Id, "ID");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("ID");
            entity.Property(e => e.Acpywd)
                .HasDefaultValueSql("'0'")
                .HasComment("A侧排烟温度")
                .HasColumnName("acpywd");
            entity.Property(e => e.Agmjml)
                .HasDefaultValueSql("'0'")
                .HasComment("A给煤机煤量")
                .HasColumnName("agmjml");
            entity.Property(e => e.Bcpywd)
                .HasDefaultValueSql("'0'")
                .HasComment("B侧排烟温度")
                .HasColumnName("bcpywd");
            entity.Property(e => e.Bgmjml)
                .HasDefaultValueSql("'0'")
                .HasComment("B给煤机煤量")
                .HasColumnName("bgmjml");
            entity.Property(e => e.Cgmjml)
                .HasDefaultValueSql("'0'")
                .HasComment("C给煤机煤量")
                .HasColumnName("cgmjml");
            entity.Property(e => e.Dgmjml)
                .HasDefaultValueSql("'0'")
                .HasComment("D给煤机煤量")
                .HasColumnName("dgmjml");
            entity.Property(e => e.Dwfrl)
                .HasDefaultValueSql("'0'")
                .HasComment("低位发热量")
                .HasColumnName("dwfrl");
            entity.Property(e => e.Dwfrlqj)
                .HasMaxLength(20)
                .HasComment("低位发热量区间")
                .HasColumnName("dwfrlqj");
            entity.Property(e => e.Dynqqxhsjszg1wd)
                .HasDefaultValueSql("'0'")
                .HasComment("低压凝汽器循环水进水支管1温度")
                .HasColumnName("dynqqxhsjszg1wd");
            entity.Property(e => e.Dynqqxhsjszg1yl)
                .HasDefaultValueSql("'0'")
                .HasComment("低压凝汽器循环水进水支管1压力")
                .HasColumnName("dynqqxhsjszg1yl");
            entity.Property(e => e.Dynqqxhsjszg2wd)
                .HasDefaultValueSql("'0'")
                .HasComment("低压凝汽器循环水进水支管2温度")
                .HasColumnName("dynqqxhsjszg2wd");
            entity.Property(e => e.Dynqqxhsjszg2yl)
                .HasDefaultValueSql("'0'")
                .HasComment("低压凝汽器循环水进水支管2压力")
                .HasColumnName("dynqqxhsjszg2yl");
            entity.Property(e => e.Egmjml)
                .HasDefaultValueSql("'0'")
                .HasComment("E给煤机煤量")
                .HasColumnName("egmjml");
            entity.Property(e => e.Fgmjml)
                .HasDefaultValueSql("'0'")
                .HasComment("F给煤机煤量")
                .HasColumnName("fgmjml");
            entity.Property(e => e.Fh)
                .HasDefaultValueSql("'0'")
                .HasComment("负荷")
                .HasColumnName("fh");
            entity.Property(e => e.Fhhtl)
                .HasDefaultValueSql("'0'")
                .HasComment("飞灰含碳量")
                .HasColumnName("fhhtl");
            entity.Property(e => e.Fhqj)
                .HasMaxLength(20)
                .HasComment("负荷区间")
                .HasColumnName("fhqj");
            entity.Property(e => e.Fxs)
                .HasDefaultValueSql("'0'")
                .HasComment("分析水")
                .HasColumnName("fxs");
            entity.Property(e => e.Gksjfw)
                .HasMaxLength(50)
                .HasComment("工况时间范围")
                .HasColumnName("gksjfw");
            entity.Property(e => e.Glxl)
                .HasDefaultValueSql("'0'")
                .HasComment("锅炉效率")
                .HasColumnName("glxl");
            entity.Property(e => e.Glxlhc)
                .HasDefaultValueSql("'0'")
                .HasComment("锅炉效率耗差")
                .HasColumnName("glxlhc");
            entity.Property(e => e.Grd)
                .HasDefaultValueSql("'0'")
                .HasComment("过热度")
                .HasColumnName("grd");
            entity.Property(e => e.Grqycejjwsll)
                .HasDefaultValueSql("'0'")
                .HasComment("过热器右侧二级减温水流量")
                .HasColumnName("grqycejjwsll");
            entity.Property(e => e.Grqycyjjwsll)
                .HasDefaultValueSql("'0'")
                .HasComment("过热器右侧一级减温水流量")
                .HasColumnName("grqycyjjwsll");
            entity.Property(e => e.Grqyqdb5)
                .HasDefaultValueSql("'0'")
                .HasComment("过热器烟气挡板5")
                .HasColumnName("grqyqdb5");
            entity.Property(e => e.Grqyqdb6)
                .HasDefaultValueSql("'0'")
                .HasComment("过热器烟气挡板6")
                .HasColumnName("grqyqdb6");
            entity.Property(e => e.Grqyqdb7)
                .HasDefaultValueSql("'0'")
                .HasComment("过热器烟气挡板7")
                .HasColumnName("grqyqdb7");
            entity.Property(e => e.Grqyqdb8)
                .HasDefaultValueSql("'0'")
                .HasComment("过热器烟气挡板8")
                .HasColumnName("grqyqdb8");
            entity.Property(e => e.Grqzcejjwsll)
                .HasDefaultValueSql("'0'")
                .HasComment("过热器左侧二级减温水流量")
                .HasColumnName("grqzcejjwsll");
            entity.Property(e => e.Grqzcyjjwsll)
                .HasDefaultValueSql("'0'")
                .HasComment("过热器左侧一级减温水流量")
                .HasColumnName("grqzcyjjwsll");
            entity.Property(e => e.Hf)
                .HasDefaultValueSql("'0'")
                .HasComment("灰分")
                .HasColumnName("hf");
            entity.Property(e => e.Hff)
                .HasDefaultValueSql("'0'")
                .HasComment("挥发分")
                .HasColumnName("hff");
            entity.Property(e => e.Hjwd)
                .HasDefaultValueSql("'0'")
                .HasComment("环境温度")
                .HasColumnName("hjwd");
            entity.Property(e => e.Hjwdqj)
                .HasMaxLength(20)
                .HasComment("环境温度区间")
                .HasColumnName("hjwdqj");
            entity.Property(e => e.Hqysecfll)
                .HasDefaultValueSql("'0'")
                .HasComment("后墙右上二次风流量")
                .HasColumnName("hqysecfll");
            entity.Property(e => e.Hqysrjfll)
                .HasDefaultValueSql("'0'")
                .HasComment("后墙右上燃烬风流量")
                .HasColumnName("hqysrjfll");
            entity.Property(e => e.Hqyxecfll)
                .HasDefaultValueSql("'0'")
                .HasComment("后墙右下二次风流量")
                .HasColumnName("hqyxecfll");
            entity.Property(e => e.Hqyxrjfll)
                .HasDefaultValueSql("'0'")
                .HasComment("后墙右下燃烬风流量")
                .HasColumnName("hqyxrjfll");
            entity.Property(e => e.Hqyzecfll)
                .HasDefaultValueSql("'0'")
                .HasComment("后墙右中二次风流量")
                .HasColumnName("hqyzecfll");
            entity.Property(e => e.Hqzsecfll)
                .HasDefaultValueSql("'0'")
                .HasComment("后墙左上二次风流量")
                .HasColumnName("hqzsecfll");
            entity.Property(e => e.Hqzsrjfll)
                .HasDefaultValueSql("'0'")
                .HasComment("后墙左上燃烬风流量")
                .HasColumnName("hqzsrjfll");
            entity.Property(e => e.Hqzxecfll)
                .HasDefaultValueSql("'0'")
                .HasComment("后墙左下二次风流量")
                .HasColumnName("hqzxecfll");
            entity.Property(e => e.Hqzxrjfll)
                .HasDefaultValueSql("'0'")
                .HasComment("后墙左下燃烬风流量")
                .HasColumnName("hqzxrjfll");
            entity.Property(e => e.Hqzzecfll)
                .HasDefaultValueSql("'0'")
                .HasComment("后墙左中二次风流量")
                .HasColumnName("hqzzecfll");
            entity.Property(e => e.Hypz)
                .HasDefaultValueSql("'0'")
                .HasComment("滑压偏置")
                .HasColumnName("hypz");
            entity.Property(e => e.KyqAckyqhyl)
                .HasDefaultValueSql("'0'")
                .HasComment("空预器A出口烟气含氧量")
                .HasColumnName("kyqAckyqhyl");
            entity.Property(e => e.KyqBckyqhyl)
                .HasDefaultValueSql("'0'")
                .HasComment("空预器B出口烟气含氧量")
                .HasColumnName("kyqBckyqhyl");
            entity.Property(e => e.Lyczrqjwsll)
                .HasDefaultValueSql("'0'")
                .HasComment("#1炉右侧再热器减温水流量")
                .HasColumnName("lyczrqjwsll");
            entity.Property(e => e.Lzczrqjwsll)
                .HasDefaultValueSql("'0'")
                .HasComment("#1炉左侧再热器减温水流量")
                .HasColumnName("lzczrqjwsll");
            entity.Property(e => e.Lzhtl)
                .HasDefaultValueSql("'0'")
                .HasComment("炉渣含碳量")
                .HasColumnName("lzhtl");
            entity.Property(e => e.Nqqby)
                .HasDefaultValueSql("'0'")
                .HasComment("凝汽器背压")
                .HasColumnName("nqqby");
            entity.Property(e => e.Pywd)
                .HasDefaultValueSql("'0'")
                .HasComment("排烟温度")
                .HasColumnName("pywd");
            entity.Property(e => e.Qjrh)
                .HasDefaultValueSql("'0'")
                .HasComment("汽机热耗")
                .HasColumnName("qjrh");
            entity.Property(e => e.Qjrhhc)
                .HasDefaultValueSql("'0'")
                .HasComment("汽机热耗耗差")
                .HasColumnName("qjrhhc");
            entity.Property(e => e.Qqysecfll)
                .HasDefaultValueSql("'0'")
                .HasComment("前墙右上二次风流量")
                .HasColumnName("qqysecfll");
            entity.Property(e => e.Qqysrjfll)
                .HasDefaultValueSql("'0'")
                .HasComment("前墙右上燃烬风流量")
                .HasColumnName("qqysrjfll");
            entity.Property(e => e.Qqyxecfll)
                .HasDefaultValueSql("'0'")
                .HasComment("前墙右下二次风流量")
                .HasColumnName("qqyxecfll");
            entity.Property(e => e.Qqyxrjfll)
                .HasDefaultValueSql("'0'")
                .HasComment("前墙右下燃烬风流量")
                .HasColumnName("qqyxrjfll");
            entity.Property(e => e.Qqyzecfll)
                .HasDefaultValueSql("'0'")
                .HasComment("前墙右中二次风流量")
                .HasColumnName("qqyzecfll");
            entity.Property(e => e.Qqzsecfll)
                .HasDefaultValueSql("'0'")
                .HasComment("前墙左上二次风流量")
                .HasColumnName("qqzsecfll");
            entity.Property(e => e.Qqzsrjfll)
                .HasDefaultValueSql("'0'")
                .HasComment("前墙左上燃烬风流量")
                .HasColumnName("qqzsrjfll");
            entity.Property(e => e.Qqzxecfll)
                .HasDefaultValueSql("'0'")
                .HasComment("前墙左下二次风流量")
                .HasColumnName("qqzxecfll");
            entity.Property(e => e.Qqzxrjfll)
                .HasDefaultValueSql("'0'")
                .HasComment("前墙左下燃烬风流量")
                .HasColumnName("qqzxrjfll");
            entity.Property(e => e.Qqzzecfll)
                .HasDefaultValueSql("'0'")
                .HasComment("前墙左中二次风流量")
                .HasColumnName("qqzzecfll");
            entity.Property(e => e.Qsf)
                .HasDefaultValueSql("'0'")
                .HasComment("全水分")
                .HasColumnName("qsf");
            entity.Property(e => e.Remarks)
                .HasComment("备注")
                .HasColumnType("text")
                .HasColumnName("remarks");
            entity.Property(e => e.Rll)
                .HasDefaultValueSql("'0'")
                .HasComment("燃料量")
                .HasColumnName("rll");
            entity.Property(e => e.Sfjadykd)
                .HasDefaultValueSql("'0'")
                .HasComment("送风机A动叶开度")
                .HasColumnName("sfjadykd");
            entity.Property(e => e.Sfjbdykd)
                .HasDefaultValueSql("'0'")
                .HasComment("送风机B动叶开度")
                .HasColumnName("sfjbdykd");
            entity.Property(e => e.Sfwd)
                .HasDefaultValueSql("'0'")
                .HasComment("送风温度")
                .HasColumnName("sfwd");
            entity.Property(e => e.Sj)
                .HasComment("指标数据时间")
                .HasColumnType("datetime")
                .HasColumnName("sj");
            entity.Property(e => e.Smb)
                .HasDefaultValueSql("'0'")
                .HasComment("水煤比")
                .HasColumnName("smb");
            entity.Property(e => e.Type)
                .HasComment("0：标杆工况；1：专家工况")
                .HasColumnType("int(11)")
                .HasColumnName("type");
            entity.Property(e => e.Yl)
                .HasDefaultValueSql("'0'")
                .HasComment("氧量")
                .HasColumnName("yl");
            entity.Property(e => e.Ylsdz)
                .HasDefaultValueSql("'0'")
                .HasComment("氧量设定值")
                .HasColumnName("ylsdz");
            entity.Property(e => e.Zfl)
                .HasDefaultValueSql("'0'")
                .HasComment("总风量")
                .HasColumnName("zfl");
            entity.Property(e => e.Zgsll)
                .HasDefaultValueSql("'0'")
                .HasComment("主给水流量")
                .HasColumnName("zgsll");
            entity.Property(e => e.Zhhc)
                .HasDefaultValueSql("'0'")
                .HasComment("综合耗差")
                .HasColumnName("zhhc");
            entity.Property(e => e.Zkbadl)
                .HasDefaultValueSql("'0'")
                .HasComment("真空泵A电流")
                .HasColumnName("zkbadl");
            entity.Property(e => e.Zkbbdl)
                .HasDefaultValueSql("'0'")
                .HasComment("真空泵B电流")
                .HasColumnName("zkbbdl");
            entity.Property(e => e.Zkbcdl)
                .HasDefaultValueSql("'0'")
                .HasComment("真空泵C电流")
                .HasColumnName("zkbcdl");
            entity.Property(e => e.Zrqyqdb1)
                .HasDefaultValueSql("'0'")
                .HasComment("再热器烟气挡板1")
                .HasColumnName("zrqyqdb1");
            entity.Property(e => e.Zrqyqdb2)
                .HasDefaultValueSql("'0'")
                .HasComment("再热器烟气挡板2")
                .HasColumnName("zrqyqdb2");
            entity.Property(e => e.Zrqyqdb3)
                .HasDefaultValueSql("'0'")
                .HasComment("再热器烟气挡板3")
                .HasColumnName("zrqyqdb3");
            entity.Property(e => e.Zrqyqdb4)
                .HasDefaultValueSql("'0'")
                .HasComment("再热器烟气挡板4")
                .HasColumnName("zrqyqdb4");
            entity.Property(e => e.Zrzqwd)
                .HasDefaultValueSql("'0'")
                .HasComment("再热蒸汽温度")
                .HasColumnName("zrzqwd");
            entity.Property(e => e.Zrzqyl)
                .HasDefaultValueSql("'0'")
                .HasComment("再热蒸汽压力")
                .HasColumnName("zrzqyl");
            entity.Property(e => e.Zzqwd)
                .HasDefaultValueSql("'0'")
                .HasComment("主蒸汽温度")
                .HasColumnName("zzqwd");
            entity.Property(e => e.Zzqyl)
                .HasDefaultValueSql("'0'")
                .HasComment("主蒸汽压力")
                .HasColumnName("zzqyl");
            entity.Property(e => e.comparetime)
                .HasDefaultValueSql("'0'")
                .HasComment("标杆时间")
                .HasColumnName("comparetime");
        });
        modelBuilder.Entity<CldIndexconditioncompare>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("cld_indexcondition_compare");

            entity.HasIndex(e => e.Id, "ID");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("ID");
            entity.Property(e => e.Acpywd)
                .HasDefaultValueSql("'0'")
                .HasComment("A侧排烟温度")
                .HasColumnName("acpywd");
            entity.Property(e => e.Agmjml)
                .HasDefaultValueSql("'0'")
                .HasComment("A给煤机煤量")
                .HasColumnName("agmjml");
            entity.Property(e => e.Bcpywd)
                .HasDefaultValueSql("'0'")
                .HasComment("B侧排烟温度")
                .HasColumnName("bcpywd");
            entity.Property(e => e.Bgmjml)
                .HasDefaultValueSql("'0'")
                .HasComment("B给煤机煤量")
                .HasColumnName("bgmjml");
            entity.Property(e => e.Cgmjml)
                .HasDefaultValueSql("'0'")
                .HasComment("C给煤机煤量")
                .HasColumnName("cgmjml");
            entity.Property(e => e.Dgmjml)
                .HasDefaultValueSql("'0'")
                .HasComment("D给煤机煤量")
                .HasColumnName("dgmjml");
            entity.Property(e => e.Dwfrl)
                .HasDefaultValueSql("'0'")
                .HasComment("低位发热量")
                .HasColumnName("dwfrl");
            entity.Property(e => e.Dwfrlqj)
                .HasMaxLength(20)
                .HasComment("低位发热量区间")
                .HasColumnName("dwfrlqj");
            entity.Property(e => e.Dynqqxhsjszg1wd)
                .HasDefaultValueSql("'0'")
                .HasComment("低压凝汽器循环水进水支管1温度")
                .HasColumnName("dynqqxhsjszg1wd");
            entity.Property(e => e.Dynqqxhsjszg1yl)
                .HasDefaultValueSql("'0'")
                .HasComment("低压凝汽器循环水进水支管1压力")
                .HasColumnName("dynqqxhsjszg1yl");
            entity.Property(e => e.Dynqqxhsjszg2wd)
                .HasDefaultValueSql("'0'")
                .HasComment("低压凝汽器循环水进水支管2温度")
                .HasColumnName("dynqqxhsjszg2wd");
            entity.Property(e => e.Dynqqxhsjszg2yl)
                .HasDefaultValueSql("'0'")
                .HasComment("低压凝汽器循环水进水支管2压力")
                .HasColumnName("dynqqxhsjszg2yl");
            entity.Property(e => e.Egmjml)
                .HasDefaultValueSql("'0'")
                .HasComment("E给煤机煤量")
                .HasColumnName("egmjml");
            entity.Property(e => e.Fgmjml)
                .HasDefaultValueSql("'0'")
                .HasComment("F给煤机煤量")
                .HasColumnName("fgmjml");
            entity.Property(e => e.Fh)
                .HasDefaultValueSql("'0'")
                .HasComment("负荷")
                .HasColumnName("fh");
            entity.Property(e => e.Fhhtl)
                .HasDefaultValueSql("'0'")
                .HasComment("飞灰含碳量")
                .HasColumnName("fhhtl");
            entity.Property(e => e.Fhqj)
                .HasMaxLength(20)
                .HasComment("负荷区间")
                .HasColumnName("fhqj");
            entity.Property(e => e.Fxs)
                .HasDefaultValueSql("'0'")
                .HasComment("分析水")
                .HasColumnName("fxs");
            entity.Property(e => e.Gksjfw)
                .HasMaxLength(50)
                .HasComment("工况时间范围")
                .HasColumnName("gksjfw");
            entity.Property(e => e.Glxl)
                .HasDefaultValueSql("'0'")
                .HasComment("锅炉效率")
                .HasColumnName("glxl");
            entity.Property(e => e.Glxlhc)
                .HasDefaultValueSql("'0'")
                .HasComment("锅炉效率耗差")
                .HasColumnName("glxlhc");
            entity.Property(e => e.Grd)
                .HasDefaultValueSql("'0'")
                .HasComment("过热度")
                .HasColumnName("grd");
            entity.Property(e => e.Grqycejjwsll)
                .HasDefaultValueSql("'0'")
                .HasComment("过热器右侧二级减温水流量")
                .HasColumnName("grqycejjwsll");
            entity.Property(e => e.Grqycyjjwsll)
                .HasDefaultValueSql("'0'")
                .HasComment("过热器右侧一级减温水流量")
                .HasColumnName("grqycyjjwsll");
            entity.Property(e => e.Grqyqdb5)
                .HasDefaultValueSql("'0'")
                .HasComment("过热器烟气挡板5")
                .HasColumnName("grqyqdb5");
            entity.Property(e => e.Grqyqdb6)
                .HasDefaultValueSql("'0'")
                .HasComment("过热器烟气挡板6")
                .HasColumnName("grqyqdb6");
            entity.Property(e => e.Grqyqdb7)
                .HasDefaultValueSql("'0'")
                .HasComment("过热器烟气挡板7")
                .HasColumnName("grqyqdb7");
            entity.Property(e => e.Grqyqdb8)
                .HasDefaultValueSql("'0'")
                .HasComment("过热器烟气挡板8")
                .HasColumnName("grqyqdb8");
            entity.Property(e => e.Grqzcejjwsll)
                .HasDefaultValueSql("'0'")
                .HasComment("过热器左侧二级减温水流量")
                .HasColumnName("grqzcejjwsll");
            entity.Property(e => e.Grqzcyjjwsll)
                .HasDefaultValueSql("'0'")
                .HasComment("过热器左侧一级减温水流量")
                .HasColumnName("grqzcyjjwsll");
            entity.Property(e => e.Hf)
                .HasDefaultValueSql("'0'")
                .HasComment("灰分")
                .HasColumnName("hf");
            entity.Property(e => e.Hff)
                .HasDefaultValueSql("'0'")
                .HasComment("挥发分")
                .HasColumnName("hff");
            entity.Property(e => e.Hjwd)
                .HasDefaultValueSql("'0'")
                .HasComment("环境温度")
                .HasColumnName("hjwd");
            entity.Property(e => e.Hjwdqj)
                .HasMaxLength(20)
                .HasComment("环境温度区间")
                .HasColumnName("hjwdqj");
            entity.Property(e => e.Hqysecfll)
                .HasDefaultValueSql("'0'")
                .HasComment("后墙右上二次风流量")
                .HasColumnName("hqysecfll");
            entity.Property(e => e.Hqysrjfll)
                .HasDefaultValueSql("'0'")
                .HasComment("后墙右上燃烬风流量")
                .HasColumnName("hqysrjfll");
            entity.Property(e => e.Hqyxecfll)
                .HasDefaultValueSql("'0'")
                .HasComment("后墙右下二次风流量")
                .HasColumnName("hqyxecfll");
            entity.Property(e => e.Hqyxrjfll)
                .HasDefaultValueSql("'0'")
                .HasComment("后墙右下燃烬风流量")
                .HasColumnName("hqyxrjfll");
            entity.Property(e => e.Hqyzecfll)
                .HasDefaultValueSql("'0'")
                .HasComment("后墙右中二次风流量")
                .HasColumnName("hqyzecfll");
            entity.Property(e => e.Hqzsecfll)
                .HasDefaultValueSql("'0'")
                .HasComment("后墙左上二次风流量")
                .HasColumnName("hqzsecfll");
            entity.Property(e => e.Hqzsrjfll)
                .HasDefaultValueSql("'0'")
                .HasComment("后墙左上燃烬风流量")
                .HasColumnName("hqzsrjfll");
            entity.Property(e => e.Hqzxecfll)
                .HasDefaultValueSql("'0'")
                .HasComment("后墙左下二次风流量")
                .HasColumnName("hqzxecfll");
            entity.Property(e => e.Hqzxrjfll)
                .HasDefaultValueSql("'0'")
                .HasComment("后墙左下燃烬风流量")
                .HasColumnName("hqzxrjfll");
            entity.Property(e => e.Hqzzecfll)
                .HasDefaultValueSql("'0'")
                .HasComment("后墙左中二次风流量")
                .HasColumnName("hqzzecfll");
            entity.Property(e => e.Hypz)
                .HasDefaultValueSql("'0'")
                .HasComment("滑压偏置")
                .HasColumnName("hypz");
            entity.Property(e => e.KyqAckyqhyl)
                .HasDefaultValueSql("'0'")
                .HasComment("空预器A出口烟气含氧量")
                .HasColumnName("kyqAckyqhyl");
            entity.Property(e => e.KyqBckyqhyl)
                .HasDefaultValueSql("'0'")
                .HasComment("空预器B出口烟气含氧量")
                .HasColumnName("kyqBckyqhyl");
            entity.Property(e => e.Lyczrqjwsll)
                .HasDefaultValueSql("'0'")
                .HasComment("#1炉右侧再热器减温水流量")
                .HasColumnName("lyczrqjwsll");
            entity.Property(e => e.Lzczrqjwsll)
                .HasDefaultValueSql("'0'")
                .HasComment("#1炉左侧再热器减温水流量")
                .HasColumnName("lzczrqjwsll");
            entity.Property(e => e.Lzhtl)
                .HasDefaultValueSql("'0'")
                .HasComment("炉渣含碳量")
                .HasColumnName("lzhtl");
            entity.Property(e => e.Nqqby)
                .HasDefaultValueSql("'0'")
                .HasComment("凝汽器背压")
                .HasColumnName("nqqby");
            entity.Property(e => e.Pywd)
                .HasDefaultValueSql("'0'")
                .HasComment("排烟温度")
                .HasColumnName("pywd");
            entity.Property(e => e.Qjrh)
                .HasDefaultValueSql("'0'")
                .HasComment("汽机热耗")
                .HasColumnName("qjrh");
            entity.Property(e => e.Qjrhhc)
                .HasDefaultValueSql("'0'")
                .HasComment("汽机热耗耗差")
                .HasColumnName("qjrhhc");
            entity.Property(e => e.Qqysecfll)
                .HasDefaultValueSql("'0'")
                .HasComment("前墙右上二次风流量")
                .HasColumnName("qqysecfll");
            entity.Property(e => e.Qqysrjfll)
                .HasDefaultValueSql("'0'")
                .HasComment("前墙右上燃烬风流量")
                .HasColumnName("qqysrjfll");
            entity.Property(e => e.Qqyxecfll)
                .HasDefaultValueSql("'0'")
                .HasComment("前墙右下二次风流量")
                .HasColumnName("qqyxecfll");
            entity.Property(e => e.Qqyxrjfll)
                .HasDefaultValueSql("'0'")
                .HasComment("前墙右下燃烬风流量")
                .HasColumnName("qqyxrjfll");
            entity.Property(e => e.Qqyzecfll)
                .HasDefaultValueSql("'0'")
                .HasComment("前墙右中二次风流量")
                .HasColumnName("qqyzecfll");
            entity.Property(e => e.Qqzsecfll)
                .HasDefaultValueSql("'0'")
                .HasComment("前墙左上二次风流量")
                .HasColumnName("qqzsecfll");
            entity.Property(e => e.Qqzsrjfll)
                .HasDefaultValueSql("'0'")
                .HasComment("前墙左上燃烬风流量")
                .HasColumnName("qqzsrjfll");
            entity.Property(e => e.Qqzxecfll)
                .HasDefaultValueSql("'0'")
                .HasComment("前墙左下二次风流量")
                .HasColumnName("qqzxecfll");
            entity.Property(e => e.Qqzxrjfll)
                .HasDefaultValueSql("'0'")
                .HasComment("前墙左下燃烬风流量")
                .HasColumnName("qqzxrjfll");
            entity.Property(e => e.Qqzzecfll)
                .HasDefaultValueSql("'0'")
                .HasComment("前墙左中二次风流量")
                .HasColumnName("qqzzecfll");
            entity.Property(e => e.Qsf)
                .HasDefaultValueSql("'0'")
                .HasComment("全水分")
                .HasColumnName("qsf");
            entity.Property(e => e.Remarks)
                .HasComment("备注")
                .HasColumnType("text")
                .HasColumnName("remarks");
            entity.Property(e => e.Rll)
                .HasDefaultValueSql("'0'")
                .HasComment("燃料量")
                .HasColumnName("rll");
            entity.Property(e => e.Sfjadykd)
                .HasDefaultValueSql("'0'")
                .HasComment("送风机A动叶开度")
                .HasColumnName("sfjadykd");
            entity.Property(e => e.Sfjbdykd)
                .HasDefaultValueSql("'0'")
                .HasComment("送风机B动叶开度")
                .HasColumnName("sfjbdykd");
            entity.Property(e => e.Sfwd)
                .HasDefaultValueSql("'0'")
                .HasComment("送风温度")
                .HasColumnName("sfwd");
            entity.Property(e => e.Sj)
                .HasComment("指标数据时间")
                .HasColumnType("datetime")
                .HasColumnName("sj");
            entity.Property(e => e.Smb)
                .HasDefaultValueSql("'0'")
                .HasComment("水煤比")
                .HasColumnName("smb");
            entity.Property(e => e.Type)
                .HasComment("0：标杆工况；1：专家工况")
                .HasColumnType("int(11)")
                .HasColumnName("type");
            entity.Property(e => e.Yl)
                .HasDefaultValueSql("'0'")
                .HasComment("氧量")
                .HasColumnName("yl");
            entity.Property(e => e.Ylsdz)
                .HasDefaultValueSql("'0'")
                .HasComment("氧量设定值")
                .HasColumnName("ylsdz");
            entity.Property(e => e.Zfl)
                .HasDefaultValueSql("'0'")
                .HasComment("总风量")
                .HasColumnName("zfl");
            entity.Property(e => e.Zgsll)
                .HasDefaultValueSql("'0'")
                .HasComment("主给水流量")
                .HasColumnName("zgsll");
            entity.Property(e => e.Zhhc)
                .HasDefaultValueSql("'0'")
                .HasComment("综合耗差")
                .HasColumnName("zhhc");
            entity.Property(e => e.Zkbadl)
                .HasDefaultValueSql("'0'")
                .HasComment("真空泵A电流")
                .HasColumnName("zkbadl");
            entity.Property(e => e.Zkbbdl)
                .HasDefaultValueSql("'0'")
                .HasComment("真空泵B电流")
                .HasColumnName("zkbbdl");
            entity.Property(e => e.Zkbcdl)
                .HasDefaultValueSql("'0'")
                .HasComment("真空泵C电流")
                .HasColumnName("zkbcdl");
            entity.Property(e => e.Zrqyqdb1)
                .HasDefaultValueSql("'0'")
                .HasComment("再热器烟气挡板1")
                .HasColumnName("zrqyqdb1");
            entity.Property(e => e.Zrqyqdb2)
                .HasDefaultValueSql("'0'")
                .HasComment("再热器烟气挡板2")
                .HasColumnName("zrqyqdb2");
            entity.Property(e => e.Zrqyqdb3)
                .HasDefaultValueSql("'0'")
                .HasComment("再热器烟气挡板3")
                .HasColumnName("zrqyqdb3");
            entity.Property(e => e.Zrqyqdb4)
                .HasDefaultValueSql("'0'")
                .HasComment("再热器烟气挡板4")
                .HasColumnName("zrqyqdb4");
            entity.Property(e => e.Zrzqwd)
                .HasDefaultValueSql("'0'")
                .HasComment("再热蒸汽温度")
                .HasColumnName("zrzqwd");
            entity.Property(e => e.Zrzqyl)
                .HasDefaultValueSql("'0'")
                .HasComment("再热蒸汽压力")
                .HasColumnName("zrzqyl");
            entity.Property(e => e.Zzqwd)
                .HasDefaultValueSql("'0'")
                .HasComment("主蒸汽温度")
                .HasColumnName("zzqwd");
            entity.Property(e => e.Zzqyl)
                .HasDefaultValueSql("'0'")
                .HasComment("主蒸汽压力")
                .HasColumnName("zzqyl");
            entity.Property(e => e.comparetime)
                .HasDefaultValueSql("'0'")
                .HasComment("标杆时间")
                .HasColumnName("comparetime");
        });

        modelBuilder.Entity<CldConstant>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("cld_constant");

            entity.HasIndex(e => e.SymbolName, "FunctionName");

            entity.HasIndex(e => e.Id, "ID");

            entity.HasIndex(e => e.Name, "PbjectID");

            entity.HasIndex(e => e.PrjControllerId, "Prj_Controller_ID");

            entity.HasIndex(e => e.PrjDocumentId, "Prj_Document_ID");

            entity.HasIndex(e => e.PrjSheetId, "Prj_Sheet_ID");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("ID");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.PrjControllerId)
                .HasColumnType("int(11)")
                .HasColumnName("Prj_Controller_ID");
            entity.Property(e => e.PrjDocumentId)
                .HasColumnType("int(11)")
                .HasColumnName("Prj_Document_ID");
            entity.Property(e => e.PrjSheetId)
                .HasColumnType("int(11)")
                .HasColumnName("Prj_Sheet_ID");
            entity.Property(e => e.SymbolName).HasMaxLength(50);
            entity.Property(e => e.XY)
                .HasMaxLength(50)
                .HasColumnName("X_Y");

            entity.HasOne(d => d.PrjController).WithMany(p => p.CldConstants)
                .HasForeignKey(d => d.PrjControllerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Prj_ControllerCld_Constant");

            entity.HasOne(d => d.PrjDocument).WithMany(p => p.CldConstants)
                .HasForeignKey(d => d.PrjDocumentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Prj_DocumentCld_Constant");

            entity.HasOne(d => d.PrjSheet).WithMany(p => p.CldConstants)
                .HasForeignKey(d => d.PrjSheetId)
                .HasConstraintName("Prj_SheetCld_Constant");
        });

        modelBuilder.Entity<CldFcblock>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("cld_fcblock");

            entity.HasIndex(e => e.AlgName, "AlgName").IsUnique();

            entity.HasIndex(e => e.FunctionName, "FCMasterFunctionName");

            entity.HasIndex(e => e.Id, "ID1");

            entity.HasIndex(e => e.LoopId, "LoopID");

            entity.HasIndex(e => e.MacroId, "MacroID");

            entity.HasIndex(e => e.Name, "ObjectID");

            entity.HasIndex(e => e.PrjControllerId, "Prj_Controller_ID");

            entity.HasIndex(e => e.PrjDocumentId, "Prj_Document_ID");

            entity.HasIndex(e => e.PrjSheetId, "Prj_Sheet_ID");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("ID");
            entity.Property(e => e.AlgName).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(50);
            entity.Property(e => e.FunctionName).HasMaxLength(50);
            entity.Property(e => e.InstantStatus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)");
            entity.Property(e => e.LoopId)
                .HasMaxLength(50)
                .HasColumnName("LoopID");
            entity.Property(e => e.MacroId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("MacroID");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Period).HasMaxLength(50);
            entity.Property(e => e.Phase).HasMaxLength(50);
            entity.Property(e => e.PrjControllerId)
                .HasColumnType("int(11)")
                .HasColumnName("Prj_Controller_ID");
            entity.Property(e => e.PrjDocumentId)
                .HasColumnType("int(11)")
                .HasColumnName("Prj_Document_ID");
            entity.Property(e => e.PrjSheetId)
                .HasColumnType("int(11)")
                .HasColumnName("Prj_Sheet_ID");
            entity.Property(e => e.Sequence)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)");
            entity.Property(e => e.SymbolName).HasMaxLength(50);
            entity.Property(e => e.XY)
                .HasMaxLength(50)
                .HasColumnName("X_Y");

            entity.HasOne(d => d.PrjController).WithMany(p => p.CldFcblocks)
                .HasForeignKey(d => d.PrjControllerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Prj_ControllerCld_FCBlock");

            entity.HasOne(d => d.PrjDocument).WithMany(p => p.CldFcblocks)
                .HasForeignKey(d => d.PrjDocumentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Prj_DocumentCld_FCBlock");

            entity.HasOne(d => d.PrjSheet).WithMany(p => p.CldFcblocks)
                .HasForeignKey(d => d.PrjSheetId)
                .HasConstraintName("Prj_SheetCld_FCBlock");
        });

        modelBuilder.Entity<CldFcinput>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("cld_fcinput");

            entity.HasIndex(e => e.CldFcblockId, "Cld_FCMaster_ID");

            entity.HasIndex(e => e.Id, "ID");

            entity.HasIndex(e => e.PointName, "PointName");

            entity.HasIndex(e => e.PrjControllerId, "Prj_Controller_ID");

            entity.HasIndex(e => e.PrjDocumentId, "Prj_Document_ID");

            entity.HasIndex(e => e.PrjSheetId, "Prj_Sheet_ID");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("ID");
            entity.Property(e => e.CldFcblockId)
                .HasColumnType("int(11)")
                .HasColumnName("Cld_FCBlock_ID");
            entity.Property(e => e.Description).HasMaxLength(50);
            entity.Property(e => e.InitialValue).HasMaxLength(50);
            entity.Property(e => e.Negate).HasDefaultValueSql("'0'");
            entity.Property(e => e.PinName).HasMaxLength(50);
            entity.Property(e => e.Point).HasMaxLength(250);
            entity.Property(e => e.PointName).HasMaxLength(250);
            entity.Property(e => e.PrjControllerId)
                .HasColumnType("int(11)")
                .HasColumnName("Prj_Controller_ID");
            entity.Property(e => e.PrjDocumentId)
                .HasColumnType("int(11)")
                .HasColumnName("Prj_Document_ID");
            entity.Property(e => e.PrjSheetId)
                .HasColumnType("int(11)")
                .HasColumnName("Prj_Sheet_ID");
            entity.Property(e => e.Visible).HasDefaultValueSql("'0'");

            entity.HasOne(d => d.CldFcblock).WithMany(p => p.CldFcinputs)
                .HasForeignKey(d => d.CldFcblockId)
                .HasConstraintName("Cld_FCBlockCld_FCInput");

            entity.HasOne(d => d.PrjController).WithMany(p => p.CldFcinputs)
                .HasForeignKey(d => d.PrjControllerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Prj_ControllerCld_FCInput");

            entity.HasOne(d => d.PrjDocument).WithMany(p => p.CldFcinputs)
                .HasForeignKey(d => d.PrjDocumentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Prj_DocumentCld_FCInput");

            entity.HasOne(d => d.PrjSheet).WithMany(p => p.CldFcinputs)
                .HasForeignKey(d => d.PrjSheetId)
                .HasConstraintName("Prj_SheetCld_FCInput");
        });

        modelBuilder.Entity<CldFcoutput>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("cld_fcoutput");

            entity.HasIndex(e => e.CldFcblockId, "Cld_FCMaster_ID");

            entity.HasIndex(e => e.Id, "ID").IsUnique();

            entity.HasIndex(e => e.PointName, "PointName");

            entity.HasIndex(e => e.PrjControllerId, "Prj_Controller_ID");

            entity.HasIndex(e => e.PrjDocumentId, "Prj_Document_ID");

            entity.HasIndex(e => e.PrjSheetId, "Prj_Sheet_ID");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("ID");
            entity.Property(e => e.CldFcblockId)
                .HasColumnType("int(11)")
                .HasColumnName("Cld_FCBlock_ID");
            entity.Property(e => e.Description).HasMaxLength(50);
            entity.Property(e => e.InitialValue).HasMaxLength(50);
            entity.Property(e => e.Negate).HasDefaultValueSql("'0'");
            entity.Property(e => e.PinName).HasMaxLength(50);
            entity.Property(e => e.PointName).HasMaxLength(250);
            entity.Property(e => e.PrjControllerId)
                .HasColumnType("int(11)")
                .HasColumnName("Prj_Controller_ID");
            entity.Property(e => e.PrjDocumentId)
                .HasColumnType("int(11)")
                .HasColumnName("Prj_Document_ID");
            entity.Property(e => e.PrjSheetId)
                .HasColumnType("int(11)")
                .HasColumnName("Prj_Sheet_ID");
            entity.Property(e => e.Visible).HasDefaultValueSql("'0'");

            entity.HasOne(d => d.CldFcblock).WithMany(p => p.CldFcoutputs)
                .HasForeignKey(d => d.CldFcblockId)
                .HasConstraintName("Cld_FCBlockCld_FCOutput");

            entity.HasOne(d => d.PrjController).WithMany(p => p.CldFcoutputs)
                .HasForeignKey(d => d.PrjControllerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Prj_ControllerCld_FCOutput");

            entity.HasOne(d => d.PrjDocument).WithMany(p => p.CldFcoutputs)
                .HasForeignKey(d => d.PrjDocumentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Prj_DocumentCld_FCOutput");

            entity.HasOne(d => d.PrjSheet).WithMany(p => p.CldFcoutputs)
                .HasForeignKey(d => d.PrjSheetId)
                .HasConstraintName("Prj_SheetCld_FCOutput");
        });

        modelBuilder.Entity<CldFcparameter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("cld_fcparameter");

            entity.HasIndex(e => e.CldFcblockId, "Cld_FCBlock_ID");

            entity.HasIndex(e => e.Id, "ID");

            entity.HasIndex(e => e.PrjControllerId, "Prj_Controller_ID");

            entity.HasIndex(e => e.PrjDocumentId, "Prj_Document_ID");

            entity.HasIndex(e => e.PrjSheetId, "Prj_Sheet_ID");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("ID");
            entity.Property(e => e.CldFcblockId)
                .HasColumnType("int(11)")
                .HasColumnName("Cld_FCBlock_ID");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.PrjControllerId)
                .HasColumnType("int(11)")
                .HasColumnName("Prj_Controller_ID");
            entity.Property(e => e.PrjDocumentId)
                .HasColumnType("int(11)")
                .HasColumnName("Prj_Document_ID");
            entity.Property(e => e.PrjSheetId)
                .HasColumnType("int(11)")
                .HasColumnName("Prj_Sheet_ID");
            entity.Property(e => e.Pvalue)
                .HasMaxLength(250)
                .HasColumnName("PValue");

            entity.HasOne(d => d.CldFcblock).WithMany(p => p.CldFcparameters)
                .HasForeignKey(d => d.CldFcblockId)
                .HasConstraintName("Cld_FCBlockCld_FCParameter");

            entity.HasOne(d => d.PrjController).WithMany(p => p.CldFcparameters)
                .HasForeignKey(d => d.PrjControllerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Prj_ControllerCld_FCParameter");

            entity.HasOne(d => d.PrjDocument).WithMany(p => p.CldFcparameters)
                .HasForeignKey(d => d.PrjDocumentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Prj_DocumentCld_FCParameter");

            entity.HasOne(d => d.PrjSheet).WithMany(p => p.CldFcparameters)
                .HasForeignKey(d => d.PrjSheetId)
                .HasConstraintName("Prj_SheetCld_FCParameter");
        });

        modelBuilder.Entity<CldGraphic>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("cld_graphic");

            entity.HasIndex(e => e.Id, "ID").IsUnique();

            entity.HasIndex(e => e.PrjControllerId, "Prj_Controller_ID");

            entity.HasIndex(e => e.PrjDocumentId, "Prj_Document_ID");

            entity.HasIndex(e => e.PrjSheetId, "Prj_Sheet_ID");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("ID");
            entity.Property(e => e.Layer).HasMaxLength(50);
            entity.Property(e => e.PrjControllerId)
                .HasColumnType("int(11)")
                .HasColumnName("Prj_Controller_ID");
            entity.Property(e => e.PrjDocumentId)
                .HasColumnType("int(11)")
                .HasColumnName("Prj_Document_ID");
            entity.Property(e => e.PrjSheetId)
                .HasColumnType("int(11)")
                .HasColumnName("Prj_Sheet_ID");
            entity.Property(e => e.Type).HasMaxLength(50);

            entity.HasOne(d => d.PrjController).WithMany(p => p.CldGraphics)
                .HasForeignKey(d => d.PrjControllerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Prj_ControllerCld_Graphic");

            entity.HasOne(d => d.PrjDocument).WithMany(p => p.CldGraphics)
                .HasForeignKey(d => d.PrjDocumentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Prj_DocumentCld_Graphic");

            entity.HasOne(d => d.PrjSheet).WithMany(p => p.CldGraphics)
                .HasForeignKey(d => d.PrjSheetId)
                .HasConstraintName("Prj_SheetCld_Graphic");
        });

        modelBuilder.Entity<CldIref>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("cld_iref");

            entity.HasIndex(e => e.FunctionName, "BlockID");

            entity.HasIndex(e => e.FunctionCode, "FunctionCode");

            entity.HasIndex(e => e.Id, "ID");

            entity.HasIndex(e => e.NetworkId, "NetworkID");

            entity.HasIndex(e => e.Name, "ObjectID");

            entity.HasIndex(e => e.PrjControllerId, "Prj_Controller_ID");

            entity.HasIndex(e => e.PrjDocumentId, "Prj_Document_ID");

            entity.HasIndex(e => e.PrjSheetId, "Prj_Sheet_ID");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("ID");
            entity.Property(e => e.Address).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(250);
            entity.Property(e => e.FunctionCode).HasMaxLength(50);
            entity.Property(e => e.FunctionName)
                .HasMaxLength(50)
                .HasDefaultValueSql("'IRef'");
            entity.Property(e => e.Name).HasMaxLength(250);
            entity.Property(e => e.Negate).HasDefaultValueSql("'0'");
            entity.Property(e => e.NetworkId)
                .HasMaxLength(50)
                .HasColumnName("NetworkID");
            entity.Property(e => e.PinName).HasMaxLength(50);
            entity.Property(e => e.PrjControllerId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("Prj_Controller_ID");
            entity.Property(e => e.PrjDocumentId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("Prj_Document_ID");
            entity.Property(e => e.PrjSheetId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("Prj_Sheet_ID");
            entity.Property(e => e.RefName).HasMaxLength(150);
            entity.Property(e => e.SrcRefId)
                .HasMaxLength(50)
                .HasColumnName("SrcRefID");
            entity.Property(e => e.XY)
                .HasMaxLength(50)
                .HasColumnName("X_Y");

            entity.HasOne(d => d.PrjController).WithMany(p => p.CldIrefs)
                .HasForeignKey(d => d.PrjControllerId)
                .HasConstraintName("Prj_ControllerCld_IRef");

            entity.HasOne(d => d.PrjDocument).WithMany(p => p.CldIrefs)
                .HasForeignKey(d => d.PrjDocumentId)
                .HasConstraintName("Prj_DocumentCld_IRef");

            entity.HasOne(d => d.PrjSheet).WithMany(p => p.CldIrefs)
                .HasForeignKey(d => d.PrjSheetId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("Prj_SheetCld_IRef");
        });

        modelBuilder.Entity<CldOref>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("cld_oref");

            entity.HasIndex(e => e.SrcBlockId, "BlockID");

            entity.HasIndex(e => e.Id, "ID");

            entity.HasIndex(e => e.NetworkId, "NetworkID");

            entity.HasIndex(e => e.Name, "ObjectID");

            entity.HasIndex(e => e.PrjControllerId, "Prj_Controller_ID");

            entity.HasIndex(e => e.PrjDocumentId, "Prj_Document_ID");

            entity.HasIndex(e => e.PrjSheetId, "Prj_Sheet_ID");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("ID");
            entity.Property(e => e.Description).HasMaxLength(250);
            entity.Property(e => e.FunctionName)
                .HasMaxLength(50)
                .HasDefaultValueSql("'ORef'");
            entity.Property(e => e.Name).HasMaxLength(250);
            entity.Property(e => e.Negate).HasDefaultValueSql("'0'");
            entity.Property(e => e.NetworkId)
                .HasMaxLength(50)
                .HasColumnName("NetworkID");
            entity.Property(e => e.PrjControllerId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("Prj_Controller_ID");
            entity.Property(e => e.PrjDocumentId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("Prj_Document_ID");
            entity.Property(e => e.PrjSheetId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("Prj_Sheet_ID");
            entity.Property(e => e.RefName).HasMaxLength(150);
            entity.Property(e => e.SrcAddress).HasMaxLength(50);
            entity.Property(e => e.SrcBlockId)
                .HasMaxLength(50)
                .HasColumnName("SrcBlockID");
            entity.Property(e => e.SrcPinName).HasMaxLength(50);
            entity.Property(e => e.XY)
                .HasMaxLength(50)
                .HasColumnName("X_Y");

            entity.HasOne(d => d.PrjController).WithMany(p => p.CldOrefs)
                .HasForeignKey(d => d.PrjControllerId)
                .HasConstraintName("Prj_ControllerCld_ORef");

            entity.HasOne(d => d.PrjDocument).WithMany(p => p.CldOrefs)
                .HasForeignKey(d => d.PrjDocumentId)
                .HasConstraintName("Prj_DocumentCld_ORef");

            entity.HasOne(d => d.PrjSheet).WithMany(p => p.CldOrefs)
                .HasForeignKey(d => d.PrjSheetId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("Prj_SheetCld_ORef");
        });

        modelBuilder.Entity<CldSignal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("cld_signal");

            entity.HasIndex(e => e.Id, "ID").IsUnique();

            entity.HasIndex(e => e.PrjControllerId, "Prj_Controller_ID");

            entity.HasIndex(e => e.PrjDocumentId, "Prj_Document_ID");

            entity.HasIndex(e => e.PrjSheetId, "Prj_Sheet_ID");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("ID");
            entity.Property(e => e.EntityBelongTo).HasMaxLength(50);
            entity.Property(e => e.FromBlockName).HasMaxLength(250);
            entity.Property(e => e.FromPinName).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.PrjControllerId)
                .HasColumnType("int(11)")
                .HasColumnName("Prj_Controller_ID");
            entity.Property(e => e.PrjDocumentId)
                .HasColumnType("int(11)")
                .HasColumnName("Prj_Document_ID");
            entity.Property(e => e.PrjSheetId)
                .HasColumnType("int(11)")
                .HasColumnName("Prj_Sheet_ID");
            entity.Property(e => e.SignalType).HasMaxLength(50);
            entity.Property(e => e.ToBlockName).HasMaxLength(250);
            entity.Property(e => e.ToPinName).HasMaxLength(50);

            entity.HasOne(d => d.PrjController).WithMany(p => p.CldSignals)
                .HasForeignKey(d => d.PrjControllerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Prj_ControllerCld_Signal");

            entity.HasOne(d => d.PrjDocument).WithMany(p => p.CldSignals)
                .HasForeignKey(d => d.PrjDocumentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Prj_DocumentCld_Signal");

            entity.HasOne(d => d.PrjSheet).WithMany(p => p.CldSignals)
                .HasForeignKey(d => d.PrjSheetId)
                .HasConstraintName("Prj_SheetCld_Signal");
        });

        modelBuilder.Entity<Iomap>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("iomap");

            entity.HasIndex(e => e.Id, "ID");

            entity.HasIndex(e => e.Kkscode, "KKSCode");

            entity.HasIndex(e => e.PrjControllerId, "Prj_Controller_ID");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("ID");
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.IomapDirection)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("IOMapDirection");
            entity.Property(e => e.IomapName)
                .HasMaxLength(50)
                .HasColumnName("IOMapName");
            entity.Property(e => e.Iotype)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("IOType");
            entity.Property(e => e.Kkscode)
                .HasMaxLength(50)
                .HasColumnName("KKSCode");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.PrjControllerId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("Prj_Controller_ID");
        });

        modelBuilder.Entity<MetaCrossreference>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("meta_crossreference");

            entity.HasIndex(e => e.Id, "ID");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("ID");
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(50);
            entity.Property(e => e.FunctionName).HasMaxLength(50);
            entity.Property(e => e.Type).HasMaxLength(50);
        });

        modelBuilder.Entity<MetaDatatype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("meta_datatype");

            entity.HasIndex(e => e.Name, "DataTypeName").IsUnique();

            entity.HasIndex(e => e.Id, "ID");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("ID");
            entity.Property(e => e.Class).HasMaxLength(50);
            entity.Property(e => e.Index)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)");
            entity.Property(e => e.Length)
                .HasDefaultValueSql("'0'")
                .HasColumnType("smallint(6)");
            entity.Property(e => e.SystemType).HasMaxLength(255);
        });

        modelBuilder.Entity<MetaDatatypedetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("meta_datatypedetail");

            entity.HasIndex(e => e.Id, "ID");

            entity.HasIndex(e => e.MetaDataTypeId, "Meta_DataType_ID");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("ID");
            entity.Property(e => e.DataTypeName).HasMaxLength(50);
            entity.Property(e => e.Index).HasColumnType("int(11)");
            entity.Property(e => e.MemberName).HasMaxLength(50);
            entity.Property(e => e.MetaDataTypeId)
                .HasColumnType("int(11)")
                .HasColumnName("Meta_DataType_ID");
            entity.Property(e => e.SystemType).HasMaxLength(50);

            entity.HasOne(d => d.MetaDataType).WithMany(p => p.MetaDatatypedetails)
                .HasForeignKey(d => d.MetaDataTypeId)
                .HasConstraintName("Meta_DataTypeMeta_DataTypeDetail");
        });

        modelBuilder.Entity<MetaFcdetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("meta_fcdetail");

            entity.HasIndex(e => e.Id, "ID");

            entity.HasIndex(e => e.MetaFcmasterId, "Meta_FCMaster_ID");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("ID");
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.FunctionName).HasMaxLength(50);
            entity.Property(e => e.MaxValues).HasMaxLength(50);
            entity.Property(e => e.MetaFcmasterId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("Meta_FCMaster_ID");
            entity.Property(e => e.MinValue).HasMaxLength(50);
            entity.Property(e => e.PinIndex).HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.PinName).HasMaxLength(50);
            entity.Property(e => e.PinSignalType)
                .HasMaxLength(50)
                .HasDefaultValueSql("'Logical'");
            entity.Property(e => e.PinType).HasMaxLength(50);
            entity.Property(e => e.PointName).HasMaxLength(50);
            entity.Property(e => e.Tune).HasDefaultValueSql("'0'");
            entity.Property(e => e.Visible).HasDefaultValueSql("'0'");

            entity.HasOne(d => d.MetaFcmaster).WithMany(p => p.MetaFcdetails)
                .HasForeignKey(d => d.MetaFcmasterId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("Meta_FCMasterMeta_FCDetail");
        });

        modelBuilder.Entity<MetaFcmaster>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("meta_fcmaster");

            entity.HasIndex(e => e.FunctionCode, "FunctionCode");

            entity.HasIndex(e => e.FunctionName, "FunctionName").IsUnique();

            entity.HasIndex(e => e.Id, "ID").IsUnique();

            entity.HasIndex(e => e.PrjSystemId, "Meta_Directory_ID2");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("ID");
            entity.Property(e => e.Algorithm).HasMaxLength(50);
            entity.Property(e => e.CreateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(50);
            entity.Property(e => e.Diag)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(3) unsigned")
                .HasColumnName("DIAG");
            entity.Property(e => e.Fclength)
                .HasColumnType("smallint(6)")
                .HasColumnName("FCLength");
            entity.Property(e => e.FunctionCode)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)");
            entity.Property(e => e.FunctionName).HasMaxLength(50);
            entity.Property(e => e.InputCount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.InternalCount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)");
            entity.Property(e => e.ModelState).HasMaxLength(50);
            entity.Property(e => e.ModelType).HasMaxLength(50);
            entity.Property(e => e.OutPutCount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.PrjSystemId)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)")
                .HasColumnName("Prj_System_ID");
            entity.Property(e => e.SpecCount)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(3) unsigned");
            entity.Property(e => e.State).HasMaxLength(50);
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .HasDefaultValueSql("'Function Code'");
            entity.Property(e => e.Version).HasMaxLength(50);
            entity.Property(e => e.Visable)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)");
        });

        modelBuilder.Entity<MetaFcmasterVersion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("meta_fcmaster_version");

            entity.HasIndex(e => e.Id, "ID").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("ID");
            entity.Property(e => e.ConditionName).HasMaxLength(50);
            entity.Property(e => e.CreateTime).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(50);
            entity.Property(e => e.MetaFcmasterId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("Meta_FCMaster_ID");
            entity.Property(e => e.ModelState).HasMaxLength(50);
            entity.Property(e => e.State).HasMaxLength(50);
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)");
            entity.Property(e => e.Version).HasMaxLength(50);
            entity.Property(e => e.Visable)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)");
        });

        modelBuilder.Entity<MetaSymboldetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("meta_symboldetail");

            entity.HasIndex(e => e.Id, "ID");

            entity.HasIndex(e => e.SymbolId, "Meta_SymbolMasterMeta_SymbolDetail");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("ID");
            entity.Property(e => e.DynamicType)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)");
            entity.Property(e => e.ElementType).HasMaxLength(50);
            entity.Property(e => e.SymbolId)
                .HasMaxLength(50)
                .HasColumnName("SymbolID");

            entity.HasOne(d => d.Symbol).WithMany(p => p.MetaSymboldetails)
                .HasForeignKey(d => d.SymbolId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("Meta_SymbolMasterMeta_SymbolDetail");
        });

        modelBuilder.Entity<MetaSymbolexchange>(entity =>
        {
            entity.HasKey(e => e.ObjectId).HasName("PRIMARY");

            entity.ToTable("meta_symbolexchange");

            entity.HasIndex(e => e.ObjectId, "ObjectID");

            entity.HasIndex(e => e.ParentObjectId, "ParentObjectID");

            entity.Property(e => e.ObjectId)
                .HasMaxLength(50)
                .HasColumnName("ObjectID");
            entity.Property(e => e.ObjectName).HasMaxLength(50);
            entity.Property(e => e.ObjectType).HasMaxLength(50);
            entity.Property(e => e.ParentObjectId)
                .HasMaxLength(50)
                .HasColumnName("ParentObjectID");
        });

        modelBuilder.Entity<MetaSymbolmaster>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("meta_symbolmaster");

            entity.HasIndex(e => e.Code, "Code");

            entity.HasIndex(e => e.Id, "SymbolID");

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .HasColumnName("ID");
            entity.Property(e => e.Code)
                .HasDefaultValueSql("'0'")
                .HasColumnType("smallint(6)");
            entity.Property(e => e.FunctionName).HasMaxLength(50);
            entity.Property(e => e.OringinPoint).HasMaxLength(50);
            entity.Property(e => e.SymbolName).HasMaxLength(50);
            entity.Property(e => e.SymbolType).HasMaxLength(50);
        });

        modelBuilder.Entity<PrjController>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("prj_controller");

            entity.HasIndex(e => e.Id, "ID");

            entity.HasIndex(e => e.PrjUnitId, "Prj_Unit_ID");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("ID");
            entity.Property(e => e.ControllerAddress).HasMaxLength(50);
            entity.Property(e => e.ControllerName).HasMaxLength(50);
            entity.Property(e => e.CreateTime).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(100);
            entity.Property(e => e.ModifyTime).HasColumnType("datetime");
            entity.Property(e => e.PrjUnitId)
                .HasColumnType("int(11)")
                .HasColumnName("Prj_Unit_ID");
            entity.Property(e => e.Sequence)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)");
            entity.Property(e => e.TranslatorResult)
                .HasMaxLength(50)
                .HasDefaultValueSql("'''未翻译'''");
            entity.Property(e => e.Version)
                .HasMaxLength(100)
                .HasDefaultValueSql("'0'");

            entity.HasOne(d => d.PrjUnit).WithMany(p => p.PrjControllers)
                .HasForeignKey(d => d.PrjUnitId)
                .HasConstraintName("Prj_UnitPrj_Controller");
        });

        modelBuilder.Entity<PrjDocument>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("prj_document");

            entity.HasIndex(e => e.Id, "ID").IsUnique();

            entity.HasIndex(e => e.PrjControllerId, "Prj_Controller_ID");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("ID");
            entity.Property(e => e.Changed)
                .HasMaxLength(50)
                .HasDefaultValueSql("'0'")
                .HasColumnName("changed");
            entity.Property(e => e.CreateTime).HasColumnType("datetime");
            entity.Property(e => e.DocumentCaption).HasMaxLength(50);
            entity.Property(e => e.DocumentName).HasMaxLength(100);
            entity.Property(e => e.ModifyTime).HasColumnType("datetime");
            entity.Property(e => e.ParentSequence)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)");
            entity.Property(e => e.PrjControllerId)
                .HasColumnType("int(11)")
                .HasColumnName("Prj_Controller_ID");
            entity.Property(e => e.Sequence)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)");
            entity.Property(e => e.TranslatorResult)
                .HasMaxLength(50)
                .HasDefaultValueSql("'''未翻译'''");
            entity.Property(e => e.Type).HasMaxLength(50);

            entity.HasOne(d => d.PrjController).WithMany(p => p.PrjDocuments)
                .HasForeignKey(d => d.PrjControllerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Prj_ControllerPrj_Document");
        });

        modelBuilder.Entity<PrjNetwork>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("prj_network");

            entity.HasIndex(e => e.Id, "ID").IsUnique();

            entity.HasIndex(e => e.PrjProjectId, "Prj_Project_ID");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("ID");
            entity.Property(e => e.Description).HasMaxLength(100);
            entity.Property(e => e.NetworkAddress).HasMaxLength(50);
            entity.Property(e => e.NetworkName).HasMaxLength(50);
            entity.Property(e => e.PrjProjectId)
                .HasColumnType("int(11)")
                .HasColumnName("Prj_Project_ID");

            entity.HasOne(d => d.PrjProject).WithMany(p => p.PrjNetworks)
                .HasForeignKey(d => d.PrjProjectId)
                .HasConstraintName("Prj_ProjectPrj_Network");
        });

        modelBuilder.Entity<PrjProject>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("prj_project");

            entity.HasIndex(e => e.Id, "ID");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("ID");
            entity.Property(e => e.AlarmVersion)
                .HasMaxLength(50)
                .HasDefaultValueSql("'0'");
            entity.Property(e => e.BlockMaxNumber)
                .HasMaxLength(50)
                .HasDefaultValueSql("'0'");
            entity.Property(e => e.CreateTime).HasColumnType("datetime");
            entity.Property(e => e.ModifyTime).HasColumnType("datetime");
            entity.Property(e => e.PinMaxNumber)
                .HasMaxLength(50)
                .HasDefaultValueSql("'0'");
            entity.Property(e => e.ProjectName).HasMaxLength(150);
            entity.Property(e => e.ProjectPath).HasMaxLength(150);
            entity.Property(e => e.Type).HasMaxLength(50);
            entity.Property(e => e.VarSystemVersion)
                .HasMaxLength(50)
                .HasDefaultValueSql("'0'");
        });

        modelBuilder.Entity<PrjSheet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("prj_sheet");

            entity.HasIndex(e => e.Id, "ID");

            entity.HasIndex(e => e.PrjSystemId, "Meta_Directory_ID");

            entity.HasIndex(e => e.PrjDocumentId, "Prj_Document_ID");

            entity.HasIndex(e => e.PrjControllerId, "Prj_SheetControllerAddress");

            entity.HasIndex(e => e.SheetNum, "SheetID");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("ID");
            entity.Property(e => e.CreateTime).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(250);
            entity.Property(e => e.Height)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)");
            entity.Property(e => e.Macro).HasDefaultValueSql("'0'");
            entity.Property(e => e.ModifyTime).HasColumnType("datetime");
            entity.Property(e => e.PrjControllerId)
                .HasColumnType("int(11)")
                .HasColumnName("Prj_Controller_ID");
            entity.Property(e => e.PrjDocumentId)
                .HasColumnType("int(11)")
                .HasColumnName("Prj_Document_ID");
            entity.Property(e => e.PrjSystemId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("Prj_System_ID");
            entity.Property(e => e.Sequence)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)");
            entity.Property(e => e.SheetName).HasMaxLength(50);
            entity.Property(e => e.SheetNum)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)");
            entity.Property(e => e.State).HasMaxLength(50);
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .HasDefaultValueSql("'CFC'");
            entity.Property(e => e.Version)
                .HasMaxLength(50)
                .HasDefaultValueSql("'0'");
            entity.Property(e => e.Width)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)");

            entity.HasOne(d => d.PrjController).WithMany(p => p.PrjSheets)
                .HasForeignKey(d => d.PrjControllerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Prj_ControllerPrj_Sheet");

            entity.HasOne(d => d.PrjDocument).WithMany(p => p.PrjSheets)
                .HasForeignKey(d => d.PrjDocumentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Prj_DocumentPrj_Sheet");
        });

        modelBuilder.Entity<PrjSystem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("prj_system");

            entity.HasIndex(e => e.Id, "ID");

            entity.HasIndex(e => e.ParentId, "ParentID");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("ID");
            entity.Property(e => e.Description).HasMaxLength(50);
            entity.Property(e => e.ModelType).HasMaxLength(20);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.ParentId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("ParentID");
            entity.Property(e => e.SystemId)
                .HasColumnType("int(11)")
                .HasColumnName("SystemID");
        });

        modelBuilder.Entity<PrjUnit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("prj_unit");

            entity.HasIndex(e => e.Id, "ID");

            entity.HasIndex(e => e.PrjNetworkId, "Prj_Network");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("ID");
            entity.Property(e => e.Description).HasMaxLength(100);
            entity.Property(e => e.LoadPoint).HasMaxLength(50);
            entity.Property(e => e.PrjNetworkId)
                .HasColumnType("int(11)")
                .HasColumnName("Prj_Network_ID");
            entity.Property(e => e.TempPoint).HasMaxLength(50);
            entity.Property(e => e.UnitAddress).HasMaxLength(50);
            entity.Property(e => e.UnitName).HasMaxLength(50);

            entity.HasOne(d => d.PrjNetwork).WithMany(p => p.PrjUnits)
                .HasForeignKey(d => d.PrjNetworkId)
                .HasConstraintName("Prj_NetworkPrj_Unit");
        });

        modelBuilder.Entity<T1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("t1");

            entity.HasIndex(e => e.PointName, "ID");

            entity.Property(e => e.OpointName)
                .HasMaxLength(50)
                .HasColumnName("OPointName");
            entity.Property(e => e.PointName).HasMaxLength(50);
        });

        modelBuilder.Entity<TempControlleruserlibraryname>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("temp_controlleruserlibraryname");

            entity.HasIndex(e => e.Id, "ID");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("ID");
            entity.Property(e => e.ControllerName).HasMaxLength(50);
            entity.Property(e => e.LibraryName).HasMaxLength(50);
        });

        modelBuilder.Entity<TempFunctionnamechanged>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("temp_functionnamechanged");

            entity.HasIndex(e => e.IsLibrary, "ControllerID");

            entity.HasIndex(e => e.Id, "ID");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("ID");
            entity.Property(e => e.Address).HasMaxLength(50);
            entity.Property(e => e.IsLibrary).HasDefaultValueSql("'0'");
            entity.Property(e => e.NewName).HasMaxLength(50);
            entity.Property(e => e.OldName).HasMaxLength(50);
        });

        modelBuilder.Entity<Temperaturepoint>(entity =>
        {
            entity.HasKey(e => e.Name).HasName("PRIMARY");

            entity.ToTable("temperaturepoint");

            entity.HasIndex(e => e.ControllerId, "ControllerID");

            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.ControllerId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("ControllerID");
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(250);
        });

        modelBuilder.Entity<Viewdcspoint>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viewdcspoint");

            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.MaximunScale).HasMaxLength(50);
            entity.Property(e => e.MinimumScale).HasMaxLength(50);
            entity.Property(e => e.ModelType)
                .HasMaxLength(8)
                .HasDefaultValueSql("''");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Opcaddress)
                .HasMaxLength(0)
                .HasDefaultValueSql("''")
                .IsFixedLength()
                .HasColumnName("OPCAddress");
            entity.Property(e => e.SystemId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)");
            entity.Property(e => e.Unit).HasMaxLength(50);
        });

        modelBuilder.Entity<Viewpoint>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viewpoint");

            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.MaximunScale).HasMaxLength(50);
            entity.Property(e => e.MinimumScale).HasMaxLength(50);
            entity.Property(e => e.ModelType).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(151);
            entity.Property(e => e.SystemId).HasColumnType("int(11)");
            entity.Property(e => e.Unit).HasMaxLength(50);
        });

        modelBuilder.Entity<Viewwarnpoint>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("viewwarnpoint");

            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.ModelType).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(151);
            entity.Property(e => e.SystemId)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)");
        });

        modelBuilder.Entity<Whereusedalgname>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("whereusedalgname");

            entity.HasIndex(e => e.Id, "ID");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("ID");
            entity.Property(e => e.AlgName).HasMaxLength(250);
            entity.Property(e => e.SheetName).HasMaxLength(250);
        });

        modelBuilder.Entity<Whereusediref>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("whereusediref");

            entity.HasIndex(e => e.Id, "ID");

            entity.HasIndex(e => e.Name, "ObjectID");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("ID");
            entity.Property(e => e.Name).HasMaxLength(250);
            entity.Property(e => e.RefName).HasMaxLength(150);
            entity.Property(e => e.SheetName).HasMaxLength(50);
        });

        modelBuilder.Entity<Whereusedoref>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("whereusedoref");

            entity.HasIndex(e => e.SheetName, "BlockID");

            entity.HasIndex(e => e.Id, "ID");

            entity.HasIndex(e => e.Name, "ObjectID");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("ID");
            entity.Property(e => e.Name).HasMaxLength(250);
            entity.Property(e => e.RefName).HasMaxLength(150);
            entity.Property(e => e.SheetName).HasMaxLength(50);
        });

        modelBuilder.Entity<Whereusedvarsystem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("whereusedvarsystem");

            entity.HasIndex(e => e.Id, "ID");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("ID");
            entity.Property(e => e.DataType).HasMaxLength(50);
            entity.Property(e => e.DefaultValue).HasMaxLength(250);
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<CldWarnpoint>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("cld_warnpoint");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("ID");
            entity.Property(e => e.AlarmLevel)
                .HasComment("报警级别")
                .HasColumnType("int(11)");
            entity.Property(e => e.AlarmTypeId)
                .HasComment("报警类型编号")
                .HasColumnType("int(11)")
                .HasColumnName("AlarmTypeID");
            entity.Property(e => e.CldFcblockId)
                .HasComment("块编号")
                .HasColumnType("int(11)")
                .HasColumnName("Cld_FCBlock_ID");
            entity.Property(e => e.CopyToDiagOnoff)
                .HasComment("推送诊断（0：\"否\"，1：\"是\"）")
                .HasColumnType("int(11)")
                .HasColumnName("CopyToDiagONOFF");
            entity.Property(e => e.Description)
                .HasMaxLength(250)
                .HasComment("描述");
            entity.Property(e => e.Equation)
                .HasMaxLength(250)
                .HasComment("公式");
            entity.Property(e => e.Gzpname)
                .HasMaxLength(250)
                .HasComment("光子牌")
                .HasColumnName("GZPName");
            entity.Property(e => e.Gzponoff)
                .HasComment("光子牌状态（0：\"否\"，1：\"是\"）")
                .HasColumnType("int(11)")
                .HasColumnName("GZPONOFF");
            entity.Property(e => e.InsertTime)
                .HasComment("写入时间")
                .HasColumnType("datetime");
            entity.Property(e => e.IsConfirm)
                .HasComment("报警确认")
                .HasColumnType("int(11)");
            entity.Property(e => e.LowLimit)
                .HasMaxLength(50)
                .HasComment("残差下限");
            entity.Property(e => e.ModelOrrule)
                .HasComment("报警类型（模型或者规则）")
                .HasColumnType("int(11)")
                .HasColumnName("ModelORRule");
            entity.Property(e => e.OutputPoint)
                .HasMaxLength(50)
                .HasComment("输出点");
            entity.Property(e => e.PointName)
                .HasMaxLength(50)
                .HasComment("点名");
            entity.Property(e => e.PointOrmodel)
                .HasComment("测点或者模型")
                .HasColumnType("int(11)")
                .HasColumnName("PointORModel");
            entity.Property(e => e.PrjControllerId)
                .HasColumnType("int(11)")
                .HasColumnName("Prj_Controller_ID");
            entity.Property(e => e.PrjDocumentId)
                .HasColumnType("int(11)")
                .HasColumnName("Prj_Document_ID");
            entity.Property(e => e.PrjSheetId)
                .HasComment("页面编号")
                .HasColumnType("int(11)")
                .HasColumnName("Prj_Sheet_ID");
            entity.Property(e => e.RealTimeStatus)
                .HasComment("实时状态")
                .HasColumnType("int(11)");
            entity.Property(e => e.Running)
                .HasComment("是否运行")
                .HasColumnType("int(11)");
            entity.Property(e => e.RunningLog).HasComment("运行日志");
            entity.Property(e => e.ShortMessageOnoff)
                .HasComment("短信告警（0：\"否\"，1：\"是\"）")
                .HasColumnType("int(11)")
                .HasColumnName("ShortMessageONOFF");
            entity.Property(e => e.Suggestion)
                .HasMaxLength(250)
                .HasComment("建议");
            entity.Property(e => e.TimeDurationThreshold)
                .HasComment("告警延时")
                .HasColumnType("int(11)");
            entity.Property(e => e.Unit)
                .HasMaxLength(20)
                .HasComment("单位");
            entity.Property(e => e.UpLimit)
                .HasMaxLength(50)
                .HasComment("残差上限");
            entity.Property(e => e.WarnConstraint)
                .HasMaxLength(250)
                .HasComment("限制条件");
            entity.Property(e => e.WarnConstraintName)
                .HasMaxLength(150)
                .HasDefaultValueSql("'无限制'")
                .HasComment("限制名称");
            entity.Property(e => e.LimitAlarmName)
                .HasMaxLength(250)
                .HasComment("限值报警条件");
            entity.Property(e => e.LimitAlarmCondition)
                .HasMaxLength(150)
                .HasDefaultValueSql("'无限制'")
                .HasComment("限值报警名称");

            entity.Property(e => e.WarnId)
                .HasMaxLength(20)
                .HasColumnName("WarnID");
            entity.Property(e => e.WarnStatus)
                .HasComment("已有实例（0：\"是\" ，1：\"否\"）")
                .HasColumnType("int(11)");
            entity.Property(e => e.WarnVisable)
                .HasComment("是否运行（0：\"否\"，1：\"是\"）")
                .HasColumnType("int(11)");
            entity.Property(e => e.IsAlarmSuspended)
                .HasComment("是否挂起（0：\"否\"，1：\"是\"）")
                .HasColumnType("int(11)");
            entity.Property(e => e.IsWriteBack)
                .HasComment("是否回写（0：\"否\"，1：\"是\"）")
                .HasColumnType("int(11)");
            entity.Property(e => e.WriteBackPointName)
                .HasMaxLength(250)
                .HasComment("回写点名称");

        });

        modelBuilder.Entity<Pointshow>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("pointshow")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .ValueGeneratedOnAdd();
            entity.Property(e => e.pointname)
                .HasMaxLength(255)
                .IsRequired();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
