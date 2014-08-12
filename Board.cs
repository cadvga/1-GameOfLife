using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Life
{
    internal partial class frmBase : Form
    {
        #region Atributos
        private int _XBotones;
        private int _YBotones;
        private Vida _Vida;
        #endregion

        #region Propiedades
        private int XBotones
        {
            get
            {
                return this._XBotones;
            }
            set
            {
                this._XBotones = value;
            }
        }
        private int YBotones
        {
            get
            {
                return this._YBotones;
            }
            set
            {
                this._YBotones = value;
            }
        }
        #endregion

        #region Constructor
        internal frmBase()//(int pXBotones, int pYBotones)
        {
            InitializeComponent();
        }
        #endregion

        #region Metodos Privados
        private void CreaBotones() 
        {
            //Llamado por el evento Load del formulario
            //Se encarga de crear un tablero con botones manejados por 
            //un unico controlador de eventos.
            Button auxboton;
            int MaxBucleX, MaxBucleY;
            int TamX, TamY;
            int AnchuraControl, AlturaControl;
            System.Drawing.Size auxTam; // Tamaño del botón
            System.Drawing.Size auxTamControl; //Tamaño del control para un resize

            AnchuraControl = PanelTablero.Size.Width;
            AlturaControl = PanelTablero.Size.Height;


            MaxBucleX = _XBotones - 1;
            MaxBucleY = _YBotones - 1;
            TamX = AnchuraControl / _XBotones;
            TamY = AlturaControl / _YBotones;

            //Ajusto el tamaño para que no haya bordes...
            auxTamControl = new System.Drawing.Size(TamX * XBotones, TamY * YBotones);
            PanelTablero.Size = auxTamControl;


            for (int Y = 0; Y <= MaxBucleY; Y++)
            {
                for (int X = 0; X <= MaxBucleX; X++)
                {
                    auxTam = new System.Drawing.Size(TamX, TamY);
                    auxboton = new Button();
                    auxboton.Name = X.ToString() + "," + Y.ToString();
                    auxboton.Tag = X.ToString() + "," + Y.ToString();
                    //if (X==MaxBucleX) {auxboton.BackColor = System.Drawing.Color.Red;}
                    //else {auxboton.BackColor = System.Drawing.Color.Blue;}
                    auxboton.Size = auxTam;
                    auxboton.Location = new Point(X * TamX, Y * TamY);
                    auxboton.Click += new System.EventHandler(this.Tablero1_Click);
                    PanelTablero.Controls.Add(auxboton);
                }
            }
        }
        private void ExtraeCoordenadas(string CadenaCoordenadas, ref string X, ref string Y)
        {
            //Función auxiliar q recibe coordenadas del tipo 10,8 y devuelve X=10 Y=8
            string [] auxCadenaArray;
            auxCadenaArray = CadenaCoordenadas.Split(",".ToCharArray());
            X = auxCadenaArray[0].ToString();
            Y = auxCadenaArray[1].ToString();
        }
        private void ColoreaBoton(bool activado, Button auxBoton) 
        {
            // Se encarga de colorear un botón para indicar que está activado o no
            // Los colores podrían ser configurables?
            if (activado)
            {
                auxBoton.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                auxBoton.BackColor = System.Drawing.Color.Gray;
            }
        }
        private void Tablero_Rellena(Vida auxVida)
        {
            //Se le pasa una matriz auxVida
            //Y rellena el tablero de botones, colorando los activados.
            string auxX = "";
            string auxY = "";

            foreach (Button auxBoton in PanelTablero.Controls)
            {
                ExtraeCoordenadas(auxBoton.Name, ref auxX, ref auxY);
                ColoreaBoton(_Vida.Tablero[int.Parse(auxX), int.Parse(auxY)], auxBoton);
            }
        }
        #endregion

        #region Metodos manejadores de eventos
        private void frmBase_Load(object sender, EventArgs e)
        {
            //Es el evento Load del formulario
        }
        private void Tablero1_Click(object sender, EventArgs e)
        {
            // Es el manejador del evento CLICK de todos los botones
            Button auxBoton;
            string auxCadenaPosicion;
            string auxX = "";
            string auxY = "";

            auxBoton = (Button)sender;


            auxCadenaPosicion = auxBoton.Tag.ToString();
            ExtraeCoordenadas(auxCadenaPosicion, ref auxX, ref  auxY);
            //Cambio la matriz
            _Vida.Activa(int.Parse(auxX), int.Parse(auxY));
            //Relleno el tablero con la matriz _Vida
            Tablero_Rellena(_Vida);
        }
        private void Temporizador_Tick(object sender, EventArgs e)
        {
            //Cada cierto tiempo se calcula la matriz del juego de la vida
            //Llamando al metodo que lo hace de la clase Vida.
            _Vida.GenerarTurnoJuegoVida();
            Tablero_Rellena(_Vida);
            txtTurno.Text = _Vida.Turno.ToString();

        }
        private void cmdPaso_Click(object sender, EventArgs e)
        {
            _Vida.GenerarTurnoJuegoVida();
            Tablero_Rellena(_Vida);
        }
        private void cmdEmpezar_Click(object sender, EventArgs e)
        {
            if (Temporizador.Enabled)
            {
                cmdPaso.Enabled = true;
                cmdEmpezar.Text = "Empezar";
                Temporizador.Enabled = false;
            }
            else
            {
                cmdPaso.Enabled = false;
                cmdEmpezar.Text = "Parar";
                Temporizador.Interval = 1000;
                Temporizador.Enabled = true;
            }
        }
        private void cmdCrear_Click(object sender, EventArgs e)
        {
            try
            {
                // Hago que el panel ocupe lo mismo que el control
                // PanelTablero.Size = this.Size;
                XBotones = int.Parse(txtX.Text); //pXBotones;
                YBotones = int.Parse(txtY.Text); // pYBotones;
                // Creo la estructura de datos para almacenar el juego de la vida
                cmdCrear.Enabled = false;
                cmdEmpezar.Enabled = true;
                cmdPaso.Enabled = true;
                chkRedondo.Enabled = false;
                _Vida = new Vida(XBotones, YBotones,chkRedondo.Checked);
                CreaBotones();
                Tablero_Rellena(_Vida);
            }
            catch (Exception Ex)
            {

                MessageBox.Show("Error: " + Ex.Message);
            }
        }
        private void cmdURL_Click(object sender, EventArgs e)
        {
            //Ñapa para lanzar primero el firefox
            try
            {
                System.Diagnostics.Process.Start("firefox.exe", "http://es.wikipedia.org/wiki/Juego_de_la_vida");
            }
            catch (Exception)
            {
                System.Diagnostics.Process.Start("iexplore.exe", "http://es.wikipedia.org/wiki/Juego_de_la_vida");
            }
        }
        #endregion
    }
}