using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
		namespace AccesoADatos.Entities.Procedures.dbo {
			[Serializable()]                         //
			[DataItemAttributeSchemaName("dbo")]  // Database Schema Name
			[DataItemAttributeObjectName("ObtenerUsuario","ObtenerUsuario")]    // Object name  and alias in Database
			[DataItemAttributeObjectType(DataItemAttributeObjectType.ObjectTypeEnum.Procedure)] // Table, Procedures,StoredProcedure,Function
			public class ObtenerUsuario : IDataItem
			{
				        
				public class ColumnNames
				{
					public const string Nombre = "Nombre";
					public const string Apellido = "Apellido";
					public const string Edad = "Edad";
					public const string NombrePais = "NombrePais";
					public const string ContinenteId = "ContinenteId";
					public const string NombreContinente = "NombreContinente";
				}
				public enum FieldEnum : int
                {
					Nombre,
					Apellido,
					Edad,
					NombrePais,
					ContinenteId,
					NombreContinente
				}
	               /// <summary>
                /// Parameterless Constructor
	               /// <summary>
                public ObtenerUsuario()
                {
                }
             [DataItemAttributeFieldName("Nombre","Nombre")]
             public String Nombre { get; set; }
             [DataItemAttributeFieldName("Apellido","Apellido")]
             public String Apellido { get; set; }
             [DataItemAttributeFieldName("Edad","Edad")]
             public Int16? Edad { get; set; }
             [DataItemAttributeFieldName("NombrePais","NombrePais")]
             public String NombrePais { get; set; }
             [DataItemAttributeFieldName("ContinenteId","ContinenteId")]
             public Int64? ContinenteId { get; set; }
             [DataItemAttributeFieldName("NombreContinente","NombreContinente")]
             public String NombreContinente { get; set; }
				
			} //Class ObtenerUsuario 
			
} //namespace AccesoADatos.Entities.Procedures.dbo
