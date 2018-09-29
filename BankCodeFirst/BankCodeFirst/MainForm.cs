using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankCodeFirst.Models;
using BankCodeFirst.Forms;

namespace BankCodeFirst
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            using (BankDBContext bankDBContext = new BankDBContext())
            {
                bankDBContext.Users.Add(new User() {
                    Name = txbName.Text,
                    Surname = txbSurname.Text,
                    PasportNumber = txbPassportNumber.Text
                });
                bankDBContext.SaveChanges();
            }

            CreditInfoForm creditInfoForm = new CreditInfoForm();
            creditInfoForm.ShowDialog();
        }

        private void Btn_tekrarCredit_Click(object sender, EventArgs e)
        {
            TekrarForm tekrarForm = new TekrarForm();
            tekrarForm.ShowDialog();
        }

        private void Btn_showAll_Click(object sender, EventArgs e)
        {
            ShowAllForm showAllForm = new ShowAllForm();
            showAllForm.ShowDialog();
        }
    }
}
