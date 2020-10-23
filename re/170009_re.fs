// Learn more about F# at http://fsharp.org

open System
open System.Text.RegularExpressions

let mutable tokens = []
let sourceCode = "int result = 1;".Split(' ')

for word in sourceCode do
    if List.exists ((=)word) ["str"; "int"; "bool"] then
        tokens <- List.append tokens [word]
    elif Regex.IsMatch(word, "[A-Za-z]") then
        tokens <- List.append tokens [word]
    elif List.exists ((=)word) ["*";"-";"/";"+";"%";"="] then
        tokens <- List.append tokens [word]
    elif Regex.IsMatch (word,"[0-9]") then
        if word.[word.Length - 1] = ';' then
            tokens <- List.append tokens [word.[0..(word.Length-1)]]
            tokens <- List.append tokens [";"]
        else
            tokens <- List.append tokens [word]


printfn "%A" tokens 
    
let variablePROLOG(w : byref<string>) : bool= 
    if (Char.IsLetter(w.[0]) && Char.IsUpper(w.[0]) || w.[0] = '_') then 
        w <- w.[1..(w.Length-1)]
        while (not (String.IsNullOrEmpty(w)) && (Char.IsNumber w.[0] || w.[0] = '_')) do
            w <- w.[1..(w.Length-1)]
    String.IsNullOrEmpty(w)    
            
[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    0 // return an integer exit code
