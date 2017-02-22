create procedure spExcluirCliente

@Id as int

as
begin
	delete from tblCliente where Id = @Id
end
