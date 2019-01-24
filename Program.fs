
module TypeProvidersFSharp.Providers
open TypeProvidersFSharp.TypeProviders

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    testJsonPr()
    testHtmlPr()
    testXmlProvider()
    0 // return an integer exit code
