﻿using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using YYModel;

namespace YYModel
{
	// @interface YYModel (NSObject)
	[Category]
	[BaseType (typeof(NSObject))]
	interface NSObject_YYModel
	{
		// +(instancetype _Nullable)yy_modelWithJSON:(id _Nonnull)json;
		[Static]
		[Export("yy_modelWithJSON:")]
        [return: NullAllowed]
        [EditorBrowsable(EditorBrowsableState.Never)]
		NSObject Yy_modelWithJSON(NSObject json);

		// +(instancetype _Nullable)yy_modelWithDictionary:(NSDictionary * _Nonnull)dictionary;
		[Static]
		[Export("yy_modelWithDictionary:")]
		[return: NullAllowed]
		[EditorBrowsable(EditorBrowsableState.Never)]
		NSObject Yy_modelWithDictionary(NSDictionary dictionary);

		// -(BOOL)yy_modelSetWithJSON:(id _Nonnull)json;
		[Export ("yy_modelSetWithJSON:")]
		bool Yy_modelSetWithJSON (NSObject json);

		// -(BOOL)yy_modelSetWithDictionary:(NSDictionary * _Nonnull)dic;
		[Export ("yy_modelSetWithDictionary:")]
		bool Yy_modelSetWithDictionary (NSDictionary dic);

		// -(id _Nullable)yy_modelToJSONObject;
		[NullAllowed, Export ("yy_modelToJSONObject")]
		NSObject Yy_modelToJSONObject ();

		// -(NSData * _Nullable)yy_modelToJSONData;
		[NullAllowed, Export ("yy_modelToJSONData")]
		NSData Yy_modelToJSONData ();

		// -(NSString * _Nullable)yy_modelToJSONString;
		[NullAllowed, Export ("yy_modelToJSONString")]
		string Yy_modelToJSONString ();

		// -(id _Nullable)yy_modelCopy;
		[NullAllowed, Export ("yy_modelCopy")]
		NSObject Yy_modelCopy ();

		// -(void)yy_modelEncodeWithCoder:(NSCoder * _Nonnull)aCoder;
		[Export ("yy_modelEncodeWithCoder:")]
		void Yy_modelEncodeWithCoder (NSCoder aCoder);

		// -(id _Nonnull)yy_modelInitWithCoder:(NSCoder * _Nonnull)aDecoder;
		[Export ("yy_modelInitWithCoder:")]
		NSObject Yy_modelInitWithCoder (NSCoder aDecoder);

		// -(NSUInteger)yy_modelHash;
		[Export ("yy_modelHash")]
		nuint Yy_modelHash ();

		// -(BOOL)yy_modelIsEqual:(id _Nonnull)model;
		[Export ("yy_modelIsEqual:")]
		bool Yy_modelIsEqual (NSObject model);

		// -(NSString * _Nonnull)yy_modelDescription;
		[Export ("yy_modelDescription")]
		string Yy_modelDescription ();
	}

	// @interface YYModel (NSArray)
	[Category]
	[BaseType (typeof(NSArray))]
	interface NSArray_YYModel
	{
		// +(NSArray * _Nullable)yy_modelArrayWithClass:(Class _Nonnull)cls json:(id _Nonnull)json;
		[Static]
		[Export ("yy_modelArrayWithClass:json:")]
		[return: NullAllowed]
		[EditorBrowsable(EditorBrowsableState.Never)]
		NSObject[] Yy_modelArrayWithClass (Class cls, NSObject json);
	}

	// @interface YYModel (NSDictionary)
	[Category]
	[BaseType (typeof(NSDictionary))]
	interface NSDictionary_YYModel
	{
		// +(NSDictionary * _Nullable)yy_modelDictionaryWithClass:(Class _Nonnull)cls json:(id _Nonnull)json;
		[Static]
		[Export ("yy_modelDictionaryWithClass:json:")]
		[return: NullAllowed]
        [EditorBrowsable(EditorBrowsableState.Never)]
		NSDictionary Yy_modelDictionaryWithClass (Class cls, NSObject json);
	}

