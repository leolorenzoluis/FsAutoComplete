module X =
  let func x = x + 1

let testval = FileTwo.NewObjectType()

let val2 = X.func 2

let val3 = testval.Terrific "hello"

let val4 = X.func "yo"

[<EntryPoint>]
let main args =
    printfn "Hello %d" val2
    0
