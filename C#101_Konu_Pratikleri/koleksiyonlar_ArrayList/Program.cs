using System.Collections;

namespace koleksiyonlar_ArrayList;
class Program
{
    static void Main(string[] args)
    {
       //system.Collection namespace
        ArrayList liste = new ArrayList();
        liste.Add("Ayse");
        liste.Add(2);
        liste.Add(true);
        liste.Add('A');

        //icerisnde verilere erisim
        Console.WriteLine(liste[1]);

        foreach (var item in liste)
            Console.WriteLine(item);
        
        //AddRange
        Console.WriteLine("*** Add Range ***");
       // string[] renkler ={"kirmizi","sari","yesil"};
        List<int> sayilar = new List<int>(){1,8,3,7,9,92,5};
       // liste.AddRange(renkler);
        liste.AddRange(sayilar);

        foreach(var item in liste)
            Console.WriteLine(item);

        //Sort
        Console.WriteLine("***Sort****");
        liste.Sort();

        foreach(var item in liste)
            Console.WriteLine(item);

        //Binary Search
        Console.WriteLine("***Binary search**");
        Console.WriteLine(liste.BinarySearch(9));

        //reverse
         Console.WriteLine("***Reverse**");
         liste.Reverse();

          foreach(var item in liste)
            Console.WriteLine(item);

        //Clear()  
         Console.WriteLine("***Clear**");      
        liste.Clear();

         foreach(var item in liste)
            Console.WriteLine(item);
       
    }
}
