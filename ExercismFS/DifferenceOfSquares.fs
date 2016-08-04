module DifferenceOfSquares

let square n = n * n

let squareOfSums n =
    [1..n] |> List.sum |> square

let sumOfSquares n =
    [1..n] |> List.map square |> List.sum

let difference n =
    (squareOfSums n) - (sumOfSquares n)

