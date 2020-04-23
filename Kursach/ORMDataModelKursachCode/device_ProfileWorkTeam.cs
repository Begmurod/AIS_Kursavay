using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace Kursach.DBKursach
{

    public partial class device_ProfileWorkTeam
    {
        public device_ProfileWorkTeam(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
