

using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Tanjameh.Core.Entities;

namespace Tanjameh.Infrastructure.Data.Configs;


internal class CatalogBrandConfig : IEntityTypeConfiguration<CatalogBrand>
{
    public void Configure(EntityTypeBuilder<CatalogBrand> builder)
    {
        builder.HasMany(x => x.CatalogBrandApis)
            .WithOne(x => x.CatalogBrand)
            .HasForeignKey(x => x.CatalogBrandId);

        builder.HasData(

        new CatalogBrand
        {
            Id = 1,
            ApiId = 14644,
            Name = "Hollister",
            Description = "Inspired by beaches, blue skies and sunshine, Southern California label <strong>Hollister</strong> champions an endless summer. Never taking itself too seriously, its laid-back style is infused ",
            Slug = "hollister",
        },
        new CatalogBrand
        {
            Id = 2,
            ApiId = 53,
            Name = "ASOS DESIGN",
            Description = "This is <strong>ASOS DESIGN</strong> – your go-to for all the latest trends, no matter who you are, where you’re from and what you’re up to. Exclusive to ASOS, our universal brand is her",
            Slug = "asos-design",
        },
        new CatalogBrand
        {
            Id = 3,
            ApiId = 3682,
            Name = "Carhartt WIP",
            Description = "The youngest child of the Carhartt family, <strong>Carhartt WIP</strong> launched in London in 1989 with fresh ideas. Paying homage to its workwear roots, the brand serves utility designs with a s",
            Slug = "carhartt-wip",
        },
        new CatalogBrand
        {
            Id = 4,
            ApiId = 2986,
            Name = "Nike",
            Description = "Key players in everything activewear-related, it doesn’t get more iconic than <strong>Nike</strong>. Sporting some of the most wanted trainers in the game, browse Air Max 90s and Air Force 1s, as ",
            Slug = "nike",
        },
        new CatalogBrand
        {
            Id = 5,
            ApiId = 12983,
            Name = "River Island",
            Description = "High-street favourite <strong>River Island</strong> has been a go-to for decades. Known for adding signature detailing to its designs, expect to see classic looks with an RI twist from our ... ",
            Slug = "river-island",
        },
        new CatalogBrand
        {
            Id = 6,
            ApiId = 14920,
            Name = "Sixth June",
            Description = "<strong>Sixth June</strong> launched in Paris in 2008, breathing fresh air into street style. With its innovative and reactive approach, its longline tees, bomber jackets and sweats have helped",
            Slug = "sixth-june",
        },
        new CatalogBrand
        {
            Id = 7,
            ApiId = 16522,
            Name = "Gramicci",
            Description = "",
            Slug = "gramicci",
        },
        new CatalogBrand
        {
            Id = 8,
            ApiId = 12461,
            Name = "Jack & Jones",
            Description = "Founded in the 90s as a jeanswear brand, Danish label <strong>Jack & Jones</strong> has since gone on to expand its sartorial offering to include everything from jumpers, jackets and T-shirts to",
            Slug = "jack-&-jones",
        },
        new CatalogBrand
        {
            Id = 9,
            ApiId = 401,
            Name = "Levi's",
            Description = "Since creating the first ever pair of blue jeans back in 1873, American label <strong>Levi's</strong> has gone on to become one of the world’s most iconic denim brands – but you already knew that",
            Slug = "levi's",
        },
        new CatalogBrand
        {
            Id = 10,
            ApiId = 14370,
            Name = "Abercrombie & Fitch",
            Description = "The modern <strong>Abercrombie & Fitch</strong> is the next generation of effortless all-American style. The essence of laidback sophistication with an element of simplicity, A&F sets th",
            Slug = "abercrombie-&-fitch",
        },
        new CatalogBrand
        {
            Id = 11,
            ApiId = 3253,
            Name = "Dickies",
            Description = "With over 90 years of manufacturing experience, <strong>Dickies</strong> traces its reputation for durability and performance back to its workwear roots. Rounding up a selection of everyday stap",
            Slug = "dickies",
        },
        new CatalogBrand
        {
            Id = 12,
            ApiId = 3312,
            Name = "The North Face",
            Description = "Born from two hikers’ love for adventure, <strong>The North Face</strong> has become one of the best-known brands for outdoor clothing and equipment. Look to our ... ",
            Slug = "the-north-face",
        },
        new CatalogBrand
        {
            Id = 13,
            ApiId = 18,
            Name = "adidas Originals",
            Description = "<strong>adidas Originals</strong> needs no introduction. The brand’s famous 3-Stripes can be seen on the track, field and in the latest streetwear trends. Scroll the ... ",
            Slug = "adidas-originals",
        },
        new CatalogBrand
        {
            Id = 14,
            ApiId = 12769,
            Name = "Reclaimed Vintage",
            Description = "If your aesthetic is part on-trend, part throwback vibes, then you’ll love <strong>Reclaimed Vintage</strong>. With two distinct collections, ... ",
            Slug = "reclaimed-vintage",
        },
        new CatalogBrand
        {
            Id = 15,
            ApiId = 14441,
            Name = "ONLY & SONS",
            Description = "Bringing you classic menswear with a twist, <strong>ONLY & SONS</strong> is all about elevating your fav’ everyday pieces. Serve some serious laidback looks with fresh white T-shirts and graph",
            Slug = "only-&-sons",
        },
        new CatalogBrand
        {
            Id = 16,
            ApiId = 14403,
            Name = "Element",
            Description = "",
            Slug = "element",
        },
        new CatalogBrand
        {
            Id = 17,
            ApiId = 2943,
            Name = "Fred Perry",
            Description = "Founded by triple Wimbledon champion <strong>Fred Perry</strong> in 1952, the eponymous clothing brand blends classic British street style with an athletic twist. Our ... ",
            Slug = "fred-perry",
        },
        new CatalogBrand
        {
            Id = 18,
            ApiId = 75,
            Name = "Ben Sherman",
            Description = "Adopted by the Mod movement of the 1960s, <strong>Ben Sherman</strong> channel their Mod roots to a contemporary range of menswear, including everything from their iconic check shirts to polos ",
            Slug = "ben-sherman",
        },
        new CatalogBrand
        {
            Id = 19,
            ApiId = 14159,
            Name = "Selected Homme",
            Description = "A staple wardrobe doesn’t have to be basic, so upgrade your everyday edit with <strong>Selected Homme</strong>. Embracing a minimalist aesthetic, the brand puts a Scandi twist on contemporary s",
            Slug = "selected-homme",
        },
        new CatalogBrand
        {
            Id = 20,
            ApiId = 16545,
            Name = "Nike Golf",
            Description = "Innovative sportswear? Check. Streetwear? Check. If it wasn’t *super* obvious yet, we’re talking about Nike. With the best-selling trainers in the game, scroll our Nike at ASOS edit to score everything from Air Force 1s and Air Max 90s to Blazers (now",
            Slug = "nike-golf",
        },
        new CatalogBrand
        {
            Id = 21,
            ApiId = 15176,
            Name = "Nike Running",
            Description = "Key players in everything activewear-related, it doesn’t get more iconic than Nike. Sporting some of the most wanted trainers in the game, browse Air Max 90s and Air Force 1s, as well as Cortez and Joyride styles. Get off-duty looks down with tracksuits",
            Slug = "nike-running",
        },
        new CatalogBrand
        {
            Id = 22,
            ApiId = 16123,
            Name = "Hi-Tec",
            Description = "Founded in 1974 in Shoeburyness (yes, it&rsquo;s a real place), England, innovative brand <strong>Hi-Tec</strong> set out to build a comfortable squash shoe with a lightweight feel. From there, Hi-T",
            Slug = "hi-tec",
        },
        new CatalogBrand
        {
            Id = 23,
            ApiId = 3497,
            Name = "Farah",
            Description = "From their birth in the 1920s, <strong>Farah</strong> has been adopted by subcultures across the board; from Mods to Skins and Rockabillies. Renowned for their classic canvas slacks and sharp",
            Slug = "farah",
        },
        new CatalogBrand
        {
            Id = 24,
            ApiId = 15127,
            Name = "Napapijri",
            Description = "First thought up in the shadow of Europe’s highest peak, the Monte Bianco, outdoors-loving brand <strong>Napapijri</strong> has been combining innovative materials with close attention to st",
            Slug = "napapijri",
        },
        new CatalogBrand
        {
            Id = 25,
            ApiId = 12791,
            Name = "AllSaints",
            Description = "East London born and bred, <strong>AllSaints</strong> turned heads in the mid-90s with its investment leather jackets. Today, a collection of worn-in denim, vintage-inspired shirts and classic j",
            Slug = "allsaints",
        },
        new CatalogBrand
        {
            Id = 26,
            ApiId = 3029,
            Name = "Tommy Hilfiger",
            Description = "Whether it’s an embroidered logo, a bold graphic print or its iconic red, white and blue colour-blocking, there’s no mistaking <strong>Tommy Hilfiger</strong>. Flying the flag for all th",
            Slug = "tommy-hilfiger",
        },
        new CatalogBrand
        {
            Id = 27,
            ApiId = 14758,
            Name = "ADPT",
            Description = "For a low-effort, high-reward wardrobe, check out clothing brand <strong>ADPT</strong>. We’re talking new levels of casj excellence with washed-out T-shirts, brushed shirts and teddy sweatshirts. T",
            Slug = "adpt",
        },
        new CatalogBrand
        {
            Id = 28,
            ApiId = 15370,
            Name = "Bershka",
            Description = "Taking inspiration from the latest music, technology and social media trends, <strong>Bershka</strong> serves up fresh new fashion and wardrobe staples you’ll want to rotate on the regular. We",
            Slug = "bershka",
        },
        new CatalogBrand
        {
            Id = 29,
            ApiId = 14512,
            Name = "Le Breve",
            Description = "",
            Slug = "le-breve",
        },
        new CatalogBrand
        {
            Id = 30,
            ApiId = 12136,
            Name = "Armani Exchange",
            Description = "One of the most iconic names in fashion history, Giorgio Armani launched <strong>Armani Exchange</strong> in 1991 as a youthful, sportier sub-label of his eponymous brand. Inspired by the l",
            Slug = "armani-exchange",
        },
        new CatalogBrand
        {
            Id = 31,
            ApiId = 16236,
            Name = "Topman",
            Description = "Welcome to the new chapter of <strong>Topman</strong>. Championing the very best of its heritage, this next phase celebrates cherished pieces, while embracing the new, and retaining that unique Lon",
            Slug = "topman",
        },
        new CatalogBrand
        {
            Id = 32,
            ApiId = 691,
            Name = "Superdry",
            Description = "<strong>Superdry</strong> merges Japanese-inspired graphics with vintage Americana styling. The result? Expect quality fabrics, hand-drawn prints and tailored fits to slot into your everyday line-",
            Slug = "superdry",
        },
        new CatalogBrand
        {
            Id = 33,
            ApiId = 14126,
            Name = "Pull&Bear",
            Description = "Champions of the casual capsule wardrobe, make <strong>Pull&Bear</strong> your new must-scroll brand. With a focus on laid-back Californian style, the brand mixes grunge, sports and streetwear re",
            Slug = "pull&bear",
        },
        new CatalogBrand
        {
            Id = 34,
            ApiId = 15878,
            Name = "Collusion",
            Description = "A new brand for the coming-of-age generation that refuses to compromise on principle or style, <strong>Collusion</strong> believes clothes that celebrate self-expression and inclusivity should",
            Slug = "collusion",
        },
        new CatalogBrand
        {
            Id = 35,
            ApiId = 12077,
            Name = "BOSS by Hugo Boss",
            Description = "BOSS offers an authentic and understated wardrobe for the modern man. Crafted from super-soft fabrics, BOSS bodywear, loungewear and accessory collections offer ultimate comfort and enduring style.",
            Slug = "boss-by-hugo-boss",
        },
        new CatalogBrand
        {
            Id = 36,
            ApiId = 14712,
            Name = "WALK LONDON",
            Description = "Combining fine Italian style and craftsmanship with modern British design, footwear brand <strong>WALK LONDON</strong> takes its inspiration from its local surroundings and London’s culture.",
            Slug = "walk-london",
        },
        new CatalogBrand
        {
            Id = 37,
            ApiId = 14550,
            Name = "Teva",
            Description = "Founded in 1984 with the motto, “Strap in and go,” footwear brand <strong>Teva</strong> offers an iconic selection of hard-wearing designs. Inspired by an active lifestyle, their collection of hi",
            Slug = "teva",
        },
        new CatalogBrand
        {
            Id = 38,
            ApiId = 14287,
            Name = "Weekday",
            Description = "With Scandi roots and a street-style vibe, <strong>Weekday</strong> offers up that coveted laid-back, minimal look. Founded in 2002, the Swedish brand draws inspiration from art, pop and youth c",
            Slug = "weekday",
        },
        new CatalogBrand
        {
            Id = 39,
            ApiId = 3062,
            Name = "Wrangler",
            Description = "Originally a cowboy jean, <strong>Wrangler</strong> grew to be one of the defining American denim brands. Today, ... ",
            Slug = "wrangler",
        },
        new CatalogBrand
        {
            Id = 40,
            ApiId = 79,
            Name = "Birkenstock",
            Description = "It’s not all about new – sometimes you can’t beat a classic, and <strong>Birkenstock</strong> is exactly that. Starting out way back in 1774, the footwear brand soon became known for its",
            Slug = "birkenstock",
        },
        new CatalogBrand
        {
            Id = 41,
            ApiId = 396,
            Name = "Lee",
            Description = "Founded in 1889 by Henry David Lee, <strong>Lee</strong> are a denim brand that utilise their rich history to make jeans and workwear inspired clothing with an authentic edge. ... ",
            Slug = "lee",
        },
        new CatalogBrand
        {
            Id = 42,
            ApiId = 14468,
            Name = "Nicce",
            Description = "The designers behind <strong>Nicce</strong> look to the streets of London for inspiration, and with its diverse culture and rich music scene, it’s not hard to see why. Expect T-shirts and h",
            Slug = "nicce",
        },
        new CatalogBrand
        {
            Id = 43,
            ApiId = 20903,
            Name = "Sol de Janeiro",
            Description = "",
            Slug = "sol-de-janeiro",
        },
        new CatalogBrand
        {
            Id = 44,
            ApiId = 15829,
            Name = "Isle of Paradise",
            Description = "",
            Slug = "isle-of-paradise",
        },
        new CatalogBrand
        {
            Id = 45,
            ApiId = 16511,
            Name = "Rituals",
            Description = "",
            Slug = "rituals",
        },
        new CatalogBrand
        {
            Id = 46,
            ApiId = 14535,
            Name = "Ann Summers",
            Description = "Make your top drawer your favourite drawer with our <strong>Ann Summers</strong> at ASOS edit. All about embracing self-confidence, the brand knows how to celebrate self-love. Treat yourself",
            Slug = "ann-summers",
        },
        new CatalogBrand
        {
            Id = 47,
            ApiId = 22555,
            Name = "Weleda",
            Description = "",
            Slug = "weleda",
        },
        new CatalogBrand
        {
            Id = 48,
            ApiId = 22705,
            Name = "Erborian",
            Description = "",
            Slug = "erborian",
        },
        new CatalogBrand
        {
            Id = 49,
            ApiId = 17600,
            Name = "Tanologist",
            Description = "Get ready for streak-free bronzed skin with fake-tan favourite <strong>Tanologist</strong>, created by makeup artist and beauty influencer Lottie Tomlinson. Whether you’re looking",
            Slug = "tanologist",
        },
        new CatalogBrand
        {
            Id = 50,
            ApiId = 3234,
            Name = "Bolongaro Trevor",
            Description = "Hoxton-founded <strong>Bolongaro Trevor</strong> takes its sartorial cues from British subcultures like the mods, skins and punks. Designed in East London, the brand’s retro leather jack",
            Slug = "bolongaro-trevor",
        },
        new CatalogBrand
        {
            Id = 51,
            ApiId = 17700,
            Name = "HUGO BOSS Fragrances",
            Description = "If you need an excuse for a wardrobe update,&nbsp;<strong>HUGO BOSS Fragrances</strong>&nbsp;is it. Best known for its tailoring finesse, the luxury German fashion brand has your back when it co",
            Slug = "hugo-boss-fragrances",
        },
        new CatalogBrand
        {
            Id = 52,
            ApiId = 19157,
            Name = "MAEGAN",
            Description = "",
            Slug = "maegan",
        },
        new CatalogBrand
        {
            Id = 53,
            ApiId = 14096,
            Name = "Obey",
            Description = "Founded in 2001, US streetwear label <strong>Obey</strong> is an extension of graffiti artist Shepard Fairey’s street and fine art campaign. Moving his populist views from the canvas to clothing, F",
            Slug = "obey",
        },
        new CatalogBrand
        {
            Id = 54,
            ApiId = 18150,
            Name = "Nuxe",
            Description = "",
            Slug = "nuxe",
        },
        new CatalogBrand
        {
            Id = 55,
            ApiId = 12577,
            Name = "Caudalie",
            Description = "Created in Bordeaux in 1995, <strong>Caudalie</strong> recycles the grape seed oil usually thrown away during harvesting to produce an effective and luxurious beauty range – pretty ",
            Slug = "caudalie",
        },
        new CatalogBrand
        {
            Id = 56,
            ApiId = 20703,
            Name = "Billie Eilish",
            Description = "",
            Slug = "billie-eilish",
        },
        new CatalogBrand
        {
            Id = 57,
            ApiId = 224,
            Name = "French Connection",
            Description = "Founded in 1972 by Stephen Marks and driven by innovation, <strong>French Connection</strong> is known for its wearable, intelligent collections and off-beat advertising campaigns. French",
            Slug = "french-connection",
        },
        new CatalogBrand
        {
            Id = 58,
            ApiId = 16651,
            Name = "Threadbare Fitness",
            Description = "",
            Slug = "threadbare-fitness",
        },
        new CatalogBrand
        {
            Id = 59,
            ApiId = 13289,
            Name = "Sekonda",
            Description = "British watch brand <strong>Sekonda</strong> was launched in 1966 and now offers an expansive collection of innovative designs. ... ",
            Slug = "sekonda",
        },
        new CatalogBrand
        {
            Id = 60,
            ApiId = 12962,
            Name = "Komono",
            Description = "In 2009 Anton Janssens and Raf Maes launched <strong>Komono</strong> which means 'small things' in Japanese. However, ... ",
            Slug = "komono",
        },
        new CatalogBrand
        {
            Id = 61,
            ApiId = 18054,
            Name = "Valentino Bags",
            Description = "",
            Slug = "valentino-bags",
        },
        new CatalogBrand
        {
            Id = 62,
            ApiId = 15883,
            Name = "NA-KD",
            Description = "If classic street style with a touch of tailoring is your thing, then it&rsquo;s time to get excited because that&rsquo;s exactly what Swedish brand <strong>NA-KD's</strong> all about. Pad out your",
            Slug = "na-kd",
        },
        new CatalogBrand
        {
            Id = 63,
            ApiId = 15586,
            Name = "Simply Be",
            Description = "Celebrating women of all shapes and sizes, <strong>Simply Be</strong> makes a serious case for plus-size style. Inspired by international trends, the brand’s latest offering includes everyth",
            Slug = "simply-be",
        },
        new CatalogBrand
        {
            Id = 64,
            ApiId = 13817,
            Name = "New Look",
            Description = "Since setting up shop in the 60s, <strong>New Look</strong> has become a high-street classic known for creating universally loved, wardrobe-ready collections. Shop the ... ",
            Slug = "new-look",
        },
        new CatalogBrand
        {
            Id = 65,
            ApiId = 14538,
            Name = "Threadbare",
            Description = "",
            Slug = "threadbare",
        },
        new CatalogBrand
        {
            Id = 66,
            ApiId = 13116,
            Name = "sister jane",
            Description = "Serving up femininity with a vintage twist, <strong>sister jane</strong> perfects your 9-9 style with its pretty blouses and tailored separates. Embroidered Peter-Pan collars, delicate pleat",
            Slug = "sister-jane",
        },
        new CatalogBrand
        {
            Id = 67,
            ApiId = 15812,
            Name = "Vero Moda Curve",
            Description = "Whether you’re after a wardrobe refresh or just a few staples, <strong>Vero Moda Curve</strong> serves big outfit energy. Scroll for your new favourite pair of jeans, available in a variety o",
            Slug = "vero-moda-curve",
        },
        new CatalogBrand
        {
            Id = 68,
            ApiId = 3663,
            Name = "Vila",
            Description = "Seeking inspiration from street and city style, Scandi favourite <strong>Vila</strong> combines quality fabrics and delicate cuts to create a collection of fashion-forward pieces. Signature floral p",
            Slug = "vila",
        },
        new CatalogBrand
        {
            Id = 69,
            ApiId = 15629,
            Name = "Stradivarius",
            Description = "Barcelona-born clothing brand <strong>Stradivarius</strong> moves to its own beat. With an eye for minimalism and trend-led detail, expect classic silhouettes and a neutral colour palette (",
            Slug = "stradivarius",
        },
        new CatalogBrand
        {
            Id = 70,
            ApiId = 15128,
            Name = "Miss Selfridge",
            Description = "<strong>Miss Selfridge</strong> takes you from day to date night with its off-duty looks and full-on glamour. Solve what-to-wear dilemmas with its dresses and accessories that combine inh",
            Slug = "miss-selfridge",
        },
        new CatalogBrand
        {
            Id = 71,
            ApiId = 14516,
            Name = "Waven",
            Description = "Inspired by minimalist design, contemporary denim brand <strong>Waven</strong> focuses on clean lines and relaxed silhouettes. Channeling two generations of denim manufacturing know-how into its p",
            Slug = "waven",
        },
        new CatalogBrand
        {
            Id = 72,
            ApiId = 3180,
            Name = "Dr Martens",
            Description = "Docs, Doc Martens, DMs – we’ve all got our own name for them, but one thing’s for sure: <strong>Dr Martens</strong> kicks against the norm. The British footwear brand’s shoes, boots and ",
            Slug = "dr-martens",
        },
        new CatalogBrand
        {
            Id = 73,
            ApiId = 3672,
            Name = "Timberland",
            Description = "With a rich New England heritage, <strong>Timberland</strong> signature work boots were quickly adopted by a new wave of youth culture. With a rugged feel and reputation for quality, ... ",
            Slug = "timberland",
        },
        new CatalogBrand
        {
            Id = 74,
            ApiId = 16346,
            Name = "adidas performance",
            Description = "<strong>adidas performance</strong> needs no introduction. The brand’s famous 3-Stripes can be seen on the track, field and in the latest streetwear trends. Scroll the ... ",
            Slug = "adidas-performance",
        },
        new CatalogBrand
        {
            Id = 75,
            ApiId = 12967,
            Name = "ALDO",
            Description = "Inspired by seasonal trends, Canadian footwear and accessory brand <strong>ALDO</strong> looks to the runways for inspiration when designing its collections. We’ve pulled together an edit of its ",
            Slug = "aldo",
        },
        new CatalogBrand
        {
            Id = 76,
            ApiId = 765,
            Name = "Vans",
            Description = "ABOUT VANS Land more than just tricks with skatewear label <strong>Vans</strong>. Rewriting the blueprint for board shoes everywhere since 1966, the brand’s remit has expanded to include everything ",
            Slug = "vans",
        },
        new CatalogBrand
        {
            Id = 77,
            ApiId = 14991,
            Name = "Bondi Sands",
            Description = "Labelled Australia’s favourite tan, <strong>Bondi Sands</strong> is quickly becoming a firm favourite among fake-tan fans. Formulated with skin-nourishing ingredients including Jojo",
            Slug = "bondi-sands",
        },
        new CatalogBrand
        {
            Id = 78,
            ApiId = 16246,
            Name = "The Fox Tan",
            Description = "Faking it not your thing? Enter Australian-made brand <strong>The Fox Tan</strong>. Enriched with an exclusive ingredient, its mists, sprays and sealers help encourage the producti",
            Slug = "the-fox-tan",
        },
        new CatalogBrand
        {
            Id = 79,
            ApiId = 20602,
            Name = "Aire",
            Description = "Say hello to shade-stopping style with our <strong>Aire</strong> at ASOS edit. Featuring a range of on-trend designs, Australian label ... ",
            Slug = "aire",
        },
        new CatalogBrand
        {
            Id = 80,
            ApiId = 597,
            Name = "Ralph Lauren",
            Description = "Naming his brand after a sport that embodied a world of classic style, Ralph Lauren created <strong>Ralph Lauren</strong> in 1967 with a line of men's ties. Fast forward and the label is ",
            Slug = "ralph-lauren",
        },
        new CatalogBrand
        {
            Id = 81,
            ApiId = 16305,
            Name = "Topshop",
            Description = "<strong>Topshop</strong> is entering a new era. Retaining its fashion authority and the very best of its heritage, while celebrating iconic styles such as the Jamie and Joni jean, and embracing ",
            Slug = "topshop",
        },
        new CatalogBrand
        {
            Id = 82,
            ApiId = 62200,
            Name = "Hello Sunday",
            Description = "",
            Slug = "hello-sunday",
        },
        new CatalogBrand
        {
            Id = 83,
            ApiId = 544,
            Name = "Paul Smith",
            Description = "Famed for his “classics with a twist” mantra, <strong>Paul Smith</strong> has been at the forefront of the menswear scene for over thirty years. This season sees the designer channelli",
            Slug = "paul-smith",
        },
        new CatalogBrand
        {
            Id = 84,
            ApiId = 15034,
            Name = "Yours",
            Description = "Make wardrobe dilemmas a thing of the past thanks to clothing brand <strong>Yours</strong>. With staple separates that work all day (and night) and comfy co-ords to chill in, the brand’s plus-si",
            Slug = "yours",
        },
        new CatalogBrand
        {
            Id = 85,
            ApiId = 105,
            Name = "Calvin Klein",
            Description = "Underwear authority and all-round fashion icon, <strong>Calvin Klein</strong> puts a designer stamp on clean, casual-cool staples. From shirts to waistbands, the brand’s famous CK logo serve",
            Slug = "calvin-klein",
        },
        new CatalogBrand
        {
            Id = 86,
            ApiId = 12727,
            Name = "Le Specs",
            Description = "Sun’s out, shades on. Australian sunglasses brand <strong>Le Specs</strong> has been serving strong eyewear looks since 1979. With frames to suit all moods, consider your ultimate summer add-",
            Slug = "le-specs",
        },
        new CatalogBrand
        {
            Id = 87,
            ApiId = 3128,
            Name = "Ray-Ban",
            Description = "First produced for the U.S. Air Force, <strong>Ray-Ban</strong> has been making iconic sunglasses since 1937. With a rich pop culture history, ... ",
            Slug = "ray-ban",
        },
        new CatalogBrand
        {
            Id = 88,
            ApiId = 15203,
            Name = "Under Armour",
            Description = "Empowering athletes through passion, design and the relentless pursuit of innovation, <strong>Under Armour</strong> creates sports clothing and footwear to help you deliver your best performa",
            Slug = "under-armour",
        },
        new CatalogBrand
        {
            Id = 89,
            ApiId = 767,
            Name = "Versace",
            Description = "With added Donatella, Italian fashion house Versace adds a line of luxury accessories to its signature feminine style and OTT glamour. Think cat-eye and oversized sunglasses, handbags and jewellery all stamped with the label’s iconic Medusa logo, animal",
            Slug = "versace",
        },
        new CatalogBrand
        {
            Id = 90,
            ApiId = 439,
            Name = "Magic",
            Description = "<strong>Magic</strong> creates a range of underwear solutions designed to enhance and maximise your figure underneath clothing. Bra strap converters, stick on push up pads and fashion t",
            Slug = "magic",
        },
        new CatalogBrand
        {
            Id = 91,
            ApiId = 13137,
            Name = "True Decadence",
            Description = "Combining timeless silhouettes with standout embellishments, <strong>True Decadence</strong> have been mastering occasionwear since 2016. The brand's eye-catching array of tiered maxi dre",
            Slug = "true-decadence",
        },
        new CatalogBrand
        {
            Id = 92,
            ApiId = 3594,
            Name = "Polo Ralph Lauren",
            Description = "Known for its collegiate-cool American style, heritage brand <strong>Polo Ralph Lauren</strong> is a big player in the menswear game. Sample some of its signature preppy designs with our ",
            Slug = "polo-ralph-lauren",
        },
        new CatalogBrand
        {
            Id = 93,
            ApiId = 499,
            Name = "New Balance",
            Description = "Founded over 100 years ago, <strong>New Balance</strong> (aka the dad-trainer OG) has been flexing its footwear credentials for as long as we can remember. Shop the ... ",
            Slug = "new-balance",
        },
        new CatalogBrand
        {
            Id = 94,
            ApiId = 12069,
            Name = "Gant",
            Description = "When it comes to shirts, <strong>Gant</strong> knows its stuff. Founded as a shirtmakers back in 1949, the brand went on to shape the iconic Ivy League style embraced by 50s Harvard, Yale and Princet",
            Slug = "gant",
        },
        new CatalogBrand
        {
            Id = 95,
            ApiId = 14116,
            Name = "ellesse",
            Description = "From Italian ski and tennis apparel to iconic 80s sports fashion, <strong>ellesse</strong> proves that sportswear isn’t just for getting physical. The brand nails that retro athleisure aesthetic",
            Slug = "ellesse",
        },
        new CatalogBrand
        {
            Id = 96,
            ApiId = 13872,
            Name = "PS Paul Smith",
            Description = "Designed in London, UK, <strong>PS Paul Smith</strong> bears all the hallmarks of Sir Paul Smith’s individual and quintessentially British style. Signature details feature across a rang",
            Slug = "ps-paul-smith",
        },
        new CatalogBrand
        {
            Id = 97,
            ApiId = 15622,
            Name = "Rip N Dip",
            Description = "Started in 2009 by a group of friends at a Florida skate camp, LA-based label <strong>Rip N Dip</strong> combines skate apparel with classic streetwear. Known for its eccentric designs, includin",
            Slug = "rip-n-dip",
        },
        new CatalogBrand
        {
            Id = 98,
            ApiId = 2988,
            Name = "Reebok",
            Description = "Since 1895, <strong>Reebok's</strong> ancestor company have been developing their line of running shoes and trainers. With the brand launched in its own right in 1958, ... ",
            Slug = "reebok",
        },
        new CatalogBrand
        {
            Id = 99,
            ApiId = 16674,
            Name = "Don't Think Twice",
            Description = "",
            Slug = "don't-think-twice",
        },
        new CatalogBrand
        {
            Id = 100,
            ApiId = 3060,
            Name = "Emporio Armani",
            Description = "A diffusion line from iconic fashion house Armani, <strong>Emporio Armani</strong> offers timeless style with their collections of wearable classics. ... ",
            Slug = "emporio-armani",
        },
        new CatalogBrand
        {
            Id = 101,
            ApiId = 16119,
            Name = "& Other Stories",
            Description = "With design ateliers in Paris, Stockholm and Los Angeles, <strong>& Other Stories</strong> collections are as varied and creative as the locations they take inspiration from. Find staple j",
            Slug = "&-other-stories",
        },
        new CatalogBrand
        {
            Id = 102,
            ApiId = 14483,
            Name = "True Violet",
            Description = "Prom dress stresses and wedding attire worries? Check out <strong>True Violet</strong> collection and get schooled on all-occasionwear. We’re talking hand-painted floral prints and embelli",
            Slug = "true-violet",
        },
        new CatalogBrand
        {
            Id = 103,
            ApiId = 16485,
            Name = "Jaded Rose Tall",
            Description = "<strong>Jaded Rose Tall</strong> launches their first collection exclusively on ASOS (we’re super happy about that btw!). Calling on the catwalk, ... ",
            Slug = "jaded-rose-tall",
        },
        new CatalogBrand
        {
            Id = 104,
            ApiId = 13511,
            Name = "ASOS Curve",
            Description = "This is <strong>ASOS Curve</strong> – your go-to for all the latest trends, no matter who you are, where you’re from and what you’re up to. Exclusive to ASOS, our universal brand is he",
            Slug = "asos-curve",
        },
        new CatalogBrand
        {
            Id = 105,
            ApiId = 12542,
            Name = "Accessorize",
            Description = "Founded in 1973, Monsoon brought hand-crafted and folk-inspired global fashion to London with their first stall on the Portobello Road. Developing an accessories line to sit alongside this collection saw the introduction of ... ",
            Slug = "accessorize",
        },
        new CatalogBrand
        {
            Id = 106,
            ApiId = 15719,
            Name = "ASOS EDITION",
            Description = "Turn up and stand out in occasionwear that’s as unique as you. With luxe attention to detail, <strong>ASOS EDITION</strong> is designed for the most memorable moments of your life. Think ",
            Slug = "asos-edition",
        },
        new CatalogBrand
        {
            Id = 107,
            ApiId = 14146,
            Name = "Skinnydip",
            Description = "Designing fashion accessories with an edge, the squad behind <strong>Skinnydip</strong> standout range knows gals just want to have fun. Influenced by the world around us, the brand creates ev",
            Slug = "skinnydip",
        },
        new CatalogBrand
        {
            Id = 108,
            ApiId = 14162,
            Name = "ASOS Tall",
            Description = "This is <strong>ASOS Tall</strong> – your go-to for all the latest trends, no matter who you are, where you’re from and what you’re up to. Exclusive to ASOS, our universal brand is her",
            Slug = "asos-tall",
        },
        new CatalogBrand
        {
            Id = 109,
            ApiId = 14450,
            Name = "Jeffrey Campbell",
            Description = "Family-owned label <strong>Jeffrey Campbell</strong> puts its stamp on vintage inspirations and catwalk trends with a standout footwear collection. Dressing up your walk from the street",
            Slug = "jeffrey-campbell",
        },
        new CatalogBrand
        {
            Id = 110,
            ApiId = 13661,
            Name = "Love Moschino",
            Description = "A diffusion line of Franco Moschino's iconic Italian design house, <strong>Love Moschino</strong> creates a playful and irreverent collection injected with a sense of youthful cool. Witty ",
            Slug = "love-moschino",
        },
        new CatalogBrand
        {
            Id = 111,
            ApiId = 13862,
            Name = "Vesper",
            Description = "Hot new label <strong>Vesper</strong> gives you a serious fashion fix with their collection of figure sculpting dresses. Cut from luxe, super stretch fabrics, each dress is designed to flatter an",
            Slug = "vesper",
        },
        new CatalogBrand
        {
            Id = 112,
            ApiId = 14012,
            Name = "Monki",
            Description = "If you’re all for personality and expression, then <strong>Monki</strong>  is the brand for you. Known for its street-meets-Scandi-chic designs, it grabs bold, bright colours and a whole lot of ",
            Slug = "monki",
        },
        new CatalogBrand
        {
            Id = 113,
            ApiId = 15068,
            Name = "River Island Plus",
            Description = "",
            Slug = "river-island-plus",
        },
        new CatalogBrand
        {
            Id = 114,
            ApiId = 15177,
            Name = "Nike Training",
            Description = "Innovative sportswear? Check. Streetwear? Check. If it wasn’t *super* obvious yet, we’re talking about Nike. With the best-selling trainers in the game, scroll our Nike at ASOS edit to score everything from Air Force 1s and Air Max 90s to Blazers (now",
            Slug = "nike-training",
        },
        new CatalogBrand
        {
            Id = 115,
            ApiId = 13850,
            Name = "ONLY",
            Description = "Looking for trending pieces that will get you noticed? Enter: <strong>ONLY</strong>. The brand delivers the freshest selection of printed mini dresses and blouses for every plan in your calendar. B",
            Slug = "only",
        },
        new CatalogBrand
        {
            Id = 116,
            ApiId = 14599,
            Name = "Pimkie",
            Description = "In 1971, French label <strong>Pimkie</strong> brought three textiles specialists together to create empowering collections that encourage women to express themselves, and the rest is fashion hist",
            Slug = "pimkie",
        },
        new CatalogBrand
        {
            Id = 117,
            ApiId = 14185,
            Name = "Jaded Rose",
            Description = "<strong>Jaded Rose</strong> launches their first collection exclusively on ASOS (we’re super happy about that btw!). Calling on the catwalk, ... ",
            Slug = "jaded-rose",
        },
        new CatalogBrand
        {
            Id = 118,
            ApiId = 15734,
            Name = "Wednesday's Girl",
            Description = "Give your wardrobe that extra something-something with the latest drop from <strong>Wednesday's Girl</strong>. Big on floral and ditsy prints, the brand helps bring your daytime thing to",
            Slug = "wednesday's-girl",
        },
        new CatalogBrand
        {
            Id = 119,
            ApiId = 12117,
            Name = "Mango",
            Description = "The designers behind Barcelona-born <strong>Mango</strong> know that pairing timeless style with minimalist design is a winning formula. We’ve handpicked our fave pieces from its dreamy collectio",
            Slug = "mango",
        },
        new CatalogBrand
        {
            Id = 120,
            ApiId = 16483,
            Name = "Jaded Rose Petite",
            Description = "<strong>Jaded Rose Petite</strong> launches their first collection exclusively on ASOS (we’re super happy about that btw!). Calling on the catwalk, ... ",
            Slug = "jaded-rose-petite",
        },
        new CatalogBrand
        {
            Id = 121,
            ApiId = 14023,
            Name = "Daisy Street",
            Description = "If you like your trends as fast as they come then <strong>Daisy Street</strong> is the label for you. Always up on their A-game, ... ",
            Slug = "daisy-street",
        },
        new CatalogBrand
        {
            Id = 122,
            ApiId = 96,
            Name = "Bronx",
            Description = "Be your own icon in a statement pair of shoes from the <strong>Bronx</strong> at ASOS range. Experimenting with out-there styles – think snakeskin prints, gleaming hardware and cut-out designs ",
            Slug = "bronx",
        },
        new CatalogBrand
        {
            Id = 123,
            ApiId = 13138,
            Name = "Glamorous",
            Description = "An eclectic mix of vintage influences and contemporary partywear are at the heart of Manchester based label <strong>Glamorous</strong>, where individual style is the key.  The carefully source",
            Slug = "glamorous",
        },
        new CatalogBrand
        {
            Id = 124,
            ApiId = 16633,
            Name = "Missyempire",
            Description = "Be your own influencer with fashion brand <strong>Missyempire</strong>. From the social feed straight to your wardrobe, the label taps into the latest trends with its range of clothes and ac",
            Slug = "missyempire",
        },
        new CatalogBrand
        {
            Id = 125,
            ApiId = 21166,
            Name = "Glamorous Wide Fit",
            Description = "An eclectic mix of vintage influences and contemporary partywear are at the heart of Manchester based label <strong>Glamorous Wide Fit</strong>, where individual style is the key.  The careful",
            Slug = "glamorous-wide-fit",
        },
        new CatalogBrand
        {
            Id = 126,
            ApiId = 15778,
            Name = "Glamorous Wide Fit",
            Description = "An eclectic mix of vintage influences and contemporary partywear are at the heart of Manchester based label <strong>Glamorous Wide Fit</strong>, where individual style is the key.  The careful",
            Slug = "glamorous-wide-fit",
        },
        new CatalogBrand
        {
            Id = 127,
            ApiId = 16344,
            Name = "Il Sarto",
            Description = "",
            Slug = "il-sarto",
        },
        new CatalogBrand
        {
            Id = 128,
            ApiId = 15735,
            Name = "Emory Park",
            Description = "Based in downtown Los Angeles, new kid on the block <strong>Emory Park</strong> has that effortlessly cool thing well and truly nailed down. Mixing vintage checks and ditsy prints with matchy",
            Slug = "emory-park",
        },
        new CatalogBrand
        {
            Id = 129,
            ApiId = 3040,
            Name = "Pieces",
            Description = "With its Scandinavian roots and minimalist styling, <strong>Pieces</strong> is your go-to label for everyday essentials. From clothing and footwear to jewellery and accessories, the brand ties you",
            Slug = "pieces",
        },
        new CatalogBrand
        {
            Id = 130,
            ApiId = 15720,
            Name = "Nike Football",
            Description = "Innovative sportswear? Check. Streetwear? Check. If it wasn’t *super* obvious yet, we’re talking about Nike. With the best-selling trainers in the game, scroll our Nike at ASOS edit to score everything from Air Force 1s and Air Max 90s to Blazers (now",
            Slug = "nike-football",
        },
        new CatalogBrand
        {
            Id = 131,
            ApiId = 14958,
            Name = "Gym King",
            Description = "Comfort and style? That's no sweat with <strong>Gym King</strong> jersey tees, vests and tracksuits. Influenced by street culture and global nightlife, shop its collections for premium, super-chi",
            Slug = "gym-king",
        },
        new CatalogBrand
        {
            Id = 132,
            ApiId = 746,
            Name = "True Religion",
            Description = "Founded in 2002 by Jeffrey Lubell, with the intention of redefining premium denim, <strong>True Religion</strong> draw inspiration from 1970s style to create a range of vintage inspired jeans",
            Slug = "true-religion",
        },
        new CatalogBrand
        {
            Id = 133,
            ApiId = 15631,
            Name = "Tommy Jeans",
            Description = "Whether it’s an embroidered logo, a bold graphic print or its iconic red, white and blue colour-blocking, there’s no mistaking <strong>Tommy Jeans</strong>. Flying the flag for all thing",
            Slug = "tommy-jeans",
        },
        new CatalogBrand
        {
            Id = 134,
            ApiId = 14334,
            Name = "Helly Hansen",
            Description = "A true heritage brand, <strong>Helly Hansen</strong> was created back in 1877. Founded by Norwegian Helly Juell Hansen and his wife Maren Margarethe, they started out making clothing designed",
            Slug = "helly-hansen",
        },
        new CatalogBrand
        {
            Id = 135,
            ApiId = 15863,
            Name = "Barneys Originals Plus",
            Description = "",
            Slug = "barneys-originals-plus",
        },
        new CatalogBrand
        {
            Id = 136,
            ApiId = 16279,
            Name = "Koi Footwear",
            Description = "Give tired trainers the boot with our <strong>Koi Footwear</strong> at ASOS edit. Expect a range of vegan shoes, boots and trainers with a quirky, modern twist. From embellished hiking boots ",
            Slug = "koi-footwear",
        },
        new CatalogBrand
        {
            Id = 137,
            ApiId = 3179,
            Name = "Hunter",
            Description = "",
            Slug = "hunter",
        },
        new CatalogBrand
        {
            Id = 138,
            ApiId = 14353,
            Name = "Buffalo",
            Description = "Doing some sole searching? Scroll no further than Y2K icons <strong>Buffalo</strong>. With chunky treads that will transport you back to the 90s, expect statement-making trainers and boots in hi",
            Slug = "buffalo",
        },
        new CatalogBrand
        {
            Id = 139,
            ApiId = 14489,
            Name = "Lee Jeans",
            Description = "American denim brand <strong>Lee Jeans</strong> always finds the perfect balance between heritage and modernity. Fill your denim days with its cropped jeans, shirts and dungarees in skinny cuts, true",
            Slug = "lee-jeans",
        },
        new CatalogBrand
        {
            Id = 140,
            ApiId = 16500,
            Name = "Barney s Original Petite",
            Description = "",
            Slug = "barney-s-original-petite",
        },
        new CatalogBrand
        {
            Id = 141,
            ApiId = 14698,
            Name = "Brave Soul Plus",
            Description = "",
            Slug = "brave-soul-plus",
        },
        new CatalogBrand
        {
            Id = 142,
            ApiId = 3009,
            Name = "Steve Madden",
            Description = "Outfit sorted but don’t have the footwear to go with it? <strong>Steve Madden</strong> has every style of shoe to help pull your look together, whatever the occasion. Expect chunky trainer",
            Slug = "steve-madden",
        },
        new CatalogBrand
        {
            Id = 143,
            ApiId = 15805,
            Name = "Coco & Eve",
            Description = "Inspired by a trip to Bali, vegan brand <strong>Coco &amp; Eve</strong> was created by two friends who wanted to bring a taste of their travels back home. Now, thanks ",
            Slug = "coco-&-eve",
        },
        new CatalogBrand
        {
            Id = 144,
            ApiId = 16380,
            Name = "Bleach London",
            Description = "Starting as a single chair and sink in the corner of a nail bar, <strong>Bleach London</strong>n now has a number of hair salons, as well as a range of hair products designed to ",
            Slug = "bleach-london",
        },
        new CatalogBrand
        {
            Id = 145,
            ApiId = 14339,
            Name = "Bulldog",
            Description = "Straightforward skin care is grooming brand <strong>Bulldog</strong> in a nutshell. With vegan-friendly products designed for all skin types, confusing lingo has been ditched in fa",
            Slug = "bulldog",
        },
        new CatalogBrand
        {
            Id = 146,
            ApiId = 14600,
            Name = "Lola May",
            Description = "Launched in 2014, <strong>Lola May</strong> reworks its high-end feel with street style influences for its capsule collection with ASOS. The result is a range of oversized shapes and minimal ta",
            Slug = "lola-may",
        },
        new CatalogBrand
        {
            Id = 147,
            ApiId = 14100,
            Name = "Rains",
            Description = "<strong>Rains</strong> have been defying Danish weather - that’s an average of 121 rain days a year - since 2011, with their own take on the classic raincoat. With a concept designed to be easy to",
            Slug = "rains",
        },
        new CatalogBrand
        {
            Id = 148,
            ApiId = 62251,
            Name = "Made By Mitchell",
            Description = "TBQHWY, we’re pretty sure our <strong>Made By Mitchell</strong> at ASOS edit will have your inner MUA swooning. Haven’t heard of the Blursh range? Allow us to introduce yo",
            Slug = "made-by-mitchell",
        },
        new CatalogBrand
        {
            Id = 149,
            ApiId = 16216,
            Name = "Zoe Ayla",
            Description = "",
            Slug = "zoe-ayla",
        },
        new CatalogBrand
        {
            Id = 150,
            ApiId = 16637,
            Name = "Pretty Lavish Curve",
            Description = "If (like us) you love a bit of statement tailoring, where better to look for some wardrobe-addition inspiration than <strong>Pretty Lavish Curve</strong>? Founded by two sisters in 2013, t",
            Slug = "pretty-lavish-curve",
        },
        new CatalogBrand
        {
            Id = 151,
            ApiId = 15718,
            Name = "Glamorous Curve",
            Description = "An eclectic mix of vintage influences and contemporary partywear are at the heart of Manchester based label <strong>Glamorous Curve</strong>, where individual style is the key.  The carefully ",
            Slug = "glamorous-curve",
        },
        new CatalogBrand
        {
            Id = 152,
            ApiId = 13512,
            Name = "ASOS Petite",
            Description = "This is <strong>ASOS Petite</strong> – your go-to for all the latest trends, no matter who you are, where you’re from and what you’re up to. Exclusive to ASOS, our universal brand is h",
            Slug = "asos-petite",
        },
        new CatalogBrand
        {
            Id = 153,
            ApiId = 14513,
            Name = "Champion",
            Description = "<strong>Champion</strong> has been sorting your street-meets-sportswear styles through the decades. Whether you’re a frequent gym goer, new to the tracks or just want to look good lounging, the",
            Slug = "champion",
        },
        new CatalogBrand
        {
            Id = 154,
            ApiId = 15099,
            Name = "My Accessories",
            Description = "The team behind <strong>My Accessories</strong> draw on more than 15 years of design expertise to put the finishing touches to your look. Expect berets, bag charms and beanies all in the ",
            Slug = "my-accessories",
        },
        new CatalogBrand
        {
            Id = 155,
            ApiId = 13881,
            Name = "Volcom",
            Description = "The idea for <strong>Volcom</strong>&nbsp;came to its founders Richard Woolcott and Tucker Hall during a snowboarding trip in 1991. Incorporating their philosophy of 'Youth against establishment' t",
            Slug = "volcom",
        },
        new CatalogBrand
        {
            Id = 156,
            ApiId = 3182,
            Name = "New Era",
            Description = "American label <strong>New Era</strong> have long enjoyed a relationship with the world of baseball, manufacturing baseball hats for teams since the 1930s. As popular off field as they are on, <",
            Slug = "new-era",
        },
        new CatalogBrand
        {
            Id = 157,
            ApiId = 15849,
            Name = "Puma Golf",
            Description = "Disrupting the game since 1948, <strong>Puma Golf</strong> is out to set and smash goals in its bid to be the fastest sports brand in the world. Scroll the Puma at ASOS edit for the pieces we’re rat",
            Slug = "puma-golf",
        },
        new CatalogBrand
        {
            Id = 158,
            ApiId = 14751,
            Name = "A Star Is Born",
            Description = "East meets West with our exclusive evening range, <strong>A Star Is Born</strong>. We’re talking party perfection with statement beading, hand embroidery and pretty prints. Fall for red",
            Slug = "a-star-is-born",
        },
        new CatalogBrand
        {
            Id = 159,
            ApiId = 16711,
            Name = "VAI21",
            Description = "",
            Slug = "vai21",
        },
        new CatalogBrand
        {
            Id = 160,
            ApiId = 22855,
            Name = "DIFF Eyewear",
            Description = "Watch out, the sun’s about. And we’re loving DIFF Eyewear for delivering *the* freshest sunglasses to help protect those peepers. Classic round sunglasses are given a modern update via pastel shades plus, expect square sunglasses that’ll amp-up ‘f",
            Slug = "diff-eyewear",
        },
        new CatalogBrand
        {
            Id = 161,
            ApiId = 712,
            Name = "Ted Baker",
            Description = "Showcasing its signature style through key separates and statement party dresses, <strong>Ted Baker</strong> is renowned for bringing a contemporary edge to classic styles. Combining a vibrant ",
            Slug = "ted-baker",
        },
        new CatalogBrand
        {
            Id = 162,
            ApiId = 716,
            Name = "TFNC",
            Description = "London label <strong>TFNC</strong> is renowned for its standout occasionwear. Step it up in sparkly fabrics, embellished styles and party-prepped bodycon dresses – just don’t outshine the bride.",
            Slug = "tfnc",
        },
        new CatalogBrand
        {
            Id = 163,
            ApiId = 15368,
            Name = "Maya",
            Description = "Brides-to-be, show your devotion to your best gals with <strong>Maya</strong> embellished bridesmaid dresses. Choose from a selection of midi, maxi and fit-and-flare styles for standout sequins, fl",
            Slug = "maya",
        },
        new CatalogBrand
        {
            Id = 164,
            ApiId = 299,
            Name = "Hummel",
            Description = "Slick Danish design meets urban athleisure with sports-heritage brand <strong>Hummel</strong>. Listing both retro and current trends as influences, the label goes hard on strong colour combos, sp",
            Slug = "hummel",
        },
        new CatalogBrand
        {
            Id = 165,
            ApiId = 13688,
            Name = "Asics",
            Description = "What do you get when you combine advanced technologies with flex-worthy footwear? <strong>Asics</strong>, obvs. Designed with top-tier workouts in mind, the brand serves up performance-enhanced styl",
            Slug = "asics",
        },
        new CatalogBrand
        {
            Id = 166,
            ApiId = 16727,
            Name = "On Running",
            Description = "Searching for running trainers that go the extra mile? <strong>On Running</strong> is the brand to bookmark. Not one for compromising, it was created by professional athletes and an engineer,",
            Slug = "on-running",
        },
        new CatalogBrand
        {
            Id = 167,
            ApiId = 14269,
            Name = "Jordan",
            Description = "Ever since his game-changing jump shot sealed the 1982 NCAA Championship, Michael Jordan has been setting new standards in scores and style for basketball. After first wearing his original Air Jordan Is in 1985, ... ",
            Slug = "jordan",
        },
        new CatalogBrand
        {
            Id = 168,
            ApiId = 589,
            Name = "Puma",
            Description = "Always bringing its A-game, sports giant <strong>Puma</strong> is all about setting and smashing goals in its quest to be forever faster. Feeling motivated yet? Join the club. Packed with all our fa",
            Slug = "puma",
        },
        new CatalogBrand
        {
            Id = 169,
            ApiId = 13687,
            Name = "Native Youth",
            Description = "<strong>Native Youth</strong> introduces oversized silhouettes and lightweight co-ords into your wardrobe this season. Expect clean shapes and soft-touch tencel contrasted with raw-edge fin",
            Slug = "native-youth",
        },
        new CatalogBrand
        {
            Id = 170,
            ApiId = 391,
            Name = "Lacoste",
            Description = "Famed for its iconic crocodile emblem, <strong>Lacoste</strong> was founded by tennis superstar René Lacoste in 1933 and was first to introduce the pique polo shirt. Utilising its sporting backgro",
            Slug = "lacoste",
        },
        new CatalogBrand
        {
            Id = 171,
            ApiId = 16082,
            Name = "Versace Jeans Couture",
            Description = "Part high fashion, part street style, <strong>Versace Jeans Couture</strong> sits between the two. Founded by Donatella and Gianni Versace, the brand’s range of clothing and accessories ta",
            Slug = "versace-jeans-couture",
        },
        new CatalogBrand
        {
            Id = 172,
            ApiId = 15059,
            Name = "Columbia",
            Description = "",
            Slug = "columbia",
        },
        new CatalogBrand
        {
            Id = 173,
            ApiId = 16333,
            Name = "My Accessories Curve",
            Description = "The team behind <strong>My Accessories Curve</strong> draw on more than 15 years of design expertise to put the finishing touches to your look. Expect berets, bag charms and beanies all i",
            Slug = "my-accessories-curve",
        },
        new CatalogBrand
        {
            Id = 174,
            ApiId = 13927,
            Name = "Noisy May",
            Description = "Bringing relaxed, trend-led vibes to your everyday ‘fits, <strong>Noisy May</strong> is your go-to label for fashion-forward denim and wardrobe staples. Get on board with authentic, raw-cut ",
            Slug = "noisy-may",
        },
        new CatalogBrand
        {
            Id = 175,
            ApiId = 16649,
            Name = "BOSS Bodywear",
            Description = "If you need an excuse for a wardrobe update, <strong>BOSS Bodywear</strong> is it. Best known for its tailoring finesse, the luxury German fashion brand has your back when it comes to quality de",
            Slug = "boss-bodywear",
        },
        new CatalogBrand
        {
            Id = 176,
            ApiId = 14969,
            Name = "DesignB London",
            Description = "Accessorize your ‘fit to the fullest with London-based brand <strong>DesignB London</strong>. We’re talking from head-to-toe, with hair clips, earrings and anklets that have both Scandi mini",
            Slug = "designb-london",
        },
        new CatalogBrand
        {
            Id = 177,
            ApiId = 14955,
            Name = "Loungeable",
            Description = "Put your feet up. <strong>Loungeable</strong> has all your lazy-day needs covered. Get in your comfort zone with its fun prints, fleece fabrics and super-cute novelty slippers.",
            Slug = "loungeable",
        },
        new CatalogBrand
        {
            Id = 178,
            ApiId = 15146,
            Name = "Boux Avenue",
            Description = "From standout styles to everyday basics, London-based <strong>Boux Avenue</strong>  lingerie collection has you covered in all the right places. With a focus on fit and attention to deta",
            Slug = "boux-avenue",
        },
        new CatalogBrand
        {
            Id = 179,
            ApiId = 16568,
            Name = "Schuh",
            Description = "Stepping up at a time when fashion dictated a single look, footwear brand <strong>Schuh</strong> has led the way in the ‘wear whatever’ movement. Master of fulfilling your footwear needs, its of",
            Slug = "schuh",
        },
        new CatalogBrand
        {
            Id = 180,
            ApiId = 752,
            Name = "UGG",
            Description = "A hit with the So-Cal surf crowd back in the 70s, <strong>UGG</strong> iconic sheepskin boots have come a long way since then. From the beach to bona fide footwear staple, the brand now offers everyt",
            Slug = "ugg",
        },
        new CatalogBrand
        {
            Id = 181,
            ApiId = 15139,
            Name = "HUGO",
            Description = "Specialising in streetwear, <strong>HUGO</strong> is here to push boundaries through its clothing – and we’re *big* fans. Shop our HUGO at ASOS edit to bag graphic T-shirts, hoodies and sweatshir",
            Slug = "hugo",
        },
        new CatalogBrand
        {
            Id = 182,
            ApiId = 12927,
            Name = "Sorel",
            Description = "Inspired by Inuit knowhow, <strong>Sorel</strong> shoes and boots provide insulation even in the coldest of sub zero temperatures. Uncompromising craftsmanship and uncomplicated design see a range o",
            Slug = "sorel",
        },
        new CatalogBrand
        {
            Id = 183,
            ApiId = 22005,
            Name = "Charles & Keith",
            Description = "It’s the little things that count. Case in point: Charles & Keith's range of accessories. Serving up finishing touches for your ‘fit, the label is sure to raise those envy-inducing levels. Scroll shoulder bags and cross-body bags (not to mention their",
            Slug = "charles-&-keith",
        },
        new CatalogBrand
        {
            Id = 184,
            ApiId = 17855,
            Name = "Monday Haircare",
            Description = "Hair-wash day just got interesting. Specialising in luxe, salon-quality hair-care products formulated with natural ingredients, vegan-brand <strong>Monday Haircare</strong> is ",
            Slug = "monday-haircare",
        },
        new CatalogBrand
        {
            Id = 185,
            ApiId = 13126,
            Name = "Herschel Supply Co",
            Description = "<strong>Herschel Supply Co</strong> produces quality built backpacks inspired by vintage mountaineering equipment, American heritage and world travel. With a passion for individuality and persona",
            Slug = "herschel-supply-co",
        },
        new CatalogBrand
        {
            Id = 186,
            ApiId = 12144,
            Name = "Tangle Teezer",
            Description = "<strong>Tangle Teezer</strong> specialises in award-winning hairbrushes that make taming your hair a whole lot easier. Thanks to patented teeth technology, the brand’s brushes are ",
            Slug = "tangle-teezer",
        },
        new CatalogBrand
        {
            Id = 187,
            ApiId = 14059,
            Name = "Santa Cruz",
            Description = "Known for its elaborately illustrated decks, skateboard brand <strong>Santa Cruz</strong> accompanying apparel is every bit as cool as its cruisers. The result is a collection of boyfriend T-",
            Slug = "santa-cruz",
        },
        new CatalogBrand
        {
            Id = 188,
            ApiId = 16183,
            Name = "Lullabellz",
            Description = "Want to switch up your look in minutes? Great news, <strong>Lullabellz</strong>'s lace-front wigs are an easy way to experiment with your vibe. The brand is big on everyday glam and we’ve p",
            Slug = "lullabellz",
        },
        new CatalogBrand
        {
            Id = 189,
            ApiId = 16471,
            Name = "NEOM",
            Description = "",
            Slug = "neom",
        },
        new CatalogBrand
        {
            Id = 190,
            ApiId = 16477,
            Name = "Aveeno",
            Description = "ICYDK, <strong>Aveeno</strong> is the skincare brand turning softness up a notch. You can forget dry flakes and cracked skin ain’t a thing when you’ve got body washes, buttery hand ",
            Slug = "aveeno",
        },
        new CatalogBrand
        {
            Id = 191,
            ApiId = 16131,
            Name = "Karl Kani",
            Description = "Unable to find apparel that expressed his style the way he wanted, <strong>Karl Kani</strong> decided to take matters into his own hands. At just 16, the Brooklyn-born designer began making his ",
            Slug = "karl-kani",
        },
        new CatalogBrand
        {
            Id = 192,
            ApiId = 3098,
            Name = "Vero Moda",
            Description = "Whether you’re after a wardrobe refresh or just a few staples, <strong>Vero Moda</strong> serves big outfit energy. Scroll for your new favourite pair of jeans, available in a variety of fits",
            Slug = "vero-moda",
        },
        new CatalogBrand
        {
            Id = 193,
            ApiId = 14076,
            Name = "Neon Rose",
            Description = "<strong>Neon Rose</strong> switches up its contemporary style from dusk till dawn, layering cool outerwear over relaxed playsuits, plunging necklines and midi dresses. Shop its separates for c",
            Slug = "neon-rose",
        },
        new CatalogBrand
        {
            Id = 194,
            ApiId = 15994,
            Name = "Neon Rose Plus",
            Description = "<strong>Neon Rose Plus</strong> switches up its contemporary style from dusk till dawn, layering cool outerwear over relaxed playsuits, plunging necklines and midi dresses. Shop its separates ",
            Slug = "neon-rose-plus",
        },
        new CatalogBrand
        {
            Id = 195,
            ApiId = 160,
            Name = "DKNY",
            Description = "An iconic brand for as long as we can remember, <strong>DKNY</strong> designs fail-safe pieces for work, play, and everything in-between. Created by fashion legend Donna Karan, the label serves up B",
            Slug = "dkny",
        },
        new CatalogBrand
        {
            Id = 196,
            ApiId = 3119,
            Name = "Gossard",
            Description = "Inspired by 1900's French actress Sarah Bernhardt's on-stage corseted silhouette, <strong>Gossard</strong> began creating super smooth underwear for cleavage enhancing curves. ... ",
            Slug = "gossard",
        },
        new CatalogBrand
        {
            Id = 197,
            ApiId = 15807,
            Name = "The Couture Club",
            Description = "<strong>The Couture Club</strong> – Manchester’s latest street-style offering – is changing the casualwear game. A self-confessed lifestyle brand, its range of T-shirts and sweats a",
            Slug = "the-couture-club",
        },
        new CatalogBrand
        {
            Id = 198,
            ApiId = 13510,
            Name = "ASOS Maternity",
            Description = "This is <strong>ASOS Maternity</strong> – your go-to for all the latest trends, no matter who you are, where you’re from and what you’re up to. Exclusive to ASOS, our universal brand i",
            Slug = "asos-maternity",
        },
        new CatalogBrand
        {
            Id = 199,
            ApiId = 14042,
            Name = "Bluebella",
            Description = "Inspired by what lies beneath, British lingerie label <strong>Bluebella</strong> creates fashion cross-over styles with a provocative twist. Check out our edit of its bras, briefs and bodies a",
            Slug = "bluebella",
        },
        new CatalogBrand
        {
            Id = 200,
            ApiId = 16631,
            Name = "ASOS LUXE",
            Description = "Get ready to send those ‘What you wearing?’ texts, because <strong>ASOS Luxe</strong> is serving elevated looks that'll dominate your IG feed and beyond. Make high-key co-ords the first st",
            Slug = "asos-luxe",
        },
        new CatalogBrand
        {
            Id = 201,
            ApiId = 16508,
            Name = "LAUREN by RALPH LAUREN",
            Description = "<strong>LAUREN by RALPH LAUREN</strong> has achieved icon status. Known for its preppy-chic designs and signature polo player logo, the brand offers a range of collegiate-cool clothing",
            Slug = "lauren-by-ralph-lauren",
        },
        new CatalogBrand
        {
            Id = 202,
            ApiId = 15882,
            Name = "Lindex",
            Description = "",
            Slug = "lindex",
        },
        new CatalogBrand
        {
            Id = 203,
            ApiId = 12255,
            Name = "Orelia",
            Description = "Eclectic label <strong>Orelia</strong> makes beautiful costume jewellery adorned with Swarovski crystals, semi-precious stones and charms. A love of shopping and travel sees eclectic influences a",
            Slug = "orelia",
        },
        new CatalogBrand
        {
            Id = 204,
            ApiId = 20202,
            Name = "Esmee Curve",
            Description = "After some new beachwear for your next trip?&nbsp;<strong>Esmee Curve</strong>&nbsp;has a range of relaxed options for when it’s extra hot. For something to throw on over your bikini, browse the ",
            Slug = "esmee-curve",
        },
        new CatalogBrand
        {
            Id = 205,
            ApiId = 3738,
            Name = "Dune",
            Description = "Searching for trend-led designs combined with a timeless appeal? Then look to <strong>Dune</strong>. With a collection featuring cross-body and tote bags, your belongings will be secured in s",
            Slug = "dune",
        },
        new CatalogBrand
        {
            Id = 206,
            ApiId = 12840,
            Name = "Selected",
            Description = "Embracing freedom, identity and style, <strong>Selected</strong> offers a collection of understated elegance and timeless cool. Focusing on clean, contemporary lines with its tailoring, ... ",
            Slug = "selected",
        },
        new CatalogBrand
        {
            Id = 207,
            ApiId = 15687,
            Name = "Flounce London",
            Description = "Whatever the occasion, nail your going-out ’fit with <strong>Flounce London</strong> collection of party pieces. Streamline your silhouette in velvet and metallic bodysuits, or choose f",
            Slug = "flounce-london",
        },
        new CatalogBrand
        {
            Id = 208,
            ApiId = 12205,
            Name = "LAB Series",
            Description = "Developing a high-tech skin-care range specifically for men, <strong>LAB Series</strong> is big on science-first formulas. What’s more, the experts behind the brand have made sure",
            Slug = "lab-series",
        },
        new CatalogBrand
        {
            Id = 209,
            ApiId = 3379,
            Name = "Elemis",
            Description = "Calling all skincare obsessives – <strong>Elemis</strong> range of skin and body-care heroes brings the spa to you. Created by a team of scientists and skincare experts, the brand blends botani",
            Slug = "elemis",
        },
        new CatalogBrand
        {
            Id = 210,
            ApiId = 20551,
            Name = "Flamingo",
            Description = "Body-care brand Flamingo believes that when we take care of ourselves, we’re able show up for ourselves. With a range of products designed to upgrade your TLC routine, scroll our Flamingo at ASOS edit and experience the brand’s science and feedback-ba",
            Slug = "flamingo",
        },
        new CatalogBrand
        {
            Id = 211,
            ApiId = 22805,
            Name = "Doll Beauty",
            Description = "This is makeup brand <strong>Doll Beauty</strong>, and its motto is: make them stare. POV: you're turning glam all the way up with its super-shiny lip glosses in every shade from b",
            Slug = "doll-beauty",
        },
        new CatalogBrand
        {
            Id = 212,
            ApiId = 20701,
            Name = "Revolution Man",
            Description = "Created in 2013 around the founder’s kitchen table, <strong>Revolution Man</strong> is committed to making vegan makeup and skincare that’s accessible to all. You’ll have to be quick thou",
            Slug = "revolution-man",
        },
        new CatalogBrand
        {
            Id = 213,
            ApiId = 15563,
            Name = "Apothecary 87",
            Description = "Your hair and skin go through a lot. Treat them to some well-earned TLC with <strong>Apothecary 87</strong> grooming and styling products. Fragranced with super-fresh scents, the brand’s r",
            Slug = "apothecary-87",
        },
        new CatalogBrand
        {
            Id = 214,
            ApiId = 12930,
            Name = "bareMinerals",
            Description = "There’s no better feeling than taking your makeup off at the end of the day, but when it comes to <strong>bareMinerals</strong>, you might forget you even have it on. Naturally ",
            Slug = "bareminerals",
        },
        new CatalogBrand
        {
            Id = 215,
            ApiId = 15585,
            Name = "Murdock London",
            Description = "Scouring the globe to source the perfect ingredients, <strong>Murdock London</strong> doesn&rsquo;t hold back when it comes to creating its range of men's grooming products.",
            Slug = "murdock-london",
        },
        new CatalogBrand
        {
            Id = 216,
            ApiId = 16337,
            Name = "Style Cheat",
            Description = "Our edit of your new favourite brand <strong>Style Cheat</strong> is here. Delivering the cutest dresses, tops and jumpsuits, ... ",
            Slug = "style-cheat",
        },
        new CatalogBrand
        {
            Id = 217,
            ApiId = 14988,
            Name = "Amy Lynn",
            Description = "Put the sweats away and dress up for the day with <strong>Amy Lynn</strong>. The London-based clothing label offers up contemporary capsule collections that’ll have you craving that look-good",
            Slug = "amy-lynn",
        },
        new CatalogBrand
        {
            Id = 218,
            ApiId = 12507,
            Name = "Calvin Klein Jeans",
            Description = "Underwear authority and all-round fashion icon, <strong>Calvin Klein Jeans</strong> puts a designer stamp on clean, casual-cool staples. From smart shirts to waistbands, the brand’s famous C",
            Slug = "calvin-klein-jeans",
        },
        new CatalogBrand
        {
            Id = 219,
            ApiId = 15715,
            Name = "Barbour International",
            Description = "With a rich heritage dating back to 1894, quintessentially British brand, <strong>Barbour International</strong> have garnered a reputation for quality and durability, across their collection of h",
            Slug = "barbour-international",
        },
        new CatalogBrand
        {
            Id = 220,
            ApiId = 14630,
            Name = "Beauty Extras",
            Description = "",
            Slug = "beauty-extras",
        },
        new CatalogBrand
        {
            Id = 221,
            ApiId = 16338,
            Name = "Planks",
            Description = "Taking elements of street culture, Alpine lifestyle and British design, snow-sports brand Planks is owned and inspired by skiers. Built for the slopes, but just as at home on the streets, ... ",
            Slug = "planks",
        },
        new CatalogBrand
        {
            Id = 222,
            ApiId = 15643,
            Name = "ASOS 4505",
            Description = "Whether you’re gaining, training or exploring the great outdoors, our resident fitness brand <strong>ASOS 4505</strong> has your athletic aesthetic covered. Scroll leggings, shorts and jogge",
            Slug = "asos-4505",
        },
        new CatalogBrand
        {
            Id = 223,
            ApiId = 12113,
            Name = "Berghaus",
            Description = "A literal translation of the German for 'mountain centre', <strong>Berghaus</strong> was founded in 1966 by two mountaineering friends frustrated with the lack of decent outdoor wear.",
            Slug = "berghaus",
        },
        new CatalogBrand
        {
            Id = 224,
            ApiId = 16546,
            Name = "Be Mine Wide Fit",
            Description = "Searching for shoes that will take your wedding-day look from aisle-to-dancefloor?&nbsp;<strong>Be Mine Wide Fit</strong>&nbsp;is here to tick one thing off your list, so you can focus on the ",
            Slug = "be-mine-wide-fit",
        },
        new CatalogBrand
        {
            Id = 225,
            ApiId = 16059,
            Name = "4th & Reckless",
            Description = "<strong>4th & Reckless</strong> is the UK-based brand your wardrobe wants to be introduced to. From jumpsuits to crop tops, LBDs to blazers, its mix of classic tailoring and on-trend shades",
            Slug = "4th-&-reckless",
        },
        new CatalogBrand
        {
            Id = 226,
            ApiId = 62151,
            Name = "Sachajuan",
            Description = "Give your hair the TLC it deserves with our <strong>Sachajuan</strong> at ASOS edit. All about keeping it simple, the brand focuses on making haircare easy. From volumizing and scalp",
            Slug = "sachajuan",
        },
        new CatalogBrand
        {
            Id = 227,
            ApiId = 15747,
            Name = "HIIT",
            Description = "",
            Slug = "hiit",
        },
        new CatalogBrand
        {
            Id = 228,
            ApiId = 13078,
            Name = "Nars",
            Description = "<strong>Nars</strong> has become one of the biggest names in the industry since its conception in 1994 by François Nars. Known for its no-rules attitude to self-expression, the brand’s co",
            Slug = "nars",
        },
        new CatalogBrand
        {
            Id = 229,
            ApiId = 13527,
            Name = "Revolution",
            Description = "Created in 2013 around the founder&rsquo;s kitchen table, <strong>Revolution</strong> is committed to making vegan makeup and skincare that&rsquo;s accessible to all. You&rsquo;ll h",
            Slug = "revolution",
        },
        new CatalogBrand
        {
            Id = 230,
            ApiId = 15898,
            Name = "Philip Kingsley",
            Description = "<strong>Philip Kingsley</strong> knows that healthy, happy hair begins at the roots. The brand’s award-winning range of shampoos and conditioners is powered by trichology, me",
            Slug = "philip-kingsley",
        },
        new CatalogBrand
        {
            Id = 231,
            ApiId = 16190,
            Name = "Cantu",
            Description = "When it comes to textured hair, Cantu is your go-to brand – but you probably already knew that. Its award-winning treatments are designed to look after your coils, curls, waves, or straight tresses. Our edit features all the classics, including the ultr",
            Slug = "cantu",
        },
        new CatalogBrand
        {
            Id = 232,
            ApiId = 16264,
            Name = "Wrangler Plus",
            Description = "From its working cowboy roots, <strong>Wrangler Plus</strong> American blue jeans set a new standard for the denim industry. Inspired by the very first pair of ... ",
            Slug = "wrangler-plus",
        },
        new CatalogBrand
        {
            Id = 233,
            ApiId = 15230,
            Name = "River Island Petite",
            Description = "High-street hero <strong>River Island Petite</strong> covers all bases with its selection of clothing, accessories, swimwear and footwear. Offering everything from standout party dresses an",
            Slug = "river-island-petite",
        },
        new CatalogBrand
        {
            Id = 234,
            ApiId = 22659,
            Name = "Michael Kors Fragrances",
            Description = "Looking to spritz up your fragrance shelf? Indulge in a lil bit of luxury with Michael Kors Fragrances. From fashion to fragrance, the brand adds *luxe* to everything it creates – think florals, citrus and musky scents. Shop our Michael Kors Fragrances ",
            Slug = "michael-kors-fragrances",
        },
        new CatalogBrand
        {
            Id = 235,
            ApiId = 13488,
            Name = "Issey Miyake",
            Description = "",
            Slug = "issey-miyake",
        },
        new CatalogBrand
        {
            Id = 236,
            ApiId = 62061,
            Name = "Megababe",
            Description = "Say goodbye to the taboos of body care and hello to our Megababe at ASOS edit. Ft. the goods to top up your self-care shelf, the label will have you feeling comfortable AND confident in your own skin. Shop deodorants to fight sweat and odour, or scroll an",
            Slug = "megababe",
        },
        new CatalogBrand
        {
            Id = 237,
            ApiId = 16205,
            Name = "Crocs",
            Description = "We’re calling it – <strong>Crocs</strong> are back. Since 2002, the brand has dedicated itself to finding new comfort technologies and revolutionary materials to keep your feet feeling good – ",
            Slug = "crocs",
        },
        new CatalogBrand
        {
            Id = 238,
            ApiId = 612,
            Name = "Replay",
            Description = "Hitting refresh on classic cuts – the name makes sense now, right? – <strong>Replay</strong> jeans, jackets and T-shirts are updated with hand-crafted details and over-dyed finishes. Its bags an",
            Slug = "replay",
        },
        new CatalogBrand
        {
            Id = 239,
            ApiId = 3272,
            Name = "Speedo",
            Description = "Founded on Bondi Beach, <strong>Speedo</strong> is the world's best-selling swimwear brand, synonymous with a legion of gold medal champions. With a focus on technical innovation, the label has bee",
            Slug = "speedo",
        },
        new CatalogBrand
        {
            Id = 240,
            ApiId = 16670,
            Name = "Bailey Rose",
            Description = "ICYMI, there’s a Y2K revival and <strong>Bailey Rose</strong> is bringing all the nostalgic feels. We’ve pulled together our pick of the labels smock dresses in retro prints and cute, cr",
            Slug = "bailey-rose",
        },
        new CatalogBrand
        {
            Id = 241,
            ApiId = 15441,
            Name = "Influence Plus",
            Description = "",
            Slug = "influence-plus",
        },
        new CatalogBrand
        {
            Id = 242,
            ApiId = 13632,
            Name = "Frock and Frill",
            Description = "Channelling a vintage vibe with a standout collection of party dresses and glam separates, <strong>Frock and Frill</strong> mixes catwalk inspiration with Art Deco detailing. With a fresh, f",
            Slug = "frock-and-frill",
        },
        new CatalogBrand
        {
            Id = 243,
            ApiId = 21555,
            Name = "Something New",
            Description = "Unlock your wardrobe potential with <strong>Something New</strong>, the brand that encourages you to be bold. Expect gram-worthy designs ft. prints and embellishments as well as matching c",
            Slug = "something-new",
        },
        new CatalogBrand
        {
            Id = 244,
            ApiId = 14565,
            Name = "NaaNaa",
            Description = "With a flair for party pieces, <strong>NaaNaa</strong> puts its statement stamp on bodycon silhouettes, tailored jumpsuits and figure-flattering midi dresses. Strappy styling and peekaboo cut-out",
            Slug = "naanaa",
        },
        new CatalogBrand
        {
            Id = 245,
            ApiId = 20650,
            Name = "e.l.f.",
            Description = "Give your beauty bag the ultimate makeover with <strong>e.l.f.</strong>. The vegan brand is all about creating game-changing products for every face – we’re talking mascaras to make",
            Slug = "e.l.f.",
        },
        new CatalogBrand
        {
            Id = 246,
            ApiId = 15818,
            Name = "Bobbi Brown",
            Description = "Named after the makeup artist who founded it in 1991, cosmetics brand <strong>Bobbi Brown</strong> started life behind the counter of a department store in New York City. Fast forw",
            Slug = "bobbi-brown",
        },
        new CatalogBrand
        {
            Id = 247,
            ApiId = 740,
            Name = "Too Faced Cosmetics",
            Description = "What's full of makeup bag MVPs and offers endless looks? Our <strong>Too Faced Cosmetics</strong> at edit at ASOS of course. Scroll the brand’s chocolate bronzers to add some warmth",
            Slug = "too-faced-cosmetics",
        },
        new CatalogBrand
        {
            Id = 248,
            ApiId = 16543,
            Name = "Mylee",
            Description = "Founded in 2014, British brand <strong>Mylee</strong> makes DIY dreams a reality with its extensive range of gel nail polishes, primers and nail-perfecting treatments – meaning you can",
            Slug = "mylee",
        },
        new CatalogBrand
        {
            Id = 249,
            ApiId = 16551,
            Name = "Acnecide",
            Description = "",
            Slug = "acnecide",
        },
        new CatalogBrand
        {
            Id = 250,
            ApiId = 16552,
            Name = "Sunday Riley",
            Description = "Hit refresh on your morning routine and show your skin some love with <strong>Sunday Riley</strong>. The brand’s products are made with balancing botanicals and lightweight, vit",
            Slug = "sunday-riley",
        },
        new CatalogBrand
        {
            Id = 251,
            ApiId = 15943,
            Name = "Laura Mercier",
            Description = "",
            Slug = "laura-mercier",
        },
        new CatalogBrand
        {
            Id = 252,
            ApiId = 15939,
            Name = "Origins",
            Description = "",
            Slug = "origins",
        },
        new CatalogBrand
        {
            Id = 253,
            ApiId = 13931,
            Name = "Brave Soul",
            Description = "",
            Slug = "brave-soul",
        },
        new CatalogBrand
        {
            Id = 254,
            ApiId = 14989,
            Name = "UNIQUE21",
            Description = "Specialising in clean, minimal tailoring, British label <strong>Unique 21</strong> smartens up your wardrobe staples with its latest offering. Designed exclusively in-house, th",
            Slug = "unique21",
        },
        new CatalogBrand
        {
            Id = 255,
            ApiId = 20750,
            Name = "Cherry Beach",
            Description = "",
            Slug = "cherry-beach",
        },
        new CatalogBrand
        {
            Id = 256,
            ApiId = 21960,
            Name = "GUESS Originals",
            Description = "If it’s cool casualwear you’re after, then it’s cool casualwear you’re gonna get – <strong>GUESS Originals</strong>, please stand up. Inspired by modern streetwear and archival",
            Slug = "guess-originals",
        },
        new CatalogBrand
        {
            Id = 257,
            ApiId = 21706,
            Name = "PACSUN",
            Description = "Question: what casj wardrobe is complete without pieces from PACSUN? Answer: none. The California-based brand is delivering throw-on-and-go styles that’ll become your everyday heroes. Expect hoodies, T-shirts and jeans with the freshest cuts and graphic",
            Slug = "pacsun",
        },
        new CatalogBrand
        {
            Id = 258,
            ApiId = 18850,
            Name = "First Distraction",
            Description = "",
            Slug = "first-distraction",
        },
        new CatalogBrand
        {
            Id = 259,
            ApiId = 14434,
            Name = "L'Oreal",
            Description = "With an approach grounded in science, leading beauty brand <strong>L'Oreal</strong> demands only the most visionary products from its team. Whether you need an everyday cover-up or a slick",
            Slug = "l'oreal",
        },
        new CatalogBrand
        {
            Id = 260,
            ApiId = 16340,
            Name = "Beauut",
            Description = "When it comes to occasionwear, there’s nothing like a little sparkle. Serving embellished dresses, tops and bottoms, our <strong>Beauut</strong> at ASOS edit has you covered for every event in ",
            Slug = "beauut",
        },
        new CatalogBrand
        {
            Id = 261,
            ApiId = 13679,
            Name = "Influence",
            Description = "Trend focused and led by catwalk styles, <strong>Influence</strong> create a collection of knitwear, dresses and jersey separates. ... ",
            Slug = "influence",
        },
        new CatalogBrand
        {
            Id = 262,
            ApiId = 15950,
            Name = "Nike Basketball",
            Description = "Innovative sportswear? Check. Streetwear? Check. If it wasn’t *super* obvious yet, we’re talking about Nike. With the best-selling trainers in the game, scroll our Nike at ASOS edit to score everything from Air Force 1s and Air Max 90s to Blazers (now",
            Slug = "nike-basketball",
        },
        new CatalogBrand
        {
            Id = 263,
            ApiId = 21661,
            Name = "Commando",
            Description = "Streamline your style with ultra-glam brand Commando. Serving seamless bodysuits, leggings and crop tops, the brand specialises in timeless staples to sculpt and enhance. Shop our Commando at ASOS edit for mini skirts that offer a sleek, form-fitting silh",
            Slug = "commando",
        },
        new CatalogBrand
        {
            Id = 264,
            ApiId = 14490,
            Name = "Good For Nothing",
            Description = "Streetwear label <strong>Good For Nothing</strong> confronts the status quo with its collection of contrasts. Established in 2011, it challenges construction with tees and sweats in cut a",
            Slug = "good-for-nothing",
        },
        new CatalogBrand
        {
            Id = 265,
            ApiId = 16377,
            Name = "We Are We Wear",
            Description = "ABOUT WE ARE WE WEAR <strong>We Are We Wear</strong> is making waves on the swimwear scene. Its versatile collection is inspired by the idea that swimwear isn’t just for a dip in the se",
            Slug = "we-are-we-wear",
        },
        new CatalogBrand
        {
            Id = 266,
            ApiId = 14607,
            Name = "Flook",
            Description = "Proving there’s nothing accidental about <strong>Flook</strong> woven designs, founder Nikki Flook calls on highly skilled artisans in Indonesia to create her collections. The result is a range ",
            Slug = "flook",
        },
        new CatalogBrand
        {
            Id = 267,
            ApiId = 15301,
            Name = "Lace & Beads",
            Description = "London-based label <strong>Lace & Beads</strong> know sparkly dresses are always a good idea, so create the perfect handcrafted party pieces for your BNO. Expect standout embellishment, crop ",
            Slug = "lace-&-beads",
        },
        new CatalogBrand
        {
            Id = 268,
            ApiId = 14369,
            Name = "Parisian",
            Description = "Dress for the main stage with <strong>Parisian</strong> cool cover-ups and crochet separates. It’s all in the details, so pack a floral print to ace your festival steez, or fall for fringing ",
            Slug = "parisian",
        },
        new CatalogBrand
        {
            Id = 269,
            ApiId = 16715,
            Name = "Urban Revivo",
            Description = "Social calendar filling up fast? Pair your plans with 00s-born <strong>Urban Revivo</strong>, the fashion-forward brand with runway-inspired designs at the ready. Shop all the latest looks,",
            Slug = "urban-revivo",
        },
        new CatalogBrand
        {
            Id = 270,
            ApiId = 12512,
            Name = "Skechers",
            Description = "Built on principles of comfort and durability, American brand <strong>Skechers</strong> has become a household name in premium kicks. Offering both casual and performance ranges, the brand chann",
            Slug = "skechers",
        },
        new CatalogBrand
        {
            Id = 271,
            ApiId = 13575,
            Name = "Little Mistress",
            Description = "<strong>Little Mistress</strong> collection ticks all your occasionwear boxes – we’re talking weddings, proms, fancy parties and everything in-between. The brand’s pretty dresses a",
            Slug = "little-mistress",
        },
        new CatalogBrand
        {
            Id = 272,
            ApiId = 166,
            Name = "Dr Denim",
            Description = "Famous for their narrow silhouette and skinny jeans, <strong>Dr Denim</strong> was founded in Sweden in 2003 and today offers a variety of clothing with denim very much still on the agenda.",
            Slug = "dr-denim",
        },
        new CatalogBrand
        {
            Id = 273,
            ApiId = 16554,
            Name = "SNDYS",
            Description = "Embracing all things Sunday, Australian brand <strong>SNDYS</strong> is big on easy, comfy clothing. The brand’s knitted T-shirts, skirts, hoodies and trousers are ideal for lounging, while subt",
            Slug = "sndys",
        },
        new CatalogBrand
        {
            Id = 274,
            ApiId = 12732,
            Name = "Barbour",
            Description = "With a rich heritage dating back to 1894, quintessentially British brand, <strong>Barbour</strong> have garnered a reputation for quality and durability, across their collection of high performanc",
            Slug = "barbour",
        },
        new CatalogBrand
        {
            Id = 275,
            ApiId = 16623,
            Name = "Salomon",
            Description = "",
            Slug = "salomon",
        },
        new CatalogBrand
        {
            Id = 276,
            ApiId = 14823,
            Name = "Public Desire",
            Description = "If you thought <strong>Public Desire</strong> only did shoes, we’ve got news for you. Updating its offering with a range of selfie-worthy apparel – think slinky dresses, statement co-o",
            Slug = "public-desire",
        },
        new CatalogBrand
        {
            Id = 277,
            ApiId = 15723,
            Name = "adidas Golf",
            Description = "<strong>adidas Golf</strong> needs no introduction. The brand’s famous 3-Stripes can be seen on the track, field and in the latest streetwear trends. Scroll the ... ",
            Slug = "adidas-golf",
        },
        new CatalogBrand
        {
            Id = 278,
            ApiId = 582,
            Name = "Pretty Polly",
            Description = "If you wear tights, chances are you’ve worn a pair of <strong>Pretty Polly</strong> tights. Leading the hosiery game since 1919, the British brand’s selection of tights is available in a",
            Slug = "pretty-polly",
        },
        new CatalogBrand
        {
            Id = 279,
            ApiId = 12359,
            Name = "Mama.licious",
            Description = "<strong>Mama.licious</strong> make light work of pregnancy dressing, with a modern collection of jeans, dresses and jersey designed to flatter your bump and accommodate your new curves. Mixing fine prints, delicate cuts and femini",
            Slug = "mama.licious",
        },
        new CatalogBrand
        {
            Id = 280,
            ApiId = 3563,
            Name = "Oakley",
            Description = "Jim Jannard founded <strong>Oakley</strong> with $300 and the simple idea of making sunglasses that work and look better than anything else out there. Beginning an evolution of eyewear from generic ",
            Slug = "oakley",
        },
        new CatalogBrand
        {
            Id = 281,
            ApiId = 3624,
            Name = "Roxy",
            Description = "When Quiksilver started sister label <strong>Roxy</strong> it was a pretty big deal. With a band of female pro surfers quite literally on board, ... ",
            Slug = "roxy",
        },
        new CatalogBrand
        {
            Id = 282,
            ApiId = 15129,
            Name = "Miss Selfridge Petite",
            Description = "<strong>Miss Selfridge Petite</strong> takes you from day to date night with its off-duty looks and full-on glamour. Solve what-to-wear dilemmas with its dresses and accessories that comb",
            Slug = "miss-selfridge-petite",
        },
        new CatalogBrand
        {
            Id = 283,
            ApiId = 13889,
            Name = "Quay Australia",
            Description = "Born roadside on the festival circuit, eyewear brand <strong>Quay Australia</strong> helps you soak up the good vibes with its range of standout sunglasses and glasses. Serve real shade with oversi",
            Slug = "quay-australia",
        },
        new CatalogBrand
        {
            Id = 284,
            ApiId = 16641,
            Name = "Lapp The Brand",
            Description = "Looking to pull off practical-meets-glam athleisure? Take a cue from our <strong>Lapp The Brand</strong> at ASOS edit. Serving effortless styles designed to flatter and empower, shop the ",
            Slug = "lapp-the-brand",
        },
        new CatalogBrand
        {
            Id = 285,
            ApiId = 15648,
            Name = "TYPO",
            Description = "Australian label <strong>TYPO</strong> offers a fun collection of gifts and homeware. Channelling its quirky personality into a range of designs, the brand’s glitter notebooks, pens and speakers ",
            Slug = "typo",
        },
        new CatalogBrand
        {
            Id = 286,
            ApiId = 16657,
            Name = "Morphe",
            Description = "Born among artists and influencers in Los Angeles, <strong>Morphe</strong> blends the rules and celebrates individuality with its high-performance makeup collection. Whether bright neon",
            Slug = "morphe",
        },
        new CatalogBrand
        {
            Id = 287,
            ApiId = 14664,
            Name = "Brave Soul Tall",
            Description = "",
            Slug = "brave-soul-tall",
        },
        new CatalogBrand
        {
            Id = 288,
            ApiId = 15817,
            Name = "Clinique",
            Description = "Founded back in 1968, <strong>Clinique</strong> has gone on to become one of the world’s most iconic skin-care and makeup brands – but you already knew that. We’re giving props ",
            Slug = "clinique",
        },
        new CatalogBrand
        {
            Id = 289,
            ApiId = 15796,
            Name = "MAC",
            Description = "Tell a friend – <strong>MAC</strong> has launched on ASOS and all our dreams have come true. The colourful cosmetics brand officially launched in 1984 in a department store in Toronto, C",
            Slug = "mac",
        },
        new CatalogBrand
        {
            Id = 290,
            ApiId = 15407,
            Name = "Soul Star",
            Description = "",
            Slug = "soul-star",
        },
        new CatalogBrand
        {
            Id = 291,
            ApiId = 13027,
            Name = "Nip+Fab",
            Description = "Blink and you’ll miss it – <strong>Nip+Fab</strong> collection of skin-care products aims to deliver instant results. Formulated with innovative ingredients including glycolic acid and drag",
            Slug = "nip+fab",
        },
        new CatalogBrand
        {
            Id = 292,
            ApiId = 3470,
            Name = "Muubaa",
            Description = "<strong>Muubaa</strong> design philosophy is about creating current yet timeless pieces for each wearer to make their own. Redefining the possibilities of leather, ... ",
            Slug = "muubaa",
        },
        new CatalogBrand
        {
            Id = 293,
            ApiId = 15841,
            Name = "Dr Dennis Gross",
            Description = "",
            Slug = "dr-dennis-gross",
        },
        new CatalogBrand
        {
            Id = 294,
            ApiId = 14722,
            Name = "EA7",
            Description = "A diffusion line from iconic fashion house Armani, <strong>EA7</strong> offers timeless style with their collections of wearable classics. ... ",
            Slug = "ea7",
        },
        new CatalogBrand
        {
            Id = 295,
            ApiId = 16445,
            Name = "Revolution Pro",
            Description = "Created in 2013 around the founder’s kitchen table, <strong>Revolution Pro</strong> is committed to making vegan makeup and skincare that’s accessible to all. You’ll have to b",
            Slug = "revolution-pro",
        },
        new CatalogBrand
        {
            Id = 296,
            ApiId = 15379,
            Name = "Invisibobble",
            Description = "After tying up her hair for a fancy dress party with an old phone cord, <strong>Invisibobble</strong> founder discovered a new way to tidy her tresses. Enlisting German technicians to finalise he",
            Slug = "invisibobble",
        },
        new CatalogBrand
        {
            Id = 297,
            ApiId = 22605,
            Name = "Object Tall",
            Description = "Object Tall is one of those clothing brands that everyone can get in on. Its mixture of boho styles and minimal designs serve up that casual-cool vibe we all know and love. Think pretty dresses in relaxed cuts, blouses in interesting fabrics and everyday ",
            Slug = "object-tall",
        },
        new CatalogBrand
        {
            Id = 298,
            ApiId = 15928,
            Name = "THE INKEY LIST",
            Description = "Skincare can be confusing with ingredients that sound more sci-fi than soothing. Luckily, though, skincare brand <strong>THE INKEY LIST</strong>  believes in a more straightforw",
            Slug = "the-inkey-list",
        },
        new CatalogBrand
        {
            Id = 299,
            ApiId = 15461,
            Name = "L'Oreal Men Expert",
            Description = "<strong>L'Oreal Men Expert</strong> don’t throw around the term ‘expert’ lightly. This is a grooming range that combines a legacy of science and innovation and is designed complete",
            Slug = "l'oreal-men-expert",
        },
        new CatalogBrand
        {
            Id = 300,
            ApiId = 16360,
            Name = "Public Desire Wide Fit",
            Description = "If you thought <strong>Public Desire Wide Fit</strong> only did shoes, we’ve got news for you. Updating its offering with a range of selfie-worthy apparel – think slinky dresses, state",
            Slug = "public-desire-wide-fit",
        },
        new CatalogBrand
        {
            Id = 301,
            ApiId = 23255,
            Name = "The Beauty Crop",
            Description = "Makeup that nurtures your skin? Yes please. All about putting its formulas first, <strong>The Beauty Crop</strong> uses nutrition-rich ingredients in its products while deliver",
            Slug = "the-beauty-crop",
        },
        new CatalogBrand
        {
            Id = 302,
            ApiId = 21502,
            Name = "AZALEA WANG",
            Description = "",
            Slug = "azalea-wang",
        },
        new CatalogBrand
        {
            Id = 303,
            ApiId = 15665,
            Name = "Shea Moisture",
            Description = "",
            Slug = "shea-moisture",
        },
        new CatalogBrand
        {
            Id = 304,
            ApiId = 22955,
            Name = "Luna",
            Description = "Give your pyjama drawer some love with our Luna at ASOS edit. All about trend-led nightwear, the brand will have you entering sleep mode in style. Scroll matching shirt and short sets in multiple prints or go all-in-one with its comfy rompers. Looking to ",
            Slug = "luna",
        },
        new CatalogBrand
        {
            Id = 305,
            ApiId = 16355,
            Name = "4th & Reckless Petite",
            Description = "<strong>4th & Reckless Petite</strong> is the UK-based brand your wardrobe wants to be introduced to. From jumpsuits to crop tops, LBDs to blazers, its mix of classic tailoring and on-trend",
            Slug = "4th-&-reckless-petite",
        },
        new CatalogBrand
        {
            Id = 306,
            ApiId = 16354,
            Name = "4th & Reckless Tall",
            Description = "<strong>4th & Reckless Tall</strong> is the UK-based brand your wardrobe wants to be introduced to. From jumpsuits to crop tops, LBDs to blazers, its mix of classic tailoring and on-trend s",
            Slug = "4th-&-reckless-tall",
        },
        new CatalogBrand
        {
            Id = 307,
            ApiId = 22159,
            Name = "4th & Reckless Plus",
            Description = "<strong>4th & Reckless Plus</strong> is the UK-based brand your wardrobe wants to be introduced to. From jumpsuits to crop tops, LBDs to blazers, its mix of classic tailoring and on-trend sh",
            Slug = "4th-&-reckless-plus",
        },
        new CatalogBrand
        {
            Id = 308,
            ApiId = 16478,
            Name = "OLAPLEX",
            Description = "If you’re looking to achieve shiny, healthy-looking hair at home, <strong>OLAPLEX's</strong> hair-care heroes are designed to restore and strengthen damaged hair. The brand’s game-",
            Slug = "olaplex",
        },
        new CatalogBrand
        {
            Id = 309,
            ApiId = 15751,
            Name = "Forever New Petite",
            Description = "Founded in Melbourne in 2006 as a start-up retailer, <strong>Forever New Petite</strong> has evolved into one of the fastest-growing brands in Australia, thanks to its film and catwalk-inspi",
            Slug = "forever-new-petite",
        },
        new CatalogBrand
        {
            Id = 310,
            ApiId = 15709,
            Name = "Flounce London Plus",
            Description = "Whatever the occasion, nail your going-out ’fit with <strong>Flounce London Plus</strong> collection of party pieces. Fall for velvet and metallic bodysuits, or choose from fancier-than",
            Slug = "flounce-london-plus",
        },
        new CatalogBrand
        {
            Id = 311,
            ApiId = 14459,
            Name = "Starlet",
            Description = "With its standout bodycons and sequinned dresses, <strong>Starlet</strong> proves first impressions count. Shop its embroidered and hand-embellished pieces, designed by its talented team and ins",
            Slug = "starlet",
        },
        new CatalogBrand
        {
            Id = 312,
            ApiId = 14510,
            Name = "Never Fully Dressed",
            Description = "From its humble beginnings at London’s Portobello Road market, <strong>Never Fully Dressed</strong> has grown into a brand known for classic clean lines and flattering silhouettes.",
            Slug = "never-fully-dressed",
        },
        new CatalogBrand
        {
            Id = 313,
            ApiId = 15058,
            Name = "Daisy Street Plus",
            Description = "If you like your trends as fast as they come then <strong>Daisy Street Plus</strong> is the label for you. Always up on their A-game, ... ",
            Slug = "daisy-street-plus",
        },
        new CatalogBrand
        {
            Id = 314,
            ApiId = 22906,
            Name = "JDY Tall",
            Description = "<strong>JDY Tall</strong> collection here at ASOS is a bit of us, and we think it’ll be a bit of you, too. Mix and match its dreamy denim skirts and jeans with trusty jersey pieces, or snap up an ",
            Slug = "jdy-tall",
        },
        new CatalogBrand
        {
            Id = 315,
            ApiId = 22905,
            Name = "JDY Petite",
            Description = "<strong>JDY Petite</strong> collection here at ASOS is a bit of us, and we think it’ll be a bit of you, too. Mix and match its dreamy denim skirts and jeans with trusty jersey pieces, or snap up a",
            Slug = "jdy-petite",
        },
        new CatalogBrand
        {
            Id = 316,
            ApiId = 131,
            Name = "Converse",
            Description = "The iconic high-top canvas trainer created by <strong>Converse</strong> at the beginning of the 20th Century, have become a genre defining item. They now sit comfortably alongside the label's trai",
            Slug = "converse",
        },
        new CatalogBrand
        {
            Id = 317,
            ApiId = 12279,
            Name = "Gap",
            Description = "",
            Slug = "gap",
        },
        new CatalogBrand
        {
            Id = 318,
            ApiId = 18500,
            Name = "ASOS WEEKEND COLLECTIVE",
            Description = "This is <strong>ASOS WEEKEND COLLECTIVE</strong> – your go-to for all the latest trends, no matter who you are, where you’re from and what you’re up to. Exclusive to ASOS, our universa",
            Slug = "asos-weekend-collective",
        },
        new CatalogBrand
        {
            Id = 319,
            ApiId = 17802,
            Name = "Revolution Hair",
            Description = "Created in 2013 around the founder’s kitchen table,&nbsp;<strong>Revolution Hair</strong>&nbsp;is committed to making vegan makeup and skincare that’s accessible to all. You’l",
            Slug = "revolution-hair",
        },
        new CatalogBrand
        {
            Id = 320,
            ApiId = 13621,
            Name = "Quiksilver",
            Description = "Whether you’re surfin' in the sun, boardin’ in the snow or chillin’ by the campfire, activewear label <strong>Quiksilver</strong> has got all your moods covered. Scroll our Quiksilver a",
            Slug = "quiksilver",
        },
        new CatalogBrand
        {
            Id = 321,
            ApiId = 15700,
            Name = "AFRM",
            Description = "Hailing from sunny Los Angeles, our AFRM at ASOS edit brings California street style straight to your saved list. Short for affirmation (ICYDK), AFRM creates fashion-forward pieces incl. bodycon dresses with lace-up deets for when the club’s calling you",
            Slug = "afrm",
        },
        new CatalogBrand
        {
            Id = 322,
            ApiId = 15831,
            Name = "Twisted Tailor",
            Description = "Switch up your suiting game with <strong>Twisted Tailor</strong>. Taking inspiration from British culture with a nod to punk attitude, the London-based brand is coming through with high-qua",
            Slug = "twisted-tailor",
        },
        new CatalogBrand
        {
            Id = 323,
            ApiId = 15619,
            Name = "Forever New",
            Description = "Founded in Melbourne in 2006 as a start-up retailer, <strong>Forever New</strong> has evolved into one of the fastest-growing brands in Australia, thanks to its range of film and catwalk-ins",
            Slug = "forever-new",
        },
        new CatalogBrand
        {
            Id = 324,
            ApiId = 62059,
            Name = "Daska",
            Description = "ICYDK, dressing modestly doesn’t mean you have to compromise your style creds – DASKA is here to prove it. It’s the bolder the better when it comes to this brand’s jumpsuits and high-neck maxi dresses, ft. block colours and bright prints. Or, for ",
            Slug = "daska",
        },
        new CatalogBrand
        {
            Id = 325,
            ApiId = 16173,
            Name = "Vila Petite",
            Description = "Seeking inspiration from street and city style, Scandi favourite <strong>Vila Petite</strong> combines quality fabrics and delicate cuts to create a collection of fashion-forward pieces. Signature f",
            Slug = "vila-petite",
        },
        new CatalogBrand
        {
            Id = 326,
            ApiId = 21657,
            Name = "Kaiia",
            Description = "Nobody nails elevated basics like British brand Kaiia. From corset tops to cargo trousers, our Kaiia at ASOS edit will take your street style to the next level. Refresh your daywear ‘drobe with co-ord sets and mix-and-match tailoring (hello, cropped bla",
            Slug = "kaiia",
        },
        new CatalogBrand
        {
            Id = 327,
            ApiId = 14251,
            Name = "Ripcurl",
            Description = "Aussie label <strong>Ripcurl</strong> was born in the cold water waves of Bells Beach. Not just for the boys, ... ",
            Slug = "ripcurl",
        },
        new CatalogBrand
        {
            Id = 328,
            ApiId = 16575,
            Name = "AsYou",
            Description = "Serving up new-new trends, emerging brand <strong>AsYou</strong> is a big vibe. Whether you’re off-duty or going out-out, there’s a piece for every mood – from legging shorts and oversized ",
            Slug = "asyou",
        },
        new CatalogBrand
        {
            Id = 329,
            ApiId = 15360,
            Name = "Hunkemoller",
            Description = "Inspired by the most beautiful people in the world, the designers behind <strong>Hunkem&ouml;ller</strong>  take your confidence levels up to a 100 with their range of flirty",
            Slug = "hunkemoller",
        },
        new CatalogBrand
        {
            Id = 330,
            ApiId = 16696,
            Name = "Valentino Bags",
            Description = "Combining luxury aesthetic with traditional touches and cutting-edge design, <strong>Valentino Bags</strong> is on hand to give your carryall line-up a serious upgrade with its latest sel",
            Slug = "valentino-bags",
        },
        new CatalogBrand
        {
            Id = 331,
            ApiId = 15902,
            Name = "SIMMI Shoes",
            Description = "Get ready to go out-out with <strong>SIMMI Shoes</strong>’s offering of the latest footwear and clothing. Created with a trailblazer in mind, the brand’s designs are unapologetically bold – ",
            Slug = "simmi-shoes",
        },
        new CatalogBrand
        {
            Id = 332,
            ApiId = 22505,
            Name = "IIQUAL",
            Description = "",
            Slug = "iiqual",
        },
        new CatalogBrand
        {
            Id = 333,
            ApiId = 20702,
            Name = "Easy Tiger",
            Description = "Be the moment in colour-poppin’ brand Easy Tiger. ICYDK, it’s *the* destination for statement styles that give festival szn meets 70s groove. Get browsing our Easy Tiger at ASOS edit for brightly printed sets complete with bikinis and matching sarongs",
            Slug = "easy-tiger",
        },
        new CatalogBrand
        {
            Id = 334,
            ApiId = 22305,
            Name = "It’s Now Cool",
            Description = "In the mood for a major beachwear moment? Then dip your toe into our It’s Now Cool at ASOS edit. Featuring 90s-inspired swimwear (read: high-cut legs), the label’s offering is bound to up the envy-inducing levels. Scroll bikini tops finished in bold p",
            Slug = "it’s-now-cool",
        },
        new CatalogBrand
        {
            Id = 335,
            ApiId = 16322,
            Name = "Never Fully Dressed Plus",
            Description = "From its humble beginnings at London’s Portobello Road market, <strong>Never Fully Dressed Plus</strong> has grown into a brand known for classic clean lines and flattering silhoue",
            Slug = "never-fully-dressed-plus",
        },
        new CatalogBrand
        {
            Id = 336,
            ApiId = 13942,
            Name = "The Ragged Priest",
            Description = "If standing out from the crowd’s your thing, stand out in <strong>The Ragged Priest</strong>. Designed and made in the UK, the brand’s bold selection of striped, neon and tie-dye d",
            Slug = "the-ragged-priest",
        },
        new CatalogBrand
        {
            Id = 337,
            ApiId = 16269,
            Name = "Cotton:On",
            Description = "",
            Slug = "cotton:on",
        },
        new CatalogBrand
        {
            Id = 338,
            ApiId = 18653,
            Name = "JJXX",
            Description = "Say hello to <strong>JJXX</strong> – newest member of the Jack & Jones fam. Celebrating all things denim, the brand channels 30 years of experience into empowering women with quality essentials f",
            Slug = "jjxx",
        },
        new CatalogBrand
        {
            Id = 339,
            ApiId = 15900,
            Name = "In The Style",
            Description = "Love dressing for yourself and nobody else? <strong>In The Style</strong> is all about empowering women through fashion with its celebrity-inspired range of clothing. If you need an excuse ",
            Slug = "in-the-style",
        },
        new CatalogBrand
        {
            Id = 340,
            ApiId = 13073,
            Name = "Lyle & Scott",
            Description = "The <strong>Lyle & Scott</strong> range balances an old school 80s attitude with preppy styling and laid-back collegiate cool. Sweatshirts and joggers bring a relaxed yet stylish attitu",
            Slug = "lyle-&-scott",
        },
        new CatalogBrand
        {
            Id = 341,
            ApiId = 16191,
            Name = "In The Style Plus",
            Description = "Love dressing for yourself and nobody else? <strong>In The Style Plus</strong> is all about empowering women through fashion with its celebrity-inspired range of clothing. If you need an ex",
            Slug = "in-the-style-plus",
        },
        new CatalogBrand
        {
            Id = 342,
            ApiId = 14164,
            Name = "SikSilk",
            Description = "The guys behind <strong>SikSilk</strong> are obsessed with American, Japanese and Brit street culture. OK, so that’s quite a lot of influences, but it all makes sense when you see it distilled ",
            Slug = "siksilk",
        },
        new CatalogBrand
        {
            Id = 343,
            ApiId = 15828,
            Name = "ONLY Tall",
            Description = "Let’s be honest, we all love a bit of Scandi style. That’s why we’ve put together an edit of Danish high-street brand <strong>ONLY Tall</strong> freshest pieces, including classic denim cuts,",
            Slug = "only-tall",
        },
        new CatalogBrand
        {
            Id = 344,
            ApiId = 15685,
            Name = "Be Mine",
            Description = "Searching for shoes that will take your wedding-day look from aisle-to-dancefloor? <strong>Be Mine</strong> is here to tick one thing off your list, so you can focus on the ‘I do’ instead of",
            Slug = "be-mine",
        },
        new CatalogBrand
        {
            Id = 345,
            ApiId = 13214,
            Name = "Marshall Artist",
            Description = "<strong>Marshall Artist</strong> was founded in 2000 and has fast developed a reputation as being one of the most eclectic and best loved new menswear labels. Known for creating modern, ta",
            Slug = "marshall-artist",
        },
        new CatalogBrand
        {
            Id = 346,
            ApiId = 16650,
            Name = "HUGO Bodywear",
            Description = "If you need an excuse for a wardrobe update, <strong>HUGO Bodywear</strong> is it. Best known for its tailoring finesse, the luxury German fashion brand has your back when it comes to quality de",
            Slug = "hugo-bodywear",
        },
        new CatalogBrand
        {
            Id = 347,
            ApiId = 17650,
            Name = "LUSH",
            Description = "The authority on fresh handmade cosmetics, <strong>LUSH</strong> serves up sweet-smelling hair, body and skincare goodies for your self-care shelf (not that they’ll spend much time on i",
            Slug = "lush",
        },
        new CatalogBrand
        {
            Id = 348,
            ApiId = 13727,
            Name = "Malin + Goetz",
            Description = "",
            Slug = "malin-+-goetz",
        },
        new CatalogBrand
        {
            Id = 349,
            ApiId = 13886,
            Name = "Closet London",
            Description = "Designing and producing a covetable collection of day to night dresses in the heart of London, <strong>Closet London</strong> transcends seasons to bring you fashion-forward pieces that will alwa",
            Slug = "closet-london",
        },
        new CatalogBrand
        {
            Id = 350,
            ApiId = 13644,
            Name = "47 Brand",
            Description = "With a classic history of the American dream come to life, <strong>47 Brand</strong> was founded by twin brothers Arthur and Henry D'Angelo, who arrived in Boston from Italy and witnessed the pas",
            Slug = "47-brand",
        },
        new CatalogBrand
        {
            Id = 351,
            ApiId = 16724,
            Name = "KAYALI",
            Description = "Founded by Mona Kattan, <strong>KAYALI</strong> (Arabic for ‘my imagination’) brings a collection of intoxicating fragrances inspired by her Middle Eastern heritage. The brand’s perfumes ar",
            Slug = "kayali",
        },
        new CatalogBrand
        {
            Id = 352,
            ApiId = 22155,
            Name = "Floral Street",
            Description = "Let your fragrance do the talking with perfume brand Floral Street. Searching for a selection of high-impact aromas that’ll kit out your fragrance ‘drobe? Shop our Floral Street at ASOS edit and expect flower-inspired scents ft. notes of citrus and ea",
            Slug = "floral-street",
        },
        new CatalogBrand
        {
            Id = 353,
            ApiId = 62062,
            Name = "Messy Weekend",
            Description = "Introducing: <strong>Messy Weekend</strong>. Serving sunny essentials to elevate your accessories line-up, shop the brand’s sunglasses and caps that are *giving* sensible-yet-stylish sun",
            Slug = "messy-weekend",
        },
        new CatalogBrand
        {
            Id = 354,
            ApiId = 13652,
            Name = "HUF",
            Description = "<strong>HUF</strong> owner Keith Hufnagel grew up skateboarding in the streets of New York before moving to San Francisco to pursue his passion.  Opening his first store in 2002, ... ",
            Slug = "huf",
        },
        new CatalogBrand
        {
            Id = 355,
            ApiId = 20612,
            Name = "Narciso Rodriguez",
            Description = "ICYDK, Narciso Rodriguez isn’t just a fashion-industry icon, he also creates fragrances that will have your current faves nervous. With perfumes For Him and For Her the brand celebrates masculinity and femininity through its floral and woody scents. Scr",
            Slug = "narciso-rodriguez",
        },
        new CatalogBrand
        {
            Id = 356,
            ApiId = 14379,
            Name = "AAPE BY A BATHING APE®",
            Description = "A BATHING APE launched its brand new diffusion line, <strong>AAPE BY A BATHING APE®</strong> (Aape for short), in 2012 with the aim to create a collection of simple, light clothes for everyday wear.",
            Slug = "aape-by-a-bathing-ape®",
        },
        new CatalogBrand
        {
            Id = 357,
            ApiId = 3008,
            Name = "Billabong",
            Description = "In 1973, <strong>Billabong</strong> founders Gordon and Rena Merchant started crafting and selling board shorts to surf shops on Australia’s Gold Coast. Thanks to the durable, triple-stitchin",
            Slug = "billabong",
        },
        new CatalogBrand
        {
            Id = 358,
            ApiId = 16592,
            Name = "River Island Tall",
            Description = "High-street hero <strong>River Island Tall</strong> covers all bases with its selection of clothing, accessories, swimwear and footwear. Offering everything from standout party dresses and ",
            Slug = "river-island-tall",
        },
        new CatalogBrand
        {
            Id = 359,
            ApiId = 21000,
            Name = "Curlsmith",
            Description = "Give your coils the care they crave with <strong>Curlsmith</strong>. Packed full of superfoods (think almond oil, blackcurrants and mashed avocados), our ... ",
            Slug = "curlsmith",
        },
        new CatalogBrand
        {
            Id = 360,
            ApiId = 16547,
            Name = "Living Proof",
            Description = "",
            Slug = "living-proof",
        },
        new CatalogBrand
        {
            Id = 361,
            ApiId = 21755,
            Name = "ARKIVE",
            Description = "Give your strands some TLC with ARKIVE. Featuring products to care for your head and style those locks, what more could you want? Scroll cleansing shampoos and nourishing conditioners to say goodbye to bad hair days, or filter by hairspray to lock-in your",
            Slug = "arkive",
        },
        new CatalogBrand
        {
            Id = 362,
            ApiId = 2994,
            Name = "ghd",
            Description = "It’s no surprise that <strong>ghd</strong> stands for ‘Good Hair Day’, with its first styler making major waves in the hair-styling scene back in 2001. As an official stockist, our ... ",
            Slug = "ghd",
        },
        new CatalogBrand
        {
            Id = 363,
            ApiId = 18904,
            Name = "Face Halo",
            Description = "Switch to effective, fuss-free makeup removal with <strong>Face Halo</strong>. You won’t need to rub, scrub or use soap thanks to ultra-fine fibres that help trap makeup and reach ",
            Slug = "face-halo",
        },
        new CatalogBrand
        {
            Id = 364,
            ApiId = 14291,
            Name = "Foreo",
            Description = "It’s time to power up your self-care routine – snap up award-winning skincare devices and products from our <strong>Foreo</strong> at ASOS edit. From gentle Micro-Foam cleansers and dee",
            Slug = "foreo",
        },
        new CatalogBrand
        {
            Id = 365,
            ApiId = 15741,
            Name = "Sand & Sky",
            Description = "",
            Slug = "sand-&-sky",
        },
        new CatalogBrand
        {
            Id = 366,
            ApiId = 15919,
            Name = "Estee Lauder",
            Description = "Making its ASOS debut – if we could roll out a red carpet, we would – <strong>Estee Lauder</strong> multi-award-winning skin care and makeup is about to take up all the space ",
            Slug = "estee-lauder",
        },
        new CatalogBrand
        {
            Id = 367,
            ApiId = 15247,
            Name = "The Ordinary",
            Description = "",
            Slug = "the-ordinary",
        },
        new CatalogBrand
        {
            Id = 368,
            ApiId = 16585,
            Name = "Simmi Wide Fit",
            Description = "Get ready to go out-out with <strong>Simmi Wide Fit</strong>’s offering of the latest footwear and clothing. Created with a trailblazer in mind, the brand’s designs are unapologetically bold ",
            Slug = "simmi-wide-fit",
        },
        new CatalogBrand
        {
            Id = 369,
            ApiId = 16114,
            Name = "Revolution Skincare",
            Description = "Created in 2013 around the founder’s kitchen table,&nbsp;<strong>Revolution Skincare</strong>&nbsp;is committed to making vegan makeup and skincare that’s accessible to all. You",
            Slug = "revolution-skincare",
        },
        new CatalogBrand
        {
            Id = 370,
            ApiId = 2955,
            Name = "Spanx",
            Description = "Founded more than 20 years ago by Sara Blakely with nothing but a pair of footless tights, <strong>Spanx</strong> shapewear revolutionised the industry with its body-sculpting collection. Having ga",
            Slug = "spanx",
        },
        new CatalogBrand
        {
            Id = 371,
            ApiId = 13987,
            Name = "Y.A.S",
            Description = "Putting a clean twist on everyday essentials, Danish label <strong>Y.A.S</strong> packs its understated-cool style into dresses, premium leather and tailored pieces. Think minimalist designs paired ",
            Slug = "y.a.s",
        },
        new CatalogBrand
        {
            Id = 372,
            ApiId = 13943,
            Name = "Lavish Alice",
            Description = "<strong>Lavish Alice</strong> represents directional design with a bold signature. Cut to enhance the silhouette and heighten the body, capes, asymmetry, cutaway details and a clean, minima",
            Slug = "lavish-alice",
        },
        new CatalogBrand
        {
            Id = 373,
            ApiId = 16204,
            Name = "Pretty Lavish",
            Description = "Question: what’s timeless, chic and always IG-ready? Our <strong>Pretty Lavish</strong> at ASOS edit, ofc. Shop midi skirts and tops in soft knits and sequin finishes, plus printed dress",
            Slug = "pretty-lavish",
        },
        new CatalogBrand
        {
            Id = 374,
            ApiId = 16710,
            Name = "Simmi Clothing",
            Description = "Get ready to go out-out with <strong>Simmi Clothing</strong>’s offering of the latest footwear and clothing. Created with a trailblazer in mind, the brand’s designs are unapologetically bold ",
            Slug = "simmi-clothing",
        },
        new CatalogBrand
        {
            Id = 375,
            ApiId = 16638,
            Name = "Collective the Label Curve",
            Description = "RSVPd yes but don’t know what to wear yet? Don’t worry, <strong>Collective the Label Curve</strong> has got your back. The dressed-up sister brand of Glamorous, it's big on occa",
            Slug = "collective-the-label-curve",
        },
        new CatalogBrand
        {
            Id = 376,
            ApiId = 16308,
            Name = "Topshop Tall",
            Description = "Introducing <strong>Topshop Tall</strong> at ASOS. Shop our edit to discover our top picks from the London-born brand, including clothes, shoes and accessories. And if you’re just stopping by ",
            Slug = "topshop-tall",
        },
        new CatalogBrand
        {
            Id = 377,
            ApiId = 14304,
            Name = "Vero Moda Petite",
            Description = "Whether you’re after a wardrobe refresh or just a few staples, <strong>Vero Moda Petite</strong> serves big outfit energy. Scroll for your new favourite pair of jeans, available in a variety ",
            Slug = "vero-moda-petite",
        },
        new CatalogBrand
        {
            Id = 378,
            ApiId = 16487,
            Name = "Urban Threads Petite",
            Description = "",
            Slug = "urban-threads-petite",
        },
        new CatalogBrand
        {
            Id = 379,
            ApiId = 15395,
            Name = "Heartbreak",
            Description = "",
            Slug = "heartbreak",
        },
        new CatalogBrand
        {
            Id = 380,
            ApiId = 20611,
            Name = "Night Addict Plus",
            Description = "",
            Slug = "night-addict-plus",
        },
        new CatalogBrand
        {
            Id = 381,
            ApiId = 15910,
            Name = "Influence Maternity",
            Description = "",
            Slug = "influence-maternity",
        },
        new CatalogBrand
        {
            Id = 382,
            ApiId = 14457,
            Name = "Vero Moda Tall",
            Description = "Whether you’re after a wardrobe refresh or just a few staples, <strong>Vero Moda Tall</strong> serves big outfit energy. Scroll for your new favourite pair of jeans, available in a variety of",
            Slug = "vero-moda-tall",
        },
        new CatalogBrand
        {
            Id = 383,
            ApiId = 3606,
            Name = "Whistles",
            Description = "London-based label <strong>Whistles</strong> is a firm ASOS favourite. The brand’s collections pair clean silhouettes with premium fabrics, while relaxed fits keep things chill – think print",
            Slug = "whistles",
        },
        new CatalogBrand
        {
            Id = 384,
            ApiId = 62550,
            Name = "Hugo Red",
            Description = "",
            Slug = "hugo-red",
        },
        new CatalogBrand
        {
            Id = 385,
            ApiId = 12090,
            Name = "BOSS Orange",
            Description = "BOSS offers an authentic and understated wardrobe for the modern man. Crafted from super-soft fabrics, BOSS bodywear, loungewear and accessory collections offer ultimate comfort and enduring style.",
            Slug = "boss-orange",
        },
        new CatalogBrand
        {
            Id = 386,
            ApiId = 3454,
            Name = "Free People",
            Description = "With roots back to the ‘70s, the <strong>Free People</strong> girl lives through art, fashion, music and wanderlust. She’s feminine in spirit and Bohemian in attitude. From sweet to tough",
            Slug = "free-people",
        },
        new CatalogBrand
        {
            Id = 387,
            ApiId = 443,
            Name = "Marc Jacobs",
            Description = "After graduating from Parsons School of Design, <strong>Marc Jacobs</strong> founded his eponymous label in 1984. Loved for his retro-inspired cool, it has since become a go-t",
            Slug = "marc-jacobs",
        },
        new CatalogBrand
        {
            Id = 388,
            ApiId = 15224,
            Name = "Dermalogica",
            Description = "A brand that’s all about healthy and happy skin, <strong>Dermalogica</strong> is used by skin therapists all over the world. Offering professional-grade products, the brand achie",
            Slug = "dermalogica",
        },
        new CatalogBrand
        {
            Id = 389,
            ApiId = 21169,
            Name = "Dr Denim Plus",
            Description = "Founded by the Graah family in 2004, iconic Swedish brand <strong>Dr Denim Plus</strong> are famed for their skinny jeans and simple Scandinavian styling. Branching out with a collection of jers",
            Slug = "dr-denim-plus",
        },
        new CatalogBrand
        {
            Id = 390,
            ApiId = 15739,
            Name = "Barber Pro",
            Description = "Formulating a range of sheet masks developed specifically for men, <strong>Barber Pro</strong> gives your razor-and-face-cream regime a serious overhaul. The brand’s peel-off putty and foamin",
            Slug = "barber-pro",
        },
        new CatalogBrand
        {
            Id = 391,
            ApiId = 22355,
            Name = "Dsquared",
            Description = "",
            Slug = "dsquared",
        },
        new CatalogBrand
        {
            Id = 392,
            ApiId = 22757,
            Name = "Petit Moments",
            Description = "Attention accessory lovers, Petit Moments has landed. Featuring trend-led designs to make any jewellery box jealous, the label’s offering will sit pride of place in your ‘fit. Scroll crush-worthy necklaces in a range of tones – or shop hoop and drop",
            Slug = "petit-moments",
        },
        new CatalogBrand
        {
            Id = 393,
            ApiId = 16683,
            Name = "Extro & Vert",
            Description = "Dreaming of an effortlessly chic capsule wardrobe? Extro & Vert has got you covered. Specialising in modern tailoring, the brand serves up minimal designs with maximum impact. Expect oversized blazers and relaxed trousers, or mix-and-match with polished s",
            Slug = "extro-&-vert",
        },
        new CatalogBrand
        {
            Id = 394,
            ApiId = 16144,
            Name = "ONLY Curve",
            Description = "Let’s be honest, we all love a bit of Scandi style. That’s why we’ve put together an edit of Danish high-street brand <strong>ONLY Curve</strong> freshest pieces, including classic denim cuts",
            Slug = "only-curve",
        },
        new CatalogBrand
        {
            Id = 395,
            ApiId = 22657,
            Name = "Whistles Petite",
            Description = "London-based label <strong>Whistles Petite</strong> is a firm ASOS favourite. The brand’s collections pair clean silhouettes with premium fabrics, while relaxed fits keep things chill – thin",
            Slug = "whistles-petite",
        },
        new CatalogBrand
        {
            Id = 396,
            ApiId = 16307,
            Name = "Topshop Petite",
            Description = "Introducing <strong>Topshop Petite</strong> at ASOS. Shop our edit to discover our top picks from the London-born brand, including clothes, shoes and accessories. And if you’re just stopping b",
            Slug = "topshop-petite",
        },
        new CatalogBrand
        {
            Id = 397,
            ApiId = 16394,
            Name = "I Saw It First",
            Description = "Give your wardrobe that main-feed treatment with <strong>I Saw It First</strong>. Scroll the brand’s range of bodycon party dresses, faux-leather trousers and embellished tops for the u",
            Slug = "i-saw-it-first",
        },
        new CatalogBrand
        {
            Id = 398,
            ApiId = 479,
            Name = "Morgan",
            Description = "Founded in 1968 by sisters Jocelyn Bismuth and Odette Barouch, French label <strong>Morgan</strong> opened its first store in Paris’ 6th arrondissement. Known for its ready-to-wear collections, ",
            Slug = "morgan",
        },
        new CatalogBrand
        {
            Id = 399,
            ApiId = 14230,
            Name = "Uppercut Deluxe",
            Description = "The Aussie boys behind <strong>Uppercut Deluxe</strong> are such big fans of the traditional barber experience they decided to create their own at home. So that’s a complete range of hai",
            Slug = "uppercut-deluxe",
        },
        new CatalogBrand
        {
            Id = 400,
            ApiId = 3352,
            Name = "Clarks Originals",
            Description = "Reviving and replicating footwear legends, <strong>Clarks Originals</strong> laid-back shoes and boots look to authenticity and individuality. Desert boots, wallabee shoes and hiking boots",
            Slug = "clarks-originals",
        },
        new CatalogBrand
        {
            Id = 401,
            ApiId = 13579,
            Name = "AJ Morgan",
            Description = "Creating a snappy range of fashion eyewear and sunglasses, American label <strong>AJ Morgan</strong> has seen its lenses appear in cult films and television series such as, Demolition Man, Bev",
            Slug = "aj-morgan",
        },
        new CatalogBrand
        {
            Id = 402,
            ApiId = 673,
            Name = "Spitfire",
            Description = "London-based label <strong> Spitfire</strong>  has garnered a cult following with its cutting-edge eyewear, featuring imaginative style details such as removable UV l",
            Slug = "spitfire",
        },
        new CatalogBrand
        {
            Id = 403,
            ApiId = 16434,
            Name = "Labelrail",
            Description = "",
            Slug = "labelrail",
        },
        new CatalogBrand
        {
            Id = 404,
            ApiId = 12456,
            Name = "Pretty Green",
            Description = "Founded in 2009 by Liam Gallagher, <strong>Pretty Green</strong> has a deep understanding of British street culture. Named after a track by The Jam, it unites music and fashion, giving simple,",
            Slug = "pretty-green",
        },
        new CatalogBrand
        {
            Id = 405,
            ApiId = 15488,
            Name = "Calvin Klein Golf",
            Description = "Launching a line of golf clothing and accessories, <strong>Calvin Klein Golf</strong> brings its modern-minimalist aesthetic to the fairways. Whatever the weather, get your gear up to par with",
            Slug = "calvin-klein-golf",
        },
        new CatalogBrand
        {
            Id = 406,
            ApiId = 17952,
            Name = "Pieces Plus",
            Description = "With its Scandinavian roots and minimalist styling, <strong>Pieces Plus</strong> is your go-to label for everyday essentials. From clothing and footwear to jewellery and accessories, the brand tie",
            Slug = "pieces-plus",
        },
        new CatalogBrand
        {
            Id = 407,
            ApiId = 62400,
            Name = "Milk Makeup",
            Description = "",
            Slug = "milk-makeup",
        },
        new CatalogBrand
        {
            Id = 408,
            ApiId = 3498,
            Name = "Benefit",
            Description = "In 1976, sisters Jean and Jane Ford flipped a coin – heads they opened a deli, tails they opened a makeup store. It landed on tails, so they set up shop in San Francisco and launched whimsical cosmetics brand ... ",
            Slug = "benefit",
        },
        new CatalogBrand
        {
            Id = 409,
            ApiId = 15020,
            Name = "Kitsch",
            Description = "Specialising in all things you didn’t know you wanted, accessory brand <strong>Kitsch</strong> designs everything from hair accessories to sleep aids and skincare tools. Stock up on hair bits l",
            Slug = "kitsch",
        },
        new CatalogBrand
        {
            Id = 410,
            ApiId = 17900,
            Name = "Urban Classics",
            Description = "Say hello to streetwear brand <strong>Urban Classics</strong>. The label is home to a collection of no effort, effort makers perfect for those laid-back moods. Start from the bottom with trouse",
            Slug = "urban-classics",
        },
        new CatalogBrand
        {
            Id = 411,
            ApiId = 14821,
            Name = "Hope & Ivy",
            Description = "Prom queens and wedding guests, claim the best-dressed title in <strong>Hope & Ivy</strong> occasion-ready collection. Shop its notice-me styles for hand-painted florals, Bardot necklines a",
            Slug = "hope-&-ivy",
        },
        new CatalogBrand
        {
            Id = 412,
            ApiId = 15672,
            Name = "BOSS Athleisure",
            Description = "With a focus on quality craftsmanship and impeccable design, the <strong>BOSS Athleisure</strong> collection offers a premium range of tailoring, athleisure and refined casualwear. Expect tailored se",
            Slug = "boss-athleisure",
        },
        new CatalogBrand
        {
            Id = 413,
            ApiId = 13991,
            Name = "JDY",
            Description = "<strong>JDY</strong> collection here at ASOS is a bit of us, and we think it’ll be a bit of you, too. Mix and match its dreamy denim skirts and jeans with trusty jersey pieces, or snap up an entir",
            Slug = "jdy",
        },
        new CatalogBrand
        {
            Id = 414,
            ApiId = 202,
            Name = "Fila",
            Description = "Founded in 1911 by brothers in Biella, Italy, <strong>Fila</strong> packs more than 100 years of heritage into its collections. Championed throughout the 80s before becoming streetwear history, its",
            Slug = "fila",
        },
        new CatalogBrand
        {
            Id = 415,
            ApiId = 12092,
            Name = "BOSS Green",
            Description = "<strong>BOSS Orange</strong> is the laid-back, easy-going side of HUGO BOSS. Fusing craft with signature design, ... ",
            Slug = "boss-green",
        },
        new CatalogBrand
        {
            Id = 416,
            ApiId = 14564,
            Name = "Object",
            Description = "<strong>Object</strong> is one of those clothing brands that everyone can get in on. Its mixture of boho styles and minimal designs serve up that casual-cool vibe we all know and love. Think pret",
            Slug = "object",
        },
        new CatalogBrand
        {
            Id = 417,
            ApiId = 15000,
            Name = "Von Dutch",
            Description = "Branded ‘the Godfather of modern day pinstriping’, <strong>Von Dutch</strong>, AKA Kenneth Howard, first started out blasting motorbikes and cars with iconic Americana imagery. Fast forward ",
            Slug = "von-dutch",
        },
        new CatalogBrand
        {
            Id = 418,
            ApiId = 16506,
            Name = "Charlotte Tilbury",
            Description = "<strong>Charlotte Tilbury</strong> is a pretty huge deal. With over 27 years’ experience in the beauty industry (major), the world-famous British makeup artist’s namesake",
            Slug = "charlotte-tilbury",
        },
        new CatalogBrand
        {
            Id = 419,
            ApiId = 15973,
            Name = "Dr.Jart+",
            Description = "Combining the latest in Korean skincare technology, <strong>Dr.Jart+</strong> is all about results-driven products that work hard for different skin needs. Browse the brand’s cleanse",
            Slug = "dr.jart+",
        },
        new CatalogBrand
        {
            Id = 420,
            ApiId = 20201,
            Name = "The Frolic",
            Description = "With timeless collections that are easy-to-wear *and* focused on personal style, we’re saying <strong>The Frolic</strong> FTW – and we mean it. The Aussie boutique stocks a range of top-tier st",
            Slug = "the-frolic",
        },
        new CatalogBrand
        {
            Id = 421,
            ApiId = 16525,
            Name = "Annorlunda",
            Description = "Minimalism just got an update with Scandi clothing brand <strong>Annorlunda</strong>. Serving up a fresh slice of street-style inspiration, the brand’s collections are all about staple piec",
            Slug = "annorlunda",
        },
        new CatalogBrand
        {
            Id = 422,
            ApiId = 20300,
            Name = "Threadbare Plus Fitness",
            Description = "",
            Slug = "threadbare-plus-fitness",
        },
        new CatalogBrand
        {
            Id = 423,
            ApiId = 16097,
            Name = "Collective The Label",
            Description = "RSVPd yes but don’t know what to wear yet? Don’t worry, <strong>Collective The Label</strong> has got your back. The dressed-up sister brand of Glamorous, it's big on occasionwe",
            Slug = "collective-the-label",
        },
        new CatalogBrand
        {
            Id = 424,
            ApiId = 62058,
            Name = "Girls Crew",
            Description = "PSA: we’ve got your statement styles sorted all thanks to LA jewellery brand <strong>Girls Crew</strong>. It’s got creativity on lock with necklaces, rings and anklets that’ll add a lil",
            Slug = "girls-crew",
        },
        new CatalogBrand
        {
            Id = 425,
            ApiId = 17857,
            Name = "Mario Badescu",
            Description = "",
            Slug = "mario-badescu",
        },
        new CatalogBrand
        {
            Id = 426,
            ApiId = 16412,
            Name = "Collective The Label Petite",
            Description = "RSVPd yes but don’t know what to wear yet? Don’t worry, <strong>Collective The Label Petite</strong> has got your back. The dressed-up sister brand of Glamorous, it's big on occ",
            Slug = "collective-the-label-petite",
        },
        new CatalogBrand
        {
            Id = 427,
            ApiId = 15668,
            Name = "Le Mini Macaron",
            Description = "Bringing you longer-lasting, glossier manicures, <strong>Le Mini Macaron</strong> takes your nail game up a notch with its gel-manicure kits. Designed to look like the sugary-sweet treat",
            Slug = "le-mini-macaron",
        },
        new CatalogBrand
        {
            Id = 428,
            ApiId = 14730,
            Name = "Noak",
            Description = "",
            Slug = "noak",
        },
        new CatalogBrand
        {
            Id = 429,
            ApiId = 13891,
            Name = "South Beach",
            Description = "Whatever your plans, <strong>South Beach</strong> have the ‘fits. After a beach-day look that delivers from head-to-toe? Scroll the brand’s hats, sunglasses and sandals – perfect for p",
            Slug = "south-beach",
        },
        new CatalogBrand
        {
            Id = 430,
            ApiId = 15921,
            Name = "Barbour Beacon",
            Description = "With a rich heritage dating back to 1894, quintessentially British brand, <strong>Barbour Beacon</strong> have garnered a reputation for quality and durability, across their collection of high per",
            Slug = "barbour-beacon",
        },
        new CatalogBrand
        {
            Id = 431,
            ApiId = 274,
            Name = "Havaianas",
            Description = "Born in 1962, Brazilian label <strong>Havaianas</strong> are famed for their world renowned flip flops. Representing Brazilian values of simplicity, optimism, energy and colour, ... ",
            Slug = "havaianas",
        },
        new CatalogBrand
        {
            Id = 432,
            ApiId = 16530,
            Name = "Esmée",
            Description = "After some new beachwear for your next trip? <strong>Esmée</strong> has a range of relaxed options for when it’s extra hot. For something to throw on over your bikini, browse the brand’s mini ",
            Slug = "esmée",
        },
        new CatalogBrand
        {
            Id = 433,
            ApiId = 16243,
            Name = "Viggo",
            Description = "Fix up and look sharp with <strong>Viggo</strong> range of standout formalwear. Taking a bolder stance on Scandi style, the brand creates a range of modern, refreshing and bright tailoring for your ",
            Slug = "viggo",
        },
        new CatalogBrand
        {
            Id = 434,
            ApiId = 14139,
            Name = "Moon Boot",
            Description = "With Neil Armstrong et al. in mind, Giancarlo Zanatta launched his lunar-inspired footwear label, <strong>Moon Boot</strong>, in the 70s – taking one giant leap for winter footwear. Turning",
            Slug = "moon-boot",
        },
        new CatalogBrand
        {
            Id = 435,
            ApiId = 62412,
            Name = "Drybar",
            Description = "Show your locks some love with our <strong>Drybar</strong> at ASOS edit. Ft. haircare heroes to bless your blow-dry, the brand has just the stuff to style your strands. Shop hair tools",
            Slug = "drybar",
        },
        new CatalogBrand
        {
            Id = 436,
            ApiId = 62406,
            Name = "Kylie Cosmetics by Kylie Jenner",
            Description = "Launching in 2015 with her i-c-o-n-i-c lip kits, makeup mogul and insta royalty Kylie Jenner knows a thing or two about the makeup game. With a Jenner-ous range of products to choose from, scroll our ... ",
            Slug = "kylie-cosmetics-by-kylie-jenner",
        },
        new CatalogBrand
        {
            Id = 437,
            ApiId = 21857,
            Name = "Neutrogena",
            Description = "POV: You’ve found Neutrogena and are never going back. Whether it’s a *major* self-care shelf restock or a daily product upgrade, browse our <strong>Neutrogena</strong> at ASOS ",
            Slug = "neutrogena",
        },
        new CatalogBrand
        {
            Id = 438,
            ApiId = 16636,
            Name = "Threadbare Maternity",
            Description = "",
            Slug = "threadbare-maternity",
        },
        new CatalogBrand
        {
            Id = 439,
            ApiId = 14345,
            Name = "Bardot",
            Description = "With one eye firmly on the catwalk <strong>Bardot</strong> owns the latest trends. Soaked in Aussie sunshine, these guys crop it like it’s hot in camis and printed bralets, scuba skater skirts ",
            Slug = "bardot",
        },
        new CatalogBrand
        {
            Id = 440,
            ApiId = 17852,
            Name = "In The Style Petite",
            Description = "Love dressing for yourself and nobody else? <strong>In The Style Petite</strong> is all about empowering women through fashion with its celebrity-inspired range of clothing. If you need an ",
            Slug = "in-the-style-petite",
        },
        new CatalogBrand
        {
            Id = 441,
            ApiId = 17858,
            Name = "In The Style Tall",
            Description = "Love dressing for yourself and nobody else? <strong>In The Style Tall</strong> is all about empowering women through fashion with its celebrity-inspired range of clothing. If you need an ex",
            Slug = "in-the-style-tall",
        },
        new CatalogBrand
        {
            Id = 442,
            ApiId = 62051,
            Name = "Circus NY",
            Description = "We’re falling head over heels for our Circus NY at ASOS edit. Featuring a range of trend-led and bold designs, we’re finding the brand hard to scroll past TBH. Shop mules when you want to slip-in to style – or browse the label’s collection of chun",
            Slug = "circus-ny",
        },
        new CatalogBrand
        {
            Id = 443,
            ApiId = 22706,
            Name = "Good News",
            Description = "",
            Slug = "good-news",
        },
        new CatalogBrand
        {
            Id = 444,
            ApiId = 16016,
            Name = "Anaya",
            Description = "Brides-to-be, assemble – <strong>Anaya</strong> has officially joined our ranks. The sister brand of occasionwear label Maya, its pastel-toned collection of tulle maxi dresses and co-o",
            Slug = "anaya",
        },
        new CatalogBrand
        {
            Id = 445,
            ApiId = 16007,
            Name = "Candypants",
            Description = "The people behind Candypants have turned their attention from throwing the hottest parties in town (we know, best job ever, right?) to ticking off everything you’ll need to make waves on your next sea-and-sand adventure. From swimsuits to bikinis, cover",
            Slug = "candypants",
        },
        new CatalogBrand
        {
            Id = 446,
            ApiId = 16587,
            Name = "Anaya Tall",
            Description = "",
            Slug = "anaya-tall",
        },
        new CatalogBrand
        {
            Id = 447,
            ApiId = 21150,
            Name = "Closet London Tall",
            Description = "",
            Slug = "closet-london-tall",
        },
        new CatalogBrand
        {
            Id = 448,
            ApiId = 16400,
            Name = "Anaya Petite",
            Description = "Brides-to-be, assemble – <strong>Anaya Petite</strong> has officially joined our ranks. The sister brand of occasionwear label Maya, its pastel-toned collection of tulle maxi dresses a",
            Slug = "anaya-petite",
        },
        new CatalogBrand
        {
            Id = 449,
            ApiId = 20502,
            Name = "Naked Wardrobe",
            Description = "Designed for the bold, the glam and the fashion-forward, look to Naked Wardrobe for pieces that are so good you’ll want to gatekeep. With bodycon, the vibe running through our Naked Wardrobe at ASOS edit, expect sleek mini and midi dresses in slinky fab",
            Slug = "naked-wardrobe",
        },
        new CatalogBrand
        {
            Id = 450,
            ApiId = 14688,
            Name = "Babyliss",
            Description = "Here to make light work of your mane, <strong>Babyliss</strong> has been leading the hair game for more than 50 years. With tools designed for all hair types, it’s never been easier to",
            Slug = "babyliss",
        },
        new CatalogBrand
        {
            Id = 451,
            ApiId = 14041,
            Name = "Classics 77",
            Description = "Surf at daybreak and skate ‘til sunset? Then you’ll be into accessories brand <strong>Classics 77</strong>, who take their inspiration from the continued search for freedom and the dream o",
            Slug = "classics-77",
        },
        new CatalogBrand
        {
            Id = 452,
            ApiId = 16565,
            Name = "ASOS Dark Future",
            Description = "Fresh on the streetwear scene, London-based label <strong>ASOS Dark Future</strong> brings a hint of minimalism to its collection of relaxed urban staples. With a considered colour palett",
            Slug = "asos-dark-future",
        },
        new CatalogBrand
        {
            Id = 453,
            ApiId = 19952,
            Name = "COSRX",
            Description = "Say goodbye to skincare worries and hello to your new fave K-beauty brand <strong>COSRX</strong>. All about simplicity, the label uses minimal yet effective ingredients to serve all skin",
            Slug = "cosrx",
        },
        new CatalogBrand
        {
            Id = 454,
            ApiId = 15295,
            Name = "frank body",
            Description = "<strong>Frank Body's</strong> Australian made and owned, coffee-based skincare range rubs you the right way, targeting problematic skin conditions and damaging free radicals. Made from n",
            Slug = "frank-body",
        },
        new CatalogBrand
        {
            Id = 455,
            ApiId = 15957,
            Name = "Shay & Blue",
            Description = "Well, this is exciting. We’ve teamed up with award-winning London perfumery <strong>Shay & Blue</strong> and put together an edit of its dreamy, unisex fragrances, including a ",
            Slug = "shay-&-blue",
        },
        new CatalogBrand
        {
            Id = 456,
            ApiId = 3018,
            Name = "Rimmel London",
            Description = "<strong>Rimmel London</strong> has been re-writing the rules of makeup since 1834, helping you express yourself however you choose. Founded by Eugène Rimmel – aka, the man who practical",
            Slug = "rimmel-london",
        },
        new CatalogBrand
        {
            Id = 457,
            ApiId = 13852,
            Name = "Chelsea Peers",
            Description = "New York label <strong>Chelsea Peers</strong> brings us a brilliant range of our latest loungewear obsession- onesies. All-American with a prep-inspired look, ... ",
            Slug = "chelsea-peers",
        },
        new CatalogBrand
        {
            Id = 458,
            ApiId = 15753,
            Name = "Raid Wide Fit",
            Description = "Footwear brand <strong>Raid Wide Fit</strong> loves shoes so much that its collection covers every style you could think of — and for that, we're eternally grateful. Expect classic Chelsea boots,",
            Slug = "raid-wide-fit",
        },
        new CatalogBrand
        {
            Id = 459,
            ApiId = 21350,
            Name = "Coola",
            Description = "",
            Slug = "coola",
        },
        new CatalogBrand
        {
            Id = 460,
            ApiId = 23105,
            Name = "Six Stories",
            Description = "POV: you’re on the journey from being newly engaged to newlywed and <strong>Six Stories</strong> is your wedding BFF. Expect dreamy bridesmaid dresses for your besties and pyjamas that’l",
            Slug = "six-stories",
        },
        new CatalogBrand
        {
            Id = 461,
            ApiId = 18250,
            Name = "WetBrush",
            Description = "Warning: this is a knot-free zone. Swerve the stress of messy hair and cop yourself a top-drawer detangler from hair-care brand <strong>WetBrush</strong>. Bringing tangle-free tresses",
            Slug = "wetbrush",
        },
        new CatalogBrand
        {
            Id = 462,
            ApiId = 15390,
            Name = "OUAI",
            Description = "<strong>OUAI</strong> believes that good hair starts from within. Thanks to its MD-formulated supplements restoring hair health from the inside, and shampoos, conditioners and styling products that nouri",
            Slug = "ouai",
        },
        new CatalogBrand
        {
            Id = 463,
            ApiId = 20600,
            Name = "Topshop Curve",
            Description = "Introducing <strong>Topshop Curve</strong> at ASOS. Shop our edit to discover our top picks from the London-born brand, including clothes, shoes and accessories. And if you’re just stopping by",
            Slug = "topshop-curve",
        },
        new CatalogBrand
        {
            Id = 464,
            ApiId = 15010,
            Name = "Office",
            Description = "",
            Slug = "office",
        },
        new CatalogBrand
        {
            Id = 465,
            ApiId = 66,
            Name = "Barry M",
            Description = "Born in the 80s,&nbsp;<strong>Barry M</strong>&nbsp;has been a leader in&nbsp;the&nbsp;bold-makeup&nbsp;scene&nbsp;since the start.&nbsp;From market stall to mainstream, the brand’s made the m",
            Slug = "barry-m",
        },
        new CatalogBrand
        {
            Id = 466,
            ApiId = 14884,
            Name = "NYX Professional Makeup",
            Description = "Named after the Greek goddess who ruled the night, <strong>NYX Professional Makeup</strong> combines beauty and power. Rich pigments, long-lasting formulas and a fun approach to colour help y",
            Slug = "nyx-professional-makeup",
        },
        new CatalogBrand
        {
            Id = 467,
            ApiId = 16719,
            Name = "Huda Beauty",
            Description = "",
            Slug = "huda-beauty",
        },
        new CatalogBrand
        {
            Id = 468,
            ApiId = 16498,
            Name = "Beauty Works",
            Description = "Creating simple and effective solutions for all hair types, discover <strong>Beauty Works</strong> range of products and tools, designed to help style, protect and restore your lo",
            Slug = "beauty-works",
        },
        new CatalogBrand
        {
            Id = 469,
            ApiId = 18800,
            Name = "Kristin Ess",
            Description = "Founded by *the* expert in ‘perfectly imperfect’ hair, <strong>Kristin Ess</strong> is big on products that protect your strands from the inside out. Manage your mane with",
            Slug = "kristin-ess",
        },
        new CatalogBrand
        {
            Id = 470,
            ApiId = 13844,
            Name = "New Look Plus",
            Description = "Since setting up shop in the 60s, <strong>New Look Plus</strong> has become a high-street classic known for creating universally loved, wardrobe-ready collections. Shop the ... ",
            Slug = "new-look-plus",
        },
        new CatalogBrand
        {
            Id = 471,
            ApiId = 16391,
            Name = "Femme Luxe",
            Description = "Founded in 2017, <strong>Femme Luxe</strong> is big on bold, fresh fashion. Based in Manchester, the brand’s trend-led range brings glitter, glamour and standout styling to your wardrobe ",
            Slug = "femme-luxe",
        },
        new CatalogBrand
        {
            Id = 472,
            ApiId = 16443,
            Name = "Noisy May Curve",
            Description = "Bringing relaxed, trend-led vibes to your everyday ‘fits, <strong>Noisy May Curve</strong> is your go-to label for fashion-forward denim and wardrobe staples. Get on board with authentic, ra",
            Slug = "noisy-may-curve",
        },
        new CatalogBrand
        {
            Id = 473,
            ApiId = 16634,
            Name = "Vila Curve",
            Description = "Seeking inspiration from street and city style, Danish label <strong>Vila Curve</strong> combine quality fabrics, textures and delicate cuts to create fashion-forward garments. Intricate feminine de",
            Slug = "vila-curve",
        },
        new CatalogBrand
        {
            Id = 474,
            ApiId = 16232,
            Name = "Shiseido",
            Description = "One of the oldest cosmetics companies in the world, <strong>Shiseido</strong> boasts over 145 years of Japanese beauty experience. Skip to the best bits with our ... ",
            Slug = "shiseido",
        },
        new CatalogBrand
        {
            Id = 475,
            ApiId = 16537,
            Name = "Threadbare Tall",
            Description = "",
            Slug = "threadbare-tall",
        },
        new CatalogBrand
        {
            Id = 476,
            ApiId = 15169,
            Name = "ASOS MADE IN",
            Description = "",
            Slug = "asos-made-in",
        },
        new CatalogBrand
        {
            Id = 477,
            ApiId = 16047,
            Name = "Tommy Hilfiger Sport",
            Description = "Founded in 1985, all-American brand <strong>Tommy Hilfiger Sport</strong> is best known for its preppy vibe and iconic red, white and blue logo. Branching out, the brand has stepped up it",
            Slug = "tommy-hilfiger-sport",
        },
        new CatalogBrand
        {
            Id = 478,
            ApiId = 16470,
            Name = "I Heart Revolution",
            Description = "Created in 2013 around the founder’s kitchen table, <strong>I Heart Revolution</strong> is committed to making makeup and skincare that’s accessible to all. You’ll have to be ",
            Slug = "i-heart-revolution",
        },
        new CatalogBrand
        {
            Id = 479,
            ApiId = 16398,
            Name = "Anaya Plus",
            Description = "Brides-to-be, assemble – <strong>Anaya Plus</strong> has officially joined our ranks. The sister brand of occasionwear label Maya, its pastel-toned collection of tulle maxi dresses and",
            Slug = "anaya-plus",
        },
        new CatalogBrand
        {
            Id = 480,
            ApiId = 259,
            Name = "Guess",
            Description = "Founded in 1981 by the Marciano brothers, <strong>Guess</strong> started out redefining denim with a selection of slim-fit stonewash jeans before adding watches and footwear to its range. Guess Conne",
            Slug = "guess",
        },
        new CatalogBrand
        {
            Id = 481,
            ApiId = 18052,
            Name = "Madewell",
            Description = "<strong>Madewell</strong> stylosophy? All good days start with great jeans. Best known for its top-tier timeless denim, the all-American clothing brand is big on the classics. Our ... ",
            Slug = "madewell",
        },
        new CatalogBrand
        {
            Id = 482,
            ApiId = 16553,
            Name = "Cetaphil",
            Description = "",
            Slug = "cetaphil",
        },
        new CatalogBrand
        {
            Id = 483,
            ApiId = 16128,
            Name = "New Girl Order Curve",
            Description = "Whatever the occasion, <strong>New Girl Order</strong> specialises in all things bold and daring with its personality-packed collection. We&rsquo;ve pulled together some of our favourite ",
            Slug = "new-girl-order-curve",
        },
        new CatalogBrand
        {
            Id = 484,
            ApiId = 17951,
            Name = "Pieces Petite",
            Description = "With its Scandinavian roots and minimalist styling, <strong>Pieces Petite</strong> is your go-to label for everyday essentials. From clothing and footwear to jewellery and accessories, the brand t",
            Slug = "pieces-petite",
        },
        new CatalogBrand
        {
            Id = 485,
            ApiId = 15145,
            Name = "Raid",
            Description = "Footwear brand <strong>Raid</strong> loves shoes so much that its collection covers every style you could think of — and for that, we're eternally grateful. Expect classic Chelsea boots, slick lo",
            Slug = "raid",
        },
        new CatalogBrand
        {
            Id = 486,
            ApiId = 21557,
            Name = "Coney Island Picnic",
            Description = "ICYMI, Coney Island Picnic is here to supply your casj line up with some fresh ‘fits. Its designers take inspo from vintage athletics and future ideologies to create garms that’ll level up your low-key looks. Expect T-shirts, hoodies and sweatshirts t",
            Slug = "coney-island-picnic",
        },
        new CatalogBrand
        {
            Id = 487,
            ApiId = 3192,
            Name = "this works",
            Description = "Brit brand <strong>this works</strong> knows that your skin goes through a lot. Formulated with a ‘Superblend’ of natural ingredients, its award-winning range of products work with",
            Slug = "this-works",
        },
        new CatalogBrand
        {
            Id = 488,
            ApiId = 3212,
            Name = "Superga",
            Description = "Italy really is home to a few of our favourite things – pizza, pasta and, of course, <strong>Superga</strong>. More than 100 years old, the brand gives its classic creps a fresh-as update with ",
            Slug = "superga",
        },
        new CatalogBrand
        {
            Id = 489,
            ApiId = 13685,
            Name = "Protest",
            Description = "PSA: elevating your slope style couldn’t be easier with clothing brand <strong>Protest</strong>. Dutch-founded, the label serves up cold-weather gear to keep your ‘fit looking sub-zero – in ",
            Slug = "protest",
        },
        new CatalogBrand
        {
            Id = 490,
            ApiId = 17,
            Name = "adidas",
            Description = "<strong>adidas</strong> needs no introduction. The brand’s famous 3-Stripes can be seen on the track, field and in the latest streetwear trends. Scroll the ... ",
            Slug = "adidas",
        },
        new CatalogBrand
        {
            Id = 491,
            ApiId = 21559,
            Name = "Bye Bra",
            Description = "Here’s the sitch: you found the perfect ‘fit, but forgot the all-important base layer. Enter, Bye Bra. Serving shapewear and underwear in a wide range of sizes and skin tones, our Bye Bra at ASOS edit has a solution for every occasion. We’re talking",
            Slug = "bye-bra",
        },
        new CatalogBrand
        {
            Id = 492,
            ApiId = 20500,
            Name = "Chelsea Peers Tall",
            Description = "",
            Slug = "chelsea-peers-tall",
        },
        new CatalogBrand
        {
            Id = 493,
            ApiId = 20454,
            Name = "Chelsea Peers Petite",
            Description = "",
            Slug = "chelsea-peers-petite",
        },
        new CatalogBrand
        {
            Id = 494,
            ApiId = 14544,
            Name = "Dr Paw Paw",
            Description = "Bringing pawpaw to British shores, <strong>Dr. PAWPAW</strong> unveil their multi-use balm that&rsquo;s packed with effective natural ingredients &ndash; think fermente",
            Slug = "dr-paw-paw",
        },
        new CatalogBrand
        {
            Id = 495,
            ApiId = 3190,
            Name = "Pixi",
            Description = "Trading on its ethos of natural beauty, <strong>Pixi</strong> makeup and skin-care line combines innovative formulas with skin-loving properties. With over 20 years in the cosmetics industry, makeu",
            Slug = "pixi",
        },
        new CatalogBrand
        {
            Id = 496,
            ApiId = 20501,
            Name = "Vero Moda Maternity",
            Description = "Whether you’re after a wardrobe refresh or just a few staples,&nbsp;<strong>Vero Moda Maternity</strong>&nbsp;serves big outfit energy. Scroll for your new favourite pair of jeans, available ",
            Slug = "vero-moda-maternity",
        },
        new CatalogBrand
        {
            Id = 497,
            ApiId = 625,
            Name = "Rocketdog",
            Description = "",
            Slug = "rocketdog",
        },
        new CatalogBrand
        {
            Id = 498,
            ApiId = 15214,
            Name = "Vesper Tall",
            Description = "Hot new label <strong>Vesper Tall</strong> gives you a serious fashion fix with their collection of figure sculpting dresses. Cut from luxe, super stretch fabrics, each dress is designed to flatt",
            Slug = "vesper-tall",
        },
        new CatalogBrand
        {
            Id = 499,
            ApiId = 16486,
            Name = "Zemeta",
            Description = "Based in Brooklyn, New York, <strong>Zemeta</strong> draws inspiration from its diverse doorstep to bring us the latest streetwear clothing. With a focus on asymmetric cuts, textured fabrics and ",
            Slug = "zemeta",
        },
        new CatalogBrand
        {
            Id = 500,
            ApiId = 16557,
            Name = "DesignB London Curve",
            Description = "<strong>DesignB London Curve</strong> is the perfect pairing of quality and design. This London label creates major everyday vibes with its collection of faux-suede chokers, silver and gold jewe",
            Slug = "designb-london-curve",
        },
        new CatalogBrand
        {
            Id = 501,
            ApiId = 17953,
            Name = "Bolongaro Trevor Sport",
            Description = "",
            Slug = "bolongaro-trevor-sport",
        },
        new CatalogBrand
        {
            Id = 502,
            ApiId = 110,
            Name = "Casio",
            Description = "When it comes to watches, <strong>Casio's</strong> are about as classic as they come. The Japanese brand&rsquo;s range of watches pairs go-with-everything design with functionality ",
            Slug = "casio",
        },
        new CatalogBrand
        {
            Id = 503,
            ApiId = 298,
            Name = "BOSS",
            Description = "If you need an excuse for a wardrobe update, <strong>BOSS</strong> is it. Best known for its tailoring finesse, the luxury German fashion brand has your back when it comes to quality design. The",
            Slug = "boss",
        },
        new CatalogBrand
        {
            Id = 504,
            ApiId = 504,
            Name = "Nixon",
            Description = "When they couldn't find a watch that fulfilled their need for style and substance, <strong>Nixon</strong> set about creating their own. From their base in Southern California, ... ",
            Slug = "nixon",
        },
        new CatalogBrand
        {
            Id = 505,
            ApiId = 15237,
            Name = "Nobody's Child",
            Description = "Refresh your wardrobe with casj-cool essentials by London brand <strong>Nobody's Child</strong>. Think tomboy meets girly-girl, as seasonal styles – including crop tops, jumpsuits and da",
            Slug = "nobody's-child",
        },
        new CatalogBrand
        {
            Id = 506,
            ApiId = 20850,
            Name = "Tammy Girl",
            Description = "Hold the flip phone, because <strong>Tammy Girl</strong> is back. Featuring a Y2K reboot, the brand’s offering is here to satisfy your nostalgic cravings. Scroll mini, midi and maxi dresses",
            Slug = "tammy-girl",
        },
        new CatalogBrand
        {
            Id = 507,
            ApiId = 16427,
            Name = "ASRA",
            Description = "Step up your shoe game with our&nbsp;<strong>ASRA</strong>&nbsp;at ASOS edit.&nbsp;<strong>ASRA</strong>&nbsp;(which stands for Association, So",
            Slug = "asra",
        },
        new CatalogBrand
        {
            Id = 508,
            ApiId = 156,
            Name = "Diesel",
            Description = "Changing the denim game since 1978, <strong>Diesel</strong> celebrates self-expression and individuality with its reinterpreted lifestyle pieces. Ripped-up, washed denim features acr",
            Slug = "diesel",
        },
        new CatalogBrand
        {
            Id = 509,
            ApiId = 16535,
            Name = "Threadbare Curve",
            Description = "",
            Slug = "threadbare-curve",
        },
        new CatalogBrand
        {
            Id = 510,
            ApiId = 16536,
            Name = "Threadbare Petite",
            Description = "",
            Slug = "threadbare-petite",
        },
        new CatalogBrand
        {
            Id = 511,
            ApiId = 262,
            Name = "H by Hudson",
            Description = "Launched in 2004, footwear label <strong>H by Hudson</strong>  reworks current trends into its signature in-house style, referencing music and youth culture influences. Expect a wide range of contem",
            Slug = "h-by-hudson",
        },
        new CatalogBrand
        {
            Id = 512,
            ApiId = 16497,
            Name = "ICONIC LONDON",
            Description = "<strong>ICONIC LONDON</strong> is all about creating trend-led makeup collections that are as standout as its name suggests. The brand’s glow-boosting beauty products help add ",
            Slug = "iconic-london",
        },
        new CatalogBrand
        {
            Id = 513,
            ApiId = 12203,
            Name = "Juicy Couture",
            Description = "In case you missed it, Juicy Couture is back. Revive the noughties and treat your casj line up with some freshly squeezed styles in our <strong>Juicy Couture</strong> at ASOS edit. Expect T-shirts,",
            Slug = "juicy-couture",
        },
        new CatalogBrand
        {
            Id = 514,
            ApiId = 16706,
            Name = "Wild Lovers",
            Description = "Feel like the best version of yourself with <strong>Wild Lovers</strong>’ range of lingerie and loungewear. The female-founded label was created to capture the retro girl’s free spirit w",
            Slug = "wild-lovers",
        },
        new CatalogBrand
        {
            Id = 515,
            ApiId = 16166,
            Name = "Garnier",
            Description = "",
            Slug = "garnier",
        },
        new CatalogBrand
        {
            Id = 516,
            ApiId = 15708,
            Name = "Tan Luxe",
            Description = "",
            Slug = "tan-luxe",
        },
        new CatalogBrand
        {
            Id = 517,
            ApiId = 20251,
            Name = "The Frolic Plus",
            Description = "With timeless collections that are easy-to-wear *and* focused on personal style, we’re saying The Frolic FTW – and we mean it. The Aussie boutique stocks a range of top-tier styles all designed on its home turf, and each delivering a different aesthet",
            Slug = "the-frolic-plus",
        },
        new CatalogBrand
        {
            Id = 518,
            ApiId = 777,
            Name = "Wahl",
            Description = "Celebrating its 100th anniversary as a pioneer of home grooming in 2019, <strong>Wahl</strong> keeps you top of the crops with its professional-standard range. Fix up, look sharp with its beard trimm",
            Slug = "wahl",
        },
        new CatalogBrand
        {
            Id = 519,
            ApiId = 16138,
            Name = "CeraVe",
            Description = "Delivering no-nonsense skincare that’s kind enough for even the most sensitive skin, <strong>CeraVe</strong> is here to give your AM/PM routine a serious upgrade. Developed by dermato",
            Slug = "cerave",
        },
        new CatalogBrand
        {
            Id = 520,
            ApiId = 16266,
            Name = "Native Youth Plus",
            Description = "<strong>Native Youth Plus</strong> introduces oversized silhouettes and lightweight co-ords into your wardrobe this season. Expect clean shapes and soft-touch tencel contrasted with raw-edg",
            Slug = "native-youth-plus",
        },
        new CatalogBrand
        {
            Id = 521,
            ApiId = 14448,
            Name = "Noisy May Petite",
            Description = "Bringing relaxed, trend-led vibes to your everyday ‘fits, <strong>Noisy May Petite</strong> is your go-to label for fashion-forward denim and wardrobe staples. Get on board with authentic, r",
            Slug = "noisy-may-petite",
        },
        new CatalogBrand
        {
            Id = 522,
            ApiId = 23205,
            Name = "Patchology",
            Description = "Update your self-care shelf with our <strong>Patchology</strong> at ASOS edit. Ft. targeted products that get to work ASAP, the brand is here to revolutionise your routine. Start fr",
            Slug = "patchology",
        },
        new CatalogBrand
        {
            Id = 523,
            ApiId = 15393,
            Name = "Alpha-H",
            Description = "An expert in the art of exfoliation, resurfacing and skin renewal, <strong>Alpha-H</strong> is all about results-driven skincare. The award-winning beauty brand behind cult product Liq",
            Slug = "alpha-h",
        },
        new CatalogBrand
        {
            Id = 524,
            ApiId = 15600,
            Name = "Maya Plus",
            Description = "Stealing the spotlight with standout sequins and sheer layers, <strong>Maya Plus</strong> is your go-to for next-level occasionwear. With a nod to the catwalks, expect floor-sweeping maxis, pretty ",
            Slug = "maya-plus",
        },
        new CatalogBrand
        {
            Id = 525,
            ApiId = 14810,
            Name = "Maya Tall",
            Description = "Standout sequins and cool cut-outs help steal the spotlight with <strong>Maya Tall</strong> occasionwear. With a nod to the catwalks, expect need-right-now maxi dresses, hand embellishment and prom",
            Slug = "maya-tall",
        },
        new CatalogBrand
        {
            Id = 526,
            ApiId = 15503,
            Name = "LEVIS SKATEBOARDING",
            Description = "Offering a fresh take on skate clothing, <strong>LEVIS SKATEBOARDING</strong> Skateboarding takes your favourite Levi’s designs and reconstructs them in toughened-up fabrics. Expect straight-leg je",
            Slug = "levis-skateboarding",
        },
        new CatalogBrand
        {
            Id = 527,
            ApiId = 15833,
            Name = "Urban Threads",
            Description = "",
            Slug = "urban-threads",
        },
        new CatalogBrand
        {
            Id = 528,
            ApiId = 178,
            Name = "Elegant Touch",
            Description = "Multi-award winning nail care brand, <strong>Elegant Touch</strong> was developed right on the King’s Road in Chelsea. With its roots at the heart of London’s celebrity and fash",
            Slug = "elegant-touch",
        },
        new CatalogBrand
        {
            Id = 529,
            ApiId = 196,
            Name = "Eylure",
            Description = "Originating in the 1940s, false lash connoisseurs <strong>Eylure</strong>, channel their show business roots through their extensive eyelash collection. Intricately handmade, the range spans from",
            Slug = "eylure",
        },
        new CatalogBrand
        {
            Id = 530,
            ApiId = 16315,
            Name = "Lace & Beads Plus",
            Description = "London-based label <strong>Lace & Beads Plus</strong> know sparkly dresses are always a good idea, so create the perfect handcrafted party pieces for your BNO. Expect standout embellishment, ",
            Slug = "lace-&-beads-plus",
        },
        new CatalogBrand
        {
            Id = 531,
            ApiId = 14248,
            Name = "New Look Tall",
            Description = "Since setting up shop in the 60s, <strong>New Look</strong> has become a high-street classic known for creating universally loved, wardrobe-ready collections. Shop the ... ",
            Slug = "new-look-tall",
        },
        new CatalogBrand
        {
            Id = 532,
            ApiId = 16655,
            Name = "Threadbare Fitness Tall",
            Description = "",
            Slug = "threadbare-fitness-tall",
        },
        new CatalogBrand
        {
            Id = 533,
            ApiId = 16654,
            Name = "Threadbare Fitness Petite",
            Description = "",
            Slug = "threadbare-fitness-petite",
        },
        new CatalogBrand
        {
            Id = 534,
            ApiId = 15140,
            Name = "Embryolisse",
            Description = "Founded by a dermatologist in 1950s Paris, <strong>Embryolisse</strong> Laboratoires put the care into skincare. Initially turning heads with their famous Lait-Crème moisturiser, ... ",
            Slug = "embryolisse",
        },
        new CatalogBrand
        {
            Id = 535,
            ApiId = 14327,
            Name = "Maya Petite",
            Description = "Brides-to-be, show your devotion to your best gals with <strong>Maya Petite</strong> embellished bridesmaid dresses. Choose from a selection of midi, maxi and fit-and-flare styles for standout sequ",
            Slug = "maya-petite",
        },
        new CatalogBrand
        {
            Id = 536,
            ApiId = 16529,
            Name = "Iisla & Bird",
            Description = "Designing a range of super-dreamy beachwear, <strong>Iisla & Bird</strong> has got us keeping our fingers crossed for warm weather. Keep it breezy with co-ord beach tops, beach shorts and b",
            Slug = "iisla-&-bird",
        },
        new CatalogBrand
        {
            Id = 537,
            ApiId = 16421,
            Name = "Real Techniques",
            Description = "Award-winning and all in when it comes to innovation, makeup brand <strong>Real Techniques</strong> is on hand with the foundation brushes, cosmetic sponges and cleansing gels ",
            Slug = "real-techniques",
        },
        new CatalogBrand
        {
            Id = 538,
            ApiId = 14176,
            Name = "Truffle Collection",
            Description = "",
            Slug = "truffle-collection",
        },
        new CatalogBrand
        {
            Id = 539,
            ApiId = 14590,
            Name = "Missguided",
            Description = "From casual daytime pieces to elevated weekend styles, add some newness to your line-up with our <strong>Missguided</strong> at ASOS edit. Filling up our social feeds and Saved Items since 20",
            Slug = "missguided",
        },
        new CatalogBrand
        {
            Id = 540,
            ApiId = 15770,
            Name = "Fashionkilla",
            Description = "Serving Insta-glam realness, clothing brand&nbsp;<strong>Fashionkilla</strong>&nbsp;certainly know how to grab our attention. Make room for BNO dresses such as mini, midi and bodycon option",
            Slug = "fashionkilla",
        },
        new CatalogBrand
        {
            Id = 541,
            ApiId = 21554,
            Name = "Edikted",
            Description = "",
            Slug = "edikted",
        },
        new CatalogBrand
        {
            Id = 542,
            ApiId = 14714,
            Name = "In Your Dreams",
            Description = "",
            Slug = "in-your-dreams",
        },
        new CatalogBrand
        {
            Id = 543,
            ApiId = 20150,
            Name = "Pull&Bear Tall",
            Description = "When it comes to your casual rotation, no one does it better than <strong>Pull&Bear</strong>. Inspired by the laid-back vibe of Palm Springs, California, the brand references grunge influences,",
            Slug = "pull&bear-tall",
        },
        new CatalogBrand
        {
            Id = 544,
            ApiId = 14119,
            Name = "New Look Petite",
            Description = "Since setting up shop in the 60s, <strong>New Look Petite</strong> has become a high-street classic known for creating universally loved, wardrobe-ready collections. Shop the ... ",
            Slug = "new-look-petite",
        },
        new CatalogBrand
        {
            Id = 545,
            ApiId = 16386,
            Name = "American Eagle",
            Description = "Inclusive and empowering,  <strong>American Eagle</strong> is a clothing brand that celebrates individuality through its staples and standout pieces. Expect everything from cosy hoodies and",
            Slug = "american-eagle",
        },
        new CatalogBrand
        {
            Id = 546,
            ApiId = 15307,
            Name = "Gilly Hicks",
            Description = "Love Abercrombie & Fitch? Us too. That's why we're so excited to have its lingerie brand, <strong>Gilly Hicks</strong>, at ASOS. Channelling that familiar effortless vibe, our edit of its ba",
            Slug = "gilly-hicks",
        },
        new CatalogBrand
        {
            Id = 547,
            ApiId = 3492,
            Name = "FCUK",
            Description = "<strong>French Connection</strong> have been creating well-designed, fashion-forward collections since 1972, delivering stylish separates, statement dresses and clean-cu",
            Slug = "fcuk",
        },
        new CatalogBrand
        {
            Id = 548,
            ApiId = 12833,
            Name = "Maurie & Eve",
            Description = "",
            Slug = "maurie-&-eve",
        },
        new CatalogBrand
        {
            Id = 549,
            ApiId = 16494,
            Name = "Stan Ray",
            Description = "When it comes to getting dressed, <strong>Stan Ray</strong> isn’t messing about. Making clothes designed to be worn (like, really worn), the Texas-born brand delivers durable, fuss-free threads",
            Slug = "stan-ray",
        },
        new CatalogBrand
        {
            Id = 550,
            ApiId = 20705,
            Name = "MIM",
            Description = "",
            Slug = "mim",
        },
        new CatalogBrand
        {
            Id = 551,
            ApiId = 13849,
            Name = "Vogue",
            Description = "Delivering designer sunglasses in a range of shapes and colours, <strong>Vogue Eyewear</strong> is all about bringing a bit of glamour and sophistication to your everyday look. Fro",
            Slug = "vogue",
        },
        new CatalogBrand
        {
            Id = 552,
            ApiId = 21958,
            Name = "Dr. Barbara Sturm",
            Description = "Nobody nails great skincare like world-renowned aesthetics doctor, Barbara Sturm. Boasting an impressive celebrity following, our Barbara Sturm at ASOS edit puts science-based skincare firmly on the map (and into our baskets!). Get the spa treatment with ",
            Slug = "dr.-barbara-sturm",
        },
        new CatalogBrand
        {
            Id = 553,
            ApiId = 12431,
            Name = "Kickers",
            Description = "French designed youth brand <strong>Kickers</strong> saw a resurgence in popularity when they were adopted by the rave scene of the early 90s. With their distinctive tough crepe soles and nubuck l",
            Slug = "kickers",
        },
        new CatalogBrand
        {
            Id = 554,
            ApiId = 12477,
            Name = "We The Free by Free People",
            Description = "Founded in 1970s Pennsylvania, USA, <strong>Free People</strong> channels a bohemian femininity in their designs. With emphasis on freedom of dress, ... ",
            Slug = "we-the-free-by-free-people",
        },
        new CatalogBrand
        {
            Id = 555,
            ApiId = 16589,
            Name = "KAVU",
            Description = "With a philosophy of getting out and doing what makes you smile, Seattle-born brand <strong>KAVU</strong> hits the ground running when it comes to adventure-ready gear. Scroll our ... ",
            Slug = "kavu",
        },
        new CatalogBrand
        {
            Id = 556,
            ApiId = 16378,
            Name = "Wednesday's Girl Maternity",
            Description = "Give your wardrobe that extra something-something with the latest drop from <strong>Wednesday's Girl Maternity</strong>. Big on floral and ditsy prints, the brand helps bring your daytim",
            Slug = "wednesday's-girl-maternity",
        },
        new CatalogBrand
        {
            Id = 557,
            ApiId = 21200,
            Name = "Nobody’s Child Petite",
            Description = "",
            Slug = "nobody’s-child-petite",
        },
        new CatalogBrand
        {
            Id = 558,
            ApiId = 16682,
            Name = "Nobody's Child Plus",
            Description = "Refresh your wardrobe with casj-cool essentials by London brand <strong>Nobody's Child Plus</strong>. Think tomboy meets girly-girl, as seasonal styles – including crop tops, jumpsuits a",
            Slug = "nobody's-child-plus",
        },
        new CatalogBrand
        {
            Id = 559,
            ApiId = 12311,
            Name = "Base London",
            Description = "Founded in 1995, <strong>Base London</strong> was created to fill a noticeable gap in the market for men's design-led, high quality formal footwear at a reasonable price. Quickly developing in ",
            Slug = "base-london",
        },
        new CatalogBrand
        {
            Id = 560,
            ApiId = 16319,
            Name = "Les Girls Les Boys",
            Description = "<strong>Les Girls Les Boys</strong> is the creator of our new favourite style aesthetic: underwear meets street. Designing the sleekest, chicest selection of lingerie and loungewear, ",
            Slug = "les-girls-les-boys",
        },
        new CatalogBrand
        {
            Id = 561,
            ApiId = 15869,
            Name = "Elsie & Fred",
            Description = "Whether you&rsquo;re heading to a festival or just feeling a little extra, <strong>Elsie &amp; Fred</strong> ticks all the boxes. Think sequins, glitter and tassels galore",
            Slug = "elsie-&-fred",
        },
        new CatalogBrand
        {
            Id = 562,
            ApiId = 16339,
            Name = "M.A.D Beauty",
            Description = "Bringing a bit of fun to the beauty scene, <strong>M.A.D Beauty</strong> knows how to make childhood dreams come true when it comes to novelty beauty gifting. With Disney accessori",
            Slug = "m.a.d-beauty",
        },
        new CatalogBrand
        {
            Id = 563,
            ApiId = 15757,
            Name = "Madden Girl",
            Description = "",
            Slug = "madden-girl",
        },
        new CatalogBrand
        {
            Id = 564,
            ApiId = 20452,
            Name = "Kanya London",
            Description = "We’re *living* for <strong>Kanya London</strong> and their mission to reimagine occasion wear with modern twists. The South Asian-owned brand creates timeless pieces that are inspired by ",
            Slug = "kanya-london",
        },
        new CatalogBrand
        {
            Id = 565,
            ApiId = 15350,
            Name = "Ultrasun",
            Description = "With 25 years in expertise, Swiss suncare brand <strong>Ultrasun's</strong> skin protection is known for its once-a-day application. Its sun lotions, sprays and gels offer long-lastin",
            Slug = "ultrasun",
        },
        new CatalogBrand
        {
            Id = 566,
            ApiId = 16507,
            Name = "Sun Bum",
            Description = "Get that feel-good factor (15 to 50) with <strong>Sun Bum</strong>. Big on sun care, the brand’s vegan and cruelty-free SPF products make it easy to stay safe in the sun all year rou",
            Slug = "sun-bum",
        },
        new CatalogBrand
        {
            Id = 567,
            ApiId = 14555,
            Name = "Lottie",
            Description = "Inspired by trending looks, <strong>Lottie</strong> future-proofs your makeup bag with its range of cosmetics. Scrolling through the most talked about social feeds so you don’t have to, ",
            Slug = "lottie",
        },
        new CatalogBrand
        {
            Id = 568,
            ApiId = 20607,
            Name = "Tatti Lashes",
            Description = "Give your trusty mascara a day off with <strong>Tatti Lashes</strong> . The brand’s collection of luxe false lashes lets you keep things fresh and customise your look. Scroll ou",
            Slug = "tatti-lashes",
        },
        new CatalogBrand
        {
            Id = 569,
            ApiId = 12191,
            Name = "Ed Hardy",
            Description = "What’s bold, grungy and serving Y2K vibes? You in an Ed Hardy dress, obvs. With colour-blocking and gram-worthy graphics, the brand fuses together tattoo artistry and fashion to create on-trend pieces that’ll have heads turning. Browse our Ed Hardy at",
            Slug = "ed-hardy",
        },
        new CatalogBrand
        {
            Id = 570,
            ApiId = 12724,
            Name = "Alpha Industries",
            Description = "The premier supplier of tough wearing jackets for the U.S. military; <strong>Alpha Industries</strong> have over 50 years of quality manufacturing expertise and unrivalled heritage under ",
            Slug = "alpha-industries",
        },
        new CatalogBrand
        {
            Id = 571,
            ApiId = 15609,
            Name = "Parlez",
            Description = "The designers behind <strong>Parlez</strong> draw on a love of street culture to craft their collection of hoodies, sweatshirts and T-shirts. Inspired by sportswear and nautical aesthetics, the lab",
            Slug = "parlez",
        },
        new CatalogBrand
        {
            Id = 572,
            ApiId = 16164,
            Name = "Wednesday's Girl Curve",
            Description = "",
            Slug = "wednesday's-girl-curve",
        },
        new CatalogBrand
        {
            Id = 573,
            ApiId = 12731,
            Name = "Fiorucci",
            Description = "Italian label <strong>Fiorucci</strong> achieved cult status in the 70s and 80s with its outlandish designs and skin-tight jeans. More than 50 years later, the brand has relaunched with a focus",
            Slug = "fiorucci",
        },
        new CatalogBrand
        {
            Id = 574,
            ApiId = 16401,
            Name = "L'Oreal Elvive",
            Description = "With an approach grounded in science, leading beauty brand <strong>L&rsquo;Oreal</strong> demands only the most visionary products from its team. Whether you need an everyd",
            Slug = "l'oreal-elvive",
        },
        new CatalogBrand
        {
            Id = 575,
            ApiId = 16193,
            Name = "Sunday Rain",
            Description = "If you’re the kind of person who likes a bubble bath and series binge after a busy day, then Sunday Rain is for you. Big on self-care, its range of heavenly scented bath and body products gives your ‘me time’ a serious upgrade. Shop our edit of the ",
            Slug = "sunday-rain",
        },
        new CatalogBrand
        {
            Id = 576,
            ApiId = 13843,
            Name = "New Look Maternity",
            Description = "Since setting up shop in the 60s, <strong>New Look Maternity</strong> has become a high-street classic known for creating universally loved, wardrobe-ready collections. Shop the ... ",
            Slug = "new-look-maternity",
        },
        new CatalogBrand
        {
            Id = 577,
            ApiId = 16709,
            Name = "Sergio Tacchini",
            Description = "A lover of style and authenticity, Italian tennis champion <strong>Sergio Tacchini</strong> founded his namesake label in 1966. Since then, the brand has helped redefine traditional sports",
            Slug = "sergio-tacchini",
        },
        new CatalogBrand
        {
            Id = 578,
            ApiId = 676,
            Name = "St. Tropez",
            Description = "Providing a natural tan all year round, <strong>St. Tropez</strong> offer a professional, streak-free sun-kissed glow with their range of fake tan and tinted moisturisers. Cont",
            Slug = "st.-tropez",
        },
        new CatalogBrand
        {
            Id = 579,
            ApiId = 16619,
            Name = "Aaron Wallace",
            Description = "Determined to create a brand that black men everywhere could be proud of, <strong>Aaron Wallace</strong> kick-started his namesake grooming brand in 2016 from his south London barbershop. Sp",
            Slug = "aaron-wallace",
        },
        new CatalogBrand
        {
            Id = 580,
            ApiId = 22356,
            Name = "Sarah Chapman",
            Description = "Want to get your complexion in check? Us too. Enter Sarah Chapman, founder behind the luxury champ of all skincare labels. Find treatment room TLC at your fingertips with the brand’s milky cleansers and scroll silky serums for that profesh facial feel -",
            Slug = "sarah-chapman",
        },
        new CatalogBrand
        {
            Id = 581,
            ApiId = 16233,
            Name = "Piz Buin",
            Description = "",
            Slug = "piz-buin",
        },
        new CatalogBrand
        {
            Id = 582,
            ApiId = 20400,
            Name = "FADED FUTURE",
            Description = "Your future’s looking bright with London-based jewellery brand Faded Future in it. If you’re new to the accessorising game, a chain necklace never misses, and there’s everything from mixed metals to multiple layers to choose from. Or, if you’re lo",
            Slug = "faded-future",
        },
        new CatalogBrand
        {
            Id = 583,
            ApiId = 16607,
            Name = "Lancaster",
            Description = "Offering a selection of broad-spectrum sun protection, sun-care brand <strong>Lancaster</strong> is your go-to for tanning responsibly. Stock up on its SPF tanning oils, suntan lotio",
            Slug = "lancaster",
        },
        new CatalogBrand
        {
            Id = 584,
            ApiId = 15338,
            Name = "Pureology",
            Description = "Fed up with colour fade? <strong>Pureology</strong> range of haircare is designed to protect colour-treated hair and give you that fresh-out-the-salon look. Its sulphate-free shampoos, conditioners,",
            Slug = "pureology",
        },
        new CatalogBrand
        {
            Id = 585,
            ApiId = 21955,
            Name = "Grown Alchemist",
            Description = "",
            Slug = "grown-alchemist",
        },
        new CatalogBrand
        {
            Id = 586,
            ApiId = 12168,
            Name = "Beauty Blender",
            Description = "",
            Slug = "beauty-blender",
        },
        new CatalogBrand
        {
            Id = 587,
            ApiId = 20605,
            Name = "KYO",
            Description = "Refresh your wardrobe with our <strong>KYO</strong> at ASOS edit. Combining Far East fashion and Western street style, the brand is all about keeping things versatile. Make a statement wit",
            Slug = "kyo",
        },
        new CatalogBrand
        {
            Id = 588,
            ApiId = 16447,
            Name = "HARRY'S",
            Description = "<strong>HARRY'S</strong> is the name and well-rounded, straightforward skincare is its game. After a close, comfortable shave? You’re in luck – the NYC-based men’s grooming brand has the tool",
            Slug = "harry's",
        },
        new CatalogBrand
        {
            Id = 589,
            ApiId = 16116,
            Name = "OGX",
            Description = "",
            Slug = "ogx",
        },
        new CatalogBrand
        {
            Id = 590,
            ApiId = 3735,
            Name = "G-Star",
            Description = "Denim pioneers <strong>G-Star</strong> are famed for their work with raw denim jeans, utilising innovative techniques to create new styles and cuts. The ... ",
            Slug = "g-star",
        },
        new CatalogBrand
        {
            Id = 591,
            ApiId = 12455,
            Name = "Palladium",
            Description = "<strong>Palladium</strong> boots are made for, well, just about everything. After manufacturing airplane tyres in the 1920s, the French brand went on to apply the same tough rubber to the soles o",
            Slug = "palladium",
        },
        new CatalogBrand
        {
            Id = 592,
            ApiId = 12681,
            Name = "Vita Liberata",
            Description = "",
            Slug = "vita-liberata",
        },
        new CatalogBrand
        {
            Id = 593,
            ApiId = 15589,
            Name = "Spectrum",
            Description = "Newsflash: our <strong>Spectrum</strong> at ASOS edit has landed, and the beauty brand sure knows how to handle makeup bag MVPs. Scroll singular makeup brushes and sponges designed fo",
            Slug = "spectrum",
        },
        new CatalogBrand
        {
            Id = 594,
            ApiId = 16514,
            Name = "Veet",
            Description = "",
            Slug = "veet",
        },
        new CatalogBrand
        {
            Id = 595,
            ApiId = 15473,
            Name = "MasqueBAR",
            Description = "Get serious with your skincare routine with <strong>MasqueBAR</strong> sheet, mud and cream masks. Developed in Korea, its range of professional-standard home remedies are formulated with ingred",
            Slug = "masquebar",
        },
        new CatalogBrand
        {
            Id = 596,
            ApiId = 15816,
            Name = "Aveda",
            Description = "",
            Slug = "aveda",
        },
        new CatalogBrand
        {
            Id = 597,
            ApiId = 16203,
            Name = "Gillette",
            Description = "With over 115 years in the business, <strong>Gillette</strong> knows what it’s doing. The brand is committed to creating the closest and most comfortable shave with its ever-evolvin",
            Slug = "gillette",
        },
        new CatalogBrand
        {
            Id = 598,
            ApiId = 16022,
            Name = "New Girl Order",
            Description = "Whatever the occasion, <strong>New Girl Order</strong> specialises in all things bold and daring with its personality-packed collection. We’ve pulled together some of our favourite grap",
            Slug = "new-girl-order",
        },
        new CatalogBrand
        {
            Id = 599,
            ApiId = 16618,
            Name = "EGO",
            Description = "Our two favourite words: new shoes. Supplying the goods is Manchester-based footwear brand <strong>EGO</strong>, serving up catwalk-inspired designs loved by your fave fashion influencers since 2015",
            Slug = "ego",
        },
        new CatalogBrand
        {
            Id = 600,
            ApiId = 20051,
            Name = "Jamaican Mango & Lime",
            Description = "",
            Slug = "jamaican-mango-&-lime",
        },
        new CatalogBrand
        {
            Id = 601,
            ApiId = 17701,
            Name = "Hairburst",
            Description = "Locks feeling a little lacklustre? <strong>Hairburst</strong> is on hand to give them a zhuzh with its range of award-winning hair care. Specifically formulated to promote length and",
            Slug = "hairburst",
        },
        new CatalogBrand
        {
            Id = 602,
            ApiId = 14451,
            Name = "Rule London",
            Description = "",
            Slug = "rule-london",
        },
        new CatalogBrand
        {
            Id = 603,
            ApiId = 16414,
            Name = "Damson Madder",
            Description = "Introducing <strong>Damson Madder</strong>: the London-based brand supplying you with the perf’ garms for a wardrobe refresh. Choose from statement hoodies, joggers and T-shirts, or colo",
            Slug = "damson-madder",
        },
        new CatalogBrand
        {
            Id = 604,
            ApiId = 18050,
            Name = "Bali Body",
            Description = "Finding your glow couldn’t be easier with <strong>Bali Body</strong>. Inspired by the shores of Bali, the Australian-born brand shines through with a range of vegan tanning treats ",
            Slug = "bali-body",
        },
        new CatalogBrand
        {
            Id = 605,
            ApiId = 20951,
            Name = "Extro & Vert Tall",
            Description = "",
            Slug = "extro-&-vert-tall",
        },
        new CatalogBrand
        {
            Id = 606,
            ApiId = 16578,
            Name = "Vesper Petite",
            Description = "Hot new label <strong>Vesper Petite</strong> gives you a serious fashion fix with their collection of figure sculpting dresses. Cut from luxe, super stretch fabrics, each dress is designed to fla",
            Slug = "vesper-petite",
        },
        new CatalogBrand
        {
            Id = 607,
            ApiId = 12635,
            Name = "Murad",
            Description = "Pioneering skincare brand <strong>Murad</strong> consistently deliver results with their high performance collection. Creating tailor-made product ranges to target specific skin concerns, each ... ",
            Slug = "murad",
        },
        new CatalogBrand
        {
            Id = 608,
            ApiId = 17950,
            Name = "Pieces Tall",
            Description = "With its Scandinavian roots and minimalist styling, <strong>Pieces Tall</strong> is your go-to label for everyday essentials. From clothing and footwear to jewellery and accessories, the brand tie",
            Slug = "pieces-tall",
        },
        new CatalogBrand
        {
            Id = 609,
            ApiId = 16475,
            Name = "Glow Hub",
            Description = "<strong>Glow Hub</strong> believes that healthy, happy skin isn’t just a trend, and we agree. Packed with vitamins and antioxidants, the brand’s colour-coded ranges help make it ea",
            Slug = "glow-hub",
        },
        new CatalogBrand
        {
            Id = 610,
            ApiId = 16423,
            Name = "Aria Cove",
            Description = "With confidence and empowerment at the heart of its designs, <strong>Aria Cove</strong> is a go-to for standout partywear. Level up your weekend look with our ... ",
            Slug = "aria-cove",
        },
        new CatalogBrand
        {
            Id = 611,
            ApiId = 15752,
            Name = "First Aid Beauty",
            Description = "Is your AM-PM regime in need of a little TLC? Look to <strong>First Aid Beauty</strong> for your new skincare heroes. Providing targeted solutions for sensitive skin types, th",
            Slug = "first-aid-beauty",
        },
        new CatalogBrand
        {
            Id = 612,
            ApiId = 13827,
            Name = "RVCA",
            Description = "Offering more than your average action sports brand, <strong>RVCA</strong> is a design-driven lifestyle brand that doesn't concern itself with passing trends. Their fresh take on swimwear sees lase",
            Slug = "rvca",
        },
        new CatalogBrand
        {
            Id = 613,
            ApiId = 16438,
            Name = "Easilocks",
            Description = "Dreaming of longer, thicker hair? Bring the bounce back with hair extensions from <strong>Easilocks</strong>. Whether you’re in the mood for sleek ponytail pieces, glossy fringe ex",
            Slug = "easilocks",
        },
        new CatalogBrand
        {
            Id = 614,
            ApiId = 3392,
            Name = "Rare",
            Description = "Focusing on statement pieces with a truly feminine twist, boutique brand <strong>Rare</strong> take influence from catwalk trends and iconic style setters. Look out for party dresses and miniskirts ",
            Slug = "rare",
        },
        new CatalogBrand
        {
            Id = 615,
            ApiId = 16705,
            Name = "HVISK",
            Description = "",
            Slug = "hvisk",
        },
        new CatalogBrand
        {
            Id = 616,
            ApiId = 21959,
            Name = "Spotlight",
            Description = "",
            Slug = "spotlight",
        },
        new CatalogBrand
        {
            Id = 617,
            ApiId = 15815,
            Name = "Bumble and Bumble",
            Description = "Great news for hair everywhere – <strong>Bumble and Bumble</strong> is officially available on ASOS. Often spotted backstage during fashion week, the New York City salon’",
            Slug = "bumble-and-bumble",
        },
        new CatalogBrand
        {
            Id = 618,
            ApiId = 16267,
            Name = "My White Secret",
            Description = "",
            Slug = "my-white-secret",
        },
        new CatalogBrand
        {
            Id = 619,
            ApiId = 15961,
            Name = "David Beckham",
            Description = "Looking for your next signature scent? Our edit of football legend David Beckham’s aftershaves has you covered. Keep things fresh and fruity with its Classic Blue eau de toilette, or go for Homme if a heady scent is more your vibe – we love the spiced",
            Slug = "david-beckham",
        },
        new CatalogBrand
        {
            Id = 620,
            ApiId = 23055,
            Name = "Sui Ava",
            Description = "A look is never complete without on-point accessories, and Sui Ava is here to help your ‘fit reach its *full* potench. Shop colourful beaded necklaces for Y2K vibes, or wear your five a day with its stud and hoop earrings in fruity designs. Hair-up kind",
            Slug = "sui-ava",
        },
        new CatalogBrand
        {
            Id = 621,
            ApiId = 21807,
            Name = "Sundae Body",
            Description = "",
            Slug = "sundae-body",
        },
        new CatalogBrand
        {
            Id = 622,
            ApiId = 19500,
            Name = "Carbon Theory",
            Description = "",
            Slug = "carbon-theory",
        },
        new CatalogBrand
        {
            Id = 623,
            ApiId = 16112,
            Name = "Flat Lay Company",
            Description = "",
            Slug = "flat-lay-company",
        },
        new CatalogBrand
        {
            Id = 624,
            ApiId = 16679,
            Name = "Shaka",
            Description = "",
            Slug = "shaka",
        },
        new CatalogBrand
        {
            Id = 625,
            ApiId = 3755,
            Name = "DKNY Active",
            Description = "",
            Slug = "dkny-active",
        },
        new CatalogBrand
        {
            Id = 626,
            ApiId = 62101,
            Name = "Messina Hembry Clothing Ltd",
            Description = "",
            Slug = "messina-hembry-clothing-ltd",
        },
        new CatalogBrand
        {
            Id = 627,
            ApiId = 13597,
            Name = "Icon Brand",
            Description = "Back in 2008, <strong>Icon Brand</strong> started as a youthful spin-off to a jewellery design company that was 31-years-old. Now based out of London, New York and Sydney, its simple and refine",
            Slug = "icon-brand",
        },
        new CatalogBrand
        {
            Id = 628,
            ApiId = 16431,
            Name = "Sixth June Plus",
            Description = "Breathing fresh air into street style, <strong>Sixth June Plus</strong> launched in Paris in 2008. With its creative and innovative approach to design, the brand’s collection of jumpers, cr",
            Slug = "sixth-june-plus",
        },
        new CatalogBrand
        {
            Id = 629,
            ApiId = 15248,
            Name = "Johnny's Chop Shop",
            Description = "London barbers <strong>Johnny's Chop Shop</strong> channel their well-groomed attitude and Americana aesthetic into their expert range. Expect beard oils, shampoos and styling clays rich",
            Slug = "johnny's-chop-shop",
        },
        new CatalogBrand
        {
            Id = 630,
            ApiId = 20950,
            Name = "Extro & Vert Petite",
            Description = "",
            Slug = "extro-&-vert-petite",
        },
        new CatalogBrand
        {
            Id = 631,
            ApiId = 15811,
            Name = "Y.A.S Petite",
            Description = "Putting a clean twist on everyday essentials, Danish label <strong>Y.A.S Petite</strong> packs its understated-cool style into dresses, premium leather and tailored pieces. Think minimalist designs ",
            Slug = "y.a.s-petite",
        },
        new CatalogBrand
        {
            Id = 632,
            ApiId = 13656,
            Name = "Cat Footwear",
            Description = "From the construction site to our daily rotation, <strong>Cat Footwear</strong> range of rugged workwear has grown into a collection of lifestyle clothing and footwear with serious flex appeal",
            Slug = "cat-footwear",
        },
        new CatalogBrand
        {
            Id = 633,
            ApiId = 22455,
            Name = "Bouclème",
            Description = "Three words: knots, dryness and the dreaded F-R-I-Z-Z. Maintaining curly tresses can be challenging, but Bouclème gets it. Celebrating natural curls is the brand’s MO and the reason it delivers a range of products specifically catered to care for all t",
            Slug = "bouclème",
        },
        new CatalogBrand
        {
            Id = 634,
            ApiId = 15067,
            Name = "Missguided Maternity",
            Description = "From casual daytime pieces to elevated weekend styles, add some newness to your line-up with our <strong>Missguided</strong> at ASOS edit. Filling up our social feeds and Saved Items since 20",
            Slug = "missguided-maternity",
        },
        new CatalogBrand
        {
            Id = 635,
            ApiId = 12491,
            Name = "Barneys Originals",
            Description = "",
            Slug = "barneys-originals",
        },
        new CatalogBrand
        {
            Id = 636,
            ApiId = 62450,
            Name = "JACK1T",
            Description = "PSA: we have zero chill when it comes to outerwear brand <strong>JACK1T</strong>. Allow us to introduce you to a go-to label, whether you’re heading for the slopes or the streets – expect puffe",
            Slug = "jack1t",
        },
        new CatalogBrand
        {
            Id = 637,
            ApiId = 3414,
            Name = "Schott",
            Description = "A family owned brand created in New York with a rich history, <strong>Schott's</strong> pea coats and leather jackets are still produced by hand. ... ",
            Slug = "schott",
        },
        new CatalogBrand
        {
            Id = 638,
            ApiId = 13017,
            Name = "Crooked Tongues",
            Description = "London-based brand <strong>Crooked Tongues</strong> is easily identifiable by its bold streetwear. Headed up by graphic designers, the drops take inspiration from pop culture and the ska",
            Slug = "crooked-tongues",
        },
        new CatalogBrand
        {
            Id = 639,
            ApiId = 62250,
            Name = "OOSC",
            Description = "",
            Slug = "oosc",
        },
        new CatalogBrand
        {
            Id = 640,
            ApiId = 15591,
            Name = "Jack Wolfskin",
            Description = "Calling all adventure lovers! <strong>Jack Wolfskin</strong> is here with all the kit you’ll need for your upcoming outdoor pursuits. Big on functionality and high-performance fabrics, the",
            Slug = "jack-wolfskin",
        },
        new CatalogBrand
        {
            Id = 641,
            ApiId = 16005,
            Name = "Women'secret",
            Description = "Sweet dreams start with cute sleepwear &ndash; enter <strong>Women'secret</strong> with its collection of cute and creative designs. Our edit of the brand&rsquo;s night dresses, pyjama sets ",
            Slug = "women'secret",
        },
        new CatalogBrand
        {
            Id = 642,
            ApiId = 15895,
            Name = "Sally Hansen",
            Description = "Perfect your fingertips with <strong>Sally Hansen's</strong> range of nail varnishes and nail-care products. Scroll vitamin nail serums to help protect and strengthen your nails, ",
            Slug = "sally-hansen",
        },
        new CatalogBrand
        {
            Id = 643,
            ApiId = 14300,
            Name = "Jaded London",
            Description = "<strong>Jaded London</strong> takes its inspiration from global street-style, from East London to LA and New York. The product of London-based siblings Jade and Grant Goulden, this is a brand",
            Slug = "jaded-london",
        },
        new CatalogBrand
        {
            Id = 644,
            ApiId = 62503,
            Name = "Soho Skin",
            Description = "",
            Slug = "soho-skin",
        },
        new CatalogBrand
        {
            Id = 645,
            ApiId = 16250,
            Name = "Dickies Girl",
            Description = "With over 90 years of manufacturing experience, <strong>Dickies</strong> traces its reputation for durability and performance back to its workwear roots. Rounding up a selection of everyday stap",
            Slug = "dickies-girl",
        },
        new CatalogBrand
        {
            Id = 646,
            ApiId = 21855,
            Name = "Lace & Beads Petite",
            Description = "London-based label <strong>Lace & Beads Petite</strong> know sparkly dresses are always a good idea, so create the perfect handcrafted party pieces for your BNO. Expect standout embellishment",
            Slug = "lace-&-beads-petite",
        },
        new CatalogBrand
        {
            Id = 647,
            ApiId = 16135,
            Name = "StylPro",
            Description = "",
            Slug = "stylpro",
        },
        new CatalogBrand
        {
            Id = 648,
            ApiId = 16461,
            Name = "The O Dolls Collection",
            Description = "Inspired by their signature luxe style, influencers Ellie and Daisey O’Donnell introduce <strong>The O Dolls Collection</strong>. For easy, everyday glam, shop cropped hoodies a",
            Slug = "the-o-dolls-collection",
        },
        new CatalogBrand
        {
            Id = 649,
            ApiId = 16178,
            Name = "Go Guy",
            Description = "The search is over for your new festival attire – <strong>Go Guy</strong> has just landed onsite. Starting off as a one-woman feat. sewing machine show, the brand hasn’t stopped growing since ",
            Slug = "go-guy",
        },
        new CatalogBrand
        {
            Id = 650,
            ApiId = 14444,
            Name = "Little Mistress Plus",
            Description = "<strong>Little Mistress Plus</strong> collection ticks all your occasionwear boxes – we’re talking weddings, proms, fancy parties and everything in-between. The brand’s pretty dres",
            Slug = "little-mistress-plus",
        },
        new CatalogBrand
        {
            Id = 651,
            ApiId = 16393,
            Name = "Eivy",
            Description = "Get ski-season ready with <strong>Eivy</strong>. Based in the Swedish mount resort of Åre, the brand knows a thing or two when it comes to skiwear. Scroll our ... ",
            Slug = "eivy",
        },
        new CatalogBrand
        {
            Id = 652,
            ApiId = 12552,
            Name = "The Hundreds",
            Description = "Co-founded by Ben and Bobby Hundreds in 2003, <strong>The Hundreds</strong> centre on street subculture with both a clothing line and an online magazine.  ... ",
            Slug = "the-hundreds",
        },
        new CatalogBrand
        {
            Id = 653,
            ApiId = 480,
            Name = "Moschino",
            Description = "If founder Franco Moschino left one legacy behind him, it was the motto of Italian design house <strong>Moschino</strong>; 'fashion should be fun'. Diffusion lines Cheap and Chic and Love Moschi",
            Slug = "moschino",
        },
        new CatalogBrand
        {
            Id = 654,
            ApiId = 15351,
            Name = "L Oréal Pa",
            Description = "Inspired by beauty influencers, <strong>L&rsquo;Oreal Paris' COLORISTA </strong> haircare is made for the fearless. Choose from spray-on pastels to more wearable colours",
            Slug = "l-oréal-pa",
        },
        new CatalogBrand
        {
            Id = 655,
            ApiId = 20050,
            Name = "Eco Style",
            Description = "<strong>Eco Style</strong> makes beauty affordable as it believes its power should be accessible (ICYDK: eco = economical). Specialising in weightless hair gels enriched with moistur",
            Slug = "eco-style",
        },
        new CatalogBrand
        {
            Id = 656,
            ApiId = 20606,
            Name = "Extro & Vert Plus",
            Description = "Dreaming of an effortlessly chic capsule wardrobe? Extro & Vert has got you covered. Specialising in modern tailoring, the brand serves up minimal designs with maximum impact. Expect oversized blazers and relaxed trousers, or mix-and-match with polished s",
            Slug = "extro-&-vert-plus",
        },
        new CatalogBrand
        {
            Id = 657,
            ApiId = 16723,
            Name = "Wishful",
            Description = "Drawing on her 10+ years expertise as a beauty blogger, Huda Kattan decided to turn her attention to her followers’ skincare concerns and create skincare brand ... ",
            Slug = "wishful",
        },
        new CatalogBrand
        {
            Id = 658,
            ApiId = 16180,
            Name = "Psychic Sisters",
            Description = "Psychic Sisters’ range of spiritual and holistic products are ideal for novices and experts alike. The team behind the brand have been practicing tarot, clairvoyance and reiki healing for over 10 years – so they’re kinda a big deal. Shop our edit of",
            Slug = "psychic-sisters",
        },
        new CatalogBrand
        {
            Id = 659,
            ApiId = 16652,
            Name = "Threadbare Fitness Curve",
            Description = "",
            Slug = "threadbare-fitness-curve",
        },
        new CatalogBrand
        {
            Id = 660,
            ApiId = 14803,
            Name = "Missguided Plus",
            Description = "From casual daytime pieces to elevated weekend styles, add some newness to your line-up with our <strong>Missguided</strong> at ASOS edit. Filling up our social feeds and Saved Items since 20",
            Slug = "missguided-plus",
        },
        new CatalogBrand
        {
            Id = 661,
            ApiId = 21055,
            Name = "Loungeable Tall",
            Description = "",
            Slug = "loungeable-tall",
        },
        new CatalogBrand
        {
            Id = 662,
            ApiId = 21450,
            Name = "Basic Pleasure Mode",
            Description = "Nostalgic AND futuristic, what more could you want? Enter clothing brand Basic Pleasure Mode. Inspired by underground subcultures, sci-fi movies and 00s magazines, the label is here to enhance your line-up. Scroll tops and T-shirts featuring graphic print",
            Slug = "basic-pleasure-mode",
        },
        new CatalogBrand
        {
            Id = 663,
            ApiId = 16072,
            Name = "Dr Denim Tall",
            Description = "Founded by the Graah family in 2004, iconic Swedish brand <strong>Dr Denim Tall</strong> are famed for their skinny jeans and simple Scandinavian styling. Branching out with a collection of jers",
            Slug = "dr-denim-tall",
        },
        new CatalogBrand
        {
            Id = 664,
            ApiId = 16387,
            Name = "Hope & Ivy Plus",
            Description = "Prom queens and wedding guests, claim the best-dressed title in <strong>Hope & Ivy Plus</strong> occasion-ready collection. Shop its notice-me styles for hand-painted florals, Bardot neckli",
            Slug = "hope-&-ivy-plus",
        },
        new CatalogBrand
        {
            Id = 665,
            ApiId = 15091,
            Name = "Hope & Ivy Maternity",
            Description = "From best dressed to wedding guest, <strong>Hope & Ivy Maternity</strong> dresses you for the next nine months and beyond. Choose from bump-friendly bodycons and two-in-one nursing dresses,",
            Slug = "hope-&-ivy-maternity",
        },
        new CatalogBrand
        {
            Id = 666,
            ApiId = 16581,
            Name = "Violet Romance Petite",
            Description = "",
            Slug = "violet-romance-petite",
        },
        new CatalogBrand
        {
            Id = 667,
            ApiId = 13305,
            Name = "REN",
            Description = "Pioneering beauty brand <strong>REN</strong> drew up a comprehensive list of ingredients that weren’t welcome in its products when it was founded back in 2000, and hasn’",
            Slug = "ren",
        },
        new CatalogBrand
        {
            Id = 668,
            ApiId = 15003,
            Name = "Harry Brown",
            Description = "",
            Slug = "harry-brown",
        },
        new CatalogBrand
        {
            Id = 669,
            ApiId = 15364,
            Name = "Gianni Feraud",
            Description = "",
            Slug = "gianni-feraud",
        },
        new CatalogBrand
        {
            Id = 670,
            ApiId = 19900,
            Name = "Shambhala",
            Description = "",
            Slug = "shambhala",
        },
        new CatalogBrand
        {
            Id = 671,
            ApiId = 14557,
            Name = "Jayley",
            Description = "Take it outside and embrace those warm, fuzzy feels with clothing brand <strong>Jayley</strong>. The brand’s collection of outerwear and accessories is handcrafted from premium fabrics leaving ",
            Slug = "jayley",
        },
        new CatalogBrand
        {
            Id = 672,
            ApiId = 13518,
            Name = "Hurley",
            Description = "Born in the heart of American surfing culture in Southern California, <strong>Hurley</strong> has been creating surfing goods since the late 70s. Our ... ",
            Slug = "hurley",
        },
        new CatalogBrand
        {
            Id = 673,
            ApiId = 13935,
            Name = "Deus Ex Machina",
            Description = "Founded in 2006, <strong>Deus Ex Machina</strong> hails from Australia. Originally launching with customised motorcycles, the guys at Deus Ex quickly developed a clothing range and we're g",
            Slug = "deus-ex-machina",
        },
        new CatalogBrand
        {
            Id = 674,
            ApiId = 16432,
            Name = "A.Kjaerbede",
            Description = "",
            Slug = "a.kjaerbede",
        },
        new CatalogBrand
        {
            Id = 675,
            ApiId = 15821,
            Name = "CHICKIDEE",
            Description = "With just a market cart and a passion for interior design, Joe Chandler founded British homeware label <strong>Chickidee</strong> back in 2007. We&rsquo;ve rounded up a selecti",
            Slug = "chickidee",
        },
        new CatalogBrand
        {
            Id = 676,
            ApiId = 14974,
            Name = "Sisters of the Tribe",
            Description = "Australian-based label <strong>Sisters of the Tribe</strong> turns up the heat with its out-all-day-and-night styles. Standout prints and trims bring an added edge to your wardrobe ",
            Slug = "sisters-of-the-tribe",
        },
        new CatalogBrand
        {
            Id = 677,
            ApiId = 21156,
            Name = "Truffle Collection Wide Fit",
            Description = "",
            Slug = "truffle-collection-wide-fit",
        },
        new CatalogBrand
        {
            Id = 678,
            ApiId = 18151,
            Name = "BeYou",
            Description = "BeYou creates science-backed period products. Best known for its award-winning monthly period patches, the brand also helps to balance inequalities in medical research by developing products in a way that challenges the status quo. Find everything you nee",
            Slug = "beyou",
        },
        new CatalogBrand
        {
            Id = 679,
            ApiId = 13573,
            Name = "Rhythm",
            Description = "Inspired by adventure, swimwear brand <strong>Rhythm</strong> range is as much about self-expression as it is doing what you love. Drawing on influences from art, music, fashion and travel, its b",
            Slug = "rhythm",
        },
        new CatalogBrand
        {
            Id = 680,
            ApiId = 16214,
            Name = "Tonymoly",
            Description = "<p>For targeted skincare products that also give your bathroom cabinet a bit of a zhuzh, introduce yourself to Tonymoly. Born in Seoul, it joins the long list of Korean beauty brands we&rsquo;re already obsessed with. Known for its adorable packaging, the",
            Slug = "tonymoly",
        },
        new CatalogBrand
        {
            Id = 681,
            ApiId = 62789,
            Name = "Denim Project",
            Description = "Social calendar filling up fast? Our Denim Project at ASOS edit has a bunch of elevated everyday wear that just, hits different. Serving up T-shirts, trousers, and hoodies, as well as (you guessed it) – denim, consider your plans sorted as you tuck your",
            Slug = "denim-project",
        },
        new CatalogBrand
        {
            Id = 682,
            ApiId = 14187,
            Name = "CAT",
            Description = "With almost two decades of shoe-making under its belt, <strong>CAT</strong> has grown its line from a handful of work boots to a full collection of footwear and accessories. Its tough boots ",
            Slug = "cat",
        },
        new CatalogBrand
        {
            Id = 683,
            ApiId = 13761,
            Name = "Fat Moose",
            Description = "Danish outdoors brand <strong>Fat Moose</strong> was founded by three friends, all with backgrounds in extreme sports and a desire to combine durable and innovative fabrics with practical soluti",
            Slug = "fat-moose",
        },
        new CatalogBrand
        {
            Id = 684,
            ApiId = 13962,
            Name = "Limit",
            Description = "Watch makers <strong>Limit</strong>   have been bringing Swiss construction back to their UK-based headquarters since 1912. With sleek leather straps and super precise Japanese quartz movement, ... ",
            Slug = "limit",
        },
        new CatalogBrand
        {
            Id = 685,
            ApiId = 3675,
            Name = "Urbancode",
            Description = "British design company <strong>Urbancode</strong>, uses traditional techniques across a contemporary edit of leather handbags and jackets. Cropped, aviator and biker styles are updated, all w",
            Slug = "urbancode",
        },
        new CatalogBrand
        {
            Id = 686,
            ApiId = 14449,
            Name = "Noisy May Tall",
            Description = "Bringing relaxed, trend-led vibes to your everyday ‘fits, <strong>Noisy May Tall</strong> is your go-to label for fashion-forward denim and wardrobe staples. Get on board with authentic, raw",
            Slug = "noisy-may-tall",
        },
        new CatalogBrand
        {
            Id = 687,
            ApiId = 12626,
            Name = "L'Occitane",
            Description = "Creating a sensory experience, <strong>L'Occitane</strong> samples the purest plant oils to formulate their certified organic collection. In keeping with the Mediterranean art de vivre, fragr",
            Slug = "l'occitane",
        },
        new CatalogBrand
        {
            Id = 688,
            ApiId = 12754,
            Name = "Dare 2b",
            Description = "We dare you to scroll past our Dare 2b at ASOS edit. You can’t do it, can ya? Maybe because the multi-sportswear brand has been pushing the boundaries of outdoor wear since 1999. Whether you’re running, climbing, or skiing, you won’t need to look an",
            Slug = "dare-2b",
        },
        new CatalogBrand
        {
            Id = 689,
            ApiId = 15584,
            Name = "Brave Soul Petite",
            Description = "",
            Slug = "brave-soul-petite",
        },
        new CatalogBrand
        {
            Id = 690,
            ApiId = 20601,
            Name = "Topshop Hourglass",
            Description = "Introducing <strong>Topshop Hourglass</strong> at ASOS. Shop our edit to discover our top picks from the London-born brand, including clothes, shoes and accessories. And if you’re just stoppin",
            Slug = "topshop-hourglass",
        },
        new CatalogBrand
        {
            Id = 691,
            ApiId = 62798,
            Name = "Off The Hook",
            Description = "Off The Hook is here to bring your *sole*searching to a halt. From loafers to knee-high boots, consider your ‘fit sorted from the bottom up with the brand’s range of footwear. Shop our Off The Hook at ASOS edit for boots that’ll take you from the of",
            Slug = "off-the-hook",
        },
        new CatalogBrand
        {
            Id = 692,
            ApiId = 16244,
            Name = "Shelby & Sons",
            Description = "No one can deny the power of a good suit, least of all <strong>Shelby & Sons</strong>. Serving up formalwear with a fresh edge, its range is inspired by those who ruled the streets in the ea",
            Slug = "shelby-&-sons",
        },
        new CatalogBrand
        {
            Id = 693,
            ApiId = 647,
            Name = "Sean John",
            Description = "",
            Slug = "sean-john",
        },
        new CatalogBrand
        {
            Id = 694,
            ApiId = 16406,
            Name = "Forever New Curve",
            Description = "Obsessed with embellishment and standout silhouettes, <strong>Forever New Curve</strong> offers the ultimate in occassionwear. From flowing maxi dresses to bodycon fits, get prepped for your",
            Slug = "forever-new-curve",
        },
        new CatalogBrand
        {
            Id = 695,
            ApiId = 15297,
            Name = "Lamoda",
            Description = "<strong>Lamoda</strong> introduced the accessories market to its fresh bags and jewellery on ASOS Marketplace in 2012. Taking inspiration from badass girls, street trends and 90s throwbacks, it c",
            Slug = "lamoda",
        },
        new CatalogBrand
        {
            Id = 696,
            ApiId = 62700,
            Name = "Regatta",
            Description = "Notification: missed call – it’s from the outdoors and it kinda wants you to get o-u-t there. We’ll add our <strong>Regatta</strong> at ASOS edit to your contacts because you won’t need to",
            Slug = "regatta",
        },
        new CatalogBrand
        {
            Id = 697,
            ApiId = 16528,
            Name = "The Kript",
            Description = "If you’re all about copping the latest trending styles, <strong>The Kript</strong> is the brand for you. First launching on the ‘gram, the Beirut-based clothing label takes its inspo from ",
            Slug = "the-kript",
        },
        new CatalogBrand
        {
            Id = 698,
            ApiId = 15827,
            Name = "ONLY Petite",
            Description = "Let’s be honest, we all love a bit of Scandi style. That’s why we’ve put together an edit of Danish high-street brand <strong>ONLY Petite</strong> freshest pieces, including classic denim cut",
            Slug = "only-petite",
        },
        new CatalogBrand
        {
            Id = 699,
            ApiId = 3154,
            Name = "Helene Berman",
            Description = "",
            Slug = "helene-berman",
        },
        new CatalogBrand
        {
            Id = 700,
            ApiId = 62410,
            Name = "Pajar",
            Description = "",
            Slug = "pajar",
        },
        new CatalogBrand
        {
            Id = 701,
            ApiId = 3513,
            Name = "Claudia Canova",
            Description = "",
            Slug = "claudia-canova",
        },
        new CatalogBrand
        {
            Id = 702,
            ApiId = 15143,
            Name = "Dorina",
            Description = "When it comes to underwear, it’s the style, comfort and support for <strong>Dorina</strong>. Empowering women to embrace body diversity, the brand offers plus size, fuller bust and maternity ra",
            Slug = "dorina",
        },
        new CatalogBrand
        {
            Id = 703,
            ApiId = 16039,
            Name = "Thinx",
            Description = "",
            Slug = "thinx",
        },
        new CatalogBrand
        {
            Id = 704,
            ApiId = 481,
            Name = "Motel",
            Description = "Inspired by vintage prints and cuts, <strong>Motel</strong> are renowned for creating well-crafted pieces in an eclectic mix of designs. Embracing the feminine silhouette; look out for statement pa",
            Slug = "motel",
        },
        new CatalogBrand
        {
            Id = 705,
            ApiId = 13839,
            Name = "Call it Spring",
            Description = "Vegan brand <strong>Call It Spring</strong> looks high and wide for its inspirations, taking influences from the streets, culture and the runway to create its trend-led fo",
            Slug = "call-it-spring",
        },
        new CatalogBrand
        {
            Id = 706,
            ApiId = 15355,
            Name = "Tommy Hilfiger Denim",
            Description = "<strong>Tommy Hilfiger</strong> is a global brand with a classic/cool American heritage. Think timeless, preppy Americana, updated, re-imagined and always changing across ",
            Slug = "tommy-hilfiger-denim",
        },
        new CatalogBrand
        {
            Id = 707,
            ApiId = 16306,
            Name = "Topshop Maternity",
            Description = "Introducing <strong>Topshop Maternity</strong> at ASOS. Shop our edit to discover our top picks from the London-born brand, including clothes, shoes and accessories. And if you’re just stoppin",
            Slug = "topshop-maternity",
        },
        new CatalogBrand
        {
            Id = 708,
            ApiId = 62799,
            Name = "SENSSE",
            Description = "",
            Slug = "sensse",
        },
        new CatalogBrand
        {
            Id = 709,
            ApiId = 12527,
            Name = "Accurist",
            Description = "Launched in 1946, British brand <strong>Accurist</strong> has led the way in making watches of exceptional quality, style and reliability for 70 years. Combining precision engineering with smart ",
            Slug = "accurist",
        },
        new CatalogBrand
        {
            Id = 710,
            ApiId = 16534,
            Name = "VIOLET ROMANCE",
            Description = "",
            Slug = "violet-romance",
        },
        new CatalogBrand
        {
            Id = 711,
            ApiId = 18901,
            Name = "Edited",
            Description = "In the mood for effortless style? Look no further than German brand <strong>Edited</strong>. The label’s offering of it-pieces and timeless basics are total wardrobe wins. Scroll tops and trousers in",
            Slug = "edited",
        },
        new CatalogBrand
        {
            Id = 712,
            ApiId = 14616,
            Name = "Kingsley Ryan",
            Description = "Mix up your jewellery game with <strong>Kingsley Ryan</strong> fresh and innovative designs. Inspired by fashion and street trends, expect everything from minimal earrings to stackable rin",
            Slug = "kingsley-ryan",
        },
        new CatalogBrand
        {
            Id = 713,
            ApiId = 15710,
            Name = "Flounce London Maternity",
            Description = "Whatever the occasion, nail your going-out ’fit with <strong>Flounce London Maternity</strong> collection of party pieces. Tick all your maternity boxes in velvet tops, or choose from f",
            Slug = "flounce-london-maternity",
        },
        new CatalogBrand
        {
            Id = 714,
            ApiId = 13668,
            Name = "AX Paris",
            Description = "If you’re after a new going-out look or dressing for a big occasion, <strong>AX Paris</strong> never fails to deliver. Scroll the brand’s lace, satin and slinky bodycon dresses in mini and ",
            Slug = "ax-paris",
        },
        new CatalogBrand
        {
            Id = 715,
            ApiId = 14629,
            Name = "Devils Advocate",
            Description = "",
            Slug = "devils-advocate",
        }
            );
    }
}

