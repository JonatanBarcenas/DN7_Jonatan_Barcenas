CREATE DEFINER=`root`@`localhost` PROCEDURE `members_last_week`()
BEGIN
  DECLARE today DATE;
  DECLARE start_of_week DATE;
  SET today = CURDATE();
  SET start_of_week = DATE_SUB(today, INTERVAL WEEKDAY(today) DAY);

  SELECT m.member_id, m.inscription_date, mt.name AS membership_type
  FROM members m
  INNER JOIN membershiptypes mt ON m.membership_id = mt.membershiptype_id
  WHERE m.inscription_date BETWEEN start_of_week - INTERVAL 7 DAY AND start_of_week;
END