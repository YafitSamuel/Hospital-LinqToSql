#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hospital_LinqToSql.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="HospitalDB")]
	public partial class NurseDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertNurse(Nurse instance);
    partial void UpdateNurse(Nurse instance);
    partial void DeleteNurse(Nurse instance);
    #endregion
		
		public NurseDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["HospitalDBConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public NurseDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public NurseDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public NurseDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public NurseDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Nurse> Nurses
		{
			get
			{
				return this.GetTable<Nurse>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Nurse")]
	public partial class Nurse : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _firstNmae;
		
		private string _lastName;
		
		private System.Nullable<int> _payment;
		
		private System.Nullable<int> _timeWork;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnfirstNmaeChanging(string value);
    partial void OnfirstNmaeChanged();
    partial void OnlastNameChanging(string value);
    partial void OnlastNameChanged();
    partial void OnpaymentChanging(System.Nullable<int> value);
    partial void OnpaymentChanged();
    partial void OntimeWorkChanging(System.Nullable<int> value);
    partial void OntimeWorkChanged();
    #endregion
		
		public Nurse()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_firstNmae", DbType="NChar(10)")]
		public string firstNmae
		{
			get
			{
				return this._firstNmae;
			}
			set
			{
				if ((this._firstNmae != value))
				{
					this.OnfirstNmaeChanging(value);
					this.SendPropertyChanging();
					this._firstNmae = value;
					this.SendPropertyChanged("firstNmae");
					this.OnfirstNmaeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lastName", DbType="NChar(10)")]
		public string lastName
		{
			get
			{
				return this._lastName;
			}
			set
			{
				if ((this._lastName != value))
				{
					this.OnlastNameChanging(value);
					this.SendPropertyChanging();
					this._lastName = value;
					this.SendPropertyChanged("lastName");
					this.OnlastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_payment", DbType="Int")]
		public System.Nullable<int> payment
		{
			get
			{
				return this._payment;
			}
			set
			{
				if ((this._payment != value))
				{
					this.OnpaymentChanging(value);
					this.SendPropertyChanging();
					this._payment = value;
					this.SendPropertyChanged("payment");
					this.OnpaymentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_timeWork", DbType="Int")]
		public System.Nullable<int> timeWork
		{
			get
			{
				return this._timeWork;
			}
			set
			{
				if ((this._timeWork != value))
				{
					this.OntimeWorkChanging(value);
					this.SendPropertyChanging();
					this._timeWork = value;
					this.SendPropertyChanged("timeWork");
					this.OntimeWorkChanged();
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
