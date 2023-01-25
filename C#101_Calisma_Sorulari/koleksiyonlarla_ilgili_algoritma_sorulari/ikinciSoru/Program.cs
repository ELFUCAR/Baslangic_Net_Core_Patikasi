using System.Collections;

namespace ikinciSoru;
class Program
{
    static void Main(string[] args)
    {
        int[] Arr=new int[10];

        Console.WriteLine("enter numbers");
        for(int i=0;i<Arr.Length;i++)
        {
            Arr[i]=Convert.ToInt32(Console.ReadLine());
        }

        int max=0, max2=0; 
        int min=0, min2=0;

        for(int i=0; i<Arr.Length; i++){
            if(Arr[i] > max)
            {         
                    max2=max;
                    max=Arr[i];
            }
            else if(Arr[i]>max2 && Arr[i]<max)
            {
                    max2=Arr[i];
            }  
        }

        for(int i=0; i<Arr.Length; i++){
            if(Arr[i] < min)
            {         
                    min2=min;
                    min=Arr[i];
            }
            else if(Arr[i]<min2 && Arr[i]<min)
            {
                    min2=Arr[i];
            }  
        }

        int maxOrt, minOrt, OrtTop;

            maxOrt=(max+max2)/2;
            minOrt=(min+min2)/2;
            OrtTop=minOrt+maxOrt;
        
             Console.WriteLine("Maximum Sayilarinin Ortalamasi: "+ maxOrt);                    
             Console.WriteLine("Minimum Sayilarinin Ortalamasi: "+ minOrt);                        
             Console.WriteLine("Ortalama Toplami: "+ OrtTop);

}
}

