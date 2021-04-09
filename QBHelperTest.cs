using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using TapcheckHR.Helpers;

namespace TapcheckHR.UnitTest
{
    [TestClass]
    public class QBHelperTest
    {
        [TestMethod]
        public void QBHelper_GetQBEmployeeDetails_ShouldSucceed()
        {
            QBHelper QBHelper = new QBHelper();

           var FileBytes = File.ReadAllBytes("SampleData/QBHelperEmployeeInformationFile.xlsx");

           DataTable dt = QBHelper.ExcelToDataTable(FileBytes);

            var actual = QBHelper.GetQBEmployeeDetails(dt);

            Assert.IsNotNull(actual,"actual");
            Assert.AreNotEqual(0, actual.Count,"actual.Count");
            

        }
    }
}
