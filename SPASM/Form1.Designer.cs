namespace SPASM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnGetEQ = new Button();
            txtGetEQ = new TextBox();
            btnGetINIs = new Button();
            txtINIs = new TextBox();
            btnGetSocials = new Button();
            txtSocials = new TextBox();
            lblTitle = new Label();
            cboCurrentCharacter = new ComboBox();
            lblCurrentCharacter = new Label();
            txtAllSocials = new TextBox();
            cboSource = new ComboBox();
            lblSource = new Label();
            lstCurrent = new ListBox();
            txtcurrentLine1 = new TextBox();
            txtcurrentLine2 = new TextBox();
            txtcurrentLine3 = new TextBox();
            txtcurrentLine4 = new TextBox();
            txtcurrentLine5 = new TextBox();
            txtcurrentColor = new TextBox();
            lblcurrentDetails = new Label();
            lblcurrentMacroList = new Label();
            lstAllSocials = new ListBox();
            lblAllSocials = new Label();
            lblAllDetail = new Label();
            txtAllColor = new TextBox();
            txtAllLine5 = new TextBox();
            txtAllLine4 = new TextBox();
            txtAllLine3 = new TextBox();
            txtAllLine2 = new TextBox();
            txtAllLine1 = new TextBox();
            lblcurrentLine1 = new Label();
            lblcurrentLine2 = new Label();
            lblcurrentLine3 = new Label();
            lblcurrentLine4 = new Label();
            lblcurrentLine5 = new Label();
            lblCurrentColor = new Label();
            lblAllColor = new Label();
            lblAllLine5 = new Label();
            lblAllLine4 = new Label();
            lblAllLine3 = new Label();
            lblAllLine2 = new Label();
            lblAllLine1 = new Label();
            statusStrip1 = new StatusStrip();
            toolStripProgressBar1 = new ToolStripProgressBar();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lblVersion = new Label();
            textBox1 = new TextBox();
            lblInstructions = new Label();
            txtCurrentName = new TextBox();
            lblCurrentName = new Label();
            lblAllName = new Label();
            txtAllName = new TextBox();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnGetEQ
            // 
            btnGetEQ.Location = new Point(40, 44);
            btnGetEQ.Name = "btnGetEQ";
            btnGetEQ.Size = new Size(128, 23);
            btnGetEQ.TabIndex = 0;
            btnGetEQ.Text = "Select EQ folder";
            btnGetEQ.UseVisualStyleBackColor = true;
            btnGetEQ.Click += btnGetEQ_Click;
            // 
            // txtGetEQ
            // 
            txtGetEQ.Location = new Point(185, 44);
            txtGetEQ.Name = "txtGetEQ";
            txtGetEQ.Size = new Size(493, 23);
            txtGetEQ.TabIndex = 1;
            txtGetEQ.Text = "C:\\temp\\SPASM";
            // 
            // btnGetINIs
            // 
            btnGetINIs.Location = new Point(40, 84);
            btnGetINIs.Name = "btnGetINIs";
            btnGetINIs.Size = new Size(128, 23);
            btnGetINIs.TabIndex = 2;
            btnGetINIs.Text = "Get INI files";
            btnGetINIs.UseVisualStyleBackColor = true;
            btnGetINIs.Click += btnGetINIs_Click;
            // 
            // txtINIs
            // 
            txtINIs.Location = new Point(185, 84);
            txtINIs.Multiline = true;
            txtINIs.Name = "txtINIs";
            txtINIs.ScrollBars = ScrollBars.Vertical;
            txtINIs.Size = new Size(490, 131);
            txtINIs.TabIndex = 3;
            // 
            // btnGetSocials
            // 
            btnGetSocials.Location = new Point(40, 295);
            btnGetSocials.Name = "btnGetSocials";
            btnGetSocials.Size = new Size(128, 23);
            btnGetSocials.TabIndex = 4;
            btnGetSocials.Text = "Get Socials";
            btnGetSocials.UseVisualStyleBackColor = true;
            btnGetSocials.Click += btnGetSocials_Click;
            // 
            // txtSocials
            // 
            txtSocials.Location = new Point(755, 15);
            txtSocials.Multiline = true;
            txtSocials.Name = "txtSocials";
            txtSocials.ScrollBars = ScrollBars.Vertical;
            txtSocials.Size = new Size(98, 23);
            txtSocials.TabIndex = 5;
            txtSocials.Visible = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitle.Location = new Point(261, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(414, 21);
            lblTitle.TabIndex = 6;
            lblTitle.Text = "Simple Program for Automated Socials Manipulation";
            // 
            // cboCurrentCharacter
            // 
            cboCurrentCharacter.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCurrentCharacter.FormattingEnabled = true;
            cboCurrentCharacter.Location = new Point(185, 270);
            cboCurrentCharacter.Name = "cboCurrentCharacter";
            cboCurrentCharacter.Size = new Size(371, 23);
            cboCurrentCharacter.TabIndex = 7;
            // 
            // lblCurrentCharacter
            // 
            lblCurrentCharacter.AutoSize = true;
            lblCurrentCharacter.Location = new Point(185, 252);
            lblCurrentCharacter.Name = "lblCurrentCharacter";
            lblCurrentCharacter.Size = new Size(124, 15);
            lblCurrentCharacter.TabIndex = 8;
            lblCurrentCharacter.Text = "Character to be edited";
            // 
            // txtAllSocials
            // 
            txtAllSocials.Location = new Point(859, 15);
            txtAllSocials.Multiline = true;
            txtAllSocials.Name = "txtAllSocials";
            txtAllSocials.ScrollBars = ScrollBars.Vertical;
            txtAllSocials.Size = new Size(98, 23);
            txtAllSocials.TabIndex = 9;
            txtAllSocials.Visible = false;
            // 
            // cboSource
            // 
            cboSource.FormattingEnabled = true;
            cboSource.Location = new Point(645, 270);
            cboSource.Name = "cboSource";
            cboSource.Size = new Size(371, 23);
            cboSource.TabIndex = 10;
            // 
            // lblSource
            // 
            lblSource.AutoSize = true;
            lblSource.Location = new Point(645, 252);
            lblSource.Name = "lblSource";
            lblSource.Size = new Size(130, 15);
            lblSource.TabIndex = 11;
            lblSource.Text = "Character to copy from";
            // 
            // lstCurrent
            // 
            lstCurrent.FormattingEnabled = true;
            lstCurrent.ItemHeight = 15;
            lstCurrent.Location = new Point(185, 353);
            lstCurrent.Name = "lstCurrent";
            lstCurrent.ScrollAlwaysVisible = true;
            lstCurrent.Size = new Size(371, 94);
            lstCurrent.TabIndex = 12;
            lstCurrent.SelectedIndexChanged += lstCurrent_SelectedIndexChanged;
            // 
            // txtcurrentLine1
            // 
            txtcurrentLine1.Location = new Point(185, 519);
            txtcurrentLine1.Name = "txtcurrentLine1";
            txtcurrentLine1.Size = new Size(371, 23);
            txtcurrentLine1.TabIndex = 13;
            // 
            // txtcurrentLine2
            // 
            txtcurrentLine2.Location = new Point(185, 548);
            txtcurrentLine2.Name = "txtcurrentLine2";
            txtcurrentLine2.Size = new Size(371, 23);
            txtcurrentLine2.TabIndex = 14;
            // 
            // txtcurrentLine3
            // 
            txtcurrentLine3.Location = new Point(185, 577);
            txtcurrentLine3.Name = "txtcurrentLine3";
            txtcurrentLine3.Size = new Size(371, 23);
            txtcurrentLine3.TabIndex = 15;
            // 
            // txtcurrentLine4
            // 
            txtcurrentLine4.Location = new Point(185, 606);
            txtcurrentLine4.Name = "txtcurrentLine4";
            txtcurrentLine4.Size = new Size(371, 23);
            txtcurrentLine4.TabIndex = 16;
            // 
            // txtcurrentLine5
            // 
            txtcurrentLine5.Location = new Point(185, 635);
            txtcurrentLine5.Name = "txtcurrentLine5";
            txtcurrentLine5.Size = new Size(371, 23);
            txtcurrentLine5.TabIndex = 17;
            // 
            // txtcurrentColor
            // 
            txtcurrentColor.Location = new Point(185, 664);
            txtcurrentColor.Name = "txtcurrentColor";
            txtcurrentColor.Size = new Size(33, 23);
            txtcurrentColor.TabIndex = 18;
            // 
            // lblcurrentDetails
            // 
            lblcurrentDetails.AutoSize = true;
            lblcurrentDetails.Location = new Point(185, 472);
            lblcurrentDetails.Name = "lblcurrentDetails";
            lblcurrentDetails.Size = new Size(78, 15);
            lblcurrentDetails.TabIndex = 19;
            lblcurrentDetails.Text = "Macro details";
            // 
            // lblcurrentMacroList
            // 
            lblcurrentMacroList.AutoSize = true;
            lblcurrentMacroList.Location = new Point(185, 335);
            lblcurrentMacroList.Name = "lblcurrentMacroList";
            lblcurrentMacroList.Size = new Size(89, 15);
            lblcurrentMacroList.TabIndex = 20;
            lblcurrentMacroList.Text = "Current macros";
            // 
            // lstAllSocials
            // 
            lstAllSocials.FormattingEnabled = true;
            lstAllSocials.ItemHeight = 15;
            lstAllSocials.Location = new Point(645, 353);
            lstAllSocials.Name = "lstAllSocials";
            lstAllSocials.ScrollAlwaysVisible = true;
            lstAllSocials.Size = new Size(371, 94);
            lstAllSocials.TabIndex = 21;
            lstAllSocials.SelectedIndexChanged += lstAllSocials_SelectedIndexChanged;
            // 
            // lblAllSocials
            // 
            lblAllSocials.AutoSize = true;
            lblAllSocials.Location = new Point(645, 335);
            lblAllSocials.Name = "lblAllSocials";
            lblAllSocials.Size = new Size(85, 15);
            lblAllSocials.TabIndex = 22;
            lblAllSocials.Text = "Source macros";
            // 
            // lblAllDetail
            // 
            lblAllDetail.AutoSize = true;
            lblAllDetail.Location = new Point(645, 472);
            lblAllDetail.Name = "lblAllDetail";
            lblAllDetail.Size = new Size(78, 15);
            lblAllDetail.TabIndex = 29;
            lblAllDetail.Text = "Macro details";
            // 
            // txtAllColor
            // 
            txtAllColor.Location = new Point(645, 664);
            txtAllColor.Name = "txtAllColor";
            txtAllColor.Size = new Size(33, 23);
            txtAllColor.TabIndex = 28;
            // 
            // txtAllLine5
            // 
            txtAllLine5.Location = new Point(645, 635);
            txtAllLine5.Name = "txtAllLine5";
            txtAllLine5.Size = new Size(371, 23);
            txtAllLine5.TabIndex = 27;
            // 
            // txtAllLine4
            // 
            txtAllLine4.Location = new Point(645, 606);
            txtAllLine4.Name = "txtAllLine4";
            txtAllLine4.Size = new Size(371, 23);
            txtAllLine4.TabIndex = 26;
            // 
            // txtAllLine3
            // 
            txtAllLine3.Location = new Point(645, 577);
            txtAllLine3.Name = "txtAllLine3";
            txtAllLine3.Size = new Size(371, 23);
            txtAllLine3.TabIndex = 25;
            // 
            // txtAllLine2
            // 
            txtAllLine2.Location = new Point(645, 548);
            txtAllLine2.Name = "txtAllLine2";
            txtAllLine2.Size = new Size(371, 23);
            txtAllLine2.TabIndex = 24;
            // 
            // txtAllLine1
            // 
            txtAllLine1.Location = new Point(645, 519);
            txtAllLine1.Name = "txtAllLine1";
            txtAllLine1.Size = new Size(371, 23);
            txtAllLine1.TabIndex = 23;
            // 
            // lblcurrentLine1
            // 
            lblcurrentLine1.AutoSize = true;
            lblcurrentLine1.Location = new Point(130, 522);
            lblcurrentLine1.Name = "lblcurrentLine1";
            lblcurrentLine1.Size = new Size(38, 15);
            lblcurrentLine1.TabIndex = 30;
            lblcurrentLine1.Text = "Line 1";
            // 
            // lblcurrentLine2
            // 
            lblcurrentLine2.AutoSize = true;
            lblcurrentLine2.Location = new Point(130, 551);
            lblcurrentLine2.Name = "lblcurrentLine2";
            lblcurrentLine2.Size = new Size(38, 15);
            lblcurrentLine2.TabIndex = 31;
            lblcurrentLine2.Text = "Line 2";
            // 
            // lblcurrentLine3
            // 
            lblcurrentLine3.AutoSize = true;
            lblcurrentLine3.Location = new Point(130, 580);
            lblcurrentLine3.Name = "lblcurrentLine3";
            lblcurrentLine3.Size = new Size(38, 15);
            lblcurrentLine3.TabIndex = 32;
            lblcurrentLine3.Text = "Line 3";
            // 
            // lblcurrentLine4
            // 
            lblcurrentLine4.AutoSize = true;
            lblcurrentLine4.Location = new Point(130, 609);
            lblcurrentLine4.Name = "lblcurrentLine4";
            lblcurrentLine4.Size = new Size(38, 15);
            lblcurrentLine4.TabIndex = 33;
            lblcurrentLine4.Text = "Line 4";
            // 
            // lblcurrentLine5
            // 
            lblcurrentLine5.AutoSize = true;
            lblcurrentLine5.Location = new Point(130, 638);
            lblcurrentLine5.Name = "lblcurrentLine5";
            lblcurrentLine5.Size = new Size(38, 15);
            lblcurrentLine5.TabIndex = 34;
            lblcurrentLine5.Text = "Line 5";
            // 
            // lblCurrentColor
            // 
            lblCurrentColor.AutoSize = true;
            lblCurrentColor.Location = new Point(130, 667);
            lblCurrentColor.Name = "lblCurrentColor";
            lblCurrentColor.Size = new Size(36, 15);
            lblCurrentColor.TabIndex = 35;
            lblCurrentColor.Text = "Color";
            // 
            // lblAllColor
            // 
            lblAllColor.AutoSize = true;
            lblAllColor.Location = new Point(592, 667);
            lblAllColor.Name = "lblAllColor";
            lblAllColor.Size = new Size(36, 15);
            lblAllColor.TabIndex = 41;
            lblAllColor.Text = "Color";
            // 
            // lblAllLine5
            // 
            lblAllLine5.AutoSize = true;
            lblAllLine5.Location = new Point(592, 638);
            lblAllLine5.Name = "lblAllLine5";
            lblAllLine5.Size = new Size(38, 15);
            lblAllLine5.TabIndex = 40;
            lblAllLine5.Text = "Line 5";
            // 
            // lblAllLine4
            // 
            lblAllLine4.AutoSize = true;
            lblAllLine4.Location = new Point(592, 609);
            lblAllLine4.Name = "lblAllLine4";
            lblAllLine4.Size = new Size(38, 15);
            lblAllLine4.TabIndex = 39;
            lblAllLine4.Text = "Line 4";
            // 
            // lblAllLine3
            // 
            lblAllLine3.AutoSize = true;
            lblAllLine3.Location = new Point(592, 580);
            lblAllLine3.Name = "lblAllLine3";
            lblAllLine3.Size = new Size(38, 15);
            lblAllLine3.TabIndex = 38;
            lblAllLine3.Text = "Line 3";
            // 
            // lblAllLine2
            // 
            lblAllLine2.AutoSize = true;
            lblAllLine2.Location = new Point(592, 551);
            lblAllLine2.Name = "lblAllLine2";
            lblAllLine2.Size = new Size(38, 15);
            lblAllLine2.TabIndex = 37;
            lblAllLine2.Text = "Line 2";
            // 
            // lblAllLine1
            // 
            lblAllLine1.AutoSize = true;
            lblAllLine1.Location = new Point(592, 522);
            lblAllLine1.Name = "lblAllLine1";
            lblAllLine1.Size = new Size(38, 15);
            lblAllLine1.TabIndex = 36;
            lblAllLine1.Text = "Line 1";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripProgressBar1, toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 721);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1059, 22);
            statusStrip1.TabIndex = 42;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(100, 16);
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(118, 17);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Location = new Point(988, 15);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(28, 15);
            lblVersion.TabIndex = 43;
            lblVersion.Text = "v1.0";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(702, 66);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(314, 149);
            textBox1.TabIndex = 44;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // lblInstructions
            // 
            lblInstructions.AutoSize = true;
            lblInstructions.Location = new Point(702, 48);
            lblInstructions.Name = "lblInstructions";
            lblInstructions.Size = new Size(69, 15);
            lblInstructions.TabIndex = 45;
            lblInstructions.Text = "Instructions";
            // 
            // txtCurrentName
            // 
            txtCurrentName.Location = new Point(185, 490);
            txtCurrentName.Name = "txtCurrentName";
            txtCurrentName.Size = new Size(221, 23);
            txtCurrentName.TabIndex = 46;
            // 
            // lblCurrentName
            // 
            lblCurrentName.AutoSize = true;
            lblCurrentName.Location = new Point(130, 493);
            lblCurrentName.Name = "lblCurrentName";
            lblCurrentName.Size = new Size(39, 15);
            lblCurrentName.TabIndex = 47;
            lblCurrentName.Text = "Name";
            // 
            // lblAllName
            // 
            lblAllName.AutoSize = true;
            lblAllName.Location = new Point(590, 493);
            lblAllName.Name = "lblAllName";
            lblAllName.Size = new Size(39, 15);
            lblAllName.TabIndex = 49;
            lblAllName.Text = "Name";
            // 
            // txtAllName
            // 
            txtAllName.Location = new Point(645, 490);
            txtAllName.Name = "txtAllName";
            txtAllName.Size = new Size(221, 23);
            txtAllName.TabIndex = 48;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 743);
            Controls.Add(lblAllName);
            Controls.Add(txtAllName);
            Controls.Add(lblCurrentName);
            Controls.Add(txtCurrentName);
            Controls.Add(lblInstructions);
            Controls.Add(textBox1);
            Controls.Add(lblVersion);
            Controls.Add(statusStrip1);
            Controls.Add(lblAllColor);
            Controls.Add(lblAllLine5);
            Controls.Add(lblAllLine4);
            Controls.Add(lblAllLine3);
            Controls.Add(lblAllLine2);
            Controls.Add(lblAllLine1);
            Controls.Add(lblCurrentColor);
            Controls.Add(lblcurrentLine5);
            Controls.Add(lblcurrentLine4);
            Controls.Add(lblcurrentLine3);
            Controls.Add(lblcurrentLine2);
            Controls.Add(lblcurrentLine1);
            Controls.Add(lblAllDetail);
            Controls.Add(txtAllColor);
            Controls.Add(txtAllLine5);
            Controls.Add(txtAllLine4);
            Controls.Add(txtAllLine3);
            Controls.Add(txtAllLine2);
            Controls.Add(txtAllLine1);
            Controls.Add(lblAllSocials);
            Controls.Add(lstAllSocials);
            Controls.Add(lblcurrentMacroList);
            Controls.Add(lblcurrentDetails);
            Controls.Add(txtcurrentColor);
            Controls.Add(txtcurrentLine5);
            Controls.Add(txtcurrentLine4);
            Controls.Add(txtcurrentLine3);
            Controls.Add(txtcurrentLine2);
            Controls.Add(txtcurrentLine1);
            Controls.Add(lstCurrent);
            Controls.Add(lblSource);
            Controls.Add(cboSource);
            Controls.Add(txtAllSocials);
            Controls.Add(lblCurrentCharacter);
            Controls.Add(cboCurrentCharacter);
            Controls.Add(lblTitle);
            Controls.Add(txtSocials);
            Controls.Add(btnGetSocials);
            Controls.Add(txtINIs);
            Controls.Add(btnGetINIs);
            Controls.Add(txtGetEQ);
            Controls.Add(btnGetEQ);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "SPASM";
            Load += Form1_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGetEQ;
        private TextBox txtGetEQ;
        private Button btnGetINIs;
        private TextBox txtINIs;
        private Button btnGetSocials;
        private TextBox txtSocials;
        private Label lblTitle;
        private ComboBox cboCurrentCharacter;
        private Label lblCurrentCharacter;
        private TextBox txtAllSocials;
        private ComboBox cboSource;
        private Label lblSource;
        private ListBox lstCurrent;
        private TextBox txtcurrentLine1;
        private TextBox txtcurrentLine2;
        private TextBox txtcurrentLine3;
        private TextBox txtcurrentLine4;
        private TextBox txtcurrentLine5;
        private TextBox txtcurrentColor;
        private Label lblcurrentDetails;
        private Label lblcurrentMacroList;
        private ListBox lstAllSocials;
        private Label lblAllSocials;
        private Label lblAllDetail;
        private TextBox txtAllColor;
        private TextBox txtAllLine5;
        private TextBox txtAllLine4;
        private TextBox txtAllLine3;
        private TextBox txtAllLine2;
        private TextBox txtAllLine1;
        private Label lblcurrentLine1;
        private Label lblcurrentLine2;
        private Label lblcurrentLine3;
        private Label lblcurrentLine4;
        private Label lblcurrentLine5;
        private Label lblCurrentColor;
        private Label lblAllColor;
        private Label lblAllLine5;
        private Label lblAllLine4;
        private Label lblAllLine3;
        private Label lblAllLine2;
        private Label lblAllLine1;
        private StatusStrip statusStrip1;
        private ToolStripProgressBar toolStripProgressBar1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Label lblVersion;
        private TextBox textBox1;
        private Label lblInstructions;
        private TextBox txtCurrentName;
        private Label lblCurrentName;
        private Label lblAllName;
        private TextBox txtAllName;
    }
}
