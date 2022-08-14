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

[JniSignatureAttribute("Lorg/objectweb/asm/util/TextifierSupport;", "public abstract interface")]
public partial interface TextifierSupport
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static TextifierSupport()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lorg/objectweb/asm/util/TextifierSupport;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "textify", "(Ljava/lang/StringBuilder;Ljava/util/Map;)V"));
	}

	[JniSignatureAttribute("(Ljava/lang/StringBuilder;Ljava/util/Map;)V", "public abstract")]
	void textify(Dova.JDK.java.lang.StringBuilder arg0, Dova.JDK.java.util.Map arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
	}
}
