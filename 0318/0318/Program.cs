using _0318.Services;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var xmlService1 = new ImportXmlService();

            var datas = xmlService1.LoadFormFile(@"C:\Users\chang chin-wei\Documents\NKUST_1092\高雄活動資料.xml");


            Console.WriteLine(string.Format("分析完成，共有{0}筆資料", datas.Count));
            datas.ForEach(x =>
            {
                Console.WriteLine(string.Format("地點:{0} 描述:{1}", x.Add, x.Name));
            });

            Console.ReadKey();
        }
    }
}