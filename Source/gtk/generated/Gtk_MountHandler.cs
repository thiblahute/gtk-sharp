// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;

	public delegate void MountHandler(object o, MountArgs args);

	public class MountArgs : GLib.SignalArgs {
		public GLib.MountOperation MountOperation{
			get {
				return (GLib.MountOperation) Args [0];
			}
		}

	}
}
