namespace algoritma_sorulari;
class Program
{
    static void Main(string[] args)
    {
                //Console.WriteLine("Hello, World!");
            Console.WriteLine("enter a element of array:");
            int num;
            num = int.Parse(Console.ReadLine());
            FindEven(num);
     
    }


    public static void FindEven(int num){
            int[] arr = new int[num];

            if(num>0)
            {
                   //Console.WriteLine("enter pozitive numbers "+ count + "times");

                   for(int i=0;i<num;i++)
                   {       
                        Console.WriteLine("Enter {0}. number:",i+1);      
                        arr[i]=int.Parse(Console.ReadLine());
                   }

            }
                   
                    for(int i=0;i<num;i++)
                    {
                        if(arr[i]%2==0)
                            Console.WriteLine("even number:"+ arr[i]);
                    }

    }
 
}
