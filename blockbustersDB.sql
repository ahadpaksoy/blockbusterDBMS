PGDMP     .                    y            blockbusterDB    14.1    14.1 �    �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            �           1262    16882    blockbusterDB    DATABASE     l   CREATE DATABASE "blockbusterDB" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE = 'Turkish_Turkey.1254';
    DROP DATABASE "blockbusterDB";
                postgres    false            �            1255    17595    bringfilms(character varying)    FUNCTION     x  CREATE FUNCTION public.bringfilms(variable character varying) RETURNS TABLE(film_id_column integer, title_column character varying, language_id_column character varying, rating_column character varying, lenght_column smallint)
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
 =   DROP FUNCTION public.bringfilms(variable character varying);
       public          postgres    false            �            1255    17596 %   bringfilmslanguage(character varying)    FUNCTION     �  CREATE FUNCTION public.bringfilmslanguage(variable character varying) RETURNS TABLE(language_id_column character varying, film_id_column integer, title_column character varying, rating_column character varying, lenght_column smallint)
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
 E   DROP FUNCTION public.bringfilmslanguage(variable character varying);
       public          postgres    false            �            1255    17514    last_updated()    FUNCTION     �   CREATE FUNCTION public.last_updated() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
BEGIN
    NEW.last_update = CURRENT_TIMESTAMP;
    RETURN NEW;
END 
$$;
 %   DROP FUNCTION public.last_updated();
       public          postgres    false            �            1255    17497    update_counter_delete()    FUNCTION     �   CREATE FUNCTION public.update_counter_delete() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
	begin
	update update_counter set update_counter_delete= update_counter_delete+1;
	return new;
	end;
$$;
 .   DROP FUNCTION public.update_counter_delete();
       public          postgres    false            �            1255    17532    update_counter_insert()    FUNCTION     �   CREATE FUNCTION public.update_counter_insert() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
	begin
	update update_counter set update_counter_insert= update_counter_insert+1;
	return new;
	end;
$$;
 .   DROP FUNCTION public.update_counter_insert();
       public          postgres    false            �            1255    17540    update_counter_update()    FUNCTION     �   CREATE FUNCTION public.update_counter_update() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
	begin
	update update_counter set update_counter_update= update_counter_update+1;
	return new;
	end;
