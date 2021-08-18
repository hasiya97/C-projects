
namespace Hotel_Reservation_System
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpass = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtfname = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtgender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtlame = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtcno = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtnic = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtuname = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtcpass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtage = new Guna.UI2.WinForms.Guna2TextBox();
            this.Registerbutton = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 1055);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtpass);
            this.panel2.Controls.Add(this.guna2DateTimePicker1);
            this.panel2.Controls.Add(this.txtfname);
            this.panel2.Controls.Add(this.txtgender);
            this.panel2.Controls.Add(this.txtlame);
            this.panel2.Controls.Add(this.txtcno);
            this.panel2.Controls.Add(this.txtnic);
            this.panel2.Controls.Add(this.txtuname);
            this.panel2.Controls.Add(this.txtcpass);
            this.panel2.Controls.Add(this.txtage);
            this.panel2.Controls.Add(this.Registerbutton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(888, 1055);
            this.panel2.TabIndex = 15;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(290, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 38);
            this.label2.TabIndex = 15;
            this.label2.Text = "REGISTER";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtpass
            // 
            this.txtpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpass.DefaultText = "";
            this.txtpass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtpass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtpass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpass.DisabledState.Parent = this.txtpass;
            this.txtpass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpass.FocusedState.Parent = this.txtpass;
            this.txtpass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpass.HoverState.Parent = this.txtpass;
            this.txtpass.Location = new System.Drawing.Point(149, 493);
            this.txtpass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.PlaceholderText = "Password";
            this.txtpass.SelectedText = "";
            this.txtpass.ShadowDecoration.Parent = this.txtpass;
            this.txtpass.Size = new System.Drawing.Size(525, 60);
            this.txtpass.TabIndex = 7;
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.CheckedState.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker1.HoverState.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(149, 645);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.ShadowDecoration.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(525, 53);
            this.guna2DateTimePicker1.TabIndex = 14;
            this.guna2DateTimePicker1.Value = new System.DateTime(2021, 8, 10, 15, 40, 26, 135);
            // 
            // txtfname
            // 
            this.txtfname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtfname.DefaultText = "";
            this.txtfname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtfname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtfname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtfname.DisabledState.Parent = this.txtfname;
            this.txtfname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtfname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtfname.FocusedState.Parent = this.txtfname;
            this.txtfname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtfname.HoverState.Parent = this.txtfname;
            this.txtfname.Location = new System.Drawing.Point(149, 144);
            this.txtfname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtfname.Name = "txtfname";
            this.txtfname.PasswordChar = '\0';
            this.txtfname.PlaceholderText = "FirstName";
            this.txtfname.SelectedText = "";
            this.txtfname.ShadowDecoration.Parent = this.txtfname;
            this.txtfname.Size = new System.Drawing.Size(525, 66);
            this.txtfname.TabIndex = 0;
            // 
            // txtgender
            // 
            this.txtgender.BackColor = System.Drawing.Color.Transparent;
            this.txtgender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtgender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtgender.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtgender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtgender.FocusedState.Parent = this.txtgender;
            this.txtgender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtgender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtgender.HoverState.Parent = this.txtgender;
            this.txtgender.ItemHeight = 30;
            this.txtgender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.txtgender.ItemsAppearance.Parent = this.txtgender;
            this.txtgender.Location = new System.Drawing.Point(149, 374);
            this.txtgender.Name = "txtgender";
            this.txtgender.ShadowDecoration.Parent = this.txtgender;
            this.txtgender.Size = new System.Drawing.Size(525, 36);
            this.txtgender.TabIndex = 13;
            // 
            // txtlame
            // 
            this.txtlame.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtlame.DefaultText = "";
            this.txtlame.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtlame.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtlame.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtlame.DisabledState.Parent = this.txtlame;
            this.txtlame.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtlame.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtlame.FocusedState.Parent = this.txtlame;
            this.txtlame.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtlame.HoverState.Parent = this.txtlame;
            this.txtlame.Location = new System.Drawing.Point(149, 224);
            this.txtlame.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtlame.Name = "txtlame";
            this.txtlame.PasswordChar = '\0';
            this.txtlame.PlaceholderText = "LastName";
            this.txtlame.SelectedText = "";
            this.txtlame.ShadowDecoration.Parent = this.txtlame;
            this.txtlame.Size = new System.Drawing.Size(525, 70);
            this.txtlame.TabIndex = 1;
            // 
            // txtcno
            // 
            this.txtcno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcno.DefaultText = "";
            this.txtcno.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtcno.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtcno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcno.DisabledState.Parent = this.txtcno;
            this.txtcno.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcno.FocusedState.Parent = this.txtcno;
            this.txtcno.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcno.HoverState.Parent = this.txtcno;
            this.txtcno.Location = new System.Drawing.Point(149, 305);
            this.txtcno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcno.Name = "txtcno";
            this.txtcno.PasswordChar = '\0';
            this.txtcno.PlaceholderText = "Contact Number";
            this.txtcno.SelectedText = "";
            this.txtcno.ShadowDecoration.Parent = this.txtcno;
            this.txtcno.Size = new System.Drawing.Size(525, 60);
            this.txtcno.TabIndex = 12;
            // 
            // txtnic
            // 
            this.txtnic.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnic.DefaultText = "";
            this.txtnic.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtnic.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtnic.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnic.DisabledState.Parent = this.txtnic;
            this.txtnic.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnic.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnic.FocusedState.Parent = this.txtnic;
            this.txtnic.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnic.HoverState.Parent = this.txtnic;
            this.txtnic.Location = new System.Drawing.Point(149, 68);
            this.txtnic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnic.Name = "txtnic";
            this.txtnic.PasswordChar = '\0';
            this.txtnic.PlaceholderText = "NIC";
            this.txtnic.SelectedText = "";
            this.txtnic.ShadowDecoration.Parent = this.txtnic;
            this.txtnic.Size = new System.Drawing.Size(525, 66);
            this.txtnic.TabIndex = 2;
            // 
            // txtuname
            // 
            this.txtuname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtuname.DefaultText = "";
            this.txtuname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtuname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtuname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtuname.DisabledState.Parent = this.txtuname;
            this.txtuname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtuname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtuname.FocusedState.Parent = this.txtuname;
            this.txtuname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtuname.HoverState.Parent = this.txtuname;
            this.txtuname.Location = new System.Drawing.Point(149, 424);
            this.txtuname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtuname.Name = "txtuname";
            this.txtuname.PasswordChar = '\0';
            this.txtuname.PlaceholderText = "Username";
            this.txtuname.SelectedText = "";
            this.txtuname.ShadowDecoration.Parent = this.txtuname;
            this.txtuname.Size = new System.Drawing.Size(525, 57);
            this.txtuname.TabIndex = 5;
            // 
            // txtcpass
            // 
            this.txtcpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcpass.DefaultText = "";
            this.txtcpass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtcpass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtcpass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcpass.DisabledState.Parent = this.txtcpass;
            this.txtcpass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcpass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcpass.FocusedState.Parent = this.txtcpass;
            this.txtcpass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcpass.HoverState.Parent = this.txtcpass;
            this.txtcpass.Location = new System.Drawing.Point(149, 569);
            this.txtcpass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcpass.Name = "txtcpass";
            this.txtcpass.PasswordChar = '*';
            this.txtcpass.PlaceholderText = "Confirm Password";
            this.txtcpass.SelectedText = "";
            this.txtcpass.ShadowDecoration.Parent = this.txtcpass;
            this.txtcpass.Size = new System.Drawing.Size(525, 61);
            this.txtcpass.TabIndex = 10;
            // 
            // txtage
            // 
            this.txtage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtage.DefaultText = "";
            this.txtage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtage.DisabledState.Parent = this.txtage;
            this.txtage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtage.FocusedState.Parent = this.txtage;
            this.txtage.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtage.HoverState.Parent = this.txtage;
            this.txtage.Location = new System.Drawing.Point(149, 716);
            this.txtage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtage.Name = "txtage";
            this.txtage.PasswordChar = '\0';
            this.txtage.PlaceholderText = "Age";
            this.txtage.SelectedText = "";
            this.txtage.ShadowDecoration.Parent = this.txtage;
            this.txtage.Size = new System.Drawing.Size(525, 69);
            this.txtage.TabIndex = 8;
            // 
            // Registerbutton
            // 
            this.Registerbutton.CheckedState.Parent = this.Registerbutton;
            this.Registerbutton.CustomImages.Parent = this.Registerbutton;
            this.Registerbutton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Registerbutton.ForeColor = System.Drawing.Color.White;
            this.Registerbutton.HoverState.Parent = this.Registerbutton;
            this.Registerbutton.Location = new System.Drawing.Point(211, 816);
            this.Registerbutton.Name = "Registerbutton";
            this.Registerbutton.ShadowDecoration.Parent = this.Registerbutton;
            this.Registerbutton.Size = new System.Drawing.Size(390, 100);
            this.Registerbutton.TabIndex = 9;
            this.Registerbutton.Text = "Register";
            this.Registerbutton.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(488, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 40);
            this.label1.TabIndex = 11;
            this.label1.Text = "Register";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(888, 1055);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtnic;
        private Guna.UI2.WinForms.Guna2TextBox txtlame;
        private Guna.UI2.WinForms.Guna2TextBox txtfname;
        private Guna.UI2.WinForms.Guna2TextBox txtuname;
        private Guna.UI2.WinForms.Guna2TextBox txtpass;
        private Guna.UI2.WinForms.Guna2Button Registerbutton;
        private Guna.UI2.WinForms.Guna2TextBox txtage;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtcpass;
        private Guna.UI2.WinForms.Guna2TextBox txtcno;
        private Guna.UI2.WinForms.Guna2ComboBox txtgender;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
    }
}