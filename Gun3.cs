namespace ConsoleApp1;

public class Gun3
{
    public Gun3()
    {
    
    }
  
}
/*
 * # bit tabanli operatorler:
    & | ^ >> << ~
    1101 0011
    1010 1010
   &---------
    1000 0010
      byte num = 9;//Tek sayi 
       // gelen sayi tek ise ikili tabanda bunu cifte cevirecek olan kodlari yazalim.
       num = (byte) (num & 0xfffe);//1111 1110 -1 a b c d e f
       //Console.WriteLine(num);

       int num2 = 10;
       if ((num2 & 1) != 1) //sayi cift oldugu anlasilir.
       {
           Console.WriteLine("Sayi ciftttir "+ num2);
           num2 += 1;
           if ((num2 & 1) == 1)//sayi tek
           {
               Console.WriteLine("Sayi tektir "+num2);
           }
       }
       
    | 1101 0011
      1010 1010
     |----------
      1111 1011
   XOR ^ ozel veya sadece karsilastirilmakta olan bitler farkliysa bir bite 1 degerini verir.
   0111 1111
   1011 1001
  ^---------
   1100 0110
   
   xor sifrelemelerde kullanilabilir.
   R1= X ^ Y(KEY) ; VERICI
   R2= R1 ^ Y(KEY) ; X--ORJINAL DATA R2=ALICI DECODE
     int num = 14;
        num = (num | 1);//num | 1--> 0000 0001 -> 15
       // Console.WriteLine(num);
        int a = 12; 
        int b = 5;  
        int c = a ^ b;
        string key = "data";

        char e = Convert.ToChar(65);
        
        Console.WriteLine(e + " !!!===!!!!");
        
        Console.WriteLine("XOR ile bit islemi yapilan deger" + c);
        int d = c ^ b;
        Console.WriteLine(d);
   Tekli birin tumleyeni (DEGIL):
   1001 0110 A tamsayisi bu bitlere sahip olsun.
~A=0110 1001 
  int num = -15; // 1001 1000  0110 0111  10
     
     Console.WriteLine(~num);
     
    #Kaydirma Operatorleri:
    << Sola kaydir 2 uzeri n 
    >> Saga kaydir 2 uzeri n 
     int num = 10;
     Console.WriteLine(num << 1); //2 uzeri 1 
     Console.WriteLine(num << 2); 
     Console.WriteLine(num >> 1);
     Console.WriteLine(num << 30);// int degerinin disina ciktigi icin ust bite 1 kaydirir.
     -----------------------------------------------------------------------------
     ? Operatoru: if-the-else ifadelerinin yerlerine kullanilir.
     Uclu operatordur.(ternary op.)
     Deyim1 ? Deyim2 : Deyim3;
     
    //Bir sayinin mutlak degerini alan bir kod.
     int num = -10; //[-10]-> 10
     if (num<0)
     {
      //num = -num;
     // Console.WriteLine(num);
     }
     else
     {
      //Console.WriteLine(num);
     }

     int num2 = num < 0 ? -num : num;
     int i = 1;
     if (i != 0  ? true : false)
     {
      Console.WriteLine("Sifira esit degil");
     }
     //Console.WriteLine(num2);
   
     Switch-Case : Birkac case ifadesinin ortak bir kodu paylastigi durumda case ifadelerini
     ust uste yigmak sikca kullanilan bir tekniktir.
     case 1:
     case 2:
     case 3: 
             cw();
             break;
     int yas = 3;
    
     switch (yas)
     {
      case 1:
       case 2:
        case 3:
      case 6:
       Console.WriteLine("Cocuk");
       break;
      case <=15:
       Console.WriteLine("Genc");
       break;
      case <=18 :
       Console.WriteLine("Yetiskin");
       break;
      default:
       Console.WriteLine("Giremez..");
       break;
     }

     Boolean a = true;
     switch (a)
     {
       case true:
        Console.WriteLine("Veri dogru");
        break;
       case false:
        Console.WriteLine("Yanlis");
        break;
     }
              
 */