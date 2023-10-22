using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UygunsuzlukRaporuProjesi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCrate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Unsuitabilities",
                columns: table => new
                {
                    UnsuitabilityNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnsuitabilityType = table.Column<int>(type: "int", nullable: false),
                    OrderNumber = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ProjectNumber = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    WorkOrderNumber = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    PartNumber = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    UnsuitabilityData = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PartRevisionNumber = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    UnsuitabilityDetectedCenterNumber = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    UnsuitabilityDetectedOperationNumber = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ProductionQuantity = table.Column<int>(type: "int", nullable: false),
                    AcceptedQuantity = table.Column<int>(type: "int", nullable: false),
                    UnsuitabilityQuantity = table.Column<int>(type: "int", nullable: false),
                    UnsuitabilePersonel = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    UnsuitabileSection = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    SerialNumber = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CustomerInfo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    UnsuitabilityDefinition = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    UnsuitabilityIdentifierInfo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    UnsuitabilityIdentifiingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UnsuitabilityConfirmerInfo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    UnsuitabilityConfirmingInfo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmergencySolution = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: true),
                    EmergencySolutionWriterInfo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    EmergencySolutionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UnsuitabilityCodeAndDescription = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsCustomerProduct = table.Column<bool>(type: "bit", nullable: false),
                    IsDfActivityRequired = table.Column<bool>(type: "bit", nullable: false),
                    ActionForRefusingUnsuitability = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false),
                    ActionForRefusingUnsuitabilityPersonelInfo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ActionForRefusingUnsuitabilityDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AuditResult = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false),
                    UnsuitabilityDetectorPersonelInfo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    UnsuitabilityDetectionDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unsuitabilities", x => x.UnsuitabilityNumber);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Unsuitabilities");
        }
    }
}
