using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace RoomReservationContracts
{
    public class RoomReservation : INotifyPropertyChanged
    {
        private int id;

        public int Id
        {
            get { return id;  }
            set { SetProperty(ref id, value); }
        }

        protected virtual void SetProperty<T>(ref T item, T value, [CallerMemberName] string propertyName = null)
        {
            if(!EqualityComparer<T>.Default.Equals(item, value))
            {
                item = value;
                OnNotifyPropertyChanged(propertyName);
            }
        }

        protected virtual void OnNotifyPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler eventHandler = PropertyChanged;

        }

    }
}
