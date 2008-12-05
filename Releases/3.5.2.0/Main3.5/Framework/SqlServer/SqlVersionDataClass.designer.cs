﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MSBuild.ExtensionPack.SqlServer
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
    
    
    [System.Data.Linq.Mapping.DatabaseAttribute(Name="UserData")]
    public partial class SqlVersionDataClass : System.Data.Linq.DataContext
    {
        
        private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
        
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertBuildNumber(BuildNumber instance);
    partial void UpdateBuildNumber(BuildNumber instance);
    partial void DeleteBuildNumber(BuildNumber instance);
    #endregion
        
        public SqlVersionDataClass() : 
                base(global::MSBuild.ExtensionPack.Properties.Settings.Default.UserDataConnectionString, mappingSource)
        {
            OnCreated();
        }
        
        public SqlVersionDataClass(string connection) : 
                base(connection, mappingSource)
        {
            OnCreated();
        }
        
        public SqlVersionDataClass(System.Data.IDbConnection connection) : 
                base(connection, mappingSource)
        {
            OnCreated();
        }
        
        public SqlVersionDataClass(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
                base(connection, mappingSource)
        {
            OnCreated();
        }
        
        public SqlVersionDataClass(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
                base(connection, mappingSource)
        {
            OnCreated();
        }
        
        public System.Data.Linq.Table<BuildNumber> BuildNumbers
        {
            get
            {
                return this.GetTable<BuildNumber>();
            }
        }
    }
    
    [Table(Name="dbo.BuildNumbers")]
    public partial class BuildNumber : INotifyPropertyChanging, INotifyPropertyChanged
    {
        
        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        
        private string _SequenceName;
        
        private int _Major;
        
        private int _Minor;
        
        private int _Build;
        
        private int _Increment;
        
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSequenceNameChanging(string value);
    partial void OnSequenceNameChanged();
    partial void OnMajorChanging(int value);
    partial void OnMajorChanged();
    partial void OnMinorChanging(int value);
    partial void OnMinorChanged();
    partial void OnBuildChanging(int value);
    partial void OnBuildChanged();
    partial void OnIncrementChanging(int value);
    partial void OnIncrementChanged();
    #endregion
        
        public BuildNumber()
        {
            OnCreated();
        }
        
        [Column(Storage="_SequenceName", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
        public string SequenceName
        {
            get
            {
                return this._SequenceName;
            }
            set
            {
                if ((this._SequenceName != value))
                {
                    this.OnSequenceNameChanging(value);
                    this.SendPropertyChanging();
                    this._SequenceName = value;
                    this.SendPropertyChanged("BuildName");
                    this.OnSequenceNameChanged();
                }
            }
        }
        
        [Column(Storage="_Major", DbType="Int")]
        public int Major
        {
            get
            {
                return this._Major;
            }
            set
            {
                if ((this._Major != value))
                {
                    this.OnMajorChanging(value);
                    this.SendPropertyChanging();
                    this._Major = value;
                    this.SendPropertyChanged("Major");
                    this.OnMajorChanged();
                }
            }
        }
        
        [Column(Storage="_Minor", DbType="Int")]
        public int Minor
        {
            get
            {
                return this._Minor;
            }
            set
            {
                if ((this._Minor != value))
                {
                    this.OnMinorChanging(value);
                    this.SendPropertyChanging();
                    this._Minor = value;
                    this.SendPropertyChanged("Minor");
                    this.OnMinorChanged();
                }
            }
        }
        
        [Column(Storage="_Build", DbType="Int")]
        public int Build
        {
            get
            {
                return this._Build;
            }
            set
            {
                if ((this._Build != value))
                {
                    this.OnBuildChanging(value);
                    this.SendPropertyChanging();
                    this._Build = value;
                    this.SendPropertyChanged("Build");
                    this.OnBuildChanged();
                }
            }
        }
        
        [Column(Storage="_Increment", DbType="Int")]
        public int Increment
        {
            get
            {
                return this._Increment;
            }
            set
            {
                if ((this._Increment != value))
                {
                    this.OnIncrementChanging(value);
                    this.SendPropertyChanging();
                    this._Increment = value;
                    this.SendPropertyChanged("Increment");
                    this.OnIncrementChanged();
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
