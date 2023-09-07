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
    "Id" : 1,
    "FirstName": "Jhon",
    "LastName": "Doe"
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