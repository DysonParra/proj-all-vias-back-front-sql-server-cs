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
    [StrCodigo]                         VARCHAR(100)        NOT NULL,
    [StrParametro]                      VARCHAR(100)            NULL DEFAULT NULL,
    [StrValor]                          VARCHAR(100)            NULL DEFAULT NULL,
    PRIMARY KEY CLUSTERED ([StrCodigo])
);

IF NOT EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name LIKE 'Conductor')
CREATE TABLE [dbo].[Conductor] (
    [IntCedula]                         INT                 NOT NULL IDENTITY,
    [StrNombre]                         VARCHAR(100)            NULL DEFAULT NULL,
    [StrEstado]                         VARCHAR(100)            NULL DEFAULT NULL,
    PRIMARY KEY CLUSTERED ([IntCedula])
);

IF NOT EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name LIKE 'CodigoIdentificacionVial')
CREATE TABLE [dbo].[CodigoIdentificacionVial] (
    [StrCiv]                            VARCHAR(50)         NOT NULL,
    [StrNombreEjeVia]                   VARCHAR(100)            NULL DEFAULT NULL,
    [StrNombreExtremoInicial]           VARCHAR(100)            NULL DEFAULT NULL,
    [StrNombreExtremoFinal]             VARCHAR(100)            NULL DEFAULT NULL,
    [StrTipoMalla]                      VARCHAR(100)            NULL DEFAULT NULL,
    PRIMARY KEY CLUSTERED ([StrCiv])
);

IF NOT EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name LIKE 'Cliente')
CREATE TABLE [dbo].[Cliente] (
    [StrNit]                            VARCHAR(50)         NOT NULL,
    [StrNombre]                         VARCHAR(100)            NULL DEFAULT NULL,
    [StrDireccion]                      VARCHAR(100)            NULL DEFAULT NULL,
    [StrTelefono]                       VARCHAR(100)            NULL DEFAULT NULL,
    [StrFax]                            VARCHAR(100)            NULL DEFAULT NULL,
    [StrObservaciones]                  VARCHAR(250)            NULL DEFAULT NULL,
    PRIMARY KEY CLUSTERED ([StrNit])
);

IF NOT EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name LIKE 'Ayudante')
CREATE TABLE [dbo].[Ayudante] (
    [IntCedula]                         INT                 NOT NULL IDENTITY,
    [StrNombre]                         VARCHAR(100)            NULL DEFAULT NULL,
    [StrEstado]                         VARCHAR(100)            NULL DEFAULT NULL,
    PRIMARY KEY CLUSTERED ([IntCedula])
);

IF NOT EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name LIKE 'MateriaPrima')
CREATE TABLE [dbo].[MateriaPrima] (
    [StrCodigo]                         VARCHAR(100)        NOT NULL,
    [StrNombre]                         VARCHAR(100)            NULL DEFAULT NULL,
    [StrDetalles]                       VARCHAR(250)            NULL DEFAULT NULL,
    [StrTipo]                           VARCHAR(100)            NULL DEFAULT NULL,
    PRIMARY KEY CLUSTERED ([StrCodigo])
);

IF NOT EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name LIKE 'Indicador')
CREATE TABLE [dbo].[Indicador] (
    [StrCodigo]                         VARCHAR(100)        NOT NULL,
    [StrNombre]                         VARCHAR(100)            NULL DEFAULT NULL,
    [StrTamanoTrama]                    VARCHAR(10)             NULL DEFAULT NULL,
    [StrPosicionInicialPeso]            VARCHAR(10)             NULL DEFAULT NULL,
    [StrTotalDatosPeso]                 VARCHAR(10)             NULL DEFAULT NULL,
    [StrCaracterFinTrama]               VARCHAR(10)             NULL DEFAULT NULL,
    [StrCaracterInicioTrama]            VARCHAR(10)             NULL DEFAULT NULL,
    PRIMARY KEY CLUSTERED ([StrCodigo])
);

