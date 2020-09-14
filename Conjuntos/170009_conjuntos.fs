(*
 *  Nombre:     Raul Andres Argott Castro
 *  Matricula:  170009
 *  Carrera:    ITI
 *  Description:  Pasar el codigo de Conjuntos de python a F Sharp
 *
 *  Written:       11/09/2020
 *  Last updated:  13/09/2020
 *
 *  % F#
 *  % F# script
*)
open System


let mutable A = Set.empty
let mutable B = Set.empty
let mutable C = Set.empty:Set<int>

A <- Set.ofList [1; 2; 3; 4; 5]
B <- Set.ofList [3; 4; 5; 6; 7]
C <- Set.empty

printfn "A set is: %A" A
printfn "B set is: %A" B
printfn "C set is: %A" C




// Pertenencia
let pertenencia() =
    printfn "1 in A = %b" (A.Contains(1))
    printfn "1 not in A = %b" (not (A.Contains(1)))
    printfn "1 in A = %b" (A.Contains(10))
    printfn "1 in A = %b" (not (A.Contains(10)))

// Convertir a un conjunto
let transformarConj() = 
    let a = [1;2;3]
    let conjuntoA = Set.ofList a
    printfn "The set is: %A" conjuntoA
    let b = [1;2;3]
    let conjuntoB = Set.ofList b
    printfn "The set is: %A" conjuntoB
    let c = [1;2;3]
    let conjuntoC = Set.ofList c
    printfn "The set is: %A" conjuntoC





// Remove an item from the set
let quitar() = 
    A <- A.Remove 5
    printfn "The set after to delete:  %A " A
    

// Remove all items from the set
let clearSet() = 
    A <- Set.empty
    printfn "The set clear:  %A " A
    
// Copy a set
let copiar() =
   A <- B
   printfn "Set A = %A compare set B = %A" A B


// Add an item
let agregar() = 
    B <- B.Add(987)
    printfn "The set after to delete:  %A " B

/// Set operations
// Union
let union() = 
    printfn "The union  = %A" (Set.union A B)

// Intersection
let interseccion() = 
    printfn "The intersection = %A" (Set.intersect A B)

// Difference
let diferencia() = 
    printfn "The difference = %A" (A-B)
    printfn "The difference = %A" (Set.difference A B)

// Symetric difference
let simetrica() = 
    printfn "The symetryc difference = %A" ((A-B) + (B-A))
    printfn "The symetryc difference = %A" ((B-A) + (A-B))
    printfn "The symetryc difference = %A" ((C-A) + (A-C))
    printfn "The symetryc difference = %A" ((B-C) + (C-B))

// Subset
let subconjunto() = 
    printfn "The subset = %b" (A.IsSubsetOf B)
    printfn "The subset = %b" (B.IsSubsetOf A)

// Superset
let superconjunto() = 
    printfn "The superset = %b" (A.IsSupersetOf B)
    printfn "The superset = %b" (B.IsSupersetOf A)


let main =
    quitar()
    clearSet()
    copiar()
    agregar()
    union()
    interseccion()
    diferencia()
    simetrica()
    subconjunto()
    superconjunto()
    0 // return an integer exit code
