namespace metotlar;
class Program
{
    static void Main(string[] args)
    {
        int a=2;
        int b=3;
        Console.WriteLine(a+b);

        int sonuc=Topla(a,b);
        Console.WriteLine(sonuc);
        //Console.WriteLine("Hello, World!");
    }

        static int Topla(int deger1,int deger2){
                return(deger1+deger2);
        }

}

class Metotlar{
    public void EkranaYazdir(string veri){
        Console.WriteLine(veri);
    }
    public int ArttirveTopla(int deger1,int deger2){
        deger1+=1;
        deger2+=1;
        return deger1+deger2;
    }

}
