using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Summary_Project___Bank
{
    public class Bank
    {
        private List<Account> accList = new List<Account>();
        private List<Customer> cusList = new List<Customer>();
        private Dictionary<int, Customer> mapCustomerIDToCustomer = new Dictionary<int, Customer>();
        private Dictionary<int, Customer> mapCustomerNumberToCustomer = new Dictionary<int, Customer>();
        private Dictionary<int, Account> mapAccountNumberToAccount = new Dictionary<int, Account>();
        private Dictionary<Customer, List<Account>> mapCustomerToAccountList = new Dictionary<Customer, List<Account>>();
        private int totalMoneyInBank;
        private int profits;

        public Bank()
        {
        }

        Customer GetCustomerById(int customerId)
        {

        }

        Customer GetCustomerByNumber(int customerNumber)
        {

        }

        Account GetAccountByNumber(int accountNumber)
        {

        }

        List<Account> GetAccountsByCustomer(Customer customer)
        {

        }

        void AddNewCustomer(Customer customer)
        {

        }

        void OpenNewAccount(Account account, Customer customer)
        {

        }

        int Deposit(Account account, int ammount)
        {

        }

        int Withdraw(Account account, int ammount)
        {

        }

        int GetCustomerTotalBalance(Account aaccount)
        {

        }

        void CloseAccount(Account account)
        {

        }

        void ChargeAnnualCommision(float percentage)
        {

        }

        void JoinAccounts(Account account1, Account account2)
        {

        }
    }
}
