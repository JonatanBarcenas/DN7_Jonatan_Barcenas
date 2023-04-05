insert into country (idcountry, name) values (1, 'USA');
insert into country (idcountry, name) values (2, 'Argentina');
insert into country (idcountry, name) values (3, 'Colombia');
insert into country (idcountry, name) values (4, 'Mexico');
insert into country (idcountry, name) values (5, 'Cuba');

select *from sqltesting.country;

insert into company (idcompany, companyname, location) values (1, 'Company test', 'SU');
insert into company (idcompany, companyname, location) values (2, 'Contoso', 'NO');
insert into company (idcompany, companyname, location) values (3, 'Tesla', 'AM');

select *from sqltesting.company;

insert into users (iduser, username, email, idcompany) values (1,'admin','admin@test.com',1);
insert into users (iduser, username, email, idcompany) values (2,'admin','admin@contoso.com',2);
insert into users (iduser, username, email, idcompany) values (3,'admin','admin@tesla.com',3);

insert into city (idcity, name, idcountry) values (1, 'CDMX',4);
insert into city (idcity, name, idcountry) values (2, 'Guadalajara',4);
insert into city (idcity, name, idcountry) values (3, 'Monterrey',4);
insert into city (idcity, name, idcountry) values (4, 'Los Angeles',1);
insert into city (idcity, name, idcountry) values (5, 'New York',1);
insert into city (idcity, name, idcountry) values (6, 'Washington D.C.',1);
insert into city (idcity, name, idcountry) values (7, 'Buenos Aires',2);
insert into city (idcity, name, idcountry) values (8, 'La Habana',3);
insert into city (idcity, name, idcountry) values (9, 'Medeyin',5);
insert into city (idcity, name, idcountry) values (10, 'Barranquilla',5);



SELECT * FROM sqltesting.city;

update city set name = 'La Habana' where idcity = 8;

SELECT * FROM city ci inner join country co on ci.idcountry = co.idcountry;

insert into city (idcity, name, idcountry) values (11, 'Monterrey',6);
insert into city (idcity, name, idcountry) values (12, 'Reynosa',6);






