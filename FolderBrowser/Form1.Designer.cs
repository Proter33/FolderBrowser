namespace FolderBrowser {
    partial class FolderBrowser {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.dataGridView_left = new System.Windows.Forms.DataGridView();
            this.dataGridView_right = new System.Windows.Forms.DataGridView();
            this.button_directory_left = new System.Windows.Forms.Button();
            this.button_directory_right = new System.Windows.Forms.Button();
            this.label_dir_left = new System.Windows.Forms.Label();
            this.label_dir_right = new System.Windows.Forms.Label();
            this.button_remove = new System.Windows.Forms.Button();
            this.button_mkdir = new System.Windows.Forms.Button();
            this.button_left_name_ASC = new System.Windows.Forms.Button();
            this.button_left_name_DESC = new System.Windows.Forms.Button();
            this.button_left_date_ASC = new System.Windows.Forms.Button();
            this.button_left_date_DESC = new System.Windows.Forms.Button();
            this.button_left_default = new System.Windows.Forms.Button();
            this.button_right_default = new System.Windows.Forms.Button();
            this.button_right_name_ASC = new System.Windows.Forms.Button();
            this.button_right_name_DESC = new System.Windows.Forms.Button();
            this.button_right_time_ASC = new System.Windows.Forms.Button();
            this.button_right_time_DESC = new System.Windows.Forms.Button();
            this.panel_order_left = new System.Windows.Forms.Panel();
            this.button_left_order_list = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel_order_right = new System.Windows.Forms.Panel();
            this.button_right_order_list = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_right)).BeginInit();
            this.panel_order_left.SuspendLayout();
            this.panel_order_right.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_left
            // 
            this.dataGridView_left.AllowDrop = true;
            this.dataGridView_left.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_left.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView_left.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_left.Location = new System.Drawing.Point(12, 41);
            this.dataGridView_left.MultiSelect = false;
            this.dataGridView_left.Name = "dataGridView_left";
            this.dataGridView_left.ReadOnly = true;
            this.dataGridView_left.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_left.Size = new System.Drawing.Size(600, 720);
            this.dataGridView_left.TabIndex = 0;
            this.dataGridView_left.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_left_CellClick);
            this.dataGridView_left.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_left_CellDoubleClick);
            this.dataGridView_left.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_left_KeyDown);
            // 
            // dataGridView_right
            // 
            this.dataGridView_right.AllowDrop = true;
            this.dataGridView_right.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_right.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_right.Location = new System.Drawing.Point(632, 41);
            this.dataGridView_right.MultiSelect = false;
            this.dataGridView_right.Name = "dataGridView_right";
            this.dataGridView_right.ReadOnly = true;
            this.dataGridView_right.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_right.Size = new System.Drawing.Size(600, 720);
            this.dataGridView_right.TabIndex = 1;
            this.dataGridView_right.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_right_CellClick);
            this.dataGridView_right.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_right_CellDoubleClick);
            this.dataGridView_right.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_right_KeyDown);
            // 
            // button_directory_left
            // 
            this.button_directory_left.Location = new System.Drawing.Point(15, 767);
            this.button_directory_left.Name = "button_directory_left";
            this.button_directory_left.Size = new System.Drawing.Size(600, 23);
            this.button_directory_left.TabIndex = 2;
            this.button_directory_left.Text = "Open Directory";
            this.button_directory_left.UseVisualStyleBackColor = true;
            this.button_directory_left.Click += new System.EventHandler(this.button_directory_left_Click);
            // 
            // button_directory_right
            // 
            this.button_directory_right.Location = new System.Drawing.Point(632, 767);
            this.button_directory_right.Name = "button_directory_right";
            this.button_directory_right.Size = new System.Drawing.Size(600, 23);
            this.button_directory_right.TabIndex = 3;
            this.button_directory_right.Text = "Open Directory";
            this.button_directory_right.UseVisualStyleBackColor = true;
            this.button_directory_right.Click += new System.EventHandler(this.button_directory_right_Click);
            // 
            // label_dir_left
            // 
            this.label_dir_left.AutoSize = true;
            this.label_dir_left.Location = new System.Drawing.Point(12, 17);
            this.label_dir_left.Name = "label_dir_left";
            this.label_dir_left.Size = new System.Drawing.Size(67, 13);
            this.label_dir_left.TabIndex = 4;
            this.label_dir_left.Text = "directory_left";
            // 
            // label_dir_right
            // 
            this.label_dir_right.AutoSize = true;
            this.label_dir_right.Location = new System.Drawing.Point(629, 17);
            this.label_dir_right.Name = "label_dir_right";
            this.label_dir_right.Size = new System.Drawing.Size(73, 13);
            this.label_dir_right.TabIndex = 5;
            this.label_dir_right.Text = "directory_right";
            // 
            // button_remove
            // 
            this.button_remove.Location = new System.Drawing.Point(130, 796);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(109, 55);
            this.button_remove.TabIndex = 6;
            this.button_remove.Text = "Remove (F8)";
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // button_mkdir
            // 
            this.button_mkdir.Location = new System.Drawing.Point(15, 796);
            this.button_mkdir.Name = "button_mkdir";
            this.button_mkdir.Size = new System.Drawing.Size(109, 55);
            this.button_mkdir.TabIndex = 7;
            this.button_mkdir.Text = "New Folder (F7)";
            this.button_mkdir.UseVisualStyleBackColor = true;
            this.button_mkdir.Click += new System.EventHandler(this.button_mkdir_Click);
            // 
            // button_left_name_ASC
            // 
            this.button_left_name_ASC.Location = new System.Drawing.Point(0, 40);
            this.button_left_name_ASC.Name = "button_left_name_ASC";
            this.button_left_name_ASC.Size = new System.Drawing.Size(100, 23);
            this.button_left_name_ASC.TabIndex = 8;
            this.button_left_name_ASC.Text = "Name ASC";
            this.button_left_name_ASC.UseVisualStyleBackColor = true;
            this.button_left_name_ASC.Click += new System.EventHandler(this.button_left_name_ASC_Click);
            // 
            // button_left_name_DESC
            // 
            this.button_left_name_DESC.Location = new System.Drawing.Point(0, 60);
            this.button_left_name_DESC.Name = "button_left_name_DESC";
            this.button_left_name_DESC.Size = new System.Drawing.Size(100, 23);
            this.button_left_name_DESC.TabIndex = 9;
            this.button_left_name_DESC.Text = "Name DESC";
            this.button_left_name_DESC.UseVisualStyleBackColor = true;
            this.button_left_name_DESC.Click += new System.EventHandler(this.button_left_name_DESC_Click);
            // 
            // button_left_date_ASC
            // 
            this.button_left_date_ASC.Location = new System.Drawing.Point(0, 80);
            this.button_left_date_ASC.Name = "button_left_date_ASC";
            this.button_left_date_ASC.Size = new System.Drawing.Size(100, 23);
            this.button_left_date_ASC.TabIndex = 10;
            this.button_left_date_ASC.Text = "Date ASC";
            this.button_left_date_ASC.UseVisualStyleBackColor = true;
            this.button_left_date_ASC.Click += new System.EventHandler(this.button_left_date_ASC_Click);
            // 
            // button_left_date_DESC
            // 
            this.button_left_date_DESC.Location = new System.Drawing.Point(0, 100);
            this.button_left_date_DESC.Name = "button_left_date_DESC";
            this.button_left_date_DESC.Size = new System.Drawing.Size(100, 23);
            this.button_left_date_DESC.TabIndex = 11;
            this.button_left_date_DESC.Text = "Date DESC";
            this.button_left_date_DESC.UseVisualStyleBackColor = true;
            this.button_left_date_DESC.Click += new System.EventHandler(this.button_left_date_DESC_Click);
            // 
            // button_left_default
            // 
            this.button_left_default.Location = new System.Drawing.Point(0, 20);
            this.button_left_default.Name = "button_left_default";
            this.button_left_default.Size = new System.Drawing.Size(100, 23);
            this.button_left_default.TabIndex = 12;
            this.button_left_default.Text = "Default";
            this.button_left_default.UseVisualStyleBackColor = true;
            this.button_left_default.Click += new System.EventHandler(this.button_left_default_Click);
            // 
            // button_right_default
            // 
            this.button_right_default.Location = new System.Drawing.Point(0, 20);
            this.button_right_default.Name = "button_right_default";
            this.button_right_default.Size = new System.Drawing.Size(100, 23);
            this.button_right_default.TabIndex = 13;
            this.button_right_default.Text = "Default";
            this.button_right_default.UseVisualStyleBackColor = true;
            this.button_right_default.Click += new System.EventHandler(this.button_right_default_Click);
            // 
            // button_right_name_ASC
            // 
            this.button_right_name_ASC.Location = new System.Drawing.Point(0, 40);
            this.button_right_name_ASC.Name = "button_right_name_ASC";
            this.button_right_name_ASC.Size = new System.Drawing.Size(100, 23);
            this.button_right_name_ASC.TabIndex = 14;
            this.button_right_name_ASC.Text = "Name ASC";
            this.button_right_name_ASC.UseVisualStyleBackColor = true;
            this.button_right_name_ASC.Click += new System.EventHandler(this.button_right_name_ASC_Click);
            // 
            // button_right_name_DESC
            // 
            this.button_right_name_DESC.Location = new System.Drawing.Point(0, 60);
            this.button_right_name_DESC.Name = "button_right_name_DESC";
            this.button_right_name_DESC.Size = new System.Drawing.Size(100, 23);
            this.button_right_name_DESC.TabIndex = 15;
            this.button_right_name_DESC.Text = "Name DESC";
            this.button_right_name_DESC.UseVisualStyleBackColor = true;
            this.button_right_name_DESC.Click += new System.EventHandler(this.button_right_name_DESC_Click);
            // 
            // button_right_time_ASC
            // 
            this.button_right_time_ASC.Location = new System.Drawing.Point(0, 80);
            this.button_right_time_ASC.Name = "button_right_time_ASC";
            this.button_right_time_ASC.Size = new System.Drawing.Size(100, 23);
            this.button_right_time_ASC.TabIndex = 16;
            this.button_right_time_ASC.Text = "Date ASC";
            this.button_right_time_ASC.UseVisualStyleBackColor = true;
            this.button_right_time_ASC.Click += new System.EventHandler(this.button_right_time_ASC_Click);
            // 
            // button_right_time_DESC
            // 
            this.button_right_time_DESC.Location = new System.Drawing.Point(0, 100);
            this.button_right_time_DESC.Name = "button_right_time_DESC";
            this.button_right_time_DESC.Size = new System.Drawing.Size(100, 23);
            this.button_right_time_DESC.TabIndex = 17;
            this.button_right_time_DESC.Text = "Date DESC";
            this.button_right_time_DESC.UseVisualStyleBackColor = true;
            this.button_right_time_DESC.Click += new System.EventHandler(this.button_right_time_DESC_Click);
            // 
            // panel_order_left
            // 
            this.panel_order_left.Controls.Add(this.button_left_order_list);
            this.panel_order_left.Controls.Add(this.button_left_default);
            this.panel_order_left.Controls.Add(this.button_left_name_ASC);
            this.panel_order_left.Controls.Add(this.button_left_name_DESC);
            this.panel_order_left.Controls.Add(this.button_left_date_ASC);
            this.panel_order_left.Controls.Add(this.button_left_date_DESC);
            this.panel_order_left.Location = new System.Drawing.Point(512, 17);
            this.panel_order_left.MaximumSize = new System.Drawing.Size(100, 120);
            this.panel_order_left.MinimumSize = new System.Drawing.Size(100, 23);
            this.panel_order_left.Name = "panel_order_left";
            this.panel_order_left.Size = new System.Drawing.Size(100, 23);
            this.panel_order_left.TabIndex = 18;
            // 
            // button_left_order_list
            // 
            this.button_left_order_list.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_left_order_list.Image = global::FolderBrowser.Properties.Resources.expande;
            this.button_left_order_list.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_left_order_list.Location = new System.Drawing.Point(0, 0);
            this.button_left_order_list.Name = "button_left_order_list";
            this.button_left_order_list.Size = new System.Drawing.Size(100, 23);
            this.button_left_order_list.TabIndex = 0;
            this.button_left_order_list.Text = "Default";
            this.button_left_order_list.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_left_order_list.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_left_order_list.UseVisualStyleBackColor = true;
            this.button_left_order_list.Click += new System.EventHandler(this.button_left_order_list_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(455, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Order By:";
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 3000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // panel_order_right
            // 
            this.panel_order_right.Controls.Add(this.button_right_order_list);
            this.panel_order_right.Controls.Add(this.button_right_default);
            this.panel_order_right.Controls.Add(this.button_right_name_ASC);
            this.panel_order_right.Controls.Add(this.button_right_time_DESC);
            this.panel_order_right.Controls.Add(this.button_right_name_DESC);
            this.panel_order_right.Controls.Add(this.button_right_time_ASC);
            this.panel_order_right.Location = new System.Drawing.Point(1132, 17);
            this.panel_order_right.MaximumSize = new System.Drawing.Size(100, 120);
            this.panel_order_right.MinimumSize = new System.Drawing.Size(100, 23);
            this.panel_order_right.Name = "panel_order_right";
            this.panel_order_right.Size = new System.Drawing.Size(100, 23);
            this.panel_order_right.TabIndex = 13;
            // 
            // button_right_order_list
            // 
            this.button_right_order_list.Image = global::FolderBrowser.Properties.Resources.expande;
            this.button_right_order_list.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_right_order_list.Location = new System.Drawing.Point(0, 0);
            this.button_right_order_list.Name = "button_right_order_list";
            this.button_right_order_list.Size = new System.Drawing.Size(100, 23);
            this.button_right_order_list.TabIndex = 14;
            this.button_right_order_list.Text = "Default";
            this.button_right_order_list.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_right_order_list.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_right_order_list.UseVisualStyleBackColor = true;
            this.button_right_order_list.Click += new System.EventHandler(this.button_right_order_list_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1075, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Order By:";
            // 
            // timer3
            // 
            this.timer3.Interval = 15;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // FolderBrowser
            // 
            this.ClientSize = new System.Drawing.Size(1244, 869);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel_order_right);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_order_left);
            this.Controls.Add(this.button_mkdir);
            this.Controls.Add(this.button_remove);
            this.Controls.Add(this.label_dir_right);
            this.Controls.Add(this.label_dir_left);
            this.Controls.Add(this.button_directory_right);
            this.Controls.Add(this.button_directory_left);
            this.Controls.Add(this.dataGridView_right);
            this.Controls.Add(this.dataGridView_left);
            this.Name = "FolderBrowser";
            this.Text = "FolderBrowser";
            this.Load += new System.EventHandler(this.FolderBrowser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_right)).EndInit();
            this.panel_order_left.ResumeLayout(false);
            this.panel_order_right.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView_right;
        private System.Windows.Forms.Button button_directory_left;
        private System.Windows.Forms.Button button_directory_right;
        private System.Windows.Forms.Label label_dir_left;
        private System.Windows.Forms.Label label_dir_right;
        private System.Windows.Forms.DataGridView dataGridView_left;
        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.Button button_mkdir;
        private System.Windows.Forms.Button button_left_name_ASC;
        private System.Windows.Forms.Button button_left_name_DESC;
        private System.Windows.Forms.Button button_left_date_ASC;
        private System.Windows.Forms.Button button_left_date_DESC;
        private System.Windows.Forms.Button button_left_default;
        private System.Windows.Forms.Button button_right_default;
        private System.Windows.Forms.Button button_right_name_ASC;
        private System.Windows.Forms.Button button_right_name_DESC;
        private System.Windows.Forms.Button button_right_time_ASC;
        private System.Windows.Forms.Button button_right_time_DESC;
        private System.Windows.Forms.Panel panel_order_left;
        private System.Windows.Forms.Button button_left_order_list;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel panel_order_right;
        private System.Windows.Forms.Button button_right_order_list;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer3;
    }
}

