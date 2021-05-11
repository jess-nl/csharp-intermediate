using System;

namespace Indexers
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Jay";
            Console.WriteLine(cookie["name"]);
        }
    }
}
