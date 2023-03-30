CREATE 
    ALGORITHM = UNDEFINED 
    DEFINER = `root`@`localhost` 
    SQL SECURITY DEFINER
VIEW `usersrole` AS
    SELECT 
        `users`.`username` AS `name`, `role`.`name` AS `role`
    FROM
        ((`users`
        JOIN `usersinrole` ON ((`users`.`user_id` = `usersinrole`.`user_id`)))
        JOIN `role` ON ((`usersinrole`.`role_id` = `role`.`role_id`)))