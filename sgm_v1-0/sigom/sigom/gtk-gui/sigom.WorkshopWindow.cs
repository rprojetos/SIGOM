
// This file has been generated by the GUI designer. Do not modify.
namespace sigom
{
	public partial class WorkshopWindow
	{
		private global::Gtk.UIManager UIManager;

		private global::Gtk.Action UsurioAction;

		private global::Gtk.Action CadastarAction;

		private global::Gtk.Action AlterarAction;

		private global::Gtk.Action DeletarAction;

		private global::Gtk.Action ServiosAction;

		private global::Gtk.Action OrdemServioOSAction;

		private global::Gtk.Action NovaOSAction;

		private global::Gtk.Action AlterarOSAction;

		private global::Gtk.Action BaixarOSAction;

		private global::Gtk.Action DeletarOSAction;

		private global::Gtk.Action SolicitaoOramentoAction;

		private global::Gtk.Action AtendimentoAction;

		private global::Gtk.Action ServioAction;

		private global::Gtk.Action SolicitaoOramentoAction1;

		private global::Gtk.Action GerenciamentoAction;

		private global::Gtk.Action ClienteAction1;

		private global::Gtk.Action VeiculoAction;

		private global::Gtk.Action SolicitaoOramentoSOAction;

		private global::Gtk.Action CadastrarAction;

		private global::Gtk.Action CadastrarAction1;

		private global::Gtk.Action EmitirSOAction;

		private global::Gtk.Action PreencherAction;

		private global::Gtk.Action OrdemServioAction;

		private global::Gtk.Action AbertaAction;

		private global::Gtk.Action ClienteAction;

		private global::Gtk.Action VeiculoAction1;

		private global::Gtk.Action ServioAction1;

		private global::Gtk.Action FuncionrioAction;

		private global::Gtk.Action BuscarAction;

		private global::Gtk.Action CadastrarAction2;

		private global::Gtk.Action AlterarAction1;

		private global::Gtk.Action DeletarAction1;

		private global::Gtk.Action BuscarAction1;

		private global::Gtk.Action CadastrarAction3;

		private global::Gtk.Action AlterarAction2;

		private global::Gtk.Action DeletarAction2;

		private global::Gtk.Action BuscarAction2;

		private global::Gtk.Action CadastrarAction4;

		private global::Gtk.Action AlterarAction3;

		private global::Gtk.Action DeletarAction3;

		private global::Gtk.Action BuscarAction3;

		private global::Gtk.Action CadastrarAction5;

		private global::Gtk.Action AlterarAction4;

		private global::Gtk.Action DeletarAction4;

		private global::Gtk.Fixed fixed2;

		private global::Gtk.MenuBar menubar3;

