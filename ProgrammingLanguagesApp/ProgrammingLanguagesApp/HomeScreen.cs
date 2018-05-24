using System;
using CoreGraphics;
using System.Collections.Generic;
using UIKit;
using System.Linq;
namespace ProgrammingLanguagesApp
{
    public class HomeScreen : UIViewController
    {
        UITableView table;

        public HomeScreen()
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            var width = View.Bounds.Width;
            var height = View.Bounds.Height;

            table = new UITableView(new CGRect(0, 0, width, height));
            table.AutoresizingMask = UIViewAutoresizing.All;
            CreateTableItems();
            Add(table);
        }

        protected void CreateTableItems()
        {
            List<ProgrammingLanguage> tableItems = new List<ProgrammingLanguage>();
            foreach(var pl in ProgrammingLanguage.LanguageList)
            {
                tableItems.Add(pl);
            }
            tableItems = tableItems.OrderBy(pl => pl.Name).ToList();
            table.Source = new TableSource(tableItems.ToArray(), this);
        }

        public override bool PrefersStatusBarHidden()
        {
            return true;
        }
    }
}
