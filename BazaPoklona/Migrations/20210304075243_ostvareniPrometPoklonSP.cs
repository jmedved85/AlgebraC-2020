using Microsoft.EntityFrameworkCore.Migrations;

namespace BazaPoklona.Migrations
{
    public partial class ostvareniPrometPoklonSP : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           
            string procedure = @"Create procedure ostvareniPrometPoklonSP
                                AS
                                BEGIN
                                SELECT 
	                                max(Naziv) AS NazivRobe,
	                                VrstaRobe, 
	                                sum(Cijena) AS UkupnoPoVrstiRobe
	                                FROM dbo.Poklon
	                                GROUP BY VrstaRobe
                                END";
            migrationBuilder.Sql(procedure);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
          

            string procedure = @"Drop procedure ostvareniPrometPoklonSP";
                                
            migrationBuilder.Sql(procedure);
        }
    }
}
