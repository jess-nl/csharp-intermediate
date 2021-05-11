using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace UpcastingAndDowncasting
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Text text = new Text();
            //Shape shape = text;

            //text.Width = 200;
            //shape.Width = 100;

            //Console.WriteLine(text.Width);


            //StreamReader reader = new StreamReader(new MemoryStream());


            //ArrayList list = new ArrayList();
            //list.Add(1);
            //list.Add("Jay");
            //list.Add(new Text());

            //var anotherList = new List<Shape>();


            Shape shape = new Text();
            Text text = (Text)shape;
        }
    }
}
