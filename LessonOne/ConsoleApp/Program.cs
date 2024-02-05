
using Business.Concrete;
using Entities.Concrete;

SelamVer(isim: "Altan");
SelamVer(isim: "İlkay");
SelamVer(isim: "İsmet");
SelamVer();
int sonuc = Topla();




string ogrenci1 = "Altan";
string ogrenci2 = "İlkay";
string ogrenci3 = "İsmet";





string[] ogrenciler = new string[2];
ogrenciler[0] = "Altan";
ogrenciler[1] = "İlkay";


ogrenciler = new string[4];
ogrenciler[3] = "Ali";




for (int i = 0; i < ogrenciler.Length; i++)
{
    Console.WriteLine(ogrenciler[i]);
}


string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };
sehirler2 = sehirler1;
sehirler1[0] = "Adana";
Console.WriteLine(sehirler2[0]);


Person person1 = new Person();
person1.FirstName = "Altan";
person1.LastName = "Emuce";
person1.DateOfBirthYear = 1996;
person1.NationalIdentity = 11057048;


Person person2 = new Person();
person2.FirstName = "Altan";


foreach (string sehir in sehirler1)
{
    Console.WriteLine(sehir);
}

//generic collection 
List<string> yeniSehirler1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" };
yeniSehirler1.Add("Adana 1"); //listeye yeni eklenen veriyi diğerlerini kaybederek değil onlarla beraber çalışmasını sağlar
foreach (string sehir in yeniSehirler1)
{
    Console.WriteLine(sehir);
}



PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);

Console.ReadLine();
        

static void SelamVer(string isim = "noname")
//method yöntemi, parantez içindekiler parametre, noname eğer boş gelirse (default parametre)
{
    Console.WriteLine("Merhaba " + isim);
}
static int Topla(int sayi1 = 12, int sayi2 = 13)
{
    int sonuc = sayi1 + sayi2;
    Console.WriteLine("Toplam: " + sonuc.ToString());
    return sonuc;
}