$$;
 .   DROP FUNCTION public.update_counter_update();
       public          postgres    false            �            1259    16886    actor    TABLE     �   CREATE TABLE public.actor (
    actor_id integer NOT NULL,
    first_name character varying(45) NOT NULL,
    last_name character varying(45) NOT NULL,
    last_update timestamp without time zone DEFAULT now() NOT NULL
);
    DROP TABLE public.actor;
       public         heap    postgres    false            �            1259    16912    address    TABLE     !  CREATE TABLE public.address (
    address_id integer NOT NULL,
    address character varying(50) NOT NULL,
    city_id smallint NOT NULL,
    postal_code character varying(10),
    phone character varying(20) NOT NULL,
    last_update timestamp without time zone DEFAULT now() NOT NULL
);
    DROP TABLE public.address;
       public         heap    postgres    false            �            1259    17283    category    TABLE     �   CREATE TABLE public.category (
    category_id integer NOT NULL,
    name character varying(25) NOT NULL,
    last_update timestamp without time zone DEFAULT now() NOT NULL
);
    DROP TABLE public.category;
       public         heap    postgres    false            �            1259    16898    city    TABLE     �   CREATE TABLE public.city (
    city_id integer NOT NULL,
    city character varying(50) NOT NULL,
    country_id smallint NOT NULL,
    last_update timestamp without time zone DEFAULT now() NOT NULL
);
    DROP TABLE public.city;
       public         heap    postgres    false            �            1259    16892    country    TABLE     �   CREATE TABLE public.country (
    country_id integer NOT NULL,
    country character varying(50) NOT NULL,
    last_update timestamp without time zone DEFAULT now() NOT NULL
);
    DROP TABLE public.country;
       public         heap    postgres    false            �            1259    17369    customer    TABLE     �  CREATE TABLE public.customer (
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
    DROP TABLE public.customer;
       public         heap    postgres    false            �            1259    17250    film    TABLE     �  CREATE TABLE public.film (
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
    DROP TABLE public.film;
       public         heap    postgres    false            �            1259    17289 
   film_actor    TABLE     �   CREATE TABLE public.film_actor (
    actor_id smallint NOT NULL,
    film_id smallint NOT NULL,
    last_update timestamp without time zone DEFAULT now() NOT NULL
);
    DROP TABLE public.film_actor;
       public         heap    postgres    false            �            1259    17353    film_category    TABLE     �   CREATE TABLE public.film_category (
    film_id smallint NOT NULL,
    category_id smallint NOT NULL,
    last_update timestamp without time zone DEFAULT now() NOT NULL
);
 !   DROP TABLE public.film_category;
       public         heap    postgres    false            �            1259    17249    film_film_id_seq    SEQUENCE     �   CREATE SEQUENCE public.film_film_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 '   DROP SEQUENCE public.film_film_id_seq;
       public          postgres    false    214            �           0    0    film_film_id_seq    SEQUENCE OWNED BY     E   ALTER SEQUENCE public.film_film_id_seq OWNED BY public.film.film_id;
          public          postgres    false    213            �            1259    17342 	   inventory    TABLE     �   CREATE TABLE public.inventory (
    inventory_id integer NOT NULL,
    film_id smallint NOT NULL,
    store_id smallint NOT NULL,
    last_update timestamp without time zone DEFAULT now() NOT NULL
);
    DROP TABLE public.inventory;
       public         heap    postgres    false            �            1259    17271    language    TABLE     �   CREATE TABLE public.language (
    language_id character varying(4) NOT NULL,
    name character(20) NOT NULL,
    last_update timestamp without time zone DEFAULT now() NOT NULL
);
    DROP TABLE public.language;
       public         heap    postgres    false            �            1259    17422    payment    TABLE     A  CREATE TABLE public.payment (
    payment_id integer NOT NULL,
    customer_id smallint NOT NULL,
    staff_id smallint NOT NULL,
    rental_id integer NOT NULL,
    amount numeric(5,2) NOT NULL,
    payment_date timestamp without time zone NOT NULL,
    last_update timestamp without time zone DEFAULT now() NOT NULL
);
    DROP TABLE public.payment;
       public         heap    postgres    false            �            1259    17398    rental    TABLE     L  CREATE TABLE public.rental (
    rental_id integer NOT NULL,
    rental_date timestamp without time zone NOT NULL,
    inventory_id integer NOT NULL,
    customer_id smallint NOT NULL,
    return_date timestamp without time zone,
    staff_id smallint NOT NULL,
    last_update timestamp without time zone DEFAULT now() NOT NULL
);
    DROP TABLE public.rental;
       public         heap    postgres    false            �            1259    17322    staff    TABLE     �  CREATE TABLE public.staff (
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
    DROP TABLE public.staff;
       public         heap    postgres    false            �            1259    17308    store    TABLE     �   CREATE TABLE public.store (
    store_id integer NOT NULL,
    manager_staff_id smallint NOT NULL,
    address_id smallint NOT NULL,
    last_update timestamp without time zone DEFAULT now() NOT NULL
);
    DROP TABLE public.store;
       public         heap    postgres    false            �            1259    17533    update_counter    TABLE     �   CREATE TABLE public.update_counter (
    update_counter_insert smallint,
    update_counter_delete smallint,
    update_counter_update smallint DEFAULT '0'::smallint
);
 "   DROP TABLE public.update_counter;
       public         heap    postgres    false            �           2604    17537    film film_id    DEFAULT     l   ALTER TABLE ONLY public.film ALTER COLUMN film_id SET DEFAULT nextval('public.film_film_id_seq'::regclass);
 ;   ALTER TABLE public.film ALTER COLUMN film_id DROP DEFAULT;
       public          postgres    false    214    213    214            �          0    16886    actor 
   TABLE DATA           M   COPY public.actor (actor_id, first_name, last_name, last_update) FROM stdin;
    public          postgres    false    209   b�       �          0    16912    address 
   TABLE DATA           `   COPY public.address (address_id, address, city_id, postal_code, phone, last_update) FROM stdin;
    public          postgres    false    212    �       �          0    17283    category 
   TABLE DATA           B   COPY public.category (category_id, name, last_update) FROM stdin;
    public          postgres    false    216   ־       �          0    16898    city 
   TABLE DATA           F   COPY public.city (city_id, city, country_id, last_update) FROM stdin;
    public          postgres    false    211   k�       �          0    16892    country 
   TABLE DATA           C   COPY public.country (country_id, country, last_update) FROM stdin;
    public          postgres    false    210   ��       �          0    17369    customer 
   TABLE DATA           �   COPY public.customer (customer_id, store_id, first_name, last_name, email, address_id, activebool, create_date, last_update) FROM stdin;
    public          postgres    false    222   ��       �          0    17250    film 
   TABLE DATA           �   COPY public.film (film_id, title, description, release_year, language_id, replacement_cost, rating, last_update, lenght) FROM stdin;
    public          postgres    false    214   ��       �          0    17289 
   film_actor 
   TABLE DATA           D   COPY public.film_actor (actor_id, film_id, last_update) FROM stdin;
    public          postgres    false    217   /�       �          0    17353    film_category 
   TABLE DATA           J   COPY public.film_category (film_id, category_id, last_update) FROM stdin;
    public          postgres    false    221   L�       �          0    17342 	   inventory 
   TABLE DATA           Q   COPY public.inventory (inventory_id, film_id, store_id, last_update) FROM stdin;
    public          postgres    false    220   i�       �          0    17271    language 
   TABLE DATA           B   COPY public.language (language_id, name, last_update) FROM stdin;
    public          postgres    false    215   ��       �          0    17422    payment 
   TABLE DATA           r   COPY public.payment (payment_id, customer_id, staff_id, rental_id, amount, payment_date, last_update) FROM stdin;
    public          postgres    false    224   #�       �          0    17398    rental 
   TABLE DATA           w   COPY public.rental (rental_id, rental_date, inventory_id, customer_id, return_date, staff_id, last_update) FROM stdin;
    public          postgres    false    223   @�       �          0    17322    staff 
   TABLE DATA           �   COPY public.staff (staff_id, first_name, last_name, address_id, email, store_id, active, username, password, last_update) FROM stdin;
    public          postgres    false    219   ]�       �          0    17308    store 
   TABLE DATA           T   COPY public.store (store_id, manager_staff_id, address_id, last_update) FROM stdin;
    public          postgres    false    218   z�       �          0    17533    update_counter 
   TABLE DATA           m   COPY public.update_counter (update_counter_insert, update_counter_delete, update_counter_update) FROM stdin;
    public          postgres    false    225   ��       �           0    0    film_film_id_seq    SEQUENCE SET     ?   SELECT pg_catalog.setval('public.film_film_id_seq', 1, false);
          public          postgres    false    213            �           2606    16891    actor actor_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public.actor
    ADD CONSTRAINT actor_pkey PRIMARY KEY (actor_id);
 :   ALTER TABLE ONLY public.actor DROP CONSTRAINT actor_pkey;
       public            postgres    false    209            �           2606    16917    address address_pkey 
   CONSTRAINT     Z   ALTER TABLE ONLY public.address
    ADD CONSTRAINT address_pkey PRIMARY KEY (address_id);
 >   ALTER TABLE ONLY public.address DROP CONSTRAINT address_pkey;
       public            postgres    false    212            �           2606    17288    category category_pkey 
   CONSTRAINT     ]   ALTER TABLE ONLY public.category
    ADD CONSTRAINT category_pkey PRIMARY KEY (category_id);
 @   ALTER TABLE ONLY public.category DROP CONSTRAINT category_pkey;
       public            postgres    false    216            �           2606    16903    city city_pkey 
   CONSTRAINT     Q   ALTER TABLE ONLY public.city
    ADD CONSTRAINT city_pkey PRIMARY KEY (city_id);
 8   ALTER TABLE ONLY public.city DROP CONSTRAINT city_pkey;
       public            postgres    false    211            �           2606    16897    country country_pkey 
   CONSTRAINT     Z   ALTER TABLE ONLY public.country
    ADD CONSTRAINT country_pkey PRIMARY KEY (country_id);
 >   ALTER TABLE ONLY public.country DROP CONSTRAINT country_pkey;
       public            postgres    false    210            �           2606    17376    customer customer_pkey 
   CONSTRAINT     ]   ALTER TABLE ONLY public.customer
    ADD CONSTRAINT customer_pkey PRIMARY KEY (customer_id);
 @   ALTER TABLE ONLY public.customer DROP CONSTRAINT customer_pkey;
       public            postgres    false    222            �           2606    17294    film_actor film_actor_pkey 
   CONSTRAINT     g   ALTER TABLE ONLY public.film_actor
    ADD CONSTRAINT film_actor_pkey PRIMARY KEY (actor_id, film_id);
 D   ALTER TABLE ONLY public.film_actor DROP CONSTRAINT film_actor_pkey;
       public            postgres    false    217    217            �           2606    17358     film_category film_category_pkey 
   CONSTRAINT     p   ALTER TABLE ONLY public.film_category
    ADD CONSTRAINT film_category_pkey PRIMARY KEY (film_id, category_id);
 J   ALTER TABLE ONLY public.film_category DROP CONSTRAINT film_category_pkey;
       public            postgres    false    221    221            �           2606    17258    film film_pkey 
   CONSTRAINT     Q   ALTER TABLE ONLY public.film
    ADD CONSTRAINT film_pkey PRIMARY KEY (film_id);
 8   ALTER TABLE ONLY public.film DROP CONSTRAINT film_pkey;
       public            postgres    false    214            �           2606    17347    inventory inventory_pkey 
   CONSTRAINT     `   ALTER TABLE ONLY public.inventory
    ADD CONSTRAINT inventory_pkey PRIMARY KEY (inventory_id);
 B   ALTER TABLE ONLY public.inventory DROP CONSTRAINT inventory_pkey;
       public            postgres    false    220            �           2606    17276    language language_pkey 
   CONSTRAINT     ]   ALTER TABLE ONLY public.language
    ADD CONSTRAINT language_pkey PRIMARY KEY (language_id);
 @   ALTER TABLE ONLY public.language DROP CONSTRAINT language_pkey;
       public            postgres    false    215            �           2606    17426    payment payment_pkey 
   CONSTRAINT     Z   ALTER TABLE ONLY public.payment
    ADD CONSTRAINT payment_pkey PRIMARY KEY (payment_id);
 >   ALTER TABLE ONLY public.payment DROP CONSTRAINT payment_pkey;
       public            postgres    false    224            �           2606    17403    rental rental_pkey 
   CONSTRAINT     W   ALTER TABLE ONLY public.rental
    ADD CONSTRAINT rental_pkey PRIMARY KEY (rental_id);
 <   ALTER TABLE ONLY public.rental DROP CONSTRAINT rental_pkey;
       public            postgres    false    223            �           2606    17328    staff staff_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public.staff
    ADD CONSTRAINT staff_pkey PRIMARY KEY (staff_id);
 :   ALTER TABLE ONLY public.staff DROP CONSTRAINT staff_pkey;
       public            postgres    false    219            �           2606    17313    store store_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public.store
    ADD CONSTRAINT store_pkey PRIMARY KEY (store_id);
 :   ALTER TABLE ONLY public.store DROP CONSTRAINT store_pkey;
       public            postgres    false    218            �           1259    17282    fki_language_id    INDEX     G   CREATE INDEX fki_language_id ON public.film USING btree (language_id);
 #   DROP INDEX public.fki_language_id;
       public            postgres    false    214            �           2620    17515    actor last_updated    TRIGGER     o   CREATE TRIGGER last_updated BEFORE UPDATE ON public.actor FOR EACH ROW EXECUTE FUNCTION public.last_updated();
 +   DROP TRIGGER last_updated ON public.actor;
       public          postgres    false    226    209            �           2620    17517    address last_updated    TRIGGER     q   CREATE TRIGGER last_updated BEFORE UPDATE ON public.address FOR EACH ROW EXECUTE FUNCTION public.last_updated();
 -   DROP TRIGGER last_updated ON public.address;
       public          postgres    false    212    226            �           2620    17518    category last_updated    TRIGGER     r   CREATE TRIGGER last_updated BEFORE UPDATE ON public.category FOR EACH ROW EXECUTE FUNCTION public.last_updated();
 .   DROP TRIGGER last_updated ON public.category;
       public          postgres    false    226    216            �           2620    17519    city last_updated    TRIGGER     n   CREATE TRIGGER last_updated BEFORE UPDATE ON public.city FOR EACH ROW EXECUTE FUNCTION public.last_updated();
 *   DROP TRIGGER last_updated ON public.city;
       public          postgres    false    226    211            �           2620    17516    country last_updated    TRIGGER     q   CREATE TRIGGER last_updated BEFORE UPDATE ON public.country FOR EACH ROW EXECUTE FUNCTION public.last_updated();
 -   DROP TRIGGER last_updated ON public.country;
       public          postgres    false    210    226                       2620    17520    customer last_updated    TRIGGER     r   CREATE TRIGGER last_updated BEFORE UPDATE ON public.customer FOR EACH ROW EXECUTE FUNCTION public.last_updated();
 .   DROP TRIGGER last_updated ON public.customer;
       public          postgres    false    226    222            �           2620    17521    film last_updated    TRIGGER     n   CREATE TRIGGER last_updated BEFORE UPDATE ON public.film FOR EACH ROW EXECUTE FUNCTION public.last_updated();
 *   DROP TRIGGER last_updated ON public.film;
       public          postgres    false    226    214                       2620    17522    film_actor last_updated    TRIGGER     t   CREATE TRIGGER last_updated BEFORE UPDATE ON public.film_actor FOR EACH ROW EXECUTE FUNCTION public.last_updated();
 0   DROP TRIGGER last_updated ON public.film_actor;
       public          postgres    false    226    217                       2620    17523    film_category last_updated    TRIGGER     w   CREATE TRIGGER last_updated BEFORE UPDATE ON public.film_category FOR EACH ROW EXECUTE FUNCTION public.last_updated();
 3   DROP TRIGGER last_updated ON public.film_category;
       public          postgres    false    221    226                       2620    17524    inventory last_updated    TRIGGER     s   CREATE TRIGGER last_updated BEFORE UPDATE ON public.inventory FOR EACH ROW EXECUTE FUNCTION public.last_updated();
 /   DROP TRIGGER last_updated ON public.inventory;
       public          postgres    false    220    226            �           2620    17525    language last_updated    TRIGGER     r   CREATE TRIGGER last_updated BEFORE UPDATE ON public.language FOR EACH ROW EXECUTE FUNCTION public.last_updated();
 .   DROP TRIGGER last_updated ON public.language;
       public          postgres    false    215    226                       2620    17526    payment last_updated    TRIGGER     q   CREATE TRIGGER last_updated BEFORE UPDATE ON public.payment FOR EACH ROW EXECUTE FUNCTION public.last_updated();
 -   DROP TRIGGER last_updated ON public.payment;
       public          postgres    false    224    226                       2620    17527    rental last_updated    TRIGGER     p   CREATE TRIGGER last_updated BEFORE UPDATE ON public.rental FOR EACH ROW EXECUTE FUNCTION public.last_updated();
 ,   DROP TRIGGER last_updated ON public.rental;
       public          postgres    false    223    226                       2620    17528    staff last_updated    TRIGGER     o   CREATE TRIGGER last_updated BEFORE UPDATE ON public.staff FOR EACH ROW EXECUTE FUNCTION public.last_updated();
 +   DROP TRIGGER last_updated ON public.staff;
       public          postgres    false    226    219                       2620    17529    store last_updated    TRIGGER     o   CREATE TRIGGER last_updated BEFORE UPDATE ON public.store FOR EACH ROW EXECUTE FUNCTION public.last_updated();
 +   DROP TRIGGER last_updated ON public.store;
       public          postgres    false    226    218            �           2620    17539    actor update_counter_delete    TRIGGER     �   CREATE TRIGGER update_counter_delete AFTER DELETE ON public.actor FOR EACH ROW EXECUTE FUNCTION public.update_counter_delete();
 4   DROP TRIGGER update_counter_delete ON public.actor;
       public          postgres    false    228    209            �           2620    17542    address update_counter_delete    TRIGGER     �   CREATE TRIGGER update_counter_delete AFTER DELETE ON public.address FOR EACH ROW EXECUTE FUNCTION public.update_counter_delete();
 6   DROP TRIGGER update_counter_delete ON public.address;
       public          postgres    false    228    212            �           2620    17545    category update_counter_delete    TRIGGER     �   CREATE TRIGGER update_counter_delete AFTER DELETE ON public.category FOR EACH ROW EXECUTE FUNCTION public.update_counter_delete();
 7   DROP TRIGGER update_counter_delete ON public.category;
       public          postgres    false    216    228            �           2620    17548    city update_counter_delete    TRIGGER        CREATE TRIGGER update_counter_delete AFTER DELETE ON public.city FOR EACH ROW EXECUTE FUNCTION public.update_counter_delete();
 3   DROP TRIGGER update_counter_delete ON public.city;
       public          postgres    false    228    211            �           2620    17551    country update_counter_delete    TRIGGER     �   CREATE TRIGGER update_counter_delete AFTER DELETE ON public.country FOR EACH ROW EXECUTE FUNCTION public.update_counter_delete();
 6   DROP TRIGGER update_counter_delete ON public.country;
       public          postgres    false    210    228                       2620    17554    customer update_counter_delete    TRIGGER     �   CREATE TRIGGER update_counter_delete AFTER DELETE ON public.customer FOR EACH ROW EXECUTE FUNCTION public.update_counter_delete();
 7   DROP TRIGGER update_counter_delete ON public.customer;
       public          postgres    false    222    228            �           2620    17557    film update_counter_delete    TRIGGER        CREATE TRIGGER update_counter_delete AFTER DELETE ON public.film FOR EACH ROW EXECUTE FUNCTION public.update_counter_delete();
 3   DROP TRIGGER update_counter_delete ON public.film;
       public          postgres    false    228    214                       2620    17560     film_actor update_counter_delete    TRIGGER     �   CREATE TRIGGER update_counter_delete AFTER DELETE ON public.film_actor FOR EACH ROW EXECUTE FUNCTION public.update_counter_delete();
 9   DROP TRIGGER update_counter_delete ON public.film_actor;
       public          postgres    false    228    217                       2620    17563 #   film_category update_counter_delete    TRIGGER     �   CREATE TRIGGER update_counter_delete AFTER DELETE ON public.film_category FOR EACH ROW EXECUTE FUNCTION public.update_counter_delete();
 <   DROP TRIGGER update_counter_delete ON public.film_category;
       public          postgres    false    228    221                       2620    17566    inventory update_counter_delete    TRIGGER     �   CREATE TRIGGER update_counter_delete AFTER DELETE ON public.inventory FOR EACH ROW EXECUTE FUNCTION public.update_counter_delete();
 8   DROP TRIGGER update_counter_delete ON public.inventory;
       public          postgres    false    228    220            �           2620    17571    language update_counter_delete    TRIGGER     �   CREATE TRIGGER update_counter_delete AFTER DELETE ON public.language FOR EACH ROW EXECUTE FUNCTION public.update_counter_delete();
 7   DROP TRIGGER update_counter_delete ON public.language;
       public          postgres    false    228    215                       2620    17576    payment update_counter_delete    TRIGGER     �   CREATE TRIGGER update_counter_delete AFTER DELETE ON public.payment FOR EACH ROW EXECUTE FUNCTION public.update_counter_delete();
 6   DROP TRIGGER update_counter_delete ON public.payment;
       public          postgres    false    228    224                       2620    17579    rental update_counter_delete    TRIGGER     �   CREATE TRIGGER update_counter_delete AFTER DELETE ON public.rental FOR EACH ROW EXECUTE FUNCTION public.update_counter_delete();
 5   DROP TRIGGER update_counter_delete ON public.rental;
       public          postgres    false    228    223                       2620    17582    staff update_counter_delete    TRIGGER     �   CREATE TRIGGER update_counter_delete AFTER DELETE ON public.staff FOR EACH ROW EXECUTE FUNCTION public.update_counter_delete();
 4   DROP TRIGGER update_counter_delete ON public.staff;
       public          postgres    false    228    219                       2620    17585    store update_counter_delete    TRIGGER     �   CREATE TRIGGER update_counter_delete AFTER DELETE ON public.store FOR EACH ROW EXECUTE FUNCTION public.update_counter_delete();
 4   DROP TRIGGER update_counter_delete ON public.store;
       public          postgres    false    228    218            �           2620    17538    actor update_counter_insert    TRIGGER     �   CREATE TRIGGER update_counter_insert AFTER INSERT ON public.actor FOR EACH ROW EXECUTE FUNCTION public.update_counter_insert();
 4   DROP TRIGGER update_counter_insert ON public.actor;
       public          postgres    false    227    209            �           2620    17543    address update_counter_insert    TRIGGER     �   CREATE TRIGGER update_counter_insert AFTER INSERT ON public.address FOR EACH ROW EXECUTE FUNCTION public.update_counter_insert();
 6   DROP TRIGGER update_counter_insert ON public.address;
       public          postgres    false    227    212            �           2620    17546    category update_counter_insert    TRIGGER     �   CREATE TRIGGER update_counter_insert AFTER INSERT ON public.category FOR EACH ROW EXECUTE FUNCTION public.update_counter_insert();
 7   DROP TRIGGER update_counter_insert ON public.category;
       public          postgres    false    227    216            �           2620    17549    city update_counter_insert    TRIGGER        CREATE TRIGGER update_counter_insert AFTER INSERT ON public.city FOR EACH ROW EXECUTE FUNCTION public.update_counter_insert();
 3   DROP TRIGGER update_counter_insert ON public.city;
       public          postgres    false    227    211            �           2620    17552    country update_counter_insert    TRIGGER     �   CREATE TRIGGER update_counter_insert AFTER INSERT ON public.country FOR EACH ROW EXECUTE FUNCTION public.update_counter_insert();
 6   DROP TRIGGER update_counter_insert ON public.country;
       public          postgres    false    210    227                       2620    17555    customer update_counter_insert    TRIGGER     �   CREATE TRIGGER update_counter_insert AFTER INSERT ON public.customer FOR EACH ROW EXECUTE FUNCTION public.update_counter_insert();
 7   DROP TRIGGER update_counter_insert ON public.customer;
       public          postgres    false    222    227            �           2620    17558    film update_counter_insert    TRIGGER        CREATE TRIGGER update_counter_insert AFTER INSERT ON public.film FOR EACH ROW EXECUTE FUNCTION public.update_counter_insert();
 3   DROP TRIGGER update_counter_insert ON public.film;
       public          postgres    false    227    214                        2620    17561     film_actor update_counter_insert    TRIGGER     �   CREATE TRIGGER update_counter_insert AFTER INSERT ON public.film_actor FOR EACH ROW EXECUTE FUNCTION public.update_counter_insert();
 9   DROP TRIGGER update_counter_insert ON public.film_actor;
       public          postgres    false    227    217                       2620    17564 #   film_category update_counter_insert    TRIGGER     �   CREATE TRIGGER update_counter_insert AFTER INSERT ON public.film_category FOR EACH ROW EXECUTE FUNCTION public.update_counter_insert();
 <   DROP TRIGGER update_counter_insert ON public.film_category;
       public          postgres    false    227    221                       2620    17567    inventory update_counter_insert    TRIGGER     �   CREATE TRIGGER update_counter_insert AFTER INSERT ON public.inventory FOR EACH ROW EXECUTE FUNCTION public.update_counter_insert();
 8   DROP TRIGGER update_counter_insert ON public.inventory;
       public          postgres    false    227    220            �           2620    17572    language update_counter_insert    TRIGGER     �   CREATE TRIGGER update_counter_insert AFTER INSERT ON public.language FOR EACH ROW EXECUTE FUNCTION public.update_counter_insert();
 7   DROP TRIGGER update_counter_insert ON public.language;
       public          postgres    false    227    215                       2620    17577    payment update_counter_insert    TRIGGER     �   CREATE TRIGGER update_counter_insert AFTER INSERT ON public.payment FOR EACH ROW EXECUTE FUNCTION public.update_counter_insert();
 6   DROP TRIGGER update_counter_insert ON public.payment;
       public          postgres    false    227    224                       2620    17580    rental update_counter_insert    TRIGGER     �   CREATE TRIGGER update_counter_insert AFTER INSERT ON public.rental FOR EACH ROW EXECUTE FUNCTION public.update_counter_insert();
 5   DROP TRIGGER update_counter_insert ON public.rental;
       public          postgres    false    227    223            	           2620    17583    staff update_counter_insert    TRIGGER     �   CREATE TRIGGER update_counter_insert AFTER INSERT ON public.staff FOR EACH ROW EXECUTE FUNCTION public.update_counter_insert();
 4   DROP TRIGGER update_counter_insert ON public.staff;
       public          postgres    false    227    219                       2620    17586    store update_counter_insert    TRIGGER     �   CREATE TRIGGER update_counter_insert AFTER INSERT ON public.store FOR EACH ROW EXECUTE FUNCTION public.update_counter_insert();
 4   DROP TRIGGER update_counter_insert ON public.store;
       public          postgres    false    218    227            �           2620    17541    actor update_counter_update    TRIGGER     �   CREATE TRIGGER update_counter_update AFTER UPDATE ON public.actor FOR EACH ROW EXECUTE FUNCTION public.update_counter_update();
 4   DROP TRIGGER update_counter_update ON public.actor;
       public          postgres    false    231    209            �           2620    17544    address update_counter_update    TRIGGER     �   CREATE TRIGGER update_counter_update AFTER UPDATE ON public.address FOR EACH ROW EXECUTE FUNCTION public.update_counter_update();
 6   DROP TRIGGER update_counter_update ON public.address;
       public          postgres    false    231    212            �           2620    17547    category update_counter_update    TRIGGER     �   CREATE TRIGGER update_counter_update AFTER UPDATE ON public.category FOR EACH ROW EXECUTE FUNCTION public.update_counter_update();
 7   DROP TRIGGER update_counter_update ON public.category;
       public          postgres    false    231    216            �           2620    17550    city update_counter_update    TRIGGER        CREATE TRIGGER update_counter_update AFTER UPDATE ON public.city FOR EACH ROW EXECUTE FUNCTION public.update_counter_update();
 3   DROP TRIGGER update_counter_update ON public.city;
       public          postgres    false    211    231            �           2620    17553    country update_counter_update    TRIGGER     �   CREATE TRIGGER update_counter_update AFTER UPDATE ON public.country FOR EACH ROW EXECUTE FUNCTION public.update_counter_update();
 6   DROP TRIGGER update_counter_update ON public.country;
       public          postgres    false    231    210                       2620    17556    customer update_counter_update    TRIGGER     �   CREATE TRIGGER update_counter_update AFTER UPDATE ON public.customer FOR EACH ROW EXECUTE FUNCTION public.update_counter_update();
 7   DROP TRIGGER update_counter_update ON public.customer;
       public          postgres    false    222    231            �           2620    17559    film update_counter_update    TRIGGER        CREATE TRIGGER update_counter_update AFTER UPDATE ON public.film FOR EACH ROW EXECUTE FUNCTION public.update_counter_update();
 3   DROP TRIGGER update_counter_update ON public.film;
       public          postgres    false    214    231            �           2620    17562     film_actor update_counter_update    TRIGGER     �   CREATE TRIGGER update_counter_update AFTER UPDATE ON public.film_actor FOR EACH ROW EXECUTE FUNCTION public.update_counter_update();
 9   DROP TRIGGER update_counter_update ON public.film_actor;
       public          postgres    false    217    231                       2620    17565 #   film_category update_counter_update    TRIGGER     �   CREATE TRIGGER update_counter_update AFTER UPDATE ON public.film_category FOR EACH ROW EXECUTE FUNCTION public.update_counter_update();
 <   DROP TRIGGER update_counter_update ON public.film_category;
       public          postgres    false    231    221                       2620    17568    inventory update_counter_update    TRIGGER     �   CREATE TRIGGER update_counter_update AFTER UPDATE ON public.inventory FOR EACH ROW EXECUTE FUNCTION public.update_counter_update();
 8   DROP TRIGGER update_counter_update ON public.inventory;
       public          postgres    false    220    231            �           2620    17573    language update_counter_update    TRIGGER     �   CREATE TRIGGER update_counter_update AFTER UPDATE ON public.language FOR EACH ROW EXECUTE FUNCTION public.update_counter_update();
 7   DROP TRIGGER update_counter_update ON public.language;
       public          postgres    false    231    215                       2620    17578    payment update_counter_update    TRIGGER     �   CREATE TRIGGER update_counter_update AFTER UPDATE ON public.payment FOR EACH ROW EXECUTE FUNCTION public.update_counter_update();
 6   DROP TRIGGER update_counter_update ON public.payment;
       public          postgres    false    231    224                       2620    17581    rental update_counter_update    TRIGGER     �   CREATE TRIGGER update_counter_update AFTER UPDATE ON public.rental FOR EACH ROW EXECUTE FUNCTION public.update_counter_update();
 5   DROP TRIGGER update_counter_update ON public.rental;
       public          postgres    false    231    223            
           2620    17584    staff update_counter_update    TRIGGER     �   CREATE TRIGGER update_counter_update AFTER UPDATE ON public.staff FOR EACH ROW EXECUTE FUNCTION public.update_counter_update();
 4   DROP TRIGGER update_counter_update ON public.staff;
       public          postgres    false    219    231                       2620    17587    store update_counter_update    TRIGGER     �   CREATE TRIGGER update_counter_update AFTER UPDATE ON public.store FOR EACH ROW EXECUTE FUNCTION public.update_counter_update();
 4   DROP TRIGGER update_counter_update ON public.store;
       public          postgres    false    218    231            �           2606    17377 !   customer customer_address_id_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.customer
    ADD CONSTRAINT customer_address_id_fkey FOREIGN KEY (address_id) REFERENCES public.address(address_id) ON UPDATE CASCADE ON DELETE RESTRICT;
 K   ALTER TABLE ONLY public.customer DROP CONSTRAINT customer_address_id_fkey;
       public          postgres    false    3257    212    222            �           2606    17295 #   film_actor film_actor_actor_id_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.film_actor
    ADD CONSTRAINT film_actor_actor_id_fkey FOREIGN KEY (actor_id) REFERENCES public.actor(actor_id) ON UPDATE CASCADE ON DELETE RESTRICT;
 M   ALTER TABLE ONLY public.film_actor DROP CONSTRAINT film_actor_actor_id_fkey;
       public          postgres    false    217    3251    209            �           2606    17300 "   film_actor film_actor_film_id_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.film_actor
    ADD CONSTRAINT film_actor_film_id_fkey FOREIGN KEY (film_id) REFERENCES public.film(film_id) ON UPDATE CASCADE ON DELETE RESTRICT;
 L   ALTER TABLE ONLY public.film_actor DROP CONSTRAINT film_actor_film_id_fkey;
       public          postgres    false    214    3259    217            �           2606    17359 ,   film_category film_category_category_id_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.film_category
    ADD CONSTRAINT film_category_category_id_fkey FOREIGN KEY (category_id) REFERENCES public.category(category_id) ON UPDATE CASCADE ON DELETE RESTRICT;
 V   ALTER TABLE ONLY public.film_category DROP CONSTRAINT film_category_category_id_fkey;
       public          postgres    false    216    221    3264            �           2606    17364 (   film_category film_category_film_id_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.film_category
    ADD CONSTRAINT film_category_film_id_fkey FOREIGN KEY (film_id) REFERENCES public.film(film_id) ON UPDATE CASCADE ON DELETE RESTRICT;
 R   ALTER TABLE ONLY public.film_category DROP CONSTRAINT film_category_film_id_fkey;
       public          postgres    false    3259    214    221            �           2606    17588    film film_language_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.film
    ADD CONSTRAINT film_language_fkey FOREIGN KEY (language_id) REFERENCES public.language(language_id) ON UPDATE CASCADE ON DELETE RESTRICT;
 A   ALTER TABLE ONLY public.film DROP CONSTRAINT film_language_fkey;
       public          postgres    false    214    215    3262            �           2606    16918    address fk_address_city    FK CONSTRAINT     z   ALTER TABLE ONLY public.address
    ADD CONSTRAINT fk_address_city FOREIGN KEY (city_id) REFERENCES public.city(city_id);
 A   ALTER TABLE ONLY public.address DROP CONSTRAINT fk_address_city;
       public          postgres    false    3255    211    212            �           2606    16904    city fk_city    FK CONSTRAINT     x   ALTER TABLE ONLY public.city
    ADD CONSTRAINT fk_city FOREIGN KEY (country_id) REFERENCES public.country(country_id);
 6   ALTER TABLE ONLY public.city DROP CONSTRAINT fk_city;
       public          postgres    false    3253    211    210            �           2606    17348     inventory inventory_film_id_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.inventory
    ADD CONSTRAINT inventory_film_id_fkey FOREIGN KEY (film_id) REFERENCES public.film(film_id) ON UPDATE CASCADE ON DELETE RESTRICT;
 J   ALTER TABLE ONLY public.inventory DROP CONSTRAINT inventory_film_id_fkey;
       public          postgres    false    214    220    3259            �           2606    17427     payment payment_customer_id_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.payment
    ADD CONSTRAINT payment_customer_id_fkey FOREIGN KEY (customer_id) REFERENCES public.customer(customer_id) ON UPDATE CASCADE ON DELETE RESTRICT;
 J   ALTER TABLE ONLY public.payment DROP CONSTRAINT payment_customer_id_fkey;
       public          postgres    false    224    222    3276            �           2606    17432    payment payment_rental_id_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.payment
    ADD CONSTRAINT payment_rental_id_fkey FOREIGN KEY (rental_id) REFERENCES public.rental(rental_id) ON UPDATE CASCADE ON DELETE SET NULL;
 H   ALTER TABLE ONLY public.payment DROP CONSTRAINT payment_rental_id_fkey;
       public          postgres    false    223    224    3278            �           2606    17437    payment payment_staff_id_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.payment
    ADD CONSTRAINT payment_staff_id_fkey FOREIGN KEY (staff_id) REFERENCES public.staff(staff_id) ON UPDATE CASCADE ON DELETE RESTRICT;
 G   ALTER TABLE ONLY public.payment DROP CONSTRAINT payment_staff_id_fkey;
       public          postgres    false    224    219    3270            �           2606    17404    rental rental_customer_id_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.rental
    ADD CONSTRAINT rental_customer_id_fkey FOREIGN KEY (customer_id) REFERENCES public.customer(customer_id) ON UPDATE CASCADE ON DELETE RESTRICT;
 H   ALTER TABLE ONLY public.rental DROP CONSTRAINT rental_customer_id_fkey;
       public          postgres    false    3276    223    222            �           2606    17409    rental rental_inventory_id_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.rental
    ADD CONSTRAINT rental_inventory_id_fkey FOREIGN KEY (inventory_id) REFERENCES public.inventory(inventory_id) ON UPDATE CASCADE ON DELETE RESTRICT;
 I   ALTER TABLE ONLY public.rental DROP CONSTRAINT rental_inventory_id_fkey;
       public          postgres    false    3272    223    220            �           2606    17414    rental rental_staff_id_key    FK CONSTRAINT     �   ALTER TABLE ONLY public.rental
    ADD CONSTRAINT rental_staff_id_key FOREIGN KEY (staff_id) REFERENCES public.staff(staff_id);
 D   ALTER TABLE ONLY public.rental DROP CONSTRAINT rental_staff_id_key;
       public          postgres    false    223    219    3270            �           2606    17329    staff staff_address_id_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.staff
    ADD CONSTRAINT staff_address_id_fkey FOREIGN KEY (address_id) REFERENCES public.address(address_id) ON UPDATE CASCADE ON DELETE RESTRICT;
 E   ALTER TABLE ONLY public.staff DROP CONSTRAINT staff_address_id_fkey;
       public          postgres    false    212    219    3257            �           2606    17314    store store_address_id_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.store
    ADD CONSTRAINT store_address_id_fkey FOREIGN KEY (address_id) REFERENCES public.address(address_id) ON UPDATE CASCADE ON DELETE RESTRICT;
 E   ALTER TABLE ONLY public.store DROP CONSTRAINT store_address_id_fkey;
       public          postgres    false    3257    218    212            �           2606    17334 !   store store_manager_staff_id_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.store
    ADD CONSTRAINT store_manager_staff_id_fkey FOREIGN KEY (manager_staff_id) REFERENCES public.staff(staff_id) ON UPDATE CASCADE ON DELETE RESTRICT;
 K   ALTER TABLE ONLY public.store DROP CONSTRAINT store_manager_staff_id_fkey;
       public          postgres    false    218    219    3270            �   �   x�m�K
�0����*����&}��n��MhHM%��vWN܀.L��3�8��\�>B�D�E)���\�h����J�6-��M�pq���#��p&Q���d��O~��'04��=L��]t��N�Ÿd(�a�]!-������N��W�|�'
D����JrT�e�1���H      �   �  x������ ���)|L��53�1~�^{�8dC����ӗ�j�Uw�����3��l�Ng��]�����1�Ӵ������ҦC��$�T`d�o���(ѵ�P��b��{}I�X�~�4�o�
�����	�٣���d�&��O�q�1ظ��_
(��
*H��YPB�qHy���Kþ�����h���.��w��,�|t !K����F	z���4�4��/6����+!��{!�s��a��r�����u1��ZֲcS8��]��v��a��>�M?��m�eh���4[��$��(I�W%i�m|t���Lf�'����2çl''���P��>�I��[T}�tU����ϫ"@�7�Z�۲����CwkHŵ�r�?Q�n@3�n��!U}m�������      �   �   x�m�K
� @�3��*�8~�z�n�	$��ܾ���"��{<���V�f������!ף,�PXZ:��	��m�^�_)���_�'
��h�b#D�z�3����(�$F�t���~�9��S�X��B��3T      �   %  x���Ɏ�6 �s�+�F��:��2� A���6-�H���3��;��-�||��*��`��0���/�a���^��юji�0�{(ל�-�lg,5B�O�1,k(����w�Ia9�p�e�i��%�$w�9����C��!�B�3�qeDC�y�崥���Kb`����MOiOm�(�J)��x�s�P�A,���-��K?�����YA�k��rɷa�\�s�)鴰�1�����6�Ju�rma|���_��u���˖�cL:�J�a��~m�&?�	S�O>m*�;e���iX<����D�DG�c�f�������x��UK�uN2[#c��9�xF�"�l��9N>�W�{���cP8�5��ͤ�2L��gp�S(�S�3L9���{Hٿ*,&�Y!�.���<�M�N;��~��ǟ�~|���@�
)	W���ۯ\. � �=��Ԣ��Ho�%�c���������S�1��8���oK��=&�H�R���L~y�����;��'��}�zV��3�P����r�}CJX�=NSh8w|4�ց{�t��^d�C�4�P��@?1!za:-��f)0~��a�I
�-�&��?�th8��]η�6��e�����R��,��s97�D+��Ԁ����
VI\�����vKg%>B"-\񻹡J��R�}Y�;�]��R�%���|z4����H>5Ύui��������%6����OXB��@���s�YôĄ��i�Y*V7�ß�����2�z���59��r��!�~��� ��x[Z�՚��1O�i=O%zip^�j$�V0��Cm�k;�`濈��4ϴXʇڻ��n�J�[���9��	��.2Ks%����d�Ja�ٹ��1m�b�p����E15��S�Iܗ�y%�-�ꢒ���#����-7��iAV��Z��|J�|��]}�Z����}�9�s��Ou�7��Q�ks����í�K2�ǐp*3��~��"��P������TX2~z�[w9m���b^��Gb��+�%;�t���B���      �   �   x���A�� е9E/�	��tc%�jJ* �z��f5#U������8/+��6xEsE1u��v���2��r�d,�F�H�$�C}R�`��,.���J�Z%���p�!���܈P���%��R��ԛ��띶�W���򢷈̜T����wZ�/>��� >�s�z��)`�L3}��!s��r���J"Q���mYV�N)�i⚕      �      x������ � �      �   }   x�u�;�0��)|�X�����#:
hi��1�'%�[팆8]ϗ�=��������Y�cG��-�T�z�5t��⅍˗/W��UC5�szd�2���Jp�Nb�A��� ���f�1C�%�      �      x������ � �      �      x������ � �      �      x������ � �      �   �   x�s�s�L�K��,�P@�FF���F��
��V@d`�gibjlb��YRZ�M��`���<R�x�pf�$�d&���=�3�(55[A�h-n��ŉ��i�y9�y)�Dh��h��/*O��$Ɩ`W����Ԕ�<����qqq )6V�      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x�3�4�4����� 	^     