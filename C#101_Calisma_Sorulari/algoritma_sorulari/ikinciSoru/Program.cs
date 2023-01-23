namespace ikinciSoru;
class Program
{
    static void Main(string[] args)
    {
            Console.WriteLine("Enter an element of array:");
            int num1=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number:");
            int num2=int.Parse(Console.ReadLine());
            EqualDivided(num1,num2);
            
    }

    public static void EqualDivided(int num1, int num2){
            int[] arr = new int[num1];

            if(num1>0)
            {
                   for(int i=0;i<num1;i++)
                   {       
                        Console.WriteLine("Enter {0}. number:",i+1);      
                        arr[i]=int.Parse(Console.ReadLine());
                   }
     
                    for(int i=0;i<num1;i++)
                    {
                        if(num2%arr[i]==0 || num2==arr[i] )
                            Console.WriteLine("equalNumber and dividedNumber:"+ arr[i]);
                    }
            }
            else{
                Console.WriteLine("Something went wrong");
            }
    }

}
