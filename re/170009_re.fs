(*
 *  Nombre:     Raul Andres Argott Castro
 *  Matricula:  170009
 *  Carrera:    ITI
 *  Description:  Expresion regular
 *
 *  Written:       22/10/2020
 *
 *  % F#
 *  % F# script
*)
open System
open System.Text.RegularExpressions

let mutable tokens = []
let sourceCode = "int result = 1;".Split(' ')

//recorrido de la cadena
for word in sourceCode do
    if List.exists ((=)word) ["str"; "int"; "bool"] then //evalua el DATATYPE
        tokens <- List.append tokens [word]
    elif Regex.IsMatch(word, "[A-Za-z]") then //EVALUA EL NOMBRE DE VARIABLE
        tokens <- List.append tokens [word]
    elif List.exists ((=)word) ["*";"-";"/";"+";"%";"="] then //EVALUA OPERADOR
        tokens <- List.append tokens [word]
    elif Regex.IsMatch (word,"[0-9]") then //EVALUA EL DATO
        if word.[word.Length - 1] = ';' then
            tokens <- List.append tokens [word.[0..(word.Length-2)]]
            tokens <- List.append tokens [";"]
        else
            tokens <- List.append tokens [word]


printfn "%A" tokens 
    
//Evaluacion del nombre de una variable    
let variablePROLOG(w : byref<string>) : bool= 
    if (Char.IsLetter(w.[0]) && Char.IsUpper(w.[0]) || w.[0] = '_') then 
        w <- w.[1..(w.Length-1)]
        while (not (String.IsNullOrEmpty(w)) && (Char.IsNumber w.[0] || w.[0] = '_')) do
            w <- w.[1..(w.Length-1)]
    String.IsNullOrEmpty(w)    
            
