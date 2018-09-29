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
    public partial class ShowAllForm : Form
    {
        public ShowAllForm()
        {
            InitializeComponent();

            using ( BankDBContext bankDBContext = new BankDBContext())
            {
                var a = bankDBContext.Users.ToList();
                var b = a.Select(x => new
                {
                    Name = x.Name,
                    Surname = x.Surname,
                    PassportNumber = x.PasportNumber,
                    Amount = bankDBContext.CreditInfos.Where(c => x.Id == c.UserId).Sum(g =>  g.Amount),
                    Data = bankDBContext.CreditInfos.Where(c => x.Id == c.UserId).Select(g=>g.DateCredit).FirstOrDefault()
                });
                dgvAll.DataSource = b.ToList();
            }
        }
    }
}
