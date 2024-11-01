using Data;
using Modelos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentacion
{
    public partial class FormVenta : Form
    {

        List<Venta> listVenta = new List<Venta>();

        public FormVenta()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            DVenta.Insert();
            listVenta = BVenta.Get();
            bindingSource1.DataSource = list;



            DateTime fecha = dateTimePicker1.Value;

            int idMateria = (int)comboBox1.SelectedValue;
            int idAlumno = (int)comboBox2.SelectedValue;
            int turno = (int)comboBox3.SelectedValue;

            NInscripcion.Insert(idMateria, idAlumno, turno, fecha);
            lista = NInscripcion.Get();
            bindingSource1.DataSource = lista;
            label4.Text = $"Inscripcion lista";



        }
    }
}
