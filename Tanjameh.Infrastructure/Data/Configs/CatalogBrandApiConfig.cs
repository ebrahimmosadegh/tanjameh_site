

using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Tanjameh.Core.Entities;
using Tanjameh.Core.Constants;

namespace Tanjameh.Infrastructure.Data.Configs;


internal class CatalogBrandApiConfig : IEntityTypeConfiguration<CatalogBrandApi>
{
    public void Configure(EntityTypeBuilder<CatalogBrandApi> builder)
    {
        builder.HasData(

        new CatalogBrandApi
        {
            Id = 1,
            ApiId = 14644,
            ApiName = ApiNames.Asos,
            Name = "Hollister",
            CatalogBrandId = 1,
        },
        new CatalogBrandApi
        {
            Id = 2,
            ApiId = 53,
            ApiName = ApiNames.Asos,
            Name = "ASOS DESIGN",
            CatalogBrandId = 2,
        },
        new CatalogBrandApi
        {
            Id = 3,
            ApiId = 3682,
            ApiName = ApiNames.Asos,
            Name = "Carhartt WIP",
            CatalogBrandId = 3,
        },
        new CatalogBrandApi
        {
            Id = 4,
            ApiId = 2986,
            ApiName = ApiNames.Asos,
            Name = "Nike",
            CatalogBrandId = 4,
        },
        new CatalogBrandApi
        {
            Id = 5,
            ApiId = 12983,
            ApiName = ApiNames.Asos,
            Name = "River Island",
            CatalogBrandId = 5,
        },
        new CatalogBrandApi
        {
            Id = 6,
            ApiId = 14920,
            ApiName = ApiNames.Asos,
            Name = "Sixth June",
            CatalogBrandId = 6,
        },
        new CatalogBrandApi
        {
            Id = 7,
            ApiId = 16522,
            ApiName = ApiNames.Asos,
            Name = "Gramicci",
            CatalogBrandId = 7,
        },
        new CatalogBrandApi
        {
            Id = 8,
            ApiId = 12461,
            ApiName = ApiNames.Asos,
            Name = "Jack & Jones",
            CatalogBrandId = 8,
        },
        new CatalogBrandApi
        {
            Id = 9,
            ApiId = 401,
            ApiName = ApiNames.Asos,
            Name = "Levi's",
            CatalogBrandId = 9,
        },
        new CatalogBrandApi
        {
            Id = 10,
            ApiId = 14370,
            ApiName = ApiNames.Asos,
            Name = "Abercrombie & Fitch",
            CatalogBrandId = 10,
        },
        new CatalogBrandApi
        {
            Id = 11,
            ApiId = 3253,
            ApiName = ApiNames.Asos,
            Name = "Dickies",
            CatalogBrandId = 11,
        },
        new CatalogBrandApi
        {
            Id = 12,
            ApiId = 3312,
            ApiName = ApiNames.Asos,
            Name = "The North Face",
            CatalogBrandId = 12,
        },
        new CatalogBrandApi
        {
            Id = 13,
            ApiId = 18,
            ApiName = ApiNames.Asos,
            Name = "adidas Originals",
            CatalogBrandId = 13,
        },
        new CatalogBrandApi
        {
            Id = 14,
            ApiId = 12769,
            ApiName = ApiNames.Asos,
            Name = "Reclaimed Vintage",
            CatalogBrandId = 14,
        },
        new CatalogBrandApi
        {
            Id = 15,
            ApiId = 14441,
            ApiName = ApiNames.Asos,
            Name = "ONLY & SONS",
            CatalogBrandId = 15,
        },
        new CatalogBrandApi
        {
            Id = 16,
            ApiId = 14403,
            ApiName = ApiNames.Asos,
            Name = "Element",
            CatalogBrandId = 16,
        },
        new CatalogBrandApi
        {
            Id = 17,
            ApiId = 2943,
            ApiName = ApiNames.Asos,
            Name = "Fred Perry",
            CatalogBrandId = 17,
        },
        new CatalogBrandApi
        {
            Id = 18,
            ApiId = 75,
            ApiName = ApiNames.Asos,
            Name = "Ben Sherman",
            CatalogBrandId = 18,
        },
        new CatalogBrandApi
        {
            Id = 19,
            ApiId = 14159,
            ApiName = ApiNames.Asos,
            Name = "Selected Homme",
            CatalogBrandId = 19,
        },
        new CatalogBrandApi
        {
            Id = 20,
            ApiId = 16545,
            ApiName = ApiNames.Asos,
            Name = "Nike Golf",
            CatalogBrandId = 20,
        },
        new CatalogBrandApi
        {
            Id = 21,
            ApiId = 15176,
            ApiName = ApiNames.Asos,
            Name = "Nike Running",
            CatalogBrandId = 21,
        },
        new CatalogBrandApi
        {
            Id = 22,
            ApiId = 16123,
            ApiName = ApiNames.Asos,
            Name = "Hi-Tec",
            CatalogBrandId = 22,
        },
        new CatalogBrandApi
        {
            Id = 23,
            ApiId = 3497,
            ApiName = ApiNames.Asos,
            Name = "Farah",
            CatalogBrandId = 23,
        },
        new CatalogBrandApi
        {
            Id = 24,
            ApiId = 15127,
            ApiName = ApiNames.Asos,
            Name = "Napapijri",
            CatalogBrandId = 24,
        },
        new CatalogBrandApi
        {
            Id = 25,
            ApiId = 12791,
            ApiName = ApiNames.Asos,
            Name = "AllSaints",
            CatalogBrandId = 25,
        },
        new CatalogBrandApi
        {
            Id = 26,
            ApiId = 3029,
            ApiName = ApiNames.Asos,
            Name = "Tommy Hilfiger",
            CatalogBrandId = 26,
        },
        new CatalogBrandApi
        {
            Id = 27,
            ApiId = 14758,
            ApiName = ApiNames.Asos,
            Name = "ADPT",
            CatalogBrandId = 27,
        },
        new CatalogBrandApi
        {
            Id = 28,
            ApiId = 15370,
            ApiName = ApiNames.Asos,
            Name = "Bershka",
            CatalogBrandId = 28,
        },
        new CatalogBrandApi
        {
            Id = 29,
            ApiId = 14512,
            ApiName = ApiNames.Asos,
            Name = "Le Breve",
            CatalogBrandId = 29,
        },
        new CatalogBrandApi
        {
            Id = 30,
            ApiId = 12136,
            ApiName = ApiNames.Asos,
            Name = "Armani Exchange",
            CatalogBrandId = 30,
        },
        new CatalogBrandApi
        {
            Id = 31,
            ApiId = 16236,
            ApiName = ApiNames.Asos,
            Name = "Topman",
            CatalogBrandId = 31,
        },
        new CatalogBrandApi
        {
            Id = 32,
            ApiId = 691,
            ApiName = ApiNames.Asos,
            Name = "Superdry",
            CatalogBrandId = 32,
        },
        new CatalogBrandApi
        {
            Id = 33,
            ApiId = 14126,
            ApiName = ApiNames.Asos,
            Name = "Pull&Bear",
            CatalogBrandId = 33,
        },
        new CatalogBrandApi
        {
            Id = 34,
            ApiId = 15878,
            ApiName = ApiNames.Asos,
            Name = "Collusion",
            CatalogBrandId = 34,
        },
        new CatalogBrandApi
        {
            Id = 35,
            ApiId = 12077,
            ApiName = ApiNames.Asos,
            Name = "BOSS by Hugo Boss",
            CatalogBrandId = 35,
        },
        new CatalogBrandApi
        {
            Id = 36,
            ApiId = 14712,
            ApiName = ApiNames.Asos,
            Name = "WALK LONDON",
            CatalogBrandId = 36,
        },
        new CatalogBrandApi
        {
            Id = 37,
            ApiId = 14550,
            ApiName = ApiNames.Asos,
            Name = "Teva",
            CatalogBrandId = 37,
        },
        new CatalogBrandApi
        {
            Id = 38,
            ApiId = 14287,
            ApiName = ApiNames.Asos,
            Name = "Weekday",
            CatalogBrandId = 38,
        },
        new CatalogBrandApi
        {
            Id = 39,
            ApiId = 3062,
            ApiName = ApiNames.Asos,
            Name = "Wrangler",
            CatalogBrandId = 39,
        },
        new CatalogBrandApi
        {
            Id = 40,
            ApiId = 79,
            ApiName = ApiNames.Asos,
            Name = "Birkenstock",
            CatalogBrandId = 40,
        },
        new CatalogBrandApi
        {
            Id = 41,
            ApiId = 396,
            ApiName = ApiNames.Asos,
            Name = "Lee",
            CatalogBrandId = 41,
        },
        new CatalogBrandApi
        {
            Id = 42,
            ApiId = 14468,
            ApiName = ApiNames.Asos,
            Name = "Nicce",
            CatalogBrandId = 42,
        },
        new CatalogBrandApi
        {
            Id = 43,
            ApiId = 20903,
            ApiName = ApiNames.Asos,
            Name = "Sol de Janeiro",
            CatalogBrandId = 43,
        },
        new CatalogBrandApi
        {
            Id = 44,
            ApiId = 15829,
            ApiName = ApiNames.Asos,
            Name = "Isle of Paradise",
            CatalogBrandId = 44,
        },
        new CatalogBrandApi
        {
            Id = 45,
            ApiId = 16511,
            ApiName = ApiNames.Asos,
            Name = "Rituals",
            CatalogBrandId = 45,
        },
        new CatalogBrandApi
        {
            Id = 46,
            ApiId = 14535,
            ApiName = ApiNames.Asos,
            Name = "Ann Summers",
            CatalogBrandId = 46,
        },
        new CatalogBrandApi
        {
            Id = 47,
            ApiId = 22555,
            ApiName = ApiNames.Asos,
            Name = "Weleda",
            CatalogBrandId = 47,
        },
        new CatalogBrandApi
        {
            Id = 48,
            ApiId = 22705,
            ApiName = ApiNames.Asos,
            Name = "Erborian",
            CatalogBrandId = 48,
        },
        new CatalogBrandApi
        {
            Id = 49,
            ApiId = 17600,
            ApiName = ApiNames.Asos,
            Name = "Tanologist",
            CatalogBrandId = 49,
        },
        new CatalogBrandApi
        {
            Id = 50,
            ApiId = 3234,
            ApiName = ApiNames.Asos,
            Name = "Bolongaro Trevor",
            CatalogBrandId = 50,
        },
        new CatalogBrandApi
        {
            Id = 51,
            ApiId = 17700,
            ApiName = ApiNames.Asos,
            Name = "HUGO BOSS Fragrances",
            CatalogBrandId = 51,
        },
        new CatalogBrandApi
        {
            Id = 52,
            ApiId = 19157,
            ApiName = ApiNames.Asos,
            Name = "MAEGAN",
            CatalogBrandId = 52,
        },
        new CatalogBrandApi
        {
            Id = 53,
            ApiId = 14096,
            ApiName = ApiNames.Asos,
            Name = "Obey",
            CatalogBrandId = 53,
        },
        new CatalogBrandApi
        {
            Id = 54,
            ApiId = 18150,
            ApiName = ApiNames.Asos,
            Name = "Nuxe",
            CatalogBrandId = 54,
        },
        new CatalogBrandApi
        {
            Id = 55,
            ApiId = 12577,
            ApiName = ApiNames.Asos,
            Name = "Caudalie",
            CatalogBrandId = 55,
        },
        new CatalogBrandApi
        {
            Id = 56,
            ApiId = 20703,
            ApiName = ApiNames.Asos,
            Name = "Billie Eilish",
            CatalogBrandId = 56,
        },
        new CatalogBrandApi
        {
            Id = 57,
            ApiId = 224,
            ApiName = ApiNames.Asos,
            Name = "French Connection",
            CatalogBrandId = 57,
        },
        new CatalogBrandApi
        {
            Id = 58,
            ApiId = 16651,
            ApiName = ApiNames.Asos,
            Name = "Threadbare Fitness",
            CatalogBrandId = 58,
        },
        new CatalogBrandApi
        {
            Id = 59,
            ApiId = 13289,
            ApiName = ApiNames.Asos,
            Name = "Sekonda",
            CatalogBrandId = 59,
        },
        new CatalogBrandApi
        {
            Id = 60,
            ApiId = 12962,
            ApiName = ApiNames.Asos,
            Name = "Komono",
            CatalogBrandId = 60,
        },
        new CatalogBrandApi
        {
            Id = 61,
            ApiId = 18054,
            ApiName = ApiNames.Asos,
            Name = "Valentino Bags",
            CatalogBrandId = 61,
        },
        new CatalogBrandApi
        {
            Id = 62,
            ApiId = 15883,
            ApiName = ApiNames.Asos,
            Name = "NA-KD",
            CatalogBrandId = 62,
        },
        new CatalogBrandApi
        {
            Id = 63,
            ApiId = 15586,
            ApiName = ApiNames.Asos,
            Name = "Simply Be",
            CatalogBrandId = 63,
        },
        new CatalogBrandApi
        {
            Id = 64,
            ApiId = 13817,
            ApiName = ApiNames.Asos,
            Name = "New Look",
            CatalogBrandId = 64,
        },
        new CatalogBrandApi
        {
            Id = 65,
            ApiId = 14538,
            ApiName = ApiNames.Asos,
            Name = "Threadbare",
            CatalogBrandId = 65,
        },
        new CatalogBrandApi
        {
            Id = 66,
            ApiId = 13116,
            ApiName = ApiNames.Asos,
            Name = "sister jane",
            CatalogBrandId = 66,
        },
        new CatalogBrandApi
        {
            Id = 67,
            ApiId = 15812,
            ApiName = ApiNames.Asos,
            Name = "Vero Moda Curve",
            CatalogBrandId = 67,
        },
        new CatalogBrandApi
        {
            Id = 68,
            ApiId = 3663,
            ApiName = ApiNames.Asos,
            Name = "Vila",
            CatalogBrandId = 68,
        },
        new CatalogBrandApi
        {
            Id = 69,
            ApiId = 15629,
            ApiName = ApiNames.Asos,
            Name = "Stradivarius",
            CatalogBrandId = 69,
        },
        new CatalogBrandApi
        {
            Id = 70,
            ApiId = 15128,
            ApiName = ApiNames.Asos,
            Name = "Miss Selfridge",
            CatalogBrandId = 70,
        },
        new CatalogBrandApi
        {
            Id = 71,
            ApiId = 14516,
            ApiName = ApiNames.Asos,
            Name = "Waven",
            CatalogBrandId = 71,
        },
        new CatalogBrandApi
        {
            Id = 72,
            ApiId = 3180,
            ApiName = ApiNames.Asos,
            Name = "Dr Martens",
            CatalogBrandId = 72,
        },
        new CatalogBrandApi
        {
            Id = 73,
            ApiId = 3672,
            ApiName = ApiNames.Asos,
            Name = "Timberland",
            CatalogBrandId = 73,
        },
        new CatalogBrandApi
        {
            Id = 74,
            ApiId = 16346,
            ApiName = ApiNames.Asos,
            Name = "adidas performance",
            CatalogBrandId = 74,
        },
        new CatalogBrandApi
        {
            Id = 75,
            ApiId = 12967,
            ApiName = ApiNames.Asos,
            Name = "ALDO",
            CatalogBrandId = 75,
        },
        new CatalogBrandApi
        {
            Id = 76,
            ApiId = 765,
            ApiName = ApiNames.Asos,
            Name = "Vans",
            CatalogBrandId = 76,
        },
        new CatalogBrandApi
        {
            Id = 77,
            ApiId = 14991,
            ApiName = ApiNames.Asos,
            Name = "Bondi Sands",
            CatalogBrandId = 77,
        },
        new CatalogBrandApi
        {
            Id = 78,
            ApiId = 16246,
            ApiName = ApiNames.Asos,
            Name = "The Fox Tan",
            CatalogBrandId = 78,
        },
        new CatalogBrandApi
        {
            Id = 79,
            ApiId = 20602,
            ApiName = ApiNames.Asos,
            Name = "Aire",
            CatalogBrandId = 79,
        },
        new CatalogBrandApi
        {
            Id = 80,
            ApiId = 597,
            ApiName = ApiNames.Asos,
            Name = "Ralph Lauren",
            CatalogBrandId = 80,
        },
        new CatalogBrandApi
        {
            Id = 81,
            ApiId = 16305,
            ApiName = ApiNames.Asos,
            Name = "Topshop",
            CatalogBrandId = 81,
        },
        new CatalogBrandApi
        {
            Id = 82,
            ApiId = 62200,
            ApiName = ApiNames.Asos,
            Name = "Hello Sunday",
            CatalogBrandId = 82,
        },
        new CatalogBrandApi
        {
            Id = 83,
            ApiId = 544,
            ApiName = ApiNames.Asos,
            Name = "Paul Smith",
            CatalogBrandId = 83,
        },
        new CatalogBrandApi
        {
            Id = 84,
            ApiId = 15034,
            ApiName = ApiNames.Asos,
            Name = "Yours",
            CatalogBrandId = 84,
        },
        new CatalogBrandApi
        {
            Id = 85,
            ApiId = 105,
            ApiName = ApiNames.Asos,
            Name = "Calvin Klein",
            CatalogBrandId = 85,
        },
        new CatalogBrandApi
        {
            Id = 86,
            ApiId = 12727,
            ApiName = ApiNames.Asos,
            Name = "Le Specs",
            CatalogBrandId = 86,
        },
        new CatalogBrandApi
        {
            Id = 87,
            ApiId = 3128,
            ApiName = ApiNames.Asos,
            Name = "Ray-Ban",
            CatalogBrandId = 87,
        },
        new CatalogBrandApi
        {
            Id = 88,
            ApiId = 15203,
            ApiName = ApiNames.Asos,
            Name = "Under Armour",
            CatalogBrandId = 88,
        },
        new CatalogBrandApi
        {
            Id = 89,
            ApiId = 767,
            ApiName = ApiNames.Asos,
            Name = "Versace",
            CatalogBrandId = 89,
        },
        new CatalogBrandApi
        {
            Id = 90,
            ApiId = 439,
            ApiName = ApiNames.Asos,
            Name = "Magic",
            CatalogBrandId = 90,
        },
        new CatalogBrandApi
        {
            Id = 91,
            ApiId = 13137,
            ApiName = ApiNames.Asos,
            Name = "True Decadence",
            CatalogBrandId = 91,
        },
        new CatalogBrandApi
        {
            Id = 92,
            ApiId = 3594,
            ApiName = ApiNames.Asos,
            Name = "Polo Ralph Lauren",
            CatalogBrandId = 92,
        },
        new CatalogBrandApi
        {
            Id = 93,
            ApiId = 499,
            ApiName = ApiNames.Asos,
            Name = "New Balance",
            CatalogBrandId = 93,
        },
        new CatalogBrandApi
        {
            Id = 94,
            ApiId = 12069,
            ApiName = ApiNames.Asos,
            Name = "Gant",
            CatalogBrandId = 94,
        },
        new CatalogBrandApi
        {
            Id = 95,
            ApiId = 14116,
            ApiName = ApiNames.Asos,
            Name = "ellesse",
            CatalogBrandId = 95,
        },
        new CatalogBrandApi
        {
            Id = 96,
            ApiId = 13872,
            ApiName = ApiNames.Asos,
            Name = "PS Paul Smith",
            CatalogBrandId = 96,
        },
        new CatalogBrandApi
        {
            Id = 97,
            ApiId = 15622,
            ApiName = ApiNames.Asos,
            Name = "Rip N Dip",
            CatalogBrandId = 97,
        },
        new CatalogBrandApi
        {
            Id = 98,
            ApiId = 2988,
            ApiName = ApiNames.Asos,
            Name = "Reebok",
            CatalogBrandId = 98,
        },
        new CatalogBrandApi
        {
            Id = 99,
            ApiId = 16674,
            ApiName = ApiNames.Asos,
            Name = "Don't Think Twice",
            CatalogBrandId = 99,
        },
        new CatalogBrandApi
        {
            Id = 100,
            ApiId = 3060,
            ApiName = ApiNames.Asos,
            Name = "Emporio Armani",
            CatalogBrandId = 100,
        },
        new CatalogBrandApi
        {
            Id = 101,
            ApiId = 16119,
            ApiName = ApiNames.Asos,
            Name = "& Other Stories",
            CatalogBrandId = 101,
        },
        new CatalogBrandApi
        {
            Id = 102,
            ApiId = 14483,
            ApiName = ApiNames.Asos,
            Name = "True Violet",
            CatalogBrandId = 102,
        },
        new CatalogBrandApi
        {
            Id = 103,
            ApiId = 16485,
            ApiName = ApiNames.Asos,
            Name = "Jaded Rose Tall",
            CatalogBrandId = 103,
        },
        new CatalogBrandApi
        {
            Id = 104,
            ApiId = 13511,
            ApiName = ApiNames.Asos,
            Name = "ASOS Curve",
            CatalogBrandId = 104,
        },
        new CatalogBrandApi
        {
            Id = 105,
            ApiId = 12542,
            ApiName = ApiNames.Asos,
            Name = "Accessorize",
            CatalogBrandId = 105,
        },
        new CatalogBrandApi
        {
            Id = 106,
            ApiId = 15719,
            ApiName = ApiNames.Asos,
            Name = "ASOS EDITION",
            CatalogBrandId = 106,
        },
        new CatalogBrandApi
        {
            Id = 107,
            ApiId = 14146,
            ApiName = ApiNames.Asos,
            Name = "Skinnydip",
            CatalogBrandId = 107,
        },
        new CatalogBrandApi
        {
            Id = 108,
            ApiId = 14162,
            ApiName = ApiNames.Asos,
            Name = "ASOS Tall",
            CatalogBrandId = 108,
        },
        new CatalogBrandApi
        {
            Id = 109,
            ApiId = 14450,
            ApiName = ApiNames.Asos,
            Name = "Jeffrey Campbell",
            CatalogBrandId = 109,
        },
        new CatalogBrandApi
        {
            Id = 110,
            ApiId = 13661,
            ApiName = ApiNames.Asos,
            Name = "Love Moschino",
            CatalogBrandId = 110,
        },
        new CatalogBrandApi
        {
            Id = 111,
            ApiId = 13862,
            ApiName = ApiNames.Asos,
            Name = "Vesper",
            CatalogBrandId = 111,
        },
        new CatalogBrandApi
        {
            Id = 112,
            ApiId = 14012,
            ApiName = ApiNames.Asos,
            Name = "Monki",
            CatalogBrandId = 112,
        },
        new CatalogBrandApi
        {
            Id = 113,
            ApiId = 15068,
            ApiName = ApiNames.Asos,
            Name = "River Island Plus",
            CatalogBrandId = 113,
        },
        new CatalogBrandApi
        {
            Id = 114,
            ApiId = 15177,
            ApiName = ApiNames.Asos,
            Name = "Nike Training",
            CatalogBrandId = 114,
        },
        new CatalogBrandApi
        {
            Id = 115,
            ApiId = 13850,
            ApiName = ApiNames.Asos,
            Name = "ONLY",
            CatalogBrandId = 115,
        },
        new CatalogBrandApi
        {
            Id = 116,
            ApiId = 14599,
            ApiName = ApiNames.Asos,
            Name = "Pimkie",
            CatalogBrandId = 116,
        },
        new CatalogBrandApi
        {
            Id = 117,
            ApiId = 14185,
            ApiName = ApiNames.Asos,
            Name = "Jaded Rose",
            CatalogBrandId = 117,
        },
        new CatalogBrandApi
        {
            Id = 118,
            ApiId = 15734,
            ApiName = ApiNames.Asos,
            Name = "Wednesday's Girl",
            CatalogBrandId = 118,
        },
        new CatalogBrandApi
        {
            Id = 119,
            ApiId = 12117,
            ApiName = ApiNames.Asos,
            Name = "Mango",
            CatalogBrandId = 119,
        },
        new CatalogBrandApi
        {
            Id = 120,
            ApiId = 16483,
            ApiName = ApiNames.Asos,
            Name = "Jaded Rose Petite",
            CatalogBrandId = 120,
        },
        new CatalogBrandApi
        {
            Id = 121,
            ApiId = 14023,
            ApiName = ApiNames.Asos,
            Name = "Daisy Street",
            CatalogBrandId = 121,
        },
        new CatalogBrandApi
        {
            Id = 122,
            ApiId = 96,
            ApiName = ApiNames.Asos,
            Name = "Bronx",
            CatalogBrandId = 122,
        },
        new CatalogBrandApi
        {
            Id = 123,
            ApiId = 13138,
            ApiName = ApiNames.Asos,
            Name = "Glamorous",
            CatalogBrandId = 123,
        },
        new CatalogBrandApi
        {
            Id = 124,
            ApiId = 16633,
            ApiName = ApiNames.Asos,
            Name = "Missyempire",
            CatalogBrandId = 124,
        },
        new CatalogBrandApi
        {
            Id = 125,
            ApiId = 21166,
            ApiName = ApiNames.Asos,
            Name = "Glamorous Wide Fit",
            CatalogBrandId = 125,
        },
        new CatalogBrandApi
        {
            Id = 126,
            ApiId = 15778,
            ApiName = ApiNames.Asos,
            Name = "Glamorous Wide Fit",
            CatalogBrandId = 126,
        },
        new CatalogBrandApi
        {
            Id = 127,
            ApiId = 16344,
            ApiName = ApiNames.Asos,
            Name = "Il Sarto",
            CatalogBrandId = 127,
        },
        new CatalogBrandApi
        {
            Id = 128,
            ApiId = 15735,
            ApiName = ApiNames.Asos,
            Name = "Emory Park",
            CatalogBrandId = 128,
        },
        new CatalogBrandApi
        {
            Id = 129,
            ApiId = 3040,
            ApiName = ApiNames.Asos,
            Name = "Pieces",
            CatalogBrandId = 129,
        },
        new CatalogBrandApi
        {
            Id = 130,
            ApiId = 15720,
            ApiName = ApiNames.Asos,
            Name = "Nike Football",
            CatalogBrandId = 130,
        },
        new CatalogBrandApi
        {
            Id = 131,
            ApiId = 14958,
            ApiName = ApiNames.Asos,
            Name = "Gym King",
            CatalogBrandId = 131,
        },
        new CatalogBrandApi
        {
            Id = 132,
            ApiId = 746,
            ApiName = ApiNames.Asos,
            Name = "True Religion",
            CatalogBrandId = 132,
        },
        new CatalogBrandApi
        {
            Id = 133,
            ApiId = 15631,
            ApiName = ApiNames.Asos,
            Name = "Tommy Jeans",
            CatalogBrandId = 133,
        },
        new CatalogBrandApi
        {
            Id = 134,
            ApiId = 14334,
            ApiName = ApiNames.Asos,
            Name = "Helly Hansen",
            CatalogBrandId = 134,
        },
        new CatalogBrandApi
        {
            Id = 135,
            ApiId = 15863,
            ApiName = ApiNames.Asos,
            Name = "Barneys Originals Plus",
            CatalogBrandId = 135,
        },
        new CatalogBrandApi
        {
            Id = 136,
            ApiId = 16279,
            ApiName = ApiNames.Asos,
            Name = "Koi Footwear",
            CatalogBrandId = 136,
        },
        new CatalogBrandApi
        {
            Id = 137,
            ApiId = 3179,
            ApiName = ApiNames.Asos,
            Name = "Hunter",
            CatalogBrandId = 137,
        },
        new CatalogBrandApi
        {
            Id = 138,
            ApiId = 14353,
            ApiName = ApiNames.Asos,
            Name = "Buffalo",
            CatalogBrandId = 138,
        },
        new CatalogBrandApi
        {
            Id = 139,
            ApiId = 14489,
            ApiName = ApiNames.Asos,
            Name = "Lee Jeans",
            CatalogBrandId = 139,
        },
        new CatalogBrandApi
        {
            Id = 140,
            ApiId = 16500,
            ApiName = ApiNames.Asos,
            Name = "Barney s Original Petite",
            CatalogBrandId = 140,
        },
        new CatalogBrandApi
        {
            Id = 141,
            ApiId = 14698,
            ApiName = ApiNames.Asos,
            Name = "Brave Soul Plus",
            CatalogBrandId = 141,
        },
        new CatalogBrandApi
        {
            Id = 142,
            ApiId = 3009,
            ApiName = ApiNames.Asos,
            Name = "Steve Madden",
            CatalogBrandId = 142,
        },
        new CatalogBrandApi
        {
            Id = 143,
            ApiId = 15805,
            ApiName = ApiNames.Asos,
            Name = "Coco & Eve",
            CatalogBrandId = 143,
        },
        new CatalogBrandApi
        {
            Id = 144,
            ApiId = 16380,
            ApiName = ApiNames.Asos,
            Name = "Bleach London",
            CatalogBrandId = 144,
        },
        new CatalogBrandApi
        {
            Id = 145,
            ApiId = 14339,
            ApiName = ApiNames.Asos,
            Name = "Bulldog",
            CatalogBrandId = 145,
        },
        new CatalogBrandApi
        {
            Id = 146,
            ApiId = 14600,
            ApiName = ApiNames.Asos,
            Name = "Lola May",
            CatalogBrandId = 146,
        },
        new CatalogBrandApi
        {
            Id = 147,
            ApiId = 14100,
            ApiName = ApiNames.Asos,
            Name = "Rains",
            CatalogBrandId = 147,
        },
        new CatalogBrandApi
        {
            Id = 148,
            ApiId = 62251,
            ApiName = ApiNames.Asos,
            Name = "Made By Mitchell",
            CatalogBrandId = 148,
        },
        new CatalogBrandApi
        {
            Id = 149,
            ApiId = 16216,
            ApiName = ApiNames.Asos,
            Name = "Zoe Ayla",
            CatalogBrandId = 149,
        },
        new CatalogBrandApi
        {
            Id = 150,
            ApiId = 16637,
            ApiName = ApiNames.Asos,
            Name = "Pretty Lavish Curve",
            CatalogBrandId = 150,
        },
        new CatalogBrandApi
        {
            Id = 151,
            ApiId = 15718,
            ApiName = ApiNames.Asos,
            Name = "Glamorous Curve",
            CatalogBrandId = 151,
        },
        new CatalogBrandApi
        {
            Id = 152,
            ApiId = 13512,
            ApiName = ApiNames.Asos,
            Name = "ASOS Petite",
            CatalogBrandId = 152,
        },
        new CatalogBrandApi
        {
            Id = 153,
            ApiId = 14513,
            ApiName = ApiNames.Asos,
            Name = "Champion",
            CatalogBrandId = 153,
        },
        new CatalogBrandApi
        {
            Id = 154,
            ApiId = 15099,
            ApiName = ApiNames.Asos,
            Name = "My Accessories",
            CatalogBrandId = 154,
        },
        new CatalogBrandApi
        {
            Id = 155,
            ApiId = 13881,
            ApiName = ApiNames.Asos,
            Name = "Volcom",
            CatalogBrandId = 155,
        },
        new CatalogBrandApi
        {
            Id = 156,
            ApiId = 3182,
            ApiName = ApiNames.Asos,
            Name = "New Era",
            CatalogBrandId = 156,
        },
        new CatalogBrandApi
        {
            Id = 157,
            ApiId = 15849,
            ApiName = ApiNames.Asos,
            Name = "Puma Golf",
            CatalogBrandId = 157,
        },
        new CatalogBrandApi
        {
            Id = 158,
            ApiId = 14751,
            ApiName = ApiNames.Asos,
            Name = "A Star Is Born",
            CatalogBrandId = 158,
        },
        new CatalogBrandApi
        {
            Id = 159,
            ApiId = 16711,
            ApiName = ApiNames.Asos,
            Name = "VAI21",
            CatalogBrandId = 159,
        },
        new CatalogBrandApi
        {
            Id = 160,
            ApiId = 22855,
            ApiName = ApiNames.Asos,
            Name = "DIFF Eyewear",
            CatalogBrandId = 160,
        },
        new CatalogBrandApi
        {
            Id = 161,
            ApiId = 712,
            ApiName = ApiNames.Asos,
            Name = "Ted Baker",
            CatalogBrandId = 161,
        },
        new CatalogBrandApi
        {
            Id = 162,
            ApiId = 716,
            ApiName = ApiNames.Asos,
            Name = "TFNC",
            CatalogBrandId = 162,
        },
        new CatalogBrandApi
        {
            Id = 163,
            ApiId = 15368,
            ApiName = ApiNames.Asos,
            Name = "Maya",
            CatalogBrandId = 163,
        },
        new CatalogBrandApi
        {
            Id = 164,
            ApiId = 299,
            ApiName = ApiNames.Asos,
            Name = "Hummel",
            CatalogBrandId = 164,
        },
        new CatalogBrandApi
        {
            Id = 165,
            ApiId = 13688,
            ApiName = ApiNames.Asos,
            Name = "Asics",
            CatalogBrandId = 165,
        },
        new CatalogBrandApi
        {
            Id = 166,
            ApiId = 16727,
            ApiName = ApiNames.Asos,
            Name = "On Running",
            CatalogBrandId = 166,
        },
        new CatalogBrandApi
        {
            Id = 167,
            ApiId = 14269,
            ApiName = ApiNames.Asos,
            Name = "Jordan",
            CatalogBrandId = 167,
        },
        new CatalogBrandApi
        {
            Id = 168,
            ApiId = 589,
            ApiName = ApiNames.Asos,
            Name = "Puma",
            CatalogBrandId = 168,
        },
        new CatalogBrandApi
        {
            Id = 169,
            ApiId = 13687,
            ApiName = ApiNames.Asos,
            Name = "Native Youth",
            CatalogBrandId = 169,
        },
        new CatalogBrandApi
        {
            Id = 170,
            ApiId = 391,
            ApiName = ApiNames.Asos,
            Name = "Lacoste",
            CatalogBrandId = 170,
        },
        new CatalogBrandApi
        {
            Id = 171,
            ApiId = 16082,
            ApiName = ApiNames.Asos,
            Name = "Versace Jeans Couture",
            CatalogBrandId = 171,
        },
        new CatalogBrandApi
        {
            Id = 172,
            ApiId = 15059,
            ApiName = ApiNames.Asos,
            Name = "Columbia",
            CatalogBrandId = 172,
        },
        new CatalogBrandApi
        {
            Id = 173,
            ApiId = 16333,
            ApiName = ApiNames.Asos,
            Name = "My Accessories Curve",
            CatalogBrandId = 173,
        },
        new CatalogBrandApi
        {
            Id = 174,
            ApiId = 13927,
            ApiName = ApiNames.Asos,
            Name = "Noisy May",
            CatalogBrandId = 174,
        },
        new CatalogBrandApi
        {
            Id = 175,
            ApiId = 16649,
            ApiName = ApiNames.Asos,
            Name = "BOSS Bodywear",
            CatalogBrandId = 175,
        },
        new CatalogBrandApi
        {
            Id = 176,
            ApiId = 14969,
            ApiName = ApiNames.Asos,
            Name = "DesignB London",
            CatalogBrandId = 176,
        },
        new CatalogBrandApi
        {
            Id = 177,
            ApiId = 14955,
            ApiName = ApiNames.Asos,
            Name = "Loungeable",
            CatalogBrandId = 177,
        },
        new CatalogBrandApi
        {
            Id = 178,
            ApiId = 15146,
            ApiName = ApiNames.Asos,
            Name = "Boux Avenue",
            CatalogBrandId = 178,
        },
        new CatalogBrandApi
        {
            Id = 179,
            ApiId = 16568,
            ApiName = ApiNames.Asos,
            Name = "Schuh",
            CatalogBrandId = 179,
        },
        new CatalogBrandApi
        {
            Id = 180,
            ApiId = 752,
            ApiName = ApiNames.Asos,
            Name = "UGG",
            CatalogBrandId = 180,
        },
        new CatalogBrandApi
        {
            Id = 181,
            ApiId = 15139,
            ApiName = ApiNames.Asos,
            Name = "HUGO",
            CatalogBrandId = 181,
        },
        new CatalogBrandApi
        {
            Id = 182,
            ApiId = 12927,
            ApiName = ApiNames.Asos,
            Name = "Sorel",
            CatalogBrandId = 182,
        },
        new CatalogBrandApi
        {
            Id = 183,
            ApiId = 22005,
            ApiName = ApiNames.Asos,
            Name = "Charles & Keith",
            CatalogBrandId = 183,
        },
        new CatalogBrandApi
        {
            Id = 184,
            ApiId = 17855,
            ApiName = ApiNames.Asos,
            Name = "Monday Haircare",
            CatalogBrandId = 184,
        },
        new CatalogBrandApi
        {
            Id = 185,
            ApiId = 13126,
            ApiName = ApiNames.Asos,
            Name = "Herschel Supply Co",
            CatalogBrandId = 185,
        },
        new CatalogBrandApi
        {
            Id = 186,
            ApiId = 12144,
            ApiName = ApiNames.Asos,
            Name = "Tangle Teezer",
            CatalogBrandId = 186,
        },
        new CatalogBrandApi
        {
            Id = 187,
            ApiId = 14059,
            ApiName = ApiNames.Asos,
            Name = "Santa Cruz",
            CatalogBrandId = 187,
        },
        new CatalogBrandApi
        {
            Id = 188,
            ApiId = 16183,
            ApiName = ApiNames.Asos,
            Name = "Lullabellz",
            CatalogBrandId = 188,
        },
        new CatalogBrandApi
        {
            Id = 189,
            ApiId = 16471,
            ApiName = ApiNames.Asos,
            Name = "NEOM",
            CatalogBrandId = 189,
        },
        new CatalogBrandApi
        {
            Id = 190,
            ApiId = 16477,
            ApiName = ApiNames.Asos,
            Name = "Aveeno",
            CatalogBrandId = 190,
        },
        new CatalogBrandApi
        {
            Id = 191,
            ApiId = 16131,
            ApiName = ApiNames.Asos,
            Name = "Karl Kani",
            CatalogBrandId = 191,
        },
        new CatalogBrandApi
        {
            Id = 192,
            ApiId = 3098,
            ApiName = ApiNames.Asos,
            Name = "Vero Moda",
            CatalogBrandId = 192,
        },
        new CatalogBrandApi
        {
            Id = 193,
            ApiId = 14076,
            ApiName = ApiNames.Asos,
            Name = "Neon Rose",
            CatalogBrandId = 193,
        },
        new CatalogBrandApi
        {
            Id = 194,
            ApiId = 15994,
            ApiName = ApiNames.Asos,
            Name = "Neon Rose Plus",
            CatalogBrandId = 194,
        },
        new CatalogBrandApi
        {
            Id = 195,
            ApiId = 160,
            ApiName = ApiNames.Asos,
            Name = "DKNY",
            CatalogBrandId = 195,
        },
        new CatalogBrandApi
        {
            Id = 196,
            ApiId = 3119,
            ApiName = ApiNames.Asos,
            Name = "Gossard",
            CatalogBrandId = 196,
        },
        new CatalogBrandApi
        {
            Id = 197,
            ApiId = 15807,
            ApiName = ApiNames.Asos,
            Name = "The Couture Club",
            CatalogBrandId = 197,
        },
        new CatalogBrandApi
        {
            Id = 198,
            ApiId = 13510,
            ApiName = ApiNames.Asos,
            Name = "ASOS Maternity",
            CatalogBrandId = 198,
        },
        new CatalogBrandApi
        {
            Id = 199,
            ApiId = 14042,
            ApiName = ApiNames.Asos,
            Name = "Bluebella",
            CatalogBrandId = 199,
        },
        new CatalogBrandApi
        {
            Id = 200,
            ApiId = 16631,
            ApiName = ApiNames.Asos,
            Name = "ASOS LUXE",
            CatalogBrandId = 200,
        },
        new CatalogBrandApi
        {
            Id = 201,
            ApiId = 16508,
            ApiName = ApiNames.Asos,
            Name = "LAUREN by RALPH LAUREN",
            CatalogBrandId = 201,
        },
        new CatalogBrandApi
        {
            Id = 202,
            ApiId = 15882,
            ApiName = ApiNames.Asos,
            Name = "Lindex",
            CatalogBrandId = 202,
        },
        new CatalogBrandApi
        {
            Id = 203,
            ApiId = 12255,
            ApiName = ApiNames.Asos,
            Name = "Orelia",
            CatalogBrandId = 203,
        },
        new CatalogBrandApi
        {
            Id = 204,
            ApiId = 20202,
            ApiName = ApiNames.Asos,
            Name = "Esmee Curve",
            CatalogBrandId = 204,
        },
        new CatalogBrandApi
        {
            Id = 205,
            ApiId = 3738,
            ApiName = ApiNames.Asos,
            Name = "Dune",
            CatalogBrandId = 205,
        },
        new CatalogBrandApi
        {
            Id = 206,
            ApiId = 12840,
            ApiName = ApiNames.Asos,
            Name = "Selected",
            CatalogBrandId = 206,
        },
        new CatalogBrandApi
        {
            Id = 207,
            ApiId = 15687,
            ApiName = ApiNames.Asos,
            Name = "Flounce London",
            CatalogBrandId = 207,
        },
        new CatalogBrandApi
        {
            Id = 208,
            ApiId = 12205,
            ApiName = ApiNames.Asos,
            Name = "LAB Series",
            CatalogBrandId = 208,
        },
        new CatalogBrandApi
        {
            Id = 209,
            ApiId = 3379,
            ApiName = ApiNames.Asos,
            Name = "Elemis",
            CatalogBrandId = 209,
        },
        new CatalogBrandApi
        {
            Id = 210,
            ApiId = 20551,
            ApiName = ApiNames.Asos,
            Name = "Flamingo",
            CatalogBrandId = 210,
        },
        new CatalogBrandApi
        {
            Id = 211,
            ApiId = 22805,
            ApiName = ApiNames.Asos,
            Name = "Doll Beauty",
            CatalogBrandId = 211,
        },
        new CatalogBrandApi
        {
            Id = 212,
            ApiId = 20701,
            ApiName = ApiNames.Asos,
            Name = "Revolution Man",
            CatalogBrandId = 212,
        },
        new CatalogBrandApi
        {
            Id = 213,
            ApiId = 15563,
            ApiName = ApiNames.Asos,
            Name = "Apothecary 87",
            CatalogBrandId = 213,
        },
        new CatalogBrandApi
        {
            Id = 214,
            ApiId = 12930,
            ApiName = ApiNames.Asos,
            Name = "bareMinerals",
            CatalogBrandId = 214,
        },
        new CatalogBrandApi
        {
            Id = 215,
            ApiId = 15585,
            ApiName = ApiNames.Asos,
            Name = "Murdock London",
            CatalogBrandId = 215,
        },
        new CatalogBrandApi
        {
            Id = 216,
            ApiId = 16337,
            ApiName = ApiNames.Asos,
            Name = "Style Cheat",
            CatalogBrandId = 216,
        },
        new CatalogBrandApi
        {
            Id = 217,
            ApiId = 14988,
            ApiName = ApiNames.Asos,
            Name = "Amy Lynn",
            CatalogBrandId = 217,
        },
        new CatalogBrandApi
        {
            Id = 218,
            ApiId = 12507,
            ApiName = ApiNames.Asos,
            Name = "Calvin Klein Jeans",
            CatalogBrandId = 218,
        },
        new CatalogBrandApi
        {
            Id = 219,
            ApiId = 15715,
            ApiName = ApiNames.Asos,
            Name = "Barbour International",
            CatalogBrandId = 219,
        },
        new CatalogBrandApi
        {
            Id = 220,
            ApiId = 14630,
            ApiName = ApiNames.Asos,
            Name = "Beauty Extras",
            CatalogBrandId = 220,
        },
        new CatalogBrandApi
        {
            Id = 221,
            ApiId = 16338,
            ApiName = ApiNames.Asos,
            Name = "Planks",
            CatalogBrandId = 221,
        },
        new CatalogBrandApi
        {
            Id = 222,
            ApiId = 15643,
            ApiName = ApiNames.Asos,
            Name = "ASOS 4505",
            CatalogBrandId = 222,
        },
        new CatalogBrandApi
        {
            Id = 223,
            ApiId = 12113,
            ApiName = ApiNames.Asos,
            Name = "Berghaus",
            CatalogBrandId = 223,
        },
        new CatalogBrandApi
        {
            Id = 224,
            ApiId = 16546,
            ApiName = ApiNames.Asos,
            Name = "Be Mine Wide Fit",
            CatalogBrandId = 224,
        },
        new CatalogBrandApi
        {
            Id = 225,
            ApiId = 16059,
            ApiName = ApiNames.Asos,
            Name = "4th & Reckless",
            CatalogBrandId = 225,
        },
        new CatalogBrandApi
        {
            Id = 226,
            ApiId = 62151,
            ApiName = ApiNames.Asos,
            Name = "Sachajuan",
            CatalogBrandId = 226,
        },
        new CatalogBrandApi
        {
            Id = 227,
            ApiId = 15747,
            ApiName = ApiNames.Asos,
            Name = "HIIT",
            CatalogBrandId = 227,
        },
        new CatalogBrandApi
        {
            Id = 228,
            ApiId = 13078,
            ApiName = ApiNames.Asos,
            Name = "Nars",
            CatalogBrandId = 228,
        },
        new CatalogBrandApi
        {
            Id = 229,
            ApiId = 13527,
            ApiName = ApiNames.Asos,
            Name = "Revolution",
            CatalogBrandId = 229,
        },
        new CatalogBrandApi
        {
            Id = 230,
            ApiId = 15898,
            ApiName = ApiNames.Asos,
            Name = "Philip Kingsley",
            CatalogBrandId = 230,
        },
        new CatalogBrandApi
        {
            Id = 231,
            ApiId = 16190,
            ApiName = ApiNames.Asos,
            Name = "Cantu",
            CatalogBrandId = 231,
        },
        new CatalogBrandApi
        {
            Id = 232,
            ApiId = 16264,
            ApiName = ApiNames.Asos,
            Name = "Wrangler Plus",
            CatalogBrandId = 232,
        },
        new CatalogBrandApi
        {
            Id = 233,
            ApiId = 15230,
            ApiName = ApiNames.Asos,
            Name = "River Island Petite",
            CatalogBrandId = 233,
        },
        new CatalogBrandApi
        {
            Id = 234,
            ApiId = 22659,
            ApiName = ApiNames.Asos,
            Name = "Michael Kors Fragrances",
            CatalogBrandId = 234,
        },
        new CatalogBrandApi
        {
            Id = 235,
            ApiId = 13488,
            ApiName = ApiNames.Asos,
            Name = "Issey Miyake",
            CatalogBrandId = 235,
        },
        new CatalogBrandApi
        {
            Id = 236,
            ApiId = 62061,
            ApiName = ApiNames.Asos,
            Name = "Megababe",
            CatalogBrandId = 236,
        },
        new CatalogBrandApi
        {
            Id = 237,
            ApiId = 16205,
            ApiName = ApiNames.Asos,
            Name = "Crocs",
            CatalogBrandId = 237,
        },
        new CatalogBrandApi
        {
            Id = 238,
            ApiId = 612,
            ApiName = ApiNames.Asos,
            Name = "Replay",
            CatalogBrandId = 238,
        },
        new CatalogBrandApi
        {
            Id = 239,
            ApiId = 3272,
            ApiName = ApiNames.Asos,
            Name = "Speedo",
            CatalogBrandId = 239,
        },
        new CatalogBrandApi
        {
            Id = 240,
            ApiId = 16670,
            ApiName = ApiNames.Asos,
            Name = "Bailey Rose",
            CatalogBrandId = 240,
        },
        new CatalogBrandApi
        {
            Id = 241,
            ApiId = 15441,
            ApiName = ApiNames.Asos,
            Name = "Influence Plus",
            CatalogBrandId = 241,
        },
        new CatalogBrandApi
        {
            Id = 242,
            ApiId = 13632,
            ApiName = ApiNames.Asos,
            Name = "Frock and Frill",
            CatalogBrandId = 242,
        },
        new CatalogBrandApi
        {
            Id = 243,
            ApiId = 21555,
            ApiName = ApiNames.Asos,
            Name = "Something New",
            CatalogBrandId = 243,
        },
        new CatalogBrandApi
        {
            Id = 244,
            ApiId = 14565,
            ApiName = ApiNames.Asos,
            Name = "NaaNaa",
            CatalogBrandId = 244,
        },
        new CatalogBrandApi
        {
            Id = 245,
            ApiId = 20650,
            ApiName = ApiNames.Asos,
            Name = "e.l.f.",
            CatalogBrandId = 245,
        },
        new CatalogBrandApi
        {
            Id = 246,
            ApiId = 15818,
            ApiName = ApiNames.Asos,
            Name = "Bobbi Brown",
            CatalogBrandId = 246,
        },
        new CatalogBrandApi
        {
            Id = 247,
            ApiId = 740,
            ApiName = ApiNames.Asos,
            Name = "Too Faced Cosmetics",
            CatalogBrandId = 247,
        },
        new CatalogBrandApi
        {
            Id = 248,
            ApiId = 16543,
            ApiName = ApiNames.Asos,
            Name = "Mylee",
            CatalogBrandId = 248,
        },
        new CatalogBrandApi
        {
            Id = 249,
            ApiId = 16551,
            ApiName = ApiNames.Asos,
            Name = "Acnecide",
            CatalogBrandId = 249,
        },
        new CatalogBrandApi
        {
            Id = 250,
            ApiId = 16552,
            ApiName = ApiNames.Asos,
            Name = "Sunday Riley",
            CatalogBrandId = 250,
        },
        new CatalogBrandApi
        {
            Id = 251,
            ApiId = 15943,
            ApiName = ApiNames.Asos,
            Name = "Laura Mercier",
            CatalogBrandId = 251,
        },
        new CatalogBrandApi
        {
            Id = 252,
            ApiId = 15939,
            ApiName = ApiNames.Asos,
            Name = "Origins",
            CatalogBrandId = 252,
        },
        new CatalogBrandApi
        {
            Id = 253,
            ApiId = 13931,
            ApiName = ApiNames.Asos,
            Name = "Brave Soul",
            CatalogBrandId = 253,
        },
        new CatalogBrandApi
        {
            Id = 254,
            ApiId = 14989,
            ApiName = ApiNames.Asos,
            Name = "UNIQUE21",
            CatalogBrandId = 254,
        },
        new CatalogBrandApi
        {
            Id = 255,
            ApiId = 20750,
            ApiName = ApiNames.Asos,
            Name = "Cherry Beach",
            CatalogBrandId = 255,
        },
        new CatalogBrandApi
        {
            Id = 256,
            ApiId = 21960,
            ApiName = ApiNames.Asos,
            Name = "GUESS Originals",
            CatalogBrandId = 256,
        },
        new CatalogBrandApi
        {
            Id = 257,
            ApiId = 21706,
            ApiName = ApiNames.Asos,
            Name = "PACSUN",
            CatalogBrandId = 257,
        },
        new CatalogBrandApi
        {
            Id = 258,
            ApiId = 18850,
            ApiName = ApiNames.Asos,
            Name = "First Distraction",
            CatalogBrandId = 258,
        },
        new CatalogBrandApi
        {
            Id = 259,
            ApiId = 14434,
            ApiName = ApiNames.Asos,
            Name = "L'Oreal",
            CatalogBrandId = 259,
        },
        new CatalogBrandApi
        {
            Id = 260,
            ApiId = 16340,
            ApiName = ApiNames.Asos,
            Name = "Beauut",
            CatalogBrandId = 260,
        },
        new CatalogBrandApi
        {
            Id = 261,
            ApiId = 13679,
            ApiName = ApiNames.Asos,
            Name = "Influence",
            CatalogBrandId = 261,
        },
        new CatalogBrandApi
        {
            Id = 262,
            ApiId = 15950,
            ApiName = ApiNames.Asos,
            Name = "Nike Basketball",
            CatalogBrandId = 262,
        },
        new CatalogBrandApi
        {
            Id = 263,
            ApiId = 21661,
            ApiName = ApiNames.Asos,
            Name = "Commando",
            CatalogBrandId = 263,
        },
        new CatalogBrandApi
        {
            Id = 264,
            ApiId = 14490,
            ApiName = ApiNames.Asos,
            Name = "Good For Nothing",
            CatalogBrandId = 264,
        },
        new CatalogBrandApi
        {
            Id = 265,
            ApiId = 16377,
            ApiName = ApiNames.Asos,
            Name = "We Are We Wear",
            CatalogBrandId = 265,
        },
        new CatalogBrandApi
        {
            Id = 266,
            ApiId = 14607,
            ApiName = ApiNames.Asos,
            Name = "Flook",
            CatalogBrandId = 266,
        },
        new CatalogBrandApi
        {
            Id = 267,
            ApiId = 15301,
            ApiName = ApiNames.Asos,
            Name = "Lace & Beads",
            CatalogBrandId = 267,
        },
        new CatalogBrandApi
        {
            Id = 268,
            ApiId = 14369,
            ApiName = ApiNames.Asos,
            Name = "Parisian",
            CatalogBrandId = 268,
        },
        new CatalogBrandApi
        {
            Id = 269,
            ApiId = 16715,
            ApiName = ApiNames.Asos,
            Name = "Urban Revivo",
            CatalogBrandId = 269,
        },
        new CatalogBrandApi
        {
            Id = 270,
            ApiId = 12512,
            ApiName = ApiNames.Asos,
            Name = "Skechers",
            CatalogBrandId = 270,
        },
        new CatalogBrandApi
        {
            Id = 271,
            ApiId = 13575,
            ApiName = ApiNames.Asos,
            Name = "Little Mistress",
            CatalogBrandId = 271,
        },
        new CatalogBrandApi
        {
            Id = 272,
            ApiId = 166,
            ApiName = ApiNames.Asos,
            Name = "Dr Denim",
            CatalogBrandId = 272,
        },
        new CatalogBrandApi
        {
            Id = 273,
            ApiId = 16554,
            ApiName = ApiNames.Asos,
            Name = "SNDYS",
            CatalogBrandId = 273,
        },
        new CatalogBrandApi
        {
            Id = 274,
            ApiId = 12732,
            ApiName = ApiNames.Asos,
            Name = "Barbour",
            CatalogBrandId = 274,
        },
        new CatalogBrandApi
        {
            Id = 275,
            ApiId = 16623,
            ApiName = ApiNames.Asos,
            Name = "Salomon",
            CatalogBrandId = 275,
        },
        new CatalogBrandApi
        {
            Id = 276,
            ApiId = 14823,
            ApiName = ApiNames.Asos,
            Name = "Public Desire",
            CatalogBrandId = 276,
        },
        new CatalogBrandApi
        {
            Id = 277,
            ApiId = 15723,
            ApiName = ApiNames.Asos,
            Name = "adidas Golf",
            CatalogBrandId = 277,
        },
        new CatalogBrandApi
        {
            Id = 278,
            ApiId = 582,
            ApiName = ApiNames.Asos,
            Name = "Pretty Polly",
            CatalogBrandId = 278,
        },
        new CatalogBrandApi
        {
            Id = 279,
            ApiId = 12359,
            ApiName = ApiNames.Asos,
            Name = "Mama.licious",
            CatalogBrandId = 279,
        },
        new CatalogBrandApi
        {
            Id = 280,
            ApiId = 3563,
            ApiName = ApiNames.Asos,
            Name = "Oakley",
            CatalogBrandId = 280,
        },
        new CatalogBrandApi
        {
            Id = 281,
            ApiId = 3624,
            ApiName = ApiNames.Asos,
            Name = "Roxy",
            CatalogBrandId = 281,
        },
        new CatalogBrandApi
        {
            Id = 282,
            ApiId = 15129,
            ApiName = ApiNames.Asos,
            Name = "Miss Selfridge Petite",
            CatalogBrandId = 282,
        },
        new CatalogBrandApi
        {
            Id = 283,
            ApiId = 13889,
            ApiName = ApiNames.Asos,
            Name = "Quay Australia",
            CatalogBrandId = 283,
        },
        new CatalogBrandApi
        {
            Id = 284,
            ApiId = 16641,
            ApiName = ApiNames.Asos,
            Name = "Lapp The Brand",
            CatalogBrandId = 284,
        },
        new CatalogBrandApi
        {
            Id = 285,
            ApiId = 15648,
            ApiName = ApiNames.Asos,
            Name = "TYPO",
            CatalogBrandId = 285,
        },
        new CatalogBrandApi
        {
            Id = 286,
            ApiId = 16657,
            ApiName = ApiNames.Asos,
            Name = "Morphe",
            CatalogBrandId = 286,
        },
        new CatalogBrandApi
        {
            Id = 287,
            ApiId = 14664,
            ApiName = ApiNames.Asos,
            Name = "Brave Soul Tall",
            CatalogBrandId = 287,
        },
        new CatalogBrandApi
        {
            Id = 288,
            ApiId = 15817,
            ApiName = ApiNames.Asos,
            Name = "Clinique",
            CatalogBrandId = 288,
        },
        new CatalogBrandApi
        {
            Id = 289,
            ApiId = 15796,
            ApiName = ApiNames.Asos,
            Name = "MAC",
            CatalogBrandId = 289,
        },
        new CatalogBrandApi
        {
            Id = 290,
            ApiId = 15407,
            ApiName = ApiNames.Asos,
            Name = "Soul Star",
            CatalogBrandId = 290,
        },
        new CatalogBrandApi
        {
            Id = 291,
            ApiId = 13027,
            ApiName = ApiNames.Asos,
            Name = "Nip+Fab",
            CatalogBrandId = 291,
        },
        new CatalogBrandApi
        {
            Id = 292,
            ApiId = 3470,
            ApiName = ApiNames.Asos,
            Name = "Muubaa",
            CatalogBrandId = 292,
        },
        new CatalogBrandApi
        {
            Id = 293,
            ApiId = 15841,
            ApiName = ApiNames.Asos,
            Name = "Dr Dennis Gross",
            CatalogBrandId = 293,
        },
        new CatalogBrandApi
        {
            Id = 294,
            ApiId = 14722,
            ApiName = ApiNames.Asos,
            Name = "EA7",
            CatalogBrandId = 294,
        },
        new CatalogBrandApi
        {
            Id = 295,
            ApiId = 16445,
            ApiName = ApiNames.Asos,
            Name = "Revolution Pro",
            CatalogBrandId = 295,
        },
        new CatalogBrandApi
        {
            Id = 296,
            ApiId = 15379,
            ApiName = ApiNames.Asos,
            Name = "Invisibobble",
            CatalogBrandId = 296,
        },
        new CatalogBrandApi
        {
            Id = 297,
            ApiId = 22605,
            ApiName = ApiNames.Asos,
            Name = "Object Tall",
            CatalogBrandId = 297,
        },
        new CatalogBrandApi
        {
            Id = 298,
            ApiId = 15928,
            ApiName = ApiNames.Asos,
            Name = "THE INKEY LIST",
            CatalogBrandId = 298,
        },
        new CatalogBrandApi
        {
            Id = 299,
            ApiId = 15461,
            ApiName = ApiNames.Asos,
            Name = "L'Oreal Men Expert",
            CatalogBrandId = 299,
        },
        new CatalogBrandApi
        {
            Id = 300,
            ApiId = 16360,
            ApiName = ApiNames.Asos,
            Name = "Public Desire Wide Fit",
            CatalogBrandId = 300,
        },
        new CatalogBrandApi
        {
            Id = 301,
            ApiId = 23255,
            ApiName = ApiNames.Asos,
            Name = "The Beauty Crop",
            CatalogBrandId = 301,
        },
        new CatalogBrandApi
        {
            Id = 302,
            ApiId = 21502,
            ApiName = ApiNames.Asos,
            Name = "AZALEA WANG",
            CatalogBrandId = 302,
        },
        new CatalogBrandApi
        {
            Id = 303,
            ApiId = 15665,
            ApiName = ApiNames.Asos,
            Name = "Shea Moisture",
            CatalogBrandId = 303,
        },
        new CatalogBrandApi
        {
            Id = 304,
            ApiId = 22955,
            ApiName = ApiNames.Asos,
            Name = "Luna",
            CatalogBrandId = 304,
        },
        new CatalogBrandApi
        {
            Id = 305,
            ApiId = 16355,
            ApiName = ApiNames.Asos,
            Name = "4th & Reckless Petite",
            CatalogBrandId = 305,
        },
        new CatalogBrandApi
        {
            Id = 306,
            ApiId = 16354,
            ApiName = ApiNames.Asos,
            Name = "4th & Reckless Tall",
            CatalogBrandId = 306,
        },
        new CatalogBrandApi
        {
            Id = 307,
            ApiId = 22159,
            ApiName = ApiNames.Asos,
            Name = "4th & Reckless Plus",
            CatalogBrandId = 307,
        },
        new CatalogBrandApi
        {
            Id = 308,
            ApiId = 16478,
            ApiName = ApiNames.Asos,
            Name = "OLAPLEX",
            CatalogBrandId = 308,
        },
        new CatalogBrandApi
        {
            Id = 309,
            ApiId = 15751,
            ApiName = ApiNames.Asos,
            Name = "Forever New Petite",
            CatalogBrandId = 309,
        },
        new CatalogBrandApi
        {
            Id = 310,
            ApiId = 15709,
            ApiName = ApiNames.Asos,
            Name = "Flounce London Plus",
            CatalogBrandId = 310,
        },
        new CatalogBrandApi
        {
            Id = 311,
            ApiId = 14459,
            ApiName = ApiNames.Asos,
            Name = "Starlet",
            CatalogBrandId = 311,
        },
        new CatalogBrandApi
        {
            Id = 312,
            ApiId = 14510,
            ApiName = ApiNames.Asos,
            Name = "Never Fully Dressed",
            CatalogBrandId = 312,
        },
        new CatalogBrandApi
        {
            Id = 313,
            ApiId = 15058,
            ApiName = ApiNames.Asos,
            Name = "Daisy Street Plus",
            CatalogBrandId = 313,
        },
        new CatalogBrandApi
        {
            Id = 314,
            ApiId = 22906,
            ApiName = ApiNames.Asos,
            Name = "JDY Tall",
            CatalogBrandId = 314,
        },
        new CatalogBrandApi
        {
            Id = 315,
            ApiId = 22905,
            ApiName = ApiNames.Asos,
            Name = "JDY Petite",
            CatalogBrandId = 315,
        },
        new CatalogBrandApi
        {
            Id = 316,
            ApiId = 131,
            ApiName = ApiNames.Asos,
            Name = "Converse",
            CatalogBrandId = 316,
        },
        new CatalogBrandApi
        {
            Id = 317,
            ApiId = 12279,
            ApiName = ApiNames.Asos,
            Name = "Gap",
            CatalogBrandId = 317,
        },
        new CatalogBrandApi
        {
            Id = 318,
            ApiId = 18500,
            ApiName = ApiNames.Asos,
            Name = "ASOS WEEKEND COLLECTIVE",
            CatalogBrandId = 318,
        },
        new CatalogBrandApi
        {
            Id = 319,
            ApiId = 17802,
            ApiName = ApiNames.Asos,
            Name = "Revolution Hair",
            CatalogBrandId = 319,
        },
        new CatalogBrandApi
        {
            Id = 320,
            ApiId = 13621,
            ApiName = ApiNames.Asos,
            Name = "Quiksilver",
            CatalogBrandId = 320,
        },
        new CatalogBrandApi
        {
            Id = 321,
            ApiId = 15700,
            ApiName = ApiNames.Asos,
            Name = "AFRM",
            CatalogBrandId = 321,
        },
        new CatalogBrandApi
        {
            Id = 322,
            ApiId = 15831,
            ApiName = ApiNames.Asos,
            Name = "Twisted Tailor",
            CatalogBrandId = 322,
        },
        new CatalogBrandApi
        {
            Id = 323,
            ApiId = 15619,
            ApiName = ApiNames.Asos,
            Name = "Forever New",
            CatalogBrandId = 323,
        },
        new CatalogBrandApi
        {
            Id = 324,
            ApiId = 62059,
            ApiName = ApiNames.Asos,
            Name = "Daska",
            CatalogBrandId = 324,
        },
        new CatalogBrandApi
        {
            Id = 325,
            ApiId = 16173,
            ApiName = ApiNames.Asos,
            Name = "Vila Petite",
            CatalogBrandId = 325,
        },
        new CatalogBrandApi
        {
            Id = 326,
            ApiId = 21657,
            ApiName = ApiNames.Asos,
            Name = "Kaiia",
            CatalogBrandId = 326,
        },
        new CatalogBrandApi
        {
            Id = 327,
            ApiId = 14251,
            ApiName = ApiNames.Asos,
            Name = "Ripcurl",
            CatalogBrandId = 327,
        },
        new CatalogBrandApi
        {
            Id = 328,
            ApiId = 16575,
            ApiName = ApiNames.Asos,
            Name = "AsYou",
            CatalogBrandId = 328,
        },
        new CatalogBrandApi
        {
            Id = 329,
            ApiId = 15360,
            ApiName = ApiNames.Asos,
            Name = "Hunkemoller",
            CatalogBrandId = 329,
        },
        new CatalogBrandApi
        {
            Id = 330,
            ApiId = 16696,
            ApiName = ApiNames.Asos,
            Name = "Valentino Bags",
            CatalogBrandId = 330,
        },
        new CatalogBrandApi
        {
            Id = 331,
            ApiId = 15902,
            ApiName = ApiNames.Asos,
            Name = "SIMMI Shoes",
            CatalogBrandId = 331,
        },
        new CatalogBrandApi
        {
            Id = 332,
            ApiId = 22505,
            ApiName = ApiNames.Asos,
            Name = "IIQUAL",
            CatalogBrandId = 332,
        },
        new CatalogBrandApi
        {
            Id = 333,
            ApiId = 20702,
            ApiName = ApiNames.Asos,
            Name = "Easy Tiger",
            CatalogBrandId = 333,
        },
        new CatalogBrandApi
        {
            Id = 334,
            ApiId = 22305,
            ApiName = ApiNames.Asos,
            Name = "It’s Now Cool",
            CatalogBrandId = 334,
        },
        new CatalogBrandApi
        {
            Id = 335,
            ApiId = 16322,
            ApiName = ApiNames.Asos,
            Name = "Never Fully Dressed Plus",
            CatalogBrandId = 335,
        },
        new CatalogBrandApi
        {
            Id = 336,
            ApiId = 13942,
            ApiName = ApiNames.Asos,
            Name = "The Ragged Priest",
            CatalogBrandId = 336,
        },
        new CatalogBrandApi
        {
            Id = 337,
            ApiId = 16269,
            ApiName = ApiNames.Asos,
            Name = "Cotton:On",
            CatalogBrandId = 337,
        },
        new CatalogBrandApi
        {
            Id = 338,
            ApiId = 18653,
            ApiName = ApiNames.Asos,
            Name = "JJXX",
            CatalogBrandId = 338,
        },
        new CatalogBrandApi
        {
            Id = 339,
            ApiId = 15900,
            ApiName = ApiNames.Asos,
            Name = "In The Style",
            CatalogBrandId = 339,
        },
        new CatalogBrandApi
        {
            Id = 340,
            ApiId = 13073,
            ApiName = ApiNames.Asos,
            Name = "Lyle & Scott",
            CatalogBrandId = 340,
        },
        new CatalogBrandApi
        {
            Id = 341,
            ApiId = 16191,
            ApiName = ApiNames.Asos,
            Name = "In The Style Plus",
            CatalogBrandId = 341,
        },
        new CatalogBrandApi
        {
            Id = 342,
            ApiId = 14164,
            ApiName = ApiNames.Asos,
            Name = "SikSilk",
            CatalogBrandId = 342,
        },
        new CatalogBrandApi
        {
            Id = 343,
            ApiId = 15828,
            ApiName = ApiNames.Asos,
            Name = "ONLY Tall",
            CatalogBrandId = 343,
        },
        new CatalogBrandApi
        {
            Id = 344,
            ApiId = 15685,
            ApiName = ApiNames.Asos,
            Name = "Be Mine",
            CatalogBrandId = 344,
        },
        new CatalogBrandApi
        {
            Id = 345,
            ApiId = 13214,
            ApiName = ApiNames.Asos,
            Name = "Marshall Artist",
            CatalogBrandId = 345,
        },
        new CatalogBrandApi
        {
            Id = 346,
            ApiId = 16650,
            ApiName = ApiNames.Asos,
            Name = "HUGO Bodywear",
            CatalogBrandId = 346,
        },
        new CatalogBrandApi
        {
            Id = 347,
            ApiId = 17650,
            ApiName = ApiNames.Asos,
            Name = "LUSH",
            CatalogBrandId = 347,
        },
        new CatalogBrandApi
        {
            Id = 348,
            ApiId = 13727,
            ApiName = ApiNames.Asos,
            Name = "Malin + Goetz",
            CatalogBrandId = 348,
        },
        new CatalogBrandApi
        {
            Id = 349,
            ApiId = 13886,
            ApiName = ApiNames.Asos,
            Name = "Closet London",
            CatalogBrandId = 349,
        },
        new CatalogBrandApi
        {
            Id = 350,
            ApiId = 13644,
            ApiName = ApiNames.Asos,
            Name = "47 Brand",
            CatalogBrandId = 350,
        },
        new CatalogBrandApi
        {
            Id = 351,
            ApiId = 16724,
            ApiName = ApiNames.Asos,
            Name = "KAYALI",
            CatalogBrandId = 351,
        },
        new CatalogBrandApi
        {
            Id = 352,
            ApiId = 22155,
            ApiName = ApiNames.Asos,
            Name = "Floral Street",
            CatalogBrandId = 352,
        },
        new CatalogBrandApi
        {
            Id = 353,
            ApiId = 62062,
            ApiName = ApiNames.Asos,
            Name = "Messy Weekend",
            CatalogBrandId = 353,
        },
        new CatalogBrandApi
        {
            Id = 354,
            ApiId = 13652,
            ApiName = ApiNames.Asos,
            Name = "HUF",
            CatalogBrandId = 354,
        },
        new CatalogBrandApi
        {
            Id = 355,
            ApiId = 20612,
            ApiName = ApiNames.Asos,
            Name = "Narciso Rodriguez",
            CatalogBrandId = 355,
        },
        new CatalogBrandApi
        {
            Id = 356,
            ApiId = 14379,
            ApiName = ApiNames.Asos,
            Name = "AAPE BY A BATHING APE®",
            CatalogBrandId = 356,
        },
        new CatalogBrandApi
        {
            Id = 357,
            ApiId = 3008,
            ApiName = ApiNames.Asos,
            Name = "Billabong",
            CatalogBrandId = 357,
        },
        new CatalogBrandApi
        {
            Id = 358,
            ApiId = 16592,
            ApiName = ApiNames.Asos,
            Name = "River Island Tall",
            CatalogBrandId = 358,
        },
        new CatalogBrandApi
        {
            Id = 359,
            ApiId = 21000,
            ApiName = ApiNames.Asos,
            Name = "Curlsmith",
            CatalogBrandId = 359,
        },
        new CatalogBrandApi
        {
            Id = 360,
            ApiId = 16547,
            ApiName = ApiNames.Asos,
            Name = "Living Proof",
            CatalogBrandId = 360,
        },
        new CatalogBrandApi
        {
            Id = 361,
            ApiId = 21755,
            ApiName = ApiNames.Asos,
            Name = "ARKIVE",
            CatalogBrandId = 361,
        },
        new CatalogBrandApi
        {
            Id = 362,
            ApiId = 2994,
            ApiName = ApiNames.Asos,
            Name = "ghd",
            CatalogBrandId = 362,
        },
        new CatalogBrandApi
        {
            Id = 363,
            ApiId = 18904,
            ApiName = ApiNames.Asos,
            Name = "Face Halo",
            CatalogBrandId = 363,
        },
        new CatalogBrandApi
        {
            Id = 364,
            ApiId = 14291,
            ApiName = ApiNames.Asos,
            Name = "Foreo",
            CatalogBrandId = 364,
        },
        new CatalogBrandApi
        {
            Id = 365,
            ApiId = 15741,
            ApiName = ApiNames.Asos,
            Name = "Sand & Sky",
            CatalogBrandId = 365,
        },
        new CatalogBrandApi
        {
            Id = 366,
            ApiId = 15919,
            ApiName = ApiNames.Asos,
            Name = "Estee Lauder",
            CatalogBrandId = 366,
        },
        new CatalogBrandApi
        {
            Id = 367,
            ApiId = 15247,
            ApiName = ApiNames.Asos,
            Name = "The Ordinary",
            CatalogBrandId = 367,
        },
        new CatalogBrandApi
        {
            Id = 368,
            ApiId = 16585,
            ApiName = ApiNames.Asos,
            Name = "Simmi Wide Fit",
            CatalogBrandId = 368,
        },
        new CatalogBrandApi
        {
            Id = 369,
            ApiId = 16114,
            ApiName = ApiNames.Asos,
            Name = "Revolution Skincare",
            CatalogBrandId = 369,
        },
        new CatalogBrandApi
        {
            Id = 370,
            ApiId = 2955,
            ApiName = ApiNames.Asos,
            Name = "Spanx",
            CatalogBrandId = 370,
        },
        new CatalogBrandApi
        {
            Id = 371,
            ApiId = 13987,
            ApiName = ApiNames.Asos,
            Name = "Y.A.S",
            CatalogBrandId = 371,
        },
        new CatalogBrandApi
        {
            Id = 372,
            ApiId = 13943,
            ApiName = ApiNames.Asos,
            Name = "Lavish Alice",
            CatalogBrandId = 372,
        },
        new CatalogBrandApi
        {
            Id = 373,
            ApiId = 16204,
            ApiName = ApiNames.Asos,
            Name = "Pretty Lavish",
            CatalogBrandId = 373,
        },
        new CatalogBrandApi
        {
            Id = 374,
            ApiId = 16710,
            ApiName = ApiNames.Asos,
            Name = "Simmi Clothing",
            CatalogBrandId = 374,
        },
        new CatalogBrandApi
        {
            Id = 375,
            ApiId = 16638,
            ApiName = ApiNames.Asos,
            Name = "Collective the Label Curve",
            CatalogBrandId = 375,
        },
        new CatalogBrandApi
        {
            Id = 376,
            ApiId = 16308,
            ApiName = ApiNames.Asos,
            Name = "Topshop Tall",
            CatalogBrandId = 376,
        },
        new CatalogBrandApi
        {
            Id = 377,
            ApiId = 14304,
            ApiName = ApiNames.Asos,
            Name = "Vero Moda Petite",
            CatalogBrandId = 377,
        },
        new CatalogBrandApi
        {
            Id = 378,
            ApiId = 16487,
            ApiName = ApiNames.Asos,
            Name = "Urban Threads Petite",
            CatalogBrandId = 378,
        },
        new CatalogBrandApi
        {
            Id = 379,
            ApiId = 15395,
            ApiName = ApiNames.Asos,
            Name = "Heartbreak",
            CatalogBrandId = 379,
        },
        new CatalogBrandApi
        {
            Id = 380,
            ApiId = 20611,
            ApiName = ApiNames.Asos,
            Name = "Night Addict Plus",
            CatalogBrandId = 380,
        },
        new CatalogBrandApi
        {
            Id = 381,
            ApiId = 15910,
            ApiName = ApiNames.Asos,
            Name = "Influence Maternity",
            CatalogBrandId = 381,
        },
        new CatalogBrandApi
        {
            Id = 382,
            ApiId = 14457,
            ApiName = ApiNames.Asos,
            Name = "Vero Moda Tall",
            CatalogBrandId = 382,
        },
        new CatalogBrandApi
        {
            Id = 383,
            ApiId = 3606,
            ApiName = ApiNames.Asos,
            Name = "Whistles",
            CatalogBrandId = 383,
        },
        new CatalogBrandApi
        {
            Id = 384,
            ApiId = 62550,
            ApiName = ApiNames.Asos,
            Name = "Hugo Red",
            CatalogBrandId = 384,
        },
        new CatalogBrandApi
        {
            Id = 385,
            ApiId = 12090,
            ApiName = ApiNames.Asos,
            Name = "BOSS Orange",
            CatalogBrandId = 385,
        },
        new CatalogBrandApi
        {
            Id = 386,
            ApiId = 3454,
            ApiName = ApiNames.Asos,
            Name = "Free People",
            CatalogBrandId = 386,
        },
        new CatalogBrandApi
        {
            Id = 387,
            ApiId = 443,
            ApiName = ApiNames.Asos,
            Name = "Marc Jacobs",
            CatalogBrandId = 387,
        },
        new CatalogBrandApi
        {
            Id = 388,
            ApiId = 15224,
            ApiName = ApiNames.Asos,
            Name = "Dermalogica",
            CatalogBrandId = 388,
        },
        new CatalogBrandApi
        {
            Id = 389,
            ApiId = 21169,
            ApiName = ApiNames.Asos,
            Name = "Dr Denim Plus",
            CatalogBrandId = 389,
        },
        new CatalogBrandApi
        {
            Id = 390,
            ApiId = 15739,
            ApiName = ApiNames.Asos,
            Name = "Barber Pro",
            CatalogBrandId = 390,
        },
        new CatalogBrandApi
        {
            Id = 391,
            ApiId = 22355,
            ApiName = ApiNames.Asos,
            Name = "Dsquared",
            CatalogBrandId = 391,
        },
        new CatalogBrandApi
        {
            Id = 392,
            ApiId = 22757,
            ApiName = ApiNames.Asos,
            Name = "Petit Moments",
            CatalogBrandId = 392,
        },
        new CatalogBrandApi
        {
            Id = 393,
            ApiId = 16683,
            ApiName = ApiNames.Asos,
            Name = "Extro & Vert",
            CatalogBrandId = 393,
        },
        new CatalogBrandApi
        {
            Id = 394,
            ApiId = 16144,
            ApiName = ApiNames.Asos,
            Name = "ONLY Curve",
            CatalogBrandId = 394,
        },
        new CatalogBrandApi
        {
            Id = 395,
            ApiId = 22657,
            ApiName = ApiNames.Asos,
            Name = "Whistles Petite",
            CatalogBrandId = 395,
        },
        new CatalogBrandApi
        {
            Id = 396,
            ApiId = 16307,
            ApiName = ApiNames.Asos,
            Name = "Topshop Petite",
            CatalogBrandId = 396,
        },
        new CatalogBrandApi
        {
            Id = 397,
            ApiId = 16394,
            ApiName = ApiNames.Asos,
            Name = "I Saw It First",
            CatalogBrandId = 397,
        },
        new CatalogBrandApi
        {
            Id = 398,
            ApiId = 479,
            ApiName = ApiNames.Asos,
            Name = "Morgan",
            CatalogBrandId = 398,
        },
        new CatalogBrandApi
        {
            Id = 399,
            ApiId = 14230,
            ApiName = ApiNames.Asos,
            Name = "Uppercut Deluxe",
            CatalogBrandId = 399,
        },
        new CatalogBrandApi
        {
            Id = 400,
            ApiId = 3352,
            ApiName = ApiNames.Asos,
            Name = "Clarks Originals",
            CatalogBrandId = 400,
        },
        new CatalogBrandApi
        {
            Id = 401,
            ApiId = 13579,
            ApiName = ApiNames.Asos,
            Name = "AJ Morgan",
            CatalogBrandId = 401,
        },
        new CatalogBrandApi
        {
            Id = 402,
            ApiId = 673,
            ApiName = ApiNames.Asos,
            Name = "Spitfire",
            CatalogBrandId = 402,
        },
        new CatalogBrandApi
        {
            Id = 403,
            ApiId = 16434,
            ApiName = ApiNames.Asos,
            Name = "Labelrail",
            CatalogBrandId = 403,
        },
        new CatalogBrandApi
        {
            Id = 404,
            ApiId = 12456,
            ApiName = ApiNames.Asos,
            Name = "Pretty Green",
            CatalogBrandId = 404,
        },
        new CatalogBrandApi
        {
            Id = 405,
            ApiId = 15488,
            ApiName = ApiNames.Asos,
            Name = "Calvin Klein Golf",
            CatalogBrandId = 405,
        },
        new CatalogBrandApi
        {
            Id = 406,
            ApiId = 17952,
            ApiName = ApiNames.Asos,
            Name = "Pieces Plus",
            CatalogBrandId = 406,
        },
        new CatalogBrandApi
        {
            Id = 407,
            ApiId = 62400,
            ApiName = ApiNames.Asos,
            Name = "Milk Makeup",
            CatalogBrandId = 407,
        },
        new CatalogBrandApi
        {
            Id = 408,
            ApiId = 3498,
            ApiName = ApiNames.Asos,
            Name = "Benefit",
            CatalogBrandId = 408,
        },
        new CatalogBrandApi
        {
            Id = 409,
            ApiId = 15020,
            ApiName = ApiNames.Asos,
            Name = "Kitsch",
            CatalogBrandId = 409,
        },
        new CatalogBrandApi
        {
            Id = 410,
            ApiId = 17900,
            ApiName = ApiNames.Asos,
            Name = "Urban Classics",
            CatalogBrandId = 410,
        },
        new CatalogBrandApi
        {
            Id = 411,
            ApiId = 14821,
            ApiName = ApiNames.Asos,
            Name = "Hope & Ivy",
            CatalogBrandId = 411,
        },
        new CatalogBrandApi
        {
            Id = 412,
            ApiId = 15672,
            ApiName = ApiNames.Asos,
            Name = "BOSS Athleisure",
            CatalogBrandId = 412,
        },
        new CatalogBrandApi
        {
            Id = 413,
            ApiId = 13991,
            ApiName = ApiNames.Asos,
            Name = "JDY",
            CatalogBrandId = 413,
        },
        new CatalogBrandApi
        {
            Id = 414,
            ApiId = 202,
            ApiName = ApiNames.Asos,
            Name = "Fila",
            CatalogBrandId = 414,
        },
        new CatalogBrandApi
        {
            Id = 415,
            ApiId = 12092,
            ApiName = ApiNames.Asos,
            Name = "BOSS Green",
            CatalogBrandId = 415,
        },
        new CatalogBrandApi
        {
            Id = 416,
            ApiId = 14564,
            ApiName = ApiNames.Asos,
            Name = "Object",
            CatalogBrandId = 416,
        },
        new CatalogBrandApi
        {
            Id = 417,
            ApiId = 15000,
            ApiName = ApiNames.Asos,
            Name = "Von Dutch",
            CatalogBrandId = 417,
        },
        new CatalogBrandApi
        {
            Id = 418,
            ApiId = 16506,
            ApiName = ApiNames.Asos,
            Name = "Charlotte Tilbury",
            CatalogBrandId = 418,
        },
        new CatalogBrandApi
        {
            Id = 419,
            ApiId = 15973,
            ApiName = ApiNames.Asos,
            Name = "Dr.Jart+",
            CatalogBrandId = 419,
        },
        new CatalogBrandApi
        {
            Id = 420,
            ApiId = 20201,
            ApiName = ApiNames.Asos,
            Name = "The Frolic",
            CatalogBrandId = 420,
        },
        new CatalogBrandApi
        {
            Id = 421,
            ApiId = 16525,
            ApiName = ApiNames.Asos,
            Name = "Annorlunda",
            CatalogBrandId = 421,
        },
        new CatalogBrandApi
        {
            Id = 422,
            ApiId = 20300,
            ApiName = ApiNames.Asos,
            Name = "Threadbare Plus Fitness",
            CatalogBrandId = 422,
        },
        new CatalogBrandApi
        {
            Id = 423,
            ApiId = 16097,
            ApiName = ApiNames.Asos,
            Name = "Collective The Label",
            CatalogBrandId = 423,
        },
        new CatalogBrandApi
        {
            Id = 424,
            ApiId = 62058,
            ApiName = ApiNames.Asos,
            Name = "Girls Crew",
            CatalogBrandId = 424,
        },
        new CatalogBrandApi
        {
            Id = 425,
            ApiId = 17857,
            ApiName = ApiNames.Asos,
            Name = "Mario Badescu",
            CatalogBrandId = 425,
        },
        new CatalogBrandApi
        {
            Id = 426,
            ApiId = 16412,
            ApiName = ApiNames.Asos,
            Name = "Collective The Label Petite",
            CatalogBrandId = 426,
        },
        new CatalogBrandApi
        {
            Id = 427,
            ApiId = 15668,
            ApiName = ApiNames.Asos,
            Name = "Le Mini Macaron",
            CatalogBrandId = 427,
        },
        new CatalogBrandApi
        {
            Id = 428,
            ApiId = 14730,
            ApiName = ApiNames.Asos,
            Name = "Noak",
            CatalogBrandId = 428,
        },
        new CatalogBrandApi
        {
            Id = 429,
            ApiId = 13891,
            ApiName = ApiNames.Asos,
            Name = "South Beach",
            CatalogBrandId = 429,
        },
        new CatalogBrandApi
        {
            Id = 430,
            ApiId = 15921,
            ApiName = ApiNames.Asos,
            Name = "Barbour Beacon",
            CatalogBrandId = 430,
        },
        new CatalogBrandApi
        {
            Id = 431,
            ApiId = 274,
            ApiName = ApiNames.Asos,
            Name = "Havaianas",
            CatalogBrandId = 431,
        },
        new CatalogBrandApi
        {
            Id = 432,
            ApiId = 16530,
            ApiName = ApiNames.Asos,
            Name = "Esmée",
            CatalogBrandId = 432,
        },
        new CatalogBrandApi
        {
            Id = 433,
            ApiId = 16243,
            ApiName = ApiNames.Asos,
            Name = "Viggo",
            CatalogBrandId = 433,
        },
        new CatalogBrandApi
        {
            Id = 434,
            ApiId = 14139,
            ApiName = ApiNames.Asos,
            Name = "Moon Boot",
            CatalogBrandId = 434,
        },
        new CatalogBrandApi
        {
            Id = 435,
            ApiId = 62412,
            ApiName = ApiNames.Asos,
            Name = "Drybar",
            CatalogBrandId = 435,
        },
        new CatalogBrandApi
        {
            Id = 436,
            ApiId = 62406,
            ApiName = ApiNames.Asos,
            Name = "Kylie Cosmetics by Kylie Jenner",
            CatalogBrandId = 436,
        },
        new CatalogBrandApi
        {
            Id = 437,
            ApiId = 21857,
            ApiName = ApiNames.Asos,
            Name = "Neutrogena",
            CatalogBrandId = 437,
        },
        new CatalogBrandApi
        {
            Id = 438,
            ApiId = 16636,
            ApiName = ApiNames.Asos,
            Name = "Threadbare Maternity",
            CatalogBrandId = 438,
        },
        new CatalogBrandApi
        {
            Id = 439,
            ApiId = 14345,
            ApiName = ApiNames.Asos,
            Name = "Bardot",
            CatalogBrandId = 439,
        },
        new CatalogBrandApi
        {
            Id = 440,
            ApiId = 17852,
            ApiName = ApiNames.Asos,
            Name = "In The Style Petite",
            CatalogBrandId = 440,
        },
        new CatalogBrandApi
        {
            Id = 441,
            ApiId = 17858,
            ApiName = ApiNames.Asos,
            Name = "In The Style Tall",
            CatalogBrandId = 441,
        },
        new CatalogBrandApi
        {
            Id = 442,
            ApiId = 62051,
            ApiName = ApiNames.Asos,
            Name = "Circus NY",
            CatalogBrandId = 442,
        },
        new CatalogBrandApi
        {
            Id = 443,
            ApiId = 22706,
            ApiName = ApiNames.Asos,
            Name = "Good News",
            CatalogBrandId = 443,
        },
        new CatalogBrandApi
        {
            Id = 444,
            ApiId = 16016,
            ApiName = ApiNames.Asos,
            Name = "Anaya",
            CatalogBrandId = 444,
        },
        new CatalogBrandApi
        {
            Id = 445,
            ApiId = 16007,
            ApiName = ApiNames.Asos,
            Name = "Candypants",
            CatalogBrandId = 445,
        },
        new CatalogBrandApi
        {
            Id = 446,
            ApiId = 16587,
            ApiName = ApiNames.Asos,
            Name = "Anaya Tall",
            CatalogBrandId = 446,
        },
        new CatalogBrandApi
        {
            Id = 447,
            ApiId = 21150,
            ApiName = ApiNames.Asos,
            Name = "Closet London Tall",
            CatalogBrandId = 447,
        },
        new CatalogBrandApi
        {
            Id = 448,
            ApiId = 16400,
            ApiName = ApiNames.Asos,
            Name = "Anaya Petite",
            CatalogBrandId = 448,
        },
        new CatalogBrandApi
        {
            Id = 449,
            ApiId = 20502,
            ApiName = ApiNames.Asos,
            Name = "Naked Wardrobe",
            CatalogBrandId = 449,
        },
        new CatalogBrandApi
        {
            Id = 450,
            ApiId = 14688,
            ApiName = ApiNames.Asos,
            Name = "Babyliss",
            CatalogBrandId = 450,
        },
        new CatalogBrandApi
        {
            Id = 451,
            ApiId = 14041,
            ApiName = ApiNames.Asos,
            Name = "Classics 77",
            CatalogBrandId = 451,
        },
        new CatalogBrandApi
        {
            Id = 452,
            ApiId = 16565,
            ApiName = ApiNames.Asos,
            Name = "ASOS Dark Future",
            CatalogBrandId = 452,
        },
        new CatalogBrandApi
        {
            Id = 453,
            ApiId = 19952,
            ApiName = ApiNames.Asos,
            Name = "COSRX",
            CatalogBrandId = 453,
        },
        new CatalogBrandApi
        {
            Id = 454,
            ApiId = 15295,
            ApiName = ApiNames.Asos,
            Name = "frank body",
            CatalogBrandId = 454,
        },
        new CatalogBrandApi
        {
            Id = 455,
            ApiId = 15957,
            ApiName = ApiNames.Asos,
            Name = "Shay & Blue",
            CatalogBrandId = 455,
        },
        new CatalogBrandApi
        {
            Id = 456,
            ApiId = 3018,
            ApiName = ApiNames.Asos,
            Name = "Rimmel London",
            CatalogBrandId = 456,
        },
        new CatalogBrandApi
        {
            Id = 457,
            ApiId = 13852,
            ApiName = ApiNames.Asos,
            Name = "Chelsea Peers",
            CatalogBrandId = 457,
        },
        new CatalogBrandApi
        {
            Id = 458,
            ApiId = 15753,
            ApiName = ApiNames.Asos,
            Name = "Raid Wide Fit",
            CatalogBrandId = 458,
        },
        new CatalogBrandApi
        {
            Id = 459,
            ApiId = 21350,
            ApiName = ApiNames.Asos,
            Name = "Coola",
            CatalogBrandId = 459,
        },
        new CatalogBrandApi
        {
            Id = 460,
            ApiId = 23105,
            ApiName = ApiNames.Asos,
            Name = "Six Stories",
            CatalogBrandId = 460,
        },
        new CatalogBrandApi
        {
            Id = 461,
            ApiId = 18250,
            ApiName = ApiNames.Asos,
            Name = "WetBrush",
            CatalogBrandId = 461,
        },
        new CatalogBrandApi
        {
            Id = 462,
            ApiId = 15390,
            ApiName = ApiNames.Asos,
            Name = "OUAI",
            CatalogBrandId = 462,
        },
        new CatalogBrandApi
        {
            Id = 463,
            ApiId = 20600,
            ApiName = ApiNames.Asos,
            Name = "Topshop Curve",
            CatalogBrandId = 463,
        },
        new CatalogBrandApi
        {
            Id = 464,
            ApiId = 15010,
            ApiName = ApiNames.Asos,
            Name = "Office",
            CatalogBrandId = 464,
        },
        new CatalogBrandApi
        {
            Id = 465,
            ApiId = 66,
            ApiName = ApiNames.Asos,
            Name = "Barry M",
            CatalogBrandId = 465,
        },
        new CatalogBrandApi
        {
            Id = 466,
            ApiId = 14884,
            ApiName = ApiNames.Asos,
            Name = "NYX Professional Makeup",
            CatalogBrandId = 466,
        },
        new CatalogBrandApi
        {
            Id = 467,
            ApiId = 16719,
            ApiName = ApiNames.Asos,
            Name = "Huda Beauty",
            CatalogBrandId = 467,
        },
        new CatalogBrandApi
        {
            Id = 468,
            ApiId = 16498,
            ApiName = ApiNames.Asos,
            Name = "Beauty Works",
            CatalogBrandId = 468,
        },
        new CatalogBrandApi
        {
            Id = 469,
            ApiId = 18800,
            ApiName = ApiNames.Asos,
            Name = "Kristin Ess",
            CatalogBrandId = 469,
        },
        new CatalogBrandApi
        {
            Id = 470,
            ApiId = 13844,
            ApiName = ApiNames.Asos,
            Name = "New Look Plus",
            CatalogBrandId = 470,
        },
        new CatalogBrandApi
        {
            Id = 471,
            ApiId = 16391,
            ApiName = ApiNames.Asos,
            Name = "Femme Luxe",
            CatalogBrandId = 471,
        },
        new CatalogBrandApi
        {
            Id = 472,
            ApiId = 16443,
            ApiName = ApiNames.Asos,
            Name = "Noisy May Curve",
            CatalogBrandId = 472,
        },
        new CatalogBrandApi
        {
            Id = 473,
            ApiId = 16634,
            ApiName = ApiNames.Asos,
            Name = "Vila Curve",
            CatalogBrandId = 473,
        },
        new CatalogBrandApi
        {
            Id = 474,
            ApiId = 16232,
            ApiName = ApiNames.Asos,
            Name = "Shiseido",
            CatalogBrandId = 474,
        },
        new CatalogBrandApi
        {
            Id = 475,
            ApiId = 16537,
            ApiName = ApiNames.Asos,
            Name = "Threadbare Tall",
            CatalogBrandId = 475,
        },
        new CatalogBrandApi
        {
            Id = 476,
            ApiId = 15169,
            ApiName = ApiNames.Asos,
            Name = "ASOS MADE IN",
            CatalogBrandId = 476,
        },
        new CatalogBrandApi
        {
            Id = 477,
            ApiId = 16047,
            ApiName = ApiNames.Asos,
            Name = "Tommy Hilfiger Sport",
            CatalogBrandId = 477,
        },
        new CatalogBrandApi
        {
            Id = 478,
            ApiId = 16470,
            ApiName = ApiNames.Asos,
            Name = "I Heart Revolution",
            CatalogBrandId = 478,
        },
        new CatalogBrandApi
        {
            Id = 479,
            ApiId = 16398,
            ApiName = ApiNames.Asos,
            Name = "Anaya Plus",
            CatalogBrandId = 479,
        },
        new CatalogBrandApi
        {
            Id = 480,
            ApiId = 259,
            ApiName = ApiNames.Asos,
            Name = "Guess",
            CatalogBrandId = 480,
        },
        new CatalogBrandApi
        {
            Id = 481,
            ApiId = 18052,
            ApiName = ApiNames.Asos,
            Name = "Madewell",
            CatalogBrandId = 481,
        },
        new CatalogBrandApi
        {
            Id = 482,
            ApiId = 16553,
            ApiName = ApiNames.Asos,
            Name = "Cetaphil",
            CatalogBrandId = 482,
        },
        new CatalogBrandApi
        {
            Id = 483,
            ApiId = 16128,
            ApiName = ApiNames.Asos,
            Name = "New Girl Order Curve",
            CatalogBrandId = 483,
        },
        new CatalogBrandApi
        {
            Id = 484,
            ApiId = 17951,
            ApiName = ApiNames.Asos,
            Name = "Pieces Petite",
            CatalogBrandId = 484,
        },
        new CatalogBrandApi
        {
            Id = 485,
            ApiId = 15145,
            ApiName = ApiNames.Asos,
            Name = "Raid",
            CatalogBrandId = 485,
        },
        new CatalogBrandApi
        {
            Id = 486,
            ApiId = 21557,
            ApiName = ApiNames.Asos,
            Name = "Coney Island Picnic",
            CatalogBrandId = 486,
        },
        new CatalogBrandApi
        {
            Id = 487,
            ApiId = 3192,
            ApiName = ApiNames.Asos,
            Name = "this works",
            CatalogBrandId = 487,
        },
        new CatalogBrandApi
        {
            Id = 488,
            ApiId = 3212,
            ApiName = ApiNames.Asos,
            Name = "Superga",
            CatalogBrandId = 488,
        },
        new CatalogBrandApi
        {
            Id = 489,
            ApiId = 13685,
            ApiName = ApiNames.Asos,
            Name = "Protest",
            CatalogBrandId = 489,
        },
        new CatalogBrandApi
        {
            Id = 490,
            ApiId = 17,
            ApiName = ApiNames.Asos,
            Name = "adidas",
            CatalogBrandId = 490,
        },
        new CatalogBrandApi
        {
            Id = 491,
            ApiId = 21559,
            ApiName = ApiNames.Asos,
            Name = "Bye Bra",
            CatalogBrandId = 491,
        },
        new CatalogBrandApi
        {
            Id = 492,
            ApiId = 20500,
            ApiName = ApiNames.Asos,
            Name = "Chelsea Peers Tall",
            CatalogBrandId = 492,
        },
        new CatalogBrandApi
        {
            Id = 493,
            ApiId = 20454,
            ApiName = ApiNames.Asos,
            Name = "Chelsea Peers Petite",
            CatalogBrandId = 493,
        },
        new CatalogBrandApi
        {
            Id = 494,
            ApiId = 14544,
            ApiName = ApiNames.Asos,
            Name = "Dr Paw Paw",
            CatalogBrandId = 494,
        },
        new CatalogBrandApi
        {
            Id = 495,
            ApiId = 3190,
            ApiName = ApiNames.Asos,
            Name = "Pixi",
            CatalogBrandId = 495,
        },
        new CatalogBrandApi
        {
            Id = 496,
            ApiId = 20501,
            ApiName = ApiNames.Asos,
            Name = "Vero Moda Maternity",
            CatalogBrandId = 496,
        },
        new CatalogBrandApi
        {
            Id = 497,
            ApiId = 625,
            ApiName = ApiNames.Asos,
            Name = "Rocketdog",
            CatalogBrandId = 497,
        },
        new CatalogBrandApi
        {
            Id = 498,
            ApiId = 15214,
            ApiName = ApiNames.Asos,
            Name = "Vesper Tall",
            CatalogBrandId = 498,
        },
        new CatalogBrandApi
        {
            Id = 499,
            ApiId = 16486,
            ApiName = ApiNames.Asos,
            Name = "Zemeta",
            CatalogBrandId = 499,
        },
        new CatalogBrandApi
        {
            Id = 500,
            ApiId = 16557,
            ApiName = ApiNames.Asos,
            Name = "DesignB London Curve",
            CatalogBrandId = 500,
        },
        new CatalogBrandApi
        {
            Id = 501,
            ApiId = 17953,
            ApiName = ApiNames.Asos,
            Name = "Bolongaro Trevor Sport",
            CatalogBrandId = 501,
        },
        new CatalogBrandApi
        {
            Id = 502,
            ApiId = 110,
            ApiName = ApiNames.Asos,
            Name = "Casio",
            CatalogBrandId = 502,
        },
        new CatalogBrandApi
        {
            Id = 503,
            ApiId = 298,
            ApiName = ApiNames.Asos,
            Name = "BOSS",
            CatalogBrandId = 503,
        },
        new CatalogBrandApi
        {
            Id = 504,
            ApiId = 504,
            ApiName = ApiNames.Asos,
            Name = "Nixon",
            CatalogBrandId = 504,
        },
        new CatalogBrandApi
        {
            Id = 505,
            ApiId = 15237,
            ApiName = ApiNames.Asos,
            Name = "Nobody's Child",
            CatalogBrandId = 505,
        },
        new CatalogBrandApi
        {
            Id = 506,
            ApiId = 20850,
            ApiName = ApiNames.Asos,
            Name = "Tammy Girl",
            CatalogBrandId = 506,
        },
        new CatalogBrandApi
        {
            Id = 507,
            ApiId = 16427,
            ApiName = ApiNames.Asos,
            Name = "ASRA",
            CatalogBrandId = 507,
        },
        new CatalogBrandApi
        {
            Id = 508,
            ApiId = 156,
            ApiName = ApiNames.Asos,
            Name = "Diesel",
            CatalogBrandId = 508,
        },
        new CatalogBrandApi
        {
            Id = 509,
            ApiId = 16535,
            ApiName = ApiNames.Asos,
            Name = "Threadbare Curve",
            CatalogBrandId = 509,
        },
        new CatalogBrandApi
        {
            Id = 510,
            ApiId = 16536,
            ApiName = ApiNames.Asos,
            Name = "Threadbare Petite",
            CatalogBrandId = 510,
        },
        new CatalogBrandApi
        {
            Id = 511,
            ApiId = 262,
            ApiName = ApiNames.Asos,
            Name = "H by Hudson",
            CatalogBrandId = 511,
        },
        new CatalogBrandApi
        {
            Id = 512,
            ApiId = 16497,
            ApiName = ApiNames.Asos,
            Name = "ICONIC LONDON",
            CatalogBrandId = 512,
        },
        new CatalogBrandApi
        {
            Id = 513,
            ApiId = 12203,
            ApiName = ApiNames.Asos,
            Name = "Juicy Couture",
            CatalogBrandId = 513,
        },
        new CatalogBrandApi
        {
            Id = 514,
            ApiId = 16706,
            ApiName = ApiNames.Asos,
            Name = "Wild Lovers",
            CatalogBrandId = 514,
        },
        new CatalogBrandApi
        {
            Id = 515,
            ApiId = 16166,
            ApiName = ApiNames.Asos,
            Name = "Garnier",
            CatalogBrandId = 515,
        },
        new CatalogBrandApi
        {
            Id = 516,
            ApiId = 15708,
            ApiName = ApiNames.Asos,
            Name = "Tan Luxe",
            CatalogBrandId = 516,
        },
        new CatalogBrandApi
        {
            Id = 517,
            ApiId = 20251,
            ApiName = ApiNames.Asos,
            Name = "The Frolic Plus",
            CatalogBrandId = 517,
        },
        new CatalogBrandApi
        {
            Id = 518,
            ApiId = 777,
            ApiName = ApiNames.Asos,
            Name = "Wahl",
            CatalogBrandId = 518,
        },
        new CatalogBrandApi
        {
            Id = 519,
            ApiId = 16138,
            ApiName = ApiNames.Asos,
            Name = "CeraVe",
            CatalogBrandId = 519,
        },
        new CatalogBrandApi
        {
            Id = 520,
            ApiId = 16266,
            ApiName = ApiNames.Asos,
            Name = "Native Youth Plus",
            CatalogBrandId = 520,
        },
        new CatalogBrandApi
        {
            Id = 521,
            ApiId = 14448,
            ApiName = ApiNames.Asos,
            Name = "Noisy May Petite",
            CatalogBrandId = 521,
        },
        new CatalogBrandApi
        {
            Id = 522,
            ApiId = 23205,
            ApiName = ApiNames.Asos,
            Name = "Patchology",
            CatalogBrandId = 522,
        },
        new CatalogBrandApi
        {
            Id = 523,
            ApiId = 15393,
            ApiName = ApiNames.Asos,
            Name = "Alpha-H",
            CatalogBrandId = 523,
        },
        new CatalogBrandApi
        {
            Id = 524,
            ApiId = 15600,
            ApiName = ApiNames.Asos,
            Name = "Maya Plus",
            CatalogBrandId = 524,
        },
        new CatalogBrandApi
        {
            Id = 525,
            ApiId = 14810,
            ApiName = ApiNames.Asos,
            Name = "Maya Tall",
            CatalogBrandId = 525,
        },
        new CatalogBrandApi
        {
            Id = 526,
            ApiId = 15503,
            ApiName = ApiNames.Asos,
            Name = "LEVIS SKATEBOARDING",
            CatalogBrandId = 526,
        },
        new CatalogBrandApi
        {
            Id = 527,
            ApiId = 15833,
            ApiName = ApiNames.Asos,
            Name = "Urban Threads",
            CatalogBrandId = 527,
        },
        new CatalogBrandApi
        {
            Id = 528,
            ApiId = 178,
            ApiName = ApiNames.Asos,
            Name = "Elegant Touch",
            CatalogBrandId = 528,
        },
        new CatalogBrandApi
        {
            Id = 529,
            ApiId = 196,
            ApiName = ApiNames.Asos,
            Name = "Eylure",
            CatalogBrandId = 529,
        },
        new CatalogBrandApi
        {
            Id = 530,
            ApiId = 16315,
            ApiName = ApiNames.Asos,
            Name = "Lace & Beads Plus",
            CatalogBrandId = 530,
        },
        new CatalogBrandApi
        {
            Id = 531,
            ApiId = 14248,
            ApiName = ApiNames.Asos,
            Name = "New Look Tall",
            CatalogBrandId = 531,
        },
        new CatalogBrandApi
        {
            Id = 532,
            ApiId = 16655,
            ApiName = ApiNames.Asos,
            Name = "Threadbare Fitness Tall",
            CatalogBrandId = 532,
        },
        new CatalogBrandApi
        {
            Id = 533,
            ApiId = 16654,
            ApiName = ApiNames.Asos,
            Name = "Threadbare Fitness Petite",
            CatalogBrandId = 533,
        },
        new CatalogBrandApi
        {
            Id = 534,
            ApiId = 15140,
            ApiName = ApiNames.Asos,
            Name = "Embryolisse",
            CatalogBrandId = 534,
        },
        new CatalogBrandApi
        {
            Id = 535,
            ApiId = 14327,
            ApiName = ApiNames.Asos,
            Name = "Maya Petite",
            CatalogBrandId = 535,
        },
        new CatalogBrandApi
        {
            Id = 536,
            ApiId = 16529,
            ApiName = ApiNames.Asos,
            Name = "Iisla & Bird",
            CatalogBrandId = 536,
        },
        new CatalogBrandApi
        {
            Id = 537,
            ApiId = 16421,
            ApiName = ApiNames.Asos,
            Name = "Real Techniques",
            CatalogBrandId = 537,
        },
        new CatalogBrandApi
        {
            Id = 538,
            ApiId = 14176,
            ApiName = ApiNames.Asos,
            Name = "Truffle Collection",
            CatalogBrandId = 538,
        },
        new CatalogBrandApi
        {
            Id = 539,
            ApiId = 14590,
            ApiName = ApiNames.Asos,
            Name = "Missguided",
            CatalogBrandId = 539,
        },
        new CatalogBrandApi
        {
            Id = 540,
            ApiId = 15770,
            ApiName = ApiNames.Asos,
            Name = "Fashionkilla",
            CatalogBrandId = 540,
        },
        new CatalogBrandApi
        {
            Id = 541,
            ApiId = 21554,
            ApiName = ApiNames.Asos,
            Name = "Edikted",
            CatalogBrandId = 541,
        },
        new CatalogBrandApi
        {
            Id = 542,
            ApiId = 14714,
            ApiName = ApiNames.Asos,
            Name = "In Your Dreams",
            CatalogBrandId = 542,
        },
        new CatalogBrandApi
        {
            Id = 543,
            ApiId = 20150,
            ApiName = ApiNames.Asos,
            Name = "Pull&Bear Tall",
            CatalogBrandId = 543,
        },
        new CatalogBrandApi
        {
            Id = 544,
            ApiId = 14119,
            ApiName = ApiNames.Asos,
            Name = "New Look Petite",
            CatalogBrandId = 544,
        },
        new CatalogBrandApi
        {
            Id = 545,
            ApiId = 16386,
            ApiName = ApiNames.Asos,
            Name = "American Eagle",
            CatalogBrandId = 545,
        },
        new CatalogBrandApi
        {
            Id = 546,
            ApiId = 15307,
            ApiName = ApiNames.Asos,
            Name = "Gilly Hicks",
            CatalogBrandId = 546,
        },
        new CatalogBrandApi
        {
            Id = 547,
            ApiId = 3492,
            ApiName = ApiNames.Asos,
            Name = "FCUK",
            CatalogBrandId = 547,
        },
        new CatalogBrandApi
        {
            Id = 548,
            ApiId = 12833,
            ApiName = ApiNames.Asos,
            Name = "Maurie & Eve",
            CatalogBrandId = 548,
        },
        new CatalogBrandApi
        {
            Id = 549,
            ApiId = 16494,
            ApiName = ApiNames.Asos,
            Name = "Stan Ray",
            CatalogBrandId = 549,
        },
        new CatalogBrandApi
        {
            Id = 550,
            ApiId = 20705,
            ApiName = ApiNames.Asos,
            Name = "MIM",
            CatalogBrandId = 550,
        },
        new CatalogBrandApi
        {
            Id = 551,
            ApiId = 13849,
            ApiName = ApiNames.Asos,
            Name = "Vogue",
            CatalogBrandId = 551,
        },
        new CatalogBrandApi
        {
            Id = 552,
            ApiId = 21958,
            ApiName = ApiNames.Asos,
            Name = "Dr. Barbara Sturm",
            CatalogBrandId = 552,
        },
        new CatalogBrandApi
        {
            Id = 553,
            ApiId = 12431,
            ApiName = ApiNames.Asos,
            Name = "Kickers",
            CatalogBrandId = 553,
        },
        new CatalogBrandApi
        {
            Id = 554,
            ApiId = 12477,
            ApiName = ApiNames.Asos,
            Name = "We The Free by Free People",
            CatalogBrandId = 554,
        },
        new CatalogBrandApi
        {
            Id = 555,
            ApiId = 16589,
            ApiName = ApiNames.Asos,
            Name = "KAVU",
            CatalogBrandId = 555,
        },
        new CatalogBrandApi
        {
            Id = 556,
            ApiId = 16378,
            ApiName = ApiNames.Asos,
            Name = "Wednesday's Girl Maternity",
            CatalogBrandId = 556,
        },
        new CatalogBrandApi
        {
            Id = 557,
            ApiId = 21200,
            ApiName = ApiNames.Asos,
            Name = "Nobody’s Child Petite",
            CatalogBrandId = 557,
        },
        new CatalogBrandApi
        {
            Id = 558,
            ApiId = 16682,
            ApiName = ApiNames.Asos,
            Name = "Nobody's Child Plus",
            CatalogBrandId = 558,
        },
        new CatalogBrandApi
        {
            Id = 559,
            ApiId = 12311,
            ApiName = ApiNames.Asos,
            Name = "Base London",
            CatalogBrandId = 559,
        },
        new CatalogBrandApi
        {
            Id = 560,
            ApiId = 16319,
            ApiName = ApiNames.Asos,
            Name = "Les Girls Les Boys",
            CatalogBrandId = 560,
        },
        new CatalogBrandApi
        {
            Id = 561,
            ApiId = 15869,
            ApiName = ApiNames.Asos,
            Name = "Elsie & Fred",
            CatalogBrandId = 561,
        },
        new CatalogBrandApi
        {
            Id = 562,
            ApiId = 16339,
            ApiName = ApiNames.Asos,
            Name = "M.A.D Beauty",
            CatalogBrandId = 562,
        },
        new CatalogBrandApi
        {
            Id = 563,
            ApiId = 15757,
            ApiName = ApiNames.Asos,
            Name = "Madden Girl",
            CatalogBrandId = 563,
        },
        new CatalogBrandApi
        {
            Id = 564,
            ApiId = 20452,
            ApiName = ApiNames.Asos,
            Name = "Kanya London",
            CatalogBrandId = 564,
        },
        new CatalogBrandApi
        {
            Id = 565,
            ApiId = 15350,
            ApiName = ApiNames.Asos,
            Name = "Ultrasun",
            CatalogBrandId = 565,
        },
        new CatalogBrandApi
        {
            Id = 566,
            ApiId = 16507,
            ApiName = ApiNames.Asos,
            Name = "Sun Bum",
            CatalogBrandId = 566,
        },
        new CatalogBrandApi
        {
            Id = 567,
            ApiId = 14555,
            ApiName = ApiNames.Asos,
            Name = "Lottie",
            CatalogBrandId = 567,
        },
        new CatalogBrandApi
        {
            Id = 568,
            ApiId = 20607,
            ApiName = ApiNames.Asos,
            Name = "Tatti Lashes",
            CatalogBrandId = 568,
        },
        new CatalogBrandApi
        {
            Id = 569,
            ApiId = 12191,
            ApiName = ApiNames.Asos,
            Name = "Ed Hardy",
            CatalogBrandId = 569,
        },
        new CatalogBrandApi
        {
            Id = 570,
            ApiId = 12724,
            ApiName = ApiNames.Asos,
            Name = "Alpha Industries",
            CatalogBrandId = 570,
        },
        new CatalogBrandApi
        {
            Id = 571,
            ApiId = 15609,
            ApiName = ApiNames.Asos,
            Name = "Parlez",
            CatalogBrandId = 571,
        },
        new CatalogBrandApi
        {
            Id = 572,
            ApiId = 16164,
            ApiName = ApiNames.Asos,
            Name = "Wednesday's Girl Curve",
            CatalogBrandId = 572,
        },
        new CatalogBrandApi
        {
            Id = 573,
            ApiId = 12731,
            ApiName = ApiNames.Asos,
            Name = "Fiorucci",
            CatalogBrandId = 573,
        },
        new CatalogBrandApi
        {
            Id = 574,
            ApiId = 16401,
            ApiName = ApiNames.Asos,
            Name = "L'Oreal Elvive",
            CatalogBrandId = 574,
        },
        new CatalogBrandApi
        {
            Id = 575,
            ApiId = 16193,
            ApiName = ApiNames.Asos,
            Name = "Sunday Rain",
            CatalogBrandId = 575,
        },
        new CatalogBrandApi
        {
            Id = 576,
            ApiId = 13843,
            ApiName = ApiNames.Asos,
            Name = "New Look Maternity",
            CatalogBrandId = 576,
        },
        new CatalogBrandApi
        {
            Id = 577,
            ApiId = 16709,
            ApiName = ApiNames.Asos,
            Name = "Sergio Tacchini",
            CatalogBrandId = 577,
        },
        new CatalogBrandApi
        {
            Id = 578,
            ApiId = 676,
            ApiName = ApiNames.Asos,
            Name = "St. Tropez",
            CatalogBrandId = 578,
        },
        new CatalogBrandApi
        {
            Id = 579,
            ApiId = 16619,
            ApiName = ApiNames.Asos,
            Name = "Aaron Wallace",
            CatalogBrandId = 579,
        },
        new CatalogBrandApi
        {
            Id = 580,
            ApiId = 22356,
            ApiName = ApiNames.Asos,
            Name = "Sarah Chapman",
            CatalogBrandId = 580,
        },
        new CatalogBrandApi
        {
            Id = 581,
            ApiId = 16233,
            ApiName = ApiNames.Asos,
            Name = "Piz Buin",
            CatalogBrandId = 581,
        },
        new CatalogBrandApi
        {
            Id = 582,
            ApiId = 20400,
            ApiName = ApiNames.Asos,
            Name = "FADED FUTURE",
            CatalogBrandId = 582,
        },
        new CatalogBrandApi
        {
            Id = 583,
            ApiId = 16607,
            ApiName = ApiNames.Asos,
            Name = "Lancaster",
            CatalogBrandId = 583,
        },
        new CatalogBrandApi
        {
            Id = 584,
            ApiId = 15338,
            ApiName = ApiNames.Asos,
            Name = "Pureology",
            CatalogBrandId = 584,
        },
        new CatalogBrandApi
        {
            Id = 585,
            ApiId = 21955,
            ApiName = ApiNames.Asos,
            Name = "Grown Alchemist",
            CatalogBrandId = 585,
        },
        new CatalogBrandApi
        {
            Id = 586,
            ApiId = 12168,
            ApiName = ApiNames.Asos,
            Name = "Beauty Blender",
            CatalogBrandId = 586,
        },
        new CatalogBrandApi
        {
            Id = 587,
            ApiId = 20605,
            ApiName = ApiNames.Asos,
            Name = "KYO",
            CatalogBrandId = 587,
        },
        new CatalogBrandApi
        {
            Id = 588,
            ApiId = 16447,
            ApiName = ApiNames.Asos,
            Name = "HARRY'S",
            CatalogBrandId = 588,
        },
        new CatalogBrandApi
        {
            Id = 589,
            ApiId = 16116,
            ApiName = ApiNames.Asos,
            Name = "OGX",
            CatalogBrandId = 589,
        },
        new CatalogBrandApi
        {
            Id = 590,
            ApiId = 3735,
            ApiName = ApiNames.Asos,
            Name = "G-Star",
            CatalogBrandId = 590,
        },
        new CatalogBrandApi
        {
            Id = 591,
            ApiId = 12455,
            ApiName = ApiNames.Asos,
            Name = "Palladium",
            CatalogBrandId = 591,
        },
        new CatalogBrandApi
        {
            Id = 592,
            ApiId = 12681,
            ApiName = ApiNames.Asos,
            Name = "Vita Liberata",
            CatalogBrandId = 592,
        },
        new CatalogBrandApi
        {
            Id = 593,
            ApiId = 15589,
            ApiName = ApiNames.Asos,
            Name = "Spectrum",
            CatalogBrandId = 593,
        },
        new CatalogBrandApi
        {
            Id = 594,
            ApiId = 16514,
            ApiName = ApiNames.Asos,
            Name = "Veet",
            CatalogBrandId = 594,
        },
        new CatalogBrandApi
        {
            Id = 595,
            ApiId = 15473,
            ApiName = ApiNames.Asos,
            Name = "MasqueBAR",
            CatalogBrandId = 595,
        },
        new CatalogBrandApi
        {
            Id = 596,
            ApiId = 15816,
            ApiName = ApiNames.Asos,
            Name = "Aveda",
            CatalogBrandId = 596,
        },
        new CatalogBrandApi
        {
            Id = 597,
            ApiId = 16203,
            ApiName = ApiNames.Asos,
            Name = "Gillette",
            CatalogBrandId = 597,
        },
        new CatalogBrandApi
        {
            Id = 598,
            ApiId = 16022,
            ApiName = ApiNames.Asos,
            Name = "New Girl Order",
            CatalogBrandId = 598,
        },
        new CatalogBrandApi
        {
            Id = 599,
            ApiId = 16618,
            ApiName = ApiNames.Asos,
            Name = "EGO",
            CatalogBrandId = 599,
        },
        new CatalogBrandApi
        {
            Id = 600,
            ApiId = 20051,
            ApiName = ApiNames.Asos,
            Name = "Jamaican Mango & Lime",
            CatalogBrandId = 600,
        },
        new CatalogBrandApi
        {
            Id = 601,
            ApiId = 17701,
            ApiName = ApiNames.Asos,
            Name = "Hairburst",
            CatalogBrandId = 601,
        },
        new CatalogBrandApi
        {
            Id = 602,
            ApiId = 14451,
            ApiName = ApiNames.Asos,
            Name = "Rule London",
            CatalogBrandId = 602,
        },
        new CatalogBrandApi
        {
            Id = 603,
            ApiId = 16414,
            ApiName = ApiNames.Asos,
            Name = "Damson Madder",
            CatalogBrandId = 603,
        },
        new CatalogBrandApi
        {
            Id = 604,
            ApiId = 18050,
            ApiName = ApiNames.Asos,
            Name = "Bali Body",
            CatalogBrandId = 604,
        },
        new CatalogBrandApi
        {
            Id = 605,
            ApiId = 20951,
            ApiName = ApiNames.Asos,
            Name = "Extro & Vert Tall",
            CatalogBrandId = 605,
        },
        new CatalogBrandApi
        {
            Id = 606,
            ApiId = 16578,
            ApiName = ApiNames.Asos,
            Name = "Vesper Petite",
            CatalogBrandId = 606,
        },
        new CatalogBrandApi
        {
            Id = 607,
            ApiId = 12635,
            ApiName = ApiNames.Asos,
            Name = "Murad",
            CatalogBrandId = 607,
        },
        new CatalogBrandApi
        {
            Id = 608,
            ApiId = 17950,
            ApiName = ApiNames.Asos,
            Name = "Pieces Tall",
            CatalogBrandId = 608,
        },
        new CatalogBrandApi
        {
            Id = 609,
            ApiId = 16475,
            ApiName = ApiNames.Asos,
            Name = "Glow Hub",
            CatalogBrandId = 609,
        },
        new CatalogBrandApi
        {
            Id = 610,
            ApiId = 16423,
            ApiName = ApiNames.Asos,
            Name = "Aria Cove",
            CatalogBrandId = 610,
        },
        new CatalogBrandApi
        {
            Id = 611,
            ApiId = 15752,
            ApiName = ApiNames.Asos,
            Name = "First Aid Beauty",
            CatalogBrandId = 611,
        },
        new CatalogBrandApi
        {
            Id = 612,
            ApiId = 13827,
            ApiName = ApiNames.Asos,
            Name = "RVCA",
            CatalogBrandId = 612,
        },
        new CatalogBrandApi
        {
            Id = 613,
            ApiId = 16438,
            ApiName = ApiNames.Asos,
            Name = "Easilocks",
            CatalogBrandId = 613,
        },
        new CatalogBrandApi
        {
            Id = 614,
            ApiId = 3392,
            ApiName = ApiNames.Asos,
            Name = "Rare",
            CatalogBrandId = 614,
        },
        new CatalogBrandApi
        {
            Id = 615,
            ApiId = 16705,
            ApiName = ApiNames.Asos,
            Name = "HVISK",
            CatalogBrandId = 615,
        },
        new CatalogBrandApi
        {
            Id = 616,
            ApiId = 21959,
            ApiName = ApiNames.Asos,
            Name = "Spotlight",
            CatalogBrandId = 616,
        },
        new CatalogBrandApi
        {
            Id = 617,
            ApiId = 15815,
            ApiName = ApiNames.Asos,
            Name = "Bumble and Bumble",
            CatalogBrandId = 617,
        },
        new CatalogBrandApi
        {
            Id = 618,
            ApiId = 16267,
            ApiName = ApiNames.Asos,
            Name = "My White Secret",
            CatalogBrandId = 618,
        },
        new CatalogBrandApi
        {
            Id = 619,
            ApiId = 15961,
            ApiName = ApiNames.Asos,
            Name = "David Beckham",
            CatalogBrandId = 619,
        },
        new CatalogBrandApi
        {
            Id = 620,
            ApiId = 23055,
            ApiName = ApiNames.Asos,
            Name = "Sui Ava",
            CatalogBrandId = 620,
        },
        new CatalogBrandApi
        {
            Id = 621,
            ApiId = 21807,
            ApiName = ApiNames.Asos,
            Name = "Sundae Body",
            CatalogBrandId = 621,
        },
        new CatalogBrandApi
        {
            Id = 622,
            ApiId = 19500,
            ApiName = ApiNames.Asos,
            Name = "Carbon Theory",
            CatalogBrandId = 622,
        },
        new CatalogBrandApi
        {
            Id = 623,
            ApiId = 16112,
            ApiName = ApiNames.Asos,
            Name = "Flat Lay Company",
            CatalogBrandId = 623,
        },
        new CatalogBrandApi
        {
            Id = 624,
            ApiId = 16679,
            ApiName = ApiNames.Asos,
            Name = "Shaka",
            CatalogBrandId = 624,
        },
        new CatalogBrandApi
        {
            Id = 625,
            ApiId = 3755,
            ApiName = ApiNames.Asos,
            Name = "DKNY Active",
            CatalogBrandId = 625,
        },
        new CatalogBrandApi
        {
            Id = 626,
            ApiId = 62101,
            ApiName = ApiNames.Asos,
            Name = "Messina Hembry Clothing Ltd",
            CatalogBrandId = 626,
        },
        new CatalogBrandApi
        {
            Id = 627,
            ApiId = 13597,
            ApiName = ApiNames.Asos,
            Name = "Icon Brand",
            CatalogBrandId = 627,
        },
        new CatalogBrandApi
        {
            Id = 628,
            ApiId = 16431,
            ApiName = ApiNames.Asos,
            Name = "Sixth June Plus",
            CatalogBrandId = 628,
        },
        new CatalogBrandApi
        {
            Id = 629,
            ApiId = 15248,
            ApiName = ApiNames.Asos,
            Name = "Johnny's Chop Shop",
            CatalogBrandId = 629,
        },
        new CatalogBrandApi
        {
            Id = 630,
            ApiId = 20950,
            ApiName = ApiNames.Asos,
            Name = "Extro & Vert Petite",
            CatalogBrandId = 630,
        },
        new CatalogBrandApi
        {
            Id = 631,
            ApiId = 15811,
            ApiName = ApiNames.Asos,
            Name = "Y.A.S Petite",
            CatalogBrandId = 631,
        },
        new CatalogBrandApi
        {
            Id = 632,
            ApiId = 13656,
            ApiName = ApiNames.Asos,
            Name = "Cat Footwear",
            CatalogBrandId = 632,
        },
        new CatalogBrandApi
        {
            Id = 633,
            ApiId = 22455,
            ApiName = ApiNames.Asos,
            Name = "Bouclème",
            CatalogBrandId = 633,
        },
        new CatalogBrandApi
        {
            Id = 634,
            ApiId = 15067,
            ApiName = ApiNames.Asos,
            Name = "Missguided Maternity",
            CatalogBrandId = 634,
        },
        new CatalogBrandApi
        {
            Id = 635,
            ApiId = 12491,
            ApiName = ApiNames.Asos,
            Name = "Barneys Originals",
            CatalogBrandId = 635,
        },
        new CatalogBrandApi
        {
            Id = 636,
            ApiId = 62450,
            ApiName = ApiNames.Asos,
            Name = "JACK1T",
            CatalogBrandId = 636,
        },
        new CatalogBrandApi
        {
            Id = 637,
            ApiId = 3414,
            ApiName = ApiNames.Asos,
            Name = "Schott",
            CatalogBrandId = 637,
        },
        new CatalogBrandApi
        {
            Id = 638,
            ApiId = 13017,
            ApiName = ApiNames.Asos,
            Name = "Crooked Tongues",
            CatalogBrandId = 638,
        },
        new CatalogBrandApi
        {
            Id = 639,
            ApiId = 62250,
            ApiName = ApiNames.Asos,
            Name = "OOSC",
            CatalogBrandId = 639,
        },
        new CatalogBrandApi
        {
            Id = 640,
            ApiId = 15591,
            ApiName = ApiNames.Asos,
            Name = "Jack Wolfskin",
            CatalogBrandId = 640,
        },
        new CatalogBrandApi
        {
            Id = 641,
            ApiId = 16005,
            ApiName = ApiNames.Asos,
            Name = "Women'secret",
            CatalogBrandId = 641,
        },
        new CatalogBrandApi
        {
            Id = 642,
            ApiId = 15895,
            ApiName = ApiNames.Asos,
            Name = "Sally Hansen",
            CatalogBrandId = 642,
        },
        new CatalogBrandApi
        {
            Id = 643,
            ApiId = 14300,
            ApiName = ApiNames.Asos,
            Name = "Jaded London",
            CatalogBrandId = 643,
        },
        new CatalogBrandApi
        {
            Id = 644,
            ApiId = 62503,
            ApiName = ApiNames.Asos,
            Name = "Soho Skin",
            CatalogBrandId = 644,
        },
        new CatalogBrandApi
        {
            Id = 645,
            ApiId = 16250,
            ApiName = ApiNames.Asos,
            Name = "Dickies Girl",
            CatalogBrandId = 645,
        },
        new CatalogBrandApi
        {
            Id = 646,
            ApiId = 21855,
            ApiName = ApiNames.Asos,
            Name = "Lace & Beads Petite",
            CatalogBrandId = 646,
        },
        new CatalogBrandApi
        {
            Id = 647,
            ApiId = 16135,
            ApiName = ApiNames.Asos,
            Name = "StylPro",
            CatalogBrandId = 647,
        },
        new CatalogBrandApi
        {
            Id = 648,
            ApiId = 16461,
            ApiName = ApiNames.Asos,
            Name = "The O Dolls Collection",
            CatalogBrandId = 648,
        },
        new CatalogBrandApi
        {
            Id = 649,
            ApiId = 16178,
            ApiName = ApiNames.Asos,
            Name = "Go Guy",
            CatalogBrandId = 649,
        },
        new CatalogBrandApi
        {
            Id = 650,
            ApiId = 14444,
            ApiName = ApiNames.Asos,
            Name = "Little Mistress Plus",
            CatalogBrandId = 650,
        },
        new CatalogBrandApi
        {
            Id = 651,
            ApiId = 16393,
            ApiName = ApiNames.Asos,
            Name = "Eivy",
            CatalogBrandId = 651,
        },
        new CatalogBrandApi
        {
            Id = 652,
            ApiId = 12552,
            ApiName = ApiNames.Asos,
            Name = "The Hundreds",
            CatalogBrandId = 652,
        },
        new CatalogBrandApi
        {
            Id = 653,
            ApiId = 480,
            ApiName = ApiNames.Asos,
            Name = "Moschino",
            CatalogBrandId = 653,
        },
        new CatalogBrandApi
        {
            Id = 654,
            ApiId = 15351,
            ApiName = ApiNames.Asos,
            Name = "L Oréal Pa",
            CatalogBrandId = 654,
        },
        new CatalogBrandApi
        {
            Id = 655,
            ApiId = 20050,
            ApiName = ApiNames.Asos,
            Name = "Eco Style",
            CatalogBrandId = 655,
        },
        new CatalogBrandApi
        {
            Id = 656,
            ApiId = 20606,
            ApiName = ApiNames.Asos,
            Name = "Extro & Vert Plus",
            CatalogBrandId = 656,
        },
        new CatalogBrandApi
        {
            Id = 657,
            ApiId = 16723,
            ApiName = ApiNames.Asos,
            Name = "Wishful",
            CatalogBrandId = 657,
        },
        new CatalogBrandApi
        {
            Id = 658,
            ApiId = 16180,
            ApiName = ApiNames.Asos,
            Name = "Psychic Sisters",
            CatalogBrandId = 658,
        },
        new CatalogBrandApi
        {
            Id = 659,
            ApiId = 16652,
            ApiName = ApiNames.Asos,
            Name = "Threadbare Fitness Curve",
            CatalogBrandId = 659,
        },
        new CatalogBrandApi
        {
            Id = 660,
            ApiId = 14803,
            ApiName = ApiNames.Asos,
            Name = "Missguided Plus",
            CatalogBrandId = 660,
        },
        new CatalogBrandApi
        {
            Id = 661,
            ApiId = 21055,
            ApiName = ApiNames.Asos,
            Name = "Loungeable Tall",
            CatalogBrandId = 661,
        },
        new CatalogBrandApi
        {
            Id = 662,
            ApiId = 21450,
            ApiName = ApiNames.Asos,
            Name = "Basic Pleasure Mode",
            CatalogBrandId = 662,
        },
        new CatalogBrandApi
        {
            Id = 663,
            ApiId = 16072,
            ApiName = ApiNames.Asos,
            Name = "Dr Denim Tall",
            CatalogBrandId = 663,
        },
        new CatalogBrandApi
        {
            Id = 664,
            ApiId = 16387,
            ApiName = ApiNames.Asos,
            Name = "Hope & Ivy Plus",
            CatalogBrandId = 664,
        },
        new CatalogBrandApi
        {
            Id = 665,
            ApiId = 15091,
            ApiName = ApiNames.Asos,
            Name = "Hope & Ivy Maternity",
            CatalogBrandId = 665,
        },
        new CatalogBrandApi
        {
            Id = 666,
            ApiId = 16581,
            ApiName = ApiNames.Asos,
            Name = "Violet Romance Petite",
            CatalogBrandId = 666,
        },
        new CatalogBrandApi
        {
            Id = 667,
            ApiId = 13305,
            ApiName = ApiNames.Asos,
            Name = "REN",
            CatalogBrandId = 667,
        },
        new CatalogBrandApi
        {
            Id = 668,
            ApiId = 15003,
            ApiName = ApiNames.Asos,
            Name = "Harry Brown",
            CatalogBrandId = 668,
        },
        new CatalogBrandApi
        {
            Id = 669,
            ApiId = 15364,
            ApiName = ApiNames.Asos,
            Name = "Gianni Feraud",
            CatalogBrandId = 669,
        },
        new CatalogBrandApi
        {
            Id = 670,
            ApiId = 19900,
            ApiName = ApiNames.Asos,
            Name = "Shambhala",
            CatalogBrandId = 670,
        },
        new CatalogBrandApi
        {
            Id = 671,
            ApiId = 14557,
            ApiName = ApiNames.Asos,
            Name = "Jayley",
            CatalogBrandId = 671,
        },
        new CatalogBrandApi
        {
            Id = 672,
            ApiId = 13518,
            ApiName = ApiNames.Asos,
            Name = "Hurley",
            CatalogBrandId = 672,
        },
        new CatalogBrandApi
        {
            Id = 673,
            ApiId = 13935,
            ApiName = ApiNames.Asos,
            Name = "Deus Ex Machina",
            CatalogBrandId = 673,
        },
        new CatalogBrandApi
        {
            Id = 674,
            ApiId = 16432,
            ApiName = ApiNames.Asos,
            Name = "A.Kjaerbede",
            CatalogBrandId = 674,
        },
        new CatalogBrandApi
        {
            Id = 675,
            ApiId = 15821,
            ApiName = ApiNames.Asos,
            Name = "CHICKIDEE",
            CatalogBrandId = 675,
        },
        new CatalogBrandApi
        {
            Id = 676,
            ApiId = 14974,
            ApiName = ApiNames.Asos,
            Name = "Sisters of the Tribe",
            CatalogBrandId = 676,
        },
        new CatalogBrandApi
        {
            Id = 677,
            ApiId = 21156,
            ApiName = ApiNames.Asos,
            Name = "Truffle Collection Wide Fit",
            CatalogBrandId = 677,
        },
        new CatalogBrandApi
        {
            Id = 678,
            ApiId = 18151,
            ApiName = ApiNames.Asos,
            Name = "BeYou",
            CatalogBrandId = 678,
        },
        new CatalogBrandApi
        {
            Id = 679,
            ApiId = 13573,
            ApiName = ApiNames.Asos,
            Name = "Rhythm",
            CatalogBrandId = 679,
        },
        new CatalogBrandApi
        {
            Id = 680,
            ApiId = 16214,
            ApiName = ApiNames.Asos,
            Name = "Tonymoly",
            CatalogBrandId = 680,
        },
        new CatalogBrandApi
        {
            Id = 681,
            ApiId = 62789,
            ApiName = ApiNames.Asos,
            Name = "Denim Project",
            CatalogBrandId = 681,
        },
        new CatalogBrandApi
        {
            Id = 682,
            ApiId = 14187,
            ApiName = ApiNames.Asos,
            Name = "CAT",
            CatalogBrandId = 682,
        },
        new CatalogBrandApi
        {
            Id = 683,
            ApiId = 13761,
            ApiName = ApiNames.Asos,
            Name = "Fat Moose",
            CatalogBrandId = 683,
        },
        new CatalogBrandApi
        {
            Id = 684,
            ApiId = 13962,
            ApiName = ApiNames.Asos,
            Name = "Limit",
            CatalogBrandId = 684,
        },
        new CatalogBrandApi
        {
            Id = 685,
            ApiId = 3675,
            ApiName = ApiNames.Asos,
            Name = "Urbancode",
            CatalogBrandId = 685,
        },
        new CatalogBrandApi
        {
            Id = 686,
            ApiId = 14449,
            ApiName = ApiNames.Asos,
            Name = "Noisy May Tall",
            CatalogBrandId = 686,
        },
        new CatalogBrandApi
        {
            Id = 687,
            ApiId = 12626,
            ApiName = ApiNames.Asos,
            Name = "L'Occitane",
            CatalogBrandId = 687,
        },
        new CatalogBrandApi
        {
            Id = 688,
            ApiId = 12754,
            ApiName = ApiNames.Asos,
            Name = "Dare 2b",
            CatalogBrandId = 688,
        },
        new CatalogBrandApi
        {
            Id = 689,
            ApiId = 15584,
            ApiName = ApiNames.Asos,
            Name = "Brave Soul Petite",
            CatalogBrandId = 689,
        },
        new CatalogBrandApi
        {
            Id = 690,
            ApiId = 20601,
            ApiName = ApiNames.Asos,
            Name = "Topshop Hourglass",
            CatalogBrandId = 690,
        },
        new CatalogBrandApi
        {
            Id = 691,
            ApiId = 62798,
            ApiName = ApiNames.Asos,
            Name = "Off The Hook",
            CatalogBrandId = 691,
        },
        new CatalogBrandApi
        {
            Id = 692,
            ApiId = 16244,
            ApiName = ApiNames.Asos,
            Name = "Shelby & Sons",
            CatalogBrandId = 692,
        },
        new CatalogBrandApi
        {
            Id = 693,
            ApiId = 647,
            ApiName = ApiNames.Asos,
            Name = "Sean John",
            CatalogBrandId = 693,
        },
        new CatalogBrandApi
        {
            Id = 694,
            ApiId = 16406,
            ApiName = ApiNames.Asos,
            Name = "Forever New Curve",
            CatalogBrandId = 694,
        },
        new CatalogBrandApi
        {
            Id = 695,
            ApiId = 15297,
            ApiName = ApiNames.Asos,
            Name = "Lamoda",
            CatalogBrandId = 695,
        },
        new CatalogBrandApi
        {
            Id = 696,
            ApiId = 62700,
            ApiName = ApiNames.Asos,
            Name = "Regatta",
            CatalogBrandId = 696,
        },
        new CatalogBrandApi
        {
            Id = 697,
            ApiId = 16528,
            ApiName = ApiNames.Asos,
            Name = "The Kript",
            CatalogBrandId = 697,
        },
        new CatalogBrandApi
        {
            Id = 698,
            ApiId = 15827,
            ApiName = ApiNames.Asos,
            Name = "ONLY Petite",
            CatalogBrandId = 698,
        },
        new CatalogBrandApi
        {
            Id = 699,
            ApiId = 3154,
            ApiName = ApiNames.Asos,
            Name = "Helene Berman",
            CatalogBrandId = 699,
        },
        new CatalogBrandApi
        {
            Id = 700,
            ApiId = 62410,
            ApiName = ApiNames.Asos,
            Name = "Pajar",
            CatalogBrandId = 700,
        },
        new CatalogBrandApi
        {
            Id = 701,
            ApiId = 3513,
            ApiName = ApiNames.Asos,
            Name = "Claudia Canova",
            CatalogBrandId = 701,
        },
        new CatalogBrandApi
        {
            Id = 702,
            ApiId = 15143,
            ApiName = ApiNames.Asos,
            Name = "Dorina",
            CatalogBrandId = 702,
        },
        new CatalogBrandApi
        {
            Id = 703,
            ApiId = 16039,
            ApiName = ApiNames.Asos,
            Name = "Thinx",
            CatalogBrandId = 703,
        },
        new CatalogBrandApi
        {
            Id = 704,
            ApiId = 481,
            ApiName = ApiNames.Asos,
            Name = "Motel",
            CatalogBrandId = 704,
        },
        new CatalogBrandApi
        {
            Id = 705,
            ApiId = 13839,
            ApiName = ApiNames.Asos,
            Name = "Call it Spring",
            CatalogBrandId = 705,
        },
        new CatalogBrandApi
        {
            Id = 706,
            ApiId = 15355,
            ApiName = ApiNames.Asos,
            Name = "Tommy Hilfiger Denim",
            CatalogBrandId = 706,
        },
        new CatalogBrandApi
        {
            Id = 707,
            ApiId = 16306,
            ApiName = ApiNames.Asos,
            Name = "Topshop Maternity",
            CatalogBrandId = 707,
        },
        new CatalogBrandApi
        {
            Id = 708,
            ApiId = 62799,
            ApiName = ApiNames.Asos,
            Name = "SENSSE",
            CatalogBrandId = 708,
        },
        new CatalogBrandApi
        {
            Id = 709,
            ApiId = 12527,
            ApiName = ApiNames.Asos,
            Name = "Accurist",
            CatalogBrandId = 709,
        },
        new CatalogBrandApi
        {
            Id = 710,
            ApiId = 16534,
            ApiName = ApiNames.Asos,
            Name = "VIOLET ROMANCE",
            CatalogBrandId = 710,
        },
        new CatalogBrandApi
        {
            Id = 711,
            ApiId = 18901,
            ApiName = ApiNames.Asos,
            Name = "Edited",
            CatalogBrandId = 711,
        },
        new CatalogBrandApi
        {
            Id = 712,
            ApiId = 14616,
            ApiName = ApiNames.Asos,
            Name = "Kingsley Ryan",
            CatalogBrandId = 712,
        },
        new CatalogBrandApi
        {
            Id = 713,
            ApiId = 15710,
            ApiName = ApiNames.Asos,
            Name = "Flounce London Maternity",
            CatalogBrandId = 713,
        },
        new CatalogBrandApi
        {
            Id = 714,
            ApiId = 13668,
            ApiName = ApiNames.Asos,
            Name = "AX Paris",
            CatalogBrandId = 714,
        },
        new CatalogBrandApi
        {
            Id = 715,
            ApiId = 14629,
            ApiName = ApiNames.Asos,
            Name = "Devils Advocate",
            CatalogBrandId = 715,
        }
            );
    }
}