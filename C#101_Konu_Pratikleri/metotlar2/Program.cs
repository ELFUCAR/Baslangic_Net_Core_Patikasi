namespace metotlar2;
class Program
{
    static void Main(string[] args)
    {
        string sayi="999";
        //out parametreler
        bool sonuc=int.TryParse(sayi,out int outSayi);
        if(sonuc){
            Console.WriteLine("Basarili!");
            Console.WriteLine(outSayi);
        }
        else{
            Console.WriteLine("Basarisiz!");
        }

        Metotlar instance=new Metotlar();
        instance.Topla(4,5,out int toplamSonucu);
        Console.WriteLine(toplamSonucu); 

       // Console.WriteLine("Hello, World!");
       //metot aşırı yüklenme 
       int ifade=999;
       instance.EkranYazdir(Convert.ToString(ifade));
       instance.EkranYazdir(ifade);
       instance.EkranYazdir("elif"+"ucar");

       //metot imzası
       //metotadi+parametre sayısı+parametre
    }
}

class Metotlar{
    public void Topla(int a,int b,out int toplam){
        toplam=a+b;
    }

    public void EkranYazdir(string veri){
        Console.WriteLine(veri);
    }
     public void EkranYazdir(int veri){
        Console.WriteLine(veri);
    }

    public void EkranYazdir(string veri1,string veri2){
        Console.WriteLine(veri1+veri2);
    }
}
