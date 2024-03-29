﻿using OurBank.Models;

namespace OurBank.Repositories.Abstractions
{
    public interface IAccountRepository
    {
        public void Add(Account model);
        public void Remove(int id);
        public void RemoveRange(Customer model);
        public Account Get(int id);
    }
}
