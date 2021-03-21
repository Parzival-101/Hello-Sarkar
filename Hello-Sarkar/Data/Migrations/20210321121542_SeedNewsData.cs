using Microsoft.EntityFrameworkCore.Migrations;

namespace Hello_Sarkar.Data.Migrations
{
    public partial class SeedNewsData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "Info",
                value: "Over 500,000 entrepreneurs affected by Covid-19 have received an income tax exemption of over Rs2 billion, the tax authority has said.Section 25 of the Financial Act 2020 - 21 provisions tax exemption for taxpayers depending on the size of their annual transactions.According to the Inland Revenue Department, the government waived the income tax amounting to Rs2.16 billion for 512, 753 taxpayers under this scheme.“They were given an opportunity till mid - March this year to pay a certain portion of their tax liability of the last fiscal year and get the rest of their tax liabilities waived off,” said Arjun Dhakal, information officer at the department.The first category of taxpayers receiving the discount are those whose annual transaction is up to Rs2 million or those whose annual income is up to Rs200, 000 and need to pay the tax.As per the Financial Act, they are supposed to get an exemption of 75 percent of the total tax liability in fiscal year 2019 - 20.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "Info",
                value: "Over 500,000 entrepreneurs affected by Covid-19 have received an income tax exemption of over Rs2 billion, the tax authority has said.Section 25 of the Financial Act 2020 - 21 provisions tax exemption for taxpayers depending on the size of their annual transactions.According to the Inland Revenue Department, the government waived the income tax amounting to Rs2.16 billion for 512, 753 taxpayers under this scheme.“They were given an opportunity till mid - March this year to pay a certain portion of their tax liability of the last fiscal year and get the rest of their tax liabilities waived off,” said Arjun Dhakal, information officer at the department.The first category of taxpayers receiving the discount are those whose annual transaction is up to Rs2 million or those whose annual income is up to Rs200, 000 and need to pay the tax.As per the Financial Act, they are supposed to get an exemption of 75 percent of the total tax liability in fiscal year 2019 - 20.According to the Inland Revenue Department, a total of 443, 075 taxpayers falling under this category received the exemption for Rs1.5 billion.The second category of taxpayers to receive the exemption are those whose annual transaction is Rs2 to 5 million.They are supposed to get a 50 percent waiver of their total tax liability in the fiscal year 2019 - 20, according to the Financial Act(2020 - 21).According to the department, a total of 19, 700 taxpayers under this category enjoyed this facility, getting an exemption of Rs208.5 million in tax dues.The third category of taxpayers to receive the exemption are those whose annual transactions are up to Rs10 million.As per the Financial Act, they are supposed to get a tax waiver of 25 percent on the tax liability in the last fiscal year.According to the tax authority, a total of 49, 700 taxpayers get a tax waiver of Rs393.2 million.The fourth category of taxpayers to receive the waiver under the scheme are entrepreneurs involved in the tourism sector including hotel, travel, trekking, transport and aviation sectors.People in these sectors having annual transactions over Rs 10 million are supposed to get a 20 percent tax waiver.According to the tax authority, a total of 278 taxpayers from this category got a waiver of Rs56.29 million in total from their tax liabilities of last fiscal year.Information Officer Dhakal said businesses and tourism sectors were badly affected by the Covid - 19 pandemic last fiscal year and the government introduced the scheme as relief measures to affected sectors.Particularly, this scheme aims to address the plight of small enterprises and the tourism industry, which suffered badly from the pandemic.A survey report released by Nepal Rastra Bank in August revealed the grave condition of the micro, small and medium enterprises with a majority of them being closed completely compared to bigger enterprises during the nearly four - month long lockdown.Over 60 percent of micro and small enterprises were fully closed during the lockdown compared to less than 50 percent enterprises above medium enterprises were closed fully, according to the survey.Over 95 percent small and cottage industries had responded saying that their business went down by over 73 percent, according to the survey.The lockdown was imposed from March 24 to July 21 last year.");
        }
    }
}
