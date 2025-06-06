﻿
namespace Tanjameh.Core.Constants;

public static class ProductTypeTranslate
{
    public static string GetTranslate(string productType)
    {
        if (_translations.TryGetValue(productType, out var result))
        {
            return result;
        }
        else
        {
            return productType;
        }
    }

    private static readonly Dictionary<string, string> _translations = new Dictionary<string, string>()
    {
    { "T-shirts", "تیشرت" },
    { "Shirts", "پیراهن" },
    { "Rings", "انگشتر" },
    { "Vests", "جلیقه" },
    { "Polo Shirts", "پولوشرت" },
    { "Shorts", "شلوارک" },
    { "Gilets", "ژیله" },
    { "Trunks", "مایو" },
    { "Jackets", "کت" },
    { "Socks", "جوراب" },
    { "Face Coverings", "ماسک صورت" },
    { "Sandals", "صندل" },
    { "Jeans", "شلوار جین" },
    { "Suit Jackets", "کت و شلوار" },
    { "Suit Trousers", "شلوار کت و شلوار" },
    { "Trousers", "شلوار" },
    { "Sweatshirts", "سویشرت" },
    { "Hoodies", "هودی" },
    { "Waistcoats", "جلیقه" },
    { "Blazers", "کت رسمی" },
    { "Body Moisturisers", "مرطوب کننده بدن" },
    { "Fake Tan", "برنزه مصنوعی" },
    { "Bath Sets", "ست حمام" },
    { "Body Washes", "شوینده بدن" },
    { "Body Scrubs", "اسکراب بدن" },
    { "Body Oils", "روغن بدن" },
    { "Self Tan", "برنزه کننده" },
    { "Fragrances", "عطر" },
    { "Candles", "شمع" },
    { "Watches", "ساعت" },
    { "Belts", "کمربند" },
    { "Chinos", "شلوار چینو" },
    { "Shoes", "کفش" },
    { "Sunglasses", "عینک آفتابی" },
    { "Sun Care", "محافظت از آفتاب" },
    { "Briefs", "شورت مردانه" },
    { "Joggers", "شلوار راحتی" },
    { "Bra Solutions", "ابزارهای سوتین" },
    { "Hair Clips", "کلیپس مو" },
    { "Bras", "سوتین" },
    { "Tracksuits", "لباس ورزشی" },
    { "Thongs", "شورت بند دار" },
    { "Boxers", "شورت بوکسری" },
    { "Loungewear Sets", "ست لباس خانگی" },
    { "Bralets", "سوتین سبک" },
    { "Dresses", "لباس زنانه" },
    { "Bags", "کیف" },
    { "Purses", "کیف پول" },
    { "Boots", "چکمه" },
    { "Fleeces", "پلیور پشمی" },
    { "Coats", "پالتو" },
    { "Hair Masks", "ماسک مو" },
    { "Shampoos", "شامپو" },
    { "Hair Mists & Fragrances", "اسپری مو" },
    { "Facial Moisturisers", "مرطوب کننده صورت" },
    { "Facial Serums", "سرم صورت" },
    { "Wash Bags", "کیف شستشو" },
    { "Makeup Bags", "کیف آرایش" },
    { "Beauty Tools", "ابزار زیبایی" },
    { "Makeup Brushes", "براش آرایش" },
    { "Vibrators", "ویبراتور" },
    { "Lubricants", "لوبریکانت" },
    { "Caps", "کلاه" },
    { "Harnesses", "تسمه" },
    { "Scarves", "شال گردن" },
    { "Hats", "کلاه" },
    { "Snoods", "گردگیر" },
    { "Trainers", "کتانی" },
    { "Sliders", "دمپایی" },
    { "Jock Straps", "جاکی استرپ" },
    { "Hairbands", "کش مو" },
    { "Headbands", "هدبند" },
    { "Slippers", "دمپایی راحتی" },
    { "Conditioners", "نرم کننده مو" },
    { "Hair Brushes", "برس مو" },
    { "Hair Extensions", "اکستنشن مو" },
    { "Body Lotions", "لوسیون بدن" },
    { "Leggings", "لگ" },
    { "Nighties", "لباس خواب" },
    { "Skirts", "دامن" },
    { "Corset Tops", "تاپ کرست" },
    { "Crop Tops", "کراپ تاپ" },
    { "Pyjamas", "لباس خواب" },
    { "Earrings", "گوشواره" },
    { "Bum Bags", "کیف کمری" },
    { "Bracelets", "دستبند" },
    { "Necklaces", "گردنبند" },
    { "Card Holders", "جاکارتی" },
    { "Corsets", "کرست" },
    { "Blouses", "بلوز" },
    { "Backpacks", "کوله پشتی" },
    { "Shaving Creams & Gels", "کرم و ژل اصلاح" },
    { "Shaving Sets", "ست اصلاح" },
    { "Grooming Sets", "ست آراستگی" },
    { "Beard Oils", "روغن ریش" },
    { "Beard Balms", "بالم ریش" },
    { "After Shave Lotions", "لوسیون پس از اصلاح" },
    { "Gloves", "دستکش" },
    { "Skincare Sets", "ست مراقبت پوست" },
    { "Hair Grips", "گیره مو" },
    { "Lingerie Bralets", "سوتین زنانه" },
    { "Hair Treatments", "درمان مو" },
    { "Hair Sets", "ست مو" },
    { "Camis", "تاپ بندی" },
    { "Lip Balms", "بالم لب" },
    { "Blushers", "رژ گونه" },
    { "Lip Glosses", "براق کننده لب" },
    { "Nightwear Sets", "ست لباس خواب" },
    { "Palettes", "پالت آرایش" },
    { "Bronzers", "برنزه کننده" },
    { "Swim Shorts", "شلوارک شنا" },
    { "Playsuits", "پلی‌سوت" },
    { "Jumpsuits", "جامپ‌سوت" },
    { "UV Sun Protection", "محافظت از خورشید UV" },
    { "Body Treatments", "درمان بدن" },
    { "Cardigans", "ژاکت" },
    { "Jumpers", "پلیور" },
    { "Pyjama Bottoms", "شلوار پیژامه" },
    { "Onesies", "لباس یکسره" },
    { "Eye Shadow Palettes", "پالت سایه چشم" },
    { "Lipsticks", "رژ لب" },
    { "Highlighters", "هایلایتر" },
    { "Cleansers", "پاک کننده‌ها" },
    { "Nail Treatments", "درمان ناخن" },
    { "Facial Exfoliators", "لایه بردار صورت" },
    { "Makeup Removers", "پاک کننده آرایش" },
    { "Facial Creams", "کرم‌های صورت" },
    { "Face Masks", "ماسک‌های صورت" },
    { "Bikini Tops", "تاپ بیکینی" },
    { "Ties", "کراوات" },
    { "Bow Ties", "پاپیون" },
    { "Hygiene Products", "محصولات بهداشتی" },
    { "Bikini Bottoms", "شلوارک بیکینی" },
    { "Water Bottles", "بطری‌های آب" },
    { "Primers", "پرایمر" },
    { "Pyjama Tops", "تاپ پیژامه" },
    { "Lip Kits", "ست لب" },
    { "Facial Masks", "ماسک‌های صورت" },
    { "Eye Creams", "کرم‌های چشم" },
    { "Wallets", "کیف پول" },
    { "Beanies", "کلاه بافتنی" },
    { "Flip Flops", "دمپایی" },
    { "Hair Bands", "بند مو" },
    { "Hair Accessories", "اکسسوری مو" },
    { "Eyebrow Pencils", "مداد ابرو" },
    { "Eye Shadows", "سایه چشم" },
    { "Makeup Sets", "ست آرایش" },
    { "Dungarees", "لباس کار" },
    { "Scalp Scrubs & Treatments", "اسکراب پوست سر" },
    { "Lingerie Sets", "ست لباس زیر" },
    { "Football Shirts", "پیراهن فوتبال" },
    { "Tank Tops", "تاپ بندی" },
    { "Co-ords", "ست هماهنگ" },
    { "Cover Ups", "روپوش" },
    { "Bodies", "لباس بدن" },
    { "Wellies", "چکمه‌های بارانی" },
    { "Ponchos", "پانچو" },
    { "Hair Sprays", "اسپری مو" },
    { "Hair Dryers", "سشوار" },
    { "Hair Straighteners", "اتو مو" },
    { "Shapewear", "لباس فرم دهنده" },
    { "Tanning Mitts", "دستکش برنزه" },
    { "Makeup Cloths", "دستمال‌های آرایش" },
    { "Spot Treatments", "درمان لکه‌ها" },
    { "Unitards", "لباس یکسره ورزشی" },
    { "Tanning Sets", "ست برنزه" },
    { "Eye Serums", "سرم چشم" },
    { "Foundations", "کرم‌پودر" },
    { "Hair Pomades", "پماد مو" },
    { "Eyeliners", "خط چشم" },
    { "Eyebrow Kits", "ست ابرو" },
    { "Slips", "زیرلباسی" },
    { "Compression Shorts", "شلوارک فشرده‌سازی" },
    { "Leave-in Treatments", "درمان مو بدون شستشو" },
    { "Hair Serums", "سرم مو" },
    { "Hair Oils", "روغن مو" },
    { "Lip Liners", "خط لب" },
    { "Concealers", "کانسیلر" },
    { "Eyebrow Gels", "ژل ابرو" },
    { "Mascaras", "ریمل" },
    { "Tights", "جوراب شلواری" },
    { "Setting Sprays", "اسپری فیکس کننده" },
    { "Facial Cleansers", "پاک کننده‌های صورت" },
    { "Underwear Sets", "ست لباس زیر" },
    { "Tie Bars", "گیره کراوات" },
    { "Pocket Squares", "دستمال جیبی" },
    { "Nail Clippers", "ناخن‌گیر" },
    { "Hair Removal Creams", "کرم‌های موبر" },
    { "Hand Creams", "کرم‌های دست" },
    { "Swim Trunks", "مایو شنا" },
    { "Sunglasses Accessories", "اکسسوری عینک آفتابی" },
    { "Diffusers", "دستگاه پخش عطر" },
    { "Toners", "تونرها" },
    { "Curling Wands", "فرکننده مو" },
    { "Dry Shampoos", "شامپوی خشک" },
    { "Hand Lotions", "لوسیون دست" },
    { "Hair Clippers", "ماشین اصلاح" },
    { "Headscarves", "روسری" },
    { "Facial Oils", "روغن صورت" },
    { "Eye Primers", "پرایمر چشم" },
    { "Sponges", "اسفنج آرایشی" },
    { "Face + Body Sets", "ست صورت و بدن" },
    { "Jeggings", "لگ جین" },
    { "Ski Pants", "شلوار اسکی" },
    { "Anklets", "پابند" },
    { "Watch Straps", "بند ساعت" },
    { "Dressing Gowns", "لباس راحتی" },
    { "Gems", "نگین" },
    { "Beauty Sets", "ست زیبایی" },
    { "Sports Bras", "سوتین ورزشی" },
    { "Sweatbands", "دستبند عرق‌گیر" },
    { "Pencil Sharpeners", "مدادتراش" },
    { "Compression Tops", "تاپ فشرده‌سازی" },
    { "Robes", "روپوش" },
    { "Bikinis", "بیکینی" },
    { "False Nails", "ناخن مصنوعی" },
    { "False Eyelashes", "مژه مصنوعی" },
    { "Eyebrow Stencils", "شابلون ابرو" },
    { "Powders", "پودر آرایشی" },
    { "Contour Sticks", "استیک کانتور" },
    { "Contours", "کانتور" },
    { "Eyebrow Tints", "رنگ ابرو" },
    { "Body Glitters", "درخشان‌کننده بدن" },
    { "Boiler Suits", "لباس کار" },
    { "Razors & Blades", "تیغ و ژیلت" },
    { "Foot Lotions", "لوسیون پا" },
    { "Nail Art", "هنر ناخن" },
    { "Lip Treatments", "درمان لب" },
    { "Tweezers", "موچین" },
    { "Masks", "ماسک‌ها" },
    { "Deodorant", "دئودورانت" },
    { "Beard Brushes", "برس ریش" },
    { "Hair Colours", "رنگ مو" },
    { "Styling Products", "محصولات حالت‌دهنده مو" },
    { "Hair Creams", "کرم‌های مو" },
    { "Heat Protection Sprays", "اسپری محافظ حرارتی" },
    { "Makeup Brush Cleansers", "پاک‌کننده براش آرایش" },
    { "Shaving Brushes", "برس اصلاح" },
    { "Laptop Cases", "کاور لپ‌تاپ" },
    { "Makeup Brush Sets", "ست براش آرایش" },
    { "Trimmers", "ماشین اصلاح" },
    { "Beard Washes", "شامپو ریش" },
    { "Fascinators", "اکسسوری مو" },
    { "Hand Washes", "مایع دستشویی" },
    { "Cleansing Brushes", "برس پاکسازی" },
    { "Eyebrow Brushes", "براش ابرو" },
    { "Skincare Tools & Accessories", "ابزارها و اکسسوری‌های مراقبت از پوست" },
    { "Room Fragrances", "عطرهای اتاق" },
    { "Rollers", "رولر مو" },
    { "Dental Care Product", "محصولات مراقبت از دندان" },
    { "Toothbrush Holder", "جا مسواکی" },
    { "Compression Tights", "جوراب فشرده‌سازی" },
    { "Running Tights", "جوراب شلواری ورزشی" },
    { "Ski Jackets", "ژاکت اسکی" },
    { "Gift Boxes", "بسته‌های هدیه" },
    { "Eye Masks", "ماسک چشم" },
    { "Creams", "کرم‌ها" },
    { "Sheet Masks", "ماسک‌های ورقه‌ای" },
    { "Shavers", "ماشین اصلاح" },
    { "Beauty Storage", "ذخیره‌سازی لوازم زیبایی" },
    { "Lingerie Bodies", "لباس زیر زنانه" },
    { "Facial Washes", "شوینده‌های صورت" },
    { "Hair Waxes", "واکس مو" },
    { "Skin Serums", "سرم‌های پوستی" },
    { "Eye Treatments", "درمان‌های چشم" },
    { "Suspenders", "سوزنی‌های شلوار" },
    { "Cards", "کارت‌ها" },
    { "Laptop Bags", "کیف‌های لپ‌تاپ" },
    { "Body Tapes", "نوار بدن" },
    { "Sleep Aids", "ابزارهای کمک‌خواب" },
    { "Ear Cuffs", "گوشواره‌های تزیینی" },
    { "Swim Briefs", "شورت شنا" },
    { "Crystals", "کریستال‌ها" },
    { "Arm Cuffs", "دستبندها" },
    { "Suspender Belts", "کمربند سوزنی" },
    { "Eye Pencils", "مداد چشم" },
    { "Colour Correctors", "تصحیح‌کننده‌های رنگ" },
    { "Shell Tops", "تاپ شل" }
};

}
