namespace ucuncuSoru;
class Program
{
    static void Main(string[] args)
    {

            char[] arr= {'a','A','e','E','i','İ','I','o','O','Ö','ö','u','Ü'};

            string sentence=Console.ReadLine();
            char[] sentChar; 


            foreach(char c in sentence.ToCharArray()){
                for(int i=0; i<sentence.Length; i++)
                     if(c==arr[i])
                        sentChar[i]=c;
            }

            
        Console.WriteLine('Hello, World!');
    }
}
