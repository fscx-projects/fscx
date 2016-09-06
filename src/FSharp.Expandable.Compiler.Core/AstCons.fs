//////////////////////////////////////////////////////////////////////////////////////
// This is auto-generated codes by FSharp.Expandable.Compiler.Generator. Do not edit.
// Generated: Tue, 06 Sep 2016 05:04:36 GMT
//////////////////////////////////////////////////////////////////////////////////////

namespace Microsoft.FSharp.Compiler.Ast

open System
open Microsoft.FSharp.Compiler
open Microsoft.FSharp.Compiler.Ast
open Microsoft.FSharp.Compiler.SourceCodeServices
open Microsoft.FSharp.Compiler.AbstractIL
open Microsoft.FSharp.Compiler.AbstractIL.IL

/// Construct record types commonly with independed RequireQualifiedAccessAttribute.
module internal AstRecordCons =

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.FSharpNavigationTopLevelDeclaration".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let initFSharpNavigationTopLevelDeclaration
     (declaration: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpNavigationDeclarationItem)
     (nested: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpNavigationDeclarationItem[]) =
    { Declaration = declaration; Nested = nested }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.FSharpProjectOptions".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let initFSharpProjectOptions
     (projectFileName: string)
     (projectFileNames: string[])
     (otherOptions: string[])
     (referencedProjects: (string * Microsoft.FSharp.Compiler.SourceCodeServices.FSharpProjectOptions)[])
     (isIncompleteTypeCheckEnvironment: bool)
     (useScriptResolutionRules: bool)
     (loadTime: System.DateTime)
     (unresolvedReferences: Microsoft.FSharp.Compiler.SourceCodeServices.UnresolvedReferencesSet option) =
    { ProjectFileName = projectFileName; ProjectFileNames = projectFileNames; OtherOptions = otherOptions; ReferencedProjects = referencedProjects; IsIncompleteTypeCheckEnvironment = isIncompleteTypeCheckEnvironment; UseScriptResolutionRules = useScriptResolutionRules; LoadTime = loadTime; UnresolvedReferences = unresolvedReferences }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.SourceCodeServices.FSharpTokenInfo".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let initFSharpTokenInfo
     (leftColumn: int)
     (rightColumn: int)
     (colorClass: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpTokenColorKind)
     (charClass: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpTokenCharKind)
     (fSharpTokenTriggerClass: Microsoft.FSharp.Compiler.SourceCodeServices.FSharpTokenTriggerClass)
     (tag: int)
     (tokenName: string)
     (fullMatchedLength: int) =
    { LeftColumn = leftColumn; RightColumn = rightColumn; ColorClass = colorClass; CharClass = charClass; FSharpTokenTriggerClass = fSharpTokenTriggerClass; Tag = tag; TokenName = tokenName; FullMatchedLength = fullMatchedLength }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILAssemblyManifest".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let initILAssemblyManifest
     (name: string)
     (auxModuleHashAlgorithm: int)
     (securityDecls: Microsoft.FSharp.Compiler.AbstractIL.IL.ILPermissions)
     (publicKey: byte[] option)
     (version: (System.UInt16 * System.UInt16 * System.UInt16 * System.UInt16) option)
     (locale: string option)
     (customAttrs: Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttributes)
     (assemblyLongevity: Microsoft.FSharp.Compiler.AbstractIL.IL.ILAssemblyLongevity)
     (disableJitOptimizations: bool)
     (jitTracking: bool)
     (retargetable: bool)
     (exportedTypes: Microsoft.FSharp.Compiler.AbstractIL.IL.ILExportedTypesAndForwarders)
     (entrypointElsewhere: Microsoft.FSharp.Compiler.AbstractIL.IL.ILModuleRef option) =
    { Name = name; AuxModuleHashAlgorithm = auxModuleHashAlgorithm; SecurityDecls = securityDecls; PublicKey = publicKey; Version = version; Locale = locale; CustomAttrs = customAttrs; AssemblyLongevity = assemblyLongevity; DisableJitOptimizations = disableJitOptimizations; JitTracking = jitTracking; Retargetable = retargetable; ExportedTypes = exportedTypes; EntrypointElsewhere = entrypointElsewhere }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribute".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let initILAttribute
     (_method: Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodSpec)
     (data: byte[]) =
    { Method = _method; Data = data }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILCallingSignature".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let initILCallingSignature
     (callingConv: Microsoft.FSharp.Compiler.AbstractIL.IL.ILCallingConv)
     (argTypes: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType list)
     (returnType: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType) =
    { CallingConv = callingConv; ArgTypes = argTypes; ReturnType = returnType }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILCode".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let initILCode
     (labels: System.Collections.Generic.Dictionary<int, int>)
     (instrs: Microsoft.FSharp.Compiler.AbstractIL.IL.ILInstr[])
     (exceptions: Microsoft.FSharp.Compiler.AbstractIL.IL.ILExceptionSpec list)
     (locals: Microsoft.FSharp.Compiler.AbstractIL.IL.ILLocalDebugInfo list) =
    { Microsoft.FSharp.Compiler.AbstractIL.IL.ILCode.Labels = labels; Microsoft.FSharp.Compiler.AbstractIL.IL.ILCode.Instrs = instrs; Microsoft.FSharp.Compiler.AbstractIL.IL.ILCode.Exceptions = exceptions; Microsoft.FSharp.Compiler.AbstractIL.IL.ILCode.Locals = locals }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILEnumInfo".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let initILEnumInfo
     (enumValues: (string * Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldInit) list)
     (enumType: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType) =
    { enumValues = enumValues; enumType = enumType }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILEventDef".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let initILEventDef
     (_type: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType option)
     (name: string)
     (isRTSpecialName: bool)
     (isSpecialName: bool)
     (addMethod: Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodRef)
     (removeMethod: Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodRef)
     (fireMethod: Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodRef option)
     (otherMethods: Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodRef list)
     (customAttrs: Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttributes) =
    { Type = _type; Name = name; IsRTSpecialName = isRTSpecialName; IsSpecialName = isSpecialName; AddMethod = addMethod; RemoveMethod = removeMethod; FireMethod = fireMethod; OtherMethods = otherMethods; CustomAttrs = customAttrs }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILExceptionSpec".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let initILExceptionSpec
     (range: (int * int))
     (clause: Microsoft.FSharp.Compiler.AbstractIL.IL.ILExceptionClause) =
    { Microsoft.FSharp.Compiler.AbstractIL.IL.ILExceptionSpec.Range = range; Microsoft.FSharp.Compiler.AbstractIL.IL.ILExceptionSpec.Clause = clause }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILExportedTypeOrForwarder".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let initILExportedTypeOrForwarder
     (scopeRef: Microsoft.FSharp.Compiler.AbstractIL.IL.ILScopeRef)
     (name: string)
     (isForwarder: bool)
     (access: Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDefAccess)
     (nested: Microsoft.FSharp.Compiler.AbstractIL.IL.ILNestedExportedTypes)
     (customAttrs: Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttributes) =
    { ScopeRef = scopeRef; Name = name; IsForwarder = isForwarder; Access = access; Nested = nested; CustomAttrs = customAttrs }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldDef".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let initILFieldDef
     (name: string)
     (_type: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType)
     (isStatic: bool)
     (access: Microsoft.FSharp.Compiler.AbstractIL.IL.ILMemberAccess)
     (data: byte[] option)
     (literalValue: Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldInit option)
     (offset: int option)
     (isSpecialName: bool)
     (marshal: Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType option)
     (notSerialized: bool)
     (isLiteral: bool)
     (isInitOnly: bool)
     (customAttrs: Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttributes) =
    { Name = name; Type = _type; IsStatic = isStatic; Access = access; Data = data; LiteralValue = literalValue; Offset = offset; IsSpecialName = isSpecialName; Marshal = marshal; NotSerialized = notSerialized; IsLiteral = isLiteral; IsInitOnly = isInitOnly; CustomAttrs = customAttrs }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldRef".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let initILFieldRef
     (enclosingTypeRef: Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeRef)
     (name: string)
     (_type: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType) =
    { EnclosingTypeRef = enclosingTypeRef; Name = name; Type = _type }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldSpec".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let initILFieldSpec
     (fieldRef: Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldRef)
     (enclosingType: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType) =
    { FieldRef = fieldRef; EnclosingType = enclosingType }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILGenericParameterDef".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let initILGenericParameterDef
     (name: string)
     (constraints: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType list)
     (variance: Microsoft.FSharp.Compiler.AbstractIL.IL.ILGenericVariance)
     (hasReferenceTypeConstraint: bool)
     (customAttrs: Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttributes)
     (hasNotNullableValueTypeConstraint: bool)
     (hasDefaultConstructorConstraint: bool) =
    { Name = name; Constraints = constraints; Variance = variance; HasReferenceTypeConstraint = hasReferenceTypeConstraint; CustomAttrs = customAttrs; HasNotNullableValueTypeConstraint = hasNotNullableValueTypeConstraint; HasDefaultConstructorConstraint = hasDefaultConstructorConstraint }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILGlobals".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let initILGlobals
     (traits: Microsoft.FSharp.Compiler.AbstractIL.IL.IPrimaryAssemblyTraits)
     (primaryAssemblyName: string)
     (noDebugData: bool)
     (tref_Object: Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeRef)
     (tspec_Object: Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeSpec)
     (typ_Object: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType)
     (tref_String: Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeRef)
     (typ_String: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType)
     (typ_StringBuilder: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType)
     (typ_AsyncCallback: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType)
     (typ_IAsyncResult: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType)
     (typ_IComparable: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType)
     (tref_Type: Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeRef)
     (typ_Type: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType)
     (typ_Missing: System.Lazy<Microsoft.FSharp.Compiler.AbstractIL.IL.ILType>)
     (typ_Activator: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType)
     (typ_Delegate: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType)
     (typ_ValueType: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType)
     (typ_Enum: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType)
     (tspec_TypedReference: Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeSpec option)
     (typ_TypedReference: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType option)
     (typ_MulticastDelegate: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType)
     (typ_Array: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType)
     (tspec_Int64: Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeSpec)
     (tspec_UInt64: Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeSpec)
     (tspec_Int32: Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeSpec)
     (tspec_UInt32: Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeSpec)
     (tspec_Int16: Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeSpec)
     (tspec_UInt16: Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeSpec)
     (tspec_SByte: Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeSpec)
     (tspec_Byte: Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeSpec)
     (tspec_Single: Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeSpec)
     (tspec_Double: Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeSpec)
     (tspec_IntPtr: Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeSpec)
     (tspec_UIntPtr: Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeSpec)
     (tspec_Char: Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeSpec)
     (tspec_Bool: Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeSpec)
     (typ_int8: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType)
     (typ_int16: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType)
     (typ_int32: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType)
     (typ_int64: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType)
     (typ_uint8: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType)
     (typ_uint16: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType)
     (typ_uint32: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType)
     (typ_uint64: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType)
     (typ_float32: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType)
     (typ_float64: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType)
     (typ_bool: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType)
     (typ_char: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType)
     (typ_IntPtr: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType)
     (typ_UIntPtr: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType)
     (typ_RuntimeArgumentHandle: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType option)
     (typ_RuntimeTypeHandle: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType)
     (typ_RuntimeMethodHandle: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType)
     (typ_RuntimeFieldHandle: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType)
     (typ_Byte: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType)
     (typ_Int16: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType)
     (typ_Int32: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType)
     (typ_Int64: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType)
     (typ_SByte: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType)
     (typ_UInt16: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType)
     (typ_UInt32: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType)
     (typ_UInt64: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType)
     (typ_Single: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType)
     (typ_Double: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType)
     (typ_Bool: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType)
     (typ_Char: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType)
     (typ_SerializationInfo: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType option)
     (typ_StreamingContext: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType)
     (tref_SecurityPermissionAttribute: Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeRef option)
     (tspec_Exception: Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeSpec)
     (typ_Exception: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType)
     (generatedAttribsCache: Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribute list)
     (debuggerBrowsableNeverAttributeCache: Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribute option)
     (debuggerTypeProxyAttributeCache: Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttribute option) =
    { traits = traits; primaryAssemblyName = primaryAssemblyName; noDebugData = noDebugData; tref_Object = tref_Object; tspec_Object = tspec_Object; typ_Object = typ_Object; tref_String = tref_String; typ_String = typ_String; typ_StringBuilder = typ_StringBuilder; typ_AsyncCallback = typ_AsyncCallback; typ_IAsyncResult = typ_IAsyncResult; typ_IComparable = typ_IComparable; tref_Type = tref_Type; typ_Type = typ_Type; typ_Missing = typ_Missing; typ_Activator = typ_Activator; typ_Delegate = typ_Delegate; typ_ValueType = typ_ValueType; typ_Enum = typ_Enum; tspec_TypedReference = tspec_TypedReference; typ_TypedReference = typ_TypedReference; typ_MulticastDelegate = typ_MulticastDelegate; typ_Array = typ_Array; tspec_Int64 = tspec_Int64; tspec_UInt64 = tspec_UInt64; tspec_Int32 = tspec_Int32; tspec_UInt32 = tspec_UInt32; tspec_Int16 = tspec_Int16; tspec_UInt16 = tspec_UInt16; tspec_SByte = tspec_SByte; tspec_Byte = tspec_Byte; tspec_Single = tspec_Single; tspec_Double = tspec_Double; tspec_IntPtr = tspec_IntPtr; tspec_UIntPtr = tspec_UIntPtr; tspec_Char = tspec_Char; tspec_Bool = tspec_Bool; typ_int8 = typ_int8; typ_int16 = typ_int16; typ_int32 = typ_int32; typ_int64 = typ_int64; typ_uint8 = typ_uint8; typ_uint16 = typ_uint16; typ_uint32 = typ_uint32; typ_uint64 = typ_uint64; typ_float32 = typ_float32; typ_float64 = typ_float64; typ_bool = typ_bool; typ_char = typ_char; typ_IntPtr = typ_IntPtr; typ_UIntPtr = typ_UIntPtr; typ_RuntimeArgumentHandle = typ_RuntimeArgumentHandle; typ_RuntimeTypeHandle = typ_RuntimeTypeHandle; typ_RuntimeMethodHandle = typ_RuntimeMethodHandle; typ_RuntimeFieldHandle = typ_RuntimeFieldHandle; typ_Byte = typ_Byte; typ_Int16 = typ_Int16; typ_Int32 = typ_Int32; typ_Int64 = typ_Int64; typ_SByte = typ_SByte; typ_UInt16 = typ_UInt16; typ_UInt32 = typ_UInt32; typ_UInt64 = typ_UInt64; typ_Single = typ_Single; typ_Double = typ_Double; typ_Bool = typ_Bool; typ_Char = typ_Char; typ_SerializationInfo = typ_SerializationInfo; typ_StreamingContext = typ_StreamingContext; tref_SecurityPermissionAttribute = tref_SecurityPermissionAttribute; tspec_Exception = tspec_Exception; typ_Exception = typ_Exception; generatedAttribsCache = generatedAttribsCache; debuggerBrowsableNeverAttributeCache = debuggerBrowsableNeverAttributeCache; debuggerTypeProxyAttributeCache = debuggerTypeProxyAttributeCache }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILLocal".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let initILLocal
     (_type: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType)
     (isPinned: bool)
     (debugInfo: (string * int * int) option) =
    { Microsoft.FSharp.Compiler.AbstractIL.IL.ILLocal.Type = _type; Microsoft.FSharp.Compiler.AbstractIL.IL.ILLocal.IsPinned = isPinned; Microsoft.FSharp.Compiler.AbstractIL.IL.ILLocal.DebugInfo = debugInfo }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILLocalDebugInfo".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let initILLocalDebugInfo
     (range: (int * int))
     (debugMappings: Microsoft.FSharp.Compiler.AbstractIL.IL.ILLocalDebugMapping list) =
    { Microsoft.FSharp.Compiler.AbstractIL.IL.ILLocalDebugInfo.Range = range; Microsoft.FSharp.Compiler.AbstractIL.IL.ILLocalDebugInfo.DebugMappings = debugMappings }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILLocalDebugMapping".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let initILLocalDebugMapping
     (localIndex: int)
     (localName: string) =
    { Microsoft.FSharp.Compiler.AbstractIL.IL.ILLocalDebugMapping.LocalIndex = localIndex; Microsoft.FSharp.Compiler.AbstractIL.IL.ILLocalDebugMapping.LocalName = localName }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodBody".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let initILMethodBody
     (isZeroInit: bool)
     (maxStack: int)
     (noInlining: bool)
     (locals: Microsoft.FSharp.Compiler.AbstractIL.IL.ILLocal list)
     (code: Microsoft.FSharp.Compiler.AbstractIL.IL.ILCode)
     (sourceMarker: Microsoft.FSharp.Compiler.AbstractIL.IL.ILSourceMarker option) =
    { Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodBody.IsZeroInit = isZeroInit; Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodBody.MaxStack = maxStack; Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodBody.NoInlining = noInlining; Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodBody.Locals = locals; Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodBody.Code = code; Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodBody.SourceMarker = sourceMarker }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodDef".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let initILMethodDef
     (name: string)
     (mdKind: Microsoft.FSharp.Compiler.AbstractIL.IL.MethodKind)
     (callingConv: Microsoft.FSharp.Compiler.AbstractIL.IL.ILCallingConv)
     (parameters: Microsoft.FSharp.Compiler.AbstractIL.IL.ILParameter list)
     (_return: Microsoft.FSharp.Compiler.AbstractIL.IL.ILReturn)
     (access: Microsoft.FSharp.Compiler.AbstractIL.IL.ILMemberAccess)
     (mdBody: Microsoft.FSharp.Compiler.AbstractIL.IL.ILLazyMethodBody)
     (mdCodeKind: Microsoft.FSharp.Compiler.AbstractIL.IL.MethodCodeKind)
     (isInternalCall: bool)
     (isManaged: bool)
     (isForwardRef: bool)
     (securityDecls: Microsoft.FSharp.Compiler.AbstractIL.IL.ILPermissions)
     (hasSecurity: bool)
     (isEntryPoint: bool)
     (isReqSecObj: bool)
     (isHideBySig: bool)
     (isSpecialName: bool)
     (isUnmanagedExport: bool)
     (isSynchronized: bool)
     (isPreserveSig: bool)
     (isMustRun: bool)
     (isNoInline: bool)
     (genericParams: Microsoft.FSharp.Compiler.AbstractIL.IL.ILGenericParameterDef list)
     (customAttrs: Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttributes) =
    { Name = name; mdKind = mdKind; CallingConv = callingConv; Parameters = parameters; Return = _return; Access = access; mdBody = mdBody; mdCodeKind = mdCodeKind; IsInternalCall = isInternalCall; IsManaged = isManaged; IsForwardRef = isForwardRef; SecurityDecls = securityDecls; HasSecurity = hasSecurity; IsEntryPoint = isEntryPoint; IsReqSecObj = isReqSecObj; IsHideBySig = isHideBySig; IsSpecialName = isSpecialName; IsUnmanagedExport = isUnmanagedExport; IsSynchronized = isSynchronized; IsPreserveSig = isPreserveSig; IsMustRun = isMustRun; IsNoInline = isNoInline; GenericParams = genericParams; CustomAttrs = customAttrs }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodImplDef".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let initILMethodImplDef
     (overrides: Microsoft.FSharp.Compiler.AbstractIL.IL.ILOverridesSpec)
     (overrideBy: Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodSpec) =
    { Overrides = overrides; OverrideBy = overrideBy }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodVirtualInfo".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let initILMethodVirtualInfo
     (isFinal: bool)
     (isNewSlot: bool)
     (isCheckAccessOnOverride: bool)
     (isAbstract: bool) =
    { IsFinal = isFinal; IsNewSlot = isNewSlot; IsCheckAccessOnOverride = isCheckAccessOnOverride; IsAbstract = isAbstract }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILModuleDef".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let initILModuleDef
     (manifest: Microsoft.FSharp.Compiler.AbstractIL.IL.ILAssemblyManifest option)
     (customAttrs: Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttributes)
     (name: string)
     (typeDefs: Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDefs)
     (subsystemVersion: (int * int))
     (useHighEntropyVA: bool)
     (subSystemFlags: int)
     (isDLL: bool)
     (isILOnly: bool)
     (platform: Microsoft.FSharp.Compiler.AbstractIL.IL.ILPlatform option)
     (stackReserveSize: int option)
     (is32Bit: bool)
     (is32BitPreferred: bool)
     (is64Bit: bool)
     (virtualAlignment: int)
     (physicalAlignment: int)
     (imageBase: int)
     (metadataVersion: string)
     (resources: Microsoft.FSharp.Compiler.AbstractIL.IL.ILResources)
     (nativeResources: System.Lazy<byte[]> list) =
    { Manifest = manifest; CustomAttrs = customAttrs; Name = name; TypeDefs = typeDefs; SubsystemVersion = subsystemVersion; UseHighEntropyVA = useHighEntropyVA; SubSystemFlags = subSystemFlags; IsDLL = isDLL; IsILOnly = isILOnly; Platform = platform; StackReserveSize = stackReserveSize; Is32Bit = is32Bit; Is32BitPreferred = is32BitPreferred; Is64Bit = is64Bit; VirtualAlignment = virtualAlignment; PhysicalAlignment = physicalAlignment; ImageBase = imageBase; MetadataVersion = metadataVersion; Resources = resources; NativeResources = nativeResources }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILNestedExportedType".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let initILNestedExportedType
     (name: string)
     (access: Microsoft.FSharp.Compiler.AbstractIL.IL.ILMemberAccess)
     (nested: Microsoft.FSharp.Compiler.AbstractIL.IL.ILNestedExportedTypes)
     (customAttrs: Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttributes) =
    { Name = name; Access = access; Nested = nested; CustomAttrs = customAttrs }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILParameter".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let initILParameter
     (name: string option)
     (_type: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType)
     (_default: Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldInit option)
     (marshal: Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType option)
     (isIn: bool)
     (isOut: bool)
     (isOptional: bool)
     (customAttrs: Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttributes) =
    { Microsoft.FSharp.Compiler.AbstractIL.IL.ILParameter.Name = name; Microsoft.FSharp.Compiler.AbstractIL.IL.ILParameter.Type = _type; Microsoft.FSharp.Compiler.AbstractIL.IL.ILParameter.Default = _default; Microsoft.FSharp.Compiler.AbstractIL.IL.ILParameter.Marshal = marshal; Microsoft.FSharp.Compiler.AbstractIL.IL.ILParameter.IsIn = isIn; Microsoft.FSharp.Compiler.AbstractIL.IL.ILParameter.IsOut = isOut; Microsoft.FSharp.Compiler.AbstractIL.IL.ILParameter.IsOptional = isOptional; Microsoft.FSharp.Compiler.AbstractIL.IL.ILParameter.CustomAttrs = customAttrs }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILPropertyDef".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let initILPropertyDef
     (name: string)
     (isRTSpecialName: bool)
     (isSpecialName: bool)
     (setMethod: Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodRef option)
     (getMethod: Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodRef option)
     (callingConv: Microsoft.FSharp.Compiler.AbstractIL.IL.ILThisConvention)
     (_type: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType)
     (init: Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldInit option)
     (args: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType list)
     (customAttrs: Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttributes) =
    { Name = name; IsRTSpecialName = isRTSpecialName; IsSpecialName = isSpecialName; SetMethod = setMethod; GetMethod = getMethod; CallingConv = callingConv; Type = _type; Init = init; Args = args; CustomAttrs = customAttrs }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILReferences".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let initILReferences
     (assemblyReferences: Microsoft.FSharp.Compiler.AbstractIL.IL.ILAssemblyRef list)
     (moduleReferences: Microsoft.FSharp.Compiler.AbstractIL.IL.ILModuleRef list) =
    { AssemblyReferences = assemblyReferences; ModuleReferences = moduleReferences }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILResource".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let initILResource
     (name: string)
     (location: Microsoft.FSharp.Compiler.AbstractIL.IL.ILResourceLocation)
     (access: Microsoft.FSharp.Compiler.AbstractIL.IL.ILResourceAccess)
     (customAttrs: Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttributes) =
    { Name = name; Location = location; Access = access; CustomAttrs = customAttrs }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILReturn".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let initILReturn
     (marshal: Microsoft.FSharp.Compiler.AbstractIL.IL.ILNativeType option)
     (_type: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType)
     (customAttrs: Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttributes) =
    { Microsoft.FSharp.Compiler.AbstractIL.IL.ILReturn.Marshal = marshal; Microsoft.FSharp.Compiler.AbstractIL.IL.ILReturn.Type = _type; Microsoft.FSharp.Compiler.AbstractIL.IL.ILReturn.CustomAttrs = customAttrs }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDef".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let initILTypeDef
     (tdKind: Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDefKind)
     (name: string)
     (genericParams: Microsoft.FSharp.Compiler.AbstractIL.IL.ILGenericParameterDef list)
     (access: Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDefAccess)
     (isAbstract: bool)
     (isSealed: bool)
     (isSerializable: bool)
     (isComInterop: bool)
     (layout: Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDefLayout)
     (isSpecialName: bool)
     (encoding: Microsoft.FSharp.Compiler.AbstractIL.IL.ILDefaultPInvokeEncoding)
     (nestedTypes: Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDefs)
     (implements: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType list)
     (extends: Microsoft.FSharp.Compiler.AbstractIL.IL.ILType option)
     (methods: Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodDefs)
     (securityDecls: Microsoft.FSharp.Compiler.AbstractIL.IL.ILPermissions)
     (hasSecurity: bool)
     (fields: Microsoft.FSharp.Compiler.AbstractIL.IL.ILFieldDefs)
     (methodImpls: Microsoft.FSharp.Compiler.AbstractIL.IL.ILMethodImplDefs)
     (initSemantics: Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeInit)
     (events: Microsoft.FSharp.Compiler.AbstractIL.IL.ILEventDefs)
     (properties: Microsoft.FSharp.Compiler.AbstractIL.IL.ILPropertyDefs)
     (customAttrs: Microsoft.FSharp.Compiler.AbstractIL.IL.ILAttributes) =
    { tdKind = tdKind; Name = name; GenericParams = genericParams; Access = access; IsAbstract = isAbstract; IsSealed = isSealed; IsSerializable = isSerializable; IsComInterop = isComInterop; Layout = layout; IsSpecialName = isSpecialName; Encoding = encoding; NestedTypes = nestedTypes; Implements = implements; Extends = extends; Methods = methods; SecurityDecls = securityDecls; HasSecurity = hasSecurity; Fields = fields; MethodImpls = methodImpls; InitSemantics = initSemantics; Events = events; Properties = properties; CustomAttrs = customAttrs }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.ILTypeDefLayoutInfo".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let initILTypeDefLayoutInfo
     (size: int option)
     (pack: System.UInt16 option) =
    { Size = size; Pack = pack }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.MemberFlags".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let initMemberFlags
     (isInstance: bool)
     (isDispatchSlot: bool)
     (isOverrideOrExplicitImpl: bool)
     (isFinal: bool)
     (memberKind: Microsoft.FSharp.Compiler.Ast.MemberKind) =
    { IsInstance = isInstance; IsDispatchSlot = isDispatchSlot; IsOverrideOrExplicitImpl = isOverrideOrExplicitImpl; IsFinal = isFinal; MemberKind = memberKind }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.AbstractIL.IL.PInvokeMethod".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let initPInvokeMethod
     (where: Microsoft.FSharp.Compiler.AbstractIL.IL.ILModuleRef)
     (name: string)
     (callingConv: Microsoft.FSharp.Compiler.AbstractIL.IL.PInvokeCallingConvention)
     (charEncoding: Microsoft.FSharp.Compiler.AbstractIL.IL.PInvokeCharEncoding)
     (noMangle: bool)
     (lastError: bool)
     (throwOnUnmappableChar: Microsoft.FSharp.Compiler.AbstractIL.IL.PInvokeThrowOnUnmappableChar)
     (charBestFit: Microsoft.FSharp.Compiler.AbstractIL.IL.PInvokeCharBestFit) =
    { Microsoft.FSharp.Compiler.AbstractIL.IL.PInvokeMethod.Where = where; Microsoft.FSharp.Compiler.AbstractIL.IL.PInvokeMethod.Name = name; Microsoft.FSharp.Compiler.AbstractIL.IL.PInvokeMethod.CallingConv = callingConv; Microsoft.FSharp.Compiler.AbstractIL.IL.PInvokeMethod.CharEncoding = charEncoding; Microsoft.FSharp.Compiler.AbstractIL.IL.PInvokeMethod.NoMangle = noMangle; Microsoft.FSharp.Compiler.AbstractIL.IL.PInvokeMethod.LastError = lastError; Microsoft.FSharp.Compiler.AbstractIL.IL.PInvokeMethod.ThrowOnUnmappableChar = throwOnUnmappableChar; Microsoft.FSharp.Compiler.AbstractIL.IL.PInvokeMethod.CharBestFit = charBestFit }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.ErrorLogger.PhasedError".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let initPhasedError
     (_exception: System.Exception)
     (phase: Microsoft.FSharp.Compiler.ErrorLogger.BuildPhase) =
    { Exception = _exception; Phase = phase }

  /// <summary>
  /// Construct "Microsoft.FSharp.Compiler.Ast.SynAttribute".
  /// </summary>
  /// <returns>Constructed record.</returns>
  let initSynAttribute
     (typeName: Microsoft.FSharp.Compiler.Ast.LongIdentWithDots)
     (argExpr: Microsoft.FSharp.Compiler.Ast.SynExpr)
     (target: Microsoft.FSharp.Compiler.Ast.Ident option)
     (appliesToGetterAndSetter: bool)
     (range: Microsoft.FSharp.Compiler.Range.range) =
    { Microsoft.FSharp.Compiler.Ast.SynAttribute.TypeName = typeName; Microsoft.FSharp.Compiler.Ast.SynAttribute.ArgExpr = argExpr; Microsoft.FSharp.Compiler.Ast.SynAttribute.Target = target; Microsoft.FSharp.Compiler.Ast.SynAttribute.AppliesToGetterAndSetter = appliesToGetterAndSetter; Microsoft.FSharp.Compiler.Ast.SynAttribute.Range = range }

