module ExercismFS

open System

let IsAllCaps (s:string) = String.Equals( s, s.ToUpper())
let IsQuestion (s:string) = s.EndsWith("?")

type Bob( phrase : string ) = 

    member this.hey() =
        "Whatever."


    