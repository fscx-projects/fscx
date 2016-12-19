
[<EntryPoint>]
let main argv =
    SampleCode.AspectTargets1.f11(123, "ABC", 456)
    SampleCode.AspectTargets1.f12(123, "ABC", 456)
    SampleCode.AspectTargets1.f13(123, "ABC", 456)
    SampleCode.AspectTargets1.f14()

    SampleCode.AspectTargets2.f21 123 "ABC" 456
    SampleCode.AspectTargets2.f22 123 "ABC" 456
    SampleCode.AspectTargets2.f23 123 "ABC" 456

    SampleCode.AspectTargets3.f31 123 "ABC" 456
    SampleCode.AspectTargets3.f32 123 "ABC" 456
    SampleCode.AspectTargets3.f33 123 "ABC" 456
    0
