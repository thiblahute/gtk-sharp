// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;

	public delegate void VolumeRemovedHandler(object o, VolumeRemovedArgs args);

	public class VolumeRemovedArgs : GLib.SignalArgs {
		public GLib.IVolume Volume{
			get {
				return GLib.VolumeAdapter.GetObject (Args [0] as GLib.Object);
			}
		}

	}
}
