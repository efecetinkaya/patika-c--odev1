using System;

namespace consoleprogramlama
{
     class Program
    {
        static void Main(string[] args)
        {
            /* Soru1 */
         Console.WriteLine("Pozitif Bir Sayı Giriniz.");
         int diziuzunlugu = Convert.ToInt32(Console.ReadLine()) ;
         int[] dizi = new int[diziuzunlugu];
         
        for (int i = 0; i < diziuzunlugu; i++)
        {
             Console.WriteLine("Dizinin "+ (i+1) + ". elemanını giriniz.");
             int eleman = Convert.ToInt32(Console.ReadLine());
             dizi[i] = eleman;
        }
         
        foreach(int a in dizi)
        {
            if(a % 2 == 0)
            Console.Write(a + " ");
        } 
         
         /* Soru 2 */
         Console.WriteLine("Pozitif iki sayı giriniz");
         string sayilar = Console.ReadLine();
         string[] array = sayilar.Split(new char[]{' '},2);
         int n = Convert.ToInt32(array[0]);
         int m = Convert.ToInt32(array[1]);

         
        Console.WriteLine(n + " adet pozitif tam sayı giriniz.");
        string sayilar2 = Console.ReadLine();
        string[] array2 = sayilar2.Split(new char[]{' '},n);

        int diziuzunlugu = array2.Length;

        int[] array2_int = new int[n];
        for (int i = 0; i < diziuzunlugu; i++)
        {
            array2_int[i] = Convert.ToInt32(array2[i]); 
        }

        
        for (int i = 0; i < diziuzunlugu; i++)
        {
            if(array2_int[i] % m == 0)
            {
                Console.WriteLine(array2_int[i] + " ");
            }
        } 

        /* Soru 3 */
        Console.WriteLine("Bir sayı giriniz.");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(n + " adet kelime giriniz.");
        string girdi = Console.ReadLine();
        string[] kelimeler = girdi.Split(new Char[]{' '},n);
        Array.Reverse(kelimeler);
         int kelimeler_lenght = kelimeler.Count();
          for (int i = 0; i < kelimeler_lenght; i++)
          {
              Console.Write(kelimeler[i] + " ");
          } 
           /* Soru 4 */
          Console.WriteLine("Bir cümle yazınız.");
          string cumle_string = Console.ReadLine();
          string[] cumle_array = cumle_string.Split(new char[]{' '});
          int kelime_sayisi = cumle_array.Count();
          Console.WriteLine("Kelime Sayısı= " + kelime_sayisi); 
            
          int harf_sayisi = cumle_string.Count();
          int bosluk_sayisi = 0;
          foreach (char a in cumle_string)
          {
              if(a == ' ')
              {
                  bosluk_sayisi++;
              }
          }
          Console.WriteLine("Harf sayısı= " + (harf_sayisi - bosluk_sayisi));
       }
    }
}
