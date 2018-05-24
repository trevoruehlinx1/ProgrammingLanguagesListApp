using System;
using UIKit;
using Foundation;
using System.Linq;
using System.Collections.Generic;

namespace ProgrammingLanguagesApp
{
    public class TableSource:UITableViewSource
    {
        string[] keys;
        Dictionary<string, List<ProgrammingLanguage>> indexedTableItems;
        protected ProgrammingLanguage[] tableItems;
        protected string cellIdentifier = "TableCell";
        HomeScreen owner;

        public TableSource(ProgrammingLanguage[] items, HomeScreen owner)
        {
            tableItems = items;
            this.owner = owner;
            indexedTableItems = new Dictionary<string, List<ProgrammingLanguage>>();

            foreach(var pl in tableItems)
            {
                var key = pl.Name[0].ToString();
                if(indexedTableItems.ContainsKey(key))
                {
                    indexedTableItems[key].Add(pl);
                }
                   else
                {
                    indexedTableItems.Add(key, new List<ProgrammingLanguage>() { pl });
                }
                keys = indexedTableItems.Keys.ToArray();
            }

        }

        public override nint NumberOfSections(UITableView tableView)
        {
            return keys.Length;
        }
        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return indexedTableItems[keys[section]].Count;
        }

        // Called when a row is touched
        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            UIAlertController infoAlertController = UIAlertController.Create("Developed By " + tableItems[indexPath.Row].ChiefDevs,"Inspired By " + tableItems[indexPath.Row].InfluencedBy, UIAlertControllerStyle.Alert);
            infoAlertController.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));
            //infoAlertController.AddAction(UIAlertAction.Create("on" + , UIAlertActionStyle.Cancel, null));
            owner.PresentViewController(infoAlertController, true, null);

            tableView.DeselectRow(indexPath, true);
        }
        // Called by the TableView to get the actual UITableViewCell to render for the particular row
        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            UITableViewCell cell = tableView.DequeueReusableCell(cellIdentifier);
            ProgrammingLanguage item = tableItems[indexPath.Row];

            //if there are no cells to reuse, create a new one
            if (cell == null)
            { cell = new UITableViewCell(UITableViewCellStyle.Default, cellIdentifier); }

            cell.TextLabel.Text = indexedTableItems[keys[indexPath.Section]][indexPath.Row].Name +" "+
                                    indexedTableItems[keys[indexPath.Section]][indexPath.Row].Date;

            return cell;
        }
		public override string[] SectionIndexTitles(UITableView tableView)
		{
            return keys;
		}
	}
}
