namespace MyCompany.MyApp

open System
open Constructs
open HashiCorp.Cdktf

module Program =

    [<EntryPoint>]
    let main argv =
        let app = App()
        let _ = MainStack(app, "learn-cdktf")
        app.Synth()
        Console.WriteLine("App synth complete")
        0 // Return an integer exit code

