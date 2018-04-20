using System;
using Gtk;


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

    protected void OnBtnShowMsgClicked(object sender, EventArgs e)
    {
        // Cria dialogo
        MessageDialog dlg = new MessageDialog(null, DialogFlags.Modal, MessageType.Info, ButtonsType.YesNo, "Hello World!");

        dlg.Response += delegate (object o, ResponseArgs resp)
        {
            if (resp.ResponseId == ResponseType.Yes)
            {
                label1.Text = "Button Yes";

            }
            if (resp.ResponseId == ResponseType.No)
            {
                label1.Text = "Button No";

            }
        };

        // chama dialogo
        dlg.Run();
        // Destroi diaglogo
        dlg.Destroy();


        MessageDialog md = new MessageDialog(this,
        DialogFlags.DestroyWithParent, MessageType.Info,
        ButtonsType.Close, "Download completed");
        md.Run();
        md.Destroy();

        sigom.WorkshopWindow w = new sigom.WorkshopWindow();
        w.Show();

        this.Destroy();
    }
}
