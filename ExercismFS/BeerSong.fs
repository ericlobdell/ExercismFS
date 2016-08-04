module BeerSong

let getLineEnding lineNumber =
    let bottles = if lineNumber = 2 then "bottle" else "bottles"
    match lineNumber with
    | n when n = 0 -> "99 bottles of beer on the wall"
    | n when n = 1 -> "no more bottles of beer on the wall"
    | _ -> sprintf "%d %s of beer on the wall" (lineNumber - 1) bottles

let verse lineNumber =  
    let bottles = if lineNumber = 1 then "bottle" else "bottles"
    let oneOrIt = if lineNumber = 1 then "it" else "one"
    if lineNumber = 0 then 
       sprintf  "No more bottles of beer on the wall, no more bottles of beer.\nGo to the store and buy some more, %s.\n" (getLineEnding lineNumber)
    else
        sprintf "%d %s of beer on the wall, %d %s of beer.\nTake %s down and pass it around, %s.\n" lineNumber bottles lineNumber bottles oneOrIt (getLineEnding lineNumber)

let verses start finish =
    let range = if start > finish then [finish..start] else [start..finish]
    let lines = range
                |> List.map (fun lineNumber -> verse lineNumber )
                |> List.rev
                |> String.concat "\n"

    sprintf "%s%s" lines "\n"

let sing = verses 99 0


