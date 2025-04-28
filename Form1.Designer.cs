namespace Codeco9
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtPassword = new TextBox();
            txtLogin = new TextBox();
            btnSave = new Button();
            btnRetrieve = new Button();
            lstPasswords = new ListBox();
            label1 = new Label();
            label2 = new Label();
            txtWebsite = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtNotes = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            button19 = new Button();
            button20 = new Button();
            button21 = new Button();
            button22 = new Button();
            button23 = new Button();
            button24 = new Button();
            button25 = new Button();
            button26 = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            lstPasswords2 = new ListBox();
            btnNew = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            tabPage3 = new TabPage();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            button30 = new Button();
            btnViewKey = new Button();
            label5 = new Label();
            txtSecretKey = new TextBox();
            btnCopyKey = new Button();
            tabPage2 = new TabPage();
            tabPage4 = new TabPage();
            linkLabel4 = new LinkLabel();
            label13 = new Label();
            linkLabel3 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            linkLabel1 = new LinkLabel();
            label9 = new Label();
            pictureBox1 = new PictureBox();
            imageList1 = new ImageList(components);
            button27 = new Button();
            txtSearchFor = new TextBox();
            btnSearch = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.Gainsboro;
            txtPassword.ForeColor = Color.FromArgb(64, 64, 64);
            txtPassword.Location = new Point(10, 173);
            txtPassword.MaxLength = 99;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(163, 23);
            txtPassword.TabIndex = 3;
            // 
            // txtLogin
            // 
            txtLogin.BackColor = Color.Gainsboro;
            txtLogin.ForeColor = Color.FromArgb(64, 64, 64);
            txtLogin.Location = new Point(10, 125);
            txtLogin.MaxLength = 99;
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(163, 23);
            txtLogin.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Gray;
            btnSave.Cursor = Cursors.Hand;
            btnSave.Enabled = false;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.ForeColor = SystemColors.ControlLight;
            btnSave.Location = new Point(10, 293);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(163, 23);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click_1;
            // 
            // btnRetrieve
            // 
            btnRetrieve.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnRetrieve.Location = new Point(150, 476);
            btnRetrieve.Name = "btnRetrieve";
            btnRetrieve.Size = new Size(100, 23);
            btnRetrieve.TabIndex = 300;
            btnRetrieve.TabStop = false;
            btnRetrieve.Text = "Retrieve";
            btnRetrieve.UseVisualStyleBackColor = true;
            btnRetrieve.Visible = false;
            btnRetrieve.Click += btnRetrieve_Click_1;
            // 
            // lstPasswords
            // 
            lstPasswords.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstPasswords.BackColor = Color.Gold;
            lstPasswords.FormattingEnabled = true;
            lstPasswords.ItemHeight = 15;
            lstPasswords.Location = new Point(199, 6);
            lstPasswords.Name = "lstPasswords";
            lstPasswords.Size = new Size(250, 154);
            lstPasswords.Sorted = true;
            lstPasswords.TabIndex = 4;
            lstPasswords.Visible = false;
            lstPasswords.SelectedIndexChanged += lstPasswords_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(10, 109);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 5;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.ForeColor = SystemColors.ControlLight;
            label2.Location = new Point(10, 155);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 6;
            label2.Text = "Password";
            // 
            // txtWebsite
            // 
            txtWebsite.BackColor = Color.Gainsboro;
            txtWebsite.Location = new Point(10, 78);
            txtWebsite.MaxLength = 99;
            txtWebsite.Name = "txtWebsite";
            txtWebsite.Size = new Size(163, 23);
            txtWebsite.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.ForeColor = SystemColors.ControlLight;
            label3.Location = new Point(10, 60);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 8;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.ForeColor = SystemColors.ControlLight;
            label4.Location = new Point(10, 205);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 10;
            label4.Text = "Notes";
            // 
            // txtNotes
            // 
            txtNotes.BackColor = Color.Gainsboro;
            txtNotes.ForeColor = Color.FromArgb(64, 64, 64);
            txtNotes.Location = new Point(10, 223);
            txtNotes.MaxLength = 99;
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(163, 53);
            txtNotes.TabIndex = 4;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = SystemColors.ControlLight;
            button1.Location = new Point(478, 56);
            button1.Name = "button1";
            button1.Size = new Size(27, 23);
            button1.TabIndex = 11;
            button1.Text = "A";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = SystemColors.ControlLight;
            button2.Location = new Point(478, 77);
            button2.Name = "button2";
            button2.Size = new Size(27, 23);
            button2.TabIndex = 12;
            button2.Text = "B";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.FlatStyle = FlatStyle.Popup;
            button3.ForeColor = SystemColors.ControlLight;
            button3.Location = new Point(478, 341);
            button3.Name = "button3";
            button3.Size = new Size(27, 23);
            button3.TabIndex = 24;
            button3.Text = "N";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.FlatStyle = FlatStyle.Popup;
            button4.ForeColor = SystemColors.ControlLight;
            button4.Location = new Point(478, 319);
            button4.Name = "button4";
            button4.Size = new Size(27, 23);
            button4.TabIndex = 23;
            button4.Text = "M";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button5.FlatStyle = FlatStyle.Popup;
            button5.ForeColor = SystemColors.ControlLight;
            button5.Location = new Point(478, 297);
            button5.Name = "button5";
            button5.Size = new Size(27, 23);
            button5.TabIndex = 22;
            button5.Text = "L";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button6.FlatStyle = FlatStyle.Popup;
            button6.ForeColor = SystemColors.ControlLight;
            button6.Location = new Point(478, 275);
            button6.Name = "button6";
            button6.Size = new Size(27, 23);
            button6.TabIndex = 21;
            button6.Text = "K";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button7.FlatStyle = FlatStyle.Popup;
            button7.ForeColor = SystemColors.ControlLight;
            button7.Location = new Point(478, 253);
            button7.Name = "button7";
            button7.Size = new Size(27, 23);
            button7.TabIndex = 20;
            button7.Text = "J";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button8.FlatStyle = FlatStyle.Popup;
            button8.ForeColor = SystemColors.ControlLight;
            button8.Location = new Point(478, 231);
            button8.Name = "button8";
            button8.Size = new Size(27, 23);
            button8.TabIndex = 19;
            button8.Text = "I";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button9.FlatStyle = FlatStyle.Popup;
            button9.ForeColor = SystemColors.ControlLight;
            button9.Location = new Point(478, 209);
            button9.Name = "button9";
            button9.Size = new Size(27, 23);
            button9.TabIndex = 18;
            button9.Text = "H";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button10.FlatStyle = FlatStyle.Popup;
            button10.ForeColor = SystemColors.ControlLight;
            button10.Location = new Point(478, 187);
            button10.Name = "button10";
            button10.Size = new Size(27, 23);
            button10.TabIndex = 17;
            button10.Text = "G";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button11.FlatStyle = FlatStyle.Popup;
            button11.ForeColor = SystemColors.ControlLight;
            button11.Location = new Point(478, 165);
            button11.Name = "button11";
            button11.Size = new Size(27, 23);
            button11.TabIndex = 16;
            button11.Text = "F";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button12.FlatStyle = FlatStyle.Popup;
            button12.ForeColor = SystemColors.ControlLight;
            button12.Location = new Point(478, 143);
            button12.Name = "button12";
            button12.Size = new Size(27, 23);
            button12.TabIndex = 15;
            button12.Text = "E";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button13.FlatStyle = FlatStyle.Popup;
            button13.ForeColor = SystemColors.ControlLight;
            button13.Location = new Point(478, 121);
            button13.Name = "button13";
            button13.Size = new Size(27, 23);
            button13.TabIndex = 14;
            button13.Text = "D";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // button14
            // 
            button14.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button14.FlatStyle = FlatStyle.Popup;
            button14.ForeColor = SystemColors.ControlLight;
            button14.Location = new Point(478, 99);
            button14.Name = "button14";
            button14.Size = new Size(27, 23);
            button14.TabIndex = 13;
            button14.Text = "C";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // button15
            // 
            button15.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button15.FlatStyle = FlatStyle.Popup;
            button15.ForeColor = SystemColors.ControlLight;
            button15.Location = new Point(478, 583);
            button15.Name = "button15";
            button15.Size = new Size(27, 23);
            button15.TabIndex = 34;
            button15.Text = "Y";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button15_Click;
            // 
            // button16
            // 
            button16.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button16.FlatStyle = FlatStyle.Popup;
            button16.ForeColor = SystemColors.ControlLight;
            button16.Location = new Point(478, 561);
            button16.Name = "button16";
            button16.Size = new Size(27, 23);
            button16.TabIndex = 33;
            button16.Text = "X";
            button16.UseVisualStyleBackColor = true;
            button16.Click += button16_Click;
            // 
            // button17
            // 
            button17.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button17.FlatStyle = FlatStyle.Popup;
            button17.ForeColor = SystemColors.ControlLight;
            button17.Location = new Point(478, 517);
            button17.Name = "button17";
            button17.Size = new Size(27, 23);
            button17.TabIndex = 32;
            button17.Text = "V";
            button17.UseVisualStyleBackColor = true;
            button17.Click += button17_Click;
            // 
            // button18
            // 
            button18.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button18.FlatStyle = FlatStyle.Popup;
            button18.ForeColor = SystemColors.ControlLight;
            button18.Location = new Point(478, 495);
            button18.Name = "button18";
            button18.Size = new Size(27, 23);
            button18.TabIndex = 31;
            button18.Text = "U";
            button18.UseVisualStyleBackColor = true;
            button18.Click += button18_Click;
            // 
            // button19
            // 
            button19.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button19.FlatStyle = FlatStyle.Popup;
            button19.ForeColor = SystemColors.ControlLight;
            button19.Location = new Point(478, 473);
            button19.Name = "button19";
            button19.Size = new Size(27, 23);
            button19.TabIndex = 30;
            button19.Text = "T";
            button19.UseVisualStyleBackColor = true;
            button19.Click += button19_Click;
            // 
            // button20
            // 
            button20.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button20.FlatStyle = FlatStyle.Popup;
            button20.ForeColor = SystemColors.ControlLight;
            button20.Location = new Point(478, 451);
            button20.Name = "button20";
            button20.Size = new Size(27, 23);
            button20.TabIndex = 29;
            button20.Text = "S";
            button20.UseVisualStyleBackColor = true;
            button20.Click += button20_Click;
            // 
            // button21
            // 
            button21.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button21.FlatStyle = FlatStyle.Popup;
            button21.ForeColor = SystemColors.ControlLight;
            button21.Location = new Point(478, 429);
            button21.Name = "button21";
            button21.Size = new Size(27, 23);
            button21.TabIndex = 28;
            button21.Text = "R";
            button21.UseVisualStyleBackColor = true;
            button21.Click += button21_Click;
            // 
            // button22
            // 
            button22.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button22.FlatStyle = FlatStyle.Popup;
            button22.ForeColor = SystemColors.ControlLight;
            button22.Location = new Point(478, 407);
            button22.Name = "button22";
            button22.Size = new Size(27, 23);
            button22.TabIndex = 27;
            button22.Text = "Q";
            button22.UseVisualStyleBackColor = true;
            button22.Click += button22_Click;
            // 
            // button23
            // 
            button23.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button23.FlatStyle = FlatStyle.Popup;
            button23.ForeColor = SystemColors.ControlLight;
            button23.Location = new Point(478, 385);
            button23.Name = "button23";
            button23.Size = new Size(27, 23);
            button23.TabIndex = 26;
            button23.Text = "P";
            button23.UseVisualStyleBackColor = true;
            button23.Click += button23_Click;
            // 
            // button24
            // 
            button24.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button24.FlatStyle = FlatStyle.Popup;
            button24.ForeColor = SystemColors.ControlLight;
            button24.Location = new Point(478, 363);
            button24.Name = "button24";
            button24.Size = new Size(27, 23);
            button24.TabIndex = 25;
            button24.Text = "O";
            button24.UseVisualStyleBackColor = true;
            button24.Click += button24_Click;
            // 
            // button25
            // 
            button25.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button25.FlatStyle = FlatStyle.Popup;
            button25.ForeColor = SystemColors.ControlLight;
            button25.Location = new Point(478, 605);
            button25.Name = "button25";
            button25.Size = new Size(27, 23);
            button25.TabIndex = 35;
            button25.Text = "Z";
            button25.UseVisualStyleBackColor = true;
            button25.Click += button25_Click;
            // 
            // button26
            // 
            button26.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button26.FlatStyle = FlatStyle.Popup;
            button26.ForeColor = SystemColors.ControlLight;
            button26.Location = new Point(478, 34);
            button26.Name = "button26";
            button26.Size = new Size(27, 23);
            button26.TabIndex = 10;
            button26.Text = "#";
            button26.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.ImageList = imageList1;
            tabControl1.Location = new Point(8, 34);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.ShowToolTips = true;
            tabControl1.Size = new Size(464, 594);
            tabControl1.TabIndex = 36;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Gray;
            tabPage1.Controls.Add(lstPasswords2);
            tabPage1.Controls.Add(btnNew);
            tabPage1.Controls.Add(btnUpdate);
            tabPage1.Controls.Add(btnDelete);
            tabPage1.Controls.Add(lstPasswords);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(txtNotes);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(txtWebsite);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(btnRetrieve);
            tabPage1.Controls.Add(btnSave);
            tabPage1.Controls.Add(txtLogin);
            tabPage1.Controls.Add(txtPassword);
            tabPage1.ImageIndex = 5;
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(456, 566);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Vault";
            // 
            // lstPasswords2
            // 
            lstPasswords2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lstPasswords2.BackColor = Color.Gainsboro;
            lstPasswords2.FormattingEnabled = true;
            lstPasswords2.ItemHeight = 15;
            lstPasswords2.Location = new Point(199, 28);
            lstPasswords2.Name = "lstPasswords2";
            lstPasswords2.Size = new Size(250, 529);
            lstPasswords2.Sorted = true;
            lstPasswords2.TabIndex = 304;
            lstPasswords2.SelectedIndexChanged += lstPasswords2_SelectedIndexChanged;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.Gray;
            btnNew.Cursor = Cursors.Hand;
            btnNew.FlatStyle = FlatStyle.Popup;
            btnNew.ForeColor = SystemColors.ControlLight;
            btnNew.Location = new Point(10, 30);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(163, 23);
            btnNew.TabIndex = 303;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Gray;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.Enabled = false;
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.ForeColor = SystemColors.ControlLight;
            btnUpdate.Location = new Point(10, 322);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(163, 23);
            btnUpdate.TabIndex = 302;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDelete.Enabled = false;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.ForeColor = Color.FromArgb(192, 0, 0);
            btnDelete.Location = new Point(10, 529);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(163, 23);
            btnDelete.TabIndex = 301;
            btnDelete.TabStop = false;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(button30);
            tabPage3.Controls.Add(btnViewKey);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(txtSecretKey);
            tabPage3.Controls.Add(btnCopyKey);
            tabPage3.ImageKey = "Key-Access-01-16.png";
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(456, 566);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Key";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.Location = new Point(15, 86);
            label8.Name = "label8";
            label8.Size = new Size(431, 52);
            label8.TabIndex = 7;
            label8.Text = resources.GetString("label8.Text");
            // 
            // label7
            // 
            label7.Location = new Point(15, 35);
            label7.Name = "label7";
            label7.Size = new Size(431, 58);
            label7.TabIndex = 6;
            label7.Text = resources.GetString("label7.Text");
            // 
            // label6
            // 
            label6.Location = new Point(15, 218);
            label6.Name = "label6";
            label6.Size = new Size(432, 80);
            label6.TabIndex = 5;
            label6.Text = resources.GetString("label6.Text");
            // 
            // button30
            // 
            button30.Cursor = Cursors.Hand;
            button30.FlatStyle = FlatStyle.Popup;
            button30.Location = new Point(15, 191);
            button30.Name = "button30";
            button30.Size = new Size(122, 23);
            button30.TabIndex = 4;
            button30.Text = "Generate New Key";
            button30.UseVisualStyleBackColor = true;
            // 
            // btnViewKey
            // 
            btnViewKey.Cursor = Cursors.Hand;
            btnViewKey.FlatStyle = FlatStyle.Popup;
            btnViewKey.Location = new Point(15, 141);
            btnViewKey.Name = "btnViewKey";
            btnViewKey.Size = new Size(70, 23);
            btnViewKey.TabIndex = 3;
            btnViewKey.Text = "View Key";
            btnViewKey.UseVisualStyleBackColor = true;
            btnViewKey.Click += btnViewKey_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(15, 13);
            label5.Name = "label5";
            label5.Size = new Size(96, 15);
            label5.TabIndex = 2;
            label5.Text = "Your Secret Key";
            // 
            // txtSecretKey
            // 
            txtSecretKey.Location = new Point(91, 141);
            txtSecretKey.Name = "txtSecretKey";
            txtSecretKey.Size = new Size(284, 23);
            txtSecretKey.TabIndex = 1;
            txtSecretKey.Visible = false;
            // 
            // btnCopyKey
            // 
            btnCopyKey.Cursor = Cursors.Hand;
            btnCopyKey.FlatStyle = FlatStyle.Popup;
            btnCopyKey.Location = new Point(381, 141);
            btnCopyKey.Name = "btnCopyKey";
            btnCopyKey.Size = new Size(43, 23);
            btnCopyKey.TabIndex = 0;
            btnCopyKey.Text = "Copy";
            btnCopyKey.UseVisualStyleBackColor = true;
            btnCopyKey.Visible = false;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label16);
            tabPage2.Controls.Add(label15);
            tabPage2.ImageKey = "User_Profile_16.png";
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(456, 566);
            tabPage2.TabIndex = 3;
            tabPage2.Text = "Greg";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(groupBox3);
            tabPage4.Controls.Add(groupBox2);
            tabPage4.Controls.Add(groupBox1);
            tabPage4.ImageKey = "Help-Shield-16-gray.png";
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(456, 566);
            tabPage4.TabIndex = 4;
            tabPage4.Text = "Help";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // linkLabel4
            // 
            linkLabel4.AutoSize = true;
            linkLabel4.Location = new Point(16, 87);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new Size(193, 15);
            linkLabel4.TabIndex = 9;
            linkLabel4.TabStop = true;
            linkLabel4.Text = "Nuke9.com/GregYoung9/SSSecretS";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(16, 67);
            label13.Name = "label13";
            label13.Size = new Size(64, 15);
            label13.TabIndex = 8;
            label13.Text = "Download:";
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Location = new Point(16, 22);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(66, 15);
            linkLabel3.TabIndex = 7;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "nuke9.com";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(16, 46);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(194, 15);
            linkLabel2.TabIndex = 6;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "github.com/GregYoung9/SSSecretS";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(16, 30);
            label12.Name = "label12";
            label12.Size = new Size(177, 15);
            label12.TabIndex = 5;
            label12.Text = "Software Version:  ALPHA 1.0.0.0";
            // 
            // label11
            // 
            label11.Image = Properties.Resources.flagUSA;
            label11.ImageAlign = ContentAlignment.MiddleLeft;
            label11.Location = new Point(16, 89);
            label11.Name = "label11";
            label11.Size = new Size(144, 18);
            label11.TabIndex = 4;
            label11.Text = "Columbus, Ohio USA";
            label11.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(16, 69);
            label10.Name = "label10";
            label10.Size = new Size(89, 15);
            label10.TabIndex = 3;
            label10.Text = "(614) 349-NUKE\r\n";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(16, 47);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(101, 15);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "greg@nuke9.com";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 30);
            label9.Name = "label9";
            label9.Size = new Size(69, 15);
            label9.TabIndex = 1;
            label9.Text = "Greg Young";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.SilverbackCS_sm;
            pictureBox1.Location = new Point(16, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(177, 177);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "User_Profile_16.png");
            imageList1.Images.SetKeyName(1, "Document-01-16.png");
            imageList1.Images.SetKeyName(2, "Edit-16.png");
            imageList1.Images.SetKeyName(3, "Excel-Export-16.png");
            imageList1.Images.SetKeyName(4, "Tools-02-16.png");
            imageList1.Images.SetKeyName(5, "Lock-WF-16.ico");
            imageList1.Images.SetKeyName(6, "Key-Access-01-16.png");
            imageList1.Images.SetKeyName(7, "Help-Shield-16.png");
            imageList1.Images.SetKeyName(8, "Help-Shield-16-gray.png");
            imageList1.Images.SetKeyName(9, "Question_16.png");
            // 
            // button27
            // 
            button27.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button27.FlatStyle = FlatStyle.Popup;
            button27.ForeColor = SystemColors.ControlLight;
            button27.Location = new Point(478, 539);
            button27.Name = "button27";
            button27.Size = new Size(27, 23);
            button27.TabIndex = 37;
            button27.Text = "W";
            button27.UseVisualStyleBackColor = true;
            button27.Click += button27_Click;
            // 
            // txtSearchFor
            // 
            txtSearchFor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearchFor.BackColor = Color.Gray;
            txtSearchFor.BorderStyle = BorderStyle.FixedSingle;
            txtSearchFor.Location = new Point(363, 5);
            txtSearchFor.Name = "txtSearchFor";
            txtSearchFor.Size = new Size(109, 23);
            txtSearchFor.TabIndex = 38;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.BackColor = Color.Gray;
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Image = Properties.Resources.Search_Find_24;
            btnSearch.Location = new Point(476, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(30, 27);
            btnSearch.TabIndex = 39;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(linkLabel4);
            groupBox1.Controls.Add(linkLabel2);
            groupBox1.Controls.Add(label13);
            groupBox1.Location = new Point(24, 154);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(258, 138);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Software";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Controls.Add(linkLabel3);
            groupBox2.Location = new Point(24, 305);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(258, 243);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Support";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(linkLabel1);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label11);
            groupBox3.Location = new Point(24, 19);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(258, 122);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Developer";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(17, 110);
            label14.Name = "label14";
            label14.Size = new Size(170, 15);
            label14.TabIndex = 10;
            label14.Text = "Web and mobile coming soon.";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(19, 95);
            label15.Name = "label15";
            label15.Size = new Size(57, 15);
            label15.TabIndex = 0;
            label15.Text = "Your data";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(16, 38);
            label16.Name = "label16";
            label16.Size = new Size(208, 15);
            label16.TabIndex = 1;
            label16.Text = "Your login and account info goes here";
            // 
            // Form1
            // 
            AcceptButton = btnSearch;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(512, 635);
            Controls.Add(txtSearchFor);
            Controls.Add(btnSearch);
            Controls.Add(button27);
            Controls.Add(button26);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button25);
            Controls.Add(button14);
            Controls.Add(button11);
            Controls.Add(button1);
            Controls.Add(button15);
            Controls.Add(button10);
            Controls.Add(button24);
            Controls.Add(button16);
            Controls.Add(button9);
            Controls.Add(button2);
            Controls.Add(button17);
            Controls.Add(button8);
            Controls.Add(button23);
            Controls.Add(button18);
            Controls.Add(button7);
            Controls.Add(button19);
            Controls.Add(button3);
            Controls.Add(button6);
            Controls.Add(button20);
            Controls.Add(button22);
            Controls.Add(button5);
            Controls.Add(button21);
            Controls.Add(button4);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "N|9 Super Simple Secret Saver";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPassword;
        private TextBox txtLogin;
        private Button btnSave;
        private Button btnRetrieve;
        private ListBox lstPasswords;
        private Label label1;
        private Label label2;
        private TextBox txtWebsite;
        private Label label3;
        private Label label4;
        private TextBox txtNotes;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
        private Button button19;
        private Button button20;
        private Button button21;
        private Button button22;
        private Button button23;
        private Button button24;
        private Button button25;
        private Button button26;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button button27;
        private Button btnDelete;
        private Button btnUpdate;
        private TextBox txtSearchFor;
        private Button btnSearch;
        private Button btnNew;
        private TabPage tabPage3;
        private TextBox txtSecretKey;
        private Button btnCopyKey;
        private Label label5;
        private Button btnViewKey;
        private Label label6;
        private Button button30;
        private Label label7;
        private Label label8;
        private ImageList imageList1;
        private TabPage tabPage2;
        private ListBox lstPasswords2;
        private TabPage tabPage4;
        private PictureBox pictureBox1;
        private Label label10;
        private LinkLabel linkLabel1;
        private Label label9;
        private Label label11;
        private LinkLabel linkLabel2;
        private Label label12;
        private LinkLabel linkLabel4;
        private Label label13;
        private LinkLabel linkLabel3;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private Label label14;
        private Label label16;
        private Label label15;
    }
}
