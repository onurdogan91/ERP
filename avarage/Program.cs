namespace avarage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5 elemanlı bir dizi, sayıları biz giriyoruz ve ortalamasını veren program
            
            double[] array = new double[5];
            Console.WriteLine("1. Sayiyi Giriniz : ");
            array[0] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. Sayiyi Giriniz : ");
            array[1] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3. Sayiyi Giriniz : ");
            array[2] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("4. Sayiyi Giriniz : ");
            array[3] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("5. Sayiyi Giriniz : ");
            array[4] = Convert.ToInt32(Console.ReadLine());
                        
            //Console.WriteLine((array[0] + array[1] + array[2] + array[3] + array[4]) / array.Length);

            double f = 0;
            double avarage = 5; 

           for (int i = 0; i == array.Length; i++)
            {
                f += array[i];                
            }
            
            avarage = f / array.Length;
            Console.WriteLine("Girdiginiz Sayilarin Ortalamasi : " + avarage);

        }
    }
}