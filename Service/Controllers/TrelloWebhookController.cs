using System;
using Manatee.Trello;
using Manatee.Trello.Json;
using Microsoft.AspNetCore.Mvc;
using Action = Manatee.Trello.Action;
using System.Reflection;

namespace Service.Controllers
{
    [Route("api/v1/webhooks/trello")]
    public class TrelloWebhookController : Controller
    {
        [Route("")]
        [HttpPost]
        public void Index(
            [FromBody] string content
        )
        {
            var jsonAction = TrelloConfiguration.Deserializer.Deserialize<IJsonWebhookNotification>(content).Action;
            const BindingFlags flags = BindingFlags.NonPublic | BindingFlags.Instance;
            Action action = (Action) typeof(Action)
                .GetConstructor(flags, null, Type.EmptyTypes, null)
                .Invoke(jsonAction, null);

            Console.WriteLine("Got something!");
            
            // Do stuff
        }
    }
}