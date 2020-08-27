using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Matematica.Test
{
    [TestClass]
    public class CalculadoraTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            "|DataDirectory|\\data.csv", "data#csv", DataAccessMethod.Sequential),
            DeploymentItem("data.csv")]

        public void SumaDeTresNumerosEnteros()
        {
            var numero1 = Int32.Parse(TestContext.DataRow["numero1"].ToString());
            var numero2 = Int32.Parse(TestContext.DataRow["numero2"].ToString());
            var numero3 = Int32.Parse(TestContext.DataRow["numero3"].ToString());
            var esperado = Int32.Parse(TestContext.DataRow["resultado"].ToString());

            var calcular = new Calculadora();
            var resultado = calcular.Sumar(numero1, numero2, numero3);

            Assert.AreEqual(esperado, resultado);
        }
    }
}
