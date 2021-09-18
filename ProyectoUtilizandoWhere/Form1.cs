using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoUtilizandoWhere
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClic_Click(object sender, EventArgs e)
        {


            int[] numeros = { 0,1,2,3,4,5,6,7,8,9 }; // Se define la lista en la cual trabajaremos 

            // se hace el uso del operador where para hcer la consulta
            var consulta =
                from num in numeros
                where num < 5
                select num;

            // se ejecuta la consulta
            foreach ( var numeroinferior in consulta)
                lstData.Items.Add(numeroinferior);

        }

        private void btnclic2_Click(object sender, EventArgs e)
        {
            int[] numeros = { 0,1,2,3,4,5,6,7,8,9 };

            var consulta =
                from num in numeros
                where IsEven(num)
                select num;

            foreach (var entero in consulta)
            {
                lstDatos2.Items.Add(entero);
            }

        }
        static bool IsEven(int i )
        {
            return i % 2 == 0;
        }

        private void btnClic3_Click(object sender, EventArgs e)
        {
            int [] numeros = { 0,1,2,3,4,5,6,7,8,9,};


            foreach ( var numb in numeros)
            {
                lstLista.Items.Add(numb);
            }

        }

        private void lstData_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
