//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.Serialization;

namespace DataEntities
{
    [DataContract(IsReference = true)]
    [KnownType(typeof(menu))]
    [KnownType(typeof(ventas))]
    public partial class usuario: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region Primitive Properties
    
        [DataMember]
        public System.Guid Id
        {
            get { return _id; }
            set
            {
                if (_id != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'Id' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _id = value;
                    OnPropertyChanged("Id");
                }
            }
        }
        private System.Guid _id;
    
        [DataMember]
        public string UserName
        {
            get { return _userName; }
            set
            {
                if (_userName != value)
                {
                    _userName = value;
                    OnPropertyChanged("UserName");
                }
            }
        }
        private string _userName;
    
        [DataMember]
        public string Contraseña
        {
            get { return _contraseña; }
            set
            {
                if (_contraseña != value)
                {
                    _contraseña = value;
                    OnPropertyChanged("Contraseña");
                }
            }
        }
        private string _contraseña;
    
        [DataMember]
        public string Nombre
        {
            get { return _nombre; }
            set
            {
                if (_nombre != value)
                {
                    _nombre = value;
                    OnPropertyChanged("Nombre");
                }
            }
        }
        private string _nombre;
    
        [DataMember]
        public string Email
        {
            get { return _email; }
            set
            {
                if (_email != value)
                {
                    _email = value;
                    OnPropertyChanged("Email");
                }
            }
        }
        private string _email;
    
        [DataMember]
        public Nullable<bool> Estado
        {
            get { return _estado; }
            set
            {
                if (_estado != value)
                {
                    _estado = value;
                    OnPropertyChanged("Estado");
                }
            }
        }
        private Nullable<bool> _estado;
    
        [DataMember]
        public Nullable<decimal> CupoDiario
        {
            get { return _cupoDiario; }
            set
            {
                if (_cupoDiario != value)
                {
                    _cupoDiario = value;
                    OnPropertyChanged("CupoDiario");
                }
            }
        }
        private Nullable<decimal> _cupoDiario;
    
        [DataMember]
        public Nullable<System.Guid> IdPerfil
        {
            get { return _idPerfil; }
            set
            {
                if (_idPerfil != value)
                {
                    _idPerfil = value;
                    OnPropertyChanged("IdPerfil");
                }
            }
        }
        private Nullable<System.Guid> _idPerfil;
    
        [DataMember]
        public Nullable<System.Guid> IdUltimaVenta
        {
            get { return _idUltimaVenta; }
            set
            {
                if (_idUltimaVenta != value)
                {
                    _idUltimaVenta = value;
                    OnPropertyChanged("IdUltimaVenta");
                }
            }
        }
        private Nullable<System.Guid> _idUltimaVenta;

        #endregion
        #region Navigation Properties
    
        [DataMember]
        public TrackableCollection<menu> menu
        {
            get
            {
                if (_menu == null)
                {
                    _menu = new TrackableCollection<menu>();
                    _menu.CollectionChanged += Fixupmenu;
                }
                return _menu;
            }
            set
            {
                if (!ReferenceEquals(_menu, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("Cannot set the FixupChangeTrackingCollection when ChangeTracking is enabled");
                    }
                    if (_menu != null)
                    {
                        _menu.CollectionChanged -= Fixupmenu;
                    }
                    _menu = value;
                    if (_menu != null)
                    {
                        _menu.CollectionChanged += Fixupmenu;
                    }
                    OnNavigationPropertyChanged("menu");
                }
            }
        }
        private TrackableCollection<menu> _menu;
    
        [DataMember]
        public TrackableCollection<ventas> ventas
        {
            get
            {
                if (_ventas == null)
                {
                    _ventas = new TrackableCollection<ventas>();
                    _ventas.CollectionChanged += Fixupventas;
                }
                return _ventas;
            }
            set
            {
                if (!ReferenceEquals(_ventas, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("Cannot set the FixupChangeTrackingCollection when ChangeTracking is enabled");
                    }
                    if (_ventas != null)
                    {
                        _ventas.CollectionChanged -= Fixupventas;
                    }
                    _ventas = value;
                    if (_ventas != null)
                    {
                        _ventas.CollectionChanged += Fixupventas;
                    }
                    OnNavigationPropertyChanged("ventas");
                }
            }
        }
        private TrackableCollection<ventas> _ventas;

        #endregion
        #region ChangeTracking
    
        protected virtual void OnPropertyChanged(String propertyName)
        {
            if (ChangeTracker.State != ObjectState.Added && ChangeTracker.State != ObjectState.Deleted)
            {
                ChangeTracker.State = ObjectState.Modified;
            }
            if (_propertyChanged != null)
            {
                _propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    
        protected virtual void OnNavigationPropertyChanged(String propertyName)
        {
            if (_propertyChanged != null)
            {
                _propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    
        event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged{ add { _propertyChanged += value; } remove { _propertyChanged -= value; } }
        private event PropertyChangedEventHandler _propertyChanged;
        private ObjectChangeTracker _changeTracker;
    
        [DataMember]
        public ObjectChangeTracker ChangeTracker
        {
            get
            {
                if (_changeTracker == null)
                {
                    _changeTracker = new ObjectChangeTracker();
                    _changeTracker.ObjectStateChanging += HandleObjectStateChanging;
                }
                return _changeTracker;
            }
            set
            {
                if(_changeTracker != null)
                {
                    _changeTracker.ObjectStateChanging -= HandleObjectStateChanging;
                }
                _changeTracker = value;
                if(_changeTracker != null)
                {
                    _changeTracker.ObjectStateChanging += HandleObjectStateChanging;
                }
            }
        }
    
        private void HandleObjectStateChanging(object sender, ObjectStateChangingEventArgs e)
        {
            if (e.NewState == ObjectState.Deleted)
            {
                ClearNavigationProperties();
            }
        }
    
        protected bool IsDeserializing { get; private set; }
    
        [OnDeserializing]
        public void OnDeserializingMethod(StreamingContext context)
        {
            IsDeserializing = true;
        }
    
        [OnDeserialized]
        public void OnDeserializedMethod(StreamingContext context)
        {
            IsDeserializing = false;
            ChangeTracker.ChangeTrackingEnabled = true;
        }
    
        protected virtual void ClearNavigationProperties()
        {
            menu.Clear();
            ventas.Clear();
        }

        #endregion
        #region Association Fixup
    
        private void Fixupmenu(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (menu item in e.NewItems)
                {
                    if (!item.usuario.Contains(this))
                    {
                        item.usuario.Add(this);
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("menu", item);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (menu item in e.OldItems)
                {
                    if (item.usuario.Contains(this))
                    {
                        item.usuario.Remove(this);
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("menu", item);
                    }
                }
            }
        }
    
        private void Fixupventas(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (ventas item in e.NewItems)
                {
                    item.usuario = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("ventas", item);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (ventas item in e.OldItems)
                {
                    if (ReferenceEquals(item.usuario, this))
                    {
                        item.usuario = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("ventas", item);
                    }
                }
            }
        }

        #endregion
    }
}