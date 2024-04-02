namespace FInal_Project
{
    partial class UCcustomers
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btndlt = new Guna.UI2.WinForms.Guna2Button();
            this.btnupdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnadd = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtcontact = new Guna.UI.WinForms.GunaTextBox();
            this.txtaddress = new Guna.UI.WinForms.GunaTextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtsearch = new Guna.UI.WinForms.GunaTextBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvcustomers = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtname = new Guna.UI.WinForms.GunaTextBox();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtnic = new Guna.UI.WinForms.GunaTextBox();
            this.guna2HtmlLabel10 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcustomers)).BeginInit();
            this.guna2GroupBox2.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btndlt
            // 
            this.btndlt.BorderRadius = 15;
            this.btndlt.CheckedState.Parent = this.btndlt;
            this.btndlt.CustomImages.Parent = this.btndlt;
            this.btndlt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(93)))), ((int)(((byte)(211)))));
            this.btndlt.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndlt.ForeColor = System.Drawing.Color.White;
            this.btndlt.HoverState.FillColor = System.Drawing.Color.Red;
            this.btndlt.HoverState.Parent = this.btndlt;
            this.btndlt.Location = new System.Drawing.Point(182, 655);
            this.btndlt.Margin = new System.Windows.Forms.Padding(4);
            this.btndlt.Name = "btndlt";
            this.btndlt.ShadowDecoration.Parent = this.btndlt;
            this.btndlt.Size = new System.Drawing.Size(164, 55);
            this.btndlt.TabIndex = 61;
            this.btndlt.Text = "Delete";
            this.btndlt.Click += new System.EventHandler(this.btndlt_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BorderRadius = 15;
            this.btnupdate.CheckedState.Parent = this.btnupdate;
            this.btnupdate.CustomImages.Parent = this.btnupdate;
            this.btnupdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(93)))), ((int)(((byte)(211)))));
            this.btnupdate.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.HoverState.FillColor = System.Drawing.Color.Lime;
            this.btnupdate.HoverState.Parent = this.btnupdate;
            this.btnupdate.Location = new System.Drawing.Point(284, 575);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.ShadowDecoration.Parent = this.btnupdate;
            this.btnupdate.Size = new System.Drawing.Size(164, 55);
            this.btnupdate.TabIndex = 60;
            this.btnupdate.Text = "Update";
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnadd
            // 
            this.btnadd.BorderRadius = 15;
            this.btnadd.CheckedState.Parent = this.btnadd;
            this.btnadd.CustomImages.Parent = this.btnadd;
            this.btnadd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(93)))), ((int)(((byte)(211)))));
            this.btnadd.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.HoverState.Parent = this.btnadd;
            this.btnadd.Location = new System.Drawing.Point(89, 577);
            this.btnadd.Margin = new System.Windows.Forms.Padding(4);
            this.btnadd.Name = "btnadd";
            this.btnadd.ShadowDecoration.Parent = this.btnadd;
            this.btnadd.Size = new System.Drawing.Size(166, 53);
            this.btnadd.TabIndex = 59;
            this.btnadd.Text = "Add";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(38)))), ((int)(((byte)(237)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(143, 18);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(278, 34);
            this.guna2HtmlLabel2.TabIndex = 58;
            this.guna2HtmlLabel2.Text = "Customer Registration";
            // 
            // txtcontact
            // 
            this.txtcontact.BackColor = System.Drawing.Color.Transparent;
            this.txtcontact.BaseColor = System.Drawing.Color.White;
            this.txtcontact.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(140)))), ((int)(((byte)(253)))));
            this.txtcontact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcontact.FocusedBaseColor = System.Drawing.Color.White;
            this.txtcontact.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(140)))), ((int)(((byte)(253)))));
            this.txtcontact.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtcontact.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontact.Location = new System.Drawing.Point(88, 451);
            this.txtcontact.Margin = new System.Windows.Forms.Padding(4);
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.PasswordChar = '\0';
            this.txtcontact.Radius = 10;
            this.txtcontact.SelectedText = "";
            this.txtcontact.Size = new System.Drawing.Size(360, 80);
            this.txtcontact.TabIndex = 57;
            // 
            // txtaddress
            // 
            this.txtaddress.BackColor = System.Drawing.Color.Transparent;
            this.txtaddress.BaseColor = System.Drawing.Color.White;
            this.txtaddress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(140)))), ((int)(((byte)(253)))));
            this.txtaddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtaddress.FocusedBaseColor = System.Drawing.Color.White;
            this.txtaddress.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(140)))), ((int)(((byte)(253)))));
            this.txtaddress.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtaddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress.Location = new System.Drawing.Point(89, 312);
            this.txtaddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.PasswordChar = '\0';
            this.txtaddress.Radius = 10;
            this.txtaddress.SelectedText = "";
            this.txtaddress.Size = new System.Drawing.Size(360, 92);
            this.txtaddress.TabIndex = 55;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(89, 278);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(79, 27);
            this.guna2HtmlLabel1.TabIndex = 54;
            this.guna2HtmlLabel1.Text = "Address :";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(88, 416);
            this.guna2HtmlLabel6.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(77, 27);
            this.guna2HtmlLabel6.TabIndex = 53;
            this.guna2HtmlLabel6.Text = "Contact :";
            // 
            // txtsearch
            // 
            this.txtsearch.BackColor = System.Drawing.Color.Transparent;
            this.txtsearch.BaseColor = System.Drawing.Color.White;
            this.txtsearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(140)))), ((int)(((byte)(253)))));
            this.txtsearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsearch.FocusedBaseColor = System.Drawing.Color.White;
            this.txtsearch.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(140)))), ((int)(((byte)(253)))));
            this.txtsearch.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtsearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(109, 125);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.PasswordChar = '\0';
            this.txtsearch.Radius = 10;
            this.txtsearch.SelectedText = "";
            this.txtsearch.Size = new System.Drawing.Size(282, 44);
            this.txtsearch.TabIndex = 62;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(32, 129);
            this.guna2HtmlLabel4.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(69, 27);
            this.guna2HtmlLabel4.TabIndex = 62;
            this.guna2HtmlLabel4.Text = "Search :";
            // 
            // dgvcustomers
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.dgvcustomers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvcustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvcustomers.BackgroundColor = System.Drawing.Color.White;
            this.dgvcustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvcustomers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvcustomers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvcustomers.ColumnHeadersHeight = 50;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(13)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvcustomers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvcustomers.EnableHeadersVisualStyles = false;
            this.dgvcustomers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dgvcustomers.Location = new System.Drawing.Point(32, 222);
            this.dgvcustomers.Name = "dgvcustomers";
            this.dgvcustomers.RowHeadersVisible = false;
            this.dgvcustomers.RowHeadersWidth = 51;
            this.dgvcustomers.RowTemplate.Height = 24;
            this.dgvcustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvcustomers.Size = new System.Drawing.Size(729, 470);
            this.dgvcustomers.TabIndex = 59;
            this.dgvcustomers.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue;
            this.dgvcustomers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.dgvcustomers.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvcustomers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvcustomers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvcustomers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvcustomers.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvcustomers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dgvcustomers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.dgvcustomers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvcustomers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvcustomers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvcustomers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvcustomers.ThemeStyle.HeaderStyle.Height = 50;
            this.dgvcustomers.ThemeStyle.ReadOnly = false;
            this.dgvcustomers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.dgvcustomers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvcustomers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvcustomers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(13)))), ((int)(((byte)(187)))));
            this.dgvcustomers.ThemeStyle.RowsStyle.Height = 24;
            this.dgvcustomers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            this.dgvcustomers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(6)))), ((int)(((byte)(38)))));
            this.guna2GroupBox2.BorderRadius = 15;
            this.guna2GroupBox2.BorderThickness = 2;
            this.guna2GroupBox2.Controls.Add(this.txtsearch);
            this.guna2GroupBox2.Controls.Add(this.guna2HtmlLabel4);
            this.guna2GroupBox2.Controls.Add(this.dgvcustomers);
            this.guna2GroupBox2.Controls.Add(this.guna2HtmlLabel3);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.White;
            this.guna2GroupBox2.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.guna2GroupBox2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(13)))), ((int)(((byte)(187)))));
            this.guna2GroupBox2.Location = new System.Drawing.Point(604, 51);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.ShadowDecoration.Parent = this.guna2GroupBox2;
            this.guna2GroupBox2.Size = new System.Drawing.Size(792, 728);
            this.guna2GroupBox2.TabIndex = 64;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(38)))), ((int)(((byte)(237)))));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(270, 18);
            this.guna2HtmlLabel3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(259, 34);
            this.guna2HtmlLabel3.TabIndex = 58;
            this.guna2HtmlLabel3.Text = "Registred Customers";
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.Color.Transparent;
            this.txtname.BaseColor = System.Drawing.Color.White;
            this.txtname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(140)))), ((int)(((byte)(253)))));
            this.txtname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtname.FocusedBaseColor = System.Drawing.Color.White;
            this.txtname.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(140)))), ((int)(((byte)(253)))));
            this.txtname.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(88, 222);
            this.txtname.Margin = new System.Windows.Forms.Padding(4);
            this.txtname.Name = "txtname";
            this.txtname.PasswordChar = '\0';
            this.txtname.Radius = 10;
            this.txtname.SelectedText = "";
            this.txtname.Size = new System.Drawing.Size(360, 44);
            this.txtname.TabIndex = 49;
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(88, 188);
            this.guna2HtmlLabel9.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(62, 27);
            this.guna2HtmlLabel9.TabIndex = 48;
            this.guna2HtmlLabel9.Text = "Name :";
            // 
            // txtnic
            // 
            this.txtnic.BackColor = System.Drawing.Color.Transparent;
            this.txtnic.BaseColor = System.Drawing.Color.White;
            this.txtnic.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(140)))), ((int)(((byte)(253)))));
            this.txtnic.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnic.FocusedBaseColor = System.Drawing.Color.White;
            this.txtnic.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(140)))), ((int)(((byte)(253)))));
            this.txtnic.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtnic.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnic.Location = new System.Drawing.Point(88, 129);
            this.txtnic.Margin = new System.Windows.Forms.Padding(4);
            this.txtnic.Name = "txtnic";
            this.txtnic.PasswordChar = '\0';
            this.txtnic.Radius = 10;
            this.txtnic.SelectedText = "";
            this.txtnic.Size = new System.Drawing.Size(360, 44);
            this.txtnic.TabIndex = 47;
            // 
            // guna2HtmlLabel10
            // 
            this.guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2HtmlLabel10.Location = new System.Drawing.Point(88, 94);
            this.guna2HtmlLabel10.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel10.Name = "guna2HtmlLabel10";
            this.guna2HtmlLabel10.Size = new System.Drawing.Size(129, 27);
            this.guna2HtmlLabel10.TabIndex = 46;
            this.guna2HtmlLabel10.Text = "Customer NIC :";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(6)))), ((int)(((byte)(38)))));
            this.guna2GroupBox1.BorderRadius = 15;
            this.guna2GroupBox1.BorderThickness = 2;
            this.guna2GroupBox1.Controls.Add(this.btndlt);
            this.guna2GroupBox1.Controls.Add(this.btnupdate);
            this.guna2GroupBox1.Controls.Add(this.btnadd);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2GroupBox1.Controls.Add(this.txtcontact);
            this.guna2GroupBox1.Controls.Add(this.txtaddress);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel6);
            this.guna2GroupBox1.Controls.Add(this.txtname);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel9);
            this.guna2GroupBox1.Controls.Add(this.txtnic);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel10);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.White;
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(13)))), ((int)(((byte)(187)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(45, 51);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(529, 728);
            this.guna2GroupBox1.TabIndex = 63;
            // 
            // UCcustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.guna2GroupBox1);
            this.Name = "UCcustomers";
            this.Size = new System.Drawing.Size(1421, 799);
            this.Load += new System.EventHandler(this.UCcustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcustomers)).EndInit();
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btndlt;
        private Guna.UI2.WinForms.Guna2Button btnupdate;
        private Guna.UI2.WinForms.Guna2Button btnadd;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI.WinForms.GunaTextBox txtcontact;
        private Guna.UI.WinForms.GunaTextBox txtaddress;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI.WinForms.GunaTextBox txtsearch;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2DataGridView dgvcustomers;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI.WinForms.GunaTextBox txtname;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Guna.UI.WinForms.GunaTextBox txtnic;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel10;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
    }
}
