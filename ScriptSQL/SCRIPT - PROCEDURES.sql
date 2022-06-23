drop procedure if exists VERIFICAR_CUENTA_USUARIO ;
drop procedure if exists BUSCAR_ROL_POR_ID ;
drop procedure if exists LISTAR_USUARIO_X_NOMBRE ; 
drop procedure if exists MODIFICAR_DATOS_USUARIO ; 
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
    IN _fid_usuario INT
)
BEGIN
	INSERT INTO asistencia(fid_usuario,hora_inicio,fecha,activo) 
    VALUES(_fid_usuario,(now()- INTERVAL 5 HOUR),(now()- INTERVAL 5 HOUR),1);
END$

CREATE PROCEDURE ELIMINAR_ASISTENCIA(
	IN _id_asistencia INT
)
BEGIN
	UPDATE asistencia SET activo = 0 WHERE id_asistencia = _id_asistencia;
END$

CREATE PROCEDURE INSERTAR_ASISTENCIA_SALIDA(
	IN _id_usuario INT
)
BEGIN
	SET @max = (SELECT MAX(hora_inicio) FROM asistencia WHERE _id_usuario = fid_usuario);
	UPDATE asistencia  SET  hora_fin = (now()- INTERVAL 5 HOUR)
    WHERE fid_usuario = _id_usuario AND hora_inicio = @max;
END$

CREATE PROCEDURE LISTAR_ASISTENCIA_TODOS()
BEGIN
	SELECT a.id_asistencia, a.hora_inicio, a.hora_fin, a.fecha, u.id_usuario,p.nombre, p.DNI
		FROM asistencia a INNER JOIN usuario u ON a.fid_usuario = u.id_usuario
        INNER JOIN persona p ON u.id_usuario = p.id_persona
        WHERE a.activo = 1 ;        
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

CREATE  PROCEDURE LISTAR_PERSONAS_TODAS()
BEGIN 
	SELECT p.id_persona , p.nombre, p.apellido_paterno, p.apellido_materno , p.DNI, p.razon_social, p.RUC,t.id_tipo_persona, t.descripcion 
    from persona p INNER JOIN tipo_persona t 
    ON p.fid_tipo = t.id_tipo_persona 
    WHERE p.activo = 1;
END$

CREATE PROCEDURE INSERTAR_PERSONA(out _id_persona int ,in _fid_tipo char, in _nombre varchar(50) , in _apellido_paterno varchar(50) , in _apellido_materno varchar(20),
									in _DNI varchar(50) )
BEGIN
	insert into persona(fid_tipo,nombre,apellido_paterno,apellido_materno,DNI,activo )
					values (_fid_tipo,_nombre,_apellido_paterno,_apellido_materno,_DNI,1) ; 
    set _id_persona = @@last_insert_id ;
END$

CREATE PROCEDURE MODIFICAR_PERSONA(in _id_persona int ,in _nombre varchar(50),in _apellido_paterno varchar(50),in _apellido_materno varchar(50), in _DNI varchar(10))
begin
	update persona set nombre = _nombre , apellido_paterno = _apellido_paterno, apellido_materno = _apellido_materno , DNI = _DNI
    where id_persona = _id_persona ; 
end$

CREATE  PROCEDURE LISTAR_PERSONAS()
BEGIN 
	SELECT p.id_persona , p.nombre, p.apellido_paterno, p.apellido_materno , p.DNI, p.fid_tipo, t.descripcion 
    from persona p INNER JOIN tipo_persona t 
    ON p.fid_tipo = t.id_tipo_persona 
    WHERE p.activo = 1 AND
	p.fid_tipo = 'N';
END$

CREATE PROCEDURE INSERTAR_EMPRESA(out _id_persona int , in _razon_social varchar(100) , in _ruc varchar(30), in _nombre VARCHAR(100), in _fid_tipo char )
begin
	insert into persona(nombre, fid_tipo,razon_social,RUC , activo ) values (_nombre,_fid_tipo , _razon_social , _ruc , 1) ;
	set _id_persona = @@last_insert_id ;
end$

