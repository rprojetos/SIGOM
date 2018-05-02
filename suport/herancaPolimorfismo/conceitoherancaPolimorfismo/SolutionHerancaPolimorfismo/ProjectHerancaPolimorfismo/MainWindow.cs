using System;
using Gtk;
using ProjectHerancaPolimorfismo;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnBtnCadastraClienteClicked(object sender, EventArgs e)
    {
        Classe3 c3 = new Classe3();
        c3.CadastraCliente(Int32.Parse(entCodigo.Text),entNome.Text,
                           entEndereco.Text, entTelefone.Text);
    }
}
