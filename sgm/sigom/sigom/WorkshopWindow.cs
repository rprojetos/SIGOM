using System;
namespace sigom
{
    public partial class WorkshopWindow : Gtk.Window
    {
        public WorkshopWindow() :
            base(Gtk.WindowType.Toplevel)
        {
            DbLite dbl = new DbLite();
            dbl.modifyUserPassword();
            this.Build();
        }


    }
}
