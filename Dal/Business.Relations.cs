using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
	namespace AccesoADatos.Business.Relations.dbo {
	    /// <summary>
	    /// 
	    /// </summary>
		public class Banco : RelationsDataHandler
		{
				public enum ColumnEnum : int
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
			   protected List<Entities.Relations.dbo.Banco> _cacheItemList = new List<Entities.Relations.dbo.Banco>();
			   protected List<Entities.Relations.dbo.Banco> _entities = null;
            public new CustomWhereParameter Where { get; set; }
            public new CustomOrderByParameter OrderByParameter { get; set; }
            public new CustomGroupByParameter GroupByParameter { get; set; }
            public new CustomAggregateParameter AggregateParameter { get; set; }
            public Banco() : base()
            {
                base._dataItem = new Entities.Relations.dbo.Banco();
                Where = new CustomWhereParameter();
                OrderByParameter = new CustomOrderByParameter();
                GroupByParameter = new CustomGroupByParameter();
            }
            public class CustomAggregateParameter : AggregateParameter
            {
                 internal AggregateParameter aggregateParameter = new AggregateParameter();
                 public void Add(AccesoADatos.sqlEnum.FunctionEnum functionEnum, ColumnEnum column)
                     {
                         this.aggregateParameter.Add(functionEnum, Enum.GetName(typeof(ColumnEnum), column));
                     }
            }
			// Adds to a memory cache to hold pending transactions
			public void AddToCache(Entities.Relations.dbo.Banco item)
			{
				_cacheItemList.Add(item);
			}
			public void UpdateCache()
			{
                this.BeginTransaction();
				foreach(IDataItem item in _cacheItemList)
					base.Add(item);
				this.EndTransaction(true);
			}
			// Method that accepts arguments corresponding to fields (Those wich aren´t identity.)
         /// <summary>
         /// Banco Add Method
         /// </summary>
         /// <param name='Nombre'></param>
         /// <param name='Descripcion'></param>
         /// <param name='Codigo'></param>
         /// <param name='PaisId'></param>
         /// <param name='Habilitado'></param>
         /// <param name='UsuarioCreacion'></param>
         /// <param name='FechaCreacion'></param>
         /// <param name='UsuarioModificacion'></param>
         /// <param name='FechaModificacion'></param>
         /// <returns>Entities.Relations.dbo.Banco</returns>
			public Entities.Relations.dbo.Banco Add(String Nombre,String Descripcion,String Codigo,Int64 PaisId,Boolean Habilitado,Int64 UsuarioCreacion,DateTime FechaCreacion,Int64 UsuarioModificacion,DateTime FechaModificacion) 
			{
			  return (Entities.Relations.dbo.Banco)base.Add(new Entities.Relations.dbo.Banco(Nombre,Descripcion,Codigo,PaisId,Habilitado,UsuarioCreacion,FechaCreacion,UsuarioModificacion,FechaModificacion));
			}
            public new List<Entities.Relations.dbo.Banco> Items()
            {
                RelationsDataHandler dh =  new RelationsDataHandler(this._dataItem);
                dh.WhereParameter = this.Where.whereParameter;
                dh.OrderByParameter = this.OrderByParameter.orderByParameter;
                dh.GroupByParameter = this.GroupByParameter.groupByParameter;
                _entities = dh.Items().Cast<Entities.Relations.dbo.Banco>().ToList<Entities.Relations.dbo.Banco>();
                return _entities;
            }
            /// <summary>
            /// Gets Entities.Relations.dbo.Banco items by Pk
            /// </summary>
            /// <param name="Id"></param>
            /// <returns></returns>
            public List<Entities.Relations.dbo.Banco> Items(Int64 Id)
            {
                this.Where.Clear();
                    if (this.Where.whereParameter.Count == 0)
                    {
                         this.Where.Add(ColumnEnum.Id, AccesoADatos.sqlEnum.OperandEnum.Equal, Id);
                    }
                    else
                    {
                         this.Where.Add(AccesoADatos.sqlEnum.ConjunctionEnum.AND,ColumnEnum.Id, AccesoADatos.sqlEnum.OperandEnum.Equal, Id);
                    }
                return this.Items();
            }
            /// <summary>
            /// Gets items with all fields
            /// </summary>
            /// <param name="Id"></param>
            /// <param name="Nombre"></param>
            /// <param name="Descripcion"></param>
            /// <param name="Codigo"></param>
            /// <param name="PaisId"></param>
            /// <param name="Habilitado"></param>
            /// <param name="UsuarioCreacion"></param>
            /// <param name="FechaCreacion"></param>
            /// <param name="UsuarioModificacion"></param>
            /// <param name="FechaModificacion"></param>
            /// <returns></returns>
            public List<Entities.Relations.dbo.Banco> Items(Int64? Id,String Nombre,String Descripcion,String Codigo,Int64? PaisId,Boolean? Habilitado,Int64? UsuarioCreacion,DateTime? FechaCreacion,Int64? UsuarioModificacion,DateTime? FechaModificacion)
            {
                this.Where.whereParameter.Clear();
                if (Id != null)
                {
                    if (this.Where.whereParameter.Count == 0)
                    {
                        this.Where.Add(ColumnEnum.Id, AccesoADatos.sqlEnum.OperandEnum.Equal, Id);
                    }
                    else
                    {
                        this.Where.Add(AccesoADatos.sqlEnum.ConjunctionEnum.AND, ColumnEnum.Id, AccesoADatos.sqlEnum.OperandEnum.Equal, Id);
                    }
                   
                }
                if (Nombre != null)
                {
                    if (this.Where.whereParameter.Count == 0)
                    {
                        this.Where.Add(ColumnEnum.Nombre, AccesoADatos.sqlEnum.OperandEnum.Equal, Nombre);
                    }
                    else
                    {
                        this.Where.Add(AccesoADatos.sqlEnum.ConjunctionEnum.AND, ColumnEnum.Nombre, AccesoADatos.sqlEnum.OperandEnum.Equal, Nombre);
                    }
                   
                }
                if (Descripcion != null)
                {
                    if (this.Where.whereParameter.Count == 0)
                    {
                        this.Where.Add(ColumnEnum.Descripcion, AccesoADatos.sqlEnum.OperandEnum.Equal, Descripcion);
                    }
                    else
                    {
                        this.Where.Add(AccesoADatos.sqlEnum.ConjunctionEnum.AND, ColumnEnum.Descripcion, AccesoADatos.sqlEnum.OperandEnum.Equal, Descripcion);
                    }
                   
                }
                if (Codigo != null)
                {
                    if (this.Where.whereParameter.Count == 0)
                    {
                        this.Where.Add(ColumnEnum.Codigo, AccesoADatos.sqlEnum.OperandEnum.Equal, Codigo);
                    }
                    else
                    {
                        this.Where.Add(AccesoADatos.sqlEnum.ConjunctionEnum.AND, ColumnEnum.Codigo, AccesoADatos.sqlEnum.OperandEnum.Equal, Codigo);
                    }
                   
                }
                if (PaisId != null)
                {
                    if (this.Where.whereParameter.Count == 0)
                    {
                        this.Where.Add(ColumnEnum.PaisId, AccesoADatos.sqlEnum.OperandEnum.Equal, PaisId);
                    }
                    else
                    {
                        this.Where.Add(AccesoADatos.sqlEnum.ConjunctionEnum.AND, ColumnEnum.PaisId, AccesoADatos.sqlEnum.OperandEnum.Equal, PaisId);
                    }
                   
                }
                if (Habilitado != null)
                {
                    if (this.Where.whereParameter.Count == 0)
                    {
                        this.Where.Add(ColumnEnum.Habilitado, AccesoADatos.sqlEnum.OperandEnum.Equal, Habilitado);
                    }
                    else
                    {
                        this.Where.Add(AccesoADatos.sqlEnum.ConjunctionEnum.AND, ColumnEnum.Habilitado, AccesoADatos.sqlEnum.OperandEnum.Equal, Habilitado);
                    }
                   
                }
                if (UsuarioCreacion != null)
                {
                    if (this.Where.whereParameter.Count == 0)
                    {
                        this.Where.Add(ColumnEnum.UsuarioCreacion, AccesoADatos.sqlEnum.OperandEnum.Equal, UsuarioCreacion);
                    }
                    else
                    {
                        this.Where.Add(AccesoADatos.sqlEnum.ConjunctionEnum.AND, ColumnEnum.UsuarioCreacion, AccesoADatos.sqlEnum.OperandEnum.Equal, UsuarioCreacion);
                    }
                   
                }
                if (FechaCreacion != null)
                {
                    if (this.Where.whereParameter.Count == 0)
                    {
                        this.Where.Add(ColumnEnum.FechaCreacion, AccesoADatos.sqlEnum.OperandEnum.Equal, FechaCreacion);
                    }
                    else
                    {
                        this.Where.Add(AccesoADatos.sqlEnum.ConjunctionEnum.AND, ColumnEnum.FechaCreacion, AccesoADatos.sqlEnum.OperandEnum.Equal, FechaCreacion);
                    }
                   
                }
                if (UsuarioModificacion != null)
                {
                    if (this.Where.whereParameter.Count == 0)
                    {
                        this.Where.Add(ColumnEnum.UsuarioModificacion, AccesoADatos.sqlEnum.OperandEnum.Equal, UsuarioModificacion);
                    }
                    else
                    {
                        this.Where.Add(AccesoADatos.sqlEnum.ConjunctionEnum.AND, ColumnEnum.UsuarioModificacion, AccesoADatos.sqlEnum.OperandEnum.Equal, UsuarioModificacion);
                    }
                   
                }
                if (FechaModificacion != null)
                {
                    if (this.Where.whereParameter.Count == 0)
                    {
                        this.Where.Add(ColumnEnum.FechaModificacion, AccesoADatos.sqlEnum.OperandEnum.Equal, FechaModificacion);
                    }
                    else
                    {
                        this.Where.Add(AccesoADatos.sqlEnum.ConjunctionEnum.AND, ColumnEnum.FechaModificacion, AccesoADatos.sqlEnum.OperandEnum.Equal, FechaModificacion);
                    }
                   
                }
                return this.Items();
            }
            public List<Entities.Relations.dbo.Banco> Result 
            {
                get { return _entities; }
            }
            public Entities.Relations.dbo.Banco Add(Entities.Relations.dbo.Banco item)
            {
                RelationsDataHandler dh = new RelationsDataHandler(this._dataItem);
                return (Entities.Relations.dbo.Banco)base.Add((IDataItem)item);
            }
            public Int64 Update(Entities.Relations.dbo.Banco item)
            {
                return base.Update((IDataItem)item);
            }
            public Int64 Delete(Entities.Relations.dbo.Banco item)
            {
                return base.DeleteItem((IDataItem)item);
            }
            /// Updates an instance of Entities.Relations.dbo.Banco with parameters
            /// </summary>
            /// <param name="Id"></param>
            /// <param name="Nombre"></param>
            /// <param name="Descripcion"></param>
            /// <param name="Codigo"></param>
            /// <param name="PaisId"></param>
            /// <param name="Habilitado"></param>
            /// <param name="UsuarioCreacion"></param>
            /// <param name="FechaCreacion"></param>
            /// <param name="UsuarioModificacion"></param>
            /// <param name="FechaModificacion"></param>
            /// <returns>Int64</returns>
            public Int64 Update(Int64 Id,String Nombre,String Descripcion,String Codigo,Int64 PaisId,Boolean Habilitado,Int64 UsuarioCreacion,DateTime FechaCreacion,Int64 UsuarioModificacion,DateTime FechaModificacion)
            {
                 Entities.Tables.dbo.Banco item = new Entities.Tables.dbo.Banco();
                 item.Id = Id;
                 item.Nombre = Nombre;
                 item.Descripcion = Descripcion;
                 item.Codigo = Codigo;
                 item.PaisId = PaisId;
                 item.Habilitado = Habilitado;
                 item.UsuarioCreacion = UsuarioCreacion;
                 item.FechaCreacion = FechaCreacion;
                 item.UsuarioModificacion = UsuarioModificacion;
                 item.FechaModificacion = FechaModificacion;

                return base.Update((IDataItem)item);
            }
            public class CustomWhereParameter : WhereParameter {
                 internal WhereParameter whereParameter = new WhereParameter();
                 public void Add(ColumnEnum betweenColumn, AccesoADatos.sqlEnum.OperandEnum operand, object valueFrom, object valueTo)
                 {
                     this.whereParameter.Add(Enum.GetName(typeof(ColumnEnum), betweenColumn), valueFrom, valueTo);
                 }
                 public void  Add(ColumnEnum column, AccesoADatos.sqlEnum.OperandEnum operand,object value)
                 {
                     this.whereParameter.Add(Enum.GetName(typeof(ColumnEnum), column), operand, value);
                 }
                 public void Add(AccesoADatos.sqlEnum.ConjunctionEnum conjunction,ColumnEnum betweenColumn, AccesoADatos.sqlEnum.OperandEnum operand, object valueFrom, object valueTo)
                 {
                     this.whereParameter.Add(conjunction, Enum.GetName(typeof(ColumnEnum), betweenColumn), valueFrom, valueTo);
                 }
                 public void Add(AccesoADatos.sqlEnum.ConjunctionEnum conjunction,ColumnEnum column, AccesoADatos.sqlEnum.OperandEnum operand, object value)
                 {
                     this.whereParameter.Add(conjunction, Enum.GetName(typeof(ColumnEnum), column), operand, value);
                 }
                 public void Clear()
                 {
                     this.whereParameter.Clear();
                 }
                 public long Count
                 {
                     get {
                         return this.whereParameter.Count;
                     }
                 }
            }
            public class CustomOrderByParameter : OrderByParameter {
                 internal OrderByParameter orderByParameter = new OrderByParameter();
                 public void Add(ColumnEnum column, AccesoADatos.sqlEnum.DirEnum direction = AccesoADatos.sqlEnum.DirEnum.ASC)
                 {
                     this.orderByParameter.Add(Enum.GetName(typeof(ColumnEnum), column), direction);
                 }
            }
            public class CustomGroupByParameter : GroupByParameter {
                 internal GroupByParameter groupByParameter = new GroupByParameter();
                 public void Add(ColumnEnum column)
                 {
                     this.groupByParameter.Add(Enum.GetName(typeof(ColumnEnum), column));
                 }
            }
        } // class Banco
	} //namespace AccesoADatos.Business.Relations.dbo
	namespace AccesoADatos.Business.Relations.dbo {
	    /// <summary>
	    /// 
	    /// </summary>
		public class Continente : RelationsDataHandler
		{
				public enum ColumnEnum : int
                {
					Id,
					Nombre
				}
			   protected List<Entities.Relations.dbo.Continente> _cacheItemList = new List<Entities.Relations.dbo.Continente>();
			   protected List<Entities.Relations.dbo.Continente> _entities = null;
            public new CustomWhereParameter Where { get; set; }
            public new CustomOrderByParameter OrderByParameter { get; set; }
            public new CustomGroupByParameter GroupByParameter { get; set; }
            public new CustomAggregateParameter AggregateParameter { get; set; }
            public Continente() : base()
            {
                base._dataItem = new Entities.Relations.dbo.Continente();
                Where = new CustomWhereParameter();
                OrderByParameter = new CustomOrderByParameter();
                GroupByParameter = new CustomGroupByParameter();
            }
            public class CustomAggregateParameter : AggregateParameter
            {
                 internal AggregateParameter aggregateParameter = new AggregateParameter();
                 public void Add(AccesoADatos.sqlEnum.FunctionEnum functionEnum, ColumnEnum column)
                     {
                         this.aggregateParameter.Add(functionEnum, Enum.GetName(typeof(ColumnEnum), column));
                     }
            }
			// Adds to a memory cache to hold pending transactions
			public void AddToCache(Entities.Relations.dbo.Continente item)
			{
				_cacheItemList.Add(item);
			}
			public void UpdateCache()
			{
                this.BeginTransaction();
				foreach(IDataItem item in _cacheItemList)
					base.Add(item);
				this.EndTransaction(true);
			}
			// Method that accepts arguments corresponding to fields (Those wich aren´t identity.)
         /// <summary>
         /// Continente Add Method
         /// </summary>
         /// <param name='Nombre'></param>
         /// <returns>Entities.Relations.dbo.Continente</returns>
			public Entities.Relations.dbo.Continente Add(String Nombre) 
			{
			  return (Entities.Relations.dbo.Continente)base.Add(new Entities.Relations.dbo.Continente(Nombre));
			}
            public new List<Entities.Relations.dbo.Continente> Items()
            {
                RelationsDataHandler dh =  new RelationsDataHandler(this._dataItem);
                dh.WhereParameter = this.Where.whereParameter;
                dh.OrderByParameter = this.OrderByParameter.orderByParameter;
                dh.GroupByParameter = this.GroupByParameter.groupByParameter;
                _entities = dh.Items().Cast<Entities.Relations.dbo.Continente>().ToList<Entities.Relations.dbo.Continente>();
                return _entities;
            }
            /// <summary>
            /// Gets Entities.Relations.dbo.Continente items by Pk
            /// </summary>
            /// <param name="Id"></param>
            /// <returns></returns>
            public List<Entities.Relations.dbo.Continente> Items(Int64 Id)
            {
                this.Where.Clear();
                    if (this.Where.whereParameter.Count == 0)
                    {
                         this.Where.Add(ColumnEnum.Id, AccesoADatos.sqlEnum.OperandEnum.Equal, Id);
                    }
                    else
                    {
                         this.Where.Add(AccesoADatos.sqlEnum.ConjunctionEnum.AND,ColumnEnum.Id, AccesoADatos.sqlEnum.OperandEnum.Equal, Id);
                    }
                return this.Items();
            }
            /// <summary>
            /// Gets items with all fields
            /// </summary>
            /// <param name="Id"></param>
            /// <param name="Nombre"></param>
            /// <returns></returns>
            public List<Entities.Relations.dbo.Continente> Items(Int64? Id,String Nombre)
            {
                this.Where.whereParameter.Clear();
                if (Id != null)
                {
                    if (this.Where.whereParameter.Count == 0)
                    {
                        this.Where.Add(ColumnEnum.Id, AccesoADatos.sqlEnum.OperandEnum.Equal, Id);
                    }
                    else
                    {
                        this.Where.Add(AccesoADatos.sqlEnum.ConjunctionEnum.AND, ColumnEnum.Id, AccesoADatos.sqlEnum.OperandEnum.Equal, Id);
                    }
                   
                }
                if (Nombre != null)
                {
                    if (this.Where.whereParameter.Count == 0)
                    {
                        this.Where.Add(ColumnEnum.Nombre, AccesoADatos.sqlEnum.OperandEnum.Equal, Nombre);
                    }
                    else
                    {
                        this.Where.Add(AccesoADatos.sqlEnum.ConjunctionEnum.AND, ColumnEnum.Nombre, AccesoADatos.sqlEnum.OperandEnum.Equal, Nombre);
                    }
                   
                }
                return this.Items();
            }
            public List<Entities.Relations.dbo.Continente> Result 
            {
                get { return _entities; }
            }
            public Entities.Relations.dbo.Continente Add(Entities.Relations.dbo.Continente item)
            {
                RelationsDataHandler dh = new RelationsDataHandler(this._dataItem);
                return (Entities.Relations.dbo.Continente)base.Add((IDataItem)item);
            }
            public Int64 Update(Entities.Relations.dbo.Continente item)
            {
                return base.Update((IDataItem)item);
            }
            public Int64 Delete(Entities.Relations.dbo.Continente item)
            {
                return base.DeleteItem((IDataItem)item);
            }
            /// Updates an instance of Entities.Relations.dbo.Continente with parameters
            /// </summary>
            /// <param name="Id"></param>
            /// <param name="Nombre"></param>
            /// <returns>Int64</returns>
            public Int64 Update(Int64 Id,String Nombre)
            {
                 Entities.Tables.dbo.Continente item = new Entities.Tables.dbo.Continente();
                 item.Id = Id;
                 item.Nombre = Nombre;

                return base.Update((IDataItem)item);
            }
            public class CustomWhereParameter : WhereParameter {
                 internal WhereParameter whereParameter = new WhereParameter();
                 public void Add(ColumnEnum betweenColumn, AccesoADatos.sqlEnum.OperandEnum operand, object valueFrom, object valueTo)
                 {
                     this.whereParameter.Add(Enum.GetName(typeof(ColumnEnum), betweenColumn), valueFrom, valueTo);
                 }
                 public void  Add(ColumnEnum column, AccesoADatos.sqlEnum.OperandEnum operand,object value)
                 {
                     this.whereParameter.Add(Enum.GetName(typeof(ColumnEnum), column), operand, value);
                 }
                 public void Add(AccesoADatos.sqlEnum.ConjunctionEnum conjunction,ColumnEnum betweenColumn, AccesoADatos.sqlEnum.OperandEnum operand, object valueFrom, object valueTo)
                 {
                     this.whereParameter.Add(conjunction, Enum.GetName(typeof(ColumnEnum), betweenColumn), valueFrom, valueTo);
                 }
                 public void Add(AccesoADatos.sqlEnum.ConjunctionEnum conjunction,ColumnEnum column, AccesoADatos.sqlEnum.OperandEnum operand, object value)
                 {
                     this.whereParameter.Add(conjunction, Enum.GetName(typeof(ColumnEnum), column), operand, value);
                 }
                 public void Clear()
                 {
                     this.whereParameter.Clear();
                 }
                 public long Count
                 {
                     get {
                         return this.whereParameter.Count;
                     }
                 }
            }
            public class CustomOrderByParameter : OrderByParameter {
                 internal OrderByParameter orderByParameter = new OrderByParameter();
                 public void Add(ColumnEnum column, AccesoADatos.sqlEnum.DirEnum direction = AccesoADatos.sqlEnum.DirEnum.ASC)
                 {
                     this.orderByParameter.Add(Enum.GetName(typeof(ColumnEnum), column), direction);
                 }
            }
            public class CustomGroupByParameter : GroupByParameter {
                 internal GroupByParameter groupByParameter = new GroupByParameter();
                 public void Add(ColumnEnum column)
                 {
                     this.groupByParameter.Add(Enum.GetName(typeof(ColumnEnum), column));
                 }
            }
        } // class Continente
	} //namespace AccesoADatos.Business.Relations.dbo
	namespace AccesoADatos.Business.Relations.dbo {
	    /// <summary>
	    /// 
	    /// </summary>
		public class Log : RelationsDataHandler
		{
				public enum ColumnEnum : int
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
			   protected List<Entities.Relations.dbo.Log> _cacheItemList = new List<Entities.Relations.dbo.Log>();
			   protected List<Entities.Relations.dbo.Log> _entities = null;
            public new CustomWhereParameter Where { get; set; }
            public new CustomOrderByParameter OrderByParameter { get; set; }
            public new CustomGroupByParameter GroupByParameter { get; set; }
            public new CustomAggregateParameter AggregateParameter { get; set; }
            public Log() : base()
            {
                base._dataItem = new Entities.Relations.dbo.Log();
                Where = new CustomWhereParameter();
                OrderByParameter = new CustomOrderByParameter();
                GroupByParameter = new CustomGroupByParameter();
            }
            public class CustomAggregateParameter : AggregateParameter
            {
                 internal AggregateParameter aggregateParameter = new AggregateParameter();
                 public void Add(AccesoADatos.sqlEnum.FunctionEnum functionEnum, ColumnEnum column)
                     {
                         this.aggregateParameter.Add(functionEnum, Enum.GetName(typeof(ColumnEnum), column));
                     }
            }
			// Adds to a memory cache to hold pending transactions
			public void AddToCache(Entities.Relations.dbo.Log item)
			{
				_cacheItemList.Add(item);
			}
			public void UpdateCache()
			{
                this.BeginTransaction();
				foreach(IDataItem item in _cacheItemList)
					base.Add(item);
				this.EndTransaction(true);
			}
			// Method that accepts arguments corresponding to fields (Those wich aren´t identity.)
         /// <summary>
         /// Log Add Method
         /// </summary>
         /// <param name='TipoId'></param>
         /// <param name='AplicacionId'></param>
         /// <param name='Fecha'></param>
         /// <param name='Descripcion'></param>
         /// <param name='Detalle'></param>
         /// <param name='Modulo'></param>
         /// <param name='Metodo'></param>
         /// <param name='UsuarioId'></param>
         /// <returns>Entities.Relations.dbo.Log</returns>
			public Entities.Relations.dbo.Log Add(Int64 TipoId,Int64 AplicacionId,DateTime Fecha,String Descripcion,String Detalle,String Modulo,String Metodo,Int64 UsuarioId) 
			{
			  return (Entities.Relations.dbo.Log)base.Add(new Entities.Relations.dbo.Log(TipoId,AplicacionId,Fecha,Descripcion,Detalle,Modulo,Metodo,UsuarioId));
			}
            public new List<Entities.Relations.dbo.Log> Items()
            {
                RelationsDataHandler dh =  new RelationsDataHandler(this._dataItem);
                dh.WhereParameter = this.Where.whereParameter;
                dh.OrderByParameter = this.OrderByParameter.orderByParameter;
                dh.GroupByParameter = this.GroupByParameter.groupByParameter;
                _entities = dh.Items().Cast<Entities.Relations.dbo.Log>().ToList<Entities.Relations.dbo.Log>();
                return _entities;
            }
            /// <summary>
            /// Gets Entities.Relations.dbo.Log items by Pk
            /// </summary>
            /// <param name="Id"></param>
            /// <returns></returns>
            public List<Entities.Relations.dbo.Log> Items(Int64 Id)
            {
                this.Where.Clear();
                    if (this.Where.whereParameter.Count == 0)
                    {
                         this.Where.Add(ColumnEnum.Id, AccesoADatos.sqlEnum.OperandEnum.Equal, Id);
                    }
                    else
                    {
                         this.Where.Add(AccesoADatos.sqlEnum.ConjunctionEnum.AND,ColumnEnum.Id, AccesoADatos.sqlEnum.OperandEnum.Equal, Id);
                    }
                return this.Items();
            }
            /// <summary>
            /// Gets items with all fields
            /// </summary>
            /// <param name="Id"></param>
            /// <param name="TipoId"></param>
            /// <param name="AplicacionId"></param>
            /// <param name="Fecha"></param>
            /// <param name="Descripcion"></param>
            /// <param name="Detalle"></param>
            /// <param name="Modulo"></param>
            /// <param name="Metodo"></param>
            /// <param name="UsuarioId"></param>
            /// <returns></returns>
            public List<Entities.Relations.dbo.Log> Items(Int64? Id,Int64? TipoId,Int64? AplicacionId,DateTime? Fecha,String Descripcion,String Detalle,String Modulo,String Metodo,Int64? UsuarioId)
            {
                this.Where.whereParameter.Clear();
                if (Id != null)
                {
                    if (this.Where.whereParameter.Count == 0)
                    {
                        this.Where.Add(ColumnEnum.Id, AccesoADatos.sqlEnum.OperandEnum.Equal, Id);
                    }
                    else
                    {
                        this.Where.Add(AccesoADatos.sqlEnum.ConjunctionEnum.AND, ColumnEnum.Id, AccesoADatos.sqlEnum.OperandEnum.Equal, Id);
                    }
                   
                }
                if (TipoId != null)
                {
                    if (this.Where.whereParameter.Count == 0)
                    {
                        this.Where.Add(ColumnEnum.TipoId, AccesoADatos.sqlEnum.OperandEnum.Equal, TipoId);
                    }
                    else
                    {
                        this.Where.Add(AccesoADatos.sqlEnum.ConjunctionEnum.AND, ColumnEnum.TipoId, AccesoADatos.sqlEnum.OperandEnum.Equal, TipoId);
                    }
                   
                }
                if (AplicacionId != null)
                {
                    if (this.Where.whereParameter.Count == 0)
                    {
                        this.Where.Add(ColumnEnum.AplicacionId, AccesoADatos.sqlEnum.OperandEnum.Equal, AplicacionId);
                    }
                    else
                    {
                        this.Where.Add(AccesoADatos.sqlEnum.ConjunctionEnum.AND, ColumnEnum.AplicacionId, AccesoADatos.sqlEnum.OperandEnum.Equal, AplicacionId);
                    }
                   
                }
                if (Fecha != null)
                {
                    if (this.Where.whereParameter.Count == 0)
                    {
                        this.Where.Add(ColumnEnum.Fecha, AccesoADatos.sqlEnum.OperandEnum.Equal, Fecha);
                    }
                    else
                    {
                        this.Where.Add(AccesoADatos.sqlEnum.ConjunctionEnum.AND, ColumnEnum.Fecha, AccesoADatos.sqlEnum.OperandEnum.Equal, Fecha);
                    }
                   
                }
                if (Descripcion != null)
                {
                    if (this.Where.whereParameter.Count == 0)
                    {
                        this.Where.Add(ColumnEnum.Descripcion, AccesoADatos.sqlEnum.OperandEnum.Equal, Descripcion);
                    }
                    else
                    {
                        this.Where.Add(AccesoADatos.sqlEnum.ConjunctionEnum.AND, ColumnEnum.Descripcion, AccesoADatos.sqlEnum.OperandEnum.Equal, Descripcion);
                    }
                   
                }
                if (Detalle != null)
                {
                    if (this.Where.whereParameter.Count == 0)
                    {
                        this.Where.Add(ColumnEnum.Detalle, AccesoADatos.sqlEnum.OperandEnum.Equal, Detalle);
                    }
                    else
                    {
                        this.Where.Add(AccesoADatos.sqlEnum.ConjunctionEnum.AND, ColumnEnum.Detalle, AccesoADatos.sqlEnum.OperandEnum.Equal, Detalle);
                    }
                   
                }
                if (Modulo != null)
                {
                    if (this.Where.whereParameter.Count == 0)
                    {
                        this.Where.Add(ColumnEnum.Modulo, AccesoADatos.sqlEnum.OperandEnum.Equal, Modulo);
                    }
                    else
                    {
                        this.Where.Add(AccesoADatos.sqlEnum.ConjunctionEnum.AND, ColumnEnum.Modulo, AccesoADatos.sqlEnum.OperandEnum.Equal, Modulo);
                    }
                   
                }
                if (Metodo != null)
                {
                    if (this.Where.whereParameter.Count == 0)
                    {
                        this.Where.Add(ColumnEnum.Metodo, AccesoADatos.sqlEnum.OperandEnum.Equal, Metodo);
                    }
                    else
                    {
                        this.Where.Add(AccesoADatos.sqlEnum.ConjunctionEnum.AND, ColumnEnum.Metodo, AccesoADatos.sqlEnum.OperandEnum.Equal, Metodo);
                    }
                   
                }
                if (UsuarioId != null)
                {
                    if (this.Where.whereParameter.Count == 0)
                    {
                        this.Where.Add(ColumnEnum.UsuarioId, AccesoADatos.sqlEnum.OperandEnum.Equal, UsuarioId);
                    }
                    else
                    {
                        this.Where.Add(AccesoADatos.sqlEnum.ConjunctionEnum.AND, ColumnEnum.UsuarioId, AccesoADatos.sqlEnum.OperandEnum.Equal, UsuarioId);
                    }
                   
                }
                return this.Items();
            }
            public List<Entities.Relations.dbo.Log> Result 
            {
                get { return _entities; }
            }
            public Entities.Relations.dbo.Log Add(Entities.Relations.dbo.Log item)
            {
                RelationsDataHandler dh = new RelationsDataHandler(this._dataItem);
                return (Entities.Relations.dbo.Log)base.Add((IDataItem)item);
            }
            public Int64 Update(Entities.Relations.dbo.Log item)
            {
                return base.Update((IDataItem)item);
            }
            public Int64 Delete(Entities.Relations.dbo.Log item)
            {
                return base.DeleteItem((IDataItem)item);
            }
            /// Updates an instance of Entities.Relations.dbo.Log with parameters
            /// </summary>
            /// <param name="Id"></param>
            /// <param name="TipoId"></param>
            /// <param name="AplicacionId"></param>
            /// <param name="Fecha"></param>
            /// <param name="Descripcion"></param>
            /// <param name="Detalle"></param>
            /// <param name="Modulo"></param>
            /// <param name="Metodo"></param>
            /// <param name="UsuarioId"></param>
            /// <returns>Int64</returns>
            public Int64 Update(Int64 Id,Int64 TipoId,Int64 AplicacionId,DateTime Fecha,String Descripcion,String Detalle,String Modulo,String Metodo,Int64 UsuarioId)
            {
                 Entities.Tables.dbo.Log item = new Entities.Tables.dbo.Log();
                 item.Id = Id;
                 item.TipoId = TipoId;
                 item.AplicacionId = AplicacionId;
                 item.Fecha = Fecha;
                 item.Descripcion = Descripcion;
                 item.Detalle = Detalle;
                 item.Modulo = Modulo;
                 item.Metodo = Metodo;
                 item.UsuarioId = UsuarioId;

                return base.Update((IDataItem)item);
            }
            public class CustomWhereParameter : WhereParameter {
                 internal WhereParameter whereParameter = new WhereParameter();
                 public void Add(ColumnEnum betweenColumn, AccesoADatos.sqlEnum.OperandEnum operand, object valueFrom, object valueTo)
                 {
                     this.whereParameter.Add(Enum.GetName(typeof(ColumnEnum), betweenColumn), valueFrom, valueTo);
                 }
                 public void  Add(ColumnEnum column, AccesoADatos.sqlEnum.OperandEnum operand,object value)
                 {
                     this.whereParameter.Add(Enum.GetName(typeof(ColumnEnum), column), operand, value);
                 }
                 public void Add(AccesoADatos.sqlEnum.ConjunctionEnum conjunction,ColumnEnum betweenColumn, AccesoADatos.sqlEnum.OperandEnum operand, object valueFrom, object valueTo)
                 {
                     this.whereParameter.Add(conjunction, Enum.GetName(typeof(ColumnEnum), betweenColumn), valueFrom, valueTo);
                 }
                 public void Add(AccesoADatos.sqlEnum.ConjunctionEnum conjunction,ColumnEnum column, AccesoADatos.sqlEnum.OperandEnum operand, object value)
                 {
                     this.whereParameter.Add(conjunction, Enum.GetName(typeof(ColumnEnum), column), operand, value);
                 }
                 public void Clear()
                 {
                     this.whereParameter.Clear();
                 }
                 public long Count
                 {
                     get {
                         return this.whereParameter.Count;
                     }
                 }
            }
            public class CustomOrderByParameter : OrderByParameter {
                 internal OrderByParameter orderByParameter = new OrderByParameter();
                 public void Add(ColumnEnum column, AccesoADatos.sqlEnum.DirEnum direction = AccesoADatos.sqlEnum.DirEnum.ASC)
                 {
                     this.orderByParameter.Add(Enum.GetName(typeof(ColumnEnum), column), direction);
                 }
            }
            public class CustomGroupByParameter : GroupByParameter {
                 internal GroupByParameter groupByParameter = new GroupByParameter();
                 public void Add(ColumnEnum column)
                 {
                     this.groupByParameter.Add(Enum.GetName(typeof(ColumnEnum), column));
                 }
            }
        } // class Log
	} //namespace AccesoADatos.Business.Relations.dbo
	namespace AccesoADatos.Business.Relations.dbo {
	    /// <summary>
	    /// Es la tabla de paises
	    /// </summary>
		public class Pais : RelationsDataHandler
		{
				public enum ColumnEnum : int
                {
					Id,
					Nombre,
					ContinenteId
				}
			   protected List<Entities.Relations.dbo.Pais> _cacheItemList = new List<Entities.Relations.dbo.Pais>();
			   protected List<Entities.Relations.dbo.Pais> _entities = null;
            public new CustomWhereParameter Where { get; set; }
            public new CustomOrderByParameter OrderByParameter { get; set; }
            public new CustomGroupByParameter GroupByParameter { get; set; }
            public new CustomAggregateParameter AggregateParameter { get; set; }
            public Pais() : base()
            {
                base._dataItem = new Entities.Relations.dbo.Pais();
                Where = new CustomWhereParameter();
                OrderByParameter = new CustomOrderByParameter();
                GroupByParameter = new CustomGroupByParameter();
            }
            public class CustomAggregateParameter : AggregateParameter
            {
                 internal AggregateParameter aggregateParameter = new AggregateParameter();
                 public void Add(AccesoADatos.sqlEnum.FunctionEnum functionEnum, ColumnEnum column)
                     {
                         this.aggregateParameter.Add(functionEnum, Enum.GetName(typeof(ColumnEnum), column));
                     }
            }
			// Adds to a memory cache to hold pending transactions
			public void AddToCache(Entities.Relations.dbo.Pais item)
			{
				_cacheItemList.Add(item);
			}
			public void UpdateCache()
			{
                this.BeginTransaction();
				foreach(IDataItem item in _cacheItemList)
					base.Add(item);
				this.EndTransaction(true);
			}
			// Method that accepts arguments corresponding to fields (Those wich aren´t identity.)
         /// <summary>
         /// Pais Add Method
         /// </summary>
         /// <param name='Nombre'></param>
         /// <param name='AccesoADatos.Entities.Relations.dbo.Continente ContinenteId'></param>
         /// <returns>Entities.Relations.dbo.Pais</returns>
			public Entities.Relations.dbo.Pais Add(String Nombre,AccesoADatos.Entities.Relations.dbo.Continente ContinenteId) 
			{
			  return (Entities.Relations.dbo.Pais)base.Add(new Entities.Relations.dbo.Pais(Nombre,ContinenteId));
			}
            public new List<Entities.Relations.dbo.Pais> Items()
            {
                RelationsDataHandler dh =  new RelationsDataHandler(this._dataItem);
                dh.WhereParameter = this.Where.whereParameter;
                dh.OrderByParameter = this.OrderByParameter.orderByParameter;
                dh.GroupByParameter = this.GroupByParameter.groupByParameter;
                _entities = dh.Items().Cast<Entities.Relations.dbo.Pais>().ToList<Entities.Relations.dbo.Pais>();
                return _entities;
            }
            /// <summary>
            /// Gets Entities.Relations.dbo.Pais items by Pk
            /// </summary>
            /// <param name="Id"></param>
            /// <returns></returns>
            public List<Entities.Relations.dbo.Pais> Items(Int64 Id)
            {
                this.Where.Clear();
                    if (this.Where.whereParameter.Count == 0)
                    {
                         this.Where.Add(ColumnEnum.Id, AccesoADatos.sqlEnum.OperandEnum.Equal, Id);
                    }
                    else
                    {
                         this.Where.Add(AccesoADatos.sqlEnum.ConjunctionEnum.AND,ColumnEnum.Id, AccesoADatos.sqlEnum.OperandEnum.Equal, Id);
                    }
                return this.Items();
            }
            /// <summary>
            /// Gets items with all fields
            /// </summary>
            /// <param name="Id"></param>
            /// <param name="Nombre"></param>
            /// <param name="ContinenteId"></param>
            /// <returns></returns>
            public List<Entities.Relations.dbo.Pais> Items(Int64? Id,String Nombre,Int64? ContinenteId)
            {
                this.Where.whereParameter.Clear();
                if (Id != null)
                {
                    if (this.Where.whereParameter.Count == 0)
                    {
                        this.Where.Add(ColumnEnum.Id, AccesoADatos.sqlEnum.OperandEnum.Equal, Id);
                    }
                    else
                    {
                        this.Where.Add(AccesoADatos.sqlEnum.ConjunctionEnum.AND, ColumnEnum.Id, AccesoADatos.sqlEnum.OperandEnum.Equal, Id);
                    }
                   
                }
                if (Nombre != null)
                {
                    if (this.Where.whereParameter.Count == 0)
                    {
                        this.Where.Add(ColumnEnum.Nombre, AccesoADatos.sqlEnum.OperandEnum.Equal, Nombre);
                    }
                    else
                    {
                        this.Where.Add(AccesoADatos.sqlEnum.ConjunctionEnum.AND, ColumnEnum.Nombre, AccesoADatos.sqlEnum.OperandEnum.Equal, Nombre);
                    }
                   
                }
                if (ContinenteId != null)
                {
                    if (this.Where.whereParameter.Count == 0)
                    {
                        this.Where.Add(ColumnEnum.ContinenteId, AccesoADatos.sqlEnum.OperandEnum.Equal, ContinenteId);
                    }
                    else
                    {
                        this.Where.Add(AccesoADatos.sqlEnum.ConjunctionEnum.AND, ColumnEnum.ContinenteId, AccesoADatos.sqlEnum.OperandEnum.Equal, ContinenteId);
                    }
                   
                }
                return this.Items();
            }
            public List<Entities.Relations.dbo.Pais> Result 
            {
                get { return _entities; }
            }
            public Entities.Relations.dbo.Pais Add(Entities.Relations.dbo.Pais item)
            {
                RelationsDataHandler dh = new RelationsDataHandler(this._dataItem);
                return (Entities.Relations.dbo.Pais)base.Add((IDataItem)item);
            }
            public Int64 Update(Entities.Relations.dbo.Pais item)
            {
                return base.Update((IDataItem)item);
            }
            public Int64 Delete(Entities.Relations.dbo.Pais item)
            {
                return base.DeleteItem((IDataItem)item);
            }
            /// Updates an instance of Entities.Relations.dbo.Pais with parameters
            /// </summary>
            /// <param name="Id"></param>
            /// <param name="Nombre"></param>
            /// <param name="ContinenteId"></param>
            /// <returns>Int64</returns>
            public Int64 Update(Int64 Id,String Nombre,Int64 ContinenteId)
            {
                 Entities.Tables.dbo.Pais item = new Entities.Tables.dbo.Pais();
                 item.Id = Id;
                 item.Nombre = Nombre;
                 item.ContinenteId = ContinenteId;

                return base.Update((IDataItem)item);
            }
            public class CustomWhereParameter : WhereParameter {
                 internal WhereParameter whereParameter = new WhereParameter();
                 public void Add(ColumnEnum betweenColumn, AccesoADatos.sqlEnum.OperandEnum operand, object valueFrom, object valueTo)
                 {
                     this.whereParameter.Add(Enum.GetName(typeof(ColumnEnum), betweenColumn), valueFrom, valueTo);
                 }
                 public void  Add(ColumnEnum column, AccesoADatos.sqlEnum.OperandEnum operand,object value)
                 {
                     this.whereParameter.Add(Enum.GetName(typeof(ColumnEnum), column), operand, value);
                 }
                 public void Add(AccesoADatos.sqlEnum.ConjunctionEnum conjunction,ColumnEnum betweenColumn, AccesoADatos.sqlEnum.OperandEnum operand, object valueFrom, object valueTo)
                 {
                     this.whereParameter.Add(conjunction, Enum.GetName(typeof(ColumnEnum), betweenColumn), valueFrom, valueTo);
                 }
                 public void Add(AccesoADatos.sqlEnum.ConjunctionEnum conjunction,ColumnEnum column, AccesoADatos.sqlEnum.OperandEnum operand, object value)
                 {
                     this.whereParameter.Add(conjunction, Enum.GetName(typeof(ColumnEnum), column), operand, value);
                 }
                 public void Clear()
                 {
                     this.whereParameter.Clear();
                 }
                 public long Count
                 {
                     get {
                         return this.whereParameter.Count;
                     }
                 }
            }
            public class CustomOrderByParameter : OrderByParameter {
                 internal OrderByParameter orderByParameter = new OrderByParameter();
                 public void Add(ColumnEnum column, AccesoADatos.sqlEnum.DirEnum direction = AccesoADatos.sqlEnum.DirEnum.ASC)
                 {
                     this.orderByParameter.Add(Enum.GetName(typeof(ColumnEnum), column), direction);
                 }
            }
            public class CustomGroupByParameter : GroupByParameter {
                 internal GroupByParameter groupByParameter = new GroupByParameter();
                 public void Add(ColumnEnum column)
                 {
                     this.groupByParameter.Add(Enum.GetName(typeof(ColumnEnum), column));
                 }
            }
        } // class Pais
	} //namespace AccesoADatos.Business.Relations.dbo
	namespace AccesoADatos.Business.Relations.dbo {
	    /// <summary>
	    /// Tabla de Usuarios
	    /// </summary>
		public class Usuario : RelationsDataHandler
		{
				public enum ColumnEnum : int
                {
					Id,
					Nombre,
					Apellido,
					Edad,
					PaisId
				}
			   protected List<Entities.Relations.dbo.Usuario> _cacheItemList = new List<Entities.Relations.dbo.Usuario>();
			   protected List<Entities.Relations.dbo.Usuario> _entities = null;
            public new CustomWhereParameter Where { get; set; }
            public new CustomOrderByParameter OrderByParameter { get; set; }
            public new CustomGroupByParameter GroupByParameter { get; set; }
            public new CustomAggregateParameter AggregateParameter { get; set; }
            public Usuario() : base()
            {
                base._dataItem = new Entities.Relations.dbo.Usuario();
                Where = new CustomWhereParameter();
                OrderByParameter = new CustomOrderByParameter();
                GroupByParameter = new CustomGroupByParameter();
            }
            public class CustomAggregateParameter : AggregateParameter
            {
                 internal AggregateParameter aggregateParameter = new AggregateParameter();
                 public void Add(AccesoADatos.sqlEnum.FunctionEnum functionEnum, ColumnEnum column)
                     {
                         this.aggregateParameter.Add(functionEnum, Enum.GetName(typeof(ColumnEnum), column));
                     }
            }
			// Adds to a memory cache to hold pending transactions
			public void AddToCache(Entities.Relations.dbo.Usuario item)
			{
				_cacheItemList.Add(item);
			}
			public void UpdateCache()
			{
                this.BeginTransaction();
				foreach(IDataItem item in _cacheItemList)
					base.Add(item);
				this.EndTransaction(true);
			}
			// Method that accepts arguments corresponding to fields (Those wich aren´t identity.)
         /// <summary>
         /// Usuario Add Method
         /// </summary>
         /// <param name='Nombre'></param>
         /// <param name='Apellido'></param>
         /// <param name='Edad'></param>
         /// <param name='AccesoADatos.Entities.Relations.dbo.Pais PaisId'></param>
         /// <returns>Entities.Relations.dbo.Usuario</returns>
			public Entities.Relations.dbo.Usuario Add(String Nombre,String Apellido,Int16 Edad,AccesoADatos.Entities.Relations.dbo.Pais PaisId) 
			{
			  return (Entities.Relations.dbo.Usuario)base.Add(new Entities.Relations.dbo.Usuario(Nombre,Apellido,Edad,PaisId));
			}
            public new List<Entities.Relations.dbo.Usuario> Items()
            {
                RelationsDataHandler dh =  new RelationsDataHandler(this._dataItem);
                dh.WhereParameter = this.Where.whereParameter;
                dh.OrderByParameter = this.OrderByParameter.orderByParameter;
                dh.GroupByParameter = this.GroupByParameter.groupByParameter;
                _entities = dh.Items().Cast<Entities.Relations.dbo.Usuario>().ToList<Entities.Relations.dbo.Usuario>();
                return _entities;
            }
            /// <summary>
            /// Gets Entities.Relations.dbo.Usuario items by Pk
            /// </summary>
            /// <param name="Id"></param>
            /// <returns></returns>
            public List<Entities.Relations.dbo.Usuario> Items(Int64 Id)
            {
                this.Where.Clear();
                    if (this.Where.whereParameter.Count == 0)
                    {
                         this.Where.Add(ColumnEnum.Id, AccesoADatos.sqlEnum.OperandEnum.Equal, Id);
                    }
                    else
                    {
                         this.Where.Add(AccesoADatos.sqlEnum.ConjunctionEnum.AND,ColumnEnum.Id, AccesoADatos.sqlEnum.OperandEnum.Equal, Id);
                    }
                return this.Items();
            }
            /// <summary>
            /// Gets items with all fields
            /// </summary>
            /// <param name="Id"></param>
            /// <param name="Nombre"></param>
            /// <param name="Apellido"></param>
            /// <param name="Edad"></param>
            /// <param name="PaisId"></param>
            /// <returns></returns>
            public List<Entities.Relations.dbo.Usuario> Items(Int64? Id,String Nombre,String Apellido,Int16? Edad,Int64? PaisId)
            {
                this.Where.whereParameter.Clear();
                if (Id != null)
                {
                    if (this.Where.whereParameter.Count == 0)
                    {
                        this.Where.Add(ColumnEnum.Id, AccesoADatos.sqlEnum.OperandEnum.Equal, Id);
                    }
                    else
                    {
                        this.Where.Add(AccesoADatos.sqlEnum.ConjunctionEnum.AND, ColumnEnum.Id, AccesoADatos.sqlEnum.OperandEnum.Equal, Id);
                    }
                   
                }
                if (Nombre != null)
                {
                    if (this.Where.whereParameter.Count == 0)
                    {
                        this.Where.Add(ColumnEnum.Nombre, AccesoADatos.sqlEnum.OperandEnum.Equal, Nombre);
                    }
                    else
                    {
                        this.Where.Add(AccesoADatos.sqlEnum.ConjunctionEnum.AND, ColumnEnum.Nombre, AccesoADatos.sqlEnum.OperandEnum.Equal, Nombre);
                    }
                   
                }
                if (Apellido != null)
                {
                    if (this.Where.whereParameter.Count == 0)
                    {
                        this.Where.Add(ColumnEnum.Apellido, AccesoADatos.sqlEnum.OperandEnum.Equal, Apellido);
                    }
                    else
                    {
                        this.Where.Add(AccesoADatos.sqlEnum.ConjunctionEnum.AND, ColumnEnum.Apellido, AccesoADatos.sqlEnum.OperandEnum.Equal, Apellido);
                    }
                   
                }
                if (Edad != null)
                {
                    if (this.Where.whereParameter.Count == 0)
                    {
                        this.Where.Add(ColumnEnum.Edad, AccesoADatos.sqlEnum.OperandEnum.Equal, Edad);
                    }
                    else
                    {
                        this.Where.Add(AccesoADatos.sqlEnum.ConjunctionEnum.AND, ColumnEnum.Edad, AccesoADatos.sqlEnum.OperandEnum.Equal, Edad);
                    }
                   
                }
                if (PaisId != null)
                {
                    if (this.Where.whereParameter.Count == 0)
                    {
                        this.Where.Add(ColumnEnum.PaisId, AccesoADatos.sqlEnum.OperandEnum.Equal, PaisId);
                    }
                    else
                    {
                        this.Where.Add(AccesoADatos.sqlEnum.ConjunctionEnum.AND, ColumnEnum.PaisId, AccesoADatos.sqlEnum.OperandEnum.Equal, PaisId);
                    }
                   
                }
                return this.Items();
            }
            public List<Entities.Relations.dbo.Usuario> Result 
            {
                get { return _entities; }
            }
            public Entities.Relations.dbo.Usuario Add(Entities.Relations.dbo.Usuario item)
            {
                RelationsDataHandler dh = new RelationsDataHandler(this._dataItem);
                return (Entities.Relations.dbo.Usuario)base.Add((IDataItem)item);
            }
            public Int64 Update(Entities.Relations.dbo.Usuario item)
            {
                return base.Update((IDataItem)item);
            }
            public Int64 Delete(Entities.Relations.dbo.Usuario item)
            {
                return base.DeleteItem((IDataItem)item);
            }
            /// Updates an instance of Entities.Relations.dbo.Usuario with parameters
            /// </summary>
            /// <param name="Id"></param>
            /// <param name="Nombre"></param>
            /// <param name="Apellido"></param>
            /// <param name="Edad"></param>
            /// <param name="PaisId"></param>
            /// <returns>Int64</returns>
            public Int64 Update(Int64 Id,String Nombre,String Apellido,Int16 Edad,Int64 PaisId)
            {
                 Entities.Tables.dbo.Usuario item = new Entities.Tables.dbo.Usuario();
                 item.Id = Id;
                 item.Nombre = Nombre;
                 item.Apellido = Apellido;
                 item.Edad = Edad;
                 item.PaisId = PaisId;

                return base.Update((IDataItem)item);
            }
            public class CustomWhereParameter : WhereParameter {
                 internal WhereParameter whereParameter = new WhereParameter();
                 public void Add(ColumnEnum betweenColumn, AccesoADatos.sqlEnum.OperandEnum operand, object valueFrom, object valueTo)
                 {
                     this.whereParameter.Add(Enum.GetName(typeof(ColumnEnum), betweenColumn), valueFrom, valueTo);
                 }
                 public void  Add(ColumnEnum column, AccesoADatos.sqlEnum.OperandEnum operand,object value)
                 {
                     this.whereParameter.Add(Enum.GetName(typeof(ColumnEnum), column), operand, value);
                 }
                 public void Add(AccesoADatos.sqlEnum.ConjunctionEnum conjunction,ColumnEnum betweenColumn, AccesoADatos.sqlEnum.OperandEnum operand, object valueFrom, object valueTo)
                 {
                     this.whereParameter.Add(conjunction, Enum.GetName(typeof(ColumnEnum), betweenColumn), valueFrom, valueTo);
                 }
                 public void Add(AccesoADatos.sqlEnum.ConjunctionEnum conjunction,ColumnEnum column, AccesoADatos.sqlEnum.OperandEnum operand, object value)
                 {
                     this.whereParameter.Add(conjunction, Enum.GetName(typeof(ColumnEnum), column), operand, value);
                 }
                 public void Clear()
                 {
                     this.whereParameter.Clear();
                 }
                 public long Count
                 {
                     get {
                         return this.whereParameter.Count;
                     }
                 }
            }
            public class CustomOrderByParameter : OrderByParameter {
                 internal OrderByParameter orderByParameter = new OrderByParameter();
                 public void Add(ColumnEnum column, AccesoADatos.sqlEnum.DirEnum direction = AccesoADatos.sqlEnum.DirEnum.ASC)
                 {
                     this.orderByParameter.Add(Enum.GetName(typeof(ColumnEnum), column), direction);
                 }
            }
            public class CustomGroupByParameter : GroupByParameter {
                 internal GroupByParameter groupByParameter = new GroupByParameter();
                 public void Add(ColumnEnum column)
                 {
                     this.groupByParameter.Add(Enum.GetName(typeof(ColumnEnum), column));
                 }
            }
        } // class Usuario
	} //namespace AccesoADatos.Business.Relations.dbo
