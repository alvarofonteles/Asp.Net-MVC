using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ferramentas
{
    public class Validacao
    {
        //Valida CPF
        public static bool IsCpf(string cpf)
        {
            try
            {
                int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                int soma, resto;
                string tempCpf, digito;

                cpf = cpf.Trim();
                cpf = cpf.Replace(".", "").Replace("-", "").Replace(" ", "");

                if (cpf.Length != 11)
                {
                    return false;
                }
                else
                {
                    tempCpf = cpf.Substring(0, 9);

                    soma = 0;
                    for (int i = 0; i < 9; i++)
                        soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

                    resto = soma % 11;
                    if (resto < 2)
                        resto = 0;
                    else
                        resto = 11 - resto;

                    digito = resto.ToString();
                    tempCpf = tempCpf + digito;

                    soma = 0;
                    for (int i = 0; i < 10; i++)
                        soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

                    resto = soma % 11;
                    if (resto < 2)
                        resto = 0;
                    else
                        resto = 11 - resto;

                    digito = digito + resto.ToString();
                    return cpf.EndsWith(digito);
                }
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }

        }

        //************************************************************************************

        //Valida  CNPJ
        public static bool IsCnpj(string cnpj)
        {
            try
            {
                int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
                int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
                int soma, resto;
                string digito, tempCnpj;

                cnpj = cnpj.Trim();
                cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "").Replace(" ", "");

                if (cnpj.Length != 14)
                {
                    return false;
                }
                else
                {
                    tempCnpj = cnpj.Substring(0, 12);

                    soma = 0;
                    for (int i = 0; i < 12; i++)
                        soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];

                    resto = (soma % 11);
                    if (resto < 2)
                        resto = 0;
                    else
                        resto = 11 - resto;

                    digito = resto.ToString();
                    tempCnpj = tempCnpj + digito;

                    soma = 0;
                    for (int i = 0; i < 13; i++)
                        soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];

                    resto = (soma % 11);
                    if (resto < 2)
                        resto = 0;
                    else
                        resto = 11 - resto;

                    digito = digito + resto.ToString();
                    return cnpj.EndsWith(digito);
                }
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }

        //************************************************************************************

        //Valida  E-mail
        public static bool ValidaEmail(string email)
        {
            string strRegex = "^([a-zA-Z0-9_\\-\\.]+)@((\\[[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]"
                + "{1,3}\\.)|(([a-zA-Z0-9\\-]+\\.)+))([a-zA-Z]{2,4}|[0,9]{1,3})(\\]?)$";
            Regex re = new Regex(strRegex);

            return !re.IsMatch(email);
        }

        //************************************************************************************

        //Verifica  Endereço (CEP)
        static public string cep = "";
        static public string cidade = "";
        static public string estado = "";
        static public string endereco = "";
        static public string bairro = "";

        public static Boolean verificaCEP(string CEP)
        {
            bool flag = true;
            try
            {
                DataSet ds = new DataSet();
                string xml = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml".Replace("@cep", CEP);
                ds.ReadXml(xml);
                endereco = ds.Tables[0].Rows[0]["logradouro"].ToString();
                bairro = ds.Tables[0].Rows[0]["bairro"].ToString();
                cidade = ds.Tables[0].Rows[0]["cidade"].ToString();
                estado = ds.Tables[0].Rows[0]["uf"].ToString();
                cep = CEP;

                if (endereco == "" && bairro == "" && cidade == "" && estado == "")
                {
                    flag = false;
                }
            }
            catch (Exception)
            {
                endereco = "";
                bairro = "";
                cidade = "";
                estado = "";
                cep = "";
                throw new Exception("Sem acesso a Internet.");
            }
            return flag;
        }

        //************************************************************************************

        //Valida  Endereço Backup do Banco
        public static void BackupDataBase(string ConnString, string nomeDB, string backupFile)
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

        //************************************************************************************

        //Valida  Endereço Restauração do Banco
        public static void RestauraDatabase(string ConnString, string nomeDB, string backupFile)
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

        //************************************************************************************

        //Valida  Endereço (CEP)
        public static bool ValidaCEP(string cep)//mascara
        {
            return Regex.IsMatch(cep, ("[0-9]{5}-[0-9]{3}"));
        }
    }
}
