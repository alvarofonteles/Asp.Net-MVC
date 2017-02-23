using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DadosDaConexao
    {
        public static String servidor;
        public static String banco;
        public static String usuario;
        public static String senha;

        public static String StringDeConexao
        {
            get
            {
                //@"Data Source=ANDROID-77A185F\SQLEXPRESS16;Initial Catalog=NewControleEstoque;User ID=sa;Password=lele";
                return @"Data Source=" + servidor + ";Initial Catalog=" + banco + ";User ID=" + usuario + ";Password=" + senha;
            }
        }
    }
}
