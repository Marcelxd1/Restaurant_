DROP PROCEDURE IF EXISTS INSERTAR_ROL;
DROP PROCEDURE IF EXISTS INSERTAR_RESTAURANTE ;
DROP PROCEDURE IF EXISTS INSERTAR_PERSONA ;
DROP PROCEDURE IF EXISTS INSERTAR_USUARIO; 
DROP PROCEDURE IF EXISTS MODIFICAR_ROL;
DROP PROCEDURE IF EXISTS ELIMINAR_ROL;
DROP PROCEDURE IF EXISTS LISTAR_ROL_TODAS;
DROP PROCEDURE IF EXISTS LISTAR_RESTAURANTE_TODAS ;
DROP PROCEDURE IF EXISTS MODIFICAR_RESTAURANT ;
DROP PROCEDURE IF EXISTS LISTAR_PERSONAS ; 
DROP PROCEDURE IF EXISTS MODIFICAR_PERSONA;
DROP PROCEDURE IF EXISTS ELIMINAR_PERSONA ; 
DROP PROCEDURE IF EXISTS MODIFICAR_USUARIO; 
DROP PROCEDURE IF EXISTS ELIMINAR_USUARIO ; 
DELIMITER $ 
CREATE PROCEDURE INSERTAR_ROL(out _id_rol int , in _descripcion varchar(50) )
BEGIN
	insert into rol(descripcion,activo) values (_descripcion,1) ; 
    set _id_rol = @@last_insert_id ;
END$

CREATE PROCEDURE INSERTAR_RESTAURANTE(out _id_rest int , in _ruc varchar(20) , in _nombre varchar(50) , in _telefono varchar(20),
									in _direccion varchar(50) , in _dineroActual decimal(10,2))
BEGIN
	insert into restaurante(ruc,nombre,telefono,direccion,dineroActual) 
					values (_ruc,_nombre,_telefono , _direccion , _dineroActual) ; 
    set _id_rest = @@last_insert_id ;
END$

CREATE PROCEDURE INSERTAR_PERSONA(out _id_persona int , in _nombre varchar(50) , in _apellidoPat varchar(50) , in _apellidoMat varchar(20),
									in _DNI varchar(50) , in _tipo char , in _razon_social varchar(50) , in _RUC varchar(50))
BEGIN
	insert into persona(nombre,apellido_paterno,apellido_materno,DNI,tipo,razon_social,RUC,activo) 
					values (_nombre,_apellidoPat,_apellidoMat , _DNI , _tipo ,_razon_social,_razon_social,1) ; 
    set _id_persona = @@last_insert_id ;
END$

CREATE PROCEDURE INSERTAR_USUARIO(in _id_usuario int , in _fid_rol varchar(50) , in _fid_restaurante varchar(50) , in _usuario varchar(20),
									in _password varchar(50) , in _estado TINYINT , in _salario decimal(10,2) , in _telefono varchar(50))
BEGIN
	insert into usuario(id_usuario, fid_rol,fid_restaurante,usuario,password,estado,salario,telefono) 
					values (_id_usuario, _fid_rol,_fid_restaurante,_usuario,_password,_estado,_salario,_telefono) ; 
END$


CREATE PROCEDURE MODIFICAR_ROL(IN _idRol int  , IN _descripcion varchar(50))
BEGIN
	update rol set descripcion = _descripcion where rol.id_rol = _idRol;
END$

CREATE PROCEDURE ELIMINAR_ROL(IN _idRol int)
begin
	update rol set activo = 0 where id_rol = _idRol ;
end$

CREATE PROCEDURE LISTAR_ROL_TODAS()
BEGIN
	select id_rol , descripcion from rol where activo = 1  ;
END$
###################################RESTAURANTE######################
CREATE PROCEDURE LISTAR_RESTAURANTE_TODAS()
BEGIN
	select id_restaurante , nombre , ruc from restaurante ;
END$

CREATE PROCEDURE MODIFICAR_RESTAURANT(in _id_restaurante int ,in _ruc varchar(50),
									in _nombre varchar(50), in _telefono varchar(50),in _direccion varchar(50))
begin
	update restaurante set ruc = _ruc ,  nombre = _nombre ,  telefono = _telefono ,  direccion = _direccion
    where id_restaurante  =  1 ;
end$
####################################################################

CREATE PROCEDURE LISTAR_PERSONAS()
BEGIN 
	SELECT id_persona , nombre, apellido_paterno , DNI from persona  ; 
END$

CREATE PROCEDURE MODIFICAR_PERSONA(in _id_persona int ,in _nombre varchar(50),in _apellido_paterno varchar(50), in _DNI varchar(10))
begin
	update persona set nombre = _nombre , apellido_paterno = _apellido_paterno , DNI = _DNI 
    where id_persona = _id_persona ; 
end$

CREATE PROCEDURE ELIMINAR_PERSONA (in _id_persona int )
begin 
	update persona set activo = 0 where id_persona = _id_persona ;
end$

CREATE PROCEDURE LISTAR_USUARIOS()
BEGIN 
	select id_usuario , usuario , salario , telefono from usuario ;
END$

CREATE PROCEDURE MODIFICAR_USUARIO(in _id_usuario int , in _usuario varchar(50) , in _password varchar(50) )
BEGIN
	update usuario set usuario = _usuario , password = _password where id_usuario = _id_usuario ; 
END; 

CREATE PROCEDURE ELIMINAR_USUARIO(in _id_usuario)
begin
	update usuario set activo = 0 where id_usuario = _id_usuario ; 
end $