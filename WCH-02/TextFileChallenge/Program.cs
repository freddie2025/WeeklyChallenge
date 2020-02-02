using System;
using System.Windows.Forms;

namespace TextFileChallenge
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
            Application.SetCompatibleTextRenderingDefault(true);

            var repository = new Model.UserCsvRepository(Application.StartupPath);
            var view = new View.ChallengeForm();

            // Poor Man's Dependency Injection/Pure Dependency Injection, Main() is the Composition Root.
            var presenter = new Presenter.ChallengePresenter(view, repository);

            Application.Run(view);
        }
    }
}
