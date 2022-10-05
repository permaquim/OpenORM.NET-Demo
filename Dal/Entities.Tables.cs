using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
		namespace AccesoADatos.Entities.Tables.dbo {
			[Serializable()]                         //
			[DataItemAttributeSchemaName("dbo")]  // Database Schema Name
			[DataItemAttributeObjectName("Banco","Banco")]    // Object name  and alias in Database
			[DataItemAttributeObjectType(DataItemAttributeObjectType.ObjectTypeEnum.Table)] // Table, View,StoredProcedure,Function
			public class Banco : IDataItem
			{
				        
				public class ColumnNames
				{
					public const string Id = "Id";
					public const string Nombre = "Nombre";
					public const string Descripcion = "Descripcion";
					public const string Codigo = "Codigo";
					public const string PaisId = "PaisId";
					public const string Habilitado = "Habilitado";
					public const string UsuarioCreacion = "UsuarioCreacion";
					public const string FechaCreacion = "FechaCreacion";
					public const string UsuarioModificacion = "UsuarioModificacion";
					public const string FechaModificacion = "FechaModificacion";
				}
				public enum FieldEnum : int
                {
					Id,
					Nombre,
					Descripcion,
					Codigo,
					PaisId,
					Habilitado,
					UsuarioCreacion,
					FechaCreacion,
					UsuarioModificacion,
					FechaModificacion
				}
	               /// <summary>
                /// Parameterless Constructor
	               /// <summary>
                public Banco()
                {
                }
                public  Banco(String Nombre,String Descripcion,String Codigo,Int64 PaisId,Boolean Habilitado,Int64 UsuarioCreacion,DateTime FechaCreacion,Int64? UsuarioModificacion,DateTime? FechaModificacion)
                {
                    this.Id = Id;
                    this.Nombre = Nombre;
                    this.Descripcion = Descripcion;
                    this.Codigo = Codigo;
                    this.PaisId = PaisId;
                    this.Habilitado = Habilitado;
                    this.UsuarioCreacion = UsuarioCreacion;
                    this.FechaCreacion = FechaCreacion;
                    this.UsuarioModificacion = UsuarioModificacion;
                    this.FechaModificacion = FechaModificacion;
                }
             [DataItemAttributeFieldName("Id","Id")]
             [PropertyAttribute(PropertyAttribute.PropertyAttributeEnum.Pk)] //Is Primary Key
             [PropertyAttribute(PropertyAttribute.PropertyAttributeEnum.Auto)] //Is Auto Key
             public Int64 Id { get; set; }
             [DataItemAttributeFieldName("Nombre","Nombre")]
             [PropertyAttribute(PropertyAttribute.PropertyAttributeEnum.Display)] //Is Display Default
             public String Nombre { get; set; }
             [DataItemAttributeFieldName("Descripcion","Descripcion")]
             public String Descripcion { get; set; }
             [DataItemAttributeFieldName("Codigo","Codigo")]
             public String Codigo { get; set; }
             [DataItemAttributeFieldName("PaisId","PaisId")]
             public Int64 PaisId { get; set; }
             [DataItemAttributeFieldName("Habilitado","Habilitado")]
             public Boolean Habilitado { get; set; }
             [DataItemAttributeFieldName("UsuarioCreacion","UsuarioCreacion")]
             public Int64 UsuarioCreacion { get; set; }
             [DataItemAttributeFieldName("FechaCreacion","FechaCreacion")]
             public DateTime FechaCreacion { get; set; }
             [DataItemAttributeFieldName("UsuarioModificacion","UsuarioModificacion")]
             public Int64? UsuarioModificacion { get; set; }
             [DataItemAttributeFieldName("FechaModificacion","FechaModificacion")]
             public DateTime? FechaModificacion { get; set; }
				
			} //Class Banco 
} //namespace AccesoADatos.Entities.Tables.dbo
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
			[DataItemAttributeObjectName("Log","Log")]    // Object name  and alias in Database
			[DataItemAttributeObjectType(DataItemAttributeObjectType.ObjectTypeEnum.Table)] // Table, View,StoredProcedure,Function
			public class Log : IDataItem
			{
				        
				public class ColumnNames
				{
					public const string Id = "Id";
					public const string TipoId = "TipoId";
					public const string AplicacionId = "AplicacionId";
					public const string Fecha = "Fecha";
					public const string Descripcion = "Descripcion";
					public const string Detalle = "Detalle";
					public const string Modulo = "Modulo";
					public const string Metodo = "Metodo";
					public const string UsuarioId = "UsuarioId";
				}
				public enum FieldEnum : int
                {
					Id,
					TipoId,
					AplicacionId,
					Fecha,
					Descripcion,
					Detalle,
					Modulo,
					Metodo,
					UsuarioId
				}
	               /// <summary>
                /// Parameterless Constructor
	               /// <summary>
                public Log()
                {
                }
                public  Log(Int64 TipoId,Int64 AplicacionId,DateTime Fecha,String Descripcion,String Detalle,String Modulo,String Metodo,Int64 UsuarioId)
                {
                    this.Id = Id;
                    this.TipoId = TipoId;
                    this.AplicacionId = AplicacionId;
                    this.Fecha = Fecha;
                    this.Descripcion = Descripcion;
                    this.Detalle = Detalle;
                    this.Modulo = Modulo;
                    this.Metodo = Metodo;
                    this.UsuarioId = UsuarioId;
                }
             [DataItemAttributeFieldName("Id","Id")]
             [PropertyAttribute(PropertyAttribute.PropertyAttributeEnum.Pk)] //Is Primary Key
             [PropertyAttribute(PropertyAttribute.PropertyAttributeEnum.Auto)] //Is Auto Key
             public Int64 Id { get; set; }
             [DataItemAttributeFieldName("TipoId","TipoId")]
             public Int64 TipoId { get; set; }
             [DataItemAttributeFieldName("AplicacionId","AplicacionId")]
             public Int64 AplicacionId { get; set; }
             [DataItemAttributeFieldName("Fecha","Fecha")]
             public DateTime Fecha { get; set; }
             [DataItemAttributeFieldName("Descripcion","Descripcion")]
             public String Descripcion { get; set; }
             [DataItemAttributeFieldName("Detalle","Detalle")]
             public String Detalle { get; set; }
             [DataItemAttributeFieldName("Modulo","Modulo")]
             public String Modulo { get; set; }
             [DataItemAttributeFieldName("Metodo","Metodo")]
             public String Metodo { get; set; }
             [DataItemAttributeFieldName("UsuarioId","UsuarioId")]
             public Int64 UsuarioId { get; set; }
				
			} //Class Log 
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
