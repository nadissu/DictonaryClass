using System;

namespace DictonaryClass
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictonary<int,string> dictonaryList = new MyDictonary<int,string>();
            dictonaryList.Add(1,":"+ "Konsorsiyum:Uluslararası kimi kuruluşların ya da kimi devletlerin ekonomik ve mali yardımları yürütmek için oluşturdukları ortak organ.");
            dictonaryList.Add(2,":"+ "Postmodernizm:Yazında ve daha çok da mimarlıkta, modern sonrası ortaya çıkan türlü yönelişlere verilen ad.");
            dictonaryList.Add(3,":"+ "Konfederasyon:Egemenliği, kendi bağımsız hükümeti olmakla birlikte merkezi bir hükümetin yönetimini kabul eden devletlerin oluşturduğu birlik, devletler birliği.");
            dictonaryList.List();
        }
    }
}
