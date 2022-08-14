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

namespace Dova.JDK.org.objectweb.asm;

[JniSignatureAttribute("Lorg/objectweb/asm/ByteVector;", "public")]
public partial class ByteVector
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ByteVector()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lorg/objectweb/asm/ByteVector;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "data", "[B"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "length", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([B)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(I)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putByte", "(I)Lorg/objectweb/asm/ByteVector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putShort", "(I)Lorg/objectweb/asm/ByteVector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putInt", "(I)Lorg/objectweb/asm/ByteVector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putLong", "(J)Lorg/objectweb/asm/ByteVector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "size", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "put12", "(II)Lorg/objectweb/asm/ByteVector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putByteArray", "([BII)Lorg/objectweb/asm/ByteVector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "enlarge", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "encodeUtf8", "(Ljava/lang/String;II)Lorg/objectweb/asm/ByteVector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "put11", "(II)Lorg/objectweb/asm/ByteVector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "put112", "(III)Lorg/objectweb/asm/ByteVector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "put122", "(III)Lorg/objectweb/asm/ByteVector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putUTF8", "(Ljava/lang/String;)Lorg/objectweb/asm/ByteVector;"));
	}

	[JniSignatureAttribute("[B", "")]
	public JavaArray<byte> data_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int length_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ByteVector(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("([B)V", "")]
	public ByteVector(JavaArray<byte> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	[JniSignatureAttribute("(I)V", "public")]
	public ByteVector(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public ByteVector() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2]))
	{
	}

	public override string GetJavaClassSignature() => "Lorg/objectweb/asm/ByteVector;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(I)Lorg/objectweb/asm/ByteVector;", "public")]
	public Dova.JDK.org.objectweb.asm.ByteVector putByte(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.org.objectweb.asm.ByteVector>(ret);
	}

	[JniSignatureAttribute("(I)Lorg/objectweb/asm/ByteVector;", "public")]
	public Dova.JDK.org.objectweb.asm.ByteVector putShort(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.org.objectweb.asm.ByteVector>(ret);
	}

	[JniSignatureAttribute("(I)Lorg/objectweb/asm/ByteVector;", "public")]
	public Dova.JDK.org.objectweb.asm.ByteVector putInt(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.org.objectweb.asm.ByteVector>(ret);
	}

	[JniSignatureAttribute("(J)Lorg/objectweb/asm/ByteVector;", "public")]
	public Dova.JDK.org.objectweb.asm.ByteVector putLong(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.org.objectweb.asm.ByteVector>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int size()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
		return ret;
	}

	[JniSignatureAttribute("(II)Lorg/objectweb/asm/ByteVector;", "final")]
	public Dova.JDK.org.objectweb.asm.ByteVector put12(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.org.objectweb.asm.ByteVector>(ret);
	}

	[JniSignatureAttribute("([BII)Lorg/objectweb/asm/ByteVector;", "public")]
	public Dova.JDK.org.objectweb.asm.ByteVector putByteArray(JavaArray<byte> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.org.objectweb.asm.ByteVector>(ret);
	}

	[JniSignatureAttribute("(I)V", "private")]
	public void enlarge(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;II)Lorg/objectweb/asm/ByteVector;", "final")]
	public Dova.JDK.org.objectweb.asm.ByteVector encodeUtf8(Dova.JDK.java.lang.String arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.org.objectweb.asm.ByteVector>(ret);
	}

	[JniSignatureAttribute("(II)Lorg/objectweb/asm/ByteVector;", "final")]
	public Dova.JDK.org.objectweb.asm.ByteVector put11(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.org.objectweb.asm.ByteVector>(ret);
	}

	[JniSignatureAttribute("(III)Lorg/objectweb/asm/ByteVector;", "final")]
	public Dova.JDK.org.objectweb.asm.ByteVector put112(int arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.org.objectweb.asm.ByteVector>(ret);
	}

	[JniSignatureAttribute("(III)Lorg/objectweb/asm/ByteVector;", "final")]
	public Dova.JDK.org.objectweb.asm.ByteVector put122(int arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.org.objectweb.asm.ByteVector>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lorg/objectweb/asm/ByteVector;", "public")]
	public Dova.JDK.org.objectweb.asm.ByteVector putUTF8(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.org.objectweb.asm.ByteVector>(ret);
	}
}
