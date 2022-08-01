using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
		namespace AccesoADatos.Entities.Tables.dbo {
			[Serializable()]                         //
			[DataItemAttributeSchemaName("dbo")]  // Database Schema Name
			[DataItemAttributeObjectName("Continente","Continente")]    // Object name  and alias in Database
			[DataItemAttributeObjectType(DataItemAttributeObjectType.ObjectTypeEnum.Table)] // Table, View,StoredProcedure,Function
			public class Continente : IDataItem
			{
				        
				public class ColumnNames
				{
					public const string Id = "Id";
					public const string Nombre = "Nombre";
				}
				public enum FieldEnum : int
                {
					Id,
					Nombre
				}
	               /// <summary>
                /// Parameterless Constructor
	               /// <summary>
                public Continente()
                {
                }
                public  Continente(String Nombre)
                {
                    this.Id = Id;
                    this.Nombre = Nombre;
                }
             [DataItemAttributeFieldName("Id","Id")]
             [PropertyAttribute(PropertyAttribute.PropertyAttributeEnum.Pk)] //Is Primary Key
             [PropertyAttribute(PropertyAttribute.PropertyAttributeEnum.Auto)] //Is Auto Key
             public Int64 Id { get; set; }
             [DataItemAttributeFieldName("Nombre","Nombre")]
             [PropertyAttribute(PropertyAttribute.PropertyAttributeEnum.Display)] //Is Display Default
             public String Nombre { get; set; }
				
			} //Class Continente 
} //namespace AccesoADatos.Entities.Tables.dbo
		namespace AccesoADatos.Entities.Tables.dbo {
			[Serializable()]                         //
			[DataItemAttributeSchemaName("dbo")]  // Database Schema Name
			[DataItemAttributeObjectName("Pais","Pais")]    // Object name  and alias in Database
			[DataItemAttributeObjectType(DataItemAttributeObjectType.ObjectTypeEnum.Table)] // Table, View,StoredProcedure,Function
			public class Pais : IDataItem
			{
				        
				public class ColumnNames
				{
					public const string Id = "Id";
					public const string Nombre = "Nombre";
					public const string ContinenteId = "ContinenteId";
				}
				public enum FieldEnum : int
                {
					Id,
					Nombre,
					ContinenteId
				}
	               /// <summary>
                /// Parameterless Constructor
	               /// <summary>
                public Pais()
                {
                }
                public  Pais(String Nombre,Int64 ContinenteId)
                {
                    this.Id = Id;
                    this.Nombre = Nombre;
                    this.ContinenteId = ContinenteId;
                }
             [DataItemAttributeFieldName("Id","Id")]
             [PropertyAttribute(PropertyAttribute.PropertyAttributeEnum.Pk)] //Is Primary Key
             [PropertyAttribute(PropertyAttribute.PropertyAttributeEnum.Auto)] //Is Auto Key
             public Int64 Id { get; set; }
             [DataItemAttributeFieldName("Nombre","Nombre")]
             [PropertyAttribute(PropertyAttribute.PropertyAttributeEnum.Display)] //Is Display Default
             public String Nombre { get; set; }
             [DataItemAttributeFieldName("ContinenteId","ContinenteId")]
             [PropertyAttribute(PropertyAttribute.PropertyAttributeEnum.Fk)] //Is Foreign Key
             [PropertyAttributeForeignKeyObjectName("Continente")]// Object name in Database
             public Int64 ContinenteId { get; set; }
				
			} //Class Pais 
} //namespace AccesoADatos.Entities.Tables.dbo
		namespace AccesoADatos.Entities.Tables.dbo {
			[Serializable()]                         //
			[DataItemAttributeSchemaName("dbo")]  // Database Schema Name
			[DataItemAttributeObjectName("Usuario","Usuario")]    // Object name  and alias in Database
			[DataItemAttributeObjectType(DataItemAttributeObjectType.ObjectTypeEnum.Table)] // Table, View,StoredProcedure,Function
			public class Usuario : IDataItem
			{
				        
				public class ColumnNames
				{
					public const string Id = "Id";
					public const string Nombre = "Nombre";
					public const string Apellido = "Apellido";
					public const string Edad = "Edad";
					public const string PaisId = "PaisId";
				}
				public enum FieldEnum : int
                {
					Id,
					Nombre,
					Apellido,
					Edad,
					PaisId
				}
	               /// <summary>
                /// Parameterless Constructor
	               /// <summary>
                public Usuario()
                {
                }
                public  Usuario(String Nombre,String Apellido,Int16 Edad,Int64 PaisId)
                {
                    this.Id = Id;
                    this.Nombre = Nombre;
                    this.Apellido = Apellido;
                    this.Edad = Edad;
                    this.PaisId = PaisId;
                }
             [DataItemAttributeFieldName("Id","Id")]
             [PropertyAttribute(PropertyAttribute.PropertyAttributeEnum.Pk)] //Is Primary Key
             [PropertyAttribute(PropertyAttribute.PropertyAttributeEnum.Auto)] //Is Auto Key
             public Int64 Id { get; set; }
             [DataItemAttributeFieldName("Nombre","Nombre")]
             [PropertyAttribute(PropertyAttribute.PropertyAttributeEnum.Display)] //Is Display Default
             public String Nombre { get; set; }
             [DataItemAttributeFieldName("Apellido","Apellido")]
             public String Apellido { get; set; }
             [DataItemAttributeFieldName("Edad","Edad")]
             public Int16 Edad { get; set; }
             [DataItemAttributeFieldName("PaisId","PaisId")]
             [PropertyAttribute(PropertyAttribute.PropertyAttributeEnum.Fk)] //Is Foreign Key
             [PropertyAttributeForeignKeyObjectName("Pais")]// Object name in Database
             public Int64 PaisId { get; set; }
				
			} //Class Usuario 
} //namespace AccesoADatos.Entities.Tables.dbo
