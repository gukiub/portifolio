CREATE PROCEDURE [dbo].JUBA_GetTicketbyIDUser
	@Id_name Bigint

as 
	select 
		TK.id as Id,
		TK.IdUser as Id_User,
		TK.Problem as Problem,
		TK.PhoneNumber as PhoneNumber,
		TK.[status] as [Status],
		US.[name] as [Name]

from JUBA_ticket as TK
inner join [user] as US
on US.id = TK.Id_User
where [Id_user] = @Id_name


	

		
