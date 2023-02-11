USE master
GO
IF EXISTS(SELECT * FROM sys.databases WHERE name = 'Vias') DROP DATABASE [Vias]
GO
CREATE DATABASE [Vias];
GO
USE [Vias];
GO

IF NOT EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name LIKE 'Configuracion')
CREATE TABLE [dbo].[Configuracion] (
    [Codigo]                            VARCHAR(100)        NOT NULL,
    [Parametro]                         VARCHAR(100)            NULL DEFAULT NULL,
    [Valor]                             VARCHAR(100)            NULL DEFAULT NULL,
    PRIMARY KEY CLUSTERED ([Codigo])
);

IF NOT EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name LIKE 'Conductor')
CREATE TABLE [dbo].[Conductor] (
    [Cedula]                            INT                 NOT NULL IDENTITY,
    [Nombre]                            VARCHAR(100)            NULL DEFAULT NULL,
    [Estado]                            VARCHAR(100)            NULL DEFAULT NULL,
    PRIMARY KEY CLUSTERED ([Cedula])
);

IF NOT EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name LIKE 'Codigo_Identificacion_Vial')
CREATE TABLE [dbo].[Codigo_Identificacion_Vial] (
    [Civ]                               VARCHAR(50)         NOT NULL,
    [Nombre_Eje_Via]                    VARCHAR(100)            NULL DEFAULT NULL,
    [Nombre_Extremo_Inicial]            VARCHAR(100)            NULL DEFAULT NULL,
    [Nombre_Extremo_Final]              VARCHAR(100)            NULL DEFAULT NULL,
    [Tipo_Malla]                        VARCHAR(100)            NULL DEFAULT NULL,
    PRIMARY KEY CLUSTERED ([Civ])
);

IF NOT EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name LIKE 'Cliente')
CREATE TABLE [dbo].[Cliente] (
    [Nit]                               VARCHAR(50)         NOT NULL,
    [Nombre]                            VARCHAR(100)            NULL DEFAULT NULL,
    [Direccion]                         VARCHAR(100)            NULL DEFAULT NULL,
    [Telefono]                          VARCHAR(100)            NULL DEFAULT NULL,
    [Fax]                               VARCHAR(100)            NULL DEFAULT NULL,
    [Observaciones]                     VARCHAR(250)            NULL DEFAULT NULL,
    PRIMARY KEY CLUSTERED ([Nit])
);

IF NOT EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name LIKE 'Ayudante')
CREATE TABLE [dbo].[Ayudante] (
    [Cedula]                            INT                 NOT NULL IDENTITY,
    [Nombre]                            VARCHAR(100)            NULL DEFAULT NULL,
    [Estado]                            VARCHAR(100)            NULL DEFAULT NULL,
    PRIMARY KEY CLUSTERED ([Cedula])
);

IF NOT EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name LIKE 'Materia_Prima')
CREATE TABLE [dbo].[Materia_Prima] (
    [Codigo]                            VARCHAR(100)        NOT NULL,
    [Nombre]                            VARCHAR(100)            NULL DEFAULT NULL,
    [Detalles]                          VARCHAR(250)            NULL DEFAULT NULL,
    [Tipo]                              VARCHAR(100)            NULL DEFAULT NULL,
    PRIMARY KEY CLUSTERED ([Codigo])
);

IF NOT EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name LIKE 'Indicador')
CREATE TABLE [dbo].[Indicador] (
    [Codigo]                            VARCHAR(100)        NOT NULL,
    [Nombre]                            VARCHAR(100)            NULL DEFAULT NULL,
    [Tamano_Trama]                      VARCHAR(10)             NULL DEFAULT NULL,
    [Posicion_Inicial_Peso]             VARCHAR(10)             NULL DEFAULT NULL,
    [Total_Datos_Peso]                  VARCHAR(10)             NULL DEFAULT NULL,
    [Caracter_Fin_Trama]                VARCHAR(10)             NULL DEFAULT NULL,
    [Caracter_Inicio_Trama]             VARCHAR(10)             NULL DEFAULT NULL,
    PRIMARY KEY CLUSTERED ([Codigo])
);

