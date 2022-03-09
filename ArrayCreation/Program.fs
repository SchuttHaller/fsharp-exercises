open System

[<EntryPoint>]
let main argv =

    let numbers =
        [| for i in 0..4 -> pown 2 i |]

    printfn "%A" numbers 

    let isEven x =
        x % 2 = 0

    let evenNumbers =
        [| 
            for i in 1..9 do 
                let x = i * i
                if x |> isEven then
                    x
        |]

    printfn "%A" evenNumbers 

    let total =
        [| for i in 1..1000 -> i * i |]
        |> Array.sum

    printfn "The total is: %i" total 

    0

