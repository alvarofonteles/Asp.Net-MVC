CREATE PROCEDURE spAlterarCliente

@Id AS INT,
@Nome AS VARCHAR(50),
@Telefone AS VARCHAR(15),
@Email AS VARCHAR(80)

AS
BEGIN
	UPDATE tblCliente 
	SET Nome = @Nome, Telefone = @Telefone, Email = @Email
	WHERE Id = @Id
END