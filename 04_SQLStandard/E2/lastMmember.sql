SELECT m.first_name, m.last_name, mp.name as membership
FROM members m
JOIN membershiptypes mp ON m.membership_id = mp.membershiptype_id
ORDER BY m.inscription_date DESC
LIMIT 1;