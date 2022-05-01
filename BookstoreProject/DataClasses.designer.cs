﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookstoreProject
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="BookDatabase")]
	public partial class DataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertBooks(Books instance);
    partial void UpdateBooks(Books instance);
    partial void DeleteBooks(Books instance);
    partial void InsertBookstore(Bookstore instance);
    partial void UpdateBookstore(Bookstore instance);
    partial void DeleteBookstore(Bookstore instance);
    partial void InsertBookBookstore(BookBookstore instance);
    partial void UpdateBookBookstore(BookBookstore instance);
    partial void DeleteBookBookstore(BookBookstore instance);
    #endregion
		
		public DataClassesDataContext() : 
				base(global::BookstoreProject.Properties.Settings.Default.BookDatabaseConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Books> Books
		{
			get
			{
				return this.GetTable<Books>();
			}
		}
		
		public System.Data.Linq.Table<Bookstore> Bookstore
		{
			get
			{
				return this.GetTable<Bookstore>();
			}
		}
		
		public System.Data.Linq.Table<BookBookstore> BookBookstore
		{
			get
			{
				return this.GetTable<BookBookstore>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Books")]
	public partial class Books : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Name;
		
		private string _Author;
		
		private System.Nullable<int> _Year;
		
		private System.Nullable<decimal> _Price;
		
		private EntitySet<BookBookstore> _BookBookstore;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnAuthorChanging(string value);
    partial void OnAuthorChanged();
    partial void OnYearChanging(System.Nullable<int> value);
    partial void OnYearChanged();
    partial void OnPriceChanging(System.Nullable<decimal> value);
    partial void OnPriceChanged();
    #endregion
		
		public Books()
		{
			this._BookBookstore = new EntitySet<BookBookstore>(new Action<BookBookstore>(this.attach_BookBookstore), new Action<BookBookstore>(this.detach_BookBookstore));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(100) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Author", DbType="NVarChar(MAX)")]
		public string Author
		{
			get
			{
				return this._Author;
			}
			set
			{
				if ((this._Author != value))
				{
					this.OnAuthorChanging(value);
					this.SendPropertyChanging();
					this._Author = value;
					this.SendPropertyChanged("Author");
					this.OnAuthorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Year", DbType="Int")]
		public System.Nullable<int> Year
		{
			get
			{
				return this._Year;
			}
			set
			{
				if ((this._Year != value))
				{
					this.OnYearChanging(value);
					this.SendPropertyChanging();
					this._Year = value;
					this.SendPropertyChanged("Year");
					this.OnYearChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Money")]
		public System.Nullable<decimal> Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Books_BookBookstore", Storage="_BookBookstore", ThisKey="Name", OtherKey="Book")]
		public EntitySet<BookBookstore> BookBookstore
		{
			get
			{
				return this._BookBookstore;
			}
			set
			{
				this._BookBookstore.Assign(value);
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
		
		private void attach_BookBookstore(BookBookstore entity)
		{
			this.SendPropertyChanging();
			entity.Books = this;
		}
		
		private void detach_BookBookstore(BookBookstore entity)
		{
			this.SendPropertyChanging();
			entity.Books = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Bookstore")]
	public partial class Bookstore : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _ShopName;
		
		private string _Adress;
		
		private EntitySet<BookBookstore> _BookBookstore;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnShopNameChanging(string value);
    partial void OnShopNameChanged();
    partial void OnAdressChanging(string value);
    partial void OnAdressChanged();
    #endregion
		
		public Bookstore()
		{
			this._BookBookstore = new EntitySet<BookBookstore>(new Action<BookBookstore>(this.attach_BookBookstore), new Action<BookBookstore>(this.detach_BookBookstore));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ShopName", DbType="NVarChar(100) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string ShopName
		{
			get
			{
				return this._ShopName;
			}
			set
			{
				if ((this._ShopName != value))
				{
					this.OnShopNameChanging(value);
					this.SendPropertyChanging();
					this._ShopName = value;
					this.SendPropertyChanged("ShopName");
					this.OnShopNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Adress", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Adress
		{
			get
			{
				return this._Adress;
			}
			set
			{
				if ((this._Adress != value))
				{
					this.OnAdressChanging(value);
					this.SendPropertyChanging();
					this._Adress = value;
					this.SendPropertyChanged("Adress");
					this.OnAdressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Bookstore_BookBookstore", Storage="_BookBookstore", ThisKey="ShopName", OtherKey="BookstoreName")]
		public EntitySet<BookBookstore> BookBookstore
		{
			get
			{
				return this._BookBookstore;
			}
			set
			{
				this._BookBookstore.Assign(value);
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
		
		private void attach_BookBookstore(BookBookstore entity)
		{
			this.SendPropertyChanging();
			entity.Bookstore = this;
		}
		
		private void detach_BookBookstore(BookBookstore entity)
		{
			this.SendPropertyChanging();
			entity.Bookstore = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BookBookstore")]
	public partial class BookBookstore : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Book;
		
		private string _BookstoreName;
		
		private bool _isAvalible;
		
		private EntityRef<Books> _Books;
		
		private EntityRef<Bookstore> _Bookstore;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnBookChanging(string value);
    partial void OnBookChanged();
    partial void OnBookstoreNameChanging(string value);
    partial void OnBookstoreNameChanged();
    partial void OnisAvalibleChanging(bool value);
    partial void OnisAvalibleChanged();
    #endregion
		
		public BookBookstore()
		{
			this._Books = default(EntityRef<Books>);
			this._Bookstore = default(EntityRef<Bookstore>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Book", DbType="NVarChar(100) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Book
		{
			get
			{
				return this._Book;
			}
			set
			{
				if ((this._Book != value))
				{
					if (this._Books.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnBookChanging(value);
					this.SendPropertyChanging();
					this._Book = value;
					this.SendPropertyChanged("Book");
					this.OnBookChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BookstoreName", DbType="NVarChar(100) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string BookstoreName
		{
			get
			{
				return this._BookstoreName;
			}
			set
			{
				if ((this._BookstoreName != value))
				{
					if (this._Bookstore.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnBookstoreNameChanging(value);
					this.SendPropertyChanging();
					this._BookstoreName = value;
					this.SendPropertyChanged("BookstoreName");
					this.OnBookstoreNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_isAvalible", DbType="Bit NOT NULL")]
		public bool isAvalible
		{
			get
			{
				return this._isAvalible;
			}
			set
			{
				if ((this._isAvalible != value))
				{
					this.OnisAvalibleChanging(value);
					this.SendPropertyChanging();
					this._isAvalible = value;
					this.SendPropertyChanged("isAvalible");
					this.OnisAvalibleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Books_BookBookstore", Storage="_Books", ThisKey="Book", OtherKey="Name", IsForeignKey=true)]
		public Books Books
		{
			get
			{
				return this._Books.Entity;
			}
			set
			{
				Books previousValue = this._Books.Entity;
				if (((previousValue != value) 
							|| (this._Books.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Books.Entity = null;
						previousValue.BookBookstore.Remove(this);
					}
					this._Books.Entity = value;
					if ((value != null))
					{
						value.BookBookstore.Add(this);
						this._Book = value.Name;
					}
					else
					{
						this._Book = default(string);
					}
					this.SendPropertyChanged("Books");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Bookstore_BookBookstore", Storage="_Bookstore", ThisKey="BookstoreName", OtherKey="ShopName", IsForeignKey=true)]
		public Bookstore Bookstore
		{
			get
			{
				return this._Bookstore.Entity;
			}
			set
			{
				Bookstore previousValue = this._Bookstore.Entity;
				if (((previousValue != value) 
							|| (this._Bookstore.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Bookstore.Entity = null;
						previousValue.BookBookstore.Remove(this);
					}
					this._Bookstore.Entity = value;
					if ((value != null))
					{
						value.BookBookstore.Add(this);
						this._BookstoreName = value.ShopName;
					}
					else
					{
						this._BookstoreName = default(string);
					}
					this.SendPropertyChanged("Bookstore");
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