IF NOT EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name LIKE 'Usuario')
CREATE TABLE [dbo].[Usuario] (
    [IntCedula]                         INT                 NOT NULL IDENTITY,
    [StrNombre]                         VARCHAR(100)            NULL DEFAULT NULL,
    [StrApellido]                       VARCHAR(100)            NULL DEFAULT NULL,
    [StrNick]                           VARCHAR(50)             NULL DEFAULT NULL,
    [StrTipo]                           VARCHAR(50)             NULL DEFAULT NULL,
    [StrPassword]                       VARCHAR(200)            NULL DEFAULT NULL,
    PRIMARY KEY CLUSTERED ([IntCedula])
);

IF NOT EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name LIKE 'Transportadora')
CREATE TABLE [dbo].[Transportadora] (
    [StrNombre]                         VARCHAR(100)        NOT NULL,
    [StrNit]                            VARCHAR(50)             NULL DEFAULT NULL,
    [StrDireccion]                      VARCHAR(100)            NULL DEFAULT NULL,
    [StrTelefono]                       VARCHAR(50)             NULL DEFAULT NULL,
    [StrFax]                            VARCHAR(100)            NULL DEFAULT NULL,
    [StrObservaciones]                  VARCHAR(250)            NULL DEFAULT NULL,
    PRIMARY KEY CLUSTERED ([StrNombre])
);

IF NOT EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name LIKE 'Proveedor')
CREATE TABLE [dbo].[Proveedor] (
    [StrNit]                            VARCHAR(50)         NOT NULL,
    [StrNombre]                         VARCHAR(100)            NULL DEFAULT NULL,
    [StrDireccion]                      VARCHAR(100)            NULL DEFAULT NULL,
    [StrTelefono]                       VARCHAR(100)            NULL DEFAULT NULL,
    [StrFax]                            VARCHAR(100)            NULL DEFAULT NULL,
    [StrObservaciones]                  VARCHAR(250)            NULL DEFAULT NULL,
    PRIMARY KEY CLUSTERED ([StrNit])
);

IF NOT EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name LIKE 'Producto')
CREATE TABLE [dbo].[Producto] (
    [StrCodigo]                         VARCHAR(100)        NOT NULL,
    [StrNombre]                         VARCHAR(100)            NULL DEFAULT NULL,
    [StrDetalles]                       VARCHAR(100)            NULL DEFAULT NULL,
    [StrTipo]                           VARCHAR(100)            NULL DEFAULT NULL,
    PRIMARY KEY CLUSTERED ([StrCodigo])
);

IF NOT EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name LIKE 'Planta')
CREATE TABLE [dbo].[Planta] (
    [StrCodigo]                         VARCHAR(100)        NOT NULL,
    [StrNombre]                         VARCHAR(100)            NULL DEFAULT NULL,
    [StrDetalles]                       VARCHAR(250)            NULL DEFAULT NULL,
    PRIMARY KEY CLUSTERED ([StrCodigo])
);

IF NOT EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name LIKE 'Origen')
CREATE TABLE [dbo].[Origen] (
    [StrCodigo]                         VARCHAR(100)        NOT NULL,
    [StrNombre]                         VARCHAR(100)            NULL DEFAULT NULL,
    [StrDetalles]                       VARCHAR(250)            NULL DEFAULT NULL,
    PRIMARY KEY CLUSTERED ([StrCodigo])
);

IF NOT EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name LIKE 'Destino')
CREATE TABLE [dbo].[Destino] (
    [StrCodigo]                         VARCHAR(100)        NOT NULL,
    [StrNombre]                         VARCHAR(100)            NULL DEFAULT NULL,
    [StrDetalles]                       VARCHAR(250)            NULL DEFAULT NULL,
    PRIMARY KEY CLUSTERED ([StrCodigo])
);

