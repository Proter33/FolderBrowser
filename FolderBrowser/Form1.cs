using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using FolderBrowser.Properties;

namespace FolderBrowser {
    public partial class FolderBrowser : Form {

        public string directory1;
        public string directory2;
        public bool left;
        public bool is_collapsed_left = true;
        public bool is_collapsed_right = true;
        public string prefix_left = "default";
        public string prefix_right = "default";

        public String[] files = System.IO.Directory.GetFiles(@"C:\");
        public String[] folders = System.IO.Directory.GetDirectories(@"C:\");
        public String[] files2 = System.IO.Directory.GetFiles(@"C:\");
        public String[] folders2 = System.IO.Directory.GetDirectories(@"C:\");
        private object panel_order_list;

        public void Folder_Loader_Left(String prefix) {

            label_dir_left.Text = directory1;

            DataTable table = new DataTable();
            table.Columns.Add("File Name");
            table.Columns.Add("File Size");
            DataColumn date = new DataColumn("Date Create");
            date.DataType = System.Type.GetType("System.DateTime");
            table.Columns.Add(date);
            
            for (int i = 0; i < folders.Length; i++) {
                DirectoryInfo folder = new DirectoryInfo(folders[i]);
                table.Rows.Add(folder.Name, "<DIR>", folder.CreationTime);
            }

            for (int i = 0; i < files.Length; i++) {
                FileInfo file = new FileInfo(files[i]);
                table.Rows.Add(file.Name, Convert.ToDouble(file.Length / 1024) + "KB", file.CreationTime);
            }

            if (prefix == "name ASC")
                table.DefaultView.Sort = "File Name";
            else if (prefix == "name DESC") {
                DataView view = table.DefaultView;
                view.Sort = "File Name DESC";
                table = view.ToTable();
            }
            else if (prefix == "time ASC")
                table.DefaultView.Sort = "Date Create";
            else if (prefix == "time DESC") {
                DataView view = table.DefaultView;
                view.Sort = "Date Create DESC";
                table = view.ToTable();
            }
            DataRow sub = table.NewRow();
            sub[0] = "..";
            sub[1] = "<DIR>";
            table.Rows.InsertAt(sub, 0);
            dataGridView_left.DataSource = table;
            dataGridView_left.Rows[1].Selected = false;

        }

        public void Folder_Loader_Right(String prefix) {

            label_dir_right.Text = directory2;

            DataTable table2 = new DataTable();
            table2.Columns.Add("File Name");
            table2.Columns.Add("File Size");
            DataColumn date = new DataColumn("Date Create");
            date.DataType = System.Type.GetType("System.DateTime");
            table2.Columns.Add(date);

            for (int i = 0; i < folders2.Length; i++) {
                DirectoryInfo folder = new DirectoryInfo(folders2[i]);
                table2.Rows.Add(folder.Name, "<DIR>", folder.CreationTime);
            }

            for (int i = 0; i < files2.Length; i++) {
                FileInfo file = new FileInfo(files2[i]);
                table2.Rows.Add(file.Name, Convert.ToDouble(file.Length / 1024) + "KB", file.CreationTime);
            }

            if (prefix == "name ASC")
                table2.DefaultView.Sort = "File Name";
            else if (prefix == "name DESC") {
                DataView view = table2.DefaultView;
                view.Sort = "File Name DESC";
                table2 = view.ToTable();
            }
            else if (prefix == "time ASC")
                table2.DefaultView.Sort = "Date Create";
            else if (prefix == "time DESC") {
                DataView view = table2.DefaultView;
                view.Sort = "Date Create DESC";
                table2 = view.ToTable();
            }
            DataRow sub = table2.NewRow();
            sub[0] = "..";
            sub[1] = "<DIR>";
            table2.Rows.InsertAt(sub, 0);

            dataGridView_right.DataSource = table2;
            dataGridView_right.Rows[0].Selected = false;

        }

        public bool mkdir(String tmp) {
            if (left) {
                if (!System.IO.Directory.Exists(Path.Combine(directory1, tmp))) {
                    System.IO.Directory.CreateDirectory(Path.Combine(directory1, tmp));
                    return true;
                }
                else
                    return false;
            }
            else {
                if (!System.IO.Directory.Exists(Path.Combine(directory2, tmp))) {
                    System.IO.Directory.CreateDirectory(Path.Combine(directory2, tmp));
                    return true;
                }
                else
                    return false;
            }
        }

        public FolderBrowser() {
            InitializeComponent();
        }

        private void FolderBrowser_Load(object sender, EventArgs e) {

            FolderBrowserDialog FBD = new FolderBrowserDialog();

            if (FBD.ShowDialog() == DialogResult.OK) {
                directory1 = FBD.SelectedPath;
                directory2 = FBD.SelectedPath;
                files = System.IO.Directory.GetFiles(directory1);
                files2 = System.IO.Directory.GetFiles(directory2);
                folders = System.IO.Directory.GetDirectories(directory1);
                folders2 = System.IO.Directory.GetDirectories(directory2);
            }

            Folder_Loader_Left("default");
            Folder_Loader_Right("default");
        }

        private void button_directory_left_Click(object sender, EventArgs e) {

            FolderBrowserDialog FBD = new FolderBrowserDialog();

            if(FBD.ShowDialog() == DialogResult.OK) {
                directory1 = FBD.SelectedPath;
                files = System.IO.Directory.GetFiles(directory1);
                folders = System.IO.Directory.GetDirectories(directory1);
            }

            Folder_Loader_Left(prefix_left);
        }

        private void button_directory_right_Click(object sender, EventArgs e) {
            FolderBrowserDialog FBD = new FolderBrowserDialog();

            if (FBD.ShowDialog() == DialogResult.OK) {
                directory2 = FBD.SelectedPath;
                files2 = System.IO.Directory.GetFiles(directory2);
                folders2 = System.IO.Directory.GetDirectories(directory2);
            }

            Folder_Loader_Right(prefix_right);
        }

        private void dataGridView_left_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            int selectedrowindex = dataGridView_left.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView_left.Rows[selectedrowindex];
            string tmp = selectedRow.Cells[0].Value.ToString();
            if (selectedRow.Cells[1].Value.ToString() == "<DIR>") {
                if (tmp == "..") {
                    directory1 = directory1.Substring(0, directory1.LastIndexOf('\\'));
                    files = System.IO.Directory.GetFiles(directory1);
                    folders = System.IO.Directory.GetDirectories(directory1);
                }
                else {
                    directory1 = directory1 + "\\" + tmp;
                    files = System.IO.Directory.GetFiles(directory1);
                    folders = System.IO.Directory.GetDirectories(directory1);
                }

                Folder_Loader_Left(prefix_left);
            }
        }

        private void dataGridView_right_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            int selectedrowindex = dataGridView_right.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView_right.Rows[selectedrowindex];
            string tmp = selectedRow.Cells[0].Value.ToString();
            if (selectedRow.Cells[1].Value.ToString() == "<DIR>") {
                if (tmp == "..") {
                    directory2 = directory2.Substring(0, directory2.LastIndexOf('\\'));
                    files2 = System.IO.Directory.GetFiles(directory2);
                    folders2 = System.IO.Directory.GetDirectories(directory2);
                }
                else {
                    directory2 = directory2 + "\\" + tmp;
                    files2 = System.IO.Directory.GetFiles(directory2);
                    folders2 = System.IO.Directory.GetDirectories(directory2);
                }
                
                Folder_Loader_Right(prefix_right);
            }
        }

        private void dataGridView_left_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (dataGridView_right.SelectedRows.Count > 0) {
                int selectedrowindex = dataGridView_right.SelectedCells[0].RowIndex;
                dataGridView_right.Rows[selectedrowindex].Selected = false;
            }
        }

        private void dataGridView_right_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (dataGridView_left.SelectedRows.Count > 0) {
                int selectedrowindex = dataGridView_left.SelectedCells[0].RowIndex;
                dataGridView_left.Rows[selectedrowindex].Selected = false;
            }
        }