IF NOT EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name LIKE 'Usuario')
CREATE TABLE [dbo].[Usuario] (
    [Cedula]                            INT                 NOT NULL IDENTITY,
    [Nombre]                            VARCHAR(100)            NULL DEFAULT NULL,
    [Apellido]                          VARCHAR(100)            NULL DEFAULT NULL,
    [Nick]                              VARCHAR(50)             NULL DEFAULT NULL,
    [Tipo]                              VARCHAR(50)             NULL DEFAULT NULL,
    [Password]                          VARCHAR(200)            NULL DEFAULT NULL,
    PRIMARY KEY CLUSTERED ([Cedula])
);

IF NOT EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name LIKE 'Transportadora')
CREATE TABLE [dbo].[Transportadora] (
    [Nombre]                            VARCHAR(100)        NOT NULL,
    [Nit]                               VARCHAR(50)             NULL DEFAULT NULL,
    [Direccion]                         VARCHAR(100)            NULL DEFAULT NULL,
    [Telefono]                          VARCHAR(50)             NULL DEFAULT NULL,
    [Fax]                               VARCHAR(100)            NULL DEFAULT NULL,
    [Observaciones]                     VARCHAR(250)            NULL DEFAULT NULL,
    PRIMARY KEY CLUSTERED ([Nombre])
);

IF NOT EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name LIKE 'Proveedor')
CREATE TABLE [dbo].[Proveedor] (
    [Nit]                               VARCHAR(50)         NOT NULL,
    [Nombre]                            VARCHAR(100)            NULL DEFAULT NULL,
    [Direccion]                         VARCHAR(100)            NULL DEFAULT NULL,
    [Telefono]                          VARCHAR(100)            NULL DEFAULT NULL,
    [Fax]                               VARCHAR(100)            NULL DEFAULT NULL,
    [Observaciones]                     VARCHAR(250)            NULL DEFAULT NULL,
    PRIMARY KEY CLUSTERED ([Nit])
);

IF NOT EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name LIKE 'Producto')
CREATE TABLE [dbo].[Producto] (
    [Codigo]                            VARCHAR(100)        NOT NULL,
    [Nombre]                            VARCHAR(100)            NULL DEFAULT NULL,
    [Detalles]                          VARCHAR(100)            NULL DEFAULT NULL,
    [Tipo]                              VARCHAR(100)            NULL DEFAULT NULL,
    PRIMARY KEY CLUSTERED ([Codigo])
);

IF NOT EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name LIKE 'Planta')
CREATE TABLE [dbo].[Planta] (
    [Codigo]                            VARCHAR(100)        NOT NULL,
    [Nombre]                            VARCHAR(100)            NULL DEFAULT NULL,
    [Detalles]                          VARCHAR(250)            NULL DEFAULT NULL,
    PRIMARY KEY CLUSTERED ([Codigo])
);

IF NOT EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name LIKE 'Origen')
CREATE TABLE [dbo].[Origen] (
    [Codigo]                            VARCHAR(100)        NOT NULL,
    [Nombre]                            VARCHAR(100)            NULL DEFAULT NULL,
    [Detalles]                          VARCHAR(250)            NULL DEFAULT NULL,
    PRIMARY KEY CLUSTERED ([Codigo])
);

IF NOT EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name LIKE 'Destino')
CREATE TABLE [dbo].[Destino] (
    [Codigo]                            VARCHAR(100)        NOT NULL,
    [Nombre]                            VARCHAR(100)            NULL DEFAULT NULL,
    [Detalles]                          VARCHAR(250)            NULL DEFAULT NULL,
    PRIMARY KEY CLUSTERED ([Codigo])
);

