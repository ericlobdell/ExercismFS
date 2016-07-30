module SumOfMultiples

let isMultiple n x =
    x % n = 0

let isMultipleOfAny ns x =
    List.exists (fun n -> isMultiple n x ) ns

let sumOfMultiples ns x =
    [2..(x - 1)]
    |> List.filter ( fun n -> isMultipleOfAny ns n )
    |> List.sum 
