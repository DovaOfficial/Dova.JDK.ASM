/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.14-02:14)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.org.objectweb.asm.tree.analysis;

[JniSignatureAttribute("Lorg/objectweb/asm/tree/analysis/SourceInterpreter;", "public")]
public partial class SourceInterpreter
	: Dova.JDK.org.objectweb.asm.tree.analysis.Interpreter
	, Dova.JDK.org.objectweb.asm.Opcodes
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SourceInterpreter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lorg/objectweb/asm/tree/analysis/SourceInterpreter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "merge", "(Lorg/objectweb/asm/tree/analysis/SourceValue;Lorg/objectweb/asm/tree/analysis/SourceValue;)Lorg/objectweb/asm/tree/analysis/SourceValue;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "merge", "(Lorg/objectweb/asm/tree/analysis/Value;Lorg/objectweb/asm/tree/analysis/Value;)Lorg/objectweb/asm/tree/analysis/Value;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newValue_0", "(Lorg/objectweb/asm/Type;)Lorg/objectweb/asm/tree/analysis/Value;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newValue_1", "(Lorg/objectweb/asm/Type;)Lorg/objectweb/asm/tree/analysis/SourceValue;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "containsAll", "(Ljava/util/Set;Ljava/util/Set;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copyOperation", "(Lorg/objectweb/asm/tree/AbstractInsnNode;Lorg/objectweb/asm/tree/analysis/SourceValue;)Lorg/objectweb/asm/tree/analysis/SourceValue;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copyOperation", "(Lorg/objectweb/asm/tree/AbstractInsnNode;Lorg/objectweb/asm/tree/analysis/Value;)Lorg/objectweb/asm/tree/analysis/Value;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unaryOperation", "(Lorg/objectweb/asm/tree/AbstractInsnNode;Lorg/objectweb/asm/tree/analysis/Value;)Lorg/objectweb/asm/tree/analysis/Value;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unaryOperation", "(Lorg/objectweb/asm/tree/AbstractInsnNode;Lorg/objectweb/asm/tree/analysis/SourceValue;)Lorg/objectweb/asm/tree/analysis/SourceValue;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "binaryOperation", "(Lorg/objectweb/asm/tree/AbstractInsnNode;Lorg/objectweb/asm/tree/analysis/Value;Lorg/objectweb/asm/tree/analysis/Value;)Lorg/objectweb/asm/tree/analysis/Value;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "binaryOperation", "(Lorg/objectweb/asm/tree/AbstractInsnNode;Lorg/objectweb/asm/tree/analysis/SourceValue;Lorg/objectweb/asm/tree/analysis/SourceValue;)Lorg/objectweb/asm/tree/analysis/SourceValue;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ternaryOperation", "(Lorg/objectweb/asm/tree/AbstractInsnNode;Lorg/objectweb/asm/tree/analysis/SourceValue;Lorg/objectweb/asm/tree/analysis/SourceValue;Lorg/objectweb/asm/tree/analysis/SourceValue;)Lorg/objectweb/asm/tree/analysis/SourceValue;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ternaryOperation", "(Lorg/objectweb/asm/tree/AbstractInsnNode;Lorg/objectweb/asm/tree/analysis/Value;Lorg/objectweb/asm/tree/analysis/Value;Lorg/objectweb/asm/tree/analysis/Value;)Lorg/objectweb/asm/tree/analysis/Value;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "naryOperation_0", "(Lorg/objectweb/asm/tree/AbstractInsnNode;Ljava/util/List;)Lorg/objectweb/asm/tree/analysis/SourceValue;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "naryOperation_1", "(Lorg/objectweb/asm/tree/AbstractInsnNode;Ljava/util/List;)Lorg/objectweb/asm/tree/analysis/Value;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "returnOperation", "(Lorg/objectweb/asm/tree/AbstractInsnNode;Lorg/objectweb/asm/tree/analysis/Value;Lorg/objectweb/asm/tree/analysis/Value;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "returnOperation", "(Lorg/objectweb/asm/tree/AbstractInsnNode;Lorg/objectweb/asm/tree/analysis/SourceValue;Lorg/objectweb/asm/tree/analysis/SourceValue;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newOperation_0", "(Lorg/objectweb/asm/tree/AbstractInsnNode;)Lorg/objectweb/asm/tree/analysis/SourceValue;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newOperation_1", "(Lorg/objectweb/asm/tree/AbstractInsnNode;)Lorg/objectweb/asm/tree/analysis/Value;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SourceInterpreter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public SourceInterpreter() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	[JniSignatureAttribute("(I)V", "protected")]
	public SourceInterpreter(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lorg/objectweb/asm/tree/analysis/SourceInterpreter;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lorg/objectweb/asm/tree/analysis/SourceValue;Lorg/objectweb/asm/tree/analysis/SourceValue;)Lorg/objectweb/asm/tree/analysis/SourceValue;", "public")]
	public Dova.JDK.org.objectweb.asm.tree.analysis.SourceValue merge(Dova.JDK.org.objectweb.asm.tree.analysis.SourceValue arg0, Dova.JDK.org.objectweb.asm.tree.analysis.SourceValue arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.org.objectweb.asm.tree.analysis.SourceValue>(ret);
	}

	[JniSignatureAttribute("(Lorg/objectweb/asm/tree/analysis/Value;Lorg/objectweb/asm/tree/analysis/Value;)Lorg/objectweb/asm/tree/analysis/Value;", "public volatile")]
	public Dova.JDK.org.objectweb.asm.tree.analysis.Value merge(Dova.JDK.org.objectweb.asm.tree.analysis.Value arg0, Dova.JDK.org.objectweb.asm.tree.analysis.Value arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.org.objectweb.asm.tree.analysis.Value>(ret);
	}

	[JniSignatureAttribute("(Lorg/objectweb/asm/Type;)Lorg/objectweb/asm/tree/analysis/Value;", "public volatile")]
	public Dova.JDK.org.objectweb.asm.tree.analysis.Value newValue_0(Dova.JDK.org.objectweb.asm.Type arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.org.objectweb.asm.tree.analysis.Value>(ret);
	}

	[JniSignatureAttribute("(Lorg/objectweb/asm/Type;)Lorg/objectweb/asm/tree/analysis/SourceValue;", "public")]
	public Dova.JDK.org.objectweb.asm.tree.analysis.SourceValue newValue_1(Dova.JDK.org.objectweb.asm.Type arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.org.objectweb.asm.tree.analysis.SourceValue>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Set;Ljava/util/Set;)Z", "private static")]
	public static bool containsAll(Dova.JDK.java.util.Set arg0, Dova.JDK.java.util.Set arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lorg/objectweb/asm/tree/AbstractInsnNode;Lorg/objectweb/asm/tree/analysis/SourceValue;)Lorg/objectweb/asm/tree/analysis/SourceValue;", "public")]
	public Dova.JDK.org.objectweb.asm.tree.analysis.SourceValue copyOperation(Dova.JDK.org.objectweb.asm.tree.AbstractInsnNode arg0, Dova.JDK.org.objectweb.asm.tree.analysis.SourceValue arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.org.objectweb.asm.tree.analysis.SourceValue>(ret);
	}

	[JniSignatureAttribute("(Lorg/objectweb/asm/tree/AbstractInsnNode;Lorg/objectweb/asm/tree/analysis/Value;)Lorg/objectweb/asm/tree/analysis/Value;", "public volatile")]
	public Dova.JDK.org.objectweb.asm.tree.analysis.Value copyOperation(Dova.JDK.org.objectweb.asm.tree.AbstractInsnNode arg0, Dova.JDK.org.objectweb.asm.tree.analysis.Value arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.org.objectweb.asm.tree.analysis.Value>(ret);
	}

	[JniSignatureAttribute("(Lorg/objectweb/asm/tree/AbstractInsnNode;Lorg/objectweb/asm/tree/analysis/Value;)Lorg/objectweb/asm/tree/analysis/Value;", "public volatile")]
	public Dova.JDK.org.objectweb.asm.tree.analysis.Value unaryOperation(Dova.JDK.org.objectweb.asm.tree.AbstractInsnNode arg0, Dova.JDK.org.objectweb.asm.tree.analysis.Value arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.org.objectweb.asm.tree.analysis.Value>(ret);
	}

	[JniSignatureAttribute("(Lorg/objectweb/asm/tree/AbstractInsnNode;Lorg/objectweb/asm/tree/analysis/SourceValue;)Lorg/objectweb/asm/tree/analysis/SourceValue;", "public")]
	public Dova.JDK.org.objectweb.asm.tree.analysis.SourceValue unaryOperation(Dova.JDK.org.objectweb.asm.tree.AbstractInsnNode arg0, Dova.JDK.org.objectweb.asm.tree.analysis.SourceValue arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.org.objectweb.asm.tree.analysis.SourceValue>(ret);
	}

	[JniSignatureAttribute("(Lorg/objectweb/asm/tree/AbstractInsnNode;Lorg/objectweb/asm/tree/analysis/Value;Lorg/objectweb/asm/tree/analysis/Value;)Lorg/objectweb/asm/tree/analysis/Value;", "public volatile")]
	public Dova.JDK.org.objectweb.asm.tree.analysis.Value binaryOperation(Dova.JDK.org.objectweb.asm.tree.AbstractInsnNode arg0, Dova.JDK.org.objectweb.asm.tree.analysis.Value arg1, Dova.JDK.org.objectweb.asm.tree.analysis.Value arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.org.objectweb.asm.tree.analysis.Value>(ret);
	}

	[JniSignatureAttribute("(Lorg/objectweb/asm/tree/AbstractInsnNode;Lorg/objectweb/asm/tree/analysis/SourceValue;Lorg/objectweb/asm/tree/analysis/SourceValue;)Lorg/objectweb/asm/tree/analysis/SourceValue;", "public")]
	public Dova.JDK.org.objectweb.asm.tree.analysis.SourceValue binaryOperation(Dova.JDK.org.objectweb.asm.tree.AbstractInsnNode arg0, Dova.JDK.org.objectweb.asm.tree.analysis.SourceValue arg1, Dova.JDK.org.objectweb.asm.tree.analysis.SourceValue arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.org.objectweb.asm.tree.analysis.SourceValue>(ret);
	}

	[JniSignatureAttribute("(Lorg/objectweb/asm/tree/AbstractInsnNode;Lorg/objectweb/asm/tree/analysis/SourceValue;Lorg/objectweb/asm/tree/analysis/SourceValue;Lorg/objectweb/asm/tree/analysis/SourceValue;)Lorg/objectweb/asm/tree/analysis/SourceValue;", "public")]
	public Dova.JDK.org.objectweb.asm.tree.analysis.SourceValue ternaryOperation(Dova.JDK.org.objectweb.asm.tree.AbstractInsnNode arg0, Dova.JDK.org.objectweb.asm.tree.analysis.SourceValue arg1, Dova.JDK.org.objectweb.asm.tree.analysis.SourceValue arg2, Dova.JDK.org.objectweb.asm.tree.analysis.SourceValue arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.org.objectweb.asm.tree.analysis.SourceValue>(ret);
	}

	[JniSignatureAttribute("(Lorg/objectweb/asm/tree/AbstractInsnNode;Lorg/objectweb/asm/tree/analysis/Value;Lorg/objectweb/asm/tree/analysis/Value;Lorg/objectweb/asm/tree/analysis/Value;)Lorg/objectweb/asm/tree/analysis/Value;", "public volatile")]
	public Dova.JDK.org.objectweb.asm.tree.analysis.Value ternaryOperation(Dova.JDK.org.objectweb.asm.tree.AbstractInsnNode arg0, Dova.JDK.org.objectweb.asm.tree.analysis.Value arg1, Dova.JDK.org.objectweb.asm.tree.analysis.Value arg2, Dova.JDK.org.objectweb.asm.tree.analysis.Value arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.org.objectweb.asm.tree.analysis.Value>(ret);
	}

	[JniSignatureAttribute("(Lorg/objectweb/asm/tree/AbstractInsnNode;Ljava/util/List;)Lorg/objectweb/asm/tree/analysis/SourceValue;", "public")]
	public Dova.JDK.org.objectweb.asm.tree.analysis.SourceValue naryOperation_0(Dova.JDK.org.objectweb.asm.tree.AbstractInsnNode arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.org.objectweb.asm.tree.analysis.SourceValue>(ret);
	}

	[JniSignatureAttribute("(Lorg/objectweb/asm/tree/AbstractInsnNode;Ljava/util/List;)Lorg/objectweb/asm/tree/analysis/Value;", "public volatile")]
	public Dova.JDK.org.objectweb.asm.tree.analysis.Value naryOperation_1(Dova.JDK.org.objectweb.asm.tree.AbstractInsnNode arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.org.objectweb.asm.tree.analysis.Value>(ret);
	}

	[JniSignatureAttribute("(Lorg/objectweb/asm/tree/AbstractInsnNode;Lorg/objectweb/asm/tree/analysis/Value;Lorg/objectweb/asm/tree/analysis/Value;)V", "public volatile")]
	public void returnOperation(Dova.JDK.org.objectweb.asm.tree.AbstractInsnNode arg0, Dova.JDK.org.objectweb.asm.tree.analysis.Value arg1, Dova.JDK.org.objectweb.asm.tree.analysis.Value arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lorg/objectweb/asm/tree/AbstractInsnNode;Lorg/objectweb/asm/tree/analysis/SourceValue;Lorg/objectweb/asm/tree/analysis/SourceValue;)V", "public")]
	public void returnOperation(Dova.JDK.org.objectweb.asm.tree.AbstractInsnNode arg0, Dova.JDK.org.objectweb.asm.tree.analysis.SourceValue arg1, Dova.JDK.org.objectweb.asm.tree.analysis.SourceValue arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lorg/objectweb/asm/tree/AbstractInsnNode;)Lorg/objectweb/asm/tree/analysis/SourceValue;", "public")]
	public Dova.JDK.org.objectweb.asm.tree.analysis.SourceValue newOperation_0(Dova.JDK.org.objectweb.asm.tree.AbstractInsnNode arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.org.objectweb.asm.tree.analysis.SourceValue>(ret);
	}

	[JniSignatureAttribute("(Lorg/objectweb/asm/tree/AbstractInsnNode;)Lorg/objectweb/asm/tree/analysis/Value;", "public volatile")]
	public Dova.JDK.org.objectweb.asm.tree.analysis.Value newOperation_1(Dova.JDK.org.objectweb.asm.tree.AbstractInsnNode arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.org.objectweb.asm.tree.analysis.Value>(ret);
	}
}