IF NOT EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name LIKE 'Vehiculo')
CREATE TABLE [dbo].[Vehiculo] (
    [Codigo]                            VARCHAR(100)        NOT NULL,
    [Placa_Vehiculo]                    VARCHAR(50)             NULL DEFAULT NULL,
    [Numero_Interno]                    VARCHAR(50)             NULL DEFAULT NULL,
    [Id_Transportador]                  VARCHAR(100)            NULL DEFAULT NULL,
    [Tara]                              VARCHAR(50)             NULL DEFAULT NULL,
    [Ejes]                              VARCHAR(50)             NULL DEFAULT NULL,
    [Volumen_Vehiculo]                  VARCHAR(50)             NULL DEFAULT NULL,
    [Interno]                           VARCHAR(50)             NULL DEFAULT NULL,
    [Patronado]                         VARCHAR(50)             NULL DEFAULT NULL,
    [Observacion]                       VARCHAR(200)            NULL DEFAULT NULL,
    PRIMARY KEY CLUSTERED ([Codigo])
);

IF NOT EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name LIKE 'Vehiculo_En_Transito')
CREATE TABLE [dbo].[Vehiculo_En_Transito] (
    [Placa]                             VARCHAR(100)        NOT NULL,
    [Caso]                              VARCHAR(100)            NULL DEFAULT NULL,
    [Conductor]                         VARCHAR(100)            NULL DEFAULT NULL,
    [Cedula]                            INT                     NULL DEFAULT NULL,
    [Materia_Prima_Producto]            VARCHAR(100)            NULL DEFAULT NULL,
    [Planta]                            VARCHAR(100)            NULL DEFAULT NULL,
    [Cliente_Proveedor]                 VARCHAR(100)            NULL DEFAULT NULL,
    [Origen_Destino]                    VARCHAR(100)            NULL DEFAULT NULL,
    [Transportadora]                    VARCHAR(100)            NULL DEFAULT NULL,
    [Fecha_Entrada]                     VARCHAR(20)             NULL DEFAULT NULL,
    [Hora_Entrada]                      VARCHAR(20)             NULL DEFAULT NULL,
    [Fecha_Peso_Vacio]                  VARCHAR(20)             NULL DEFAULT NULL,
    [Hora_Peso_Vacio]                   VARCHAR(20)             NULL DEFAULT NULL,
    [Fecha_Despacho_Planta]             VARCHAR(20)             NULL DEFAULT NULL,
    [Hora_Despacho_Planta]              VARCHAR(20)             NULL DEFAULT NULL,
    [Fecha_Peso_Lleno]                  VARCHAR(20)             NULL DEFAULT NULL,
    [Hora_Peso_Lleno]                   VARCHAR(20)             NULL DEFAULT NULL,
    [Fecha_Salida]                      VARCHAR(20)             NULL DEFAULT NULL,
    [Hora_Salida]                       VARCHAR(20)             NULL DEFAULT NULL,
    [Bruto]                             INT                     NULL DEFAULT NULL,
    [Tara]                              INT                     NULL DEFAULT NULL,
    [Neto]                              INT                     NULL DEFAULT NULL,
    [No_Tiquete]                        INT                     NULL DEFAULT NULL,
    [No_Shipment]                       VARCHAR(100)            NULL DEFAULT NULL,
    [No_Sello]                          VARCHAR(100)            NULL DEFAULT NULL,
    [No_R]                              VARCHAR(100)            NULL DEFAULT NULL,
    [No_Contenedor]                     VARCHAR(100)            NULL DEFAULT NULL,
    [Operario]                          VARCHAR(100)            NULL DEFAULT NULL,
    [Nick_Operario]                     VARCHAR(100)            NULL DEFAULT NULL,
    [Observaciones]                     VARCHAR(250)            NULL DEFAULT NULL,
    [No_Interno]                        VARCHAR(100)            NULL DEFAULT NULL,
    [Tipo_Vehiculo]                     VARCHAR(50)             NULL DEFAULT NULL,
    [Entregado_Por]                     VARCHAR(100)            NULL DEFAULT NULL,
    [Recibido_Por]                      VARCHAR(100)            NULL DEFAULT NULL,
    [Direccion]                         VARCHAR(100)            NULL DEFAULT NULL,
    [Civ]                               VARCHAR(50)             NULL DEFAULT NULL,
    [Id_Vehiculo]                       VARCHAR(100)            NULL DEFAULT NULL,
    [Tipo_Producto]                     VARCHAR(100)            NULL DEFAULT NULL,
    [Id_Producto]                       VARCHAR(100)            NULL DEFAULT NULL,
    [Unidad]                            VARCHAR(50)             NULL DEFAULT NULL,
    [Volumen]                           VARCHAR(50)             NULL DEFAULT NULL,
    PRIMARY KEY CLUSTERED ([Placa])
);

