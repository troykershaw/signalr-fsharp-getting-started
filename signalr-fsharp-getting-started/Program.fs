open Customer

[<EntryPoint>]
let main _ =
    let signalr = Signalr.Server "http://localhost:7777"
    let staticServer = Static.Server "http://localhost:8777"

    let rec loop message =
        async {
            signalr.Send message
            do! Async.Sleep 1000
            return! loop message
        }

    {
        Name = "Philip J. Fry"
        Phone = Phone "201 289 654" |> Some
        Email = Email "fry@planetexpress.com" |> Some
        Address =
            {
                Street = "Robot Arms Apartments, Apt 00100100"
                Suburb = "Manhattan"
                City = "New New York"
                ZipCode = ZipCode "10007"
                Planet = "Earth"
            } |> Some
    }
    |> loop
    |> Async.RunSynchronously

    0
