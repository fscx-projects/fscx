//////////////////////////////////////////////////////////////////////////////////////
// This is auto-generated codes by FSharp.Expandable.Compiler.Generator. Do not edit.
// Generated: Thu, 04 Aug 2016 02:57:06 GMT
//////////////////////////////////////////////////////////////////////////////////////

namespace Microsoft.FSharp.Compiler.Ast

open System
open Microsoft.FSharp.Compiler
open Microsoft.FSharp.Compiler.Ast

////////////////////////////////////////////////////////////

/// <summary>
/// FSharp.Compiler.Service's untyped AST nodes.
/// </summary>
[<RequireQualifiedAccess>]
type AstElement =
  | Access of SynAccess
  | ArgInfo of SynArgInfo
  | Binding of SynBinding
  | BindingKind of SynBindingKind
  | BindingReturnInfo of SynBindingReturnInfo
  | ComponentInfo of SynComponentInfo
  | Const of SynConst
  | ConstructorArgs of SynConstructorArgs
  | EnumCase of SynEnumCase
  | ExceptionDefn of SynExceptionDefn
  | ExceptionDefnRepr of SynExceptionDefnRepr
  | ExceptionSig of SynExceptionSig
  | Expr of SynExpr
  | Field of SynField
  | IndexerArg of SynIndexerArg
  | InterfaceImpl of SynInterfaceImpl
  | MatchClause of SynMatchClause
  | Measure of SynMeasure
  | MemberDefn of SynMemberDefn
  | MemberSig of SynMemberSig
  | ModuleDecl of SynModuleDecl
  | ModuleOrNamespace of SynModuleOrNamespace
  | ModuleOrNamespaceSig of SynModuleOrNamespaceSig
  | ModuleSigDecl of SynModuleSigDecl
  | Pat of SynPat
  | RationalConst of SynRationalConst
  | ReturnInfo of SynReturnInfo
  | SimplePat of SynSimplePat
  | SimplePatAlternativeIdInfo of SynSimplePatAlternativeIdInfo
  | SimplePats of SynSimplePats
  | StaticOptimizationConstraint of SynStaticOptimizationConstraint
  | Typar of SynTypar
  | TyparDecl of SynTyparDecl
  | Type of SynType
  | TypeConstraint of SynTypeConstraint
  | TypeDefn of SynTypeDefn
  | TypeDefnKind of SynTypeDefnKind
  | TypeDefnRepr of SynTypeDefnRepr
  | TypeDefnSig of SynTypeDefnSig
  | TypeDefnSigRepr of SynTypeDefnSigRepr
  | TypeDefnSimpleRepr of SynTypeDefnSimpleRepr
  | UnionCase of SynUnionCase
  | UnionCaseType of SynUnionCaseType
  | ValData of SynValData
  | ValInfo of SynValInfo
  | ValSig of SynValSig
  | ValTyparDecls of SynValTyparDecls
