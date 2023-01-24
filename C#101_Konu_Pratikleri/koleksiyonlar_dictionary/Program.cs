using System.Collections.Generic;
namespace koleksiyonlar_dictionary;
class Program
{
    static void Main(string[] args)
    {
        //System.Collection.Generic;
        Dictionary<int,string> kullanicilar=new Dictionary<int, string>();

        kullanicilar.Add(10,"Ayse Yilmaz");
        kullanicilar.Add(12,"Ahmet Yildirim");
        kullanicilar.Add(18,"Deniz Arda");
        kullanicilar.Add(20,"Ozcan Cosar");
     
        //dizinin elemanlarına erisim
        Console.WriteLine("***Elemanlara erisim");
        Console.WriteLine(kullanicilar[12]);

        foreach (var item in kullanicilar)
            Console.WriteLine(item);

        //Count
        Console.WriteLine("***Count****");
        Console.WriteLine(kullanicilar.Count);

        //Contains
        Console.WriteLine("***Contains***");
        Console.WriteLine(kullanicilar.ContainsKey(12));
        Console.WriteLine(kullanicilar.ContainsValue("Elif Ucar"));
        
        //Remove
        Console.WriteLine("***Remove****");
        kullanicilar.Remove(12);
        foreach(var item in kullanicilar){
            Console.WriteLine(item.Value);
        } 

        //Keys
        Console.WriteLine("***Keys****");
        foreach(var item in kullanicilar.Keys){
            Console.WriteLine(item);
        } 

        //Values
        Console.WriteLine("***Values****");
        foreach(var item in kullanicilar.Values){
            Console.WriteLine(item);
        } 


    }
}
