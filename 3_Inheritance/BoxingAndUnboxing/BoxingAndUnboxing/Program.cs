using System;
using System.Collections;
using System.Collections.Generic;

namespace BoxingAndUnboxing
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var list = new ArrayList();
            list.Add(1);
            list.Add("Jay");
            list.Add(DateTime.Today);

            var number = (int)list[1];

            var anotherList = new List<int>();
            //anotherList.Add();
            var names = new List<string>();
            //names.Add();
        }
    }
}
