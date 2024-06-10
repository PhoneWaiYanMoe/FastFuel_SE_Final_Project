# README.txt

## Project: Fast Fuel (Fast food change)

### Overview
This project provides the server side and client side for food ordering system which is called "Fast Fuel". We cover the whole fast food change system consisting of
-Touch Screen Pos Point Of Sale Machine:
• Windows Form / Web Form for the demos
• Payment demo (via e-wallet like VNPay. Paypal,..)
- Staffs use: (need a login function)
• Windows Form Project Build: staff of stores use when they are in the office.
• Web Forms Project: staff of store/company use when they are working from home.
- Agents use (at each store): (either need an Agent ID / Agent Login: should be created by staff)
• When agents make a payment can link with e-wallet
• Agent order confirmation: can be sent via Email or Instant Message based on Mobile Phone
- B2C Ecommerce Website/Mobile App: Order & Payment function like Touch POS above
• Any technology but make sure that the website connects to the same database MSSQL (*)
• Should connect to database via API or class library instead of connecting directly to the MSSQL
Database

### Prerequisites
Before you begin, ensure you have the following:
-MSSQL
-Visual Studio

# Reference : Mc'Donald

### Instructions

Touch Screen POS For Customers
- File name : FastFoodPOS (Made with windowForm-C#)
- SQL db name : FastFood (Users,Orders,Payments,Foods)
- Install the packages you might need to run your application

. The user can select dine in or take away
. The user can check the menu via categories
. The user can check the order summary
. The user can make payments with the options (cash,E-wallet,credit card)
. The data are saved in both orders and payments table.

E-Commerce Website For Customers
- File name : FastFuel (Made with Razor-C#)
- SQL db name : FastFood (Users,Orders,UserVouchers,Voucher,Payments,Foods) //The same table with POS
- Install the packages you might need to run your application

. The user can register the account.
. The user can log in.
. The user can change the password.(Password is encrypted)
. The user can check the menu via categories
. The user can check the order summary
. The user can make payments with the options (cash,E-wallet,credit card)
.The user can use the one-time used vouchers while purchasing.
. The data are saved in both orders and payments table.
. The data are saved in database.

Agents
- File name : Agents (Made with windowForm)
- SQL db name : FastFood (Users,Orders,Payments,Foods)
- Install the packages you might need to run your application

. Agents(Cashier) can check the orders and update order from the users.
. Agents can make payments. 
. The data are saved in the database

Staffs
- File name : Winformstaff (Made with windowForm)
- SQL db name : FastFood (Users,Orders,Payments,Foods)
- Install the packages you might need to run your application
  
- File name :  webstaff (Made with Razor)
- SQL db name : FastFood (Users,Orders,Payments,Foods)
- Install the packages you might need to run your application

. Staffs(Admins) make agent accounts
. Staffs create the menu
. Staffs give global vouchers
. The data are saved in the database.
