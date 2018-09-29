using BankCodeFirst.Models;
using BankCodeFirst.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankCodeFirst.Forms
{
    public partial class CreditInfoForm : Form
    {
        public CreditInfoForm()
        {
            InitializeComponent();

            using (BankDBContext bankDBContext = new BankDBContext())
            {
                txbUserName.Text = bankDBContext.Users.Select(x => x.Name).ToList().LastOrDefault();
                txbUserName.ReadOnly = true;

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (BankDBContext bankDBContext = new BankDBContext())
            {
                bankDBContext.CreditInfos.Add(new CreditInfo() {
                    Amount = Convert.ToInt32(txbAmount.Text),
                    DateCredit = DateTime.Now,
                    UserId = bankDBContext.Users.ToList().LastOrDefault().Id
                });
                bankDBContext.SaveChanges();
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            ShowAllForm showAllForm = new ShowAllForm();
            showAllForm.ShowDialog();
        }
    }
}
