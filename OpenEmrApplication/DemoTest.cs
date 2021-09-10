using MetLife.OpenEmrApplication.Utilities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;

namespace MetLife.OpenEmrApplication
{
    class DemoTest
    {

        [Test]
        public void JsonRead()
        {
            StreamReader reader = new StreamReader(@"D:\B-Mine\Company\Company\MetLife\OpenEmrApplication\OpenEmrApplication\TestData\data.json");
            string strData= reader.ReadToEnd();
            //Console.WriteLine(strData);

            dynamic json= JsonConvert.DeserializeObject(strData);

            Console.WriteLine(json["browser"]);
        }


        [Test]
        public void JsonRead1()
        {
            var reader = new StreamReader(@"D:\B-Mine\Company\Company\MetLife\OpenEmrApplication\OpenEmrApplication\TestData\data.json");
            var strData = reader.ReadToEnd();
            //Console.WriteLine(strData);

            dynamic json = JsonConvert.DeserializeObject(strData);

            Console.WriteLine(json["browser"]);
        }


        //admin123 ,pass ,Dutch ,Invalid username or password
        //John123,pass,English (Indian),Invalid username or password



        //admin,pass
        //physician,physician123
        //mark,mark123
        //king,king123



        [Test,TestCaseSource(typeof(TestCaseSourceUtils), "ValidData")]
        public void ValidTest(string username,string password)
        {
            Console.WriteLine(username + password);
        }












        [Test]
        [TestCase("john","john123")]
        [TestCase("mark", "john123")]
        public void SampleTest(string username,string password)
        {
            Console.WriteLine(username+password);
        }

    }
}
