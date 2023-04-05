


select*from(select max(total_films) max_films from(select count(*) total_films, actor_id from sakila.film_actor group by actor_id) sub)sub_max 
inner join(select count(*) total_films, actor_id from sakila.film_actor group by actor_id) sub2 on sub_max.max_films = sub2.max_films;