IF NOT EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name LIKE 'Vehiculo')
CREATE TABLE [dbo].[Vehiculo] (
    [StrCodigo]                         VARCHAR(100)        NOT NULL,
    [StrPlacaVehiculo]                  VARCHAR(50)             NULL DEFAULT NULL,
    [StrNumeroInterno]                  VARCHAR(50)             NULL DEFAULT NULL,
    [StrIdTransportador]                VARCHAR(100)            NULL DEFAULT NULL,
    [StrTara]                           VARCHAR(50)             NULL DEFAULT NULL,
    [StrEjes]                           VARCHAR(50)             NULL DEFAULT NULL,
    [StrVolumenVehiculo]                VARCHAR(50)             NULL DEFAULT NULL,
    [StrInterno]                        VARCHAR(50)             NULL DEFAULT NULL,
    [StrPatronado]                      VARCHAR(50)             NULL DEFAULT NULL,
    [StrObservacion]                    VARCHAR(200)            NULL DEFAULT NULL,
    PRIMARY KEY CLUSTERED ([StrCodigo])
);

IF NOT EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name LIKE 'VehiculoEnTransito')
CREATE TABLE [dbo].[VehiculoEnTransito] (
    [StrPlaca]                          VARCHAR(100)        NOT NULL,
    [StrCaso]                           VARCHAR(100)            NULL DEFAULT NULL,
    [StrConductor]                      VARCHAR(100)            NULL DEFAULT NULL,
    [IntCedula]                         INT                     NULL DEFAULT NULL,
    [StrMateriaPrimaProducto]           VARCHAR(100)            NULL DEFAULT NULL,
    [StrPlanta]                         VARCHAR(100)            NULL DEFAULT NULL,
    [StrClienteProveedor]               VARCHAR(100)            NULL DEFAULT NULL,
    [StrOrigenDestino]                  VARCHAR(100)            NULL DEFAULT NULL,
    [StrTransportadora]                 VARCHAR(100)            NULL DEFAULT NULL,
    [StrFechaEntrada]                   VARCHAR(20)             NULL DEFAULT NULL,
    [StrHoraEntrada]                    VARCHAR(20)             NULL DEFAULT NULL,
    [StrFechaPesoVacio]                 VARCHAR(20)             NULL DEFAULT NULL,
    [StrHoraPesoVacio]                  VARCHAR(20)             NULL DEFAULT NULL,
    [StrFechaDespachoPlanta]            VARCHAR(20)             NULL DEFAULT NULL,
    [StrHoraDespachoPlanta]             VARCHAR(20)             NULL DEFAULT NULL,
    [StrFechaPesoLleno]                 VARCHAR(20)             NULL DEFAULT NULL,
    [StrHoraPesoLleno]                  VARCHAR(20)             NULL DEFAULT NULL,
    [StrFechaSalida]                    VARCHAR(20)             NULL DEFAULT NULL,
    [StrHoraSalida]                     VARCHAR(20)             NULL DEFAULT NULL,
    [IntBruto]                          INT                     NULL DEFAULT NULL,
    [IntTara]                           INT                     NULL DEFAULT NULL,
    [IntNeto]                           INT                     NULL DEFAULT NULL,
    [IntNoTiquete]                      INT                     NULL DEFAULT NULL,
    [StrNoShipment]                     VARCHAR(100)            NULL DEFAULT NULL,
    [StrNoSello]                        VARCHAR(100)            NULL DEFAULT NULL,
    [StrNoR]                            VARCHAR(100)            NULL DEFAULT NULL,
    [StrNoContenedor]                   VARCHAR(100)            NULL DEFAULT NULL,
    [StrOperario]                       VARCHAR(100)            NULL DEFAULT NULL,
    [StrNickOperario]                   VARCHAR(100)            NULL DEFAULT NULL,
    [StrObservaciones]                  VARCHAR(250)            NULL DEFAULT NULL,
    [StrNoInterno]                      VARCHAR(100)            NULL DEFAULT NULL,
    [StrTipoVehiculo]                   VARCHAR(50)             NULL DEFAULT NULL,
    [StrEntregadoPor]                   VARCHAR(100)            NULL DEFAULT NULL,
    [StrRecibidoPor]                    VARCHAR(100)            NULL DEFAULT NULL,
    [StrDireccion]                      VARCHAR(100)            NULL DEFAULT NULL,
    [StrCiv]                            VARCHAR(50)             NULL DEFAULT NULL,
    [StrIdVehiculo]                     VARCHAR(100)            NULL DEFAULT NULL,
    [StrTipoProducto]                   VARCHAR(100)            NULL DEFAULT NULL,
    [StrIdProducto]                     VARCHAR(100)            NULL DEFAULT NULL,
    [StrUnidad]                         VARCHAR(50)             NULL DEFAULT NULL,
    [StrVolumen]                        VARCHAR(50)             NULL DEFAULT NULL,
    PRIMARY KEY CLUSTERED ([StrPlaca])
);

