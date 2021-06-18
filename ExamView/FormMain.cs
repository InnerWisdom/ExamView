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

    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        [Dependency]
        public new IUnityContainer Container { get; set; }

        private void рейсыToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormReis>();
            form.ShowDialog();
        }

        private void пассажирыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var container = BuildUnityContainer();
            var form = container.Resolve<FormPass>();
            form.ShowDialog();

        }

        private static IUnityContainer BuildUnityContainer()
        {
            var currentContainer = new UnityContainer();
            currentContainer.RegisterType<IPassLogic, PassLogic>(new
           HierarchicalLifetimeManager());
            currentContainer.RegisterType<IReisLogic, ReisLogic>(new
           HierarchicalLifetimeManager());
            return currentContainer;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
