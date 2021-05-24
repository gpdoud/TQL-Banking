using System;
using System.Collections.Generic;
using System.Text;

namespace TQL_Banking {
    interface IBanking {
        decimal GetBalance();
        string GetAccountNumber();
    }
}
