' VB Script Document
function cambiar(nombre)
	imagen = "Imagenes/Botones/" & nombre & "2.jpg"
	if nombre = "inicio" then
		inicio.src = imagen
	end if
	if nombre = "galeria" then
		galeria.src = imagen
	end if
	if nombre = "historia" then
		historia.src = imagen
	end if
	if nombre = "cotizar" then
		cotizar.src = imagen
	end if
end function

function volver(nombre)
	loc = Right(parent.mainFrame.location,len(parent.mainFrame.location)- inStrRev(parent.mainFrame.location,"/"))
	imagen = "Imagenes/Botones/" & nombre & "1.jpg"
	if loc <> "center.html" AND nombre = "inicio" then
		inicio.src = imagen
	end if 
	if loc <> "galeria.html" AND nombre = "galeria" then
		galeria.src = imagen
	end if 
	if loc <> "historia.html" AND nombre = "historia" then
		historia.src = imagen
	end if
	if loc <> "cotizar.html" AND nombre = "cotizar" then
		cotizar.src = imagen
	end if
end function

