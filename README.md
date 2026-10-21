# Biblioteca (C# · Windows Forms)

Aplicación de escritorio para gestionar una pequeña biblioteca, hecha como práctica de la asignatura de Interfaces (2º DAM).

## Funcionalidades
- **Alta de libros**: título, autor, editorial, si es nuevo y portada (JPG).
- **Consulta**: listado de títulos con la portada del libro seleccionado, y listado de autores o editoriales.
- Interfaz MDI con menú y atajos de teclado, ventanas hijas y reloj en la barra de estado.
- Confirmación al cerrar la aplicación.

## Tecnologías
C# · .NET Framework 4.7.2 · Windows Forms · Visual Studio

## Cómo ejecutarlo
1. Clona el repositorio.
2. Abre `Biblioteca/Biblioteca.sln` con Visual Studio (solo Windows).
3. Pulsa F5 para compilar y ejecutar.

## Nota
Los datos se guardan en memoria mientras la aplicación está abierta; las portadas se guardan en la carpeta `imagenes` junto al ejecutable.

## Capturas
![Menú principal](capturas_biblioteca/menu.png)
![Alta de libros](capturas_biblioteca/alta.png)
![Consulta de libros](capturas_biblioteca/consulta.png)
