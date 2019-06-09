		
CREATE PROCEDURE [dbo].[JUBA_UpdateTicket]
	@Id bigint,
	@status varchar(30)
AS
	UPDATE JUBA_Ticket SET 
		[status] = @status
	WHERE Id = @id

		
