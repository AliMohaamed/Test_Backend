using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodePulse_API.Migrations.AuthDb
{
    /// <inheritdoc />
    public partial class InitialMigrationForAuth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dfb53c3a-1caf-4165-a4d4-92f615c1cb88",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "41cb6386-3a79-4596-83c0-4a7b6c907c99", "AQAAAAIAAYagAAAAECzfdSC1hQt7Ln89yDw9OcVT9XJ3eWGbw4fcEJvZ2vZTLA/P3RzTv5hAG4aTWEWckQ==", "7988a60d-cb40-4cfa-ae43-b289c2cdcfab" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dfb53c3a-1caf-4165-a4d4-92f615c1cb88",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0512e421-d493-43b6-bd4c-40f833e9bd86", "AQAAAAIAAYagAAAAEM0j+0Dgf7GhsvypfSXZmDCfvGDvo12WgxwU/8I2kaW8o440f4okF4gs9lBACGl5Wg==", "735d22d0-f9b1-4d95-9389-8fc4ad967351" });
        }
    }
}
