let unorderedList = [4; 7; 2; 0; 9; 1; 6; 7; 5; 4; 3; 8; 6]

let rec quicksort list =
    match list with
    | [] -> []
    | head :: tail ->
        let smaller, larger =
            List.partition (fun item -> item < head) tail
        quicksort smaller @ head :: quicksort larger

let orderedList = quicksort unorderedList
printfn "Unordered List: %A" unorderedList
printfn "Ordered List:   %A" orderedList

open System
Console.ReadKey(false) |> ignore



