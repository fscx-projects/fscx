open System
open System.Runtime.InteropServices

[<DllImport("user32.dll", CharSet = CharSet.Unicode)>]
extern int MessageBox(IntPtr hWnd, string text, string caption, int options);

[<EntryPoint>]
let main argv = 
  //MessageBox(IntPtr.Zero, "Wait for attached debugger...", "fscx-enabled-main", 0 ||| 0x30) |> ignore
  FscxOutputSample1.f1 (123, "ABC", 456)
  FscxOutputSample2.f2 (789, "DEF", 111)
  printfn "%A" argv
  0
