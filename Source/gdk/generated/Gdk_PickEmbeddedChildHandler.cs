// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;

	public delegate void PickEmbeddedChildHandler(object o, PickEmbeddedChildArgs args);

	public class PickEmbeddedChildArgs : GLib.SignalArgs {
		public double X{
			get {
				return (double) Args [0];
			}
		}

		public double Y{
			get {
				return (double) Args [1];
			}
		}

	}
}
