using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace System.Globalization_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Calendar
            DateTime d1 = DateTime.Now;

            System.Globalization.Calendar calendar;
            DateTime dt = new DateTime(2019, 1, 1, new GregorianCalendar());
            dt.AddHours(3.29);

            DateTime d2 = DateTime.Now;

            TimeSpan timeSpan = d1.Subtract(d2);
            #endregion

            #region CultureInfo
            System.Globalization.CultureInfo cultureInfo = new CultureInfo("pt-BR");
            #endregion

            #region CultureInfo - Threading
            CultureInfo cit = System.Threading.Thread.CurrentThread.CurrentCulture;

            //Mudando o CultureInfo da Thread que está sendo executada
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

            CultureInfo cvi = CultureInfo.InvariantCulture;
            #endregion
        }
    }
}
