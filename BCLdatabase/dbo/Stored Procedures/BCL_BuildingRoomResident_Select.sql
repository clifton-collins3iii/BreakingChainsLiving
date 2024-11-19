-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[BCL_BuildingRoomResident_Select]
	@FK_BuildingRoom_Id	int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	Select brr.PK_RoomResident_Id, bbr.Name_Short, FK_Resident_Id, bbr.RentPaymentFrequency, bbr.RentPaymentAmount, bbr.IsActive, bbr.IsDeleted
	From BCL_BuildingRoom bbr
	Inner Join BCL_RoomResident brr on brr.FK_BuildingRoom_Id = bbr.PK_BuildingRoom_Id
	Inner Join BCL_Resident br on br.PK_Resident_Id = brr.FK_Resident_Id
	Where bbr.PK_BuildingRoom_Id = @FK_BuildingRoom_Id
END