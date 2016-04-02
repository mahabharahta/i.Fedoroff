using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
namespace FileViewerLib
{
    public class ViewPanel : Panel
    {
        public string SelectedItemName;
        public string CurrentFolder;
        public List<Item> Items;
        internal Point ItemLocation = new Point(20, 20);
        public Stack<string> History = new Stack<string>();
        
        public ViewPanel()
        {
            this.CurrentFolder = "C://";
            this.Items = this.GetItems(CurrentFolder);
            this.History.Push(CurrentFolder);
        }
        public ViewPanel(String Folder)
        {
            this.History.Push(Folder);
            this.CurrentFolder = Folder;
            this.Items = this.GetItems(Folder);

        }
      
        public List<Item> GetItems(string Folder)
        {
            try
            {
                DirectoryInfo d = new DirectoryInfo(Folder);
                foreach (var item in d.GetDirectories())
                {
                    this.Controls.Add(new Item(this, item.Name, ItemLocation, Item.TypeOfItem.Folder));
                    if (this.Width > ItemLocation.X + 200)
                        ItemLocation.X += 140;
                    else
                    {
                        ItemLocation.X = 20;
                        ItemLocation.Y += 180;
                    }
                }
                foreach (var item in d.GetFiles())
                {
                    if (item.ToString().EndsWith(".doc") || item.ToString().EndsWith(".docx"))
                        this.Controls.Add(new Item(this, item.Name, ItemLocation, Item.TypeOfItem.Document));
                    else
                        this.Controls.Add(new Item(this, item.Name, ItemLocation, Item.TypeOfItem.ElseType));
                    if (this.Width > ItemLocation.X + 200)
                        ItemLocation.X += 140;
                    else
                    {
                        ItemLocation.X = 20;
                        ItemLocation.Y += 180;
                    }
                }
                if (Item.Items.Count == 0)
                {
                    Label l = new Label();
                    l.TextAlign = ContentAlignment.MiddleCenter;
                    this.Controls.Add(l);
                    l.Text = "Пусто";
                }
               
            }
            catch { }

            return Item.Items;
        }
        public void ChangeFolderTo(string path)
        {
            this.Controls.Clear();
            Item.Items.Clear();
            this.ItemLocation = new Point(20, 20);
            this.CurrentFolder = path;
            this.Items = this.GetItems(path);
            this.History.Push(path);
        }
        public void BackToPreviousFolder()
        {
            this.SelectedItemName = null;
            try
            {
                this.CurrentFolder = History.Pop();
            }
            catch (InvalidOperationException )
            { MessageBox.Show("Це коренева папка"); }
            this.Controls.Clear();
            Item.Items.Clear();
            this.ItemLocation = new Point(20, 20);
            this.GetItems(CurrentFolder);

        }

    }
}
