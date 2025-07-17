//Get-ChildItem *.resx -Recurse | Unblock-File

//Del Control Database
drop table APPOINTMENTS cascade constraints;
drop table CLIENTS cascade constraints;
drop table COUNTIES cascade constraints;
drop table PARTS cascade constraints;
drop table SERVICEPARTS cascade constraints;

--------------------------------------------------------------------------------

PROMPT CREATING Table Counties
PROMPT

CREATE TABLE Counties
(County varchar2(20) NOT NULL,

CONSTRAINT pk_Counties PRIMARY KEY (County))

--------------------------------------------------------------------------------


PROMPT CREATING Table Clients
PROMPT

CREATE TABLE Clients
(ClientID numeric(3) NOT NULL,
Firstname varchar2(20) NOT NULL,
Lastname varchar2(20) NOT NULL,
Phone varchar2(13) NOT NULL UNIQUE,
Email varchar2(40) NOT NULL UNIQUE,
County varchar2(20) NOT NULL,
City varchar2(20) NOT NULL,
Street varchar2(50) NOT NULL,
AirCode varchar2(7) NOT NULL,
Status char(1) NOT NULL ,

CONSTRAINT pk_Clients PRIMARY KEY (ClientID),
CONSTRAINT fk_Clients_Counties FOREIGN KEY (County) REFERENCES Counties);

--------------------------------------------------------------------------------

PROMPT CREATING Table Parts
PROMPT

CREATE TABLE Parts
(PartID numeric(3) NOT NULL,
Type varchar2(20) NOT NULL,
Compatibility varchar2(100) NOT NULL,
Supplier varchar2(20) NOT NULL,
Manufacturer varchar2(20) NOT NULL,
Quantity numeric(3) NOT NULL,
Price numeric(6,2) NOT NULL,
usedTimes numeric(4),
Status char(1) NOT NULL,

CONSTRAINT pk_Parts PRIMARY KEY (PartID))

--------------------------------------------------------------------------------

PROMPT CREATING Table Appointments
PROMPT

CREATE TABLE Appointments
(AppointmentID numeric(3) NOT NULL,
ClientID numeric(3) NOT NULL,
App_Date date NOT NULL,
App_Time varchar2(5) NOT NULL,
Cost numeric(7, 2) NOT NULL,
Status char(1) NOT NULL,

CONSTRAINT pk_Appointments PRIMARY KEY (AppointmentID),
CONSTRAINT fk_Appointments_Clients FOREIGN KEY (ClientID) REFERENCES Clients);

--------------------------------------------------------------------------------


PROMPT CREATING Table ServiceParts
PROMPT

CREATE TABLE ServiceParts
(AppointmentID numeric(3) NOT NULL,
PartID numeric(3) NOT NULL,
--PRIMARY KEY(AppointmentID, PartID),
CONSTRAINT fk_AppointmentID FOREIGN KEY (AppointmentID) REFERENCES Appointments,
CONSTRAINT fk_PartID FOREIGN KEY (PartID) REFERENCES Parts);

--------------------------------------------------------------------------------


INSERT INTO Counties VALUES ('Carlow');
INSERT INTO Counties VALUES ('Cavan');
INSERT INTO Counties VALUES ('Clare');
INSERT INTO Counties VALUES ('Cork');
INSERT INTO Counties VALUES ('Donegal');
INSERT INTO Counties VALUES ('Dublin');
INSERT INTO Counties VALUES ('Galway');
INSERT INTO Counties VALUES ('Kerry');
INSERT INTO Counties VALUES ('Kildare');
INSERT INTO Counties VALUES ('Kilkenny');
INSERT INTO Counties VALUES ('Laois');
INSERT INTO Counties VALUES ('Leitrim');
INSERT INTO Counties VALUES ('Limerick');
INSERT INTO Counties VALUES ('Longford');
INSERT INTO Counties VALUES ('Louth');
INSERT INTO Counties VALUES ('Mayo');
INSERT INTO Counties VALUES ('Meath');
INSERT INTO Counties VALUES ('Monaghan');
INSERT INTO Counties VALUES ('Offaly');
INSERT INTO Counties VALUES ('Roscommon');
INSERT INTO Counties VALUES ('Sligo');
INSERT INTO Counties VALUES ('Tipperary');
INSERT INTO Counties VALUES ('Waterford');
INSERT INTO Counties VALUES ('Westmeath');
INSERT INTO Counties VALUES ('Wexford');
INSERT INTO Counties VALUES ('Wicklow');
INSERT INTO Counties VALUES ('Antrim');
INSERT INTO Counties VALUES ('Armagh');
INSERT INTO Counties VALUES ('Down');
INSERT INTO Counties VALUES ('Fermanagh');
INSERT INTO Counties VALUES ('Londonderry');
INSERT INTO Counties VALUES ('Tyrone');
COMMIT;


--------------------------------------------------------------------------------

-- Clients INSERT Queries

INSERT INTO Clients
VALUES(100,'Nikita','Kokach','+380768814537','nikitka@gmail.com','Carlow','WaxTown', 'LightLine 14A', 'A37GG23','R');
COMMIT;

