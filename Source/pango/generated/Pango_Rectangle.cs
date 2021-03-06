// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Pango {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public partial struct Rectangle : IEquatable<Rectangle> {

		public int X;
		public int Y;
		public int Width;
		public int Height;

		public static Pango.Rectangle Zero = new Pango.Rectangle ();

		public static Pango.Rectangle New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Pango.Rectangle.Zero;
			return (Pango.Rectangle) Marshal.PtrToStructure (raw, typeof (Pango.Rectangle));
		}

		public bool Equals (Rectangle other)
		{
			return true && X.Equals (other.X) && Y.Equals (other.Y) && Width.Equals (other.Width) && Height.Equals (other.Height);
		}

		public override bool Equals (object other)
		{
			return other is Rectangle && Equals ((Rectangle) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType ().FullName.GetHashCode () ^ X.GetHashCode () ^ Y.GetHashCode () ^ Width.GetHashCode () ^ Height.GetHashCode ();
		}

		private static GLib.GType GType {
			get { return GLib.GType.Pointer; }
		}
#endregion
	}
}
