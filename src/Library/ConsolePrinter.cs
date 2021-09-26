//---------------------------------------------------------------------------------
// Utilizamos los principios de polimorfismo para cambiar la clase "AllInOnePrinter" 
// a una interfaz con dos sub clases.
// Borramos y volvimos a crear el archivo Recipe.txt para comprobar que se cumpliera
// el principio de sustitucion LSP. Pudimos comprobar que al realizar nuestros cambios
// el programa siguio funcionando de la misma forma que antes cumpliendolo.
//---------------------------------------------------------------------------------
using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{   
    public class ConsolePrinter : IPrinter
    {
        public void PrintRecipe(Recipe recipe)
        {
            Console.WriteLine(recipe.GetTextToPrint());
        }
    }
}
