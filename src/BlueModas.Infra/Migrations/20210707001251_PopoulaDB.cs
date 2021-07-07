using Microsoft.EntityFrameworkCore.Migrations;

namespace BlueModas.Infra.Migrations
{
    public partial class PopoulaDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                @"insert into Product values (
                    newid(), 
                    'Camiseta Lost Bomb', 
                    'Produzida com 100% algodão com fios penteado', 
                    89.90, 
                    'https://lostbrasil.vteximg.com.br/arquivos/ids/161393-400-400/Camiseta-Lost-Bomb-0.jpg?v=637527947815930000')");

            migrationBuilder.Sql(
                @"insert into Product values (
                    newid(), 
                    'Camiseta Lost Stripped Ful', 
                    'Malha digital TSOL 100% Algodão', 
                    159.90, 
                    'https://lostbrasil.vteximg.com.br/arquivos/ids/161889-400-400/Camiseta-Lost-Stripped-Ful-0.jpg?v=637582433194700000')");

            migrationBuilder.Sql(
               @"insert into Product values (
                    newid(), 
                    'Jaqueta Corta Vento Lost', 
                    'Malha digital TSOL 100% Algodão', 
                    299.90, 
                    'https://lostbrasil.vteximg.com.br/arquivos/ids/159319-400-400/Jaqueta-Corta-Vento-Lost-Pocket.jpg?v=637232710424870000')");

            migrationBuilder.Sql(
               @"insert into Product values (
                    newid(), 
                    'Camiseta Lost Slackers', 
                    'Produzida com 100% algodão com fios penteado', 
                    79.90, 
                    'https://lostbrasil.vteximg.com.br/arquivos/ids/159389-400-400/Camiseta-Lost-Slackers.jpg?v=637275085885330000')");

            migrationBuilder.Sql(
               @"insert into Product values (
                    newid(), 
                    'Camiseta Lost Tsol Full', 
                    'Malha digital TSOL 100% Algodão', 
                    189.90, 
                    'https://lostbrasil.vteximg.com.br/arquivos/ids/161777-1000-1000/Camiseta-Lost-Tsol-Full-0.jpg?v=637575487558400000')");

            migrationBuilder.Sql(
      @"insert into Product values (
                    newid(), 
                    'Camiseta Lost Sheep Line', 
                    'Malha digital TSOL 100% Algodão', 
                    89.90, 
                    'https://lostbrasil.vteximg.com.br/arquivos/ids/161907-1000-1000/Camiseta-Lost-Sheep-Line-0.jpg?v=637582434883570000')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete Product");
        }
    }
}
