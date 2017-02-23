using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Info.DAO
{
    public class DataContextFactory//classe fabrica DAO
    {
        private static InfoDataContext dataContext;//cria conexao
        public static InfoDataContext DataContext //cria a classe da conexao
        {
            get
            {
                if (dataContext == null)
                    dataContext = new InfoDataContext();

                return dataContext;
            }
        }
    }
}
