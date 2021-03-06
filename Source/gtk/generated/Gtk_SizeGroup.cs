// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class SizeGroup : GLib.Object {

		public SizeGroup (IntPtr raw) : base(raw) {}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_size_group_new(int mode);

		public SizeGroup (Gtk.SizeGroupMode mode) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (SizeGroup)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				names.Add ("mode");
				vals.Add (new GLib.Value (mode));
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			Raw = gtk_size_group_new((int) mode);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_size_group_get_mode(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_size_group_set_mode(IntPtr raw, int mode);

		[GLib.Property ("mode")]
		public Gtk.SizeGroupMode Mode {
			get  {
				int raw_ret = gtk_size_group_get_mode(Handle);
				Gtk.SizeGroupMode ret = (Gtk.SizeGroupMode) raw_ret;
				return ret;
			}
			set  {
				gtk_size_group_set_mode(Handle, (int) value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_size_group_get_ignore_hidden(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_size_group_set_ignore_hidden(IntPtr raw, bool ignore_hidden);

		[Obsolete]
		[GLib.Property ("ignore-hidden")]
		public bool IgnoreHidden {
			get  {
				bool raw_ret = gtk_size_group_get_ignore_hidden(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_size_group_set_ignore_hidden(Handle, value);
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("_gtk_reserved1"
							, GLib.Object.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved1
							, null
							, "_gtk_reserved2"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gtk_reserved2"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved2
							, "_gtk_reserved1"
							, "_gtk_reserved3"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gtk_reserved3"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved3
							, "_gtk_reserved2"
							, "_gtk_reserved4"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gtk_reserved4"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved4
							, "_gtk_reserved3"
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_size_group_add_widget(IntPtr raw, IntPtr widget);

		public void AddWidget(Gtk.Widget widget) {
			gtk_size_group_add_widget(Handle, widget == null ? IntPtr.Zero : widget.Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_size_group_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_size_group_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_size_group_get_widgets(IntPtr raw);

		public Gtk.Widget[] Widgets { 
			get {
				IntPtr raw_ret = gtk_size_group_get_widgets(Handle);
				Gtk.Widget[] ret = (Gtk.Widget[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.SList), false, false, typeof(Gtk.Widget));
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_size_group_remove_widget(IntPtr raw, IntPtr widget);

		public void RemoveWidget(Gtk.Widget widget) {
			gtk_size_group_remove_widget(Handle, widget == null ? IntPtr.Zero : widget.Handle);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("priv"
							, GLib.Object.abi_info.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // priv
							, null
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}
