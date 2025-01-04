-- --------------------------------------------------------------------------------
-- Name: Bob Nields 
 
-- Abstract: FlyMe2theMoon
-- --------------------------------------------------------------------------------

-- --------------------------------------------------------------------------------
-- Options
-- --------------------------------------------------------------------------------
USE dbFlyMe2theMoon;     
SET NOCOUNT ON;  

-- --------------------------------------------------------------------------------
--						Problem #10
-- --------------------------------------------------------------------------------

-- Drop Table Statements
IF OBJECT_ID ('TPilotFlights')			IS NOT NULL DROP TABLE TPilotFlights
IF OBJECT_ID ('TAttendantFlights')		IS NOT NULL DROP TABLE TAttendantFlights
IF OBJECT_ID ('TFlightPassengers')		IS NOT NULL DROP TABLE TFlightPassengers
IF OBJECT_ID ('TMaintenanceMaintenanceWorkers')			IS NOT NULL DROP TABLE TMaintenanceMaintenanceWorkers

IF OBJECT_ID ('TPassengers')			IS NOT NULL DROP TABLE TPassengers
IF OBJECT_ID ('TPilots')				IS NOT NULL DROP TABLE TPilots
IF OBJECT_ID ('TAttendants')			IS NOT NULL DROP TABLE TAttendants
IF OBJECT_ID ('TMaintenanceWorkers')	IS NOT NULL DROP TABLE TMaintenanceWorkers

IF OBJECT_ID ('TFlights')				IS NOT NULL DROP TABLE TFlights
IF OBJECT_ID ('TMaintenances')			IS NOT NULL DROP TABLE TMaintenances
IF OBJECT_ID ('TPlanes')				IS NOT NULL DROP TABLE TPlanes
IF OBJECT_ID ('TPlaneTypes')			IS NOT NULL DROP TABLE TPlaneTypes
IF OBJECT_ID ('TPilotRoles')			IS NOT NULL DROP TABLE TPilotRoles
IF OBJECT_ID ('TAirports')				IS NOT NULL DROP TABLE TAirports
IF OBJECT_ID ('TStates')				IS NOT NULL DROP TABLE TStates

-- --------------------------------------------------------------------------------
--	Step #1 : Create table 
-- --------------------------------------------------------------------------------

CREATE TABLE TPassengers
(
	 intPassengerID			INTEGER			NOT NULL
	,strFirstName			VARCHAR(255)	NOT NULL
	,strLastName			VARCHAR(255)	NOT NULL
	,strAddress				VARCHAR(255)	NOT NULL
	,strCity				VARCHAR(255)	NOT NULL
	,intStateID				INTEGER			NOT NULL
	,strZip					VARCHAR(255)	NOT NULL
	,strPhoneNumber			VARCHAR(255)	NOT NULL
	,strEmail				VARCHAR(255)	NOT NULL
	,CONSTRAINT TPassengers_PK PRIMARY KEY ( intPassengerID )
)


CREATE TABLE TPilots
(
	 intPilotID				INTEGER			NOT NULL
	,strFirstName			VARCHAR(255)	NOT NULL
	,strLastName			VARCHAR(255)	NOT NULL
	,strEmployeeID			VARCHAR(255)	NOT NULL
	,dtmDateOfHire			DATETIME		NOT NULL
	,dtmDateOfTermination	DATETIME		NOT NULL
	,dtmDateOfLicense		DATETIME		NOT NULL
	,intPilotRoleID			INTEGER			NOT NULL

	,CONSTRAINT TPilots_PK PRIMARY KEY ( intPilotID )
)


CREATE TABLE TAttendants
(
	 intAttendantID			INTEGER			NOT NULL
	,strFirstName			VARCHAR(255)	NOT NULL
	,strLastName			VARCHAR(255)	NOT NULL
	,strEmployeeID			VARCHAR(255)	NOT NULL
	,dtmDateOfHire			DATETIME		NOT NULL
	,dtmDateOfTermination	DATETIME		NOT NULL
	,CONSTRAINT TAttendants_PK PRIMARY KEY ( intAttendantID )
)


CREATE TABLE TMaintenanceWorkers
(
	 intMaintenanceWorkerID	INTEGER			NOT NULL
	,strFirstName			VARCHAR(255)	NOT NULL
	,strLastName			VARCHAR(255)	NOT NULL
	,strEmployeeID			VARCHAR(255)	NOT NULL
	,dtmDateOfHire			DATETIME		NOT NULL
	,dtmDateOfTermination	DATETIME		NOT NULL
	,dtmDateOfCertification	DATETIME		NOT NULL
	,CONSTRAINT TMaintenanceWorkers_PK PRIMARY KEY ( intMaintenanceWorkerID )
)


