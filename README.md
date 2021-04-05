"# fashion-ecom-ns"

# Requirement

Build an ecommerce web site with minimum functionality below:

**For customers:**

- Home page: category menu, features products
- View products by category
- View product details
- Product rating
- Register
- Login/Logout
- Optional (shopping cart, ordering)

**For admin:**

- Login/logout
- Manage product categories (Name, Description)
- Manage products (Name, Category, Description, Price, Images, CreatedDate, UpdatedDate)
- View customers

# Resource

- Jpopup - https://github.com/robiveli/jpopup
- Splidejs - https://github.com/Splidejs/splide
- Normalize - https://necolas.github.io/normalize.css/
- Bootstrap (Grid System) - https://github.com/twbs/bootstrap
- Line Awesome - https://icons8.com/line-awesome

# ERD
![Image Erd](https://github.com/vtoan/fashion-ecom-ns/blob/doc/docs/fashion_ns_ecom_db.png)

# Service Diagram
![Image Service](https://github.com/vtoan/fashion-ecom-ns/blob/doc/docs/service%20diagram.png)

# Use EF Migrations on different Assembly
## add migrations
- On Assembly contain BbContext 
```
    dotnet ef migrations add Init -s ../Core
```
With "Core" is Project StartUp

