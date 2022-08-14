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

[JniSignatureAttribute("Lorg/objectweb/asm/tree/analysis/Analyzer;", "public")]
public partial class Analyzer
	: Dova.JDK.java.lang.Object
	, Dova.JDK.org.objectweb.asm.Opcodes
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Analyzer()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lorg/objectweb/asm/tree/analysis/Analyzer;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "interpreter", "Lorg/objectweb/asm/tree/analysis/Interpreter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "insnList", "Lorg/objectweb/asm/tree/InsnList;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "insnListSize", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "handlers", "[Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "frames", "[Lorg/objectweb/asm/tree/analysis/Frame;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "subroutines", "[Lorg/objectweb/asm/tree/analysis/Subroutine;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "inInstructionsToProcess", "[Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "instructionsToProcess", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "numInstructionsToProcess", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lorg/objectweb/asm/tree/analysis/Interpreter;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "merge", "(ILorg/objectweb/asm/tree/analysis/Frame;Lorg/objectweb/asm/tree/analysis/Subroutine;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "merge", "(ILorg/objectweb/asm/tree/analysis/Frame;Lorg/objectweb/asm/tree/analysis/Frame;Lorg/objectweb/asm/tree/analysis/Subroutine;[Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "init", "(Ljava/lang/String;Lorg/objectweb/asm/tree/MethodNode;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHandlers", "(I)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "analyze", "(Ljava/lang/String;Lorg/objectweb/asm/tree/MethodNode;)[Lorg/objectweb/asm/tree/analysis/Frame;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findSubroutine", "(ILorg/objectweb/asm/tree/analysis/Subroutine;Ljava/util/List;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "computeInitialFrame", "(Ljava/lang/String;Lorg/objectweb/asm/tree/MethodNode;)Lorg/objectweb/asm/tree/analysis/Frame;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newControlFlowEdge", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newControlFlowExceptionEdge", "(II)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newControlFlowExceptionEdge", "(ILorg/objectweb/asm/tree/TryCatchBlockNode;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newFrame", "(Lorg/objectweb/asm/tree/analysis/Frame;)Lorg/objectweb/asm/tree/analysis/Frame;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newFrame", "(II)Lorg/objectweb/asm/tree/analysis/Frame;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "analyzeAndComputeMaxs", "(Ljava/lang/String;Lorg/objectweb/asm/tree/MethodNode;)[Lorg/objectweb/asm/tree/analysis/Frame;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "computeMaxLocals", "(Lorg/objectweb/asm/tree/MethodNode;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "computeMaxStack", "([Lorg/objectweb/asm/tree/analysis/Frame;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFrames", "()[Lorg/objectweb/asm/tree/analysis/Frame;"));
	}

	[JniSignatureAttribute("Lorg/objectweb/asm/tree/analysis/Interpreter;", "private final")]
	public Dova.JDK.org.objectweb.asm.tree.analysis.Interpreter interpreter_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.org.objectweb.asm.tree.analysis.Interpreter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lorg/objectweb/asm/tree/InsnList;", "private")]
	public Dova.JDK.org.objectweb.asm.tree.InsnList insnList_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.org.objectweb.asm.tree.InsnList>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int insnListSize_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("[Ljava/util/List;", "private")]
	public JavaArray<Dova.JDK.java.util.List> handlers_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.util.List>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lorg/objectweb/asm/tree/analysis/Frame;", "private")]
	public JavaArray<Dova.JDK.org.objectweb.asm.tree.analysis.Frame> frames_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.org.objectweb.asm.tree.analysis.Frame>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lorg/objectweb/asm/tree/analysis/Subroutine;", "private")]
	public JavaArray<Dova.JDK.org.objectweb.asm.tree.analysis.Subroutine> subroutines_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.org.objectweb.asm.tree.analysis.Subroutine>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Z", "private")]
	public JavaArray<bool> inInstructionsToProcess_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<JavaArray<bool>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[I", "private")]
	public JavaArray<int> instructionsToProcess_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int numInstructionsToProcess_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[8]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[8], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Analyzer(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lorg/objectweb/asm/tree/analysis/Interpreter;)V", "public")]
	public Analyzer(Dova.JDK.org.objectweb.asm.tree.analysis.Interpreter arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lorg/objectweb/asm/tree/analysis/Analyzer;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(ILorg/objectweb/asm/tree/analysis/Frame;Lorg/objectweb/asm/tree/analysis/Subroutine;)V", "private")]
	public void merge(int arg0, Dova.JDK.org.objectweb.asm.tree.analysis.Frame arg1, Dova.JDK.org.objectweb.asm.tree.analysis.Subroutine arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(ILorg/objectweb/asm/tree/analysis/Frame;Lorg/objectweb/asm/tree/analysis/Frame;Lorg/objectweb/asm/tree/analysis/Subroutine;[Z)V", "private")]
	public void merge(int arg0, Dova.JDK.org.objectweb.asm.tree.analysis.Frame arg1, Dova.JDK.org.objectweb.asm.tree.analysis.Frame arg2, Dova.JDK.org.objectweb.asm.tree.analysis.Subroutine arg3, JavaArray<bool> arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lorg/objectweb/asm/tree/MethodNode;)V", "protected")]
	public void init(Dova.JDK.java.lang.String arg0, Dova.JDK.org.objectweb.asm.tree.MethodNode arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
	}

	[JniSignatureAttribute("(I)Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List getHandlers(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lorg/objectweb/asm/tree/MethodNode;)[Lorg/objectweb/asm/tree/analysis/Frame;", "public")]
	public JavaArray<Dova.JDK.org.objectweb.asm.tree.analysis.Frame> analyze(Dova.JDK.java.lang.String arg0, Dova.JDK.org.objectweb.asm.tree.MethodNode arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.org.objectweb.asm.tree.analysis.Frame>>(ret);
	}

	[JniSignatureAttribute("(ILorg/objectweb/asm/tree/analysis/Subroutine;Ljava/util/List;)V", "private")]
	public void findSubroutine(int arg0, Dova.JDK.org.objectweb.asm.tree.analysis.Subroutine arg1, Dova.JDK.java.util.List arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lorg/objectweb/asm/tree/MethodNode;)Lorg/objectweb/asm/tree/analysis/Frame;", "private")]
	public Dova.JDK.org.objectweb.asm.tree.analysis.Frame computeInitialFrame(Dova.JDK.java.lang.String arg0, Dova.JDK.org.objectweb.asm.tree.MethodNode arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.org.objectweb.asm.tree.analysis.Frame>(ret);
	}

	[JniSignatureAttribute("(II)V", "protected")]
	public void newControlFlowEdge(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
	}

	[JniSignatureAttribute("(II)Z", "protected")]
	public bool newControlFlowExceptionEdge(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(ILorg/objectweb/asm/tree/TryCatchBlockNode;)Z", "protected")]
	public bool newControlFlowExceptionEdge(int arg0, Dova.JDK.org.objectweb.asm.tree.TryCatchBlockNode arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lorg/objectweb/asm/tree/analysis/Frame;)Lorg/objectweb/asm/tree/analysis/Frame;", "protected")]
	public Dova.JDK.org.objectweb.asm.tree.analysis.Frame newFrame(Dova.JDK.org.objectweb.asm.tree.analysis.Frame arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.org.objectweb.asm.tree.analysis.Frame>(ret);
	}

	[JniSignatureAttribute("(II)Lorg/objectweb/asm/tree/analysis/Frame;", "protected")]
	public Dova.JDK.org.objectweb.asm.tree.analysis.Frame newFrame(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.org.objectweb.asm.tree.analysis.Frame>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lorg/objectweb/asm/tree/MethodNode;)[Lorg/objectweb/asm/tree/analysis/Frame;", "public")]
	public JavaArray<Dova.JDK.org.objectweb.asm.tree.analysis.Frame> analyzeAndComputeMaxs(Dova.JDK.java.lang.String arg0, Dova.JDK.org.objectweb.asm.tree.MethodNode arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.org.objectweb.asm.tree.analysis.Frame>>(ret);
	}

	[JniSignatureAttribute("(Lorg/objectweb/asm/tree/MethodNode;)I", "private static")]
	public static int computeMaxLocals(Dova.JDK.org.objectweb.asm.tree.MethodNode arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[13], arg0);
		return ret;
	}

	[JniSignatureAttribute("([Lorg/objectweb/asm/tree/analysis/Frame;)I", "private static")]
	public static int computeMaxStack(JavaArray<Dova.JDK.org.objectweb.asm.tree.analysis.Frame> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[14], arg0);
		return ret;
	}

	[JniSignatureAttribute("()[Lorg/objectweb/asm/tree/analysis/Frame;", "public")]
	public JavaArray<Dova.JDK.org.objectweb.asm.tree.analysis.Frame> getFrames()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.org.objectweb.asm.tree.analysis.Frame>>(ret);
	}
}
