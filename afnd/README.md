# AFND

## Descripción

Programa de F Sharp que simula un automata finito con entradas definidas por expresiones regulares.
En este caso se implementará un automata no deterministico con la siguiente definicion:

    L(r) = a*ba*(c+d)
    L(a*) = {ε,a,aa,aaa,aaaa,...}
    L(b) = {b}
    L(c+d) = {c,d}
    L(r) = {bc,bd,abc,abd,bca,bda,abca,abda,aabca,...}

## Ejecucuón


1. Ejecutando el proyecto con run
    Para esto se debe ingresar en la consola dentro de la carpeta Conjuntos la siguiente luinea:

        dotnet run 170009_afnd.fs

    En esta ejecucion se imprimiran los resultados de todas las funciones a la vez y en el orden en el que se encuentran escritas en el main
