#pragma warning disable
using Games_In_One;
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
            // Starts out on the main screen, and goes to add game pop-up.
            // Testing the existence of the add game screen, and that the game name text box has defualt value.
            MainScreen main = new MainScreen();
            AddGameScreen addGameScreen = new AddGameScreen(main);
            TextBox gameNameTextBox = addGameScreen.GetType().GetField("GameNameTextBox", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(addGameScreen) as TextBox;
            Button clearAddGameButton = addGameScreen.GetType().GetField("ClearAddGameButton", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(addGameScreen) as Button;
            Assert.AreEqual("Name", gameNameTextBox.Text);

            // Testing that the default text goes away if the user clicks on the text box.
            MethodInfo enterMethod = typeof(AddGameScreen).GetMethod("GameNameTextBox_Enter", BindingFlags.Instance | BindingFlags.NonPublic);
            enterMethod.Invoke(addGameScreen, new object[] { clearAddGameButton, EventArgs.Empty });
            Assert.AreEqual("", gameNameTextBox.Text);

            // Testing that default text is restored if the user clicks away from the text box.
            MethodInfo exitMethod = typeof(AddGameScreen).GetMethod("GameNameTextBox_Exit", BindingFlags.Instance | BindingFlags.NonPublic);
            exitMethod.Invoke(addGameScreen, new object[] { clearAddGameButton, EventArgs.Empty });
            Assert.AreEqual("Name", gameNameTextBox.Text);

            // Testing the 'clear' button functionality on the name text box.
            gameNameTextBox.Text = "Chrome";
            clearAddGameButton.PerformClick();
            Assert.AreEqual("Name", gameNameTextBox.Text);

        }

        [TestMethod]
        public void TestClearAddGameButton()
        {
            // Tests the clear button on all of the text boxes in the 'add game' pop-up.
            // Initializations.
            MainScreen main = new MainScreen();
            AddGameScreen addGameScreen = new AddGameScreen(main);
            TextBox gameNameTextBox = addGameScreen.GetType().GetField("GameNameTextBox", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(addGameScreen) as TextBox;
            MaskedTextBox gamePathTextBox = addGameScreen.GetType().GetField("GamePathTextBox", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(addGameScreen) as MaskedTextBox;
            MaskedTextBox gameimagePathTextBox = addGameScreen.GetType().GetField("GameImagePathTextBox", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(addGameScreen) as MaskedTextBox;
            Button clearAddGameButton = addGameScreen.GetType().GetField("ClearAddGameButton", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(addGameScreen) as Button;
            
            // Testing the defualt texts.
            Assert.AreEqual("Name", gameNameTextBox.Text);
            Assert.AreEqual("Game Path", gamePathTextBox.Text);
            Assert.AreEqual("Image Path", gameimagePathTextBox.Text);
            
            // Adding text to the text boxes.
            gameNameTextBox.Text = "Chrome";
            gamePathTextBox.Text = "game.exe";
            gameimagePathTextBox.Text = "iamge.png";
            
            // Testing whether the defualt text is retored for all if the 'clear' button is clicked by user.
            clearAddGameButton.PerformClick();
            Assert.AreEqual("Name", gameNameTextBox.Text);
            Assert.AreEqual("Game Path", gamePathTextBox.Text);
            Assert.AreEqual("Image Path", gameimagePathTextBox.Text);
        }
    }
}
