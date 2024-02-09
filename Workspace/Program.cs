//Degiskenler();

using Business.Concrete;
using Entities.Concrete;

static void Degiskenler()
{
    string msg = "Merhaba";
    double tutar = 100000.5;
    double kdv = 1.18;
    int sayi = 100;
    bool isLogin = false;

    string ad = "Alper";
    string soyad = "Çelik";
    int dogumYili = 1989;
    long tcNo = 12345678910;

    Console.WriteLine(msg);
    Console.WriteLine("Tutar: " + tutar * kdv);
}

Person vatandas1 = new Person();

vatandas1.FirstName = "Alper";
vatandas1.LastName = "Çelik";
vatandas1.NationalIdentity = 12345678910;
vatandas1.DateOfBirthYear = 1989;

Console.WriteLine("First Name: " + vatandas1.FirstName);
Console.WriteLine("Last Name: " + vatandas1.LastName);
Console.WriteLine("Birth Year: " + vatandas1.NationalIdentity);
Console.WriteLine("TC No: " + vatandas1.DateOfBirthYear);

//public class Vatandas
//{
//    public string FirstName { get; set; }
//    public string LastName { get; set; }
//    public int BirthYear { get; set; }
//    public long TcNo { get; set; }
//}

// Business Abstract Soyut Nesneleri Tutar 
// Business Concrete Somut Nesneleri Tutar

static void Greeting()
{
    Console.WriteLine("Merhaba");
}

static void Greeting1(string name)
{
    Console.WriteLine("Merhaba, " + name);
}
static void Greeting2(string name="no name")
{
    Console.WriteLine("Merhaba, "+name);
}

static int Topla(int num1, int num2) 
{
    int total = num1 + num2;
    Console.WriteLine("Toplam: " + total);
    return total;
}


//Greeting();
//Greeting();
//Greeting1("Alper");
//Greeting2();
//Topla(3,5);

// Diziler (Arrays)


string[] ogrenciler = new string[3];
ogrenciler[0] = "Ahmet";
ogrenciler[1] = "Ayşe";
ogrenciler[2] = "Mehmet";

for (int i = 0; i < ogrenciler.Length; i++)
{
    Console.WriteLine(ogrenciler[i]);
}

/*Referans tipler
 * Array
 * Class
 * Interface
 * Abstract
 */

/*Değer tipler
 * int
 * double
 * bool vb.
 */

string[] sehirler1 = { "Ankara", "İstanbul", "İzmir" };
string[] sehirler2 = { "Antalya", "Bursa", "Diyarbakır" };
sehirler2 = sehirler1;
sehirler1[0] = "Adana";
  

foreach (string sehir in sehirler1)
{
    Console.WriteLine(sehir);
}
Console.WriteLine("******************************");
List<string> yeniSehirler1 = new List<string> { "Ankara 1","İstanbul 1","İzmir 1" };

yeniSehirler1.Add("Adana 1");

foreach (string sehir1 in yeniSehirler1)
{
    Console.WriteLine(sehir1);
}

Console.WriteLine("******************************");

Person person1 = new Person();
person1.FirstName = "Alper";
person1.LastName = "Çelik";
person1.NationalIdentity = 123;
person1.DateOfBirthYear = 1989;

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);