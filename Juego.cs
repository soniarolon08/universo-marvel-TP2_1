using System;

namespace TP2_1
{
    class Juego
    {
        #region Atributos

            private bool Resultado;
            private Combate Combates;
            private int Nivel;

        #endregion

        #region Constructores

            public Juego(){
                this.Resultado = false;
                this.Combates = new Combate();
                this.Nivel = 1;
            }
        

            public Juego(bool resultado, Combate combates, int nivel){
                this.Resultado = resultado;
                this.Combates = combates;
                this.Nivel = nivel;
            }

        #endregion

        #region Getters y Setters

            //Set

            public void SetResultado(bool resultado){
                this.Resultado = resultado;
            }
            public void SetNivel(int nivel){
                this.Nivel = nivel;
            }
            public void SetCombates(Combate combates){
                this.Combates = combates;
            }

            //Get

            public Combate GetCombates(){
                return this.Combates;
            }
            public bool GetResultado(){
                return this.Resultado;
            }
            public int GetNivel(){
                return this.Nivel;
            }
            
        #endregion
        
        #region Metodos

            public void Comenzar(){
            }
            public void Terminar(){          
            }

        #endregion

    }
}