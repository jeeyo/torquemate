-- Adminer 4.8.1 PostgreSQL 16.2 (Debian 16.2-1.pgdg120+2) dump

CREATE SEQUENCE torque_data_id_seq INCREMENT 1 MINVALUE 1 MAXVALUE 2147483647 CACHE 1;

CREATE TABLE "public"."torque_data" (
    "id" integer DEFAULT nextval('torque_data_id_seq') NOT NULL,
    "device_id" character(255) NOT NULL,
    "session_id" character(255) NOT NULL,
    "time" timestamp NOT NULL,
    "gps_latitude" point NOT NULL,
    "gps_longitude" point NOT NULL,
    "gps_speed" double precision NOT NULL,
    "gps_altitude" double precision NOT NULL,
    "gps_heading" double precision NOT NULL,
    "gps_accuracy" double precision NOT NULL,
    "gps_satellites" double precision NOT NULL,
    "obd_speed" double precision NOT NULL,
    "obd_rpm" double precision NOT NULL,
    "obd_engine_load" double precision NOT NULL,
    "obd_coolant_temperature" double precision NOT NULL,
    "obd_battery_voltage" double precision NOT NULL,
    "obd_instananeous_co2_emission" double precision NOT NULL,
    "obd_relative_throttle_position" double precision NOT NULL,
    "obd_intake_air_temperature" double precision NOT NULL,
    "obd_trip_distance" double precision NOT NULL,
    "obd_trip_time" double precision NOT NULL,
    CONSTRAINT "torque_data_pkey" PRIMARY KEY ("id")
) WITH (oids = false);


-- 2024-02-18 03:19:12.963239+07
