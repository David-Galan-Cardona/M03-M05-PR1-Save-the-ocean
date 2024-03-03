using Save_the_ocean;
using System;

namespace TestProjectSaveTheOcean
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestValidate()
        {//Arrange
            int num = 5;
            //Act
            bool result = MainProgram.Validate(num);
            //Assert
            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void TestCalculateGA()
        { //Arrange
            Cetacean cetacean = new Cetacean("dolphin", "Delphinidae", "Delphinus delphis", 150);
          //Act
            int result = cetacean.CalculateGA(50, true);
          //Assert
            Assert.AreEqual(48, result);
        }
        [TestMethod]
        public void TestCalculateGA2()
        { //Arrange
            SeaBird seaBird = new SeaBird("seagull", "Laridae", "Larus", 5);
          //Act
            int result = seaBird.CalculateGA(50, false);
          //Assert
            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void TestCalculateGA3()
        { //Arrange
            SeaTurtle seaTurtle = new SeaTurtle("loggerhead", "Cheloniidae", "Caretta caretta", 100);
          //Act
            int result = seaTurtle.CalculateGA(50, true);
          //Assert
            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void TestShowRescue()
        { //Arrange
            StringWriter sw = new();
            Console.SetOut(sw);
            SeaTurtle seaTurtle = new SeaTurtle("loggerhead", "Cheloniidae", "Caretta caretta", 100);
            Rescue rescue = new Rescue(25, "12/12/2020", "Tortuga Marina", 80, "Barcelona", seaTurtle);
            //Act
            rescue.ShowRescue();
            string expected = "+-------------------------------------------------------------+\n|                       RESCAT                                |\n" +
            "+-------------------------------------------------------------+\n| # Rescat | Data rescat | Superfam�lia   | GA | Localitzaci� |\n+-------------------------------------------------------------+\n| RES 025   | 12/12/2020  | Tortuga Marina         | 80 | Barcelona     |\n+-------------------------------------------------------------+";
            //Assert
            Assert.AreEqual(expected, sw.ToString().Trim());
        }
        [TestMethod]
        public void TestShowAnimal()
        { //Arrange
            StringWriter sw = new();
            Console.SetOut(sw);
            SeaTurtle seaTurtle = new SeaTurtle("loggerhead", "Cheloniidae", "Caretta caretta", 100);
            Rescue rescue = new Rescue(25, "12/12/2020", "Tortuga Marina", 80, "Barcelona", seaTurtle);
          //Act
            rescue.ShowAnimal();
            string expected = "+-------------------------------------------------------------+\n|                       FITXA                                 |\n+-------------------------------------------------------------+\n| # Nom | Superfam�lia | Esp�cie        | Pes aproximat       |\n+-------------------------------------------------------------+\n| loggerhead | Cheloniidae       | Caretta caretta   | 100kg              |\n+-------------------------------------------------------------+";
          //Assert
            Assert.AreEqual(expected, sw.ToString().Trim());
        }
        [TestMethod]
        public void TestShowGa()
        { //Arrange
            StringWriter sw = new();
            Console.SetOut(sw);
            SeaTurtle seaTurtle = new SeaTurtle("loggerhead", "Cheloniidae", "Caretta caretta", 100);
            Rescue rescue = new Rescue(25, "12/12/2020", "Tortuga Marina", 80, "Barcelona", seaTurtle);
          //Act
            rescue.showGa(2);
            string expected = "La tortuga t� un grau d'afectaci� de 80%, qu� vols fer?:\n1.Curar aqu�\n2.Fer un trasllat al centre";
          //Assert
            Assert.AreEqual(expected, sw.ToString().Trim());
        }
    }
}