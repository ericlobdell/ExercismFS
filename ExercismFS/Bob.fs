module ExercismFS

open System
open System.Text.RegularExpressions

let IsEmpty (s:string) = String.IsNullOrWhiteSpace(s)

let IsAllCaps (s:string) = String.Equals( s, s.ToUpper())

let IsAllNumbers (s:string) =
    let rgx = new Regex(@"[\s,?!]")
    let stripped = rgx.Replace(s, "") 
    let result: int = 0
    Int32.TryParse(stripped, ref result)

let IsExclaimation (s:string) : bool =
   ( IsAllCaps s ) && not ( IsAllNumbers s )

let IsQuestion (s:string) = 
    s.EndsWith("?") && not (IsExclaimation s)

type Bob( phrase : string ) = 
    let sut = phrase.Trim()

    member this.hey() =
        if IsEmpty sut then "Fine. Be that way!"
        else if IsQuestion sut then "Sure."
        else if IsExclaimation sut then "Whoa, chill out!"
        else "Whatever."