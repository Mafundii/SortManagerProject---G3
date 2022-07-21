using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SortTests
{
    public class MergeSortTests
    {
        [TestCaseSource(typeof(TestData), nameof(TestData.ArraysToTest))]
        public void GivenAnArrayOfMultipeDifferentNumbers_Sort_ReturnsLowestToHighest(int[] array, int[] resultArray)
        {
            Assert.That(MergeSort.MergeSorting(array), Is.EqualTo(resultArray));
        }

        [TestCaseSource(typeof(TestData), nameof(TestData.NegativeArraysToTest))]
        public void GivenAnArrayOfNegativeNumbers_Sort_ReturnsLowestToHighest(int[] array, int[] resultArray)
        {
            Assert.That(MergeSort.MergeSorting(array), Is.EqualTo(resultArray));
        }

        [TestCaseSource(typeof(TestData), nameof(TestData.OneElementArrayToTest))]
        public void GivenAnArrayOfOneNumber_Sort_ReturnsSameNumber(int[] array)
        {
            Assert.That(MergeSort.MergeSorting(array), Is.EqualTo(array));
        }

        [TestCaseSource(typeof(TestData), nameof(TestData.EmptyArrayToTest))]
        public void GivenAnEmptyArray_Sort_ReturnsEmptyArray(int[] array)
        {
            Assert.That(MergeSort.MergeSorting(array), Is.EqualTo(array));
        }

        [TestCaseSource(typeof(TestData), nameof(TestData.SameNumberArrayToTest))]
        public void GivenAnArrayOfTheSameNumbers_Sort_ReturnsSameNumbers(int[] array)
        {
            Assert.That(MergeSort.MergeSorting(array), Is.EqualTo(array));
        }
    }
}
