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

            //Seed Data
            builder.HasData
            (
                new Product
                {
                    ProductID = 1,
                    SupplierID = 1,
                    Name = "RimWorld",
                    CategoryID = 4,
                    UnitPrice = 50,
                    Discount = 0,
                    ImageUrl = "/images/ProductPictures/Steam/rimworld_logo.png",
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
                    ImageUrl = "/images/ProductPictures/Steam/bannerlord_logo.png",
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
                    ImageUrl = "/images/ProductPictures/Steam/gtav_logo.png",
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
                    ImageUrl = "/images/ProductPictures/Steam/ck2_logo.png",
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
                    ImageUrl = "/images/ProductPictures/Steam/eu4_logo.png",
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
                    ImageUrl = "/images/ProductPictures/Steam/hoi4_logo.png",
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
                    ImageUrl = "/images/ProductPictures/Steam/skyrim_logo.png",
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
                    ImageUrl = "/images/ProductPictures/Steam/fallout4_logo.png",
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
                    ImageUrl = "/images/ProductPictures/Steam/csgo_logo.png",
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
                    ImageUrl = "/images/ProductPictures/Steam/half-life_logo.png",
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
                    ImageUrl = "/images/ProductPictures/Steam/sims4_logo.png",
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
                    ImageUrl = "/images/ProductPictures/Steam/battlefield4_logo.png",
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
                    ImageUrl = "/images/ProductPictures/Steam/fifa19_logo.png",
                    ShortDescription = "FIFA 19, EA Vancouver tarafından geliştirilen ve Electronic Arts şirketinin yayımcılığını yaptığı spor simülasyon video oyunu olarak sunulan FIFA serisi. 6 Haziran 2018 tarihinde yapılan E3 2018 basın konferansında, oyunun 28 Eylül 2018 tarihinde PlayStation 3, PlayStation 4, Xbox 360, Xbox One, Nintendo Switch ve Microsoft Windows platformlarında çıkmış olacağı açıklanmıştır.",
                    LongDescription = "FIFA serisinin 26. oyunudur. FIFA 18 oyununda da olduğu gibi oyunun standart sürümünün kapağında Cristiano Ronaldo yer almıştır. Ancak, İspanyol kulübü Real Madrid'den İtalyan ekibi Juventus'a beklenmedik transferi sonrası kapak resmi yenilenmiştir. Ayrıca Şampiyonlar sürümünün kapağında Neymar yer almıştır. Şubat 2019'da düzenlenen standart sürümün kapağında Neymar, Kevin De Bruyne ve Paulo Dybala'ya yer verilmiştir.",
                    AltText = "FIFA 19"
                },
                new Product
                {
                    ProductID = 14,
                    SupplierID = 2,
                    CategoryID = 6,
                    Name = "A Way Out",
                    UnitPrice = 155,
                    Discount = 0,
                    ImageUrl = "/images/ProductPictures/Steam/awayout_logo.png",
                    ShortDescription = "A Way Out is an action-adventure game developed by Hazelight Studios and published by Electronic Arts under their EA Originals program. It is the second video game to be directed by Josef Fares after Brothers: A Tale of Two Sons. The game has no single-player option: it is only playable in either online or local split screen co-op between two players.",
                    LongDescription = "A Way Out is an action-adventure game played from a third-person perspective. It is specifically designed for split-screen cooperative multiplayer, which means that it must be played with another player through either local or online play. In the game, players control Leo and Vincent, two convicted prisoners who must break out of prison and stay on the run from authorities. As the story of both protagonists is told simultaneously, their progress may not be synchronized, which may result in one player being able to control their character, while another is watching a cutscene. Players need to cooperate with each other in order to progress, and each situation can be approached differently, with both characters taking different roles.",
                    AltText = "A Way Out"
                },
                new Product
                {
                    ProductID = 15,
                    SupplierID = 2,
                    CategoryID = 2,
                    Name = "Dead Space 3",
                    UnitPrice = 200,
                    Discount = 0,
                    ImageUrl = "/images/ProductPictures/Steam/deadspace3_logo.png",
                    ShortDescription = "Dead Space 3 is a survival horror action-adventure video game developed by Visceral Games and published by Electronic Arts. Announced at E3 2012 and released internationally in February 2013, it is the sequel to Dead Space 2 and the third main entry in the Dead Space series.",
                    LongDescription = "In Dead Space 3, Isaac Clarke teams up with EarthGov Sergeant John Carver as they travel to Tau Volantis, an ice-covered planet, to end the Marker and Necromorph threat for good. Development of the game began after the completion of Dead Space 2.It is the only game in the Dead Space series to feature online co - op. The game received positive reviews from game critics upon release; reviewers praised the game's rewarding action gameplay, although criticism was directed at the focus on action over horror, as well as a weak and unfocused story compared to its predecessors. Despite poor sales, EA and Visceral expressed interest in a sequel. However, Visceral Games was shut down in 2017, and no confirmation that a new installment in the series is being developed by another studio.",
                    AltText = "Dead Space 3"
                },
                new Product
                {
                    ProductID = 16,
                    SupplierID = 2,
                    CategoryID = 4,
                    Name = "Command & Conquer Red Alert 3",
                    UnitPrice = 200,
                    Discount = 0,
                    ImageUrl = "/images/ProductPictures/Steam/cc-redalert_logo.png",
                    ShortDescription = "Command & Conquer: Red Alert 3 (Kısaca C&C:RA3) EA Los Angeles tarafından geliştirilip, Electronic Arts tarafından 2008'de yayınlanan bir gerçek zamanlı strateji oyunu. 14 Şubat 2008'de EA LA tarafından geliştirildiği duyuruldu ve 28 Ekim 2008'de Windows tabanlı bilgisayarlar için; 11 Kasım'da Xbox 360 konsolu için yayınlandı.",
                    LongDescription = "Sovyetler ile Müttefikler arasındaki savaşta müttefikler üstünlüğü sağlamak ve Sovyetler savaşı kaybetmek üzereydi. Bunun üzerine Premier Cherdenko, gizli yürüttüğü bir zaman makinesi projesini hayata geçirmeye karar vermişti.Zaman makinesi tam olarak hazır değildi ve bu makineyi icat eden doktor Zelisnsky Cherdenko'yu durdumayı çalışmıştı ama Cherkenko yanına General Krukov'u da alıp geçmişe gitmeye kararlıydı.",
                    AltText = "Command & Conquer Red Alert 3"
                },
                new Product
                {
                    ProductID = 17,
                    SupplierID = 2,
                    CategoryID = 6,
                    Name = "Mass Effect",
                    UnitPrice = 100,
                    Discount = 0,
                    ImageUrl = "/images/ProductPictures/Steam/masseffect_logo.png",
                    ShortDescription = "Oyun gelecekte 2183 yılında geçmektedir. Oyuncu Commander Shepard isimli bir karakteri canlandirir ve bu karakter galaksiyi gemisi SSV Normandy ile araştırma altinda tutmaktadir.",
                    LongDescription = "Mass Effect'in devamı olan Mass Effect 2, 26 ocak 2010 tarihinde piyasaya sürülmüştür. Mass Effect 2'de birinci oyundan kalan kayıt dosyalarını aktarabilirsiniz ki bu sizin oyun boyunca yapacağınız şeyleride değiştirecektir.Mass Effect serisi Mass Effect 2 ile beraber IGN ve EA Games Entertainment açıklamasıyla tüm platformlarda 34.5 milyon satarak iyi bir başarı elde etmiştir.Aynı zamanda EA Games in en çok kazandıran ilk 5 oyunu arasında yer almaktadır.",
                    AltText = "Mass Effect"
                },
                new Product
                {
                    ProductID = 18,
                    SupplierID = 2,
                    CategoryID = 3,
                    Name = "Dragon Age: Origins",
                    UnitPrice = 54,
                    Discount = 0,
                    ImageUrl = "/images/ProductPictures/Steam/da-origins_logo.png",
                    ShortDescription = "Dragon Age: Origins (Türkçesi: Ejderha Çağı: Başlangıçlar), BioWare tarafından geliştirilen ve Electronic Arts tarafından dağıtılan tek oyunculu rol yapma video oyunudur. Dragon Age serisinin ilk oyunu olup Kasım 2009'da Microsoft Windows, PlayStation 3 ve Xbox 360; 21 Aralık 2009'da ise OS X için satışa sunulmuştur.",
                    LongDescription = "Kurgusal Ferelden krallığında, sivil sürtüşmelerin yaşandığı bir dönemde kurgulanmış oyunda oyuncular; bir elf, insan ve cüce geçmişinden gelen bir savaşçı, büyücü veya bir hırsız rolünde; krallığa yaklaşmakta olan ve 'Darkspawn' (Zebâni) olarak bilinen şeytani güçlerin istilasına karşı krallığı bir araya getirmekle görevlidirler. Oyuncunun karakteri, eskilerden beri var olan 'Grey Warden' tertibinde silâh altına alınır. Gri Muhafızlar, Zebâni olarak bilinen şeytani güçlere karşı gelip, 'Yıkım' (Blight) olarak bilinen, zebânileri komuta eden Şahlanmış Şeytan'ı (Archdemon) yenmekle görevlendirilmişlerdir. Oyun, kuş bakışı perspektife değiştirilebilen üçüncü şahıs perspektifi ile oynanır. Oyun boyunca oyuncular, oyunun ana hikâyesinde ve ilerlenmesinde önemli rol oynayan ve maceraları boyunca eşlik edecek çeşitli karakterler ile karşılaşırlar.",
                    AltText = "Dragon Age: Origins"
                },
                new Product
                {
                    ProductID = 19,
                    SupplierID = 2,
                    CategoryID = 1,
                    Name = "Crysis 3",
                    UnitPrice = 54,
                    Discount = 0,
                    ImageUrl = "/images/ProductPictures/Steam/crysis3_logo.png",
                    ShortDescription = "Crysis 3, Crytek tarafından geliştirilmiş, Electronic Arts tarafından ise yayımcılığı yapılmış olan bilim kurgu türü video oyunudur. Crysis 3 serinin diğer oyunları gibi Türkçe alt yazı ve seslendirme içermektedir.",
                    LongDescription = "Crysis 3, Crysis 2'den 24 yıl sonrasında yani 2047 yılında ve bir kez daha New York şehrinde geçiyor. İkinci oyunda gerçekleşen büyük savaşın ardından Prophet, Crynet tarafından hapse atılır ve Cephler (uzaylılar) tarafından dünya üzerinde o ana kadar görülmemiş en büyük işgal gerçekleştirilir. Ayrıca New York, Crysis 2'nin sonundaki büyük patlamadan sonra sular altında kalır ve şehir ormanımsı bir hal alır. Bu olaylardan sonra şehrin bir kısmı Cell Corporation tarafından Nanodome adı verilen dev bir fanusun içine alınır. Nanodome içerisindeki alana ise 'New York City Liberty Dome' adı verilir. Cell Corporation bu fanusun amacının karantina bölgesi oluşturmak ve insanları uzaylılardan korumak olduğunu söylese de, Prophet, Cell Corporation'ın Nanodome içerisinde dünyayı ele geçirmek için teknoloji geliştirdiğini öngörür. Crysis 3'te ana karakter Prophet olacak. Prophet bu defa intikam için savaşacak.",
                    AltText = "Crysis 3"
                },
                new Product
                {
                    ProductID = 20,
                    SupplierID = 2,
                    CategoryID = 1,
                    Name = "Star Wars Battlefront",
                    UnitPrice = 100,
                    Discount = 0,
                    ImageUrl = "/images/ProductPictures/Steam/starwars-battlefron_logo.png",
                    ShortDescription = "Star Wars: Battlefront, DICE tarafından geliştirilen, Electronic Arts'ın ise yayımcılığı yaptığı video oyunudur.",
                    LongDescription = "Oyunda hikâye modu bulunmamakta ve genel olarak çok oyunculu bölüme odaklı. Ama oyuncuların offline olarak, tek başlarına oynayabilecekleri görevler de bulunuyor. Ayrıca oyuncular bu görevleri arkadaşlarıyla birlikte Co-op (kooperatif) olarak da oynayabilirler. Co-op (kooperatif) görevler konsollarda split screen olarak oynanabilir. Oyun hem birinci şahıs nişancı hem de üçüncü şahıs nişancı olarak oynanabiliyor. Oyuncular Rebel Alliance (Asi Birliği) ya da Stormtrooper taraflarından birini seçerek birbirleriyle savaşıyorlar. Ayrıca Darth Vader ve Boba Fett gibi Star Wars evreninin önemli karakterleri de oynanabiliyor. Oyuncular karakterlerini özelleştirebilirler. Hoth, Endor, Tatooine, Sullust gezegenlerinde geçecek olan oyunda 12 tane harita bulunuyor. Haritalar 40 oyuncuyu destekliyor. Oyunda X-Wing, Millennium Falcon, TIE Fighters ve AT-ST Walker gibi oyuncuların kullanabileceği birçok araç bulunuyor.",
                    AltText = "Star Wars Battlefront"
                }
            );

        }
    }
}
