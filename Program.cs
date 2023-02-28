using Permissive.Data;
using Permissive.Generator;

using System.Text;


ExchangeData exchange = ExchangeGenerator.CreateExchangeData();

// I'm giving it some data!
exchange.PublishData(
    SecretData: Encoding.ASCII.GetBytes("I'm a secret message!"),
    DefaultData: Encoding.ASCII.GetBytes("I'm a default message!")
);

// Is not authorized, will return the DefaultData.
Console.WriteLine("Current Data: " + exchange.GetDataAsString());

// Giving authorization to return the SecretData.
exchange.GrantAuthorization();
Console.WriteLine("Authorized!");

// Will give SecretData now that it is authorized.
Console.WriteLine("Current Data: " + exchange.GetDataAsString());

exchange.DenyAuthorization();
Console.WriteLine("Deauthorized!");

// No longer authorized, will return the DefaultData.
Console.WriteLine("Current Data: " + exchange.GetDataAsString());