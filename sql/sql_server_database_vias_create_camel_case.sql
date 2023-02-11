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

IF NOT EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name LIKE 'CodigoIdentificacionVial')
CREATE TABLE [dbo].[CodigoIdentificacionVial] (
    [Civ]                               VARCHAR(50)         NOT NULL,
    [NombreEjeVia]                      VARCHAR(100)            NULL DEFAULT NULL,
    [NombreExtremoInicial]              VARCHAR(100)            NULL DEFAULT NULL,
    [NombreExtremoFinal]                VARCHAR(100)            NULL DEFAULT NULL,
    [TipoMalla]                         VARCHAR(100)            NULL DEFAULT NULL,
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

IF NOT EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name LIKE 'MateriaPrima')
CREATE TABLE [dbo].[MateriaPrima] (
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
    [TamanoTrama]                       VARCHAR(10)             NULL DEFAULT NULL,
    [PosicionInicialPeso]               VARCHAR(10)             NULL DEFAULT NULL,
    [TotalDatosPeso]                    VARCHAR(10)             NULL DEFAULT NULL,
    [CaracterFinTrama]                  VARCHAR(10)             NULL DEFAULT NULL,
    [CaracterInicioTrama]               VARCHAR(10)             NULL DEFAULT NULL,
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
    [PlacaVehiculo]                     VARCHAR(50)             NULL DEFAULT NULL,
    [NumeroInterno]                     VARCHAR(50)             NULL DEFAULT NULL,
    [IdTransportador]                   VARCHAR(100)            NULL DEFAULT NULL,
    [Tara]                              VARCHAR(50)             NULL DEFAULT NULL,
    [Ejes]                              VARCHAR(50)             NULL DEFAULT NULL,
    [VolumenVehiculo]                   VARCHAR(50)             NULL DEFAULT NULL,
    [Interno]                           VARCHAR(50)             NULL DEFAULT NULL,
    [Patronado]                         VARCHAR(50)             NULL DEFAULT NULL,
    [Observacion]                       VARCHAR(200)            NULL DEFAULT NULL,
    PRIMARY KEY CLUSTERED ([Codigo])
);

IF NOT EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name LIKE 'VehiculoEnTransito')
CREATE TABLE [dbo].[VehiculoEnTransito] (
    [Placa]                             VARCHAR(100)        NOT NULL,
    [Caso]                              VARCHAR(100)            NULL DEFAULT NULL,
    [Conductor]                         VARCHAR(100)            NULL DEFAULT NULL,
    [Cedula]                            INT                     NULL DEFAULT NULL,
    [MateriaPrimaProducto]              VARCHAR(100)            NULL DEFAULT NULL,
    [Planta]                            VARCHAR(100)            NULL DEFAULT NULL,
    [ClienteProveedor]                  VARCHAR(100)            NULL DEFAULT NULL,
    [OrigenDestino]                     VARCHAR(100)            NULL DEFAULT NULL,
    [Transportadora]                    VARCHAR(100)            NULL DEFAULT NULL,
    [FechaEntrada]                      VARCHAR(20)             NULL DEFAULT NULL,
    [HoraEntrada]                       VARCHAR(20)             NULL DEFAULT NULL,
    [FechaPesoVacio]                    VARCHAR(20)             NULL DEFAULT NULL,
    [HoraPesoVacio]                     VARCHAR(20)             NULL DEFAULT NULL,
    [FechaDespachoPlanta]               VARCHAR(20)             NULL DEFAULT NULL,
    [HoraDespachoPlanta]                VARCHAR(20)             NULL DEFAULT NULL,
    [FechaPesoLleno]                    VARCHAR(20)             NULL DEFAULT NULL,
    [HoraPesoLleno]                     VARCHAR(20)             NULL DEFAULT NULL,
    [FechaSalida]                       VARCHAR(20)             NULL DEFAULT NULL,
    [HoraSalida]                        VARCHAR(20)             NULL DEFAULT NULL,
    [Bruto]                             INT                     NULL DEFAULT NULL,
    [Tara]                              INT                     NULL DEFAULT NULL,
    [Neto]                              INT                     NULL DEFAULT NULL,
    [NoTiquete]                         INT                     NULL DEFAULT NULL,
    [NoShipment]                        VARCHAR(100)            NULL DEFAULT NULL,
    [NoSello]                           VARCHAR(100)            NULL DEFAULT NULL,
    [NoR]                               VARCHAR(100)            NULL DEFAULT NULL,
    [NoContenedor]                      VARCHAR(100)            NULL DEFAULT NULL,
    [Operario]                          VARCHAR(100)            NULL DEFAULT NULL,
    [NickOperario]                      VARCHAR(100)            NULL DEFAULT NULL,
    [Observaciones]                     VARCHAR(250)            NULL DEFAULT NULL,
    [NoInterno]                         VARCHAR(100)            NULL DEFAULT NULL,
    [TipoVehiculo]                      VARCHAR(50)             NULL DEFAULT NULL,
    [EntregadoPor]                      VARCHAR(100)            NULL DEFAULT NULL,
    [RecibidoPor]                       VARCHAR(100)            NULL DEFAULT NULL,
    [Direccion]                         VARCHAR(100)            NULL DEFAULT NULL,
    [Civ]                               VARCHAR(50)             NULL DEFAULT NULL,
    [IdVehiculo]                        VARCHAR(100)            NULL DEFAULT NULL,
    [TipoProducto]                      VARCHAR(100)            NULL DEFAULT NULL,
    [IdProducto]                        VARCHAR(100)            NULL DEFAULT NULL,
    [Unidad]                            VARCHAR(50)             NULL DEFAULT NULL,
    [Volumen]                           VARCHAR(50)             NULL DEFAULT NULL,
    PRIMARY KEY CLUSTERED ([Placa])
);