IF NOT EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name LIKE 'RegistroEliminado')
CREATE TABLE [dbo].[RegistroEliminado] (
    [StrPlaca]                          VARCHAR(100)        NOT NULL,
    [StrCaso]                           VARCHAR(100)            NULL DEFAULT NULL,
    [StrConductor]                      VARCHAR(100)            NULL DEFAULT NULL,
    [IntCedula]                         INT                     NULL DEFAULT NULL,
    [StrMateriaPrimaProducto]           VARCHAR(100)            NULL DEFAULT NULL,
    [StrPlanta]                         VARCHAR(100)            NULL DEFAULT NULL,
    [StrClienteProveedor]               VARCHAR(100)            NULL DEFAULT NULL,
    [StrOrigenDestino]                  VARCHAR(100)            NULL DEFAULT NULL,
    [StrTransportadora]                 VARCHAR(100)            NULL DEFAULT NULL,
    [StrFechaEntrada]                   VARCHAR(20)             NULL DEFAULT NULL,
    [StrHoraEntrada]                    VARCHAR(20)             NULL DEFAULT NULL,
    [StrFechaPesoVacio]                 VARCHAR(20)             NULL DEFAULT NULL,
    [StrHoraPesoVacio]                  VARCHAR(20)             NULL DEFAULT NULL,
    [StrFechaDespachoPlanta]            VARCHAR(20)             NULL DEFAULT NULL,
    [StrHoraDespachoPlanta]             VARCHAR(20)             NULL DEFAULT NULL,
    [StrFechaPesoLleno]                 VARCHAR(20)             NULL DEFAULT NULL,
    [StrHoraPesoLleno]                  VARCHAR(20)             NULL DEFAULT NULL,
    [StrFechaSalida]                    VARCHAR(20)             NULL DEFAULT NULL,
    [StrHoraSalida]                     VARCHAR(20)             NULL DEFAULT NULL,
    [IntBruto]                          INT                     NULL DEFAULT NULL,
    [IntTara]                           INT                     NULL DEFAULT NULL,
    [IntNeto]                           INT                     NULL DEFAULT NULL,
    [StrNoShipment]                     VARCHAR(100)            NULL DEFAULT NULL,
    [StrNoSello]                        VARCHAR(100)            NULL DEFAULT NULL,
    [StrNoR]                            VARCHAR(100)            NULL DEFAULT NULL,
    [StrNoContenedor]                   VARCHAR(100)            NULL DEFAULT NULL,
    [StrOperario]                       VARCHAR(100)            NULL DEFAULT NULL,
    [StrNickOperario]                   VARCHAR(100)            NULL DEFAULT NULL,
    [StrObservaciones]                  VARCHAR(250)            NULL DEFAULT NULL,
    PRIMARY KEY CLUSTERED ([StrPlaca])
);

