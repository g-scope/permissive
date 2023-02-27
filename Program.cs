/*
    Screw the plan, we ball.
*/  

using Permissive.Data;
using Permissive.Generator;

ClientData clientData = ClientGenerator.CreateClientData("127.0.0.1");
StatusData statusData = clientData.get_status();

// Method A
(int status_code, string message) = statusData.get_status();

// Just changing it up a little.
statusData.set_status(
    status: 200,
    message: "success!"
);

// Method B
int status_code_b = statusData.get_code();
string message_b = statusData.get_message();


Console.WriteLine($"Method A | [{status_code}] {message}");
Console.WriteLine($"Method B | [{status_code_b}] {message_b}");