IF NOT EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name LIKE 'RegistroEliminado')
CREATE TABLE [dbo].[RegistroEliminado] (
    [Placa]                             VARCHAR(100)        NOT NULL,
    [Caso]                              VARCHAR(100)            NULL DEFAULT NULL,
    [Conductor]                         VARCHAR(100)            NULL DEFAULT NULL,
    [Cedula]                            INT                     NULL DEFAULT NULL,
    [MateriaPrimaProducto]              VARCHAR(100)            NULL DEFAULT NULL,
    [Planta]                            VARCHAR(100)            NULL DEFAULT NULL,
    [ClienteProveedor]                  VARCHAR(100)            NULL DEFAULT NULL,
    [OrigenDestino]                     VARCHAR(100)            NULL DEFAULT NULL,
    [Transportadora]                    VARCHAR(100)            NULL DEFAULT NULL,
    [FechaEntrada]                      VARCHAR(20)             NULL DEFAULT NULL,
    [HoraEntrada]                       VARCHAR(20)             NULL DEFAULT NULL,
    [FechaPesoVacio]                    VARCHAR(20)             NULL DEFAULT NULL,
    [HoraPesoVacio]                     VARCHAR(20)             NULL DEFAULT NULL,
    [FechaDespachoPlanta]               VARCHAR(20)             NULL DEFAULT NULL,
    [HoraDespachoPlanta]                VARCHAR(20)             NULL DEFAULT NULL,
    [FechaPesoLleno]                    VARCHAR(20)             NULL DEFAULT NULL,
    [HoraPesoLleno]                     VARCHAR(20)             NULL DEFAULT NULL,
    [FechaSalida]                       VARCHAR(20)             NULL DEFAULT NULL,
    [HoraSalida]                        VARCHAR(20)             NULL DEFAULT NULL,
    [Bruto]                             INT                     NULL DEFAULT NULL,
    [Tara]                              INT                     NULL DEFAULT NULL,
    [Neto]                              INT                     NULL DEFAULT NULL,
    [NoShipment]                        VARCHAR(100)            NULL DEFAULT NULL,
    [NoSello]                           VARCHAR(100)            NULL DEFAULT NULL,
    [NoR]                               VARCHAR(100)            NULL DEFAULT NULL,
    [NoContenedor]                      VARCHAR(100)            NULL DEFAULT NULL,
    [Operario]                          VARCHAR(100)            NULL DEFAULT NULL,
    [NickOperario]                      VARCHAR(100)            NULL DEFAULT NULL,
    [Observaciones]                     VARCHAR(250)            NULL DEFAULT NULL,
    PRIMARY KEY CLUSTERED ([Placa])
);

