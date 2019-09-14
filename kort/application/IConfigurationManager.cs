using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kort.data.contexts;

namespace kort.application
{
    public interface IConfigurationManager
    {
        ISqliteSettings CreateISqliteSettings(Uri sqliteUri, int? commandTimeout);
        bool Has<T>();
        T Get<T>();
        void Set<T>(T t);
    }
}