IF NOT EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name LIKE 'Registro_Eliminado')
CREATE TABLE [dbo].[Registro_Eliminado] (
    [Placa]                             VARCHAR(100)        NOT NULL,
    [Caso]                              VARCHAR(100)            NULL DEFAULT NULL,
    [Conductor]                         VARCHAR(100)            NULL DEFAULT NULL,
    [Cedula]                            INT                     NULL DEFAULT NULL,
    [Materia_Prima_Producto]            VARCHAR(100)            NULL DEFAULT NULL,
    [Planta]                            VARCHAR(100)            NULL DEFAULT NULL,
    [Cliente_Proveedor]                 VARCHAR(100)            NULL DEFAULT NULL,
    [Origen_Destino]                    VARCHAR(100)            NULL DEFAULT NULL,
    [Transportadora]                    VARCHAR(100)            NULL DEFAULT NULL,
    [Fecha_Entrada]                     VARCHAR(20)             NULL DEFAULT NULL,
    [Hora_Entrada]                      VARCHAR(20)             NULL DEFAULT NULL,
    [Fecha_Peso_Vacio]                  VARCHAR(20)             NULL DEFAULT NULL,
    [Hora_Peso_Vacio]                   VARCHAR(20)             NULL DEFAULT NULL,
    [Fecha_Despacho_Planta]             VARCHAR(20)             NULL DEFAULT NULL,
    [Hora_Despacho_Planta]              VARCHAR(20)             NULL DEFAULT NULL,
    [Fecha_Peso_Lleno]                  VARCHAR(20)             NULL DEFAULT NULL,
    [Hora_Peso_Lleno]                   VARCHAR(20)             NULL DEFAULT NULL,
    [Fecha_Salida]                      VARCHAR(20)             NULL DEFAULT NULL,
    [Hora_Salida]                       VARCHAR(20)             NULL DEFAULT NULL,
    [Bruto]                             INT                     NULL DEFAULT NULL,
    [Tara]                              INT                     NULL DEFAULT NULL,
    [Neto]                              INT                     NULL DEFAULT NULL,
    [No_Shipment]                       VARCHAR(100)            NULL DEFAULT NULL,
    [No_Sello]                          VARCHAR(100)            NULL DEFAULT NULL,
    [No_R]                              VARCHAR(100)            NULL DEFAULT NULL,
    [No_Contenedor]                     VARCHAR(100)            NULL DEFAULT NULL,
    [Operario]                          VARCHAR(100)            NULL DEFAULT NULL,
    [Nick_Operario]                     VARCHAR(100)            NULL DEFAULT NULL,
    [Observaciones]                     VARCHAR(250)            NULL DEFAULT NULL,
    PRIMARY KEY CLUSTERED ([Placa])
);

