﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VehicleDatabaseManager
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="VehicleDatabase")]
	public partial class VDDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertDbClient(DbClient instance);
    partial void UpdateDbClient(DbClient instance);
    partial void DeleteDbClient(DbClient instance);
    partial void InsertDbStatus(DbStatus instance);
    partial void UpdateDbStatus(DbStatus instance);
    partial void DeleteDbStatus(DbStatus instance);
    partial void InsertDbType(DbType instance);
    partial void UpdateDbType(DbType instance);
    partial void DeleteDbType(DbType instance);
    partial void InsertDbManufacturer(DbManufacturer instance);
    partial void UpdateDbManufacturer(DbManufacturer instance);
    partial void DeleteDbManufacturer(DbManufacturer instance);
    partial void InsertDbModel(DbModel instance);
    partial void UpdateDbModel(DbModel instance);
    partial void DeleteDbModel(DbModel instance);
    #endregion
		
		public VDDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["VehicleDatabaseConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public VDDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public VDDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public VDDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public VDDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<DbClient> DbClients
		{
			get
			{
				return this.GetTable<DbClient>();
			}
		}
		
		public System.Data.Linq.Table<DbStatus> DbStatus
		{
			get
			{
				return this.GetTable<DbStatus>();
			}
		}
		
		public System.Data.Linq.Table<DbType> DbTypes
		{
			get
			{
				return this.GetTable<DbType>();
			}
		}
		
		public System.Data.Linq.Table<DbManufacturer> DbManufacturers
		{
			get
			{
				return this.GetTable<DbManufacturer>();
			}
		}
		
		public System.Data.Linq.Table<DbModel> DbModels
		{
			get
			{
				return this.GetTable<DbModel>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Clients")]
	public partial class DbClient : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Name;
		
		private string _CallbackUrl;
		
		private string _Password;
		
		private System.DateTime _DateCreated;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnCallbackUrlChanging(string value);
    partial void OnCallbackUrlChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnDateCreatedChanging(System.DateTime value);
    partial void OnDateCreatedChanged();
    #endregion
		
		public DbClient()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CallbackUrl", DbType="VarChar(512)")]
		public string CallbackUrl
		{
			get
			{
				return this._CallbackUrl;
			}
			set
			{
				if ((this._CallbackUrl != value))
				{
					this.OnCallbackUrlChanging(value);
					this.SendPropertyChanging();
					this._CallbackUrl = value;
					this.SendPropertyChanged("CallbackUrl");
					this.OnCallbackUrlChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateCreated", DbType="DateTime NOT NULL")]
		public System.DateTime DateCreated
		{
			get
			{
				return this._DateCreated;
			}
			set
			{
				if ((this._DateCreated != value))
				{
					this.OnDateCreatedChanging(value);
					this.SendPropertyChanging();
					this._DateCreated = value;
					this.SendPropertyChanged("DateCreated");
					this.OnDateCreatedChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Statuses")]
	public partial class DbStatus : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Name;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public DbStatus()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
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
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Types")]
	public partial class DbType : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Name;
		
		private int _Status;
		
		private EntitySet<DbModel> _DbModels;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnStatusChanging(int value);
    partial void OnStatusChanged();
    #endregion
		
		public DbType()
		{
			this._DbModels = new EntitySet<DbModel>(new Action<DbModel>(this.attach_DbModels), new Action<DbModel>(this.detach_DbModels));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Status", DbType="Int NOT NULL")]
		public int Status
		{
			get
			{
				return this._Status;
			}
			set
			{
				if ((this._Status != value))
				{
					this.OnStatusChanging(value);
					this.SendPropertyChanging();
					this._Status = value;
					this.SendPropertyChanged("Status");
					this.OnStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DbType_DbModel", Storage="_DbModels", ThisKey="ID", OtherKey="TypeID")]
		public EntitySet<DbModel> DbModels
		{
			get
			{
				return this._DbModels;
			}
			set
			{
				this._DbModels.Assign(value);
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
		
		private void attach_DbModels(DbModel entity)
		{
			this.SendPropertyChanging();
			entity.DbType = this;
		}
		
		private void detach_DbModels(DbModel entity)
		{
			this.SendPropertyChanging();
			entity.DbType = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Manufacturers")]
	public partial class DbManufacturer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Name;
		
		private string _WikipediaID;
		
		private int _Status;
		
		private EntitySet<DbModel> _DbModels;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnWikipediaIDChanging(string value);
    partial void OnWikipediaIDChanged();
    partial void OnStatusChanging(int value);
    partial void OnStatusChanged();
    #endregion
		
		public DbManufacturer()
		{
			this._DbModels = new EntitySet<DbModel>(new Action<DbModel>(this.attach_DbModels), new Action<DbModel>(this.detach_DbModels));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WikipediaID", DbType="VarChar(255)")]
		public string WikipediaID
		{
			get
			{
				return this._WikipediaID;
			}
			set
			{
				if ((this._WikipediaID != value))
				{
					this.OnWikipediaIDChanging(value);
					this.SendPropertyChanging();
					this._WikipediaID = value;
					this.SendPropertyChanged("WikipediaID");
					this.OnWikipediaIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Status", DbType="Int NOT NULL")]
		public int Status
		{
			get
			{
				return this._Status;
			}
			set
			{
				if ((this._Status != value))
				{
					this.OnStatusChanging(value);
					this.SendPropertyChanging();
					this._Status = value;
					this.SendPropertyChanged("Status");
					this.OnStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DbManufacturer_DbModel", Storage="_DbModels", ThisKey="ID", OtherKey="ManufacturerID")]
		public EntitySet<DbModel> DbModels
		{
			get
			{
				return this._DbModels;
			}
			set
			{
				this._DbModels.Assign(value);
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
		
		private void attach_DbModels(DbModel entity)
		{
			this.SendPropertyChanging();
			entity.DbManufacturer = this;
		}
		
		private void detach_DbModels(DbModel entity)
		{
			this.SendPropertyChanging();
			entity.DbManufacturer = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Models")]
	public partial class DbModel : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private int _ManufacturerID;
		
		private string _Name;
		
		private string _VariantName;
		
		private string _WikipediaID;
		
		private System.Nullable<int> _YearIntroduced;
		
		private System.Nullable<int> _YearStopped;
		
		private int _TypeID;
		
		private System.Nullable<int> _EngineSizeCC;
		
		private int _Status;
		
		private EntityRef<DbManufacturer> _DbManufacturer;
		
		private EntityRef<DbType> _DbType;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnManufacturerIDChanging(int value);
    partial void OnManufacturerIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnVariantNameChanging(string value);
    partial void OnVariantNameChanged();
    partial void OnWikipediaIDChanging(string value);
    partial void OnWikipediaIDChanged();
    partial void OnYearIntroducedChanging(System.Nullable<int> value);
    partial void OnYearIntroducedChanged();
    partial void OnYearStoppedChanging(System.Nullable<int> value);
    partial void OnYearStoppedChanged();
    partial void OnTypeIDChanging(int value);
    partial void OnTypeIDChanged();
    partial void OnEngineSizeCCChanging(System.Nullable<int> value);
    partial void OnEngineSizeCCChanged();
    partial void OnStatusChanging(int value);
    partial void OnStatusChanged();
    #endregion
		
		public DbModel()
		{
			this._DbManufacturer = default(EntityRef<DbManufacturer>);
			this._DbType = default(EntityRef<DbType>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ManufacturerID", DbType="Int NOT NULL")]
		public int ManufacturerID
		{
			get
			{
				return this._ManufacturerID;
			}
			set
			{
				if ((this._ManufacturerID != value))
				{
					if (this._DbManufacturer.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnManufacturerIDChanging(value);
					this.SendPropertyChanging();
					this._ManufacturerID = value;
					this.SendPropertyChanged("ManufacturerID");
					this.OnManufacturerIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VariantName", DbType="VarChar(100)")]
		public string VariantName
		{
			get
			{
				return this._VariantName;
			}
			set
			{
				if ((this._VariantName != value))
				{
					this.OnVariantNameChanging(value);
					this.SendPropertyChanging();
					this._VariantName = value;
					this.SendPropertyChanged("VariantName");
					this.OnVariantNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WikipediaID", DbType="VarChar(255)")]
		public string WikipediaID
		{
			get
			{
				return this._WikipediaID;
			}
			set
			{
				if ((this._WikipediaID != value))
				{
					this.OnWikipediaIDChanging(value);
					this.SendPropertyChanging();
					this._WikipediaID = value;
					this.SendPropertyChanged("WikipediaID");
					this.OnWikipediaIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_YearIntroduced", DbType="Int")]
		public System.Nullable<int> YearIntroduced
		{
			get
			{
				return this._YearIntroduced;
			}
			set
			{
				if ((this._YearIntroduced != value))
				{
					this.OnYearIntroducedChanging(value);
					this.SendPropertyChanging();
					this._YearIntroduced = value;
					this.SendPropertyChanged("YearIntroduced");
					this.OnYearIntroducedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_YearStopped", DbType="Int")]
		public System.Nullable<int> YearStopped
		{
			get
			{
				return this._YearStopped;
			}
			set
			{
				if ((this._YearStopped != value))
				{
					this.OnYearStoppedChanging(value);
					this.SendPropertyChanging();
					this._YearStopped = value;
					this.SendPropertyChanged("YearStopped");
					this.OnYearStoppedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TypeID", DbType="Int NOT NULL")]
		public int TypeID
		{
			get
			{
				return this._TypeID;
			}
			set
			{
				if ((this._TypeID != value))
				{
					if (this._DbType.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnTypeIDChanging(value);
					this.SendPropertyChanging();
					this._TypeID = value;
					this.SendPropertyChanged("TypeID");
					this.OnTypeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EngineSizeCC", DbType="Int")]
		public System.Nullable<int> EngineSizeCC
		{
			get
			{
				return this._EngineSizeCC;
			}
			set
			{
				if ((this._EngineSizeCC != value))
				{
					this.OnEngineSizeCCChanging(value);
					this.SendPropertyChanging();
					this._EngineSizeCC = value;
					this.SendPropertyChanged("EngineSizeCC");
					this.OnEngineSizeCCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Status", DbType="Int NOT NULL")]
		public int Status
		{
			get
			{
				return this._Status;
			}
			set
			{
				if ((this._Status != value))
				{
					this.OnStatusChanging(value);
					this.SendPropertyChanging();
					this._Status = value;
					this.SendPropertyChanged("Status");
					this.OnStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DbManufacturer_DbModel", Storage="_DbManufacturer", ThisKey="ManufacturerID", OtherKey="ID", IsForeignKey=true)]
		public DbManufacturer DbManufacturer
		{
			get
			{
				return this._DbManufacturer.Entity;
			}
			set
			{
				DbManufacturer previousValue = this._DbManufacturer.Entity;
				if (((previousValue != value) 
							|| (this._DbManufacturer.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._DbManufacturer.Entity = null;
						previousValue.DbModels.Remove(this);
					}
					this._DbManufacturer.Entity = value;
					if ((value != null))
					{
						value.DbModels.Add(this);
						this._ManufacturerID = value.ID;
					}
					else
					{
						this._ManufacturerID = default(int);
					}
					this.SendPropertyChanged("DbManufacturer");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DbType_DbModel", Storage="_DbType", ThisKey="TypeID", OtherKey="ID", IsForeignKey=true)]
		public DbType DbType
		{
			get
			{
				return this._DbType.Entity;
			}
			set
			{
				DbType previousValue = this._DbType.Entity;
				if (((previousValue != value) 
							|| (this._DbType.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._DbType.Entity = null;
						previousValue.DbModels.Remove(this);
					}
					this._DbType.Entity = value;
					if ((value != null))
					{
						value.DbModels.Add(this);
						this._TypeID = value.ID;
					}
					else
					{
						this._TypeID = default(int);
					}
					this.SendPropertyChanged("DbType");
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
