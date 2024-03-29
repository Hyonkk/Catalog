USE [DataBase]
GO
/****** Object:  StoredProcedure [dbo].[ProfesoriToDiscipline]    Script Date: 6/5/2022 2:51:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[ProfesoriToDiscipline]
as
declare @nr1 int 
declare @prof_id int
declare @counter int = 0
declare @disciplina_id int
declare @disciplina varchar(50)
declare @test varchar(max)
select @nr1 = count(id) from Profesori
while(@counter < @nr1)
begin
	set @prof_id = (select id from Profesori order by id offset @counter rows fetch next 1 rows only)
	set @test = (select Disciplina from Profesori where id=@prof_id)
	if(charIndex(',',@test,0) = 0) 
		Begin
			set @disciplina = @test
			set @disciplina_id = (select id_disciplina from Discipline where denumire = @disciplina)
			insert into ProfDisc
			values (@prof_id,@disciplina_id)
		End
	else 
		Begin
			declare @n int = 0
			declare @m int = 0
			declare @total int = len(@test)
			while( @n < @total)
				begin
					if(CHARINDEX(',',@test,@n)!=0)
						Begin
							set @disciplina = (select SUBSTRING(p.Disciplina,@n,CharIndex(',',p.Disciplina,@n)) from Profesori p where id=@prof_id)
							set @n = CharIndex(',',@test,@m) + 1 
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
