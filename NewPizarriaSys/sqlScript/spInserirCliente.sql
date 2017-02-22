create procedure spInserirCliente

@Nome as varchar(50),
@Telefone as varchar(15),
@Email as varchar(80)

as
begin
	INSERT INTO tblCliente (Nome, Telefone, Email)
	VALUES (@Nome, @Telefone, @Email)

	SELECT @@IDENTITY
end;