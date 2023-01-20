namespace RecordKeeperWinForms
{
    partial class frmMain
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
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.grecordsummary = new System.Windows.Forms.DataGridView();
            this.gPartyList = new System.Windows.Forms.DataGridView();
            this.gPresidentList = new System.Windows.Forms.DataGridView();
            this.tblConnection = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtDB = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnNewPresident = new System.Windows.Forms.Button();
            this.tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grecordsummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPartyList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPresidentList)).BeginInit();
            this.tblConnection.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.Controls.Add(this.grecordsummary, 0, 1);
            this.tblMain.Controls.Add(this.gPartyList, 1, 1);
            this.tblMain.Controls.Add(this.gPresidentList, 0, 2);
            this.tblMain.Controls.Add(this.tblConnection, 0, 0);
            this.tblMain.Controls.Add(this.btnNewPresident, 1, 2);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 3;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.11111F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.11111F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tblMain.Size = new System.Drawing.Size(800, 450);
            this.tblMain.TabIndex = 0;
            // 
            // grecordsummary
            // 
            this.grecordsummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grecordsummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grecordsummary.Location = new System.Drawing.Point(3, 71);
            this.grecordsummary.Name = "grecordsummary";
            this.grecordsummary.RowHeadersWidth = 51;
            this.grecordsummary.RowTemplate.Height = 29;
            this.grecordsummary.Size = new System.Drawing.Size(394, 170);
            this.grecordsummary.TabIndex = 0;
            // 
            // gPartyList
            // 
            this.gPartyList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gPartyList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gPartyList.Location = new System.Drawing.Point(403, 71);
            this.gPartyList.Name = "gPartyList";
            this.gPartyList.RowHeadersWidth = 51;
            this.gPartyList.RowTemplate.Height = 29;
            this.gPartyList.Size = new System.Drawing.Size(394, 170);
            this.gPartyList.TabIndex = 1;
            // 
            // gPresidentList
            // 
            this.gPresidentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gPresidentList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gPresidentList.Location = new System.Drawing.Point(3, 247);
            this.gPresidentList.Name = "gPresidentList";
            this.gPresidentList.RowHeadersWidth = 51;
            this.gPresidentList.RowTemplate.Height = 29;
            this.gPresidentList.Size = new System.Drawing.Size(394, 200);
            this.gPresidentList.TabIndex = 2;
            // 
            // tblConnection
            // 
            this.tblConnection.ColumnCount = 5;
            this.tblMain.SetColumnSpan(this.tblConnection, 2);
            this.tblConnection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblConnection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblConnection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblConnection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblConnection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblConnection.Controls.Add(this.label1, 0, 0);
            this.tblConnection.Controls.Add(this.label2, 1, 0);
            this.tblConnection.Controls.Add(this.label3, 2, 0);
            this.tblConnection.Controls.Add(this.label4, 3, 0);
            this.tblConnection.Controls.Add(this.txtServer, 0, 1);
            this.tblConnection.Controls.Add(this.txtDB, 1, 1);
            this.tblConnection.Controls.Add(this.txtusername, 2, 1);
            this.tblConnection.Controls.Add(this.txtpassword, 3, 1);
            this.tblConnection.Controls.Add(this.btnConnect, 4, 1);
            this.tblConnection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblConnection.Location = new System.Drawing.Point(3, 3);
            this.tblConnection.Name = "tblConnection";
            this.tblConnection.RowCount = 2;
            this.tblConnection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblConnection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblConnection.Size = new System.Drawing.Size(794, 62);
            this.tblConnection.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Database";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "UserName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(477, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // txtServer
            // 
            this.txtServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtServer.Location = new System.Drawing.Point(3, 34);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(152, 27);
            this.txtServer.TabIndex = 4;
            // 
            // txtDB
            // 
            this.txtDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDB.Location = new System.Drawing.Point(161, 34);
            this.txtDB.Name = "txtDB";
            this.txtDB.Size = new System.Drawing.Size(152, 27);
            this.txtDB.TabIndex = 5;
            // 
            // txtusername
            // 
            this.txtusername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtusername.Location = new System.Drawing.Point(319, 34);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(152, 27);
            this.txtusername.TabIndex = 6;
            // 
            // txtpassword
            // 
            this.txtpassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtpassword.Location = new System.Drawing.Point(477, 34);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(152, 27);
            this.txtpassword.TabIndex = 7;
            // 
            // btnConnect
            // 
            this.btnConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConnect.Location = new System.Drawing.Point(635, 34);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(156, 25);
            this.btnConnect.TabIndex = 8;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // btnNewPresident
            // 
            this.btnNewPresident.AutoSize = true;
            this.btnNewPresident.Location = new System.Drawing.Point(403, 247);
            this.btnNewPresident.Name = "btnNewPresident";
            this.btnNewPresident.Size = new System.Drawing.Size(114, 30);
            this.btnNewPresident.TabIndex = 4;
            this.btnNewPresident.Text = "New President";
            this.btnNewPresident.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tblMain);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grecordsummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPartyList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPresidentList)).EndInit();
            this.tblConnection.ResumeLayout(false);
            this.tblConnection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblMain;
        private DataGridView grecordsummary;
        private DataGridView gPartyList;
        private DataGridView gPresidentList;
        private TableLayoutPanel tblConnection;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtServer;
        private TextBox txtDB;
        private TextBox txtusername;
        private TextBox txtpassword;
        private Button btnConnect;
        private Button btnNewPresident;
    }
}