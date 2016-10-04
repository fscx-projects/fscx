//////////////////////////////////////////////////////////////////////////////////////
// This is auto-generated codes by FSharp.Expandable.Compiler.Generator. Do not edit.
// Generated: Tue, 04 Oct 2016 08:05:56 GMT
//////////////////////////////////////////////////////////////////////////////////////

namespace Microsoft.FSharp.Compiler.Ast.Visitor

open System

/// Construct record types without conflict free.
[<AutoOpen>]
module AstRecordCons =

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.FSharpNavigationTopLevelDeclaration".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genFSharpNavigationTopLevelDeclaration
     (declaration: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpNavigationDeclarationItem,
      nested: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpNavigationDeclarationItem[]) =
    { Microsoft.FSharp.Compiler.SourceCodeServices.FSharpNavigationTopLevelDeclaration.Declaration = declaration;
      Microsoft.FSharp.Compiler.SourceCodeServices.FSharpNavigationTopLevelDeclaration.Nested = nested }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.FSharpProjectOptions".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genFSharpProjectOptions
     (projectFileName: string,
      projectFileNames: string[],
      otherOptions: string[],
      referencedProjects: (string * Microsoft.FSharp.Compiler.SourceCodeServices.FSharpProjectOptions)[],
      isIncompleteTypeCheckEnvironment: bool,
      useScriptResolutionRules: bool,
      loadTime: System.DateTime,
      unresolvedReferences: Microsoft.FSharp.Compiler.SourceCodeServices.UnresolvedReferencesSet option) =
    { Microsoft.FSharp.Compiler.SourceCodeServices.FSharpProjectOptions.ProjectFileName = projectFileName;
      Microsoft.FSharp.Compiler.SourceCodeServices.FSharpProjectOptions.ProjectFileNames = projectFileNames;
      Microsoft.FSharp.Compiler.SourceCodeServices.FSharpProjectOptions.OtherOptions = otherOptions;
      Microsoft.FSharp.Compiler.SourceCodeServices.FSharpProjectOptions.ReferencedProjects = referencedProjects;
      Microsoft.FSharp.Compiler.SourceCodeServices.FSharpProjectOptions.IsIncompleteTypeCheckEnvironment = isIncompleteTypeCheckEnvironment;
      Microsoft.FSharp.Compiler.SourceCodeServices.FSharpProjectOptions.UseScriptResolutionRules = useScriptResolutionRules;
      Microsoft.FSharp.Compiler.SourceCodeServices.FSharpProjectOptions.LoadTime = loadTime;
      Microsoft.FSharp.Compiler.SourceCodeServices.FSharpProjectOptions.UnresolvedReferences = unresolvedReferences }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.FSharpTokenInfo".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genFSharpTokenInfo
     (leftColumn: int,
      rightColumn: int,
      colorClass: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpTokenColorKind,
      charClass: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpTokenCharKind,
      fSharpTokenTriggerClass: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpTokenTriggerClass,
      tag: int,
      tokenName: string,
      fullMatchedLength: int) =
    { Microsoft.FSharp.Compiler.SourceCodeServices.FSharpTokenInfo.LeftColumn = leftColumn;
      Microsoft.FSharp.Compiler.SourceCodeServices.FSharpTokenInfo.RightColumn = rightColumn;
      Microsoft.FSharp.Compiler.SourceCodeServices.FSharpTokenInfo.ColorClass = colorClass;
      Microsoft.FSharp.Compiler.SourceCodeServices.FSharpTokenInfo.CharClass = charClass;
      Microsoft.FSharp.Compiler.SourceCodeServices.FSharpTokenInfo.FSharpTokenTriggerClass = fSharpTokenTriggerClass;
      Microsoft.FSharp.Compiler.SourceCodeServices.FSharpTokenInfo.Tag = tag;
      Microsoft.FSharp.Compiler.SourceCodeServices.FSharpTokenInfo.TokenName = tokenName;
      Microsoft.FSharp.Compiler.SourceCodeServices.FSharpTokenInfo.FullMatchedLength = fullMatchedLength }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILAssemblyManifest".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genILAssemblyManifest
     (name: string,
      auxModuleHashAlgorithm: int,
      securityDecls: Microsoft.FSharp.Compiler.AbstractIL.IL.ILPermissions,
      publicKey: byte[] option,
      version: (System.UInt16 * System.UInt16 * System.UInt16 * System.UInt16) option,
      locale: string option,
      customAttrs: Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttributes,
      assemblyLongevity: Microsoft.FSharp.Compiler.AbstractIL.IL.ILAssemblyLongevity,
      disableJitOptimizations: bool,
      jitTracking: bool,
      retargetable: bool,
      exportedTypes: Microsoft.FSharp.Compiler.AbstractIL.IL.ILExportedTypesAndForwarders,
      entrypointElsewhere: Microsoft.FSharp.Compiler.AbstractIL.IL.ILModuleRef option) =
    { Microsoft.FSharp.Compiler.AbstractIL.IL.ILAssemblyManifest.Name = name;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILAssemblyManifest.AuxModuleHashAlgorithm = auxModuleHashAlgorithm;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILAssemblyManifest.SecurityDecls = securityDecls;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILAssemblyManifest.PublicKey = publicKey;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILAssemblyManifest.Version = version;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILAssemblyManifest.Locale = locale;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILAssemblyManifest.CustomAttrs = customAttrs;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILAssemblyManifest.AssemblyLongevity = assemblyLongevity;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILAssemblyManifest.DisableJitOptimizations = disableJitOptimizations;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILAssemblyManifest.JitTracking = jitTracking;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILAssemblyManifest.Retargetable = retargetable;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILAssemblyManifest.ExportedTypes = exportedTypes;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILAssemblyManifest.EntrypointElsewhere = entrypointElsewhere }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribute".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genILAttribute
     (_method: Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodSpec,
      data: byte[]) =
    { Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribute.Method = _method;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribute.Data = data }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILCallingSignature".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genILCallingSignature
     (callingConv: Microsoft.FSharp.Compiler.AbstractIL.IL.ILCallingConv,
      argTypes: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType list,
      returnType: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType) =
    { Microsoft.FSharp.Compiler.AbstractIL.IL.ILCallingSignature.CallingConv = callingConv;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILCallingSignature.ArgTypes = argTypes;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILCallingSignature.ReturnType = returnType }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILCode".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genILCode
     (labels: System.Collections.Generic.Dictionary<int, int>,
      instrs: Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr[],
      exceptions: Microsoft.FSharp.Compiler.AbstractIL.IL.ILExceptionSpec list,
      locals: Microsoft.FSharp.Compiler.AbstractIL.IL.ILLocalDebugInfo list) =
    { Microsoft.FSharp.Compiler.AbstractIL.IL.ILCode.Labels = labels;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILCode.Instrs = instrs;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILCode.Exceptions = exceptions;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILCode.Locals = locals }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILEnumInfo".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genILEnumInfo
     (enumValues: (string * Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldInit) list,
      enumType: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType) =
    { Microsoft.FSharp.Compiler.AbstractIL.IL.ILEnumInfo.enumValues = enumValues;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILEnumInfo.enumType = enumType }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILEventDef".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genILEventDef
     (_type: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType option,
      name: string,
      isRTSpecialName: bool,
      isSpecialName: bool,
      addMethod: Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodRef,
      removeMethod: Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodRef,
      fireMethod: Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodRef option,
      otherMethods: Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodRef list,
      customAttrs: Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttributes) =
    { Microsoft.FSharp.Compiler.AbstractIL.IL.ILEventDef.Type = _type;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILEventDef.Name = name;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILEventDef.IsRTSpecialName = isRTSpecialName;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILEventDef.IsSpecialName = isSpecialName;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILEventDef.AddMethod = addMethod;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILEventDef.RemoveMethod = removeMethod;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILEventDef.FireMethod = fireMethod;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILEventDef.OtherMethods = otherMethods;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILEventDef.CustomAttrs = customAttrs }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILExceptionSpec".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genILExceptionSpec
     (range: (int * int),
      clause: Microsoft.FSharp.Compiler.AbstractIL.IL.ILExceptionClause) =
    { Microsoft.FSharp.Compiler.AbstractIL.IL.ILExceptionSpec.Range = range;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILExceptionSpec.Clause = clause }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILExportedTypeOrForwarder".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genILExportedTypeOrForwarder
     (scopeRef: Microsoft.FSharp.Compiler.AbstractIL.IL.ILScopeRef,
      name: string,
      isForwarder: bool,
      access: Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDefAccess,
      nested: Microsoft.FSharp.Compiler.AbstractIL.IL.ILNestedExportedTypes,
      customAttrs: Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttributes) =
    { Microsoft.FSharp.Compiler.AbstractIL.IL.ILExportedTypeOrForwarder.ScopeRef = scopeRef;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILExportedTypeOrForwarder.Name = name;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILExportedTypeOrForwarder.IsForwarder = isForwarder;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILExportedTypeOrForwarder.Access = access;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILExportedTypeOrForwarder.Nested = nested;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILExportedTypeOrForwarder.CustomAttrs = customAttrs }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldDef".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genILFieldDef
     (name: string,
      _type: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType,
      isStatic: bool,
      access: Microsoft.FSharp.Compiler.AbstractIL.IL.ILMemberAccess,
      data: byte[] option,
      literalValue: Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldInit option,
      offset: int option,
      isSpecialName: bool,
      marshal: Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType option,
      notSerialized: bool,
      isLiteral: bool,
      isInitOnly: bool,
      customAttrs: Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttributes) =
    { Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldDef.Name = name;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldDef.Type = _type;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldDef.IsStatic = isStatic;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldDef.Access = access;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldDef.Data = data;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldDef.LiteralValue = literalValue;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldDef.Offset = offset;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldDef.IsSpecialName = isSpecialName;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldDef.Marshal = marshal;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldDef.NotSerialized = notSerialized;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldDef.IsLiteral = isLiteral;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldDef.IsInitOnly = isInitOnly;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldDef.CustomAttrs = customAttrs }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldRef".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genILFieldRef
     (enclosingTypeRef: Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeRef,
      name: string,
      _type: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType) =
    { Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldRef.EnclosingTypeRef = enclosingTypeRef;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldRef.Name = name;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldRef.Type = _type }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldSpec".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genILFieldSpec
     (fieldRef: Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldRef,
      enclosingType: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType) =
    { Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldSpec.FieldRef = fieldRef;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldSpec.EnclosingType = enclosingType }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILGenericParameterDef".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genILGenericParameterDef
     (name: string,
      constraints: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType list,
      variance: Microsoft.FSharp.Compiler.AbstractIL.IL.ILGenericVariance,
      hasReferenceTypeConstraint: bool,
      customAttrs: Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttributes,
      hasNotNullableValueTypeConstraint: bool,
      hasDefaultConstructorConstraint: bool) =
    { Microsoft.FSharp.Compiler.AbstractIL.IL.ILGenericParameterDef.Name = name;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGenericParameterDef.Constraints = constraints;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGenericParameterDef.Variance = variance;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGenericParameterDef.HasReferenceTypeConstraint = hasReferenceTypeConstraint;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGenericParameterDef.CustomAttrs = customAttrs;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGenericParameterDef.HasNotNullableValueTypeConstraint = hasNotNullableValueTypeConstraint;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGenericParameterDef.HasDefaultConstructorConstraint = hasDefaultConstructorConstraint }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genILGlobals
     (traits: Microsoft.FSharp.Compiler.AbstractIL.IL.IPrimaryAssemblyTraits,
      primaryAssemblyName: string,
      noDebugData: bool,
      tref_Object: Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeRef,
      tspec_Object: Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeSpec,
      typ_Object: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType,
      tref_String: Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeRef,
      typ_String: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType,
      typ_StringBuilder: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType,
      typ_AsyncCallback: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType,
      typ_IAsyncResult: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType,
      typ_IComparable: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType,
      tref_Type: Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeRef,
      typ_Type: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType,
      typ_Missing: System.Lazy<Microsoft.FSharp.Compiler.AbstractIL.IL.ILType>,
      typ_Activator: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType,
      typ_Delegate: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType,
      typ_ValueType: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType,
      typ_Enum: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType,
      tspec_TypedReference: Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeSpec option,
      typ_TypedReference: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType option,
      typ_MulticastDelegate: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType,
      typ_Array: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType,
      tspec_Int64: Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeSpec,
      tspec_UInt64: Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeSpec,
      tspec_Int32: Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeSpec,
      tspec_UInt32: Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeSpec,
      tspec_Int16: Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeSpec,
      tspec_UInt16: Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeSpec,
      tspec_SByte: Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeSpec,
      tspec_Byte: Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeSpec,
      tspec_Single: Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeSpec,
      tspec_Double: Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeSpec,
      tspec_IntPtr: Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeSpec,
      tspec_UIntPtr: Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeSpec,
      tspec_Char: Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeSpec,
      tspec_Bool: Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeSpec,
      typ_int8: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType,
      typ_int16: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType,
      typ_int32: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType,
      typ_int64: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType,
      typ_uint8: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType,
      typ_uint16: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType,
      typ_uint32: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType,
      typ_uint64: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType,
      typ_float32: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType,
      typ_float64: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType,
      typ_bool: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType,
      typ_char: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType,
      typ_IntPtr: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType,
      typ_UIntPtr: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType,
      typ_RuntimeArgumentHandle: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType option,
      typ_RuntimeTypeHandle: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType,
      typ_RuntimeMethodHandle: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType,
      typ_RuntimeFieldHandle: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType,
      typ_Byte: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType,
      typ_Int16: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType,
      typ_Int32: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType,
      typ_Int64: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType,
      typ_SByte: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType,
      typ_UInt16: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType,
      typ_UInt32: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType,
      typ_UInt64: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType,
      typ_Single: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType,
      typ_Double: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType,
      typ_Bool: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType,
      typ_Char: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType,
      typ_SerializationInfo: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType option,
      typ_StreamingContext: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType,
      tref_SecurityPermissionAttribute: Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeRef option,
      tspec_Exception: Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeSpec,
      typ_Exception: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType,
      generatedAttribsCache: Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribute list,
      debuggerBrowsableNeverAttributeCache: Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribute option,
      debuggerTypeProxyAttributeCache: Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribute option) =
    { Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.traits = traits;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.primaryAssemblyName = primaryAssemblyName;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.noDebugData = noDebugData;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.tref_Object = tref_Object;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.tspec_Object = tspec_Object;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.typ_Object = typ_Object;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.tref_String = tref_String;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.typ_String = typ_String;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.typ_StringBuilder = typ_StringBuilder;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.typ_AsyncCallback = typ_AsyncCallback;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.typ_IAsyncResult = typ_IAsyncResult;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.typ_IComparable = typ_IComparable;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.tref_Type = tref_Type;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.typ_Type = typ_Type;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.typ_Missing = typ_Missing;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.typ_Activator = typ_Activator;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.typ_Delegate = typ_Delegate;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.typ_ValueType = typ_ValueType;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.typ_Enum = typ_Enum;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.tspec_TypedReference = tspec_TypedReference;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.typ_TypedReference = typ_TypedReference;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.typ_MulticastDelegate = typ_MulticastDelegate;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.typ_Array = typ_Array;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.tspec_Int64 = tspec_Int64;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.tspec_UInt64 = tspec_UInt64;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.tspec_Int32 = tspec_Int32;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.tspec_UInt32 = tspec_UInt32;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.tspec_Int16 = tspec_Int16;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.tspec_UInt16 = tspec_UInt16;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.tspec_SByte = tspec_SByte;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.tspec_Byte = tspec_Byte;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.tspec_Single = tspec_Single;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.tspec_Double = tspec_Double;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.tspec_IntPtr = tspec_IntPtr;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.tspec_UIntPtr = tspec_UIntPtr;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.tspec_Char = tspec_Char;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.tspec_Bool = tspec_Bool;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.typ_int8 = typ_int8;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.typ_int16 = typ_int16;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.typ_int32 = typ_int32;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.typ_int64 = typ_int64;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.typ_uint8 = typ_uint8;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.typ_uint16 = typ_uint16;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.typ_uint32 = typ_uint32;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.typ_uint64 = typ_uint64;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.typ_float32 = typ_float32;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.typ_float64 = typ_float64;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.typ_bool = typ_bool;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.typ_char = typ_char;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.typ_IntPtr = typ_IntPtr;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.typ_UIntPtr = typ_UIntPtr;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.typ_RuntimeArgumentHandle = typ_RuntimeArgumentHandle;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.typ_RuntimeTypeHandle = typ_RuntimeTypeHandle;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.typ_RuntimeMethodHandle = typ_RuntimeMethodHandle;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.typ_RuntimeFieldHandle = typ_RuntimeFieldHandle;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.typ_Byte = typ_Byte;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.typ_Int16 = typ_Int16;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.typ_Int32 = typ_Int32;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.typ_Int64 = typ_Int64;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.typ_SByte = typ_SByte;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.typ_UInt16 = typ_UInt16;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.typ_UInt32 = typ_UInt32;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.typ_UInt64 = typ_UInt64;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.typ_Single = typ_Single;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.typ_Double = typ_Double;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.typ_Bool = typ_Bool;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.typ_Char = typ_Char;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.typ_SerializationInfo = typ_SerializationInfo;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.typ_StreamingContext = typ_StreamingContext;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.tref_SecurityPermissionAttribute = tref_SecurityPermissionAttribute;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.tspec_Exception = tspec_Exception;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.typ_Exception = typ_Exception;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.generatedAttribsCache = generatedAttribsCache;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.debuggerBrowsableNeverAttributeCache = debuggerBrowsableNeverAttributeCache;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals.debuggerTypeProxyAttributeCache = debuggerTypeProxyAttributeCache }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILLocal".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genILLocal
     (_type: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType,
      isPinned: bool,
      debugInfo: (string * int * int) option) =
    { Microsoft.FSharp.Compiler.AbstractIL.IL.ILLocal.Type = _type;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILLocal.IsPinned = isPinned;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILLocal.DebugInfo = debugInfo }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILLocalDebugInfo".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genILLocalDebugInfo
     (range: (int * int),
      debugMappings: Microsoft.FSharp.Compiler.AbstractIL.IL.ILLocalDebugMapping list) =
    { Microsoft.FSharp.Compiler.AbstractIL.IL.ILLocalDebugInfo.Range = range;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILLocalDebugInfo.DebugMappings = debugMappings }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILLocalDebugMapping".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genILLocalDebugMapping
     (localIndex: int,
      localName: string) =
    { Microsoft.FSharp.Compiler.AbstractIL.IL.ILLocalDebugMapping.LocalIndex = localIndex;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILLocalDebugMapping.LocalName = localName }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodBody".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genILMethodBody
     (isZeroInit: bool,
      maxStack: int,
      noInlining: bool,
      locals: Microsoft.FSharp.Compiler.AbstractIL.IL.ILLocal list,
      code: Microsoft.FSharp.Compiler.AbstractIL.IL.ILCode,
      sourceMarker: Microsoft.FSharp.Compiler.AbstractIL.IL.ILSourceMarker option) =
    { Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodBody.IsZeroInit = isZeroInit;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodBody.MaxStack = maxStack;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodBody.NoInlining = noInlining;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodBody.Locals = locals;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodBody.Code = code;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodBody.SourceMarker = sourceMarker }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodDef".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genILMethodDef
     (name: string,
      mdKind: Microsoft.FSharp.Compiler.AbstractIL.IL.MethodKind,
      callingConv: Microsoft.FSharp.Compiler.AbstractIL.IL.ILCallingConv,
      parameters: Microsoft.FSharp.Compiler.AbstractIL.IL.ILParameter list,
      _return: Microsoft.FSharp.Compiler.AbstractIL.IL.ILReturn,
      access: Microsoft.FSharp.Compiler.AbstractIL.IL.ILMemberAccess,
      mdBody: Microsoft.FSharp.Compiler.AbstractIL.IL.ILLazyMethodBody,
      mdCodeKind: Microsoft.FSharp.Compiler.AbstractIL.IL.MethodCodeKind,
      isInternalCall: bool,
      isManaged: bool,
      isForwardRef: bool,
      securityDecls: Microsoft.FSharp.Compiler.AbstractIL.IL.ILPermissions,
      hasSecurity: bool,
      isEntryPoint: bool,
      isReqSecObj: bool,
      isHideBySig: bool,
      isSpecialName: bool,
      isUnmanagedExport: bool,
      isSynchronized: bool,
      isPreserveSig: bool,
      isMustRun: bool,
      isNoInline: bool,
      genericParams: Microsoft.FSharp.Compiler.AbstractIL.IL.ILGenericParameterDef list,
      customAttrs: Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttributes) =
    { Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodDef.Name = name;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodDef.mdKind = mdKind;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodDef.CallingConv = callingConv;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodDef.Parameters = parameters;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodDef.Return = _return;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodDef.Access = access;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodDef.mdBody = mdBody;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodDef.mdCodeKind = mdCodeKind;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodDef.IsInternalCall = isInternalCall;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodDef.IsManaged = isManaged;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodDef.IsForwardRef = isForwardRef;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodDef.SecurityDecls = securityDecls;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodDef.HasSecurity = hasSecurity;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodDef.IsEntryPoint = isEntryPoint;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodDef.IsReqSecObj = isReqSecObj;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodDef.IsHideBySig = isHideBySig;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodDef.IsSpecialName = isSpecialName;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodDef.IsUnmanagedExport = isUnmanagedExport;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodDef.IsSynchronized = isSynchronized;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodDef.IsPreserveSig = isPreserveSig;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodDef.IsMustRun = isMustRun;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodDef.IsNoInline = isNoInline;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodDef.GenericParams = genericParams;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodDef.CustomAttrs = customAttrs }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodImplDef".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genILMethodImplDef
     (overrides: Microsoft.FSharp.Compiler.AbstractIL.IL.ILOverridesSpec,
      overrideBy: Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodSpec) =
    { Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodImplDef.Overrides = overrides;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodImplDef.OverrideBy = overrideBy }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodVirtualInfo".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genILMethodVirtualInfo
     (isFinal: bool,
      isNewSlot: bool,
      isCheckAccessOnOverride: bool,
      isAbstract: bool) =
    { Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodVirtualInfo.IsFinal = isFinal;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodVirtualInfo.IsNewSlot = isNewSlot;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodVirtualInfo.IsCheckAccessOnOverride = isCheckAccessOnOverride;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodVirtualInfo.IsAbstract = isAbstract }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILModuleDef".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genILModuleDef
     (manifest: Microsoft.FSharp.Compiler.AbstractIL.IL.ILAssemblyManifest option,
      customAttrs: Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttributes,
      name: string,
      typeDefs: Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDefs,
      subsystemVersion: (int * int),
      useHighEntropyVA: bool,
      subSystemFlags: int,
      isDLL: bool,
      isILOnly: bool,
      platform: Microsoft.FSharp.Compiler.AbstractIL.IL.ILPlatform option,
      stackReserveSize: int option,
      is32Bit: bool,
      is32BitPreferred: bool,
      is64Bit: bool,
      virtualAlignment: int,
      physicalAlignment: int,
      imageBase: int,
      metadataVersion: string,
      resources: Microsoft.FSharp.Compiler.AbstractIL.IL.ILResources,
      nativeResources: System.Lazy<byte[]> list) =
    { Microsoft.FSharp.Compiler.AbstractIL.IL.ILModuleDef.Manifest = manifest;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILModuleDef.CustomAttrs = customAttrs;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILModuleDef.Name = name;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILModuleDef.TypeDefs = typeDefs;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILModuleDef.SubsystemVersion = subsystemVersion;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILModuleDef.UseHighEntropyVA = useHighEntropyVA;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILModuleDef.SubSystemFlags = subSystemFlags;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILModuleDef.IsDLL = isDLL;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILModuleDef.IsILOnly = isILOnly;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILModuleDef.Platform = platform;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILModuleDef.StackReserveSize = stackReserveSize;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILModuleDef.Is32Bit = is32Bit;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILModuleDef.Is32BitPreferred = is32BitPreferred;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILModuleDef.Is64Bit = is64Bit;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILModuleDef.VirtualAlignment = virtualAlignment;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILModuleDef.PhysicalAlignment = physicalAlignment;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILModuleDef.ImageBase = imageBase;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILModuleDef.MetadataVersion = metadataVersion;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILModuleDef.Resources = resources;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILModuleDef.NativeResources = nativeResources }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNestedExportedType".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genILNestedExportedType
     (name: string,
      access: Microsoft.FSharp.Compiler.AbstractIL.IL.ILMemberAccess,
      nested: Microsoft.FSharp.Compiler.AbstractIL.IL.ILNestedExportedTypes,
      customAttrs: Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttributes) =
    { Microsoft.FSharp.Compiler.AbstractIL.IL.ILNestedExportedType.Name = name;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILNestedExportedType.Access = access;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILNestedExportedType.Nested = nested;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILNestedExportedType.CustomAttrs = customAttrs }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILParameter".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genILParameter
     (name: string option,
      _type: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType,
      _default: Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldInit option,
      marshal: Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType option,
      isIn: bool,
      isOut: bool,
      isOptional: bool,
      customAttrs: Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttributes) =
    { Microsoft.FSharp.Compiler.AbstractIL.IL.ILParameter.Name = name;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILParameter.Type = _type;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILParameter.Default = _default;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILParameter.Marshal = marshal;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILParameter.IsIn = isIn;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILParameter.IsOut = isOut;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILParameter.IsOptional = isOptional;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILParameter.CustomAttrs = customAttrs }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILPropertyDef".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genILPropertyDef
     (name: string,
      isRTSpecialName: bool,
      isSpecialName: bool,
      setMethod: Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodRef option,
      getMethod: Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodRef option,
      callingConv: Microsoft.FSharp.Compiler.AbstractIL.IL.ILThisConvention,
      _type: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType,
      init: Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldInit option,
      args: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType list,
      customAttrs: Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttributes) =
    { Microsoft.FSharp.Compiler.AbstractIL.IL.ILPropertyDef.Name = name;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILPropertyDef.IsRTSpecialName = isRTSpecialName;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILPropertyDef.IsSpecialName = isSpecialName;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILPropertyDef.SetMethod = setMethod;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILPropertyDef.GetMethod = getMethod;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILPropertyDef.CallingConv = callingConv;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILPropertyDef.Type = _type;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILPropertyDef.Init = init;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILPropertyDef.Args = args;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILPropertyDef.CustomAttrs = customAttrs }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILReferences".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genILReferences
     (assemblyReferences: Microsoft.FSharp.Compiler.AbstractIL.IL.ILAssemblyRef list,
      moduleReferences: Microsoft.FSharp.Compiler.AbstractIL.IL.ILModuleRef list) =
    { Microsoft.FSharp.Compiler.AbstractIL.IL.ILReferences.AssemblyReferences = assemblyReferences;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILReferences.ModuleReferences = moduleReferences }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILResource".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genILResource
     (name: string,
      location: Microsoft.FSharp.Compiler.AbstractIL.IL.ILResourceLocation,
      access: Microsoft.FSharp.Compiler.AbstractIL.IL.ILResourceAccess,
      customAttrs: Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttributes) =
    { Microsoft.FSharp.Compiler.AbstractIL.IL.ILResource.Name = name;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILResource.Location = location;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILResource.Access = access;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILResource.CustomAttrs = customAttrs }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILReturn".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genILReturn
     (marshal: Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType option,
      _type: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType,
      customAttrs: Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttributes) =
    { Microsoft.FSharp.Compiler.AbstractIL.IL.ILReturn.Marshal = marshal;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILReturn.Type = _type;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILReturn.CustomAttrs = customAttrs }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDef".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genILTypeDef
     (tdKind: Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDefKind,
      name: string,
      genericParams: Microsoft.FSharp.Compiler.AbstractIL.IL.ILGenericParameterDef list,
      access: Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDefAccess,
      isAbstract: bool,
      isSealed: bool,
      isSerializable: bool,
      isComInterop: bool,
      layout: Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDefLayout,
      isSpecialName: bool,
      encoding: Microsoft.FSharp.Compiler.AbstractIL.IL.ILDefaultPInvokeEncoding,
      nestedTypes: Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDefs,
      implements: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType list,
      extends: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType option,
      methods: Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodDefs,
      securityDecls: Microsoft.FSharp.Compiler.AbstractIL.IL.ILPermissions,
      hasSecurity: bool,
      fields: Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldDefs,
      methodImpls: Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodImplDefs,
      initSemantics: Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeInit,
      events: Microsoft.FSharp.Compiler.AbstractIL.IL.ILEventDefs,
      properties: Microsoft.FSharp.Compiler.AbstractIL.IL.ILPropertyDefs,
      customAttrs: Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttributes) =
    { Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDef.tdKind = tdKind;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDef.Name = name;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDef.GenericParams = genericParams;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDef.Access = access;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDef.IsAbstract = isAbstract;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDef.IsSealed = isSealed;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDef.IsSerializable = isSerializable;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDef.IsComInterop = isComInterop;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDef.Layout = layout;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDef.IsSpecialName = isSpecialName;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDef.Encoding = encoding;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDef.NestedTypes = nestedTypes;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDef.Implements = implements;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDef.Extends = extends;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDef.Methods = methods;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDef.SecurityDecls = securityDecls;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDef.HasSecurity = hasSecurity;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDef.Fields = fields;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDef.MethodImpls = methodImpls;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDef.InitSemantics = initSemantics;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDef.Events = events;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDef.Properties = properties;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDef.CustomAttrs = customAttrs }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDefLayoutInfo".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genILTypeDefLayoutInfo
     (size: int option,
      pack: System.UInt16 option) =
    { Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDefLayoutInfo.Size = size;
      Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDefLayoutInfo.Pack = pack }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.MemberFlags".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genMemberFlags
     (isInstance: bool,
      isDispatchSlot: bool,
      isOverrideOrExplicitImpl: bool,
      isFinal: bool,
      memberKind: Microsoft.FSharp.Compiler.Ast.MemberKind) =
    { Microsoft.FSharp.Compiler.Ast.MemberFlags.IsInstance = isInstance;
      Microsoft.FSharp.Compiler.Ast.MemberFlags.IsDispatchSlot = isDispatchSlot;
      Microsoft.FSharp.Compiler.Ast.MemberFlags.IsOverrideOrExplicitImpl = isOverrideOrExplicitImpl;
      Microsoft.FSharp.Compiler.Ast.MemberFlags.IsFinal = isFinal;
      Microsoft.FSharp.Compiler.Ast.MemberFlags.MemberKind = memberKind }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.PInvokeMethod".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genPInvokeMethod
     (where: Microsoft.FSharp.Compiler.AbstractIL.IL.ILModuleRef,
      name: string,
      callingConv: Microsoft.FSharp.Compiler.AbstractIL.IL.PInvokeCallingConvention,
      charEncoding: Microsoft.FSharp.Compiler.AbstractIL.IL.PInvokeCharEncoding,
      noMangle: bool,
      lastError: bool,
      throwOnUnmappableChar: Microsoft.FSharp.Compiler.AbstractIL.IL.PInvokeThrowOnUnmappableChar,
      charBestFit: Microsoft.FSharp.Compiler.AbstractIL.IL.PInvokeCharBestFit) =
    { Microsoft.FSharp.Compiler.AbstractIL.IL.PInvokeMethod.Where = where;
      Microsoft.FSharp.Compiler.AbstractIL.IL.PInvokeMethod.Name = name;
      Microsoft.FSharp.Compiler.AbstractIL.IL.PInvokeMethod.CallingConv = callingConv;
      Microsoft.FSharp.Compiler.AbstractIL.IL.PInvokeMethod.CharEncoding = charEncoding;
      Microsoft.FSharp.Compiler.AbstractIL.IL.PInvokeMethod.NoMangle = noMangle;
      Microsoft.FSharp.Compiler.AbstractIL.IL.PInvokeMethod.LastError = lastError;
      Microsoft.FSharp.Compiler.AbstractIL.IL.PInvokeMethod.ThrowOnUnmappableChar = throwOnUnmappableChar;
      Microsoft.FSharp.Compiler.AbstractIL.IL.PInvokeMethod.CharBestFit = charBestFit }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.ErrorLogger.PhasedError".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genPhasedError
     (_exception: System.Exception,
      phase: Microsoft.FSharp.Compiler.ErrorLogger.BuildPhase) =
    { Microsoft.FSharp.Compiler.ErrorLogger.PhasedError.Exception = _exception;
      Microsoft.FSharp.Compiler.ErrorLogger.PhasedError.Phase = phase }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynAttribute".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let genSynAttribute
     (typeName: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots,
      argExpr: Microsoft.FSharp.Compiler.Ast.SynExpr,
      target: Microsoft.FSharp.Compiler.Ast.Ident option,
      appliesToGetterAndSetter: bool,
      range: Microsoft.FSharp.Compiler.Range.range) =
    { Microsoft.FSharp.Compiler.Ast.SynAttribute.TypeName = typeName;
      Microsoft.FSharp.Compiler.Ast.SynAttribute.ArgExpr = argExpr;
      Microsoft.FSharp.Compiler.Ast.SynAttribute.Target = target;
      Microsoft.FSharp.Compiler.Ast.SynAttribute.AppliesToGetterAndSetter = appliesToGetterAndSetter;
      Microsoft.FSharp.Compiler.Ast.SynAttribute.Range = range }

