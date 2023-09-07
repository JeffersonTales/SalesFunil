using SalesFunil.desktop._Repositories;
using SalesFunil.desktop.Models;
using SalesFunil.desktop.Presenters;
using SalesFunil.desktop.Views;
using System.Configuration;

namespace SalesFunil.desktop {
    internal static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string sqlConnectionString = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;
            
            IPetView view = new PetView();
            IPetRepository repository = new PetRepository(sqlConnectionString);
            new PetPresenter(view, repository);
            Application.Run((Form)view);
        }
    }
}