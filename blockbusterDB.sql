--
-- PostgreSQL database dump
--

-- Dumped from database version 14.1
-- Dumped by pg_dump version 14.1

-- Started on 2021-12-20 16:24:15

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- TOC entry 229 (class 1255 OID 17595)
-- Name: bringfilms(character varying); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.bringfilms(variable character varying) RETURNS TABLE(film_id_column integer, title_column character varying, language_id_column character varying, rating_column character varying, lenght_column smallint)
    LANGUAGE plpgsql
    AS $$
begin
	return query
	select
	film_id,title,language_id,rating,lenght
	from
	film
	where title like variable;
end;
$$;


ALTER FUNCTION public.bringfilms(variable character varying) OWNER TO postgres;

--
-- TOC entry 230 (class 1255 OID 17596)
-- Name: bringfilmslanguage(character varying); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.bringfilmslanguage(variable character varying) RETURNS TABLE(language_id_column character varying, film_id_column integer, title_column character varying, rating_column character varying, lenght_column smallint)
    LANGUAGE plpgsql
    AS $$
begin
	return query
	select
	language_id,film_id,title,rating,lenght
	from
	film
	where language_id like variable;
end;
$$;


ALTER FUNCTION public.bringfilmslanguage(variable character varying) OWNER TO postgres;

