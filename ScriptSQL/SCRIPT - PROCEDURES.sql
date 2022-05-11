-- RESTAURANTE ------------------------------------------------------------------------------------------------------------
DELIMITER $
CREATE PROCEDURE INSERTAR_RESTAURANTE(out _id_rest int , in _ruc varchar(20) , in _nombre varchar(50) , in _telefono varchar(20),
									in _direccion varchar(50) , in _dineroActual decimal(10,2))
BEGIN
	insert into restaurante(ruc,nombre,telefono,direccion,dineroActual,activo) 
					values (_ruc,_nombre,_telefono , _direccion , _dineroActual,1) ; 
    set _id_rest = @@last_insert_id ;
END$

CREATE PROCEDURE LISTAR_RESTAURANTE_TODAS()
BEGIN
	select * from restaurante 
    where activo = 1;
END$

CREATE PROCEDURE MODIFICAR_RESTAURANTE(in _id_restaurante int ,in _ruc varchar(50),
									in _nombre varchar(50), in _telefono varchar(50),in _direccion varchar(50),in _dineroActual DECIMAL(10,2),in _activo INT)
begin
	update restaurante set ruc = _ruc ,nombre = _nombre ,telefono = _telefono ,direccion = _direccion, dineroActual = _dineroActual, activo =_activo
    where id_restaurante  =  _id_restaurante ;
end$

CREATE PROCEDURE ELIMINAR_RESTAURANTE(
	IN _id_restaurante INT
)
BEGIN
	UPDATE restaurante SET activo = 0 WHERE id_restaurante = _id_restaurante;
END$

-- PRODUCTO ------------------------------------------------------------------------------------------------------------
CREATE  PROCEDURE INSERTAR_PRODUCTO(
	OUT _id_item_vendible INT,
	IN _nombre VARCHAR(100),
    IN  _precio DECIMAL(10,2),
    IN _descripcion VARCHAR(100), 
    IN _estado TINYINT, 
    IN _fid_tipo_producto CHAR(1), 
    IN  _presentacion VARCHAR(50),
    IN _fid_categoria INT
)
BEGIN
	INSERT INTO item_vendible
    (nombre,precio,descripcion,estado) VALUES(_nombre,_precio,_descripcion,_estado);
    SET _id_item_vendible = @@last_insert_id;
    INSERT INTO producto(id_producto,fid_tipo_producto,presentacion,fid_categoria) VALUES(_id_item_vendible,_fid_tipo_producto,_presentacion,_fid_categoria);
END$

CREATE  PROCEDURE ELIMINAR_PRODUCTO(
	IN _id_item_vendible INT
)
BEGIN
	UPDATE item_vendible SET estado = 0 WHERE id_item_vendible = _id_item_vendible;
END$

CREATE PROCEDURE LISTAR_PRODUCTOS_TODOS()
BEGIN
	SELECT i.id_item_vendible, i.nombre, i.precio, i.descripcion, i.estado, p.fid_tipo_producto, p.presentacion, c.id_categoria, c.nombre as nombre_cat, c.descripcion as detalle 
    FROM item_vendible i INNER JOIN producto p ON p.id_producto = i.id_item_vendible 
    INNER JOIN categoria c ON p.fid_categoria = c.id_categoria 
    WHERE i.estado = 1;
END$

CREATE PROCEDURE MODIFICAR_PRODUCTO(
	IN _id_item_vendible INT,
	IN _nombre VARCHAR(100),
    IN  _precio DECIMAL(10,2),
    IN _descripcion VARCHAR(100), 
    IN _estado TINYINT, 
    IN _fid_tipo_producto CHAR(1), 
    IN  _presentacion VARCHAR(50),
    IN _fid_categoria INT
)
BEGIN
	UPDATE item_vendible SET nombre = _nombre, precio = _precio, descripcion = _descripcion, estado = _estado  WHERE id_item_vendible = _id_item_vendible;
    UPDATE producto SET fid_tipo_producto = _fid_tipo_producto, presentacion = _presentacion, fid_categoria = _fid_categoria WHERE id_producto = _id_item_vendible;
END$

CREATE PROCEDURE LISTAR_PRODUCTOS_X_NOMBRE(IN _nombre VARCHAR(100))
BEGIN
	SELECT i.id_item_vendible, i.nombre, i.precio, i.descripcion, i.estado, p.fid_tipo_producto, p.presentacion, c.id_categoria, c.nombre as nombre_cat, c.descripcion as detalle  
    FROM producto p
    INNER JOIN item_vendible i ON p.id_producto = i.id_item_vendible
    INNER JOIN categoria c ON c.id_categoria = p.id_producto
    WHERE estado = 1 AND 
    i.nombre LIKE CONCAT('%',_nombre,'%');
END$

-- ITEM_VENDIBLE ------------------------------------------------------------------------------------------------------------
CREATE PROCEDURE LISTAR_ITEMVENDIBLE_X_NOMBRE(IN _nombre VARCHAR(100))
BEGIN
	SELECT id_item_vendible, nombre, precio, descripcion FROM item_vendible 
    WHERE estado = 1 AND 
    nombre LIKE CONCAT('%',_nombre,'%');
END$

