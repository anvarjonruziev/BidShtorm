﻿namespace BidShtorm.Application.Interfaces
{
    public interface IUnitOfWork
    {
        Task CommitChangesAsync();
    }
}