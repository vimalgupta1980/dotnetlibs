using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

using SysconCommon.Accounting;
using SysconCommon.Common.Environment;
using SysconCommon.Common;

namespace SysconCommon.Accounting.MasterBuilder
{
    public class LedgerAccount : ILedgerAccount, IXmlSerializable
    {
        public LedgerAccount()
        {
        }

        public LedgerAccount(int recnum)
        {
            _Recnum = recnum;
        }

        private int _Recnum;
        public int Recnum
        {
            get { return _Recnum; }
        }

        public string Name
        {
            get
            {
                return Cache.CacheResult(() => Connections.GetScalar<string>("select lngnme from lgract where recnum = {0}", this.Recnum));
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}", Recnum, Name);
        }

        public System.Xml.Schema.XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            //throw new NotImplementedException();
            this._Recnum = int.Parse(reader.ReadString());
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteString(Recnum.ToString());
        }
    }
}
