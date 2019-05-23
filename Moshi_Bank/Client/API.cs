using Bunifu.Framework.UI;
using Moshi_Bank.Client;
using Moshi_Bank.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace Moshi_Bank
{
    class API
    {
        public static String SelectMd5(String text)
        {
            String md5 = null;
            MySqlDataReader reader = database.NewExecuteQuerry("SELECT MD5('" + text + "')", null, null);
            while (reader.Read())
            {
                md5 = reader.GetString(0);
            }
            reader.Close();
            return md5;
        }
        public static Staff Staff
        {
            get;
            set;
        }
        public static void ClearFields(Control.ControlCollection parent)
        {
            foreach (Control control in parent)
            {
                if (control is TextBox)
                {
                    TextBox txt = control as TextBox;
                    txt.Clear();
                }
                if (control is PictureBox)
                {
                    PictureBox pic = control as PictureBox;
                    pic.Image = null;
                }
            }
        }
        public static void Message(String message, MessageBoxIcon mIcon)
        {
            MessageBox.Show(message, "Mzalendo", MessageBoxButtons.OK, mIcon);
        }
        public static void BrowseImage(PictureBox p)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.ShowDialog();
            p.ImageLocation = op.FileName;
        }
        public static byte[] ImageToByte(Image img)
        {
            MemoryStream ms = new MemoryStream();
            if (img != null)
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            return ms.ToArray();
        }
        public static Image ImageFromByte(byte[] data)
        {
            try
            {
                return Image.FromStream(new MemoryStream(data));
            }
            catch
            {
                return null;
            }

        }
        public static void filter(params TextBox[] textBoxCollection)
        {
            foreach (TextBox t in textBoxCollection)
            {
                t.KeyPress += T_KeyPress;
            }
        }
        public static void filter(params Bunifu.Framework.UI.BunifuMaterialTextbox[] textBoxCollection)
        {
            foreach (BunifuMaterialTextbox t in textBoxCollection)
            {
                t.KeyPress += T_KeyPress;
            }
        }
        private static void T_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                char c = e.KeyChar;
                if (!Char.IsDigit(c) && c != '.' && c != '\b')
                {
                    e.Handled = true;
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        public static class Controllers
        {
            public static class Loans
            {
                private static class Services
                {
                    public static List<Loan> FormatLoan(MySqlDataReader reader)
                    {
                        List<Loan> loans = new List<Loan>(); ;
                        while (reader.Read())
                        {
                            loans.Add(new Loan
                            {

                                Id = reader["id"].ToString(),
                                Account = new Account { Number = reader["AccountNumber"].ToString() },

                                Principal = reader.GetDecimal("Principal"),
                                Interest = reader.GetDecimal("Interest"),
                                Rate = reader.GetDecimal("Rate"),
                                Amount = reader.GetDecimal("Amount"),
                                Time = reader.GetInt32("Time"),
                                MonthlyAmount = reader.GetDecimal("MonthlyAmount"),
                                Balance = reader.GetDecimal("Balance"),
                                StandingCharge = reader.GetDecimal("StandingCharge"),
                                DateApplied = reader.GetDateTime("date_stamp"),
                                Status = reader.GetInt32("Status"),
                                Description = reader["Description"].ToString(),
                                GUID = reader["GUID"].ToString()

                            });
                        }
                        reader.Close();
                        return loans;
                    }
                }

                public static void Create(Loan loan)
                {
                    database.NewExecute(
                        "INSERT INTO `loan_application` " +
                        "(`StandingCharge`,`GUID`,`AccountNumber`,`Principal`,`Interest`,`Rate`,`Amount`,`Time`,`MonthlyAmount`,`Description`,`Status`,`Balance`)" +
                        " VALUES (@sc,@guid,@accNo,@principal,@interest,@rate, @amount, @time,@mamount, @Description, @Status,@Balance);",
                        new List<string> {
                            "@sc",  "@guid","@accNo","@principal","@interest","@rate",
                            "@amount", "@time", "@mamount", "@Description", "@Status", "@Balance" },
                        new List<object> {
                            loan.StandingCharge,
                            loan.GUID,
                            loan.Account.Number,
                            loan.Principal,
                            loan.Interest,
                            loan.Rate,
                            loan.Amount,
                            loan.Time,
                            loan.MonthlyAmount,
                            loan.Description ,
                            loan.Status,
                            loan.Balance
                        });

                }
                public static Loan FindByGuid(object GUID)
                {
                    return Services.
                        FormatLoan(
                        database.
                        NewExecuteQuerry("SELECT * FROM `loan_application` WHERE GUID = @guid;", new List<string> { "@guid" }, new List<object> { GUID }))[0];
                }
                public static Loan FindById(object loanId)
                {
                    return Services.
                        FormatLoan(
                        database.
                        NewExecuteQuerry("SELECT * FROM `loan_application` WHERE Id = @id;", new List<string> { "@id" }, new List<object> { loanId }))[0];
                }
                public static List<Loan> FindByAccountNumber(object AccountNumber)
                {
                    return Services.FormatLoan(database.NewExecuteQuerry(
                        "SELECT * FROM loan_application WHERE AccountNumber = @acc ORDER BY date_stamp DESC;",
                        new List<string> { "@acc" },
                        new List<object> { AccountNumber }
                        ));
                }
                public static void UpdateStatus(Loan loan, object status)
                {
                    database.NewExecute("UPDATE loan_application SET Status = @status WHERE Id = @id;"
                        , new List<string> { "@id", "@status" }
                        , new List<object> { loan.Id, status });
                }
                public static void UpdateBalance(Loan loan, Account account, decimal amount)
                {
                    database.NewExecute("UPDATE `loan_application` SET `Balance` = @amount WHERE `Id` = @lid AND `AccountNumber` = @accNo ;"
                        , new List<string> { "@amount", "@lid", "@accNo" }
                        , new List<object> { loan.Balance - amount, loan.Id, account.Number });
                }
                public static class SupportDocuments
                {
                    private static class Services
                    {
                        public static List<SupportDocument> FormatDocument(MySqlDataReader reader)
                        {
                            List<SupportDocument> docs = new List<SupportDocument>();
                            while (reader.Read())
                            {
                                docs.Add(new SupportDocument
                                {
                                    Description = reader["description"].ToString(),
                                    Document = (byte[])reader["data"],
                                    Id = reader["id"].ToString(),
                                    Loan = new Models.Loan { Id = reader["loan_id"].ToString() }
                                });
                            }
                            reader.Close();
                            return docs;
                        }
                    }
                    public static void Create(SupportDocument doc)
                    {
                        database.NewExecute(
                            "INSERT INTO `loan_documents` (`loan_id`,`description`,`data`) VALUES (@loanId,@desc,@data);",
                            new List<string> { "@loanId", "@desc", "@data" },
                            new List<object> { doc.Loan.Id, doc.Description, doc.Document });
                    }
                    public static List<SupportDocument> SupportDocs(Object LoanId)
                    {
                        return Services.FormatDocument(database.NewExecuteQuerry(
                            "SELECT * FROM loan_documents WHERE loan_id = @loanId;",
                            new List<string> { "@loanId" },
                            new List<object> { LoanId }));

                    }
                    public static SupportDocument Doc(Object docId)
                    {
                        return Services.FormatDocument(database.NewExecuteQuerry(
                            "SELECT * FROM loan_documents WHERE Id = @loanId;",
                            new List<string> { "@loanId" },
                            new List<object> { docId }))[0];

                    }
                    public static void SaveSupportDocs(List<SupportDocument> docs)
                    {
                        foreach (SupportDocument doc in docs)
                        {
                            Create(doc);
                        }
                    }
                }
                public static class Guarantors
                {
                    private static class Services
                    {
                        public static List<Guarantor> FormatGuarantors(MySqlDataReader reader)
                        {
                            List<Guarantor> data = new List<Guarantor>();
                            while (reader.Read())
                            {
                                data.Add(
                                    new Guarantor
                                    {
                                        Id = reader["Id"].ToString(),
                                        Loan = new Models.Loan { Id = reader["loan_id"].ToString() },
                                        User = new User { Id = reader["user_id"].ToString() }
                                    });
                            }
                            reader.Close();
                            return data;
                        }
                    }
                    public static void Create(Guarantor guarantor)
                    {
                        database.NewExecute(
                            "INSERT INTO `guarantors` (`user_id`,`loan_id`) VALUES (@userId,@loanId);"
                            , new List<string> { "@userId", "@loanId" }
                            , new List<object> { guarantor.User.Id, guarantor.Loan.Id });
                    }
                    public static List<Guarantor> LoanGuarantors(Object LoanId)
                    {
                        return Services.FormatGuarantors(database.NewExecuteQuerry(
                            "SELECT * FROM guarantors WHERE loan_id = @loanId;",
                            new List<string> { "@loanId" },
                            new List<object> { LoanId }));

                    }
                    public static void SaveGuarantors(List<Guarantor> guarantors)
                    {
                        foreach (Guarantor g in guarantors)
                        {
                            Create(g);
                        }
                    }
                }
            }
            public static class LoansData
            {
                private static class Service
                {
                    public static Double Interest(MySqlDataReader reader)
                    {
                        Double inte = 0;
                        while (reader.Read())
                        {
                            inte = reader.GetDouble(0);
                        }
                        reader.Close();
                        return inte;
                    }
                    public static Double StandingCharge(MySqlDataReader reader)
                    {
                        Double inte = 0;
                        while (reader.Read())
                        {
                            inte = reader.GetDouble(0);
                        }
                        reader.Close();
                        return inte;
                    }
                }
                public static LoanData GetLoanData()
                {
                    return new LoanData
                    {
                        InterestRate = Service.Interest(database.NewExecuteQuerry("SELECT `value` FROM `SETTINGS` WHERE `key` = 'l_i';", null, null)),
                        StandingCharge = Service.StandingCharge(database.NewExecuteQuerry("SELECT `value` FROM `SETTINGS` WHERE `key` = 'l_s_c';", null, null))

                    };
                }
                public static void UpdateStandingCharge(double SC)
                {
                    database.NewExecute(
                        "UPDATE `SETTINGS` SET `value` = @val WHERE `key` = 'l_s_c';",
                        new List<string> { "@val" },
                        new List<object> { SC });
                }
                public static void UpdateInterest(double I)
                {
                    database.NewExecute("UPDATE  `SETTINGS` SET `value` = @val WHERE `key` = 'l_i';",
                        new List<string> { "@val" },
                        new List<object> { I });
                }
            }
            public static class Staffs
            {
                private static class Service
                {
                    public static Staff FormatStaff(MySqlDataReader reader)
                    {
                        Staff staff = null;
                        while (reader.Read())
                        {
                            staff = new Staff
                            {
                                Id = reader["Id"].ToString(),
                                Names = reader["Names"].ToString(),
                                Email = reader["Email"].ToString(),
                                Level = reader.GetInt32("Level"),
                                Address = reader["Address"].ToString(),
                                DateCreated = reader["date_stamp"].ToString(),
                                NationalId = reader["NationalId"].ToString(),
                                Phone = reader["Phone"].ToString(),
                                Password = reader["Password"].ToString(),
                                UserPhoto = (byte[])reader["Photo"]
                            };
                        }
                        reader.Close();
                        return staff;
                    }
                }
                public static void Create(Staff staff)
                {
                    string sql =
                                 "INSERT INTO staff " +
                                 "(`Names`,`NationalId`,`Address`,`Password`,`Phone`,`Email`,`Photo`,`Level`) " +
                                 "VALUES " +
                                 "(@names,@nationalId,@address,md5(@password),@phone,@email,@photo,@level) ";

                    database.NewExecute(
                        sql,
                        new SQL().ParameterRange("@names", "@nationalId", "@address", "@password", "@phone", "@email", "@photo", "@level"),
                        new SQL().ValuesRange(staff.Names, staff.NationalId, staff.Address, staff.Password, staff.Phone, staff.Email, staff.UserPhoto, staff.Level)
                        );
                    Logger.Log(" Creating staff : " + staff.Email);
                }
                public static Staff Login(Staff staff)
                {
                    if (staff != null)
                    {
                        Client.Logger.Log(" Try Login : " + staff.Email + ", Password : " + staff.Password);
                    }
                    staff = Staffs.Service.FormatStaff(
                        Client.
                        database.
                        NewExecuteQuerry(
                        "SELECT * FROM `staff`  WHERE `Email` = @email AND  `Password` = md5(@password);",
                        new SQL().ParameterRange("@email", "@password"),
                        new SQL().ValuesRange(staff.Email, staff.Password)
                        ));

                    return staff;
                }

                public static void UpdateSettings(String NewPassword, byte[] photo, String staffId)
                {
                    string sql =
                                  "UPDATE staff " +
                                  " SET `Password` = md5(@password) , Photo = @photo" +
                                  " WHERE " +
                                  " Id = @id;";

                    database.NewExecute(
                        sql,
                        new SQL().ParameterRange("@password", "@photo", "@id"),
                        new SQL().ValuesRange(NewPassword, photo, staffId)
                        );
                }
                public static void UpdatePassword(String NewPassword, String staffId)
                {
                    string sql =
                                  "UPDATE staff " +
                                  " SET `Password` = md5(@password) " +
                                  " WHERE " +
                                  " Id = @id;";

                    database.NewExecute(
                        sql,
                        new SQL().ParameterRange("@password", "@id"),
                        new SQL().ValuesRange(NewPassword, staffId)
                        );
                }

                internal static Staff FindByStaffNo(object staffNo)
                {
                    return Service.FormatStaff(
                        database.NewExecuteQuerry("SELECT * FROM staff WHERE Id = @Id;",
                        new SQL().ParameterRange("@Id"),
                        new SQL().ValuesRange(staffNo)
                        ));
                }

                internal static Staff FindByNationalId(object nationalId)
                {
                    return Service.FormatStaff(
                        database.NewExecuteQuerry("SELECT * FROM staff WHERE NationalId = @Id;",
                        new SQL().ParameterRange("@Id"),
                        new SQL().ValuesRange(nationalId)
                        ));
                }
                internal static Staff FindByEmail(object email)
                {
                    return Service.FormatStaff(
                        database.NewExecuteQuerry("SELECT * FROM staff WHERE Email = @email;",
                        new SQL().ParameterRange("@email"),
                        new SQL().ValuesRange(email)
                        ));
                }

                internal static void UpdateLevel(int level, string id)
                {
                    string sql =
                                   "UPDATE staff " +
                                   " SET `Level` = @level " +
                                   " WHERE " +
                                   " Id = @id;";

                    database.NewExecute(
                        sql,
                        new SQL().ParameterRange("@level", "@id"),
                        new SQL().ValuesRange(level, id)
                        );
                }
            }
            public static class Fees
            {
                public static class Service
                {
                    public static Fee FormatFee(MySqlDataReader reader)
                    {
                        Fee fee = null;
                        while (reader.Read())
                        {
                            fee = new Fee
                            {
                                AccountType = reader.GetInt32("Type"),
                                Id = "Id",
                                Amount = reader.GetDouble("Amount")
                            };
                        }
                        reader.Close();
                        return fee;
                    }
                }
                public static void Create(Fee fee)
                {
                    database.NewExecute(
                        "INSERT INTO fee (`Type`,`Amount`)VALUES (@type,@amount);",
                        new SQL().ParameterRange("@type", "@amount"),
                        new SQL().ValuesRange(fee.AccountType, fee.Amount)
                        );
                }
                public static void Update(Fee fee)
                {
                    database.NewExecute(
                        "UPDATE  fee  SET `Amount` = @amount WHERE `Type` = @type;",
                        new SQL().ParameterRange("@type", "@amount"),
                        new SQL().ValuesRange(fee.AccountType, fee.Amount)
                        );
                    Client.Logger.Log(" Updating Fee : " + fee.Amount + ", For : " + fee.AccountType + " By : " + Staff.Id);
                }
                public static Fee FindByAccountType(int AccountType)
                {
                    return
                        Fees
                        .Service
                        .FormatFee(
                        Client
                        .database
                        .NewExecuteQuerry(
                           "SELECT * FROM fee WHERE `Type` = @type;",
                           new SQL().ParameterRange("@type"),
                           new SQL().ValuesRange(AccountType)
                           ));
                }

            }
            public static class AccountConstrains
            {
                private static class Service
                {
                    public static Constrain FormatConstrain(MySqlDataReader reader)
                    {
                        Constrain constrain = null;
                        while (reader.Read())
                        {
                            constrain = new Constrain
                            {
                                Amount = reader.GetDouble("Amount"),
                                Id = reader["Id"].ToString(),
                                Time = reader.GetInt32("Time")
                            };
                        }
                        reader.Close();
                        return constrain;
                    }

                }
                public static void Create(Constrain constrain)
                {
                    Client.Logger.Log(" Creating  Constrain : " + constrain.Account + ", Constrains : {" + constrain.Amount + "," + constrain.Time
                    );
                    database.NewExecute(
                        "INSERT INTO `fixed_dep_constrains` (`AccountNumber`,`Time`,`Amount`) VALUES (@accNo,@time,@amount)"
                        , new SQL().ParameterRange("@accNo", "@time", "@amount")
                        , new SQL().ValuesRange(constrain.Account.Number, constrain.Time, constrain.Amount));
                }
                public static Constrain FindConstrain(Account account)
                {
                    return AccountConstrains
                        .Service
                        .FormatConstrain
                        (
                        database.NewExecuteQuerry("SELECT * FROM `fixed_dep_constrains` WHERE `AccountNumber` = @accNo"
                        , new SQL().ParameterRange("@accNo")
                        , new SQL().ValuesRange(account.Number))
                        );
                }
            }
            public static class SystemAccount
            {
                public static void Credit(double amount)
                {

                }
                public static void Debit(double amount)
                {

                }
            }
            public static class Settings
            {
                public static int GetChargingSystem()
                {
                    int cs = 0;
                    MySqlDataReader read = database.NewExecuteQuerry("SELECT * FROM settings where `key` = 'c_s'", null, null);
                    while (read.Read())
                    {
                        cs = read.GetInt32("value");
                    }
                    read.Close();
                    return cs;
                }
                public static void SaveChargingSystem(int ncs)
                {
                    Client.Logger.Log(" Updated Charging System : " + ncs);
                    database.NewExecute("UPDATE  settings SET `value` = " + ncs + "  where `key` = 'c_s'", null, null);

                }
                public static String GetChargingSystem(int cs)
                {
                    String sCs = null;
                    switch (cs)
                    {
                        case 1:
                            sCs = "Values System";
                            break;
                        case 2:
                            sCs = "Percentage System";
                            break;
                    }
                    return sCs;
                }
            }
            public static class TransactionTypes
            {
                public static Dictionary<String, int> LoadTransactionTypes()
                {
                    Dictionary<String, int> tt = new Dictionary<String, int>();
                    MySqlDataReader read = database.NewExecuteQuerry("SELECT * FROM transaction_types", null, null);
                    while (read.Read())
                    {
                        tt.Add(read.GetString("Description"), read.GetInt32("Id"));
                    }
                    read.Close();
                    return tt;
                }
            }
            public static class CreditDebit
            {
                private static class Services
                {
                    public static Models.CreditDebit FormatCreditDebit(MySqlDataReader dataReader)
                    {
                        Models.CreditDebit credDeb = null;
                        String tId = "-1", tdId = "-1", number = "-1";
                        while (dataReader.Read())
                        {
                            credDeb = new Models.CreditDebit
                            {
                                Id = dataReader["Id"].ToString(),
                                Credit = dataReader.GetDouble("Credit"),
                                Debit = dataReader.GetDouble("Debit"),
                                NewBalance = dataReader.GetDouble("NewBalance"),
                                DateStamp = dataReader.GetDateTime("date_stamp")
                            };
                        }
                        dataReader.Close();
                        credDeb.Transaction = API.Controllers.Transaction.FindByID(tId);
                        credDeb.TransactionDescription = API.Controllers.TransactionDescription.FindByID(tdId);
                        credDeb.Account = API.Controllers.Accounts.FetchByAccountNumber(number);
                        return credDeb;
                    }
                }
                public static void CreateForLoans(Models.CreditDebit creditDebit)
                {
                    String sql =
                                      "INSERT INTO `cred_deb` " +
                                      "(`TransactionId`,`AccountNumber`,`Credit`,`Debit`,`NewBalance`,`description_id`) " +
                                     "VALUES " +
                                     "(" + creditDebit.Transaction.TransactionId + "," + creditDebit.Account.Number + "," + creditDebit.Credit + "," + creditDebit.Debit + "," + creditDebit.NewBalance + ",'" + creditDebit.TransactionDescription.Id + "');" +
                                     ";";
                    database.execute(sql);

                }
                public static void Create(Models.CreditDebit creditDebit)
                {
                    if (creditDebit.TransactionType
                        == Models.Transaction.TransactionTypes.DEPOSIT
                        || creditDebit.TransactionType
                        == Models.Transaction.TransactionTypes.SYSTEM_DEPOSIT
                        || creditDebit.TransactionType
                        == Models.Transaction.TransactionTypes.SEND_RECEIVE_RECEIVE
                        || creditDebit.TransactionType
                        == Models.Transaction.TransactionTypes.LOAN_PAYMENT
                        || creditDebit.TransactionType
                        == Models.Transaction.TransactionTypes.ACCOUNT_CREATION_FEE
                        || creditDebit.TransactionType
                        == Models.Transaction.TransactionTypes.STANDING_CHARGE)
                    {
                        //increment new Balance by Creditamount
                        creditDebit.NewBalance = creditDebit.Credit + creditDebit.Account.Balance;
                    }
                    else if (creditDebit.TransactionType
                        == Models.Transaction.TransactionTypes.WITHDRAW
                        || creditDebit.TransactionType
                        == Models.Transaction.TransactionTypes.SEND_RECEIVE_SEND)
                    {
                        creditDebit.NewBalance = creditDebit.Account.Balance - creditDebit.Debit;
                    }
                    
                    String sql =
                                    "INSERT INTO `cred_deb` " +
                                    "(`TransactionId`,`AccountNumber`,`Credit`,`Debit`,`NewBalance`,`description_id`) " +
                                   "VALUES " +
                                   "(" + creditDebit.Transaction.TransactionId + "," + creditDebit.Account.Number + "," + creditDebit.Credit + "," + creditDebit.Debit + "," + creditDebit.NewBalance + ",'" + creditDebit.TransactionDescription.Id + "');" +
                                   "UPDATE accounts SET balance = '" + creditDebit.NewBalance + "' WHERE Number = " + creditDebit.Account.Number + ";";
                    database.execute(sql);

                }

                public static Models.CreditDebit FindByTransactionId(String TransactionId)
                {
                    return API.Controllers.CreditDebit.
                            Services
                            .FormatCreditDebit(
                                Client.
                                database.
                                executeQuerry(
                                     "SELECT * FROM cred_deb WHERE `TransactionId` = " + TransactionId));
                }
            }
            public static class Users
            {
                public static class Services
                {
                    public static Models.User FormatUser(MySqlDataReader dataReader)
                    {
                        Models.User user = null;
                        while (dataReader.Read())
                        {
                            user = new Models.User
                            {
                                Names = dataReader["Names"].ToString(),
                                Email = dataReader["Email"].ToString(),
                                Address = dataReader["Address"].ToString(),
                                NationalId = dataReader["NationalId"].ToString(),
                                DateCreated = dataReader["date_stamp"].ToString(),
                                Id = dataReader["Id"].ToString(),
                                Phone = dataReader["Phone"].ToString(),
                                UserPhoto = (byte[])dataReader["Photo"],
                                DigitalSignature = (byte[])dataReader["DigitalSignature"]
                            };
                        }
                        dataReader.Close();
                        return user;
                    }
                }
                public static User FindByNatinalId(object NationalId)
                {
                    return Services.FormatUser(database.executeQuerry("SELECT * FROM users WHERE NationalId = '" + NationalId + "';"));

                }
                public static User FindById(object Id)
                {
                    return Services.FormatUser(database.executeQuerry("SELECT * FROM users WHERE Id = " + Id + ";"));

                }
                public static int Count()
                {
                    int count = 0;
                    MySqlDataReader reader = database.executeQuerry("SELECT count(*) FROM users;");
                    while (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                    reader.Close();
                    return count;
                }
                public static int AccountsCount(object uId)
                {
                    int count = 0;
                    MySqlDataReader reader = database.executeQuerry("SELECT count(*) FROM accounts WHERE `UserId` =" + uId + " ; ");
                    while (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                    reader.Close();
                    return count;
                }
            }
            public static class Transaction
            {
                private static class Services
                {
                    public static Models.Transaction FormatTransaction(MySqlDataReader reader)
                    {
                        Models.Transaction Transaction = null;
                        while (reader.Read())
                        {
                            Transaction = new Models.Transaction
                            {
                                TransactionId = reader.GetString("Id"),
                                TransationDate = reader["date_stamp"].ToString(),
                                TransationGUId = reader["GUID"].ToString(),
                                TransationType = reader.GetInt32("Type")
                            };
                        }
                        reader.Close();
                        return Transaction;
                    }
                }

                internal static void Create(Models.Transaction Transaction)
                {
                    database.NewExecute(
                        "INSERT INTO transaction (`GUID`,`Type`,`userId`) VALUES (@Guid,@Type,@uId)",
                        new SQL().ParameterRange("@Guid", "@Type", "@uId"),
                        new SQL().ValuesRange(Transaction.TransationGUId, Transaction.TransationType,API.Staff.Id)
                        );
                }

                internal static Models.Transaction FindByGUID(string p)
                {
                    return Services.FormatTransaction(database.NewExecuteQuerry(
                        "SELECT * FROM transaction WHERE GUID = @Guid",
                        new SQL().ParameterRange("@Guid"),
                        new SQL().ValuesRange(p)
                        ));
                }

                internal static Models.Transaction FindByID(string tId)
                {
                    return Services.FormatTransaction(database.NewExecuteQuerry(
                        "SELECT * FROM transaction WHERE Id = @tId",
                        new SQL().ParameterRange("@tId"),
                        new SQL().ValuesRange(tId)
                        ));
                }
            }
            public static class TransactionDescription
            {
                private static class Services
                {
                    public static Models.TransactionDescription FormatTransactionDescription(MySqlDataReader reader)
                    {
                        Models.TransactionDescription Td = null;
                        while (reader.Read())
                        {
                            Td = new Models.TransactionDescription
                            {
                                Id = reader["Id"].ToString(),
                                GUID = reader["Guid"].ToString(),
                                Description = reader["Description"].ToString(),
                                DateStamp = reader.GetDateTime("date_stamp"),
                                CreditAccount = new Account { Number = reader["CreditAccount"].ToString() },
                                DebitAccount = new Account { Number = reader["DebitAccount"].ToString() }
                            };
                        }
                        reader.Close();
                        return Td;
                    }
                }
                internal static Models.TransactionDescription FindByID(string tdId)
                {
                    return Services.FormatTransactionDescription(
                        Client.
                        database.
                        NewExecuteQuerry("SELECT * FROM description WHERE `Id` = @id",
                        new SQL().ParameterRange("@id"),
                        new SQL().ValuesRange(tdId)));
                }

                internal static void Create(Models.TransactionDescription TransactionDescription)
                {
                    database.NewExecute(
                        "INSERT INTO description (`Description`,`CreditAccount`,`DebitAccount`,`GUID`) VALUES (@d,@ca,@da,@g)"
                        , new SQL().ParameterRange("@d", "@ca", "@da", "@g")
                        , new SQL().ValuesRange(TransactionDescription.Description, TransactionDescription.CreditAccount.Number, TransactionDescription.DebitAccount.Number, TransactionDescription.GUID));
                }

                internal static Models.TransactionDescription FindByGUID(string p)
                {

                    return Services.FormatTransactionDescription(
                        Client.
                        database.
                        NewExecuteQuerry("SELECT * FROM description WHERE `Guid` = @id",
                        new SQL().ParameterRange("@id"),
                        new SQL().ValuesRange(p)));
                }
            }
            public static class TransactionCharges
            {
                private static class Services
                {
                    public static TransactionCharge FormatTransactionCharge(MySqlDataReader reader)
                    {
                        TransactionCharge transaC = null;
                        while (reader.Read())
                        {
                            transaC = new TransactionCharge
                            {
                                Charge = reader.GetDouble("Charge"),
                                DateStamp = reader.GetDateTime("date_stamp"),
                                Id = reader.GetInt32("Id"),
                                MaxValue = reader.GetDouble("MaxValue"),
                                MinValue = reader.GetDouble("MinValue"),
                                Percentage = reader.GetDouble("Percentage"),

                            };
                        }
                        reader.Close();
                        return transaC;
                    }
                }
                internal static TransactionCharge FindByValue(double amount, int p)
                {
                    return Services.FormatTransactionCharge(
                        database.NewExecuteQuerry(
                        "SELECT * FROM transaction_charges WHERE   @amount > `MinValue` AND  @amount < `MaxValue` AND TransactionType = @type",
                        new SQL().ParameterRange("@amount", "@type"),
                        new SQL().ValuesRange(amount, p))
                        );
                }

                internal static void UpdatePercentage(int p1, decimal p2)
                {
                    database.NewExecute(
                                            "UPDATE  transaction_charges SET `Percentage` = @perc WHERE `Id` = @id;",
                                            new SQL().ParameterRange("@id", "@perc"),
                                            new SQL().ValuesRange(p1, p2))
                                            ;
                }

                internal static Dictionary<string, int> LoadRanges()
                {
                    Dictionary<string, int> Range = new Dictionary<string, int>();
                    MySqlDataReader data = database
                        .NewExecuteQuerry(
                        "SELECT tc.Id, CONCAT(' ( ',tc.MinValue,' - ',tc.`MaxValue`, ' )',tt.Description) AS 'Range' FROM transaction_charges AS tc INNER JOIN transaction_types AS tt ON tt.Id = tc.TransactionType"
                        , null, null);
                    while (data.Read())
                    {
                        Range.Add(data[1].ToString(), Convert.ToInt32(data[0]));
                    }
                    data.Close();
                    return Range;
                }

                internal static void UpdateValue(int p1, double p2)
                {
                    database.NewExecute(
                                            "UPDATE  transaction_charges SET `Charge` = @charge WHERE `Id` = @id",
                                            new SQL().ParameterRange("@id", "@charge"),
                                            new SQL().ValuesRange(p1, p2))
                                            ;
                }

                internal static void Create(TransactionCharge transactionCharge)
                {
                    database.NewExecute(
                                            "INSERT INTO transaction_charges (`TransactionType`,`MinValue`,`MaxValue`,`Charge`) VALUES (@tt,@minV,@maxV,@charge);",
                                            new SQL().ParameterRange("@tt", "@minV", "@maxV", "@charge"),
                                            new SQL().ValuesRange(transactionCharge.TransactionType, transactionCharge.MinValue, transactionCharge.MaxValue, transactionCharge.Charge))
                                            ;

                }
            }
            public static class Accounts
            {
                private static class Services
                {
                    public static Models.Account FormatAccount(MySqlDataReader reader)
                    {
                        Models.Account account = null;
                        while (reader.Read())
                        {
                            account = new Models.Account
                            {
                                UserId = reader.GetInt32("UserId"),
                                Number = reader["Number"].ToString(),
                                DateCreated = reader["date_stamp"].ToString(),
                                Names = reader["Names"].ToString(),
                                Balance = reader.GetDouble("Balance"),
                                Status = reader.GetInt32("Status"),
                                PIN = reader["pin"].ToString(),
                                Type = new AccountType { Type = reader.GetInt32("Type") }
                            };
                        }
                        reader.Close();
                        return account;
                    }
                }
                public static void Activate(Account account)
                {
                    database.NewExecute(
                           "UPDATE accounts SET `Status` = 1 WHERE `Number` = @Number",
                           new SQL().ParameterRange("@Number"),
                           new SQL().ValuesRange(account.Number)
                           );
                }
                public static void Deactivate(Account account)
                {

                    database.NewExecute(
                           "UPDATE accounts SET `Status` = 2 WHERE `Number` = @Number",
                           new SQL().ParameterRange("@Number"),
                           new SQL().ValuesRange(account.Number)
                           );
                }
                public static Account FetchByAccountNumber(object accountNumber)
                {
                    return Services.FormatAccount(database.NewExecuteQuerry(
                        "SELECT * FROM accounts WHERE Number = @accNo", new SQL().ParameterRange("@accNo"),
                        new SQL().ValuesRange(accountNumber)

                        ));
                }

                internal static void CreateAccount(Account account)
                {
                    database.NewExecute(
                        "INSERT INTO accounts (`Names`,`Type`,`UserId`,`Balance`,`Pin`) VALUES (@Names,@Type,@UserId,@Balance,md5(@pin))",
                        new SQL().ParameterRange("@Names", "@Type", "@UserId", "@Balance", "@pin"),
                        new SQL().ValuesRange(account.Names, account.Type, account.UserId, account.Balance,account.PIN)
                        );
                }

                internal static Account FetchNewUserAccount(int p1, string p2)
                {
                    return Services.FormatAccount(database.NewExecuteQuerry(
                           "SELECT * FROM accounts WHERE `Names` = @accNames AND `UserId` = @userId ORDER BY date_stamp desc LIMIT 1",
                           new SQL().ParameterRange("@accNames", "@userId"),
                           new SQL().ValuesRange(p2, p1)

                           ));
                }

            }
        }

    }
}
