using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TinhToan_52_Hao;

namespace UnitTest_TinhToan_52_Hao
{
    [TestClass]
    public class UnitTest1_52_Hao
    {
        private TinhPhepToan_52_Hao c_52_Hao; //thiet lap du lieu dung chung cho TC
        [TestInitialize]
        public void TaoSo_52_Hao() // tao ham de tao du lieu cho cac TC
        {
            c_52_Hao = new TinhPhepToan_52_Hao(4, 2);
        }
        [TestMethod] //phai co testmethod moi chay duoc TC
        public void TC1_52_Hao_Test_Cong() //TC1_Cong_52_Hao
        {
            int expected_52_Hao, actual_52_Hao; //Ket qua mong doi, ket qua thuc te
            expected_52_Hao = 6; //ket qua mong doi 
            actual_52_Hao = c_52_Hao.Execute_52_Hao("+"); //ket qua thuc te
            Assert.AreEqual(expected_52_Hao, actual_52_Hao); //kiem tra ket qua pass/fail
        }

        [TestMethod]
        public void TC2_52_Hao_Test_Tru()//TC2_Tru_52_Hao
        {
            int expected_52_Hao, actual_52_Hao;
            expected_52_Hao = 2; //ket qua mong doi
            actual_52_Hao = c_52_Hao.Execute_52_Hao("-"); //ket qua thuc te
            Assert.AreEqual(expected_52_Hao, actual_52_Hao); // ket qua pass/fail
        }

        [TestMethod]
        public void TC3_52_Hao_Test_Nhan() //TC3_Nhan_52_Hao
        {
            int expected_52_Hao, actual_52_Hao;
            expected_52_Hao = 8; // ket qua mong doi
            actual_52_Hao = c_52_Hao.Execute_52_Hao("*"); //ket qua thuc te
            Assert.AreEqual(expected_52_Hao, actual_52_Hao); // ket qua pass/fail
        }

        [TestMethod]
        public void TC4_52_Hao_Test_Chia()//TC4_Chia_52_Hao
        {
            int expected_52_Hao, actual_52_Hao;
            expected_52_Hao = 2; //ket qua mong doi
            actual_52_Hao = c_52_Hao.Execute_52_Hao("/"); //ket qua thuc te
            Assert.AreEqual(expected_52_Hao, actual_52_Hao); // ket qua pass/fail
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]  //TC_ChiaZero_52_Hao
        public void TC5_52_Hao_Test_ChiaChoKhong()//TC5_Chia0_52_Hao
        {
            c_52_Hao = new TinhPhepToan_52_Hao(4, 0);//khoi tao gia tri cho testcase
            c_52_Hao.Execute_52_Hao("/"); //Excute chia
        }

        [TestMethod]
        public void TC6_52_Hao_Test_Fail_Cong()
        {
            int expected_52_Hao, actual_52_Hao;
            expected_52_Hao = 7; //ket qua mong doi
            actual_52_Hao = c_52_Hao.Execute_52_Hao("+"); //ket qua thuc te
            Assert.AreEqual(expected_52_Hao, actual_52_Hao); // ket qua pass/fail
        }

        [TestMethod]
        public void TC7_52_Hao_Test_Fail_Tru()
        {
            int expected_52_Hao, actual_52_Hao;
            expected_52_Hao = 1; //ket qua mong doi
            actual_52_Hao = c_52_Hao.Execute_52_Hao("-"); //ket qua thuc te
            Assert.AreEqual(expected_52_Hao, actual_52_Hao); // ket qua pass/fail
        }

        [TestMethod]
        public void TC8_52_Hao_Test_Fail_Nhan()
        {
            int expected_52_Hao, actual_52_Hao;
            expected_52_Hao = 9; //ket qua mong doi
            actual_52_Hao = c_52_Hao.Execute_52_Hao("*"); //ket qua thuc te
            Assert.AreEqual(expected_52_Hao, actual_52_Hao); // ket qua pass/fail
        }

        [TestMethod]
        public void TC9_52_Hao_Test_Fail_Chia()
        {
            int expected_52_Hao, actual_52_Hao;
            expected_52_Hao = 3; //ket qua mong doi
            actual_52_Hao = c_52_Hao.Execute_52_Hao("/"); //ket qua thuc te
            Assert.AreEqual(expected_52_Hao, actual_52_Hao); // ket qua pass/fail
        }






        public TestContext TestContext { get; set; } // Tao doi tuong TestContext

        //Viet testcase su dung bo du lieu file csv gom 3 cot va 3 testcase pass
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @".\Data_52_Hao\TestData_52_Hao_3Col.csv", "TestData_52_Hao_3Col#csv",
            DataAccessMethod.Sequential)]

        [TestMethod]
        public void TC10_52_Hao_3Pass_TestWithDataSource_3Col()
        {
            int a_52_Hao = int.Parse(TestContext.DataRow[0].ToString());  //Lay gia tri a
            int b_52_Hao = int.Parse(TestContext.DataRow[1].ToString()); //Lay gia tri b
            int expected_52_Hao = int.Parse(TestContext.DataRow[2].ToString()); //Lay gia tri ket qua 

            TinhPhepToan_52_Hao c_52_Hao = new TinhPhepToan_52_Hao(a_52_Hao, b_52_Hao);  //khai bao bien c_52_Hao
            int actual_52_Hao = c_52_Hao.Execute_52_Hao("+"); //Thuc hien phep tinh cong cua bo du lieu
            Assert.AreEqual(expected_52_Hao, actual_52_Hao); // So sanh ket qua tra ve pass
        }



        //Viet testcase su dung bo du lieu file csv gom 4 cot va 4 testcase pass
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @".\Data_52_Hao\TestData_52_Hao_4Col.csv", "TestData_52_Hao_4Col#csv",
            DataAccessMethod.Sequential)]

        [TestMethod]
        public void TC11_52_Hao_4Pass_TestWithDataSource_4Col()
        {
            int a_52_Hao = int.Parse(TestContext.DataRow[0].ToString()); //Lay gia tri a
            int b_52_Hao = int.Parse(TestContext.DataRow[1].ToString()); //Lay gia tri b
            string operation_52_Hao = TestContext.DataRow[2].ToString(); //Khai bao phep tinh operation
            operation_52_Hao = operation_52_Hao.Replace("'", ""); //Thuc hien bo qua ki tu ' va khoang trang o operation
            Console.WriteLine(operation_52_Hao); 
            int expected_52_Hao = int.Parse(TestContext.DataRow[3].ToString()); //Lay gia tri ket qua
            TinhPhepToan_52_Hao c_52_Hao = new TinhPhepToan_52_Hao(a_52_Hao, b_52_Hao); //Khai bao bien c_52_Hao
            int actual_52_Hao = c_52_Hao.Execute_52_Hao(operation_52_Hao); //Thuc hien cac phep tinh da co trong du lieu
            Assert.AreEqual(expected_52_Hao, actual_52_Hao); //So sanh ket qua tra ve pass 
        }
    }
}
