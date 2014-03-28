using Dibware.UnitTesting.Resources;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Dibware.UnitTesting
{
    /// <summary>
    /// Encapsulates String based asserts
    /// Ref:
    ///   http://geekswithblogs.net/sdorman/archive/2009/01/31/adding-custom-assertions-to-mstest.aspx
    /// </summary>
    public static class StringAssert
    {
        #region IsEmpty

        /// <summary>
        /// Asserts that the specified value is empty.
        /// </summary>
        /// <param name="value">The value to be tested.</param>
        public static void IsEmpty(String value)
        {
            IsEmpty(value, AssertFailureMessages.Generic, String.Empty, value);
        }

        /// <summary>
        /// Asserts that the specified value is empty.
        /// </summary>
        /// <param name="value">The value to be tested.</param>
        /// <param name="message">A message to display. This message can be seen in the unit test results.</param>
        public static void IsEmpty(String value, String message)
        {
            IsEmpty(value, message, null);
        }

        /// <summary>
        /// Asserts that the specified value is empty.
        /// </summary>
        /// <param name="value">The value to be tested.</param>
        /// <param name="message">A message to display. This message can be seen in the unit test results.</param>
        /// <param name="parameters">An array of parameters to use when formatting <paramref name="message"/>.</param>
        public static void IsEmpty(String value, String message, params object[] parameters)
        {
            Assert.IsTrue(value.Length == 0, message, parameters);
        }

        #endregion
    }
}