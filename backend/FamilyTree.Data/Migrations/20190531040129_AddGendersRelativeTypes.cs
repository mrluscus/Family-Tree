using Microsoft.EntityFrameworkCore.Migrations;

namespace FamilyTree.Data.Migrations
{
    public partial class AddGendersRelativeTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Gender", new[] { "Code", "Name" }, new[] { "male", "Муж" });
            migrationBuilder.InsertData("Gender", new[] { "Code", "Name" }, new[] { "female", "Жен" });

            migrationBuilder.InsertData("RelativeType", new[] { "Code", "Name" }, new[] { "mother", "Мать" });
            migrationBuilder.InsertData("RelativeType", new[] { "Code", "Name" }, new[] { "father", "Отец" });
            migrationBuilder.InsertData("RelativeType", new[] { "Code", "Name" }, new[] { "son", "Сын" });
            migrationBuilder.InsertData("RelativeType", new[] { "Code", "Name" }, new[] { "daughter", "Дочь" });
            migrationBuilder.InsertData("RelativeType", new[] { "Code", "Name" }, new[] { "brother", "Брат" });
            migrationBuilder.InsertData("RelativeType", new[] { "Code", "Name" }, new[] { "sister", "Сестра" });
            migrationBuilder.InsertData("RelativeType", new[] { "Code", "Name" }, new[] { "grandmother", "Бабушка" });
            migrationBuilder.InsertData("RelativeType", new[] { "Code", "Name" }, new[] { "grandfather", "Дедушка" });
            migrationBuilder.InsertData("RelativeType", new[] { "Code", "Name" }, new[] { "husband", "Муж" });
            migrationBuilder.InsertData("RelativeType", new[] { "Code", "Name" }, new[] { "wife", "Жена" });
            migrationBuilder.InsertData("RelativeType", new[] { "Code", "Name" }, new[] { "cohabiting", "Сожитель" });
            migrationBuilder.InsertData("RelativeType", new[] { "Code", "Name" }, new[] { "adopted-mather", "Приёмная мать" });
            migrationBuilder.InsertData("RelativeType", new[] { "Code", "Name" }, new[] { "adopted-father", "Приёмный отец" });
            migrationBuilder.InsertData("RelativeType", new[] { "Code", "Name" }, new[] { "adopted-son", "Приёмный сын" });
            migrationBuilder.InsertData("RelativeType", new[] { "Code", "Name" }, new[] { "adopted-daughter", "Приёмная дочь" });
            migrationBuilder.InsertData("RelativeType", new[] { "Code", "Name" }, new[] { "uncle", "Дядя" });
            migrationBuilder.InsertData("RelativeType", new[] { "Code", "Name" }, new[] { "aunt", "Тётя" });
            migrationBuilder.InsertData("RelativeType", new[] { "Code", "Name" }, new[] { "nephew", "Племянник" });
            migrationBuilder.InsertData("RelativeType", new[] { "Code", "Name" }, new[] { "niece", "Племянница" });
            migrationBuilder.InsertData("RelativeType", new[] { "Code", "Name" }, new[] { "cousin-male", "Двоюродный брат" });
            migrationBuilder.InsertData("RelativeType", new[] { "Code", "Name" }, new[] { "cousin-female", "Двоюродная сестра" });

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}
