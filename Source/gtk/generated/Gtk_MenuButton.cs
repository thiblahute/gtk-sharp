// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class MenuButton : Gtk.ToggleButton {

		public MenuButton (IntPtr raw) : base(raw) {}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_menu_button_new();

		public MenuButton () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (MenuButton)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gtk_menu_button_new();
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_menu_button_get_popup(IntPtr raw);

		[GLib.Property ("popup")]
		public Gtk.Menu Popup {
			get  {
				IntPtr raw_ret = gtk_menu_button_get_popup(Handle);
				Gtk.Menu ret = GLib.Object.GetObject(raw_ret) as Gtk.Menu;
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("popup", val);
				val.Dispose ();
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_menu_button_get_menu_model(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_menu_button_set_menu_model(IntPtr raw, IntPtr menu_model);

		[GLib.Property ("menu-model")]
		public GLib.MenuModel MenuModel {
			get  {
				IntPtr raw_ret = gtk_menu_button_get_menu_model(Handle);
				GLib.MenuModel ret = GLib.Object.GetObject(raw_ret) as GLib.MenuModel;
				return ret;
			}
			set  {
				gtk_menu_button_set_menu_model(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_menu_button_get_align_widget(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_menu_button_set_align_widget(IntPtr raw, IntPtr align_widget);

		[GLib.Property ("align-widget")]
		public Gtk.Widget AlignWidget {
			get  {
				IntPtr raw_ret = gtk_menu_button_get_align_widget(Handle);
				Gtk.Widget ret = GLib.Object.GetObject(raw_ret) as Gtk.Widget;
				return ret;
			}
			set  {
				gtk_menu_button_set_align_widget(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_menu_button_get_direction(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_menu_button_set_direction(IntPtr raw, int direction);

		[GLib.Property ("direction")]
		public Gtk.ArrowType Direction {
			get  {
				int raw_ret = gtk_menu_button_get_direction(Handle);
				Gtk.ArrowType ret = (Gtk.ArrowType) raw_ret;
				return ret;
			}
			set  {
				gtk_menu_button_set_direction(Handle, (int) value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_menu_button_get_use_popover(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_menu_button_set_use_popover(IntPtr raw, bool use_popover);

		[GLib.Property ("use-popover")]
		public bool UsePopover {
			get  {
				bool raw_ret = gtk_menu_button_get_use_popover(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_menu_button_set_use_popover(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_menu_button_get_popover(IntPtr raw);

		[GLib.Property ("popover")]
		public Gtk.Popover Popover {
			get  {
				IntPtr raw_ret = gtk_menu_button_get_popover(Handle);
				Gtk.Popover ret = GLib.Object.GetObject(raw_ret) as Gtk.Popover;
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("popover", val);
				val.Dispose ();
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("_gtk_reserved1"
							, Gtk.ToggleButton.class_abi.Fields
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
		static extern IntPtr gtk_menu_button_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_menu_button_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("priv"
							, Gtk.ToggleButton.abi_info.Fields
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
