using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;



namespace Coding_Week_13
{
    public partial class Program
    {
        static void Main(string[] args)
        {
        }
        InitializeComponent();
        private InitializeComponent();


        EnvironmentVariableTarget db = DBContext.GetInstance();

        //Lets fetch the categories and list on the categories tab
        List<string> catItems = new List<string>();
        catItems.Add("All");
        foreach (var category in db.Select<Category>())
        {
            catitems
        }
        optCat.Items = catItems.ToArray();

    }
    
    private voidFrmMain_Shown(object sender, EventArgs e)
    {
    menu.Width = 306;
    Console.WriteLine("1. My scroll list");
    Console.WriteLine("2. Add scroll");
    Console.WriteLine("Choose what to do");
    Console.WriteLine("Scroll to learn list :");
    Console.WriteLine("Scroll 1: Book of Peace");
    Console.WriteLine("Scroll 2: Scroll of Swords");
    Console.WriteLine("Scroll 3: Silence Guide Book");
    List<string> scrolls = new List<string>() { "Book of Peace", "Scroll of
Swords", "Silence Guide Book" };
 var scroll = new List<string>() { "Book of Peace", "Scroll of Swords",
"Silence Guide Book" };
 class Scroll
{
    string scroll;
    int maxscroll;
    static void Main(string[] args)
 Scroll myObj = new Scroll("Scroll 1: Book of Peace");
    myObj.Scroll = "Scroll 2: Scroll of Swords");
 myObj.maxSpeed = "Scroll 3: Silence Guide Book");
 Console.WriteLine("How many scroll to Add");
 Console.WriteLine("book 3");
 Console.WriteLine("book 4");
    }
}
