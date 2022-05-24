using System;///<remarks>Cambio de posición . Se a puesto el using en la primera linea en vez de la segunda.La razón es mejorar la legibilidad</remarks>


//namespace EDexamenT6a8

///<remarks>Espacios entre metodos clases y bloques de código. Se a utilizado el bóton de ejecutar limpieza y proceso a mano .La razón es mejorar la legibilidad </remarks>

///<remarks>Eliminación de this .Se han eliminado los this que no están dentro del constrcutor. No son necesario  </remarks>

///<remarks>Eliminación de else incesario.Se han elimiado else de algunos métodos( ConsumoAgua,ConsumoCapsulas) .No es necesario,pues ya se devuelve el valor necesario </remarks>

class ejemplodemicafetera ///<remarks>Cambio de posición . Se colocado esta clase en primer lugar porque tiene el main.La razón es mejorar la legibilidad </remarks>

{

    static void main()
    {
        ///<remarks>Cambio de nombre . Se ha cambiado todas los nombre de varibles al estilo .La razón es mejorar la legibilidad </remarks>

        cafetera miCafeteraEjemplo = new cafetera("EspressoBarista", "Procoffee", 0.6, 7);

        Console.WriteLine(miCafeteraEjemplo.agua);
        Console.WriteLine(miCafeteraEjemplo.ConsumoCapsulas(5));
        Console.WriteLine(miCafeteraEjemplo.totaldecapsulas);
        Console.WriteLine(miCafeteraEjemplo.ConsumoAgua(5));
        Console.WriteLine(miCafeteraEjemplo.agua);
        miCafeteraEjemplo.LLenarDeposito(0.5);
        Console.WriteLine(miCafeteraEjemplo.agua);
        miCafeteraEjemplo.ReponerCapsulas(3);
        Console.WriteLine(miCafeteraEjemplo.totaldecapsulas);


    }

}



class cafetera
{
    ///<summary>
/// Es una clase que gestiona la cantidad de capsulas y el consumo de agua ,tambiém informa de si hay que llenar el deposito y reponer las capsulas
/// <param name="numerodecafe">Valor de tipo double  el cual específica la cantidad de cafes.</param>
/// <param name="cantidadcapsulas">Valor de tipo double  el cual específica la cantidad de cafes.</param>
///</summary>
///

    ///<remarks>Cambiar nombre .Se ha cambiado el nombre de las varibles por nombres más descriptivos.La razón es para hacer que sea más legible. </remarks>
    ///<remarks>Se ha puesto los capos antes que los métodos</remarks>
    public string marca;
    public string referencia;
    public double agua;
    public double totaldecapsulas;
    ///<remarks>Cambiar nombre.Se ha cambiado el nombre del los  métodos y constructor  al estilo pasCal.Se ha realizado por buenas practicas del </remarks>

    public Cafetera(string marca, string referencia, double agua, double totaldecapsulas)
    {
        this.marca = marca; //marca de la máquina cafetera
        this.referencia =referencia; //referencia del modelo
        this.totaldecapsulas = totaldecapsulas; //Total de cápsulas en la máquina. 
        this.agua = agua; //Cantidad de agua en el recipiente. 
    }

     
    public string ConsumoAgua(double numerodecafe) //numero de cafés a hacer
    {
        const CONSTANTE = 0.1;///<remarks>Cambiar nombre y variable.Si es constante debe ser "const" y estar escrita en mayusculas.Se ha realizado por buenas practicas del </remarks>
        agua = agua - numerodecafe * CONSTANTE; // Constante de consumo de agua 0.1l por cada unidad de café. 
        ///<remarks>Eliminación de this .No es necesario  </remarks>
        if (agua < 0.1)
        {   
            agua = 0;

            return "Falta agua en el depósito, por favor, revisar los niveles.";///<returns>Mensajes de revisión de agua</returns>

        } ///<remarks>Eliminación de else  .No es necesario  </remarks>
          return "Quedan" + this.agua + " centilitros";///<returns>Sring que devuelve cuantos centilitros de agua quedan </returns>
        
    }
    
    public string ConsumoCapsulas(double numerodecafe) //Hacer un café 
    {
       totaldeCapsulas = totaldeCapsulas - numerodecafe;
        if (totaldeCapsulas < 0)
        {
            totaldeCapsulas = 0;
            return "Faltan cápsulas en el depósito, por favor, compre cápsulas.";
        }
       
         return "Quedan" + this.totaldeCapsulas + "unidades"; ///<returns>Un string que devuelve cuantas capsulas quedan</returns>
        
    }
  
    public double ReponerCapsulas(double cantidadcapsulas)
    {
      totaldeCapsulas = totaldeCapsulas + cantidadcapsulas;
        return totaldeCapsulas;///<returns>Un double que devuelve la cantidad de capsulas que quedan despues de la resta </returns>
    }

    public double LLenarDeposito(double litros)
    {
        agua = agua + litros;
        return agua;///<returns>Un double que devuelve la cantidad de aguas que queda despues de la suma </returns>
    }

   ///<remarks>Eliminación .Se ha eliminado el método VerEspecificacion() porque no se llama </remarks>VerEspecificacion
    

}


