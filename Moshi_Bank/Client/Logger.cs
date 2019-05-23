using System;
using MySql.Data.MySqlClient;

namespace Moshi_Bank.Client
{
    public static class Logger
    {
        public class Service
        {
            public static Log FormatLog(MySqlDataReader reader)
            {
                Log l = null;
                while (reader.Read())
                {
                    l = new Client.Log
                    {
                        Description = reader.GetString("Description"),
                        IpAddress = reader.GetString("IpAddress"),
                        MachineName = reader.GetString("MachineName"),
                        Id = reader.GetString("Id"),
                        UserId = reader.GetString("UserId"),
                        GUID = reader.GetString("GUID"),
                        DateStamp = reader["date_stamp"].ToString()
                    };
                }
                reader.Close();
                return l;
            }
        }
        public static Log Log(String desc)
        {
            Log l = new Log();
            l.Description = desc;
            l.GUID = Guid.NewGuid().ToString();
            l.IpAddress = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName()).AddressList[1].ToString();
            l.MachineName = Environment.MachineName;
            Client.database.NewExecute("INSERT INTO logs  (`Description`,`IpAddress`,`MachineName`,`GUID`,`UserId`) "
                + "VALUES ('" + l.Description + "','" + l.IpAddress + "','" + l.MachineName + "','" + l.GUID + "','" + l.UserId + "');", null, null);
            return Logger.Service.FormatLog(Client.database.NewExecuteQuerry("SELECT * FROM logs WHERE `GUID` = '" + l.GUID + "';", null, null));
        }
    }
    public class Log
    {
        public String GUID
        {
            get;
            set;
        }
        public String DateStamp
        {
            get;
            set;
        }
        public String Id
        {
            get;
            set;
        }
        public String Description
        {
            get;
            set;
        }

        public String IpAddress
        {
            get;
            set;
        }
        public String UserId
        {
            get;
            set;
        }
        public String MachineName
        {
            get;
            set;
        }

    }
}
