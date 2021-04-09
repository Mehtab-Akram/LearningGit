using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TapcheckHR.Helpers;

namespace TapcheckHR.UnitTest
{
    [TestClass]
    public class MatrixCareHelperTest
    {
        [TestMethod]
        public void ConvertStringDateToDateTime()
        {
            //->Arrange
            MatrixCareHelper matrixCare = new MatrixCareHelper();

            //->Act
            var expected = matrixCare.ConvertToDateTime("1/31/2021");
            var actual = new DateTime(2021, 1, 31);

            //->Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MatrixCareHelper_GetMatrixCareTimeClockEnteries_ShouldSucceed()
        {
            //->Arrange
            MatrixCareHelper matrixCare = new MatrixCareHelper();

            //->Act
            var actual = matrixCare.GetMatrixCareTimeClockEnteries(@"SampleData\MatrixCareTimeClockSampleFile.csv");

            //->Assert
            Assert.IsNotNull(actual,"Actual");
            Assert.AreNotEqual(0, actual.Count,"Actual.Count");
            Assert.AreEqual(2, actual.Count,"Actual.Count");
        }
    }
}
