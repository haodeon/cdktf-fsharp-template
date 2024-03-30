namespace MyCompany.MyApp

open System
open Constructs
open HashiCorp.Cdktf

type MainStack(scope: Construct, id: string) =
    inherit TerraformStack(scope, id)
    // define resources here

