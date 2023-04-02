insert into productinventory (productinventory_id, name, description, producttype_id, quantity) 
values (6, "Mass gainer", "mass gainer", 1, 11);

CALL get_products_by_type(1);

CALL registrar_venta(6, 2);



