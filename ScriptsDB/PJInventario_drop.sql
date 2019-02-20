-- Created by Vertabelo (http://vertabelo.com)
-- Last modification date: 2019-02-18 17:12:55.88

-- foreign keys
ALTER TABLE Asignado DROP CONSTRAINT Asignado_Equipo1;

ALTER TABLE Asignado DROP CONSTRAINT Asignado_Equipo2;

ALTER TABLE Despacho DROP CONSTRAINT Despacho_Circuito;

ALTER TABLE Equipo DROP CONSTRAINT Equipo_Contrato;

ALTER TABLE Equipo DROP CONSTRAINT Equipo_Estado;

ALTER TABLE Equipo DROP CONSTRAINT Equipo_Puesto_Despacho;

ALTER TABLE Equipo DROP CONSTRAINT Equipo_TipoDeEquipo;

ALTER TABLE Equipos_Permitidos DROP CONSTRAINT Equipos_Permitidos_TipoDeEquipo1;

ALTER TABLE Equipos_Permitidos DROP CONSTRAINT Equipos_Permitidos_TipoDeEquipo2;

ALTER TABLE Puesto_Despacho DROP CONSTRAINT Puesto_Despacho_Despacho;

ALTER TABLE Puesto_Despacho DROP CONSTRAINT Puesto_Despacho_Puesto;

ALTER TABLE Usuario DROP CONSTRAINT Usuario_Rol;

-- tables
DROP TABLE Asignado;

DROP TABLE Circuito;

DROP TABLE Contrato;

DROP TABLE Despacho;

DROP TABLE Equipo;

DROP TABLE Equipos_Permitidos;

DROP TABLE Estado;

DROP TABLE Historico;

DROP TABLE LogModificacion;

DROP TABLE Puesto;

DROP TABLE Puesto_Despacho;

DROP TABLE Rol;

DROP TABLE TipoEquipo;

DROP TABLE Usuario;

-- End of file.

