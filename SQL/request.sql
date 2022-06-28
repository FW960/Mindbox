select category.name as category, type.name as type, brand.name as brand from product
left join category on category.id = product.category_id
left join `type` on type.id = product.type_id
left join brand on brand.id = product.brand_id;

/* 
Реализация таблиц в БД написана таким образом, что как такого имени у каждого товара нет.

Есть категория товара(Для мужчин, женщин, головные убор и тд), тип товара(Футболка, туфли и тд) и также бренд.

Надеюсь подобный запрос не будет минусом. Скриншоты реализации таблицы прикрепил в папке img.
*/