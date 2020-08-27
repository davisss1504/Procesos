using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Informatica.Negocio.Test
{
    [TestClass]
    public class AlgoritmosOrdenacionTest
    {
        public static int[] valores = { 11, 55, 33, 77, 69 };
        public static int[] esperados = { 11, 33, 55, 69, 77};
        Ordenacion ordenacion = new Ordenacion();

        [TestMethod]
        public void ordenarBurbuja()
        {
            List<int> ordenados = ordenacion.Burbuja(valores);

            Assert.AreEqual(ordenados[0], esperados[0]);
            Assert.AreEqual(ordenados[1], esperados[1]);
            Assert.AreEqual(ordenados[2], esperados[2]);
            Assert.AreEqual(ordenados[3], esperados[3]);
            Assert.AreEqual(ordenados[4], esperados[4]);
        }

        [TestMethod]
        public void ordenarQuickSort()
        {
            int[] valores = { 17, 99, 266, 2, 78 };
            int[] esperados = { 2, 17, 78, 99, 266};

            List<int> ordenados = ordenacion.QuickSort(valores, 0, valores.Length - 1);

            Assert.AreEqual(ordenados[0], esperados[0]);
            Assert.AreEqual(ordenados[1], esperados[1]);
            Assert.AreEqual(ordenados[2], esperados[2]);
            Assert.AreEqual(ordenados[3], esperados[3]);
            Assert.AreEqual(ordenados[4], esperados[4]);
        }

        [TestMethod]
        public void ordenarShellShort()
        {
            List<int> ordenados = ordenacion.ShellShort(valores);

            Assert.AreEqual(ordenados[0], esperados[0]);
            Assert.AreEqual(ordenados[1], esperados[1]);
            Assert.AreEqual(ordenados[2], esperados[2]);
            Assert.AreEqual(ordenados[3], esperados[3]);
            Assert.AreEqual(ordenados[4], esperados[4]);
        }
    }
}