		private global::Gtk.DrawingArea drawingarea1;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget sigom.WorkshopWindow
			this.UIManager = new global::Gtk.UIManager();
			global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup("Default");
			this.UsurioAction = new global::Gtk.Action("UsurioAction", global::Mono.Unix.Catalog.GetString("Usuário"), null, null);
			this.UsurioAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Usuário");
			w1.Add(this.UsurioAction, null);
			this.CadastarAction = new global::Gtk.Action("CadastarAction", global::Mono.Unix.Catalog.GetString("Cadastar"), null, null);
			this.CadastarAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Cadastar");
			w1.Add(this.CadastarAction, null);
			this.AlterarAction = new global::Gtk.Action("AlterarAction", global::Mono.Unix.Catalog.GetString("Alterar"), null, null);
			this.AlterarAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Alterar");
			w1.Add(this.AlterarAction, null);
			this.DeletarAction = new global::Gtk.Action("DeletarAction", global::Mono.Unix.Catalog.GetString("Deletar"), null, null);
			this.DeletarAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Deletar");
			w1.Add(this.DeletarAction, null);
			this.ServiosAction = new global::Gtk.Action("ServiosAction", global::Mono.Unix.Catalog.GetString("Serviços"), null, null);
			this.ServiosAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Serviços");
			w1.Add(this.ServiosAction, null);
			this.OrdemServioOSAction = new global::Gtk.Action("OrdemServioOSAction", global::Mono.Unix.Catalog.GetString("Ordem Serviço(O.S.)"), null, null);
			this.OrdemServioOSAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Ordem Serviço(O.S.)");
			w1.Add(this.OrdemServioOSAction, null);
			this.NovaOSAction = new global::Gtk.Action("NovaOSAction", global::Mono.Unix.Catalog.GetString("Nova O.S."), null, null);
			this.NovaOSAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Nova O.S.");
			w1.Add(this.NovaOSAction, null);
			this.AlterarOSAction = new global::Gtk.Action("AlterarOSAction", global::Mono.Unix.Catalog.GetString("Alterar O.S."), null, null);
			this.AlterarOSAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Alterar O.S.");
			w1.Add(this.AlterarOSAction, null);
			this.BaixarOSAction = new global::Gtk.Action("BaixarOSAction", global::Mono.Unix.Catalog.GetString("Baixar O.S."), null, null);
			this.BaixarOSAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Baixar O.S.");
			w1.Add(this.BaixarOSAction, null);
			this.DeletarOSAction = new global::Gtk.Action("DeletarOSAction", global::Mono.Unix.Catalog.GetString("Deletar O.S."), null, null);
			this.DeletarOSAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Deletar O.S.");
			w1.Add(this.DeletarOSAction, null);
			this.SolicitaoOramentoAction = new global::Gtk.Action("SolicitaoOramentoAction", global::Mono.Unix.Catalog.GetString("Solicitação Orçamento"), null, null);
			this.SolicitaoOramentoAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Solicitação Orçamento");
			w1.Add(this.SolicitaoOramentoAction, null);
			this.AtendimentoAction = new global::Gtk.Action("AtendimentoAction", global::Mono.Unix.Catalog.GetString("Atendimento"), null, null);
			this.AtendimentoAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Atendimento");
			w1.Add(this.AtendimentoAction, null);
			this.ServioAction = new global::Gtk.Action("ServioAction", global::Mono.Unix.Catalog.GetString("Serviço"), null, null);
			this.ServioAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Serviço");
			w1.Add(this.ServioAction, null);
			this.SolicitaoOramentoAction1 = new global::Gtk.Action("SolicitaoOramentoAction1", global::Mono.Unix.Catalog.GetString("Solicitação Orçamento"), null, null);
			this.SolicitaoOramentoAction1.ShortLabel = global::Mono.Unix.Catalog.GetString("Solicitação Orçamento");
			w1.Add(this.SolicitaoOramentoAction1, null);
			this.GerenciamentoAction = new global::Gtk.Action("GerenciamentoAction", global::Mono.Unix.Catalog.GetString("Gerenciamento"), null, null);
			this.GerenciamentoAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Gerenciamento");
			w1.Add(this.GerenciamentoAction, null);
			this.ClienteAction1 = new global::Gtk.Action("ClienteAction1", global::Mono.Unix.Catalog.GetString("Cliente"), null, null);
			this.ClienteAction1.ShortLabel = global::Mono.Unix.Catalog.GetString("Cliente");
			w1.Add(this.ClienteAction1, null);
			this.VeiculoAction = new global::Gtk.Action("VeiculoAction", global::Mono.Unix.Catalog.GetString("Veiculo"), null, null);
			this.VeiculoAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Veiculo");
			w1.Add(this.VeiculoAction, null);
			this.SolicitaoOramentoSOAction = new global::Gtk.Action("SolicitaoOramentoSOAction", global::Mono.Unix.Catalog.GetString("Solicitação Orçamento (S.O.)"), null, null);
			this.SolicitaoOramentoSOAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Solicitação Orçamento (S.O.)");
			w1.Add(this.SolicitaoOramentoSOAction, null);
			this.CadastrarAction = new global::Gtk.Action("CadastrarAction", global::Mono.Unix.Catalog.GetString("Cadastrar"), null, null);
			this.CadastrarAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Cadastrar");
			w1.Add(this.CadastrarAction, null);
			this.CadastrarAction1 = new global::Gtk.Action("CadastrarAction1", global::Mono.Unix.Catalog.GetString("Cadastrar"), null, null);
			this.CadastrarAction1.ShortLabel = global::Mono.Unix.Catalog.GetString("Cadastrar");
			w1.Add(this.CadastrarAction1, null);
			this.EmitirSOAction = new global::Gtk.Action("EmitirSOAction", global::Mono.Unix.Catalog.GetString("Emitir S.O."), null, null);
			this.EmitirSOAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Emitir S.O.");
			w1.Add(this.EmitirSOAction, null);
			this.PreencherAction = new global::Gtk.Action("PreencherAction", global::Mono.Unix.Catalog.GetString("Preencher"), null, null);
			this.PreencherAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Preencher");
			w1.Add(this.PreencherAction, null);
			this.OrdemServioAction = new global::Gtk.Action("OrdemServioAction", global::Mono.Unix.Catalog.GetString("Ordem Serviço"), null, null);
			this.OrdemServioAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Ordem Serviço");
			w1.Add(this.OrdemServioAction, null);
			this.AbertaAction = new global::Gtk.Action("AbertaAction", global::Mono.Unix.Catalog.GetString("Aberta"), null, null);
			this.AbertaAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Aberta");
			w1.Add(this.AbertaAction, null);
			this.ClienteAction = new global::Gtk.Action("ClienteAction", global::Mono.Unix.Catalog.GetString("Cliente"), null, null);
			this.ClienteAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Cliente");
			w1.Add(this.ClienteAction, null);
			this.VeiculoAction1 = new global::Gtk.Action("VeiculoAction1", global::Mono.Unix.Catalog.GetString("Veiculo"), null, null);
			this.VeiculoAction1.ShortLabel = global::Mono.Unix.Catalog.GetString("Veiculo");
			w1.Add(this.VeiculoAction1, null);
			this.ServioAction1 = new global::Gtk.Action("ServioAction1", global::Mono.Unix.Catalog.GetString("Serviço"), null, null);
			this.ServioAction1.ShortLabel = global::Mono.Unix.Catalog.GetString("Serviço");
			w1.Add(this.ServioAction1, null);
			this.FuncionrioAction = new global::Gtk.Action("FuncionrioAction", global::Mono.Unix.Catalog.GetString("Funcionário"), null, null);
			this.FuncionrioAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Funcionário");
			w1.Add(this.FuncionrioAction, null);
			this.BuscarAction = new global::Gtk.Action("BuscarAction", global::Mono.Unix.Catalog.GetString("Buscar"), null, null);
			this.BuscarAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Buscar");
			w1.Add(this.BuscarAction, null);
			this.CadastrarAction2 = new global::Gtk.Action("CadastrarAction2", global::Mono.Unix.Catalog.GetString("Cadastrar"), null, null);
			this.CadastrarAction2.ShortLabel = global::Mono.Unix.Catalog.GetString("Cadastrar");
			w1.Add(this.CadastrarAction2, null);
			this.AlterarAction1 = new global::Gtk.Action("AlterarAction1", global::Mono.Unix.Catalog.GetString("Alterar"), null, null);
			this.AlterarAction1.ShortLabel = global::Mono.Unix.Catalog.GetString("Alterar");
			w1.Add(this.AlterarAction1, null);
			this.DeletarAction1 = new global::Gtk.Action("DeletarAction1", global::Mono.Unix.Catalog.GetString("Deletar"), null, null);
			this.DeletarAction1.ShortLabel = global::Mono.Unix.Catalog.GetString("Deletar");
			w1.Add(this.DeletarAction1, null);
			this.BuscarAction1 = new global::Gtk.Action("BuscarAction1", global::Mono.Unix.Catalog.GetString("Buscar"), null, null);
			this.BuscarAction1.ShortLabel = global::Mono.Unix.Catalog.GetString("Buscar");
			w1.Add(this.BuscarAction1, null);
			this.CadastrarAction3 = new global::Gtk.Action("CadastrarAction3", global::Mono.Unix.Catalog.GetString("Cadastrar"), null, null);
			this.CadastrarAction3.ShortLabel = global::Mono.Unix.Catalog.GetString("Cadastrar");
			w1.Add(this.CadastrarAction3, null);
			this.AlterarAction2 = new global::Gtk.Action("AlterarAction2", global::Mono.Unix.Catalog.GetString("Alterar"), null, null);
			this.AlterarAction2.ShortLabel = global::Mono.Unix.Catalog.GetString("Alterar");
			w1.Add(this.AlterarAction2, null);
			this.DeletarAction2 = new global::Gtk.Action("DeletarAction2", global::Mono.Unix.Catalog.GetString("Deletar"), null, null);
			this.DeletarAction2.ShortLabel = global::Mono.Unix.Catalog.GetString("Deletar");
			w1.Add(this.DeletarAction2, null);
			this.BuscarAction2 = new global::Gtk.Action("BuscarAction2", global::Mono.Unix.Catalog.GetString("Buscar"), null, null);
			this.BuscarAction2.ShortLabel = global::Mono.Unix.Catalog.GetString("Buscar");
			w1.Add(this.BuscarAction2, null);
			this.CadastrarAction4 = new global::Gtk.Action("CadastrarAction4", global::Mono.Unix.Catalog.GetString("Cadastrar"), null, null);
			this.CadastrarAction4.ShortLabel = global::Mono.Unix.Catalog.GetString("Cadastrar");
			w1.Add(this.CadastrarAction4, null);
			this.AlterarAction3 = new global::Gtk.Action("AlterarAction3", global::Mono.Unix.Catalog.GetString("Alterar"), null, null);
			this.AlterarAction3.ShortLabel = global::Mono.Unix.Catalog.GetString("Alterar");
			w1.Add(this.AlterarAction3, null);
			this.DeletarAction3 = new global::Gtk.Action("DeletarAction3", global::Mono.Unix.Catalog.GetString("Deletar"), null, null);
			this.DeletarAction3.ShortLabel = global::Mono.Unix.Catalog.GetString("Deletar");
			w1.Add(this.DeletarAction3, null);
			this.BuscarAction3 = new global::Gtk.Action("BuscarAction3", global::Mono.Unix.Catalog.GetString("Buscar"), null, null);
			this.BuscarAction3.ShortLabel = global::Mono.Unix.Catalog.GetString("Buscar");
			w1.Add(this.BuscarAction3, null);
			this.CadastrarAction5 = new global::Gtk.Action("CadastrarAction5", global::Mono.Unix.Catalog.GetString("Cadastrar"), null, null);
			this.CadastrarAction5.ShortLabel = global::Mono.Unix.Catalog.GetString("Cadastrar");
			w1.Add(this.CadastrarAction5, null);
			this.AlterarAction4 = new global::Gtk.Action("AlterarAction4", global::Mono.Unix.Catalog.GetString("Alterar"), null, null);
			this.AlterarAction4.ShortLabel = global::Mono.Unix.Catalog.GetString("Alterar");
			w1.Add(this.AlterarAction4, null);
			this.DeletarAction4 = new global::Gtk.Action("DeletarAction4", global::Mono.Unix.Catalog.GetString("Deletar"), null, null);
			this.DeletarAction4.ShortLabel = global::Mono.Unix.Catalog.GetString("Deletar");
			w1.Add(this.DeletarAction4, null);
			this.UIManager.InsertActionGroup(w1, 0);
			this.AddAccelGroup(this.UIManager.AccelGroup);
			this.Name = "sigom.WorkshopWindow";
			this.Title = global::Mono.Unix.Catalog.GetString("WorkshopWindow");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child sigom.WorkshopWindow.Gtk.Container+ContainerChild
			this.fixed2 = new global::Gtk.Fixed();
			this.fixed2.Name = "fixed2";
			this.fixed2.HasWindow = false;
			// Container child fixed2.Gtk.Fixed+FixedChild
			this.UIManager.AddUiFromString("<ui><menubar name=\'menubar3\'><menu name=\'AtendimentoAction\' action=\'AtendimentoAc" +
					"tion\'><menu name=\'ClienteAction1\' action=\'ClienteAction1\'><menuitem name=\'Cadast" +
					"rarAction\' action=\'CadastrarAction\'/></menu><menu name=\'VeiculoAction\' action=\'V" +
					"eiculoAction\'><menuitem name=\'CadastrarAction1\' action=\'CadastrarAction1\'/></men" +
					"u><menu name=\'SolicitaoOramentoSOAction\' action=\'SolicitaoOramentoSOAction\'><men" +
					"uitem name=\'EmitirSOAction\' action=\'EmitirSOAction\'/></menu></menu><menu name=\'S" +
					"ervioAction\' action=\'ServioAction\'><menu name=\'SolicitaoOramentoAction1\' action=" +
					"\'SolicitaoOramentoAction1\'><menuitem name=\'PreencherAction\' action=\'PreencherAct" +
					"ion\'/></menu><menu name=\'OrdemServioAction\' action=\'OrdemServioAction\'><menuitem" +
					" name=\'AbertaAction\' action=\'AbertaAction\'/></menu></menu><menu name=\'Gerenciame" +
					"ntoAction\' action=\'GerenciamentoAction\'><menu name=\'ClienteAction\' action=\'Clien" +
					"teAction\'><menuitem name=\'BuscarAction\' action=\'BuscarAction\'/><menuitem name=\'C" +
					"adastrarAction2\' action=\'CadastrarAction2\'/><menuitem name=\'AlterarAction1\' acti" +
					"on=\'AlterarAction1\'/><menuitem name=\'DeletarAction1\' action=\'DeletarAction1\'/></" +
					"menu><menu name=\'VeiculoAction1\' action=\'VeiculoAction1\'><menuitem name=\'BuscarA" +
					"ction1\' action=\'BuscarAction1\'/><menuitem name=\'CadastrarAction3\' action=\'Cadast" +
					"rarAction3\'/><menuitem name=\'AlterarAction2\' action=\'AlterarAction2\'/><menuitem " +
					"name=\'DeletarAction2\' action=\'DeletarAction2\'/></menu><menu name=\'ServioAction1\'" +
					" action=\'ServioAction1\'><menuitem name=\'BuscarAction2\' action=\'BuscarAction2\'/><" +
					"menuitem name=\'CadastrarAction4\' action=\'CadastrarAction4\'/><menuitem name=\'Alte" +
					"rarAction3\' action=\'AlterarAction3\'/><menuitem name=\'DeletarAction3\' action=\'Del" +
					"etarAction3\'/></menu><menu name=\'FuncionrioAction\' action=\'FuncionrioAction\'><me" +
					"nuitem name=\'BuscarAction3\' action=\'BuscarAction3\'/><menuitem name=\'CadastrarAct" +
					"ion5\' action=\'CadastrarAction5\'/><menuitem name=\'AlterarAction4\' action=\'Alterar" +
					"Action4\'/><menuitem name=\'DeletarAction4\' action=\'DeletarAction4\'/></menu></menu" +
					"></menubar></ui>");
			this.menubar3 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget("/menubar3")));
			this.menubar3.Name = "menubar3";
			this.fixed2.Add(this.menubar3);
			global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed2[this.menubar3]));
			w2.X = 11;
			w2.Y = 10;
			// Container child fixed2.Gtk.Fixed+FixedChild
			this.drawingarea1 = new global::Gtk.DrawingArea();
			this.drawingarea1.Name = "drawingarea1";
			this.fixed2.Add(this.drawingarea1);
			global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed2[this.drawingarea1]));
			w3.X = 330;
			w3.Y = 173;
			this.Add(this.fixed2);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 1380;
			this.DefaultHeight = 758;
			this.Show();			
		}
	}
}
