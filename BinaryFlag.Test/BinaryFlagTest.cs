using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IIG.BinaryFlag;
using System.Collections.Generic;

namespace BinaryFlag.Test
{
    [TestClass]
    public class BinaryFlagTest
    {
        const ulong length_0 = 0UL;
        const ulong length_1 = 1UL;
        const ulong length_2 = 2UL;
        const ulong length_3 = 3UL;
        const ulong length_32 = 32UL;
        const ulong length_33 = 33UL;
        const ulong length_64 = 64UL;
        const ulong length_17179868704 = 17179868704UL;
        const ulong length_17179868705 = 17179868705UL;

        #region Constructor

        [DataTestMethod]
        [DataRow(length_2, true)]
        [DataRow(length_3, true)]
        [DataRow(length_32, true)]
        public void Route_1_2_3_8_11_13_15(ulong length, bool initValue)
        {
            try
            {
                var binFlag = new MultipleBinaryFlag(length, initValue);
            }
            catch (Exception e)
            {
                Assert.IsTrue(false);
            }
        }
        [DataTestMethod]
        [DataRow(length_33, true)]
        [DataRow(length_64, true)]
        public void Route_1_2_4_9_12_13_15(ulong length, bool initValue)
        {
            try
            {
                var binFlag = new MultipleBinaryFlag(length, initValue);
            }
            catch (Exception e)
            {
                Assert.IsTrue(false);
            }
        }
        [DataTestMethod]
        [DataRow(length_64, true)]
        [DataRow(length_17179868704, true)]
        public void Route_1_2_5_6_7_15True(ulong length, bool initValue)
        {
            try
            {
                var binFlag = new MultipleBinaryFlag(length, initValue);
            }
            catch (Exception e)
            {
                Assert.IsTrue(false);
            }
        }

        [DataTestMethod]
        [DataRow(length_2)]
        [DataRow(length_3)]
        [DataRow(length_32)]
        public void Route_1_2_3_8_11_13_14_15(ulong length)
        {
            try
            {
                var binFlag = new MultipleBinaryFlag(length);
            }
            catch (Exception e)
            {
                Assert.IsTrue(false);
            }
        }

        [DataTestMethod]
        [DataRow(length_33)]
        [DataRow(length_64)]
        public void Route_1_2_4_9_12_13_14_15(ulong length)
        {
            try
            {
                var binFlag = new MultipleBinaryFlag(length);
            }
            catch (Exception e)
            {
                Assert.IsTrue(false);
            }
        }

        [DataTestMethod]
        [DataRow(length_64)]
        [DataRow(length_17179868704)]
        public void Route_1_2_5_6_7_15(ulong length)
        {
            try
            {
                var binFlag = new MultipleBinaryFlag(length);
            }
            catch (Exception e)
            {
                Assert.IsTrue(false);
            }
        }

        [DataTestMethod]
        [DataRow(length_2, false)]
        [DataRow(length_3, false)]
        [DataRow(length_32, false)]
        public void Route_1_2_3_8_11_13_14_15(ulong length, bool initValue)
        {
            try
            {
                var binFlag = new MultipleBinaryFlag(length, initValue);
                Assert.IsNotNull(binFlag);
            }
            catch (Exception e)
            {
                Assert.IsTrue(false);
            }
        }

        [DataTestMethod]
        [DataRow(length_33, false)]
        [DataRow(length_64, false)]
        public void Route_1_2_4_9_12_13_14_15(ulong length, bool initValue)
        {
            try
            {
                var binFlag = new MultipleBinaryFlag(length, initValue);
                Assert.IsNotNull(binFlag);
            }
            catch (Exception e)
            {
                Assert.IsTrue(false);
            }
        }
        [DataTestMethod]
        [DataRow(length_64, false)]
        [DataRow(length_17179868704, false)]
        public void Route_1_2_5_6_7_15False(ulong length, bool initValue)
        {
            try
            {
                var binFlag = new MultipleBinaryFlag(length, initValue);
                Assert.IsNotNull(binFlag);
            }
            catch (Exception e)
            {
                Assert.IsTrue(false);
            }
        }
        [DataTestMethod]
        [DataRow(length_1)]
        [DataRow(length_0)]
        public void Route_1_10_15(ulong length)
        {
            try
            {
                var binFlag = new MultipleBinaryFlag(length);
                Assert.IsTrue(false);
            }
            catch (Exception e)
            {
                Assert.IsTrue(true);
            }
        }
        [DataTestMethod]
        [DataRow(length_17179868705)]
        public void Route_1_2_10_15(ulong length)
        {
            try
            {
                var binFlag = new MultipleBinaryFlag(length);
                Assert.IsTrue(false);
            }
            catch (Exception e)
            {
                Assert.IsTrue(true);
            }
        }
        #endregion

        #region SetFlag

