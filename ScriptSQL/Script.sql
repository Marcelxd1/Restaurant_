DROP TABLE IF EXISTS asistencia ;
DROP TABLE IF EXISTS categoria ;
DROP TABLE IF EXISTS gasto ;
DROP TABLE IF EXISTS item_vendible ;
DROP TABLE IF EXISTS linea_pedido ;
DROP TABLE IF EXISTS linea_promocion ;
DROP TABLE IF EXISTS mesa ;
DROP TABLE IF EXISTS pedido ;
DROP TABLE IF EXISTS persona ;
DROP TABLE IF EXISTS producto ;
DROP TABLE IF EXISTS promocion ;
DROP TABLE IF EXISTS restaurante ;
DROP TABLE IF EXISTS rol ;
DROP TABLE IF EXISTS tipo_pago ;
DROP TABLE IF EXISTS trasaccion ;
DROP TABLE IF EXISTS usuario ;
-- -----------------------------------------------------
-- Table rol
-- -----------------------------------------------------
CREATE TABLE rol (
  id_rol INT NOT NULL AUTO_INCREMENT,
  descripcion VARCHAR(120) NULL DEFAULT NULL,
  PRIMARY KEY (id_rol))
ENGINE = InnoDB;

-- -----------------------------------------------------
-- Table restaurante
-- -----------------------------------------------------
CREATE TABLE restaurante (
  id_restaurante INT NOT NULL AUTO_INCREMENT,
  ruc VARCHAR(20) NULL DEFAULT NULL,
  nombre VARCHAR(120) NULL DEFAULT NULL,
  telefono VARCHAR(20) NULL DEFAULT NULL,
  direccion VARCHAR(120) NULL DEFAULT NULL,
  dineroActual DECIMAL(10,2) NULL DEFAULT NULL,
  PRIMARY KEY (id_restaurante))
ENGINE = InnoDB;



-- -----------------------------------------------------
-- Table persona
-- -----------------------------------------------------
CREATE TABLE persona (
  id_persona INT NOT NULL AUTO_INCREMENT,
  nombre VARCHAR(45) NULL,
  apellido_paterno VARCHAR(45) NULL,
  apellido_materno VARCHAR(45) NULL,
  DNI VARCHAR(45) NULL,
  tipo CHAR(1) NULL,
  razon_social VARCHAR(45) NULL,
  RUC VARCHAR(45) NULL,
  PRIMARY KEY (id_persona))
ENGINE = InnoDB;

