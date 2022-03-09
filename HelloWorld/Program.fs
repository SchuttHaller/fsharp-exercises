// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System

// Define a function to construct a message to print
let from whom =
    sprintf "from my %s program!" whom

[<EntryPoint>]
let main argv = 
    let mutable person = "Annon"
    if argv.Length > 0 then
        person <- argv.[0]
    let message = from "F#" // Call the function
    printfn "Hello %s world %s" person message
    printfn "The args are %A" argv
    0