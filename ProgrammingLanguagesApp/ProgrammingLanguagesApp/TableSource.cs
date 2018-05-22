using System;
using UIKit;
using Foundation;
namespace ProgrammingLanguagesApp
{
    public class TableSource:UITableViewSource
    {
        protected string[] tableItems;
        protected string cellIdentifier = "TableCell";
        HomeScreen owner;

        public TableSource(string[] items, HomeScreen owner)
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
            UIAlertController okAlertController = UIAlertController.Create("Row Selected", tableItems[indexPath.Row].ToString(), UIAlertControllerStyle.Alert);
            okAlertController.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));
            owner.PresentViewController(okAlertController, true, null);

            tableView.DeselectRow(indexPath, true);
        }
        // Called by the TableView to get the actual UITableViewCell to render for the particular row
        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            UITableViewCell cell = tableView.DequeueReusableCell(cellIdentifier);
            string item = tableItems[indexPath.Row];

            //if there are no cells to reuse, create a new one
            if (cell == null)
            { cell = new UITableViewCell(UITableViewCellStyle.Default, cellIdentifier); }

            cell.TextLabel.Text = item.ToString();

            return cell;
        }
    }
}
