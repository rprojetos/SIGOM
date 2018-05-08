using System;
using Gtk;
using System.Collections;
using sigom;

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
        /*
        // Cria dialogo
        //MessageDialog dlg = new MessageDialog(null, DialogFlags.Modal, MessageType.Info, ButtonsType.YesNo, "Hello World!");

        //dlg.Response += delegate (object o, ResponseArgs resp)
        //{
        //    if (resp.ResponseId == ResponseType.Yes)
        //    {
        //        label1.Text = "Button Yes";

        //    }
        //    if (resp.ResponseId == ResponseType.No)
        //    {
        //        label1.Text = "Button No";
        //
        //    }
        //};

        // chama dialogo
        //dlg.Run();
        // Destroi diaglogo
        //dlg.Destroy();


        //MessageDialog md = new MessageDialog(this,
        //DialogFlags.DestroyWithParent, MessageType.Info,
        //ButtonsType.Close, "Download completed");
        //md.Run();
        //md.Destroy();

        String path = System.IO.Directory.GetCurrentDirectory() + "/";
        String dbName = "teste03.db";

        String dbPathFile = path + dbName;

        DbLite dbl = new DbLite();
        //dbl.showMessage("Usando a classe DbLite.cs");

        //dbl.dbCreate(dbPathFile);

        //criando uma tabela
        ///string createTable = @"CREATE TABLE Pessoa (ID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,Nome VARCHAR(100) NOT NULL,Telefone VARCHAR (30))";
        ///dbl.dbSetCommand(dbPathFile, createTable);

        //Realizando um alter table --> Nome da coluna(DataNascimento) e o seu tipo(DATE)
        ///String alterTable = "ALTER TABLE Pessoa ADD Column DataNascimento VARCHAR(10)";
        ///dbl.dbSetCommand(dbPathFile, alterTable);

        //Inserir dados na tabela:
        ///String Nome = "Ricardo Poleto Ribeiro";
        ///String Telefone = "37-99937-5038";
        ///String data = "08/11/1977";
        ///String insertCommand = "INSERT INTO Pessoa (Nome, Telefone, DataNascimento)"+ 
            ///"VALUES('"+Nome+"','"+Telefone+"','"+data+"')";
        ///dbl.dbSetCommand(dbPathFile, insertCommand);

        //Update: 
        ///String uNome = "Ricardo Poleto Ribeiro";
        ///String uTelefone = "37-99937-5038";
        ///String udata = "08/11/1977";
        ///int id = 1;
        ///String insertCommand = "UPDATE Pessoa SET "+ 
            ///"Nome = '"+uNome+"', Telefone = '"+uTelefone+"', DataNascimento ='"+udata+"' WHERE ID = "+ id;
        ///dbl.dbSetCommand(dbPathFile, insertCommand);

        //DELETE
        ///int id = 2;
        ///string deleteCommand = "DELETE FROM Pessoa WHERE ID = " + id;
        ///dbl.dbSetCommand(dbPathFile, deleteCommand);

        //int id = 3;
        //string getCommand = "SELECT * FROM Pessoa WHERE ID = " + id;
        String tableName = "Pessoa";
        String getData = dbl.dbGetCommand(dbPathFile, tableName, "Nome", "ID", "3");

        //foreach (object values in getData)
        //{
            //Console.WriteLine(values);
        //    MessageDialog md = new MessageDialog(this,
        //    DialogFlags.DestroyWithParent, MessageType.Info,
        //                                         ButtonsType.Close, values.ToString());
        //    md.Run();
        //    md.Destroy();
        //} 

        //String dbPathFile, String tableName, String resultCol, String refCol, String refData

        MessageDialog md = new MessageDialog(this,
            DialogFlags.DestroyWithParent, MessageType.Info,
                                             ButtonsType.Close, getData);
            md.Run();
            md.Destroy();

        sigom.WorkshopWindow w = new sigom.WorkshopWindow();
        w.Show();

        this.Destroy();

        */

        //**********************************************************************

        //***Path do banco de dados***//
        //String path = System.IO.Directory.GetCurrentDirectory() + "/";
        //String dbName = "sigomDb.db";
        //String dbPathFile = path + dbName;
        //DbLite dbl = new DbLite();

        //dbl.showMessage(dbPathFile);
        //***Criando o banco de dados***//
        //dbl.dbCreate(dbPathFile);

        //***criando a tabela de login***//
        //string createTable = @"CREATE TABLE Login (ID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,Nome VARCHAR(100) NOT NULL,Senha VARCHAR (10) NOT NULL )";
        //dbl.dbSetCommand(dbPathFile, createTable);


        //***Inserir o administrador do login***//
        //String Nome = "admin";
        //String Senha = "123456";
        //String insertCommand = "INSERT INTO Login (Nome, Senha)"+ 
        //    "VALUES('"+Nome+"','"+Senha+"')";
        //dbl.dbSetCommand(dbPathFile, insertCommand);


        //int id = 1;
        //string getCommand = "SELECT * FROM Login WHERE ID = " + id;
        //String tableName = "Login";
        //String getData = dbl.dbGetCommand(dbPathFile, tableName, "Nome", "Nome", "admin1");

        //dbl.showMessage(getData);


        //foreach (object values in getData)
        //{

        //**********************************************************************

        //sigom.WorkshopWindow ww = new sigom.WorkshopWindow();
        //ww.Show();
        //this.Destroy();

        //DbLite dbl = new DbLite();
        //dbl.inputData();
        //dbl.showMessage(dbl.inputData());

        // This test that the InputBox can handle more newline than one.


        //if (test.ReturnCode == DialogResult.OK)
        //    MessageBox.Show(test.Text);


        //sigom.AlterarUsuario cadUser = new AlterarUsuario();

        //sigom.deletarUsuario deletUser = new deletarUsuario();

        DataSys db = new DataSys("sigomDb.db");
        String addressBank = db.dbPathFile;
        db.showMessage("Message");

    }

    protected void OnBtnNewDbClicked(object sender, EventArgs e)
    {
        //**********************************************************************

        //***Path do banco de dados***//
        String path = System.IO.Directory.GetCurrentDirectory() + "/";
        String dbName = "sigomDb.db";
        String dbPathFile = path + dbName;
        DbLite dbl = new DbLite();

        dbl.showMessage(dbPathFile);
        //***Criando o banco de dados***//
        //dbl.dbCreate(dbPathFile);

        //***criando a tabela de login***//
        //string createTable = @"CREATE TABLE Login (ID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,Nome VARCHAR(100) NOT NULL,Senha VARCHAR (10) NOT NULL )";
        //dbl.dbSetCommand(dbPathFile, createTable);


        //***Inserir o administrador do login***//
        //String Nome = "admin";
        //String Senha = "123456";
        //String insertCommand = "INSERT INTO Login (Nome, Senha)"+ 
        //    "VALUES('"+Nome+"','"+Senha+"')";
        //dbl.dbSetCommand(dbPathFile, insertCommand);

    }

    protected void OnBtnLoginClicked(object sender, EventArgs e)
    {
        String path = System.IO.Directory.GetCurrentDirectory() + "/";
        String dbName = "sigomDb.db";
        String dbPathFile = path + dbName;
        DbLite dbl = new DbLite();

        dbl.showMessage(dbPathFile);

        String tableName = "Login";

        etrUser.Text = etrUser.Text.Trim();
        etrPsw.Text = etrPsw.Text.Trim();

            if ((etrUser.Text != "") && (etrPsw.Text != ""))
            {

                String getData = dbl.dbGetCommand(dbPathFile, tableName, "Nome", "Nome", etrUser.Text);

                if (etrUser.Text == getData)
                {
                    getData = dbl.dbGetCommand(dbPathFile, tableName, "Senha", "Senha", etrPsw.Text);
                    if (etrPsw.Text == getData)
                    {
                        sigom.WorkshopWindow ww = new sigom.WorkshopWindow();
                        ww.Show();
                        this.Destroy();
                    }
                    else
                    {
                        dbl.showMessage("Usuário e/ou Senha incorreto!");
                    }
                }
                else
                {
                    dbl.showMessage("Usuário e/ou Senha incorreto!");
                }
            }
            else{
                dbl.showMessage("Usuário e/ou Senha é obrigatório!"); 
            }
        }
}

//ref.Continua ...
//http://techblog.desenvolvedores.net/2011/05/02/csharp-com-sqlite/
