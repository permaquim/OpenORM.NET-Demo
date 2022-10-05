using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
	namespace AccesoADatos.Business.Tables.dbo {
	    /// <summary>
	    /// 
	    /// </summary>
		public class Banco : DataHandler
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
         protected List<Entities.Tables.dbo.Banco> _entities = new List<Entities.Tables.dbo.Banco>();
         protected List<IDataItem> _cacheItemList = new List<IDataItem>();
         public WhereCollection Where = new WhereCollection();
         public OrderByCollection OrderBy = new OrderByCollection();
         public GroupByCollection GroupBy = new GroupByCollection();
         public AggregateCollection Aggregate { get; set; }
            public Banco() : base()
            {
                base._dataItem = new Entities.Tables.dbo.Banco();
            }
            public Banco(IDataHandler dataHandler)
                : base(dataHandler)
            {
                base._transaction = dataHandler.GetTransaction();
                base._dataItem = new Entities.Tables.dbo.Banco();
            }
            public class AggregateCollection : AggregateParameter
            {
                 internal AggregateParameter aggregateParameter = new AggregateParameter();
                 public void Add(AccesoADatos.sqlEnum.FunctionEnum functionEnum, ColumnEnum column)
                     {
                         this.aggregateParameter.Add(functionEnum, Enum.GetName(typeof(ColumnEnum), column));
                     }
            }
			// Adds to a memory cache to hold pending transactions
			public void AddToCache(Entities.Tables.dbo.Banco item)
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
         /// <returns>Entities.Tables.dbo.Banco</returns>
			public Entities.Tables.dbo.Banco Add(String Nombre,String Descripcion,String Codigo,Int64 PaisId,Boolean Habilitado,Int64 UsuarioCreacion,DateTime FechaCreacion,Int64? UsuarioModificacion,DateTime? FechaModificacion) 
			{
			  return (Entities.Tables.dbo.Banco)base.Add(new Entities.Tables.dbo.Banco(Nombre,Descripcion,Codigo,PaisId,Habilitado,UsuarioCreacion,FechaCreacion,UsuarioModificacion,FechaModificacion));
			}
            public new List<Entities.Tables.dbo.Banco> Items()
            {
                DataHandler dh =  new DataHandler(this._dataItem);
                dh.WhereParameter = this.Where;
                dh.OrderByParameter = this.OrderBy;
                dh.GroupByParameter = this.GroupBy;
                _entities = dh.Items().Cast<Entities.Tables.dbo.Banco>().ToList<Entities.Tables.dbo.Banco>();
                return _entities;
            }
            /// <summary>
            /// Gets Entities.Tables.dbo.Banco items by Pk
            /// </summary>
            /// <param name="Id"></param>
            /// <returns></returns>
            public List<Entities.Tables.dbo.Banco> Items(Int64 Id)
            {
                this.Where.Clear();
                    if (this.Where.Count == 0)
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
            /// Gets Entities.Tables.dbo.Banco items with parameters.
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
            public List<Entities.Tables.dbo.Banco> Items(Int64? Id,String Nombre,String Descripcion,String Codigo,Int64? PaisId,Boolean? Habilitado,Int64? UsuarioCreacion,DateTime? FechaCreacion,Int64? UsuarioModificacion,DateTime? FechaModificacion)
            {
                this.Where.Clear();
                if (Id != null)
                {
                    if (this.Where.Count == 0)
                    {
                        this.Where.Add(ColumnEnum.Id, sqlEnum.OperandEnum.Equal, Id);
                    }
                    else
                    {
                        this.Where.Add(sqlEnum.ConjunctionEnum.AND,ColumnEnum.Id, AccesoADatos.sqlEnum.OperandEnum.Equal, Id);
                    }
                   
                }
                if (Nombre != null)
                {
                    if (this.Where.Count == 0)
                    {
                        this.Where.Add(ColumnEnum.Nombre, sqlEnum.OperandEnum.Equal, Nombre);
                    }
                    else
                    {
                        this.Where.Add(sqlEnum.ConjunctionEnum.AND,ColumnEnum.Nombre, AccesoADatos.sqlEnum.OperandEnum.Equal, Nombre);
                    }
                   
                }
                if (Descripcion != null)
                {
                    if (this.Where.Count == 0)
                    {
                        this.Where.Add(ColumnEnum.Descripcion, sqlEnum.OperandEnum.Equal, Descripcion);
                    }
                    else
                    {
                        this.Where.Add(sqlEnum.ConjunctionEnum.AND,ColumnEnum.Descripcion, AccesoADatos.sqlEnum.OperandEnum.Equal, Descripcion);
                    }
                   
                }
                if (Codigo != null)
                {
                    if (this.Where.Count == 0)
                    {
                        this.Where.Add(ColumnEnum.Codigo, sqlEnum.OperandEnum.Equal, Codigo);
                    }
                    else
                    {
                        this.Where.Add(sqlEnum.ConjunctionEnum.AND,ColumnEnum.Codigo, AccesoADatos.sqlEnum.OperandEnum.Equal, Codigo);
                    }
                   
                }
                if (PaisId != null)
                {
                    if (this.Where.Count == 0)
                    {
                        this.Where.Add(ColumnEnum.PaisId, sqlEnum.OperandEnum.Equal, PaisId);
                    }
                    else
                    {
                        this.Where.Add(sqlEnum.ConjunctionEnum.AND,ColumnEnum.PaisId, AccesoADatos.sqlEnum.OperandEnum.Equal, PaisId);
                    }
                   
                }
                if (Habilitado != null)
                {
                    if (this.Where.Count == 0)
                    {
                        this.Where.Add(ColumnEnum.Habilitado, sqlEnum.OperandEnum.Equal, Habilitado);
                    }
                    else
                    {
                        this.Where.Add(sqlEnum.ConjunctionEnum.AND,ColumnEnum.Habilitado, AccesoADatos.sqlEnum.OperandEnum.Equal, Habilitado);
                    }
                   
                }
                if (UsuarioCreacion != null)
                {
                    if (this.Where.Count == 0)
                    {
                        this.Where.Add(ColumnEnum.UsuarioCreacion, sqlEnum.OperandEnum.Equal, UsuarioCreacion);
                    }
                    else
                    {
                        this.Where.Add(sqlEnum.ConjunctionEnum.AND,ColumnEnum.UsuarioCreacion, AccesoADatos.sqlEnum.OperandEnum.Equal, UsuarioCreacion);
                    }
                   
                }
                if (FechaCreacion != null)
                {
                    if (this.Where.Count == 0)
                    {
                        this.Where.Add(ColumnEnum.FechaCreacion, sqlEnum.OperandEnum.Equal, FechaCreacion);
                    }
                    else
                    {
                        this.Where.Add(sqlEnum.ConjunctionEnum.AND,ColumnEnum.FechaCreacion, AccesoADatos.sqlEnum.OperandEnum.Equal, FechaCreacion);
                    }
                   
                }
                if (UsuarioModificacion != null)
                {
                    if (this.Where.Count == 0)
                    {
                        this.Where.Add(ColumnEnum.UsuarioModificacion, sqlEnum.OperandEnum.Equal, UsuarioModificacion);
                    }
                    else
                    {
                        this.Where.Add(sqlEnum.ConjunctionEnum.AND,ColumnEnum.UsuarioModificacion, AccesoADatos.sqlEnum.OperandEnum.Equal, UsuarioModificacion);
                    }
                   
                }
                if (FechaModificacion != null)
                {
                    if (this.Where.Count == 0)
                    {
                        this.Where.Add(ColumnEnum.FechaModificacion, sqlEnum.OperandEnum.Equal, FechaModificacion);
                    }
                    else
                    {
                        this.Where.Add(sqlEnum.ConjunctionEnum.AND,ColumnEnum.FechaModificacion, AccesoADatos.sqlEnum.OperandEnum.Equal, FechaModificacion);
                    }
                   
                }
                return this.Items();
            }
            /// <summary>
            /// Adds an instance of Entities.Tables.dbo.Banco
            /// </summary>
            /// <param name="item"></param>
            /// <returns></returns>
            public Entities.Tables.dbo.Banco Add(Entities.Tables.dbo.Banco item)
            {
                return (Entities.Tables.dbo.Banco)base.Add((IDataItem)item);
            }
            /// <summary>
            /// Adds or updates an instance of Entities.Tables.dbo.Banco
            /// </summary>
            /// <param name="item"></param>
            /// <returns></returns>
            public Entities.Tables.dbo.Banco AddOrUpdate(Entities.Tables.dbo.Banco item)
            {
                 if (Items(item.Id).Count == 0)
                 {
                     return (Entities.Tables.dbo.Banco)base.Add((IDataItem)item);
                 }
                 else
                 {
                     Update(item);
                     return item;
                 }
             }
            /// <summary>
            /// Updates an instance of Entities.Tables.dbo.Banco
            /// </summary>
            /// <param name="item"></param>
            /// <returns><Int64/returns>
            public Int64 Update(Entities.Tables.dbo.Banco item)
            {
                return base.Update((IDataItem)item);
            }
            /// Updates an instance of Entities.Tables.dbo.Banco with parameters
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
            public Int64 Update(Int64 id,String nombre,String descripcion,String codigo,Int64 paisid,Boolean habilitado,Int64 usuariocreacion,DateTime fechacreacion,Int64? usuariomodificacion,DateTime? fechamodificacion)
            {
                return base.Update((IDataItem) new Entities.Tables.dbo.Banco {Id = id,Nombre = nombre,Descripcion = descripcion,Codigo = codigo,PaisId = paisid,Habilitado = habilitado,UsuarioCreacion = usuariocreacion,FechaCreacion = fechacreacion,UsuarioModificacion = usuariomodificacion,FechaModificacion = fechamodificacion});
            }
            /// <summary>
            /// Deletes an instance of Entities.Tables.dbo.Banco
            /// </summary>
            /// <param name="item"></param>
            /// <returns></returns>
            public Int64 Delete(Entities.Tables.dbo.Banco item)
            {
                return base.DeleteItem((IDataItem)item);
            }
            /// <summary>
            /// Deletes Entities.Tables.dbo.Banco with where conditions
            /// </summary>
            /// <returns></returns>
            public new Int64 Delete()
            {
                DataHandler dh =  new DataHandler(this._dataItem);
                dh.WhereParameter = this.Where;
                dh.OrderByParameter = this.OrderBy;
                dh.GroupByParameter = this.GroupBy;
                return dh.Delete();
            }
            /// <summary>
            /// Deletes by Pks
            /// </summary>
            /// <returns></returns>
            public Int64 Delete(Int64 id)
            {
                return base.DeleteItem((IDataItem) new Entities.Tables.dbo.Banco {Id = id});
            }
            /// <summary>
            /// Holds last Items() executed.
            /// </summary>
            /// <returns>Last Items()</returns>
            public List<Entities.Tables.dbo.Banco> Result
            {
                get{return _entities;}
            }
            public class WhereCollection : WhereParameter {
                 public void Add(ColumnEnum betweenColumn, AccesoADatos.sqlEnum.OperandEnum operand, object valueFrom, object valueTo)
                 {
                     base.Add(Enum.GetName(typeof(ColumnEnum), betweenColumn), valueFrom, valueTo);
                 }
                 public void  Add(ColumnEnum column, AccesoADatos.sqlEnum.OperandEnum operand,object value)
                 {
                     base.Add(Enum.GetName(typeof(ColumnEnum), column), operand, value);
                 }
                 public void Add(AccesoADatos.sqlEnum.ConjunctionEnum conjunction,ColumnEnum betweenColumn, AccesoADatos.sqlEnum.OperandEnum operand, object valueFrom, object valueTo)
                 {
                     base.Add(conjunction, Enum.GetName(typeof(ColumnEnum), betweenColumn), valueFrom, valueTo);
                 }
                 public void AddOperand(AccesoADatos.sqlEnum.ConjunctionEnum Conjunction)
                 {
                     base.AddConjunction(Conjunction);
                 }
                 public void OpenParentheses()
                 {
                     base.OpenParentheses();
                 }
                 public void CloseParentheses()
                 {
                     base.CloseParentheses();
                 }
                 public void Add(AccesoADatos.sqlEnum.ConjunctionEnum conjunction,ColumnEnum column, AccesoADatos.sqlEnum.OperandEnum operand, object value)
                 {
                     base.Add(conjunction, Enum.GetName(typeof(ColumnEnum), column), operand, value);
                 }
                 public new void Clear()
                 {
                     base.Clear();
                 }
                 public new long Count
                 {
                     get {
                         return base.Count;
                     }
                 }
            }
            public class OrderByCollection : OrderByParameter {
                 public void Add(ColumnEnum column, AccesoADatos.sqlEnum.DirEnum direction = AccesoADatos.sqlEnum.DirEnum.ASC)
                 {
                     base.Add(Enum.GetName(typeof(ColumnEnum), column), direction);
                 }
            }
            public class GroupByCollection : GroupByParameter {
                 public void Add(ColumnEnum column)
                 {
                     base.Add(Enum.GetName(typeof(ColumnEnum), column));
                 }
            }
        } // class Banco
	} //namespace AccesoADatos.Business.Tables.dbo
	namespace AccesoADatos.Business.Tables.dbo {
	    /// <summary>
	    /// 
	    /// </summary>
		public class Continente : DataHandler
		{
				public enum ColumnEnum : int
                {
					Id,
					Nombre
				}
         protected List<Entities.Tables.dbo.Continente> _entities = new List<Entities.Tables.dbo.Continente>();
         protected List<IDataItem> _cacheItemList = new List<IDataItem>();
         public WhereCollection Where = new WhereCollection();
         public OrderByCollection OrderBy = new OrderByCollection();
         public GroupByCollection GroupBy = new GroupByCollection();
         public AggregateCollection Aggregate { get; set; }
            public Continente() : base()
            {
                base._dataItem = new Entities.Tables.dbo.Continente();
            }
            public Continente(IDataHandler dataHandler)
                : base(dataHandler)
            {
                base._transaction = dataHandler.GetTransaction();
                base._dataItem = new Entities.Tables.dbo.Continente();
            }
            public class AggregateCollection : AggregateParameter
            {
                 internal AggregateParameter aggregateParameter = new AggregateParameter();
                 public void Add(AccesoADatos.sqlEnum.FunctionEnum functionEnum, ColumnEnum column)
                     {
                         this.aggregateParameter.Add(functionEnum, Enum.GetName(typeof(ColumnEnum), column));
                     }
            }
			// Adds to a memory cache to hold pending transactions
			public void AddToCache(Entities.Tables.dbo.Continente item)
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
         /// <returns>Entities.Tables.dbo.Continente</returns>
			public Entities.Tables.dbo.Continente Add(String Nombre) 
			{
			  return (Entities.Tables.dbo.Continente)base.Add(new Entities.Tables.dbo.Continente(Nombre));
			}
            public new List<Entities.Tables.dbo.Continente> Items()
            {
                DataHandler dh =  new DataHandler(this._dataItem);
                dh.WhereParameter = this.Where;
                dh.OrderByParameter = this.OrderBy;
                dh.GroupByParameter = this.GroupBy;
                _entities = dh.Items().Cast<Entities.Tables.dbo.Continente>().ToList<Entities.Tables.dbo.Continente>();
                return _entities;
            }
            /// <summary>
            /// Gets Entities.Tables.dbo.Continente items by Pk
            /// </summary>
            /// <param name="Id"></param>
            /// <returns></returns>
            public List<Entities.Tables.dbo.Continente> Items(Int64 Id)
            {
                this.Where.Clear();
                    if (this.Where.Count == 0)
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
            /// Gets Entities.Tables.dbo.Continente items with parameters.
            /// </summary>
            /// <param name="Id"></param>
            /// <param name="Nombre"></param>
            /// <returns></returns>
            public List<Entities.Tables.dbo.Continente> Items(Int64? Id,String Nombre)
            {
                this.Where.Clear();
                if (Id != null)
                {
                    if (this.Where.Count == 0)
                    {
                        this.Where.Add(ColumnEnum.Id, sqlEnum.OperandEnum.Equal, Id);
                    }
                    else
                    {
                        this.Where.Add(sqlEnum.ConjunctionEnum.AND,ColumnEnum.Id, AccesoADatos.sqlEnum.OperandEnum.Equal, Id);
                    }
                   
                }
                if (Nombre != null)
                {
                    if (this.Where.Count == 0)
                    {
                        this.Where.Add(ColumnEnum.Nombre, sqlEnum.OperandEnum.Equal, Nombre);
                    }
                    else
                    {
                        this.Where.Add(sqlEnum.ConjunctionEnum.AND,ColumnEnum.Nombre, AccesoADatos.sqlEnum.OperandEnum.Equal, Nombre);
                    }
                   
                }
                return this.Items();
            }
            /// <summary>
            /// Adds an instance of Entities.Tables.dbo.Continente
            /// </summary>
            /// <param name="item"></param>
            /// <returns></returns>
            public Entities.Tables.dbo.Continente Add(Entities.Tables.dbo.Continente item)
            {
                return (Entities.Tables.dbo.Continente)base.Add((IDataItem)item);
            }
            /// <summary>
            /// Adds or updates an instance of Entities.Tables.dbo.Continente
            /// </summary>
            /// <param name="item"></param>
            /// <returns></returns>
            public Entities.Tables.dbo.Continente AddOrUpdate(Entities.Tables.dbo.Continente item)
            {
                 if (Items(item.Id).Count == 0)
                 {
                     return (Entities.Tables.dbo.Continente)base.Add((IDataItem)item);
                 }
                 else
                 {
                     Update(item);
                     return item;
                 }
             }
            /// <summary>
            /// Updates an instance of Entities.Tables.dbo.Continente
            /// </summary>
            /// <param name="item"></param>
            /// <returns><Int64/returns>
            public Int64 Update(Entities.Tables.dbo.Continente item)
            {
                return base.Update((IDataItem)item);
            }
            /// Updates an instance of Entities.Tables.dbo.Continente with parameters
            /// </summary>
            /// <param name="Id"></param>
            /// <param name="Nombre"></param>
            /// <returns>Int64</returns>
            public Int64 Update(Int64 id,String nombre)
            {
                return base.Update((IDataItem) new Entities.Tables.dbo.Continente {Id = id,Nombre = nombre});
            }
            /// <summary>
            /// Deletes an instance of Entities.Tables.dbo.Continente
            /// </summary>
            /// <param name="item"></param>
            /// <returns></returns>
            public Int64 Delete(Entities.Tables.dbo.Continente item)
            {
                return base.DeleteItem((IDataItem)item);
            }
            /// <summary>
            /// Deletes Entities.Tables.dbo.Continente with where conditions
            /// </summary>
            /// <returns></returns>
            public new Int64 Delete()
            {
                DataHandler dh =  new DataHandler(this._dataItem);
                dh.WhereParameter = this.Where;
                dh.OrderByParameter = this.OrderBy;
                dh.GroupByParameter = this.GroupBy;
                return dh.Delete();
            }
            /// <summary>
            /// Deletes by Pks
            /// </summary>
            /// <returns></returns>
            public Int64 Delete(Int64 id)
            {
                return base.DeleteItem((IDataItem) new Entities.Tables.dbo.Continente {Id = id});
            }
            /// <summary>
            /// Holds last Items() executed.
            /// </summary>
            /// <returns>Last Items()</returns>
            public List<Entities.Tables.dbo.Continente> Result
            {
                get{return _entities;}
            }
            public class WhereCollection : WhereParameter {
                 public void Add(ColumnEnum betweenColumn, AccesoADatos.sqlEnum.OperandEnum operand, object valueFrom, object valueTo)
                 {
                     base.Add(Enum.GetName(typeof(ColumnEnum), betweenColumn), valueFrom, valueTo);
                 }
                 public void  Add(ColumnEnum column, AccesoADatos.sqlEnum.OperandEnum operand,object value)
                 {
                     base.Add(Enum.GetName(typeof(ColumnEnum), column), operand, value);
                 }
                 public void Add(AccesoADatos.sqlEnum.ConjunctionEnum conjunction,ColumnEnum betweenColumn, AccesoADatos.sqlEnum.OperandEnum operand, object valueFrom, object valueTo)
                 {
                     base.Add(conjunction, Enum.GetName(typeof(ColumnEnum), betweenColumn), valueFrom, valueTo);
                 }
                 public void AddOperand(AccesoADatos.sqlEnum.ConjunctionEnum Conjunction)
                 {
                     base.AddConjunction(Conjunction);
                 }
                 public void OpenParentheses()
                 {
                     base.OpenParentheses();
                 }
                 public void CloseParentheses()
                 {
                     base.CloseParentheses();
                 }
                 public void Add(AccesoADatos.sqlEnum.ConjunctionEnum conjunction,ColumnEnum column, AccesoADatos.sqlEnum.OperandEnum operand, object value)
                 {
                     base.Add(conjunction, Enum.GetName(typeof(ColumnEnum), column), operand, value);
                 }
                 public new void Clear()
                 {
                     base.Clear();
                 }
                 public new long Count
                 {
                     get {
                         return base.Count;
                     }
                 }
            }
            public class OrderByCollection : OrderByParameter {
                 public void Add(ColumnEnum column, AccesoADatos.sqlEnum.DirEnum direction = AccesoADatos.sqlEnum.DirEnum.ASC)
                 {
                     base.Add(Enum.GetName(typeof(ColumnEnum), column), direction);
                 }
            }
            public class GroupByCollection : GroupByParameter {
                 public void Add(ColumnEnum column)
                 {
                     base.Add(Enum.GetName(typeof(ColumnEnum), column));
                 }
            }
        } // class Continente
	} //namespace AccesoADatos.Business.Tables.dbo
	namespace AccesoADatos.Business.Tables.dbo {
	    /// <summary>
	    /// 
	    /// </summary>
		public class Log : DataHandler
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
         protected List<Entities.Tables.dbo.Log> _entities = new List<Entities.Tables.dbo.Log>();
         protected List<IDataItem> _cacheItemList = new List<IDataItem>();
         public WhereCollection Where = new WhereCollection();
         public OrderByCollection OrderBy = new OrderByCollection();
         public GroupByCollection GroupBy = new GroupByCollection();
         public AggregateCollection Aggregate { get; set; }
            public Log() : base()
            {
                base._dataItem = new Entities.Tables.dbo.Log();
            }
            public Log(IDataHandler dataHandler)
                : base(dataHandler)
            {
                base._transaction = dataHandler.GetTransaction();
                base._dataItem = new Entities.Tables.dbo.Log();
            }
            public class AggregateCollection : AggregateParameter
            {
                 internal AggregateParameter aggregateParameter = new AggregateParameter();
                 public void Add(AccesoADatos.sqlEnum.FunctionEnum functionEnum, ColumnEnum column)
                     {
                         this.aggregateParameter.Add(functionEnum, Enum.GetName(typeof(ColumnEnum), column));
                     }
            }
			// Adds to a memory cache to hold pending transactions
			public void AddToCache(Entities.Tables.dbo.Log item)
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
         /// <returns>Entities.Tables.dbo.Log</returns>
			public Entities.Tables.dbo.Log Add(Int64 TipoId,Int64 AplicacionId,DateTime Fecha,String Descripcion,String Detalle,String Modulo,String Metodo,Int64 UsuarioId) 
			{
			  return (Entities.Tables.dbo.Log)base.Add(new Entities.Tables.dbo.Log(TipoId,AplicacionId,Fecha,Descripcion,Detalle,Modulo,Metodo,UsuarioId));
			}
            public new List<Entities.Tables.dbo.Log> Items()
            {
                DataHandler dh =  new DataHandler(this._dataItem);
                dh.WhereParameter = this.Where;
                dh.OrderByParameter = this.OrderBy;
                dh.GroupByParameter = this.GroupBy;
                _entities = dh.Items().Cast<Entities.Tables.dbo.Log>().ToList<Entities.Tables.dbo.Log>();
                return _entities;
            }
            /// <summary>
            /// Gets Entities.Tables.dbo.Log items by Pk
            /// </summary>
            /// <param name="Id"></param>
            /// <returns></returns>
            public List<Entities.Tables.dbo.Log> Items(Int64 Id)
            {
                this.Where.Clear();
                    if (this.Where.Count == 0)
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
            /// Gets Entities.Tables.dbo.Log items with parameters.
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
            public List<Entities.Tables.dbo.Log> Items(Int64? Id,Int64? TipoId,Int64? AplicacionId,DateTime? Fecha,String Descripcion,String Detalle,String Modulo,String Metodo,Int64? UsuarioId)
            {
                this.Where.Clear();
                if (Id != null)
                {
                    if (this.Where.Count == 0)
                    {
                        this.Where.Add(ColumnEnum.Id, sqlEnum.OperandEnum.Equal, Id);
                    }
                    else
                    {
                        this.Where.Add(sqlEnum.ConjunctionEnum.AND,ColumnEnum.Id, AccesoADatos.sqlEnum.OperandEnum.Equal, Id);
                    }
                   
                }
                if (TipoId != null)
                {
                    if (this.Where.Count == 0)
                    {
                        this.Where.Add(ColumnEnum.TipoId, sqlEnum.OperandEnum.Equal, TipoId);
                    }
                    else
                    {
                        this.Where.Add(sqlEnum.ConjunctionEnum.AND,ColumnEnum.TipoId, AccesoADatos.sqlEnum.OperandEnum.Equal, TipoId);
                    }
                   
                }
                if (AplicacionId != null)
                {
                    if (this.Where.Count == 0)
                    {
                        this.Where.Add(ColumnEnum.AplicacionId, sqlEnum.OperandEnum.Equal, AplicacionId);
                    }
                    else
                    {
                        this.Where.Add(sqlEnum.ConjunctionEnum.AND,ColumnEnum.AplicacionId, AccesoADatos.sqlEnum.OperandEnum.Equal, AplicacionId);
                    }
                   
                }
                if (Fecha != null)
                {
                    if (this.Where.Count == 0)
                    {
                        this.Where.Add(ColumnEnum.Fecha, sqlEnum.OperandEnum.Equal, Fecha);
                    }
                    else
                    {
                        this.Where.Add(sqlEnum.ConjunctionEnum.AND,ColumnEnum.Fecha, AccesoADatos.sqlEnum.OperandEnum.Equal, Fecha);
                    }
                   
                }
                if (Descripcion != null)
                {
                    if (this.Where.Count == 0)
                    {
                        this.Where.Add(ColumnEnum.Descripcion, sqlEnum.OperandEnum.Equal, Descripcion);
                    }
                    else
                    {
                        this.Where.Add(sqlEnum.ConjunctionEnum.AND,ColumnEnum.Descripcion, AccesoADatos.sqlEnum.OperandEnum.Equal, Descripcion);
                    }
                   
                }
                if (Detalle != null)
                {
                    if (this.Where.Count == 0)
                    {
                        this.Where.Add(ColumnEnum.Detalle, sqlEnum.OperandEnum.Equal, Detalle);
                    }
                    else
                    {
                        this.Where.Add(sqlEnum.ConjunctionEnum.AND,ColumnEnum.Detalle, AccesoADatos.sqlEnum.OperandEnum.Equal, Detalle);
                    }
                   
                }
                if (Modulo != null)
                {
                    if (this.Where.Count == 0)
                    {
                        this.Where.Add(ColumnEnum.Modulo, sqlEnum.OperandEnum.Equal, Modulo);
                    }
                    else
                    {
                        this.Where.Add(sqlEnum.ConjunctionEnum.AND,ColumnEnum.Modulo, AccesoADatos.sqlEnum.OperandEnum.Equal, Modulo);
                    }
                   
                }
                if (Metodo != null)
                {
                    if (this.Where.Count == 0)
                    {
                        this.Where.Add(ColumnEnum.Metodo, sqlEnum.OperandEnum.Equal, Metodo);
                    }
                    else
                    {
                        this.Where.Add(sqlEnum.ConjunctionEnum.AND,ColumnEnum.Metodo, AccesoADatos.sqlEnum.OperandEnum.Equal, Metodo);
                    }
                   
                }
                if (UsuarioId != null)
                {
                    if (this.Where.Count == 0)
                    {
                        this.Where.Add(ColumnEnum.UsuarioId, sqlEnum.OperandEnum.Equal, UsuarioId);
                    }
                    else
                    {
                        this.Where.Add(sqlEnum.ConjunctionEnum.AND,ColumnEnum.UsuarioId, AccesoADatos.sqlEnum.OperandEnum.Equal, UsuarioId);
                    }
                   
                }
                return this.Items();
            }
            /// <summary>
            /// Adds an instance of Entities.Tables.dbo.Log
            /// </summary>
            /// <param name="item"></param>
            /// <returns></returns>
            public Entities.Tables.dbo.Log Add(Entities.Tables.dbo.Log item)
            {
                return (Entities.Tables.dbo.Log)base.Add((IDataItem)item);
            }
            /// <summary>
            /// Adds or updates an instance of Entities.Tables.dbo.Log
            /// </summary>
            /// <param name="item"></param>
            /// <returns></returns>
            public Entities.Tables.dbo.Log AddOrUpdate(Entities.Tables.dbo.Log item)
            {
                 if (Items(item.Id).Count == 0)
                 {
                     return (Entities.Tables.dbo.Log)base.Add((IDataItem)item);
                 }
                 else
                 {
                     Update(item);
                     return item;
                 }
             }
            /// <summary>
            /// Updates an instance of Entities.Tables.dbo.Log
            /// </summary>
            /// <param name="item"></param>
            /// <returns><Int64/returns>
            public Int64 Update(Entities.Tables.dbo.Log item)
            {
                return base.Update((IDataItem)item);
            }
            /// Updates an instance of Entities.Tables.dbo.Log with parameters
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
            public Int64 Update(Int64 id,Int64 tipoid,Int64 aplicacionid,DateTime fecha,String descripcion,String detalle,String modulo,String metodo,Int64 usuarioid)
            {
                return base.Update((IDataItem) new Entities.Tables.dbo.Log {Id = id,TipoId = tipoid,AplicacionId = aplicacionid,Fecha = fecha,Descripcion = descripcion,Detalle = detalle,Modulo = modulo,Metodo = metodo,UsuarioId = usuarioid});
            }
            /// <summary>
            /// Deletes an instance of Entities.Tables.dbo.Log
            /// </summary>
            /// <param name="item"></param>
            /// <returns></returns>
            public Int64 Delete(Entities.Tables.dbo.Log item)
            {
                return base.DeleteItem((IDataItem)item);
            }
            /// <summary>
            /// Deletes Entities.Tables.dbo.Log with where conditions
            /// </summary>
            /// <returns></returns>
            public new Int64 Delete()
            {
                DataHandler dh =  new DataHandler(this._dataItem);
                dh.WhereParameter = this.Where;
                dh.OrderByParameter = this.OrderBy;
                dh.GroupByParameter = this.GroupBy;
                return dh.Delete();
            }
            /// <summary>
            /// Deletes by Pks
            /// </summary>
            /// <returns></returns>
            public Int64 Delete(Int64 id)
            {
                return base.DeleteItem((IDataItem) new Entities.Tables.dbo.Log {Id = id});
            }
            /// <summary>
            /// Holds last Items() executed.
            /// </summary>
            /// <returns>Last Items()</returns>
            public List<Entities.Tables.dbo.Log> Result
            {
                get{return _entities;}
            }
            public class WhereCollection : WhereParameter {
                 public void Add(ColumnEnum betweenColumn, AccesoADatos.sqlEnum.OperandEnum operand, object valueFrom, object valueTo)
                 {
                     base.Add(Enum.GetName(typeof(ColumnEnum), betweenColumn), valueFrom, valueTo);
                 }
                 public void  Add(ColumnEnum column, AccesoADatos.sqlEnum.OperandEnum operand,object value)
                 {
                     base.Add(Enum.GetName(typeof(ColumnEnum), column), operand, value);
                 }
                 public void Add(AccesoADatos.sqlEnum.ConjunctionEnum conjunction,ColumnEnum betweenColumn, AccesoADatos.sqlEnum.OperandEnum operand, object valueFrom, object valueTo)
                 {
                     base.Add(conjunction, Enum.GetName(typeof(ColumnEnum), betweenColumn), valueFrom, valueTo);
                 }
                 public void AddOperand(AccesoADatos.sqlEnum.ConjunctionEnum Conjunction)
                 {
                     base.AddConjunction(Conjunction);
                 }
                 public void OpenParentheses()
                 {
                     base.OpenParentheses();
                 }
                 public void CloseParentheses()
                 {
                     base.CloseParentheses();
                 }
                 public void Add(AccesoADatos.sqlEnum.ConjunctionEnum conjunction,ColumnEnum column, AccesoADatos.sqlEnum.OperandEnum operand, object value)
                 {
                     base.Add(conjunction, Enum.GetName(typeof(ColumnEnum), column), operand, value);
                 }
                 public new void Clear()
                 {
                     base.Clear();
                 }
                 public new long Count
                 {
                     get {
                         return base.Count;
                     }
                 }
            }
            public class OrderByCollection : OrderByParameter {
                 public void Add(ColumnEnum column, AccesoADatos.sqlEnum.DirEnum direction = AccesoADatos.sqlEnum.DirEnum.ASC)
                 {
                     base.Add(Enum.GetName(typeof(ColumnEnum), column), direction);
                 }
            }
            public class GroupByCollection : GroupByParameter {
                 public void Add(ColumnEnum column)
                 {
                     base.Add(Enum.GetName(typeof(ColumnEnum), column));
                 }
            }
        } // class Log
	} //namespace AccesoADatos.Business.Tables.dbo
	namespace AccesoADatos.Business.Tables.dbo {
	    /// <summary>
	    /// Es la tabla de paises
	    /// </summary>
		public class Pais : DataHandler
		{
				public enum ColumnEnum : int
                {
					Id,
					Nombre,
					ContinenteId
				}
         protected List<Entities.Tables.dbo.Pais> _entities = new List<Entities.Tables.dbo.Pais>();
         protected List<IDataItem> _cacheItemList = new List<IDataItem>();
         public WhereCollection Where = new WhereCollection();
         public OrderByCollection OrderBy = new OrderByCollection();
         public GroupByCollection GroupBy = new GroupByCollection();
         public AggregateCollection Aggregate { get; set; }
            public Pais() : base()
            {
                base._dataItem = new Entities.Tables.dbo.Pais();
            }
            public Pais(IDataHandler dataHandler)
                : base(dataHandler)
            {
                base._transaction = dataHandler.GetTransaction();
                base._dataItem = new Entities.Tables.dbo.Pais();
            }
            public class AggregateCollection : AggregateParameter
            {
                 internal AggregateParameter aggregateParameter = new AggregateParameter();
                 public void Add(AccesoADatos.sqlEnum.FunctionEnum functionEnum, ColumnEnum column)
                     {
                         this.aggregateParameter.Add(functionEnum, Enum.GetName(typeof(ColumnEnum), column));
                     }
            }
			// Adds to a memory cache to hold pending transactions
			public void AddToCache(Entities.Tables.dbo.Pais item)
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
         /// <param name='ContinenteId'></param>
         /// <returns>Entities.Tables.dbo.Pais</returns>
			public Entities.Tables.dbo.Pais Add(String Nombre,Int64 ContinenteId) 
			{
			  return (Entities.Tables.dbo.Pais)base.Add(new Entities.Tables.dbo.Pais(Nombre,ContinenteId));
			}
            public new List<Entities.Tables.dbo.Pais> Items()
            {
                DataHandler dh =  new DataHandler(this._dataItem);
                dh.WhereParameter = this.Where;
                dh.OrderByParameter = this.OrderBy;
                dh.GroupByParameter = this.GroupBy;
                _entities = dh.Items().Cast<Entities.Tables.dbo.Pais>().ToList<Entities.Tables.dbo.Pais>();
                return _entities;
            }
            /// <summary>
            /// Gets Entities.Tables.dbo.Pais items by Pk
            /// </summary>
            /// <param name="Id"></param>
            /// <returns></returns>
            public List<Entities.Tables.dbo.Pais> Items(Int64 Id)
            {
                this.Where.Clear();
                    if (this.Where.Count == 0)
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
            /// Gets Entities.Tables.dbo.Pais items with parameters.
            /// </summary>
            /// <param name="Id"></param>
            /// <param name="Nombre"></param>
            /// <param name="ContinenteId"></param>
            /// <returns></returns>
            public List<Entities.Tables.dbo.Pais> Items(Int64? Id,String Nombre,Int64? ContinenteId)
            {
                this.Where.Clear();
                if (Id != null)
                {
                    if (this.Where.Count == 0)
                    {
                        this.Where.Add(ColumnEnum.Id, sqlEnum.OperandEnum.Equal, Id);
                    }
                    else
                    {
                        this.Where.Add(sqlEnum.ConjunctionEnum.AND,ColumnEnum.Id, AccesoADatos.sqlEnum.OperandEnum.Equal, Id);
                    }
                   
                }
                if (Nombre != null)
                {
                    if (this.Where.Count == 0)
                    {
                        this.Where.Add(ColumnEnum.Nombre, sqlEnum.OperandEnum.Equal, Nombre);
                    }
                    else
                    {
                        this.Where.Add(sqlEnum.ConjunctionEnum.AND,ColumnEnum.Nombre, AccesoADatos.sqlEnum.OperandEnum.Equal, Nombre);
                    }
                   
                }
                if (ContinenteId != null)
                {
                    if (this.Where.Count == 0)
                    {
                        this.Where.Add(ColumnEnum.ContinenteId, sqlEnum.OperandEnum.Equal, ContinenteId);
                    }
                    else
                    {
                        this.Where.Add(sqlEnum.ConjunctionEnum.AND,ColumnEnum.ContinenteId, AccesoADatos.sqlEnum.OperandEnum.Equal, ContinenteId);
                    }
                   
                }
                return this.Items();
            }
            /// <summary>
            /// Adds an instance of Entities.Tables.dbo.Pais
            /// </summary>
            /// <param name="item"></param>
            /// <returns></returns>
            public Entities.Tables.dbo.Pais Add(Entities.Tables.dbo.Pais item)
            {
                return (Entities.Tables.dbo.Pais)base.Add((IDataItem)item);
            }
            /// <summary>
            /// Adds or updates an instance of Entities.Tables.dbo.Pais
            /// </summary>
            /// <param name="item"></param>
            /// <returns></returns>
            public Entities.Tables.dbo.Pais AddOrUpdate(Entities.Tables.dbo.Pais item)
            {
                 if (Items(item.Id).Count == 0)
                 {
                     return (Entities.Tables.dbo.Pais)base.Add((IDataItem)item);
                 }
                 else
                 {
                     Update(item);
                     return item;
                 }
             }
            /// <summary>
            /// Updates an instance of Entities.Tables.dbo.Pais
            /// </summary>
            /// <param name="item"></param>
            /// <returns><Int64/returns>
            public Int64 Update(Entities.Tables.dbo.Pais item)
            {
                return base.Update((IDataItem)item);
            }
            /// Updates an instance of Entities.Tables.dbo.Pais with parameters
            /// </summary>
            /// <param name="Id"></param>
            /// <param name="Nombre"></param>
            /// <param name="ContinenteId"></param>
            /// <returns>Int64</returns>
            public Int64 Update(Int64 id,String nombre,Int64 continenteid)
            {
                return base.Update((IDataItem) new Entities.Tables.dbo.Pais {Id = id,Nombre = nombre,ContinenteId = continenteid});
            }
            /// <summary>
            /// Deletes an instance of Entities.Tables.dbo.Pais
            /// </summary>
            /// <param name="item"></param>
            /// <returns></returns>
            public Int64 Delete(Entities.Tables.dbo.Pais item)
            {
                return base.DeleteItem((IDataItem)item);
            }
            /// <summary>
            /// Deletes Entities.Tables.dbo.Pais with where conditions
            /// </summary>
            /// <returns></returns>
            public new Int64 Delete()
            {
                DataHandler dh =  new DataHandler(this._dataItem);
                dh.WhereParameter = this.Where;
                dh.OrderByParameter = this.OrderBy;
                dh.GroupByParameter = this.GroupBy;
                return dh.Delete();
            }
            /// <summary>
            /// Deletes by Pks
            /// </summary>
            /// <returns></returns>
            public Int64 Delete(Int64 id)
            {
                return base.DeleteItem((IDataItem) new Entities.Tables.dbo.Pais {Id = id});
            }
            /// <summary>
            /// Holds last Items() executed.
            /// </summary>
            /// <returns>Last Items()</returns>
            public List<Entities.Tables.dbo.Pais> Result
            {
                get{return _entities;}
            }
            public class WhereCollection : WhereParameter {
                 public void Add(ColumnEnum betweenColumn, AccesoADatos.sqlEnum.OperandEnum operand, object valueFrom, object valueTo)
                 {
                     base.Add(Enum.GetName(typeof(ColumnEnum), betweenColumn), valueFrom, valueTo);
                 }
                 public void  Add(ColumnEnum column, AccesoADatos.sqlEnum.OperandEnum operand,object value)
                 {
                     base.Add(Enum.GetName(typeof(ColumnEnum), column), operand, value);
                 }
                 public void Add(AccesoADatos.sqlEnum.ConjunctionEnum conjunction,ColumnEnum betweenColumn, AccesoADatos.sqlEnum.OperandEnum operand, object valueFrom, object valueTo)
                 {
                     base.Add(conjunction, Enum.GetName(typeof(ColumnEnum), betweenColumn), valueFrom, valueTo);
                 }
                 public void AddOperand(AccesoADatos.sqlEnum.ConjunctionEnum Conjunction)
                 {
                     base.AddConjunction(Conjunction);
                 }
                 public void OpenParentheses()
                 {
                     base.OpenParentheses();
                 }
                 public void CloseParentheses()
                 {
                     base.CloseParentheses();
                 }
                 public void Add(AccesoADatos.sqlEnum.ConjunctionEnum conjunction,ColumnEnum column, AccesoADatos.sqlEnum.OperandEnum operand, object value)
                 {
                     base.Add(conjunction, Enum.GetName(typeof(ColumnEnum), column), operand, value);
                 }
                 public new void Clear()
                 {
                     base.Clear();
                 }
                 public new long Count
                 {
                     get {
                         return base.Count;
                     }
                 }
            }
            public class OrderByCollection : OrderByParameter {
                 public void Add(ColumnEnum column, AccesoADatos.sqlEnum.DirEnum direction = AccesoADatos.sqlEnum.DirEnum.ASC)
                 {
                     base.Add(Enum.GetName(typeof(ColumnEnum), column), direction);
                 }
            }
            public class GroupByCollection : GroupByParameter {
                 public void Add(ColumnEnum column)
                 {
                     base.Add(Enum.GetName(typeof(ColumnEnum), column));
                 }
            }
        } // class Pais
	} //namespace AccesoADatos.Business.Tables.dbo
	namespace AccesoADatos.Business.Tables.dbo {
	    /// <summary>
	    /// Tabla de Usuarios
	    /// </summary>
		public class Usuario : DataHandler
		{
				public enum ColumnEnum : int
                {
					Id,
					Nombre,
					Apellido,
					Edad,
					PaisId
				}
         protected List<Entities.Tables.dbo.Usuario> _entities = new List<Entities.Tables.dbo.Usuario>();
         protected List<IDataItem> _cacheItemList = new List<IDataItem>();
         public WhereCollection Where = new WhereCollection();
         public OrderByCollection OrderBy = new OrderByCollection();
         public GroupByCollection GroupBy = new GroupByCollection();
         public AggregateCollection Aggregate { get; set; }
            public Usuario() : base()
            {
                base._dataItem = new Entities.Tables.dbo.Usuario();
            }
            public Usuario(IDataHandler dataHandler)
                : base(dataHandler)
            {
                base._transaction = dataHandler.GetTransaction();
                base._dataItem = new Entities.Tables.dbo.Usuario();
            }
            public class AggregateCollection : AggregateParameter
            {
                 internal AggregateParameter aggregateParameter = new AggregateParameter();
                 public void Add(AccesoADatos.sqlEnum.FunctionEnum functionEnum, ColumnEnum column)
                     {
                         this.aggregateParameter.Add(functionEnum, Enum.GetName(typeof(ColumnEnum), column));
                     }
            }
			// Adds to a memory cache to hold pending transactions
			public void AddToCache(Entities.Tables.dbo.Usuario item)
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
         /// <param name='PaisId'></param>
         /// <returns>Entities.Tables.dbo.Usuario</returns>
			public Entities.Tables.dbo.Usuario Add(String Nombre,String Apellido,Int16 Edad,Int64 PaisId) 
			{
			  return (Entities.Tables.dbo.Usuario)base.Add(new Entities.Tables.dbo.Usuario(Nombre,Apellido,Edad,PaisId));
			}
            public new List<Entities.Tables.dbo.Usuario> Items()
            {
                DataHandler dh =  new DataHandler(this._dataItem);
                dh.WhereParameter = this.Where;
                dh.OrderByParameter = this.OrderBy;
                dh.GroupByParameter = this.GroupBy;
                dh.Top( base._topSpec.Number,base._topSpec.IsPercent);
                _entities = dh.Items().Cast<Entities.Tables.dbo.Usuario>().ToList<Entities.Tables.dbo.Usuario>();
                return _entities;
            }
            /// <summary>
            /// Gets Entities.Tables.dbo.Usuario items by Pk
            /// </summary>
            /// <param name="Id"></param>
            /// <returns></returns>
            public List<Entities.Tables.dbo.Usuario> Items(Int64 Id)
            {
                this.Where.Clear();
                    if (this.Where.Count == 0)
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
            /// Gets Entities.Tables.dbo.Usuario items with parameters.
            /// </summary>
            /// <param name="Id"></param>
            /// <param name="Nombre"></param>
            /// <param name="Apellido"></param>
            /// <param name="Edad"></param>
            /// <param name="PaisId"></param>
            /// <returns></returns>
            public List<Entities.Tables.dbo.Usuario> Items(Int64? Id,String Nombre,String Apellido,Int16? Edad,Int64? PaisId)
            {
                this.Where.Clear();
                if (Id != null)
                {
                    if (this.Where.Count == 0)
                    {
                        this.Where.Add(ColumnEnum.Id, sqlEnum.OperandEnum.Equal, Id);
                    }
                    else
                    {
                        this.Where.Add(sqlEnum.ConjunctionEnum.AND,ColumnEnum.Id, AccesoADatos.sqlEnum.OperandEnum.Equal, Id);
                    }
                   
                }
                if (Nombre != null)
                {
                    if (this.Where.Count == 0)
                    {
                        this.Where.Add(ColumnEnum.Nombre, sqlEnum.OperandEnum.Equal, Nombre);
                    }
                    else
                    {
                        this.Where.Add(sqlEnum.ConjunctionEnum.AND,ColumnEnum.Nombre, AccesoADatos.sqlEnum.OperandEnum.Equal, Nombre);
                    }
                   
                }
                if (Apellido != null)
                {
                    if (this.Where.Count == 0)
                    {
                        this.Where.Add(ColumnEnum.Apellido, sqlEnum.OperandEnum.Equal, Apellido);
                    }
                    else
                    {
                        this.Where.Add(sqlEnum.ConjunctionEnum.AND,ColumnEnum.Apellido, AccesoADatos.sqlEnum.OperandEnum.Equal, Apellido);
                    }
                   
                }
                if (Edad != null)
                {
                    if (this.Where.Count == 0)
                    {
                        this.Where.Add(ColumnEnum.Edad, sqlEnum.OperandEnum.Equal, Edad);
                    }
                    else
                    {
                        this.Where.Add(sqlEnum.ConjunctionEnum.AND,ColumnEnum.Edad, AccesoADatos.sqlEnum.OperandEnum.Equal, Edad);
                    }
                   
                }
                if (PaisId != null)
                {
                    if (this.Where.Count == 0)
                    {
                        this.Where.Add(ColumnEnum.PaisId, sqlEnum.OperandEnum.Equal, PaisId);
                    }
                    else
                    {
                        this.Where.Add(sqlEnum.ConjunctionEnum.AND,ColumnEnum.PaisId, AccesoADatos.sqlEnum.OperandEnum.Equal, PaisId);
                    }
                   
                }
                return this.Items();
            }
            /// <summary>
            /// Adds an instance of Entities.Tables.dbo.Usuario
            /// </summary>
            /// <param name="item"></param>
            /// <returns></returns>
            public Entities.Tables.dbo.Usuario Add(Entities.Tables.dbo.Usuario item)
            {
                return (Entities.Tables.dbo.Usuario)base.Add((IDataItem)item);
            }
            /// <summary>
            /// Adds or updates an instance of Entities.Tables.dbo.Usuario
            /// </summary>
            /// <param name="item"></param>
            /// <returns></returns>
            public Entities.Tables.dbo.Usuario AddOrUpdate(Entities.Tables.dbo.Usuario item)
            {
                 if (Items(item.Id).Count == 0)
                 {
                     return (Entities.Tables.dbo.Usuario)base.Add((IDataItem)item);
                 }
                 else
                 {
                     Update(item);
                     return item;
                 }
             }
            /// <summary>
            /// Updates an instance of Entities.Tables.dbo.Usuario
            /// </summary>
            /// <param name="item"></param>
            /// <returns><Int64/returns>
            public Int64 Update(Entities.Tables.dbo.Usuario item)
            {
                return base.Update((IDataItem)item);
            }
            /// Updates an instance of Entities.Tables.dbo.Usuario with parameters
            /// </summary>
            /// <param name="Id"></param>
            /// <param name="Nombre"></param>
            /// <param name="Apellido"></param>
            /// <param name="Edad"></param>
            /// <param name="PaisId"></param>
            /// <returns>Int64</returns>
            public Int64 Update(Int64 id,String nombre,String apellido,Int16 edad,Int64 paisid)
            {
                return base.Update((IDataItem) new Entities.Tables.dbo.Usuario {Id = id,Nombre = nombre,Apellido = apellido,Edad = edad,PaisId = paisid});
            }
            /// <summary>
            /// Deletes an instance of Entities.Tables.dbo.Usuario
            /// </summary>
            /// <param name="item"></param>
            /// <returns></returns>
            public Int64 Delete(Entities.Tables.dbo.Usuario item)
            {
                return base.DeleteItem((IDataItem)item);
            }

            /// <summary>
            /// Deletes Entities.Tables.dbo.Usuario with where conditions
            /// </summary>
            /// <returns></returns>
            public new Int64 Delete()
            {
                DataHandler dh =  new DataHandler(this._dataItem);
                dh.WhereParameter = this.Where;
                dh.OrderByParameter = this.OrderBy;
                dh.GroupByParameter = this.GroupBy;
                return dh.Delete();
            }
            /// <summary>
            /// Deletes by Pks
            /// </summary>
            /// <returns></returns>
            public Int64 Delete(Int64 id)
            {
                return base.DeleteItem((IDataItem) new Entities.Tables.dbo.Usuario {Id = id});
            }
            /// <summary>
            /// Holds last Items() executed.
            /// </summary>
            /// <returns>Last Items()</returns>
            public List<Entities.Tables.dbo.Usuario> Result
            {
                get{return _entities;}
            }
            public class WhereCollection : WhereParameter {
                 public void Add(ColumnEnum betweenColumn, AccesoADatos.sqlEnum.OperandEnum operand, object valueFrom, object valueTo)
                 {
                     base.Add(Enum.GetName(typeof(ColumnEnum), betweenColumn), valueFrom, valueTo);
                 }
                 public void  Add(ColumnEnum column, AccesoADatos.sqlEnum.OperandEnum operand,object value)
                 {
                     base.Add(Enum.GetName(typeof(ColumnEnum), column), operand, value);
                 }
                 public void Add(AccesoADatos.sqlEnum.ConjunctionEnum conjunction,ColumnEnum betweenColumn, AccesoADatos.sqlEnum.OperandEnum operand, object valueFrom, object valueTo)
                 {
                     base.Add(conjunction, Enum.GetName(typeof(ColumnEnum), betweenColumn), valueFrom, valueTo);
                 }
                 public void AddOperand(AccesoADatos.sqlEnum.ConjunctionEnum Conjunction)
                 {
                     base.AddConjunction(Conjunction);
                 }
                 public void OpenParentheses()
                 {
                     base.OpenParentheses();
                 }
                 public void CloseParentheses()
                 {
                     base.CloseParentheses();
                 }
                 public void Add(AccesoADatos.sqlEnum.ConjunctionEnum conjunction,ColumnEnum column, AccesoADatos.sqlEnum.OperandEnum operand, object value)
                 {
                     base.Add(conjunction, Enum.GetName(typeof(ColumnEnum), column), operand, value);
                 }
                 public new void Clear()
                 {
                     base.Clear();
                 }
                 public new long Count
                 {
                     get {
                         return base.Count;
                     }
                 }
            }
            public class OrderByCollection : OrderByParameter {
                 public void Add(ColumnEnum column, AccesoADatos.sqlEnum.DirEnum direction = AccesoADatos.sqlEnum.DirEnum.ASC)
                 {
                     base.Add(Enum.GetName(typeof(ColumnEnum), column), direction);
                 }
            }
            public class GroupByCollection : GroupByParameter {
                 public void Add(ColumnEnum column)
                 {
                     base.Add(Enum.GetName(typeof(ColumnEnum), column));
                 }
            }
        } // class Usuario
	} //namespace AccesoADatos.Business.Tables.dbo
