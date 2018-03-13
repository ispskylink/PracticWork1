namespace PracticWork1
{
    partial class Form1
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
            this.tbServer = new System.Windows.Forms.TextBox();
            this.tbDBName = new System.Windows.Forms.TextBox();
            this.bConnect = new System.Windows.Forms.Button();
            this.bDisconnect = new System.Windows.Forms.Button();
            this.bGetData = new System.Windows.Forms.Button();
            this.bInsert = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tbCountry = new System.Windows.Forms.TextBox();
            this.lbView = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DB Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name Surname";
            // 
            // tbServer
            // 
            this.tbServer.Location = new System.Drawing.Point(71, 13);
            this.tbServer.Name = "tbServer";
            this.tbServer.Size = new System.Drawing.Size(171, 20);
            this.tbServer.TabIndex = 3;
            // 
            // tbDBName
            // 
            this.tbDBName.Location = new System.Drawing.Point(71, 45);
            this.tbDBName.Name = "tbDBName";
            this.tbDBName.Size = new System.Drawing.Size(171, 20);
            this.tbDBName.TabIndex = 4;
            // 
            // bConnect
            // 
            this.bConnect.Location = new System.Drawing.Point(262, 9);
            this.bConnect.Name = "bConnect";
            this.bConnect.Size = new System.Drawing.Size(75, 23);
            this.bConnect.TabIndex = 5;
            this.bConnect.Text = "Connect";
            this.bConnect.UseVisualStyleBackColor = true;
            this.bConnect.Click += new System.EventHandler(this.bConnect_Click);
            // 
            // bDisconnect
            // 
            this.bDisconnect.Location = new System.Drawing.Point(365, 9);
            this.bDisconnect.Name = "bDisconnect";
            this.bDisconnect.Size = new System.Drawing.Size(75, 23);
            this.bDisconnect.TabIndex = 6;
            this.bDisconnect.Text = "Disconnect";
            this.bDisconnect.UseVisualStyleBackColor = true;
            this.bDisconnect.Click += new System.EventHandler(this.bDisconnect_Click);
            // 
            // bGetData
            // 
            this.bGetData.Location = new System.Drawing.Point(262, 45);
            this.bGetData.Name = "bGetData";
            this.bGetData.Size = new System.Drawing.Size(75, 23);
            this.bGetData.TabIndex = 8;
            this.bGetData.Text = "Get Data";
            this.bGetData.UseVisualStyleBackColor = true;
            this.bGetData.Click += new System.EventHandler(this.bGetData_Click);
            // 
            // bInsert
            // 
            this.bInsert.Location = new System.Drawing.Point(365, 94);
            this.bInsert.Name = "bInsert";
            this.bInsert.Size = new System.Drawing.Size(75, 23);
            this.bInsert.TabIndex = 9;
            this.bInsert.Text = "Insert";
            this.bInsert.UseVisualStyleBackColor = true;
            this.bInsert.Click += new System.EventHandler(this.bInsert_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(97, 91);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(88, 20);
            this.tbName.TabIndex = 10;
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(191, 91);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(88, 20);
            this.tbSurname.TabIndex = 11;
            // 
            // tbCountry
            // 
            this.tbCountry.Location = new System.Drawing.Point(285, 91);
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.Size = new System.Drawing.Size(52, 20);
            this.tbCountry.TabIndex = 12;
            // 
            // lbView
            // 
            this.lbView.FormattingEnabled = true;
            this.lbView.Location = new System.Drawing.Point(15, 158);
            this.lbView.Name = "lbView";
            this.lbView.Size = new System.Drawing.Size(424, 212);
            this.lbView.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 395);
            this.Controls.Add(this.lbView);
            this.Controls.Add(this.tbCountry);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.bInsert);
            this.Controls.Add(this.bGetData);
            this.Controls.Add(this.bDisconnect);
            this.Controls.Add(this.bConnect);
            this.Controls.Add(this.tbDBName);
            this.Controls.Add(this.tbServer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbServer;
        private System.Windows.Forms.TextBox tbDBName;
        private System.Windows.Forms.Button bConnect;
        private System.Windows.Forms.Button bDisconnect;
        private System.Windows.Forms.Button bGetData;
        private System.Windows.Forms.Button bInsert;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.TextBox tbCountry;
        private System.Windows.Forms.ListBox lbView;
    }
}

