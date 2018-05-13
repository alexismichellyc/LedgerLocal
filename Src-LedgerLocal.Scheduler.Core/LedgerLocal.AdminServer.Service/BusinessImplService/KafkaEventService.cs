﻿using LoyaltyCoin.AdminServer.Service.LycServiceContract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Newtonsoft.Json;
using System.Net.Http;
using Serilog;
using Microsoft.Extensions.Logging;
using LedgerLocal.Blockchain.Service.LycServiceContract;
using LedgerLocal.AdminServer.Service;
using LedgerLocal.AdminServer.Dto.Models;
using LoyaltyCoin.AdminServer.Api.Web.Models;
using LedgerLocal.AdminServer.Service.BusinessImplService.Contract;

namespace LoyaltyCoin.AdminServer.Service.LycServiceImpl
{
    public class KafkaEventService : IKafkaEventService
    {
        private readonly ICommonMessageService _commonMessageService;
        private readonly IGlobalConfig _globalConfig;
        private readonly IBotService _botService;
        private HttpClient _httpClient;

        private readonly ILogger<KafkaEventService> _logger;

        public KafkaEventService(
            ILogger<KafkaEventService> logger, 
            ICommonMessageService commonMessageService,
            IBotService botService,
            IGlobalConfig globalConfig)
        {
            _logger = logger;
            _commonMessageService = commonMessageService;
            _botService = botService;
            _httpClient = new HttpClient();
            _globalConfig = globalConfig;
        }

        public async Task PoolMessageFromKafka(TimeSpan ts)
        {
            _logger.LogInformation($"Starting PoolMessageForExchangePointBroadcast...");
            var utcNow = DateTime.UtcNow;

            await _commonMessageService.PoolMessage<StandardArgModel>("llc-event-broadcast", ts, (a, b, c) =>
            {
                var resPe = JsonConvert.DeserializeObject<ActionEventDefinition>(c.Args.First());
                var resCust = c.Args.Skip(1).First();

                if (resPe != null && resPe.Timestamp.HasValue && resPe.Timestamp.Value > ServiceLocatorSingleton.Instance.UtcStartDate)
                {

                    _botService.SendMessage(string.Format($"{resPe.ActionName} => {resPe.Message}"));
                    _logger.LogInformation($"Received llc-event-broadcast for ${resCust} !");

                }

            });

            await Task.Delay(ts);
        }
    }
}