IF NOT EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name LIKE 'Ingreso')
CREATE TABLE [dbo].[Ingreso] (
    [IntNoTiquete]                      INT                 NOT NULL IDENTITY,
    [StrPlaca]                          VARCHAR(10)             NULL DEFAULT NULL,
    [StrConductor]                      VARCHAR(100)            NULL DEFAULT NULL,
    [IntCedula]                         INT                     NULL DEFAULT NULL,
    [StrMateriaPrima]                   VARCHAR(100)            NULL DEFAULT NULL,
    [StrPlanta]                         VARCHAR(100)            NULL DEFAULT NULL,
    [StrProveedor]                      VARCHAR(100)            NULL DEFAULT NULL,
    [StrOrigen]                         VARCHAR(100)            NULL DEFAULT NULL,
    [StrTransportadora]                 VARCHAR(100)            NULL DEFAULT NULL,
    [StrFechaEntrada]                   VARCHAR(20)             NULL DEFAULT NULL,
    [StrHoraEntrada]                    VARCHAR(20)             NULL DEFAULT NULL,
    [StrFechaPesoVacio]                 VARCHAR(20)             NULL DEFAULT NULL,
    [StrHoraPesoVacio]                  VARCHAR(20)             NULL DEFAULT NULL,
    [StrFechaDespachoPlanta]            VARCHAR(20)             NULL DEFAULT NULL,
    [StrHoraDespachoPlanta]             VARCHAR(20)             NULL DEFAULT NULL,
    [StrFechaPesoLleno]                 VARCHAR(20)             NULL DEFAULT NULL,
    [StrHoraPesoLleno]                  VARCHAR(20)             NULL DEFAULT NULL,
    [StrFechaSalida]                    VARCHAR(20)             NULL DEFAULT NULL,
    [StrHoraSalida]                     VARCHAR(20)             NULL DEFAULT NULL,
    [IntBruto]                          INT                     NULL DEFAULT NULL,
    [IntTara]                           INT                     NULL DEFAULT NULL,
    [IntNeto]                           INT                     NULL DEFAULT NULL,
    [StrNoShipment]                     VARCHAR(100)            NULL DEFAULT NULL,
    [StrNoSello]                        VARCHAR(100)            NULL DEFAULT NULL,
    [StrNoR]                            VARCHAR(100)            NULL DEFAULT NULL,
    [StrNoContenedor]                   VARCHAR(100)            NULL DEFAULT NULL,
    [StrOperario]                       VARCHAR(100)            NULL DEFAULT NULL,
    [StrNickOperario]                   VARCHAR(100)            NULL DEFAULT NULL,
    [StrObservaciones]                  VARCHAR(250)            NULL DEFAULT NULL,
    [StrNoInterno]                      VARCHAR(100)            NULL DEFAULT NULL,
    [StrCodigo]                         VARCHAR(50)             NULL DEFAULT NULL,
    [StrTipoVehiculo]                   VARCHAR(100)            NULL DEFAULT NULL,
    [StrTipoProducto]                   VARCHAR(100)            NULL DEFAULT NULL,
    [StrDireccion]                      VARCHAR(200)            NULL DEFAULT NULL,
    [StrEntregadoPor]                   VARCHAR(100)            NULL DEFAULT NULL,
    [StrRecibidoPor]                    VARCHAR(100)            NULL DEFAULT NULL,
    [StrUnidad]                         VARCHAR(50)             NULL DEFAULT NULL,
    [StrVolumen]                        VARCHAR(50)             NULL DEFAULT NULL,
    PRIMARY KEY CLUSTERED ([IntNoTiquete])
);

