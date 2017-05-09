using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QlkhNamespace
{
    class Utils
    {
        public static string TITLE_ERROR = "Lỗi";
        public static string TITLE_INFO = "Thông báo";


        public static void showOkDialog(string title, string message)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(message, title, buttons);
        }
    }
}
