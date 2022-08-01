using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
	namespace AccesoADatos.Business.Procedures.dbo {
	    /// <summary>
	    /// 
	    /// </summary>
		public class ObtenerUsuario : ProcedureDataHandler
		{
         private List<Entities.Procedures.dbo.ObtenerUsuario> _result = new List<Entities.Procedures.dbo.ObtenerUsuario>();
			protected List<IDataItem> _cacheItemList = new List<IDataItem>();
            public ObtenerUsuario() : base()
            {
                base._dataItem = new Entities.Procedures.dbo.ObtenerUsuario();
            }
            public  List<Entities.Procedures.dbo.ObtenerUsuario> Items()
            {
                ProcedureDataHandler dh =  new ProcedureDataHandler(this._dataItem);
                List<Entities.Procedures.dbo.ObtenerUsuario> _entities = new List<Entities.Procedures.dbo.ObtenerUsuario>();
                _result = dh.Items(new List<ParameterItemValue> {}).Cast<Entities.Procedures.dbo.ObtenerUsuario>().ToList<Entities.Procedures.dbo.ObtenerUsuario>();
                return _result;
             }
             public List<Entities.Procedures.dbo.ObtenerUsuario> Resultset
             {
                 get { return _result; }
             }
        }// class dbo
	} // namespace AccesoADatos.Business.Procedures.dbo
