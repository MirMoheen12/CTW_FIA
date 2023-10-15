using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CTW_FIA.Migrations
{
    public partial class AccusationStatusList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "strURN",
                table: "ReportingAgency",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "ReportingAgency",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ReportingAgencyTitle",
                table: "ReportingAgency",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "ReportingAgency",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            //migrationBuilder.CreateTable(
            //    name: "Address",
            //    columns: table => new
            //    {
            //        strURN = table.Column<string>(type: "nvarchar(450)", nullable: false),
            //        AddressDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        AddressName = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        AddressType = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        HouseNumber = table.Column<int>(type: "int", nullable: true),
            //        Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Province = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        District = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        City = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        StreetNumber = table.Column<int>(type: "int", nullable: true),
            //        Mohallah = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Village = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Town = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        PostOffice = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        TehsilTaluka = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        PostalZip = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        CommonwealthTerritory = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Latitude = table.Column<float>(type: "real", nullable: true),
            //        Longitude = table.Column<float>(type: "real", nullable: true),
            //        Other1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Other2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        memRemarks = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        dteSent = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        IsDeleted = table.Column<bool>(type: "bit", nullable: false),
            //        textSearch = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Status = table.Column<int>(type: "int", nullable: true),
            //        ApprovedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        ApprovedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Address", x => x.strURN);
            //    });

            //            migrationBuilder.CreateTable(
            //                name: "BaseLogs",
            //                columns: table => new
            //                {
            //                    Id = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    strURN = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    textSearch = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_BaseLogs", x => x.Id);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "CBRNs",
            //                columns: table => new
            //                {
            //                    strURN = table.Column<string>(type: "nvarchar(450)", nullable: false),
            //                    strCountryOrigin = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    strType = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    strQuantityMeasurement = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    strMethodDelivery = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    strManufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    strCountryRecovered = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    strUNNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    strSpecialPrecautions = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    strOther = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    strSecurityRating = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
            //                    textSearch = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    strHazard = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    strName = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    strPrimaryMediaImageUrn = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    intQuantity = table.Column<int>(type: "int", nullable: false),
            //                    memRemarks = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    strCategory = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    strDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    ApprovedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    ApprovedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_CBRNs", x => x.strURN);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "Chemicals",
            //                columns: table => new
            //                {
            //                    strURN = table.Column<string>(type: "nvarchar(450)", nullable: false),
            //                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    OtherNames = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    CountryRecovered = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    CountryOrigin = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    CasNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    RtecsNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    UnNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    EcNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    ChemicalFormula = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    PhysicalAppearance = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    ChemicalDangers = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    OccupationalExposureLimitsTLV = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    OccupationalExposureLimitsMAK = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    RoutesOfExposure = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    SpillageDisposal = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Packaging = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Labelling = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    SafeStorage = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    TransportEmergencyCard = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    NfpaCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    UnHazardClass = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    UnSubsidiaryRisks = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    UnPackGroup = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    HazardExposure = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    BoilingPointLow = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    BoilingPointHigh = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    MeltingPointHighLow = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    MeltingPointHigh = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    DensityLow = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    DensityHigh = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    RelativeDensityLow = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    RelativeDensityHigh = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    WaterSolubility = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    VapourPressureLow = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    VapourPressureHigh = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    RelativeVapourDensityLow = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    RelativeVapourDensityHigh = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    FlashPointLow = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    FlashPointHigh = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    AutoIgnitionTempLow = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    AutoIgnitionTempHigh = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    ExplosiveLimits = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    OctanolWaterPartitionLow = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    OctanolWaterPartitionHigh = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    InhalationRisk = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    EnvironmentalData = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    memRemarks = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    dteSent = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
            //                    textSearch = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    ApprovedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    ApprovedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_Chemicals", x => x.strURN);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "CommonLinks",
            //                columns: table => new
            //                {
            //                    strURN = table.Column<string>(type: "nvarchar(450)", nullable: false),
            //                    strURNDest = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    strURNSource = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    strLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
            //                    InformationEvaluation = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    SourceEvaluation = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    intDbIdDest = table.Column<int>(type: "int", nullable: false),
            //                    intDbIdSource = table.Column<int>(type: "int", nullable: false),
            //                    optBiDirectional = table.Column<bool>(type: "bit", nullable: false),
            //                    textSearch = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_CommonLinks", x => x.strURN);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "Communications",
            //                columns: table => new
            //                {
            //                    strURN = table.Column<string>(type: "nvarchar(450)", nullable: false),
            //                    CommType = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    CommDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    CommName = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Other = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    WebValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    ServiceProvider = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    CountryOrigin = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    memRemarks = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    dteSent = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
            //                    textSearch = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    ApprovedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    ApprovedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_Communications", x => x.strURN);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "Components",
            //                columns: table => new
            //                {
            //                    strURN = table.Column<string>(type: "nvarchar(450)", nullable: false),
            //                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    CountryOrigin = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Material = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    MethodDelivery = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    QuantityWeight = table.Column<float>(type: "real", nullable: true),
            //                    QuantityNo = table.Column<float>(type: "real", nullable: true),
            //                    CountryRecovered = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Length = table.Column<float>(type: "real", nullable: true),
            //                    Width = table.Column<float>(type: "real", nullable: true),
            //                    Height = table.Column<float>(type: "real", nullable: true),
            //                    Diameter = table.Column<float>(type: "real", nullable: true),
            //                    Colour = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Markings = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    memRemarks = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    dteSent = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
            //                    textSearch = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Status = table.Column<int>(type: "int", nullable: true),
            //                    ApprovedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    ApprovedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_Components", x => x.strURN);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "DatabaseList",
            //                columns: table => new
            //                {
            //                    strURN = table.Column<string>(type: "nvarchar(450)", nullable: false),
            //                    intType = table.Column<int>(type: "int", nullable: false),
            //                    strTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    strTable = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    strTranslation = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    optTransmit = table.Column<bool>(type: "bit", nullable: false),
            //                    optPhysicalDatabase = table.Column<bool>(type: "bit", nullable: false),
            //                    dteSent = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
            //                    textSearch = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    strControllerName = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_DatabaseList", x => x.strURN);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "Detonator",
            //                columns: table => new
            //                {
            //                    strURN = table.Column<string>(type: "nvarchar(450)", nullable: false),
            //                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Other = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Quantity = table.Column<float>(type: "real", nullable: true),
            //                    CountryOfRecovery = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    CountryOfOrigin = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    CapMaterial = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    CapColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    CapLength = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    CapDiameter = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Crimp = table.Column<int>(type: "int", nullable: true),
            //                    CrimpType = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    PlugColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    PlugMaterial = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    WireColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    WireColor2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    WireDiameter = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    WireMaterial = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    CaseTubeMaterial = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    CaseTubeColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    CaseTubeLength = table.Column<float>(type: "real", nullable: true),
            //                    CaseTubeDiameter = table.Column<float>(type: "real", nullable: true),
            //                    BaseShape = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    BaseMarking = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    BatchCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    MemRemarks = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    StrDateEstablished = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
            //                    textSearch = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Status = table.Column<int>(type: "int", nullable: true),
            //                    ApprovedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    ApprovedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_Detonator", x => x.strURN);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "Equipment",
            //                columns: table => new
            //                {
            //                    strURN = table.Column<string>(type: "nvarchar(450)", nullable: false),
            //                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Quantity = table.Column<int>(type: "int", nullable: false),
            //                    SerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    memRemarks = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    dteSent = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
            //                    textSearch = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    ApprovedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    ApprovedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_Equipment", x => x.strURN);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "Evidence",
            //                columns: table => new
            //                {
            //                    strURN = table.Column<string>(type: "nvarchar(450)", nullable: false),
            //                    Item = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Quantity = table.Column<int>(type: "int", nullable: false),
            //                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    Time = table.Column<TimeSpan>(type: "time", nullable: false),
            //                    CollectedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    memRemarks = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    dteSent = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
            //                    textSearch = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    ApprovedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    ApprovedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    OfficerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_Evidence", x => x.strURN);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "Explosive",
            //                columns: table => new
            //                {
            //                    strURN = table.Column<string>(type: "nvarchar(450)", nullable: false),
            //                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Quantity = table.Column<int>(type: "int", nullable: false),
            //                    MeasurementUnit = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    BrandName = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    CountryOrigin = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    CountryRecovered = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Markings = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Colour = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Packaging = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    ExplosiveLength = table.Column<double>(type: "float", nullable: false),
            //                    ExplosiveWidth = table.Column<double>(type: "float", nullable: false),
            //                    ExplosiveHeight = table.Column<double>(type: "float", nullable: false),
            //                    ExplosiveWeight = table.Column<double>(type: "float", nullable: false),
            //                    ExplosiveDiameter = table.Column<double>(type: "float", nullable: false),
            //                    memRemarks = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    dteSent = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
            //                    textSearch = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    ApprovedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    ApprovedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_Explosive", x => x.strURN);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "Firearms",
            //                columns: table => new
            //                {
            //                    strURN = table.Column<string>(type: "nvarchar(450)", nullable: false),
            //                    Make = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    CountryOrigin = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Impoter = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    SerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    SerialErased = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Action = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Calibre = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Quantity = table.Column<int>(type: "int", nullable: false),
            //                    CountryRecovered = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    BarrelLength = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
            //                    RoundsHeld = table.Column<int>(type: "int", nullable: false),
            //                    Deactivated = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    Reactivated = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    FactoryMade = table.Column<bool>(type: "bit", nullable: false),
            //                    Imitation = table.Column<bool>(type: "bit", nullable: false),
            //                    OwnersCertificateNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    memRemarks = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    dteSent = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
            //                    textSearch = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    ApprovedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    ApprovedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_Firearms", x => x.strURN);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "Group",
            //                columns: table => new
            //                {
            //                    strURN = table.Column<string>(type: "nvarchar(450)", nullable: false),
            //                    GroupName = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    SubCategory = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    CountryOrigin = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    GroupTo = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    HeadName = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    MemGoals = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    strDeclaredByWhom = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Strength = table.Column<int>(type: "int", nullable: false),
            //                    Area = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Province = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    District = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    PostalZip = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    MemRemarks = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    DateEstablished = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
            //                    textSearch = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    GroupReportingAgency = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    ApprovedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    ApprovedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_Group", x => x.strURN);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "Incident",
            //                columns: table => new
            //                {
            //                    strURN = table.Column<string>(type: "nvarchar(450)", nullable: false),
            //                    strOperationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    FirNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    INC_FirNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    RegYear = table.Column<int>(type: "int", nullable: false),
            //                    US = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Province = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    District = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    PostalZip = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    PoliceStation = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    IncidentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    IncidentTime = table.Column<TimeSpan>(type: "time", nullable: false),
            //                    IncidentTimeEnd = table.Column<TimeSpan>(type: "time", nullable: false),
            //                    Latitude = table.Column<double>(type: "float", nullable: false),
            //                    Longitude = table.Column<double>(type: "float", nullable: false),
            //                    NumberKilled = table.Column<int>(type: "int", nullable: false),
            //                    NumberInjured = table.Column<int>(type: "int", nullable: false),
            //                    InjuredName = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    CasualtiesNames = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    SuicideBomb = table.Column<bool>(type: "bit", nullable: false),
            //                    CTWRemarks = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Target = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Motive = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Recoveries = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    CrimeSceneRecoveries = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    CaseStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    strCaseProgress = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Weapon = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    dteSent = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
            //                    textSearch = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    NumberArrested = table.Column<int>(type: "int", nullable: false),
            //                    PreIncidentThread = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Reportedby = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    ApprovedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    ApprovedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_Incident", x => x.strURN);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "InitiationSystems",
            //                columns: table => new
            //                {
            //                    strURN = table.Column<string>(type: "nvarchar(450)", nullable: false),
            //                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Electric = table.Column<bool>(type: "bit", nullable: false),
            //                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Other = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Make = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    CountryOrigin = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Size = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Length = table.Column<double>(type: "float", nullable: false),
            //                    Width = table.Column<double>(type: "float", nullable: false),
            //                    Height = table.Column<double>(type: "float", nullable: false),
            //                    Diameter = table.Column<double>(type: "float", nullable: false),
            //                    Voltage = table.Column<int>(type: "int", nullable: false),
            //                    Markings = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    BatchCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    SerialNumbers = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Colour = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    NumberRecovered = table.Column<int>(type: "int", nullable: false),
            //                    CountryRecovered = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    memRemarks = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    dteSent = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
            //                    textSearch = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    ApprovedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    ApprovedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_InitiationSystems", x => x.strURN);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "IpLogs",
            //                columns: table => new
            //                {
            //                    strURN = table.Column<string>(type: "nvarchar(450)", nullable: false),
            //                    IP = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    intID = table.Column<int>(type: "int", nullable: false),
            //                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
            //                    textSearch = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_IpLogs", x => x.strURN);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "MacAddress",
            //                columns: table => new
            //                {
            //                    intID = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    strURN = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    MAC_Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    DepartmentID = table.Column<int>(type: "int", nullable: true),
            //                    OfficeID = table.Column<int>(type: "int", nullable: true),
            //                    ComputerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    UserID = table.Column<int>(type: "int", nullable: true),
            //                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    IsDeleted = table.Column<int>(type: "int", nullable: true)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_MacAddress", x => x.intID);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "MediaFile",
            //                columns: table => new
            //                {
            //                    strURN = table.Column<string>(type: "nvarchar(450)", nullable: false),
            //                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    ContentType = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    ContentLength = table.Column<int>(type: "int", nullable: false),
            //                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
            //                    textSearch = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_MediaFile", x => x.strURN);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "Ordinance",
            //                columns: table => new
            //                {
            //                    strURN = table.Column<string>(type: "nvarchar(450)", nullable: false),
            //                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Other = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    BrandName = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    CountryRecovered = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    CountryOrigin = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    ExplosiveWeight = table.Column<float>(type: "real", nullable: true),
            //                    memMarkings = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    BatchCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    SerialNumbers = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Colour = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Calibre = table.Column<float>(type: "real", nullable: true),
            //                    HeadStamp = table.Column<bool>(type: "bit", nullable: true),
            //                    Length = table.Column<float>(type: "real", nullable: true),
            //                    Width = table.Column<float>(type: "real", nullable: true),
            //                    Depth = table.Column<float>(type: "real", nullable: true),
            //                    Diameter = table.Column<float>(type: "real", nullable: true),
            //                    NumberRecovered = table.Column<float>(type: "real", nullable: true),
            //                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
            //                    textSearch = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_Ordinance", x => x.strURN);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "Person",
            //                columns: table => new
            //                {
            //                    strURN = table.Column<string>(type: "nvarchar(450)", nullable: false),
            //                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    CurrentStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    ReportingAgency = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    NHeadMoney = table.Column<int>(type: "int", nullable: true),
            //                    AccusationStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Aliases = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    FatherName = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    FamilyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    DOB = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    PlaceOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Tribe = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    CNIC = table.Column<long>(type: "bigint", nullable: true),
            //                    MaritalStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Religion = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Occupation = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Education = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    NormalDress = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    BodyStructure = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    BodyBuild = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    BeardColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    BaldType = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Height = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    HeightInFeet = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Complexion = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    IdentificationMark = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    PermanentIdentificationMark = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    DistinguishingMarks = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    CovertAppearance = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    OvertAppearance = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    TalkingStyle = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    VoicePitch = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    HairCutStyle = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    HairType = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    HairColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    HairImplants = table.Column<bool>(type: "bit", nullable: false),
            //                    Wig = table.Column<bool>(type: "bit", nullable: false),
            //                    CheekStructure = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    ContactLenses = table.Column<bool>(type: "bit", nullable: true),
            //                    VFaceShape = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    EarStructure = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    EyeColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    EyeLook = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Eyebrows = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    EyeGlasses = table.Column<bool>(type: "bit", nullable: true),
            //                    NoseStructure = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    LipStucture = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Mustaches = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    MustachesColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    memRemarks = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
            //                    textSearch = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    iSHeadMoney = table.Column<bool>(type: "bit", nullable: false),
            //                    isActive = table.Column<bool>(type: "bit", nullable: false),
            //                    FirNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Age = table.Column<int>(type: "int", nullable: true),
            //                    Sect = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Affiliation = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Languages = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Status = table.Column<int>(type: "int", nullable: true),
            //                    ApprovedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    ApprovedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_Person", x => x.strURN);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "PowerSource",
            //                columns: table => new
            //                {
            //                    strURN = table.Column<string>(type: "nvarchar(450)", nullable: false),
            //                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Width = table.Column<float>(type: "real", nullable: true),
            //                    Other = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Make = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    CountryOrigin = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    CountryRecovered = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Markings = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Colour = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    SerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Height = table.Column<float>(type: "real", nullable: true),
            //                    Voltage = table.Column<float>(type: "real", nullable: true),
            //                    Diameter = table.Column<float>(type: "real", nullable: true),
            //                    Length = table.Column<float>(type: "real", nullable: true),
            //                    memRemarks = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
            //                    textSearch = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    BatchCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    NumberRecovered = table.Column<int>(type: "int", nullable: true),
            //                    Size = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Status = table.Column<int>(type: "int", nullable: true),
            //                    ApprovedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    ApprovedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_PowerSource", x => x.strURN);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "SocialMedia",
            //                columns: table => new
            //                {
            //                    ProfileID = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    SocialMediaProfile = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    PersonstrURN = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_SocialMedia", x => x.ProfileID);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "tblCNIC",
            //                columns: table => new
            //                {
            //                    intID = table.Column<int>(type: "int", nullable: false)
            //                        .Annotation("SqlServer:Identity", "1, 1"),
            //                    strURN = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    strCNIC = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    strCountry = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    optOld = table.Column<double>(type: "float", nullable: true),
            //                    strLegacyCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    strPrimaryMediaImageUrn = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    optLibrary = table.Column<double>(type: "float", nullable: true),
            //                    optTransmit = table.Column<double>(type: "float", nullable: true),
            //                    memRemarks = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    excl_memTextSearch = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    optCompliance = table.Column<double>(type: "float", nullable: true),
            //                    strSecurityRating = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    strCreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    dteCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    dteSent = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    dteLastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    strLastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_tblCNIC", x => x.intID);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "tblPassport",
            //                columns: table => new
            //                {
            //                    strURN = table.Column<string>(type: "nvarchar(450)", nullable: false),
            //                    strPassportNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    strCountry = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    dteIssue = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    strPlaceIssue = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    dteExpire = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    strLegacyCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    strPrimaryMediaImageUrn = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    optLibrary = table.Column<bool>(type: "bit", nullable: true),
            //                    optTransmit = table.Column<bool>(type: "bit", nullable: true),
            //                    memRemarks = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    excl_memTextSearch = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    optCompliance = table.Column<bool>(type: "bit", nullable: true),
            //                    strSecurityRating = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    strCreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    dteCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    dteSent = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    dteLastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    strLastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_tblPassport", x => x.strURN);
            //                });

            //            migrationBuilder.CreateTable(
            //                name: "Vehicle",
            //                columns: table => new
            //                {
            //                    strURN = table.Column<string>(type: "nvarchar(450)", nullable: false),
            //                    VehicleType = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    VehicleSubType = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    MakeModel = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    RegistrationNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    ChasesNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    size = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    DeviceLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    memRemarks = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    dteSent = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
            //                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
            //                    textSearch = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //                    Status = table.Column<int>(type: "int", nullable: true),
            //                    ApprovedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
            //                    ApprovedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //                },
            //                constraints: table =>
            //                {
            //                    table.PrimaryKey("PK_Vehicle", x => x.strURN);
            //                });
            //        }

            //        protected override void Down(MigrationBuilder migrationBuilder)
            //        {
            //            migrationBuilder.DropTable(
            //                name: "Address");

            //            migrationBuilder.DropTable(
            //                name: "BaseLogs");

            //            migrationBuilder.DropTable(
            //                name: "CBRNs");

            //            migrationBuilder.DropTable(
            //                name: "Chemicals");

            //            migrationBuilder.DropTable(
            //                name: "CommonLinks");

            //            migrationBuilder.DropTable(
            //                name: "Communications");

            //            migrationBuilder.DropTable(
            //                name: "Components");

            //            migrationBuilder.DropTable(
            //                name: "DatabaseList");

            //            migrationBuilder.DropTable(
            //                name: "Detonator");

            //            migrationBuilder.DropTable(
            //                name: "Equipment");

            //            migrationBuilder.DropTable(
            //                name: "Evidence");

            //            migrationBuilder.DropTable(
            //                name: "Explosive");

            //            migrationBuilder.DropTable(
            //                name: "Firearms");

            //            migrationBuilder.DropTable(
            //                name: "Group");

            //            migrationBuilder.DropTable(
            //                name: "Incident");

            //            migrationBuilder.DropTable(
            //                name: "InitiationSystems");

            //            migrationBuilder.DropTable(
            //                name: "IpLogs");

            //            migrationBuilder.DropTable(
            //                name: "MacAddress");

            //            migrationBuilder.DropTable(
            //                name: "MediaFile");

            //            migrationBuilder.DropTable(
            //                name: "Ordinance");

            //            migrationBuilder.DropTable(
            //                name: "Person");

            //            migrationBuilder.DropTable(
            //                name: "PowerSource");

            //            migrationBuilder.DropTable(
            //                name: "SocialMedia");

            //            migrationBuilder.DropTable(
            //                name: "tblCNIC");

            //            migrationBuilder.DropTable(
            //                name: "tblPassport");

            //            migrationBuilder.DropTable(
            //                name: "Vehicle");

            //            migrationBuilder.AlterColumn<string>(
            //                name: "strURN",
            //                table: "ReportingAgency",
            //                type: "nvarchar(max)",
            //                nullable: false,
            //                defaultValue: "",
            //                oldClrType: typeof(string),
            //                oldType: "nvarchar(max)",
            //                oldNullable: true);

            //            migrationBuilder.AlterColumn<string>(
            //                name: "UpdatedBy",
            //                table: "ReportingAgency",
            //                type: "nvarchar(max)",
            //                nullable: false,
            //                defaultValue: "",
            //                oldClrType: typeof(string),
            //                oldType: "nvarchar(max)",
            //                oldNullable: true);

            //            migrationBuilder.AlterColumn<string>(
            //                name: "ReportingAgencyTitle",
            //                table: "ReportingAgency",
            //                type: "nvarchar(max)",
            //                nullable: false,
            //                defaultValue: "",
            //                oldClrType: typeof(string),
            //                oldType: "nvarchar(max)",
            //                oldNullable: true);

            //            migrationBuilder.AlterColumn<string>(
            //                name: "CreatedBy",
            //                table: "ReportingAgency",
            //                type: "nvarchar(max)",
            //                nullable: false,
            //                defaultValue: "",
            //                oldClrType: typeof(string),
            //                oldType: "nvarchar(max)",
            //                oldNullable: true);
        }
    }
}
