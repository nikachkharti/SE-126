using OurBank.Exceptions;
using OurBank.Models;
using OurBank.Repositories.Abstractions;

namespace OurBank.Repositories.Implementations
{
    public class AccountCsvRepository : IAccountRepository
    {
        const string _filePath = @"../../../Data/Accounts.csv";
        private readonly List<Account> _accounts = new();
        private readonly string _fileHeader = string.Empty;

        public AccountCsvRepository()
        {
            _accounts = SelectAccounts();
            _fileHeader = GetFileHeader();
        }


        public void Add(Account model)
        {
            try
            {
                if (!_accounts.Any(acc => acc.Equals(model)))
                {
                    model.Id = _accounts.Max(x => x.Id) + 1;
                    _accounts.Add(model);
                    SaveChanges();
                }
                else
                {
                    throw new AmbigousAccountException("Customer already exists");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public Account Get(int id) => _accounts.FirstOrDefault(x => x.Id == id);

        public void Remove(int id)
        {
            try
            {
                if (_accounts.Any(x => x.Id == id))
                {
                    var accountToRemove = Get(id);
                    _accounts.Remove(accountToRemove);

                    SaveChanges();
                }
                else
                {
                    throw new AccountNotFoundException("Account not found");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        private void SaveChanges()
        {
            var customerStrings = _accounts.Select(x => x.ToCsv());
            File.WriteAllText(_filePath, $"{_fileHeader}\n");
            File.AppendAllLines(_filePath, customerStrings);
        }

        private List<Account> SelectAccounts()
        {
            return File
                .ReadAllLines(_filePath)
                .Skip(1)
                .Select(x => x.ToAccount())
                .ToList();
        }
        private string GetFileHeader() => File.ReadAllLines(_filePath)[0];

        public void RemoveRange(Customer model)
        {
            try
            {
                List<Account> allAccountsToRemove = _accounts.Where(account => account.CustomerId == model.Id).ToList();
                if (allAccountsToRemove.Count != 0)
                {
                    foreach (var accountToRemove in allAccountsToRemove)
                    {
                        _accounts.Remove(accountToRemove);
                        SaveChanges();
                    }
                }
                else
                {
                    throw new AccountNotFoundException("Accounts to remove don't exist");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }



    internal static class AccountExtension
    {
        internal static string ToCsv(this Account obj) => $"{obj.Id},{obj.Iban},{obj.Currency},{obj.Balance},{obj.CustomerId},{obj.Name}";
        internal static Account ToAccount(this string input)
        {
            Account result = new();
            string[] csvInput = input.Split(',');

            result.Id = int.Parse(csvInput[0]);
            result.Iban = csvInput[1];
            result.Currency = csvInput[2];
            result.Balance = double.Parse(csvInput[3]);
            result.CustomerId = int.Parse(csvInput[4]);
            result.Name = csvInput[5];

            return result;

        }
    }
}
