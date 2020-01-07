use master;
go


--Datenbank anlegen
if DB_ID(N'Lagerverwaltung') is null
	Create Database Lagerverwaltung;
	go


use Lagerverwaltung;
go

--Zwischentabellen für n zu m zurücksetzen
--Anzahl:II(2)
--LiefererLiefert, bekommtgeliefert


if OBJECT_ID('enthaeltBenutzer')is not null
	Drop Table enthaeltBenutzer;
	go		

if OBJECT_ID('enthältKunde') is not null
	Drop table enthältKunde;
	go

if OBJECT_ID('enthältLieferer') is not null
	Drop table enthältLieferer;
	go

if OBJECT_ID('enthältWaren') is not null
	Drop table enthältWaren;
	go

if OBJECT_ID('Wareneingang')is not null
	Drop Table Wareneingang;
	go	

if OBJECT_ID('Warenausgang')is not null
	Drop Table Warenausgang;
	go

if OBJECT_ID('LiefererProdukte')is not null
	Drop Table LiefererProdukte
	go

if OBJECT_ID('KundeProdukte')is not null
	Drop Table KundeProdukte
	go


--Haubtabellen zurücksetzen


if OBJECT_ID('Lieferer') is not null
	Drop Table Lieferer;
	go


if OBJECT_ID('Waren')is not null
	Drop Table Waren;
	go

if OBJECT_ID('Produkte')is not null
	Drop Table Produkte;
	go


if OBJECT_ID('Kunde')is not null
	Drop Table Kunde;
	go

if OBJECT_ID('KAnsprechpartner') is not null
	Drop table KAnsprechpartner;
	go

if OBJECT_ID('LAnsprechpartner') is not null
	Drop table LAnsprechpartner;
	go


if OBJECT_ID('LagerSystem') is not null
	Drop Table LagerSystem;
	go

if OBJECT_ID('BenutzerProfil')is not null
	Drop Table BenutzerProfil;
	go



--Haupttabellen anlegen!





if OBJECT_ID('BenutzerProfil')is null
	create Table BenutzerProfil(
		NutzerNr int primary key identity(1,1),
		NutzerName nvarchar(250) not null,
		hash nvarchar(50) not null,
		salt nvarchar(50) not null
		);

If OBJECT_ID('Produkte')is null
	Create Table Produkte(
		ProduktNummer int primary key,
		ProduktName nvarchar(400) not null,
		ProduktWert real	
		);

if OBJECT_ID('Waren')is null
	create Table Waren(
		ArtikelNr int primary key not null,
		AktBestand int,
		Mindestbestand int,
		ProduktNummer int unique,
		constraint fkProdukt foreign key (ProduktNummer) references Produkte(ProduktNummer) on delete cascade
		);


if OBJECT_ID('LagerSystem')is null
	create Table LagerSystem(
		SystemNr int primary key,
		Lagername nvarchar(100)
		);

If OBJECT_ID('KAnpsrechpartner') is null
	create table KAnsprechpartner(
		AnsprechPartnerNummer int primary key,
		AnspAnrede nvarchar(9),
		AnspVorname nvarchar(500),
		AnspNachname nvarchar(500),
		AnpsHandyNummer nvarchar(18),
		AnspTelefonnummer nvarchar(18),
		AnspEmail nvarchar(250)
		);

if OBJECT_ID('Kunde')is null
	create Table Kunde(
		KundenNr int primary key not null,
		KundenName nvarchar(250) not null,
		PLZ nvarchar(20),
		Adresse nvarchar(200),
		Ort nvarchar(250),
		Telefonnummer nvarchar(18),
		EmailaddresseBetrieb nvarchar(250),
		Website nvarchar(250),
		Ansprechpartner int unique,
		constraint fkKundeAnsprechpartner foreign key(Ansprechpartner) references KAnsprechpartner(AnsprechPartnerNummer) on delete cascade
		);