IF NOT EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name LIKE 'Ingreso')
CREATE TABLE [dbo].[Ingreso] (
    [No_Tiquete]                        INT                 NOT NULL IDENTITY,
    [Placa]                             VARCHAR(10)             NULL DEFAULT NULL,
    [Conductor]                         VARCHAR(100)            NULL DEFAULT NULL,
    [Cedula]                            INT                     NULL DEFAULT NULL,
    [Materia_Prima]                     VARCHAR(100)            NULL DEFAULT NULL,
    [Planta]                            VARCHAR(100)            NULL DEFAULT NULL,
    [Proveedor]                         VARCHAR(100)            NULL DEFAULT NULL,
    [Origen]                            VARCHAR(100)            NULL DEFAULT NULL,
    [Transportadora]                    VARCHAR(100)            NULL DEFAULT NULL,
    [Fecha_Entrada]                     VARCHAR(20)             NULL DEFAULT NULL,
    [Hora_Entrada]                      VARCHAR(20)             NULL DEFAULT NULL,
    [Fecha_Peso_Vacio]                  VARCHAR(20)             NULL DEFAULT NULL,
    [Hora_Peso_Vacio]                   VARCHAR(20)             NULL DEFAULT NULL,
    [Fecha_Despacho_Planta]             VARCHAR(20)             NULL DEFAULT NULL,
    [Hora_Despacho_Planta]              VARCHAR(20)             NULL DEFAULT NULL,
    [Fecha_Peso_Lleno]                  VARCHAR(20)             NULL DEFAULT NULL,
    [Hora_Peso_Lleno]                   VARCHAR(20)             NULL DEFAULT NULL,
    [Fecha_Salida]                      VARCHAR(20)             NULL DEFAULT NULL,
    [Hora_Salida]                       VARCHAR(20)             NULL DEFAULT NULL,
    [Bruto]                             INT                     NULL DEFAULT NULL,
    [Tara]                              INT                     NULL DEFAULT NULL,
    [Neto]                              INT                     NULL DEFAULT NULL,
    [No_Shipment]                       VARCHAR(100)            NULL DEFAULT NULL,
    [No_Sello]                          VARCHAR(100)            NULL DEFAULT NULL,
    [No_R]                              VARCHAR(100)            NULL DEFAULT NULL,
    [No_Contenedor]                     VARCHAR(100)            NULL DEFAULT NULL,
    [Operario]                          VARCHAR(100)            NULL DEFAULT NULL,
    [Nick_Operario]                     VARCHAR(100)            NULL DEFAULT NULL,
    [Observaciones]                     VARCHAR(250)            NULL DEFAULT NULL,
    [No_Interno]                        VARCHAR(100)            NULL DEFAULT NULL,
    [Codigo]                            VARCHAR(50)             NULL DEFAULT NULL,
    [Tipo_Vehiculo]                     VARCHAR(100)            NULL DEFAULT NULL,
    [Tipo_Producto]                     VARCHAR(100)            NULL DEFAULT NULL,
    [Direccion]                         VARCHAR(200)            NULL DEFAULT NULL,
    [Entregado_Por]                     VARCHAR(100)            NULL DEFAULT NULL,
    [Recibido_Por]                      VARCHAR(100)            NULL DEFAULT NULL,
    [Unidad]                            VARCHAR(50)             NULL DEFAULT NULL,
    [Volumen]                           VARCHAR(50)             NULL DEFAULT NULL,
    PRIMARY KEY CLUSTERED ([No_Tiquete])
);