IF NOT EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name LIKE 'Despacho')
CREATE TABLE [dbo].[Despacho] (
    [IntNoTiquete]                      INT                 NOT NULL IDENTITY,
    [StrPlaca]                          VARCHAR(10)             NULL DEFAULT NULL,
    [StrConductor]                      VARCHAR(100)            NULL DEFAULT NULL,
    [IntCedula]                         INT                     NULL DEFAULT NULL,
    [StrProducto]                       VARCHAR(100)            NULL DEFAULT NULL,
    [StrPlanta]                         VARCHAR(100)            NULL DEFAULT NULL,
    [StrCliente]                        VARCHAR(50)             NULL DEFAULT NULL,
    [StrDestino]                        VARCHAR(100)            NULL DEFAULT NULL,
    [StrTransportadora]                 VARCHAR(100)            NULL DEFAULT NULL,
    [StrFechaEntrada]                   VARCHAR(20)             NULL DEFAULT NULL,
    [StrHoraEntrada]                    VARCHAR(20)             NULL DEFAULT NULL,
    [StrFechaPesoVacio]                 VARCHAR(20)             NULL DEFAULT NULL,
    [StrHoraPesoVacio]                  VARCHAR(20)             NULL DEFAULT NULL,
    [StrFechaDespachoPlanta]            VARCHAR(20)             NULL DEFAULT NULL,
    [StrHoraDespachoPlanta]             VARCHAR(20)             NULL DEFAULT NULL,
    [StrFechaPesoLleno]                 VARCHAR(20)             NULL DEFAULT NULL,
    [StrHoraPesoLleno]                  VARCHAR(20)             NULL DEFAULT NULL,
    [StrFechaSalida]                    VARCHAR(20)             NULL DEFAULT NULL,
    [StrHoraSalida]                     VARCHAR(20)             NULL DEFAULT NULL,
    [IntBruto]                          INT                     NULL DEFAULT NULL,
    [IntTara]                           INT                     NULL DEFAULT NULL,
    [IntNeto]                           INT                     NULL DEFAULT NULL,
    [StrNoShipment]                     VARCHAR(100)            NULL DEFAULT NULL,
    [StrNoSello]                        VARCHAR(100)            NULL DEFAULT NULL,
    [StrNoR]                            VARCHAR(100)            NULL DEFAULT NULL,
    [StrNoContenedor]                   VARCHAR(100)            NULL DEFAULT NULL,
    [StrOperario]                       VARCHAR(100)            NULL DEFAULT NULL,
    [StrNickOperario]                   VARCHAR(100)            NULL DEFAULT NULL,
    [StrObservaciones]                  VARCHAR(250)            NULL DEFAULT NULL,
    [StrNoInterno]                      VARCHAR(50)             NULL DEFAULT NULL,
    [StrCodigo]                         VARCHAR(50)             NULL DEFAULT NULL,
    [StrTipoVehiculo]                   VARCHAR(100)            NULL DEFAULT NULL,
    [StrTipoProducto]                   VARCHAR(100)            NULL DEFAULT NULL,
    [StrIdProducto]                     VARCHAR(100)            NULL DEFAULT NULL,
    [StrDireccion]                      VARCHAR(100)            NULL DEFAULT NULL,
    [StrEntregadoPor]                   VARCHAR(100)            NULL DEFAULT NULL,
    [StrRecibidoPor]                    VARCHAR(100)            NULL DEFAULT NULL,
    [StrCiv]                            VARCHAR(50)             NULL DEFAULT NULL,
    [StrUnidad]                         VARCHAR(50)             NULL DEFAULT NULL,
    [StrVolumen]                        VARCHAR(50)             NULL DEFAULT NULL,
    PRIMARY KEY CLUSTERED ([IntNoTiquete])
);

-- ---------------------------- --
-- --------FOREIGN KEYS-------- --
-- ---------------------------- --

ALTER TABLE [Vehiculo]
    ADD CONSTRAINT [VehiculoIdTraspotador]
        FOREIGN KEY ([StrIdTransportador])
        REFERENCES [Transportadora] ([StrNombre])
        ON DELETE NO ACTION
        ON UPDATE NO ACTION;