CREATE PROCEDURE MODIFICAR_EMPRESA(in _id_persona int ,in _razon_social varchar(100) , in _ruc varchar(30), in _nombre VARCHAR(100))
begin
	update persona set nombre = _nombre , razon_social = _razon_social, ruc = _ruc
    where id_persona = _id_persona ; 
end$

CREATE  PROCEDURE LISTAR_EMPRESAS()
BEGIN 
	SELECT p.id_persona , p.nombre, p.razon_social, p.RUC, p.fid_tipo, t.descripcion 
    from persona p INNER JOIN tipo_persona t 
    ON p.fid_tipo = t.id_tipo_persona 
    WHERE p.activo = 1 AND
	p.fid_tipo = 'J';
END$

-- USUARIOS

CREATE  PROCEDURE INSERTAR_USUARIO(in _id_usuario int , in _fid_rol varchar(50) , in _fid_restaurante varchar(50) ,in _usuario varchar(50),
									in _password varchar(50) , in _salario decimal(10,2) , in _telefono varchar(50) , in _correo varchar(100) , in _imagen longblob)
BEGIN
	insert into usuario(id_usuario, fid_rol,fid_restaurante,usuario,password,salario,telefono,correo,imagen) 
					values (_id_usuario, _fid_rol,_fid_restaurante,_usuario,_password,_salario,_telefono,_correo,_imagen) ; 
END$

CREATE  PROCEDURE LISTAR_USUARIOS_TODOS()
BEGIN 
	select u.id_usuario , u.usuario , u.salario , u.telefono , p.nombre, p.apellido_paterno, p.apellido_materno, p.DNI
    from usuario u inner join persona p on u.id_usuario = p.id_persona
    where p.activo = 1;
END$

CREATE PROCEDURE LISTAR_USUARIO_X_NOMBRE(IN _nombre VARCHAR(100))
BEGIN
	select u.id_usuario , u.usuario , u.salario , u.telefono , p.nombre, p.apellido_paterno, p.apellido_materno, p.DNI , r.descripcion as rol
    from usuario u 
    inner join persona p on u.id_usuario = p.id_persona
    inner join rol r on r.id_rol = u.fid_rol
    where p.activo = 1 AND  p.nombre LIKE CONCAT('%',_nombre,'%');
END$
CREATE PROCEDURE ELIMINAR_PERSONA (IN _id_persona INT)
BEGIN
	UPDATE persona SET activo = 0 WHERE id_persona = _id_persona ;
END$

DROP PROCEDURE IF EXISTS INSERTAR_PEDIDO;
DROP PROCEDURE IF EXISTS MODIFICAR_PEDIDO;
DROP PROCEDURE IF EXISTS ELIMINAR_PEDIDO;
DROP PROCEDURE IF EXISTS LISTAR_PEDIDOS_TODOS;


#------------------------------------------------------------------------------
CREATE PROCEDURE INSERTAR_PEDIDO(
	OUT _id_transaccion INT, 
    IN _fid_restaurante INT, 
	IN  _total DECIMAL(10,2), 
	IN _fecha DATETIME, 
	
	IN _fid_mesa INT, 
    IN _fid_tipo_pago CHAR(1), 
	IN _fid_mesero INT, 
	IN _fid_cajero INT,
    IN _fid_tipo_pedido CHAR(1), 
	IN _fid_cliente INT, 
	IN _fid_tipo_comprobante CHAR(1),
    IN _numero_comprobante INT, 
	IN _fid_estado_pedido CHAR(1)
)
BEGIN
	INSERT INTO transaccion (fid_restaurante, total, fecha, activo,tipo) 
    VALUES (_fid_restaurante, _total, _fecha, 1,'P');
    SET _id_transaccion = @@last_insert_id;
    
    INSERT INTO pedido (id_pedido, fid_mesa, fid_tipo_pago, fid_mesero, fid_cajero, fid_tipo_pedido, fid_cliente,
    fid_tipo_comprobante, numero_comprobante, fid_estado_pedido)
    VALUES(_id_transaccion, _fid_mesa, _fid_tipo_pago, _fid_mesero, _fid_cajero, _fid_tipo_pedido, _fid_cliente,
    _fid_tipo_comprobante, _numero_comprobante, _fid_estado_pedido);
