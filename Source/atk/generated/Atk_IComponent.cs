// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Atk {

	using System;

#region Autogenerated code
	public partial interface IComponent : GLib.IWrapper {

		event Atk.BoundsChangedHandler BoundsChanged;
		uint AddFocusHandler(Atk.FocusHandler handler);
		bool Contains(int x, int y, Atk.CoordType coord_type);
		double Alpha { 
			get;
		}
		void GetExtents(out int x, out int y, out int width, out int height, Atk.CoordType coord_type);
		Atk.Layer Layer { 
			get;
		}
		int MdiZorder { 
			get;
		}
		void GetPosition(out int x, out int y, Atk.CoordType coord_type);
		void GetSize(out int width, out int height);
		bool GrabFocus();
		Atk.Object RefAccessibleAtPoint(int x, int y, Atk.CoordType coord_type);
		void RemoveFocusHandler(uint handler_id);
		bool SetExtents(int x, int y, int width, int height, Atk.CoordType coord_type);
		bool SetPosition(int x, int y, Atk.CoordType coord_type);
		bool SetSize(int width, int height);
	}

	[GLib.GInterface (typeof (ComponentAdapter))]
	public partial interface IComponentImplementor : GLib.IWrapper {

		uint AddFocusHandler (Atk.FocusHandler handler);
		bool Contains (int x, int y, Atk.CoordType coord_type);
		Atk.Object RefAccessibleAtPoint (int x, int y, Atk.CoordType coord_type);
		void GetExtents (out int x, out int y, out int width, out int height, Atk.CoordType coord_type);
		void GetPosition (out int x, out int y, Atk.CoordType coord_type);
		void GetSize (out int width, out int height);
		bool GrabFocus ();
		void RemoveFocusHandler (uint handler_id);
		bool SetExtents (int x, int y, int width, int height, Atk.CoordType coord_type);
		bool SetPosition (int x, int y, Atk.CoordType coord_type);
		bool SetSize (int width, int height);
		Atk.Layer Layer { get; }
		int MdiZorder { get; }
		double Alpha { get; }
	}
#endregion
}
