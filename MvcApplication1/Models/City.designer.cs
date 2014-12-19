﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.34003
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcApplication1.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="aspnet-MvcApplication1-20141021183026")]
	public partial class CityDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Определения метода расширяемости
    partial void OnCreated();
    partial void Insertcity(city instance);
    partial void Updatecity(city instance);
    partial void Deletecity(city instance);
    #endregion
		
		public CityDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["aspnet_MvcApplication1_20141021183026ConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public CityDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CityDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CityDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CityDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<city> city
		{
			get
			{
				return this.GetTable<city>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.city")]
	public partial class city : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _city_id;
		
		private int _country_id;
		
		private int _region_id;
		
		private string _name;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Oncity_idChanging(int value);
    partial void Oncity_idChanged();
    partial void Oncountry_idChanging(int value);
    partial void Oncountry_idChanged();
    partial void Onregion_idChanging(int value);
    partial void Onregion_idChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    #endregion
		
		public city()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_city_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int city_id
		{
			get
			{
				return this._city_id;
			}
			set
			{
				if ((this._city_id != value))
				{
					this.Oncity_idChanging(value);
					this.SendPropertyChanging();
					this._city_id = value;
					this.SendPropertyChanged("city_id");
					this.Oncity_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_country_id", DbType="Int NOT NULL")]
		public int country_id
		{
			get
			{
				return this._country_id;
			}
			set
			{
				if ((this._country_id != value))
				{
					this.Oncountry_idChanging(value);
					this.SendPropertyChanging();
					this._country_id = value;
					this.SendPropertyChanged("country_id");
					this.Oncountry_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_region_id", DbType="Int NOT NULL")]
		public int region_id
		{
			get
			{
				return this._region_id;
			}
			set
			{
				if ((this._region_id != value))
				{
					this.Onregion_idChanging(value);
					this.SendPropertyChanging();
					this._region_id = value;
					this.SendPropertyChanged("region_id");
					this.Onregion_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(128) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