IF NOT EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name LIKE 'Ingreso')
CREATE TABLE [dbo].[Ingreso] (
    [NoTiquete]                         INT                 NOT NULL IDENTITY,
    [Placa]                             VARCHAR(10)             NULL DEFAULT NULL,
    [Conductor]                         VARCHAR(100)            NULL DEFAULT NULL,
    [Cedula]                            INT                     NULL DEFAULT NULL,
    [MateriaPrima]                      VARCHAR(100)            NULL DEFAULT NULL,
    [Planta]                            VARCHAR(100)            NULL DEFAULT NULL,
    [Proveedor]                         VARCHAR(100)            NULL DEFAULT NULL,
    [Origen]                            VARCHAR(100)            NULL DEFAULT NULL,
    [Transportadora]                    VARCHAR(100)            NULL DEFAULT NULL,
    [FechaEntrada]                      VARCHAR(20)             NULL DEFAULT NULL,
    [HoraEntrada]                       VARCHAR(20)             NULL DEFAULT NULL,
    [FechaPesoVacio]                    VARCHAR(20)             NULL DEFAULT NULL,
    [HoraPesoVacio]                     VARCHAR(20)             NULL DEFAULT NULL,
    [FechaDespachoPlanta]               VARCHAR(20)             NULL DEFAULT NULL,
    [HoraDespachoPlanta]                VARCHAR(20)             NULL DEFAULT NULL,
    [FechaPesoLleno]                    VARCHAR(20)             NULL DEFAULT NULL,
    [HoraPesoLleno]                     VARCHAR(20)             NULL DEFAULT NULL,
    [FechaSalida]                       VARCHAR(20)             NULL DEFAULT NULL,
    [HoraSalida]                        VARCHAR(20)             NULL DEFAULT NULL,
    [Bruto]                             INT                     NULL DEFAULT NULL,
    [Tara]                              INT                     NULL DEFAULT NULL,
    [Neto]                              INT                     NULL DEFAULT NULL,
    [NoShipment]                        VARCHAR(100)            NULL DEFAULT NULL,
    [NoSello]                           VARCHAR(100)            NULL DEFAULT NULL,
    [NoR]                               VARCHAR(100)            NULL DEFAULT NULL,
    [NoContenedor]                      VARCHAR(100)            NULL DEFAULT NULL,
    [Operario]                          VARCHAR(100)            NULL DEFAULT NULL,
    [NickOperario]                      VARCHAR(100)            NULL DEFAULT NULL,
    [Observaciones]                     VARCHAR(250)            NULL DEFAULT NULL,
    [NoInterno]                         VARCHAR(100)            NULL DEFAULT NULL,
    [Codigo]                            VARCHAR(50)             NULL DEFAULT NULL,
    [TipoVehiculo]                      VARCHAR(100)            NULL DEFAULT NULL,
    [TipoProducto]                      VARCHAR(100)            NULL DEFAULT NULL,
    [Direccion]                         VARCHAR(200)            NULL DEFAULT NULL,
    [EntregadoPor]                      VARCHAR(100)            NULL DEFAULT NULL,
    [RecibidoPor]                       VARCHAR(100)            NULL DEFAULT NULL,
    [Unidad]                            VARCHAR(50)             NULL DEFAULT NULL,
    [Volumen]                           VARCHAR(50)             NULL DEFAULT NULL,
    PRIMARY KEY CLUSTERED ([NoTiquete])
);