INSERT INTO Clients
VALUES(101,'Joe','Blinken','+380768814536','joe_blk228@gmail.com','Kerry','Tralee', 'LightLine 2B', 'A37FG43','R');
COMMIT;

INSERT INTO Clients
VALUES(102,'Vladic', 'Pichkin','+38076614531','vladic@gmail.com','Cavan','Kilwileen', 'LightLine 22C', 'A37FG23','R');
COMMIT;

INSERT INTO Clients
VALUES(103,'Kisi', 'Natuche','+380768814539','kisi@gmail.com','Carlow','Skullinston', 'LightLine 32V', 'C32FG23','R');
COMMIT;

INSERT INTO Clients
VALUES(104,'Jefry', 'Blackwood','+38076614575','blackwoordsss1982@gmail.com','Carlow','SishinTown', 'LightLine 21D', 'A37BB23','R');
COMMIT;

-- Parts INSERT Queries

INSERT INTO Parts (PartID, Type, Compatibility, Supplier, Manufacturer, Quantity, Price, usedTimes, Status)
VALUES (101, 'Brake Pad', 'Toyota Camry 2018', 'Auto Supplies Inc.', 'Brembo', 50, 89.99, 120, 'R');

INSERT INTO Parts (PartID, Type, Compatibility, Supplier, Manufacturer, Quantity, Price, usedTimes, Status)
VALUES (102, 'Air Filter', 'Honda Civic 2019', 'CarParts Depot', 'K.N. Filters', 100, 39.50, 85, 'R');

INSERT INTO Parts (PartID, Type, Compatibility, Supplier, Manufacturer, Quantity, Price, usedTimes, Status)
VALUES (103, 'Timing Belt', 'Ford Focus 2020', 'MotorWorks Ltd.', 'Gates', 30, 120.75, 50, 'R');

INSERT INTO Parts (PartID, Type, Compatibility, Supplier, Manufacturer, Quantity, Price, usedTimes, Status)
VALUES (104, 'Oil Filter', 'Chevrolet Silverado 2021', 'PartsPlus', 'ACDelco', 200, 18.99, 200, 'R');

INSERT INTO Parts (PartID, Type, Compatibility, Supplier, Manufacturer, Quantity, Price, usedTimes, Status)
VALUES (105, 'Spark Plug', 'Nissan Altima 2020', 'SparkAuto Parts 1', 'NGK', 150, 10.25, 500, 'R');

INSERT INTO Parts (PartID, Type, Compatibility, Supplier, Manufacturer, Quantity, Price, usedTimes, Status)
VALUES (108, 'Air Filter', 'Nissan Altima 2020', 'SparkAuto Parts 2', 'NGK 1', 95, 103.25, 5, 'R');

INSERT INTO Parts (PartID, Type, Compatibility, Supplier, Manufacturer, Quantity, Price, usedTimes, Status)
VALUES (107, 'Brake Pad', 'Nissan Altima 2020', 'SparkAuto Parts 3', 'NGK 2', 23, 105.25, 10, 'R');

INSERT INTO Parts (PartID, Type, Compatibility, Supplier, Manufacturer, Quantity, Price, usedTimes, Status)
VALUES (106, 'Headlight Bulb', 'BMW 3 Series 2019', 'LuxParts', 'Osram', 75, 45.00, 35, 'R');
COMMIT;

-- Appointments INSERT Queries

INSERT INTO Appointments (AppointmentID, ClientID, App_Date, App_Time, Cost, Status)
VALUES (101, 101, TO_DATE('15-03-2025', 'DD-MM-YYYY'), '10:00', 245, 'R');

INSERT INTO Appointments (AppointmentID, ClientID, App_Date, App_Time, Cost, Status)
VALUES (102, 102, TO_DATE('17-03-2025', 'DD-MM-YYYY'), '12:00', 124, 'R');

INSERT INTO Appointments (AppointmentID, ClientID, App_Date, App_Time, Cost, Status)
VALUES (103, 100, TO_DATE('18-03-2025', 'DD-MM-YYYY'), '18:00', 204, 'R');

INSERT INTO Appointments (AppointmentID, ClientID, App_Date, App_Time, Cost, Status)
VALUES (104, 104, TO_DATE('15-03-2024', 'DD-MM-YYYY'), '10:00', 1002, 'R');

INSERT INTO Appointments (AppointmentID, ClientID, App_Date, App_Time, Cost, Status)
VALUES (105, 102, TO_DATE('17-03-2024', 'DD-MM-YYYY'), '12:00', 1046, 'R');

INSERT INTO Appointments (AppointmentID, ClientID, App_Date, App_Time, Cost, Status)
VALUES (106, 101, TO_DATE('18-03-2024', 'DD-MM-YYYY'), '18:00', 325, 'R');

INSERT INTO Appointments (AppointmentID, ClientID, App_Date, App_Time, Cost, Status)
VALUES (107, 103, TO_DATE('27-04-2024', 'DD-MM-YYYY'), '18:00', 325, 'R');
COMMIT;

--------------------------------------------------------------------------------

COMMIT;