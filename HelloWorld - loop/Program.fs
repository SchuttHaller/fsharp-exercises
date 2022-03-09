// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System

// Define a function to construct a message to print
let hello whom =
    sprintf "Hello %s" whom

let sayHello person =
    printfn "Hello %s from my F# program!" person

[<EntryPoint>]
let main argv = 
    // ----
    for i in 0..argv.Length-1 do
        let person = argv.[i]
        let message = hello person // Call the function
        printfn "%s from my F# program!" message
    // -----
    for person in argv do
        let message = hello person // Call the function
        printfn "%s from my F# program!" message
    // -------
    Array.iter sayHello argv

    printfn "Nice to meet you."
    0