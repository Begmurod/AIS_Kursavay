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
namespace Kursach.DB.DBKursach
{

    [Persistent(@"device.TypeWorkTeam")]
    public partial class device_TypeWorkTeam : XPLiteObject
    {
        Guid fGUID;
        [Key(true)]
        public Guid GUID
        {
            get { return fGUID; }
            set { SetPropertyValue<Guid>(nameof(GUID), ref fGUID, value); }
        }
        string fNameType;
        [Size(128)]
        public string NameType
        {
            get { return fNameType; }
            set { SetPropertyValue<string>(nameof(NameType), ref fNameType, value); }
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
        [Association(@"device_WorkTeamReferencesdevice_TypeWorkTeam")]
        public XPCollection<device_WorkTeam> device_WorkTeams { get { return GetCollection<device_WorkTeam>(nameof(device_WorkTeams)); } }
    }

}