END$

#------------------------------------------------------------------------------
CREATE PROCEDURE MODIFICAR_PEDIDO(
	IN _id_pedido INT, 
	IN _fid_restaurante INT, 
	IN  _total DECIMAL(10,2), 
	IN _fecha DATETIME,
    
    IN _fid_mesa INT, 
	IN _fid_tipo_pago CHAR(1), 
	IN _fid_mesero INT, 
	IN _fid_cajero INT,
    IN _fid_tipo_pedido CHAR(1), 
	IN _fid_cliente INT, 
	IN _fid_tipo_comprobante CHAR(1),
    IN _numero_comprobante INT, 
	IN _fid_estado_pedido CHAR(1)
)
BEGIN
	UPDATE transaccion 
    SET fid_restaurante = _fid_restaurante, fid_restaurante = _fid_restaurante, total = _total, fecha = _fecha  
    WHERE id_transaccion = _id_pedido;
    UPDATE pedido 
    SET fid_mesa = _fid_mesa, fid_tipo_pago = _fid_tipo_pago, fid_mesero = _fid_mesero, fid_cajero = _fid_cajero,
		fid_tipo_pedido = _fid_tipo_pedido, fid_cliente = _fid_cliente, fid_tipo_comprobante = _fid_tipo_comprobante,
		numero_comprobante = _numero_comprobante, fid_estado_pedido = _fid_estado_pedido
    WHERE id_pedido= _id_pedido;
END$

#------------------------------------------------------------------------------
CREATE PROCEDURE ELIMINAR_PEDIDO (IN _id_transaccion INT)
BEGIN
	UPDATE transaccion SET activo = 0 WHERE id_transaccion = _id_transaccion ;
END$

#------------------------------------------------------------------------------
CREATE PROCEDURE LISTAR_PEDIDOS_TODOS()
BEGIN
	SELECT 	t.id_transaccion, t.fid_restaurante, t.total, t.fecha, 
			m.id_mesa , m.activo, m.capacidad,
            p.fid_tipo_pago, p.fid_mesero, p.fid_cajero, p.fid_cliente,
			p.fid_tipo_pedido, p.fid_tipo_comprobante, p.numero_comprobante, p.fid_estado_pedido
    FROM transaccion t INNER JOIN pedido p ON p.id_pedido = t.id_transaccion
    INNER JOIN mesa m ON m.id_mesa = p.fid_mesa
    WHERE t.activo = 1;
END$

#------------------------------------------------------------------------------
CREATE PROCEDURE BUSCAR_PEDIDO_POR_ID(
	IN _id_pedido INT
)
BEGIN
	SELECT 	t.fid_restaurante, t.total, t.fecha,
    m.id_mesa, m.capacidad,
    p.fid_tipo_pago, p.fid_mesero, p.fid_cajero, p.fid_tipo_pedido, p.fid_cliente, p.fid_tipo_comprobante, 
    p.numero_comprobante, p.fid_estado_pedido
    FROM pedido p INNER JOIN transaccion t ON p.id_pedido = t.id_transaccion
    INNER JOIN mesa m ON m.id_mesa = p.fid_mesa
    WHERE _id_pedido = p.id_pedido and t.activo = 1;
END$


#------------------------------------------------------------------------------------------
#-------------------------------------LINEA PEDIDO-----------------------------------------
DROP PROCEDURE IF EXISTS INSERTAR_LINEA_PEDIDO;
DROP PROCEDURE IF EXISTS MODIFICAR_LINEA_PEDIDO;

#------------------------------------------------------------------------------
CREATE PROCEDURE INSERTAR_LINEA_PEDIDO(
	OUT _id_linea_pedido INT,
    IN _fid_itemVendible INT,
    IN _fid_pedido INT,
    IN _unidades INT,
    IN  _subtotal DECIMAL(10,2)
)
BEGIN
	INSERT INTO linea_pedido (fid_itemVendible, fid_pedido, unidades, subtotal) 
    VALUES (_fid_itemVendible, _fid_pedido, _unidades, _subtotal);
    SET _id_linea_pedido = @@last_insert_id;
