﻿using LedgerLocal.Dto.Chain;
using LedgerLocal.Service.GrapheneLogic;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LedgerLocal.Service.ChainService
{
    public interface IAccountService
    {
        Task<List<AccountProfileSimple>> ListAccount(string lowerBound, int limit);

        Task<List<AmountDescriptionSimple>> ListBalance(string accountId);

        Task<Dictionary<string, TransactionRecordDescription>> Transfer(string from, string to, decimal amount, string symbol, string memo, bool broadcast);

        Task<List<GrapheneOpContainer>> ListHistory(string accountId, uint start, uint stop, uint limit);

        Task<WebSocketSession> SubscribeToAccountBalance(string account, string[] objectIds, Action<string> cb);
    }
}
