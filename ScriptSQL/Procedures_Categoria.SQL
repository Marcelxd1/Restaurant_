DROP PROCEDURE IF EXISTS LISTAR_CATEGORIAS_TODAS;
DROP PROCEDURE IF EXISTS INSERTAR_CATEGORIA;
DROP PROCEDURE IF EXISTS MODIFICAR_CATEGORIA;
DROP PROCEDURE IF EXISTS ELIMINAR_CATEGORIA;
DROP PROCEDURE IF EXISTS BUSCAR_CATEGORIA_POR_ID;

DELIMITER $
#------------------------------------------------------------------------------
CREATE PROCEDURE LISTAR_CATEGORIAS_TODAS()
BEGIN
	SELECT id_categoria, nombre, descripcion FROM categoria WHERE activo = 1;
END$

#------------------------------------------------------------------------------
CREATE PROCEDURE INSERTAR_CATEGORIA(
	OUT _id_categoria INT,
    IN _nombre VARCHAR(100),
	IN _descripcion VARCHAR(100)
)
BEGIN
	INSERT INTO categoria(nombre, descripcion, activo) VALUES(_nombre, _descripcion, 1);
    SET _id_categoria = @@last_insert_id;
END$

#------------------------------------------------------------------------------
CREATE PROCEDURE MODIFICAR_CATEGORIA(
	IN _id_categoria INT,
    IN _nombre VARCHAR(100),
	IN _descripcion VARCHAR(100)
)
BEGIN
	UPDATE categoria SET nombre = _nombre, descripcion = _descripcion 
	WHERE id_categoria = _id_categoria;
END$

#------------------------------------------------------------------------------
#preguntar si habra una clase activo
CREATE PROCEDURE ELIMINAR_CATEGORIA(
	IN _id_categoria INT
)
BEGIN
	UPDATE categoria SET activo = 0 where id_categoria = _id_categoria;
END$

#------------------------------------------------------------------------------
CREATE PROCEDURE BUSCAR_CATEGORIA_POR_ID(
	IN _id_categoria INT
)
BEGIN
	SELECT nombre, descripcion FROM categoria WHERE id_categoria = _id_categoria and activo = 1;
END$


