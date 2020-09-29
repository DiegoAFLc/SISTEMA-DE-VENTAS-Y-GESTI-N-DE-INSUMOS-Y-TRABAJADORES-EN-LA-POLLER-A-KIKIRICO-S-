select * from productos

update productos set precio=25
where idProd=102


create procedure productos_upd
@idprod int,
@