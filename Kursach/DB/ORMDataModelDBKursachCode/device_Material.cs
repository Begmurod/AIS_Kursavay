using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace Kursach.DB.DBKursach
{

    public partial class device_Material
    {
        public device_Material(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
