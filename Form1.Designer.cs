
namespace Gallery
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderName = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderDateEdit = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderType = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderSize = new System.Windows.Forms.ColumnHeader();
            this.PatchTextBox = new System.Windows.Forms.TextBox();
            this.buttonForward = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.btnFocus = new System.Windows.Forms.Button();
            this.buttonCreateFolder = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonCutOut = new System.Windows.Forms.Button();
            this.buttomPaste = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonCopyPath = new System.Windows.Forms.Button();
            this.buttonRename = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.Location = new System.Drawing.Point(12, 126);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(181, 432);
            this.treeView1.TabIndex = 0;
            this.treeView1.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeExpand);
            this.treeView1.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeSelect);
            this.treeView1.Click += new System.EventHandler(this.treeView1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "png-transparent-computer-icons-directory-folders-miscellaneous-angle-rectangle.pn" +
        "g");
            this.imageList1.Images.SetKeyName(1, "390901.png");
            this.imageList1.Images.SetKeyName(2, "icons8-папка-фотографий-48.png");
            this.imageList1.Images.SetKeyName(3, "icons8-музыка-16.png");
            this.imageList1.Images.SetKeyName(4, "icons8-документы-48.png");
            this.imageList1.Images.SetKeyName(5, "icons8-монитор-30.png");
            this.imageList1.Images.SetKeyName(6, "");
            // 
            // listView1
            // 
            this.listView1.AllowDrop = true;
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderDateEdit,
            this.columnHeaderType,
            this.columnHeaderSize});
            this.listView1.HideSelection = false;
            this.listView1.LabelEdit = true;
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(222, 126);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(773, 432);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.listView1_AfterLabelEdit);
            this.listView1.BeforeLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.listView1_BeforeLabelEdit);
            this.listView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listView1_DragDrop);
            this.listView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listView1_DragEnter);
            this.listView1.DragOver += new System.Windows.Forms.DragEventHandler(this.listView1_DragOver);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            this.listView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDown);
            this.listView1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseMove);
            this.listView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseUp);
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Имя";
            this.columnHeaderName.Width = 250;
            // 
            // columnHeaderDateEdit
            // 
            this.columnHeaderDateEdit.Text = "Дата изменения";
            this.columnHeaderDateEdit.Width = 250;
            // 
            // columnHeaderType
            // 
            this.columnHeaderType.Text = "Тип";
            this.columnHeaderType.Width = 80;
            // 
            // columnHeaderSize
            // 
            this.columnHeaderSize.Text = "Размер";
            this.columnHeaderSize.Width = 100;
            // 
            // PatchTextBox
            // 
            this.PatchTextBox.Location = new System.Drawing.Point(222, 93);
            this.PatchTextBox.Name = "PatchTextBox";
            this.PatchTextBox.Size = new System.Drawing.Size(611, 27);
            this.PatchTextBox.TabIndex = 2;
            this.PatchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PatchTextBox_KeyPress);
            // 
            // buttonForward
            // 
            this.buttonForward.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonForward.BackColor = System.Drawing.Color.Transparent;
            this.buttonForward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonForward.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonForward.FlatAppearance.BorderSize = 0;
            this.buttonForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonForward.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonForward.Location = new System.Drawing.Point(96, 54);
            this.buttonForward.Name = "buttonForward";
            this.buttonForward.Size = new System.Drawing.Size(47, 56);
            this.buttonForward.TabIndex = 3;
            this.buttonForward.Text = "🡆";
            this.buttonForward.UseVisualStyleBackColor = false;
            this.buttonForward.Click += new System.EventHandler(this.buttonForward_Click);
            this.buttonForward.MouseEnter += new System.EventHandler(this.buttonForward_MouseEnter);
            this.buttonForward.MouseLeave += new System.EventHandler(this.buttonForward_MouseLeave);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Transparent;
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Location = new System.Drawing.Point(43, 54);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(47, 57);
            this.buttonBack.TabIndex = 4;
            this.buttonBack.Text = "🡄";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            this.buttonBack.MouseEnter += new System.EventHandler(this.buttonBack_MouseEnter);
            this.buttonBack.MouseLeave += new System.EventHandler(this.buttonBack_MouseLeave);
            // 
            // btnFocus
            // 
            this.btnFocus.Location = new System.Drawing.Point(987, 13);
            this.btnFocus.Name = "btnFocus";
            this.btnFocus.Size = new System.Drawing.Size(0, 0);
            this.btnFocus.TabIndex = 5;
            this.btnFocus.Text = "button1";
            this.btnFocus.UseVisualStyleBackColor = true;
            // 
            // buttonCreateFolder
            // 
            this.buttonCreateFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCreateFolder.Location = new System.Drawing.Point(844, 11);
            this.buttonCreateFolder.Name = "buttonCreateFolder";
            this.buttonCreateFolder.Size = new System.Drawing.Size(72, 60);
            this.buttonCreateFolder.TabIndex = 6;
            this.buttonCreateFolder.Text = "Создать папку";
            this.buttonCreateFolder.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCreateFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonCreateFolder.UseVisualStyleBackColor = true;
            this.buttonCreateFolder.Click += new System.EventHandler(this.buttonCreateFolder_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(745, 13);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(72, 60);
            this.buttonRemove.TabIndex = 7;
            this.buttonRemove.Text = "Удалить";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonCutOut
            // 
            this.buttonCutOut.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCutOut.Location = new System.Drawing.Point(528, 11);
            this.buttonCutOut.Name = "buttonCutOut";
            this.buttonCutOut.Size = new System.Drawing.Size(77, 60);
            this.buttonCutOut.TabIndex = 8;
            this.buttonCutOut.Text = "Вырезать";
            this.buttonCutOut.UseVisualStyleBackColor = true;
            this.buttonCutOut.Click += new System.EventHandler(this.buttonCutOut_Click);
            // 
            // buttomPaste
            // 
            this.buttomPaste.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttomPaste.Location = new System.Drawing.Point(222, 11);
            this.buttomPaste.Name = "buttomPaste";
            this.buttomPaste.Size = new System.Drawing.Size(76, 60);
            this.buttomPaste.TabIndex = 9;
            this.buttomPaste.Text = "Вставить";
            this.buttomPaste.UseVisualStyleBackColor = true;
            this.buttomPaste.Click += new System.EventHandler(this.buttomPaste_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCopy.Location = new System.Drawing.Point(323, 11);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(82, 60);
            this.buttonCopy.TabIndex = 10;
            this.buttonCopy.Text = "Копировать";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // buttonCopyPath
            // 
            this.buttonCopyPath.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCopyPath.Location = new System.Drawing.Point(430, 11);
            this.buttonCopyPath.Name = "buttonCopyPath";
            this.buttonCopyPath.Size = new System.Drawing.Size(77, 60);
            this.buttonCopyPath.TabIndex = 11;
            this.buttonCopyPath.Text = "Копировать путь";
            this.buttonCopyPath.UseVisualStyleBackColor = true;
            this.buttonCopyPath.Click += new System.EventHandler(this.buttonCopyPath_Click);
            // 
            // buttonRename
            // 
            this.buttonRename.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRename.Location = new System.Drawing.Point(624, 13);
            this.buttonRename.Name = "buttonRename";
            this.buttonRename.Size = new System.Drawing.Size(94, 58);
            this.buttonRename.TabIndex = 12;
            this.buttonRename.Text = "Переименовать";
            this.buttonRename.UseVisualStyleBackColor = true;
            this.buttonRename.Click += new System.EventHandler(this.buttonRename_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(844, 92);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.Enter += new System.EventHandler(this.comboBox1_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 570);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonRename);
            this.Controls.Add(this.buttonCopyPath);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.buttomPaste);
            this.Controls.Add(this.buttonCutOut);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonCreateFolder);
            this.Controls.Add(this.btnFocus);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonForward);
            this.Controls.Add(this.PatchTextBox);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderDateEdit;
        private System.Windows.Forms.ColumnHeader columnHeaderType;
        private System.Windows.Forms.ColumnHeader columnHeaderSize;
        private System.Windows.Forms.TextBox PatchTextBox;
        private System.Windows.Forms.Button buttonForward;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button btnFocus;
        private System.Windows.Forms.Button buttonCreateFolder;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonCutOut;
        private System.Windows.Forms.Button buttomPaste;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonCopyPath;
        private System.Windows.Forms.Button buttonRename;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

