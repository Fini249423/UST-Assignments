using Abstract_class;
using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace Abstract_class

{

    public abstract class Book

    {

        protected string title;

        public string Title

        {

            get { return title; }

            set { title = value; }

        }

        public abstract void setTitle(string s);

        public string getTitle()

        {

            return title;

        }

    }

    public class MyBook : Book

    {

        public override void setTitle(string s)

        {

            title = s;

        }

    }

}

internal class Program

{

    static void Main(string[] args)

    {

        Console.WriteLine("Enter the title");

        string a = Console.ReadLine();

        MyBook new_novel = new MyBook();

        new_novel.setTitle(a);

        Console.WriteLine("The title is:" + new_novel.getTitle());

    }

}