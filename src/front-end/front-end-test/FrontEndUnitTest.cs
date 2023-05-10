#pragma warning disable
using Games_In_One_App;
using Moq;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Windows.Forms;
namespace FrontEndTest
{
    [TestClass]
    public class FrontEndUnitTest
    {

        [TestMethod]
        public void TestAddGameTextBox()
        {
            MainScreen main = new MainScreen();
            AddGameScreen addGameScreen = new AddGameScreen(main.Refresh);
            TextBox gameNameTextBox = addGameScreen.GetType().GetField("GameNameTextBox", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(addGameScreen) as TextBox;
            Button clearAddGameButton = addGameScreen.GetType().GetField("ClearAddGameButton", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(addGameScreen) as Button;
            Assert.AreEqual("Name", gameNameTextBox.Text);

            MethodInfo enterMethod = typeof(AddGameScreen).GetMethod("GameNameTextBox_Enter", BindingFlags.Instance | BindingFlags.NonPublic);
            enterMethod.Invoke(addGameScreen, new object[] { clearAddGameButton, EventArgs.Empty });
            Assert.AreEqual("", gameNameTextBox.Text);

            MethodInfo exitMethod = typeof(AddGameScreen).GetMethod("GameNameTextBox_Exit", BindingFlags.Instance | BindingFlags.NonPublic);
            exitMethod.Invoke(addGameScreen, new object[] { clearAddGameButton, EventArgs.Empty });
            Assert.AreEqual("Name", gameNameTextBox.Text);

            gameNameTextBox.Text = "Chrome";
            clearAddGameButton.PerformClick();
            Assert.AreEqual("Name", gameNameTextBox.Text);

        }

        [TestMethod]
        public void TestClearAddGameButton()
        {
            MainScreen main = new MainScreen();
            AddGameScreen addGameScreen = new AddGameScreen(main.Refresh);
            TextBox gameNameTextBox = addGameScreen.GetType().GetField("GameNameTextBox", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(addGameScreen) as TextBox;
            MaskedTextBox gamePathTextBox = addGameScreen.GetType().GetField("GamePathTextBox", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(addGameScreen) as MaskedTextBox;
            MaskedTextBox gameimagePathTextBox = addGameScreen.GetType().GetField("GameImagePathTextBox", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(addGameScreen) as MaskedTextBox;
            Button clearAddGameButton = addGameScreen.GetType().GetField("ClearAddGameButton", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(addGameScreen) as Button;
            Assert.AreEqual("Name", gameNameTextBox.Text);
            Assert.AreEqual("Game Path", gamePathTextBox.Text);
            Assert.AreEqual("Image Path", gameimagePathTextBox.Text);
            gameNameTextBox.Text = "Chrome";
            gamePathTextBox.Text = "game.exe";
            gameimagePathTextBox.Text = "iamge.png";
            clearAddGameButton.PerformClick();
            Assert.AreEqual("Name", gameNameTextBox.Text);
            Assert.AreEqual("Game Path", gamePathTextBox.Text);
            Assert.AreEqual("Image Path", gameimagePathTextBox.Text);
        }
    }
}