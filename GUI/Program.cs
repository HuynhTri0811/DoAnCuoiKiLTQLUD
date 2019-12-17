using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO.HT;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.Linq;
namespace GUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //DataContextDataContext DB = new DataContextDataContext();
            //try
            //{
            //    DB.Connection.Open();
            //}
            //catch (Exception ex)
            //{
            //    DialogResult dialog = new DialogResult();
            //    dialog = MessageBox.Show("Không thể kết nối đến database ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    if (dialog == DialogResult.OK)
            //    {
            //        Environment.Exit(1);
            //    }
            //    Environment.Exit(1);

            //}
            //DB.Connection.Close();
            Application.Run(new LoginForm());
        }
    }
}