CREATE TABLE TStates
(
	 intStateID			INTEGER			NOT NULL
	,strState			VARCHAR(255)	NOT NULL
	,CONSTRAINT TStates_PK PRIMARY KEY ( intStateID )
)


CREATE TABLE TFlights
(
	 intFlightID			INTEGER			NOT NULL
	,strFlightNumber		VARCHAR(255)	NOT NULL
	,dtmFlightDate			DATETIME		NOT NULL
	,dtmTimeofDeparture		TIME			NOT NULL
	,dtmTimeOfLanding		TIME			NOT NULL
	,intFromAirportID		INTEGER			NOT NULL
	,intToAirportID			INTEGER			NOT NULL
	,intMilesFlown			INTEGER			NOT NULL
	,intPlaneID				INTEGER			NOT NULL
	,CONSTRAINT TFlights_PK PRIMARY KEY ( intFlightID )
)


CREATE TABLE TMaintenances
(
	 intMaintenanceID		INTEGER			NOT NULL
	,strWorkCompleted		VARCHAR(8000)	NOT NULL
	,dtmMaintenanceDate		DATETIME		NOT NULL
	,intPlaneID				INTEGER			NOT NULL
	,CONSTRAINT TMaintenances_PK PRIMARY KEY ( intMaintenanceID )
)


CREATE TABLE TPlanes
(
	 intPlaneID				INTEGER			NOT NULL
	,strPlaneNumber			VARCHAR(255)	NOT NULL
	,intPlaneTypeID			INTEGER			NOT NULL
	,CONSTRAINT TPlanes_PK PRIMARY KEY ( intPlaneID )
)


CREATE TABLE TPlaneTypes	
(
	 intPlaneTypeID			INTEGER			NOT NULL
	,strPlaneType			VARCHAR(255)	NOT NULL
	,CONSTRAINT TPlaneTypes_PK PRIMARY KEY ( intPlaneTypeID )
)


CREATE TABLE TPilotRoles	
(
	 intPilotRoleID			INTEGER			NOT NULL
	,strPilotRole			VARCHAR(255)	NOT NULL
	,CONSTRAINT TPilotRoles_PK PRIMARY KEY ( intPilotRoleID )
)


CREATE TABLE TAirports
(
	 intAirportID			INTEGER			NOT NULL
	,strAirportCity			VARCHAR(255)	NOT NULL
	,strAirportCode			VARCHAR(255)	NOT NULL
	,CONSTRAINT TAirports_PK PRIMARY KEY ( intAirportID )
)


CREATE TABLE TPilotFlights
(
	 intPilotFlightID		INTEGER			NOT NULL
	,intPilotID				INTEGER			NOT NULL
	,intFlightID			INTEGER			NOT NULL
	,CONSTRAINT TPilotFlights_PK PRIMARY KEY ( intPilotFlightID )
)


CREATE TABLE TAttendantFlights
(
	 intAttendantFlightID		INTEGER			NOT NULL
	,intAttendantID				INTEGER			NOT NULL
	,intFlightID				INTEGER			NOT NULL
	,CONSTRAINT TAttendantFlights_PK PRIMARY KEY ( intAttendantFlightID )
)


CREATE TABLE TFlightPassengers
(
	 intFlightPassengerID		INTEGER			NOT NULL
	,intFlightID				INTEGER			NOT NULL
	,intPassengerID				INTEGER			NOT NULL
	,strSeat					VARCHAR(255)	NOT NULL
	,CONSTRAINT TFlightPassengers_PK PRIMARY KEY ( intFlightPassengerID )
)


CREATE TABLE TMaintenanceMaintenanceWorkers
(
	 intMaintenanceMaintenanceWorkerID		INTEGER			NOT NULL
	,intMaintenanceID						INTEGER			NOT NULL
	,intMaintenanceWorkerID					INTEGER			NOT NULL
	,intHours								INTEGER			NOT NULL
	,CONSTRAINT TMaintenanceMaintenanceWorkers_PK PRIMARY KEY ( intMaintenanceMaintenanceWorkerID )
)

