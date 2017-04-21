drop table ciudad CASCADE CONSTRAINTS;
drop table region CASCADE CONSTRAINTS;
drop table cliente CASCADE CONSTRAINTS;
drop table cobertura CASCADE CONSTRAINTS;
drop table liquidador CASCADE CONSTRAINTS;
drop table marca CASCADE CONSTRAINTS;
drop table modelo CASCADE CONSTRAINTS;
drop table seguro CASCADE CONSTRAINTS;
drop table siniestro CASCADE CONSTRAINTS;
drop table vehiculo CASCADE CONSTRAINTS;

CREATE TABLE CIUDAD
  (
    id_ciudad        NUMBER (3) NOT NULL ,
    nombre           VARCHAR2 (40) NOT NULL ,
    REGION_id_region NUMBER (2) NOT NULL
  ) ;
ALTER TABLE CIUDAD ADD CONSTRAINT CIUDAD_PK PRIMARY KEY ( id_ciudad ) ;


CREATE TABLE CLIENTE
  (
    id_cliente           VARCHAR2 (10) NOT NULL ,
    rut                  VARCHAR2 (10) NOT NULL ,
    pass                 VARCHAR2 (200) NOT NULL ,
    nombres              VARCHAR2 (50) NOT NULL ,
    apellidos            VARCHAR2 (50) NOT NULL ,
    correo               VARCHAR2 (50) NOT NULL ,
    fecha_nacimiento     DATE NOT NULL ,
    direccion            VARCHAR2 (100) NOT NULL ,
    VEHICULO_id_vehiculo VARCHAR2 (10) NOT NULL ,
    SEGURO_id_seguro     VARCHAR2 (10) NOT NULL ,
    id_ciudad            NUMBER (3) NOT NULL
  ) ;
CREATE UNIQUE INDEX CLIENTE__IDX ON CLIENTE
  (
    SEGURO_id_seguro ASC
  )
  ;
CREATE UNIQUE INDEX CLIENTE__IDXv1 ON CLIENTE
  (
    VEHICULO_id_vehiculo ASC
  )
  ;
ALTER TABLE CLIENTE ADD CONSTRAINT CLIENTE_PK PRIMARY KEY ( id_cliente ) ;


CREATE TABLE COBERTURA
  (
    id_cobertura  VARCHAR2 (10) NOT NULL ,
    perdida_total CHAR (1) NOT NULL ,
    dano_terceros CHAR (1) NOT NULL
  ) ;
ALTER TABLE COBERTURA ADD CONSTRAINT COBERTURA_PK PRIMARY KEY ( id_cobertura ) ;


CREATE TABLE LIQUIDADOR
  (
    id_liquidador    VARCHAR2 (10) NOT NULL ,
    rut              VARCHAR2 (10) NOT NULL ,
    pass             VARCHAR2 (200) NOT NULL ,
    nombres          VARCHAR2 (50) NOT NULL ,
    apellidos        VARCHAR2 (50) NOT NULL ,
    correo           VARCHAR2 (50) NOT NULL ,
    fecha_nacimiento DATE NOT NULL ,
    direccion        VARCHAR2 (100) NOT NULL ,
    id_ciudad        NUMBER (3) NOT NULL
  ) ;
ALTER TABLE LIQUIDADOR ADD CONSTRAINT LIQUIDADOR_PK PRIMARY KEY ( id_liquidador ) ;


CREATE TABLE MARCA
  (
    id_marca VARCHAR2 (10) NOT NULL ,
    nombre   VARCHAR2 (40) NOT NULL
  ) ;
ALTER TABLE MARCA ADD CONSTRAINT MARCA_PK PRIMARY KEY ( id_marca ) ;


CREATE TABLE MODELO
  (
    id_modelo      VARCHAR2 (10) NOT NULL ,
    nombre         VARCHAR2 (40) NOT NULL ,
    MARCA_id_marca VARCHAR2 (10) NOT NULL
  ) ;
