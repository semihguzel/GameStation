using GameStation.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStation.DAL.Mappings
{
    public class ProductMapping : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(x => x.ProductID);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
            builder.Property(x => x.QuantityPerUnit).HasMaxLength(50);
            builder.Property(x => x.UnitPrice).IsRequired().HasColumnType("money");
            builder.Property(x => x.OldPrice).HasColumnType("money");
            builder.Property(x => x.UnitWeight).HasMaxLength(30);
            builder.Property(x => x.Size).HasMaxLength(30);
            builder.Property(x => x.ImageUrl).IsRequired().HasMaxLength(500);
            builder.Property(x => x.AltText).IsRequired().HasMaxLength(200);
            builder.Property(x => x.ShortDescription).IsRequired().HasMaxLength(500);
            builder.Property(x => x.LongDescription).IsRequired().HasMaxLength(1500);
            builder.Property(x => x.Picture1).HasMaxLength(500);
            builder.Property(x => x.Picture2).HasMaxLength(500);
            builder.Property(x => x.Picture3).HasMaxLength(500);
            builder.Property(x => x.Picture4).HasMaxLength(500);
            builder.Property(x => x.Notes).HasMaxLength(250);

            builder.HasMany(x => x.OrderDetails).WithOne(x => x.Product).HasForeignKey(x => x.ProductID).IsRequired();
            builder.HasMany(x => x.RecentlyViews).WithOne(x => x.Product).HasForeignKey(x => x.ProductID).IsRequired();
            builder.HasMany(x => x.Reviews).WithOne(x => x.Product).HasForeignKey(x => x.ProductID).IsRequired();
            builder.HasMany(x => x.WishLists).WithOne(x => x.Product).HasForeignKey(x => x.ProductID).IsRequired();

            //Seed
            #region Steam Games
            builder.HasData
            (
                //TODO: ImageUrl's have been set. Download the images and put it to the specified directory.
                new Product
                {
                    ProductID = 1,
                    SupplierID = 1,
                    Name = "RimWorld",
                    CategoryID = 4,
                    UnitPrice = 50,
                    Discount = 0,
                    ImageUrl = Tools.PicturesDirectory + "/Pictures/ProductPictures/Steam/rimworld_logo.png",
                    AltText = "Rimworld",
                    ShortDescription = "RimWorld is a top-down construction and management simulation video game by Montreal-based developer Ludeon Studios. Originally called Eclipse Colony, it was initially released as a Kickstarter crowdfunding project in early access for Microsoft Windows, macOS, and Linux in November 2013, and was officially released on October 17, 2018.",
                    LongDescription = "The futuristic plot originally revolved around three characters being stranded on a planet located in the frontiers of known space (a 'rim world'), where their space liner crashed. The game is set in a universe where faster-than-light travel and superluminal communication are, so far, impossible, making large galactic empires inherently unfeasible. With its release on Steam the game came with the addition, among other things, of a scenario editor, allowing users to choose and modify different starting plots, with different numbers of characters, starting items and map effects available; however, the location of these plots still remained the same, that is, still on a 'rim world'"
                },
                new Product
                {
                    ProductID = 2,
                    SupplierID = 1,
                    Name = "Bannerlord",
                    CategoryID = 1,
                    UnitPrice = 160,
                    Discount = 0,
                    ImageUrl = Tools.PicturesDirectory + "/Pictures/ProductPictures/Steam/bannerlord_logo.png",
                    ShortDescription = "Mount & Blade II: Bannerlord, Orta Çağ temalı bir rol yapma oyunu olan Mount & Blade serisinin bir oyunudur. Oyun, Türk firması TaleWorlds tarafından geliştiştirilmektedir. Oyun Steam'de Ekim 2016'da çıkmıştır. Fakat oyun için bir indirme imkanı sunulmamıştır. Gamescom 2019'da oyunun erken erişim tarihi verilmiş. Ayrıca bu çıkış tarihi Mount & Blade:Warband'ın 10. yılına denk gelmiş olacak.",
                    LongDescription = "27 Eylül 2012'de bir Türk şirketi olan TaleWords tarafından duyurulmuştur. Oyunun Grafikleri daha iyi gölgeleme ve daha yüksek detaylı modellerle önceki oyun olan Mount & Blade: Warband'a göre belirgin bir şekilde daha iyi hâle getirilmiştir. Karakter animasyonları hareket yakalama (motion capture) teknolojisi kullanılarak oluşturulmuş ve yüz animasyonları da canlandırılan duygularla iyileştirilerek güncelleneceği söylendi.",
                    AltText = "Mount & Blade II: Bannerlord"
                },
                new Product
                {
                    ProductID = 3,
                    SupplierID = 1,
                    CategoryID = 3,
                    Name = "Grand Theft Auto V",
                    UnitPrice = 160,
                    Discount = 0,
                    ImageUrl = Tools.PicturesDirectory + "/Pictures/ProductPictures/Steam/gtav_logo.png",
                    ShortDescription = "Grand Theft Auto V (kısaca GTA V veya GTA 5), Rockstar North tarafından geliştirilen ve Rockstar Games tarafından yayımlanan açık uçlu aksiyon-macera tarzı video oyunu. Grand Theft Auto serisinin beşinci oyunudur. 17 Eylül 2013 tarihinde PlayStation 3 ve Xbox 360 için piyasaya çıkmıştır.",
                    LongDescription = "Oyunda Michael, Franklin ve Trevor isminde üç farklı karakter mevcuttur. Oyundaki üç karakterden her birinin farklı alanlarda farklı yetenekleri ve güçleri vardır. Örneğin, Trevor eski bir savaş pilotu olduğu için uçak, jet, helikopter ve diğer hava araçlarını kullanma konusunda diğer karakterlerden daha iyidir. Michael ise eski bir banka soyguncusu olduğundan silah kullanma konusunda diğerlerinden daha iyidir. Franklin ise araç hırsızı olduğundan otomobil ve motosiklet sürme konusunda diğerlerine göre çok daha ustadır. Oyuncular karakterler arasında geçiş yapabilme imkanına sahiplerdir.",
                    AltText = "Grand Theft Auto V"
                },
                new Product
                {
                    ProductID = 4,
                    SupplierID = 1,
                    CategoryID = 4,
                    Name = "Crusader Kings 2",
                    UnitPrice = 28,
                    Discount = 0,
                    ImageUrl = Tools.PicturesDirectory + "/Pictures/ProductPictures/Steam/ck2_logo.png",
                    ShortDescription = "Crusader Kings II is a grand strategy game set in the Middle Ages, developed by Paradox Development Studio and published by Paradox Interactive as a sequel to Crusader Kings.",
                    LongDescription = "The game is a dynasty simulator where the player controls a Medieval dynasty from 1066 to 1453, though the DLC The Old Gods and Charlemagne allow for earlier start dates of 867 and 769, respectively. Through the strategic use of war, marriages and assassinations among many other things, the player works to achieve success for their dynasty.",
                    AltText = "Crusader Kings 2"
                },
                new Product
                {
                    ProductID = 5,
                    SupplierID = 1,
                    CategoryID = 4,
                    Name = "Europa Universalis 4",
                    UnitPrice = 60,
                    Discount = 0,
                    ImageUrl = Tools.PicturesDirectory + "/Pictures/ProductPictures/Steam/eu4_logo.png",
                    ShortDescription = "Europa Universalis IV, Paradox Development Studio tarafından geliştirilmiş ve Paradox Interactive tarafından yayımlanmış strateji oyunu. Europa Universalis serisinin 4. üyesidir.EUIV ya da EU4 olarak da bilinir.",
                    LongDescription = "Oyunun temel ilkeleri dizinin daha önceki oyunlarına benzer. Oyuncu tek oyuncu olarak yapay zekaya karşı, çok oyuncu olarak diğer insanlara veya beraber yapay zekâya karşı oynayabilir. Bir devletin denetimini ele alarak diplomasi, politika ve askeri olanakları kullanmak ve diğer devletlere karşı galip olmak hedeflenir. Oyuncu birçok alternatif araç ile büyümeye çalışır. Oyunun zaman dilimi 1444 ila 1821 arasındadır, bu tarihler içerisinde oyuna oyunda yer alan istendiği ülkeyle, istendiği tarihte başlanabilir.",
                    AltText = "Europa Universalis 4"
                },
                new Product
                {
                    ProductID = 6,
                    SupplierID = 1,
                    CategoryID = 4,
                    Name = "Hearts Of Iron 4",
                    UnitPrice = 60,
                    Discount = 0,
                    ImageUrl = Tools.PicturesDirectory + "/Pictures/ProductPictures/Steam/hoi4_logo.png",
                    ShortDescription = "Hearts of Iron IV Paradox Development Studio tarafından geliştirilen ve Paradox Interactive tarafından yayımlanan strateji oyunu. Hearts of Iron III'ün devam oyunudur, diğer Hearts of Iron serisi oyunları gibi II. Dünya Savaşı'na odaklanır.",
                    LongDescription = "Oyuncular 1936 ve 1939 olmak üzere iki başlangıç tarihinden birini seçip ülkeleriyle savaşta zafer almaya çalışabilir. Oyun 2014 Ocak ayında duyuruldu. 2015 senesinin ilk çeyreğinde çıkması planlanıyordu ancak sonradan 2015'in ikinci çeyreğine ertelendi.[1] Johan Andersson oyunun istenilen seviyede olmadığını belirtip daha ileri bir tarihte çıkacağını açıkladı. 15 Mart 2016'da oyunun 6 Haziran tarihinde çıkacağı duyuruldu ve o tarihte çıktı.",
                    AltText = "Hearts Of Iron 4"
                },
                new Product
                {
                    ProductID = 7,
                    SupplierID = 1,
                    CategoryID = 3,
                    Name = "The Elder Scrolls V: Skyrim",
                    UnitPrice = 30,
                    Discount = 0,
                    ImageUrl = Tools.PicturesDirectory + "/Pictures/ProductPictures/Steam/skyrim_logo.png",
                    ShortDescription = "The Elder Scrolls V: Skyrim (yaygın olarak bilinen ismi Skyrim), Bethesda Game Studios tarafından geliştirilip Bethesda Softworks tarafından piyasaya sürülen serbest dünya tipi aksiyon RPG video oyunudur. The Elder Scrolls serisinin The Elder Scrolls IV: Oblivion'dan sonra gelen toplamda beşinci uyarlamasıdır.",
                    LongDescription = "Elder Scrolls serisinin geleneksel açık uçlu oynanış özelliği Skyrim'de de devam ettirildi. Oyuncu at üstünde veya yürüyerek ülkeyi dolaşabilir ve şehir, kasaba, zindan gibi yerler bir kez keşfedildikten sonra bu bölgelere hızlı seyahat edebilir. Görevler oyuncuya NPC'ler tarafından ya da Radyant Hikâye sistemi aracılığıyla verilir. Radyant Hikâye sistemi bir nevi oyuncunun yaptığı tüm seçimleri kaydeder ve oyundaki bazı görevlerin akışını değiştirir. Bu sistem, görev olarak, keşfedilmemiş yeni zindanlar oluşturur ve oyuncunun ülkeyle olan etkileşiminde değişiklikler yapar.",
                    AltText = "The Elder Scrolls V: Skyrim"
                },
                new Product
                {
                    ProductID = 8,
                    SupplierID = 1,
                    CategoryID = 3,
                    Name = "Fallout 4",
                    UnitPrice = 133,
                    Discount = 0,
                    ImageUrl = Tools.PicturesDirectory + "/Pictures/ProductPictures/Steam/fallout4_logo.png",
                    ShortDescription = "Fallout 4, Bethesda Game Studios'un geliştiriciliğini yaptığı ve Bethesda Softworks'ün yayımcılığını yaptığı açık dünya Aksiyon rol yapma oyunudur. Fallout serisinin beşinci büyük oyunudur ve Microsoft Windows, PlayStation 4 ve Xbox One için 10 Kasım 2015'te yayımlanmıştır.",
                    LongDescription = "Fallout 4, oynanış olarak Fallout 3'e benzer olacak, önceki oyunda olduğu gibi birinci görüş şahısı ya da üçüncü görüş şahısı ile oynanabilecek. Yeni özellik olarak ayrı parçalardan oluşabilecek zırh, ayrıntılı crafting sistemi, dinamik konuşma sistemi sayılabilir. Yeni crafting sistemiyle oyundaki bütün eşyalar belli bir parça için istenilen olabilecek. Dogmeat bu oyunda ölümsüz olacak. Oyuncular haritada isteği zaman istediği yere gidebilecek.Oyunda 50 temel silah çeşidi bulunacak ve çeşitli modifikasyonlar yapılarak 700'ün üzerinde farklı tarz silah oluşturabilecek. Power Armor, jetpack gibi çeşitli eşyalarla güçlendirilebilecek. Oyuna gelen yeni bir özellik ise kendi evini baştan aşağıya yenileyip değiştirebilmektir. Oyuncu, oyundaki eşyaları evi için kullanabilecek. Tüccarlar, şehrin birçok yerinde olup ev için malzeme satacak. Oyuncular, kendi evleri için taret ve tuzak gibi çeşitli savunma araçları inşa edebilecek.",
                    AltText = "Fallout 4"
                },
                new Product
                {
                    ProductID = 9,
                    SupplierID = 1,
                    CategoryID = 1,
                    Name = "Counter-Strike: Global Offensive",
                    UnitPrice = 20,
                    Discount = 0,
                    ImageUrl = Tools.PicturesDirectory + "/Pictures/ProductPictures/Steam/csgo_logo.png",
                    ShortDescription = "Counter-Strike: Global Offensive (kısaca CS: GO), Valve ve Hidden Path Entertainment tarafından geliştirilen çevrim içi bir birinci şahıs nişancı türünde aksiyon oyunudur.",
                    LongDescription = "Serinin önceki oyunları gibi Global Offensive, görev tabanlı birçok oyunculu birinci şahıs nişancı oyunudur. Oyuncular ilk önce görevleri tamamlamak veya düşman takımı yok etmek için teröristler (Terrorists) veya terörle mücadele ekibi (Counter-Terrorists) takımlarından birini seçerler. Örneğin, yıkım haritalarında (de_) teröristler bomba kurmaya çalışırken, terörle mücadele bombanın kurulmasını engellemeye veya kurulmuş bombayı imha etmeye çalışır. Global Offensive'e önceki oyunlardaki görevlere ek olarak silah yarışı (arms race) denilen bir mod eklenmiş, bu modla birlikte klasik Counter-Strike haritalarının yanında farklı haritalar da oyuna dahil edilmiştir.",
                    AltText = "Counter-Strike: Global Offensive"
                },
                new Product
                {
                    ProductID = 10,
                    SupplierID = 1,
                    CategoryID = 1,
                    Name = "Half-Life",
                    UnitPrice = 18,
                    Discount = 0,
                    ImageUrl = Tools.PicturesDirectory + "/Pictures/ProductPictures/Steam/half-life_logo.png",
                    ShortDescription = "Half-Life, 1998 yılında Sierra Studios tarafından yayımlanan ve Valve tarafında üretilen birinci şahıs nişancı bilim-kurgu video oyunudur. Oyun, serinin ilk oyunu olmakla beraber aynı zamanda Valve'nin ürettiği ilk oyundur.",
                    LongDescription = "Oyuncu, bir ışınlanma deneyinin ters gitmesi sonucu Xen olarak bilinen başka bir boyuttan Black Mesa Araştırma Tesisine ışınlanan uzaylılardan savaşarak ve bulmacaları çözerek tesisden kaçmaya çalışan Dr. Gordon Freeman rolünü üstleniyor. Zamanın diğer oyunlarına göre Half-Life'da ara sahneler yoktur. Oyuncu her zaman Freeman'nı kontrol ediyor. Her zaman onun gözünden görüyor. Valve'nin kurucularından olan Gabe Newell ''ekip olarak oyunun sadece ateş etmeye meyilli bir oyundan çok daha fazla olmasını istedik.'' demiştir.",
                    AltText = "Half-Life"
                },
                new Product
                {
                    ProductID = 11,
                    SupplierID = 2,
                    CategoryID = 5,
                    Name = "The Sims 4",
                    UnitPrice = 200,
                    Discount = 0,
                    ImageUrl = Tools.PicturesDirectory + "/Pictures/ProductPictures/Steam/sims4_logo.png",
                    ShortDescription = "The Sims 4, Maxis ve The Sims Studio tarafından geliştirilen ve Electronic Arts tarafından yayınlanan 2014 tarihli yaşam simülasyonu oyunudur. Electronic Arts, 6 Mayıs 2013 tarihinde bir duyuru yaparak oyunu 2014 yılında piyasaya süreceğini ve Microsoft Windows, Mac OS X platformlarında oynanacağını bildirdi.",
                    LongDescription = "The Sims 4, serinin önceki oyunları gibi yaşam simülasyonu oyunudur. Oyuncular bir Sim karakteri yaratırlar ve oyunda farklı Sim kişiliklerini keşfederek oyuna yön verirler. Simler daha önceki oyunlardan farklı olarak aynı anda iki fiziksel eylemi gerçekleştirebilir. Ayrıca Simlerin modları da oyun akışını değiştirebilir. Örneğin kızgın ya da heyecanlı bir Sim, verilen bir görevi daha hızlı yapar.",
                    AltText = "The Sims 4"
                },
                new Product
                {
                    ProductID = 12,
                    SupplierID = 2,
                    CategoryID = 1,
                    Name = "Battlefield 4",
                    UnitPrice = 100,
                    Discount = 0,
                    ImageUrl = Tools.PicturesDirectory + "/Pictures/ProductPictures/Steam/battlefield4_logo.png",
                    ShortDescription = "Battlefield 4 bir birinci şahıs nişancı video oyunudur ve İsveç’teki EA Digital Illusions CE (DICE) tarafından yapılıp Electronic Arts tarafından yayınlanmıştır. Oyun 2011’de çıkan Battlefield 3’ün devamıdır.",
                    LongDescription = "Oyunun çerçeveleri Battlefield 3’e göre genel olarak aynı kaldı. Çerçevenin sol altında harita ve pusula, ve görevle ilgili hedefler; sağ altında ise silah bilgileri yer almaktadır. Mini harita ve oyunun ana menüsü, 3 önemli şeyi belirtmektedir. Bunlar, dostların mavi ile gösterilmesi, ekip arkadaşlarının yeşil ile gösterilmesi, düşmanların ise turuncu ya da kırmızı ile gösterilmesidir. Oyunda Battlefield 3’te olduğu gibi bazı silahların iki çeşit atış modu vardır; bunlardan biri tekli atışken, diğeri de çoklu atış modudur.",
                    AltText = "Battlefield 4"
                },
                new Product
                {
                    ProductID = 13,
                    SupplierID = 2,
                    CategoryID = 1,
                    Name = "FIFA 19",
                    UnitPrice = 245,
                    Discount = 0,
                    ImageUrl = Tools.PicturesDirectory + "/Pictures/ProductPictures/Steam/battlefield4_logo.png",
                    ShortDescription = "FIFA 19, EA Vancouver tarafından geliştirilen ve Electronic Arts şirketinin yayımcılığını yaptığı spor simülasyon video oyunu olarak sunulan FIFA serisi. 6 Haziran 2018 tarihinde yapılan E3 2018 basın konferansında, oyunun 28 Eylül 2018 tarihinde PlayStation 3, PlayStation 4, Xbox 360, Xbox One, Nintendo Switch ve Microsoft Windows platformlarında çıkmış olacağı açıklanmıştır.",
                    LongDescription = "FIFA serisinin 26. oyunudur. FIFA 18 oyununda da olduğu gibi oyunun standart sürümünün kapağında Cristiano Ronaldo yer almıştır. Ancak, İspanyol kulübü Real Madrid'den İtalyan ekibi Juventus'a beklenmedik transferi sonrası kapak resmi yenilenmiştir. Ayrıca Şampiyonlar sürümünün kapağında Neymar yer almıştır. Şubat 2019'da düzenlenen standart sürümün kapağında Neymar, Kevin De Bruyne ve Paulo Dybala'ya yer verilmiştir.",
                    AltText = "FIFA 19"
                }
            );
            #endregion

        }
    }
}
