"#payments-api" 

utilizing the local host we are creating a website on this port 5245
http://localhost:5245.

by adding a URI path at the end of the URL we can perform 3 actions: a GET for all records, GET for one record, or a POST to submit another payment.

GET {{PaymentsApi_HostAddress}}/payments/ -returns all payments

GET {{PaymentsApi_HostAddress}}/payments/1 -returns a specific payment

POST {{PaymentsApi_HostAddress}}/payments/ --to submit a payment(include the expected field format: Amount, Currency, Status )
    Amount must be between $ 1-60
    Currency must be exactly 3 strings
    Status must exist and bet between 1-10 characters