If OBJECT_ID('LAnsprechpartner') is null
	create table LAnsprechpartner(
		AnprechPartnerNummer int primary key,
		AnspAnrede nvarchar(9),
		AnspVorname nvarchar(500),
		AnspNachname nvarchar(500),
		AnpsHandyNummer nvarchar(18),
		AnspTelefonnummer nvarchar(18),
		AnspEmail nvarchar(250),
		);

if OBJECT_ID('Lieferer')is null
	create Table Lieferer(
		LiefererNR int primary key not null,
		LiefererName nvarchar(250) not null,
		PLZ nvarchar(20),
		Adresse nvarchar(200),
		Ort nvarchar(250),
		Telefonnummer nvarchar(18),
		EmailaddresseBetrieb nvarchar(250),
		Website nvarchar(250),
		Ansprechpartner int unique,
		constraint fkLiefererAnprechpartner foreign key(Ansprechpartner) references LAnsprechpartner(AnprechPartnerNummer) on delete cascade
		);



--Zwischentabellen für n zu m anlegen

if OBJECT_ID('enthaeltBenutzer')is null
	create table enthaeltBenutzer(
		NNr int,
		SysNr int,
		constraint plnutzer primary key(NNR, SysNr),
		constraint fkNutzer foreign key (NNr) references BenutzerProfil (NutzerNr) on delete no action,
		constraint fkSystem foreign key (SysNr) references LagerSystem (SystemNr) on delete no action
		)


if OBJECT_ID('enthältKunde') is null
	Create Table enthältKunde(
		KNR int,
		SysNr int
		constraint pkkundeinsystem primary key(KNR, SysNr),
		constraint fkkundesys foreign key(KNR) references Kunde(KundenNr) on delete cascade,
		constraint fksyskunde foreign key(SysNr) references LagerSystem(SystemNr) on delete no action
	);

if OBJECT_ID('enthältLieferer') is null
	Create Table enthältLieferer(
		LNR int,
		SysNr int,
		constraint pkliefererinsystem primary key(LNR,SysNr),
		constraint fklieferersys foreign key(LNR) references Lieferer(LiefererNR) on delete cascade,
		constraint fksyslieferer foreign key (SysNr) references LagerSystem(SystemNr) on delete no action
	);

if OBJECT_ID('enthältWaren') is null
	Create Table enthältWaren(
		ANR int,
		SysNr int,
		constraint pkwareninsystem primary key(ANR, SysNr),
		constraint fkwarensys foreign key(ANR) references Waren(ArtikelNr) on delete cascade,
		constraint fksyswaren foreign key(SysNr) references LagerSystem(SystemNr) on delete no action
		);

if OBJECT_ID('Wareneingang') is null
	create table Wareneingang(
		WareneingangID int,
		Lieferer int,
		Artikel int,
		Bestellmenge int,
		constraint pkwareneingang primary key(Lieferer,Artikel,WareneingangID,Bestellmenge),
		constraint fkLief foreign key(Lieferer) references Lieferer(LiefererNr) on delete no action,
		constraint fkWar foreign key(Artikel) references Waren(ArtikelNr) on delete no action
		);

if OBJECT_ID('Warenausgang') is null
	create table Warenausgang(
		WarenausgangID int,
		Kunde int,
		Artikel int,
		Bestellmenge int,
		constraint pkwarenausgang primary key(Kunde, Artikel,WarenausgangID,Bestellmenge),
		constraint fkKund foreign key(Kunde) references Kunde(KundenNr) on delete no action,
		constraint fkWare foreign key(Artikel) references Waren(ArtikelNr) on delete no action
		);

if OBJECT_ID('LiefererProdukte')is null
	CREATE TABLE LiefererProdukte(
		LiefererID int,
		ProdukteID int,
		constraint pkproduktlieferer primary key(LiefererID, ProdukteID),
		constraint fkLiefererProdukte foreign key(LiefererID) references Lieferer(LiefererNr) on delete cascade,
		constraint fkProdukteLieferer foreign key(ProdukteID) references Produkte(ProduktNummer) on delete cascade
		);
