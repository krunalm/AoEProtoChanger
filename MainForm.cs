using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;

namespace AoEProtoChanger
{
    public partial class MainForm : Form
    {
        string title = "AoE 3 Proto Changer";

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            txtPopCount.Text = "1";
            openProtoFile.FileName = "";
            openProtoYFile.FileName = "";

            if (IsAdministrator())
            {
                title = "AoE 3 Proto Changer (Administrator)";
            }

            this.Text = title;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static bool IsAdministrator()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        private void btnBrowseProto_Click(object sender, EventArgs e)
        {
            if (openProtoFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtProtoPath.Text = openProtoFile.FileName;
            }
        }

        private void btnBrowseProtoy_Click(object sender, EventArgs e)
        {
            if (openProtoYFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtProtoyPath.Text = openProtoYFile.FileName;
            }
        }

        private void btnUpdateFiles_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProtoPath.Text))
            {
                MessageBox.Show("Select Proto.xml file.", title);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtProtoyPath.Text))
            {
                MessageBox.Show("Select Protoy.xml file.", title);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPopCount.Text))
            {
                MessageBox.Show("Enter Population Count Multiplier.", title);
                return;
            }

            int popCout;
            bool isNumeric = int.TryParse(txtPopCount.Text, out popCout);
            if (!isNumeric)
            {
                MessageBox.Show("Population Count Multiplier must be a number.", title);
                return;
            }

            try
            {
                DataSet dsProto = new DataSet();
                dsProto.ReadXml(txtProtoPath.Text);

                DataSet dsProtoY = new DataSet();
                dsProtoY.ReadXml(txtProtoyPath.Text);

                UpdateDataSet(dsProto, popCout);
                UpdateDataSet(dsProtoY, popCout);

                dsProto.WriteXml("test-proto.xml");
                dsProtoY.WriteXml("test-proto-y.xml");

                MessageBox.Show("XML files updated successfully.", title);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.ToString(), title);
                return;
            }
        }

        private void UpdateDataSet(DataSet ds, int popCount)
        {
            if (ds.Tables.Contains("Unit") && ds.Tables["Unit"].Columns.Contains("PopulationCount"))
            {
                foreach (DataRow dr in ds.Tables["Unit"].Rows)
                {
                    dr["PopulationCount"] = dr["PopulationCount"] != System.DBNull.Value ? (Convert.ToInt32(dr["PopulationCount"]) * popCount) : dr["PopulationCount"];

                    if (ds.Tables["Unit"].Columns.Contains("PopulationCapAddition"))
                    {
                        dr["PopulationCapAddition"] = dr["PopulationCapAddition"] != System.DBNull.Value ? (Convert.ToInt32(dr["PopulationCapAddition"]) * popCount) : dr["PopulationCapAddition"];
                    }
                }
            }
        }
    }
}
