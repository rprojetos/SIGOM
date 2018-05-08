using System;
using Gtk;
namespace sigom
{
    public class DataSys
    {
        public String dbPathFile;

        public DataSys(String dataBaseName)
        {
            String path = System.IO.Directory.GetCurrentDirectory() + "/";
            dbPathFile = path + dataBaseName;
        }

        public void showMessage(String msg)
        {
            MessageDialog md = new MessageDialog(null,
            DialogFlags.DestroyWithParent, MessageType.Info,
            ButtonsType.Close, msg);
            md.Run();
            md.Destroy();
        }

        public void dbCreate(String dbPathFile)
        {
            try
            {
                if (System.IO.File.Exists(dbPathFile))
                    System.IO.File.Delete(dbPathFile);

                Mono.Data.Sqlite.SqliteConnection.CreateFile(dbPathFile);
                showMessage("O db " + dbPathFile + ", foi criado com sucesso!");
            }
            catch (Exception ex)
            {
                showMessage("Erro ao criar db: " + ex.Message);
            }
        }

        public void inDataTable(){
            
        }


    }
}
