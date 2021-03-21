using Hello_Sarkar.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hello_Sarkar.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<News>().HasData(
                new News
                {
                    Id=1,
                    Title = "CIAA Files Corruption Case Against 17, Including 7 Govt. Officials!",
                    Info = "The Commission for the Investigation of Abuse of Authority (CIAA) on registered a corruption" +
                    " case against 17 people, including seven government officials, for illegally transferring government " +
                    "land in Lalitpur to a private housing company.According to the CIAA Spokesperson Taranath Adhikari" +
                    ",the accused transferred the ownership of the land to the private company by tampering the survey " +
                    "map published in 2022 BS.The private company then sold the land to the general public.The transferred " +
                    "land is spread over an area of eight ropanis in wards 23 and 28 of Lalitpur Metropolitan City.",
                    Source= "NepaliSansar"
                },
                new News
                {
                    Id=2,
                    Title ="Over 500,000 taxpayers hit by pandemic get tax waiver worth over Rs2 billion",
                    Info= "Over 500,000 entrepreneurs affected by Covid-19 have received an income tax exemption of over Rs2" +
                    " billion, the tax authority has said.Section 25 of the Financial Act 2020 - 21 provisions tax exemption " +
                    "for taxpayers depending on the size of their annual transactions.According to the Inland Revenue Department" +
                    ", the government waived the income tax amounting to Rs2.16 billion for 512, 753 taxpayers under this scheme." +
                    "“They were given an opportunity till mid - March this year to pay a certain portion of their tax liability" +
                    " of the last fiscal year and get the rest of their tax liabilities waived off,” said Arjun Dhakal, information " +
                    "officer at the department.The first category of taxpayers receiving the discount are those whose annual transaction" +
                    " is up to Rs2 million or those whose annual income is up to Rs200, 000 and need to pay the tax.As per the Financial" +
                    " Act, they are supposed to get an exemption of 75 percent of the total tax liability in fiscal year 2019 - 20." ,
          

                    Source="Kathmandupost"
                }
                );
        }
    }
}
