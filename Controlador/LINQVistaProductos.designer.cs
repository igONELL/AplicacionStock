﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AplicacionStock.Controlador
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="AppStockDB")]
	public partial class LINQVistaProductosDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    #endregion
		
		public LINQVistaProductosDataContext() : 
				base(global::AplicacionStock.Properties.Settings.Default.AppStockDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public LINQVistaProductosDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LINQVistaProductosDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LINQVistaProductosDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LINQVistaProductosDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<ProductosVisibles> ProductosVisibles
		{
			get
			{
				return this.GetTable<ProductosVisibles>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ProductosVisibles")]
	public partial class ProductosVisibles
	{
		
		private int _ID;
		
		private string _Nombre;
		
		private int _Cantidad;
		
		private string _Talla;
		
		private string _Modificador;
		
		public ProductosVisibles()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL")]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this._Nombre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cantidad", DbType="Int NOT NULL")]
		public int Cantidad
		{
			get
			{
				return this._Cantidad;
			}
			set
			{
				if ((this._Cantidad != value))
				{
					this._Cantidad = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Talla", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string Talla
		{
			get
			{
				return this._Talla;
			}
			set
			{
				if ((this._Talla != value))
				{
					this._Talla = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Modificador", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Modificador
		{
			get
			{
				return this._Modificador;
			}
			set
			{
				if ((this._Modificador != value))
				{
					this._Modificador = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
