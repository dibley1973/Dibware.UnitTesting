using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Dibware.UnitTesting
{
    public static class IntegerAssert
    {
        #region IsLessThan

        /// <summary>
        /// Asserts that short integer value1 is less than value2.
        /// </summary>
        /// <param name="value1">The value1.</param>
        /// <param name="value2">The value2.</param>
        public static void IsLessThan(Int16 value1, Int16 value2)
        {
            Assert.IsTrue(value1 < value2);
        }

        /// <summary>
        /// Asserts that the integer value1 is less than value2.
        /// </summary>
        /// <param name="value1">The value1.</param>
        /// <param name="value2">The value2.</param>
        public static void IsLessThan(Int32 value1, Int32 value2)
        {
            Assert.IsTrue(value1 < value2);
        }

        /// <summary>
        /// Asserts that the long integer value1 is less than value2.
        /// </summary>
        /// <param name="value1">The value1.</param>
        /// <param name="value2">The value2.</param>
        public static void IsLessThan(Int64 value1, Int64 value2)
        {
            Assert.IsTrue(value1 < value2);
        }

        #endregion
    }
}
