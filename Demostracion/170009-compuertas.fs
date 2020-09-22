(*
 *  Nombre:     Raul Andres Argott Castro
 *  Matricula:  170009
 *  Carrera:    ITI
 *  Description:  Pasar el codigo de Conjuntos de python a F Sharp
 *
 *  Written:       21/09/2020
 *  Last updated:  21/09/2020
 *
 *  % F#
 *  % F# script
*)
(*
    La variable x recorrerá la lista booleanos, tomando en la primera iteración el valor False y en la siguiente True. 
    Pero, por cada iteración, aparece una nueva variable y que también recorrerá booleanos de izquierda a derecha. 
    Así garantizamos que se alcanzan las cuatro combinaciones posibles de x e y.
    En la impresión con print, hemos empleado el argumento sep = ‘t’ para que separe cada elemento mediante un tabulador, 
    en lugar de usar un espacio en blanco, valor por omisión. Aprecia el uso de la expresión x or y para que muestre el resultado del or.
    El resto de las tablas se calcula del mismo modo, simplemente teniendo en cuenta que hay que emplear, naturalmente, 
    la expresión lógica adecuada.
    Debes saber que los operadores lógicos de Python son del tipo cortocircuitados, término que quizás te resulte familiar 
    si conoces otros lenguajes de programación. Esto significa que, si a partir del primer operando ya se puede deducir el 
    resultado final, Python ni se molestará en evaluar el segundo, con el consiguiente ahorro de tiempo.
    En un or, si el primer operando es verdadero, sabemos que el resultado lo será ya, por lo que no es necesario que Python 
    se moleste en comprobar la veracidad del segundo.
    Del mismo modo, en un and, si el primer operando es falso, el resultado inmediatamente lo será y tampoco será necesario 
    saber lo que ocurre con el segundo.
    Para finalizar, una pequeña advertencia: es un error común confundir los operadores lógicos (or y and) con los operadores 
    de unión e intersección de conjuntos (| y &).
*)
open System


let booleanos = [false; true]

// Tabla de verdad de or
printfn "x\ty\tx or y"
printfn "----------------------"
for x in booleanos do
    for y in booleanos do 
        printfn "%b\t %b\t%b" x y (x || y)
printfn ""

// Tabla de verdad de and
printfn "x\ty\tx and y"
printfn "----------------------"
for x in booleanos do
    for y in booleanos do 
        printfn "%b\t %b\t%b" x y (x && y)
printfn ""

// Tabla de verdad de not
printfn "x\tnot x"
printfn "-------------"
for x in booleanos do
    printfn "%b\t%b" x (not x)
printfn ""

// Tabla de verdad de xor
printfn "x\ty\tx ^ y"
printfn "----------------------"
for x in booleanos do
    for y in booleanos do 
        // printfn "%b\t %b\t%b" x y ((x || y) && not (x && y))
        printfn "%b\t %b\t%b" x y (x <> y) // desigualdad da los mismos resultados que xor
printfn ""