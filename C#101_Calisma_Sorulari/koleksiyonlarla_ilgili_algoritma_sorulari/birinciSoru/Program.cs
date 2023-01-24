using System.Collections;

namespace birinciSoru;
class Program
{
    static void Main(string[] args)
    {
        int num;
        string Value=" ";
        
        ArrayList asalListe=new ArrayList();
        ArrayList asalOlmayanListe=new ArrayList();

        Console.WriteLine("Enter number");

        for(int i=0;i<5;i++){
            Value=Console.ReadLine();


//Sayı asal mı degil mi listelere eklendi
            if(Convert.ToInt32(Value)<=0 && Value==" "){
                    Console.WriteLine("enter a pozitif number:");
            }

                num=Convert.ToInt32(Value);
            if(num%2==0 || num%3==0 || num%5==0 || num%7==0){
                    asalOlmayanListe.Add(num);
            }
            else if(num%2!=0 || num%3!=0 || num%5!=0 || num%7!=0){
                    asalListe.Add(num);
            }
        }
//listelerdeki elemanla büyükten küçüğe doğru sıralanacak
        Console.WriteLine("***AsalListe Sort****");
        asalListe.Sort();

        foreach(var item in asalListe)
              Console.WriteLine(item);


        Console.WriteLine("***AsalOlmayanListe Sort****");
        asalOlmayanListe.Sort();

        foreach(var item in asalOlmayanListe)
              Console.WriteLine(item);


    //listelerin uzunlukları ve ortalamaları bulundu   
        int asalCount=asalListe.Count;
        int asalOlmayanCount=asalOlmayanListe.Count;
        int asalOrt=0,asalTop=0;
        int asalOlmayanOrt=0, asalOlmayanTop=0;

         foreach(int item in asalListe){
                asalTop= item + asalTop;
         }
        asalOrt=asalTop/asalCount;

        foreach(int item in asalOlmayanListe){
                        asalOlmayanTop= item + asalOlmayanTop;
        }
        asalOlmayanOrt=asalOlmayanTop/asalOlmayanCount;

        Console.WriteLine("Asal Liste lenght: "+ asalCount);
        Console.WriteLine("ortalama: "+ asalOrt);
        Console.WriteLine("Asal Olmayan Liste lenght: "+ asalOlmayanCount);
        Console.WriteLine("ortalama: "+asalOlmayanOrt);





}
}

