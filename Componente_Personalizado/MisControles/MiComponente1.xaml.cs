using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Componente_Personalizado.MisControles
{
    public partial class MiComponente1 : UserControl
    {
        //tipo validacion podra valer dni, cp...
        public String tipoValidacion { get; set; }

        public String contenidoBoton { get; set; }

        public MiComponente1()
        {
            InitializeComponent(); 

            this.DataContext = this;
            


        }

        private void PerderFoco(object sender, RoutedEventArgs e)
        {   
            switch(tipoValidacion)
            {
                case "cp":

                    if (cajaTexto.Text == "")
                    {
                        mensaje.Content = "esta vacio";

                        //cajaTexto.BorderBrush = "#FFABADB3";  REVISAR COMO PONER BORDES DE COLOR
                    }
                    else if(cajaTexto.Text.Length!=5)
                    {
                        mensaje.Content = "datos erroneos";
                    }
                    else
                    {
                        mensaje.Content = "";
                    }

                break;

                case "numero":

                    if (cajaTexto.Text == "")
                    {
                        mensaje.Content = "no hay numero";
                    }
                    else
                    {
                        mensaje.Content = "numero incorrecto";
                    }

                break;
            }
        }
    }
}
