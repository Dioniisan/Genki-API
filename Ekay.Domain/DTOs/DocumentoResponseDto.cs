﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ekay.Domain.DTOs
{
	public class DocumentoResponseDto
	{


        public int Id { get; set; }
        public DateTime? FechaCreacion { get; set; }
       
        public string NombreArchivo { get; set; }
       
        public string NombreA { get; set; }

        public string Nombre { get; set; }

        public string Contenido { get; set; }
        


    }



}