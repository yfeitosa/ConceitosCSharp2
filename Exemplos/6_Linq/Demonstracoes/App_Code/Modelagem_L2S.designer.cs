﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="CURSO")]
public partial class Modelagem_L2SDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  partial void InsertTB_LINGUAGEM(TB_LINGUAGEM instance);
  partial void UpdateTB_LINGUAGEM(TB_LINGUAGEM instance);
  partial void DeleteTB_LINGUAGEM(TB_LINGUAGEM instance);
  #endregion
	
	public Modelagem_L2SDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["BASE_CURSO"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public Modelagem_L2SDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public Modelagem_L2SDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public Modelagem_L2SDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public Modelagem_L2SDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<TB_LINGUAGEM> TB_LINGUAGEMs
	{
		get
		{
			return this.GetTable<TB_LINGUAGEM>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TB_LINGUAGEM")]
public partial class TB_LINGUAGEM : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID_LINGUAGEM;
	
	private string _NM_LINGUAGEM;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnID_LINGUAGEMChanging(int value);
    partial void OnID_LINGUAGEMChanged();
    partial void OnNM_LINGUAGEMChanging(string value);
    partial void OnNM_LINGUAGEMChanged();
    #endregion
	
	public TB_LINGUAGEM()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_LINGUAGEM", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int ID_LINGUAGEM
	{
		get
		{
			return this._ID_LINGUAGEM;
		}
		set
		{
			if ((this._ID_LINGUAGEM != value))
			{
				this.OnID_LINGUAGEMChanging(value);
				this.SendPropertyChanging();
				this._ID_LINGUAGEM = value;
				this.SendPropertyChanged("ID_LINGUAGEM");
				this.OnID_LINGUAGEMChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NM_LINGUAGEM", DbType="VarChar(15) NOT NULL", CanBeNull=false)]
	public string NM_LINGUAGEM
	{
		get
		{
			return this._NM_LINGUAGEM;
		}
		set
		{
			if ((this._NM_LINGUAGEM != value))
			{
				this.OnNM_LINGUAGEMChanging(value);
				this.SendPropertyChanging();
				this._NM_LINGUAGEM = value;
				this.SendPropertyChanged("NM_LINGUAGEM");
				this.OnNM_LINGUAGEMChanged();
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
#pragma warning restore 1591