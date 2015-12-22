module Static

open Owin
open Microsoft.Owin.Hosting

type Server (host:string) =
    let startup (a:IAppBuilder) =
        a.UseFileServer(true) |> ignore

    do
        WebApp.Start(host, startup) |> ignore
        printfn "Static server running on %s" host