-- --------------------------------------------------------------------------------
--	Step #2 : Establish Referential Integrity 
-- --------------------------------------------------------------------------------
--
-- #	Child							Parent						Column
-- -	-----							------						---------
-- 1	TPassengers						TStates						intStateID	
-- 2	TFlightPassenger				TPassengers					intPassengerID
-- 3	TFlights						TPlanes						intPlaneID
-- 4	TFlights						TAirports					intFromAiportID
-- 5	TFlights						TAirports					intToAiportID
-- 6	TPilotFlights					TFlights					intFlightID
-- 7	TAttendantFlights				TFlights					intFlightID
-- 8	TPilotFlights					TPilots						intPilotID
-- 9	TAttendantFlights				TAttendants					intAttendantID
-- 10	TPilots							TPilotRoles					intPilotRoleID
-- 11	TPlanes							TPlaneTypes					intPlaneTypeID
-- 12	TMaintenances					TPlanes						intPlaneID
-- 13	TMaintenanceMaintenanceWorkers	TMaintenance				intMaintenanceID
-- 14	TMaintenanceMaintenanceWorkers	TMaintenanceWorker			intMaintenanceWorkerID
-- 15	TFlightPassenger				TFlights					intFlightID

--1
ALTER TABLE TPassengers ADD CONSTRAINT TPassengers_TStates_FK 
FOREIGN KEY ( intStateID ) REFERENCES TStates ( intStateID ) on delete cascade

--2
ALTER TABLE TFlightPassengers ADD CONSTRAINT TPFlightPassengers_TPassengers_FK 
FOREIGN KEY ( intPassengerID ) REFERENCES TPassengers ( intPassengerID )  on delete cascade

--3
ALTER TABLE TFlights	 ADD CONSTRAINT TFlights_TPlanes_FK 
FOREIGN KEY ( intPlaneID ) REFERENCES TPlanes ( intPlaneID )  on delete cascade

--4
ALTER TABLE TFlights	 ADD CONSTRAINT TFlights_TFromAirports_FK 
FOREIGN KEY ( intFromAirportID ) REFERENCES TAirports ( intAirportID )  on delete cascade

--5
ALTER TABLE TFlights	 ADD CONSTRAINT TFlights_TToAirports_FK 
FOREIGN KEY ( intToAirportID ) REFERENCES TAirports ( intAirportID )

--6
ALTER TABLE TPilotFlights	 ADD CONSTRAINT TPilotFlights_TFlights_FK 
FOREIGN KEY ( intFlightID ) REFERENCES TFlights (intFlightID )   on delete cascade

--7
ALTER TABLE TAttendantFlights	 ADD CONSTRAINT TAttendantFlights_TFlights_FK 
FOREIGN KEY ( intFlightID ) REFERENCES TFlights (intFlightID )  on delete cascade

--8
ALTER TABLE TPilotFlights	 ADD CONSTRAINT TPilotFlights_TPilots_FK 
FOREIGN KEY ( intPilotID ) REFERENCES TPilots (intPilotID )  on delete cascade

--9
ALTER TABLE TAttendantFlights	 ADD CONSTRAINT TAttendantFlights_TAttendants_FK 
FOREIGN KEY ( intAttendantID ) REFERENCES TAttendants (intAttendantID )  on delete cascade

--10
ALTER TABLE TPilots	 ADD CONSTRAINT TPilots_TPilotRoles_FK 
FOREIGN KEY ( intPilotRoleID ) REFERENCES TPilotRoles (intPilotRoleID )   on delete cascade

--11
ALTER TABLE TPlanes	 ADD CONSTRAINT TPlanes_TPlaneTypes_FK 
FOREIGN KEY ( intPlaneTypeID ) REFERENCES TPlaneTypes (intPlaneTypeID )   on delete cascade

--12
ALTER TABLE TMaintenances	 ADD CONSTRAINT TMaintenances_TPlanes_FK 
FOREIGN KEY ( intPlaneID ) REFERENCES TPlanes (intPlaneID )   on delete cascade

--13
ALTER TABLE TMaintenanceMaintenanceWorkers	 ADD CONSTRAINT TMaintenanceMaintenanceWorkers_TMaintenances_FK 
FOREIGN KEY ( intMaintenanceID ) REFERENCES TMaintenances (intMaintenanceID )  on delete cascade

--14
ALTER TABLE TMaintenanceMaintenanceWorkers	 ADD CONSTRAINT TMaintenanceMaintenanceWorkers_TMaintenanceWorkers_FK 
FOREIGN KEY ( intMaintenanceWorkerID ) REFERENCES TMaintenanceWorkers (intMaintenanceWorkerID )  on delete cascade

