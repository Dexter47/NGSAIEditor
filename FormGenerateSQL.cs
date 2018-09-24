using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NGSAIWriter
{
    public partial class FormGenerateSQL : Form
    {
        public FormGenerateSQL(string sql)
        {
            InitializeComponent();
            txt_generatedSQL.Text = sql;
        }

        private void FormGenerateSQL_Load(object sender, EventArgs e)
        {

        }

        private void btn_file_export_Click(object sender, EventArgs e)
        {
            Util util = new Util();
            int counter = 0;

            string counterStr = "0" + counter;

            string path = string.Format(@"{0}\SQL\{1}_{2}_world_custom.sql", Application.StartupPath, util.GetDateString(), counterStr);

            // Create the folder where we'll be saving our SQL
            System.IO.Directory.CreateDirectory(Application.StartupPath + "\\SQL");

            while (File.Exists(path))
            {
                ++counter;

                if (counter < 10)
                    counterStr = "0" + counter;
                else
                    counterStr = counter.ToString();

                path = string.Format(@"{0}\SQL\{1}_{2}_world_custom.sql", Application.StartupPath, util.GetDateString(), counterStr);
            }

            StreamWriter writer = new StreamWriter(path);
            writer.Write(txt_generatedSQL.Text + Environment.NewLine);
            writer.Close();

        }

        private void btn_clipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txt_generatedSQL.Text);
        }
    }
}
