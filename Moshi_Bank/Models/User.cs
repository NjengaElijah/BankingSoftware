using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Moshi_Bank.Client;
namespace Moshi_Bank.Models
{
    public class User
    {
        private List<Account> acc = new List<Account>();

        public String Id
        {
            get;
            set;
        }
        public String Names
        {

            get;
            set;
        }
        public String Email
        {

            get;
            set;
        }
        public String Address
        {

            get;
            set;
        }
        public String Phone
        {

            get;
            set;
        }
        public String DateCreated
        {
            get;
            set;
        }
        public String NationalId
        {
            get;
            set;
        }
        public String NOKNames
        {

            get;
            set;
        }
        public String NOKPhone
        {

            get;
            set;
        }
        public String NOKEmail
        {

            get;
            set;
        }
        public String NOKNationalId
        {
            get;
            set;
        }
        public byte[] UserPhoto
        {

            get;
            set;
        }
        public byte[] DigitalSignature
        {

            get;
            set;
        }
        public List<Account> Accounts
        {
            get { return acc; }
            set { acc = value; }
        }


        public void Save()
        {
            string sql =
                         "INSERT INTO users " +
                         "(`Names`,`NationalId`,`Address`,`N_O_KNames`,`N_O_KPhone`,`N_O_KNationalId`,`N_O_KEmail`,`Phone`,`Email`,`Photo`,`DigitalSignature` ) " +
                         "VALUES " +
                         "('" + Names + "','" + NationalId + "','" + Address + "','" + NOKNames + "','" + NOKPhone + "','" + NOKNationalId + "','" + NOKEmail + "','" + Phone + "','" + Email + "',@Photo,@DigitalSignature) ";

            MySqlCommand cmd = new MySqlCommand(sql, database.connection);
            cmd.Parameters.AddWithValue("@Photo", UserPhoto);
            cmd.Parameters.AddWithValue("@DigitalSignature", DigitalSignature);
            cmd.ExecuteNonQuery();

        }

    }
}
