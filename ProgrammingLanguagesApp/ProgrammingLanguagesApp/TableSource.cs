using System;
using UIKit;
using Foundation;
namespace ProgrammingLanguagesApp
{
    public class TableSource:UITableViewSource
    {
        protected ProgrammingLanguage[] tableItems;
        protected string cellIdentifier = "TableCell";
        HomeScreen owner;

        public TableSource(ProgrammingLanguage[] items, HomeScreen owner)
        {
            tableItems = items;
            this.owner = owner;

        }
        // Called by the TableView to determine how many sections(groups) there are.
        public override nint NumberOfSections(UITableView tableView)
        {
            return 1;
        }
        // Called by the TableView to determine how many cells to create for that particular section.

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return tableItems.Length;
        }
        // Called when a row is touched
        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            UIAlertController infoAlertController = UIAlertController.Create("Developed By " + tableItems[indexPath.Row].ChiefDevs,"Preceded By " + tableItems[indexPath.Row].InfluencedBy, UIAlertControllerStyle.Alert);
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

            cell.TextLabel.Text = item.Name +" "+ item.Date;

            return cell;
        }
    }
}
