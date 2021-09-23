// Más información acerca de F# en http://fsharp.org
// Vea el proyecto "Tutorial de F#" para obtener más ayuda.

open System 

let listam a b =[for i in 1..a -> b]
let a = 6
let b = 7
let lista = listam a b
printfn "dado 2 numeros" 
printfn "%d " a
printfn "%d " b
printfn "la multiplicacion es" 
let suma = List.sum lista
printfn "%d " suma

Console.Read()