﻿using Project_Carthage.Utils;
using System;
using System.Collections.Generic;

namespace Project_Carthage.Entidades
{
    public class Escuela : ParentEntity, iLugar
    {
        /*
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value.ToUpper(); }
        }
        */

        public int YearOfCreation { get; set; }

        public string Pais { get; set; }

        public string Ciudad { get; set; }

        public string Direccion { get; set; }

        public TiposEscuela TipoEscuela { get; set; }

        public List<Curso> Cursos { get; set; }

        public Escuela(string nombre, int year) => (Nombre, YearOfCreation) = (nombre, year);

        public Escuela(string nombre, int year, TiposEscuela tipo, string pais="", string ciudad ="")
        {
            (Nombre, YearOfCreation) = (nombre, year);
            Pais = pais;
            Ciudad = ciudad;
            TipoEscuela = tipo;
        }

        public override string ToString()
        {
            string newLine = System.Environment.NewLine;
            return $"Nombre: \"{Nombre}\", Tipo: {TipoEscuela} {newLine} Pais: {Pais}, Ciudad: {Ciudad}";
        }

        public void LimpiarLugar()
        {
            Printer.DrawLine();

            Console.WriteLine("Limpiando Escuela...");

            Console.Beep(1500, 3);

            foreach(var curso in Cursos)
            {
                curso.LimpiarLugar();
            }

            Printer.WriteTitle($"Escuela {Nombre} está limpia");
        }
    }
}