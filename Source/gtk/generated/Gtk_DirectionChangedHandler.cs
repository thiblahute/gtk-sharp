// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;

	public delegate void DirectionChangedHandler(object o, DirectionChangedArgs args);

	public class DirectionChangedArgs : GLib.SignalArgs {
		public Gtk.TextDirection PreviousDirection{
			get {
				return (Gtk.TextDirection) Args [0];
			}
		}

	}
}
