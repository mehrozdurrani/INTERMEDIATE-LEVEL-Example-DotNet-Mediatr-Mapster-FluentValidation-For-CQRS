# Register Person Request
### POST {host}/person/register

```json
{
    "FirstName": "Jhon",
    "LastName": "Doe"
}
```

# Register Person Response
```json
{
    "person": {
    "id": 1,
    "firstName": "John",
    "lastName": "Doe"
  },
  "events": [
    {
      "name": "Email Event",
      "eventIsCompleted": true
    },
    {
      "name": "SMS Event",
      "eventIsCompleted": true
    }
  ]
}
```

# Get Person Request
### GET {host}/person/personId


# Get Person Response
```json
{
    "Id" : 1,
    "FirstName": "Jhon",
    "LastName": "Doe"
}
```

# Get All Persons Request
### GET {host}/person/all

```json
[
    {
        "Id" : 1,
        "FirstName": "Jhon",
        "LastName": "Doe"
    },
    {
        "Id" : 2,
        "FirstName": "Simon",
        "LastName": "Dunt"
    }
]
```