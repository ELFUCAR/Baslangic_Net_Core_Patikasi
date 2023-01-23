namespace C_101_Operatorler;
class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine("***Atama ve işlemli Atama operatörleri");
       // int i=2;
        int y=3;
        y=y+2;
        Console.WriteLine(y);
        y+=3;
        Console.WriteLine(y);

        Console.WriteLine("***Mantıksal operatörler");
        bool isSuccess = true;
        bool isCompleted = false;

         if(isSuccess && isCompleted){
             Console.WriteLine("Perfect");
         }

         if(isSuccess || isCompleted){
            Console.WriteLine("Great");
         }

         if(isSuccess && !isCompleted){
            Console.WriteLine("Fine");
         }

        Console.WriteLine("***ilişkisel operatörler");
        int a=3;
        int b=5;
        bool sonuc=a<b;

        Console.WriteLine(sonuc);
        sonuc= a>b;
        Console.WriteLine(sonuc);
        sonuc= a>=b;
        Console.WriteLine(sonuc);
        sonuc= a<=b;
        Console.WriteLine(sonuc);
        sonuc= a==b;
        Console.WriteLine(sonuc);
        sonuc= a!=b;
        Console.WriteLine(sonuc);

        Console.WriteLine("***Aritmetik operatörler");
        int sayi1=10;
        int sayi2=2;
        int sonuc1=sayi1/sayi2;
        Console.WriteLine(sonuc1);
        sonuc1=sayi2*sayi1;
        Console.WriteLine(sonuc1);
        sonuc1=sayi1+sayi2;
        Console.WriteLine(sonuc1);
        sonuc1=sayi1-sayi2;
        Console.WriteLine(sonuc1);


        int sonuc2=20%3;
        Console.WriteLine(sonuc2);



    }
}
