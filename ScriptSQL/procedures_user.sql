DROP PROCEDURE IF EXISTS INSERTAR_ROL;
DROP PROCEDURE IF EXISTS INSERTAR_RESTAURANTE ;
DROP PROCEDURE IF EXISTS INSERTAR_PERSONA ;
DROP PROCEDURE IF EXISTS INSERTAR_USUARIO; 
DELIMITER $ 
CREATE PROCEDURE INSERTAR_ROL(out _id_rol int , in _descripcion varchar(50) )
BEGIN
	insert into rol(descripcion) values (_descripcion) ; 
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
	insert into persona(nombre,apellido_paterno,apellido_materno,DNI,tipo,razon_social,RUC) 
					values (_nombre,_apellidoPat,_apellidoMat , _DNI , _tipo ,_razon_social,_razon_social) ; 
    set _id_persona = @@last_insert_id ;
END$

CREATE PROCEDURE INSERTAR_USUARIO(in _id_usuario int , in _fid_rol varchar(50) , in _fid_restaurante varchar(50) , in _usuario varchar(20),
									in _password varchar(50) , in _estado TINYINT , in _salario decimal(10,2) , in _telefono varchar(50))
BEGIN
	insert into usuario(id_usuario, fid_rol,fid_restaurante,usuario,password,estado,salario,telefono) 
					values (_id_usuario, _fid_rol,_fid_restaurante,_usuario,_password,_estado,_salario,_telefono) ; 
END$