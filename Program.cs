using Permissive.Data;
using Permissive.Generator;

using System.Text;


ExchangeData exchange = ExchangeGenerator.CreateExchangeData();

// I'm giving it some data!
exchange.PublishData(
    SecretData: Encoding.ASCII.GetBytes("I'm a secret message!"),
    DefaultData: Encoding.ASCII.GetBytes("I'm a default message!")
);

Console.WriteLine("Current Data: " + exchange.GetDataAsString());

exchange.GrantAuthorization();
Console.WriteLine("Authorized!");

Console.WriteLine("Current Data: " + exchange.GetDataAsString());