using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace FileViewerLib
{
    public class Item :  Button
    {
        public enum TypeOfItem {Folder,Document,ElseType};
        public static List<Item> Items= new List<Item>();

        public Item()
        {
            
        }
        public Item(string Name,Point p)
        {
            this.Text = Name;
            this.BackColor = Color.Bisque;
            this.Location = p;
            this.Height = 150;
            this.Width = 120;
            this.Name = Name;
            this.Visible = true;
            Items.Add(this);
        }
        public Item(ViewPanel VP,string Name,Point p,TypeOfItem t )
        {
            
            this.Text = Name;
            this.ImageAlign = ContentAlignment.TopCenter;
            this.TextAlign = ContentAlignment.BottomCenter;
            this.ParentViewPanel = VP;
            this.BackColor = Color.White;
            this.Location = p;
            this.Height = 160;
            this.Width = 120;
            this.Name = Name;
            this.Visible = true;
            if (t == TypeOfItem.Folder)
            {
                this.MouseClick += OnFolder_Click;
                this.Image = Resources.package_wordprocessing_5909;
             
            }
            else if (t == TypeOfItem.Document)
            { 
                this.MouseClick += OnDocument_Click;
                this.Image = Resources.files_word_5038;
            }
            else
            {
                this.MouseClick += OnElse_Click;
                this.Image = Resources._32_documents_4357;
            }
            Items.Add(this);
        } 
        public ViewPanel ParentViewPanel;
        private void OnFolder_Click(object sender, EventArgs e)
        {

            this.ParentViewPanel.SelectedItemName = null;
            this.ParentViewPanel.History.Push(this.ParentViewPanel.CurrentFolder);
            string folder = this.ParentViewPanel.CurrentFolder += this.Name + "\\";
            this.ParentViewPanel.Controls.Clear();
            Item.Items.Clear();
            this.ParentViewPanel.ItemLocation = new Point(20, 20);
            try
            {
                this.ParentViewPanel.GetItems(folder);
            }
            catch (System.UnauthorizedAccessException) 
            { 
                
                MessageBox.Show("Administrator rights are required");
                this.ParentViewPanel.CurrentFolder = this.ParentViewPanel.History.Pop();
            }
            

        }
        private void OnDocument_Click(object sender, EventArgs e)
        { this.ParentViewPanel.SelectedItemName = this.ParentViewPanel.CurrentFolder + this.Name; }
        private void OnElse_Click(object sender, EventArgs e)
        { 
            this.ParentViewPanel.SelectedItemName = null;
            MessageBox.Show("Оберіть документ Word або папку"); 
        }
       
        
    }
}
