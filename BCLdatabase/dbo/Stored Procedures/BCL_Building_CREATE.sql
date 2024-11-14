﻿-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[BCL_Building_CREATE]
	@Request	varchar(2048)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	Declare
		@PK_Building_Id As Integer = Null,	-- JSON_VALUE(@Request, '$.PK_Building_Id'),
		@Name_Short As varchar(32) =JSON_VALUE(@Request, '$.Name_Short'),
		@Name_Long As varchar(64) = JSON_VALUE(@Request, '$.Name_Long'),
		@Description as varchar(512) = JSON_VALUE(@Request, '$.Description'),
		@AddressStreet as varchar(64) = JSON_VALUE(@Request, '$.AddressStreet'),
		@AddressUnit as varchar(32) = JSON_VALUE(@Request, '$.AddressUnit'),
		@AddressCity as varchar(36) = JSON_VALUE(@Request, '$.AddressCity'),
		@AddressState as varchar(2) = JSON_VALUE(@Request, '$.AddressState'),
		@AddressZip as varchar(10) = JSON_VALUE(@Request, '$.AddressZip'),
		@IsActive as bit = JSON_VALUE(@Request, '$.IsActive'),
		@IsDeleted as bit = JSON_VALUE(@Request, '$.IsDeleted')

	Insert Into BCL_Building (Name_Short, Name_Long, Description, AddressStreet, AddressUnit, AddressCity, AddressState, AddressZip, IsActive, IsDeleted)
	Values (@Name_Short, @Name_Long, @Description, @AddressStreet, @AddressUnit, @AddressCity, @AddressState, @AddressZip, @IsActive, @IsDeleted)
	Set @PK_Building_Id = @@IDENTITY

	Select *
	From BCL_Building
	Where PK_Building_Id = @PK_Building_Id

END