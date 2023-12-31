# CQRS with MediatR in .NET 7

Welcome to the CQRS with MediatR educational project! This repository demonstrates how to implement the Command Query Responsibility Segregation (CQRS) pattern using **MediatR**, **Mapster** and **FluentValidation** in .NET 7. This project is designed to help you understand the separation of queries, commands and notifications, a fundamental concept in modern software architecture.

## Project Overview

This simple application allows you to perform basic operations of adding, retrieving a person's data and publish notification on person register. It serves as an excellent resource for anyone looking to learn and explore CQRS using MediatR and Mapster.

### Features

1. **Register Person**: Add a new person's data to the system.

2. **Get Person**: Retrieve a specific person's information by their unique identifier.

3. **Get All Persons**: Retrieve a list of all registered persons in the system.

4. **Notification**: Publish notification on person register using MapsterNotification.

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
- Use your favorite API testing tool (e.g., Postman, Httpie) to send requests to the provided endpoints as mentioned above.
- Study the code, especially the usage of MediatR, Mapster and FluentValidation for command and query handling.

## How to Contribute

**Contributions are not currently accepted for this project.**

## Contact
If you have any questions or suggestions, feel free to contact me at mehrozdurrani@gmail.com

## License

This project is licensed under the MIT License - see the [LICENSE](https://opensource.org/license/mit/) file for details.