--15
ALTER TABLE TFlightPassengers	 ADD CONSTRAINT TFlightPassengers_TFlights_FK 
FOREIGN KEY ( intFlightID ) REFERENCES TFlights (intFlightID )  on delete cascade

-- --------------------------------------------------------------------------------
--	Step #3 : Add Data - INSERTS
-- --------------------------------------------------------------------------------
INSERT INTO TStates( intStateID, strState)
VALUES				(1, 'Ohio')
				   ,(2, 'Kentucky')
				   ,(3, 'Indiana')


INSERT INTO TPilotRoles( intPilotRoleID, strPilotRole)
VALUES				(1, 'Co-Pilot')
				   ,(2, 'Captain')

				
INSERT INTO TPlaneTypes( intPlaneTypeID, strPlaneType)
VALUES				(1, 'Airbus A350')
				   ,(2, 'Boeing 747-8')
				   ,(3, 'Boeing 767-300F')


INSERT INTO TPlanes( intPlaneID, strPlaneNumber, intPlaneTypeID)
VALUES				(1, '4X887G', 1)
				   ,(2, '5HT78F', 2)
				   ,(3, '5TYY65', 2)
				   ,(4, '4UR522', 1)
				   ,(5, '6OP3PK', 3)
				   ,(6, '67TYHH', 3)


INSERT INTO TAirports( intAirportID, strAirportCity, strAirportCode)
VALUES				(1, 'Cincinnati', 'CVG')
				   ,(2, 'Miami', 'MIA')
				   ,(3, 'Ft. Meyer', 'RSW')
				   ,(4, 'Louisville',  'SDF')
				   ,(5, 'Denver', 'DEN')
				   ,(6, 'Orlando', 'MCO' )


INSERT INTO TPassengers (intPassengerID, strFirstName, strLastName, strAddress, strCity, intStateID, strZip, strPhoneNumber, strEmail)
VALUES				  (1, 'Knelly', 'Nervious', '321 Elm St.', 'Cincinnati', 1, '45201', '5135553333', 'nnelly@gmail.com')
					 ,(2, 'Orville', 'Waite', '987 Oak St.', 'Cleveland', 1, '45218', '5135556333', 'owright@gmail.com')
					 ,(3, 'Eileen', 'Awnewe', '1569 Windisch Rd.', 'Dayton', 1, '45069', '5135555333', 'eonewe1@yahoo.com')
					 ,(4, 'Bob', 'Eninocean', '44561 Oak Ave.', 'Florence', 2, '45246', '8596663333', 'bobenocean@gmail.com')
					 ,(5, 'Ware', 'Hyjeked', '44881 Pine Ave.', 'Aurora', 3, '45546', '2825553333', 'Hyjekedohmy@gmail.com')
					 ,(6, 'Kay', 'Oss', '4484 Bushfield Ave.', 'Lawrenceburg', 3, '45546', '2825553333', 'wehavekayoss@gmail.com')


INSERT INTO TPilots (intPilotID, strFirstName, strLastName, strEmployeeID, dtmDateofHire, dtmDateofTermination, dtmDateofLicense, intPilotRoleID)
VALUES				  (1, 'Tip', 'Seenow', '12121', '1/1/2015', '1/1/2099', '12/1/2014', 1)
					 ,(2, 'Ima', 'Soring', '13322', '1/1/2016', '1/1/2099', '12/1/2015', 1)
					 ,(3, 'Hugh', 'Encharge', '16666', '1/1/2017', '1/1/2099', '12/1/2016', 2)
					 ,(4, 'Iwanna', 'Knapp', '17676', '1/1/2014', '1/1/2015', '12/1/2013', 1)
					 ,(5, 'Rose', 'Ennair', '19909', '1/1/2012', '1/1/2099', '12/1/2011', 2)


INSERT INTO TAttendants (intAttendantID, strFirstName, strLastName, strEmployeeID, dtmDateofHire, dtmDateofTermination)
VALUES				  (1, 'Miller', 'Tyme', '22121', '1/1/2015', '1/1/2099')
					 ,(2, 'Sherley', 'Ujest', '23322', '1/1/2016', '1/1/2099')
					 ,(3, 'Buhh', 'Biy', '26666', '1/1/2017', '1/1/2099')
					 ,(4, 'Myles', 'Amanie', '27676', '1/1/2014', '1/1/2015')
					 ,(5, 'Walker', 'Toexet', '29909', '1/1/2012', '1/1/2099')


