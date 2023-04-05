alter TABLE users
ADD CONSTRAINT company_users
FOREIGN KEY (idcompany)
REFERENCES company (idcompany);

ALTER TABLE users
ADD INDEX company_users_idx(idcompany ASC) VISIBLE;