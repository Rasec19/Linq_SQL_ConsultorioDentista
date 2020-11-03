select Dentistas.Nombre as Dentista,Especialidades.Nombre as Especialidad, Dentistas.Edad as Edad, Dentistas.Telefono as Telefono, Dentistas.Direccion as Direccion 
from Citas INNER JOIN Dentistas on Citas.Id_Cita = Dentistas.Id_Dentista
	INNER JOIN Especialidades on Citas.Id_Especialidad = Especialidades.Id_Especialidad