// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;

	public delegate void ToggleSizeRequestedHandler(object o, ToggleSizeRequestedArgs args);

	public class ToggleSizeRequestedArgs : GLib.SignalArgs {
		public int Requisition{
			set {
				Args[0] = (int)value;
			}
		}

	}
}