-- -----------------------------------------------------
-- Table usuario
-- -----------------------------------------------------
CREATE TABLE usuario (
  id_usuario INT NOT NULL AUTO_INCREMENT,
  fid_rol INT NOT NULL,
  fid_restaurante INT NOT NULL,
  usuario VARCHAR(30) NULL DEFAULT NULL,
  password VARCHAR(45) NULL DEFAULT NULL,
  estado TINYINT NULL DEFAULT NULL,
  imagen LONGBLOB NULL DEFAULT NULL,
  salario DECIMAL(10,2) NULL DEFAULT NULL,
  telefono VARCHAR(20) NULL,
  PRIMARY KEY (id_usuario),
  INDEX fid_rol (fid_rol ASC) VISIBLE,
  INDEX fid_restaurante (fid_restaurante ASC) VISIBLE,
  CONSTRAINT usuario_ibfk_1
    FOREIGN KEY (fid_rol)
    REFERENCES rol (id_rol),
  CONSTRAINT usuario_ibfk_2
    FOREIGN KEY (fid_restaurante)
    REFERENCES restaurante (id_restaurante),
  CONSTRAINT usuario_ibfk_3
    FOREIGN KEY (id_usuario)
    REFERENCES persona (id_persona)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

-- -----------------------------------------------------
-- Table asistencia
-- -----------------------------------------------------
CREATE TABLE asistencia (
  id_asistencia INT NOT NULL AUTO_INCREMENT,
  fid_usuario INT NOT NULL,
  hora_inicio DATETIME NULL DEFAULT NULL,
  hora_fin DATETIME NULL DEFAULT NULL,
  fecha DATE NULL DEFAULT NULL,
  PRIMARY KEY (id_asistencia),
  INDEX fid_usuario (fid_usuario ASC) VISIBLE,
  CONSTRAINT asistencia_ibfk_1
    FOREIGN KEY (fid_usuario)
    REFERENCES usuario (id_usuario))
ENGINE = InnoDB;

-- -----------------------------------------------------
-- Table transaccion
-- -----------------------------------------------------
CREATE TABLE transaccion (
  id_transaccion INT NOT NULL AUTO_INCREMENT,
  fid_restaurante INT NOT NULL,
  total DECIMAL(10,2) NULL DEFAULT NULL,
  fecha DATETIME NULL DEFAULT NULL,
  tipo CHAR(1) NULL DEFAULT NULL,
  PRIMARY KEY (id_transaccion),
  INDEX fid_restaurante (fid_restaurante ASC) VISIBLE,
  CONSTRAINT transaccion_ibfk_1
    FOREIGN KEY (fid_restaurante)
    REFERENCES restaurante (id_restaurante))
ENGINE = InnoDB;

-- -----------------------------------------------------
-- Table gasto
-- -----------------------------------------------------
CREATE TABLE gasto (
  id_gasto INT NOT NULL AUTO_INCREMENT,
  fid_transaccion INT NOT NULL,
  item VARCHAR(50) NULL DEFAULT NULL,
  sub_total DECIMAL(10,2) NULL DEFAULT NULL,
  PRIMARY KEY (id_gasto),
  INDEX fid_transaccion (fid_transaccion ASC) VISIBLE,
  CONSTRAINT detalle_ibfk_1
    FOREIGN KEY (fid_transaccion)
    REFERENCES transaccion (id_transaccion))
ENGINE = InnoDB;

-- -----------------------------------------------------
-- Table item_vendible
-- -----------------------------------------------------
CREATE TABLE item_vendible (
  id_item_vendible INT NOT NULL AUTO_INCREMENT,
  nombre VARCHAR(100) NULL DEFAULT NULL,
  precio DOUBLE NULL DEFAULT NULL,
  descripcion VARCHAR(100) NULL DEFAULT NULL,
  estado TINYINT NULL DEFAULT NULL,
  PRIMARY KEY (id_item_vendible))
ENGINE = InnoDB;

-- -----------------------------------------------------
-- Table mesa
-- -----------------------------------------------------
CREATE TABLE mesa (
  id_mesa INT NOT NULL AUTO_INCREMENT,
  capacidad INT NULL DEFAULT NULL,
  activo TINYINT NULL DEFAULT NULL,
  PRIMARY KEY (id_mesa))
ENGINE = InnoDB;

-- -----------------------------------------------------
-- Table tipo_pago
-- -----------------------------------------------------
CREATE TABLE tipo_pago (
  id_tipo_pago INT NOT NULL AUTO_INCREMENT,
  descripcion VARCHAR(20) NULL DEFAULT NULL,
  PRIMARY KEY (id_tipo_pago))
ENGINE = InnoDB;

-- -----------------------------------------------------
-- Table pedido
-- -----------------------------------------------------
CREATE TABLE pedido (
  id_pedido INT NOT NULL AUTO_INCREMENT,
  fid_mesa INT NOT NULL,
  fid_tipo_pago INT NOT NULL,
  fid_mesero INT NOT NULL,
  fid_cajero INT NOT NULL,
  tipo CHAR(1) NULL DEFAULT NULL,
  fid_cliente INT NOT NULL,
  tipo_comprobante CHAR(1) NULL,
  numero_comprobante INT NULL,
  PRIMARY KEY (id_pedido),
  INDEX fid_mesa (fid_mesa ASC) VISIBLE,
  INDEX fid_mesero (fid_mesero ASC) VISIBLE,
  INDEX fid_cajero (fid_cajero ASC) VISIBLE,
  INDEX fid_tipo_pago (fid_tipo_pago ASC) VISIBLE,
  INDEX pedido_ibfk_7_idx (fid_cliente ASC) VISIBLE,
  CONSTRAINT pedido_ibfk_1
    FOREIGN KEY (fid_mesa)
    REFERENCES mesa (id_mesa),
  CONSTRAINT pedido_ibfk_3
    FOREIGN KEY (fid_mesero)
    REFERENCES usuario (id_usuario),
  CONSTRAINT pedido_ibfk_4
    FOREIGN KEY (fid_cajero)
    REFERENCES usuario (id_usuario),
  CONSTRAINT pedido_ibfk_5
    FOREIGN KEY (fid_tipo_pago)
    REFERENCES tipo_pago (id_tipo_pago),
  CONSTRAINT pedido_ibfk_6
    FOREIGN KEY (id_pedido)
    REFERENCES transaccion (id_transaccion)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT pedido_ibfk_7
    FOREIGN KEY (fid_cliente)
    REFERENCES persona (id_persona)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

-- -----------------------------------------------------
-- Table linea_pedido
-- -----------------------------------------------------
CREATE TABLE linea_pedido (
  id_linea_pedido INT NOT NULL AUTO_INCREMENT,
  unidades INT NOT NULL ,
  subtotal DOUBLE NULL DEFAULT NULL,
  fid_itemVendible INT NOT NULL,
  fid_pedido INT NOT NULL,
  PRIMARY KEY (id_linea_pedido),
  INDEX fk_Linea_Pedido_ItemVendible_idx (fid_itemVendible ASC) VISIBLE,
  INDEX fk_Linea_Pedido_pedido1_idx (fid_pedido ASC) VISIBLE,
  CONSTRAINT fk_Linea_Pedido_ItemVendible
    FOREIGN KEY (fid_itemVendible)
    REFERENCES item_vendible (id_item_vendible),
  CONSTRAINT fk_Linea_Pedido_pedido1
    FOREIGN KEY (fid_pedido)
    REFERENCES pedido (id_pedido))
ENGINE = InnoDB;

-- -----------------------------------------------------
-- Table promocion
-- -----------------------------------------------------
CREATE TABLE promocion (
  id_promocion INT NOT NULL,
  INDEX fk_PromocionCombo_ItemVendible1_idx (id_promocion ASC) VISIBLE,
  PRIMARY KEY (id_promocion),
  CONSTRAINT fk_PromocionCombo_ItemVendible1
    FOREIGN KEY (id_promocion)
    REFERENCES item_vendible (id_item_vendible))
ENGINE = InnoDB;

-- -----------------------------------------------------
-- Table categoria
-- -----------------------------------------------------
CREATE TABLE categoria (
  id_categoria INT NOT NULL AUTO_INCREMENT,
  nombre VARCHAR(100) NULL DEFAULT NULL,
  descripcion VARCHAR(100) NULL DEFAULT NULL,
  activo TINYINT NULL DEFAULT NULL,
  PRIMARY KEY (id_categoria))
ENGINE = InnoDB;

-- -----------------------------------------------------
-- Table producto
-- -----------------------------------------------------
CREATE TABLE producto (
  id_producto INT NOT NULL AUTO_INCREMENT,
  tipo_producto CHAR(1) NULL,
  presentacion VARCHAR(45) NULL,
  fid_categoria INT NULL,
  PRIMARY KEY (id_producto),
  INDEX fk_Producto_tipo_comida_idx (fid_categoria ASC) VISIBLE,
  CONSTRAINT fk_Producto_tipo_comida
    FOREIGN KEY (fid_categoria)
    REFERENCES categoria (id_categoria)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT fk_Producto_Item_vendible
    FOREIGN KEY (id_producto)
    REFERENCES item_vendible (id_item_vendible)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

-- -----------------------------------------------------
-- Table linea_promocion
-- -----------------------------------------------------
CREATE TABLE linea_promocion (
  id_linea_promocion INT NOT NULL AUTO_INCREMENT,
  unidad INT NOT NULL ,
  fid_promocion INT NOT NULL,
  fid_producto INT NOT NULL,
  PRIMARY KEY (id_linea_promocion),
  INDEX fid_producto_linea_idx (fid_producto ASC) VISIBLE,
  CONSTRAINT fid_promocion_line
    FOREIGN KEY (fid_promocion)
    REFERENCES promocion (id_promocion)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT fid_producto_linea
    FOREIGN KEY (fid_producto)
    REFERENCES producto (id_producto)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;