INSERT INTO TMaintenanceWorkers (intMaintenanceWorkerID, strFirstName, strLastName, strEmployeeID, dtmDateofHire, dtmDateofTermination, dtmDateOfCertification)
VALUES				  (1, 'Gressy', 'Nuckles', '32121', '1/1/2015', '1/1/2099', '12/1/2014')
					 ,(2, 'Bolt', 'Izamiss', '33322', '1/1/2016', '1/1/2099', '12/1/2015')
					 ,(3, 'Sharon', 'Urphood', '36666', '1/1/2017', '1/1/2099','12/1/2016')
					 ,(4, 'Ides', 'Racrozed', '37676', '1/1/2014', '1/1/2015','12/1/2013')
					

INSERT INTO TMaintenances (intMaintenanceID, strWorkCompleted, dtmMaintenanceDate, intPlaneID)
VALUES				  (1, 'Fixed Wing', '1/1/2022', 1)
					 ,(2, 'Repaired Flat Tire', '3/1/2022', 2)
					 ,(3, 'Added Wiper Fluid', '4/1/2022', 3)
					 ,(4, 'Tightened Engine to Wing', '5/1/2022', 2)
					 ,(5, '100,000 mile checkup', '3/10/2022', 4)
					 ,(6, 'Replaced Loose Door', '4/10/2022', 6)
					 ,(7, 'Trapped Raccoon in Cargo Hold', '5/1/2022', 6)


INSERT INTO TFlights (intFlightID, dtmFlightDate, strFlightNumber,  dtmTimeofDeparture, dtmTimeOfLanding, intFromAirportID, intToAirportID, intMilesFlown, intPlaneID)
VALUES				  (1, '8/1/2024', '111', '10:00:00', '12:00:00', 1, 2, 1200, 2)
					 ,(2, '4/4/2022', '222','13:00:00', '15:00:00', 1, 3, 1000, 2)
					 ,(3, '8/5/2024', '333','15:00:00', '17:00:00', 1, 5, 1200, 3)
					 ,(4, '4/16/2022','444', '10:00:00', '12:00:00', 4, 6, 1100, 3)
					 ,(5, '2/14/2025','555', '18:00:00', '20:00:00', 2, 1, 1200, 3)
					 ,(6, '3/21/2022','666', '19:00:00', '21:00:00', 3, 1, 1000, 1)
					 ,(7, '12/11/2024', '777','20:00:00', '22:00:00', 3, 6, 1400, 4)
					 ,(8, '3/17/2022', '888','09:00:00', '11:00:00', 6, 4, 1100, 5)
					 ,(9, '1/19/2025', '999','08:00:00', '10:00:00', 4, 2, 1000, 6)
					 ,(10, '4/22/2022', '091','10:00:00', '12:00:00', 2, 1, 1200, 6)


INSERT INTO TPilotFlights ( intPilotFlightID, intPilotID, intFlightID)
VALUES				 ( 1, 1, 2 )
					,( 2, 1, 3 )
					,( 3, 3, 3 )
					,( 4, 3, 2 )
					,( 5, 5, 1 )
					,( 6, 2, 1 )
					,( 7, 3, 4 )
					,( 8, 2, 4 )
					,( 9, 2, 5 )
					,( 10, 3, 5 )
					,( 11, 5, 6 )
					,( 12, 1, 6 )


INSERT INTO TAttendantFlights ( intAttendantFlightID, intAttendantID, intFlightID)
VALUES				( 1, 1, 2 )
					,( 2, 2, 3 )
					,( 3, 3, 3 )
					,( 4, 4, 2 )
					,( 5, 5, 1 )
					,( 6, 1, 1 )
					,( 7, 2, 4 )
					,( 8, 3, 4 )
					,( 9, 4, 5 )
					,( 10, 5, 5 )
					,( 11, 5, 6 )
					,( 12, 1, 6 )
					

INSERT INTO TFlightPassengers ( intFlightPassengerID, intFlightID, intPassengerID, strSeat)
VALUES				 ( 1, 1, 1, '1A')
					,( 2, 1, 2, '2A' )
					,( 3, 1, 3, '1B' )
					,( 4, 1, 4, '1C' )
					,( 5, 1, 5, '1D' )
					,( 6, 2, 5, '1A' )
					,( 7, 2, 4, '2A' )
					,( 8, 2, 3, '1B' )
					,( 9, 3, 1, '1B' )
					,( 10, 3, 2, '2A' )
					,( 11, 3, 3, '1B' )
					,( 12, 3, 4, '1C' )
					,( 13, 3, 5, '1D' )
					,( 14, 4, 2, '1A' )
					,( 15, 4, 3, '1B' )
					,( 16, 4, 4, '1C' )
					,( 17, 4, 5, '1D' )
					,( 18, 5, 1, '1A' )
					,( 19, 5, 2, '2A' )
					,( 20, 5, 3, '1B' )
					,( 21, 5, 4, '2B' )
					,( 22, 6, 1, '1A' )
					,( 23, 6, 2, '2A' )
					,( 24, 6, 3, '3A' )
					