IF NOT EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name LIKE 'Despacho')
CREATE TABLE [dbo].[Despacho] (
    [NoTiquete]                         INT                 NOT NULL IDENTITY,
    [Placa]                             VARCHAR(10)             NULL DEFAULT NULL,
    [Conductor]                         VARCHAR(100)            NULL DEFAULT NULL,
    [Cedula]                            INT                     NULL DEFAULT NULL,
    [Producto]                          VARCHAR(100)            NULL DEFAULT NULL,
    [Planta]                            VARCHAR(100)            NULL DEFAULT NULL,
    [Cliente]                           VARCHAR(50)             NULL DEFAULT NULL,
    [Destino]                           VARCHAR(100)            NULL DEFAULT NULL,
    [Transportadora]                    VARCHAR(100)            NULL DEFAULT NULL,
    [FechaEntrada]                      VARCHAR(20)             NULL DEFAULT NULL,
    [HoraEntrada]                       VARCHAR(20)             NULL DEFAULT NULL,
    [FechaPesoVacio]                    VARCHAR(20)             NULL DEFAULT NULL,
    [HoraPesoVacio]                     VARCHAR(20)             NULL DEFAULT NULL,
    [FechaDespachoPlanta]               VARCHAR(20)             NULL DEFAULT NULL,
    [HoraDespachoPlanta]                VARCHAR(20)             NULL DEFAULT NULL,
    [FechaPesoLleno]                    VARCHAR(20)             NULL DEFAULT NULL,
    [HoraPesoLleno]                     VARCHAR(20)             NULL DEFAULT NULL,
    [FechaSalida]                       VARCHAR(20)             NULL DEFAULT NULL,
    [HoraSalida]                        VARCHAR(20)             NULL DEFAULT NULL,
    [Bruto]                             INT                     NULL DEFAULT NULL,
    [Tara]                              INT                     NULL DEFAULT NULL,
    [Neto]                              INT                     NULL DEFAULT NULL,
    [NoShipment]                        VARCHAR(100)            NULL DEFAULT NULL,
    [NoSello]                           VARCHAR(100)            NULL DEFAULT NULL,
    [NoR]                               VARCHAR(100)            NULL DEFAULT NULL,
    [NoContenedor]                      VARCHAR(100)            NULL DEFAULT NULL,
    [Operario]                          VARCHAR(100)            NULL DEFAULT NULL,
    [NickOperario]                      VARCHAR(100)            NULL DEFAULT NULL,
    [Observaciones]                     VARCHAR(250)            NULL DEFAULT NULL,
    [NoInterno]                         VARCHAR(50)             NULL DEFAULT NULL,
    [Codigo]                            VARCHAR(50)             NULL DEFAULT NULL,
    [TipoVehiculo]                      VARCHAR(100)            NULL DEFAULT NULL,
    [TipoProducto]                      VARCHAR(100)            NULL DEFAULT NULL,
    [IdProducto]                        VARCHAR(100)            NULL DEFAULT NULL,
    [Direccion]                         VARCHAR(100)            NULL DEFAULT NULL,
    [EntregadoPor]                      VARCHAR(100)            NULL DEFAULT NULL,
    [RecibidoPor]                       VARCHAR(100)            NULL DEFAULT NULL,
    [Civ]                               VARCHAR(50)             NULL DEFAULT NULL,
    [Unidad]                            VARCHAR(50)             NULL DEFAULT NULL,
    [Volumen]                           VARCHAR(50)             NULL DEFAULT NULL,
    PRIMARY KEY CLUSTERED ([NoTiquete])
);

-- ---------------------------- --
-- --------FOREIGN KEYS-------- --
-- ---------------------------- --

ALTER TABLE [Vehiculo]
    ADD CONSTRAINT [VehiculoIdTraspotador]
        FOREIGN KEY ([IdTransportador])
        REFERENCES [Transportadora] ([Nombre])
        ON DELETE NO ACTION
        ON UPDATE NO ACTION;

