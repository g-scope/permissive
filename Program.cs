/*
    Screw the plan, we ball.
    I forgor :skull: i'm meant to make the scaffold not my target.
*/  

using Permissive.Data;
using Permissive.Generator;

RequestData request = RequestGenerator.CreateRequestData(
    name: "test",
    type: "debug"
);

Console.WriteLine($"[Name] {request.get_name()}\n[Type] {request.get_type()}");