INSERT INTO TMaintenanceMaintenanceWorkers ( intMaintenanceMaintenanceWorkerID, intMaintenanceID, intMaintenanceWorkerID, intHours)
VALUES				 ( 1, 2, 1, 2 )
					,( 2, 4, 1, 3 )
					,( 3, 2, 3, 4 )
					,( 4, 1, 4, 2 )
					,( 5, 3, 4, 2 )
					,( 6, 4, 3, 5 )
					,( 7, 5, 1, 7 )
					,( 8, 6, 1, 2 )
					,( 9, 7, 3, 4 )
					,( 10, 4, 4, 1 )
					,( 11, 3, 3, 4 )
					,( 12, 7, 3, 8 )



Select TA.intAttendantID, TA.strLastName, TF.intFlightID, TF.strFlightNumber, TF.dtmFlightDate, TF.dtmTimeofDeparture, TF.dtmTimeOfLanding
From TAttendants as TA join TAttendantFlights as TAF on TA.intAttendantID = TAF.intAttendantID
	join TFlights as TF on TAF.intFlightID = TF.intFlightID
Where TA.intAttendantID = 1


Select TP.intPilotID, TP.strLastName, TF.intFlightID, TF.strFlightNumber, TF.dtmFlightDate, TF.dtmTimeofDeparture, TF.dtmTimeOfLanding
From TPilots as TP join TPilotFlights as TPF on TP.intPilotID = TPF.intPilotID
	join TFlights as TF on TPF.intFlightID = TF.intFlightID
Where TP.intPilotID = 1

Select TP.strLastName + ',' + TP.strFirstName as strName , TP.strAddress, TP.strCity, TS.strState, TP.strZip, TP.strPhoneNumber, TP.strEmail
From TPassengers as TP join TStates as TS on TP.intStateID = TS.intStateID
Where TP.intPassengerID = 1

Select Distinct TF.intFlightID, 'Flight #' + TF.strFlightNumber + ' - Date: ' + FORMAT(TF.dtmFlightDate, 'yyyy-MM-dd') as Flight, TF.dtmTimeofDeparture
From TFlights as TF
Where TF.dtmFlightDate > cast(getdate() as Date)

Select TF.intFlightID, TA.strAirportCity
From TFlights as TF join TAirports as TA on TF.intFromAirportID = TA.intAirportID
Where TF.dtmFlightDate > cast(getdate() as Date)

Select TF.intFlightID, TA.strAirportCity
From TFlights as TF join TAirports as TA on TF.intToAirportID = TA.intAirportID
join TFlightPassengers as TFP on TF.intFlightID = TFP.intFlightID
join TPassengers as TP on TFP.intPassengerID = TP.intPassengerID
Where TF.dtmFlightDate > cast(getdate() as Date)
	and TP.intPassengerID = 4

--Select FORMAT(TF.dtmFlightDate, 'yyyy-MM-dd')
--From TFlights as TF
--Where TF.dtmFlightDate > cast(getdate() as Date)

Select TF.intFlightID, TP.intPassengerID,TP.strLastName + ', ' + strFirstName as strName ,FORMAT(TF.dtmFlightDate, 'yyyy-MM-dd') as FlightDate, TF.dtmTimeofDeparture, TF.strFlightNumber, TA.strAirportCity
From TFlights as TF join TAirports as TA on TF.intFromAirportID = TA.intAirportID
join TFlightPassengers as TFP on TF.intFlightID = TFP.intFlightID
join TPassengers as TP on TFP.intPassengerID = TP.intPassengerID
Where TP.intPassengerID = 3
--Group By TF.intFlightID

Select TF.intFlightID, TP.strLastName + ', ' + strFirstName as strName ,FORMAT(TF.dtmFlightDate, 'yyyy-MM-dd') as FlightDate, TF.dtmTimeofDeparture, TF.strFlightNumber, TA.strAirportCity as OriginAirport, TATO.strAirportCity as DestinationAirport
From TFlights As TF 
	Join TAirports As TA On TF.intFromAirportID = TA.intAirportID
	join TAirports as TATO on TF.intToAirportID = TATO.intAirportID
	Join TFlightPassengers As TFP On TF.intFlightID = TFP.intFlightID 
	Join TPassengers As TP On TFP.intPassengerID = TP.intPassengerID
