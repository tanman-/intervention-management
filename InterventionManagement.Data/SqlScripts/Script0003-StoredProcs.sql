﻿CREATE PROCEDURE [dbo].[GetEngineerByEngineerUsername]
	@username varchar(40)
AS
	SELECT * FROM [dbo].Engineer
	WHERE EngineerUsername like @username
GO

CREATE PROCEDURE [dbo].[InsertEngineer]
	@username varchar(40), @name varchar(100), @hours int, @cost int, @districtId int
AS
	BEGIN TRY

		BEGIN TRAN Main
	
		INSERT INTO [dbo].[User](Username, Name)
		VALUES(@username, @name)

		INSERT INTO [dbo].[Engineer](EngineerUsername, CostApprovalLimit, HoursApprovalLimit, DistrictId)
		VALUES(@username, @hours, @cost, @districtId)

		COMMIT TRAN Main
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN Main
		PRINT 'InsertEngineer failed.'
	END CATCH
GO