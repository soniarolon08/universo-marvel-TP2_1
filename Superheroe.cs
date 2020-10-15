using System;

namespace TP2_1
{
    class Superheroe : Personaje
    {
        #region Atributos

            private int CantidadVidas;
            private Superpoder Superpoder;

        #endregion

        #region Constructores
            
            //Herda de personaje 
            public Superheroe(string nombre, int aniocreacion, string universo, int stamina) : base(nombre, aniocreacion, universo, stamina){
                
                //Nuevos atributos
                this.CantidadVidas = 1;
                this.Superpoder = new Superpoder();
            }

            public Superheroe(string nombre, int aniocreacion, string universo, int stamina, int cantidadvidas, Superpoder superpoder) : base(nombre, aniocreacion, universo, stamina){
                this.CantidadVidas = cantidadvidas;
                this.Superpoder = superpoder;
            }

        #endregion
        
        #region Getters y Setters

            //Set
            public void SetCantidadVidas(int cantidadvidas){
                this.CantidadVidas = cantidadvidas;
            }
            public void SetSuperpoder(Superpoder superpoder){
                this.Superpoder = superpoder;
            }

            //Get
            public int GetCantidadVidas(){
                return this.CantidadVidas;
            }

            public Superpoder GetSuperpoder(){
                return this.Superpoder;
            }

        #endregion
        
        #region Metodos

            public Item ObtenerItem(){
                return new Item();    
            }
            public void UsarItem(Item item){
            }
            public void DefenderAtaque(){
            } 
            public void UsarSuperpoder(){
            }

        #endregion


    }
}
