using BankApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web.Mvc;
using BankingApplication.Models;


namespace BankApplication.Controllers
{
    public class AccountsController : Controller
    {
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["BankingDB"].ConnectionString;

        public ActionResult Index()
        {
            List<Account> accounts = new List<Account>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Accounts", con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    accounts.Add(new Account
                    {
                        AccountId = (int)reader["AccountId"],
                        AccountNumber = (string)reader["AccountNumber"],
                        AccountHolder = (string)reader["AccountHolder"],
                        Balance = (decimal)reader["Balance"]
                    });
                }
            }

            return View(accounts);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Account account)
        {
            if (ModelState.IsValid)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Accounts (AccountNumber, AccountHolder, Balance) VALUES (@AccountNumber, @AccountHolder, @Balance)", con);
                    cmd.Parameters.AddWithValue("@AccountNumber", account.AccountNumber);
                    cmd.Parameters.AddWithValue("@AccountHolder", account.AccountHolder);
                    cmd.Parameters.AddWithValue("@Balance", account.Balance);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                return RedirectToAction("Index");
            }

            return View(account);
        }

        public ActionResult Edit(int id)
        {
            Account account = new Account();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Accounts WHERE AccountId = @AccountId", con);
                cmd.Parameters.AddWithValue("@AccountId", id);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    account = new Account
                    {
                        AccountId = (int)reader["AccountId"],
                        AccountNumber = (string)reader["AccountNumber"],
                        AccountHolder = (string)reader["AccountHolder"],
                        Balance = (decimal)reader["Balance"]
                    };
                }
            }

            return View(account);
        }

        [HttpPost]
        public ActionResult Edit(Account account)
        {
            if (ModelState.IsValid)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Accounts SET AccountNumber = @AccountNumber, AccountHolder = @AccountHolder, Balance = @Balance WHERE AccountId = @AccountId", con);
                    cmd.Parameters.AddWithValue("@AccountNumber", account.AccountNumber);
                    cmd.Parameters.AddWithValue("@AccountHolder", account.AccountHolder);
                    cmd.Parameters.AddWithValue("@Balance", account.Balance);
                    cmd.Parameters.AddWithValue("@AccountId", account.AccountId);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                return RedirectToAction("Index");
            }

            return View(account);
        }

        public ActionResult Delete(int id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Accounts WHERE AccountId = @AccountId", con);
                cmd.Parameters.AddWithValue("@AccountId", id);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            return RedirectToAction("Index");
        }
    }

}
