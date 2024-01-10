namespace programlama_temelleri_odev
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            var kullanılan = new System.Collections.Generic.List<int>();

            Console.Write("Kaç sayı almak istiyorsunuz? ");
            int sayi = Convert.ToByte(Console.ReadLine());

            for (int i = 0; i < sayi; i++)
            {
                int yeni = random.Next(1, 99);

                while (kullanılan.Contains(yeni))
                {
                    yeni = random.Next(1, 99);
                }
                Console.WriteLine("yeni sayı:" + yeni);
                kullanılan.Add(yeni);
            }
        }
    }
}
