
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Fixed fixed1;

	private global::Gtk.Label label1;

	private global::Gtk.Label label2;

	private global::Gtk.Entry entCodigo;

	private global::Gtk.Entry entNome;

	private global::Gtk.Label label3;

	private global::Gtk.Entry entEndereco;

	private global::Gtk.Label label4;

	private global::Gtk.Entry entTelefone;

	private global::Gtk.Button btnCadastraCliente;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.fixed1 = new global::Gtk.Fixed();
		this.fixed1.Name = "fixed1";
		this.fixed1.HasWindow = false;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label1 = new global::Gtk.Label();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Código:");
		this.fixed1.Add(this.label1);
		global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label1]));
		w1.X = 5;
		w1.Y = 7;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label2 = new global::Gtk.Label();
		this.label2.Name = "label2";
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Nome");
		this.fixed1.Add(this.label2);
		global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label2]));
		w2.X = 6;
		w2.Y = 60;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.entCodigo = new global::Gtk.Entry();
		this.entCodigo.CanFocus = true;
		this.entCodigo.Name = "entCodigo";
		this.entCodigo.IsEditable = true;
		this.entCodigo.InvisibleChar = '•';
		this.fixed1.Add(this.entCodigo);
		global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.entCodigo]));
		w3.X = 1;
		w3.Y = 26;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.entNome = new global::Gtk.Entry();
		this.entNome.CanFocus = true;
		this.entNome.Name = "entNome";
		this.entNome.IsEditable = true;
		this.entNome.InvisibleChar = '•';
		this.fixed1.Add(this.entNome);
		global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.entNome]));
		w4.X = 5;
		w4.Y = 77;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label3 = new global::Gtk.Label();
		this.label3.Name = "label3";
		this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Endereço:");
		this.fixed1.Add(this.label3);
		global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label3]));
		w5.X = 206;
		w5.Y = 5;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.entEndereco = new global::Gtk.Entry();
		this.entEndereco.CanFocus = true;
		this.entEndereco.Name = "entEndereco";
		this.entEndereco.IsEditable = true;
		this.entEndereco.InvisibleChar = '•';
		this.fixed1.Add(this.entEndereco);
		global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.entEndereco]));
		w6.X = 202;
		w6.Y = 25;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label4 = new global::Gtk.Label();
		this.label4.Name = "label4";
		this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("Telefone:");
		this.fixed1.Add(this.label4);
		global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label4]));
		w7.X = 204;
		w7.Y = 56;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.entTelefone = new global::Gtk.Entry();
		this.entTelefone.CanFocus = true;
		this.entTelefone.Name = "entTelefone";
		this.entTelefone.IsEditable = true;
		this.entTelefone.InvisibleChar = '•';
		this.fixed1.Add(this.entTelefone);
		global::Gtk.Fixed.FixedChild w8 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.entTelefone]));
		w8.X = 199;
		w8.Y = 76;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.btnCadastraCliente = new global::Gtk.Button();
		this.btnCadastraCliente.CanFocus = true;
		this.btnCadastraCliente.Name = "btnCadastraCliente";
		this.btnCadastraCliente.UseUnderline = true;
		this.btnCadastraCliente.Label = global::Mono.Unix.Catalog.GetString("Cadastra Cliente");
		this.fixed1.Add(this.btnCadastraCliente);
		global::Gtk.Fixed.FixedChild w9 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.btnCadastraCliente]));
		w9.X = 12;
		w9.Y = 120;
		this.Add(this.fixed1);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 402;
		this.DefaultHeight = 300;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.btnCadastraCliente.Clicked += new global::System.EventHandler(this.OnBtnCadastraClienteClicked);
	}
}