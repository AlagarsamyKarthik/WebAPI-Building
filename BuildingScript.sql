Create Database Building
use Building
Create table Building_Details
(
id int identity(1,1) primary key not null,
buildingCode nvarchar(25),
[description] nvarchar(25),
currentStatus nvarchar(25),
createdBy nvarchar(50),
createdDate datetime,
lastModifiedBy nvarchar(50),
lastModifiedDate datetime
--constraint FK_Building_Status foreign key (currentStatus) references Building_Status(id)
);
go
Create Procedure sp_GetBuilding_All
As Begin
Select * from Building_Details
End
go
Create Procedure sp_GetBuildingBy_Id
(
@Id int
)
As Begin
select * from Building_Details where Id = @Id
End
go
Create Procedure sp_SaveBuilding
(
@buildingCode nvarchar(25),
@description nvarchar(25),
@currentStatus nvarchar(25),
@createdBy nvarchar(50),
@createdDate datetime,
@lastModifiedBy nvarchar(50),
@lastModifiedDate datetime
)
As Begin
INSERT INTO Building_Details
(
buildingCode,
[description],
currentStatus,
createdBy,
createdDate,
lastModifiedBy,
lastModifiedDate)VALUES     
(
@buildingCode,
@description,
@currentStatus,
@createdBy,
@createdDate,
@lastModifiedBy,
@lastModifiedDate)
End
go
Create procedure sp_UpdateBuilding
(
@id int,
@buildingCode nvarchar(25),
@description nvarchar(25),
@currentStatus nvarchar(25),
@createdBy nvarchar(50),
@createdDate datetime,
@lastModifiedBy nvarchar(50),
@lastModifiedDate datetime
)
As Begin
Update Building_Details set buildingCode = @buildingCode, [description] = @description, currentStatus=@currentStatus,
createdBy = @createdBy,createdDate = @createdDate, lastModifiedBy = @lastModifiedBy, lastModifiedDate = @lastModifiedDate
where id = @id
End
go
Create Procedure sp_DeleteBuildingBy_Id
(
@Id int
)
As Begin
Delete from Building_Details where Id = @Id
End