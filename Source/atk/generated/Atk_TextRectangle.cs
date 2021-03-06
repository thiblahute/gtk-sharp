// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Atk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public partial struct TextRectangle : IEquatable<TextRectangle> {

		public int X;
		public int Y;
		public int Width;
		public int Height;

		public static Atk.TextRectangle Zero = new Atk.TextRectangle ();

		public static Atk.TextRectangle New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Atk.TextRectangle.Zero;
			return (Atk.TextRectangle) Marshal.PtrToStructure (raw, typeof (Atk.TextRectangle));
		}

		public bool Equals (TextRectangle other)
		{
			return true && X.Equals (other.X) && Y.Equals (other.Y) && Width.Equals (other.Width) && Height.Equals (other.Height);
		}

		public override bool Equals (object other)
		{
			return other is TextRectangle && Equals ((TextRectangle) other);
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
