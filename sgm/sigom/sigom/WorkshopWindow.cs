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

        public void OnBtnSomaClicked(object sender, EventArgs e)
        {
            Calculadora calc = new Calculadora();
            calc.Calcular(1,Int32.Parse(edtNum1.Text), Int32.Parse(edtNum2.Text));
        }

        protected void OnBtnSomaQuatroClicked(object sender, EventArgs e)
        {
            SomaQuatro sq = new SomaQuatro();
            sq.adicaoQuatro(Int32.Parse(edtNum1.Text), Int32.Parse(edtNum2.Text),
                            Int32.Parse(edtNum3.Text), Int32.Parse(edtNum4.Text));
        }
    }
}