if OBJECT_ID('KundeProdukte')is null
	CREATE TABLE KundeProdukte(
		KundenID int,
		ProdukteID int,
		constraint pkproduktkunde primary key (KundenID, ProdukteID),
		constraint fkKundeProdukte foreign key(KundenID) references Kunde(KundenNR) on delete cascade,
		constraint fkProdukteKunde foreign key(ProdukteID) references Produkte(ProduktNummer) on delete cascade
		);


insert into BenutzerProfil(NutzerName,hash,salt) 
	values('Admin','4t+7Oo9+kYnDNE7qMz73H2Q2ags=','6er58IK7t110BHNJ0DWrmEqqvQS0Gg8w9vhNtlqCCYI=');
Insert into LagerSystem(SystemNr,Lagername) 
	values(1,'Großhandels GmbH Lager');
insert into enthaeltBenutzer(NNr,SysNr) 
	values(1,1);
insert into LAnsprechpartner(AnprechPartnerNummer,AnspAnrede,AnspVorname,AnspNachname,AnpsHandyNummer,AnspEmail,AnspTelefonnummer) 
	values(1,'Herr','Michael','Myers','0456891045','Halloween@Film.de','0789123564'),
	(2,'Frau','Vanessa','Müller','051354328','VanMüller@Handelshaus.de','0635486873'),
	(3,'Herr','Gustav','Schmitt','012456379','GustavS@LiefereiAG.de','0897314323'),
	(4,'Frau','Kerstin','Hoffman','012356445','KerstinHoffman@gmx.de','0531634547'),
	(5,'Herr','Kurt','Schuhmacher','054521378','KurtSchuhmacher@web.de','0132564544'),
	(6,'Frau','Svetlana','Meier','04561012','Svetlana@HandelAG.de','05454312');
insert into Lieferer(LiefererNR,LiefererName,Website,Telefonnummer,EmailaddresseBetrieb,PLZ,Ort,Adresse,Ansprechpartner) 
	values(1,'Film-Handels-Firma GmbH','www.halloween.de','010101323','Filme@Film.de','66111','Saarbrücken','Blumenstraße',1),
	(2,'Handelshaus AG','www.handelshaus.de','0455313153','haus@handelshaus.de','66115','Burbach','Pfaffenkopfstraße', 2),
	(3,'Lieferei AG','www.lieferei.com','01356543','liefern@lieferei.de','66111','Saarbrücken','Gerberstraße',3),
	(4,'Amazon','www.amazon.com','01356464','Amazon@Amazon.de','0000','Washigton, Seatle','',4),
	(5,'Elektronik Lieferei OHG','www.elektro-lieferei.com','046506578','elektro@lieferei.de','66111','Saarbrücken','Ursulinenstraße',5),
	(6,'Handel AG','www.handel.com','01565454','trade@HandelAG.de','66111','Saarbrücken','Beethovenstraße',6)
insert into enthältLieferer(LNR,SysNr) 
	values(1,1),
	(2,1),
	(3,1),
	(4,1),
	(5,1),
	(6,1)
insert into KAnsprechpartner(AnsprechPartnerNummer,AnspAnrede,AnspVorname,AnspNachname,AnpsHandyNummer,AnspEmail,AnspTelefonnummer) 
	values(1,'Sonstiges','Annabelle','','0214666546','Horror@PuppenHandel.de','04564613'),
	(2,'Herr','Friedhelm','Schäfer','06563133','Friedhelm@Bürobedarf.de','021215646'),
	(3,'Frau','Anna','Krause','0743131','Annak@elektro.de','0546464422'),
	(4,'Herr','Harald','Schmitz','012312127','harald@Schokoverkauf.de','079563213'),
	(5,'Frau','Lara','Werner','0155676','Lara@computer.de','045232121'),
	(6,'Sonstiges','Fredrika','Skoda','0442952454','fredrika@media.de','01213568')
