CREATE DEFINER=`root`@`localhost` PROCEDURE `registrar_venta`(IN producto_id INT, IN usuario_id INT)
BEGIN
    DECLARE cantidad INT;
    DECLARE inventory_id INT;
    DECLARE product_type_id INT;

    DECLARE sale_date DATE;
    
    SELECT quantity, productinventory_id, producttype_id INTO cantidad, inventory_id, product_type_id
    FROM productinventory
    WHERE productinventory_id = producto_id AND quantity > 0;
    
    IF cantidad > 0 THEN
      
        
        SET sale_date = CURDATE();
        
        INSERT INTO sales (sale_id, member_id, quantity, sale_date, productinventory_id)
        VALUES (sale_id, usuario_id, cantidad, sale_date, inventory_id);
        
        UPDATE productinventory
        SET quantity = quantity - cantidad
        WHERE productinventory_id = producto_id;
        
        SELECT CONCAT('Venta registrada para el usuario ', usuario_id, ' del producto ', producto_id) AS mensaje;
    ELSE
        SELECT 'El producto no está en stock' AS mensaje;
    END IF;
END