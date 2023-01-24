namespace koleksiyonlar_generik;
class Program
{
    static void Main(string[] args)
    {
       //List<T> class
       //System.Collection.Generic
       //T-> object türündedir

       List<int> sayiListesi = new List<int>();

        sayiListesi.Add(23);
        sayiListesi.Add(10);
        sayiListesi.Add(4);
        sayiListesi.Add(5);
        sayiListesi.Add(92);
        sayiListesi.Add(34);
       
       
       List<string> renkListesi=new List<string>();
       renkListesi.Add("Kirmizi");
       renkListesi.Add("Mavi");
       renkListesi.Add("Turunucu");
       renkListesi.Add("Sari");
       renkListesi.Add("Yesil");

        //Count
        Console.WriteLine(renkListesi.Count);
        Console.WriteLine(sayiListesi.Count);

        //foreach ve List.ForEach ile elemanlara erişim
        foreach(var sayi in sayiListesi)
            Console.WriteLine(sayi);
        foreach(var renk in renkListesi)
            Console.WriteLine(renk);

        sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
        renkListesi.ForEach(renk=> Console.WriteLine(renk));

        //Listeden eleman cıkarma
        sayiListesi.Remove(4);
        renkListesi.Remove("Yesil");

        sayiListesi.RemoveAt(0);
        renkListesi.RemoveAt(1);

        sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
        renkListesi.ForEach(renk=> Console.WriteLine(renk));

        //liste içerisinde arama
        if(sayiListesi.Contains(10))
            Console.WriteLine("10 liste icerisinde bulundu!");

        //eleman ile index'e erisme
        Console.WriteLine(renkListesi.BinarySearch("Sari"));  


        //Diziyi List'e cevirme
        string[] hayvanlar ={"Kedi","Kopek","Kus"};
        List<string> hayvanListesi=new List<string>(hayvanlar);

        //Listeyi temizleme
        hayvanListesi.Clear();

        //List icerisnde nesne tutmak
        List<Kullanicilar> kullaniciListesi = new List<Kullanicilar>();

        Kullanicilar kullanici1=new Kullanicilar();
        kullanici1.Isim="Ayse";
        kullanici1.Soyisim="Yilmaz";
        kullanici1.Yas=26;

        Kullanicilar kullanici2=new Kullanicilar();
        kullanici2.Isim="Ahmet";
        kullanici2.Soyisim="Yildirim";
        kullanici2.Yas=30;

        kullaniciListesi.Add(kullanici1);
        kullaniciListesi.Add(kullanici2);

        List<Kullanicilar> yeniListe= new List<Kullanicilar>();

        yeniListe.Add(new Kullanicilar(){
                Isim="Deniz",
                Soyisim="Caliskan",
                Yas=24

        });

        foreach (var kullanici in kullaniciListesi){
            Console.WriteLine("Kullanici adi:"+ kullanici.Isim);
            Console.WriteLine("Kullanici soyadi:"+ kullanici.Soyisim);
            Console.WriteLine("Kullanici yas:"+ kullanici.Yas);
        }
        //yeniListe.Clear();


    }
}

public class Kullanicilar{

private string isim;
private string soyisim;
private int yas;
public string Isim{ get =>isim; set=>isim=value; }
public string Soyisim{ get =>soyisim; set=>soyisim=value; }

public int Yas{ get =>Yas; set=> yas=value; }


}
