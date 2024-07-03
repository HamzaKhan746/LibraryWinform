Create Database library_management
USE library_management
create table member
(
m_id INT primary key identity(1,1),
name varchar(50),
fname varchar(50),
email varchar(50),
cnic varchar(50),
contact varchar(50),
address varchar(50),
gender varchar(50),
password varchar(50),
)
select*from member
insert into member (name ,fname,email ,cnic,contact,address,gender,password) values ('Amna','Iqbal','kk11@gmail.com',431232131231,031232131231,'Korangi','Male',1234)
insert into member (name ,fname,email ,cnic,contact,address,gender,password) values ('Shoaib','Dawood','k2k@gmail.com',43321234513,03321234513,'Model','Male',1272)
insert into member (name ,fname,email ,cnic,contact,address,gender,password) values ('Ibad','Qureshi','k2@gmail.com',43423121341,03423121341,'Malir','Male',1289)
insert into member (name ,fname,email ,cnic,contact,address,gender,password) values ('Admin','Qureshi','k2@gmail.com',43331234123,03331234123,'Malir','Male',1232)

create table books
(
b_id INT primary key identity(1,1),
a_id int Foreign key references aurthor(a_id) not null,
c_id int Foreign key references category(c_id) not null,
p_id int Foreign key references publisher(p_id) not null,
name varchar(50),
price bigint,
quantity bigint,
)
insert into books(a_id,c_id,p_id,name,price,quantity) values(1,1,1,'Dsa',1200,12)
insert into books(a_id,c_id,p_id,name,price,quantity) values(2,2,2,'POM',1400,5)
insert into books(a_id,c_id,p_id,name,price,quantity) values(1,2,1,'FA',1500,14)

create table publisher
(
p_id  INT primary key identity(1,1),
publisher varchar(50),
)
insert into publisher (publisher)values('PRINTCOM')
insert into publisher (publisher)values('Dodger')
create table category
(
c_id  INT primary key identity(1,1),
category varchar(50),
)
insert into category(category)values('COMPUTER SCIENCE')
insert into category(category)values('MANAGEMENT')

create table aurthor
(
a_id INT primary key identity(1,1),
aurthor varchar(50),
)
insert into aurthor(aurthor)values('JOHN')
insert into aurthor(aurthor)values('DANISH')


Create table issue_return
(
i_id INT primary key identity(1,1),
m_id int Foreign key references member(m_id) not null,
b_id int Foreign key references books(b_id) not null,
s_id int Foreign key references status(s_id) not null,
issuedate varchar(50),
returndate varchar(50),
)
select*from member
select*from issue_return
insert into issue_return(m_id,b_id,s_id)values(3,3,3)
insert into issue_return(m_id,b_id,s_id,issuedate)values(3,3,1,'4-2-23')
insert into issue_return(m_id,b_id,s_id,issuedate)values(3,2,1,'4-2-23')
insert into issue_return(m_id,b_id,s_id,issuedate)values(3,1,2,'5-2-23')
create table status
(
s_id INT primary key identity(1,1),
status varchar(50),
)
insert into status (status)values('ISSUE')
insert into status (status)values('RETURN')
insert into status (status)values('REQUEST')
insert into issue_return values('1','3','Hamza','Dsa','2023 5 25','2023 5 24','0')