CREATE PROCEDURE spListarPorTelefone

@Telefone AS VARCHAR(15)

AS
BEGIN
	SELECT * FROM tblCliente WHERE Telefone = @Telefone
END