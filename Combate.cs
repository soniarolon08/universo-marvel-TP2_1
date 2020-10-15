using System;

namespace TP2_1
{
    class Combate : Personaje
    {
        #region Atributos

            private Superheroe Superheroe;
            private Villano Villano;
            private int CantidadUsosSuperpoder;
            private Personaje Ganador;

        #endregion

        #region Constructores

            public Combate(){
                this.Superheroe = new Superheroe("Superheroe", 20, "", 10);
                this.Villano = new Villano("Villano", 15, "", 29);
                this.CantidadUsosSuperpoder = 1;
            }

        #endregion

        #region Constructores

            public Combate(Superheroe superheroe, Villano villano, int cantidadusossuperpoder){
                
                this.Superheroe = superheroe;
                this.Villano = villano;
                this.CantidadUsosSuperpoder = cantidadusossuperpoder;

                
            }

        #endregion

        #region Getters y Setters

            //Set
            public void SetSuperheroe(Superheroe Superheroe){
                this.Superheroe = Superheroe;
            }
            public void SetVillano(Villano Villano){
                this.Villano = Villano;
            }
            public void SetCantidadUsosSuperpoder(int cantidadusossuperpoder){
                this.CantidadUsosSuperpoder = cantidadusossuperpoder;
            }


            //Get
            public Villano GetVillano(){
                return this.Villano;
            }
            public Superheroe GetSuperheroe(){
                return this.Superheroe;
            }

            public int GetCantidadUsosSuperpoder(){
                return this.CantidadUsosSuperpoder;
            }

        #endregion  

        #region Metodos

            public void Comenzar(){
                Console.WriteLine("El combate comenzo.");
            }
            public void Terminar(){
                Console.WriteLine("El combate finalizo.");
            }
            public void Turno(Personaje personaje){    
            }

        #endregion

    }
}