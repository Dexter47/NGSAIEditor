using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NGSAIWriter
{
    class Util
    {
        public void UpdateObject(Control ctrl, Action action)
        {
            if (!ctrl.InvokeRequired)
                action();
            else
                ctrl.Invoke(new UpdateObjectHelper(UpdateObject), ctrl, action);
        }

        delegate void UpdateObjectHelper(Control ctrl, Action action);

        public void AppendLine(ref string text, string line)
        {
            text += Environment.NewLine + line;
        }

        public string GetDateString()
        {
            string year = DateTime.Now.Year.ToString();
            string month = DateTime.Now.Month.ToString();
            string day = DateTime.Now.Day.ToString();

            if (Convert.ToInt32(month) < 10)
                month = "0" + month;

            if (Convert.ToInt32(day) < 10)
                day = "0" + day;

            return year + "_" + month + "_" + day;
        }

    }
}
