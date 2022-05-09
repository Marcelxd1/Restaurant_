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
    INSERT INTO producto(id_producto,tipo_producto,presentacion,fid_categoria) VALUES(_id_item_vendible,_tipo_producto,_presentacion,_fid_categoria);
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
	UPDATE item_vendible SET estado = 0 WHERE id_item_vendible = _id_item_vendible;
END$

#------------------------------------------------------------------------------
CREATE PROCEDURE LISTAR_PRODUCTOS_TODOS()
BEGIN
	SELECT i.id_item_vendible, i.nombre, i.precio, i.descripcion, i.estado, p.tipo_producto, p.presentacion, c.id_categoria, c.nombre as nombre_cat, c.descripcion as detalle FROM item_vendible i INNER JOIN producto p ON p.id_producto = i.id_item_vendible INNER JOIN categoria c ON p.fid_categoria = c.id_categoria WHERE i.estado = 1;
END$

DELIMITER $
#------------------------------------------------------------------------------
CREATE PROCEDURE INSERTAR_GASTO(
	OUT _id_transaccion INT,
    IN _fid_restaurante INT,
    IN  _item VARCHAR(100),
    IN _precio DECIMAL(10,2),
    IN _cantidad INT,  
    IN _total DECIMAL(10,2),
    IN _descripcion VARCHAR(100)
)
BEGIN
	INSERT INTO transaccion
    (fid_restaurante,fecha,activo,total,tipo) 
    VALUES(_fid_restaurante,(now()- INTERVAL 5 HOUR),1,_total,'G');
    SET _id_transaccion = @@last_insert_id;
    INSERT INTO gasto(id_gasto,item,precio,cantidad,descripcion) 
    VALUES(_id_transaccion,_item,_precio,_cantidad,_descripcion);
END$

#------------------------------------------------------------------------------
CREATE PROCEDURE LISTAR_GASTOS_TODOS()
BEGIN
	SELECT t.id_transaccion, t.fecha, t.total , g.item, g.cantidad, g.precio, g.descripcion, r.id_restaurante,r.nombre,r.dineroActual
		FROM transaccion t INNER JOIN gasto g ON t.id_transaccion = g.id_gasto 
        INNER JOIN restaurante r ON r.id_restaurante = t.fid_restaurante 
        WHERE t.activo = 1;
END$

#----------------------------------------------------------------------------------
CREATE PROCEDURE MODIFICAR_GASTO(
	IN _id_transaccion INT,
	IN _activo TINYINT,
	IN _item VARCHAR(100),
    IN  _precio DECIMAL(10,2),
    IN _cantidad INT,
    IN _total DECIMAL(10,2),
    IN _descripcion VARCHAR(100)
)
BEGIN
	UPDATE transaccion  SET  activo = _activo, total = _total WHERE id_transaccion = _id_transaccion;
    UPDATE gasto SET item = _item, cantidad = _cantidad, total = _total, descripcion = _descripcion, precio = _precio;
END$

#------------------------------------------------------------------------------
CREATE PROCEDURE ELIMINAR_GASTO(
	IN _id_transaccion INT
)
BEGIN
	UPDATE transaccion SET estado = 0 WHERE id_transaccion = _id_transaccion;
END$

#----------------------------------------------
DELIMITER $
CREATE TRIGGER ACTUALIZAR_DINEROACTUAL
AFTER INSERT ON transaccion
FOR EACH ROW 
BEGIN
  UPDATE restaurante
  SET dineroActual = dineroActual - new.total
  WHERE id_restaurante = new.fid_restaurante
  AND tipo = 'G'; 
END$