        [TestMethod]
        public void CompareObjects()
        {
            ulong length = length_2;
            bool initValue = false;
            try
            {
                var binFlag = new MultipleBinaryFlag(length, initValue);
                Assert.IsNotNull(binFlag);
                var binaryFlag2 = new MultipleBinaryFlag(length, initValue);
                Assert.IsNotNull(binaryFlag2);
                Assert.AreEqual(binFlag, binaryFlag2);
                Assert.IsTrue(false);
            }
            catch (Exception e)
            {
                Assert.IsTrue(true);
            }
        }

        [DataTestMethod]
        [DataRow(length_2, true)]
        [DataRow(length_33, true)]
        public void TestInitValTrue(ulong length, bool b)
        {
            try
            {
                var binFlag = new MultipleBinaryFlag(length, b);
                var flag = binFlag.GetFlag();
                Assert.IsNotNull(flag);
                Assert.AreEqual(flag, b);
            }
            catch (Exception e)
            {
                Assert.IsTrue(false);
            }
        }
        [DataTestMethod]
        [DataRow(length_2, false)]
        [DataRow(length_33, false)]
        public void TestInitValFalse(ulong length, bool b)
        {
            try
            {
                var binFlag = new MultipleBinaryFlag(length, b);
                var flag = binFlag.GetFlag();
                Assert.IsNotNull(flag);
                Assert.AreEqual(flag, b);
            }
            catch (Exception e)
            {
                Assert.IsTrue(false);
            }
        }

