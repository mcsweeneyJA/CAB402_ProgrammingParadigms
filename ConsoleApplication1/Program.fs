

//Factorial function
let rec fact x =
    if x < 1 then 1 else x * fact(x-1)


//Fibonacci 
let rec fib n =
    if n < 2 then n else fib(n-1) + fib(n-2)

//Ackermann function (dont go over 4,0) or stack overload
let rec ackermann x y =
    if x = 0 then (y + 1)
    elif y = 0 then ackermann (x - 1) 1
    else ackermann (x - 1) (ackermann x (y - 1))

//lucas number
let rec lucas n =
    if n = 0 then 2
    elif n = 1 then 1
    else  lucas(n-1) + lucas(n-2)
   
    