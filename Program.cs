//c# keyword = anahtar kelime
//bir keyword kullanmak istedigimizde basina @ isareti koymamiz gerekir
// degiskentipi degiskenismi=deger; 
// int @if = 15;
//-------//
//ciktilarin duzenlenmesi 0 1 2 kdolariyle ifade edilir. 0 hatasiz islem oldgunu gosterir.
// Console.Write("ahmet\\n");//ahmet\n \ kacis karakteri denir. n=new line 
// Console.Write("mehmet");
//10/3=3.33333- 3.33
//c#da verilerin sayisal ifadeleri 0 dan baslar.
//literaller
//Console.WriteLine("10/3 e bolunuyor ve 2 li kalan yaziliyor {0:#.##}",10.0/3);//0 yer tutucu gorevini gorecek
//10/3 e bolunuyor ve 2 li kalan yaziliyor 3,33
       
//Console.WriteLine("birinci adim {0}`dir.  ikinci adim {1} dir. {2:#.##}","ahmet","kursat",10.0/3);
//birinci adim ahmet`dir.  ikinci adim kursat dir.
//tum yazilimdillerinde standart cikti konsoldur.
//Yazilan verileri ayniyla alma:litelari : harfi harfine karakter katari literali @
//D:\Ahmet Kursat\steamapps\common\Planet Zoo\win64 
// Console.WriteLine("D:\\Ahmet Kursat\\steamapps\\common\\Planet Zoo\\win64");
// Console.WriteLine(@"D:\Ahmet Kursat\steamapps\common\Planet Zoo\win64");
//Tip donusumlerı
//temel tip donusumleri otomatik olarak c# tarafindan yapilir.
//type promotions (tip terfisi)
//byte -> int (tgmenden ustegmen) (rutbe arttirma)
//0 - 1 8 255 8*255 byte 2147483647*8=ram
//(3 byte )500 int 2147483647
//79228162514264337593543950335
// byte murtaza=Byte.MaxValue;
// Console.WriteLine(murtaza);
// int murtazaninabisi=Int32.MaxValue;
// Console.WriteLine(murtazaninabisi);
// decimal bankacimahmut=Decimal.MaxValue;
// Console.WriteLine(bankacimahmut);
//byte < int < decimal
// byte a = 255;
// byte b = 255;
// int  c = (byte)a + (byte)b;
// Console.WriteLine(c);
// int veri1 = 200; //2147483647
// int veri2 = 50; //2147483647
// byte veriler = (byte) (Convert.ToByte(veri1) + Convert.ToByte(veri2)); //255
//buyuk kucuge cevrildigi zaman veri kaybi olabilecegi icin c#kapali (otomatik ceviriye izin vermez)
// Console.WriteLine(veriler);

//Operator islemleri 
//-artirma(+) ve eksiltme(-) operatorleri-//
// int ahmetinyasi = 20;
// int ahmetinabisinyasi = 21;
// //ahmete yas eklemek istiyorum
// ahmetinyasi = 20 + 1;
// ahmetinabisinyasi += 1;
//         
// //ahmet agladi yasim buyuk dedi abimi sevmiyorum dedi.
// ahmetinyasi++;
// //abimle esit yasta olmak isteiyourm
// ahmetinabisinyasi--;
//         
// Console.WriteLine("Ahmetin Yasi {0}",ahmetinyasi);
// Console.WriteLine("Ahmetin Abisinin Yasi {0}",ahmetinabisinyasi);
namespace ConsoleApp1
{
public static class Program
{
    public static void Main(string[] args)
    {
       
        
    }
}
}