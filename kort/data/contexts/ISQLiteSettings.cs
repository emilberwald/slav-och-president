using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kort.data.contexts
{
    public interface ISqliteSettings
    {
        string ConnectionString { get; set; }
        int? CommandTimeout { get; set; }
    }
}
