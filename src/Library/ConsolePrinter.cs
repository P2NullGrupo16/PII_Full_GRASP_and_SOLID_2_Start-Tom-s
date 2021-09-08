using System;

// Para crear esta clase me baso en el principio SRP, ya que la clase Recipe no tiene mas de un motivo para cambiar,
// dada por el método que tenía para imprimir la receta en la misma.
// Creando esta clase se logra cumplir con el principio SRP, 
// teniendo esta la responsabilidad de conocer Recipe e imprimir en consola el recipe.

namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter
    {
        public static void Print(Recipe recipe)
        {
            Console.Write(recipe.GetRecipeText());
        }
    }
}