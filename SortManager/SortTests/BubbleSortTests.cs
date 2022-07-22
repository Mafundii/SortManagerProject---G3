using SortAlgorithms;

namespace SortTests
{
    public class BubbleSortTests
    {
        private BubbleSort _sut;
        [OneTimeSetUp]
        public void sort()
        {
            _sut = new BubbleSort();
        }


        [TestCaseSource(typeof(TestData), nameof(TestData.ArraysToTest))]
        public void GivenAnArrayOfMultipeDifferentNumbers_BubbleSorting_ReturnsLowestToHighest(int[] array, int[] resultArray)
        {
            Assert.That(_sut.Sort(array), Is.EqualTo(resultArray));
        }

        [TestCaseSource(typeof(TestData), nameof(TestData.SameNumberArrayToTest))]
        public void GivenAnArrayOfTheSameNumbers_BubbleSorting_ReturnsSameNumbers(int[] array)
        {
            Assert.That(_sut.Sort(array), Is.EqualTo(array));
        }

        [TestCaseSource(typeof(TestData), nameof(TestData.EmptyArrayToTest))]
        public void GivenAnEmptyArray_BubbleSorting_ReturnsEmptyArray(int[] array)
        { 
            Assert.That(_sut.Sort(array), Is.EqualTo(array));
        }

        [TestCaseSource(typeof(TestData), nameof(TestData.NegativeArraysToTest))]
        public void GivenAnArrayOfNegativeNumbers_BubbleSorting_ReturnsLowestToHighest(int[] array, int[] resultArray)
        {
            Assert.That(_sut.Sort(array), Is.EqualTo(resultArray));
        }


        [TestCaseSource(typeof(TestData), nameof(TestData.OneElementArrayToTest))]
        public void GivenAnArrayOfOneNumber_BubbleSorting_ReturnsSameNumber(int[] array)
        {
            Assert.That(_sut.Sort(array), Is.EqualTo(array));
        }
    }
}