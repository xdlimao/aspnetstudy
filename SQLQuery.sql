create database db_ajintest

use db_ajintest

create table Usuario(
id int primary key,
name varchar(255),
age int
)

select *from Usuario

insert into Usuario values (1, 'peralta', 3)

drop table Usuario