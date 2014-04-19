using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using SZ.Common;

namespace SZ.Common.Test
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public static void GetStrTest()
        {
            SZ.Common.Class1 cc = new Common.Class1();
            var res = cc.GetStr();
        }
    }
}
