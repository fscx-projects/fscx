namespace Sample

type FscxReferencedClass() =

  member __.F1 a b c =
    FscxOutputSample1.f1(a, b, c)
  member __.F2 a b c =
    FscxOutputSample2.f2(a, b, c)
