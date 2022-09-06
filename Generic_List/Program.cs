// List <T> class
//System.Collections.Generic
// T --> object türündedir.

List<int> sayiListesi = new List<int>();

sayiListesi.Add(23);
sayiListesi.Add(10);
sayiListesi.Add(4);
sayiListesi.Add(5);
sayiListesi.Add(92);
sayiListesi.Add(34);

List<string> renkListesi = new List<string>();

renkListesi.Add("Kırmızı");
renkListesi.Add("Mavi");
renkListesi.Add("Turuncu");
renkListesi.Add("Sarı");
renkListesi.Add("Yeşil");

//Count
Console.WriteLine(renkListesi.Count);
Console.WriteLine(sayiListesi.Count);

//Foreach ve List.Foreach ile elemanlara erişim
foreach (var sayi in sayiListesi)
{
    Console.WriteLine(sayi);
}

foreach (var renk in renkListesi)
    Console.WriteLine(renk);

sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
renkListesi.ForEach(renk=> Console.WriteLine(renk));

//Listeden eleman çıkarma
sayiListesi.Remove(4);
renkListesi.Remove("Yeşil");

sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
renkListesi.ForEach(renk=> Console.WriteLine(renk));

sayiListesi.RemoveAt(0);
renkListesi.RemoveAt(1);

sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
renkListesi.ForEach(renk=> Console.WriteLine(renk));

//Liste içersinde Arama
if (sayiListesi.Contains(10))
{
    Console.WriteLine("10 Liste içerisinde bulundu!");
}

//Eleman ile index'e erişme
Console.WriteLine(renkListesi.BinarySearch("Sarı"));

//Diziyi List'e çevirme
string[] hayvanlar = {"Kedi","Köpek","Kuş"};

List<string> hayvanListesi = new List<string>(hayvanlar);

//Listeyi nasıl temizleriz
hayvanListesi.Clear();

//List içersinde nese tutmak
List<Kullanıcılar> kullancıListesi = new List<Kullanıcılar>();

Kullanıcılar kullanıcı1 = new Kullanıcılar();
kullanıcı1.Isim = "deniz";
kullanıcı1.Soyisim = "denizov";
kullanıcı1.Yas = 35;

Kullanıcılar kullanıcı2 = new Kullanıcılar();
kullanıcı2.Isim = "denden";
kullanıcı2.Soyisim = "dandan";
kullanıcı2.Yas = 22;

kullancıListesi.Add(kullanıcı1);
kullancıListesi.Add(kullanıcı2);

List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();

yeniListe.Add(new Kullanıcılar(){
Isim = "MrD",
Soyisim="Yen",
Yas = 23
});

foreach (var kullanıcı in kullancıListesi)
{
    Console.WriteLine("Kullanıcı Adı:" + kullanıcı.Isim);
    Console.WriteLine("Kullanıcı Soyadı:" + kullanıcı.Soyisim);
    Console.WriteLine("Kullanıcı Yaşı:" + kullanıcı.Yas);
}

//oreach (var kullanıcı in yeniListe)
//{
//    Console.WriteLine("Kullanıcı Adı:" + kullanıcı.Isim);
//    Console.WriteLine("Kullanıcı Soyadı:" + kullanıcı.Soyisim);
//    Console.WriteLine("Kullanıcı Yaşı:" + kullanıcı.Yas);
//}

yeniListe.Clear();


public class Kullanıcılar
{
    private string isim;
    private string soyisim;
    private int yas;

    public string Isim { get => isim; set => isim = value; }
    public string Soyisim { get => soyisim; set => soyisim = value; }
    public int Yas { get => yas; set => yas = value; }
}