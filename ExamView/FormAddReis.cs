using BusinessLogic.BindingModels;
using BusinessLogic.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamView
{
    public partial class FormAddReis : Form
    {
        public FormAddReis(IReisLogic Reis)
        {
            this.Reis = Reis;
            InitializeComponent();
        }

        private readonly IReisLogic Reis;
        public int Id { set { id = value; } }

        private int? id;

        private void FormAddReis_Load(object sender, EventArgs e)
        {
            if (id.HasValue)
            {
                try
                {
                    var view = Reis.Read(new ReisBindingModel { Id = id })?[0];
                    if (view != null)
                    {
                        textBoxCompany.Text = view.company;
                        dateTimePicker1.Value = view.date;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCompany.Text))
            {
                MessageBox.Show("Заполните название", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
            try
            {
                Reis.CreateOrUpdate(new ReisBindingModel
                {
                    Id = id,
                    company = textBoxCompany.Text,
                    date = dateTimePicker1.Value
                });
                MessageBox.Show("Сохранение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
