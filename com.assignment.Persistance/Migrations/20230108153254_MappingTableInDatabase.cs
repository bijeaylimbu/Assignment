using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace com.assignment.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class MappingTableInDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tariff_master",
                columns: table => new
                {
                    tariffid = table.Column<int>(name: "tariff_id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    rebatedays = table.Column<int>(name: "rebate_days", type: "int", nullable: false),
                    rebaterate = table.Column<long>(name: "rebate_rate", type: "bigint", nullable: false),
                    penaltydays = table.Column<int>(name: "penalty_days", type: "int", nullable: false),
                    penaltyrate = table.Column<long>(name: "penalty_rate", type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tariff_master", x => x.tariffid);
                });

            migrationBuilder.CreateTable(
                name: "tariff_details",
                columns: table => new
                {
                    tariffid = table.Column<int>(name: "tariff_id", type: "int", nullable: false),
                    startunit = table.Column<int>(name: "start_unit", type: "int", nullable: false),
                    endunit = table.Column<int>(name: "end_unit", type: "int", nullable: false),
                    energyrate = table.Column<long>(name: "energy_rate", type: "bigint", nullable: false),
                    servicecharge = table.Column<long>(name: "service_charge", type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tariff_details", x => x.tariffid);
                    table.ForeignKey(
                        name: "fk_tariff_details_tariff_masters_tarif_master_temp_id",
                        column: x => x.tariffid,
                        principalTable: "tariff_master",
                        principalColumn: "tariff_id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tariff_details");

            migrationBuilder.DropTable(
                name: "tariff_master");
        }
    }
}
