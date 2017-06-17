using System;
using System.Runtime.InteropServices;
using ObjCRuntime;
using YYModel;

namespace YYModel
{
	[Native]
	public enum YYEncodingType : nuint
	{
		Mask = 255,
		Unknown = 0,
		Void = 1,
		Bool = 2,
		Int8 = 3,
		UInt8 = 4,
		Int16 = 5,
		UInt16 = 6,
		Int32 = 7,
		UInt32 = 8,
		Int64 = 9,
		UInt64 = 10,
		Float = 11,
		Double = 12,
		LongDouble = 13,
		Object = 14,
		Class = 15,
		Sel = 16,
		Block = 17,
		Pointer = 18,
		Struct = 19,
		Union = 20,
		CString = 21,
		CArray = 22,
		QualifierMask = 65280,
		QualifierConst = 1 << 8,
		QualifierIn = 1 << 9,
		QualifierInout = 1 << 10,
		QualifierOut = 1 << 11,
		QualifierBycopy = 1 << 12,
		QualifierByref = 1 << 13,
		QualifierOneway = 1 << 14,
		PropertyMask = 16711680,
		PropertyReadonly = 1 << 16,
		PropertyCopy = 1 << 17,
		PropertyRetain = 1 << 18,
		PropertyNonatomic = 1 << 19,
		PropertyWeak = 1 << 20,
		PropertyCustomGetter = 1 << 21,
		PropertyCustomSetter = 1 << 22,
		PropertyDynamic = 1 << 23
	}

	static class CFunctions
	{
		// extern YYEncodingType YYEncodingGetType (const char * _Nonnull typeEncoding);
		[DllImport ("__Internal")]
		[Verify (PlatformInvoke)]
		static extern unsafe YYEncodingType YYEncodingGetType (sbyte* typeEncoding);
	}
}
