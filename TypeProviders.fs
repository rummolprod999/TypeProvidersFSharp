module TypeProvidersFSharp.TypeProviders
open FSharp.Data

let url = "https://fsharp.github.io/FSharp.Data/data/WorldBank.json"
type jsonPr = JsonProvider<"https://fsharp.github.io/FSharp.Data/data/WorldBank.json">

let testJsonPr() =
    let js = jsonPr.Load(url)
    let test = js.Array.[0].Indicator.Id
    printfn "%s" test

let urlH = "https://fsharp.github.io/FSharp.Data/library/HtmlProvider.html"
type htmlPr = HtmlProvider<"https://fsharp.github.io/FSharp.Data/library/HtmlProvider.html">
let testHtmlPr() =
    let html = htmlPr.Load(urlH)
    let test2 = html.Html.Elements().Head.Name()
    printfn "%s" test2

type Detailed = XmlProvider<"""<author><name full="true">Karl Popper</name></author>""">
let testXmlProvider() =
        let info = Detailed.Parse("""<author><name full="false">Thomas Kuhn</name></author>""")
        printfn "%s (full=%b)" info.Name.Value info.Name.Full




