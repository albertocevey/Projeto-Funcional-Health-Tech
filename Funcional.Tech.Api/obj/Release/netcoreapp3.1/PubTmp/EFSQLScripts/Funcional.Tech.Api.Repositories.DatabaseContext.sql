﻿CREATE TABLE IF NOT EXISTS "__EFMigrationsHistory" (
    "MigrationId" character varying(150) NOT NULL,
    "ProductVersion" character varying(32) NOT NULL,
    CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY ("MigrationId")
);


DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20210824064624_CriacaoInicial') THEN
    CREATE SCHEMA IF NOT EXISTS contabancaria;
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20210824064624_CriacaoInicial') THEN
    CREATE TABLE contabancaria.conta (
        id integer NOT NULL GENERATED BY DEFAULT AS IDENTITY,
        conta integer NOT NULL,
        data_criacao timestamp without time zone NULL DEFAULT ((now())),
        saldo double precision NOT NULL,
        CONSTRAINT "PK_conta" PRIMARY KEY (id)
    );
    END IF;
END $$;

DO $$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "MigrationId" = '20210824064624_CriacaoInicial') THEN
    INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
    VALUES ('20210824064624_CriacaoInicial', '3.1.6');
    END IF;
END $$;