END$


#------------------------------------------------------------------------------
CREATE PROCEDURE MODIFICAR_LINEA_PEDIDO(
	IN _id_linea_pedido INT,
    IN _fid_itemVendible INT,
    IN _fid_pedido INT,
    IN _unidades INT,
    IN  _subtotal DECIMAL(10,2)
)
BEGIN
	UPDATE linea_pedido SET fid_itemVendible = _fid_itemVendible, fid_pedido = _fid_pedido, 
    unidades = _unidades, subtotal = _subtotal 
    WHERE id_linea_pedido = _id_linea_pedido;    
END$

DROP PROCEDURE IF EXISTS LISTAR_LINEA_PEDIDO;

CREATE PROCEDURE LISTAR_LINEA_PEDIDO ()
BEGIN
	SELECT l.id_linea_pedido, i.id_item_vendible, i.nombre, i.precio, i.descripcion, 
    l.fid_pedido, l.unidades, l.subtotal
    FROM linea_pedido l INNER JOIN item_vendible i ON l.fid_itemVendible = i.id_item_vendible
    ;
END$

#-------------------------------------------------------------------------------------
#----------------------------------------USUARIO--------------------------------------

DROP PROCEDURE IF EXISTS BUSCAR_USUARIO_POR_ID;

#------------------------------------------------------------------------------
CREATE PROCEDURE BUSCAR_USUARIO_POR_ID (IN _id_usuario INT)
BEGIN
	SELECT 	p.nombre, p.apellido_paterno, p.apellido_materno, p.DNI, p.fid_tipo , p.razon_social, p.RUC,
			r.id_rol, r.descripcion, 
            u.fid_restaurante, u.usuario, u.password, u.salario, u.telefono
    FROM usuario u INNER JOIN persona p ON p.id_persona = u.id_usuario
    INNER JOIN rol r ON u.fid_rol = r.id_rol
    WHERE _id_usuario = u.id_usuario and p.activo = 1;
END$


#-----------------------------------------------------------------------------------------
#----------------------------------------RESTAURANTE--------------------------------------
DROP PROCEDURE IF EXISTS BUSCAR_RESTAURANTE_POR_ID;

#------------------------------------------------------------------------------
CREATE PROCEDURE BUSCAR_RESTAURANTE_POR_ID(
	IN _id_restaurante INT
)
BEGIN
	SELECT r.ruc, r.nombre, r.telefono, r.direccion, r.dineroActual
    FROM restaurante r
    WHERE _id_restaurante = r.id_restaurante;
END$

#-------------------------------------------------------------------------------------
#----------------------------------------PERSONA--------------------------------------
CREATE  PROCEDURE LISTAR_CLIENTES_X_NOMBRE(in _nombre varchar(50))
BEGIN 
	SELECT p.id_persona , p.nombre, p.apellido_paterno, p.apellido_materno , p.DNI, p.razon_social, p.RUC,t.id_tipo_persona, t.descripcion 
    from persona p INNER JOIN tipo_persona t 
    ON p.fid_tipo = t.id_tipo_persona 
    WHERE p.activo = 1 AND p.nombre LIKE CONCAT('%',_nombre,'%');
END$


DROP PROCEDURE IF EXISTS BUSCAR_PERSONA_POR_ID;

#------------------------------------------------------------------------------
CREATE PROCEDURE BUSCAR_PERSONA_POR_ID(
	IN _id_persona INT
)
BEGIN
	SELECT 	p.nombre, p.apellido_paterno, p.apellido_materno, p.DNI, p.fid_tipo , p.razon_social, p.RUC
    FROM persona p
    WHERE id_persona = _id_persona and activo = 1;
END$

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

