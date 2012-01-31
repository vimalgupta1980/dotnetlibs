using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using SysconCommon.Common;
using SysconCommon.Common.Environment;

namespace SysconCommon.GUI
{
    public class UserInputAttribute : SysconAttribute
    {
        protected readonly string ConfigVarName;
        protected readonly string DefaultValue;
        public readonly string Caption;
        public readonly int OrderIndex;

        public UserInputAttribute(string caption, string configVarName = null, string defaultValue = "", int orderIndex = -1)
        {
            DefaultValue = defaultValue;
            ConfigVarName = configVarName;
            Caption = caption;
            OrderIndex = orderIndex;
        }

        private string _value;

        public string Value
        {
            get
            {
                if (ConfigVarName == null)
                    return _value;

                return Env.GetConfigVar(ConfigVarName, DefaultValue, true);
            }
            set
            {
                if (ConfigVarName != null)
                {
                    _value = value;
                }
                else
                {
                    Env.SetConfigVar(ConfigVarName, value);
                }
            }
        }
    }

    public abstract class ClickableUserInputAtrribute : UserInputAttribute
    {
        public ClickableUserInputAtrribute(string caption, string configVarName = null, string defaultValue = "", int orderIndex = -1)
            : base(caption, configVarName: configVarName, defaultValue: defaultValue, orderIndex: orderIndex)
        {
        }

        public abstract string Click();
    }

    public class FolderUserInputAttribute : ClickableUserInputAtrribute
    {
        public FolderUserInputAttribute(string caption, string configName = null, int orderIndex = -1, string defaultDir = null)
            : base(caption, configVarName: configName, orderIndex: orderIndex, defaultValue: defaultDir)
        {
        }

        public override string Click()
        {
            var dlg = new FolderBrowserDialog();
            dlg.SelectedPath = DefaultValue;
            
            if (dlg.ShowDialog() == DialogResult.OK)
                Value = dlg.SelectedPath;

            return Value;
        }
    }

    public class SMBDataDirectoryAttribute : FolderUserInputAttribute
    {
        public SMBDataDirectoryAttribute(string configName = "mbdir", int orderIndex = -1, string caption = "SMB Data Directory")
            : base(caption, configName: configName, orderIndex: orderIndex, defaultDir: @"C:\MB7\Sample Company")
        {
        }

        public override string Click()
        {
            var oldDir = Value;
            var oldmbdir = Env.GetMBDir();
            var newDir = base.Click();

            if (newDir != oldDir)
            {
                Env.SetMBDir(newDir);
                var loginScreen = new SMBLogin();
                if (loginScreen.ShowDialog() != DialogResult.OK)
                {
                    Value = oldDir;
                }

                if(ConfigVarName != "mbdir")
                    Env.SetMBDir(oldmbdir);
            }

            return Value;
        }
    }

    public class InputFileUserInputAttribute : ClickableUserInputAtrribute
    {
        protected readonly string Filter;

        public InputFileUserInputAttribute(string caption, string filter = "Any File|*.*", string configName = null, int orderIndex = -1, string defaultFileName = null)
            : base(caption, configVarName: configName, defaultValue: defaultFileName, orderIndex: orderIndex)
        {
            Filter = filter;
        }

        public override string Click()
        {
            var dlg = new OpenFileDialog();
            dlg.Multiselect = false;

            if (DefaultValue != null)
                dlg.InitialDirectory = Path.GetDirectoryName(DefaultValue);

            dlg.Filter = Filter;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Value = dlg.FileName;
            }

            return Value;
        }
    }

    public class ExcelTemplateUserInputAttribute : InputFileUserInputAttribute
    {
        public ExcelTemplateUserInputAttribute(string defaultTemplateName, string caption = "Template", string configName = "template", int orderIndex = -1, string fileTypes = "*.xlsx;*.xlsm")
            : base(caption, filter: "Excel Files|" + fileTypes, configName: configName, orderIndex: orderIndex, defaultFileName: Directory.GetCurrentDirectory() + "/" + defaultTemplateName)
        {
        }
    }
}
