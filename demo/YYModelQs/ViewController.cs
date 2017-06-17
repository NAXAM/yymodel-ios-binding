using System;
using Foundation;
using UIKit;
using YYModel;

namespace YYModelQs
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            var dob = DateTimeToNSDate(new DateTime(2016, 11, 23));
            var person = new Person
            {
                FirstName = "NAXAM",
                LastName = "COMPANY",
                DateOfBirth = dob
            };

            var json = person.Yy_modelToJSONString();
			//NOTWORK var copy = person.Yy_modelWithJSON(new NSString(json));

			var nsdata = person.Yy_modelToJSONData();
            //NOTWORK var copy2 = person.Yy_modelWithJSON(nsdata);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        public static NSDate DateTimeToNSDate(DateTime date)
        {
            DateTime reference = TimeZone.CurrentTimeZone.ToLocalTime(
                new DateTime(2001, 1, 1, 0, 0, 0));
            return NSDate.FromTimeIntervalSinceReferenceDate(
                (date - reference).TotalSeconds);
        }
    }

    [Register("Person")]
    public class Person : NSObject
    {
        [Export("firstName", ObjCRuntime.ArgumentSemantic.Strong)]
        public string FirstName { get; set; }
        [Export("lastName", ObjCRuntime.ArgumentSemantic.Strong)]
        public string LastName { get; set; }
        [Export("birthday", ObjCRuntime.ArgumentSemantic.Strong)]
        public NSDate DateOfBirth { get; set; }
    }
}
