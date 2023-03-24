using Data;
using Data.Models;

/// <summary>
/// Expense Tracker Business namespace
/// </summary>
namespace Business
{
    /// <summary>
    /// Transaction Business logic class
    /// </summary>
    public class TransactionBusiness
    {
        private Context transactionContext;

        /// <summary>
        /// Get All Transactions
        /// </summary>
        /// <returns>Transactions Collection</returns>
        public List<Transaction> GetAll()
        {
            using (transactionContext = new Context())
            {
                return transactionContext.Transactions.ToList();
            }
        }

        /// <summary>
        /// Get Single Transaction
        /// </summary>
        /// <param name="id">Identifier</param>
        /// <returns>Transaction</returns>
        public Transaction Get(int id)
        {
            using (transactionContext = new Context())
            {
                return transactionContext.Transactions.Find(id);
            }
        }

        /// <summary>
        /// Add Transaction
        /// </summary>
        /// <param name="transaction">Transaction</param>
        public void Add(Transaction transaction)
        {
            using (transactionContext = new Context())
            {
                //Add Transaction
                transactionContext.Transactions.Add(transaction);

                //Save Changes to Database
                transactionContext.SaveChanges();
            }
        }

        /// <summary>
        /// Update Transaction
        /// </summary>
        /// <param name="transaction">Transaction</param>
        /// <exception cref="Exception">If entry is not found.</exception>
        public void Update(Transaction transaction)
        {
            using (transactionContext = new Context())
            {
                var oldTransaction = transactionContext.Transactions.Find(transaction.Id);

                if (oldTransaction != null)
                {
                    //Update Transaction Values
                    transactionContext.Entry(oldTransaction).CurrentValues.SetValues(transaction);

                    //Save Changes to Database
                    transactionContext.SaveChanges();
                }
                else
                {
                    throw new Exception("Entry not found!");
                }
            }
        }

        /// <summary>
        /// Delete Transaction
        /// </summary>
        /// <param name="id">Identifier</param>
        /// <exception cref="Exception">If entry is not found.</exception>
        public void Delete(int id)
        {
            using (transactionContext = new Context())
            {
                var transaction = transactionContext.Transactions.Find(id);

                if (transaction != null)
                {
                    //Delete Transaction
                    transactionContext.Transactions.Remove(transaction);

                    //Save Changes to Database
                    transactionContext.SaveChanges();
                }
                else
                {
                    throw new Exception("Entry not found!");
                }
            }
        }
    }
}
