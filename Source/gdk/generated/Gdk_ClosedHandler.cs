// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;

	public delegate void ClosedHandler(object o, ClosedArgs args);

	public class ClosedArgs : GLib.SignalArgs {
		public bool IsError{
			get {
				return (bool) Args [0];
			}
		}

	}
}
