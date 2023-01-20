using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RecordKeeperBizObjects;
using CPUFramework;

namespace RecordKeeperWinForms
{
    public partial class frmMain : Form
    {
        int numtriesconnect = 0;
        public frmMain()    
        {
            InitializeComponent();

            btnConnect.Click += BtnConnect_Click;
            btnNewPresident.Click += BtnNewPresident_Click;

            gPresidentList.CellDoubleClick += GPresidentList_CellDoubleClick;
            DataUtility.SetSQLExpressConnectionString("RecordKeeperDB");

        }
        private void CreateNewPresident()
        {
            frmPresidentDetail f = new frmPresidentDetail();
            f.ShowForm(0);
        }
       
       
        private void Connect()
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                DataUtility.SetSQLExpressConnectionString("RecordKeeperDB");
                numtriesconnect = 0;
                BindForm();
            }
            catch (SqlException ex) when (ex.Message.StartsWith("Login failed for user"))
            {
                numtriesconnect ++;
                if (numtriesconnect < 3)
                {
                    MessageBox.Show("invalid username and password. you have  " + (3 - numtriesconnect).ToString() + "left to try");
                }
                else
                {
                    MessageBox.Show("bye");
                    Application.Exit();
                }
            }
            
            catch (SqlException ex)
            {
                //login failed for user 
                MessageBox.Show("unable to connect fix the server and database name info and try again"+ Environment.NewLine + ex.Message +  "RecordKeeper");
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        //public object Grecordsummary { get; private set; }

        private void BindForm() 
        {
            grecordsummary.DataSource = DataService.GetUSGovRecordSummary();
            gPartyList.DataSource = DataService.GetPartyList();
            gPresidentList.DataSource = DataService.GetPresidentList();

            this.FormatGrid(grecordsummary);
            this.FormatGrid(gPartyList, "PartyId");
            this.FormatGrid(gPresidentList, "PresidentId");
        }
        private void FormatGrid(DataGridView gridobj, string PrimaryKeyFieldName = "")
        {
            gridobj.ReadOnly = true;
            gridobj.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridobj.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gridobj.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridobj.RowHeadersWidth = 25;
            gridobj.AllowUserToAddRows = false;
            if(PrimaryKeyFieldName != "")
            { gridobj.Columns[PrimaryKeyFieldName].Visible = false;
            }
        }
        private void GPresidentList_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            int id = (int)gPresidentList.Rows[e.RowIndex].Cells["PresidentId"].Value;
            frmPresidentDetail f = new frmPresidentDetail();
            f.ShowForm(id);
        }
        private void BtnNewPresident_Click(object? sender, EventArgs e)
        {
            CreateNewPresident();
        }
        private void BtnConnect_Click(object? sender, EventArgs e)
        {
            Connect();
        }
    }
}
