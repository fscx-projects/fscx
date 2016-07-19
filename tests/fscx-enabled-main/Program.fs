// F# の詳細については、http://fsharp.org を参照してください
// 詳細については、'F# チュートリアル' プロジェクトを参照してください。

[<EntryPoint>]
let main argv = 
  FscxOutputSample1.f1 (123, "ABC", 456)
  FscxOutputSample2.f2 (789, "DEF", 111)
  printfn "%A" argv
  0 // 整数の終了コードを返します
