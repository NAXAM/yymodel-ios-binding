using System;
using Foundation;
using ObjCRuntime;

namespace YYModel
{
	public static partial class YY
	{
		public static NSObject ModelWithJSON(NSObject json)
		{
			return new NSObject().Yy_modelWithJSON(json);
		}
        public static NSObject ModelWithDictionary(NSDictionary dictionary)
		{
			return new NSObject().Yy_modelWithDictionary(dictionary);
		}
        public static NSObject[] ModelArrayWithClass(Class cls, NSObject json)
		{
            return new NSArray().Yy_modelArrayWithClass(cls, json);
		}
        public static NSDictionary ModelDictionaryWithClass(Class cls, NSObject json)
		{
            return new NSDictionary().Yy_modelDictionaryWithClass(cls, json);
		}
	}
}
