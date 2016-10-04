//////////////////////////////////////////////////////////////////////////////////////
// This is auto-generated codes by FSharp.Expandable.Compiler.Generator. Do not edit.
// Generated: {0:R}
//////////////////////////////////////////////////////////////////////////////////////

namespace Microsoft.FSharp.Compiler.Ast.Visitor

#nowarn "1182"

////////////////////////////////////////////////////////////

/// <summary>
/// FSharp.Compiler.Service's untyped AST inheritable visitor.
/// </summary>
/// <typeparam name="'TContext">Custom context type.</typeparam>
[<AbstractClass; NoEquality; NoComparison; AutoSerializable(false)>]
type AstInheritableVisitor<'TContext when 'TContext: (new: unit -> 'TContext)>() =

  let mutable symInf: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpCheckFileResults option = None

  // TODO: du element
  let parents = new System.Collections.Generic.Stack<Microsoft.FSharp.Compiler.Ast.Visitor.AstElement>()

  /// <summary>
  /// Parent nodes.
  /// </summary>
  member __.Parents = parents |> List.ofSeq

  /// <summary>
  /// Symbol information.
  /// </summary>
  member __.SymbolInformation =
    match symInf with
    | Some(si) -> si
    | None -> failwith "Not given symbol information for current state."
