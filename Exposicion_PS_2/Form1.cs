using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exposicion_PS_2
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
        //Sección de código para cuando se presione llamar en nuestro fórmulario principal
        //Mostramos dos casos distintos:
        private void button1_Click(object sender, EventArgs e)
        {
            //Procedemos en primera instancia a comprobar que sucede cuando no aplicamos singleton.

            //FormPrueba form = new FormPrueba(); //Llamada al constructor para crear un nuevo atributo
                                                //el cual sera nuestro formulario
            //form.Show();

            //Se comprueba que al hacer click en llamar, genera multiples ventanas del formulario.

            //Ahora haremos uso del singleton.

            FormPrueba.LlamarFormulario.Show();

            //Comprobamos que al llamar a nuestro segundo formulario, genera un primer formulario
            //y en las siguientes llamadas muestra ese mismo formulario, aplicando la lógica de uso
            //del patrón Singleton.
        }
    }
}