Where TF.dtmFlightDate < cast(getdate() As Date) 
	and TP.intPassengerID = 4

Select TF.intFlightID, TA.strAirportCity
From TFlights As TF Join TAirports As TA On TF.intToAirportID = TA.intAirportID
Join TFlightPassengers As TFP On TF.intFlightID = TFP.intFlightID Join TPassengers As TP On TFP.intPassengerID = TP.intPassengerID
Where TF.dtmFlightDate > cast(getdate() As Date) and TP.intPassengerID = 4

SELECT 
    TF.intFlightID, 
    TP.strLastName + ', ' + strFirstName as strName, 
    FORMAT(TF.dtmFlightDate, 'yyyy-MM-dd') as FlightDate, 
    TF.dtmTimeofDeparture, 
    TF.strFlightNumber, 
    TAFrom.strAirportCity AS FromAirportCity, 
    TATo.strAirportCity AS ToAirportCity
FROM 
    TFlights AS TF 
    JOIN TAirports AS TAFrom ON TF.intFromAirportID = TAFrom.intAirportID
    JOIN TAirports AS TATo ON TF.intToAirportID = TATo.intAirportID
    JOIN TFlightPassengers AS TFP ON TF.intFlightID = TFP.intFlightID 
    JOIN TPassengers AS TP ON TFP.intPassengerID = TP.intPassengerID
WHERE 
    TF.dtmFlightDate > CAST(GETDATE() AS DATE) 
    AND TP.intPassengerID = 4

Select TP.strLastName + ', ' + TP.strFirstName as strName ,TF.strFlightNumber ,TF.intMilesFlown, FORMAT(TF.dtmFlightDate, 'yyyy-MM-dd') as FlightDate, TF.dtmTimeofDeparture, TF.dtmTimeOfLanding, TA.strAirportCity, TATO.strAirportCity
From TPilots as TP
join TPilotFlights as TPF on TP.intPilotID = TPF.intPilotID
join TFlights as TF on TPF.intFlightID = TF.intFlightID
join TAirports as TA on TF.intFromAirportID = TA.intAirportID
join TAirports as TATO on TF.intToAirportID = TATO.intAirportID
join TPilotRoles as TPR on TP.intPilotRoleID = TPR.intPilotRoleID
Where TF.dtmFlightDate < CAST(GETDATE() AS DATE) 
    AND TP.intPilotID = 2

Select TA.intAttendantID, TA.strLastName + ', ' + TA.strFirstName as strName, TF.strFlightNumber ,TF.intMilesFlown, FORMAT(TF.dtmFlightDate, 'yyyy-MM-dd') as FlightDate, TF.dtmTimeofDeparture, TF.dtmTimeOfLanding, TAFROM.strAirportCity, TATO.strAirportCity as strToAirportCity
From TAttendants as TA 
join TAttendantFlights as TAF on TA.intAttendantID = TAF.intAttendantID
join TFlights as TF on TAF.intFlightID = TF.intFlightID
join TAirports as TAFROM on TF.intFromAirportID = TAFROM.intAirportID
join TAirports as TATO on TF.intToAirportID = TATO.intAirportID
Where TF.dtmFlightDate > CAST(GETDATE() AS DATE)
	and TA.intAttendantID = 3

Select TF.intFlightID, 'Flight #' + TF.strFlightNumber + ' Date: ' + FORMAT(TF.dtmFlightDate, 'yyyy-MM-dd') as Display
From TFlights as TF Where TF.dtmFlightDate > cast(getdate() As Date)

Select TP.intPilotID, TP.strFirstName, TP.strLastName, TP.strEmployeeID, FORMAT(TP.dtmDateofHire, 'MM-dd-yyyy') as dtmHire, FORMAT(TP.dtmDateofTermination, 'MM-dd-yyyy') as dtmTerm, FORMAT(TP.dtmDateofLicense, 'MM-dd-yyyy') as dtmLicense, TPR.strPilotRole
From TPilots as TP join TPilotRoles as TPR on TP.intPilotRoleID = TPR.intPilotRoleID
Where TP.intPilotID = 3

Select TA.intAttendantID, TA.strFirstName, TA.strLastName, TA.strEmployeeID, FORMAT(TA.dtmDateofHire, 'MM-dd-yyyy') as dtmHire, FORMAT(TA.dtmDateofTermination, 'MM-dd-yyyy') as dtmTerm
From TAttendants as TA	

