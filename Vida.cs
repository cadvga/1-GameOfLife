using System;
using System.Collections.Generic;
using System.Text;

namespace Life
{
    internal class Vida
    {
        #region Atributos
        private bool[,] _Tablero;
        private int _MaxTamX;
        private int _MaxTamY;
        private int _Turno;
        bool _MundoRedondo;
        #endregion

        #region Propiedades
        internal bool[,] Tablero
        {
            get
            {
                return this._Tablero;
            }
            set
            {
                this._Tablero = value;
            }
        }
        internal int Turno 
        {
            get
            {
                return this._Turno;
            }
            set
            {
                this._Turno = value;
            }
        }
        #endregion

        #region Constructor
        internal Vida(int pTamX,int pTamY,bool pMundoRedondo) 
        {
            //Inicializo el tablero
            _MaxTamX = pTamX;
            _MaxTamY = pTamY;
            _MundoRedondo = pMundoRedondo;
            _Turno = 0;
            _Tablero = new bool[_MaxTamX,_MaxTamY];


            //Inicializo a celdas vacias el tablero
            // NO HACE FALTA PORQUE SE INICIALIZAN A FALSE AUTOMATICAMENTE

        }
        #endregion

        #region Metodos
        internal void Activa(int pX, int pY) 
        {
        //Recibe 2 coordenadas y activa o desactiva esa casilla
        Tablero[pX, pY] = ! Tablero[pX, pY];
        }
        private bool EsVecino(int X, int Y)
        {
            //Funcion auxiliar para comprobar si es vecino o no una casilla de otra
            //La dificultad viene en los bordes
            
            if (_MundoRedondo) //Mundo redondo.
            {
                //Compruebo que la X esté entre 0 y _MaxTamX
                //Si se pasa de un borde le pongo el valor correcto
                if (X < 0) { X = _MaxTamX-1; }
                if (X >= _MaxTamX) { X = 0; }
                //Lo mismo con Y
                if (Y < 0) { Y = _MaxTamY-1; }
                if (Y >= _MaxTamY) { Y = 0; }
                //Cuando llega aqui X,Y tiene valores correctos
                return Tablero[X, Y];
            }
            else //Mundo limitado
            {
                if (X >= 0 && X < _MaxTamX)
                {
                    if (Y >= 0 && Y < _MaxTamY) 
                    {
                        return Tablero[X, Y];
                    }
                }
                return false;
            }
        }
        internal void GenerarTurnoJuegoVida() 
        {
        //Coge su atributo _Tablero y le hace una pasada con las reglas del juego de la vida
            int NumeroVecinos;

            _Turno++;
            bool[,] AUXTablero = new  bool[_MaxTamX, _MaxTamY];

            for (int X = 0; X < _MaxTamX; X++)
            {
                for (int Y = 0; Y < _MaxTamY; Y++)
                {
                    NumeroVecinos = 0;
                    //Calculo el numero de vecinos
                    NumeroVecinos += EsVecino(X - 1, Y - 1) ? 1 : 0;
                    NumeroVecinos += EsVecino(X, Y - 1) ? 1 : 0;
                    NumeroVecinos += EsVecino(X + 1, Y - 1) ? 1 : 0;
                    NumeroVecinos += EsVecino(X - 1, Y) ? 1 : 0;
                    NumeroVecinos += EsVecino(X + 1, Y) ? 1 : 0;
                    NumeroVecinos += EsVecino(X - 1, Y + 1) ? 1 : 0;
                    NumeroVecinos += EsVecino(X, Y + 1) ? 1 : 0;
                    NumeroVecinos += EsVecino(X + 1, Y + 1) ? 1 : 0;
                    //Segun este viva o muerta la celula cambia la condicion de vida
                    if (Tablero[X,Y])
                    {
                        //Celula Viva
                        //Una célula viva con 2 o 3 células vecinas vivas sigue viva, en otro caso muere o permanece muerta(por "soledad" o "superpoblación")
                        //AUXTablero[X, Y] = Tablero[X, Y];
                        if (NumeroVecinos == 2 || NumeroVecinos==3)
                        {
                            AUXTablero[X,Y]= true;
                        }
                        else
                        {
                            AUXTablero[X, Y] = false;
                        }
                    }
                    else
                    {
                        //Celula Muerta
                        //Una célula muerta con exactamente 3 células vecinas vivas "nace" (al turno siguiente estará viva).
                        //AUXTablero[X, Y] = Tablero[X, Y];
                        if (NumeroVecinos == 3)
                        {
                            AUXTablero[X, Y] = true;
                        }
                        else
                        {
                            AUXTablero[X, Y] = false;
                        }
                    }

                }
            }
            //Acabo de dar vueltas y en AUXTablero está el nuevo estado
            Tablero = AUXTablero;

        }

        #endregion
    }
}
