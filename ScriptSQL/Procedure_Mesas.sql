use Restaurante;

DROP PROCEDURE IF EXISTS INSERTAR_MESA ;
DROP PROCEDURE IF EXISTS LISTAR_MESA ;
DROP PROCEDURE IF EXISTS MODIFICAR_MESA ;
DROP PROCEDURE IF EXISTS ELIMINAR_MESA ;

DELIMITER $ 
CREATE PROCEDURE INSERTAR_MESA(out _id_mesa int , in _capacidad int , in _activo int)
BEGIN
	insert into mesa( capacidad,activo) values (_capacidad,_activo);
    set _id_mesa = @@last_insert_id ;                    
END$

CREATE PROCEDURE LISTAR_MESA()
BEGIN
	SELECT id_mesa, capacidad FROM mesa WHERE activo = 1;
END$

CREATE PROCEDURE MODIFICAR_MESA(
	IN _id_mesa INT,	
    IN _capacidad INT
)BEGIN
	UPDATE mesa SET capacidad = _capacidad WHERE id_mesa = _id_mesa;
END$

CREATE PROCEDURE ELIMINAR_MESA(
	IN _id_mesa INT
)
BEGIN
	UPDATE mesa SET activo = 0 where id_mesa = _id_mesa;
END$