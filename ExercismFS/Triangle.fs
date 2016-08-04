module Triangle

open System

type TriangleKind =
    | Equilateral
    | Isosceles
    | Scalene

let allSidesPositiveNumber (a: decimal) (b: decimal) (c: decimal) =
    a > 0m && b > 0m && c > 0m

let meetsTriangleInequalityRules (a: decimal) (b: decimal) (c: decimal) =
    a + b > c && b + c > a && c + a > b

let allSidesEqual (a: decimal) (b: decimal) (c: decimal) = 
    a = b && b = c

let noSidesEqual a b c =
    a <> b && b <> c && a <> c

let isValidTriangle (a: decimal) (b: decimal) (c: decimal) =
    allSidesPositiveNumber a b c && 
    meetsTriangleInequalityRules a b c

let kind (a: decimal) (b: decimal) (c: decimal) =
    if isValidTriangle a b c then
        match (a, b, c) with
        | (a, b, c) when noSidesEqual a b c -> TriangleKind.Scalene
        | (a, b, c) when allSidesEqual a b c -> TriangleKind.Equilateral
        | _ -> TriangleKind.Isosceles
    else
        raise (InvalidOperationException())

