-- MySQL dump 10.16  Distrib 10.1.13-MariaDB, for Win32 (AMD64)
-- Host: localhost    Database: blog

CREATE TABLE  articles  (
   id  int(11) NOT NULL AUTO_INCREMENT,
   author_id  int(11) NOT NULL,
   body  text,
  PRIMARY KEY (id)
);

INSERT INTO  articles  VALUES 
(1,1,'This is a  test article!'),
(2,1,'This is another article from the same author!'),
(3,1,'this is an article created with the admin page!'),
(4,1,'type something in');


CREATE TABLE  users  (
   id  int(11) NOT NULL AUTO_INCREMENT,
   email  varchar(255) NOT NULL,
   password  varchar(100) NOT NULL,
  PRIMARY KEY ( id )
);


INSERT INTO  users  VALUES 
(1,'michael@qa','$2y$10$6yVcR5B3BRVa5/ZMAJxRkeviop3kA5B.2qGojW2kZif4dHJNNOXCy');
