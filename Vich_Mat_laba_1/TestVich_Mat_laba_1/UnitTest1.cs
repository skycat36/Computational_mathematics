using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestVich_Mat_laba_1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void WhenInterLagrangBeetwenNumberTrueThenTrue()
        {
            Vich_Mat_laba_1.TableInterp[] interp = new Vich_Mat_laba_1.TableInterp[5];
            interp[0] = new Vich_Mat_laba_1.TableInterp(1.0, Math.Sinh(1.0));
            interp[1] = new Vich_Mat_laba_1.TableInterp(1.1, Math.Sinh(1.1));
            interp[2] = new Vich_Mat_laba_1.TableInterp(1.2, Math.Sinh(1.2));
            interp[3] = new Vich_Mat_laba_1.TableInterp(1.3, Math.Sinh(1.3));
            interp[4] = new Vich_Mat_laba_1.TableInterp(1.4, Math.Sinh(1.4));
            Vich_Mat_laba_1.Inter inter = new Vich_Mat_laba_1.Inter(interp);
            inter.Set_ArgX(1.03);
            bool result;
            if (inter.LagrangInterp() <1.222029 && inter.LagrangInterp() > 1.222028)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            bool expected = true;
            Assert.AreEqual(result, expected);
        }
    }
}
