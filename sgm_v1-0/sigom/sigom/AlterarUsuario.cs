﻿using System;
using Gtk;
namespace sigom
{
    public class AlterarUsuario : Gtk.Window
    {
        private Entry entry0;
        private Entry entry1;
        private Entry entry2;

        public AlterarUsuario() : base("Controle de Login")
        {
            BorderWidth = 8;

            Frame frame = new Frame("Alterar Usuário:");
            Add(frame);

            VBox vbox = new VBox(false, 8);
            vbox.BorderWidth = 8;
            frame.Add(vbox);

            // Standard message dialog
            HBox hbox = new HBox(false, 8);
            // Interactive dialog
            hbox = new HBox(false, 8);
            vbox.PackStart(hbox, false, false, 0);
            VBox vbox2 = new VBox(false, 0);

            Table table = new Table(2, 2, false);
            table.RowSpacing = 4;
            table.ColumnSpacing = 4;
            hbox.PackStart(table, false, false, 0);

            Label label = new Label("Usuário a ser alterado:");
            table.Attach(label, 0, 1, 0, 1);
            entry0 = new Entry();
            table.Attach(entry0, 1, 2, 0, 1);
            label.MnemonicWidget = entry0;

            table = new Table(2, 2, false);
            table.RowSpacing = 4;
            table.ColumnSpacing = 4;
            hbox.PackStart(table, false, false, 0);

            label = new Label("Novo Usuário:");
            table.Attach(label, 0, 1, 0, 1);
            entry1 = new Entry();
            table.Attach(entry1, 1, 2, 0, 1);
            label.MnemonicWidget = entry1;

            label = new Label("Novo Senha:");
            table.Attach(label, 0, 1, 1, 2);
            entry2 = new Entry();
            table.Attach(entry2, 1, 2, 1, 2);
            label.MnemonicWidget = entry2;

            hbox = new HBox(false, 8);
            vbox.PackStart(hbox, false, false, 0);
            Button button = new Button("_Alterar");
            button.Clicked += new EventHandler(AlterarClicked);
            hbox.PackStart(button, false, false, 0);
            vbox.PackStart(new HSeparator(), false, false, 0);

            vbox.PackStart(hbox, false, false, 0);
            button = new Button("_Cancelar");
            button.Clicked += new EventHandler(CancelarClicked);
            hbox.PackStart(button, false, false, 0);
            vbox.PackStart(new HSeparator(), false, false, 0);

            ShowAll();
        }

        protected override bool OnDeleteEvent(Gdk.Event evt)
        {
            Destroy();
            return true;
        }

        private int i = 1;

        private void AlterarClicked(object o, EventArgs args)
        {
            String path = System.IO.Directory.GetCurrentDirectory() + "/";
            String dbName = "sigomDb.db";
            String dbPathFile = path + dbName;
            DbLite dbl = new DbLite();

            String tableName = "Login";
            entry0.Text = entry0.Text.Trim();
            entry1.Text = entry1.Text.Trim();
            entry2.Text = entry2.Text.Trim();

            if (entry0.Text != "")
            {

                String getData = dbl.dbGetCommand(dbPathFile, tableName, "Nome", "Nome", entry0.Text);

                if (entry0.Text == getData)
                {

                    if ((entry1.Text != "") && (entry2.Text != ""))
                    {
                        //Alterar dados na tabela:
                        dbl.modifyUserPassword(entry0.Text, entry1.Text, entry2.Text);
                        dbl.showMessage("Usuário Cadastrado com Sucesso!");
                        Destroy();
                    }
                    else
                    {
                        dbl.showMessage("Inserir novo Usuário e/ou Senha é obrigatório!");
                    }
                }
                else
                {
                    dbl.showMessage("O usuário não existe!");
                }
            }
            else{
                dbl.showMessage("Nenhum usuário foi apontado!");
            }


        }

        private void CancelarClicked(object o, EventArgs args)
        {
            //Application.Quit();
            Destroy();
        }

        private void MessageDialogClicked(object o, EventArgs args)
        {
            using (Dialog dialog = new MessageDialog(this,
                                  DialogFlags.Modal | DialogFlags.DestroyWithParent,
                                  MessageType.Info,
                                  ButtonsType.Ok,
                                  "This message box has been popped up the following\nnumber of times:\n\n {0}",
                                  i))
            {
                dialog.Run();
                dialog.Hide();
            }

            i++;
        }

        private void InteractiveDialogClicked(object o, EventArgs args)
        {
            Dialog dialog = new Dialog("Interactive Dialog", this,
                            DialogFlags.Modal | DialogFlags.DestroyWithParent,
                            Gtk.Stock.Ok, ResponseType.Ok,
                            "_Non-stock Button", ResponseType.Cancel);

            HBox hbox = new HBox(false, 8);
            hbox.BorderWidth = 8;
            //dialog.ContentArea.PackStart (hbox, false, false, 0);

            Image stock = new Image(Stock.DialogQuestion, IconSize.Dialog);
            hbox.PackStart(stock, false, false, 0);

            Table table = new Table(2, 2, false);
            table.RowSpacing = 4;
            table.ColumnSpacing = 4;
            hbox.PackStart(table, true, true, 0);

            Label label = new Label("_Entry1");
            table.Attach(label, 0, 1, 0, 1);
            Entry localEntry1 = new Entry();
            localEntry1.Text = entry1.Text;
            table.Attach(localEntry1, 1, 2, 0, 1);
            label.MnemonicWidget = localEntry1;

            label = new Label("E_ntry2");
            table.Attach(label, 0, 1, 1, 2);
            Entry localEntry2 = new Entry();
            localEntry2.Text = entry2.Text;
            table.Attach(localEntry2, 1, 2, 1, 2);
            label.MnemonicWidget = localEntry2;

            hbox.ShowAll();

            ResponseType response = (ResponseType)dialog.Run();

            if (response == ResponseType.Ok)
            {
                entry1.Text = localEntry1.Text;
                entry2.Text = localEntry2.Text;
            }

            dialog.Destroy();
        }
    }
}
