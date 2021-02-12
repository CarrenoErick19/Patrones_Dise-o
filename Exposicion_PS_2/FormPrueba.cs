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
    public partial class FormPrueba : Form //Enlazamos el formulario de datos con el principal
    {
        public static FormPrueba formulario = null; //Inicializamos la instancia del Singleton, en este
                                                    //caso usaremos un atributo llamado formulario para
                                                    //generarlo por primera vez.
        private FormPrueba()
        {
            InitializeComponent();  //Constructor del formulario de datos.
        }
        public static FormPrueba LlamarFormulario //Método que determina si contamos con un fórmulario                                                  
        {                                         //generado anteriormente.
            get
            {
                if (formulario == null) //Si formulario contiene un valor nulo, entramos al bloque if
                {
                    formulario = new FormPrueba(); //Lllamamos al constructor FormPrueba para generar
                                                   //nuestro formulario de datos
                }
                return formulario;                 //Entonces retornamos nuestro formulario de datos

            }
        }
        private void FormPrueba_Load(object sender, EventArgs e)
        {

        }
        
    }
}
