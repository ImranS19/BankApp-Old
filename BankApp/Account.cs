﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    /// <summary>
    /// This represents a bank account where you can withdraw or deposit money into the account
    /// </summary>
    internal class Account
    {
        #region Properties
        /// <summary>
        /// Unique account number
        /// </summary>
        public int AccountNumber { get; set; }
        public string AccountName { get; set; }
        public string AccountType { get; set; }
        public decimal Balance  { get; set; }
        public string EmailAddress { get; set; }
        public DateTime CreatedDate { get; set; }
        #endregion

    }
}