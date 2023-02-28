/*
    Oops I shouldn't of done the client/status structure!
*/  

using Permissive.Data;
using Permissive.Generator;
using Permissive.Controller;
using System.Text;

ExchangeController exchange = ExchangeGenerator.CreateExchangeController();

byte[] data = System.Text.Encoding.ASCII.GetBytes("test message!");

bool success = exchange.publish_data(
    data: data
);

Console.WriteLine("Exchange not Authorized yet...");
Console.WriteLine("Data Published?: " + success);
Console.WriteLine("Attempted Data Retrieval: " + Encoding.ASCII.GetString(
    exchange.get_data()
    )
);

exchange.authorize_exchange();
Console.WriteLine("Exchange Authorized!");

Console.WriteLine("Attempted Data Retrieval: " + Encoding.ASCII.GetString(
    exchange.get_data()
    )
);