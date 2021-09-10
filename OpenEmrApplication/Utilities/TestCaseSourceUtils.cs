using System;
using System.Collections.Generic;
using System.Text;
using AutomationWrapper.Utilities;
namespace MetLife.OpenEmrApplication.Utilities
{
    class TestCaseSourceUtils
    {
        public static object[] ValidSendMessageData()
        {
            object[] main = ExcelUtils.GetSheetIntoObjectArray(@"D:\B-Mine\Company\Company\MetLife\OpenEmrApplication\OpenEmrApplication\TestData\OpenEMRData.xlsx", "ValidSendMessageTest");
            return main;
        }
        public static object[] AddPatientData()
        {
            object[] main = ExcelUtils.GetSheetIntoObjectArray(@"D:\B-Mine\Company\Company\MetLife\OpenEmrApplication\OpenEmrApplication\TestData\OpenEMRData.xlsx", "AddPatientTest");
            return main;
        }

        public static object[] ValidCredentialData()
        {
            object[] main =ExcelUtils.GetSheetIntoObjectArray(@"D:\B-Mine\Company\Company\MetLife\OpenEmrApplication\OpenEmrApplication\TestData\OpenEMRData.xlsx", "ValidCredentialTest");
            return main;
        }
        //public static object[] ValidCredentialData()
        //{
        //    object[] temp1 = new object[4];
        //    temp1[0] = "admin";
        //    temp1[1] = "pass";
        //    temp1[2] = "Dutch";
        //    temp1[3] = "OpenEMR";

        //    object[] temp2 = new object[4];
        //    temp2[0] = "John123";
        //    temp2[1] = "pass123";
        //    temp2[2] = "English (Indian)";
        //    temp2[3] = "OpenEMR";


        //    object[] main = new object[2];
        //    main[0] = temp1;
        //    main[1] = temp2;

        //    return main;
        //}

        public static object[] InvalidCredentialData()
        {
            object[] temp1 = new object[4];
            temp1[0] = "admin123";
            temp1[1] = "pass";
            temp1[2] = "Dutch";
            temp1[3] = "Invalid username or password";

            object[] temp2 = new object[4];
            temp2[0] = "John123";
            temp2[1] = "pass123";
            temp2[2] = "English (Indian)";
            temp2[3] = "Invalid username or password";


            object[] main = new object[2];
            main[0] = temp1;
            main[1] = temp2;

            return main;
        }

        //public static object[] AddPatientData()
        //{
        //    object[] temp1 = new object[4];
        //    temp1[0] = "admin123";
        //    temp1[1] = "pass";
        //    temp1[2] = "Dutch";
        //    temp1[3] = "Invalid username or password";

        //    object[] temp2 = new object[4];
        //    temp2[0] = "John123";
        //    temp2[1] = "pass123";
        //    temp2[2] = "English (Indian)";
        //    temp2[3] = "Invalid username or password";


        //    object[] main = new object[2];
        //    main[0] = temp1;
        //    main[1] = temp2;

        //    return main;
        //}

        public static object[] ValidData()
        {
            //number of test case = how many temp object required and size of main object[]
            //number of parameter = size of temp object

            object[] temp1 = new object[2];
            temp1[0] = "admin";
            temp1[1] = "pass";

            object[] temp2 = new object[2];
            temp2[0] = "physician";
            temp2[1] = "physician123";

            object[] temp3 = new object[2];
            temp3[0] = "mark";
            temp3[1] = "mark123";

            object[] temp4 = new object[2];
            temp4[0] = "king";
            temp4[1] = "king123";

            object[] main = new object[4];
            main[0] = temp1;
            main[1] = temp2;
            main[2] = temp3;
            main[3] = temp4;

            return main;
        }

    }
}
