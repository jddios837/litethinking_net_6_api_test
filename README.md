# Test .NET 6 WEB API for Lite Thinking Position

This Microservice was deployes on Azure Web App

# Application Details

This application is going to handle 3 sections:
  1. Login
  2. List of Companies
  3. List of Products per Company

## Information of a User
- Name
- Email
- Password

## Information of a Company
- Name (required, max 100 characters)
- Address (required, max 500 characters)
- NIT (required, search) [Primary Key in DB]
- Phone (required only numbers)

For now is global and not oriented to be a SAAS is NOT NEEDED add any relation with USER

## Information of a Product
- Product Name
- Quantity
- Foreign Key (NIT of Company)
