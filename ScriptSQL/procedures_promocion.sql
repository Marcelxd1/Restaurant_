DROP PROCEDURE IF EXISTS INSERTAR_PROMOCION;
DROP PROCEDURE IF EXISTS MODIFICAR_PROMOCION;
DROP PROCEDURE IF EXISTS ELIMINAR_PROMOCION;
DROP PROCEDURE IF EXISTS LISTAR_PROMOCIONES_TODOS;
DROP PROCEDURE IF EXISTS INSERTAR_LINEA_PROMOCION;
DROP PROCEDURE IF EXISTS LISTAR_LINEA_PROMOCION_PROMO;
DROP PROCEDURE IF EXISTS MODIFICAR_LINEA_PROMOCION;
DROP PROCEDURE IF EXISTS BUSCAR_PERSONA_POR_ID;
DELIMITER $

CREATE PROCEDURE INSERTAR_PROMOCION(
OUT _id_item_vendible INT ,
IN _nombre VARCHAR(50) ,
IN _precio DECIMAL(10,2) ,
IN _descripcion VARCHAR(50) ,
IN _estado VARCHAR(50)
)BEGIN
	INSERT INTO item_vendible(
     nombre, precio, descripcion, estado)
    VALUES (_nombre, _precio, _descripcion, _estado);
    SET _id_item_vendible = @@last_insert_id;
	INSERT INTO promocion (id_promocion)values (_id_item_vendible);
END$

CREATE PROCEDURE MODIFICAR_PROMOCION(
	IN _id_item_vendible INT,
    IN _nombre VARCHAR(50),
    IN _precio DECIMAL(10,2), 
    IN _descripcion VARCHAR(50), 
    IN _estado BOOLEAN
)
BEGIN
	-- update a la parte superior 
	UPDATE item_vendible SET nombre= _nombre,  precio= _precio ,  descripcion= _descripcion
     , estado= _estado where id_item_vendible= _id_item_vendible;
     -- como promocion solo tiene id que es el iditem entonces no hay nada a que hacer update
END$

CREATE PROCEDURE ELIMINAR_PROMOCION(
	IN _id_item_vendible INT
)
BEGIN
	-- es una dependencia absoluta por eso lo puse en 1 porque no se puede desactivar 
    -- independientemente la linea 
	UPDATE item_vendible SET estado = False WHERE id_item_vendible = _id_item_vendible;
    UPDATE linea_promocion SET estado = False where fid_promocion = _id_item_vendible;
END$

CREATE PROCEDURE LISTAR_PROMOCIONES_TODOS(
)
BEGIN	
	SELECT iv.id_item_vendible, iv.nombre, iv.precio , iv.descripcion, iv.estado from promocion p 
    INNER JOIN item_vendible iv ON p.id_promocion= iv.id_item_vendible;
END$

CREATE procedure INSERTAR_LINEA_PROMOCION(
	OUT _idLineaPromocion INT,
	IN _unidades INT, 
    IN _fid_promocion INT ,
	IN _fid_producto INT 
    
)BEGIN
	INSERT INTO linea_promocion
    ( unidad, fid_promocion, fid_producto, estado) VALUES ( _unidades, _fid_promocion, _fid_producto, True);
	SET _idLineaPromocion= @@last_insert_id;
    
END$

CREATE PROCEDURE MODIFICAR_LINEA_PROMOCION(
	IN _id_linea_promocion INT,
    in _unidad INT, 
    in _fid_promocion INT, 
	in _fid_producto INT,
	in _estado boolean
)
BEGIN
	UPDATE linea_promocion SET unidad= _unidad, fid_promocion= _fid_promocion , fid_producto = _fid_producto , estado = _estado 
    WHERE id_linea_promocion = _id_linea_promocion ;
    
END$

CREATE procedure LISTAR_LINEA_PROMOCION_PROMO(
	in _idPromo INT -- es el id de la proomocion que es el id itemvendible en la lista IV 
)BEGIN
	SELECT lin.fid_producto, lin.fid_promocion, lin.id_linea_promocion, lin.unidad ,
    pro.id_producto, iv.nombre , iv.estado, iv.precio, iv.descripcion ,iv.id_item_vendible, 
    pro.fid_tipo_producto, pro.presentacion, pro.fid_categoria, cat.activo, cat.descripcion, cat.id_categoria, cat.nombre FROM linea_promocion lin 
    INNER JOIN producto pro ON lin.fid_producto= pro.id_producto INNER JOIN item_vendible iv ON pro.id_producto= id_item_vendible
    INNER JOIN categoria cat ON cat.id_categoria= producto.fid_categoria
    WHERE lin.fid_promocion= _idPromo;
END$

-- procedure para buscar persona por ID
CREATE procedure BUSCAR_PERSONA_POR_ID(
	IN _id_persona	INT
)BEGIN
	SELECT id_persona , nombre, apellido_paterno , DNI from persona where _id_persona= id_persona ;
END$
DELIMITER ;