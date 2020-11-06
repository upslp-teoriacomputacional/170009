// inicio

open System

let mutable esPalindrom = true //bandera de palindromo
printf "Ingrese cadena: " 
let cadena = Console.ReadLine() //lectura de cadena en consola

// let cadena = "anita lava la tina"

let stripv3 (stripChars:string) (text:string) =
    text.Split(stripChars.ToCharArray(), StringSplitOptions.RemoveEmptyEntries) |> String.Concat // regresa cadena sin espacios

let cadenaSinEspacios = stripv3 " " cadena //obtiene cadena sin espacios 
let palindromo = Seq.toArray cadenaSinEspacios //convierte string a arreglo de caracteres

let mitad = int(floor( float(palindromo.Length/2))) //obtiene la mitad (piso) de la longitud de la cadena

let mutable memoria:char[] = Array.zeroCreate mitad //memoria para comparar

for i = 0 to mitad-1 do
    // printfn "%c" palindromo.[i]
    Array.set memoria i (palindromo.[i])  //guarda la mitad de la cadena
 
// printfn "-------"
let mutable index = 0
for j = palindromo.Length-1 downto (palindromo.Length-memoria.Length) do
    // printfn "%c" palindromo.[j]
    if palindromo.[j] <> memoria.[index] then // evalua la mitad de la cadena con la otra mitad a la inversa
        esPalindrom <- false // si no coincide un caracter cambia bandera
    index <- index+1

if esPalindrom then // evalua bandera
    printfn "La cadena %s es palindromo " cadena
else
    printfn "La cadena %s no es palindromo" cadena


//fin
