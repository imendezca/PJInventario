-- Created by Vertabelo (http://vertabelo.com)
-- Last modification date: 2019-02-18 17:02:04.539
USE PJInventario;
-- tables
-- Table: Circuito
CREATE TABLE Circuito (
    CodCircuito int  NOT NULL,
    NombreCircuito varchar(50)  NOT NULL,
    CONSTRAINT PK_Circuito PRIMARY KEY  (CodCircuito)
);

-- Table: Contrato
CREATE TABLE Contrato (
    NumContrato int  NOT NULL,
    FechaInicio datetime  NOT NULL,
    FechaFinal datetime  NULL,
    NombreEmpresa varchar(20)  NOT NULL,
    CONSTRAINT PK_Contrato PRIMARY KEY  (NumContrato)
);

-- Table: Despacho
CREATE TABLE Despacho (
    CodDespacho varchar(4)  NOT NULL,
    CodCircuito int  NOT NULL,
    NombreDespacho varchar(50)  NOT NULL,
	CantTecJud int  NOT NULL,
    CantTecJur int  NOT NULL,
    CantCoordJud int  NOT NULL,
    CantJuezCoord int  NOT NULL,
    CantJuezTram int  NOT NULL,
    CantJueces int  NOT NULL,
    CantOtros int  NOT NULL,
    CONSTRAINT PK_Despacho PRIMARY KEY  (CodDespacho),
	CONSTRAINT Despacho_Circuito FOREIGN KEY (CodCircuito) REFERENCES Circuito (CodCircuito)
);

-- Table: Estado
CREATE TABLE Estado (
    IDEstado int  NOT NULL IDENTITY,
    NombreDeEstado varchar(30)  NOT NULL,
    CONSTRAINT PK_Estado PRIMARY KEY  (IDEstado)
);

-- Table: Puesto
CREATE TABLE Puesto (
    IDPuesto varchar(10)  NOT NULL,
    NombrePuesto varchar(20)  NOT NULL,
    CONSTRAINT PK_Puesto PRIMARY KEY  (IDPuesto)
);

-- Table: Puesto_Despacho
CREATE TABLE Puesto_Despacho (
    CodDespacho varchar(4) NOT NULL,
    IDPuesto varchar(10)  NOT NULL,
    CONSTRAINT PK_Puesto_Despacho PRIMARY KEY  (CodDespacho,IDPuesto),
	CONSTRAINT Puesto_Despacho_Despacho FOREIGN KEY (CodDespacho) REFERENCES Despacho (CodDespacho),
	CONSTRAINT Puesto_Despacho_Puesto FOREIGN KEY (IDPuesto) REFERENCES Puesto (IDPuesto)
);

-- Table: TipoDeEquipo
CREATE TABLE TipoEquipo (
    IDTipoEquipo int  NOT NULL IDENTITY,
    Nombre varchar(25)  NOT NULL,
    CONSTRAINT PK_TipoEquipo PRIMARY KEY  (IDTipoEquipo)
);

-- Table: Equipo
CREATE TABLE Equipo (
    Activo int  NOT NULL,
    NumSerie varchar(25)  NOT NULL,
    Marca varchar(15)  NOT NULL,
    Descripcion varchar(255),
    TipoDeEquipo int  NOT NULL,
    CodDespacho varchar(4)  NOT NULL,
    IDPuesto varchar(10)  NOT NULL,
    NumContrato int  NOT NULL,
    IDEstado int  NOT NULL,
    Alquilado bit  NOT NULL,
    FechaIngreso datetime  NOT NULL,
    Observaciones varchar(255),
    UsuarioCrea varchar(45)  NOT NULL,
    UsuarioModifica varchar(45)  NOT NULL,
    UltimaModicacion datetime  NOT NULL,
    CONSTRAINT PK_Equipo PRIMARY KEY  (Activo),
	CONSTRAINT Equipo_Contrato FOREIGN KEY (NumContrato) REFERENCES Contrato (NumContrato),
	CONSTRAINT Equipo_Estado FOREIGN KEY (IDEstado) REFERENCES Estado (IDEstado),
	CONSTRAINT Equipo_Puesto_Despacho FOREIGN KEY (CodDespacho,IDPuesto) REFERENCES Puesto_Despacho (CodDespacho,IDPuesto),
	CONSTRAINT Equipo_TipoDeEquipo FOREIGN KEY (TipoDeEquipo) REFERENCES TipoEquipo (IDTipoEquipo)
);

-- Table: Asignado
CREATE TABLE Asignado (
    Equipo1 int  NOT NULL,
    Equipo2 int  NOT NULL,
    CONSTRAINT UK_Equipo1 UNIQUE (Equipo1),
    CONSTRAINT PK_Asignado PRIMARY KEY  (Equipo1,Equipo2),
	CONSTRAINT Asignado_Equipo1 FOREIGN KEY (Equipo1) REFERENCES Equipo (Activo),
	CONSTRAINT Asignado_Equipo2 FOREIGN KEY (Equipo2) REFERENCES Equipo (Activo)
);

-- Table: Equipos_Permitidos
CREATE TABLE Equipos_Permitidos (
    IDPermitido int  NOT NULL IDENTITY,
    TipoEquipo1 int  NOT NULL,
    TipoEquipo2 int  NOT NULL,
    CONSTRAINT PK_Equipos_Permitidos PRIMARY KEY  (IDPermitido),
	CONSTRAINT Equipos_Permitidos_TipoDeEquipo1 FOREIGN KEY (TipoEquipo1) REFERENCES TipoEquipo (IDTipoEquipo),
	CONSTRAINT Equipos_Permitidos_TipoDeEquipo2 FOREIGN KEY (TipoEquipo2) REFERENCES TipoEquipo (IDTipoEquipo)
);

-- Table: Historico
CREATE TABLE Historico (
    Activo int  NOT NULL,
    NumSerie varchar(25)  NOT NULL,
    Marca varchar(15)  NOT NULL,
    Descripcion varchar(255),
    TipoDeEquipo varchar(25)  NOT NULL,
    NombreDespacho varchar(50)  NOT NULL,
    NombrePuesto varchar(20)  NOT NULL,
    NumContrato int  NOT NULL,
    Alquilado bit  NOT NULL,
    Estado varchar(30)  NOT NULL,
    FechaIngreso datetime  NOT NULL,
    Observaciones varchar(255),
    UsuarioCrea varchar(45)  NOT NULL,
    UsuarioModifica varchar(45)  NOT NULL,
    UltimaModificacion datetime  NOT NULL,
    CONSTRAINT PK_Historico PRIMARY KEY  (Activo)
);

-- Table: LogModificacion
CREATE TABLE LogModificacion (
    NumLog int IDENTITY(1,1) NOT NULL,
    Activo int  NOT NULL,
    CONSTRAINT PK_LogModificacion PRIMARY KEY  (NumLog)
);

-- Table: Rol
CREATE TABLE Rol (
    CodRol int  NOT NULL IDENTITY,
    Descripcion varchar(20)  NOT NULL,
    CONSTRAINT PK_Rol PRIMARY KEY  (CodRol)
);


-- Table: Usuario
CREATE TABLE Usuario (
    IDUsuario int  NOT NULL,
    CodRol int  NOT NULL,
    Nombre varchar(15)  NOT NULL,
    PrimerApellido varchar(15)  NOT NULL,
    SegundoApellido varchar(15),
    Correo varchar(30)  NOT NULL,
    Telefono varchar(10),
    CONSTRAINT PK_Usuario PRIMARY KEY  (IDUsuario),
	CONSTRAINT Usuario_Rol FOREIGN KEY (CodRol) REFERENCES Rol (CodRol)
);

-- End of file.

