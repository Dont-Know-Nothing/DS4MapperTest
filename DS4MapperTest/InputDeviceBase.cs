﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS4MapperTest
{
    public abstract class InputDeviceBase
    {
        protected InputDeviceType deviceType;
        public InputDeviceType DeviceType
        {
            get => deviceType;
        }

        protected string devTypeStr;
        public string DevTypeStr
        {
            get => devTypeStr;
        }

        protected string serial;
        public string Serial
        {
            get => serial;
        }

        protected int index;
        public int Index
        {
            get => index; set => index = value;
        }

        protected double baseElapsedReference;
        public double BaseElapsedReference
        {
            get => baseElapsedReference;
        }

        public virtual event EventHandler Removal;

        protected bool synced;
        public bool Synced
        {
            get => synced;
            set
            {
                synced = value;
                SyncedChanged?.Invoke(this, EventArgs.Empty);
            }
        }
        public virtual event EventHandler SyncedChanged;

        public abstract void SetOperational();
        public abstract void Detach();
    }
}
