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

    [Persistent(@"device.Production")]
    public partial class device_Production : XPLiteObject
    {
        Guid fGUID;
        [Key(true)]
        public Guid GUID
        {
            get { return fGUID; }
            set { SetPropertyValue<Guid>(nameof(GUID), ref fGUID, value); }
        }
        device_Products fProductsGUID;
        [Association(@"device_ProductionReferencesdevice_Products")]
        public device_Products ProductsGUID
        {
            get { return fProductsGUID; }
            set { SetPropertyValue<device_Products>(nameof(ProductsGUID), ref fProductsGUID, value); }
        }
        device_Operations fOperationsGUID;
        [Association(@"device_ProductionReferencesdevice_Operations")]
        public device_Operations OperationsGUID
        {
            get { return fOperationsGUID; }
            set { SetPropertyValue<device_Operations>(nameof(OperationsGUID), ref fOperationsGUID, value); }
        }
        decimal fVolume;
        public decimal Volume
        {
            get { return fVolume; }
            set { SetPropertyValue<decimal>(nameof(Volume), ref fVolume, value); }
        }
        string fUnitOfMeasurement;
        [Size(128)]
        public string UnitOfMeasurement
        {
            get { return fUnitOfMeasurement; }
            set { SetPropertyValue<string>(nameof(UnitOfMeasurement), ref fUnitOfMeasurement, value); }
        }
        Guid fMaterialGUID;
        public Guid MaterialGUID
        {
            get { return fMaterialGUID; }
            set { SetPropertyValue<Guid>(nameof(MaterialGUID), ref fMaterialGUID, value); }
        }
        decimal fVolumeMaterial;
        public decimal VolumeMaterial
        {
            get { return fVolumeMaterial; }
            set { SetPropertyValue<decimal>(nameof(VolumeMaterial), ref fVolumeMaterial, value); }
        }
        string fUnitOfMeasurementMaterial;
        [Size(128)]
        public string UnitOfMeasurementMaterial
        {
            get { return fUnitOfMeasurementMaterial; }
            set { SetPropertyValue<string>(nameof(UnitOfMeasurementMaterial), ref fUnitOfMeasurementMaterial, value); }
        }
        DateTime fDateOfTheBeginning;
        public DateTime DateOfTheBeginning
        {
            get { return fDateOfTheBeginning; }
            set { SetPropertyValue<DateTime>(nameof(DateOfTheBeginning), ref fDateOfTheBeginning, value); }
        }
        DateTime fEndDate;
        public DateTime EndDate
        {
            get { return fEndDate; }
            set { SetPropertyValue<DateTime>(nameof(EndDate), ref fEndDate, value); }
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
    }

}
