USE [DataBase]
GO

/****** Object:  StoredProcedure [dbo].[ProfesoriToDiscipline]    Script Date: 6/5/2022 2:13:38 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

declare @nr1 int 
declare @prof_id int
declare @counter int = 0
declare @disciplina_id int
declare @disciplina varchar(50)
declare @test varchar(max)
declare @clase varchar(max)
declare @clasa varchar(max)
declare @clasa_id int
declare @n int = 0
declare @m int = 0
declare @total int
declare @ctrl int
select @nr1 = count(id) from Profesori
while(@counter < @nr1)
begin
	set @prof_id = (select id from Profesori order by id offset @counter rows fetch next 1 rows only)
	set @test = (select Disciplina from Profesori where id=@prof_id)
	set @clase = (select Clasa from Profesori where id=@prof_id)
	if(charIndex(',',@test,0) = 0) 
		Begin
			set @disciplina = @test
			set @disciplina_id = (select id_disciplina from Discipline where denumire = @disciplina)
			set @n=0
			set @m=0
			set @total = len(@clase)
			while( @n < @total)
				begin
					if(CHARINDEX(',',@clase,@n)!=0)
						Begin
							set @clasa = (select SUBSTRING(p.Clasa,@n,CharIndex(',',p.Clasa,@n)) from Profesori p where id=@prof_id)
							set @n = CharIndex(',',@clase,@m) + 1 
							set @m = @n
							set @clasa_id = (select id from Clase where Clasa = @clasa)
							/*Insert Into Profesori_Clasa
							values (@prof_id,@clasa_id,@disciplina_id)*/
						End
					else 
						 Begin
							set @clasa = (select Substring(p.Clasa,@n,@total-@n+1) from Profesori p where id=@prof_id)
							set @clasa_id = (select id from Clase where Clasa = @clasa)
							set @n = @total
							/*Insert Into Profesori_Clasa
							values (@prof_id,@clasa_id,@disciplina_id)*/
						 End
				End
			END
	else 
		Begin
			set @n=0
			set @m=0
			set @total = len(@clase)
			set @ctrl = CHARINDEX('/',@clase,0)
			while( @n < @ctrl)
				begin
					if(CHARINDEX(',',@clase,@n)!=0)
						Begin
							set @clasa = (select SUBSTRING(p.Clasa,@n,CharIndex(',',p.Clasa,@n)) from Profesori p where id=@prof_id)
							set @n = CharIndex(',',@clase,@m) + 1 
							set @m = @n
							set @disciplina_id = (select id_disciplina from Discipline where denumire = @disciplina)
							Insert Into ProfDisc
							values (@prof_id,@disciplina_id)
						End
					else 
						 Begin
							set @disciplina = (select Substring(p.Disciplina,@n,@total-@n+1) from Profesori p where id=@prof_id)
							set @disciplina_id = (select id_disciplina from Discipline where denumire = @disciplina)
							set @n = @total
							Insert Into ProfDisc
							values (@prof_id,@disciplina_id)
						 End
				end
		End
	set @counter = @counter +1
end
GO


