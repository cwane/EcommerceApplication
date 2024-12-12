# E-Commerce Single Page Application (SPA)

This repository contains an **E-Commerce Single Page Application (SPA)** developed using **ASP.NET Core MVC 8**. 
The application allows users to view products, see detailed information about each product without page reloads, 
and add products to the cart.

---

## Features

### 🛍️ Product Listing
- Displays all available products on the home page.
- Each product includes a title, author, ISBN, list price, and image.

### 🔍 Product Details
- View detailed information about a selected product.
- Product details are displayed dynamically without page reloads.

### ➕ Add to Cart
- Users can select the quantity of a product and add it to the cart.
- A success alert pops up when an item is added to the cart.

### 🏠 Back to Home
- Navigate back to the home page without reloading the page.

### 🔒 User Authentication
- User registration, login, and logout functionalities implemented using **ASP.NET Core Identity**.

---

## Models

### Product

The `Product` model stores details about each product.

### CartItem

The `CartItem` model stores details about the quantity of each product to be added in cart product.



