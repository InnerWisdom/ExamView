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
using Unity;

namespace ExamView
{
    public partial class FormAddPass : Form 
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        public int Id { set { id = value; } }
        private int? id;
        private readonly IPassLogic Pass;
        private readonly IReisLogic Reis;
        public FormAddPass(IPassLogic Pass, IReisLogic Reis)
        {
            InitializeComponent();
            this.Pass = Pass;
            this.Reis = Reis;
        }

        private void FormAddPass_Load(object sender, EventArgs e)
        {
            var list = Reis.Read(null);
            if (list != null)
            {
                comboBox1.DataSource = list;
                comboBox1.DisplayMember = "Id";
                comboBox1.ValueMember = "Id";
            }
            if (id.HasValue)
            {
                try
                {
                    var view = Pass.Read(new PassBindingModel { Id = id })?[0];
                    if (view != null)
                    {
                        textBoxName.Text = view.name;
                        textBoxGraz.Text = view.grazdanstvo;
                        comboBox1.SelectedIndex = comboBox1.FindString(view.reisId.ToString());
                        textBoxNumPlace.Text = view.numPlace.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
        }

        private void buttonSave_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                MessageBox.Show("Заполните название", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            try
            {
                Pass.CreateOrUpdate(new PassBindingModel
                {
                    Id = id,
                    name = textBoxName.Text,
                    ReisId = Int32.Parse(comboBox1.Text),
                    date = DateTime.Now,
                    numberPlace = Int32.Parse(textBoxNumPlace.Text),
                    grazdanstvo = textBoxGraz.Text
                });
                MessageBox.Show("Сохранение прошло успешно", "Сообщение",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
