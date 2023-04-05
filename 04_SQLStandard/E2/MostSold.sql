SELECT productinventory_id, SUM(quantity) AS total_sold
FROM sales
GROUP BY productinventory_id
ORDER BY total_sold DESC
LIMIT 1;