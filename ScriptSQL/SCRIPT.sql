-- -----------------------------------------------------
-- Schema Restaurante
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `Restaurante` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci ;
USE `Restaurante` ;

-- -----------------------------------------------------
-- Table `Restaurante`.`rol`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Restaurante`.`rol` (
  `id_rol` INT NOT NULL AUTO_INCREMENT,
  `descripcion` VARCHAR(120) NULL DEFAULT NULL,
  `activo` TINYINT(1) NULL DEFAULT NULL,
  PRIMARY KEY (`id_rol`))
ENGINE = InnoDB
AUTO_INCREMENT = 5
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `Restaurante`.`restaurante`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Restaurante`.`restaurante` (
  `id_restaurante` INT NOT NULL AUTO_INCREMENT,
  `ruc` VARCHAR(20) NULL DEFAULT NULL,
  `nombre` VARCHAR(120) NULL DEFAULT NULL,
  `telefono` VARCHAR(20) NULL DEFAULT NULL,
  `direccion` VARCHAR(120) NULL DEFAULT NULL,
  `dineroActual` DECIMAL(10,2) NULL DEFAULT NULL,
  `activo` TINYINT(1) NULL DEFAULT NULL,
  PRIMARY KEY (`id_restaurante`))
ENGINE = InnoDB
AUTO_INCREMENT = 3
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `Restaurante`.`tipo_persona`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Restaurante`.`tipo_persona` (
  `id_tipo_persona` CHAR(1) NOT NULL,
  `descripcion` VARCHAR(50) NULL DEFAULT NULL,
  PRIMARY KEY (`id_tipo_persona`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `Restaurante`.`persona`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Restaurante`.`persona` (
  `id_persona` INT NOT NULL AUTO_INCREMENT,
  `fid_tipo` CHAR(1) NOT NULL,
  `nombre` VARCHAR(45) NULL DEFAULT NULL,
  `apellido_paterno` VARCHAR(45) NULL DEFAULT NULL,
  `apellido_materno` VARCHAR(45) NULL DEFAULT NULL,
  `DNI` VARCHAR(45) NULL DEFAULT NULL,
  `razon_social` VARCHAR(45) NULL DEFAULT NULL,
  `RUC` VARCHAR(45) NULL DEFAULT NULL,
  `activo` TINYINT(1) NULL DEFAULT NULL,
  PRIMARY KEY (`id_persona`),
  INDEX `fid_tipo` (`fid_tipo` ASC) VISIBLE,
  CONSTRAINT `persona_ibfk_1`
    FOREIGN KEY (`fid_tipo`)
    REFERENCES `Restaurante`.`tipo_persona` (`id_tipo_persona`))
ENGINE = InnoDB
AUTO_INCREMENT = 34
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `Restaurante`.`usuario`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Restaurante`.`usuario` (
  `id_usuario` INT NOT NULL AUTO_INCREMENT,
  `fid_rol` INT NOT NULL,
  `fid_restaurante` INT NOT NULL,
  `usuario` VARCHAR(30) NULL DEFAULT NULL,
  `password` VARCHAR(45) NULL DEFAULT NULL,
  `imagen` LONGBLOB NULL DEFAULT NULL,
  `salario` DECIMAL(10,2) NULL DEFAULT NULL,
  `telefono` VARCHAR(20) NULL DEFAULT NULL,
  `correo` VARCHAR(100) NULL DEFAULT NULL,
  PRIMARY KEY (`id_usuario`),
  INDEX `fid_rol` (`fid_rol` ASC) VISIBLE,
  INDEX `fid_restaurante` (`fid_restaurante` ASC) VISIBLE,
  CONSTRAINT `usuario_ibfk_1`
    FOREIGN KEY (`fid_rol`)
    REFERENCES `Restaurante`.`rol` (`id_rol`),
  CONSTRAINT `usuario_ibfk_2`
    FOREIGN KEY (`fid_restaurante`)
    REFERENCES `Restaurante`.`restaurante` (`id_restaurante`),
  CONSTRAINT `usuario_ibfk_3`
    FOREIGN KEY (`id_usuario`)
    REFERENCES `Restaurante`.`persona` (`id_persona`))
ENGINE = InnoDB
AUTO_INCREMENT = 34
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `Restaurante`.`asistencia`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Restaurante`.`asistencia` (
  `id_asistencia` INT NOT NULL AUTO_INCREMENT,
  `fid_usuario` INT NOT NULL,
  `hora_inicio` TIME NULL DEFAULT NULL,
  `hora_fin` TIME NULL DEFAULT NULL,
  `fecha` DATE NULL DEFAULT NULL,
  `activo` TINYINT(1) NULL DEFAULT NULL,
  PRIMARY KEY (`id_asistencia`),
  INDEX `fid_usuario` (`fid_usuario` ASC) VISIBLE,
  CONSTRAINT `asistencia_ibfk_1`
    FOREIGN KEY (`fid_usuario`)
    REFERENCES `Restaurante`.`usuario` (`id_usuario`))
