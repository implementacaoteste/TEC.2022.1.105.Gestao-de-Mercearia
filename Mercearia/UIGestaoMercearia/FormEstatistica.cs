using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using System.Runtime.InteropServices;
using Models;
using BLL;

namespace UIGestaoMercearia
{
    public partial class FormEstatistica : Form
    {
        Estatistica estatistica;
        //Venda venda;
        public FormEstatistica()
        {
            InitializeComponent();
        }

        private void FormEstatistica_Load(object sender, EventArgs e)
        {
            estatistica = new Estatistica();
            DateTime dataInicio = dateTimePickerInicio.Value = dateTimePickerInicio.Value.AddDays(-30);
            DateTime dataFim = dateTimePickerFim.Value;
            bindingSourceEstatistica.DataSource = new VendaBLL().BuscarReceita(dataInicio, dataFim);


            labelGanhos.Text = ((Estatistica)bindingSourceEstatistica.Current).Ganhos.ToString("C");
            labelGastos.Text = ((Estatistica)bindingSourceEstatistica.Current).Gastos.ToString("C");
            labelSaldo.Text = ((Estatistica)bindingSourceEstatistica.Current).Saldo.ToString("C");
            //   estatistica = new VendaBLL().BuscarReceita(dataInicio, dataFim);


            //((Estatistica)bindingSourceEstatistica.Current).Ganhos = );
            /*labelGanhos.Text = estatistica.Ganhos.ToString("C");
            labelGastos.Text = estatistica.Gastos.ToString("C");
            labelSaldo.Text = estatistica.Saldo.ToString("C");*/
        }

        private void FormEstatistica_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void dateTimePickerInicio_ValueChanged(object sender, EventArgs e)
        {
            DateTime dataInicio = dateTimePickerInicio.Value = dateTimePickerInicio.Value;
            DateTime dataFim = dateTimePickerFim.Value;
            bindingSourceEstatistica.DataSource = new VendaBLL().BuscarReceita(dataInicio, dataFim);

            labelGanhos.Text = ((Estatistica)bindingSourceEstatistica.Current).Ganhos.ToString("C");
            labelGastos.Text = ((Estatistica)bindingSourceEstatistica.Current).Gastos.ToString("C");
            labelSaldo.Text = ((Estatistica)bindingSourceEstatistica.Current).Saldo.ToString("C");
        }
    }
}
