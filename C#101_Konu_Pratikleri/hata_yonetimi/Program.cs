namespace C_101_Hata_Yonetimi;
class Program
{
    static void Main(string[] args)
    {
        try{
                Console.WriteLine("Bir sayı giriniz:");
                int sayi=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz sayı:"+ sayi);
        }
        catch(Exception ex){
            Console.WriteLine("Hata:"+ex.Message.ToString());
        }
       /* finally{
            Console.WriteLine("İşlem tamamlandı!");
        }
*/

            try{
            /*  int a=int.Parse(null);
                int b=int.Parse("test");*/
                int a=int.Parse("-200000000");
            }
            catch(ArgumentNullException ex){//hata türleri
                    Console.WriteLine("Boş değer girdiniz:");
                    Console.WriteLine(ex);
            }
            catch(FormatException ex){
                Console.WriteLine("Veri tipi uygun değil:");
                    Console.WriteLine(ex);
            }
            catch(OverflowException ex){
                Console.WriteLine("Çok küçük yada çok büyük değer girdiniz:");
                Console.WriteLine(ex);
            }


        
    }
}
