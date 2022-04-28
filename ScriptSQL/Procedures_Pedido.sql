use Restaurante;
DROP PROCEDURE IF EXISTS INSERTAR_PEDIDO ;
DROP PROCEDURE IF EXISTS LISTAR_PEDIDO ;
DROP PROCEDURE IF EXISTS MODIFICAR_PEDIDO ;
DROP PROCEDURE IF EXISTS ELIMINAR_PEDIDO ;

DELIMITER $ 
CREATE PROCEDURE INSERTAR_PEDIDO(out _id_pedido int , in _fid_restaurante int , in _total float, in _tipo CHAR(1))
BEGIN
	insert into transaccion( total,tipo,fid_restaurante) values (_total,_tipo,_fid_restaurante);
    set _id_pedido = @@last_insert_id ;      
END$

/*CREATE PROCEDURE LISTAR_PEDIDO()
BEGIN
	SELECT id_mesa, capacidad FROM mesa WHERE activo = 1;
END$

CREATE PROCEDURE MODIFICAR_PEDIDO(
	IN _id_mesa INT,	
    IN _capacidad INT
)BEGIN
	UPDATE mesa SET capacidad = _capacidad WHERE id_mesa = _id_mesa;
END$

CREATE PROCEDURE ELIMINAR_PEDIDO(
	IN _id_mesa INT
)
BEGIN
	UPDATE mesa SET activo = 0 where id_mesa = _id_mesa;
END$*/