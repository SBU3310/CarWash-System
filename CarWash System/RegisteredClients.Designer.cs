namespace CarWash_System
{
    partial class RegisteredClients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisteredClients));
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDone = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnCredDone = new System.Windows.Forms.Button();
            this.txtCredAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnAppEnter = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtAppNum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkAirFil = new System.Windows.Forms.CheckBox();
            this.chkGrease = new System.Windows.Forms.CheckBox();
            this.chkOilFil = new System.Windows.Forms.CheckBox();
            this.chkEngOil = new System.Windows.Forms.CheckBox();
            this.chkTurning = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radBoth = new System.Windows.Forms.RadioButton();
            this.radExterior = new System.Windows.Forms.RadioButton();
            this.radInterior = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.redOutput = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registered Clients";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(40, 101);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(448, 247);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.btnCheck);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(440, 221);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Check Balance";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 45);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(434, 173);
            this.listBox1.TabIndex = 1;
            // 
            // btnCheck
            // 
            this.btnCheck.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Location = new System.Drawing.Point(346, 6);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(88, 29);
            this.btnCheck.TabIndex = 0;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.Controls.Add(this.btnDone);
            this.tabPage2.Controls.Add(this.txtAmount);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(440, 221);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Deposit Money";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnDone
            // 
            this.btnDone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.Location = new System.Drawing.Point(174, 135);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 2;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.BtnDone_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(174, 76);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Amount";
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage3.BackgroundImage")));
            this.tabPage3.Controls.Add(this.btnCredDone);
            this.tabPage3.Controls.Add(this.txtCredAmount);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(440, 221);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Request Credit";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnCredDone
            // 
            this.btnCredDone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCredDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCredDone.Location = new System.Drawing.Point(182, 127);
            this.btnCredDone.Name = "btnCredDone";
            this.btnCredDone.Size = new System.Drawing.Size(75, 23);
            this.btnCredDone.TabIndex = 5;
            this.btnCredDone.Text = "Done";
            this.btnCredDone.UseVisualStyleBackColor = true;
            this.btnCredDone.Click += new System.EventHandler(this.BtnCredDone_Click);
            // 
            // txtCredAmount
            // 
            this.txtCredAmount.Location = new System.Drawing.Point(182, 68);
            this.txtCredAmount.Name = "txtCredAmount";
            this.txtCredAmount.Size = new System.Drawing.Size(100, 20);
            this.txtCredAmount.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(82, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Amount";
            // 
            // tabPage4
            // 
            this.tabPage4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage4.BackgroundImage")));
            this.tabPage4.Controls.Add(this.btnAppEnter);
            this.tabPage4.Controls.Add(this.txtName);
            this.tabPage4.Controls.Add(this.txtDate);
            this.tabPage4.Controls.Add(this.txtTime);
            this.tabPage4.Controls.Add(this.txtAppNum);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(440, 221);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Make Appointment";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnAppEnter
            // 
            this.btnAppEnter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAppEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppEnter.Location = new System.Drawing.Point(338, 184);
            this.btnAppEnter.Name = "btnAppEnter";
            this.btnAppEnter.Size = new System.Drawing.Size(75, 23);
            this.btnAppEnter.TabIndex = 8;
            this.btnAppEnter.Text = "Enter";
            this.btnAppEnter.UseVisualStyleBackColor = true;
            this.btnAppEnter.Click += new System.EventHandler(this.BtnAppEnter_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(203, 154);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(132, 20);
            this.txtName.TabIndex = 7;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(203, 110);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(132, 20);
            this.txtDate.TabIndex = 6;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(203, 71);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(132, 20);
            this.txtTime.TabIndex = 5;
            // 
            // txtAppNum
            // 
            this.txtAppNum.Location = new System.Drawing.Point(203, 29);
            this.txtAppNum.Name = "txtAppNum";
            this.txtAppNum.Size = new System.Drawing.Size(132, 20);
            this.txtAppNum.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(21, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Client Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(21, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(21, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(21, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Appointment Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(167, 374);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "Type of Service";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.chkAirFil);
            this.groupBox3.Controls.Add(this.chkGrease);
            this.groupBox3.Controls.Add(this.chkOilFil);
            this.groupBox3.Controls.Add(this.chkEngOil);
            this.groupBox3.Controls.Add(this.chkTurning);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(16, 422);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(182, 228);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Maintenance";
            // 
            // chkAirFil
            // 
            this.chkAirFil.AutoSize = true;
            this.chkAirFil.Location = new System.Drawing.Point(24, 181);
            this.chkAirFil.Name = "chkAirFil";
            this.chkAirFil.Size = new System.Drawing.Size(63, 17);
            this.chkAirFil.TabIndex = 4;
            this.chkAirFil.Text = "Air Filter";
            this.chkAirFil.UseVisualStyleBackColor = true;
            // 
            // chkGrease
            // 
            this.chkGrease.AutoSize = true;
            this.chkGrease.Location = new System.Drawing.Point(24, 140);
            this.chkGrease.Name = "chkGrease";
            this.chkGrease.Size = new System.Drawing.Size(133, 17);
            this.chkGrease.TabIndex = 3;
            this.chkGrease.Text = "Grease and Lubricants";
            this.chkGrease.UseVisualStyleBackColor = true;
            // 
            // chkOilFil
            // 
            this.chkOilFil.AutoSize = true;
            this.chkOilFil.Location = new System.Drawing.Point(24, 102);
            this.chkOilFil.Name = "chkOilFil";
            this.chkOilFil.Size = new System.Drawing.Size(63, 17);
            this.chkOilFil.TabIndex = 2;
            this.chkOilFil.Text = "Oil Filter";
            this.chkOilFil.UseVisualStyleBackColor = true;
            // 
            // chkEngOil
            // 
            this.chkEngOil.AutoSize = true;
            this.chkEngOil.Location = new System.Drawing.Point(24, 65);
            this.chkEngOil.Name = "chkEngOil";
            this.chkEngOil.Size = new System.Drawing.Size(74, 17);
            this.chkEngOil.TabIndex = 1;
            this.chkEngOil.Text = "Engine Oil";
            this.chkEngOil.UseVisualStyleBackColor = true;
            // 
            // chkTurning
            // 
            this.chkTurning.AutoSize = true;
            this.chkTurning.Location = new System.Drawing.Point(24, 29);
            this.chkTurning.Name = "chkTurning";
            this.chkTurning.Size = new System.Drawing.Size(98, 17);
            this.chkTurning.TabIndex = 0;
            this.chkTurning.Text = "Engine Turning";
            this.chkTurning.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.radBoth);
            this.groupBox4.Controls.Add(this.radExterior);
            this.groupBox4.Controls.Add(this.radInterior);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(255, 422);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(190, 228);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Car Wash";
            // 
            // radBoth
            // 
            this.radBoth.AutoSize = true;
            this.radBoth.Location = new System.Drawing.Point(24, 102);
            this.radBoth.Name = "radBoth";
            this.radBoth.Size = new System.Drawing.Size(47, 17);
            this.radBoth.TabIndex = 9;
            this.radBoth.TabStop = true;
            this.radBoth.Text = "Both";
            this.radBoth.UseVisualStyleBackColor = true;
            // 
            // radExterior
            // 
            this.radExterior.AutoSize = true;
            this.radExterior.Location = new System.Drawing.Point(24, 65);
            this.radExterior.Name = "radExterior";
            this.radExterior.Size = new System.Drawing.Size(84, 17);
            this.radExterior.TabIndex = 8;
            this.radExterior.TabStop = true;
            this.radExterior.Text = "Exterior Only";
            this.radExterior.UseVisualStyleBackColor = true;
            // 
            // radInterior
            // 
            this.radInterior.AutoSize = true;
            this.radInterior.Location = new System.Drawing.Point(24, 29);
            this.radInterior.Name = "radInterior";
            this.radInterior.Size = new System.Drawing.Size(81, 17);
            this.radInterior.TabIndex = 7;
            this.radInterior.TabStop = true;
            this.radInterior.Text = "Interior Only";
            this.radInterior.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(708, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 24);
            this.label9.TabIndex = 7;
            this.label9.Text = "Total Amount";
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.Transparent;
            this.btnEnter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.Location = new System.Drawing.Point(16, 677);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 8;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.BtnEnter_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(867, 677);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // redOutput
            // 
            this.redOutput.Location = new System.Drawing.Point(606, 101);
            this.redOutput.Name = "redOutput";
            this.redOutput.Size = new System.Drawing.Size(317, 549);
            this.redOutput.TabIndex = 10;
            this.redOutput.Text = "";
            // 
            // RegisteredClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(976, 712);
            this.Controls.Add(this.redOutput);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "RegisteredClients";
            this.Text = "RegisteredClients";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnCredDone;
        private System.Windows.Forms.TextBox txtCredAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtAppNum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkAirFil;
        private System.Windows.Forms.CheckBox chkGrease;
        private System.Windows.Forms.CheckBox chkOilFil;
        private System.Windows.Forms.CheckBox chkEngOil;
        private System.Windows.Forms.CheckBox chkTurning;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAppEnter;
        private System.Windows.Forms.RadioButton radBoth;
        private System.Windows.Forms.RadioButton radExterior;
        private System.Windows.Forms.RadioButton radInterior;
        private System.Windows.Forms.RichTextBox redOutput;
    }
}