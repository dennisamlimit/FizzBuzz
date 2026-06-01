# FizzBuzz

A small but unnecessarily optimized FizzBuzz implementation in C#.

This project was built with one simple goal:

> Beat my classmate's FizzBuzz implementation.

His README says:

> "According to my benchmarks this is up to 50% faster"

So naturally, I had to respond.

## What makes this version different?

Instead of using the classic approach with modulo checks and direct console output, this implementation focuses on reducing unnecessary operations.


## Why?

Because normal FizzBuzz is too easy.

And because sometimes the real challenge is not solving the problem, but making it faster than your classmate's version.


## Disclaimer

This is not meant to be the most readable FizzBuzz implementation ever written.

It is meant to be a small optimization experiment, a benchmark playground, and a friendly competitive answer to another implementation.

## Benchmark

Benchmarks were run using BenchmarkDotNet in Release mode on .NET 10.

| Method | Mean | Allocated | Ratio |
|---|---:|---:|---:|
| Classmate original implementation | 118.26 ns | 1288 B | 1.00 |
| Classmate fixed Count implementation | 118.95 ns | 1280 B | 1.01 |
| My optimized implementation | 85.18 ns | 832 B | 0.72 |

Compared to the fixed version of my classmate's implementation, my version reduces runtime by about **28%** and memory allocations by about **35%**.

The original implementation also contains a small off-by-one bug in its `Count` property, causing it to write one extra character.


