using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace NGSAIWriter
{
    public partial class FormSAIRows : Form
    {
        DataTable schema = new DataTable();
        DataTable creatureSAITable = new DataTable();
        public FormSAIRows(DataTable schemaTable, DataTable creatureTable)
        {
            InitializeComponent();
            schema = schemaTable;
            creatureSAITable = creatureTable;
        }

        private void FormSAIRows_Load(object sender, EventArgs e)
        {
            foreach (DataRow row in schema.Rows)
            {
                lv_sai.Columns.Add(row[3].ToString(), 100);
                lv_sai_spells.Columns.Add(row[3].ToString(), 100);
            }

            // Display items in the ListView control
            for (int i = 0; i < creatureSAITable.Rows.Count; i++)
            {
                DataRow drow = creatureSAITable.Rows[i];
                ListViewItem lvi = new ListViewItem(drow["entryorguid"].ToString());

                foreach (DataRow row in schema.Rows)
                {
                    // Skip entryorguid, we already use it as header
                    if (row[3].ToString().Equals("entryorguid"))
                        continue;

                    lvi.SubItems.Add(drow[row[3].ToString()].ToString());
                }

                lv_sai.Items.Add(lvi);

                if (Convert.ToInt32(drow["action_type"]) == 11)
                {
                    ListViewItem lviSpells = new ListViewItem(drow["entryorguid"].ToString());

                    foreach (DataRow row in schema.Rows)
                    {
                        // Skip entryorguid, we already use it as header
                        if (row[3].ToString().Equals("entryorguid"))
                            continue;

                        lviSpells.SubItems.Add(drow[row[3].ToString()].ToString());
                    }

                    lv_spells.Items.Add(drow["action_param1"].ToString());

                    lv_sai_spells.Items.Add(lviSpells);
                }
            }
        }

        private void lv_spells_ItemActivate(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.wowhead.com/spell=" + lv_spells.SelectedItems[0].SubItems[0].Text);
        }
    }
}
