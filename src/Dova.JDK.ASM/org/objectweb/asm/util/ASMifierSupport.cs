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

namespace Dova.JDK.org.objectweb.asm.util;

[JniSignatureAttribute("Lorg/objectweb/asm/util/ASMifierSupport;", "public abstract interface")]
public partial interface ASMifierSupport
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ASMifierSupport()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lorg/objectweb/asm/util/ASMifierSupport;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asmify", "(Ljava/lang/StringBuilder;Ljava/lang/String;Ljava/util/Map;)V"));
	}

	[JniSignatureAttribute("(Ljava/lang/StringBuilder;Ljava/lang/String;Ljava/util/Map;)V", "public abstract")]
	void asmify(Dova.JDK.java.lang.StringBuilder arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.util.Map arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
	}
}
