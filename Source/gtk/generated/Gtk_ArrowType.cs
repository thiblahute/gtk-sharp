// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Gtk.ArrowTypeGType))]
	public enum ArrowType {

		Up,
		Down,
		Left,
		Right,
		None,
	}

	internal class ArrowTypeGType {
		[DllImport ("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_arrow_type_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gtk_arrow_type_get_type ());
			}
		}
	}
#endregion
}
