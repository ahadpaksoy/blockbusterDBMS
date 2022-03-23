# Reletional Schema

actor(actor_id: int, first_name: varchar, last_name: varchar,last_update: timestamp without timezone)

address(address_id: int, address: varchar, city_id: smallint, postal_code: varchar, phone: varchar, last_update: timestamp without time zone)

category(category_id: int, name: varchar, last_update: timestamp without time zone)

city(city_id: int, city: varchar, country_id: smallint, last_update: timestamp without time zone)

country(country_id: int, country: varchar, last_update: timestamp without time zone)

customer(customer_id: int, store_id: int, first_name: varchar, last_name: varchar,
email: varchar, address_id: smallint,
activebool: boolean, create_date: timestamp without time zone,
last_update: timestamp without time zone)

film(film_id: int, title: varchar, description: varchar, release_year: timestamp without time zone,
language_id: varchar, replacement_cost: numeric, rating: varchar,
lenght: smallint, last_update: timestamp without time zone)

film_actor(actor_id: smallint, film_id: smallint, last_update: timestamp without time zone)

film_category(film_id: small_id, category_id: smallint, last_update:timestamp without time zone)

inventory(intventory: int, film_id: smallint, store_id: smallint, last_update: timestamp without time zone)

language(language_id: varchar, name: varchar, last_update: timestamp without time zone)

payment(payment_id: int, customer_id: smallint, staff_id: smallint, rental_id: int, amount: numeric,payment_date: timestamp without time zone,)

staff(staff_id: int, first_name: varchar, last_name: varchar, address_id: smallint, email: varchar, active: boolean,
username: varchar, password: varchar, last_update: timestamp without time zone)

store(store_id: int, manager_staff_id: smallint, address_id: smallint, last_update: timestamp without time zone)

update_counter(update_counter_insert: smallint, update_counter_delete: smallint, update_counter_update: smallint)
