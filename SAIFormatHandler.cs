using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace NGSAIWriter
{
    class SAIFormatHandler
    {
        int entry, sourcetype, 
            eventtype, eventparam1, eventparam2, eventparam3, eventparam4, eventparam5, 
            actiontype, actionparam1, actionparam2, actionparam3, actionparam4, actionparam5, actionparam6,
            targettype, targetparam1, targetparam2, targetparam3;

        string comment;

        Util util = new Util();

        public int Entry { get => entry; set => entry = value; }
        public int Sourcetype { get => sourcetype; set => sourcetype = value; }
        public int Eventtype { get => eventtype; set => eventtype = value; }
        public int Eventparam1 { get => eventparam1; set => eventparam1 = value; }
        public int Eventparam2 { get => eventparam2; set => eventparam2 = value; }
        public int Eventparam3 { get => eventparam3; set => eventparam3 = value; }
        public int Eventparam4 { get => eventparam4; set => eventparam4 = value; }
        public int Eventparam5 { get => eventparam5; set => eventparam5 = value; }
        public int Actiontype { get => actiontype; set => actiontype = value; }
        public int Actionparam1 { get => actionparam1; set => actionparam1 = value; }
        public int Actionparam2 { get => actionparam2; set => actionparam2 = value; }
        public int Actionparam3 { get => actionparam3; set => actionparam3 = value; }
        public int Actionparam4 { get => actionparam4; set => actionparam4 = value; }
        public int Actionparam5 { get => actionparam5; set => actionparam5 = value; }
        public int Actionparam6 { get => actionparam6; set => actionparam6 = value; }
        public int Targettype { get => targettype; set => targettype = value; }
        public int Targetparam1 { get => targetparam1; set => targetparam1 = value; }
        public int Targetparam2 { get => targetparam2; set => targetparam2 = value; }
        public int Targetparam3 { get => targetparam3; set => targetparam3 = value; }
        public string Comment { get => comment; set => comment = value; }

        public string GenerateQuery(bool SaiEnabled, DataTable contentTable, CreatureData creature, DataTable schema)
        {
            string query = string.Format("-- {0} ({1})", creature.Name, creature.Entry);
            string deleteQuery = "";

            if (contentTable.Rows.Count > 1)
            {
                deleteQuery = string.Format("DELETE FROM `smart_scripts` WHERE `entryorguid` = {0} AND `id` IN (", creature.Entry);

                foreach (DataRow row in contentTable.Rows)
                {
                    deleteQuery += "" + row[1].ToString() + "";

                    if (contentTable.Rows.IndexOf(row) != contentTable.Rows.Count - 1)
                        deleteQuery += ", ";
                }

                deleteQuery += ");";
            }
            else
                deleteQuery = string.Format("DELETE FROM `smart_scripts` WHERE `entryorguid` = {0} AND `id` = {1};", creature.Entry, contentTable.Rows[0]["id"].ToString());

            if (!SaiEnabled)
                util.AppendLine(ref query, string.Format("UPDATE `creature_template` SET `AIName` = 'SmartAI' WHERE `entry` = {0};", creature.Entry));

            util.AppendLine(ref query, deleteQuery);

            util.AppendLine(ref query, "INSERT INTO `smart_scripts` (");

            foreach (DataRow row in schema.Rows)
            {
                query += "`" + row[3].ToString() + "`";

                if (schema.Rows.IndexOf(row) != schema.Rows.Count-1)
                    query += ", ";
            }

            query += ") VALUES ";

            /*
             * 0 - entryorguid
             * 1 - id
             * 2 - event_type
             * 3 - event_flags *
             * 4 - event_param1
             * 5 - event_param2
             * 6 - event_param3
             * 7 - event_param4
             * 8 - event_param5
             * 9 - action_type
             * 10 - action_param1
             * 11 - action_param2
             * 12 - action_param3
             * 13 - action_param4
             * 14 - action_param5
             * 15 - action_param6
             * 16 - target_type
             * 17 - target_param1
             * 18 - target_param2
             * 19 - target_param3
             * 20 - comment */

            foreach (DataRow row in contentTable.Rows)
            {
                util.AppendLine(ref query, string.Format("({0}, 0, {1}, 0, {2}, 0, 100, {3}, {4}, {5}, {6}, {7}, {8}, {9}," +
                    " {10}, {11}, {12}, {13}, {14}, {15}, {16}, {17}, {18}, {19}, 0, 0, 0, 0, 0, '{20}')" + (contentTable.Rows.IndexOf(row) != contentTable.Rows.Count - 1 ? "," : ";"),
                    row["entryorguid"],
                    row["id"],
                    row["event_type"],
                    row["event_flags"],
                    row["event_param1"],
                    row["event_param2"],
                    row["event_param3"],
                    row["event_param4"],
                    row["event_param5"],
                    row["action_type"],
                    row["action_param1"],
                    row["action_param2"],
                    row["action_param3"],
                    row["action_param4"],
                    row["action_param5"],
                    row["action_param6"],
                    row["target_type"],
                    row["target_param1"],
                    row["target_param2"],
                    row["target_param3"],
                    //row["target_param4"],
                    row["comment"]));

            }

            return query;
        }
    }
}
