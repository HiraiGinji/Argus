# Argus POS

> A Point-of-Sale and inventory management system backed by a MySQL/MariaDB database. **Beta version.**

Argus helps small retail shops handle day-to-day sales: ringing up items, tracking stock, and keeping a record of transactions and inventory changes.

---

## Features

- **POS cart & checkout**: add products to a cart and complete sales with per-item totals
- **Inventory management**: add, update, and delete products with price, quantity, and expiry date
- **Inventory audit log**: every insert, update, and delete is recorded with a date, product ID, and message
- **Transaction records**: sales history with item, price, discount, total bill, and date
- **User accounts**: registration with name, email, contact number, region, and city
- **Admin / user roles**: accounts carry an admin flag for privileged access

## Tech Stack

| Layer    | Technology                                      |
| -------- | ----------------------------------------------- |
| App      | Visual Studio solution (`Argus.sln`)            |
| Database | MySQL / MariaDB (dump exported via phpMyAdmin)  |
| Local DB | XAMPP (MariaDB 10.4, PHP 8.2 used for the dump) |

## Project Structure

```
Argus/
├── Argus/          # Main application project
├── Argus-master/   # Additional copy of the project source
├── Argus.sln       # Visual Studio solution
├── argus.sql       # Database schema + sample data
├── .gitattributes
└── .gitignore
```

## Database Schema

The `argus` database contains these tables:

| Table              | Purpose                                  | Key columns                                                     |
| ------------------ | ---------------------------------------- | --------------------------------------------------------------- |
| `accounts`         | User and admin accounts                  | `USERID` (PK), `EMAIL`, `PASSWORD`, `REGION`, `CITY`, `ISADMIN` |
| `inventory`        | Products currently in stock              | `PID` (PK), `PNAME`, `ITEMPRICE`, `QTY`, `EXPIRY_DATE`          |
| `inventory_logs`   | Audit trail of inventory changes         | `DATETIME`, `PID`, `LOG`, `FUNCTION` (INSERT / UPDATE / DELETE) |
| `item_transaction` | Completed sales records                  | `TID` (PK), `PID`, `ITEM`, `PRICE`, `DISC`, `TBILL`, `DATE`     |
| `pos_cart`         | Items in the current cart during checkout| `TRANSACTIONID`, `PID`, `pname`, `quantity`, `price`, `total`   |

## Getting Started

### Prerequisites

- [Visual Studio](https://visualstudio.microsoft.com/) (2022 or later recommended)
- [XAMPP](https://www.apachefriends.org/) (or any MySQL/MariaDB server)

### Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/HiraiGinji/Argus.git
   cd Argus
   ```

2. **Start MySQL/MariaDB**
   Open the XAMPP Control Panel and start the **MySQL** module (and **Apache** if you want phpMyAdmin).

3. **Import the database**
   - Open phpMyAdmin at `http://localhost/phpmyadmin`
   - Create a new database named `argus`
   - Select it, go to **Import**, and choose `argus.sql`

   Or from the command line:
   ```bash
   mysql -u root -p -e "CREATE DATABASE argus;"
   mysql -u root -p argus < argus.sql
   ```

4. **Configure the connection**
   Update the database connection string in the project to match your local setup (host `127.0.0.1`, database `argus`, your MySQL username and password).

5. **Build and run**
   Open `Argus.sln` in Visual Studio, restore any NuGet packages, then press **F5** to run.

## Usage

1. Log in with an account from the `accounts` table (or register a new one).
2. **Admins** can manage inventory: add, edit, and remove products.
3. Add products to the cart, apply a discount if needed, and complete the transaction.
4. Review sales in the transaction records and changes in the inventory logs.

## Security Notes

- Do **not** commit real customer data or credentials to the repository.
- Replace the sample accounts in `argus.sql` before any real deployment.
- Use a dedicated database user with limited privileges instead of `root`.
- Store passwords with a strong, salted hashing algorithm (e.g. bcrypt or Argon2).

Created by [HiraiGinji](https://github.com/HiraiGinji).
