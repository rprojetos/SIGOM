using System;
using Gtk;
using System.Collections;
using System.Collections.Generic;
//using Mono.Data.Sqlite;
//using System.Data.SQLite;
namespace sigom
{
    public class DbLite
    {
        public DbLite()
        {
        }

        public void showMessage(String msg){
            MessageDialog md = new MessageDialog(null ,
            DialogFlags.DestroyWithParent, MessageType.Info,
            ButtonsType.Close, msg);
            md.Run();
            md.Destroy();
        }

        public void dbCreate(String dbPathFile)           
        {
            try{
                if (System.IO.File.Exists(dbPathFile))
                    System.IO.File.Delete(dbPathFile);

                Mono.Data.Sqlite.SqliteConnection.CreateFile(dbPathFile);
                showMessage("O db "+ dbPathFile +", foi criado com sucesso!");
            }
            catch(Exception ex){
                showMessage("Erro ao criar db: " + ex.Message);
            }
        }

        public void dbSetCommand(String dbPathFile, String commands)
        {
            bool exists = System.IO.File.Exists(dbPathFile);
            if (exists)
            {
                try
                {
                    showMessage(dbPathFile);
                    showMessage(commands);
                    Mono.Data.Sqlite.SqliteConnection connection =
                        new Mono.Data.Sqlite.SqliteConnection("Data Source=" + dbPathFile);
                    connection.Open();
                    Mono.Data.Sqlite.SqliteCommand dbcmd = connection.CreateCommand();
                    dbcmd.CommandText = commands;
                    dbcmd.ExecuteNonQuery();
                    connection.Close();
                    showMessage("SqliteCommand Executado com sucesso!");
                }
                catch (Exception ex)
                {
                    showMessage("Erro ao executar SqliteCommand: " + ex.Message);
                }
            }
            else
            {
                showMessage("O db " + dbPathFile + ", não foi encontrado.");
            }
        }

        //dbPathFile --> path file do banco de dados
        //tablename --> nome da tabela
        //resultCol --> coluna da tabela que sera retornada Ex."Nome"
        //refCol --> coluna de referencia para comparação Ex."Senha"
        //refData --> dado que sera comparado com a coluna de referencia Ex."123"
        public String dbGetCommand(String dbPathFile, String tableName, String resultCol, String refCol, String refData)
        {
            int i = 0;
            String resultModel = "";
            String strQuery = "SELECT * FROM " + tableName;
            ArrayList readArray = new ArrayList();
            try
            {
               Mono.Data.Sqlite.SqliteConnection connection =
                    new Mono.Data.Sqlite.SqliteConnection("Data Source=" + dbPathFile);
                connection.Open();
                Mono.Data.Sqlite.SqliteCommand dbcmd = connection.CreateCommand();

                dbcmd.CommandText = strQuery;

                //SqliteDataReader rdr = cmd.ExecuteReader()
                Mono.Data.Sqlite.SqliteDataReader rdr = dbcmd.ExecuteReader();


                while (rdr.Read())
                {
                    i++;
                    //if(rdr[refCol].ToString() == refData){
                    //    resultModel = rdr[resultCol].ToString();
                    //}

                    if (rdr[refCol].ToString() == refData)
                    {
                        resultModel = rdr[resultCol].ToString();
                    }
                }


                connection.Close();
               
            }
            catch (Exception ex)
            {
                showMessage("Erro ao executar SqliteDataReader: " + ex.Message);
            }

            return resultModel;
        }

    }
}
