using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reciclaje.Logica;

namespace TesteoReciclaje
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDuracionMinutosTotal()
        {
            var rutina = new Rutinas();
            var actual1 = rutina.duracionMinutosTotal("1 hour 2 mins");
            var actual2 = rutina.duracionMinutosTotal("2 hours");
            var actual3 = rutina.duracionMinutosTotal("5 mins");
            Assert.AreEqual(62, actual1);
            Assert.AreEqual(120,actual2);
            Assert.AreEqual(5, actual3);
        }
        [TestMethod]
        public void TestEsNumero() 
        {
            var rutina = new Rutinas();
            var actual1 = rutina.esNumero("01");
            var actual2 = rutina.esNumero("a");
            Assert.AreEqual(true,actual1);
            Assert.AreEqual(false, actual2);
        }
        [TestMethod]
        public void TestEsDecimal()
        {
            var rutina = new Rutinas();
            var actual1 = rutina.esDecimal("01");
            var actual2 = rutina.esDecimal("0.1");
            var actual3 = rutina.esDecimal("a");
            var actual4 = rutina.esDecimal("12.2.5");
            Assert.AreEqual(true, actual1);
            Assert.AreEqual(true, actual2);
            Assert.AreEqual(false, actual3);
            Assert.AreEqual(false, actual4);
        }
        [TestMethod]
        public void TestEsPatente()
        {
            var rutina = new Rutinas();
            var actual1 = rutina.esPatente("aaaa11");
            var actual2 = rutina.esPatente("aab111");
            var actual3 = rutina.esPatente("aa1111");
            var actual4 = rutina.esPatente("aabb111");
            var actual5 = rutina.esPatente("a   11");
            var actual6 = rutina.esPatente("a,,a11");
            Assert.AreEqual(true, actual1);
            Assert.AreEqual(false, actual2);
            Assert.AreEqual(false, actual3);
            Assert.AreEqual(false, actual4);
            Assert.AreEqual(false, actual5);
            Assert.AreEqual(false, actual6);
        }
        [TestMethod]
        public void TestEsCorreo()
        {
            var rutina = new Rutinas();
            var actual1 = rutina.esCorreo("aa@gg.com");
            var actual2 = rutina.esCorreo("aagg.com");
            var actual3 = rutina.esCorreo("@gg.com");
            var actual4 = rutina.esCorreo("aa@ggcom");
            var actual5 = rutina.esCorreo("aa@ggcom.");
            Assert.AreEqual(true, actual1);
            Assert.AreEqual(false, actual2);
            Assert.AreEqual(false, actual3);
            Assert.AreEqual(false, actual4);
            Assert.AreEqual(false, actual5);
        }
        [TestMethod]
        public void TestEsRut()
        {
            var rutina = new Rutinas();
            var actual1 = rutina.esRut("11111111-1");
            var actual2 = rutina.esRut("11.111.111-0");
            var actual3 = rutina.esRut("11111111-0");
            var actual4 = rutina.esRut("aaaaaaa-a");
            var actual5 = rutina.esRut("11.111.111-1");
            Assert.AreEqual(true, actual1);
            Assert.AreEqual(false, actual2);
            Assert.AreEqual(false, actual3);
            Assert.AreEqual(false, actual4);
            Assert.AreEqual(false, actual5);
        }

    }
}
