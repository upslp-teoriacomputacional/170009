# AFD

## Descripción

Programa de F Sharp que simula un automata finito con entradas definidas por expresiones regulares

## Ejecucuón

Para ejecutarlo hay dos opciones:
1. Ejecutando el proyecto con run
    Para esto se debe ingresar en la consola dentro de la carpeta Conjuntos la siguiente luinea:

        dotnet run 170009_afd.fs

    En esta ejecucion se imprimiran los resultados de todas las funciones a la vez y en el orden en el que se encuentran escritas en el main
2. Ejecutando el script con FSI

    Para esto se debe seleccionar todo el codigo (Control + ALT).

    Luego se debe mandar al FSI (ALT + Enter)

    Esto compilara el codigo y lo unico que se debe hacer es escribir la funcion que se desea utilizar en la consola con ;; al final. Ejemplo:
    
        quitar();;