// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public partial struct PageRange : IEquatable<PageRange> {

		public int Start;
		public int End;

		public static Gtk.PageRange Zero = new Gtk.PageRange ();

		public static Gtk.PageRange New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Gtk.PageRange.Zero;
			return (Gtk.PageRange) Marshal.PtrToStructure (raw, typeof (Gtk.PageRange));
		}

		public bool Equals (PageRange other)
		{
			return true && Start.Equals (other.Start) && End.Equals (other.End);
		}

		public override bool Equals (object other)
		{
			return other is PageRange && Equals ((PageRange) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType ().FullName.GetHashCode () ^ Start.GetHashCode () ^ End.GetHashCode ();
		}

		private static GLib.GType GType {
			get { return GLib.GType.Pointer; }
		}
#endregion
	}
}
