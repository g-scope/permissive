/*
    Oops I shouldn't of done the client/status structure!
*/  

using Permissive.Data;
using Permissive.Generator;

ExchangeData exchangeData = ExchangeGenerator.CreateExchangeData();

List<Byte> raw_data = new List<Byte>();
string str_data = "test data!";



Console.WriteLine(exchangeData);