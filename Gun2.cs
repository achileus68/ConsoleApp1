namespace ConsoleApp1;

public class Gun2
{
    public Gun2()
    {
      
    }
}

/*Arttirma ve eksiltme part :2
 * degiskenismi++ veya degsikenismi-- : ++degiskenismi veya --degiskenismi
 *  byte ezgiyas = 20;
        byte fatmayas = 20;
        byte ahmetinyasi = ezgiyas++; //20 
        byte kursatinyasi = ++fatmayas;
        Console.WriteLine("ahmetin yasi " + ahmetinyasi); //20
        Console.WriteLine("kursatin yasi: " + kursatinyasi);//21
        Console.WriteLine("ahmetinyasi: {0} kursatinyasi : {1}",ahmetinyasi,kursatinyasi);
        Console.WriteLine("ahmetinyasi: " + ahmetinyasi + " kursatinyasi : " + kursatinyasi);
        
        ahmetinyasi: 20 kursatinyasi : 21
 * iliskisel ve Mantiksal Operatorler:
 * ^ -> XOR : Yalnizca tek bir operand dogru ise dogru sonucunu verir.
 * a durumu b durumu : a ^ b
 * true     false       true
 * false    true        true
 * true     true        false
 * false    false       false
 *   Boolean durum1 = true; //true
        Boolean durum2 = false;
        Boolean durumkarsilastir = durum1 ^ durum2;
        if (durumkarsilastir)
        {
            Console.WriteLine("ifin ic bloklari");
        }
 * Cikarim operatoru: Implication
 * sonucun yalnizca soldaki operandin dogru ve sagdaki operandin yanlis iken yanlis oldugu ikili bir islemdir.
 * a         b :    a gerektirir b
 * true     true        true
 * true     false       false
 * false    false       true
 * false    true        true
 *    Boolean durum1 = true;
        Boolean durum2 = false;
        Boolean sonuc = !durum1 | durum2;

        Console.WriteLine(sonuc);
 * karsilastirma operatorleri: Normal operatorler
 * | & ==
 *  string data = "30";//30
        int rakam2 = 10*3;
        byte rakam3 = 10;
        int data2 = 30;
        Boolean sonuc = rakam2 == rakam3;// true
        Boolean sonuc2 = Int32.Parse(data) == data2;
        
        if (sonuc2) //karsilastirma rakam rakam2 ye esit mi 
        {
            Console.WriteLine("if bloklarinin ici: "+ sonuc);
        }
 Boolean durum = !false;
        if (durum != true)// ! not isareti olarak aadlandirilir. tersini ifade eder.
        {
            Console.WriteLine("if ici bloklara girildi.");
        }
    & ve | operatorleri ve - veya and - or
    a       b       a & b
    true    true    true
    true    false   false
    false   true    false
    false   false   true
                    a | b
    true    true    true
    true    false   true
    false   true    true
    false   false   false
 * kisa devre mantiksal operatorler:
 * && - ||
  int sayi1 = 0;  //10 20 0 -10
        int sayi2 = 5;

        if ((sayi1 != 0) && (sayi2/sayi1 != 0) ) // ifadelerin durumlarini karsilastirma 10 tane ve and 
        {
            Console.WriteLine("sonuc yazdiriliyor...");
        }
        
        // Console.WriteLine(rakam2/rakam); //System.DivideByZeroException: Attempted to divide by zero.
* Atama operatoru: = -> atama zinciri  
 *  // ayni anda uc tane degisken olusturmak istiyorum. ve tek veriyi atamak istiyorum
         //Atama zinciri denir.
         int a; 
         int b;
         int c;
         a = b = c = 100;
         Console.WriteLine(a+b+c);
         int d=5, f=10 , g = 500;
        
         Console.WriteLine(d + f +g);
 * bilesik Atama :
 *   int a = 5;
        int b=  5;
        int c = 5;
        int yas = 20;
        yas += 1;
        a = a + b + c;
        
        b -= c; //0

        c *= b;
        Console.WriteLine(c);

        Console.WriteLine(a);
# bit tabanli operatorler:
& | ^ >> << ~ > *
 */