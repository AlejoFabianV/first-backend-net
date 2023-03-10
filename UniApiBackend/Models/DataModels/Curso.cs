using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;

namespace UniApiBackend.Models.DataModels
{
    public class Curso
    {
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;
        [StringLength(280)]
        public string DescriptionShort { get; set; } = string.Empty;
        public string DescriptionLong { get; set; } = string.Empty;
        public string ObjetivoPincipal { get; set; } = string.Empty;
        public string ObjetivosGenerales { get; set; } = string.Empty;
        public string Requisitos { get; set; } = string.Empty;
        public enum Nivel
        {
            Basico, Intermedio, Avanado
        }

    }
}
