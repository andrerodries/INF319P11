// Más información acerca de F# en http://fsharp.org
// Vea el proyecto "Tutorial de F#" para obtener más ayuda.

open System
let lista = [ 1; 2; 3; 4; 5; 6; 7; 8; 9; 10 ]

printfn "NUMEROS DE LA LISTA"
for i in lista do
    printf "%i " i 
printfn "" 
let par i = i%2=0
let impar i = i%2<>0
printfn "pares"
for i in lista do
    let r = par i
    if r then printf "%i " i  
printfn ""       
printfn "impares"
for i in lista do
    let r = impar i
    if r then printf "%i " i 
        
Console.Read()