ENGINE = InnoDB
AUTO_INCREMENT = 9
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `Restaurante`.`categoria`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Restaurante`.`categoria` (
  `id_categoria` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(100) NULL DEFAULT NULL,
  `descripcion` VARCHAR(100) NULL DEFAULT NULL,
  `activo` TINYINT(1) NULL DEFAULT NULL,
  PRIMARY KEY (`id_categoria`))
ENGINE = InnoDB
AUTO_INCREMENT = 17
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `Restaurante`.`estado_pedido`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Restaurante`.`estado_pedido` (
  `id_estado_pedido` CHAR(1) NOT NULL,
  `descripcion` VARCHAR(20) NULL DEFAULT NULL,
  PRIMARY KEY (`id_estado_pedido`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `Restaurante`.`transaccion`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Restaurante`.`transaccion` (
  `id_transaccion` INT NOT NULL AUTO_INCREMENT,
  `fid_restaurante` INT NOT NULL,
  `total` DECIMAL(10,2) NULL DEFAULT NULL,
  `fecha` DATETIME NULL DEFAULT NULL,
  `activo` TINYINT(1) NULL DEFAULT NULL,
  `tipo` CHAR(1) NULL DEFAULT NULL,
  PRIMARY KEY (`id_transaccion`),
  INDEX `fid_restaurante` (`fid_restaurante` ASC) VISIBLE,
  CONSTRAINT `transaccion_ibfk_1`
    FOREIGN KEY (`fid_restaurante`)
    REFERENCES `Restaurante`.`restaurante` (`id_restaurante`))
ENGINE = InnoDB
AUTO_INCREMENT = 65
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `Restaurante`.`gasto`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Restaurante`.`gasto` (
  `id_gasto` INT NOT NULL AUTO_INCREMENT,
  `item` VARCHAR(100) NULL DEFAULT NULL,
  `precio` DOUBLE(10,2) NULL DEFAULT NULL,
  `cantidad` INT NULL DEFAULT NULL,
  `descripcion` VARCHAR(100) NULL DEFAULT NULL,
  PRIMARY KEY (`id_gasto`),
  CONSTRAINT `fk_gasto_trans`
    FOREIGN KEY (`id_gasto`)
    REFERENCES `Restaurante`.`transaccion` (`id_transaccion`))
ENGINE = InnoDB
AUTO_INCREMENT = 43
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `Restaurante`.`item_vendible`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Restaurante`.`item_vendible` (
  `id_item_vendible` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(100) NULL DEFAULT NULL,
  `precio` DOUBLE NULL DEFAULT NULL,
  `descripcion` VARCHAR(100) NULL DEFAULT NULL,
  `estado` TINYINT(1) NULL DEFAULT NULL,
  `imagen` LONGBLOB NULL DEFAULT NULL,
  PRIMARY KEY (`id_item_vendible`))
ENGINE = InnoDB
AUTO_INCREMENT = 43
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `Restaurante`.`mesa`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Restaurante`.`mesa` (
  `id_mesa` INT NOT NULL AUTO_INCREMENT,
  `capacidad` INT NULL DEFAULT NULL,
  `activo` TINYINT(1) NULL DEFAULT NULL,
  `disponible` TINYINT(1) NULL DEFAULT NULL,
  `numMesa` INT NULL DEFAULT NULL,
  PRIMARY KEY (`id_mesa`))
ENGINE = InnoDB
AUTO_INCREMENT = 30
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `Restaurante`.`tipo_pago`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Restaurante`.`tipo_pago` (
  `id_tipo_pago` CHAR(1) NOT NULL,
  `descripcion` VARCHAR(20) NULL DEFAULT NULL,
  PRIMARY KEY (`id_tipo_pago`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `Restaurante`.`tipo_pedido`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Restaurante`.`tipo_pedido` (
  `id_tipo_pedido` CHAR(1) NOT NULL,
  `descripcion` VARCHAR(20) NULL DEFAULT NULL,
  PRIMARY KEY (`id_tipo_pedido`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `Restaurante`.`tipo_comprobante`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Restaurante`.`tipo_comprobante` (
  `id_tipo_comprobante` CHAR(1) NOT NULL,
  `descripcion` VARCHAR(20) NULL DEFAULT NULL,
  PRIMARY KEY (`id_tipo_comprobante`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `Restaurante`.`pedido`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Restaurante`.`pedido` (
  `id_pedido` INT NOT NULL AUTO_INCREMENT,
  `fid_mesa` INT NULL DEFAULT NULL,
  `fid_tipo_pago` CHAR(1) NULL DEFAULT NULL,
  `fid_mesero` INT NULL DEFAULT NULL,
  `fid_cajero` INT NULL DEFAULT NULL,
  `fid_tipo_pedido` CHAR(1) NOT NULL,
  `fid_cliente` INT NULL DEFAULT NULL,
  `fid_tipo_comprobante` CHAR(1) NULL DEFAULT NULL,
  `fid_estado_pedido` CHAR(1) NOT NULL,
  `numero_comprobante` INT NULL DEFAULT NULL,
  `pagado` TINYINT(1) NULL DEFAULT NULL,
  PRIMARY KEY (`id_pedido`),
  INDEX `fid_mesa` (`fid_mesa` ASC) VISIBLE,
  INDEX `fid_mesero` (`fid_mesero` ASC) VISIBLE,
  INDEX `fid_cajero` (`fid_cajero` ASC) VISIBLE,
  INDEX `fid_tipo_pago` (`fid_tipo_pago` ASC) VISIBLE,
  INDEX `pedido_ibfk_7_idx` (`fid_cliente` ASC) VISIBLE,
  INDEX `fid_tipo_pedido` (`fid_tipo_pedido` ASC) INVISIBLE,
  INDEX `fid_tipo_comprobante` (`fid_tipo_comprobante` ASC) VISIBLE,
  INDEX `fid_estado_pedido` (`fid_estado_pedido` ASC) INVISIBLE,
  CONSTRAINT `pedido_ibfk_1`
    FOREIGN KEY (`fid_mesa`)
    REFERENCES `Restaurante`.`mesa` (`id_mesa`),
  CONSTRAINT `pedido_ibfk_10`
    FOREIGN KEY (`fid_estado_pedido`)
    REFERENCES `Restaurante`.`estado_pedido` (`id_estado_pedido`),
  CONSTRAINT `pedido_ibfk_3`
    FOREIGN KEY (`fid_mesero`)
    REFERENCES `Restaurante`.`usuario` (`id_usuario`),
  CONSTRAINT `pedido_ibfk_4`
    FOREIGN KEY (`fid_cajero`)
    REFERENCES `Restaurante`.`usuario` (`id_usuario`),
  CONSTRAINT `pedido_ibfk_5`
    FOREIGN KEY (`fid_tipo_pago`)
    REFERENCES `Restaurante`.`tipo_pago` (`id_tipo_pago`),
  CONSTRAINT `pedido_ibfk_7`
    FOREIGN KEY (`fid_cliente`)
    REFERENCES `Restaurante`.`persona` (`id_persona`),
  CONSTRAINT `pedido_ibfk_8`
    FOREIGN KEY (`fid_tipo_pedido`)
    REFERENCES `Restaurante`.`tipo_pedido` (`id_tipo_pedido`),
  CONSTRAINT `pedido_ibfk_9`
    FOREIGN KEY (`fid_tipo_comprobante`)
    REFERENCES `Restaurante`.`tipo_comprobante` (`id_tipo_comprobante`))
ENGINE = InnoDB
AUTO_INCREMENT = 65
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `Restaurante`.`linea_pedido`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Restaurante`.`linea_pedido` (
  `id_linea_pedido` INT NOT NULL AUTO_INCREMENT,
  `fid_itemVendible` INT NOT NULL,
  `fid_pedido` INT NOT NULL,
  `unidades` INT NOT NULL,
  `subtotal` DOUBLE NULL DEFAULT NULL,
  `activo` TINYINT(1) NULL DEFAULT NULL,
  PRIMARY KEY (`id_linea_pedido`),
  INDEX `fk_Linea_Pedido_ItemVendible_idx` (`fid_itemVendible` ASC) VISIBLE,
  INDEX `fk_Linea_Pedido_pedido1_idx` (`fid_pedido` ASC) VISIBLE,
  CONSTRAINT `fk_Linea_Pedido_ItemVendible`
    FOREIGN KEY (`fid_itemVendible`)
    REFERENCES `Restaurante`.`item_vendible` (`id_item_vendible`),
  CONSTRAINT `fk_Linea_Pedido_pedido1`
    FOREIGN KEY (`fid_pedido`)
    REFERENCES `Restaurante`.`pedido` (`id_pedido`))
ENGINE = InnoDB
AUTO_INCREMENT = 96
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `Restaurante`.`tipo_producto`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Restaurante`.`tipo_producto` (
  `id_tipo_producto` CHAR(1) NOT NULL,
  `descripcion` VARCHAR(20) NULL DEFAULT NULL,
  PRIMARY KEY (`id_tipo_producto`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `Restaurante`.`producto`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Restaurante`.`producto` (
  `id_producto` INT NOT NULL AUTO_INCREMENT,
  `fid_categoria` INT NULL DEFAULT NULL,
  `fid_tipo_producto` CHAR(1) NOT NULL,
  `presentacion` VARCHAR(45) NULL DEFAULT NULL,
  PRIMARY KEY (`id_producto`),
  INDEX `fk_Producto_tipo_comida_idx` (`fid_categoria` ASC) VISIBLE,
  INDEX `fid_tipo_producto` (`fid_tipo_producto` ASC) VISIBLE,
  CONSTRAINT `fk_Producto_Item_vendible`
    FOREIGN KEY (`id_producto`)
    REFERENCES `Restaurante`.`item_vendible` (`id_item_vendible`),
  CONSTRAINT `fk_Producto_tipo_comida`
    FOREIGN KEY (`fid_categoria`)
    REFERENCES `Restaurante`.`categoria` (`id_categoria`),
  CONSTRAINT `producto_ibfk_1`
    FOREIGN KEY (`fid_tipo_producto`)
    REFERENCES `Restaurante`.`tipo_producto` (`id_tipo_producto`))
ENGINE = InnoDB
AUTO_INCREMENT = 43
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `Restaurante`.`promocion`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Restaurante`.`promocion` (
  `id_promocion` INT NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`id_promocion`),
  INDEX `fk_PromocionCombo_ItemVendible1_idx` (`id_promocion` ASC) VISIBLE,
  CONSTRAINT `fk_PromocionCombo_ItemVendible1`
    FOREIGN KEY (`id_promocion`)
    REFERENCES `Restaurante`.`item_vendible` (`id_item_vendible`))
ENGINE = InnoDB
AUTO_INCREMENT = 41
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `Restaurante`.`linea_promocion`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Restaurante`.`linea_promocion` (
  `id_linea_promocion` INT NOT NULL AUTO_INCREMENT,
  `fid_promocion` INT NOT NULL,
  `fid_producto` INT NOT NULL,
  `unidad` INT NOT NULL,
  `estado` TINYINT(1) NULL DEFAULT NULL,
  PRIMARY KEY (`id_linea_promocion`),
  INDEX `fid_producto_linea_idx` (`fid_producto` ASC) VISIBLE,
  INDEX `fid_promocion_line` (`fid_promocion` ASC) VISIBLE,
  CONSTRAINT `fid_producto_linea`
    FOREIGN KEY (`fid_producto`)
    REFERENCES `Restaurante`.`producto` (`id_producto`),
  CONSTRAINT `fid_promocion_line`
    FOREIGN KEY (`fid_promocion`)
    REFERENCES `Restaurante`.`promocion` (`id_promocion`))
ENGINE = InnoDB
AUTO_INCREMENT = 22
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;

USE `Restaurante` ;

-- -----------------------------------------------------
-- procedure BUSCAR_CATEGORIA_POR_ID
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE PROCEDURE `BUSCAR_CATEGORIA_POR_ID`(
	IN _id_categoria INT
)
BEGIN
	SELECT nombre, descripcion FROM categoria WHERE id_categoria = _id_categoria and activo = 1;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure BUSCAR_LINEAPEDIDO_POR_ID
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE  PROCEDURE `BUSCAR_LINEAPEDIDO_POR_ID`(IN _id_lineaPedido INT)
BEGIN
	SELECT 	i.id_item_vendible, i.nombre, i.precio, i.descripcion, 
			l.fid_pedido, l.unidades, l.subtotal
    FROM linea_pedido l INNER JOIN item_vendible i ON l.fid_itemVendible = i.id_item_vendible 
    WHERE _id_lineaPedido = l.id_lineaPedido and i.estado = 1 and l.activo  = 1;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure BUSCAR_LINEAPEDIDO_POR_PEDIDO
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE  PROCEDURE `BUSCAR_LINEAPEDIDO_POR_PEDIDO`(IN _id_pedido INT)
BEGIN
	SELECT 	l.id_linea_pedido,i.id_item_vendible, i.nombre, i.precio, i.descripcion, 
			l.fid_pedido, l.unidades, l.subtotal
    FROM linea_pedido l INNER JOIN item_vendible i ON l.fid_itemVendible = i.id_item_vendible 
    WHERE l.fid_pedido = _id_pedido and i.estado = 1 and l.activo = 1;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure BUSCAR_MESA_ID
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE  PROCEDURE `BUSCAR_MESA_ID`(in _id_mesa INT)
BEGIN
    SELECT id_mesa, capacidad, numMesa, disponible FROM mesa 
    WHERE activo = 1 AND id_mesa = _id_mesa;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure BUSCAR_PEDIDO_POR_ID
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE  PROCEDURE `BUSCAR_PEDIDO_POR_ID`(
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
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure BUSCAR_PEDIDO_POR_MESA
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE  PROCEDURE `BUSCAR_PEDIDO_POR_MESA`(IN _fid_mesa INT)
BEGIN
	SELECT 	t.id_transaccion, t.fid_restaurante, t.total, t.fecha, 
			m.id_mesa , m.activo, m.capacidad,
            p.fid_mesero, p.fid_cliente,
			p.fid_tipo_pedido, p.numero_comprobante, p.fid_estado_pedido
    FROM transaccion t INNER JOIN pedido p ON p.id_pedido = t.id_transaccion
    INNER JOIN mesa m ON m.id_mesa = p.fid_mesa
    WHERE t.activo = 1 
    AND p.fid_mesa = _fid_mesa AND p.pagado = 0;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure BUSCAR_PERSONA_POR_ID
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE  PROCEDURE `BUSCAR_PERSONA_POR_ID`(
	IN _id_persona	INT
)
BEGIN
	SELECT id_persona , nombre, apellido_paterno,apellido_materno , DNI, RUC, fid_tipo from persona where _id_persona= id_persona ;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure BUSCAR_RESTAURANTE_POR_ID
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE  PROCEDURE `BUSCAR_RESTAURANTE_POR_ID`(
	IN _id_restaurante INT
)
BEGIN
	SELECT r.ruc, r.nombre, r.telefono, r.direccion, r.dineroActual
    FROM restaurante r
    WHERE _id_restaurante = r.id_restaurante;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure BUSCAR_ROL_POR_ID
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE  PROCEDURE `BUSCAR_ROL_POR_ID`(in _id_rol int)
begin
	select * from rol where id_rol = _id_rol ; 
end$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure BUSCAR_USUARIO_POR_ID
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE  PROCEDURE `BUSCAR_USUARIO_POR_ID`(IN _id_usuario INT)
BEGIN
	SELECT 	p.nombre, p.apellido_paterno, p.apellido_materno, p.DNI, p.fid_tipo , p.razon_social, p.RUC,
			r.id_rol, r.descripcion, 
            u.fid_restaurante, u.usuario, u.password, u.salario, u.telefono
    FROM usuario u INNER JOIN persona p ON p.id_persona = u.id_usuario
    INNER JOIN rol r ON u.fid_rol = r.id_rol
    WHERE _id_usuario = u.id_usuario and p.activo = 1;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure CAMBIAR_CONTRASENIA
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE  PROCEDURE `CAMBIAR_CONTRASENIA`(in _id_usuario int, in _password varchar(100))
BEGIN
	update usuario set password = _password where id_usuario = _id_usuario ; 
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure ELIMINAR_ASISTENCIA
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE  PROCEDURE `ELIMINAR_ASISTENCIA`(
	IN _id_asistencia INT
)
BEGIN
	UPDATE asistencia SET activo = 0 WHERE id_asistencia = _id_asistencia;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure ELIMINAR_CATEGORIA
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE  PROCEDURE `ELIMINAR_CATEGORIA`(
	IN _id_categoria INT
)
BEGIN
	UPDATE categoria SET activo = 0 where id_categoria = _id_categoria;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure ELIMINAR_GASTO
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE  PROCEDURE `ELIMINAR_GASTO`(
	IN _id_transaccion INT
)
BEGIN
	UPDATE transaccion SET activo = 0 WHERE id_transaccion = _id_transaccion;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure ELIMINAR_LINEA_PROMOCION
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE PROCEDURE `ELIMINAR_LINEA_PROMOCION`(
	IN _idlinea INT,
    IN _idPromo INT
)
BEGIN
    UPDATE linea_promocion SET estado = False where fid_promocion = _idPromo and id_linea_promocion=_idlinea;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure ELIMINAR_MESA
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE  PROCEDURE `ELIMINAR_MESA`(
    IN _id_mesa INT
)
BEGIN
    UPDATE mesa SET activo = 0 where id_mesa = _id_mesa;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure ELIMINAR_PEDIDO
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE  PROCEDURE `ELIMINAR_PEDIDO`(
	IN _id_transaccion  INT
)
BEGIN
	UPDATE transaccion SET activo = 0 WHERE id_transaccion = _id_transaccion ;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure ELIMINAR_PERSONA
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE PROCEDURE `ELIMINAR_PERSONA`(in _id_persona int )
begin 
	update persona set activo = 0 where id_persona = _id_persona ;
end$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure ELIMINAR_PRODUCTO
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE PROCEDURE `ELIMINAR_PRODUCTO`(
	IN _id_item_vendible INT
)
BEGIN
	UPDATE item_vendible SET estado = 0 WHERE id_item_vendible = _id_item_vendible;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure ELIMINAR_PROMOCION
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE  PROCEDURE `ELIMINAR_PROMOCION`(
	IN _id_item_vendible INT
)
BEGIN
	-- es una dependencia absoluta por eso lo puse en 1 porque no se puede desactivar 
    -- independientemente la linea 
	UPDATE item_vendible SET estado = False WHERE id_item_vendible = _id_item_vendible;
    UPDATE linea_promocion SET estado = False where fid_promocion = _id_item_vendible;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure ELIMINAR_RESTAURANTE
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE  PROCEDURE `ELIMINAR_RESTAURANTE`(
	IN _id_restaurante INT
)
BEGIN
	UPDATE restaurante SET activo = 0 WHERE id_restaurante = _id_restaurante;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure ELIMINAR_ROL
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE PROCEDURE `ELIMINAR_ROL`(IN _idRol int)
begin
	update rol set activo = 0 where id_rol = _idRol ;
end$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure ELIMINAR_USUARIO
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE  PROCEDURE `ELIMINAR_USUARIO`(IN _id_usuario INT)
BEGIN
	UPDATE persona SET activo = 0 WHERE id_persona = _id_usuario ;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure INSERTAR_ASISTENCIA_ENTRADA
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE  PROCEDURE `INSERTAR_ASISTENCIA_ENTRADA`(
    IN _fid_usuario INT
)
BEGIN
	INSERT INTO asistencia(fid_usuario,hora_inicio,fecha,activo) 
    VALUES(_fid_usuario,(now()- INTERVAL 5 HOUR),(now()- INTERVAL 5 HOUR),1);
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure INSERTAR_ASISTENCIA_SALIDA
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE  PROCEDURE `INSERTAR_ASISTENCIA_SALIDA`(
	IN _id_usuario INT
)
BEGIN
	SET @max = (SELECT MIN(hora_inicio) FROM asistencia WHERE _id_usuario = fid_usuario);
	UPDATE asistencia  SET  hora_fin = (now()- INTERVAL 5 HOUR)
    WHERE fid_usuario = _id_usuario AND hora_inicio = @max;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure INSERTAR_CATEGORIA
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE  PROCEDURE `INSERTAR_CATEGORIA`(
	OUT _id_categoria INT,
    IN _nombre VARCHAR(100),
	IN _descripcion VARCHAR(100)
)
BEGIN
	INSERT INTO categoria(nombre, descripcion, activo) VALUES(_nombre, _descripcion, 1);
    SET _id_categoria = @@last_insert_id;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure INSERTAR_EMPRESA
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE  PROCEDURE `INSERTAR_EMPRESA`(out _id_persona int , in _razon_social varchar(100) , in _ruc varchar(30), in _nombre VARCHAR(100), in _fid_tipo char )
begin
	insert into persona(nombre, fid_tipo,razon_social,RUC , activo ) values (_nombre,_fid_tipo , _razon_social , _ruc , 1) ;
	set _id_persona = @@last_insert_id ;
end$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure INSERTAR_GASTO
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE  PROCEDURE `INSERTAR_GASTO`(
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
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure INSERTAR_LINEA_PEDIDO
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE  PROCEDURE `INSERTAR_LINEA_PEDIDO`(
	OUT _id_linea_pedido INT,
    IN _fid_itemVendible INT,
    IN _fid_pedido INT,
    IN _unidades INT,
    IN  _subtotal DECIMAL(10,2)
)
BEGIN
	INSERT INTO linea_pedido (fid_itemVendible, fid_pedido, unidades, subtotal,activo) 
    VALUES (_fid_itemVendible, _fid_pedido, _unidades, _subtotal,1);
    SET _id_linea_pedido = @@last_insert_id;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure INSERTAR_LINEA_PROMOCION
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE  PROCEDURE `INSERTAR_LINEA_PROMOCION`(
	OUT _idLineaPromocion INT,
	IN _unidades INT, 
    IN _fid_promocion INT ,
	IN _fid_producto INT 
    
)
BEGIN
	INSERT INTO linea_promocion
    ( unidad, fid_promocion, fid_producto, estado) VALUES ( _unidades, _fid_promocion, _fid_producto, True);
	SET _idLineaPromocion= @@last_insert_id;
    
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure INSERTAR_MESA
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE  PROCEDURE `INSERTAR_MESA`(out _id_mesa int , in _capacidad int, in _numMesa int )
BEGIN
    insert into mesa( capacidad, numMesa,activo,disponible) values (_capacidad, _numMesa,1,1);
    set _id_mesa = @@last_insert_id ;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure INSERTAR_PEDIDO
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE  PROCEDURE `INSERTAR_PEDIDO`(
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
    VALUES (_fid_restaurante, _total, (current_timestamp()- INTERVAL 5 HOUR), 1,'P');
    SET _id_transaccion = @@last_insert_id;
    
    INSERT INTO pedido (id_pedido, fid_mesa, fid_tipo_pago, fid_mesero, fid_cajero, fid_tipo_pedido, fid_cliente,
    fid_tipo_comprobante, numero_comprobante, fid_estado_pedido,pagado)
    VALUES(_id_transaccion, _fid_mesa, _fid_tipo_pago, _fid_mesero, _fid_cajero, _fid_tipo_pedido, _fid_cliente,
    _fid_tipo_comprobante, _id_transaccion*12345, 'E',0); 
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure INSERTAR_PEDIDO_CAJERO_CLIENTE
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE  PROCEDURE `INSERTAR_PEDIDO_CAJERO_CLIENTE`(
	OUT _id_transaccion INT, 
    IN _fid_restaurante INT, 
	IN  _total DECIMAL(10,2), 
	IN _fecha DATETIME, 
	
	IN _fid_cajero INT,
    IN _fid_cliente INT
)
BEGIN
	INSERT INTO transaccion (fid_restaurante, total, fecha, activo,tipo) 
    VALUES (_fid_restaurante, _total, (now()- INTERVAL 5 HOUR), 1,'P');
    SET _id_transaccion = @@last_insert_id;
    
    INSERT INTO pedido (id_pedido, fid_mesa, fid_cajero,fid_mesero, fid_tipo_pedido, fid_cliente,
     numero_comprobante, fid_estado_pedido,pagado)
    VALUES(_id_transaccion, 3, _fid_cajero, NULL, 'L', _fid_cliente,
     _id_transaccion*12345, 'E',0); 
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure INSERTAR_PEDIDO_MESERO_CLIENTE
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE  PROCEDURE `INSERTAR_PEDIDO_MESERO_CLIENTE`(
	OUT _id_transaccion INT, 
    IN _fid_restaurante INT, 
	IN  _total DECIMAL(10,2), 
	IN _fecha DATETIME, 
	
	IN _fid_mesa INT, 
	IN _fid_mesero INT,
    IN _fid_cliente INT
)
BEGIN
	INSERT INTO transaccion (fid_restaurante, total, fecha, activo,tipo) 
    VALUES (_fid_restaurante, _total, (now()- INTERVAL 5 HOUR), 1,'P');
    SET _id_transaccion = @@last_insert_id;
    
    INSERT INTO pedido (id_pedido, fid_mesa, fid_mesero,fid_cajero, fid_tipo_pedido, fid_cliente,
     numero_comprobante, fid_estado_pedido,pagado)
    VALUES(_id_transaccion, _fid_mesa, _fid_mesero, NULL, 'C', _fid_cliente,
     _id_transaccion*12345, 'E',0); 
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure INSERTAR_PEDIDO_SOLO_CAJERO
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE PROCEDURE `INSERTAR_PEDIDO_SOLO_CAJERO`(
	OUT _id_transaccion INT, 
    IN _fid_restaurante INT, 
	IN  _total DECIMAL(10,2), 
	IN _fecha DATETIME, 
	
	IN _fid_cajero INT
)
BEGIN
	INSERT INTO transaccion (fid_restaurante, total, fecha, activo,tipo) 
    VALUES (_fid_restaurante, _total, (now()- INTERVAL 5 HOUR), 1,'P');
    SET _id_transaccion = @@last_insert_id;
    
    INSERT INTO pedido (id_pedido, fid_mesa, fid_cajero, fid_mesero,fid_tipo_pedido, fid_cliente,
     numero_comprobante, fid_estado_pedido,pagado)
    VALUES(_id_transaccion, 3, _fid_cajero, NULL, 'L', NULL,
     _id_transaccion*12345, 'E',0); 
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure INSERTAR_PEDIDO_SOLO_MESERO
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE  PROCEDURE `INSERTAR_PEDIDO_SOLO_MESERO`(
	OUT _id_transaccion INT, 
    IN _fid_restaurante INT, 
	IN  _total DECIMAL(10,2), 
	IN _fecha DATETIME, 
	
	IN _fid_mesa INT, 
	IN _fid_mesero INT
)
BEGIN
	INSERT INTO transaccion (fid_restaurante, total, fecha, activo,tipo) 
    VALUES (_fid_restaurante, _total, (now()- INTERVAL 5 HOUR), 1,'P');
    SET _id_transaccion = @@last_insert_id;
    
    INSERT INTO pedido (id_pedido, fid_mesa, fid_mesero, fid_cajero, fid_tipo_pedido, fid_cliente,
     numero_comprobante, fid_estado_pedido,pagado)
    VALUES(_id_transaccion, _fid_mesa, _fid_mesero, NULL, 'C', NULL,
     _id_transaccion*12345, 'E',0); 
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure INSERTAR_PERSONA
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE  PROCEDURE `INSERTAR_PERSONA`(out _id_persona int ,in _fid_tipo char, in _nombre varchar(50) , in _apellido_paterno varchar(50) , in _apellido_materno varchar(20),
									in _DNI varchar(50) )
BEGIN
	insert into persona(fid_tipo,nombre,apellido_paterno,apellido_materno,DNI,activo )
					values (_fid_tipo,_nombre,_apellido_paterno,_apellido_materno,_DNI,1) ; 
    set _id_persona = @@last_insert_id ;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure INSERTAR_PRODUCTO
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE  PROCEDURE `INSERTAR_PRODUCTO`(
	OUT _id_item_vendible INT,
	IN _nombre VARCHAR(100),
    IN  _precio DECIMAL(10,2),
    IN _descripcion VARCHAR(100), 
    IN _estado TINYINT, 
    IN _fid_tipo_producto CHAR(1), 
    IN  _presentacion VARCHAR(50),
    IN _fid_categoria INT,
    IN _imagen LONGBLOB
)
BEGIN
	INSERT INTO item_vendible
    (nombre,precio,descripcion,estado,imagen) VALUES(_nombre,_precio,_descripcion,_estado,_imagen);
    SET _id_item_vendible = @@last_insert_id;
    INSERT INTO producto(id_producto,fid_tipo_producto,presentacion,fid_categoria) VALUES(_id_item_vendible,_fid_tipo_producto,_presentacion,_fid_categoria);
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure INSERTAR_PROMOCION
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE  PROCEDURE `INSERTAR_PROMOCION`(
OUT _id_item_vendible INT ,
IN _nombre VARCHAR(50) ,
IN _precio DECIMAL(10,2) ,
IN _descripcion VARCHAR(50) ,
IN _estado VARCHAR(50)
)
BEGIN
	INSERT INTO item_vendible(
     nombre, precio, descripcion, estado)
    VALUES (_nombre, _precio, _descripcion, _estado);
    SET _id_item_vendible = @@last_insert_id;
	INSERT INTO promocion (id_promocion)values (_id_item_vendible);
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure INSERTAR_RESTAURANTE
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE  PROCEDURE `INSERTAR_RESTAURANTE`(out _id_rest int , in _ruc varchar(20) , in _nombre varchar(50) , in _telefono varchar(20),
									in _direccion varchar(50) , in _dineroActual decimal(10,2))
BEGIN
	insert into restaurante(ruc,nombre,telefono,direccion,dineroActual,activo) 
					values (_ruc,_nombre,_telefono , _direccion , _dineroActual,1) ; 
    set _id_rest = @@last_insert_id ;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure INSERTAR_ROL
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE PROCEDURE `INSERTAR_ROL`(out _id_rol int , in _descripcion varchar(50) )
BEGIN
	insert into rol(descripcion,activo) values (_descripcion,1) ; 
    set _id_rol = @@last_insert_id ;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure INSERTAR_USUARIO
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE PROCEDURE `INSERTAR_USUARIO`(in _id_usuario int , in _fid_rol varchar(50) , in _fid_restaurante varchar(50) ,in _usuario varchar(50),
									in _password varchar(50) , in _salario decimal(10,2) , in _telefono varchar(50) , in _correo varchar(100) , in _imagen longblob)
BEGIN
	insert into usuario(id_usuario, fid_rol,fid_restaurante,usuario,password,salario,telefono,correo,imagen) 
					values (_id_usuario, _fid_rol,_fid_restaurante,_usuario,_password,_salario,_telefono,_correo,_imagen) ; 
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure LISTAR_ASISTENCIA_TODOS
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE  PROCEDURE `LISTAR_ASISTENCIA_TODOS`()
BEGIN
	SELECT a.id_asistencia, a.hora_inicio, a.hora_fin, a.fecha, u.id_usuario,p.nombre, p.DNI
		FROM asistencia a INNER JOIN usuario u ON a.fid_usuario = u.id_usuario
        INNER JOIN persona p ON u.id_usuario = p.id_persona
        WHERE a.activo = 1 ;        
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure LISTAR_CATEGORIAS_TODAS
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE  PROCEDURE `LISTAR_CATEGORIAS_TODAS`()
BEGIN
	SELECT id_categoria, nombre, descripcion FROM categoria WHERE activo = 1;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure LISTAR_CLIENTES_X_NOMBRE
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE PROCEDURE `LISTAR_CLIENTES_X_NOMBRE`(in _nombre varchar(50))
BEGIN 
	SELECT p.id_persona , p.nombre, p.apellido_paterno, p.apellido_materno , p.DNI, p.razon_social, p.RUC, t.descripcion, p.fid_tipo, p.activo
    from persona p INNER JOIN tipo_persona t 
    ON p.fid_tipo = t.id_tipo_persona 
    WHERE p.activo = 1 AND p.nombre LIKE CONCAT('%',_nombre,'%');
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure LISTAR_EMPRESAS
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE  PROCEDURE `LISTAR_EMPRESAS`()
BEGIN 
	SELECT p.id_persona , p.nombre, p.razon_social, p.RUC, p.fid_tipo, t.descripcion 
    from persona p INNER JOIN tipo_persona t 
    ON p.fid_tipo = t.id_tipo_persona 
    WHERE p.activo = 1 AND
	p.fid_tipo = 'J';
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure LISTAR_GASTOS_TODOS
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE  PROCEDURE `LISTAR_GASTOS_TODOS`()
BEGIN
	SELECT t.id_transaccion, t.fecha, t.total,t.activo , g.item, g.cantidad, g.precio, g.descripcion, r.id_restaurante,r.nombre,r.dineroActual
		FROM transaccion t INNER JOIN gasto g ON t.id_transaccion = g.id_gasto 
        INNER JOIN restaurante r ON r.id_restaurante = t.fid_restaurante 
        WHERE t.activo = 1;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure LISTAR_GASTOS_X_NOMBRE
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE PROCEDURE `LISTAR_GASTOS_X_NOMBRE`(in _nombre varchar(50))
BEGIN
	SELECT t.id_transaccion, t.fecha, t.total,t.activo , g.item, g.cantidad, g.precio, g.descripcion, r.id_restaurante,r.nombre,r.dineroActual
		FROM transaccion t INNER JOIN gasto g ON t.id_transaccion = g.id_gasto 
        INNER JOIN restaurante r ON r.id_restaurante = t.fid_restaurante 
        WHERE t.activo = 1 AND g.item LIKE CONCAT('%',_nombre,'%');
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure LISTAR_ITEMVENDIBLE_X_NOMBRE
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE PROCEDURE `LISTAR_ITEMVENDIBLE_X_NOMBRE`(IN _nombre VARCHAR(100))
BEGIN
	SELECT id_item_vendible, nombre, precio, descripcion FROM item_vendible 
    WHERE estado = 1 AND 
    nombre LIKE CONCAT('%',_nombre,'%');
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure LISTAR_LINEA_PEDIDO
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE  PROCEDURE `LISTAR_LINEA_PEDIDO`()
BEGIN
	SELECT l.id_linea_pedido, i.id_item_vendible, i.nombre, i.precio, i.descripcion, 
    l.fid_pedido, l.unidades, l.subtotal
    FROM linea_pedido l INNER JOIN item_vendible i ON l.fid_itemVendible = i.id_item_vendible
    WHERE l.activo = 1;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure LISTAR_LINEA_PEDIDO_MESA
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE PROCEDURE `LISTAR_LINEA_PEDIDO_MESA`(in _fid_pedido int)
BEGIN
	SELECT l.id_linea_pedido, i.id_item_vendible, i.nombre, i.precio, i.descripcion, 
    l.fid_pedido, l.unidades, l.subtotal
    FROM linea_pedido l INNER JOIN item_vendible i ON l.fid_itemVendible = i.id_item_vendible
    WHERE l.fid_pedido = _fid_pedido AND l.activo = 1;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure LISTAR_LINEA_PROMOCION_PROMO
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE  PROCEDURE `LISTAR_LINEA_PROMOCION_PROMO`(
	in _idPromo INT -- es el id de la proomocion que es el id itemvendible en la lista IV 
)
BEGIN
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
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure LISTAR_MESA_TODOS
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE  PROCEDURE `LISTAR_MESA_TODOS`()
BEGIN
    SELECT id_mesa, capacidad, numMesa, disponible FROM mesa WHERE activo = 1;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure LISTAR_PEDIDOS_PENDIENTES
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE  PROCEDURE `LISTAR_PEDIDOS_PENDIENTES`()
BEGIN
	SELECT 	t.id_transaccion, t.fid_restaurante, t.total, t.fecha, 
			m.id_mesa , m.activo, m.capacidad,
            p.fid_tipo_pago, p.fid_mesero, p.fid_cajero, p.fid_cliente,
			p.fid_tipo_pedido, p.fid_tipo_comprobante, p.numero_comprobante, p.fid_estado_pedido, m.numMesa
    FROM transaccion t INNER JOIN pedido p ON p.id_pedido = t.id_transaccion
    INNER JOIN mesa m ON m.id_mesa = p.fid_mesa
    WHERE t.activo = 1 and fid_estado_pedido = 'E' or fid_estado_pedido = 'P' ;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure LISTAR_PEDIDOS_SIN_PAGAR
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE  PROCEDURE `LISTAR_PEDIDOS_SIN_PAGAR`()
BEGIN
	SELECT 	t.id_transaccion, t.fid_restaurante, t.total, t.fecha, 
			m.id_mesa , m.activo, m.capacidad,m.numMesa,
            p.fid_tipo_pago, p.fid_mesero, p.fid_cajero, p.fid_cliente,
			p.fid_tipo_pedido, p.fid_tipo_comprobante, p.numero_comprobante, p.fid_estado_pedido
    FROM transaccion t INNER JOIN pedido p ON p.id_pedido = t.id_transaccion
    INNER JOIN mesa m ON m.id_mesa = p.fid_mesa
    WHERE t.activo = 1 and fid_estado_pedido = 'L' AND pagado = 0 ;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure LISTAR_PEDIDOS_TODOS
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE PROCEDURE `LISTAR_PEDIDOS_TODOS`()
BEGIN
	SELECT 	t.id_transaccion, t.fid_restaurante, t.total, t.fecha, 
			m.id_mesa , m.activo, m.capacidad,
            p.fid_tipo_pago,
			p.fid_tipo_pedido, p.fid_tipo_comprobante, p.numero_comprobante, p.fid_estado_pedido
    FROM transaccion t INNER JOIN pedido p ON p.id_pedido = t.id_transaccion
    INNER JOIN mesa m ON m.id_mesa = p.fid_mesa
    WHERE t.activo = 1 AND p.pagado=1;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure LISTAR_PERSONAS
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE  PROCEDURE `LISTAR_PERSONAS`()
BEGIN 
	SELECT p.id_persona , p.nombre, p.apellido_paterno, p.apellido_materno , p.DNI, p.fid_tipo, t.descripcion 
    from persona p INNER JOIN tipo_persona t 
    ON p.fid_tipo = t.id_tipo_persona 
    WHERE p.activo = 1 AND
	p.fid_tipo = 'N';
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure LISTAR_PERSONAS_TODAS
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE  PROCEDURE `LISTAR_PERSONAS_TODAS`()
BEGIN 
	SELECT p.id_persona , p.nombre, p.apellido_paterno, p.apellido_materno , p.DNI, p.razon_social, p.RUC,t.id_tipo_persona, t.descripcion 
    from persona p INNER JOIN tipo_persona t 
    ON p.fid_tipo = t.id_tipo_persona 
    WHERE p.activo = 1;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure LISTAR_PRODUCTOS_TODOS
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE  PROCEDURE `LISTAR_PRODUCTOS_TODOS`()
BEGIN
	SELECT i.id_item_vendible, i.nombre, i.precio, i.descripcion, i.estado, i.imagen, p.fid_tipo_producto, p.presentacion, c.id_categoria, c.nombre as nombre_cat, c.descripcion as detalle 
    FROM item_vendible i INNER JOIN producto p ON p.id_producto = i.id_item_vendible 
    INNER JOIN categoria c ON p.fid_categoria = c.id_categoria 
    WHERE i.estado = 1;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure LISTAR_PRODUCTOS_X_CATEGORIA
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE PROCEDURE `LISTAR_PRODUCTOS_X_CATEGORIA`(IN _nombre VARCHAR(100))
BEGIN
	SELECT i.id_item_vendible, i.nombre, i.precio, i.descripcion, i.estado, p.fid_tipo_producto, p.presentacion, 
    c.id_categoria, c.nombre as nombre_cat, c.descripcion as detalle  
    FROM producto p
    INNER JOIN item_vendible i ON p.id_producto = i.id_item_vendible
    INNER JOIN categoria c ON c.id_categoria = p.fid_categoria
    WHERE i.estado = 1 AND 
    c.nombre LIKE CONCAT('%',_nombre,'%');
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure LISTAR_PRODUCTOS_X_NOMBRE
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE PROCEDURE `LISTAR_PRODUCTOS_X_NOMBRE`(IN _nombre VARCHAR(100))
BEGIN
	SELECT i.id_item_vendible, i.nombre, i.precio, i.descripcion, i.estado, i.imagen, p.fid_tipo_producto, p.presentacion, c.id_categoria, c.nombre as nombre_cat, c.descripcion as detalle  
    FROM producto p
    INNER JOIN item_vendible i ON p.id_producto = i.id_item_vendible
    INNER JOIN categoria c ON c.id_categoria = p.fid_categoria
    WHERE estado = 1 AND 
    i.nombre LIKE CONCAT('%',_nombre,'%');
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure LISTAR_PROMOCIONES_TODOS
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE PROCEDURE `LISTAR_PROMOCIONES_TODOS`(
)
BEGIN	
	SELECT iv.id_item_vendible, iv.nombre, iv.precio , iv.descripcion, iv.estado from promocion p 
    INNER JOIN item_vendible iv ON p.id_promocion= iv.id_item_vendible;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure LISTAR_PROMOCIONES_X_NOMBRE
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE  PROCEDURE `LISTAR_PROMOCIONES_X_NOMBRE`(
	IN _nom varchar(200) 
)
BEGIN	
	SELECT iv.id_item_vendible, iv.nombre, iv.precio , iv.descripcion, iv.estado from promocion p 
    INNER JOIN item_vendible iv ON p.id_promocion= iv.id_item_vendible 
    WHERE iv.estado= 1 and iv.nombre like CONCAT('%',_nom,'%');
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure LISTAR_RESTAURANTE_TODAS
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE  PROCEDURE `LISTAR_RESTAURANTE_TODAS`()
BEGIN
	select * from restaurante 
    where activo = 1;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure LISTAR_ROL_TODAS
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE  PROCEDURE `LISTAR_ROL_TODAS`()
BEGIN
	select id_rol , descripcion from rol where activo = 1  ;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure LISTAR_TRANSACCIONES
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE PROCEDURE `LISTAR_TRANSACCIONES`()
BEGIN 
	select DISTINCT t.id_transaccion,t.total, t.fecha, t.tipo 
    from transaccion t inner join pedido p on p.pagado = 1 where t.activo = 1;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure LISTAR_TRANSACCIONES_X_FECHAS
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE PROCEDURE `LISTAR_TRANSACCIONES_X_FECHAS`(in fecha1 DATE, in fecha2 DATE)
BEGIN 
	select DISTINCT t.id_transaccion,t.total, t.fecha, t.tipo 
    from transaccion t inner join pedido p on p.pagado = 1 where t.activo = 1
    AND fecha BETWEEN fecha1 AND fecha2;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure LISTAR_USUARIOS_TODOS
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE PROCEDURE `LISTAR_USUARIOS_TODOS`()
BEGIN 
	select u.id_usuario , u.usuario , u.salario , u.telefono , p.nombre, p.apellido_paterno, p.apellido_materno, p.DNI
    from usuario u inner join persona p on u.id_usuario = p.id_persona
    where p.activo = 1;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure LISTAR_USUARIO_X_NOMBRE
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE PROCEDURE `LISTAR_USUARIO_X_NOMBRE`(IN _nombre VARCHAR(100))
BEGIN
	select u.id_usuario , u.usuario , u.salario , u.telefono , p.nombre, p.apellido_paterno, p.apellido_materno, p.DNI , r.descripcion as rol , r.id_rol as id_rol
    from usuario u 
    inner join persona p on u.id_usuario = p.id_persona
    inner join rol r on r.id_rol = u.fid_rol
    where p.activo = 1 AND  p.nombre LIKE CONCAT('%',_nombre,'%');
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure MODIFICAR_CATEGORIA
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE PROCEDURE `MODIFICAR_CATEGORIA`(
	IN _id_categoria INT,
    IN _nombre VARCHAR(100),
	IN _descripcion VARCHAR(100)
)
BEGIN
	UPDATE categoria SET nombre = _nombre, descripcion = _descripcion 
	WHERE id_categoria = _id_categoria;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure MODIFICAR_DATOS_USUARIO
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE PROCEDURE `MODIFICAR_DATOS_USUARIO`(in _id_usuario int , in _fid_rol int , in _salario decimal(10,2) , in _telefono varchar(30)  )
begin 
	update usuario set 	fid_rol = _fid_rol , salario = _salario , telefono = _telefono 
    where id_usuario = _id_usuario ; 
end$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure MODIFICAR_EMPRESA
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE PROCEDURE `MODIFICAR_EMPRESA`(in _id_persona int ,in _razon_social varchar(100) , in _ruc varchar(30), in _nombre VARCHAR(100))
begin
	update persona set nombre = _nombre , razon_social = _razon_social, ruc = _ruc
    where id_persona = _id_persona ; 
end$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure MODIFICAR_ESTADO_PEDIDO
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE  PROCEDURE `MODIFICAR_ESTADO_PEDIDO`(in _idPedido int , in _estado char)
begin
	update pedido set fid_estado_pedido = _estado 
    where id_pedido = _idPedido ;
end$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure MODIFICAR_GASTO
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE  PROCEDURE `MODIFICAR_GASTO`(
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
    UPDATE gasto SET item = _item, cantidad = _cantidad, descripcion = _descripcion, precio = _precio WHERE id_gasto = _id_transaccion;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure MODIFICAR_LINEA_PEDIDO
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE  PROCEDURE `MODIFICAR_LINEA_PEDIDO`(
	IN _id_linea_pedido INT,
    IN _fid_itemVendible INT,
    IN _fid_pedido INT,
    IN _unidades INT,
    IN  _subtotal DECIMAL(10,2),
    IN _activo tinyint(1)
)
BEGIN
	UPDATE linea_pedido SET fid_itemVendible = _fid_itemVendible, fid_pedido = _fid_pedido, 
    unidades = _unidades, subtotal = _subtotal, activo = _activo 
    WHERE id_linea_pedido = _id_linea_pedido;    
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure MODIFICAR_LINEA_PROMOCION
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE  PROCEDURE `MODIFICAR_LINEA_PROMOCION`(
	IN _id_linea_promocion INT,
    in _unidad INT, 
    in _fid_promocion INT, 
	in _fid_producto INT,
	in _estado boolean
)
BEGIN
	UPDATE linea_promocion SET unidad= _unidad, fid_promocion= _fid_promocion , fid_producto = _fid_producto , estado = _estado 
    WHERE id_linea_promocion = _id_linea_promocion ;
    
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure MODIFICAR_MESA
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE  PROCEDURE `MODIFICAR_MESA`(
    IN _id_mesa INT,
    IN _capacidad INT,
    IN _numMesa INT,
    IN _activo INT,
    IN _disponible INT
)
BEGIN
    UPDATE mesa SET capacidad = _capacidad , numMesa = _numMesa, activo = _activo, disponible = _disponible
    WHERE id_mesa = _id_mesa;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure MODIFICAR_PEDIDO
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE  PROCEDURE `MODIFICAR_PEDIDO`(
	IN _id_pedido INT,  IN  _total DECIMAL(10,2))
BEGIN
	UPDATE transaccion 
    SET  total = _total
    WHERE id_transaccion = _id_pedido;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure MODIFICAR_PERSONA
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE PROCEDURE `MODIFICAR_PERSONA`(in _id_persona int ,in _nombre varchar(50),in _apellido_paterno varchar(50),in _apellido_materno varchar(50), in _DNI varchar(10), in _RUC varchar(50), in _razon_social varchar(50))
begin
	update persona set nombre = _nombre , apellido_paterno = _apellido_paterno, apellido_materno = _apellido_materno , DNI = _DNI, RUC = _RUC, razon_social = _razon_social
    where id_persona = _id_persona ; 
end$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure MODIFICAR_PRODUCTO
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE  PROCEDURE `MODIFICAR_PRODUCTO`(
	IN _id_item_vendible INT,
	IN _nombre VARCHAR(100),
    IN  _precio DECIMAL(10,2),
    IN _descripcion VARCHAR(100), 
    IN _estado TINYINT, 
    IN _fid_tipo_producto CHAR(1), 
    IN  _presentacion VARCHAR(50),
    IN _fid_categoria INT,
    IN _imagen LONGBLOB
)
BEGIN
	UPDATE item_vendible SET nombre = _nombre, precio = _precio, descripcion = _descripcion, estado = _estado, imagen = _imagen  WHERE id_item_vendible = _id_item_vendible;
    UPDATE producto SET fid_tipo_producto = _fid_tipo_producto, presentacion = _presentacion, fid_categoria = _fid_categoria WHERE id_producto = _id_item_vendible;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure MODIFICAR_PROMOCION
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE PROCEDURE `MODIFICAR_PROMOCION`(
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
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure MODIFICAR_RESTAURANTE
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE PROCEDURE `MODIFICAR_RESTAURANTE`(in _id_restaurante int ,in _ruc varchar(50),
									in _nombre varchar(50), in _telefono varchar(50),in _direccion varchar(50),in _dineroActual DECIMAL(10,2),in _activo INT)
begin
	update restaurante set ruc = _ruc ,nombre = _nombre ,telefono = _telefono ,direccion = _direccion, dineroActual = _dineroActual, activo =_activo
    where id_restaurante  =  _id_restaurante ;
end$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure MODIFICAR_ROL
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE PROCEDURE `MODIFICAR_ROL`(IN _idRol int  , IN _descripcion varchar(50))
BEGIN
	update rol set descripcion = _descripcion where rol.id_rol = _idRol ;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure MODIFICAR_USUARIO
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE PROCEDURE `MODIFICAR_USUARIO`(in _id_usuario int , in _usuario varchar(50) , in _password varchar(50) )
BEGIN
	update usuario set usuario = _usuario , password = _password where id_usuario = _id_usuario ; 
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure REALIZAR_PAGO
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE PROCEDURE `REALIZAR_PAGO`(
	IN _id_pedido INT, IN _fid_tipo_pago CHAR(1), IN _fid_cajero INT,
     IN _fid_cliente INT, IN _fid_tipo_comprobante CHAR(1)
)
BEGIN
    UPDATE pedido 
    SET fid_tipo_pago = _fid_tipo_pago, fid_cajero = _fid_cajero,
		 fid_cliente = _fid_cliente, fid_tipo_comprobante = _fid_tipo_comprobante,pagado = 1
    WHERE id_pedido= _id_pedido;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure VERIFICAR_CUENTA_USUARIO
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE PROCEDURE `VERIFICAR_CUENTA_USUARIO`(in _username varchar(100) , in _password varchar(100))
begin
	select * from usuario where usuario = _username and password = _password ;
end$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure VERIFICAR_USUARIO
-- -----------------------------------------------------

DELIMITER $$
USE `Restaurante`$$
CREATE PROCEDURE `VERIFICAR_USUARIO`(in _DNI int , in _apellido_paterno varchar(45))
BEGIN
	select id_usuario
    from usuario u inner join persona p on p.id_persona = u.id_usuario
    where p.DNI = _DNI and
    p.apellido_paterno = _apellido_paterno and
    p.activo = 1; 
END$$


DELIMITER ;

# DATOS INICIALES
INSERT INTO `Restaurante`.`tipo_persona` (`id_tipo_persona`, `descripcion`) VALUES ('N', 'NATURAL');
INSERT INTO `Restaurante`.`tipo_persona` (`id_tipo_persona`, `descripcion`) VALUES ('J', 'JURIDICA');

INSERT INTO `Restaurante`.`tipo_producto` (`id_tipo_producto`, `descripcion`) VALUES ('C', 'COMIDAS');
INSERT INTO `Restaurante`.`tipo_producto` (`id_tipo_producto`, `descripcion`) VALUES ('B', 'BEBIDAS');

INSERT INTO Restaurante.tipo_pago(id_tipo_pago, descripcion) values('E', 'En efectivo');
INSERT INTO Restaurante.tipo_pago(id_tipo_pago, descripcion) values('T', 'Tarjeta');

INSERT INTO Restaurante.tipo_comprobante(id_tipo_comprobante, descripcion) values('B', 'Boleta');
INSERT INTO Restaurante.tipo_comprobante(id_tipo_comprobante, descripcion) values('F', 'Factura');

INSERT INTO Restaurante.tipo_pedido(id_tipo_pedido, descripcion) values('L', 'Para llevar');
INSERT INTO Restaurante.tipo_pedido(id_tipo_pedido, descripcion) values('C', 'Para comer');

INSERT INTO Restaurante.estado_pedido(id_estado_pedido, descripcion) values('E', 'En espera');
INSERT INTO Restaurante.estado_pedido(id_estado_pedido, descripcion) values('P', 'En proceso');
INSERT INTO Restaurante.estado_pedido(id_estado_pedido, descripcion) values('L', 'Listo');

