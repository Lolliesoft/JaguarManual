using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace JaguarManual
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            AppDomain.CurrentDomain.SetData("DataDirectory", Path.Combine(Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData), "Lolliesoft"));
        }


        public Image byteArrayToImage(byte[] imagepic)
        {
            MemoryStream ms = new MemoryStream(imagepic);
            Image returnImage = Image.FromStream(ms);
            return returnImage;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //
            // This is the first node in the view.
            //
            //TreeNode treeNode = new TreeNode("Windows");
            //treeView1.Nodes.Add(treeNode);
            //
            // Another node following the first node.
            //
            //treeNode = new TreeNode("Linux");
            //treeView1.Nodes.Add(treeNode);
            //
            // Create two child nodes and put them in an array.
            // ... Add the third node, and specify these as its children.
            //
            //TreeNode node2 = new TreeNode("Beef");
            //TreeNode node3 = new TreeNode("VB.NET");
            //TreeNode[] array = new TreeNode[] { node2, node3 };
            //
            // Final node.
            //
            //treeNode = new TreeNode("Dot Net Perls", array);
            //treeView1.Nodes.Add(treeNode);
        }



        private void treeView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //
            // Get the selected node.
            //
            //TreeNode node = treeView1.SelectedNode;
            //
            // Render message box.
            //
            //String sqlquery "Select name from Data where name = node";
            //MessageBox.Show(string.Format("You selected: {0}", node.Text));

            //using (SQLiteConnection conn = new SQLiteConnection("Data Source = |DataDirectory|\\JTIS.db"))
            //{
            //    conn.Open();


            //    TreeNode node = treeView1.SelectedNode;
            //    string nodename = node.ToString();
            //    ////SQLiteCommand cmd = new SQLiteCommand("SELECT Information FROM DATA WHERE name='" + (nodename.Trim().Replace("'", "''")) + "'", conn);
            //    SQLiteCommand cmd = new SQLiteCommand("SELECT article FROM DATA WHERE name ='" + (nodename.Trim().Remove(0, 10)) + "'", conn);
            //var substring = ("SELECT image_id FROM DATA WHERE name ='" + (nodename.Trim().Remove(0, 10)) + "'");


            //SQLiteCommand cmd2 = new SQLiteCommand("SELECT IMAGE FROM IMAGES INNER JOIN DATA ON IMAGES.image_id=DATA.image_id WHERE DATA.name ='" + (nodename.Trim().Remove(0, 10)) + "'", conn);


            //SQLiteDataReader reader = cmd.ExecuteReader();
            //SQLiteDataReader reader2 = cmd2.ExecuteReader();


            //while (reader.Read())
            //{
            //    webBrowser1.DocumentText = (reader["article"].ToString());


            //For Text inside a BLOB
            //byte[] imageBytes = (Byte[])reader["image"];
            //MemoryStream ms = new MemoryStream(imageBytes);
            //pictureBox1.Image = Image.FromStream(ms, true);
            //webBrowser1.DocumentText = Convert.ToBase64String(data); //For text inside a Blob

            //For Image inside a BLOB


            //byte[] imagepic = (byte[])reader["article"];

            //Clipboard.SetImage(Image.FromStream(ms, true));
            //richTextBox1.Paste();



            //richTextBox1.Text = UTF8Encoding.ASCII.GetString(imagepic); //For text inside a Blob




        }

    }

    //using (SQLiteConnection conn2 = new SQLiteConnection("Data Source = |DataDirectory|\\JTIS.db"))
    //{
    //    conn2.Open();


    //    TreeNode node = treeView1.SelectedNode;
    //    string nodename = node.ToString();
    //    SQLiteCommand cmd2 = new SQLiteCommand("SELECT IMAGE FROM IMAGES INNER JOIN DATA ON IMAGES.image_id=DATA.image_id WHERE DATA.name ='" + (nodename.Trim().Remove(0, 10)) + "'", conn2);

    //    SQLiteDataReader reader2 = cmd2.ExecuteReader();

    //    while (reader2.Read())
    //    {
    //        byte[] imageBytes = (Byte[])reader2["image"];
    //        MemoryStream ms = new MemoryStream(imageBytes);
    //        //pictureBox1.Image = Image.FromStream(ms, true);
    //        Clipboard.SetImage(Image.FromStream(ms, true));
    //        richTextBox1.Paste();
    //    }
    //    }
    //}






    ////MessageBox.Show(reader["beer_key"].ToString());
    ////textBox1.Text = (reader["beer_key"].ToString());
    ////richTextBox1.Text = (reader["article"].ToString());
    //MessageBox.Show(reader["article"].ToString());
    ////byte[] BinArticle = (byte[])row["article"];
    //richTextBox1.Text = (reader["article"].ToString());



    //private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
    //{
        ////switch ((e.Action))
        ////{
        ////    case TreeViewAction.ByKeyboard:
        ////        MessageBox.Show("You like the keyboard!");
        ////        break;
        ////    case TreeViewAction.ByMouse:
        //          String str=TreeView1.SelectedNode.Value.ToString();
        //          MessageBox.Show("You like the keyboard!");

        //          //String Sqlquery="select ChapterContent from CourseChapters where ChapterName= '" + str+"'";
        ////        richTextBox1.text("sqlquery");
        ////        break;
        ////}

        //treeView1.SelectedNode = treeView1.Nodes[0].Nodes[1];








    }





