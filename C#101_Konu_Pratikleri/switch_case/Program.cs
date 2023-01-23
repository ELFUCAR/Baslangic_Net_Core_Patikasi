namespace switch_case;
class Program
{
    static void Main(string[] args)
    {
       int month=DateTime.Now.Month;
       switch(month)
       {
            case 1:
                Console.WriteLine("Ocak");
            break;
            case 2:
                Console.WriteLine("Şubat");
            break;
            case 3:
                Console.WriteLine("Mart");
            break;
            case 4:
                Console.WriteLine("Nisan");
            break;
            default:
                Console.WriteLine("Yanlış veri girişi yaptınız:");
            break;        
            
       }

            




       
       
       
       
       
        Console.WriteLine("Hello, World!");
    }
}