ALTER TABLE [VehiculoEnTransito]
    ADD CONSTRAINT [VehiculoEnTransitoPlanta]
        FOREIGN KEY ([Planta])
        REFERENCES [Planta] ([Codigo])
        ON DELETE NO ACTION
        ON UPDATE NO ACTION,
    CONSTRAINT [VehiculoEnTransitoTransportadora]
        FOREIGN KEY ([Transportadora])
        REFERENCES [Transportadora] ([Nombre])
        ON DELETE NO ACTION
        ON UPDATE NO ACTION,
    CONSTRAINT [VehiculoEnTransitoCiv]
        FOREIGN KEY ([Civ])
        REFERENCES [CodigoIdentificacionVial] ([Civ])
        ON DELETE NO ACTION
        ON UPDATE NO ACTION,
    CONSTRAINT [VehiculoEnTransitoIdVehiculo]
        FOREIGN KEY ([IdVehiculo])
        REFERENCES [Vehiculo] ([Codigo])
        ON DELETE NO ACTION
        ON UPDATE NO ACTION,
    CONSTRAINT [VehiculoEnTransitoIdProducto]
        FOREIGN KEY ([IdProducto])
        REFERENCES [Producto] ([Codigo])
        ON DELETE NO ACTION
        ON UPDATE NO ACTION;

ALTER TABLE [RegistroEliminado]
    ADD CONSTRAINT [RegistroEliminadoPlanta]
        FOREIGN KEY ([Transportadora])
        REFERENCES [Planta] ([Codigo])
        ON DELETE NO ACTION
        ON UPDATE NO ACTION,
    CONSTRAINT [RegistroEliminadoTransportadora]
        FOREIGN KEY ([Planta])
        REFERENCES [Transportadora] ([Nombre])
        ON DELETE NO ACTION
        ON UPDATE NO ACTION;

ALTER TABLE [Ingreso]
    ADD CONSTRAINT [IngresoCodMateriaPrima]
        FOREIGN KEY ([MateriaPrima])
        REFERENCES [MateriaPrima] ([Codigo])
        ON DELETE NO ACTION
        ON UPDATE NO ACTION,
    CONSTRAINT [IngresoIdPlanta]
        FOREIGN KEY ([Planta])
        REFERENCES [Planta] ([Codigo])
        ON DELETE NO ACTION
        ON UPDATE NO ACTION,
    CONSTRAINT [IngresoIdTranspotador]
        FOREIGN KEY ([Transportadora])
        REFERENCES [Transportadora] ([Nombre])
        ON DELETE NO ACTION
        ON UPDATE NO ACTION,
    CONSTRAINT [IngresoOrigen]
        FOREIGN KEY ([Origen])
        REFERENCES [Origen] ([Codigo])
        ON DELETE NO ACTION
        ON UPDATE NO ACTION;

ALTER TABLE [Despacho]
    ADD CONSTRAINT [DespachoCodProducto]
        FOREIGN KEY ([IdProducto])
        REFERENCES [Producto] ([Codigo])
        ON DELETE NO ACTION
        ON UPDATE NO ACTION,
    CONSTRAINT [DespachoIdCliente]
        FOREIGN KEY ([Cliente])
        REFERENCES [Cliente] ([Nit])
        ON DELETE NO ACTION
        ON UPDATE NO ACTION,
    CONSTRAINT [DespachoIdPlanta]
        FOREIGN KEY ([Planta])
        REFERENCES [Planta] ([Codigo])
        ON DELETE NO ACTION
        ON UPDATE NO ACTION,
    CONSTRAINT [DespachoIdTranspotador]
        FOREIGN KEY ([Transportadora])
        REFERENCES [Transportadora] ([Nombre])
        ON DELETE NO ACTION
        ON UPDATE NO ACTION,
    CONSTRAINT [DespachoCodIv]
        FOREIGN KEY ([Civ])
        REFERENCES [CodigoIdentificacionVial] ([Civ])
        ON DELETE NO ACTION
        ON UPDATE NO ACTION,
    CONSTRAINT [DespachoDestino]
        FOREIGN KEY ([Destino])
        REFERENCES [Destino] ([Codigo])
        ON DELETE NO ACTION
        ON UPDATE NO ACTION;
