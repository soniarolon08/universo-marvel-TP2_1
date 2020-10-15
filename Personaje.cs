// Redefinir el código teniendo en cuenta la clase Personaje y teniendo en cuenta las relaciones de Herencia
// Responder:
// El método Atacar() de la clase personaje, ¿debería ser Virtual o Abstracto? Justificar.

using System;

namespace TP2_1
{
    public abstract class Personaje
    {

        #region Atributos

            private string Nombre;
            private int AnioCreacion;
            private string Universo;
            private int Stamina;
            
        #endregion

        #region Constructor
            
            // Constructores por defecto 

            public Personaje(){
                this.Nombre = "";
                this.AnioCreacion = 0;
                this.Universo = "";
                this.Stamina = 0;
                
            }
            // Constructores por parametros

            public Personaje(string nombre, int aniocreacion, string universo, int stamina){
                this.Nombre = nombre;
                this.AnioCreacion = aniocreacion;
                this.Universo = universo;
                this.Stamina = stamina;
                
            }

        #endregion 

        #region Getters y Setters

            //Set

            public void SetNombre(string nombre){
                this.Nombre = "";
            }
            public void SetAnioCreacion(int aniocreacion){
                this.AnioCreacion = 0;
            }
            public void SetUniverso(string universo){
                this.Universo = "";
            }
            public void SetStamina(int stamina){
                this.Stamina = 0;
            }

            //Get

            public string GetNombre(){
                return this.Nombre;
            }
            public int GetAnioCreacion(){
                return this.AnioCreacion;
            }
            public string GetUniverso(){
                return this.Universo;
            }
            public int GetStamina(){
                return this.Stamina;
            }


        #endregion

        #region Metodos

            public virtual void Atacar(Personaje personaje){

                Console.WriteLine("Estoy atacando a " + personaje.GetNombre());
            }

        // El metodo para mi deberia de ser virtual porque los metodos virtuales proporcionan una implementacion
        // A diferencia si ponemos un metodo abstracto, esta anularia los demas metodos de forma inmediata,
        // en los metodos virtuales esto no sucede si no se lo indica, y en este caso es lo que se necesitaria en relacion al Superheroe y villano, ambas
        // clases hijas de Personaje, por lo tanto comparten el mismo metodo.


        #endregion

    }
}