IF NOT EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name LIKE 'Despacho')
CREATE TABLE [dbo].[Despacho] (
    [No_Tiquete]                        INT                 NOT NULL IDENTITY,
    [Placa]                             VARCHAR(10)             NULL DEFAULT NULL,
    [Conductor]                         VARCHAR(100)            NULL DEFAULT NULL,
    [Cedula]                            INT                     NULL DEFAULT NULL,
    [Producto]                          VARCHAR(100)            NULL DEFAULT NULL,
    [Planta]                            VARCHAR(100)            NULL DEFAULT NULL,
    [Cliente]                           VARCHAR(50)             NULL DEFAULT NULL,
    [Destino]                           VARCHAR(100)            NULL DEFAULT NULL,
    [Transportadora]                    VARCHAR(100)            NULL DEFAULT NULL,
    [Fecha_Entrada]                     VARCHAR(20)             NULL DEFAULT NULL,
    [Hora_Entrada]                      VARCHAR(20)             NULL DEFAULT NULL,
    [Fecha_Peso_Vacio]                  VARCHAR(20)             NULL DEFAULT NULL,
    [Hora_Peso_Vacio]                   VARCHAR(20)             NULL DEFAULT NULL,
    [Fecha_Despacho_Planta]             VARCHAR(20)             NULL DEFAULT NULL,
    [Hora_Despacho_Planta]              VARCHAR(20)             NULL DEFAULT NULL,
    [Fecha_Peso_Lleno]                  VARCHAR(20)             NULL DEFAULT NULL,
    [Hora_Peso_Lleno]                   VARCHAR(20)             NULL DEFAULT NULL,
    [Fecha_Salida]                      VARCHAR(20)             NULL DEFAULT NULL,
    [Hora_Salida]                       VARCHAR(20)             NULL DEFAULT NULL,
    [Bruto]                             INT                     NULL DEFAULT NULL,
    [Tara]                              INT                     NULL DEFAULT NULL,
    [Neto]                              INT                     NULL DEFAULT NULL,
    [No_Shipment]                       VARCHAR(100)            NULL DEFAULT NULL,
    [No_Sello]                          VARCHAR(100)            NULL DEFAULT NULL,
    [No_R]                              VARCHAR(100)            NULL DEFAULT NULL,
    [No_Contenedor]                     VARCHAR(100)            NULL DEFAULT NULL,
    [Operario]                          VARCHAR(100)            NULL DEFAULT NULL,
    [Nick_Operario]                     VARCHAR(100)            NULL DEFAULT NULL,
    [Observaciones]                     VARCHAR(250)            NULL DEFAULT NULL,
    [No_Interno]                        VARCHAR(50)             NULL DEFAULT NULL,
    [Codigo]                            VARCHAR(50)             NULL DEFAULT NULL,
    [Tipo_Vehiculo]                     VARCHAR(100)            NULL DEFAULT NULL,
    [Tipo_Producto]                     VARCHAR(100)            NULL DEFAULT NULL,
    [Id_Producto]                       VARCHAR(100)            NULL DEFAULT NULL,
    [Direccion]                         VARCHAR(100)            NULL DEFAULT NULL,
    [Entregado_Por]                     VARCHAR(100)            NULL DEFAULT NULL,
    [Recibido_Por]                      VARCHAR(100)            NULL DEFAULT NULL,
    [Civ]                               VARCHAR(50)             NULL DEFAULT NULL,
    [Unidad]                            VARCHAR(50)             NULL DEFAULT NULL,
    [Volumen]                           VARCHAR(50)             NULL DEFAULT NULL,
    PRIMARY KEY CLUSTERED ([No_Tiquete])
);

-- ---------------------------- --
-- --------FOREIGN KEYS-------- --
-- ---------------------------- --

ALTER TABLE [Vehiculo]
    ADD CONSTRAINT [Vehiculo_Id_Traspotador]
        FOREIGN KEY ([Id_Transportador])
        REFERENCES [Transportadora] ([Nombre])
        ON DELETE NO ACTION
        ON UPDATE NO ACTION;

