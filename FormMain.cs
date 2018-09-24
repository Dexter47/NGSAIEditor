using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace NGSAIWriter
{
    public partial class FormMain : Form
    {
        DatabaseHandler dbhandler = new DatabaseHandler();
        CreatureData creature = new CreatureData();
        DataTable sqlStorageTable = new DataTable();

        int stashedQueryCounter = 0;

        public FormMain()
        {
            InitializeComponent();
        }

        private void bgw_database_DoWork(object sender, DoWorkEventArgs e)
        {
            Util util = new Util();
            if (!dbhandler.TestDatabaseConnection())
                util.UpdateObject(lbl_messages, () => { dbhandler.PrintExceptionMessage(); });
            else
                util.UpdateObject(lbl_messages, () => { lbl_messages.Text = "Connection successful. Database features enabled."; });

        }

        private void FillConnectionString()
        {
            dbhandler.Host = txt_cs_host.Text;
            dbhandler.User = txt_cs_user.Text;
            dbhandler.Password = txt_cs_password.Text;
            dbhandler.Port = Convert.ToInt32(nud_port.Value);
            dbhandler.Database = txt_cs_database.Text;
        }

        private void btn_cs_connect_Click(object sender, EventArgs e)
        {
            FillConnectionString();
            bgw_database.RunWorkerAsync();
        }

        private void btn_srch_ok_Click(object sender, EventArgs e)
        {
            if (!dbhandler.TestDatabaseConnection())
            {
                MessageBox.Show("You must be connected to a database in order to use this tool.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (sqlStorageTable.Rows.Count > 0)
                if (MessageBox.Show("You have queries in your stash. Searching for another creature will clear them. Continue anyways?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                    return;

            bgw_srch.RunWorkerAsync();
        }

        private void bgw_srch_DoWork(object sender, DoWorkEventArgs e)
        {
            Util util = new Util();
            util.UpdateObject(lbl_messages, () => { lbl_messages.Text = "Searching..."; });
            creature = dbhandler.FetchCreature(Convert.ToInt32(txt_srch_creature.Text));

            if (creature.Entry == 0)
            {
                util.UpdateObject(lbl_messages, () => { lbl_messages.Text = "No creature could be found for the entry " + txt_srch_creature.Text + "."; });
                return;
            }

            util.UpdateObject(lbl_cr_name_i, () => { lbl_cr_name_i.Text = "Creature Name: " + creature.Name; });
            util.UpdateObject(lbl_cr_entry_i, () => { lbl_cr_entry_i.Text = "Creature Entry: " + creature.Entry; });
            util.UpdateObject(lbl_sai_enabled, () => { lbl_sai_enabled.Text = "SAI Enabled: " + creature.SaiEnabled.ToString(); });
            util.UpdateObject(lbl_sai_count, () => { lbl_sai_count.Text = "Lines of SAI Found: " + creature.SaiCount; });
            util.UpdateObject(hplbl_wowhead, () => { hplbl_wowhead.Text = "https://www.wowhead.com/npc=" + creature.Entry; });
            util.UpdateObject(lbl_messages, () => { lbl_messages.Text = "Displaying results."; });
        }

        private void hplbl_wowhead_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(hplbl_wowhead.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormSAIRows sai = new FormSAIRows(dbhandler.GetTableSchema("smart_scripts"), dbhandler.GetSAIForCreature(Convert.ToInt32(txt_srch_creature.Text)));
            sai.Show();
        }

        private void txt_spell_Click(object sender, EventArgs e)
        {
            if (txt_spell.Text.Equals("<SPELL ID>"))
                txt_spell.Clear();

            txt_help.Text = "Insert the spell that your creature will be casting.";
        }

        private void txt_first_cast_min_Click(object sender, EventArgs e)
        {
            if (txt_first_cast_min.Text.Equals("<MIN>"))
                txt_first_cast_min.Clear();

            txt_help.Text = "The first cast of the spell will happen after N miliseconds." +
                " If <MAX> value is specified, it will be cast in a random moment between <MIN> and <MAX>";
        }

        private void txt_first_cast_max_Click(object sender, EventArgs e)
        {
            if (txt_first_cast_max.Text.Equals("<MAX>"))
                txt_first_cast_max.Clear();

            txt_help.Text = "Maximum delay for the first occurrence of the spell.";
        }

        private void txt_repeat_cast_min_Click(object sender, EventArgs e)
        {
            if (txt_repeat_cast_min.Text.Equals("<MIN>"))
                txt_repeat_cast_min.Clear();

            txt_help.Text = "After the first cast of the spell happens, it will happen again after N miliseconds." +
    " If <MAX> value is specified, it will be cast in a random moment between <MIN> and <MAX>";
        }

        private void txt_repeat_cast_max_Click(object sender, EventArgs e)
        {
            if (txt_repeat_cast_max.Text.Equals("<MAX>"))
                txt_repeat_cast_max.Clear();

            txt_help.Text = "Maximum delay for the repeat timer of the spell.";
        }

        private void gb_spells_Enter(object sender, EventArgs e)
        {
            gb_help.Visible = true;
        }

        private void cb_ef_never_repeat_MouseHover(object sender, EventArgs e)
        {
            txt_help.Text = "If checked the spell will be flagged as an one time only event and will never fire a second time.";
        }

        private void cb_targets_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cb_targets.SelectedIndex)
            {
                case 0:
                    txt_help.Text = "The spell will be fired without a target. Use this for AOE spells.";
                    break;
                case 1:
                    txt_help.Text = "The spell will be cast on our creature (e.g buffs, healing spells).";
                    break;
                case 2:
                    txt_help.Text = "The spell will be cast on our victim (unit currently target by the creature).";
                    break;
                case 3:
                    txt_help.Text = "The spell will be cast on the second unit in our threat list (excludes the tank).";
                    break;
                case 4:
                    txt_help.Text = "The spell will be cast on the last unit in our threat last. Lowest threat target.";
                    break;
                case 5:
                    txt_help.Text = "The spell will be cast on a random target in our threat list.";
                    break;
                case 6:
                    txt_help.Text = "The spell will be cast on a random target (excluding the tank).";
                    break;
                case 7:
                    txt_help.Text = "The spell will be cast on a random player within range." + Environment.NewLine +
                        "PARAM 1: Min Distance" + Environment.NewLine + "PARAM 2: Max Distance";
                    break;
                case 8:
                    txt_help.Text = "Closest creature within the range and entry provided." + Environment.NewLine +
                        "PARAM 1: Creature entry " + Environment.NewLine + "PARAM 2: Max Distance" + Environment.NewLine + "PARAM 3: Dead? (0 = false; 1 = true)";
                    break;
                case 9:
                    txt_help.Text = "The spell will be cast on the closest player within range." + Environment.NewLine +
                        "PARAM 1: Max Distance";
                    break;
                case 10:
                    txt_help.Text = "The spell will be cast the closest enemy within range." + Environment.NewLine +
                        "PARAM 1: Max Distance" + Environment.NewLine + "PARAM 2: Player Only? (0 = false; 1 = true)";
                    break;
                case 11:
                    txt_help.Text = "The spell will be cast the closest friendly unit within range." + Environment.NewLine +
                        "PARAM 1: Max Distance" + Environment.NewLine + "PARAM 2: Player Only? (0 = false; 1 = true)";
                    break;
                case 12:
                    txt_help.Text = "The spell will be cast the farthest enemy." + Environment.NewLine +
                        "PARAM 1: Max Distance" + Environment.NewLine + "PARAM 2: Player Only? (0 = false; 1 = true)" + Environment.NewLine + "PARAM 3: In Line of Sight? (0 = false; 1 = true)";
                    break;
                default:
                    txt_help.Text = "Can't help you with this ¯\\_(ツ)_//¯";
                    break;

            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://trinitycore.atlassian.net/wiki/spaces/tc/pages/2130108/smart+scripts");
        }

        private void btn_generateSAI_Click(object sender, EventArgs e)
        {
            // If the creature doesn't have any SAI yet, then it's a new creature
            // Safe for us to start with the counter at 0
            if (sqlStorageTable.Rows.Count == 0 && creature.SaiCount > 0)
                ++creature.SaiCount;

            DataRow row = sqlStorageTable.NewRow();
            row["entryorguid"] = txt_srch_creature.Text;
            row["id"] = creature.SaiCount;
            row["event_flags"] = Convert.ToInt32(cb_ef_never_repeat.Checked);

            row["event_type"] = 0; // Only IC update for now
            row["event_param1"] = Convert.ToInt32(txt_first_cast_min.Text);
            row["event_param2"] = Convert.ToInt32(txt_first_cast_max.Text);
            row["event_param3"] = Convert.ToInt32(txt_repeat_cast_min.Text);
            row["event_param4"] = Convert.ToInt32(txt_repeat_cast_max.Text);
            row["event_param5"] = 0;

            row["action_type"] = 11; // Only spell cast for now
            row["action_param1"] = Convert.ToInt32(txt_spell.Text);
            row["action_param2"] = 0;
            row["action_param3"] = 0;
            row["action_param4"] = 0;
            row["action_param5"] = 0;
            row["action_param6"] = 0;

            // Meh, lazy way out
            string target = new String(cb_targets.Text.Where(Char.IsDigit).ToArray());

            row["target_type"] = Convert.ToInt32(target);
            row["target_param1"] = Convert.ToInt32(txt_tparam1.Text);
            row["target_param2"] = Convert.ToInt32(txt_tparam2.Text);
            row["target_param3"] = Convert.ToInt32(txt_tparam3.Text);
            row["target_param4"] = 0; // Unused for now

            row["comment"] = creature.Name + " - IC - Cast " + txt_spell_name.Text;

            sqlStorageTable.Rows.Add(row);

            // We increase the counter in case we add more rows
            ++creature.SaiCount;

            ++stashedQueryCounter;

            lbl_stashed_queries_counter.Text = "Stashed Queries: " + stashedQueryCounter;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Initialize the SQL Holder table
            sqlStorageTable.Columns.Add("entryorguid", typeof(int));
            sqlStorageTable.Columns.Add("id", typeof(int));
            sqlStorageTable.Columns.Add("event_type", typeof(int));
            sqlStorageTable.Columns.Add("event_flags", typeof(int));
            for (int i = 1; i <= 5; i++)
                sqlStorageTable.Columns.Add("event_param" + i, typeof(int));

            sqlStorageTable.Columns.Add("action_type", typeof(int));

            for (int i = 1; i <= 6; i++)
                sqlStorageTable.Columns.Add("action_param" + i, typeof(int));

            sqlStorageTable.Columns.Add("target_type", typeof(int));

            for (int i = 1; i <= 4; i++)
                sqlStorageTable.Columns.Add("target_param" + i, typeof(int));

            sqlStorageTable.Columns.Add("comment", typeof(string));
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            SAIFormatHandler formatHandler = new SAIFormatHandler();
            FormGenerateSQL fgs = new FormGenerateSQL(formatHandler.GenerateQuery(creature.SaiEnabled, sqlStorageTable, creature, dbhandler.GetTableSchema("smart_scripts")));
            fgs.Show();

            stashedQueryCounter = 0;
            lbl_stashed_queries_counter.Text = "Stashed Queries: " + stashedQueryCounter;
            sqlStorageTable.Rows.Clear();

            lbl_messages.Text = "Done. Queries exported, stash cleared.";
        }

        private void btn_clear_stash_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you wish to clear your stash? All temporary queries will be lost.", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                stashedQueryCounter = 0;
                lbl_stashed_queries_counter.Text = "Stashed Queries: " + stashedQueryCounter;
                sqlStorageTable.Rows.Clear();
                lbl_messages.Text = "Done. Stash cleared.";
            }
        }
    }
}
