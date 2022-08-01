using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
		namespace AccesoADatos.Entities.Relations.dbo {
			[Serializable()]                         //
			[DataItemAttributeSchemaName("dbo")]  // Database Schema Name
			[DataItemAttributeObjectName("Continente","Continente")]    // Object name  and alias in Database
			[DataItemAttributeObjectType(DataItemAttributeObjectType.ObjectTypeEnum.Table)] // Table, View,StoredProcedure,Function
			public class Continente : IRelationsDataITem
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
             public Int64 Id { get; set; }
             [DataItemAttributeFieldName("Nombre","Nombre")]
             [PropertyAttribute(PropertyAttribute.PropertyAttributeEnum.Display)] //Is Display Default
             public String Nombre { get; set; }
                 /// <summary>
                 ///  Represents the child collection of Pais that have this ContinenteId value.
                 /// </summary>
                 [PropertyAttribute(PropertyAttribute.PropertyAttributeEnum.Exclude)] //Exclude
                 public List<AccesoADatos.Entities.Relations.dbo.Pais> ListOf_Pais_ContinenteId
                {
                     get {
                             AccesoADatos.Business.Relations.dbo.Pais entities = new AccesoADatos.Business.Relations.dbo.Pais();
                             entities.Where.Add(AccesoADatos.Business.Relations.dbo.Pais.ColumnEnum.ContinenteId, AccesoADatos.sqlEnum.OperandEnum.Equal, Id);
                             return entities.Items();
                         }
                }
             public override int GetHashCode() => (Nombre == null ? string.Empty : Nombre).GetHashCode();
             public override string ToString() => Nombre;
				
			} //Class Continente 
} //namespace AccesoADatos.Entities.Relations.dbo
		namespace AccesoADatos.Entities.Relations.dbo {
			[Serializable()]                         //
			[DataItemAttributeSchemaName("dbo")]  // Database Schema Name
			[DataItemAttributeObjectName("Pais","Pais")]    // Object name  and alias in Database
			[DataItemAttributeObjectType(DataItemAttributeObjectType.ObjectTypeEnum.Table)] // Table, View,StoredProcedure,Function
			public class Pais : IRelationsDataITem
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
                public  Pais(String Nombre,AccesoADatos.Entities.Relations.dbo.Continente ContinenteId)
                {
                    this.Id = Id;
                    this.Nombre = Nombre;
                    this.ContinenteId = ContinenteId;
                }
             [DataItemAttributeFieldName("Id","Id")]
             [PropertyAttribute(PropertyAttribute.PropertyAttributeEnum.Pk)] //Is Primary Key
             public Int64 Id { get; set; }
             [DataItemAttributeFieldName("Nombre","Nombre")]
             [PropertyAttribute(PropertyAttribute.PropertyAttributeEnum.Display)] //Is Display Default
             public String Nombre { get; set; }
             [DataItemAttributeFieldName("ContinenteId","ContinenteId")]
             [PropertyAttribute(PropertyAttribute.PropertyAttributeEnum.Exclude)] //Exclude
             internal Int64 _ContinenteId { get; set; }
             [PropertyAttribute(PropertyAttribute.PropertyAttributeEnum.Fk)] //Is Foreign Key
             [PropertyAttributeForeignKeyObjectName("Continente")]// Object name in Database
             public AccesoADatos.Entities.Relations.dbo.Continente ContinenteId
             {
                 get {
                     if (ContinenteId_ == null || ContinenteId_.Id != _ContinenteId)
                         {
                             ContinenteId = new AccesoADatos.Business.Relations.dbo.Continente().Items(this._ContinenteId).FirstOrDefault();
                         }
                     return ContinenteId_;
                     }
                 set {ContinenteId_  =  value;}
             }
             static AccesoADatos.Entities.Relations.dbo.Continente ContinenteId_ = null;
                 /// <summary>
                 ///  Represents the child collection of Usuario that have this PaisId value.
                 /// </summary>
                 [PropertyAttribute(PropertyAttribute.PropertyAttributeEnum.Exclude)] //Exclude
                 public List<AccesoADatos.Entities.Relations.dbo.Usuario> ListOf_Usuario_PaisId
                {
                     get {
                             AccesoADatos.Business.Relations.dbo.Usuario entities = new AccesoADatos.Business.Relations.dbo.Usuario();
                             entities.Where.Add(AccesoADatos.Business.Relations.dbo.Usuario.ColumnEnum.PaisId, AccesoADatos.sqlEnum.OperandEnum.Equal, Id);
                             return entities.Items();
                         }
                }
             public override int GetHashCode() => (Nombre == null ? string.Empty : Nombre).GetHashCode();
             public override string ToString() => Nombre;
				
			} //Class Pais 
} //namespace AccesoADatos.Entities.Relations.dbo
		namespace AccesoADatos.Entities.Relations.dbo {
			[Serializable()]                         //
			[DataItemAttributeSchemaName("dbo")]  // Database Schema Name
			[DataItemAttributeObjectName("Usuario","Usuario")]    // Object name  and alias in Database
			[DataItemAttributeObjectType(DataItemAttributeObjectType.ObjectTypeEnum.Table)] // Table, View,StoredProcedure,Function
			public class Usuario : IRelationsDataITem
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
                public  Usuario(String Nombre,String Apellido,Int16 Edad,AccesoADatos.Entities.Relations.dbo.Pais PaisId)
                {
                    this.Id = Id;
                    this.Nombre = Nombre;
                    this.Apellido = Apellido;
                    this.Edad = Edad;
                    this.PaisId = PaisId;
                }
             [DataItemAttributeFieldName("Id","Id")]
             [PropertyAttribute(PropertyAttribute.PropertyAttributeEnum.Pk)] //Is Primary Key
             public Int64 Id { get; set; }
             [DataItemAttributeFieldName("Nombre","Nombre")]
             [PropertyAttribute(PropertyAttribute.PropertyAttributeEnum.Display)] //Is Display Default
             public String Nombre { get; set; }
             [DataItemAttributeFieldName("Apellido","Apellido")]
             public String Apellido { get; set; }
             [DataItemAttributeFieldName("Edad","Edad")]
             public Int16 Edad { get; set; }
             [DataItemAttributeFieldName("PaisId","PaisId")]
             [PropertyAttribute(PropertyAttribute.PropertyAttributeEnum.Exclude)] //Exclude
             internal Int64 _PaisId { get; set; }
             [PropertyAttribute(PropertyAttribute.PropertyAttributeEnum.Fk)] //Is Foreign Key
             [PropertyAttributeForeignKeyObjectName("Pais")]// Object name in Database
             public AccesoADatos.Entities.Relations.dbo.Pais PaisId
             {
                 get {
                     if (PaisId_ == null || PaisId_.Id != _PaisId)
                         {
                             PaisId = new AccesoADatos.Business.Relations.dbo.Pais().Items(this._PaisId).FirstOrDefault();
                         }
                     return PaisId_;
                     }
                 set {PaisId_  =  value;}
             }
             static AccesoADatos.Entities.Relations.dbo.Pais PaisId_ = null;
             public override int GetHashCode() => (Nombre == null ? string.Empty : Nombre).GetHashCode();
             public override string ToString() => Nombre;
				
			} //Class Usuario 
} //namespace AccesoADatos.Entities.Relations.dbo
