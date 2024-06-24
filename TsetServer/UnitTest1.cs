using Moq;
using NUnit.Framework;
using Server.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace TsetServer
{
    [TestFixture]
    public class ServerTests
    {
        private Mock<ServerFirewalDBEntities1> _dbMock;
        private Server.Server _server;
        private Mock<Form> _formMock;
        private RichTextBox _richTextBox;
        private Label _labelInternetStatus;
        private TextBox _usernameTextBox;
        private Button _button5;

        [SetUp]
        public void Setup()
        {
            _dbMock = new Mock<ServerFirewalDBEntities1>();
            _formMock = new Mock<Form>();
            _richTextBox = new RichTextBox();
            _labelInternetStatus = new Label();
            _usernameTextBox = new TextBox();
            _usernameTextBox.Text = "User";
            _button5 = new Button();
            _server = new Server.Server(_dbMock.Object, _formMock.Object, _richTextBox, _labelInternetStatus, _usernameTextBox, _button5);
        }

        [Test]
        public void Button5Click_UpdatesInternetStatusLabel()
        {
   
            var sitesList = new List<Sites>
{
    new Sites { Name = "TestSite", ListSites = "www.testsite.com" }
};

            var sitesDbSet = new Mock<DbSet<Sites>>();
            sitesDbSet.As<IQueryable<Sites>>().Setup(m => m.Provider).Returns(sitesList.AsQueryable().Provider);
            sitesDbSet.As<IQueryable<Sites>>().Setup(m => m.Expression).Returns(sitesList.AsQueryable().Expression);
            sitesDbSet.As<IQueryable<Sites>>().Setup(m => m.ElementType).Returns(sitesList.AsQueryable().ElementType);
            sitesDbSet.As<IQueryable<Sites>>().Setup(m => m.GetEnumerator()).Returns(sitesList.GetEnumerator());

            _dbMock.Setup(db => db.Sites).Returns(sitesDbSet.Object);
            _server.richTextBox1.Text = "www.testsite.com";
        
            // Act
            _button5.PerformClick();

            // Assert
            Assert.AreEqual("Запретить доступ в интернет, кроме сайтов:www.testsite.com", _server.labelIntenetStatus.Text);
        }

        [Test]
        public void TextBoxUserNameIsCorrect()
        {

            var button = _server.usernameTextBox;
            Assert.IsNotNull(button, "TextBox корректен");
        }

        [Test]
        public void RichTextBoxIsCorrect()
        {

            var button = _server.usernameTextBox;
            Assert.IsNotNull(button, "RichTextBox корректен");
        }

    }
}