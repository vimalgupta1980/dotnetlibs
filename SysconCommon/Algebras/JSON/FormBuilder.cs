using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Xml;

using SysconCommon.Common;
using SysconCommon.Common.Environment;
using SysconCommon.Algebras.DataTables;
using SysconCommon.Common.Validity;

namespace SysconCommon.Algebras.JSON
{
    public static class FormBuilder
    {
        public enum InputType
        {
            Choice,
            MultiChoice,
            Date,
            Hidden,
        }

        private static InputType GetInputType(XmlNode n)
        {
            try
            {
                var type = n.Attributes["type"];
                switch (type.Value.Trim().ToLower())
                {
                    case "choice": return InputType.Choice;
                    case "multichoice": return InputType.MultiChoice;
                    case "date": return InputType.Date;
                    case "hidden": return InputType.Hidden;
                    default:
                        throw new NotImplementedException("Unknown type of input: " + type.Value.Trim());
                }
            }
            catch
            {
                // default
                return InputType.Choice;
            }
        }

#if false
        private static DataTable GetChoices(XmlNode n)
        {
            try
            {
                var sql = n.Attributes["sql"].Value;
                var dt = Connections.Connection.RunSqlStatementFromCursors("Choices", sql);
                return dt;
            }
            catch
            {
                try
                {
                    var choices = n.Attributes["choices"].Value;
                    var dt = new DataTable("Choices");
                    dt.Columns.Add("value");
                    foreach (var c in choices.Split(','))
                    {
                        var r = dt.NewRow();
                        r["value"] = c.Trim();
                        dt.Rows.Add(r);
                    }

                    return dt;
                }
                catch
                {
                    throw;
                }
            }
        }

        public static string GetForm(params string[] inputNames)
        {
            IEnumerable<XmlNode> inputs;
            var udef = Env.GetConfigXmlNode("userdefined");

            if (inputNames.IsEmpty())
            {


                inputs = from child in udef.ChildNodes.ToIEnumerable()
                         where child.NodeType == System.Xml.XmlNodeType.Element
                         select child;
            }
            else
            {
                inputs = from child in udef.ChildNodes.ToIEnumerable()
                         where child.NodeType == XmlNodeType.Element
                         where inputNames.Contains(child.Name)
                         select child;
            }

            var results = inputs.Select<XmlNode, object>(node =>
            {
                string caption = null;
                try
                {
                    caption = node.Attributes["caption"].Value;
                    Validity.Assert(caption != null, "gets caught and uses a sane value");
                }
                catch
                {
                    caption = node.Name;
                }

                DataTable choices;
                try
                {
                    choices = GetChoices(node);
                }
                catch
                {
                    choices = null;
                }

                return new
                {
                    inputName = node.Name,
                    caption = caption,
                    inputType = GetInputType(node),
                    defaultValue = node.InnerText.Trim(),
                    choices,
                };
            });

            return results.ToArray().ToJSON();
        }
#endif
    }
}
