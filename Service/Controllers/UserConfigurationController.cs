using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Service.Configuration;
using Service.Models;
using Swagger.Trello.Api;
using Swagger.Trello.Model;

namespace Service.Controllers
{
    [Route("api/v1/config")]
    public class UserConfigurationController : Controller
    {
        private readonly IConfiguration _configuration;
        
        public UserConfigurationController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        
        [Route("")]
        [HttpPost]
        public IActionResult CreateOrUpdate(
            [FromBody] IntegrationConfiguration configuration
        ) {
            Webhooks webhook = new Webhooks()
            {
                CallbackURL = "<base path>/api/v1/webhooks/trello",
                Active = "true", // TODO [Swagger] should accept bool here
                Description = "trello-Habitica integration webhook",
                IdModel = configuration.Trello.Board
            };

            IntegrationConfiguration oldConfiguration = null;
            // TODO persist data (keep old in memory if found)
            // ...

            if (true) // TODO if is new
            {
                // TODO [Swagger] return missing see: https://developers.trello.com/v1.0/reference#webhooks-2
                var ret = new WebhookApi().AddWebhooks(webhook, _configuration["Trello:ApiKey"], configuration.Trello.Token); 
            }
            else
            {
                // TODO Apply configuration changes if needed
                // ...
                
                if (oldConfiguration.Trello.Id    != configuration.Trello.Id || 
                    oldConfiguration.Trello.Board != configuration.Trello.Board)
                {
                    // TODO [Swagger] return missing see: https://developers.trello.com/v1.0/reference#webhooksid-1
                    new WebhookApi().DeleteWebhooksByIdWebhook("", _configuration["Trello:ApiKey"], oldConfiguration.Trello.Token);
                
                    // TODO [Swagger] return missing see: https://developers.trello.com/v1.0/reference#webhooksid
                    // TODO [Swagger] missing parameter {id} of object to update
                    new WebhookApi().UpdateWebhooks(webhook, _configuration["Trello:ApiKey"], configuration.Trello.Token);
                }
            }


            return null;
        }

        [Route("")]
        [HttpGet]
        public IActionResult Get(
            [FromQuery] string habiticaId,
            [FromQuery] string habiticaToken
        ) {
            throw new NotImplementedException();
        }

        [Route("")]
        [HttpDelete]
        public IActionResult Delete(
            [FromQuery] string habiticaId,
            [FromQuery] string habiticaToken
        ) {
            throw new NotImplementedException();
        }
    }
}