--
-- TOC entry 226 (class 1255 OID 17514)
-- Name: last_updated(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.last_updated() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
BEGIN
    NEW.last_update = CURRENT_TIMESTAMP;
    RETURN NEW;
END 
$$;


ALTER FUNCTION public.last_updated() OWNER TO postgres;

--
-- TOC entry 228 (class 1255 OID 17497)
-- Name: update_counter_delete(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.update_counter_delete() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
	begin
	update update_counter set update_counter_delete= update_counter_delete+1;
	return new;
	end;
$$;


ALTER FUNCTION public.update_counter_delete() OWNER TO postgres;

--
-- TOC entry 227 (class 1255 OID 17532)
-- Name: update_counter_insert(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.update_counter_insert() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
	begin
	update update_counter set update_counter_insert= update_counter_insert+1;
	return new;
	end;
$$;


ALTER FUNCTION public.update_counter_insert() OWNER TO postgres;

--
-- TOC entry 231 (class 1255 OID 17540)
-- Name: update_counter_update(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.update_counter_update() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
	begin
	update update_counter set update_counter_update= update_counter_update+1;
	return new;
	end;
$$;


ALTER FUNCTION public.update_counter_update() OWNER TO postgres;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- TOC entry 209 (class 1259 OID 16886)
-- Name: actor; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.actor (
    actor_id integer NOT NULL,
    first_name character varying(45) NOT NULL,
    last_name character varying(45) NOT NULL,
    last_update timestamp without time zone DEFAULT now() NOT NULL
);


ALTER TABLE public.actor OWNER TO postgres;

--
-- TOC entry 212 (class 1259 OID 16912)
-- Name: address; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.address (
    address_id integer NOT NULL,
    address character varying(50) NOT NULL,
    city_id smallint NOT NULL,
    postal_code character varying(10),
    phone character varying(20) NOT NULL,
    last_update timestamp without time zone DEFAULT now() NOT NULL
);


ALTER TABLE public.address OWNER TO postgres;

--
-- TOC entry 216 (class 1259 OID 17283)
-- Name: category; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.category (
    category_id integer NOT NULL,
    name character varying(25) NOT NULL,
    last_update timestamp without time zone DEFAULT now() NOT NULL
);


ALTER TABLE public.category OWNER TO postgres;

--
-- TOC entry 211 (class 1259 OID 16898)
-- Name: city; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.city (
    city_id integer NOT NULL,
    city character varying(50) NOT NULL,
    country_id smallint NOT NULL,
    last_update timestamp without time zone DEFAULT now() NOT NULL
);


ALTER TABLE public.city OWNER TO postgres;

--
-- TOC entry 210 (class 1259 OID 16892)
-- Name: country; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.country (
    country_id integer NOT NULL,
    country character varying(50) NOT NULL,
    last_update timestamp without time zone DEFAULT now() NOT NULL
);


ALTER TABLE public.country OWNER TO postgres;

--
-- TOC entry 222 (class 1259 OID 17369)
-- Name: customer; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.customer (
    customer_id integer NOT NULL,
    store_id smallint NOT NULL,
    first_name character varying(45) NOT NULL,
    last_name character varying(45) NOT NULL,
    email character varying(50),
    address_id smallint NOT NULL,
    activebool boolean DEFAULT true NOT NULL,
    create_date date DEFAULT ('now'::text)::date NOT NULL,
    last_update timestamp without time zone DEFAULT now()
);


ALTER TABLE public.customer OWNER TO postgres;

--
-- TOC entry 214 (class 1259 OID 17250)
-- Name: film; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.film (
    film_id integer NOT NULL,
    title character varying(25) NOT NULL,
    description character varying(120),
    release_year timestamp without time zone NOT NULL,
    language_id character varying(4) NOT NULL,
    replacement_cost numeric(5,2) DEFAULT 14.00 NOT NULL,
    rating character varying NOT NULL,
    last_update timestamp without time zone NOT NULL,
    lenght smallint NOT NULL
);


ALTER TABLE public.film OWNER TO postgres;

--
-- TOC entry 217 (class 1259 OID 17289)
-- Name: film_actor; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.film_actor (
    actor_id smallint NOT NULL,
    film_id smallint NOT NULL,
    last_update timestamp without time zone DEFAULT now() NOT NULL
);


ALTER TABLE public.film_actor OWNER TO postgres;

--
-- TOC entry 221 (class 1259 OID 17353)
-- Name: film_category; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.film_category (
    film_id smallint NOT NULL,
    category_id smallint NOT NULL,
    last_update timestamp without time zone DEFAULT now() NOT NULL
);


ALTER TABLE public.film_category OWNER TO postgres;

--
-- TOC entry 213 (class 1259 OID 17249)
-- Name: film_film_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.film_film_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.film_film_id_seq OWNER TO postgres;

--
-- TOC entry 3503 (class 0 OID 0)
-- Dependencies: 213
-- Name: film_film_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.film_film_id_seq OWNED BY public.film.film_id;


--
-- TOC entry 220 (class 1259 OID 17342)
-- Name: inventory; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.inventory (
    inventory_id integer NOT NULL,
    film_id smallint NOT NULL,
    store_id smallint NOT NULL,
    last_update timestamp without time zone DEFAULT now() NOT NULL
);


ALTER TABLE public.inventory OWNER TO postgres;

--
-- TOC entry 215 (class 1259 OID 17271)
-- Name: language; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.language (
    language_id character varying(4) NOT NULL,
    name character(20) NOT NULL,
    last_update timestamp without time zone DEFAULT now() NOT NULL
);


ALTER TABLE public.language OWNER TO postgres;

--
-- TOC entry 224 (class 1259 OID 17422)
-- Name: payment; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.payment (
    payment_id integer NOT NULL,
    customer_id smallint NOT NULL,
    staff_id smallint NOT NULL,
    rental_id integer NOT NULL,
    amount numeric(5,2) NOT NULL,
    payment_date timestamp without time zone NOT NULL,
    last_update timestamp without time zone DEFAULT now() NOT NULL
);


ALTER TABLE public.payment OWNER TO postgres;

--
-- TOC entry 223 (class 1259 OID 17398)
-- Name: rental; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.rental (
    rental_id integer NOT NULL,
    rental_date timestamp without time zone NOT NULL,
    inventory_id integer NOT NULL,
    customer_id smallint NOT NULL,
    return_date timestamp without time zone,
    staff_id smallint NOT NULL,
    last_update timestamp without time zone DEFAULT now() NOT NULL
);


ALTER TABLE public.rental OWNER TO postgres;

--
-- TOC entry 219 (class 1259 OID 17322)
-- Name: staff; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.staff (
    staff_id integer NOT NULL,
    first_name character varying(45) NOT NULL,
    last_name character varying(45) NOT NULL,
    address_id smallint NOT NULL,
    email character varying(50),
    store_id smallint NOT NULL,
    active boolean DEFAULT true NOT NULL,
    username character varying(16) NOT NULL,
    password character varying(40),
    last_update timestamp without time zone DEFAULT now() NOT NULL
);


ALTER TABLE public.staff OWNER TO postgres;

--
-- TOC entry 218 (class 1259 OID 17308)
-- Name: store; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.store (
    store_id integer NOT NULL,
    manager_staff_id smallint NOT NULL,
    address_id smallint NOT NULL,
    last_update timestamp without time zone DEFAULT now() NOT NULL
);


ALTER TABLE public.store OWNER TO postgres;

--
-- TOC entry 225 (class 1259 OID 17533)
-- Name: update_counter; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.update_counter (
    update_counter_insert smallint,
    update_counter_delete smallint,
    update_counter_update smallint DEFAULT '0'::smallint
);


ALTER TABLE public.update_counter OWNER TO postgres;

--
-- TOC entry 3235 (class 2604 OID 17537)
-- Name: film film_id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.film ALTER COLUMN film_id SET DEFAULT nextval('public.film_film_id_seq'::regclass);


--
-- TOC entry 3251 (class 2606 OID 16891)
-- Name: actor actor_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.actor
    ADD CONSTRAINT actor_pkey PRIMARY KEY (actor_id);


--
-- TOC entry 3257 (class 2606 OID 16917)
-- Name: address address_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.address
    ADD CONSTRAINT address_pkey PRIMARY KEY (address_id);


--
-- TOC entry 3264 (class 2606 OID 17288)
-- Name: category category_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.category
    ADD CONSTRAINT category_pkey PRIMARY KEY (category_id);


--
-- TOC entry 3255 (class 2606 OID 16903)
-- Name: city city_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.city
    ADD CONSTRAINT city_pkey PRIMARY KEY (city_id);


--
-- TOC entry 3253 (class 2606 OID 16897)
-- Name: country country_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.country
    ADD CONSTRAINT country_pkey PRIMARY KEY (country_id);


--
-- TOC entry 3276 (class 2606 OID 17376)
-- Name: customer customer_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.customer
    ADD CONSTRAINT customer_pkey PRIMARY KEY (customer_id);


--
-- TOC entry 3266 (class 2606 OID 17294)
-- Name: film_actor film_actor_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.film_actor
    ADD CONSTRAINT film_actor_pkey PRIMARY KEY (actor_id, film_id);


--
-- TOC entry 3274 (class 2606 OID 17358)
-- Name: film_category film_category_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.film_category
    ADD CONSTRAINT film_category_pkey PRIMARY KEY (film_id, category_id);


--
-- TOC entry 3259 (class 2606 OID 17258)
-- Name: film film_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.film
    ADD CONSTRAINT film_pkey PRIMARY KEY (film_id);


--
-- TOC entry 3272 (class 2606 OID 17347)
-- Name: inventory inventory_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.inventory
    ADD CONSTRAINT inventory_pkey PRIMARY KEY (inventory_id);


--
-- TOC entry 3262 (class 2606 OID 17276)
-- Name: language language_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.language
    ADD CONSTRAINT language_pkey PRIMARY KEY (language_id);


--
-- TOC entry 3280 (class 2606 OID 17426)
-- Name: payment payment_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.payment
    ADD CONSTRAINT payment_pkey PRIMARY KEY (payment_id);


--
-- TOC entry 3278 (class 2606 OID 17403)
-- Name: rental rental_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.rental
    ADD CONSTRAINT rental_pkey PRIMARY KEY (rental_id);


--
-- TOC entry 3270 (class 2606 OID 17328)
-- Name: staff staff_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.staff
    ADD CONSTRAINT staff_pkey PRIMARY KEY (staff_id);


--
-- TOC entry 3268 (class 2606 OID 17313)
-- Name: store store_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.store
    ADD CONSTRAINT store_pkey PRIMARY KEY (store_id);


--
-- TOC entry 3260 (class 1259 OID 17282)
-- Name: fki_language_id; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX fki_language_id ON public.film USING btree (language_id);


--
-- TOC entry 3302 (class 2620 OID 17515)
-- Name: actor last_updated; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER last_updated BEFORE UPDATE ON public.actor FOR EACH ROW EXECUTE FUNCTION public.last_updated();


--
-- TOC entry 3311 (class 2620 OID 17517)
-- Name: address last_updated; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER last_updated BEFORE UPDATE ON public.address FOR EACH ROW EXECUTE FUNCTION public.last_updated();


--
-- TOC entry 3326 (class 2620 OID 17518)
-- Name: category last_updated; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER last_updated BEFORE UPDATE ON public.category FOR EACH ROW EXECUTE FUNCTION public.last_updated();


--
-- TOC entry 3310 (class 2620 OID 17519)
-- Name: city last_updated; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER last_updated BEFORE UPDATE ON public.city FOR EACH ROW EXECUTE FUNCTION public.last_updated();


--
-- TOC entry 3306 (class 2620 OID 17516)
-- Name: country last_updated; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER last_updated BEFORE UPDATE ON public.country FOR EACH ROW EXECUTE FUNCTION public.last_updated();


--
-- TOC entry 3347 (class 2620 OID 17520)
-- Name: customer last_updated; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER last_updated BEFORE UPDATE ON public.customer FOR EACH ROW EXECUTE FUNCTION public.last_updated();


--
-- TOC entry 3315 (class 2620 OID 17521)
-- Name: film last_updated; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER last_updated BEFORE UPDATE ON public.film FOR EACH ROW EXECUTE FUNCTION public.last_updated();


--
-- TOC entry 3330 (class 2620 OID 17522)
-- Name: film_actor last_updated; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER last_updated BEFORE UPDATE ON public.film_actor FOR EACH ROW EXECUTE FUNCTION public.last_updated();


--
-- TOC entry 3346 (class 2620 OID 17523)
-- Name: film_category last_updated; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER last_updated BEFORE UPDATE ON public.film_category FOR EACH ROW EXECUTE FUNCTION public.last_updated();


--
-- TOC entry 3342 (class 2620 OID 17524)
-- Name: inventory last_updated; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER last_updated BEFORE UPDATE ON public.inventory FOR EACH ROW EXECUTE FUNCTION public.last_updated();


--
-- TOC entry 3322 (class 2620 OID 17525)
-- Name: language last_updated; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER last_updated BEFORE UPDATE ON public.language FOR EACH ROW EXECUTE FUNCTION public.last_updated();


--
-- TOC entry 3355 (class 2620 OID 17526)
-- Name: payment last_updated; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER last_updated BEFORE UPDATE ON public.payment FOR EACH ROW EXECUTE FUNCTION public.last_updated();


--
-- TOC entry 3351 (class 2620 OID 17527)
-- Name: rental last_updated; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER last_updated BEFORE UPDATE ON public.rental FOR EACH ROW EXECUTE FUNCTION public.last_updated();


--
-- TOC entry 3335 (class 2620 OID 17528)
-- Name: staff last_updated; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER last_updated BEFORE UPDATE ON public.staff FOR EACH ROW EXECUTE FUNCTION public.last_updated();


--
-- TOC entry 3334 (class 2620 OID 17529)
-- Name: store last_updated; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER last_updated BEFORE UPDATE ON public.store FOR EACH ROW EXECUTE FUNCTION public.last_updated();


--
-- TOC entry 3300 (class 2620 OID 17539)
-- Name: actor update_counter_delete; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER update_counter_delete AFTER DELETE ON public.actor FOR EACH ROW EXECUTE FUNCTION public.update_counter_delete();


--
-- TOC entry 3312 (class 2620 OID 17542)
-- Name: address update_counter_delete; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER update_counter_delete AFTER DELETE ON public.address FOR EACH ROW EXECUTE FUNCTION public.update_counter_delete();


--
-- TOC entry 3325 (class 2620 OID 17545)
-- Name: category update_counter_delete; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER update_counter_delete AFTER DELETE ON public.category FOR EACH ROW EXECUTE FUNCTION public.update_counter_delete();


--
-- TOC entry 3309 (class 2620 OID 17548)
-- Name: city update_counter_delete; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER update_counter_delete AFTER DELETE ON public.city FOR EACH ROW EXECUTE FUNCTION public.update_counter_delete();


--
-- TOC entry 3305 (class 2620 OID 17551)
-- Name: country update_counter_delete; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER update_counter_delete AFTER DELETE ON public.country FOR EACH ROW EXECUTE FUNCTION public.update_counter_delete();


--
-- TOC entry 3348 (class 2620 OID 17554)
-- Name: customer update_counter_delete; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER update_counter_delete AFTER DELETE ON public.customer FOR EACH ROW EXECUTE FUNCTION public.update_counter_delete();


--
-- TOC entry 3316 (class 2620 OID 17557)
-- Name: film update_counter_delete; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER update_counter_delete AFTER DELETE ON public.film FOR EACH ROW EXECUTE FUNCTION public.update_counter_delete();


--
-- TOC entry 3329 (class 2620 OID 17560)
-- Name: film_actor update_counter_delete; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER update_counter_delete AFTER DELETE ON public.film_actor FOR EACH ROW EXECUTE FUNCTION public.update_counter_delete();


--
-- TOC entry 3345 (class 2620 OID 17563)
-- Name: film_category update_counter_delete; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER update_counter_delete AFTER DELETE ON public.film_category FOR EACH ROW EXECUTE FUNCTION public.update_counter_delete();


--
-- TOC entry 3341 (class 2620 OID 17566)
-- Name: inventory update_counter_delete; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER update_counter_delete AFTER DELETE ON public.inventory FOR EACH ROW EXECUTE FUNCTION public.update_counter_delete();


--
-- TOC entry 3321 (class 2620 OID 17571)
-- Name: language update_counter_delete; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER update_counter_delete AFTER DELETE ON public.language FOR EACH ROW EXECUTE FUNCTION public.update_counter_delete();


--
-- TOC entry 3356 (class 2620 OID 17576)
-- Name: payment update_counter_delete; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER update_counter_delete AFTER DELETE ON public.payment FOR EACH ROW EXECUTE FUNCTION public.update_counter_delete();


--
-- TOC entry 3352 (class 2620 OID 17579)
-- Name: rental update_counter_delete; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER update_counter_delete AFTER DELETE ON public.rental FOR EACH ROW EXECUTE FUNCTION public.update_counter_delete();


--
-- TOC entry 3336 (class 2620 OID 17582)
-- Name: staff update_counter_delete; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER update_counter_delete AFTER DELETE ON public.staff FOR EACH ROW EXECUTE FUNCTION public.update_counter_delete();


--
-- TOC entry 3333 (class 2620 OID 17585)
-- Name: store update_counter_delete; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER update_counter_delete AFTER DELETE ON public.store FOR EACH ROW EXECUTE FUNCTION public.update_counter_delete();


--
-- TOC entry 3301 (class 2620 OID 17538)
-- Name: actor update_counter_insert; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER update_counter_insert AFTER INSERT ON public.actor FOR EACH ROW EXECUTE FUNCTION public.update_counter_insert();


--
-- TOC entry 3313 (class 2620 OID 17543)
-- Name: address update_counter_insert; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER update_counter_insert AFTER INSERT ON public.address FOR EACH ROW EXECUTE FUNCTION public.update_counter_insert();


--
-- TOC entry 3324 (class 2620 OID 17546)
-- Name: category update_counter_insert; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER update_counter_insert AFTER INSERT ON public.category FOR EACH ROW EXECUTE FUNCTION public.update_counter_insert();


--
-- TOC entry 3308 (class 2620 OID 17549)
-- Name: city update_counter_insert; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER update_counter_insert AFTER INSERT ON public.city FOR EACH ROW EXECUTE FUNCTION public.update_counter_insert();


--
-- TOC entry 3304 (class 2620 OID 17552)
-- Name: country update_counter_insert; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER update_counter_insert AFTER INSERT ON public.country FOR EACH ROW EXECUTE FUNCTION public.update_counter_insert();


--
-- TOC entry 3349 (class 2620 OID 17555)
-- Name: customer update_counter_insert; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER update_counter_insert AFTER INSERT ON public.customer FOR EACH ROW EXECUTE FUNCTION public.update_counter_insert();


--
-- TOC entry 3317 (class 2620 OID 17558)
-- Name: film update_counter_insert; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER update_counter_insert AFTER INSERT ON public.film FOR EACH ROW EXECUTE FUNCTION public.update_counter_insert();


--
-- TOC entry 3328 (class 2620 OID 17561)
-- Name: film_actor update_counter_insert; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER update_counter_insert AFTER INSERT ON public.film_actor FOR EACH ROW EXECUTE FUNCTION public.update_counter_insert();


--
-- TOC entry 3344 (class 2620 OID 17564)
-- Name: film_category update_counter_insert; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER update_counter_insert AFTER INSERT ON public.film_category FOR EACH ROW EXECUTE FUNCTION public.update_counter_insert();


--
-- TOC entry 3340 (class 2620 OID 17567)
-- Name: inventory update_counter_insert; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER update_counter_insert AFTER INSERT ON public.inventory FOR EACH ROW EXECUTE FUNCTION public.update_counter_insert();


--
-- TOC entry 3320 (class 2620 OID 17572)
-- Name: language update_counter_insert; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER update_counter_insert AFTER INSERT ON public.language FOR EACH ROW EXECUTE FUNCTION public.update_counter_insert();


--
-- TOC entry 3357 (class 2620 OID 17577)
-- Name: payment update_counter_insert; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER update_counter_insert AFTER INSERT ON public.payment FOR EACH ROW EXECUTE FUNCTION public.update_counter_insert();


--
-- TOC entry 3353 (class 2620 OID 17580)
-- Name: rental update_counter_insert; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER update_counter_insert AFTER INSERT ON public.rental FOR EACH ROW EXECUTE FUNCTION public.update_counter_insert();


--
-- TOC entry 3337 (class 2620 OID 17583)
-- Name: staff update_counter_insert; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER update_counter_insert AFTER INSERT ON public.staff FOR EACH ROW EXECUTE FUNCTION public.update_counter_insert();


--
-- TOC entry 3332 (class 2620 OID 17586)
-- Name: store update_counter_insert; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER update_counter_insert AFTER INSERT ON public.store FOR EACH ROW EXECUTE FUNCTION public.update_counter_insert();


--
-- TOC entry 3299 (class 2620 OID 17541)
-- Name: actor update_counter_update; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER update_counter_update AFTER UPDATE ON public.actor FOR EACH ROW EXECUTE FUNCTION public.update_counter_update();


--
-- TOC entry 3314 (class 2620 OID 17544)
-- Name: address update_counter_update; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER update_counter_update AFTER UPDATE ON public.address FOR EACH ROW EXECUTE FUNCTION public.update_counter_update();


--
-- TOC entry 3323 (class 2620 OID 17547)
-- Name: category update_counter_update; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER update_counter_update AFTER UPDATE ON public.category FOR EACH ROW EXECUTE FUNCTION public.update_counter_update();


--
-- TOC entry 3307 (class 2620 OID 17550)
-- Name: city update_counter_update; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER update_counter_update AFTER UPDATE ON public.city FOR EACH ROW EXECUTE FUNCTION public.update_counter_update();


--
-- TOC entry 3303 (class 2620 OID 17553)
-- Name: country update_counter_update; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER update_counter_update AFTER UPDATE ON public.country FOR EACH ROW EXECUTE FUNCTION public.update_counter_update();


--
-- TOC entry 3350 (class 2620 OID 17556)
-- Name: customer update_counter_update; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER update_counter_update AFTER UPDATE ON public.customer FOR EACH ROW EXECUTE FUNCTION public.update_counter_update();


--
-- TOC entry 3318 (class 2620 OID 17559)
-- Name: film update_counter_update; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER update_counter_update AFTER UPDATE ON public.film FOR EACH ROW EXECUTE FUNCTION public.update_counter_update();


--
-- TOC entry 3327 (class 2620 OID 17562)
-- Name: film_actor update_counter_update; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER update_counter_update AFTER UPDATE ON public.film_actor FOR EACH ROW EXECUTE FUNCTION public.update_counter_update();


--
-- TOC entry 3343 (class 2620 OID 17565)
-- Name: film_category update_counter_update; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER update_counter_update AFTER UPDATE ON public.film_category FOR EACH ROW EXECUTE FUNCTION public.update_counter_update();


--
-- TOC entry 3339 (class 2620 OID 17568)
-- Name: inventory update_counter_update; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER update_counter_update AFTER UPDATE ON public.inventory FOR EACH ROW EXECUTE FUNCTION public.update_counter_update();


--
-- TOC entry 3319 (class 2620 OID 17573)
-- Name: language update_counter_update; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER update_counter_update AFTER UPDATE ON public.language FOR EACH ROW EXECUTE FUNCTION public.update_counter_update();


--
-- TOC entry 3358 (class 2620 OID 17578)
-- Name: payment update_counter_update; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER update_counter_update AFTER UPDATE ON public.payment FOR EACH ROW EXECUTE FUNCTION public.update_counter_update();


--
-- TOC entry 3354 (class 2620 OID 17581)
-- Name: rental update_counter_update; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER update_counter_update AFTER UPDATE ON public.rental FOR EACH ROW EXECUTE FUNCTION public.update_counter_update();


--
-- TOC entry 3338 (class 2620 OID 17584)
-- Name: staff update_counter_update; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER update_counter_update AFTER UPDATE ON public.staff FOR EACH ROW EXECUTE FUNCTION public.update_counter_update();


--
-- TOC entry 3331 (class 2620 OID 17587)
-- Name: store update_counter_update; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER update_counter_update AFTER UPDATE ON public.store FOR EACH ROW EXECUTE FUNCTION public.update_counter_update();


--
-- TOC entry 3292 (class 2606 OID 17377)
-- Name: customer customer_address_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.customer
    ADD CONSTRAINT customer_address_id_fkey FOREIGN KEY (address_id) REFERENCES public.address(address_id) ON UPDATE CASCADE ON DELETE RESTRICT;


--
-- TOC entry 3284 (class 2606 OID 17295)
-- Name: film_actor film_actor_actor_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.film_actor
    ADD CONSTRAINT film_actor_actor_id_fkey FOREIGN KEY (actor_id) REFERENCES public.actor(actor_id) ON UPDATE CASCADE ON DELETE RESTRICT;


--
-- TOC entry 3285 (class 2606 OID 17300)
-- Name: film_actor film_actor_film_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.film_actor
    ADD CONSTRAINT film_actor_film_id_fkey FOREIGN KEY (film_id) REFERENCES public.film(film_id) ON UPDATE CASCADE ON DELETE RESTRICT;


--
-- TOC entry 3290 (class 2606 OID 17359)
-- Name: film_category film_category_category_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.film_category
    ADD CONSTRAINT film_category_category_id_fkey FOREIGN KEY (category_id) REFERENCES public.category(category_id) ON UPDATE CASCADE ON DELETE RESTRICT;


--
-- TOC entry 3291 (class 2606 OID 17364)
-- Name: film_category film_category_film_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.film_category
    ADD CONSTRAINT film_category_film_id_fkey FOREIGN KEY (film_id) REFERENCES public.film(film_id) ON UPDATE CASCADE ON DELETE RESTRICT;


--
-- TOC entry 3283 (class 2606 OID 17588)
-- Name: film film_language_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.film
    ADD CONSTRAINT film_language_fkey FOREIGN KEY (language_id) REFERENCES public.language(language_id) ON UPDATE CASCADE ON DELETE RESTRICT;


--
-- TOC entry 3282 (class 2606 OID 16918)
-- Name: address fk_address_city; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.address
    ADD CONSTRAINT fk_address_city FOREIGN KEY (city_id) REFERENCES public.city(city_id);


--
-- TOC entry 3281 (class 2606 OID 16904)
-- Name: city fk_city; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.city
    ADD CONSTRAINT fk_city FOREIGN KEY (country_id) REFERENCES public.country(country_id);


--
-- TOC entry 3289 (class 2606 OID 17348)
-- Name: inventory inventory_film_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.inventory
    ADD CONSTRAINT inventory_film_id_fkey FOREIGN KEY (film_id) REFERENCES public.film(film_id) ON UPDATE CASCADE ON DELETE RESTRICT;


--
-- TOC entry 3296 (class 2606 OID 17427)
-- Name: payment payment_customer_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.payment
    ADD CONSTRAINT payment_customer_id_fkey FOREIGN KEY (customer_id) REFERENCES public.customer(customer_id) ON UPDATE CASCADE ON DELETE RESTRICT;


--
-- TOC entry 3297 (class 2606 OID 17432)
-- Name: payment payment_rental_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.payment
    ADD CONSTRAINT payment_rental_id_fkey FOREIGN KEY (rental_id) REFERENCES public.rental(rental_id) ON UPDATE CASCADE ON DELETE SET NULL;


--
-- TOC entry 3298 (class 2606 OID 17437)
-- Name: payment payment_staff_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.payment
    ADD CONSTRAINT payment_staff_id_fkey FOREIGN KEY (staff_id) REFERENCES public.staff(staff_id) ON UPDATE CASCADE ON DELETE RESTRICT;


--
-- TOC entry 3293 (class 2606 OID 17404)
-- Name: rental rental_customer_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.rental
    ADD CONSTRAINT rental_customer_id_fkey FOREIGN KEY (customer_id) REFERENCES public.customer(customer_id) ON UPDATE CASCADE ON DELETE RESTRICT;


--
-- TOC entry 3294 (class 2606 OID 17409)
-- Name: rental rental_inventory_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.rental
    ADD CONSTRAINT rental_inventory_id_fkey FOREIGN KEY (inventory_id) REFERENCES public.inventory(inventory_id) ON UPDATE CASCADE ON DELETE RESTRICT;


--
-- TOC entry 3295 (class 2606 OID 17414)
-- Name: rental rental_staff_id_key; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.rental
    ADD CONSTRAINT rental_staff_id_key FOREIGN KEY (staff_id) REFERENCES public.staff(staff_id);


--
-- TOC entry 3288 (class 2606 OID 17329)
-- Name: staff staff_address_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.staff
    ADD CONSTRAINT staff_address_id_fkey FOREIGN KEY (address_id) REFERENCES public.address(address_id) ON UPDATE CASCADE ON DELETE RESTRICT;


--
-- TOC entry 3286 (class 2606 OID 17314)
-- Name: store store_address_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.store
    ADD CONSTRAINT store_address_id_fkey FOREIGN KEY (address_id) REFERENCES public.address(address_id) ON UPDATE CASCADE ON DELETE RESTRICT;


--
-- TOC entry 3287 (class 2606 OID 17334)
-- Name: store store_manager_staff_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.store
    ADD CONSTRAINT store_manager_staff_id_fkey FOREIGN KEY (manager_staff_id) REFERENCES public.staff(staff_id) ON UPDATE CASCADE ON DELETE RESTRICT;


-- Completed on 2021-12-20 16:24:15

--
-- PostgreSQL database dump complete
--

