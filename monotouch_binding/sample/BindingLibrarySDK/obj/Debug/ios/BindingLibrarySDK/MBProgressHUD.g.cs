//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.ComponentModel;
using MonoTouch;
using MonoTouch.CoreFoundation;
using MonoTouch.CoreMedia;
using MonoTouch.CoreMotion;
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;
using MonoTouch.CoreAnimation;
using MonoTouch.CoreLocation;
using MonoTouch.MapKit;
using MonoTouch.UIKit;
using MonoTouch.CoreGraphics;
using MonoTouch.NewsstandKit;
using MonoTouch.GLKit;
using MonoTouch.CoreVideo;
using OpenTK;

namespace BindingLibrarySDK {
	[Register("MBProgressHUD", true)]
	public unsafe partial class MBProgressHUD : MonoTouch.UIKit.UIView {
		[CompilerGenerated]
		static readonly IntPtr selLabelText = Selector.GetHandle ("labelText");
		[CompilerGenerated]
		static readonly IntPtr selSetLabelText_ = Selector.GetHandle ("setLabelText:");
		[CompilerGenerated]
		static readonly IntPtr selShowHUDAddedToAnimated_ = Selector.GetHandle ("showHUDAddedTo:animated:");
		[CompilerGenerated]
		static readonly IntPtr selShow_ = Selector.GetHandle ("show:");
		[CompilerGenerated]
		static readonly IntPtr selHide_ = Selector.GetHandle ("hide:");
		[CompilerGenerated]
		static readonly IntPtr selHideAfterDelay_ = Selector.GetHandle ("hide:afterDelay:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("MBProgressHUD");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  MBProgressHUD () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.Init);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.Init);
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public MBProgressHUD (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.InitWithCoder, coder.Handle);
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public MBProgressHUD (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public MBProgressHUD (IntPtr handle) : base (handle) {}

		[Export ("showHUDAddedTo:animated:")]
		[CompilerGenerated]
		public static MBProgressHUD ShowHUDAddedTo (MonoTouch.UIKit.UIView view, bool animated)
		{
			if (view == null)
				throw new ArgumentNullException ("view");
			return (MBProgressHUD) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_bool (class_ptr, selShowHUDAddedToAnimated_, view.Handle, animated));
		}
		
		[Export ("show:")]
		[CompilerGenerated]
		public virtual void Show (bool animated)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selShow_, animated);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selShow_, animated);
			}
		}
		
		[Export ("hide:")]
		[CompilerGenerated]
		public virtual void Hide (bool animated)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selHide_, animated);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selHide_, animated);
			}
		}
		
		[Export ("hide:afterDelay:")]
		[CompilerGenerated]
		public virtual void Hide (bool animated, System.Double delay)
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_bool_Double (this.Handle, selHideAfterDelay_, animated, delay);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_bool_Double (this.SuperHandle, selHideAfterDelay_, animated, delay);
			}
		}
		
		[CompilerGenerated]
		public virtual string LabelText {
			[Export ("labelText", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selLabelText));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selLabelText));
				}
			}
			
			[Export ("setLabelText:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetLabelText_, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetLabelText_, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
	} /* class MBProgressHUD */
}
