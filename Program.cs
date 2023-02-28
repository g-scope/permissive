using Permissive.Data;
using Permissive.Generator;
using Permissive.Controller;

using System.Text;

ExchangeController exchange = ExchangeGenerator.CreateExchangeController(
    DefaultData: Encoding.ASCII.GetBytes("Default Message!")
);

exchange.PublishData(
    SecretData: Encoding.ASCII.GetBytes("Secret Message!")
);

Console.WriteLine(exchange.GetDataAsString());

exchange.UpdateAuthorized(true);

Console.WriteLine(exchange.GetDataAsString());

