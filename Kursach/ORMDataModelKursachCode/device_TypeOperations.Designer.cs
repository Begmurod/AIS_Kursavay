﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace Kursach.DBKursach
{

    [Persistent(@"device.TypeOperations")]
    public partial class device_TypeOperations : XPLiteObject
    {
        Guid fGUID;
        [Key(true)]
        public Guid GUID
        {
            get { return fGUID; }
            set { SetPropertyValue<Guid>(nameof(GUID), ref fGUID, value); }
        }
        string fNameOperationsType;
        [Size(128)]
        public string NameOperationsType
        {
            get { return fNameOperationsType; }
            set { SetPropertyValue<string>(nameof(NameOperationsType), ref fNameOperationsType, value); }
        }
        DateTime fDateOfChange;
        public DateTime DateOfChange
        {
            get { return fDateOfChange; }
            set { SetPropertyValue<DateTime>(nameof(DateOfChange), ref fDateOfChange, value); }
        }
        DateTime fDeletedDate;
        public DateTime DeletedDate
        {
            get { return fDeletedDate; }
            set { SetPropertyValue<DateTime>(nameof(DeletedDate), ref fDeletedDate, value); }
        }
        [Association(@"device_OperationsReferencesdevice_TypeOperations")]
        public XPCollection<device_Operations> device_Operationss { get { return GetCollection<device_Operations>(nameof(device_Operationss)); } }
    }

}
