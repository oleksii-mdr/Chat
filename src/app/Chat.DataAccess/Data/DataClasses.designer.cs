﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Chat.DataAccess.Data
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="TestDB")]
	public partial class DataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
	#region Extensibility Method Definitions
	partial void OnCreated();
	partial void InsertRole(Role instance);
	partial void UpdateRole(Role instance);
	partial void DeleteRole(Role instance);
	partial void InsertUser_Role(User_Role instance);
	partial void UpdateUser_Role(User_Role instance);
	partial void DeleteUser_Role(User_Role instance);
	partial void InsertRoom(Room instance);
	partial void UpdateRoom(Room instance);
	partial void DeleteRoom(Room instance);
	partial void InsertMessage(Message instance);
	partial void UpdateMessage(Message instance);
	partial void DeleteMessage(Message instance);
	partial void InsertUser(User instance);
	partial void UpdateUser(User instance);
	partial void DeleteUser(User instance);
	#endregion
		
		public DataClassesDataContext() : 
				base(global::Chat.DataAccess.Properties.Settings.Default.TestDBConnectionString, mappingSource)
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
		
		public System.Data.Linq.Table<Role> Roles
		{
			get
			{
				return this.GetTable<Role>();
			}
		}
		
		public System.Data.Linq.Table<User_Role> User_Roles
		{
			get
			{
				return this.GetTable<User_Role>();
			}
		}
		
		public System.Data.Linq.Table<Room> Rooms
		{
			get
			{
				return this.GetTable<Room>();
			}
		}
		
		public System.Data.Linq.Table<Message> Messages
		{
			get
			{
				return this.GetTable<Message>();
			}
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Roles")]
	public partial class Role : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private string _Description;
		
		private EntitySet<User_Role> _User_Roles;
		
	#region Extensibility Method Definitions
	partial void OnLoaded();
	partial void OnValidate(System.Data.Linq.ChangeAction action);
	partial void OnCreated();
	partial void OnIdChanging(int value);
	partial void OnIdChanged();
	partial void OnNameChanging(string value);
	partial void OnNameChanged();
	partial void OnDescriptionChanging(string value);
	partial void OnDescriptionChanged();
	#endregion
		
		public Role()
		{
			this._User_Roles = new EntitySet<User_Role>(new Action<User_Role>(this.attach_User_Roles), new Action<User_Role>(this.detach_User_Roles));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="Text NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Role_User_Role", Storage="_User_Roles", ThisKey="Id", OtherKey="RoleId")]
		public EntitySet<User_Role> User_Roles
		{
			get
			{
				return this._User_Roles;
			}
			set
			{
				this._User_Roles.Assign(value);
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
		
		private void attach_User_Roles(User_Role entity)
		{
			this.SendPropertyChanging();
			entity.Role = this;
		}
		
		private void detach_User_Roles(User_Role entity)
		{
			this.SendPropertyChanging();
			entity.Role = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[User-Role]")]
	public partial class User_Role : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.Nullable<int> _RoleId;
		
		private System.Nullable<int> _UserId;
		
		private EntityRef<Role> _Role;
		
		private EntityRef<User> _User;
		
	#region Extensibility Method Definitions
	partial void OnLoaded();
	partial void OnValidate(System.Data.Linq.ChangeAction action);
	partial void OnCreated();
	partial void OnIdChanging(int value);
	partial void OnIdChanged();
	partial void OnRoleIdChanging(System.Nullable<int> value);
	partial void OnRoleIdChanged();
	partial void OnUserIdChanging(System.Nullable<int> value);
	partial void OnUserIdChanged();
	#endregion
		
		public User_Role()
		{
			this._Role = default(EntityRef<Role>);
			this._User = default(EntityRef<User>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RoleId", DbType="Int")]
		public System.Nullable<int> RoleId
		{
			get
			{
				return this._RoleId;
			}
			set
			{
				if ((this._RoleId != value))
				{
					if (this._Role.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnRoleIdChanging(value);
					this.SendPropertyChanging();
					this._RoleId = value;
					this.SendPropertyChanged("RoleId");
					this.OnRoleIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", DbType="Int")]
		public System.Nullable<int> UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Role_User_Role", Storage="_Role", ThisKey="RoleId", OtherKey="Id", IsForeignKey=true, DeleteRule="SET NULL")]
		public Role Role
		{
			get
			{
				return this._Role.Entity;
			}
			set
			{
				Role previousValue = this._Role.Entity;
				if (((previousValue != value) 
							|| (this._Role.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Role.Entity = null;
						previousValue.User_Roles.Remove(this);
					}
					this._Role.Entity = value;
					if ((value != null))
					{
						value.User_Roles.Add(this);
						this._RoleId = value.Id;
					}
					else
					{
						this._RoleId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Role");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_User_Role", Storage="_User", ThisKey="UserId", OtherKey="Id", IsForeignKey=true, DeleteRule="SET NULL")]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.User_Roles.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.User_Roles.Add(this);
						this._UserId = value.Id;
					}
					else
					{
						this._UserId = default(Nullable<int>);
					}
					this.SendPropertyChanged("User");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Room")]
	public partial class Room : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private int _CreatorId;
		
		private EntitySet<Message> _Messages;
		
		private EntitySet<User> _Users;
		
	#region Extensibility Method Definitions
	partial void OnLoaded();
	partial void OnValidate(System.Data.Linq.ChangeAction action);
	partial void OnCreated();
	partial void OnIdChanging(int value);
	partial void OnIdChanged();
	partial void OnNameChanging(string value);
	partial void OnNameChanged();
	partial void OnCreatorIdChanging(int value);
	partial void OnCreatorIdChanged();
	#endregion
		
		public Room()
		{
			this._Messages = new EntitySet<Message>(new Action<Message>(this.attach_Messages), new Action<Message>(this.detach_Messages));
			this._Users = new EntitySet<User>(new Action<User>(this.attach_Users), new Action<User>(this.detach_Users));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreatorId", DbType="Int NOT NULL")]
		public int CreatorId
		{
			get
			{
				return this._CreatorId;
			}
			set
			{
				if ((this._CreatorId != value))
				{
					this.OnCreatorIdChanging(value);
					this.SendPropertyChanging();
					this._CreatorId = value;
					this.SendPropertyChanged("CreatorId");
					this.OnCreatorIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Room_Message", Storage="_Messages", ThisKey="Id", OtherKey="RoomId")]
		public EntitySet<Message> Messages
		{
			get
			{
				return this._Messages;
			}
			set
			{
				this._Messages.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Room_User", Storage="_Users", ThisKey="Id", OtherKey="RoomId")]
		public EntitySet<User> Users
		{
			get
			{
				return this._Users;
			}
			set
			{
				this._Users.Assign(value);
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
		
		private void attach_Messages(Message entity)
		{
			this.SendPropertyChanging();
			entity.Room = this;
		}
		
		private void detach_Messages(Message entity)
		{
			this.SendPropertyChanging();
			entity.Room = null;
		}
		
		private void attach_Users(User entity)
		{
			this.SendPropertyChanging();
			entity.Room = this;
		}
		
		private void detach_Users(User entity)
		{
			this.SendPropertyChanging();
			entity.Room = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Messages")]
	public partial class Message : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _UserId;
		
		private System.DateTime _Date;
		
		private string _Text;
		
		private int _RoomId;
		
		private EntityRef<Room> _Room;
		
		private EntityRef<User> _User;
		
	#region Extensibility Method Definitions
	partial void OnLoaded();
	partial void OnValidate(System.Data.Linq.ChangeAction action);
	partial void OnCreated();
	partial void OnIdChanging(int value);
	partial void OnIdChanged();
	partial void OnUserIdChanging(int value);
	partial void OnUserIdChanged();
	partial void OnDateChanging(System.DateTime value);
	partial void OnDateChanged();
	partial void OnTextChanging(string value);
	partial void OnTextChanged();
	partial void OnRoomIdChanging(int value);
	partial void OnRoomIdChanged();
	#endregion
		
		public Message()
		{
			this._Room = default(EntityRef<Room>);
			this._User = default(EntityRef<User>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", DbType="Int NOT NULL")]
		public int UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="DateTime NOT NULL")]
		public System.DateTime Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this.OnDateChanging(value);
					this.SendPropertyChanging();
					this._Date = value;
					this.SendPropertyChanged("Date");
					this.OnDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Text", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string Text
		{
			get
			{
				return this._Text;
			}
			set
			{
				if ((this._Text != value))
				{
					this.OnTextChanging(value);
					this.SendPropertyChanging();
					this._Text = value;
					this.SendPropertyChanged("Text");
					this.OnTextChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RoomId", DbType="Int NOT NULL")]
		public int RoomId
		{
			get
			{
				return this._RoomId;
			}
			set
			{
				if ((this._RoomId != value))
				{
					if (this._Room.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnRoomIdChanging(value);
					this.SendPropertyChanging();
					this._RoomId = value;
					this.SendPropertyChanged("RoomId");
					this.OnRoomIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Room_Message", Storage="_Room", ThisKey="RoomId", OtherKey="Id", IsForeignKey=true)]
		public Room Room
		{
			get
			{
				return this._Room.Entity;
			}
			set
			{
				Room previousValue = this._Room.Entity;
				if (((previousValue != value) 
							|| (this._Room.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Room.Entity = null;
						previousValue.Messages.Remove(this);
					}
					this._Room.Entity = value;
					if ((value != null))
					{
						value.Messages.Add(this);
						this._RoomId = value.Id;
					}
					else
					{
						this._RoomId = default(int);
					}
					this.SendPropertyChanged("Room");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Message", Storage="_User", ThisKey="UserId", OtherKey="Id", IsForeignKey=true)]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.Messages.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.Messages.Add(this);
						this._UserId = value.Id;
					}
					else
					{
						this._UserId = default(int);
					}
					this.SendPropertyChanged("User");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Users")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private string _Password;
		
		private System.Nullable<System.DateTime> _TimeLogIn;
		
		private System.Nullable<int> _RoomId;
		
		private EntitySet<User_Role> _User_Roles;
		
		private EntitySet<Message> _Messages;
		
		private EntityRef<Room> _Room;
		
	#region Extensibility Method Definitions
	partial void OnLoaded();
	partial void OnValidate(System.Data.Linq.ChangeAction action);
	partial void OnCreated();
	partial void OnIdChanging(int value);
	partial void OnIdChanged();
	partial void OnNameChanging(string value);
	partial void OnNameChanged();
	partial void OnPasswordChanging(string value);
	partial void OnPasswordChanged();
	partial void OnTimeLogInChanging(System.Nullable<System.DateTime> value);
	partial void OnTimeLogInChanged();
	partial void OnRoomIdChanging(System.Nullable<int> value);
	partial void OnRoomIdChanged();
	#endregion
		
		public User()
		{
			this._User_Roles = new EntitySet<User_Role>(new Action<User_Role>(this.attach_User_Roles), new Action<User_Role>(this.detach_User_Roles));
			this._Messages = new EntitySet<Message>(new Action<Message>(this.attach_Messages), new Action<Message>(this.detach_Messages));
			this._Room = default(EntityRef<Room>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TimeLogIn", DbType="DateTime")]
		public System.Nullable<System.DateTime> TimeLogIn
		{
			get
			{
				return this._TimeLogIn;
			}
			set
			{
				if ((this._TimeLogIn != value))
				{
					this.OnTimeLogInChanging(value);
					this.SendPropertyChanging();
					this._TimeLogIn = value;
					this.SendPropertyChanged("TimeLogIn");
					this.OnTimeLogInChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RoomId", DbType="Int")]
		public System.Nullable<int> RoomId
		{
			get
			{
				return this._RoomId;
			}
			set
			{
				if ((this._RoomId != value))
				{
					if (this._Room.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnRoomIdChanging(value);
					this.SendPropertyChanging();
					this._RoomId = value;
					this.SendPropertyChanged("RoomId");
					this.OnRoomIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_User_Role", Storage="_User_Roles", ThisKey="Id", OtherKey="UserId")]
		public EntitySet<User_Role> User_Roles
		{
			get
			{
				return this._User_Roles;
			}
			set
			{
				this._User_Roles.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Message", Storage="_Messages", ThisKey="Id", OtherKey="UserId")]
		public EntitySet<Message> Messages
		{
			get
			{
				return this._Messages;
			}
			set
			{
				this._Messages.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Room_User", Storage="_Room", ThisKey="RoomId", OtherKey="Id", IsForeignKey=true)]
		public Room Room
		{
			get
			{
				return this._Room.Entity;
			}
			set
			{
				Room previousValue = this._Room.Entity;
				if (((previousValue != value) 
							|| (this._Room.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Room.Entity = null;
						previousValue.Users.Remove(this);
					}
					this._Room.Entity = value;
					if ((value != null))
					{
						value.Users.Add(this);
						this._RoomId = value.Id;
					}
					else
					{
						this._RoomId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Room");
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
		
		private void attach_User_Roles(User_Role entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_User_Roles(User_Role entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
		
		private void attach_Messages(Message entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_Messages(Message entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
	}
}
#pragma warning restore 1591