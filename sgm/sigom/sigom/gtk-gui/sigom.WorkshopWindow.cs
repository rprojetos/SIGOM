
// This file has been generated by the GUI designer. Do not modify.
namespace sigom
{
	public partial class WorkshopWindow
	{
		private global::Gtk.Fixed fixed2;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget sigom.WorkshopWindow
			this.Name = "sigom.WorkshopWindow";
			this.Title = global::Mono.Unix.Catalog.GetString("WorkshopWindow");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child sigom.WorkshopWindow.Gtk.Container+ContainerChild
			this.fixed2 = new global::Gtk.Fixed();
			this.fixed2.Name = "fixed2";
			this.fixed2.HasWindow = false;
			this.Add(this.fixed2);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 300;
			this.Show();
		}
	}
}