ALTER TABLE MODELO ADD CONSTRAINT MODELO_PK PRIMARY KEY ( id_modelo ) ;


CREATE TABLE REGION
  (
    id_region NUMBER (2) NOT NULL ,
    nombre    VARCHAR2 (40) NOT NULL
  ) ;
ALTER TABLE REGION ADD CONSTRAINT REGION_PK PRIMARY KEY ( id_region ) ;


CREATE TABLE SEGURO
  (
    id_seguro              VARCHAR2 (10) NOT NULL ,
    valor                  NUMBER (7) NOT NULL ,
    activo                 CHAR (1) NOT NULL,  
    COBERTURA_id_cobertura VARCHAR2 (10) NOT NULL
  ) ;
CREATE UNIQUE INDEX SEGURO__IDX ON SEGURO
  (
    COBERTURA_id_cobertura ASC
  )
  ;
ALTER TABLE SEGURO ADD CONSTRAINT SEGURO_PK PRIMARY KEY ( id_seguro ) ;


CREATE TABLE SINIESTRO
  (
    id_siniestro             VARCHAR2 (10) NOT NULL ,
    fecha                    DATE NOT NULL ,
    fecha_termino            DATE ,
    estado                   VARCHAR2 (20) NOT NULL ,
    deducible_uf             NUMBER (2,2) NOT NULL ,
    coste_reparacion         NUMBER (10) ,
    CLIENTE_id_cliente       VARCHAR2 (10) NOT NULL ,
    LIQUIDADOR_id_liquidador VARCHAR2 (10) NOT NULL
  ) ;
ALTER TABLE SINIESTRO ADD CONSTRAINT SINIESTRO_PK PRIMARY KEY ( id_siniestro ) ;


CREATE TABLE VEHICULO
  (
    id_vehiculo        VARCHAR2 (10) NOT NULL ,
    patente            VARCHAR2 (10) NOT NULL ,
    ano                NUMBER (4) NOT NULL ,
    valor_fiscal       NUMBER (9) NOT NULL ,
    id_modelo          VARCHAR2 (10) NOT NULL
  ) ;
ALTER TABLE VEHICULO ADD CONSTRAINT VEHICULO_PK PRIMARY KEY ( id_vehiculo ) ;


ALTER TABLE CIUDAD ADD CONSTRAINT CIUDAD_REGION_FK FOREIGN KEY ( REGION_id_region ) REFERENCES REGION ( id_region ) ;

ALTER TABLE CLIENTE ADD CONSTRAINT CLIENTE_SEGURO_FK FOREIGN KEY ( SEGURO_id_seguro ) REFERENCES SEGURO ( id_seguro ) ;

ALTER TABLE CLIENTE ADD CONSTRAINT CLIENTE_VEHICULO_FK FOREIGN KEY ( VEHICULO_id_vehiculo ) REFERENCES VEHICULO ( id_vehiculo ) ;

ALTER TABLE MODELO ADD CONSTRAINT MODELO_MARCA_FK FOREIGN KEY ( MARCA_id_marca ) REFERENCES MARCA ( id_marca ) ;

ALTER TABLE SEGURO ADD CONSTRAINT SEGURO_COBERTURA_FK FOREIGN KEY ( COBERTURA_id_cobertura ) REFERENCES COBERTURA ( id_cobertura ) ;

ALTER TABLE SINIESTRO ADD CONSTRAINT SINIESTRO_CLIENTE_FK FOREIGN KEY ( CLIENTE_id_cliente ) REFERENCES CLIENTE ( id_cliente ) ;

ALTER TABLE SINIESTRO ADD CONSTRAINT SINIESTRO_LIQUIDADOR_FK FOREIGN KEY ( LIQUIDADOR_id_liquidador ) REFERENCES LIQUIDADOR ( id_liquidador ) ;
