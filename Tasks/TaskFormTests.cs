//using NUnit.Framework;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net.NetworkInformation;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using Tasks;

//namespace Tasks.Tests
//{
//    [TestFixture]
//    public class Form4Tests
//    {
//        private Form4 form4; 

//        [SetUp]
//        public void Setup()
//        {
            
//            form4 = new Form4();
//            form4.Show();
//        }

//        [TearDown]
//        public void Cleanup()
//        {

//            form4.Close();
//            form4.Dispose();
//        }

//        [Test]
//        public void TestAddTask()
//        {
//            // Arrange
//            string taskName = "Тестовая задача";
//            string taskDescription = "Это тестовая задача для проверки добавления.";

//            // Act
//            form4.textBox1.Text = taskName; 
//            form4.textBox3.Text = taskDescription; 
//            form4.Button4.PerformClick(); 

//            // Assert
//            bool isDisplayed = form4.IsTaskDisplayed(taskName); 
//            Assert.IsTrue(isDisplayed, "Задача не отображается после добавления.");
//        }
//    }
//}
