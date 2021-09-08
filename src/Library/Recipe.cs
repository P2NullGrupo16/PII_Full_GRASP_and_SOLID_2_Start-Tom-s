//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;
using System.Text;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        private ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }

        // Crear un stringbuilder para almacenar el texto de la receta.
        /*
        Al ser esta clase la experta en información, debe tener la funcionalidad de crear el texto de la receta,
        cumpliendo así con el patrón Expert. Logrando con esto alta cohesión.
        */
        
        
        public StringBuilder GetRecipeText()
        {
            StringBuilder textoReceta = new StringBuilder();

            string recetaEncabezado = $"Receta de {this.FinalProduct.Description}:";
            textoReceta.AppendLine(recetaEncabezado);

            foreach (Step step in this.steps)
            {
                string texto = $"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}";
                textoReceta.AppendLine(texto);
            }
            textoReceta.ToString();
            return textoReceta;
        }
    }
}