using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gallery
{
    public partial class Form1 : Form
    {
        public List<string> patchs = new List<string>();
        public int SelectedPatch = 0;
        private int indexOfItemUnderMouseToDrag;
        private int indexOfItemUnderMouseToDrop;
        private string CopyPath;

        private Rectangle dragBoxFromMouseDown;
        private Point screenOffset;
        private bool RemoveFile;
        private int counter = 1;
        private string OldName = "";
        private int Index = 0;

        public Form1()
        {
            InitializeComponent();
            treeView1.BeforeSelect += treeView1_BeforeSelect;
            treeView1.BeforeExpand += treeView1_BeforeExpand;
            FillDriveNodes();
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.Nodes.Clear();
            string[] dirs;
            try
            {
                
                if (Directory.Exists( treeView1.SelectedNode.FullPath))
                {
                    dirs = Directory.GetDirectories(treeView1.SelectedNode.FullPath);
                    if (dirs.Length != 0)
                    {
                        for (int i = 0; i < dirs.Length; i++)
                        {
                            TreeNode dirNode = new TreeNode(new DirectoryInfo(dirs[i]).Name);
                            FillTreeNode(dirNode, dirs[i]);
                            e.Node.Nodes.Add(dirNode);
                        }
                    }
                }
            }
            catch (Exception ex) { }

        }

        private void treeView1_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.Nodes.Clear();
            string[] dirs;
            try
            {
                if (Directory.Exists(e.Node.FullPath))
                {
                    dirs = Directory.GetDirectories(e.Node.FullPath);
                    if (dirs.Length != 0)
                    {
                        for (int i = 0; i < dirs.Length; i++)
                        {
                            TreeNode dirNode = new TreeNode(new DirectoryInfo(dirs[i]).Name);
                            FillTreeNode(dirNode, dirs[i]);
                            e.Node.Nodes.Add(dirNode);
                        }
                    }
                }
            }
            catch (Exception ex) { }
        }
        private void FillDriveNodes()
        {
            treeView1.ImageList = imageList1;
            try
            {
                foreach (DriveInfo drive in DriveInfo.GetDrives())
                {
                    TreeNode driveNode = new TreeNode { Text = drive.Name, ImageIndex = 0 };
                    FillTreeNode(driveNode, drive.Name);
                    treeView1.Nodes.Add(driveNode);
                }
            }
            catch (Exception ex) { }
        }

        private void FillTreeNode(TreeNode driveNode, string path)
        {
            try
            {
                string[] dirs = Directory.GetDirectories(path);
                foreach (string dir in dirs)
                {
                    TreeNode dirNode = new TreeNode();
                    dirNode.Text = dir.Remove(0, dir.LastIndexOf("\\") + 1);
                    driveNode.Nodes.Add(dirNode);
                }
            }
            catch (Exception ex) { }

            string myDocumentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string[] dirs1 = Directory.GetDirectories(myDocumentsPath);




        }


        public void LoadListInPatch(string patch)
        {
            listView1.Items.Clear();
            listView1.View = View.Details;
            try {
                DirectoryInfo di = new DirectoryInfo(patch);
                DirectoryInfo[] dirs = di.GetDirectories();
                foreach (DirectoryInfo dir in dirs)
                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Name = dir.FullName;
                    listViewItem.ImageIndex = 0;
                    listViewItem.Text = dir.Name;
                    listView1.Items.Add(listViewItem);
                }
                FileInfo[] files = di.GetFiles();
                foreach (FileInfo file in files)
                {
                    imageList1.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(file.ToString()));
                    var arr = file.FullName.Split('.');
                    if (arr[arr.Length - 1] == "png")
                    {
                        arr = arr[0].Split("\\");
                        ListViewItem listViewItem = new ListViewItem(new string[] { arr[arr.Length - 1].ToString(), file.LastWriteTime.ToString(), file.Extension.ToString(), (file.Length + " КБ").ToString() });
                        listViewItem.Name = file.FullName;
                        listViewItem.ImageIndex = imageList1.Images.Count - 1;
                        listView1.Items.Add(listViewItem);
                    }
                }
            }
            catch (System.IO.DirectoryNotFoundException)
            {

            }
            catch (System.ArgumentException)
            {
                LoadMainMenu();
            }
        }

    
        private void treeView1_Click(object sender, EventArgs e)
        {
            PatchTextBox.Text = treeView1.SelectedNode.FullPath;
            patchs.Add(treeView1.SelectedNode.FullPath);
            SelectedPatch++;
            LoadListInPatch(treeView1.SelectedNode.FullPath);
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            PatchTextBox.Text = listView1.FocusedItem.Name;
            var type = listView1.FocusedItem.Name.Split('.');
            if (type[type.Length - 1] != "png")
            {
                patchs.Add(listView1.FocusedItem.Name);
                SelectedPatch++;
                LoadListInPatch(listView1.FocusedItem.Name);
            }
            else
            {


                List<string> img = new List<String>();
                img.Add(listView1.FocusedItem.Name);
                var path = PatchTextBox.Text.Replace(listView1.FocusedItem.Text + ".png","");
                var imag = Directory.GetFiles(path, "*.png");
                foreach(var i in imag)
                {
                    img.Add(i);
                }
                var Picture = new Picture(img);
                Picture.Show();
            }
            if(SelectedPatch == 0)
            {
                buttonBack.Enabled = false;
            }
            if(SelectedPatch == patchs.Count - 1)
            {
                buttonForward.Enabled = false;
            }
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void PatchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                LoadListInPatch(PatchTextBox.Text);
            }
        }

        private void buttonBack_MouseEnter(object sender, EventArgs e)
        {
            buttonBack.ForeColor = Color.Blue;
        }

        private void buttonBack_MouseLeave(object sender, EventArgs e)
        {
            buttonBack.ForeColor = Color.Black;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            btnFocus.Focus();
            try
            {
                LoadListInPatch(patchs[SelectedPatch - 1]);
                PatchTextBox.Text = patchs[SelectedPatch - 1];
                SelectedPatch--;
            }
            catch (Exception)
            {
                LoadMainMenu();
            };
        }

        private void buttonForward_MouseEnter(object sender, EventArgs e)
        {
            buttonForward.ForeColor = Color.Blue;
        }

        private void buttonForward_MouseLeave(object sender, EventArgs e)
        {
            buttonForward.ForeColor = Color.Black;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadMainMenu();
        }
        public void LoadMainMenu()
        {
            PatchTextBox.Text = "";
            listView1.Items.Clear();
            listView1.View = View.Tile;
            List<MyComputerFile> myComputerFiles = new List<MyComputerFile>();
            myComputerFiles.Add(new MyComputerFile() { Name = "Документы", Patch = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), IndexImg = 4 });
            myComputerFiles.Add(new MyComputerFile() { Name = "Картинки ", Patch = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), IndexImg = 1 });
            myComputerFiles.Add(new MyComputerFile() { Name = "Музыка ", Patch = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), IndexImg = 3 });
            myComputerFiles.Add(new MyComputerFile() { Name = "Рабочий стол ", Patch = Environment.GetFolderPath(Environment.SpecialFolder.Desktop), IndexImg = 5 });
            var drive = DriveInfo.GetDrives();
            foreach(var dr in drive)
            {
                myComputerFiles.Add(new MyComputerFile() { Name = dr.Name, Patch = dr.Name, IndexImg = 6 });
            }
            foreach (var item in myComputerFiles)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Name = item.Patch;
                listViewItem.ImageIndex = item.IndexImg;
                listViewItem.Text = item.Name;
                listView1.Items.Add(listViewItem);
            }
        }

        private void buttonForward_Click(object sender, EventArgs e)
        {
            try
            {
                LoadListInPatch(patchs[SelectedPatch]);
                PatchTextBox.Text = patchs[SelectedPatch];
                SelectedPatch++;
            }
            catch (Exception) { };
        }

        private void listView1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void listView1_MouseDown(object sender, MouseEventArgs e)
        {
            indexOfItemUnderMouseToDrag = listView1.Items.IndexOf(listView1.GetItemAt(e.X, e.Y));

            if (indexOfItemUnderMouseToDrag != ListBox.NoMatches)
            {



                Size dragSize = SystemInformation.DragSize;


                dragBoxFromMouseDown = new Rectangle(new Point(e.X - (dragSize.Width / 2),
                                                               e.Y - (dragSize.Height / 2)), dragSize);
            }
            else

                dragBoxFromMouseDown = Rectangle.Empty;
        }

        private void listView1_MouseUp(object sender, MouseEventArgs e)
        {
            dragBoxFromMouseDown = Rectangle.Empty;
            indexOfItemUnderMouseToDrop = listView1.Items.IndexOf(listView1.GetItemAt(e.X, e.Y));
        }

        private void listView1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                if (dragBoxFromMouseDown != Rectangle.Empty &&
                    !dragBoxFromMouseDown.Contains(e.X, e.Y))
                {
                    screenOffset = SystemInformation.WorkingArea.Location;
                    DragDropEffects dropEffect = listView1.DoDragDrop(listView1.Items[indexOfItemUnderMouseToDrag],
                        DragDropEffects.All);
                }
            }
        }

        private void listView1_DragOver(object sender, DragEventArgs e)
        {

        }

        private void listView1_DragDrop(object sender, DragEventArgs e)
        {
            var a = listView1.PointToClient(MousePosition);
            indexOfItemUnderMouseToDrop = listView1.Items.IndexOf(listView1.GetItemAt(a.X, a.Y));
            if (e.KeyState == 8)
            {
                ReplaceFrom(listView1.Items[indexOfItemUnderMouseToDrag].Name, listView1.Items[indexOfItemUnderMouseToDrop].Name, false);
            }
            else
            {
                ReplaceFrom(listView1.Items[indexOfItemUnderMouseToDrag].Name, listView1.Items[indexOfItemUnderMouseToDrop].Name, true);
            }
        }
        public void ReplaceFrom(string SourcePath, string DestinationPath, bool DeleteOrCopy)
        {
            try
            {
                foreach (string dirPath in Directory.GetDirectories(SourcePath, "*"))
                {
                    var name = dirPath.Split('\\');

                    var a = Directory.CreateDirectory(DestinationPath + "\\" + name[name.Length - 2]);
                    Directory.CreateDirectory(a + "\\" + name[name.Length - 1]);
                }
            }
            catch (Exception e) { }

            try
            {
                foreach (string newPath in Directory.GetFiles(SourcePath, "*.*"))
                {
                    var name = newPath.Split('\\');
                    File.Copy(newPath, DestinationPath + "\\" + name[name.Length - 2] + "\\" + name[name.Length - 1]);
                }
            }
            catch (Exception e)
            {
                if (File.Exists(SourcePath))
                {
                    var name = SourcePath.Split('\\');
                    File.Copy(SourcePath, DestinationPath + "\\" + name[name.Length - 1]);
                }
            }
            if(DeleteOrCopy == true)
            {
                try
                {
                    Directory.Delete(SourcePath);
                    File.Delete(SourcePath);
                }
                catch (Exception ex) { };
            }
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
           

        }

        private void buttonCreateFolder_Click(object sender, EventArgs e)
        {
            
            if (Directory.Exists(PatchTextBox.Text + "\\Новая папка"))
            {
                Directory.CreateDirectory(PatchTextBox.Text  + $"\\Новая папка({counter})");
                OldName = $"\\Новая папка({counter})";
                LoadListInPatch(PatchTextBox.Text);
                ListViewItem item = listView1.Items
                             .Cast<ListViewItem>()
                             .FirstOrDefault(x => x.Text == $"Новая папка({counter})");

                var ind = listView1.Items.IndexOf(item);
                if(ind != -1)
                {
                    
                    listView1.Items[ind].BeginEdit();
                }
                counter++;
            }
            else
            {
                counter = 1;
                Directory.CreateDirectory(PatchTextBox.Text + "\\Новая папка");
                LoadListInPatch(PatchTextBox.Text);
                LoadListInPatch(PatchTextBox.Text);
                ListViewItem item = listView1.Items
                             .Cast<ListViewItem>()
                             .FirstOrDefault(x => x.Text == $"Новая папка");

                var ind = listView1.Items.IndexOf(item);
                if (ind != -1)
                {
                    OldName = "Новая папка";
                    listView1.Items[ind].BeginEdit();
                  
                }
                
            }
        }
        

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                Directory.Delete(listView1.SelectedItems[0].Name,true);
                LoadListInPatch(PatchTextBox.Text);
            }
            catch (System.IO.IOException)
            {
                File.Delete(listView1.SelectedItems[0].Name);
                LoadListInPatch(PatchTextBox.Text);
            }
            catch(Exception ex) { }
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            CopyPath = listView1.SelectedItems[0].Name;
            RemoveFile = false;
        }

        private void buttomPaste_Click(object sender, EventArgs e)
        {

            PasteFile();
            LoadListInPatch(PatchTextBox.Text);
           

        }
        public void PasteFile()
        {
            if (Directory.Exists(CopyPath))
            {
                var name = CopyPath.Split('\\');
                Directory.CreateDirectory(PatchTextBox.Text + $"\\{name[name.Length - 1]}");
                foreach(var dir in Directory.GetDirectories(CopyPath))
                {
                    var nameDir = dir.Split('\\');
                    Directory.CreateDirectory(PatchTextBox.Text + $"\\{name[name.Length - 1]}\\{nameDir[nameDir.Length -1]}");
                }
                foreach (string newPath in Directory.GetFiles(CopyPath, "*.*"))
                {
                    var nameP = newPath.Split('\\');
                    File.Copy(newPath, (PatchTextBox.Text + $"\\" + "\\" + nameP[nameP.Length - 2] + "\\" + nameP[nameP.Length - 1]));
                }
            }
            if (File.Exists(CopyPath))
            {
                var name = CopyPath.Split('\\');
                File.Copy(CopyPath, PatchTextBox.Text + $"\\{name[name.Length - 1]}");
            }
            LoadListInPatch(PatchTextBox.Text);
            if(RemoveFile == true)
            {
                try
                {
                    Directory.Delete(CopyPath,true);
                    CopyPath = "";
                }
                catch (System.IO.IOException)
                {
                    File.Delete(CopyPath);
                }
            }
        }
        
        private void buttonCutOut_Click(object sender, EventArgs e)
        {
            RemoveFile = true;
            CopyPath = listView1.SelectedItems[0].Name;
            listView1.SelectedItems[0].Remove();
        }

        private void buttonCopyPath_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(PatchTextBox.Text);
             
        }

        private void buttonRename_Click(object sender, EventArgs e)
        {
            try
            {
                OldName = listView1.SelectedItems[0].Text;
                Index = listView1.Items.IndexOf(listView1.SelectedItems[0]);
                listView1.SelectedItems[0].BeginEdit();
            }
            catch (Exception) { }
             
             

        }
        public void RenameFolder(int IndexFolder)
        {
            Directory.Move(PatchTextBox.Text + $"\\{listView1.Items[OldName].Text},", PatchTextBox.Text + $"\\{listView1.Items[IndexFolder].Text}");
        }
        private void listView1_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            try
            {
                Directory.Move(PatchTextBox.Text + $"\\{OldName}", PatchTextBox.Text + $"\\{e.Label}");
                LoadListInPatch(PatchTextBox.Text);
                OldName = "";
            }
            catch (System.IO.IOException) { }
        }

        private void listView1_BeforeLabelEdit(object sender, LabelEditEventArgs e)
        {
          
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
    }   
}



