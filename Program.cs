/*
    Oops I shouldn't of done the client/status structure!
*/  

using Permissive.Data;
using Permissive.Generator;

ExchangeData exchangeData = ExchangeGenerator.CreateExchangeData();
exchangeData.assign_data(
    data: System.Text.Encoding.ASCII.GetBytes(
        "i'm some data that is going to be exchanged!"
    )
);

Console.WriteLine(System.Text.Encoding.ASCII.GetString(exchangeData.get_data()));

exchangeData.update_client_authorized(true);
exchangeData.update_guard_authorized(true);

Console.WriteLine(System.Text.Encoding.ASCII.GetString(exchangeData.get_data()));