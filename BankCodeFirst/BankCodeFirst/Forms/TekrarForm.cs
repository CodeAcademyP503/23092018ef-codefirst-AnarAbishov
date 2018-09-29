using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankCodeFirst.Forms;
using BankCodeFirst.Models;

namespace BankCodeFirst.Forms
{
    public partial class TekrarForm : Form
    {
        public TekrarForm()
        {
            InitializeComponent();
        }

        private void Btn_Go_Click(object sender, EventArgs e)
        {
            using (BankDBContext bankDBContext = new BankDBContext())
            {

                var a = bankDBContext.Users.ToList();

                foreach (var item in a)
                {
                    if (TxbPassportNumber.Text == item.PasportNumber)
                    {
                        int.TryParse(TxbAmount.Text, out int amount);
                        if (amount != 0)
                        {
                            bankDBContext.CreditInfos.Add(new CreditInfo()
                            {
                                Amount = Convert.ToDouble(TxbAmount.Text),
                                DateCredit = dateTimePickerDateCredit.Value,
                                UserId = item.Id
                            });
                            bankDBContext.SaveChanges();
                        }
                      
                    }
                }
            }
        }
    }
}
