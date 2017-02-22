create procedure spBuscarPorId

@Id as int

as
begin
	select * from tblCliente where Id = @Id
end