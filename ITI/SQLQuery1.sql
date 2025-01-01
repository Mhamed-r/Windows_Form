Insert into Course Values('Css',30,3)
select C.Crs_Id,C.Crs_Name,C.Crs_Duration,T.Top_Name,C.Top_Id from Course C ,Topic T Where T.Top_Id=C.Top_Id
select * From Topic
select * From Course
DELETE FROM Course
where Crs_Id=1500
DBCC CHECKIDENT (Course, RESEED,1300 )
update Course
Set Crs_Name ='Css' ,Crs_Duration=50 ,Top_Id=3
where Crs_Id=1300