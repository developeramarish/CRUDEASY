using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace EasyCrud.Migrations
{
    public partial class ALterTable_NewProps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Android",
                table: "Knowledges",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Angular",
                table: "Knowledges",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Asp",
                table: "Knowledges",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Bootstrap",
                table: "Knowledges",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "C",
                table: "Knowledges",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Cake",
                table: "Knowledges",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Cplusplus",
                table: "Knowledges",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Css",
                table: "Knowledges",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Django",
                table: "Knowledges",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Html",
                table: "Knowledges",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Illustrator",
                table: "Knowledges",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Ios",
                table: "Knowledges",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Java",
                table: "Knowledges",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Jquery",
                table: "Knowledges",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Magento",
                table: "Knowledges",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MySql",
                table: "Knowledges",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Others",
                table: "Knowledges",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Photoshop",
                table: "Knowledges",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Php",
                table: "Knowledges",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Python",
                table: "Knowledges",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Ruby",
                table: "Knowledges",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Salesforce",
                table: "Knowledges",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Seo",
                table: "Knowledges",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SqlServer",
                table: "Knowledges",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Wordpress",
                table: "Knowledges",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Account",
                table: "Candidates",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Afternoon",
                table: "Candidates",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Agency",
                table: "Candidates",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BankName",
                table: "Candidates",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CPFRecipient",
                table: "Candidates",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cellphone",
                table: "Candidates",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Chain",
                table: "Candidates",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Candidates",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Comercial",
                table: "Candidates",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "CrudLink",
                table: "Candidates",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Dawn",
                table: "Candidates",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "EightHours",
                table: "Candidates",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Candidates",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FourHours",
                table: "Candidates",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "FourSixHours",
                table: "Candidates",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HoursOnWeekends",
                table: "Candidates",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LinkedinAddress",
                table: "Candidates",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Morning",
                table: "Candidates",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Night",
                table: "Candidates",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Portfolio",
                table: "Candidates",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Recipient",
                table: "Candidates",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Salary",
                table: "Candidates",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Savings",
                table: "Candidates",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SixEightHours",
                table: "Candidates",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SkypeAddress",
                table: "Candidates",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Candidates",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Android",
                table: "Knowledges");

            migrationBuilder.DropColumn(
                name: "Angular",
                table: "Knowledges");

            migrationBuilder.DropColumn(
                name: "Asp",
                table: "Knowledges");

            migrationBuilder.DropColumn(
                name: "Bootstrap",
                table: "Knowledges");

            migrationBuilder.DropColumn(
                name: "C",
                table: "Knowledges");

            migrationBuilder.DropColumn(
                name: "Cake",
                table: "Knowledges");

            migrationBuilder.DropColumn(
                name: "Cplusplus",
                table: "Knowledges");

            migrationBuilder.DropColumn(
                name: "Css",
                table: "Knowledges");

            migrationBuilder.DropColumn(
                name: "Django",
                table: "Knowledges");

            migrationBuilder.DropColumn(
                name: "Html",
                table: "Knowledges");

            migrationBuilder.DropColumn(
                name: "Illustrator",
                table: "Knowledges");

            migrationBuilder.DropColumn(
                name: "Ios",
                table: "Knowledges");

            migrationBuilder.DropColumn(
                name: "Java",
                table: "Knowledges");

            migrationBuilder.DropColumn(
                name: "Jquery",
                table: "Knowledges");

            migrationBuilder.DropColumn(
                name: "Magento",
                table: "Knowledges");

            migrationBuilder.DropColumn(
                name: "MySql",
                table: "Knowledges");

            migrationBuilder.DropColumn(
                name: "Others",
                table: "Knowledges");

            migrationBuilder.DropColumn(
                name: "Photoshop",
                table: "Knowledges");

            migrationBuilder.DropColumn(
                name: "Php",
                table: "Knowledges");

            migrationBuilder.DropColumn(
                name: "Python",
                table: "Knowledges");

            migrationBuilder.DropColumn(
                name: "Ruby",
                table: "Knowledges");

            migrationBuilder.DropColumn(
                name: "Salesforce",
                table: "Knowledges");

            migrationBuilder.DropColumn(
                name: "Seo",
                table: "Knowledges");

            migrationBuilder.DropColumn(
                name: "SqlServer",
                table: "Knowledges");

            migrationBuilder.DropColumn(
                name: "Wordpress",
                table: "Knowledges");

            migrationBuilder.DropColumn(
                name: "Account",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "Afternoon",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "Agency",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "BankName",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "CPFRecipient",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "Cellphone",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "Chain",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "Comercial",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "CrudLink",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "Dawn",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "EightHours",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "FourHours",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "FourSixHours",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "HoursOnWeekends",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "LinkedinAddress",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "Morning",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "Night",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "Portfolio",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "Recipient",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "Salary",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "Savings",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "SixEightHours",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "SkypeAddress",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Candidates");
        }
    }
}
