using System;
using System.Configuration;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string serverIP = ConfigurationManager.AppSettings["ServerIPAddress"];
            string defaultConnection = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            Console.WriteLine(serverIP);
            Console.WriteLine(defaultConnection);
            Console.WriteLine();

            var appSettings = ConfigurationManager.AppSettings;

            foreach (var key in appSettings.AllKeys)
            {
                Console.WriteLine($"Key: { key } Value: { appSettings[key] }");
            }

            Console.WriteLine();

            var connectionStrings = ConfigurationManager.ConnectionStrings;

            foreach (ConnectionStringSettings cnn in connectionStrings)
            {
                Console.WriteLine($"Name: { cnn.Name } Value: { cnn.ConnectionString }");
            }

            Console.WriteLine();

            var appConfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var appSettingsSection = appConfig.AppSettings.Settings;

            string newKey = "Professor";
            string newValue = "Fred James";

            if (appSettingsSection[newKey] == null)
            {
                appSettingsSection.Add(newKey, newValue);
            }
            else
            {
                appSettingsSection[newKey].Value = newValue;
            }

            appConfig.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(appConfig.AppSettings.SectionInformation.Name);

            appSettings = ConfigurationManager.AppSettings;

            foreach (var key in appSettings.AllKeys)
            {
                Console.WriteLine($"Key: { key } Value: { appSettings[key] }");
            }
            
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
