using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructuraDeDatos
{
    public partial class FrmAcercaDe : Form
    {
        public FrmAcercaDe()
        {
            InitializeComponent();
        }

        private void FrmAcercaDe_Load(object sender, EventArgs e)
        {
        // Clase: Hoja donde se describe todo el comportamiento y caracteristicas que tiene un objeto que instaciamos.Describimos los campos(datos), propiedades(intermediarios) y metodos. (lo que hicimos en la clase nodo)

        // Estructura de datos:

        // Datos Estáticos:tienen un tamaño predeterminado
        // Datos Dinámicos: crecen en funcion de lo que vaya haciendo el programa. No se declara con ningun tamaño porque va tomando espacios de memoria cada vez que instanciamos un nuevo elemento.Se va agrandando o achicando debido a la necesidad.Estos son: COLA PILA LISTA, Los cuales son estructuras de datos dinamicos lineales.

        // cola: Se agrega un nodo desp del ultimo.
        // pila: Se agrega un nodo desp del primero.
        // lista: se va el que queremos, dependiendo de los parametros que necesitemos.
        // Lista de datos ordenados, donde cada elemento señala al que le sigue.
        // cola y pila se ordenan en base a los datos que llegan.

        // Agregar
        // Eliminar
        // Recorrer
        // Sobrecarga es el mismo metodo programado varias veces, con el mismo nombre.

        // Encapsulación: el codigo esta protegido dentro de la clase. El que usa el objeto solamente llama a los metodos con el nombre que tiene pero no necesita conocer la complejidad de esa programación.

        }
    }
}