-- ASISTENCIA --------------------------------------------------------------------------------------------------------------
CREATE  PROCEDURE INSERTAR_ASISTENCIA_ENTRADA(
	OUT _id_asistencia INT,
    IN _fid_usuario INT
)
BEGIN
	INSERT INTO asistencia(fid_usuario,hora_inicio,fecha,activo) 
    VALUES(_fid_usuario,(now()- INTERVAL 5 HOUR),(now()- INTERVAL 5 HOUR),1);
    SET _id_asistencia = @@last_insert_id;
END$

CREATE PROCEDURE ELIMINAR_ASISTENCIA(
	IN _id_asistencia INT
)
BEGIN
	UPDATE asistencia SET activo = 0 WHERE id_asistencia = _id_asistencia;
END$

CREATE PROCEDURE REGISTRAR_ASISTENCIA_SALIDA(
	IN _id_asistencia INT
)
BEGIN
	UPDATE asistencia  SET  hora_fin = (now()- INTERVAL 5 HOUR)
    WHERE id_asistencia = _id_asistencia;
END$

-- GASTO ---------------------------------------------------------------------------------------------------------------
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

CREATE PROCEDURE LISTAR_GASTOS_TODOS()
BEGIN
	SELECT t.id_transaccion, t.fecha, t.total , g.item, g.cantidad, g.precio, g.descripcion, r.id_restaurante,r.nombre,r.dineroActual
		FROM transaccion t INNER JOIN gasto g ON t.id_transaccion = g.id_gasto 
        INNER JOIN restaurante r ON r.id_restaurante = t.fid_restaurante 
        WHERE t.activo = 1;
END$

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
    UPDATE gasto SET item = _item, cantidad = _cantidad, descripcion = _descripcion, precio = _precio;
END$

CREATE PROCEDURE ELIMINAR_GASTO(
	IN _id_transaccion INT
)
BEGIN
	UPDATE transaccion SET estado = 0 WHERE id_transaccion = _id_transaccion;
END$

CREATE TRIGGER ACTUALIZAR_DINEROACTUAL
AFTER INSERT ON transaccion
FOR EACH ROW 
BEGIN
  UPDATE restaurante
  SET dineroActual = dineroActual - new.total
  WHERE id_restaurante = new.fid_restaurante
  AND tipo = 'G'; 
END$


-- MESA ----------------------------------------------------------------------------------------------------
DELIMITER $
CREATE PROCEDURE INSERTAR_MESA(out _id_mesa int , in _capacidad int )
BEGIN
    insert into mesa( capacidad,activo,disponible) values (_capacidad,1,1);
    set _id_mesa = @@last_insert_id ;
END$

CREATE PROCEDURE ELIMINAR_MESA(
    IN _id_mesa INT
)
BEGIN
    UPDATE mesa SET activo = 0 where id_mesa = _id_mesa;
END$

CREATE PROCEDURE LISTAR_MESA_TODOS()
BEGIN
    SELECT id_mesa, capacidad, disponible FROM mesa WHERE activo = 1;
END$

CREATE PROCEDURE MODIFICAR_MESA(
    IN _id_mesa INT,
    IN _capacidad INT,
    IN _activo INT,
    IN _disponible INT
)
BEGIN
    UPDATE mesa SET capacidad = _capacidad , activo = _activo, disponible = _disponible
    WHERE id_mesa = _id_mesa;
END$

-- PERSONA -----------------------------------------------------------------------------------------
CREATE PROCEDURE INSERTAR_PERSONA(out _id_persona int ,in _fid_tipo char, in _nombre varchar(50) , in _apellido_paterno varchar(50) , in _apellido_materno varchar(20),
									in _DNI varchar(50) )
BEGIN
	insert into persona(fid_tipo,nombre,apellido_paterno,apellido_materno,DNI,activo )
					values (_fid_tipo,_nombre,_apellido_paterno,_apellido_materno,_DNI,1) ; 
    set _id_persona = @@last_insert_id ;
END$

CREATE PROCEDURE MODIFICAR_PERSONA(in _id_persona int ,in _nombre varchar(50),in _apellido_paterno varchar(50), in _DNI varchar(10), in _fid_tipo int)
begin
	update persona set nombre = _nombre , apellido_paterno = _apellido_paterno , DNI = _DNI , fid_tipo = _fid_tipo
    where id_persona = _id_persona ; 
end$

CREATE  PROCEDURE INSERTAR_USUARIO(in _id_usuario int , in _fid_rol varchar(50) , in _fid_restaurante varchar(50) ,in _usuario varchar(50),
									in _password varchar(50) , in _salario decimal(10,2) , in _telefono varchar(50))
BEGIN
	insert into usuario(id_usuario, fid_rol,fid_restaurante,usuario,password,salario,telefono) 
					values (_id_usuario, _fid_rol,_fid_restaurante,_usuario,_password,_salario,_telefono) ; 
END$

CREATE PROCEDURE INSERTAR_EMPRESA(out _id_persona int , in _razon_social varchar(100) , in _ruc varchar(30), in _nombre VARCHAR(100), in _fid_tipo char )
begin
	insert into persona(nombre, fid_tipo,razon_social,RUC , activo ) values (_nombre,_fid_tipo , _razon_social , _ruc , 1) ;
	set _id_persona = @@last_insert_id ;
end$