#------------------------------------------------------------------------------------------
#-------------------------------------PROMOCIONES-----------------------------------------
DROP PROCEDURE IF EXISTS INSERTAR_PROMOCION;
DROP PROCEDURE IF EXISTS MODIFICAR_PROMOCION;
DROP PROCEDURE IF EXISTS ELIMINAR_PROMOCION;
DROP PROCEDURE IF EXISTS LISTAR_PROMOCIONES_TODOS;
DROP PROCEDURE IF EXISTS INSERTAR_LINEA_PROMOCION;
DROP PROCEDURE IF EXISTS LISTAR_LINEA_PROMOCION_PROMO;
DROP PROCEDURE IF EXISTS MODIFICAR_LINEA_PROMOCION;
DROP PROCEDURE IF EXISTS BUSCAR_PERSONA_POR_ID;
DROP PROCEDURE IF EXISTS ELIMINAR_LINEA_PROMOCION;
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


CREATE PROCEDURE LISTAR_PROMOCIONES_X_NOMBRE(
	IN _nom varchar(200) 
)
BEGIN	
	SELECT iv.id_item_vendible, iv.nombre, iv.precio , iv.descripcion, iv.estado from promocion p 
    INNER JOIN item_vendible iv ON p.id_promocion= iv.id_item_vendible 
    WHERE iv.estado= 1 and iv.nombre like CONCAT('%',_nom,'%');
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

CREATE PROCEDURE ELIMINAR_LINEA_PROMOCION(
	IN _idlinea INT,
    IN _idPromo INT
)
BEGIN
    UPDATE linea_promocion SET estado = False where fid_promocion = _idPromo and id_linea_promocion=_idlinea;
END$

CREATE procedure LISTAR_LINEA_PROMOCION_PROMO(
	in _idPromo INT -- es el id de la proomocion que es el id itemvendible en la lista IV 
)BEGIN
	SELECT lin.fid_producto, lin.fid_promocion, lin.id_linea_promocion, lin.unidad ,
    pro.id_producto, iv.nombre , iv.estado, iv.precio, iv.descripcion ,iv.id_item_vendible, 
    pro.fid_tipo_producto, pro.presentacion, pro.fid_categoria, cat.activo, cat.descripcion, cat.id_categoria, cat.nombre 
    FROM linea_promocion lin 
    INNER JOIN 
    producto pro ON lin.fid_producto= pro.id_producto 
    INNER JOIN 
    item_vendible iv ON pro.id_producto= id_item_vendible
    INNER JOIN 
    categoria cat ON cat.id_categoria= pro.fid_categoria
    WHERE lin.fid_promocion= _idPromo and lin.estado = 1;
END$

-- procedure para buscar persona por ID
CREATE procedure BUSCAR_PERSONA_POR_ID(
	IN _id_persona	INT
)BEGIN
	SELECT id_persona , nombre, apellido_paterno , DNI from persona where _id_persona= id_persona ;
END$
-- ---------------------------
CREATE PROCEDURE VERIFICAR_CUENTA_USUARIO(in _username varchar(100) , in _password varchar(100))
begin
	select * from usuario where usuario = _username and password = _password ;
end $

CREATE PROCEDURE BUSCAR_ROL_POR_ID(in _id_rol int)
begin
	select * from rol where id_rol = _id_rol ; 
end $


CREATE PROCEDURE LISTAR_USUARIO_X_NOMBRE(IN _nombre VARCHAR(100))
BEGIN
	select u.id_usuario , u.usuario , u.salario , u.telefono , p.nombre, p.apellido_paterno, p.apellido_materno, p.DNI , r.descripcion as rol , r.id_rol as id_rol
    from usuario u 
    inner join persona p on u.id_usuario = p.id_persona
    inner join rol r on r.id_rol = u.fid_rol
    where p.activo = 1 AND  p.nombre LIKE CONCAT('%',_nombre,'%');
END$


CREATE PROCEDURE MODIFICAR_DATOS_USUARIO(in _id_usuario int , in _fid_rol int , in _salario decimal(10,2) , in _telefono varchar(30)  )
begin 
	update usuario set 	fid_rol = _fid_rol , salario = _salario , telefono = _telefono 
    where id_usuario = _id_usuario ; 
end$