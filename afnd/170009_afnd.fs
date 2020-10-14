(*
 *  Nombre:     Raul Andres Argott Castro
 *  Matricula:  170009
 *  Carrera:    ITI
 *  Description:  Simular un atomata no deterministico con el lenguaje a*ba*b
 *
 *  Written:       5/10/2020
 *  Last updated:  6/10/2020
 *
 *  % F#
 *  % F# script
*)
open System
open System.Text.RegularExpressions

let mutable simbolo:string = null
let mutable fin:string = null


//L(r) = a*ba*(c+d)
//L(a*) = {ε,a,aa,aaa,aaaa,...}
//L(b) = {b}
//L(c+d) = {c,d}

let caracter (character) : int = 
    simbolo <- ""
    fin <- ""
    let mutable aAsterisco = "a"
    let mutable b = "b"
    let mutable cMasD = "c|d"
    let mutable x:char = 'e'

    if Regex.IsMatch(character, aAsterisco) then
        simbolo <- "a*"
        0
    elif Regex.IsMatch(character, b) then
        simbolo <- "b"
        1
    elif Regex.IsMatch(character, cMasD) then
        simbolo <- "(c+d)"
        2
    elif character.Equals(fin) then 
        3
    else 
        printfn "Caracter no valido"
        4
    
let cuerpo() = 
    printfn "+-----------------------+-----------------------+-----------------------+-----------------------+"

let contenido (estadoSiguiente, character, simbolo,estado) = 
    printfn "|\t    %i    \t|\t    %c    \t|\t   %s    \t|\t %i\t|" estadoSiguiente character simbolo estado
    cuerpo()

let encabezado() = 
    printfn "|\tEdo. Actual\t|\tCaracter\t|\tSimbolo   \t|\tEdo. Siguiente\t|"
    cuerpo()
    
// estados 1,2
// error 5
// aceptacion 4
let tabla = [[0;1;5;5]; [1;2;2;5];[5;5;5;4]]

let mutable estado = 0
printfn """+-------------------------------------+
|    Ingrese una cadena a evaluar:    |
+-------------------------------------+"""
let cadena = Console.ReadLine()
cuerpo()
encabezado()
let mutable charcaracter = 4
for character in cadena do
    let mutable estadoSiguiente = estado
    charcaracter <- caracter(string character)
    if charcaracter < 4 then
        estado <- tabla.[estado].[charcaracter]
        if estado = 5 then
            printfn "|     %i      |  %c    |%s |     %i       |" estadoSiguiente character simbolo estado
            cuerpo()
            printfn """|                                    Cadena No Valida
    +-----------------------+-----------------------+-----------------------+-----------------------+"""
        contenido(estadoSiguiente, character, simbolo, estado)
if estado <> 2 then
    printfn """|                                    Cadena No Valida
+-----------------------+-----------------------+-----------------------+-----------------------+"""
if estado = 2 && charcaracter < 4 then
    printfn "|\t    %i    \t|\t          \t|\tFin Cadena\t|\t   \t|" estado
    cuerpo()
    printfn """|                                    Cadena Valida
+-----------------------+-----------------------+-----------------------+-----------------------+"""
         // return an integer exit code