Select count(TP.intPassengerID) as Total
From TPassengers as TP

Select count(TFP.intFlightPassengerID) as Flights
From TFlightPassengers as TFP

Select avg(TF.intMilesFlown) as Average
From TPassengers as TP
join TFlightPassengers as TFP on TP.intPassengerID = TFP.intPassengerID
join TFlights as TF on TF.intFlightID = TFP.intFlightID

Select TP.strLastName + ', ' + TP.strFirstName as strName, coalesce(sum(TF.intMilesFlown), 0) as Total
From TPilots as TP
left join TPilotFlights as TPF on TP.intPilotID = TPF.intPilotID
left join TFlights as TF on TPF.intFlightID = TF.intFlightID
Group By TP.intPilotID, TP.strLastName, TP.strFirstName

Select TA.strLastName + ', ' + TA.strFirstName as strName, coalesce(sum(TF.intMilesFlown), 0) as Total
From TAttendants as TA
left join TAttendantFlights as TAF on TA.intAttendantID = TAF.intAttendantID
left join TFlights as TF on TAF.intFlightID = TF.intFlightID
Group By TA.strLastName, TA.strFirstName

Select TP.intPilotID
From TPilots as TP
join TPilotFlights as TPF on TP.intPilotID = TPF.intPilotID
join TFlights as TF on TPF.intFlightID = TF.intFlightID

Select TF.intFlightID, 'Flight #' + TF.strFlightNumber + ' Date: ' + FORMAT(TF.dtmFlightDate, 'yyyy-MM-dd') as Display
From TFlights As TF 
Where TF.dtmFlightDate > cast(getdate() As Date)



--CREATE PROCEDURE uspAddPassenger
--     @intPassengerID			AS INTEGER OUTPUT
--    ,@strFirstName			AS VARCHAR(255)
--    ,@strLastName				AS VARCHAR(255)
--    ,@strAddress				AS VARCHAR(255)
--    ,@strCity					AS VARCHAR(255)
--    ,@intStateID				AS INTEGER 
--    ,@strZip					AS VARCHAR(255)
--    ,@strPhone				AS VARCHAR(255)
--	,@strEmail					AS VARCHAR(255)
       
--AS
--SET XACT_ABORT ON --terminate and rollback if any errors
--BEGIN TRANSACTION
--    SELECT @intPassengerID = MAX(intPassengerID) + 1 
--    FROM TPassengers (TABLOCKX) -- lock table until end of transaction
--    -- default to 1 if table is empty
--    SELECT @intPassengerID = COALESCE(@intPassengerID, 1)
--    INSERT INTO TPassengers (intPassengerID, strFirstName, strLastName, strAddress, strCity, intStateID, strZip, strPhoneNumber, strEmail)
--    VALUES (@intPassengerID, @strFirstName, @strLastName, @strAddress, @strCity, @intStateID, @strZip, @strPhone, @strEmail)

--COMMIT TRANSACTION
--GO



--CREATE PROCEDURE uspUpdatePassenger
--     @intPassengerID			AS INTEGER  
--    ,@strFirstName			AS VARCHAR(255)
--    ,@strLastName				AS VARCHAR(255)
--    ,@strAddress				AS VARCHAR(255)
--    ,@strCity					AS VARCHAR(255)
--    ,@intState				AS INTEGER 
--    ,@strZip					AS VARCHAR(255)
--    ,@strPhone				AS VARCHAR(255)
--	  ,@strEmail				AS VARCHAR(255)
       
--AS
--SET XACT_ABORT ON --terminate and rollback if any errors
--BEGIN TRANSACTION
  
--    Update  TPassengers
--			SET strFirstName =	@strFirstName, 
--			    strLastName =	@strLastName,
--				strAddress =	@strAddress, 
--				strCity =		@strCity, 
--				intStateID =	@intState,
--				strZip =		@strZip,
--				strPhoneNumber = @strPhone,
--				strEmail = @strEmail
			
--	WHERE  intPassengerID = @intPassengerID
--COMMIT TRANSACTION
--GO



--CREATE PROCEDURE uspDeletePilot
--     @intPilotID			AS INTEGER  
    
       
--AS
--SET XACT_ABORT ON --terminate and rollback if any errors
--BEGIN TRANSACTION
  
--    Delete  FROM TPilots 
--	WHERE  intPilotID = @intPilotID

--COMMIT TRANSACTION
--GO