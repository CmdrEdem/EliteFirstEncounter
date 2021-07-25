using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EliteFirstEncounter.view.database
{
    class Setting : Database
    {
        public static string ReadSetting(string key)
        {
            if (connector == null)
                Connect();

            connector.Open();
            var command = connector.CreateCommand();
            command.CommandText = @"'SELECT value FROM settings WHERE key = $key";
            command.Parameters.AddWithValue("$key", key);

            var result = command.ExecuteReader();

            if (result.Read())
            {
                var returnString = result.GetString(0); ;
                connector.Close();
                return returnString;
            }
            connector.Close();
            return "";

        }

        public static Dictionary<string, string> ReadSettings()
        {
            if (connector == null)
                Connect();

            connector.Open();
            var command = connector.CreateCommand();
            command.CommandText = @"SELECT key, value FROM settings;";

            try
            {
                var result = command.ExecuteReader();

                Dictionary<string, string> settings = new();

                while (result.Read())
                {
                    settings.Add(result.GetString(0), result.GetString(1));
                }
                
                connector.Close();
                return settings;
            }
            catch (Exception ex)
            {
                return null;
            }

            

        }
        public static bool WriteSetting(string key, string value)
        {
            if (connector == null)
            {
                Connect();
            }
            connector.Open();
            var command = connector.CreateCommand();
            command.CommandText = @"UPDATE settings SET value = $value WHERE key = $key";
            command.Parameters.AddWithValue("$key", key);
            command.Parameters.AddWithValue("$value", value);

            var result = command.ExecuteReader();

            if (result.Read())
            {
                connector.Close();
                return true;
            }
            connector.Close();
            return false;

        }
    }
}
