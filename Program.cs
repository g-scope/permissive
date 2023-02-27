/*
    Excpected Functions & Endpoints, a story.

    Target uilities to use:
        - MVC

    Device Types:
        Client - A device that requests data from the Vault.
        Guard - A device that approves/denies sharing the data.
        Vault - Host containing data.

    Classes:
        - Status
            A class for generic status handling.

            - int Status.Code
                Following HTTP(s) numbers.

            - string Status.Message
                Message correlated with Status.Code.
            
             - method (int status, string message) get_status()
                returns first Status.Code, then Status.Message.
                return (status: 0?, message: ""?)
            
            - method void set_status(int status, string message = "")
                Will update the Status.Code & Status.Message value.
        

        - ClientRequest
            Packet of data to Client.

            - class ClientRequest.status
                container for status data.


        - ClientResponse : Status
            Packet of data from Client.

            - class ClientResponse.status
                container for status data.
        
        - ClientData
            General data of the Client.


*/  

