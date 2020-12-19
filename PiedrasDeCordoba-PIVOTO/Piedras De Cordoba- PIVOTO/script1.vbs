
function actualizar()
	cframe = Right(location,len(location)- inStrRev(location,"/"))
	if( inStrRev(cframe,"#") <> 0) then
		cframe = Left(cframe,len(cframe) - (len(cframe)- inStrRev(cframe,"#")) - 1)
	end if
	volverbotones(cframe)
end function

function volverbotones(cframe)
	if cframe <> "center.html" then
		parent.leftFrame.inicio.src = "Imagenes/Botones/inicio1.jpg"
	else
		parent.leftFrame.inicio.src = "Imagenes/Botones/inicio2.jpg"
	end if
	if cframe <> "galeria.html" then
		parent.leftFrame.galeria.src = "Imagenes/Botones/galeria1.jpg"
	else
		parent.leftFrame.galeria.src = "Imagenes/Botones/galeria2.jpg"
	end if
	if cframe <> "historia.html" then
		parent.leftFrame.historia.src = "Imagenes/Botones/historia1.jpg"
	else
		parent.leftFrame.historia.src = "Imagenes/Botones/historia2.jpg"
	end if
	if cframe <> "cotizar.html" then
		parent.leftFrame.cotizar.src = "Imagenes/Botones/cotizar1.jpg"
	else
		parent.leftFrame.cotizar.src = "Imagenes/Botones/cotizar2.jpg"
	end if
end function