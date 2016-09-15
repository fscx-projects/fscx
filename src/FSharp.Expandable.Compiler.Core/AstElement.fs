//////////////////////////////////////////////////////////////////////////////////////
// This is auto-generated codes by FSharp.Expandable.Compiler.Generator. Do not edit.
// Generated: Thu, 15 Sep 2016 06:01:15 GMT
//////////////////////////////////////////////////////////////////////////////////////

namespace Microsoft.FSharp.Compiler.Ast.Visitor

open System

////////////////////////////////////////////////////////////

/// <summary>
/// FSharp.Compiler.Service's untyped AST nodes.
/// </summary>
[<RequireQualifiedAccess>]
type AstElement =
  | FsiInteraction of Microsoft.FSharp.Compiler.Ast.ParsedFsiInteraction
  | HashDirective of Microsoft.FSharp.Compiler.Ast.ParsedHashDirective
  | ImplFile of Microsoft.FSharp.Compiler.Ast.ParsedImplFile
  | ImplFileFragment of Microsoft.FSharp.Compiler.Ast.ParsedImplFileFragment
  | ImplFileInput of Microsoft.FSharp.Compiler.Ast.ParsedImplFileInput
  | Input of Microsoft.FSharp.Compiler.Ast.ParsedInput
  | SigFile of Microsoft.FSharp.Compiler.Ast.ParsedSigFile
  | SigFileFragment of Microsoft.FSharp.Compiler.Ast.ParsedSigFileFragment
  | SigFileInput of Microsoft.FSharp.Compiler.Ast.ParsedSigFileInput
  | Access of Microsoft.FSharp.Compiler.Ast.SynAccess
  | ArgInfo of Microsoft.FSharp.Compiler.Ast.SynArgInfo
  | Binding of Microsoft.FSharp.Compiler.Ast.SynBinding
  | BindingKind of Microsoft.FSharp.Compiler.Ast.SynBindingKind
  | BindingReturnInfo of Microsoft.FSharp.Compiler.Ast.SynBindingReturnInfo
  | ComponentInfo of Microsoft.FSharp.Compiler.Ast.SynComponentInfo
  | Const of Microsoft.FSharp.Compiler.Ast.SynConst
  | ConstructorArgs of Microsoft.FSharp.Compiler.Ast.SynConstructorArgs
  | EnumCase of Microsoft.FSharp.Compiler.Ast.SynEnumCase
  | ExceptionDefn of Microsoft.FSharp.Compiler.Ast.SynExceptionDefn
  | ExceptionDefnRepr of Microsoft.FSharp.Compiler.Ast.SynExceptionDefnRepr
  | ExceptionSig of Microsoft.FSharp.Compiler.Ast.SynExceptionSig
  | Expr of Microsoft.FSharp.Compiler.Ast.SynExpr
  | Field of Microsoft.FSharp.Compiler.Ast.SynField
  | IndexerArg of Microsoft.FSharp.Compiler.Ast.SynIndexerArg
  | InterfaceImpl of Microsoft.FSharp.Compiler.Ast.SynInterfaceImpl
  | MatchClause of Microsoft.FSharp.Compiler.Ast.SynMatchClause
  | Measure of Microsoft.FSharp.Compiler.Ast.SynMeasure
  | MemberDefn of Microsoft.FSharp.Compiler.Ast.SynMemberDefn
  | MemberSig of Microsoft.FSharp.Compiler.Ast.SynMemberSig
  | ModuleDecl of Microsoft.FSharp.Compiler.Ast.SynModuleDecl
  | ModuleOrNamespace of Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespace
  | ModuleOrNamespaceSig of Microsoft.FSharp.Compiler.Ast.SynModuleOrNamespaceSig
  | ModuleSigDecl of Microsoft.FSharp.Compiler.Ast.SynModuleSigDecl
  | Pat of Microsoft.FSharp.Compiler.Ast.SynPat
  | RationalConst of Microsoft.FSharp.Compiler.Ast.SynRationalConst
  | ReturnInfo of Microsoft.FSharp.Compiler.Ast.SynReturnInfo
  | SimplePat of Microsoft.FSharp.Compiler.Ast.SynSimplePat
  | SimplePatAlternativeIdInfo of Microsoft.FSharp.Compiler.Ast.SynSimplePatAlternativeIdInfo
  | SimplePats of Microsoft.FSharp.Compiler.Ast.SynSimplePats
  | StaticOptimizationConstraint of Microsoft.FSharp.Compiler.Ast.SynStaticOptimizationConstraint
  | Typar of Microsoft.FSharp.Compiler.Ast.SynTypar
  | TyparDecl of Microsoft.FSharp.Compiler.Ast.SynTyparDecl
  | Type of Microsoft.FSharp.Compiler.Ast.SynType
  | TypeConstraint of Microsoft.FSharp.Compiler.Ast.SynTypeConstraint
  | TypeDefn of Microsoft.FSharp.Compiler.Ast.SynTypeDefn
  | TypeDefnKind of Microsoft.FSharp.Compiler.Ast.SynTypeDefnKind
  | TypeDefnRepr of Microsoft.FSharp.Compiler.Ast.SynTypeDefnRepr
  | TypeDefnSig of Microsoft.FSharp.Compiler.Ast.SynTypeDefnSig
  | TypeDefnSigRepr of Microsoft.FSharp.Compiler.Ast.SynTypeDefnSigRepr
  | TypeDefnSimpleRepr of Microsoft.FSharp.Compiler.Ast.SynTypeDefnSimpleRepr
  | UnionCase of Microsoft.FSharp.Compiler.Ast.SynUnionCase
  | UnionCaseType of Microsoft.FSharp.Compiler.Ast.SynUnionCaseType
  | ValData of Microsoft.FSharp.Compiler.Ast.SynValData
  | ValInfo of Microsoft.FSharp.Compiler.Ast.SynValInfo
  | ValSig of Microsoft.FSharp.Compiler.Ast.SynValSig
  | ValTyparDecls of Microsoft.FSharp.Compiler.Ast.SynValTyparDecls
