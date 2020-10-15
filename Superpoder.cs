using System;

namespace TP2_1
{
    class Superpoder
    {
        #region Atributos

            private bool Tipo;
            private int CantidadUsos;

        #endregion

        #region Constructores

            public Superpoder(){
                this.Tipo = true;
                this.CantidadUsos = 1;
            }

            public Superpoder(bool verdadero, int cantidadusos){
                this.Tipo = verdadero;
                this.CantidadUsos = cantidadusos;
            }

        #endregion

        #region Getters y Setters

            //Set
            public void SetTipo(bool verdadero){
                this.Tipo = verdadero;
            }
            public void SetCantidadUsos(int cantidadusos){
                this.CantidadUsos = cantidadusos;
            }

            //Get
            public bool GetTipo(){
                return this.Tipo;
            }
            public int GetCantidadUsos(){
                return this.CantidadUsos;
            }

        #endregion

        #region Metodos
     
            public void Usar(Superheroe superheroe){

                int cantidadusos;
                cantidadusos = this.CantidadUsos - 1;
            }

        #endregion

    }
}

