// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;

	public delegate void WindowAddedHandler(object o, WindowAddedArgs args);

	public class WindowAddedArgs : GLib.SignalArgs {
		public Gtk.Window Window{
			get {
				return (Gtk.Window) Args [0];
			}
		}

	}
}
