// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[Flags]
	[GLib.GType (typeof (GLib.MountUnmountFlagsGType))]
	public enum MountUnmountFlags {

		None,
		Force = 1 << 0,
	}

	internal class MountUnmountFlagsGType {
		[DllImport ("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_mount_unmount_flags_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (g_mount_unmount_flags_get_type ());
			}
		}
	}
#endregion
}
