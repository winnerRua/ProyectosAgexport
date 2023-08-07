using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Desarrollo1.Models
{
    public class Colaborador
    {
        //Creación de las propiedad
        public int ColaboradorId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Genero { get; set; }
        public string EstadoCivil { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Edad { get; set; }
        public long DPI { get; set; }
        public long IGSS { get; set; }
        public long IRTRA { get; set; }
        public string Pasaporte { get; set; }
        public string Departamento { get; set; }
        public string Municipio { get; set; }
        public string DireccionResidencia { get; set; }

        //Creación del constructor para inicializar la clase en controlador o gestor de BD.
        public Colaborador() { }

        //Creación del constructor que recibe los datos
        public Colaborador(int id, string nombres, string apellidos, string genero, string estadoCivil, DateTime fechaNacimiento, int edad, long dpi, long igss, long irtra, string pasaporte, string departamento, string municipio, string direccionResidencia)
        {
            ColaboradorId = id;
            Nombres = nombres;
            Apellidos = apellidos;
            Genero = genero;
            EstadoCivil = estadoCivil;
            FechaNacimiento = fechaNacimiento;
            Edad = edad;
            DPI = dpi;
            IGSS = igss;
            IRTRA = irtra;
            Pasaporte = pasaporte;
            Departamento = departamento;
            Municipio = municipio;
            DireccionResidencia = direccionResidencia;
        }

        //Creación de un constructor más para la actualización
        public Colaborador(string nombres, string apellidos, string genero, string estadoCivil, DateTime fechaNacimiento, int edad, long dpi, long igss, long irtra, string pasaporte, string departamento, string municipio, string direccionResidencia)
        {
            Nombres = nombres;
            Apellidos = apellidos;
            Genero = genero;
            EstadoCivil = estadoCivil;
            FechaNacimiento = fechaNacimiento;
            Edad = edad;
            DPI = dpi;
            IGSS = igss;
            IRTRA = irtra;
            Pasaporte = pasaporte;
            Departamento = departamento;
            Municipio = municipio;
            DireccionResidencia = direccionResidencia;
        }
    }
}