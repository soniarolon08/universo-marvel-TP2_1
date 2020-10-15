using System;

namespace TP2_1
{
    class Item
    {

        #region Atributos

            private string Tipo;

        #endregion

        #region Constructor

            public Item(){
                this.Tipo = "";
                
            }
            public Item(string tipo){
                this.Tipo = tipo;
                
            }

        #endregion 

        #region Getters y Setters

            //Set
            public void SetTipo(string tipo){
                this.Tipo = "";
            }

            //Get
            public string GetTipo(){
                return this.Tipo;
            }

        #endregion

        #region Metodos

            public string SortearTipoItem(){
                return this.Tipo; 
            }

        #endregion

    }
}
