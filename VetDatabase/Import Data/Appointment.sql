insert  Appointment ( VetID, PetID, [Date], [Time], Reason) values (4, 1, '2018-08-03', '10:42 PM', 'Insert Reason Here');
insert  Appointment ( VetID, PetID, [Date], [Time], Reason) values (2, 2, '2020-07-23', '5:31 PM', 'Insert Reason Here');
insert  Appointment ( VetID, PetID, [Date], [Time], Reason) values (3, 3, '2022-08-01', '1:05 AM', 'Insert Reason Here');
insert  Appointment ( VetID, PetID, [Date], [Time], Reason) values (4, 4, '2018-09-24', '2:43 PM', 'Insert Reason Here');
insert  Appointment ( VetID, PetID, [Date], [Time], Reason) values (5, 5, '2020-01-14', '9:21 PM', 'Insert Reason Here');
insert  Appointment ( VetID, PetID, [Date], [Time], Reason) values (6, 6, '2021-04-11', '7:52 PM', 'Insert Reason Here');
insert  Appointment ( VetID, PetID, [Date], [Time], Reason) values (9, 7, '2023-01-28', '3:50 AM', 'Insert Reason Here');
insert  Appointment ( VetID, PetID, [Date], [Time], Reason) values (8, 8, '2020-07-30', '11:27 AM', 'Insert Reason Here');
insert  Appointment ( VetID, PetID, [Date], [Time], Reason) values (9, 9, '2022-11-24', '5:38 AM', 'Insert Reason Here');
insert  Appointment ( VetID, PetID, [Date], [Time], Reason) values ( 10, 10, '2018-11-01', '10:31 PM', 'Insert Reason Here');
insert  Appointment ( VetID, PetID, [Date], [Time], Reason) values ( 11, 11, '2018-11-15', '11:34 PM', 'Insert Reason Here');
insert  Appointment ( VetID, PetID, [Date], [Time], Reason) values ( 12, 12, '2021-01-10', '11:45 AM', 'Insert Reason Here');
insert  Appointment ( VetID, PetID, [Date], [Time], Reason) values ( 13, 13, '2020-09-26', '1:14 PM', 'Insert Reason Here');
insert  Appointment ( VetID, PetID, [Date], [Time], Reason) values ( 14, 14, '2022-03-06', '7:05 PM', 'Insert Reason Here');
insert  Appointment ( VetID, PetID, [Date], [Time], Reason) values ( 15, 15, '2022-08-17', '7:34 PM', 'Insert Reason Here');
insert  Appointment ( VetID, PetID, [Date], [Time], Reason) values ( 10, 16, '2019-09-10', '12:39 PM', 'Insert Reason Here');
insert  Appointment ( VetID, PetID, [Date], [Time], Reason) values ( 17, 17, '2019-05-30', '12:46 AM', 'Insert Reason Here');
insert  Appointment ( VetID, PetID, [Date], [Time], Reason) values ( 18, 18, '2022-07-14', '9:41 AM', 'Insert Reason Here');
insert  Appointment ( VetID, PetID, [Date], [Time], Reason) values ( 19, 19, '2019-12-13', '12:15 PM', 'Insert Reason Here');
insert  Appointment ( VetID, PetID, [Date], [Time], Reason) values ( 20, 20, '2019-09-18', '12:12 AM', 'Insert Reason Here');

SELECT * FROM Appointment
	INNER JOIN Vet V ON V.VetID = Appointment.VetID
