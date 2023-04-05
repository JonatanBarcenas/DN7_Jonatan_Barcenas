CREATE DEFINER=`root`@`localhost` PROCEDURE `get_products_by_type`(IN product_type_id INT)
BEGIN
    SELECT p. productinventory_id, p.name, p.description, p.quantity
    FROM  productinventory p
    WHERE p.producttype_id = product_type_id AND p.quantity > 0;
END