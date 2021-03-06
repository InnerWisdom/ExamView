using BusinessLogic.BindingModels;
using BusinessLogic.Interface;
using DatabaseImplement.Implements;
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
using Unity.Lifetime;

namespace ExamView
{
    public partial class FormReis : Form
    {
        private readonly IReisLogic Reis;
        public FormReis(IReisLogic Reis)
        {
            this.Reis = Reis;
            InitializeComponent();
        }
        private void LoadData()
        {
            try
            {
                var list = Reis.Read(null);
                if (list != null)
                {
                    dataGridView1.DataSource = list;
                    //dataGridView1.Columns[0].Visible = false;
                    //dataGridView1.Columns[1].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormReis_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            var container = BuildUnityContainer();
            var form = container.Resolve<FormAddReis>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }
        private static IUnityContainer BuildUnityContainer()
        {
            var currentContainer = new UnityContainer();
            currentContainer.RegisterType<IReisLogic, ReisLogic>(new
           HierarchicalLifetimeManager());
            return currentContainer;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                    try
                    {
                        Reis.Delete(new ReisBindingModel { Id = id });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    LoadData();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void change_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                var container = BuildUnityContainer();
                var form = container.Resolve<FormAddReis>();
                form.Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }
    }
}
