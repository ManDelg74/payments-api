# payments-api

utilizing the local host we are creating a API on this port 5245
http://localhost:5245.

by adding a URI path at the end of the URL we can perform 3 actions: a GET for all records, GET for one record, or a POST to submit another payment.

GET {{PaymentsApi_HostAddress}}/payments/ -returns all payments

GET {{PaymentsApi_HostAddress}}/payments/1 -returns a specific payment

POST {{PaymentsApi_HostAddress}}/payments/ --to submit a payment(include the expected field format: Amount, Currency, Status )
    Amount must be between $ 1-60
    Currency must be exactly 3 strings
    Status must exist and be between 1-10 characters

# examples to run
GET http://localhost:5245/payments/
Accept: application/json

expected code: 200(and all results returned in JSON)

###
GET http://localhost:5245/payments/1
Accept: application/json

expected code: 200(only a single result set returned in json)


###

POST http://localhost:5245/payments/
Content-Type: application/json

{
    "Amount" : "21.99",
    "Currency" : "usd" 
}

expected code: 201(results returned to show what was inserted)

POST {{PaymentsApi_HostAddress}}/payments/
Content-Type: application/json

{
    "Amount" : "21.99",
    "Currency" : "us" 
}
expected code: 400(results returned "Currency must be 3 characters")