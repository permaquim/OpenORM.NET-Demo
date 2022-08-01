using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
		namespace AccesoADatos.Entities.Views.dbo {
			[Serializable()]                         //
			[DataItemAttributeSchemaName("dbo")]  // Database Schema Name
			[DataItemAttributeObjectName("VistaUsuario","VistaUsuario")]    // Object name  and alias in Database
			[DataItemAttributeObjectType(DataItemAttributeObjectType.ObjectTypeEnum.View)] // Table, View,StoredProcedure,Function
			public class VistaUsuario : IDataItem
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
                public VistaUsuario()
                {
                }
	               /// <summary>
                /// Constructor with Parameters 
	               /// <summary>
                public  VistaUsuario(String Nombre,String Apellido,Int16 Edad,String NombrePais,Int64 ContinenteId,String NombreContinente)
                {
                    this.Nombre = Nombre;
                    this.Apellido = Apellido;
                    this.Edad = Edad;
                    this.NombrePais = NombrePais;
                    this.ContinenteId = ContinenteId;
                    this.NombreContinente = NombreContinente;
                }
             [DataItemAttributeFieldName("Nombre","Nombre")]
             public String Nombre { get; set; }
             [DataItemAttributeFieldName("Apellido","Apellido")]
             public String Apellido { get; set; }
             [DataItemAttributeFieldName("Edad","Edad")]
             public Int16 Edad { get; set; }
             [DataItemAttributeFieldName("NombrePais","NombrePais")]
             public String NombrePais { get; set; }
             [DataItemAttributeFieldName("ContinenteId","ContinenteId")]
             public Int64 ContinenteId { get; set; }
             [DataItemAttributeFieldName("NombreContinente","NombreContinente")]
             public String NombreContinente { get; set; }
				
			} //Class VistaUsuario 
			
} //namespace AccesoADatos.Entities.Views.dbo
//////////////////////////////////////////////////////////////////////////////////
