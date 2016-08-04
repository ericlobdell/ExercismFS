module SpaceAge

open System

type Planet =
    | Earth
    | Mercury 
    | Venus
    | Mars
    | Jupiter
    | Saturn
    | Uranus
    | Neptune

let earthYearInSeconds = 31557600m

let planetYearInSeconds planet =
    match planet with
    | Planet.Earth -> earthYearInSeconds
    | Planet.Mercury -> earthYearInSeconds * 0.2408467m
    | Planet.Venus -> earthYearInSeconds * 0.61519726m
    | Planet.Mars -> earthYearInSeconds * 1.8808158m
    | Planet.Jupiter -> earthYearInSeconds * 11.862615m
    | Planet.Saturn -> earthYearInSeconds * 29.447498m
    | Planet.Uranus -> earthYearInSeconds * 84.016846m
    | Planet.Neptune -> earthYearInSeconds * 164.79132m
    | _ -> 0m

let spaceAge planet seconds =
    let ageOnPlanet = seconds / planetYearInSeconds planet
    Math.Round( ageOnPlanet, 2 )