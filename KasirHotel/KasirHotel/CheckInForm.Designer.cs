namespace KasirHotel
{
    partial class CheckInForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimeCheckin = new System.Windows.Forms.DateTimePicker();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.comboBoxRoom = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimeCheckout = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.labelDeposit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHECK IN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Room";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Check in";
            // 
            // dateTimeCheckin
            // 
            this.dateTimeCheckin.CustomFormat = "";
            this.dateTimeCheckin.Location = new System.Drawing.Point(101, 187);
            this.dateTimeCheckin.Name = "dateTimeCheckin";
            this.dateTimeCheckin.Size = new System.Drawing.Size(145, 20);
            this.dateTimeCheckin.TabIndex = 20;
            this.dateTimeCheckin.ValueChanged += new System.EventHandler(this.dateTimeCheckin_ValueChanged);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(101, 135);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(353, 20);
            this.textBoxAddress.TabIndex = 18;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(354, 88);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(100, 20);
            this.textBoxPhone.TabIndex = 17;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(101, 88);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(192, 20);
            this.textBoxName.TabIndex = 16;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(140, 292);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(100, 40);
            this.buttonSubmit.TabIndex = 22;
            this.buttonSubmit.Text = "SUBMIT";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(258, 292);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(100, 40);
            this.buttonClear.TabIndex = 23;
            this.buttonClear.Text = "CLEAR";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // comboBoxRoom
            // 
            this.comboBoxRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoom.FormattingEnabled = true;
            this.comboBoxRoom.Location = new System.Drawing.Point(354, 186);
            this.comboBoxRoom.Name = "comboBoxRoom";
            this.comboBoxRoom.Size = new System.Drawing.Size(100, 21);
            this.comboBoxRoom.TabIndex = 24;
            this.comboBoxRoom.Click += new System.EventHandler(this.comboBoxRoom_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Check out";
            // 
            // dateTimeCheckout
            // 
            this.dateTimeCheckout.Location = new System.Drawing.Point(101, 235);
            this.dateTimeCheckout.Name = "dateTimeCheckout";
            this.dateTimeCheckout.Size = new System.Drawing.Size(145, 20);
            this.dateTimeCheckout.TabIndex = 21;
            this.dateTimeCheckout.ValueChanged += new System.EventHandler(this.dateTimeCheckout_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(271, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Deposit (IDR) :";
            // 
            // labelDeposit
            // 
            this.labelDeposit.AutoSize = true;
            this.labelDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeposit.Location = new System.Drawing.Point(350, 236);
            this.labelDeposit.Name = "labelDeposit";
            this.labelDeposit.Size = new System.Drawing.Size(19, 20);
            this.labelDeposit.TabIndex = 26;
            this.labelDeposit.Text = "0";
            // 
            // CheckInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 364);
            this.Controls.Add(this.labelDeposit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxRoom);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.dateTimeCheckout);
            this.Controls.Add(this.dateTimeCheckin);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CheckInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHECK IN";
            this.Load += new System.EventHandler(this.CheckInForm_Load);
            this.Shown += new System.EventHandler(this.CheckInForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimeCheckin;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.ComboBox comboBoxRoom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimeCheckout;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelDeposit;
    }
}