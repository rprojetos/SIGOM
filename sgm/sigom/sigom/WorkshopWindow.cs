using System;
namespace sigom
{
    public partial class WorkshopWindow : Gtk.Window
    {
        public WorkshopWindow() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }
    }
}