        [DataTestMethod]
        [DataRow(length_2)]
        [DataRow(length_33)]
        public void TestInitValEmptyFlag(ulong length)
        {
            try
            {
                var binFlag = new MultipleBinaryFlag(length);
                var flag = binFlag.GetFlag();
                Assert.IsNotNull(flag);
                Assert.AreEqual(flag, true);
            }
            catch (Exception e)
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void TestSetFlagTrue()
        {
            ulong length = length_2;
            bool initValue = true;
            ulong pos = 1UL;
            try
            {
                var binFlag = new MultipleBinaryFlag(length, initValue);
                binFlag.SetFlag(pos);
                var flag = binFlag.GetFlag();
                Assert.IsNotNull(flag);
                Assert.AreEqual(flag, initValue);
            }
            catch (Exception e)
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void TestSetFlagFalse()
        {
            ulong length = length_2;
            bool initValue = false;
            ulong pos = 1UL;
            try
            {
                var binFlag = new MultipleBinaryFlag(length, initValue);
                binFlag.SetFlag(pos);
                var flag = binFlag.GetFlag();
                Assert.IsNotNull(flag);
                Assert.AreEqual(flag, initValue);
            }
            catch (Exception e)
            {
                Assert.IsTrue(false);
            }
        }

        [DataTestMethod]
        [DataRow(length_2, false, new ulong[] { 0UL, 1UL }, true)]
        [DataRow(length_2, false, new ulong[] { 0UL }, false)]
        [DataRow(length_2, false, new ulong[] { }, false)]
        [DataRow(length_2, true, new ulong[] { }, true)]

        [DataRow(length_2, true, new ulong[] { 0UL, 1UL }, true)]
        [DataRow(length_2, true, new ulong[] { 0UL }, true)]
        [DataRow(length_33, false, new ulong[] { }, false)]
        [DataRow(length_33, true, new ulong[] { }, true)]
        public void Route_0_1_3_4False(ulong length, bool initValue, ulong[] positions, bool result)
        {
            try
            {
                var binFlag = new MultipleBinaryFlag(length, initValue);
                foreach (ulong pos in positions)
                {
                    binFlag.SetFlag(pos);
                }
                var flag = binFlag.GetFlag();
                Assert.IsNotNull(flag);
                Assert.AreEqual(flag, result);
            }
            catch (Exception e)
            {
                Assert.IsTrue(false);
            }
        }

        [DataTestMethod]
        [DataRow(length_2, false, true)]
        [DataRow(length_33, false, true)]

        [DataRow(length_2, true, true)]
        [DataRow(length_33, true, true)]

        public void Route_0_1_3_4True(ulong length, bool initValue, bool result)
        {
            try
            {
                var binFlag = new MultipleBinaryFlag(length, initValue);
                for (ulong i = 0; i < length; i++)
                {
                    binFlag.SetFlag(i);
                }
                var flag = binFlag.GetFlag();
                Assert.IsNotNull(flag);
                Assert.AreEqual(flag, result);
            }
            catch (Exception e)
            {
                Assert.IsTrue(false);
            }
        }

        [DataTestMethod]
        [DataRow(length_2, false, 3UL)]
        [DataRow(length_33, false, 35UL)]
        [DataRow(length_2, true, 3UL)]
        [DataRow(length_33, true, 35UL)]

        public void Route_0_1_2_4(ulong length, bool b, ulong pos)
        {
            try
            {
                var binFlag = new MultipleBinaryFlag(length, b);
                binFlag.SetFlag(pos);
            }
            catch (Exception e)
            {
                Assert.IsTrue(true);
            }
        }

        [DataTestMethod]
        [DataRow(length_2, false, 3UL)]
        [DataRow(length_33, false, 35UL)]
        [DataRow(length_2, true, 3UL)]
        [DataRow(length_33, true, 35UL)]
        public void Route_0_4(ulong length, bool b, ulong pos)
        {
            try
            {
                var binFlag = new MultipleBinaryFlag(length, b);
                binFlag.Dispose();
                binFlag.SetFlag(pos);
            }
            catch (Exception e)
            {
                Assert.IsTrue(false);
            }
        }
        #endregion

        #region Dispose

        [DataTestMethod]
        [DataRow(length_2, false)]
        [DataRow(length_33, false)]
        [DataRow(length_2, true)]
        [DataRow(length_33, true)]

        public void Route_0_1_2_3_4(ulong length, bool b)
        {
            try
            {
                var binFlag = new MultipleBinaryFlag(length, b);
                binFlag.Dispose();
            }
            catch (Exception e)
            {
                Assert.IsTrue(false);
            }
        }

        [DataTestMethod]

        [DataRow(length_2, false)]
        [DataRow(length_33, false)]

        [DataRow(length_2, true)]
        [DataRow(length_33, true)]

        public void Route_0_4Dispose(ulong length, bool b)
        {
            try
            {
                var binFlag = new MultipleBinaryFlag(length, b);
                binFlag.Dispose();
            }
            catch (Exception e)
            {
                Assert.IsTrue(false);
            }
        }

        #endregion

        #region GetFlag

        [TestMethod]
        public void Route_0_2()
        {
            ulong length = length_2;
            try
            {
                var binFlag = new MultipleBinaryFlag(length);
                binFlag.Dispose();
                var flag = binFlag.GetFlag();
                Assert.AreEqual(flag, null);
            }
            catch (Exception e)
            {
                Assert.IsTrue(false);
            }

        }

        [DataTestMethod]
        [DataRow(length_2, false)]
        [DataRow(length_33, false)]
        [DataRow(length_2, true)]
        [DataRow(length_33, true)]
        public void Route_0_1_2(ulong length, bool b)
        {
            try
            {
                var binFlag = new MultipleBinaryFlag(length, b);
                var flag = binFlag.GetFlag();
                Assert.IsNotNull(flag);
            }
            catch (Exception e)
            {
                Assert.IsTrue(false);
            }

        }

        #endregion

        #region ResetFlag

        [DataTestMethod]
        [DataRow(length_2, false)]
        [DataRow(length_33, false)]
        [DataRow(length_2, true)]
        [DataRow(length_33, true)]

        public void Route_0_4(ulong length, bool b)
        {
            try
            {
                var binFlag = new MultipleBinaryFlag(length, b);
                binFlag.Dispose();
                binFlag.ResetFlag(0);
                var flag = binFlag.GetFlag();
                Assert.AreEqual(flag, null);
            }
            catch (Exception e)
            {
                Assert.IsTrue(false);
            }
        }

        [DataTestMethod]
        [DataRow(length_2, false)]
        [DataRow(length_33, false)]
        [DataRow(length_2, true)]
        [DataRow(length_33, true)]

        public void Route_0_1_2_4(ulong length, bool b)
        {
            try
            {
                var binFlag = new MultipleBinaryFlag(length, b);
                binFlag.ResetFlag(length);
            }
            catch (Exception e)
            {
                Assert.IsTrue(true);
            }
        }

        [DataTestMethod]
        [DataRow(length_2, false)]
        [DataRow(length_33, false)]
        [DataRow(length_2, true)]
        [DataRow(length_33, true)]

        public void Route_0_1_3_4(ulong length, bool b)
        {
            try
            {
                var binFlag = new MultipleBinaryFlag(length, b);
                binFlag.ResetFlag(0);
                var flag = binFlag.GetFlag();
                Assert.IsNotNull(flag);
            }
            catch (Exception e)
            {
                Assert.IsTrue(false);
            }
        }

        #endregion

        #region ToString   
        [DataTestMethod]
        [DataRow(length_3, false)]
        [DataRow(length_2, false)]
        [DataRow(length_32, false)]
        [DataRow(length_33, false)]
        [DataRow(length_64, false)]
        [DataRow(length_3, true)]
        [DataRow(length_2, true)]
        [DataRow(length_32, true)]
        [DataRow(length_33, true)]
        [DataRow(length_64, true)]
        public void FlagToString(ulong length, bool b)
        {
            try
            {
                var binFlag = new MultipleBinaryFlag(length, b);
                binFlag.ToString();
            }
            catch (Exception err)
            {
                Assert.IsTrue(false);
            }
        }

        #endregion
    }
}

