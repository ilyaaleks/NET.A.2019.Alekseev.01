using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SortingsTests
{
    [TestClass]
    public class SortingsTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] a = { 3, 5, 1, 576, 23, 12, 75, 43, 2532 };
            int[] expected = { 1, 3, 5, 12, 23, 43, 75, 576, 2532 };
            Sortings.Sortings.Quick_Sort(a, 0, a.Length - 1);
            CollectionAssert.AreEqual(expected, a);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int[] a = { 3, 5, 1, 576, 23, 12, 75, 43, 2532 };
            int[] expected = { 1, 3, 5, 12, 23, 43, 75, 576, 2532 };
            Sortings.Sortings.MergeSort(a);
            CollectionAssert.AreEqual(expected, a);
        }
        [TestMethod]
        public void TestMethod3()
        {
            int[] a = { 3, 4, 1, 2, 1, 17, 12, 124 };
            int[] expected = { 1, 1, 2, 3, 4, 12, 17, 124 };
            Sortings.Sortings.MergeSort(a);
            CollectionAssert.AreEqual(expected, a);
        }
    }
}