	// @protocol YYModel <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface YYModel
	{
		// @optional +(NSDictionary<NSString *,id> * _Nullable)modelCustomPropertyMapper;
		[Static]
		[NullAllowed, Export ("modelCustomPropertyMapper")]
		NSDictionary<NSString, NSObject> ModelCustomPropertyMapper { get; }

		// @optional +(NSDictionary<NSString *,id> * _Nullable)modelContainerPropertyGenericClass;
		[Static]
		[NullAllowed, Export ("modelContainerPropertyGenericClass")]
		NSDictionary<NSString, NSObject> ModelContainerPropertyGenericClass { get; }

		// @optional +(Class _Nullable)modelCustomClassForDictionary:(NSDictionary * _Nonnull)dictionary;
		[Static]
		[Export ("modelCustomClassForDictionary:")]
		[return: NullAllowed]
		Class ModelCustomClassForDictionary (NSDictionary dictionary);

		// @optional +(NSArray<NSString *> * _Nullable)modelPropertyBlacklist;
		[Static]
		[NullAllowed, Export ("modelPropertyBlacklist")]
		string[] ModelPropertyBlacklist { get; }

		// @optional +(NSArray<NSString *> * _Nullable)modelPropertyWhitelist;
		[Static]
		[NullAllowed, Export ("modelPropertyWhitelist")]
		string[] ModelPropertyWhitelist { get; }

		// @optional -(NSDictionary * _Nonnull)modelCustomWillTransformFromDictionary:(NSDictionary * _Nonnull)dic;
		[Export ("modelCustomWillTransformFromDictionary:")]
		NSDictionary ModelCustomWillTransformFromDictionary (NSDictionary dic);

		// @optional -(BOOL)modelCustomTransformFromDictionary:(NSDictionary * _Nonnull)dic;
		[Export ("modelCustomTransformFromDictionary:")]
		bool ModelCustomTransformFromDictionary (NSDictionary dic);

		// @optional -(BOOL)modelCustomTransformToDictionary:(NSMutableDictionary * _Nonnull)dic;
		[Export ("modelCustomTransformToDictionary:")]
		bool ModelCustomTransformToDictionary (NSMutableDictionary dic);
	}

	//// @interface YYClassIvarInfo : NSObject
	//[BaseType (typeof(NSObject))]
	//interface YYClassIvarInfo
	//{
	//	// @property (readonly, assign, nonatomic) Ivar _Nonnull ivar;
	//	[Export ("ivar", ArgumentSemantic.Assign)]
 //       unsafe Ivar Ivar { get; }

	//	// @property (readonly, nonatomic, strong) NSString * _Nonnull name;
	//	[Export ("name", ArgumentSemantic.Strong)]
	//	string Name { get; }

	//	// @property (readonly, assign, nonatomic) ptrdiff_t offset;
	//	[Export ("offset", ArgumentSemantic.Assign)]
	//	IntPtr Offset { get; }

	//	// @property (readonly, nonatomic, strong) NSString * _Nonnull typeEncoding;
	//	[Export ("typeEncoding", ArgumentSemantic.Strong)]
	//	string TypeEncoding { get; }

	//	// @property (readonly, assign, nonatomic) YYEncodingType type;
	//	[Export ("type", ArgumentSemantic.Assign)]
	//	YYEncodingType Type { get; }

	//	// -(instancetype _Nonnull)initWithIvar:(Ivar _Nonnull)ivar;
	//	[Export ("initWithIvar:")]
	//	unsafe IntPtr Constructor (Ivar* ivar);
	//}

	//// @interface YYClassMethodInfo : NSObject
	//[BaseType (typeof(NSObject))]
	//interface YYClassMethodInfo
	//{
	//	// @property (readonly, assign, nonatomic) Method _Nonnull method;
	//	[Export ("method", ArgumentSemantic.Assign)]
	//	unsafe Method* Method { get; }

	//	// @property (readonly, nonatomic, strong) NSString * _Nonnull name;
	//	[Export ("name", ArgumentSemantic.Strong)]
	//	string Name { get; }

	//	// @property (readonly, assign, nonatomic) SEL _Nonnull sel;
	//	[Export ("sel", ArgumentSemantic.Assign)]
	//	Selector Sel { get; }

	//	// @property (readonly, assign, nonatomic) IMP _Nonnull imp;
	//	[Export ("imp", ArgumentSemantic.Assign)]
	//	unsafe IMP* Imp { get; }

	//	// @property (readonly, nonatomic, strong) NSString * _Nonnull typeEncoding;
	//	[Export ("typeEncoding", ArgumentSemantic.Strong)]
	//	string TypeEncoding { get; }

	//	// @property (readonly, nonatomic, strong) NSString * _Nonnull returnTypeEncoding;
	//	[Export ("returnTypeEncoding", ArgumentSemantic.Strong)]
	//	string ReturnTypeEncoding { get; }

	//	// @property (readonly, nonatomic, strong) NSArray<NSString *> * _Nullable argumentTypeEncodings;
	//	[NullAllowed, Export ("argumentTypeEncodings", ArgumentSemantic.Strong)]
	//	string[] ArgumentTypeEncodings { get; }

	//	// -(instancetype _Nonnull)initWithMethod:(Method _Nonnull)method;
	//	[Export ("initWithMethod:")]
	//	unsafe IntPtr Constructor (Method* method);
	//}

	//// @interface YYClassPropertyInfo : NSObject
	//[BaseType (typeof(NSObject))]
	//interface YYClassPropertyInfo
	//{
	//	// @property (readonly, assign, nonatomic) objc_property_t _Nonnull property;
	//	[Export ("property", ArgumentSemantic.Assign)]
	//	unsafe objc_property_t* Property { get; }

	//	// @property (readonly, nonatomic, strong) NSString * _Nonnull name;
	//	[Export ("name", ArgumentSemantic.Strong)]
	//	string Name { get; }

	//	// @property (readonly, assign, nonatomic) YYEncodingType type;
	//	[Export ("type", ArgumentSemantic.Assign)]
	//	YYEncodingType Type { get; }

