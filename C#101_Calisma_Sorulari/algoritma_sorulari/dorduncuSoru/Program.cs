namespace dorduncuSoru;
class Program
{
    static void Main(string[] args)
    {
       
            string sentence;
            Console.Write("Enter sentence: ");
            sentence = Console.ReadLine();
            WordCount(sentence);   
    
    }



    static void WordCount(string sentence){

            string[] words = sentence.Split(' ');
            Console.WriteLine("Kelime Sayısı :"+words.Length);
            foreach(string word in words)
            {
                Console.WriteLine(word);
            }

    }
}
