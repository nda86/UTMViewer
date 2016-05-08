using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTM_Viewer_2
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

            MainForm view = new MainForm();
            Viewer1 modelViewer1 = new Viewer1();
            Viewer1Presenter presenter = new Viewer1Presenter(view, modelViewer1);

            Resend modelResend = new Resend();
            ResendPresenter resendPresender = new ResendPresenter(view, modelResend);
            Application.Run(view);
        }
    }
}
