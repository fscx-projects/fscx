namespace FSharp.Expandable

open System
open System.Linq
open System.IO

open Persimmon
open Persimmon.Assertions
open UseTestNameByReflection

open FSharp.Expandable

module CompilerImplTests =

  let asyncTest expected = async {
    let tempFilePath = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString("N"))
    try
      File.WriteAllText(tempFilePath, expected)
      return! CompilerImpl.asyncReadTextFile tempFilePath
    finally
      File.Delete tempFilePath
  }
  
  let ``can read using asyncReadTextFile`` = test {
    let expected =
      System.String.Join("", Enumerable.Range(0, 100) |> Seq.map (fun _ -> Guid.NewGuid().ToString("N")))
    let! actual = asyncRun { it (asyncTest expected) }
    do! assertEquals expected actual
  }
