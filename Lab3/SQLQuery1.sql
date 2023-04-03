
insert into lop values
('1',N'Lớp diu 1',11),
('2',N'Lớp diu 2',22),
('3',N'Lớp diu 3',33),
('4',N'Lớp diu 4',44)
go
insert into hocsinh values
('2','2','2023-03-18','2',2,'2'),
('3','6','2023-03-17','3',3,'2'),
('4','3','2023-03-16','4',4,'3'),
('5','4','2023-03-15','5',5,'3'),
('6','5','2023-03-14','6',6,'4')
select * from hocSinh
go
update hocsinh 
set tenHS='%', ngaySinh='%', diaChi='%', DTB= %, maLop='%'
where maHS= '%'
go
select * from hocSinh
delete from hocSinh
where maHs like '2'