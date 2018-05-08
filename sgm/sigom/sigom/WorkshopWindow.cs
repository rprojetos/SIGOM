using System;
namespace sigom
{
    public partial class WorkshopWindow : Gtk.Window
    {
        public WorkshopWindow() :
            base(Gtk.WindowType.Toplevel)
        {
            DbLite dbl = new DbLite();
            //dbl.modifyUserPassword();//modifyUserPassword();
            this.Build();
        }

        protected void OnCadastarActionActivated(object sender, EventArgs e)
        {
            DbLite dbl = new DbLite();
            dbl.showMessage("Cadastrar ... ");
        }

        protected void OnAlterarActionActivated(object sender, EventArgs e)
        {
        }

        protected void OnDeletarActionActivated(object sender, EventArgs e)
        {
        }
    }
}
