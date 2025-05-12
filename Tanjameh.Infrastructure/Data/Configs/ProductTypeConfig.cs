

using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Tanjameh.Core.Entities;

namespace Tanjameh.Infrastructure.Data.Configs;

internal class ProductTypeConfig : IEntityTypeConfiguration<ProductType>
{
    public void Configure(EntityTypeBuilder<ProductType> builder)
    {
        builder.HasData(

       new ProductType
       {
           Id = 1,
           Name = "T-shirts",
           Slug = "t-shirts",
           WeightId = 2,
           ApiId = 8415
       },
       new ProductType
       {
           Id = 2,
           Name = "Shirts",
           Slug = "shirts",
           WeightId = 2,
           ApiId = 8390
       },
       new ProductType
       {
           Id = 3,
           Name = "Rings",
           Slug = "rings",
           WeightId = 2,
           ApiId = 8612
       },
       new ProductType
       {
           Id = 4,
           Name = "Vests",
           Slug = "vests",
           WeightId = 2,
           ApiId = 8414
       },
       new ProductType
       {
           Id = 5,
           Name = "Polo Shirts",
           Slug = "polo-shirts",
           WeightId = 2,
           ApiId = 10888
       },
       new ProductType
       {
           Id = 6,
           Name = "Shorts",
           Slug = "shorts",
           WeightId = 2,
           ApiId = 8386
       },
       new ProductType
       {
           Id = 7,
           Name = "Gilets",
           Slug = "gilets",
           WeightId = 2,
           ApiId = 8399
       },
       new ProductType
       {
           Id = 8,
           Name = "Trunks",
           Slug = "trunks",
           WeightId = null,
           ApiId = 8572
       },
       new ProductType
       {
           Id = 9,
           Name = "Jackets",
           Slug = "jackets",
           WeightId = 3,
           ApiId = 8401
       },
       new ProductType
       {
           Id = 10,
           Name = "Socks",
           Slug = "socks",
           WeightId = null,
           ApiId = 8366
       },
       new ProductType
       {
           Id = 11,
           Name = "Face Coverings",
           Slug = "face-coverings",
           WeightId = null,
           ApiId = 11350
       },
       new ProductType
       {
           Id = 12,
           Name = "Sandals",
           Slug = "sandals",
           WeightId = 2,
           ApiId = 8600
       },
       new ProductType
       {
           Id = 13,
           Name = "Jeans",
           Slug = "jeans",
           WeightId = null,
           ApiId = 8393
       },
       new ProductType
       {
           Id = 14,
           Name = "Suit Jackets",
           Slug = "suit-jackets",
           WeightId = 3,
           ApiId = 8655
       },
       new ProductType
       {
           Id = 15,
           Name = "Suit Trousers",
           Slug = "suit-trousers",
           WeightId = 2,
           ApiId = 8654
       },
       new ProductType
       {
           Id = 16,
           Name = "Trousers",
           Slug = "trousers",
           WeightId = 3,
           ApiId = 8397
       },
       new ProductType
       {
           Id = 17,
           Name = "Sweatshirts",
           Slug = "sweatshirts",
           WeightId = 2,
           ApiId = 8405
       },
       new ProductType
       {
           Id = 18,
           Name = "Hoodies",
           Slug = "hoodies",
           WeightId = 3,
           ApiId = 8391
       },
       new ProductType
       {
           Id = 19,
           Name = "Waistcoats",
           Slug = "waistcoats",
           WeightId = 2,
           ApiId = 8554
       },
       new ProductType
       {
           Id = 20,
           Name = "Blazers",
           Slug = "blazers",
           WeightId = 3,
           ApiId = 8400
       },
       new ProductType
       {
           Id = 21,
           Name = "Body Moisturisers",
           Slug = "body-moisturisers",
           WeightId = null,
           ApiId = 9763
       },
       new ProductType
       {
           Id = 22,
           Name = "Fake Tan",
           Slug = "fake-tan",
           WeightId = null,
           ApiId = 8488
       },
       new ProductType
       {
           Id = 23,
           Name = "Bath Sets",
           Slug = "bath-sets",
           WeightId = null,
           ApiId = 9773
       },
       new ProductType
       {
           Id = 24,
           Name = "Body Washes",
           Slug = "body-washes",
           WeightId = null,
           ApiId = 8455
       },
       new ProductType
       {
           Id = 25,
           Name = "Body Scrubs",
           Slug = "body-scrubs",
           WeightId = null,
           ApiId = 9334
       },
       new ProductType
       {
           Id = 26,
           Name = "Body Oils",
           Slug = "body-oils",
           WeightId = null,
           ApiId = 9323
       },
       new ProductType
       {
           Id = 27,
           Name = "Self Tan",
           Slug = "self-tan",
           WeightId = null,
           ApiId = 9766
       },
       new ProductType
       {
           Id = 28,
           Name = "Fragrances",
           Slug = "fragrances",
           WeightId = null,
           ApiId = 8513
       },
       new ProductType
       {
           Id = 29,
           Name = "Candles",
           Slug = "candles",
           WeightId = null,
           ApiId = 8669
       },
       new ProductType
       {
           Id = 30,
           Name = "Watches",
           Slug = "watches",
           WeightId = null,
           ApiId = 8594
       },
       new ProductType
       {
           Id = 31,
           Name = "Belts",
           Slug = "belts",
           WeightId = null,
           ApiId = 8253
       },
       new ProductType
       {
           Id = 32,
           Name = "Chinos",
           Slug = "chinos",
           WeightId = null,
           ApiId = 8396
       },
       new ProductType
       {
           Id = 33,
           Name = "Shoes",
           Slug = "shoes",
           WeightId = null,
           ApiId = 8609
       },
       new ProductType
       {
           Id = 34,
           Name = "Sunglasses",
           Slug = "sunglasses",
           WeightId = null,
           ApiId = 8244
       },
       new ProductType
       {
           Id = 35,
           Name = "Sun Care",
           Slug = "sun-care",
           WeightId = null,
           ApiId = 9765
       },
       new ProductType
       {
           Id = 36,
           Name = "Briefs",
           Slug = "briefs",
           WeightId = null,
           ApiId = 8562
       },
       new ProductType
       {
           Id = 37,
           Name = "Joggers",
           Slug = "joggers",
           WeightId = 2,
           ApiId = 8407
       },
       new ProductType
       {
           Id = 38,
           Name = "Bra Solutions",
           Slug = "bra-solutions",
           WeightId = null,
           ApiId = 8699
       },
       new ProductType
       {
           Id = 39,
           Name = "Hair Clips",
           Slug = "hair-clips",
           WeightId = 2,
           ApiId = 8369
       },
       new ProductType
       {
           Id = 40,
           Name = "Bras",
           Slug = "bras",
           WeightId = 2,
           ApiId = 8565
       },
       new ProductType
       {
           Id = 41,
           Name = "Tracksuits",
           Slug = "tracksuits",
           WeightId = 4,
           ApiId = 8472
       },
       new ProductType
       {
           Id = 42,
           Name = "Thongs",
           Slug = "thongs",
           WeightId = null,
           ApiId = 8578
       },
       new ProductType
       {
           Id = 43,
           Name = "Boxers",
           Slug = "boxers",
           WeightId = null,
           ApiId = 8577
       },
       new ProductType
       {
           Id = 44,
           Name = "Loungewear Sets",
           Slug = "loungewear-sets",
           WeightId = 3,
           ApiId = 8466
       },
       new ProductType
       {
           Id = 45,
           Name = "Bralets",
           Slug = "bralets",
           WeightId = null,
           ApiId = 8560
       },
       new ProductType
       {
           Id = 46,
           Name = "Dresses",
           Slug = "dresses",
           WeightId = null,
           ApiId = 8416
       },
       new ProductType
       {
           Id = 47,
           Name = "Bags",
           Slug = "bags",
           WeightId = null,
           ApiId = 8283
       },
       new ProductType
       {
           Id = 48,
           Name = "Purses",
           Slug = "purses",
           WeightId = null,
           ApiId = 8431
       },
       new ProductType
       {
           Id = 49,
           Name = "Boots",
           Slug = "boots",
           WeightId = null,
           ApiId = 8585
       },
       new ProductType
       {
           Id = 50,
           Name = "Fleeces",
           Slug = "fleeces",
           WeightId = null,
           ApiId = 10885
       },
       new ProductType
       {
           Id = 51,
           Name = "Coats",
           Slug = "coats",
           WeightId = 4,
           ApiId = 8406
       },
       new ProductType
       {
           Id = 52,
           Name = "Hair Masks",
           Slug = "hair-masks",
           WeightId = null,
           ApiId = 8514
       },
       new ProductType
       {
           Id = 53,
           Name = "Shampoos",
           Slug = "shampoos",
           WeightId = null,
           ApiId = 8510
       },
       new ProductType
       {
           Id = 54,
           Name = "Hair Mists & Fragrances",
           Slug = "hair-mists-&-fragrances",
           WeightId = null,
           ApiId = 15987
       },
       new ProductType
       {
           Id = 55,
           Name = "Facial Moisturisers",
           Slug = "facial-moisturisers",
           WeightId = null,
           ApiId = 9769
       },
       new ProductType
       {
           Id = 56,
           Name = "Facial Serums",
           Slug = "facial-serums",
           WeightId = null,
           ApiId = 8489
       },
       new ProductType
       {
           Id = 57,
           Name = "Wash Bags",
           Slug = "wash-bags",
           WeightId = null,
           ApiId = 8282
       },
       new ProductType
       {
           Id = 58,
           Name = "Makeup Bags",
           Slug = "makeup-bags",
           WeightId = null,
           ApiId = 10071
       },
       new ProductType
       {
           Id = 59,
           Name = "Beauty Tools",
           Slug = "beauty-tools",
           WeightId = null,
           ApiId = 9332
       },
       new ProductType
       {
           Id = 60,
           Name = "Makeup Brushes",
           Slug = "makeup-brushes",
           WeightId = null,
           ApiId = 10059
       },
       new ProductType
       {
           Id = 61,
           Name = "Vibrators",
           Slug = "vibrators",
           WeightId = null,
           ApiId = 15295
       },
       new ProductType
       {
           Id = 62,
           Name = "Lubricants",
           Slug = "lubricants",
           WeightId = null,
           ApiId = 11139
       },
       new ProductType
       {
           Id = 63,
           Name = "Caps",
           Slug = "caps",
           WeightId = null,
           ApiId = 8275
       },
       new ProductType
       {
           Id = 64,
           Name = "Harnesses",
           Slug = "harnesses",
           WeightId = null,
           ApiId = 8242
       },
       new ProductType
       {
           Id = 65,
           Name = "Scarves",
           Slug = "scarves",
           WeightId = null,
           ApiId = 8276
       },
       new ProductType
       {
           Id = 66,
           Name = "Hats",
           Slug = "hats",
           WeightId = null,
           ApiId = 8245
       },
       new ProductType
       {
           Id = 67,
           Name = "Snoods",
           Slug = "snoods",
           WeightId = 2,
           ApiId = 8273
       },
       new ProductType
       {
           Id = 68,
           Name = "Trainers",
           Slug = "trainers",
           WeightId = 3,
           ApiId = 8606
       },
       new ProductType
       {
           Id = 69,
           Name = "Sliders",
           Slug = "sliders",
           WeightId = 3,
           ApiId = 10774
       },
       new ProductType
       {
           Id = 70,
           Name = "Jock Straps",
           Slug = "jock-straps",
           WeightId = null,
           ApiId = 8570
       },
       new ProductType
       {
           Id = 71,
           Name = "Hairbands",
           Slug = "hairbands",
           WeightId = 2,
           ApiId = 8240
       },
       new ProductType
       {
           Id = 72,
           Name = "Headbands",
           Slug = "headbands",
           WeightId = null,
           ApiId = 8248
       },
       new ProductType
       {
           Id = 73,
           Name = "Slippers",
           Slug = "slippers",
           WeightId = null,
           ApiId = 8597
       },
       new ProductType
       {
           Id = 74,
           Name = "Conditioners",
           Slug = "conditioners",
           WeightId = null,
           ApiId = 8449
       },
       new ProductType
       {
           Id = 75,
           Name = "Hair Brushes",
           Slug = "hair-brushes",
           WeightId = null,
           ApiId = 8526
       },
       new ProductType
       {
           Id = 76,
           Name = "Hair Extensions",
           Slug = "hair-extensions",
           WeightId = null,
           ApiId = 9770
       },
       new ProductType
       {
           Id = 77,
           Name = "Body Lotions",
           Slug = "body-lotions",
           WeightId = null,
           ApiId = 8454
       },
       new ProductType
       {
           Id = 78,
           Name = "Leggings",
           Slug = "leggings",
           WeightId = null,
           ApiId = 8385
       },
       new ProductType
       {
           Id = 79,
           Name = "Nighties",
           Slug = "nighties",
           WeightId = 2,
           ApiId = 8715
       },
       new ProductType
       {
           Id = 80,
           Name = "Skirts",
           Slug = "skirts",
           WeightId = 2,
           ApiId = 8402
       },
       new ProductType
       {
           Id = 81,
           Name = "Corset Tops",
           Slug = "corset-tops",
           WeightId = 2,
           ApiId = 11273
       },
       new ProductType
       {
           Id = 82,
           Name = "Crop Tops",
           Slug = "crop-tops",
           WeightId = 2,
           ApiId = 8398
       },
       new ProductType
       {
           Id = 83,
           Name = "Pyjamas",
           Slug = "pyjamas",
           WeightId = 2,
           ApiId = 8388
       },
       new ProductType
       {
           Id = 84,
           Name = "Earrings",
           Slug = "earrings",
           WeightId = 2,
           ApiId = 8592
       },
       new ProductType
       {
           Id = 85,
           Name = "Bum Bags",
           Slug = "bum-bags",
           WeightId = null,
           ApiId = 8266
       },
       new ProductType
       {
           Id = 86,
           Name = "Bracelets",
           Slug = "bracelets",
           WeightId = 2,
           ApiId = 8591
       },
       new ProductType
       {
           Id = 87,
           Name = "Necklaces",
           Slug = "necklaces",
           WeightId = 2,
           ApiId = 8608
       },
       new ProductType
       {
           Id = 88,
           Name = "Card Holders",
           Slug = "card-holders",
           WeightId = null,
           ApiId = 8271
       },
       new ProductType
       {
           Id = 89,
           Name = "Corsets",
           Slug = "corsets",
           WeightId = 2,
           ApiId = 8700
       },
       new ProductType
       {
           Id = 90,
           Name = "Blouses",
           Slug = "blouses",
           WeightId = 2,
           ApiId = 8392
       },
       new ProductType
       {
           Id = 91,
           Name = "Backpacks",
           Slug = "backpacks",
           WeightId = null,
           ApiId = 8281
       },
       new ProductType
       {
           Id = 92,
           Name = "Shaving Creams & Gels",
           Slug = "shaving-creams-&-gels",
           WeightId = null,
           ApiId = 8858
       },
       new ProductType
       {
           Id = 93,
           Name = "Shaving Sets",
           Slug = "shaving-sets",
           WeightId = null,
           ApiId = 8856
       },
       new ProductType
       {
           Id = 94,
           Name = "Grooming Sets",
           Slug = "grooming-sets",
           WeightId = null,
           ApiId = 9391
       },
       new ProductType
       {
           Id = 95,
           Name = "Beard Oils",
           Slug = "beard-oils",
           WeightId = null,
           ApiId = 8848
       },
       new ProductType
       {
           Id = 96,
           Name = "Beard Balms",
           Slug = "beard-balms",
           WeightId = null,
           ApiId = 8849
       },
       new ProductType
       {
           Id = 97,
           Name = "After Shave Lotions",
           Slug = "after-shave-lotions",
           WeightId = null,
           ApiId = 9295
       },
       new ProductType
       {
           Id = 98,
           Name = "Gloves",
           Slug = "gloves",
           WeightId = 2,
           ApiId = 8236
       },
       new ProductType
       {
           Id = 99,
           Name = "Skincare Sets",
           Slug = "skincare-sets",
           WeightId = null,
           ApiId = 9782
       },
       new ProductType
       {
           Id = 100,
           Name = "Hair Grips",
           Slug = "hair-grips",
           WeightId = null,
           ApiId = 9733
       },
       new ProductType
       {
           Id = 101,
           Name = "Lingerie Bralets",
           Slug = "lingerie-bralets",
           WeightId = null,
           ApiId = 9748
       },
       new ProductType
       {
           Id = 102,
           Name = "Hair Treatments",
           Slug = "hair-treatments",
           WeightId = 2,
           ApiId = 9761
       },
       new ProductType
       {
           Id = 103,
           Name = "Hair Sets",
           Slug = "hair-sets",
           WeightId = null,
           ApiId = 8527
       },
       new ProductType
       {
           Id = 104,
           Name = "Camis",
           Slug = "camis",
           WeightId = null,
           ApiId = 8417
       },
       new ProductType
       {
           Id = 105,
           Name = "Lip Balms",
           Slug = "lip-balms",
           WeightId = null,
           ApiId = 8505
       },
       new ProductType
       {
           Id = 106,
           Name = "Blushers",
           Slug = "blushers",
           WeightId = null,
           ApiId = 8447
       },
       new ProductType
       {
           Id = 107,
           Name = "Lip Glosses",
           Slug = "lip-glosses",
           WeightId = null,
           ApiId = 8543
       },
       new ProductType
       {
           Id = 108,
           Name = "Nightwear Sets",
           Slug = "nightwear-sets",
           WeightId = null,
           ApiId = 8468
       },
       new ProductType
       {
           Id = 109,
           Name = "Palettes",
           Slug = "palettes",
           WeightId = null,
           ApiId = 9787
       },
       new ProductType
       {
           Id = 110,
           Name = "Bronzers",
           Slug = "bronzers",
           WeightId = null,
           ApiId = 8451
       },
       new ProductType
       {
           Id = 111,
           Name = "Swim Shorts",
           Slug = "swim-shorts",
           WeightId = null,
           ApiId = 8576
       },
       new ProductType
       {
           Id = 112,
           Name = "Playsuits",
           Slug = "playsuits",
           WeightId = 3,
           ApiId = 8403
       },
       new ProductType
       {
           Id = 113,
           Name = "Jumpsuits",
           Slug = "jumpsuits",
           WeightId = 2,
           ApiId = 8384
       },
       new ProductType
       {
           Id = 114,
           Name = "UV Sun Protection",
           Slug = "uv-sun-protection",
           WeightId = null,
           ApiId = 15989
       },
       new ProductType
       {
           Id = 115,
           Name = "Body Treatments",
           Slug = "body-treatments",
           WeightId = null,
           ApiId = 9336
       },
       new ProductType
       {
           Id = 116,
           Name = "Cardigans",
           Slug = "cardigans",
           WeightId = 3,
           ApiId = 8404
       },
       new ProductType
       {
           Id = 117,
           Name = "Jumpers",
           Slug = "jumpers",
           WeightId = 3,
           ApiId = 8387
       },
       new ProductType
       {
           Id = 118,
           Name = "Pyjama Bottoms",
           Slug = "pyjama-bottoms",
           WeightId = null,
           ApiId = 9038
       },
       new ProductType
       {
           Id = 119,
           Name = "Onesies",
           Slug = "onesies",
           WeightId = null,
           ApiId = 8471
       },
       new ProductType
       {
           Id = 120,
           Name = "Eye Shadow Palettes",
           Slug = "eye-shadow-palettes",
           WeightId = null,
           ApiId = 9778
       },
       new ProductType
       {
           Id = 121,
           Name = "Lipsticks",
           Slug = "lipsticks",
           WeightId = null,
           ApiId = 8529
       },
       new ProductType
       {
           Id = 122,
           Name = "Highlighters",
           Slug = "highlighters",
           WeightId = null,
           ApiId = 8659
       },
       new ProductType
       {
           Id = 123,
           Name = "Cleansers",
           Slug = "cleansers",
           WeightId = null,
           ApiId = 9768
       },
       new ProductType
       {
           Id = 124,
           Name = "Nail Treatments",
           Slug = "nail-treatments",
           WeightId = null,
           ApiId = 8538
       },
       new ProductType
       {
           Id = 125,
           Name = "Facial Exfoliators",
           Slug = "facial-exfoliators",
           WeightId = null,
           ApiId = 9788
       },
       new ProductType
       {
           Id = 126,
           Name = "Makeup Removers",
           Slug = "makeup-removers",
           WeightId = null,
           ApiId = 10062
       },
       new ProductType
       {
           Id = 127,
           Name = "Facial Creams",
           Slug = "facial-creams",
           WeightId = null,
           ApiId = 9729
       },
       new ProductType
       {
           Id = 128,
           Name = "Face Masks",
           Slug = "face-masks",
           WeightId = null,
           ApiId = 8516
       },
       new ProductType
       {
           Id = 129,
           Name = "Bikini Tops",
           Slug = "bikini-tops",
           WeightId = null,
           ApiId = 8711
       },
       new ProductType
       {
           Id = 130,
           Name = "Ties",
           Slug = "ties",
           WeightId = null,
           ApiId = 8265
       },
       new ProductType
       {
           Id = 131,
           Name = "Bow Ties",
           Slug = "bow-ties",
           WeightId = null,
           ApiId = 8284
       },
       new ProductType
       {
           Id = 132,
           Name = "Hygiene Products",
           Slug = "hygiene-products",
           WeightId = null,
           ApiId = 10883
       },
       new ProductType
       {
           Id = 133,
           Name = "Bikini Bottoms",
           Slug = "bikini-bottoms",
           WeightId = null,
           ApiId = 9834
       },
       new ProductType
       {
           Id = 134,
           Name = "Water Bottles",
           Slug = "water-bottles",
           WeightId = null,
           ApiId = 9139
       },
       new ProductType
       {
           Id = 135,
           Name = "Primers",
           Slug = "primers",
           WeightId = null,
           ApiId = 8533
       },
       new ProductType
       {
           Id = 136,
           Name = "Pyjama Tops",
           Slug = "pyjama-tops",
           WeightId = null,
           ApiId = 9040
       },
       new ProductType
       {
           Id = 137,
           Name = "Lip Kits",
           Slug = "lip-kits",
           WeightId = null,
           ApiId = 9775
       },
       new ProductType
       {
           Id = 138,
           Name = "Facial Masks",
           Slug = "facial-masks",
           WeightId = null,
           ApiId = 8500
       },
       new ProductType
       {
           Id = 139,
           Name = "Eye Creams",
           Slug = "eye-creams",
           WeightId = null,
           ApiId = 8453
       },
       new ProductType
       {
           Id = 140,
           Name = "Wallets",
           Slug = "wallets",
           WeightId = null,
           ApiId = 8280
       },
       new ProductType
       {
           Id = 141,
           Name = "Beanies",
           Slug = "beanies",
           WeightId = null,
           ApiId = 8238
       },
       new ProductType
       {
           Id = 142,
           Name = "Flip Flops",
           Slug = "flip-flops",
           WeightId = null,
           ApiId = 10775
       },
       new ProductType
       {
           Id = 143,
           Name = "Hair Bands",
           Slug = "hair-bands",
           WeightId = null,
           ApiId = 8541
       },
       new ProductType
       {
           Id = 144,
           Name = "Hair Accessories",
           Slug = "hair-accessories",
           WeightId = null,
           ApiId = 15986
       },
       new ProductType
       {
           Id = 145,
           Name = "Eyebrow Pencils",
           Slug = "eyebrow-pencils",
           WeightId = null,
           ApiId = 8435
       },
       new ProductType
       {
           Id = 146,
           Name = "Eye Shadows",
           Slug = "eye-shadows",
           WeightId = null,
           ApiId = 8461
       },
       new ProductType
       {
           Id = 147,
           Name = "Makeup Sets",
           Slug = "makeup-sets",
           WeightId = null,
           ApiId = 10066
       },
       new ProductType
       {
           Id = 148,
           Name = "Dungarees",
           Slug = "dungarees",
           WeightId = 4,
           ApiId = 8411
       },
       new ProductType
       {
           Id = 149,
           Name = "Scalp Scrubs & Treatments",
           Slug = "scalp-scrubs-&-treatments",
           WeightId = null,
           ApiId = 15985
       },
       new ProductType
       {
           Id = 150,
           Name = "Lingerie Sets",
           Slug = "lingerie-sets",
           WeightId = null,
           ApiId = 8556
       },
       new ProductType
       {
           Id = 151,
           Name = "Football Shirts",
           Slug = "football-shirts",
           WeightId = null,
           ApiId = 9311
       },
       new ProductType
       {
           Id = 152,
           Name = "Tank Tops",
           Slug = "tank-tops",
           WeightId = null,
           ApiId = 9335
       },
       new ProductType
       {
           Id = 153,
           Name = "Co-ords",
           Slug = "co-ords",
           WeightId = null,
           ApiId = 9349
       },
       new ProductType
       {
           Id = 154,
           Name = "Cover Ups",
           Slug = "cover-ups",
           WeightId = null,
           ApiId = 8452
       },
       new ProductType
       {
           Id = 155,
           Name = "Bodies",
           Slug = "bodies",
           WeightId = null,
           ApiId = 8410
       },
       new ProductType
       {
           Id = 156,
           Name = "Wellies",
           Slug = "wellies",
           WeightId = null,
           ApiId = 8589
       },
       new ProductType
       {
           Id = 157,
           Name = "Ponchos",
           Slug = "ponchos",
           WeightId = null,
           ApiId = 8264
       },
       new ProductType
       {
           Id = 158,
           Name = "Hair Sprays",
           Slug = "hair-sprays",
           WeightId = null,
           ApiId = 8491
       },
       new ProductType
       {
           Id = 159,
           Name = "Hair Dryers",
           Slug = "hair-dryers",
           WeightId = null,
           ApiId = 8519
       },
       new ProductType
       {
           Id = 160,
           Name = "Hair Straighteners",
           Slug = "hair-straighteners",
           WeightId = null,
           ApiId = 8504
       },
       new ProductType
       {
           Id = 161,
           Name = "Shapewear",
           Slug = "shapewear",
           WeightId = null,
           ApiId = 8558
       },
       new ProductType
       {
           Id = 162,
           Name = "Tanning Mitts",
           Slug = "tanning-mitts",
           WeightId = null,
           ApiId = 9762
       },
       new ProductType
       {
           Id = 163,
           Name = "Makeup Cloths",
           Slug = "makeup-cloths",
           WeightId = null,
           ApiId = 10072
       },
       new ProductType
       {
           Id = 164,
           Name = "Spot Treatments",
           Slug = "spot-treatments",
           WeightId = null,
           ApiId = 15993
       },
       new ProductType
       {
           Id = 165,
           Name = "Unitards",
           Slug = "unitards",
           WeightId = 2,
           ApiId = 8567
       },
       new ProductType
       {
           Id = 166,
           Name = "Tanning Sets",
           Slug = "tanning-sets",
           WeightId = null,
           ApiId = 8499
       },
       new ProductType
       {
           Id = 167,
           Name = "Eye Serums",
           Slug = "eye-serums",
           WeightId = null,
           ApiId = 9743
       },
       new ProductType
       {
           Id = 168,
           Name = "Foundations",
           Slug = "foundations",
           WeightId = null,
           ApiId = 8549
       },
       new ProductType
       {
           Id = 169,
           Name = "Hair Pomades",
           Slug = "hair-pomades",
           WeightId = null,
           ApiId = 9786
       },
       new ProductType
       {
           Id = 170,
           Name = "Eyeliners",
           Slug = "eyeliners",
           WeightId = null,
           ApiId = 8528
       },
       new ProductType
       {
           Id = 171,
           Name = "Eyebrow Kits",
           Slug = "eyebrow-kits",
           WeightId = null,
           ApiId = 8437
       },
       new ProductType
       {
           Id = 172,
           Name = "Slips",
           Slug = "slips",
           WeightId = 2,
           ApiId = 8563
       },
       new ProductType
       {
           Id = 173,
           Name = "Compression Shorts",
           Slug = "compression-shorts",
           WeightId = null,
           ApiId = 9308
       },
       new ProductType
       {
           Id = 174,
           Name = "Leave-in Treatments",
           Slug = "leave-in-treatments",
           WeightId = null,
           ApiId = 15983
       },
       new ProductType
       {
           Id = 175,
           Name = "Hair Serums",
           Slug = "hair-serums",
           WeightId = null,
           ApiId = 8542
       },
       new ProductType
       {
           Id = 176,
           Name = "Hair Oils",
           Slug = "hair-oils",
           WeightId = null,
           ApiId = 8503
       },
       new ProductType
       {
           Id = 177,
           Name = "Lip Liners",
           Slug = "lip-liners",
           WeightId = null,
           ApiId = 9390
       },
       new ProductType
       {
           Id = 178,
           Name = "Concealers",
           Slug = "concealers",
           WeightId = null,
           ApiId = 8445
       },
       new ProductType
       {
           Id = 179,
           Name = "Eyebrow Gels",
           Slug = "eyebrow-gels",
           WeightId = null,
           ApiId = 8434
       },
       new ProductType
       {
           Id = 180,
           Name = "Mascaras",
           Slug = "mascaras",
           WeightId = null,
           ApiId = 8522
       },
       new ProductType
       {
           Id = 181,
           Name = "Tights",
           Slug = "tights",
           WeightId = null,
           ApiId = 8374
       },
       new ProductType
       {
           Id = 182,
           Name = "Setting Sprays",
           Slug = "setting-sprays",
           WeightId = null,
           ApiId = 9231
       },
       new ProductType
       {
           Id = 183,
           Name = "Facial Cleansers",
           Slug = "facial-cleansers",
           WeightId = null,
           ApiId = 8512
       },
       new ProductType
       {
           Id = 184,
           Name = "Underwear Sets",
           Slug = "underwear-sets",
           WeightId = null,
           ApiId = 8568
       },
       new ProductType
       {
           Id = 185,
           Name = "Tie Bars",
           Slug = "tie-bars",
           WeightId = null,
           ApiId = 8255
       },
       new ProductType
       {
           Id = 186,
           Name = "Pocket Squares",
           Slug = "pocket-squares",
           WeightId = null,
           ApiId = 8259
       },
       new ProductType
       {
           Id = 187,
           Name = "Nail Clippers",
           Slug = "nail-clippers",
           WeightId = null,
           ApiId = 9732
       },
       new ProductType
       {
           Id = 188,
           Name = "Hair Removal Creams",
           Slug = "hair-removal-creams",
           WeightId = null,
           ApiId = 11138
       },
       new ProductType
       {
           Id = 189,
           Name = "Hand Creams",
           Slug = "hand-creams",
           WeightId = null,
           ApiId = 8551
       },
       new ProductType
       {
           Id = 190,
           Name = "Swim Trunks",
           Slug = "swim-trunks",
           WeightId = null,
           ApiId = 8575
       },
       new ProductType
       {
           Id = 191,
           Name = "Sunglasses Accessories",
           Slug = "sunglasses-accessories",
           WeightId = null,
           ApiId = 9292
       },
       new ProductType
       {
           Id = 192,
           Name = "Diffusers",
           Slug = "diffusers",
           WeightId = null,
           ApiId = 10574
       },
       new ProductType
       {
           Id = 193,
           Name = "Toners",
           Slug = "toners",
           WeightId = null,
           ApiId = 8521
       },
       new ProductType
       {
           Id = 194,
           Name = "Curling Wands",
           Slug = "curling-wands",
           WeightId = null,
           ApiId = 9232
       },
       new ProductType
       {
           Id = 195,
           Name = "Dry Shampoos",
           Slug = "dry-shampoos",
           WeightId = null,
           ApiId = 9825
       },
       new ProductType
       {
           Id = 196,
           Name = "Hand Lotions",
           Slug = "hand-lotions",
           WeightId = null,
           ApiId = 8515
       },
       new ProductType
       {
           Id = 197,
           Name = "Hair Clippers",
           Slug = "hair-clippers",
           WeightId = null,
           ApiId = 9764
       },
       new ProductType
       {
           Id = 198,
           Name = "Headscarves",
           Slug = "headscarves",
           WeightId = null,
           ApiId = 8377
       },
       new ProductType
       {
           Id = 199,
           Name = "Facial Oils",
           Slug = "facial-oils",
           WeightId = null,
           ApiId = 8540
       },
       new ProductType
       {
           Id = 200,
           Name = "Eye Primers",
           Slug = "eye-primers",
           WeightId = null,
           ApiId = 9776
       },
       new ProductType
       {
           Id = 201,
           Name = "Sponges",
           Slug = "sponges",
           WeightId = null,
           ApiId = 8511
       },
       new ProductType
       {
           Id = 202,
           Name = "Face + Body Sets",
           Slug = "face-+-body-sets",
           WeightId = null,
           ApiId = 10904
       },
       new ProductType
       {
           Id = 203,
           Name = "Jeggings",
           Slug = "jeggings",
           WeightId = null,
           ApiId = 8412
       },
       new ProductType
       {
           Id = 204,
           Name = "Ski Pants",
           Slug = "ski-pants",
           WeightId = null,
           ApiId = 9318
       },
       new ProductType
       {
           Id = 205,
           Name = "Anklets",
           Slug = "anklets",
           WeightId = null,
           ApiId = 8605
       },
       new ProductType
       {
           Id = 206,
           Name = "Watch Straps",
           Slug = "watch-straps",
           WeightId = null,
           ApiId = 9305
       },
       new ProductType
       {
           Id = 207,
           Name = "Dressing Gowns",
           Slug = "dressing-gowns",
           WeightId = null,
           ApiId = 8469
       },
       new ProductType
       {
           Id = 208,
           Name = "Gems",
           Slug = "gems",
           WeightId = null,
           ApiId = 9767
       },
       new ProductType
       {
           Id = 209,
           Name = "Beauty Sets",
           Slug = "beauty-sets",
           WeightId = null,
           ApiId = 8446
       },
       new ProductType
       {
           Id = 210,
           Name = "Sports Bras",
           Slug = "sports-bras",
           WeightId = null,
           ApiId = 8566
       },
       new ProductType
       {
           Id = 211,
           Name = "Sweatbands",
           Slug = "sweatbands",
           WeightId = null,
           ApiId = 9317
       },
       new ProductType
       {
           Id = 212,
           Name = "Pencil Sharpeners",
           Slug = "pencil-sharpeners",
           WeightId = null,
           ApiId = 8685
       },
       new ProductType
       {
           Id = 213,
           Name = "Compression Tops",
           Slug = "compression-tops",
           WeightId = null,
           ApiId = 9306
       },
       new ProductType
       {
           Id = 214,
           Name = "Robes",
           Slug = "robes",
           WeightId = null,
           ApiId = 8467
       },
       new ProductType
       {
           Id = 215,
           Name = "Bikinis",
           Slug = "bikinis",
           WeightId = null,
           ApiId = 9233
       },
       new ProductType
       {
           Id = 216,
           Name = "False Nails",
           Slug = "false-nails",
           WeightId = null,
           ApiId = 8696
       },
       new ProductType
       {
           Id = 217,
           Name = "False Eyelashes",
           Slug = "false-eyelashes",
           WeightId = null,
           ApiId = 8530
       },
       new ProductType
       {
           Id = 218,
           Name = "Eyebrow Stencils",
           Slug = "eyebrow-stencils",
           WeightId = null,
           ApiId = 8441
       },
       new ProductType
       {
           Id = 219,
           Name = "Powders",
           Slug = "powders",
           WeightId = null,
           ApiId = 8509
       },
       new ProductType
       {
           Id = 220,
           Name = "Contour Sticks",
           Slug = "contour-sticks",
           WeightId = null,
           ApiId = 9774
       },
       new ProductType
       {
           Id = 221,
           Name = "Contours",
           Slug = "contours",
           WeightId = null,
           ApiId = 9726
       },
       new ProductType
       {
           Id = 222,
           Name = "Eyebrow Tints",
           Slug = "eyebrow-tints",
           WeightId = null,
           ApiId = 8438
       },
       new ProductType
       {
           Id = 223,
           Name = "Body Glitters",
           Slug = "body-glitters",
           WeightId = null,
           ApiId = 8450
       },
       new ProductType
       {
           Id = 224,
           Name = "Boiler Suits",
           Slug = "boiler-suits",
           WeightId = null,
           ApiId = 8555
       },
       new ProductType
       {
           Id = 225,
           Name = "Razors & Blades",
           Slug = "razors-&-blades",
           WeightId = null,
           ApiId = 11136
       },
       new ProductType
       {
           Id = 226,
           Name = "Foot Lotions",
           Slug = "foot-lotions",
           WeightId = null,
           ApiId = 8518
       },
       new ProductType
       {
           Id = 227,
           Name = "Nail Art",
           Slug = "nail-art",
           WeightId = null,
           ApiId = 8544
       },
       new ProductType
       {
           Id = 228,
           Name = "Lip Treatments",
           Slug = "lip-treatments",
           WeightId = null,
           ApiId = 9779
       },
       new ProductType
       {
           Id = 229,
           Name = "Tweezers",
           Slug = "tweezers",
           WeightId = null,
           ApiId = 8547
       },
       new ProductType
       {
           Id = 230,
           Name = "Masks",
           Slug = "masks",
           WeightId = null,
           ApiId = 9746
       },
       new ProductType
       {
           Id = 231,
           Name = "Deodorant",
           Slug = "deodorant",
           WeightId = null,
           ApiId = 11383
       },
       new ProductType
       {
           Id = 232,
           Name = "Beard Brushes",
           Slug = "beard-brushes",
           WeightId = null,
           ApiId = 9330
       },
       new ProductType
       {
           Id = 233,
           Name = "Hair Colours",
           Slug = "hair-colours",
           WeightId = null,
           ApiId = 8490
       },
       new ProductType
       {
           Id = 234,
           Name = "Styling Products",
           Slug = "styling-products",
           WeightId = null,
           ApiId = 15991
       },
       new ProductType
       {
           Id = 235,
           Name = "Hair Creams",
           Slug = "hair-creams",
           WeightId = null,
           ApiId = 8532
       },
       new ProductType
       {
           Id = 236,
           Name = "Heat Protection Sprays",
           Slug = "heat-protection-sprays",
           WeightId = null,
           ApiId = 9793
       },
       new ProductType
       {
           Id = 237,
           Name = "Makeup Brush Cleansers",
           Slug = "makeup-brush-cleansers",
           WeightId = null,
           ApiId = 10070
       },
       new ProductType
       {
           Id = 238,
           Name = "Shaving Brushes",
           Slug = "shaving-brushes",
           WeightId = null,
           ApiId = 8857
       },
       new ProductType
       {
           Id = 239,
           Name = "Laptop Cases",
           Slug = "laptop-cases",
           WeightId = null,
           ApiId = 8239
       },
       new ProductType
       {
           Id = 240,
           Name = "Makeup Brush Sets",
           Slug = "makeup-brush-sets",
           WeightId = null,
           ApiId = 10061
       },
       new ProductType
       {
           Id = 241,
           Name = "Trimmers",
           Slug = "trimmers",
           WeightId = null,
           ApiId = 8860
       },
       new ProductType
       {
           Id = 242,
           Name = "Beard Washes",
           Slug = "beard-washes",
           WeightId = null,
           ApiId = 9326
       },
       new ProductType
       {
           Id = 243,
           Name = "Fascinators",
           Slug = "fascinators",
           WeightId = null,
           ApiId = 8368
       },
       new ProductType
       {
           Id = 244,
           Name = "Hand Washes",
           Slug = "hand-washes",
           WeightId = null,
           ApiId = 9781
       },
       new ProductType
       {
           Id = 245,
           Name = "Cleansing Brushes",
           Slug = "cleansing-brushes",
           WeightId = null,
           ApiId = 9780
       },
       new ProductType
       {
           Id = 246,
           Name = "Eyebrow Brushes",
           Slug = "eyebrow-brushes",
           WeightId = null,
           ApiId = 9728
       },
       new ProductType
       {
           Id = 247,
           Name = "Skincare Tools & Accessories",
           Slug = "skincare-tools-&-accessories",
           WeightId = null,
           ApiId = 16007
       },
       new ProductType
       {
           Id = 248,
           Name = "Room Fragrances",
           Slug = "room-fragrances",
           WeightId = null,
           ApiId = 11255
       },
       new ProductType
       {
           Id = 249,
           Name = "Rollers",
           Slug = "rollers",
           WeightId = null,
           ApiId = 9236
       },
       new ProductType
       {
           Id = 250,
           Name = "Dental Care Product",
           Slug = "dental-care-product",
           WeightId = null,
           ApiId = 9731
       },
       new ProductType
       {
           Id = 251,
           Name = "Toothbrush Holder",
           Slug = "toothbrush-holder",
           WeightId = null,
           ApiId = 10566
       },
       new ProductType
       {
           Id = 252,
           Name = "Compression Tights",
           Slug = "compression-tights",
           WeightId = null,
           ApiId = 9312
       },
       new ProductType
       {
           Id = 253,
           Name = "Running Tights",
           Slug = "running-tights",
           WeightId = null,
           ApiId = 9298
       },
       new ProductType
       {
           Id = 254,
           Name = "Ski Jackets",
           Slug = "ski-jackets",
           WeightId = null,
           ApiId = 9310
       },
       new ProductType
       {
           Id = 255,
           Name = "Gift Boxes",
           Slug = "gift-boxes",
           WeightId = null,
           ApiId = 8661
       },
       new ProductType
       {
           Id = 256,
           Name = "Eye Masks",
           Slug = "eye-masks",
           WeightId = null,
           ApiId = 9755
       },
       new ProductType
       {
           Id = 257,
           Name = "Creams",
           Slug = "creams",
           WeightId = null,
           ApiId = 8456
       },
       new ProductType
       {
           Id = 258,
           Name = "Sheet Masks",
           Slug = "sheet-masks",
           WeightId = null,
           ApiId = 15992
       },
       new ProductType
       {
           Id = 259,
           Name = "Shavers",
           Slug = "shavers",
           WeightId = null,
           ApiId = 9742
       },
       new ProductType
       {
           Id = 260,
           Name = "Beauty Storage",
           Slug = "beauty-storage",
           WeightId = null,
           ApiId = 9785
       },
       new ProductType
       {
           Id = 261,
           Name = "Lingerie Bodies",
           Slug = "lingerie-bodies",
           WeightId = null,
           ApiId = 9747
       },
       new ProductType
       {
           Id = 262,
           Name = "Facial Washes",
           Slug = "facial-washes",
           WeightId = null,
           ApiId = 8501
       },
       new ProductType
       {
           Id = 263,
           Name = "Hair Waxes",
           Slug = "hair-waxes",
           WeightId = null,
           ApiId = 9300
       },
       new ProductType
       {
           Id = 264,
           Name = "Skin Serums",
           Slug = "skin-serums",
           WeightId = null,
           ApiId = 9744
       },
       new ProductType
       {
           Id = 265,
           Name = "Eye Treatments",
           Slug = "eye-treatments",
           WeightId = null,
           ApiId = 8463
       },
       new ProductType
       {
           Id = 266,
           Name = "Suspenders",
           Slug = "suspenders",
           WeightId = null,
           ApiId = 8736
       },
       new ProductType
       {
           Id = 267,
           Name = "Cards",
           Slug = "cards",
           WeightId = null,
           ApiId = 8678
       },
       new ProductType
       {
           Id = 268,
           Name = "Laptop Bags",
           Slug = "laptop-bags",
           WeightId = null,
           ApiId = 9396
       },
       new ProductType
       {
           Id = 269,
           Name = "Body Tapes",
           Slug = "body-tapes",
           WeightId = null,
           ApiId = 9345
       },
       new ProductType
       {
           Id = 270,
           Name = "Sleep Aids",
           Slug = "sleep-aids",
           WeightId = null,
           ApiId = 9333
       },
       new ProductType
       {
           Id = 271,
           Name = "Ear Cuffs",
           Slug = "ear-cuffs",
           WeightId = null,
           ApiId = 8581
       },
       new ProductType
       {
           Id = 272,
           Name = "Swim Briefs",
           Slug = "swim-briefs",
           WeightId = null,
           ApiId = 8557
       },
       new ProductType
       {
           Id = 273,
           Name = "Crystals",
           Slug = "crystals",
           WeightId = null,
           ApiId = 11256
       },
       new ProductType
       {
           Id = 274,
           Name = "Arm Cuffs",
           Slug = "arm-cuffs",
           WeightId = null,
           ApiId = 8261
       },
       new ProductType
       {
           Id = 275,
           Name = "Suspender Belts",
           Slug = "suspender-belts",
           WeightId = null,
           ApiId = 8737
       },
       new ProductType
       {
           Id = 276,
           Name = "Eye Pencils",
           Slug = "eye-pencils",
           WeightId = null,
           ApiId = 8459
       },
       new ProductType
       {
           Id = 277,
           Name = "Colour Correctors",
           Slug = "colour-correctors",
           WeightId = null,
           ApiId = 9792
       },
       new ProductType
       {
           Id = 278,
           Name = "Shell Tops",
           Slug = "shell-tops",
           WeightId = null,
           ApiId = 9132
       }
 );



    }
}
