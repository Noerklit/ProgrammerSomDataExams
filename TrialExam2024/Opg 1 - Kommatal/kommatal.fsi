
module Kommatal_fslex
open FSharp.Text.Lexing
open System/// Rule Tokenize
val Tokenize: lexbuf: LexBuffer<char> -> token
