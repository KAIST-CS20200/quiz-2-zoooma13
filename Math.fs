module CS220.Quiz1.Math

open System

/// Modify the function `collatz` in such a way that the function takes in a
/// 32-bit integer, and returns the number of steps it takes to reach 1 in the
/// Collatz sequence.
let rec collatz (n: int) : int =
  if n = 1 then 0
  elif n % 2 = 0 then 1 + collatz (n / 2)
  else 1 + collatz (3 * n + 1)