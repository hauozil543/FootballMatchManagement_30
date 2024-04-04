using Microsoft.VisualStudio.TestTools.UnitTesting;
using FootballMatchManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Demo_GUI_Testing__with_FootballMatchManagement
{
    [TestClass()]
    public class GoalsTests
    {
        [TestMethod()]
        public void btnExit_ClickTest()
        {
            // Tạo một đối tượng form Goals
            Goals goalsForm = new Goals();

            // Gọi sự kiện Click của nút Exit
            goalsForm.btnExit_Click(null, null);
            DialogResult dr1 = goalsForm.DialogResult;
            if ( dr1 == DialogResult.Yes)
            {
                Assert.IsTrue(goalsForm.IsDisposed);

            }
            // Kiểm tra xem form Goals đã được đóng hay chưa
            else
            {

                Assert.IsFalse(goalsForm.IsDisposed);
            }
            Assert.IsTrue(goalsForm.IsDisposed);
        }
    }
}