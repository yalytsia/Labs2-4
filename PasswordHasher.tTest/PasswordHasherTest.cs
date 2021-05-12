using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IIG.PasswordHashingUtils;

namespace PasswordHasherUtils.tTest
{
    [TestClass]
    public class PasswordHasherTest
    {
        private const int adler = 45;
        private string string1 = "string123";
        private string string_lat1 = "sugar";
        private string string_lat3 = "üæåøùçéñ";
        private string string_kyrrilic1 = "древляне";
        private string string_kyrrilic2 = "ВлАдИмИр";
        private string string_kyrrilic3 = "ЇїъЪёЁІііІІ";
        private string string_chineese = "魔道祖师";
        private string string_korean = "사랑";
        private string string_emo = "🌑🌒	🌓🌔🌕🌖🌗🌘";
        private string string_symbols = "¡¿@:|/'\"-_=+^&*()&!?#№%.,";
        private string string_numbers = "0123456789";
        private string string_empty = "";
        private string string_space1 = " ";



        /// <summary>
        /// Init testing with null with and zero
        /// </summary>
        [TestMethod]
        public void InitNullZero_ShouldPass()
        {
            PasswordHasher.Init(null, 0);
            string hashedStr = PasswordHasher.GetHash(string1);
            Assert.IsNotNull(hashedStr);
        }
        /// <summary>
        /// Init testing with english letters and max value
        /// </summary>
        [TestMethod]
        public void InitMaxAdler_ShouldPass()
        {
            PasswordHasher.Init(string_lat1, uint.MaxValue);
            string hashedStr = PasswordHasher.GetHash(string1);
            Assert.IsNotNull(hashedStr);
        }
        /// <summary>
        /// Init testing with english letters and min value
        /// </summary>
        [TestMethod]
        public void InitMinAdler_ShouldPass()
        {
            PasswordHasher.Init(string_lat1, uint.MinValue);
            string hashedStr = PasswordHasher.GetHash(string1);
            Assert.IsNotNull(hashedStr);
        }
        /// <summary>
        /// Init testing with space and medium value
        /// </summary>
        [TestMethod]
        public void InitSpace_ShouldPass()
        {
            PasswordHasher.Init(string_space1, adler);
            string hashedStr = PasswordHasher.GetHash(string1);
            Assert.IsNotNull(hashedStr);
        }
        /// <summary>
        /// Init testing with empty string and medium value
        /// </summary>            

        [TestMethod]
        public void InitEmpty_ShouldPass()
        {
            PasswordHasher.Init(string_empty, adler);
            string hashedStr = PasswordHasher.GetHash(string1);
            Assert.IsNotNull(hashedStr);
        }

        /// <summary>
        /// Init testing with english letters and medium value
        /// </summary>
        [TestMethod]
        public void InitNormal_ShouldPass()
        {
            PasswordHasher.Init(string_lat1, adler);
            string hashedStr = PasswordHasher.GetHash(string1);
            Assert.IsNotNull(hashedStr);
        }

        /// <summary>
        /// Init testing with non english special letters and medium value
        /// </summary>
        [TestMethod]
        public void InitLat3_ShouldPass()
        {
            PasswordHasher.Init(string_lat3, adler);
            string hashedStr = PasswordHasher.GetHash(string1);
            Assert.IsNotNull(hashedStr);
        }

        /// <summary>
        /// Init testing with kyrrilic letters and medium value
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void InitCyrillic_ShouldThrowExeption()
        {
            PasswordHasher.Init(string_kyrrilic1, adler);
            string hashedStr = PasswordHasher.GetHash(string1);
            Assert.IsNull(hashedStr);
        }

        /// <summary>
        /// Init testing with emojies and medium value
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void InitEmo_ShouldThrowExeption()
        {
            PasswordHasher.Init(string_emo, adler);
            string hashedStr = PasswordHasher.GetHash(string1);
            Assert.IsNull(hashedStr);
        }
        /// <summary>
        /// Init testing with numbers and medium value
        /// </summary>
        [TestMethod]
        public void InitNumber_ShouldPass()
        {
            PasswordHasher.Init(string_numbers, adler);
            string hashedStr = PasswordHasher.GetHash(string1);
            Assert.IsNotNull(hashedStr);
        }

        /// <summary>
        /// Init testing with symbols and medium value
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void InitSymbols_ShouldThrowExeption()
        {
            PasswordHasher.Init(string_symbols, adler);
            string hashedStr = PasswordHasher.GetHash(string1);
            Assert.IsNull(hashedStr);
        }

        /// <summary>
        /// Init testing with chineese and medium value
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void InitChineese_ShouldThrowExeption()
        {
            PasswordHasher.Init(string_chineese, adler);
            string hashedStr = PasswordHasher.GetHash(string1);
            Assert.IsNull(hashedStr);
        }


        /// <summary>
        /// Init testing with korean and medium value
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void InitKoreans_ShouldThrowExeption()
        {
            PasswordHasher.Init(string_korean, adler);
            string hashedStr = PasswordHasher.GetHash(string1);
            Assert.IsNull(hashedStr);
        }



        /// <summary>
        /// GetHash testing with english letters and medium value
        /// </summary>
        [TestMethod]
        public void GetHashNormal_ShouldPass()
        {
            string hashedStr = PasswordHasher.GetHash(string1, string_lat1, adler);
            Assert.IsNotNull(hashedStr);
        }

        /// <summary>
        /// GetHash testing without string and adler value
        /// </summary>
        [TestMethod]
        public void GetHashWithout_ShouldPass()
        {
            string hashedStr = PasswordHasher.GetHash(string1);
            Assert.IsNotNull(hashedStr);
        }

        /// <summary>
        ///  GetHash testing without empty and empty string and medium value
        /// </summary>
        [TestMethod]
        public void GetHashEmpty_ShouldPass()
        {
            string hashedStr = PasswordHasher.GetHash(string_empty, string_empty, adler);
            Assert.IsNotNull(hashedStr);
        }

        /// <summary>
        /// GetHash testing with kyrrilics and medium value
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void Cyrillic_ShouldThrowExeption()
        {
            string hashedStr = PasswordHasher.GetHash(string_kyrrilic1, string_kyrrilic2, adler);
            Assert.IsNotNull(hashedStr);
        }

        /// <summary>
        /// GetHash testing with kyrrilics and medium value
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void GetHashKyr_ShouldThrowExeption()
        {
            string hashedStr = PasswordHasher.GetHash(string_kyrrilic1, string_kyrrilic3, adler);
            Assert.IsNotNull(hashedStr);
        }
        /// <summary>
        /// GetHash testing with english strings and max value
        /// </summary>
        [TestMethod]
        public void GetHashMax_ShouldPass()
        {
            string hashedStr = PasswordHasher.GetHash(string1, string_lat1, uint.MaxValue);
            Assert.IsNotNull(hashedStr);
        }

        /// <summary>
        /// GetHash testing with english strings and min value
        /// </summary>
        [TestMethod]
        public void GetHashMin_ShouldPass()
        {
            string hashedStr = PasswordHasher.GetHash(string1, string_lat1, uint.MinValue);
            Assert.IsNotNull(hashedStr);
        }

        /// <summary>
        /// GetHash testing with null
        /// </summary>
        [TestMethod]
        public void GetHashNull_ShouldPass()
        {
            string hashedStr = PasswordHasher.GetHash(string1, null, null);
            Assert.IsNotNull(hashedStr);
        }
    }
}
