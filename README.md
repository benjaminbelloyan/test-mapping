# Integrating with Biller Machine

## Context

Welcome to Agicap ! We are developping a cashflow management software. 
To accelerate the forecast building for our user, we are importing in Agicap the invoices and other business documents already existing in third party tools.

Today, we want to integrate with a new third party tool, _Biller Machine_.

## Biller Machine

Biller mMchine exposes an api with two endpoints. In this exercise, there is no concern about authentication.

### Invoices endpoint

Url
> GET https://billermachine.com/api/invoices

Response
```json
{
    "invoices": [
        {
            "id": "N1234",
            "totalPrice": 12.34,
            "type": "client",
            "title": "Bill for services December",
            "dueDate": "2024-01-31T00:00:00",
            "thirdParty": "LocalShop"
        },
        {
            "id": "N5678",
            "totalPrice": 34.21,
            "type": "supplier",
            "title": "Bill for services November",
            "dueDate": "2024-01-15T00:00:00",
            "thirdParty": "AnotherLocalShop"
        },
    ]
}
```

### Credit notes endpoint

Url
> GET https://billermachine.com/api/creditnotes

Response
```json
{
    "creditnotes": [

        {
        "invoiceReference": "N1234",
        "discountedAmount": 1.0,
        "type": "client",
        "title": "OverPriced",
        "dueDate": "2024-01-31T00:00:00",
        "thirdParty": "LocalShop"
        },
        {
        "totalPrice": 1.0,
        "type": "supplier",
        "title": "Miscalculation",
        "dueDate": "2024-01-15T00:00:00",
        "thirdParty": "AnotherLocalShop"
        }
    ]
}
```

## Goals

We want to retrieve 4 types of business objects :
- Client invoices
- Supplier invoices
- Client credit notes
- Supplier credit notes

We ask you to implement the Biller Machine integration. This one has to respect our integration contract which code is provided.

By calling the endpoints described above, you need to create the expected business objects.
