let mutable x = 10

let addOne () = 
    x <- x + 1

let result = addOne ()
printf "%d %d" x result