ALTER TABLE [VehiculoEnTransito]
    ADD CONSTRAINT [VehiculoEnTransitoPlanta]
        FOREIGN KEY ([StrPlanta])
        REFERENCES [Planta] ([StrCodigo])
        ON DELETE NO ACTION
        ON UPDATE NO ACTION,
    CONSTRAINT [VehiculoEnTransitoTransportadora]
        FOREIGN KEY ([StrTransportadora])
        REFERENCES [Transportadora] ([StrNombre])
        ON DELETE NO ACTION
        ON UPDATE NO ACTION,
    CONSTRAINT [VehiculoEnTransitoCiv]
        FOREIGN KEY ([StrCiv])
        REFERENCES [CodigoIdentificacionVial] ([StrCiv])
        ON DELETE NO ACTION
        ON UPDATE NO ACTION,
    CONSTRAINT [VehiculoEnTransitoIdVehiculo]
        FOREIGN KEY ([StrIdVehiculo])
        REFERENCES [Vehiculo] ([StrCodigo])
        ON DELETE NO ACTION
        ON UPDATE NO ACTION,
    CONSTRAINT [VehiculoEnTransitoIdProducto]
        FOREIGN KEY ([StrIdProducto])
        REFERENCES [Producto] ([StrCodigo])
        ON DELETE NO ACTION
        ON UPDATE NO ACTION;

ALTER TABLE [RegistroEliminado]
    ADD CONSTRAINT [RegistroEliminadoPlanta]
        FOREIGN KEY ([StrTransportadora])
        REFERENCES [Planta] ([StrCodigo])
        ON DELETE NO ACTION
        ON UPDATE NO ACTION,
    CONSTRAINT [RegistroEliminadoTransportadora]
        FOREIGN KEY ([StrPlanta])
        REFERENCES [Transportadora] ([StrNombre])
        ON DELETE NO ACTION
        ON UPDATE NO ACTION;

ALTER TABLE [Ingreso]
    ADD CONSTRAINT [IngresoCodMateriaPrima]
        FOREIGN KEY ([StrMateriaPrima])
        REFERENCES [MateriaPrima] ([StrCodigo])
        ON DELETE NO ACTION
        ON UPDATE NO ACTION,
    CONSTRAINT [IngresoIdPlanta]
        FOREIGN KEY ([StrPlanta])
        REFERENCES [Planta] ([StrCodigo])
        ON DELETE NO ACTION
        ON UPDATE NO ACTION,
    CONSTRAINT [IngresoIdTranspotador]
        FOREIGN KEY ([StrTransportadora])
        REFERENCES [Transportadora] ([StrNombre])
        ON DELETE NO ACTION
        ON UPDATE NO ACTION,
    CONSTRAINT [IngresoOrigen]
        FOREIGN KEY ([StrOrigen])
        REFERENCES [Origen] ([StrCodigo])
        ON DELETE NO ACTION
        ON UPDATE NO ACTION;

ALTER TABLE [Despacho]
    ADD CONSTRAINT [DespachoCodProducto]
        FOREIGN KEY ([StrIdProducto])
        REFERENCES [Producto] ([StrCodigo])
        ON DELETE NO ACTION
        ON UPDATE NO ACTION,
    CONSTRAINT [DespachoIdCliente]
        FOREIGN KEY ([StrCliente])
        REFERENCES [Cliente] ([StrNit])
        ON DELETE NO ACTION
        ON UPDATE NO ACTION,
    CONSTRAINT [DespachoIdPlanta]
        FOREIGN KEY ([StrPlanta])
        REFERENCES [Planta] ([StrCodigo])
        ON DELETE NO ACTION
        ON UPDATE NO ACTION,
    CONSTRAINT [DespachoIdTranspotador]
        FOREIGN KEY ([StrTransportadora])
        REFERENCES [Transportadora] ([StrNombre])
        ON DELETE NO ACTION
        ON UPDATE NO ACTION,
    CONSTRAINT [DespachoCodIv]
        FOREIGN KEY ([StrCiv])
        REFERENCES [CodigoIdentificacionVial] ([StrCiv])
        ON DELETE NO ACTION
        ON UPDATE NO ACTION,
    CONSTRAINT [DespachoDestino]
        FOREIGN KEY ([StrDestino])
        REFERENCES [Destino] ([StrCodigo])
        ON DELETE NO ACTION
        ON UPDATE NO ACTION;
