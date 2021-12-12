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
    


    

    }
}
