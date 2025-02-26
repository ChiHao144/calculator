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
        public void Test_Cong_52_Hao() //TC1_Cong_52_Hao
        {
            int expected_52_Hao, actual_52_Hao; //Ket qua mong doi, ket qua thuc te
            expected_52_Hao = 6; //ket qua mong doi 
            actual_52_Hao = c_52_Hao.Execute_52_Hao("+"); //ket qua thuc te
            Assert.AreEqual(expected_52_Hao, actual_52_Hao); //kiem tra ket qua pass/fail
        }

        [TestMethod]
        public void Test_Tru_52_Hao()//TC2_Tru_52_Hao
        {
            int expected_52_Hao, actual_52_Hao;
            expected_52_Hao = 2; //ket qua mong doi
            actual_52_Hao = c_52_Hao.Execute_52_Hao("-"); //ket qua thuc te
            Assert.AreEqual(expected_52_Hao, actual_52_Hao); // ket qua pass/fail
        }

        [TestMethod]
        public void Test_Nhan_52_Hao() //TC3_Nhan_52_Hao
        {
            int expected_52_Hao, actual_52_Hao;
            expected_52_Hao = 8; // ket qua mong doi
            actual_52_Hao = c_52_Hao.Execute_52_Hao("*"); //ket qua thuc te
            Assert.AreEqual(expected_52_Hao, actual_52_Hao); // ket qua pass/fail
        }

        [TestMethod]
        public void Test_Chia_52_Hao()//TC4_Chia_52_Hao
        {
            int expected_52_Hao, actual_52_Hao;
            expected_52_Hao = 2; //ket qua mong doi
            actual_52_Hao = c_52_Hao.Execute_52_Hao("/"); //ket qua thuc te
            Assert.AreEqual(expected_52_Hao, actual_52_Hao); // ket qua pass/fail
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]  //TC_ChiaZero_52_Hao
        public void Test_ChiaChoKhong()//TC5_Chia0_52_Hao
        {
            c_52_Hao = new TinhPhepToan_52_Hao(4, 0);//khoi tao gia tri cho testcase
            c_52_Hao.Execute_52_Hao("/"); //Excute chia
        }

        [TestMethod]
        public void Test_Fail_Cong_52_Hao()
        {
            int expected_52_Hao, actual_52_Hao;
            expected_52_Hao = 7; //ket qua mong doi
            actual_52_Hao = c_52_Hao.Execute_52_Hao("+"); //ket qua thuc te
            Assert.AreEqual(expected_52_Hao, actual_52_Hao); // ket qua pass/fail
        }

        [TestMethod]
        public void Test_Fail_Tru_52_Hao()
        {
            int expected_52_Hao, actual_52_Hao;
            expected_52_Hao = 1; //ket qua mong doi
            actual_52_Hao = c_52_Hao.Execute_52_Hao("-"); //ket qua thuc te
            Assert.AreEqual(expected_52_Hao, actual_52_Hao); // ket qua pass/fail
        }

        [TestMethod]
        public void Test_Fail_Nhan_52_Hao()
        {
            int expected_52_Hao, actual_52_Hao;
            expected_52_Hao = 9; //ket qua mong doi
            actual_52_Hao = c_52_Hao.Execute_52_Hao("*"); //ket qua thuc te
            Assert.AreEqual(expected_52_Hao, actual_52_Hao); // ket qua pass/fail
        }

        [TestMethod]
        public void Test_Fail_Chia_52_Hao()
        {
            int expected_52_Hao, actual_52_Hao;
            expected_52_Hao = 3; //ket qua mong doi
            actual_52_Hao = c_52_Hao.Execute_52_Hao("/"); //ket qua thuc te
            Assert.AreEqual(expected_52_Hao, actual_52_Hao); // ket qua pass/fail
        }
    }
}
