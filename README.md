# Blockbuster DBMS — Movie Rental RDBMS + WinForms Demo

> A mockup relational database for a movie-rental company, with a C# WinForms sample app and a PostgreSQL DDL script. ([GitHub][1])

## Table of contents

* [Overview](#overview) • [Tech stack](#tech-stack) • [Repository structure](#repository-structure)
* [Quickstart](#quickstart) • [Database setup (PostgreSQL)](#database-setup-postgresql) • [WinForms demo app](#winforms-demo-app)
* [Data dictionary](#data-dictionary) • [Troubleshooting](#troubleshooting) • [Roadmap](#roadmap) • [License](#license)

---

## Overview

This project provides:

* a **PostgreSQL schema** for a Blockbuster-style rental system (actors, films, inventory, customers, payments, etc.), and
* a **C# WinForms** sample application scaffold under `blockbuster/WinFormsApp1/`. ([GitHub][1])

The README in the repo lists the **relational schema** (entities such as `actor`, `film`, `film_actor`, `film_category`, `inventory`, `customer`, `payment`, `staff`, `store`, etc.), indicating PostgreSQL column types (e.g., `timestamp without time zone`, `smallint`). ([GitHub][1])

---

## Tech stack

* **Database:** PostgreSQL (types in the schema use PostgreSQL syntax) ([GitHub][1])
* **Application:** C# **WinForms** (Windows desktop UI) under `blockbuster/WinFormsApp1` ([GitHub][1])
* **Languages (GitHub):** \~50% C#, \~49% PL/pgSQL. ([GitHub][1])

---

## Repository structure

```
.
├─ blockbuster/
│  └─ WinFormsApp1/         # C# WinForms sample (open in Visual Studio)
├─ blockbusterDB.sql        # PostgreSQL schema (tables, columns)
├─ iliskisel_sema.md        # Relational schema notes (TR)
└─ README.md                # Basic schema listing
```

Folders and files as shown on the repo home. ([GitHub][1])

---

## Quickstart

### Prerequisites

* **PostgreSQL** 13+ (psql or pgAdmin)
* **Windows + Visual Studio** (for the WinForms sample)

### Clone

```bash
git clone https://github.com/ahadpaksoy/blockbusterDBMS.git
cd blockbusterDBMS
```

---

## Database setup (PostgreSQL)

1. **Create a database** (e.g., `blockbuster`), then run the DDL script:

```bash
# from repo root, using psql
psql -U <user> -h <host> -d blockbuster -f blockbusterDB.sql
```

> The schema uses PostgreSQL types like `timestamp without time zone` and `smallint`, so PostgreSQL is the intended target. ([GitHub][1])

2. *(Optional)* **Seed data**
   If you don’t yet have sample rows, you can insert a few basics to test joins (e.g., one `language`, a couple of `category` and `film` rows, then `film_category`, `actor`, and `film_actor`). The repo does not include a seed file, so add your own minimal records.

---

## WinForms demo app

1. **Open the project**

   * Launch **Visual Studio**, open `blockbuster/WinFormsApp1/`. ([GitHub][1])

2. **Configure the connection**

   * Set the DB connection string in the app’s configuration or initialization code (the sample is a plain WinForms project; point it to your PostgreSQL instance created above).

3. **Build & run**

   * Build the solution and run. Use the forms to experiment with CRUD operations once the UI is wired to the DB.

> The repo exposes the WinForms project path and C# as a top language, but keeps app details minimal; expect to add or adjust forms, connection strings, and queries as needed. ([GitHub][1])

---

## Data dictionary

The README lists the core tables (field names/types abbreviated below). **Note:** some names appear with typos (e.g., `lenght`, `intventory`, `small_id`); keep them consistent with the SQL until you refactor. ([GitHub][1])

* **actor** — `actor_id`, `first_name`, `last_name`, `last_update`. ([GitHub][1])
* **address** — `address_id`, `address`, `city_id`, `postal_code`, `phone`, `last_update`. ([GitHub][1])
* **category** — `category_id`, `name`, `last_update`. ([GitHub][1])
* **city** — `city_id`, `city`, `country_id`, `last_update`. ([GitHub][1])
* **country** — `country_id`, `country`, `last_update`. ([GitHub][1])
* **customer** — `customer_id`, `store_id`, `first_name`, `last_name`, `email`, `address_id`, `activebool`, `create_date`, `last_update`. ([GitHub][1])
* **film** — `film_id`, `title`, `description`, `release_year`, `language_id`, `replacement_cost`, `rating`, `lenght`, `last_update`. ([GitHub][1])
* **film\_actor** — `actor_id`, `film_id`, `last_update`. ([GitHub][1])
* **film\_category** — `film_id` *(listed as `small_id` in README)*, `category_id`, `last_update`. ([GitHub][1])
* **inventory** — `intventory` *(typo for inventory id?)*, `film_id`, `store_id`, `last_update`. ([GitHub][1])
* **language** — `language_id`, `name`, `last_update`. ([GitHub][1])
* **payment** — `payment_id`, `customer_id`, `staff_id`, `rental_id`, `amount`, `payment_date`. ([GitHub][1])
* **staff** — `staff_id`, `first_name`, `last_name`, `address_id`, `email`, `active`, `username`, `password`, `last_update`. ([GitHub][1])
* **store** — `store_id`, `manager_staff_id`, `address_id`, `last_update`. ([GitHub][1])
* **update\_counter** — `update_counter_insert`, `update_counter_delete`, `update_counter_update`. ([GitHub][1])

**Intended relationships (typical for rental schemas):**

* `film` ⟷ `film_actor` ⟷ `actor`
* `film` ⟷ `film_category` ⟷ `category`
* `inventory(film_id)` → `film`, `inventory(store_id)` → `store`
* `customer(address_id)` → `address` → `city` → `country`
* `staff(address_id)` → `address`; `store(manager_staff_id)` → `staff`
* `payment(customer_id)` → `customer`, `payment(staff_id)` → `staff`

> FK definitions may live in `blockbusterDB.sql`. The README also references a `rental_id` in `payment`, but the `rental` table isn’t listed there; verify and add/adjust DDL as needed. ([GitHub][1])

---

## Troubleshooting

* **`psql: relation already exists`** → drop or use `CREATE TABLE IF NOT EXISTS` in your local copy of the DDL.
* **WinForms cannot connect** → verify the connection string (host, db, user, password, port) and that PostgreSQL accepts TCP connections (`pg_hba.conf`).
* **Typos in column names (`lenght`, `intventory`)** → either keep them as-is (to match the DDL) or rename consistently in both DB and app code with a migration.

---

## Roadmap (suggested)

* Add **primary keys, foreign keys, and indexes** explicitly if not already in `blockbusterDB.sql`.
* Provide a **seed script** and a **minimal CRUD form** wired to a few key tables (e.g., Film, Actor, Inventory).
* Add **Docker Compose** (PostgreSQL + Adminer/pgAdmin) for one-command spin-up.
* Replace typos in schema (`lenght` → `length`, `intventory` → `inventory_id`, etc.) with a migration and update references.
* Publish a **diagram** (ERD) under `/docs/` or `iliskisel_sema.md` and link it from this README.


[1]: https://github.com/ahadpaksoy/blockbusterDBMS "GitHub - ahadpaksoy/blockbusterDBMS: This is a mockup version of a movie rental companys rdbms"