        private void button_remove_Click(object sender, EventArgs e) {
            String tmp = "";
            DataGridViewRow selectedRow = new DataGridViewRow();
            bool flag = false;
            bool run = false;
            if (dataGridView_left.SelectedRows.Count > 0) {
                int selectedrowindex = dataGridView_left.SelectedCells[0].RowIndex;
                selectedRow = dataGridView_left.Rows[selectedrowindex];
                tmp = selectedRow.Cells[0].Value.ToString();
                flag = true;
                run = true;
            }
            else if (dataGridView_right.SelectedRows.Count > 0) {
                int selectedrowindex = dataGridView_right.SelectedCells[0].RowIndex;
                selectedRow = dataGridView_right.Rows[selectedrowindex];
                tmp = selectedRow.Cells[0].Value.ToString();
                run = true;
            }
            if (run) {
                if (selectedRow.Cells[1].Value.ToString() == "<DIR>") {
                    if (flag)
                        System.IO.Directory.Delete(Path.Combine(directory1, tmp), true);
                    else
                        System.IO.Directory.Delete(Path.Combine(directory2, tmp), true);
                }
                else {
                    if (flag)
                        File.Delete(Path.Combine(directory1, tmp));
                    else
                        File.Delete(Path.Combine(directory2, tmp));
                }
                String tmp_dir1 = directory1 + "\\" + tmp;
                String tmp_dir2 = directory2 + "\\" + tmp;
                if (tmp_dir2 == directory1)
                directory1 = directory1.Substring(0, directory1.LastIndexOf('\\'));
                files = System.IO.Directory.GetFiles(directory1);
                folders = System.IO.Directory.GetDirectories(directory1);
                Folder_Loader_Left(prefix_left);
                if (tmp_dir1 == directory2)
                    directory2 = directory2.Substring(0, directory2.LastIndexOf('\\'));
                files2 = System.IO.Directory.GetFiles(directory2);
                folders2 = System.IO.Directory.GetDirectories(directory2);
                Folder_Loader_Right(prefix_right);
            }
        }

