module CS220.Quiz1.Math

open System

/// Modify the function `collatz` in such a way that the function takes in a
/// 32-bit integer, and returns the number of steps it takes to reach 1 in the
/// Collatz sequence.
let collatz (n: int) : int =
    let rec tail (n: int64) (steps: int) : int =
        if n = 1 then steps
        elif n % 2L = 0 then tail (n / 2L) (steps + 1)
        else tail (3L * n + 1L) (steps + 1)
    tail n 0
