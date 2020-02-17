// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GtkSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
	internal delegate void FlowBoxForeachFuncNative(IntPtr box, IntPtr child, IntPtr user_data);

	internal class FlowBoxForeachFuncInvoker {

		FlowBoxForeachFuncNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~FlowBoxForeachFuncInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal FlowBoxForeachFuncInvoker (FlowBoxForeachFuncNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal FlowBoxForeachFuncInvoker (FlowBoxForeachFuncNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal FlowBoxForeachFuncInvoker (FlowBoxForeachFuncNative native_cb, IntPtr data, GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal Gtk.FlowBoxForeachFunc Handler {
			get {
				return new Gtk.FlowBoxForeachFunc(InvokeNative);
			}
		}

		void InvokeNative (Gtk.FlowBox box, Gtk.FlowBoxChild child)
		{
			native_cb (box == null ? IntPtr.Zero : box.Handle, child == null ? IntPtr.Zero : child.Handle, __data);
		}
	}

	internal class FlowBoxForeachFuncWrapper {

		public void NativeCallback (IntPtr box, IntPtr child, IntPtr user_data)
		{
			try {
				managed (GLib.Object.GetObject(box) as Gtk.FlowBox, GLib.Object.GetObject(child) as Gtk.FlowBoxChild);
				if (release_on_call)
					gch.Free ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		bool release_on_call = false;
		GCHandle gch;

		public void PersistUntilCalled ()
		{
			release_on_call = true;
			gch = GCHandle.Alloc (this);
		}

		internal FlowBoxForeachFuncNative NativeDelegate;
		Gtk.FlowBoxForeachFunc managed;

		public FlowBoxForeachFuncWrapper (Gtk.FlowBoxForeachFunc managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new FlowBoxForeachFuncNative (NativeCallback);
		}

		public static Gtk.FlowBoxForeachFunc GetManagedDelegate (FlowBoxForeachFuncNative native)
		{
			if (native == null)
				return null;
			FlowBoxForeachFuncWrapper wrapper = (FlowBoxForeachFuncWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}
