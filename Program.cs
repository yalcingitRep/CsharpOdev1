using System;
namespace CsharpOdev1{
    class Program{
        public static void Main(string[] args){
            //1
            int n1;
            Console.Write("Kac adet sayi girilecek : ");
            n1 = Convert.ToInt32(Console.ReadLine());
            int[] ciftSayilar = new int[n1];
            Odev od = new Odev();
            od.Yazdir(n1,ciftSayilar);
            //2
            
            Console.Write("Kac adet sayi girilecek : ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("M degeri girin : ");
            int m = Convert.ToInt32(Console.ReadLine());

            int[] mArr = new int[n2];
            od.Yazdir(n2,m,mArr);

            //3
            Console.Write("Kac adet kelime girilecek : ");
            int n3 = Convert.ToInt32(Console.ReadLine());
            string str = "";
            od.Yazdir(n3,str);

            //4
            Console.Write("Cümle yazin : ");
            string str2 = Console.ReadLine();
            od.Yazdir(str2);
        }

    }
    public class Odev{
        public void Yazdir(int n1,int[] arr){
            int n1Num;
            Console.Write("Lütfen pozitif sayi giriniz : ");
            for(int i = 0;i<n1;i++){
                n1Num = Convert.ToInt32(Console.ReadLine());
                while(n1Num < 0){   
                    Console.Write("Lütfen pozitif sayi giriniz : ");
                    n1Num = Convert.ToInt32(Console.ReadLine());
                }
                arr[i] = n1Num;
            }
            Console.WriteLine("Cift Sayilar : ");
            foreach(var item in arr){
                if(item%2 == 0)
                    Console.Write(item + " ");
            }
        }
        public void Yazdir(int n2,int m,int[] arr){
            int n2Num;
            Console.Write("Lütfen pozitif sayi giriniz : ");
            for(int i = 0;i<n2;i++){
                n2Num = Convert.ToInt32(Console.ReadLine());
                while(n2Num < 0){   
                    Console.Write("Lütfen pozitif sayi giriniz : ");
                    n2Num = Convert.ToInt32(Console.ReadLine());
                }
                arr[i] = n2Num;
            }
            Console.WriteLine("M' esit yada yam bolunen sayiler: ");
            foreach(var item in arr){
                if(item == m || item%m ==0){
                    Console.Write(item + " ");
                }
            }
        }
        public void Yazdir(int n3,string newString){
            string kelime = "";
            for(int i = 0;i<n3;i++){
                kelime = Console.ReadLine();
                while(kelime == null){
                    Console.WriteLine("bir kelime giriniz : ");
                    kelime = Console.ReadLine();
                }     
                 newString += kelime;             
            }
            
            Console.WriteLine("Ters kelime : ");
            for(int i = newString.Count() -1;i>=0;i--){
                Console.Write(newString[i]);
            }
        }
        public void Yazdir(string cumle){
            int countNum = 0, countHarf = 0;
            for(int i = 0;i<cumle.Count();i++){
                if(cumle[i] >= 65 && cumle[i] <= 90){
                    countHarf++;
                }
                else if(cumle[i] >= 97 && cumle[i] <= 122){
                    countHarf++;
                }
                else if(cumle[i] >= 48 && cumle[i] <= 57){
                    countNum++;
                }
            }
            Console.WriteLine("Toplam harf : " + countHarf);
            Console.WriteLine("Toplam rakam : " + countNum);
        }
    }
}