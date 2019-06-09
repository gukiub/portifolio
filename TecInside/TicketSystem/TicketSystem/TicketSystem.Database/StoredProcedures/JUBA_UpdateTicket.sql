		
CREATE PROCEDURE [dbo].[JUBA_NewTicket]
	@Id_user bigint,
	@problem varchar(max),
	@status varchar(30)
AS
	insert into [dbo].JUBA_Ticket (Id_user, problem, [status])
		values(@Id_user, @problem, @status)
	

		
