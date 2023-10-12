create database normal

create table client(
clientno int,
cname varchar(30),
prop_no varchar(15),
paddress varchar(30),
rent_start date,
rentfinish date,
rent int,
ownerno varchar(15),
oname varchar(20),
)




insert into client values('cr76','john kay','pg4','6 lawerence st.glasgow','1-jul-00','31-aug-01',350,'co40','tina murphy'),
     ('cr76','john kay','pg16','5 novar dr glasgow','1-sep-02','1-sep-03',450,'co93','tony shaw'),
	  ('cr56','aline stewart','pg4','6 lawerence st.glasgow','1-sep-99','10-jun-00',350,'co40','tina murphy'),
	  ('cr56','aline stewart','pg36','2 manor rd.glasgow','10-oct-00','1-dec-01',370,'co93','tony shaw'),
	   ('cr56','aline stewart','pg16','5 novar dr glasgow','1-nov-02','1-aug-03',450,'co93','tony shaw')
	   select  * from client

 

	 
	   create table client1(clientno varchar(10) primary key,cname varchar(20))
	   insert into client1
	   values('cr76','john kay'),
	   ('cr56','aline stewart')
	   select * from client1

 

	   create table owner(ownerno varchar(10)primary key,oname varchar(20))
	   insert into owner(ownerno,oname)
	   values ('co40','tina murphy'),
	   ('co93','tony shaw')
	   select * from owner

 

	   create table propertyowne(prop_no varchar(10)primary key,paddress varchar(30),rent bigint,ownerno varchar(10))
	   insert into propertyowne(prop_no,paddress,rent,ownerno) 
	   values('pg4','6 lawerence st.glasgow',350,'co40'),
	   ('pg16','5 novar dr glasgow ',450,'co93'),
	      ('pg36','2 manor rd.glasgow ',370,'co93')
		  select * from propertyowne

 

		  create table rental(clientno varchar(10) foreign key references client1(clientno),prop_no varchar(10) foreign key references propertyowne(prop_no),rent_start date,rentfinish date)
		  insert into rental(clientno,prop_no,rent_start,rentfinish )
		  values('cr76','pg4','2000-07-01','2001-08-31'),
		  ('cr76','pg16','2002-09-01','2003-09-01'),
		  ('cr56','pg4','1999-09-01','2000-06-10'),
		  ('cr56','pg36','2000-10-10','2001-12-01'),
		   ('cr56','pg16','2002-11-01','2003-08-01')
		   select * from rental

 

		