DBCC CHECKIDENT (Course, RESEED,1300)
select * from Course
DBCC CHECKIDENT (Course, RESEED,{selectedID-100}
ALTER TABLE Stud_Course
ADD CONSTRAINT FK_Stud_Course_Course
FOREIGN KEY (Crs_Id)
REFERENCES [dbo].[Course] ([Crs_Id])
ON DELETE CASCADE;
