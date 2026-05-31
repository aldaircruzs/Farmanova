using Farmano.Presenters;
using Farmano.Views;
using System;
using System.Windows.Forms;

namespace Farmano
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();

            Application.SetCompatibleTextRenderingDefault(false);

            LoginForm view =
            new LoginForm();

            LoginPresenter presenter =
            new LoginPresenter(view);

            Application.Run(view);
        }
    }
}