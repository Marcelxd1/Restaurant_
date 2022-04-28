DROP PROCEDURE IF EXISTS LISTAR_PRODUCTOS_TODOS;
DROP PROCEDURE IF EXISTS INSERTAR_PRODUCTO;
DROP PROCEDURE IF EXISTS MODIFICAR_PRODUCTO;
DROP PROCEDURE IF EXISTS ELIMINAR_PRODUCTO;


DELIMITER $
#------------------------------------------------------------------------------
CREATE PROCEDURE INSERTAR_PRODUCTO(
	OUT _id_item_vendible INT,
	IN _nombre VARCHAR(100),
    IN  _precio DECIMAL(10,2),
    IN _descripcion VARCHAR(100), 
    IN _estado TINYINT, 
    IN _tipo_producto CHAR(1), 
    IN  _presentacion VARCHAR(50),
    IN _fid_categoria INT
)
BEGIN
	INSERT INTO item_vendible
    (nombre,precio,descripcion,estado) VALUES(_nombre,_precio,_descripcion,_estado);
    SET _id_item_vendible = @@last_insert_id;
    INSERT INTO producto(tipo_producto,presentacion,fid_categoria) VALUES(_tipo_producto,_presentacion,_fid_categoria);
END$

#------------------------------------------------------------------------------
CREATE PROCEDURE MODIFICAR_PRODUCTO(
	IN _id_item_vendible INT,
	IN _nombre VARCHAR(100),
    IN  _precio DECIMAL(10,2),
    IN _descripcion VARCHAR(100), 
    IN _estado TINYINT, 
    IN _tipo_producto CHAR(1), 
    IN  _presentacion VARCHAR(50),
    IN _fid_categoria INT
)
BEGIN
	UPDATE item_vendible SET nombre = _nombre, precio = _precio, descripcion = _descripcion, estado = _estado  WHERE id_item_vendible = _id_item_vendible;
    UPDATE producto SET tipo_producto = _tipo_producto, presentacion = _presentacion, fid_categoria = _fid_categoria WHERE id_producto = _id_item_vendible;
END$

#------------------------------------------------------------------------------
CREATE PROCEDURE ELIMINAR_PRODUCTO(
	IN _id_item_vendible INT
)
BEGIN
	UPDATE item_vendible SET estado = 0 WHERE id_producto = _id_item_vendible;
END$

#------------------------------------------------------------------------------
CREATE PROCEDURE LISTAR_PRODUCTOS_TODOS()
BEGIN
	SELECT i.id_item_vendible, i.nombre, i.precio, i.descripcion, i.estado, p.tipo_producto, p.presentacion, c.id_categoria, c.nombre as nombre_cat, c.descripcion as detalle FROM item_vendible i INNER JOIN producto p ON p.id_producto = i.id_item_vendible INNER JOIN categoria c ON p.fid_categoria = c.id_categoria WHERE i.estado = 1;
END$