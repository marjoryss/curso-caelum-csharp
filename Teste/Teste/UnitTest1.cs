using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Teste.Classes;

namespace Teste
{
    [TestClass]
    public class TesteConta
    {
        private Conta _conta;

        [TestInitialize]
        public void init()
        {
            _conta = new Conta();
        }

        [TestMethod]
        public void DeveDepositar100EConter100NoSaldo()
        {
            _conta.Deposita(100);
            Assert.AreEqual(100.00, _conta.Saldo);
        }
        [TestMethod]
        public void DeveSacar100EConter0NoSaldo()
        {
            Conta c = new Conta();
            c.Deposita(100);
            c.Saca(100);
            Assert.AreEqual(0, _conta.Saldo);
        }
    }

}












































































































































