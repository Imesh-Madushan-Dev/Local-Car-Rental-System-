namespace FInal_Project
{
    partial class Dashboard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnreservations = new Guna.UI2.WinForms.Guna2Button();
            this.btnvehicles = new Guna.UI2.WinForms.Guna2Button();
            this.btncustomers = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.uCreservation1 = new FInal_Project.UCreservation();
            this.uCvehicles1 = new FInal_Project.UCvehicles();
            this.uCcustomers1 = new FInal_Project.UCcustomers();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(178)))));
            this.guna2Panel2.Controls.Add(this.pictureBox1);
            this.guna2Panel2.Controls.Add(this.btnreservations);
            this.guna2Panel2.Controls.Add(this.btnvehicles);
            this.guna2Panel2.Controls.Add(this.btncustomers);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(1421, 156);
            this.guna2Panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, -16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 201);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnreservations
            // 
            this.btnreservations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(178)))));
            this.btnreservations.BorderColor = System.Drawing.Color.White;
            this.btnreservations.BorderRadius = 10;
            this.btnreservations.BorderThickness = 2;
            this.btnreservations.CheckedState.Parent = this.btnreservations;
            this.btnreservations.CustomImages.Parent = this.btnreservations;
            this.btnreservations.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(178)))));
            this.btnreservations.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreservations.ForeColor = System.Drawing.Color.White;
            this.btnreservations.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(88)))), ((int)(((byte)(247)))));
            this.btnreservations.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnreservations.HoverState.Parent = this.btnreservations;
            this.btnreservations.Image = ((System.Drawing.Image)(resources.GetObject("btnreservations.Image")));
            this.btnreservations.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnreservations.ImageOffset = new System.Drawing.Point(17, 0);
            this.btnreservations.ImageSize = new System.Drawing.Size(25, 25);
            this.btnreservations.Location = new System.Drawing.Point(1114, 67);
            this.btnreservations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnreservations.Name = "btnreservations";
            this.btnreservations.ShadowDecoration.Parent = this.btnreservations;
            this.btnreservations.Size = new System.Drawing.Size(259, 62);
            this.btnreservations.TabIndex = 3;
            this.btnreservations.Text = "Reservations";
            this.btnreservations.TextOffset = new System.Drawing.Point(15, 0);
            this.btnreservations.Click += new System.EventHandler(this.btnreservations_Click);
            // 
            // btnvehicles
            // 
            this.btnvehicles.BorderColor = System.Drawing.Color.White;
            this.btnvehicles.BorderRadius = 10;
            this.btnvehicles.BorderThickness = 2;
            this.btnvehicles.CheckedState.Parent = this.btnvehicles;
            this.btnvehicles.CustomImages.Parent = this.btnvehicles;
            this.btnvehicles.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(178)))));
            this.btnvehicles.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvehicles.ForeColor = System.Drawing.Color.White;
            this.btnvehicles.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(88)))), ((int)(((byte)(247)))));
            this.btnvehicles.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnvehicles.HoverState.Parent = this.btnvehicles;
            this.btnvehicles.Image = ((System.Drawing.Image)(resources.GetObject("btnvehicles.Image")));
            this.btnvehicles.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnvehicles.ImageOffset = new System.Drawing.Point(17, 0);
            this.btnvehicles.ImageSize = new System.Drawing.Size(25, 25);
            this.btnvehicles.Location = new System.Drawing.Point(528, 67);
            this.btnvehicles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnvehicles.Name = "btnvehicles";
            this.btnvehicles.ShadowDecoration.Parent = this.btnvehicles;
            this.btnvehicles.Size = new System.Drawing.Size(259, 62);
            this.btnvehicles.TabIndex = 5;
            this.btnvehicles.Text = "Vehicles";
            this.btnvehicles.TextOffset = new System.Drawing.Point(15, 0);
            this.btnvehicles.Click += new System.EventHandler(this.btnvehicles_Click);
            // 
            // btncustomers
            // 
            this.btncustomers.BorderColor = System.Drawing.Color.White;
            this.btncustomers.BorderRadius = 10;
            this.btncustomers.BorderThickness = 2;
            this.btncustomers.CheckedState.Parent = this.btncustomers;
            this.btncustomers.CustomImages.Parent = this.btncustomers;
            this.btncustomers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(178)))));
            this.btncustomers.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncustomers.ForeColor = System.Drawing.Color.White;
            this.btncustomers.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(88)))), ((int)(((byte)(247)))));
            this.btncustomers.HoverState.ForeColor = System.Drawing.Color.White;
            this.btncustomers.HoverState.Parent = this.btncustomers;
            this.btncustomers.Image = ((System.Drawing.Image)(resources.GetObject("btncustomers.Image")));
            this.btncustomers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btncustomers.ImageOffset = new System.Drawing.Point(17, 0);
            this.btncustomers.ImageSize = new System.Drawing.Size(25, 25);
            this.btncustomers.Location = new System.Drawing.Point(824, 67);
            this.btncustomers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncustomers.Name = "btncustomers";
            this.btncustomers.ShadowDecoration.Parent = this.btncustomers;
            this.btncustomers.Size = new System.Drawing.Size(259, 62);
            this.btncustomers.TabIndex = 4;
            this.btncustomers.Text = "Customers";
            this.btncustomers.TextOffset = new System.Drawing.Point(15, 0);
            this.btncustomers.Click += new System.EventHandler(this.btncustomers_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = null;
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(178)))));
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.HoverState.Parent = this.guna2ControlBox3;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.Location = new System.Drawing.Point(1262, 11);
            this.guna2ControlBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.ShadowDecoration.Parent = this.guna2ControlBox3;
            this.guna2ControlBox3.Size = new System.Drawing.Size(45, 30);
            this.guna2ControlBox3.TabIndex = 5;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(178)))));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1313, 11);
            this.guna2ControlBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 30);
            this.guna2ControlBox2.TabIndex = 4;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(178)))));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1365, 11);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 30);
            this.guna2ControlBox1.TabIndex = 3;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.uCreservation1);
            this.guna2Panel1.Controls.Add(this.uCvehicles1);
            this.guna2Panel1.Controls.Add(this.uCcustomers1);
            this.guna2Panel1.Controls.Add(this.pictureBox2);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 155);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1421, 794);
            this.guna2Panel1.TabIndex = 6;
            // 
            // uCreservation1
            // 
            this.uCreservation1.Location = new System.Drawing.Point(0, 0);
            this.uCreservation1.Name = "uCreservation1";
            this.uCreservation1.Size = new System.Drawing.Size(1421, 799);
            this.uCreservation1.TabIndex = 3;
            // 
            // uCvehicles1
            // 
            this.uCvehicles1.BackColor = System.Drawing.SystemColors.Control;
            this.uCvehicles1.Location = new System.Drawing.Point(0, 0);
            this.uCvehicles1.Name = "uCvehicles1";
            this.uCvehicles1.Size = new System.Drawing.Size(1421, 799);
            this.uCvehicles1.TabIndex = 2;
            // 
            // uCcustomers1
            // 
            this.uCcustomers1.Location = new System.Drawing.Point(0, 0);
            this.uCcustomers1.Name = "uCcustomers1";
            this.uCcustomers1.Size = new System.Drawing.Size(1421, 799);
            this.uCcustomers1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(299, 141);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(806, 482);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1421, 956);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2ControlBox3);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.guna2Panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "          ";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnreservations;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Button btncustomers;
        private Guna.UI2.WinForms.Guna2Button btnvehicles;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private UCreservation uCreservation1;
        private UCvehicles uCvehicles1;
        private UCcustomers uCcustomers1;
    }
}

