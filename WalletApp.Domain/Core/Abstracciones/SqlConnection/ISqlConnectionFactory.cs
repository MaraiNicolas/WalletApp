using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace WalletApp.Domain.Core.Abstracciones.SqlConnection
{
    public interface ISqlConnectionFactory
    {
        IDbConnection CreateConnection();
    }
}