ALTER TABLE [Vehiculo_En_Transito]
    ADD CONSTRAINT [Vehiculo_En_Transito_Planta]
        FOREIGN KEY ([Planta])
        REFERENCES [Planta] ([Codigo])
        ON DELETE NO ACTION
        ON UPDATE NO ACTION,
    CONSTRAINT [Vehiculo_En_Transito_Transportadora]
        FOREIGN KEY ([Transportadora])
        REFERENCES [Transportadora] ([Nombre])
        ON DELETE NO ACTION
        ON UPDATE NO ACTION,
    CONSTRAINT [Vehiculo_En_Transito_Civ]
        FOREIGN KEY ([Civ])
        REFERENCES [Codigo_Identificacion_Vial] ([Civ])
        ON DELETE NO ACTION
        ON UPDATE NO ACTION,
    CONSTRAINT [Vehiculo_En_Transito_Id_Vehiculo]
        FOREIGN KEY ([Id_Vehiculo])
        REFERENCES [Vehiculo] ([Codigo])
        ON DELETE NO ACTION
        ON UPDATE NO ACTION,
    CONSTRAINT [Vehiculo_En_Transito_Id_Producto]
        FOREIGN KEY ([Id_Producto])
        REFERENCES [Producto] ([Codigo])
        ON DELETE NO ACTION
        ON UPDATE NO ACTION;

ALTER TABLE [Registro_Eliminado]
    ADD CONSTRAINT [Registro_Eliminado_Planta]
        FOREIGN KEY ([Transportadora])
        REFERENCES [Planta] ([Codigo])
        ON DELETE NO ACTION
        ON UPDATE NO ACTION,
    CONSTRAINT [Registro_Eliminado_Transportadora]
        FOREIGN KEY ([Planta])
        REFERENCES [Transportadora] ([Nombre])
        ON DELETE NO ACTION
        ON UPDATE NO ACTION;

ALTER TABLE [Ingreso]
    ADD CONSTRAINT [Ingreso_Cod_Materia_Prima]
        FOREIGN KEY ([Materia_Prima])
        REFERENCES [Materia_Prima] ([Codigo])
        ON DELETE NO ACTION
        ON UPDATE NO ACTION,
    CONSTRAINT [Ingreso_Id_Planta]
        FOREIGN KEY ([Planta])
        REFERENCES [Planta] ([Codigo])
        ON DELETE NO ACTION
        ON UPDATE NO ACTION,
    CONSTRAINT [Ingreso_Id_Transpotador]
        FOREIGN KEY ([Transportadora])
        REFERENCES [Transportadora] ([Nombre])
        ON DELETE NO ACTION
        ON UPDATE NO ACTION,
    CONSTRAINT [Ingreso_Origen]
        FOREIGN KEY ([Origen])
        REFERENCES [Origen] ([Codigo])
        ON DELETE NO ACTION
        ON UPDATE NO ACTION;

ALTER TABLE [Despacho]
    ADD CONSTRAINT [Despacho_Cod_Producto]
        FOREIGN KEY ([Id_Producto])
        REFERENCES [Producto] ([Codigo])
        ON DELETE NO ACTION
        ON UPDATE NO ACTION,
    CONSTRAINT [Despacho_Id_Cliente]
        FOREIGN KEY ([Cliente])
        REFERENCES [Cliente] ([Nit])
        ON DELETE NO ACTION
        ON UPDATE NO ACTION,
    CONSTRAINT [Despacho_Id_Planta]
        FOREIGN KEY ([Planta])
        REFERENCES [Planta] ([Codigo])
        ON DELETE NO ACTION
        ON UPDATE NO ACTION,
    CONSTRAINT [Despacho_Id_Transpotador]
        FOREIGN KEY ([Transportadora])
        REFERENCES [Transportadora] ([Nombre])
        ON DELETE NO ACTION
        ON UPDATE NO ACTION,
    CONSTRAINT [Despacho_Cod_Iv]
        FOREIGN KEY ([Civ])
        REFERENCES [Codigo_Identificacion_Vial] ([Civ])
        ON DELETE NO ACTION
        ON UPDATE NO ACTION,
    CONSTRAINT [Despacho_Destino]
        FOREIGN KEY ([Destino])
        REFERENCES [Destino] ([Codigo])
        ON DELETE NO ACTION
        ON UPDATE NO ACTION;
