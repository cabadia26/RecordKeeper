namespace RecordKeeperWinForms
{
    partial class frmPresidentDetail
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
            this.lblParty = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblDateBorn = new System.Windows.Forms.Label();
            this.lblDateDied = new System.Windows.Forms.Label();
            this.lblTermStart = new System.Windows.Forms.Label();
            this.lblTermEnd = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtDateBorn = new System.Windows.Forms.TextBox();
            this.txtDateDied = new System.Windows.Forms.TextBox();
            this.txtTermStart = new System.Windows.Forms.TextBox();
            this.txtTermEnd = new System.Windows.Forms.TextBox();
            this.lblExecutiveOrder = new System.Windows.Forms.Label();
            this.gExecutiveOrders = new System.Windows.Forms.DataGridView();
            this.tblButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lstParty = new System.Windows.Forms.ComboBox();
            this.tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gExecutiveOrders)).BeginInit();
            this.tblButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 3;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblMain.Controls.Add(this.lblParty, 0, 0);
            this.tblMain.Controls.Add(this.lblNumber, 0, 1);
            this.tblMain.Controls.Add(this.lblFirstName, 0, 2);
            this.tblMain.Controls.Add(this.lblLastName, 0, 3);
            this.tblMain.Controls.Add(this.lblDateBorn, 0, 4);
            this.tblMain.Controls.Add(this.lblDateDied, 0, 5);
            this.tblMain.Controls.Add(this.lblTermStart, 0, 6);
            this.tblMain.Controls.Add(this.lblTermEnd, 0, 7);
            this.tblMain.Controls.Add(this.txtNum, 1, 1);
            this.tblMain.Controls.Add(this.txtFirstName, 1, 2);
            this.tblMain.Controls.Add(this.txtLastName, 1, 3);
            this.tblMain.Controls.Add(this.txtDateBorn, 1, 4);
            this.tblMain.Controls.Add(this.txtDateDied, 1, 5);
            this.tblMain.Controls.Add(this.txtTermStart, 1, 6);
            this.tblMain.Controls.Add(this.txtTermEnd, 1, 7);
            this.tblMain.Controls.Add(this.lblExecutiveOrder, 2, 0);
            this.tblMain.Controls.Add(this.gExecutiveOrders, 2, 1);
            this.tblMain.Controls.Add(this.tblButtons, 1, 8);
            this.tblMain.Controls.Add(this.lstParty, 1, 0);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Margin = new System.Windows.Forms.Padding(5);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 9;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Size = new System.Drawing.Size(1008, 501);
            this.tblMain.TabIndex = 0;
            // 
            // lblParty
            // 
            this.lblParty.AutoSize = true;
            this.lblParty.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblParty.Location = new System.Drawing.Point(3, 0);
            this.lblParty.Name = "lblParty";
            this.lblParty.Size = new System.Drawing.Size(65, 31);
            this.lblParty.TabIndex = 0;
            this.lblParty.Text = "Party";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumber.Location = new System.Drawing.Point(3, 45);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(98, 31);
            this.lblNumber.TabIndex = 1;
            this.lblNumber.Text = "Number";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFirstName.Location = new System.Drawing.Point(3, 93);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(124, 31);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLastName.Location = new System.Drawing.Point(3, 141);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(122, 31);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last Name";
            // 
            // lblDateBorn
            // 
            this.lblDateBorn.AutoSize = true;
            this.lblDateBorn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDateBorn.Location = new System.Drawing.Point(3, 189);
            this.lblDateBorn.Name = "lblDateBorn";
            this.lblDateBorn.Size = new System.Drawing.Size(115, 31);
            this.lblDateBorn.TabIndex = 4;
            this.lblDateBorn.Text = "Date Born";
            // 
            // lblDateDied
            // 
            this.lblDateDied.AutoSize = true;
            this.lblDateDied.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDateDied.Location = new System.Drawing.Point(3, 237);
            this.lblDateDied.Name = "lblDateDied";
            this.lblDateDied.Size = new System.Drawing.Size(116, 31);
            this.lblDateDied.TabIndex = 5;
            this.lblDateDied.Text = "Date Died";
            // 
            // lblTermStart
            // 
            this.lblTermStart.AutoSize = true;
            this.lblTermStart.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTermStart.Location = new System.Drawing.Point(3, 285);
            this.lblTermStart.Name = "lblTermStart";
            this.lblTermStart.Size = new System.Drawing.Size(117, 31);
            this.lblTermStart.TabIndex = 7;
            this.lblTermStart.Text = "Term Start";
            // 
            // lblTermEnd
            // 
            this.lblTermEnd.AutoSize = true;
            this.lblTermEnd.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTermEnd.Location = new System.Drawing.Point(3, 333);
            this.lblTermEnd.Name = "lblTermEnd";
            this.lblTermEnd.Size = new System.Drawing.Size(109, 31);
            this.lblTermEnd.TabIndex = 8;
            this.lblTermEnd.Text = "Term End";
            // 
            // txtNum
            // 
            this.txtNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNum.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNum.Location = new System.Drawing.Point(257, 50);
            this.txtNum.Margin = new System.Windows.Forms.Padding(5);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(494, 38);
            this.txtNum.TabIndex = 10;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFirstName.Location = new System.Drawing.Point(257, 98);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(5);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(494, 38);
            this.txtFirstName.TabIndex = 11;
            // 
            // txtLastName
            // 
            this.txtLastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLastName.Location = new System.Drawing.Point(257, 146);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(5);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(494, 38);
            this.txtLastName.TabIndex = 12;
            // 
            // txtDateBorn
            // 
            this.txtDateBorn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDateBorn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDateBorn.Location = new System.Drawing.Point(257, 194);
            this.txtDateBorn.Margin = new System.Windows.Forms.Padding(5);
            this.txtDateBorn.Name = "txtDateBorn";
            this.txtDateBorn.Size = new System.Drawing.Size(494, 38);
            this.txtDateBorn.TabIndex = 13;
            // 
            // txtDateDied
            // 
            this.txtDateDied.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDateDied.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDateDied.Location = new System.Drawing.Point(257, 242);
            this.txtDateDied.Margin = new System.Windows.Forms.Padding(5);
            this.txtDateDied.Name = "txtDateDied";
            this.txtDateDied.Size = new System.Drawing.Size(494, 38);
            this.txtDateDied.TabIndex = 14;
            // 
            // txtTermStart
            // 
            this.txtTermStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTermStart.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTermStart.Location = new System.Drawing.Point(257, 290);
            this.txtTermStart.Margin = new System.Windows.Forms.Padding(5);
            this.txtTermStart.Name = "txtTermStart";
            this.txtTermStart.Size = new System.Drawing.Size(494, 38);
            this.txtTermStart.TabIndex = 15;
            // 
            // txtTermEnd
            // 
            this.txtTermEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTermEnd.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTermEnd.Location = new System.Drawing.Point(257, 338);
            this.txtTermEnd.Margin = new System.Windows.Forms.Padding(5);
            this.txtTermEnd.Name = "txtTermEnd";
            this.txtTermEnd.Size = new System.Drawing.Size(494, 38);
            this.txtTermEnd.TabIndex = 16;
            // 
            // lblExecutiveOrder
            // 
            this.lblExecutiveOrder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblExecutiveOrder.AutoSize = true;
            this.lblExecutiveOrder.Location = new System.Drawing.Point(789, 0);
            this.lblExecutiveOrder.Name = "lblExecutiveOrder";
            this.lblExecutiveOrder.Size = new System.Drawing.Size(185, 31);
            this.lblExecutiveOrder.TabIndex = 17;
            this.lblExecutiveOrder.Text = "Executive Orders";
            // 
            // gExecutiveOrders
            // 
            this.gExecutiveOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gExecutiveOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gExecutiveOrders.Location = new System.Drawing.Point(759, 48);
            this.gExecutiveOrders.Name = "gExecutiveOrders";
            this.gExecutiveOrders.RowHeadersWidth = 51;
            this.tblMain.SetRowSpan(this.gExecutiveOrders, 7);
            this.gExecutiveOrders.RowTemplate.Height = 29;
            this.gExecutiveOrders.Size = new System.Drawing.Size(246, 338);
            this.gExecutiveOrders.TabIndex = 18;
            // 
            // tblButtons
            // 
            this.tblButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tblButtons.AutoSize = true;
            this.tblButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblButtons.ColumnCount = 2;
            this.tblMain.SetColumnSpan(this.tblButtons, 2);
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblButtons.Controls.Add(this.btnSave, 0, 0);
            this.tblButtons.Controls.Add(this.btnDelete, 1, 0);
            this.tblButtons.Location = new System.Drawing.Point(805, 392);
            this.tblButtons.Name = "tblButtons";
            this.tblButtons.RowCount = 1;
            this.tblButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblButtons.Size = new System.Drawing.Size(200, 47);
            this.tblButtons.TabIndex = 19;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.AutoSize = true;
            this.btnSave.Location = new System.Drawing.Point(3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 41);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.AutoSize = true;
            this.btnDelete.Location = new System.Drawing.Point(103, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 41);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // lstParty
            // 
            this.lstParty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstParty.FormattingEnabled = true;
            this.lstParty.Location = new System.Drawing.Point(255, 3);
            this.lstParty.Name = "lstParty";
            this.lstParty.Size = new System.Drawing.Size(498, 39);
            this.lstParty.TabIndex = 20;
            // 
            // frmPresidentDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 501);
            this.Controls.Add(this.tblMain);
            this.Name = "frmPresidentDetail";
            this.Text = "President Detail";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gExecutiveOrders)).EndInit();
            this.tblButtons.ResumeLayout(false);
            this.tblButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblParty;
        private Label lblNumber;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblDateBorn;
        private Label lblDateDied;
        private Label lblTermStart;
        private Label lblTermEnd;
        private TextBox txtNum;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtDateBorn;
        private TextBox txtDateDied;
        private TextBox txtTermStart;
        private TextBox txtTermEnd;
        private Label lblExecutiveOrder;
        private DataGridView gExecutiveOrders;
        private TableLayoutPanel tblButtons;
        private Button btnSave;
        private Button btnDelete;
        private ComboBox lstParty;
    }
}