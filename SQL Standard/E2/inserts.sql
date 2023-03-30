
INSERT INTO role (role_id, name) VALUES
  (1, 'Admin'),
  (2, 'Manager'),
  (3, 'Trainer'),
  (4, 'Member'),
  (5, 'Recepcionist');
  
  INSERT INTO cities (city_id, city_name) VALUES
  (1, 'New York'),
  (2, 'Los Angeles'),
  (3, 'Chicago'),
  (4, 'Houston'),
  (5, 'Miami');
  
  INSERT INTO users (user_id, username, password, email, city_id) VALUES
  (1, 'admin', 'admin123', 'admin@example.com', 1),
  (2, 'manager', 'manager123', 'manager@example.com', 2),
  (3, 'trainer', 'trainer123', 'trainer@example.com', 3),
  (4, 'member1', 'member123', 'member1@example.com', 4),
  (5, 'member2', 'member123', 'member2@example.com', 5);
  
  INSERT INTO usersinrole (usersinrole_id,user_id, role_id) VALUES
  (1,1, 1),
  (2,2, 2),
  (3,3, 3),
  (4,4, 4),
  (5,5, 4);
  
  INSERT INTO measuretype (measuretype_id, name) VALUES
  (1, "meters"),
  (2, "centimeters"),
  (3, "grams"),
  (4, "liters"),
  (5,"mililiters");
  
  INSERT INTO membershiptypes(membershiptype_id, name, description, price, duration_months) VALUES
  (1,"Basic","Initial",29.99,1),
  (2,"Premium"," ",89.99,3),
  (3,"Elite"," ",179.99,6),
  (4, "Family"," " , 299.99,12),
  (5, "Student"," " , 49.99,3);
  
  INSERT INTO members(member_id, first_name, last_name, email, city_id, membership_id) VALUES
  (1, "John", "Doe", "johndoe@example.com",1,1 ),
  (2, "Jane","Smith","janesmith@example.com",2,1),
  (3, "Chris","Johnson","chrisjohnson@example.com",3,3),
  (4,"Karen","Lee","karenlee@example.com",4,4),
  (5,"Nicole","Rodriguez","nicolerodriguez@example.com",5,5);
  
  
INSERT INTO equipmenttypes(equipmenttype_id, name) VALUES
  (1,"Treadmill"),
  (2,"Stationary Bike" ),
  (3, "Weight Machine"),
  (4,"Rowing Machine"),
  (5,"Elliptical Machine");
  
  INSERT INTO producttypes(producttype_id, name, measuretype_id) VALUES
  (1,"Protein Powder",3),
  (2,"Pre-Workout", 3 ),
  (3, "Post-Workout", 3),
  (4,"Vitamins",3),
  (5,"Protein Bars",3);
  
  INSERT INTO equipmentinventory(id_equipmentinventory, name, description, equipmenttype_id) VALUES
  (1,"weight","cufflinks",3),
  (2,"Treadmill","Treadmill",1 ),
  (3, "Rowing Machine","Rowing Machine",4),
  (4,"Elliptical Machine","Elliptical Machine",5),
  (5,"Stationary Bike","Stationary Bike",1);
  
  
  INSERT INTO productinventory(productinventory_id, name, description, producttype_id) VALUES
  (1,"Protein Powder","Protein Powder",1),
  (2,"Pre-Workout","Pre-Workout",2 ),
  (3, "Post-Workout","Post-Workout",3),
  (4,"Vitamins","Vitamins",4),
  (5,"Protein Bars","Protein Bars",5);
  
  
  
  
  
  