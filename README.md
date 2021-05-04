# Assignment Requirement

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
<hr/>

# Feature
### For customer site
- View products by category.
- Search products with product name.
- Sort products with price.
- Paging.
- View product details.
- Chosse Size of product to Add To Cart.
- View gallery mage of product.
- Product rating.
- Shopping cart page.
- Checkout page.
- Login/Logout

### For admin site
- View products (include Filter, Sort, Search)
- Create/Edit/Delete product (include manage Size, Gallery)
- View categories (include  Filter by Type)
- Create/Edit/Delete category
- View current users 
- Login/Logout
<hr/>

![Fashion Project]https://github.com/vtoan/fashion-ecom-ns/blob/main/docs/Fashion%20Architecture.png)

<hr/>

# I. Backend Project (.NETCore Api)
### 1. Using
- .NET 5.0 (with API Project Template)
- Entity Framework 6
- AutoMapper 7
- Identity intergate IdentityServer 4
- Swagger
### 2. Architecture 
#### Structure
![BackEnd Project](https://github.com/vtoan/fashion-ecom-ns/blob/main/docs/Project%20Architecture.png)
#### ERD
![Image Erd](https://github.com/vtoan/fashion-ecom-ns/blob/main/docs/fashion_ns_ecom_db.png)
####  Service Class Diagram
![Image Service](https://github.com/vtoan/fashion-ecom-ns/blob/main/docs/service%20diagram.png)
### 3. Set up
1. Restore packages in projects with Dotnet CLI: 
 ```cmd 
 dotnet restore 
 ```
3. Change Client URLs in path `../Core/appsettings.json` (if run it on diffrent host/domain)
4. Change ConnectionStrings in path `../Core/appsettings.json`

<b>TIP</b>. Use EF Migrations on different Assembly
- On Assembly contain BbContext, with "Core" is WebApi Project (Start-Up Project)
Add migrations
```cmd
dotnet ef migrations add Init -s ../Core
```
Database update
```cmd
dotnet ef database update -s ../Core
```
<hr/>

# II. Customer Site (.NETCore Mvc)
### 1. Using
- Dependency Injection (Services).
- Partial View.
- Tag Helpper.
- View Component.
- Session Storage.
### 2. Resource reference
- Jpopup - https://github.com/robiveli/jpopup
- Splidejs - https://github.com/Splidejs/splide
- Normalize - https://necolas.github.io/normalize.css/
- Bootstrap (Grid System) - https://github.com/twbs/bootstrap
- Line Awesome - https://icons8.com/line-awesome
### 3. Set up
1. Restore packages in projects with Dotnet CLI: 
 ```cmd 
 dotnet restore 
 ```
2. Change Backend URLs and Image Res in path `../CustomerSite/appsettings.json` (if run it on diffrent host/domain)

<hr/>

# III. Admin Site (ReactJS)
### 1. Using
- React 17.0.2
- Intergate IdentityServer 4
- Redux
### 2. Resource reference
- Axios - https://github.com/axios/axios
- Reactstrap - https://reactstrap.github.io/components/pagination/#
- React-Toastify - https://github.com/fkhadra/react-toastify
- redux-Thunk - https://github.com/reduxjs/redux-thunk
- Oidc-Client - https://github.com/IdentityModel/oidc-client-js
- React-router-dom - https://reactrouter.com/web/guides/quick-start
### 3. Set up
1. Install packages in project with Bash: 
 ```cmd 
 npm install 
 ```
2. Change Backend URLs and Image Res in path `../config.js` (if run it on diffrent host/domain)
3. Change Client Config in path `../services/authService.js`.




