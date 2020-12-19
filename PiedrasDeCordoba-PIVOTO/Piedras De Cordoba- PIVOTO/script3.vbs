' VB Script Document
t1="98px"
t2="527px"
t3="924px"
t4="1319px"
t5="1715px"
function asignar(nombre,t,layerT,layerI)
	document.getElementById(layerT).style.visibility = "visible"
	document.getElementById(layerI).style.visibility = "visible"
	document.getElementById(layerT).style.top=t
	document.getElementById(layerI).style.top=t
	textoI = crearTexto(nombre)
	textoT = leerTexto(nombre)
	document.getElementById(layerT).innerHTML= textoT
	document.getElementById(layerI).innerHTML= textoI
end function

function crearTexto(nombre) 
	crearTexto = "<img src=Imagenes/Fotos/"&nombre&".jpg "&"name=foto width=400 height=300/>"
end function

function leerTexto(nombre)
	if inStr(Lcase(nombre),"ceniceros") then
		leerTexto = "Estos Son Ceniceros"
	end if
	if inStr(Lcase(nombre),"bachas") then
		leerTexto = "Estas Son Bachas"
	end if
	if inStr(Lcase(nombre),"esculturas") then
		leerTexto = "Estas Son Esculturas"
	end if
	if inStr(Lcase(nombre),"morteros") then
		leerTexto = "Estos Son Morteros"
	end if
	if inStr(Lcase(nombre),"institucionales") then
		leerTexto = "Estos Son Escudos Institucionales"
	end if
end function

function sacar(nombre)
	Layer1.style.visibility = "hidden"'
	Layer2.style.visibility = "hidden"'
end function

function abrir(nombre)
	imagen = "Imagenes/Fotos/" & nombre &".jpg"
	window.open imagen,nombre,"toolbar=0, menubar=0, status=1, location=0, width=430, height=330"
end function
