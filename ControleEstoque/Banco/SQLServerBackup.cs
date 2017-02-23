using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferramentas
{
    public class SQLServerBackup
    {
        public static ArrayList ObtemBancoDeDadosSQLSever(String ConnString)
        {
            ArrayList lista = new ArrayList();
            //criou a conexao
            SqlConnection cn = new SqlConnection(ConnString);
            //criou o comando
            SqlCommand cm = new SqlCommand();
            cm.Connection = cn;
            cm.CommandText = "SELECT [name] FROM sysdatabases";
            //criou o datareader
            SqlDataReader dr;
            try
            {
                cn.Open();
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(dr["name"]);
                }

            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
            finally
            {
                cn.Close();
            }
            return lista;
        }

        public static void BackupDataBase(String ConnString, string nomeDB, string backupFile)
        {
            //criou a conexao
            SqlConnection cn = new SqlConnection(ConnString);
            //criou o comando
            SqlCommand cm = new SqlCommand();
            cm.Connection = cn;
            cm.CommandText = "BACKUP DATABASE [" + nomeDB + "] TO DISK = '" + backupFile + "'";
            try
            {
                cn.Open();
                cm.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public static void RestauraDatabase(String ConnString, string nomeDB, string backupFile)
        {
            //criou a conexao
            SqlConnection con = new SqlConnection(ConnString);
            //limpa a conexao
            SqlConnection.ClearAllPools();
            con.Open();

            int iReturn = 0;

            // Se Banco não existir é criado.
            string strCommand = string.Format("SET NOCOUNT OFF; SELECT COUNT(*) FROM master.dbo.sysdatabases where name=\'{0}\'", nomeDB);
            using (SqlCommand sqlCmd = new SqlCommand(strCommand, con))
            {
                iReturn = Convert.ToInt32(sqlCmd.ExecuteScalar());
            }
            if (iReturn == 0)
            {
                SqlCommand command = con.CreateCommand();
                command.CommandText = "CREATE DATABASE " + nomeDB;
                command.ExecuteNonQuery();
            }
            //criou o comando
            string Restore = @"RESTORE Database [" + nomeDB + "] FROM DISK = N'" + backupFile + @"' WITH  FILE = 1,  NOUNLOAD,  REPLACE,  STATS = 10";
            SqlCommand RestoreCmd = new SqlCommand(Restore, con);
            try
            {
                RestoreCmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}

