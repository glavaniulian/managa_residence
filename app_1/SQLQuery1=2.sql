

insert into logare(dbo.id,dbo.nume,prenume,adresa,data_nasterii,sex,functie,email,parola,descriere,poza)
select 4,'Albu','Ioan','Calea Mosilor, Numarul 6, Bloc M120, Scara 1, Apartament 5, Etaj 1, Sector 5','1984-12-01','Masculin','Manager','alguioan@gmail.com','1234','-',BulkColumn from openrowset(bulk 'C:\Users\IULIAN-DANIELGLAVAN\Desktop\app_1\bd\4.jpg',single_blob) as image

select * from logare;

