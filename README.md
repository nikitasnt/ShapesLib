# SQL Task
## Creating tables and filling them with data
```sql
-- Таблица продуктов.
create table products
(
    id uniqueidentifier primary key,
    name nvarchar(100)
)

-- Таблица категорий.
create table categories
(
    id uniqueidentifier primary key,
    name nvarchar(100)
)

-- Связь многие-ко-многим между продуктами и категориями.
create table products_categories
(
    product_id uniqueidentifier references products(id),
    category_id uniqueidentifier references categories(id),
    primary key (product_id, category_id)
)

-- Вставка продуктов.
insert into products (id, name)
values
    (newid(), N'Кепка Abibas'),
    (newid(), N'Набор для квадроберства'),
    (newid(), 'AMD Ryzen 11'),
    (newid(), 'Intel Core i11'),
    (newid(), 'NVIDIA GeForce RTX 5090 Ti Super Mega Max Turbo Professional XL'),
    (newid(), N'Какая-то гитара')

-- Вставка категорий.
insert into categories (id, name)
values
    (newid(), N'Одежда'),
    (newid(), N'Процессоры'),
    (newid(), N'Видеокарты'),
    (newid(), N'Комплектущие для ПК')

-- Вставка связей многие-ко-многим.
insert into products_categories (product_id, category_id)
values
    (
        (select id from products where name = N'Кепка Abibas'),
        (select id from categories where name = N'Одежда')
    ),
    (
        (select id from products where name = N'Набор для квадроберства'),
        (select id from categories where name = N'Одежда')
    ),
    (
        (select id from products where name = N'AMD Ryzen 11'),
        (select id from categories where name = N'Процессоры')
    ),
    (
        (select id from products where name = N'Intel Core i11'),
        (select id from categories where name = N'Процессоры')
    ),
    (
        (select id from products where name =
                                       N'NVIDIA GeForce RTX 5090 Ti Super Mega Max Turbo Professional XL'),
        (select id from categories where name = N'Видеокарты')
    ),
    (
        (select id from products where name = N'AMD Ryzen 11'),
        (select id from categories where name = N'Комплектущие для ПК')
    ),
    (
        (select id from products where name = N'Intel Core i11'),
        (select id from categories where name = N'Комплектущие для ПК')
    ),
    (
        (select id from products where name =
                                       N'NVIDIA GeForce RTX 5090 Ti Super Mega Max Turbo Professional XL'),
        (select id from categories where name = N'Комплектущие для ПК')
    )
```
## Query “Product Name - Category Name”
```sql
-- Запрос для выбора всех пар "Имя продукта - Имя категории".
select p.name product_name, c.name category_name from products p
left join products_categories pc on p.id = pc.product_id
left join categories c on c.id = pc.category_id
order by product_name, category_name
```
