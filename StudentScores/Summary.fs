namespace StudentScores

module Summary = 

    open System.IO

    let printGroupSummary (surname: string) (students: Student[]) = 
        printfn "%s" (surname.ToUpperInvariant())
        students
        |> Array.sortBy (fun student -> student.GivenName, student.Id)
        |> Array.iter (fun student ->
            printfn "\t%20s\t%s\t%0.1f\t%0.1f\t%0.1f"
                student.GivenName student.Id student.MeanScore student.MinScore student.MaxScore)

    let summarize filePath =
        let rows = File.ReadAllLines filePath
        let studentCount = (rows |> Array.length) - 1
        printfn "Student count: %i" studentCount
        rows
        |> Array.skip 1
        // Convert each line to a student instance
        |> Array.map Student.fromString
        // Sort by mean score (descending)
        |> Array.sortByDescending (fun student -> student.MeanScore)
        // Print each Student instance
        |> Array.iter Student.printSummary

    let groupSummarize filePath =
        let rows = File.ReadAllLines filePath
        let studentCount = (rows |> Array.length) - 1
        printfn "Student count: %i" studentCount
        rows
        |> Array.skip 1
        // Convert each line to a student instance
        |> Array.map Student.fromString
        // Group by surname
        |> Array.groupBy (fun s -> s.Surname)
        // Sort
        |> Array.sortBy fst 
        // Print each Student instance
        |> Array.iter (fun (surname, students) -> printGroupSummary surname students)