insert into Kunde(KundenNr,KundenName,Ort,PLZ, Adresse,EmailaddresseBetrieb,Telefonnummer,Website, Ansprechpartner) 
	values(1,'Puppenhandel GmbH', 'Saarbrücken','66111','Försterstraße','puppen@PuppenHandel.de','0123456789','www.puppen.com',1),
	(2,'Bürobedarf GmbH', 'St.Ingbert','66386','Oststraße','Büros@Bürobedarf.de','046232531','www.büros.com',2),
	(3,'Elektro GmbH', 'Saarbrücken','66111','Schumannstraße','Elektro@elektro.de','05468131','www.elektro.com',3),
	(4,'Schokoverkauf AG', 'Saarbrücken','66111','Sulzbachstraße','schoko@schokoverkauf.de','015645646','www.schokoverkauf.com',4),
	(5,'Computer Ankauf OHG', 'Saarbrücken','66111','Karcherstraße','Com@computer.de','08989431','www.computer.com',5),
	(6,'Media KG', 'Saarbrücken','66111','Grünstraße','med@media.de','021215644','www.media.com',6)
insert into enthältKunde(KNR,SysNr) 
	values(1,1),
	(2,1),
	(3,1),
	(4,1),
	(5,1),
	(6,1);
insert into Produkte(ProduktNummer,ProduktName,ProduktWert) 
	values(1,'Ritter Sport', 2.99), (2,'Milka',1.98), (3,'Schogetten',0.99),
	(4,'Lindt',3.99), (5,'Horror Puppe',65.99), (6,'Marionetten Puppe',199.99),
	(7,'Handpuppe',99.99), (8,'Tusche',9.99), (9,'Füller',12.99), (10,'Federkiel',15.99),
	(11,'Papier A4',3.99), (12,'HDMI-Kabel',19.99), (13,'VGA-Kabel',15.99),
	(14,'LED-Leuchte',4.99), (15,'Monitor',150.99), (16,'Notebook',499.99),
	(17,'Computer',799.99), (18,'Tastatur',55.99), (19,'Spiderman DVD',9.99),
	(20,'Ritter der Kokusnuss DVD',9.99), (21,'Vier Fäuste gegen Rio DVD',9.99)
insert into Waren (ArtikelNr,ProduktNummer,AktBestand,Mindestbestand) 
	values(1,1,50,8), (2,2,100,50), (3,3,200,50), (4,4,150,50), (5,5,1,0), (6,6,10,5), (7,7,100,50),
	(8,8,50,25), (9,9,100,20), (10,10,100,25), (11,11,200,50), (12,12,50,20),
	(13,13,40,10), (14,14,200,100), (15,15,50,10), (16,16,25,5), (17,17,10,4),
	(18,18,40,15), (19,19,19,19), (20,20,250,100), (21,21,90,40)
insert into LiefererProdukte(LiefererID,ProdukteID) 
	values(4,1), (4,2), (4,3), (4,4), (4,5), (4,6), (4,7),
	(4,8), (4,9), (4,10), (4,11), (4,12),(4,13),(4,14),(4,15),
	(4,16),(4,17),(4,18),(4,19),(4,20),(4,21), (1,19),(1,20),(1,21),
	(2,1),(2,2),(2,3),(2,4),(2,8),(2,9),(2,10),(2,11),(2,18),(2,19),(2,20),(2,21),
	(3,5),(3,6),(3,7),(3,12),(3,13),(3,14),(5,12),(5,13),(5,14),(5,15),(5,16),(5,17),
	(5,18),(6,21),(6,20),(6,19),(6,5),(6,9),(6,11),(6,15),(6,7),(6,8),(6,6)
insert into KundeProdukte(KundenID,ProdukteID)
	values(1,5),(1,6),(1,7),(2,8),(2,9),(2,10),(2,11),(3,12),(3,13),(3,14),
	(3,15),(3,16),(4,1),(4,2),(4,3),(4,4),(5,15),(5,16),(5,17),(5,18),(6,19),
	(6,20),(6,21)
