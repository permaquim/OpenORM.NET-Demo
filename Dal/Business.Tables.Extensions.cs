    #region Banco

	namespace AccesoADatos.Business.Tables.dbo
{
	/// <summary>
	/// 
	/// </summary>
	public partial class Banco
	{
		public enum LogTypeEnum {
			Ninguno,
			Alta,
			Baja,
			Modificacion
		}

		public Entities.Tables.dbo.Banco Add(Entities.Tables.dbo.Banco item,long aplicacionId)
		{
			var refItem =  (Entities.Tables.dbo.Banco)base.Add((IDataItem)item);
			LogEvent(aplicacionId, LogTypeEnum.Alta, refItem);
			return refItem;
		}
		public Int64 Update(Entities.Tables.dbo.Banco item, long aplicacionId)
		{
			var refItem = base.Update((IDataItem)item);
			LogEvent(aplicacionId, LogTypeEnum.Modificacion, item);
			return refItem;
		}

		public Int64 Delete(Int64 id, long aplicacionId)
		{
			Business.Tables.dbo.Banco refentities = new();
			refentities.Items(id);
			var refentity = refentities.Result.FirstOrDefault();
			LogEvent(aplicacionId, LogTypeEnum.Baja, refentity);
			return  base.DeleteItem(refentity);

		}

		private int LogEvent(long applicacionId, LogTypeEnum logType, AccesoADatos.Entities.Tables.dbo.Banco entity)

		{
			string descripcion = string.Empty;
			string metodo = string.Empty;

			switch (logType)
			{
				case LogTypeEnum.Ninguno:
					descripcion = "No especificado";
					metodo = Enum.GetName(LogTypeEnum.Ninguno);
					break;
				case LogTypeEnum.Alta:
					descripcion = "Alta de entidad: AccesoADatos.Business.dbo.Banco";
					metodo = Enum.GetName(LogTypeEnum.Alta);
					break;
				case LogTypeEnum.Baja:
					descripcion = "Baja de entidad: AccesoADatos.Business.dbo.Banco";
					metodo = Enum.GetName(LogTypeEnum.Baja);
					break;
				case LogTypeEnum.Modificacion:
					descripcion = "Modificacion de entidad: AccesoADatos.Business.dbo.Banco";
					metodo = Enum.GetName(LogTypeEnum.Modificacion);
					break;
				default:
					break;
			}

			AccesoADatos.Business.Tables.dbo.Log logEntities = new();
			logEntities.Add(new()
			{
				AplicacionId = applicacionId,
				Descripcion = descripcion,
				Detalle = descripcion,
				Fecha = DateTime.Now,
				Metodo = metodo,
				Modulo = "",
				TipoId = (long)logType,
				UsuarioId = entity.UsuarioCreacion == null ? -1 : (long)entity.UsuarioCreacion
			});

			return 0;
        }
    }
}

    #endregion