        private void dataGridView_left_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.F8) {
                int selectedrowindex = dataGridView_left.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView_left.Rows[selectedrowindex];
                string tmp = selectedRow.Cells[0].Value.ToString();
                if (selectedRow.Cells[1].Value.ToString() == "<DIR>")
                    System.IO.Directory.Delete(Path.Combine(directory1, tmp), true);
                else
                    File.Delete(Path.Combine(directory1, tmp));
                String tmp_dir1 = directory1 + "\\" + tmp;
                files = System.IO.Directory.GetFiles(directory1);
                folders = System.IO.Directory.GetDirectories(directory1);
                Folder_Loader_Left(prefix_left);
                if (tmp_dir1 == directory2)
                    directory2 = directory2.Substring(0, directory2.LastIndexOf('\\'));
                files2 = System.IO.Directory.GetFiles(directory2);
                folders2 = System.IO.Directory.GetDirectories(directory2);
                Folder_Loader_Right(prefix_right);
                e.Handled = true;
            }
            if(e.KeyCode == Keys.F7) {
                Directories directory = new Directories(this);
                left = true;
                DialogResult dialogResult = directory.ShowDialog();
                if (dialogResult == DialogResult.OK)
                    MessageBox.Show("Directory Created");
                if (dialogResult == DialogResult.Abort)
                    MessageBox.Show("Directory Already Exists");
                files = System.IO.Directory.GetFiles(directory1);
                folders = System.IO.Directory.GetDirectories(directory1);
                Folder_Loader_Left(prefix_left);
                files2 = System.IO.Directory.GetFiles(directory2);
                folders2 = System.IO.Directory.GetDirectories(directory2);
                Folder_Loader_Right(prefix_right);
                e.Handled = true;
            }
                
        }

        private void dataGridView_right_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.F8) {
                int selectedrowindex = dataGridView_right.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView_right.Rows[selectedrowindex];
                string tmp = selectedRow.Cells[0].Value.ToString();
                if (selectedRow.Cells[1].Value.ToString() == "<DIR>")
                    System.IO.Directory.Delete(Path.Combine(directory2, tmp), true);
                else
                    File.Delete(Path.Combine(directory2, tmp));
                String tmp_dir2 = directory2 + "\\" + tmp;
                if(tmp_dir2 == directory1)
                    directory1 = directory1.Substring(0, directory1.LastIndexOf('\\'));
                files = System.IO.Directory.GetFiles(directory1);
                folders = System.IO.Directory.GetDirectories(directory1);
                Folder_Loader_Left(prefix_left);
                files2 = System.IO.Directory.GetFiles(directory2);
                folders2 = System.IO.Directory.GetDirectories(directory2);
                Folder_Loader_Right(prefix_right);
                e.Handled = true;
            }
            if (e.KeyCode == Keys.F7) {
                Directories directory = new Directories(this);
                left = false;
                DialogResult dialogResult = directory.ShowDialog();
                if (dialogResult == DialogResult.OK)
                    MessageBox.Show("Directory Created");
                if (dialogResult == DialogResult.Abort)
                    MessageBox.Show("Directory Already Exists");
                files = System.IO.Directory.GetFiles(directory1);
                folders = System.IO.Directory.GetDirectories(directory1);
                Folder_Loader_Left(prefix_left);
                files2 = System.IO.Directory.GetFiles(directory2);
                folders2 = System.IO.Directory.GetDirectories(directory2);
                Folder_Loader_Right(prefix_right);
                e.Handled = true;
            }
        }

        private void button_mkdir_Click(object sender, EventArgs e) {
            Directories directory = new Directories(this);
            bool run = false;
            if (dataGridView_left.SelectedRows.Count > 0) {
                left = true;
                run = true;
            }
            else if (dataGridView_right.SelectedRows.Count > 0) {
                run = true;
            left = false;
            }
            if (run) {
                DialogResult dialogResult = directory.ShowDialog();
                if (dialogResult == DialogResult.OK)
                    MessageBox.Show("Directory Created");
                if (dialogResult == DialogResult.Abort)
                    MessageBox.Show("Directory Already Exists");
                files = System.IO.Directory.GetFiles(directory1);
                folders = System.IO.Directory.GetDirectories(directory1);
                Folder_Loader_Left(prefix_left);
                files2 = System.IO.Directory.GetFiles(directory2);
                folders2 = System.IO.Directory.GetDirectories(directory2);
                Folder_Loader_Right(prefix_right);
            }
        }

        private void button_left_default_Click(object sender, EventArgs e) {
            prefix_left = "default";
            button_left_order_list.Text = "Default";
            timer1.Start();
            Folder_Loader_Left(prefix_left);
        }

        private void button_left_name_ASC_Click(object sender, EventArgs e) {
            prefix_left = "name ASC";
            button_left_order_list.Text = "Name ASC";
            timer1.Start();
            Folder_Loader_Left(prefix_left);
        }

        private void button_left_name_DESC_Click(object sender, EventArgs e) {
            prefix_left = "name DESC";
            button_left_order_list.Text = "Name DESC";
            timer1.Start();
            Folder_Loader_Left(prefix_left);
        }

        private void button_left_date_ASC_Click(object sender, EventArgs e) {
            prefix_left = "time ASC";
            button_left_order_list.Text = "Date ASC";
            timer1.Start();
            Folder_Loader_Left(prefix_left);
        }

        private void button_left_date_DESC_Click(object sender, EventArgs e) {
            prefix_left = "time DESC";
            button_left_order_list.Text = "Date DESC";
            timer1.Start();
            Folder_Loader_Left(prefix_left);
        }

        private void button_right_default_Click(object sender, EventArgs e) {
            prefix_right = "default";
            button_right_order_list.Text = "Default";
            timer3.Start();
            Folder_Loader_Right(prefix_right);
        }

        private void button_right_name_ASC_Click(object sender, EventArgs e) {
            prefix_right = "name ASC";
            button_right_order_list.Text = "Name ASC";
            timer3.Start();
            Folder_Loader_Right(prefix_right);
        }

        private void button_right_name_DESC_Click(object sender, EventArgs e) {
            prefix_right = "name DESC";
            button_right_order_list.Text = "Name DESC";
            timer3.Start();
            Folder_Loader_Right(prefix_right);
        }

        private void button_right_time_ASC_Click(object sender, EventArgs e) {
            prefix_right = "time ASC";
            button_right_order_list.Text = "Date ASC";
            timer3.Start();
            Folder_Loader_Right(prefix_right);
        }

        private void button_right_time_DESC_Click(object sender, EventArgs e) {
            prefix_right = "time DESC";
            button_right_order_list.Text = "Date DESC";
            timer3.Start();
            Folder_Loader_Right(prefix_right);
        }

        private void button_left_order_list_Click(object sender, EventArgs e) {
            timer1.Start();
        }

        private void button_right_order_list_Click(object sender, EventArgs e) {
            timer3.Start();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            if(is_collapsed_left) {
                button_left_order_list.Image = Resources.collapse;
                panel_order_left.Height += 10;
                if(panel_order_left.Size == panel_order_left.MaximumSize) {
                    timer1.Stop();
                    timer2.Start();
                    is_collapsed_left = false;
                }
            }
            else {
                button_left_order_list.Image = Resources.expande;
                panel_order_left.Height -= 10;
                if(panel_order_left.Size == panel_order_left.MinimumSize) {
                    timer1.Stop();
                    is_collapsed_left = true;
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e) {
            if(!is_collapsed_left) {
                timer1.Start();
                timer2.Stop();
            }
            else if(!is_collapsed_right) {
                timer3.Start();
                timer2.Stop();
            }
        }

        private void timer3_Tick(object sender, EventArgs e) {
            if (is_collapsed_right) {
                button_right_order_list.Image = Resources.collapse;
                panel_order_right.Height += 10;
                if (panel_order_right.Size == panel_order_right.MaximumSize) {
                    timer3.Stop();
                    timer2.Start();
                    is_collapsed_right = false;
                }
            }
            else {
                button_right_order_list.Image = Resources.expande;
                panel_order_right.Height -= 10;
                if (panel_order_right.Size == panel_order_right.MinimumSize) {
                    timer3.Stop();
                    is_collapsed_right = true;
                }
            }
        }
    }
}