	//	// @property (readonly, nonatomic, strong) NSString * _Nonnull typeEncoding;
	//	[Export ("typeEncoding", ArgumentSemantic.Strong)]
	//	string TypeEncoding { get; }

	//	// @property (readonly, nonatomic, strong) NSString * _Nonnull ivarName;
	//	[Export ("ivarName", ArgumentSemantic.Strong)]
	//	string IvarName { get; }

	//	// @property (readonly, assign, nonatomic) Class _Nullable cls;
	//	[NullAllowed, Export ("cls", ArgumentSemantic.Assign)]
	//	Class Cls { get; }

	//	// @property (readonly, nonatomic, strong) NSArray<NSString *> * _Nullable protocols;
	//	[NullAllowed, Export ("protocols", ArgumentSemantic.Strong)]
	//	string[] Protocols { get; }

	//	// @property (readonly, assign, nonatomic) SEL _Nonnull getter;
	//	[Export ("getter", ArgumentSemantic.Assign)]
	//	Selector Getter { get; }

	//	// @property (readonly, assign, nonatomic) SEL _Nonnull setter;
	//	[Export ("setter", ArgumentSemantic.Assign)]
	//	Selector Setter { get; }

	//	// -(instancetype _Nonnull)initWithProperty:(objc_property_t _Nonnull)property;
	//	[Export ("initWithProperty:")]
	//	unsafe IntPtr Constructor (objc_property_t* property);
	//}

	//// @interface YYClassInfo : NSObject
	//[BaseType (typeof(NSObject))]
	//interface YYClassInfo
	//{
	//	// @property (readonly, assign, nonatomic) Class _Nonnull cls;
	//	[Export ("cls", ArgumentSemantic.Assign)]
	//	Class Cls { get; }

	//	// @property (readonly, assign, nonatomic) Class _Nullable superCls;
	//	[NullAllowed, Export ("superCls", ArgumentSemantic.Assign)]
	//	Class SuperCls { get; }

	//	// @property (readonly, assign, nonatomic) Class _Nullable metaCls;
	//	[NullAllowed, Export ("metaCls", ArgumentSemantic.Assign)]
	//	Class MetaCls { get; }

	//	// @property (readonly, nonatomic) BOOL isMeta;
	//	[Export ("isMeta")]
	//	bool IsMeta { get; }

	//	// @property (readonly, nonatomic, strong) NSString * _Nonnull name;
	//	[Export ("name", ArgumentSemantic.Strong)]
	//	string Name { get; }

	//	// @property (readonly, nonatomic, strong) YYClassInfo * _Nullable superClassInfo;
	//	[NullAllowed, Export ("superClassInfo", ArgumentSemantic.Strong)]
	//	YYClassInfo SuperClassInfo { get; }

	//	// @property (readonly, nonatomic, strong) NSDictionary<NSString *,YYClassIvarInfo *> * _Nullable ivarInfos;
	//	[NullAllowed, Export ("ivarInfos", ArgumentSemantic.Strong)]
	//	NSDictionary<NSString, YYClassIvarInfo> IvarInfos { get; }

	//	// @property (readonly, nonatomic, strong) NSDictionary<NSString *,YYClassMethodInfo *> * _Nullable methodInfos;
	//	[NullAllowed, Export ("methodInfos", ArgumentSemantic.Strong)]
	//	NSDictionary<NSString, YYClassMethodInfo> MethodInfos { get; }

	//	// @property (readonly, nonatomic, strong) NSDictionary<NSString *,YYClassPropertyInfo *> * _Nullable propertyInfos;
	//	[NullAllowed, Export ("propertyInfos", ArgumentSemantic.Strong)]
	//	NSDictionary<NSString, YYClassPropertyInfo> PropertyInfos { get; }

	//	// -(void)setNeedUpdate;
	//	[Export ("setNeedUpdate")]
	//	void SetNeedUpdate ();

	//	// -(BOOL)needUpdate;
	//	[Export ("needUpdate")]
	//	bool NeedUpdate { get; }

	//	// +(instancetype _Nullable)classInfoWithClass:(Class _Nonnull)cls;
	//	[Static]
	//	[Export ("classInfoWithClass:")]
	//	[return: NullAllowed]
	//	YYClassInfo ClassInfoWithClass (Class cls);

	//	// +(instancetype _Nullable)classInfoWithClassName:(NSString * _Nonnull)className;
	//	[Static]
	//	[Export ("classInfoWithClassName:")]
	//	[return: NullAllowed]
	//	YYClassInfo ClassInfoWithClassName (string className);
	//}

	// [Static]
	// [Verify (ConstantsInterfaceAssociation)]
	// partial interface Constants
	// {
	// 	// extern double YYModelVersionNumber;
	// 	[Field ("YYModelVersionNumber", "__Internal")]
	// 	double YYModelVersionNumber { get; }

	// 	// extern const unsigned char [] YYModelVersionString;
	// 	[Field ("YYModelVersionString", "__Internal")]
	// 	byte[] YYModelVersionString { get; }
	// }
}
