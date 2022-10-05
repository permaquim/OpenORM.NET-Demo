using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
	namespace AccesoADatos.Business.Views.dbo {
	    /// <summary>
	    /// 
	    /// </summary>
		public class VistaUsuario : DataHandler
		{
				public enum ColumnEnum : int
                {
					Nombre,
					Apellido,
					Edad,
					NombrePais,
					ContinenteId,
					NombreContinente
				}
			protected List<IDataItem> _cacheItemList = new List<IDataItem>();
         public WhereCollection Where { get; set; }
         public OrderByCollection OrderBy { get; set; }
         public GroupByCollection GroupBy { get; set; }
         public AggregateCollection Aggregate { get; set; }
            public VistaUsuario() : base()
            {
                base._dataItem = new Entities.Views.dbo.VistaUsuario();
                Where = new WhereCollection();
                OrderBy = new OrderByCollection();
                GroupBy = new GroupByCollection();
            }
            public VistaUsuario(IDataHandler dataHandler)
                : base(dataHandler)
            {
                base._transaction = dataHandler.GetTransaction();
                base._dataItem = new Entities.Views.dbo.VistaUsuario();
                Where = new WhereCollection();
                OrderBy = new OrderByCollection();
                GroupBy = new GroupByCollection();
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
			public void AddToCache(Entities.Views.dbo.VistaUsuario item)
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
			public Entities.Views.dbo.VistaUsuario Add(String Nombre,String Apellido,Int16 Edad,String NombrePais,Int64 ContinenteId,String NombreContinente) 
			{
			  return (Entities.Views.dbo.VistaUsuario)base.Add(new Entities.Views.dbo.VistaUsuario(Nombre,Apellido,Edad,NombrePais,ContinenteId,NombreContinente));
			}
            public new List<Entities.Views.dbo.VistaUsuario> Items()
            {
                DataHandler dh =  new DataHandler(this._dataItem);
                dh.WhereParameter = this.Where.whereParameter;
                dh.OrderByParameter = this.OrderBy.orderByParameter;
                dh.GroupByParameter = this.GroupBy.groupByParameter;
                List<Entities.Views.dbo.VistaUsuario> _entities = new List<Entities.Views.dbo.VistaUsuario>();
                _entities = dh.Items().Cast<Entities.Views.dbo.VistaUsuario>().ToList<Entities.Views.dbo.VistaUsuario>();
                return _entities;
            }
            /// <summary>
            /// Gets 
            /// </summary>
            /// <param name="Nombre"></param>
            /// <param name="Apellido"></param>
            /// <param name="Edad"></param>
            /// <param name="NombrePais"></param>
            /// <param name="ContinenteId"></param>
            /// <param name="NombreContinente"></param>
            /// <returns></returns>
            public List<Entities.Views.dbo.VistaUsuario> Items(String Nombre,String Apellido,Int16? Edad,String NombrePais,Int64? ContinenteId,String NombreContinente)
            {
                this.Where.whereParameter.Clear();
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
                if (NombrePais != null)
                {
                    if (this.Where.whereParameter.Count == 0)
                    {
                        this.Where.Add(ColumnEnum.NombrePais, AccesoADatos.sqlEnum.OperandEnum.Equal, NombrePais);
                    }
                    else
                    {
                        this.Where.Add(AccesoADatos.sqlEnum.ConjunctionEnum.AND, ColumnEnum.NombrePais, AccesoADatos.sqlEnum.OperandEnum.Equal, NombrePais);
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
                if (NombreContinente != null)
                {
                    if (this.Where.whereParameter.Count == 0)
                    {
                        this.Where.Add(ColumnEnum.NombreContinente, AccesoADatos.sqlEnum.OperandEnum.Equal, NombreContinente);
                    }
                    else
                    {
                        this.Where.Add(AccesoADatos.sqlEnum.ConjunctionEnum.AND, ColumnEnum.NombreContinente, AccesoADatos.sqlEnum.OperandEnum.Equal, NombreContinente);
                    }
                   
                }
                return this.Items();
            }
            public new IDataItem Add(IDataItem item)
            {
                DataHandler dh = new DataHandler(this._dataItem);
                return base.Add(item);
            }
            public class WhereCollection : WhereParameter {
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
                 public void AddOperand(AccesoADatos.sqlEnum.ConjunctionEnum Conjunction)
                 {
                     this.whereParameter.AddConjunction(Conjunction);
                 }
                 public void OpenParentheses()
                 {
                     this.whereParameter.OpenParentheses();
                 }
                 public void CloseParentheses()
                 {
                     this.whereParameter.CloseParentheses();
                 }
            }
            public class OrderByCollection : OrderByParameter {
                 internal OrderByParameter orderByParameter = new OrderByParameter();
                 public void Add(ColumnEnum column, AccesoADatos.sqlEnum.DirEnum direction = AccesoADatos.sqlEnum.DirEnum.ASC)
                 {
                     this.orderByParameter.Add(Enum.GetName(typeof(ColumnEnum), column), direction);
                 }
            }
            public class GroupByCollection : GroupByParameter {
                 internal GroupByParameter groupByParameter = new GroupByParameter();
                 public void Add(ColumnEnum column)
                 {
                     this.groupByParameter.Add(Enum.GetName(typeof(ColumnEnum), column));
                 }
            }
        } // class VistaUsuario
	} //namespace AccesoADatos.Business.Views.dbo
