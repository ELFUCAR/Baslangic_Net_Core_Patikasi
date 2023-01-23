namespace ucuncuSoru;
class Program
{
    static void Main(string[] args)
    {
            Console.WriteLine("Enter an element of array:");
            int num1=int.Parse(Console.ReadLine());
            
            ListWord(num1);
            
    }

    public static void ListWord(int num1){
            string[] arr = new string[num1];
            string[] arr2= new string[num1];
            int a=num1;

            if(num1>0)
            {
                   for(int i=0;i<num1;i++)
                   {       
                        Console.WriteLine("Enter {0}. word:",i+1);      
                        arr[i]=Convert.ToString(Console.ReadLine());
                   }
     
                    for(int i=0;i<num1;i++)
                    {
                            arr2[num1]=arr[i];///  HATA VAR
                            num1=num1-1;
                          
                    }
                    for(int i=0;i<num1;i++)
                    {
                            Console.WriteLine(arr2[i]);
                    }
            }
            else{
                Console.WriteLine("Something went wrong");
            }
    }


}
