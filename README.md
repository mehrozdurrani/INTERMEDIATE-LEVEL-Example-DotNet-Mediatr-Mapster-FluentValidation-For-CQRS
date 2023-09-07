# CQRS with MediatR in .NET 7

Welcome to the CQRS with MediatR educational project! This repository demonstrates how to implement the Command Query Responsibility Segregation (CQRS) pattern using MediatR in .NET 7. This project is designed to help you understand the separation of queries and commands, a fundamental concept in modern software architecture.

## Project Overview

This simple application allows you to perform basic operations of adding and retrieving a person's data. It serves as an excellent resource for anyone looking to learn and explore CQRS using MediatR.

### Features

1. **Register Person**: Add a new person's data to the system.

2. **Get Person**: Retrieve a specific person's information by their unique identifier.

3. **Get All Persons**: Retrieve a list of all registered persons in the system.

## Usage

### Register Person Request
**POST** `{host}/person/register`

#### Request JSON
```json
{
    "FirstName": "John",
    "LastName": "Doe"
}
```
#### Response JSON
```json
{
    "Id" : 1,
    "FirstName": "John",
    "LastName": "Doe"
}
```
### Get Person Request
**GET** `{host}/person/personId`
```json
{
    "Id" : 1,
    "FirstName": "John",
    "LastName": "Doe"
}
```

### Get All Persons Request
**GET** `{host}/person/all`
```json
[
    {
        "Id" : 1,
        "FirstName": "John",
        "LastName": "Doe"
    },
    {
        "Id" : 2,
        "FirstName": "Simon",
        "LastName": "Dunt"
    }
]
```
## Getting Started
To run this project and learn about CQRS with MediatR in .NET 7, follow these steps:

- Clone this repository to your local machine.
- Open the project in your preferred .NET IDE.
- Run the application.
- Use your favorite API testing tool (e.g., Postman, Insomnia) to send requests to the provided endpoints as mentioned above.
- Study the code, especially the usage of MediatR for command and query handling.

## How to Contribute

**Contributions are not currently accepted for this project.**

## Contact
If you have any questions or suggestions, feel free to contact me at mehrozdurrani@gmail.com

## License

This project is licensed under the MIT License - see the [LICENSE](https://opensource.org/license/mit/) file for details.